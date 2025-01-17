Imports System.Drawing.Drawing2D
Imports System.IO

Public Class NewFaceForm
    Dim BackBuffer As New Bitmap(128, 128)
    Dim BackBuffer2 As New Bitmap(128, 128)
    Dim SelectedImage As Image
    Dim ImageInterpolationMode As Integer
    Dim ImageMatrix As New Matrix()
    Dim IsMouseDown As Boolean = False
    Dim MousePoint As Point

    Dim NewFaceProps As KbbEditor.KbbFaceInfo

    Dim MonthDaysLUT = {
        31, 28, 31, 30,
        31, 30, 31, 31,
        30, 31, 30, 31
    }

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim g As Graphics
        g = Graphics.FromImage(BackBuffer)
        g.InterpolationMode = ImageInterpolationMode
        g.Clear(Color.Black)
        g.Transform = ImageMatrix

        ' Draw image

        Dim ImgOffX As Single = 64 - SelectedImage.Width / 2
        Dim ImgOffY As Single = 64 - SelectedImage.Height / 2
        g.DrawImage(SelectedImage, New Point(ImgOffX, ImgOffY))

        ' Draw image with transforms

        Dim h As Graphics
        h = Graphics.FromImage(BackBuffer2)
        h.Clear(Color.Black)

        Dim cx As Double = 64
        Dim cy As Double = 64

        Dim Corners(2) As PointF
        Corners(0) = New PointF(CSng(cx - (64 / HorizontalStretchBox.Value)), CSng(cy - (64 / VerticalStretchBox.Value)))
        Corners(1) = New PointF(CSng(cx + (64 / HorizontalStretchBox.Value)), CSng(cy - (64 / VerticalStretchBox.Value)))
        Corners(2) = New PointF(CSng(cx - (64 / HorizontalStretchBox.Value)), CSng(cy + (64 / VerticalStretchBox.Value)))

        Dim X As Double
        For i = 0 To 2
            X = Corners(i).X
            Corners(i).X = CSng(Corners(i).X * Math.Cos(-RotationBox.Value) + Corners(i).Y * Math.Sin(-RotationBox.Value))
            Corners(i).Y = CSng((Corners(i).Y * Math.Cos(-RotationBox.Value)) - (X * Math.Sin(-RotationBox.Value)))
        Next i

        Dim newcx As Double = Corners(2).X + (Corners(1).X - Corners(2).X) / 2
        Dim newcy As Double = Corners(2).Y + (Corners(1).Y - Corners(2).Y) / 2

        For i = 0 To 2
            Corners(i).X = CSng(Corners(i).X + (cx - newcx - (HorizontalScrollBox.Value * 128)))
            Corners(i).Y = CSng(Corners(i).Y + (cy - newcy - (VerticalScrollBox.Value * 128)))
        Next i

        h.DrawImage(BackBuffer, Corners)

        ' End draw

        PictureBox1.BackgroundImage = BackBuffer2
        PictureBox1.Invalidate()
    End Sub

    Private Sub PictureBox1_MouseWheel(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseWheel
        If e.Delta > 0 Then
            ImageMatrix.Scale(1 + 0.05 * ZoomPwr.Value, 1 + 0.05 * ZoomPwr.Value)
        Else
            ImageMatrix.Scale(1 - 0.05 * ZoomPwr.Value, 1 - 0.05 * ZoomPwr.Value)
        End If
    End Sub

    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown
        IsMouseDown = True
        MousePoint = e.Location
    End Sub

    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove
        If IsMouseDown = True Then
            ImageMatrix.Translate((e.X - MousePoint.X) * TrPwr.Value, (e.Y - MousePoint.Y) * TrPwr.Value)
            MousePoint = e.Location
        End If
    End Sub

    Private Sub PictureBox1_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseUp
        IsMouseDown = False
    End Sub

    Private Sub SelectImageButton_Click(sender As Object, e As EventArgs) Handles SelectImageButton.Click
        If (OpenFileDialog1.ShowDialog() = DialogResult.OK) Then
            Dim Stream1 As Stream = New StreamReader(OpenFileDialog1.FileName).BaseStream
            SelectedImage = Image.FromStream(Stream1)
            Timer1.Enabled = True
            FinishButton.Enabled = True
            ImageMatrix.Reset()
            Stream1.Close()
        End If
    End Sub

    Private Sub DayBox_ValueChanged(sender As Object, e As EventArgs) Handles DayBox.ValueChanged
        NewFaceProps.DayMet = DayBox.Value
    End Sub

    Private Sub MonthBox_ValueChanged(sender As Object, e As EventArgs) Handles MonthBox.ValueChanged
        NewFaceProps.MonthMet = MonthBox.Value
        DayBox.Maximum = MonthDaysLUT(MonthBox.Value - 1)
        If MonthBox.Value = 2 Then
            If (YearBox.Value Mod 4 = 0) And ((YearBox.Value Mod 100 <> 0) Or (YearBox.Value Mod 400 = 0)) Then
                DayBox.Maximum = 29
            End If
        End If
    End Sub

    Private Sub YearBox_ValueChanged(sender As Object, e As EventArgs) Handles YearBox.ValueChanged
        NewFaceProps.YearMet = YearBox.Value
        If MonthBox.Value = 2 Then
            If (YearBox.Value Mod 4 = 0) And ((YearBox.Value Mod 100 <> 0) Or (YearBox.Value Mod 400 = 0)) Then
                DayBox.Maximum = 29
            Else
                DayBox.Maximum = 28
            End If
        End If
    End Sub

    Private Sub TimesChoosenBox_ValueChanged(sender As Object, e As EventArgs) Handles TimesChoosenBox.ValueChanged
        NewFaceProps.TimesChoosen = TimesChoosenBox.Value
    End Sub

    Private Sub AgeBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles AgeBox.SelectedIndexChanged
        If AgeBox.SelectedIndex = 5 Then
            NewFaceProps.Age = -1
        Else
            NewFaceProps.Age = AgeBox.SelectedIndex
        End If
    End Sub

    Private Sub GenderBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GenderBox.SelectedIndexChanged
        If GenderBox.SelectedIndex = 2 Then
            NewFaceProps.Gender = -1
        Else
            NewFaceProps.Gender = GenderBox.SelectedIndex
        End If
    End Sub

    Private Sub HorizontalScrollBox_ValueChanged(sender As Object, e As EventArgs) Handles HorizontalScrollBox.ValueChanged
        NewFaceProps.XMove = HorizontalScrollBox.Value
    End Sub

    Private Sub VerticalScrollBox_ValueChanged(sender As Object, e As EventArgs) Handles VerticalScrollBox.ValueChanged
        NewFaceProps.YMove = VerticalScrollBox.Value
    End Sub

    Private Sub HorizontalStretchBox_ValueChanged(sender As Object, e As EventArgs) Handles HorizontalStretchBox.ValueChanged
        NewFaceProps.XStretch = HorizontalStretchBox.Value
    End Sub

    Private Sub VerticalStretchBox_ValueChanged(sender As Object, e As EventArgs) Handles VerticalStretchBox.ValueChanged
        NewFaceProps.YStretch = VerticalStretchBox.Value
    End Sub

    Private Sub RotationBox_ValueChanged(sender As Object, e As EventArgs) Handles RotationBox.ValueChanged
        NewFaceProps.Rotation = RotationBox.Value
    End Sub

    Private Sub ResetImageTransformButton_Click(sender As Object, e As EventArgs) Handles ResetImageTransformButton.Click
        ImageMatrix.Reset()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            PictureBox1.Image = My.Resources.face_calibrate_guide
        Else
            PictureBox1.Image = Nothing
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ImageInterpolationMode = ComboBox1.SelectedIndex
    End Sub

    Private Sub FinishButton_Click(sender As Object, e As EventArgs) Handles FinishButton.Click
        Timer1.Enabled = False

        KbbEditor.NewFace(BackBuffer, NewFaceProps)

        FaceEditor.ReloadFaces()
        Close()
    End Sub

    Private Sub NewFaceForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        YearBox.Value = My.Computer.Clock.LocalTime.Year
        MonthBox.Value = My.Computer.Clock.LocalTime.Month
        DayBox.Maximum = MonthDaysLUT(MonthBox.Value - 1)
        If MonthBox.Value = 2 Then
            If YearBox.Value Mod 4 = 0 Then
                DayBox.Maximum = 29
            End If
        End If
        DayBox.Value = My.Computer.Clock.LocalTime.Day
        TimesChoosenBox.Value = 0
        AgeBox.SelectedIndex = 5
        GenderBox.SelectedIndex = 2
        HorizontalScrollBox.Value = 0
        VerticalScrollBox.Value = 0
        HorizontalStretchBox.Value = 1
        VerticalStretchBox.Value = 1
        RotationBox.Value = 0
        NewFaceProps.FaceID = KbbEditor.KbbSaveInfo.NextFaceID
        NewFaceProps.YearMet = YearBox.Value
        NewFaceProps.MonthMet = MonthBox.Value
        NewFaceProps.DayMet = DayBox.Value
        NewFaceProps.TimesChoosen = TimesChoosenBox.Value
        If AgeBox.SelectedIndex = 5 Then
            NewFaceProps.Age = -1
        Else
            NewFaceProps.Age = AgeBox.SelectedIndex
        End If
        If GenderBox.SelectedIndex = 2 Then
            NewFaceProps.Gender = -1
        Else
            NewFaceProps.Gender = GenderBox.SelectedIndex
        End If
        NewFaceProps.XMove = HorizontalScrollBox.Value
        NewFaceProps.YMove = VerticalScrollBox.Value
        NewFaceProps.XStretch = HorizontalStretchBox.Value
        NewFaceProps.YStretch = VerticalStretchBox.Value
        NewFaceProps.Rotation = RotationBox.Value
    End Sub
End Class