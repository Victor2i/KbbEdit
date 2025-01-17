Imports System.ComponentModel

Public Class FaceEditor
    Dim FacePage As Integer
    Dim SelectedFace As UInteger = &HFFFFFFFFUI
    Dim SelectedFaceProps As KbbEditor.KbbFaceInfo
    Dim FetchedFaceProps As KbbEditor.KbbFaceInfo ' To apply transform to face using their properties
    Dim FetchedFace As UInteger = &HFFFFFFFFUI
    Dim SwappedFaceImage As Bitmap
    Public FaceToEdit As New Bitmap(128, 128)

    Dim SwapMode As Boolean = False

    Dim MonthDaysLUT = {
        31, 28, 31, 30,
        31, 30, 31, 31,
        30, 31, 30, 31
    }

    Dim UFOThumb As New Bitmap(128, 128)
    Dim BackBufferS As New Bitmap(128, 128)
    Dim BackBuffer1 As New Bitmap(128, 128)
    Dim BackBuffer2 As New Bitmap(128, 128)
    Dim BackBuffer3 As New Bitmap(128, 128)
    Dim BackBuffer4 As New Bitmap(128, 128)
    Dim BackBuffer5 As New Bitmap(128, 128)
    Dim BackBuffer6 As New Bitmap(128, 128)
    Dim BackBuffer7 As New Bitmap(128, 128)
    Dim BackBuffer8 As New Bitmap(128, 128)
    Dim BackBuffer9 As New Bitmap(128, 128)
    Dim BackBuffer10 As New Bitmap(128, 128)

    Private Sub FaceEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FacePage = 0
        LeftPageButton.Enabled = False
        If KbbEditor.UFOFacesOrder(0) = &HFFFFFFFFUI Then
            FaceBox1.BackgroundImage = Nothing
        Else
            Dim g As Graphics
            g = Graphics.FromImage(UFOThumb)
            g.Clear(Color.Black)

            g.ScaleTransform(0.59375, 0.59375)
            g.DrawImage(KbbEditor.UFOFaceImages(0), 38, 69)

            g.ResetTransform()
            g.DrawImage(My.Resources.FaceUFO, 0, 0)

            FaceBox1.Image = Nothing
            FaceBox1.BackgroundImage = UFOThumb
            FaceBox1.Invalidate()
        End If
        FaceBox2.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.FacesOrder(0))
        If KbbEditor.FacesOrder(0) = &HFFFFFFFFUI Then
            FaceBox2.Enabled = False
        End If
        FaceBox3.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.FacesOrder(1))
        If KbbEditor.FacesOrder(1) = &HFFFFFFFFUI Then
            FaceBox3.Enabled = False
        End If
        FaceBox4.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.FacesOrder(2))
        If KbbEditor.FacesOrder(2) = &HFFFFFFFFUI Then
            FaceBox4.Enabled = False
        End If
        FaceBox5.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.FacesOrder(3))
        If KbbEditor.FacesOrder(3) = &HFFFFFFFFUI Then
            FaceBox5.Enabled = False
        End If
        FaceBox6.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.FacesOrder(4))
        If KbbEditor.FacesOrder(4) = &HFFFFFFFFUI Then
            FaceBox6.Enabled = False
        End If
        FaceBox7.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.FacesOrder(5))
        If KbbEditor.FacesOrder(5) = &HFFFFFFFFUI Then
            FaceBox7.Enabled = False
        End If
        FaceBox8.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.FacesOrder(6))
        If KbbEditor.FacesOrder(6) = &HFFFFFFFFUI Then
            FaceBox8.Enabled = False
        End If
        FaceBox9.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.FacesOrder(7))
        If KbbEditor.FacesOrder(7) = &HFFFFFFFFUI Then
            FaceBox9.Enabled = False
        End If
        FaceBox10.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.FacesOrder(8))
        If KbbEditor.FacesOrder(8) = &HFFFFFFFFUI Then
            FaceBox10.Enabled = False
        End If
        If KbbEditor.FacesOrder(9) = &HFFFFFFFFUI Then
            RightPageButton.Enabled = False
        Else
            RightPageButton.Enabled = True
        End If
        UpdateImageBuffer()
    End Sub

    Sub LoadSelectedFaceProps()
        ' SelectedFaceBox.BackgroundImage = KbbEditor.GetFaceImage(SelectedFace) ' useless now

        SelectedFaceProps = KbbEditor.GetFaceProps(SelectedFace)
        YearBox.Value = SelectedFaceProps.YearMet
        MonthBox.Value = SelectedFaceProps.MonthMet
        DayBox.Maximum = MonthDaysLUT(MonthBox.Value - 1)
        If MonthBox.Value = 2 Then
            If (YearBox.Value Mod 4 = 0) And ((YearBox.Value Mod 100 <> 0) Or (YearBox.Value Mod 400 = 0)) Then
                DayBox.Maximum = 29
            End If
        End If
        DayBox.Value = SelectedFaceProps.DayMet
        TimesChoosenBox.Value = SelectedFaceProps.TimesChoosen
        If SelectedFaceProps.Age <> -1 Then
            AgeBox.Text = AgeBox.Items(SelectedFaceProps.Age)
        Else
            AgeBox.Text = AgeBox.Items(5)
        End If
        If SelectedFaceProps.Gender <> -1 Then
            GenderBox.Text = GenderBox.Items(SelectedFaceProps.Gender)
        Else
            GenderBox.Text = GenderBox.Items(2)
        End If
        HorizontalScrollBox.Value = SelectedFaceProps.XMove
        VerticalScrollBox.Value = SelectedFaceProps.YMove
        HorizontalStretchBox.Value = SelectedFaceProps.XStretch
        VerticalStretchBox.Value = SelectedFaceProps.YStretch
        RotationBox.Value = SelectedFaceProps.Rotation

        UpdateImageBuffer()
    End Sub

    Private Sub LeftPageButton_Click(sender As Object, e As EventArgs) Handles LeftPageButton.Click
        FacePage -= 1
        If FacePage = 3 Then
            RightPageButton.Enabled = True
        End If
        If FacePage = 0 Then
            LeftPageButton.Enabled = False
            FaceBox1.Image = Nothing
            If KbbEditor.UFOFacesOrder(0) <> &HFFFFFFFFUI Then
                FaceBox1.BackgroundImage = UFOThumb
            End If
            FaceBox1.Enabled = True
        Else
            FaceBox1.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.FacesOrder(-1 + 10 * FacePage)) ' -1... Kinda feels weird to see this in an index.
        End If
        FaceBox2.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.FacesOrder(0 + 10 * FacePage))
        FaceBox2.Enabled = True
        If KbbEditor.FacesOrder(0 + 10 * FacePage) = &HFFFFFFFFUI Then
            FaceBox2.Enabled = False
        End If
        FaceBox3.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.FacesOrder(1 + 10 * FacePage))
        FaceBox3.Enabled = True
        If KbbEditor.FacesOrder(1 + 10 * FacePage) = &HFFFFFFFFUI Then
            FaceBox3.Enabled = False
        End If
        FaceBox4.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.FacesOrder(2 + 10 * FacePage))
        FaceBox4.Enabled = True
        If KbbEditor.FacesOrder(2 + 10 * FacePage) = &HFFFFFFFFUI Then
            FaceBox4.Enabled = False
        End If
        FaceBox5.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.FacesOrder(3 + 10 * FacePage))
        FaceBox5.Enabled = True
        If KbbEditor.FacesOrder(3 + 10 * FacePage) = &HFFFFFFFFUI Then
            FaceBox5.Enabled = False
        End If
        FaceBox6.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.FacesOrder(4 + 10 * FacePage))
        FaceBox6.Enabled = True
        If KbbEditor.FacesOrder(4 + 10 * FacePage) = &HFFFFFFFFUI Then
            FaceBox6.Enabled = False
        End If
        FaceBox7.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.FacesOrder(5 + 10 * FacePage))
        FaceBox7.Enabled = True
        If KbbEditor.FacesOrder(5 + 10 * FacePage) = &HFFFFFFFFUI Then
            FaceBox7.Enabled = False
        End If
        FaceBox8.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.FacesOrder(6 + 10 * FacePage))
        FaceBox8.Enabled = True
        If KbbEditor.FacesOrder(6 + 10 * FacePage) = &HFFFFFFFFUI Then
            FaceBox8.Enabled = False
        End If
        FaceBox9.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.FacesOrder(7 + 10 * FacePage))
        FaceBox9.Enabled = True
        If KbbEditor.FacesOrder(7 + 10 * FacePage) = &HFFFFFFFFUI Then
            FaceBox9.Enabled = False
        End If
        FaceBox10.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.FacesOrder(8 + 10 * FacePage))
        FaceBox10.Enabled = True
        If KbbEditor.FacesOrder(8 + 10 * FacePage) = &HFFFFFFFFUI Then
            FaceBox10.Enabled = False
        End If
        If KbbEditor.FacesOrder(9 + 10 * FacePage) = &HFFFFFFFFUI Then
            RightPageButton.Enabled = False
        Else
            RightPageButton.Enabled = True
        End If
        UpdateImageBuffer()
    End Sub

    Private Sub RightPageButton_Click(sender As Object, e As EventArgs) Handles RightPageButton.Click
        FacePage += 1
        If FacePage = 1 Then
            LeftPageButton.Enabled = True
            FaceBox1.Image = My.Resources.FaceHole
            FaceBox1.Enabled = True
        End If
        If FacePage = 4 Then
            RightPageButton.Enabled = False
        Else
            If KbbEditor.FacesOrder(9 + 10 * FacePage) = &HFFFFFFFFUI Then
                RightPageButton.Enabled = False
            End If
        End If
        FaceBox1.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.FacesOrder(-1 + 10 * FacePage))
        FaceBox2.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.FacesOrder(0 + 10 * FacePage))
        If KbbEditor.FacesOrder(0 + 10 * FacePage) = &HFFFFFFFFUI Then
            FaceBox2.Enabled = False
        End If
        FaceBox3.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.FacesOrder(1 + 10 * FacePage))
        If KbbEditor.FacesOrder(1 + 10 * FacePage) = &HFFFFFFFFUI Then
            FaceBox3.Enabled = False
        End If
        FaceBox4.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.FacesOrder(2 + 10 * FacePage))
        If KbbEditor.FacesOrder(2 + 10 * FacePage) = &HFFFFFFFFUI Then
            FaceBox4.Enabled = False
        End If
        FaceBox5.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.FacesOrder(3 + 10 * FacePage))
        If KbbEditor.FacesOrder(3 + 10 * FacePage) = &HFFFFFFFFUI Then
            FaceBox5.Enabled = False
        End If
        FaceBox6.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.FacesOrder(4 + 10 * FacePage))
        If KbbEditor.FacesOrder(4 + 10 * FacePage) = &HFFFFFFFFUI Then
            FaceBox6.Enabled = False
        End If
        FaceBox7.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.FacesOrder(5 + 10 * FacePage))
        If KbbEditor.FacesOrder(5 + 10 * FacePage) = &HFFFFFFFFUI Then
            FaceBox7.Enabled = False
        End If
        FaceBox8.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.FacesOrder(6 + 10 * FacePage))
        If KbbEditor.FacesOrder(6 + 10 * FacePage) = &HFFFFFFFFUI Then
            FaceBox8.Enabled = False
        End If
        FaceBox9.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.FacesOrder(7 + 10 * FacePage))
        If KbbEditor.FacesOrder(7 + 10 * FacePage) = &HFFFFFFFFUI Then
            FaceBox9.Enabled = False
        End If
        FaceBox10.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.FacesOrder(8 + 10 * FacePage))
        If KbbEditor.FacesOrder(8 + 10 * FacePage) = &HFFFFFFFFUI Then
            FaceBox10.Enabled = False
        End If
        If FacePage < 4 Then
            If KbbEditor.FacesOrder(9 + 10 * FacePage) = &HFFFFFFFFUI Then
                RightPageButton.Enabled = False
            Else
                RightPageButton.Enabled = True
            End If
        Else
            RightPageButton.Enabled = False
        End If
        UpdateImageBuffer()
    End Sub

    Private Sub FaceBox1_Click(sender As Object, e As EventArgs) Handles FaceBox1.Click
        If SwapMode = False Then
            If FacePage > 0 Then
                ImportFaceButton.Enabled = True
                ExportFaceButton.Enabled = True
                SwapFacesButton.Enabled = True
                DeleteFaceButton.Enabled = True
                KbbEditor.SetFaceProps(SelectedFace, SelectedFaceProps)
                SelectedFace = KbbEditor.FacesOrder(-1 + 10 * FacePage)
                LoadSelectedFaceProps()
            Else
                If KbbEditor.UFOFacesOrder(0) <> &HFFFFFFFFUI Then
                    UFOEditor.Show()
                End If
            End If
        Else
            If FacePage > 0 Then
                SwapFaces(SelectedFace, KbbEditor.FacesOrder(-1 + 10 * FacePage))
            End If
        End If
        UpdateImageBuffer()
    End Sub

    Private Sub FaceBox2_Click(sender As Object, e As EventArgs) Handles FaceBox2.Click
        If SwapMode = False Then
            ImportFaceButton.Enabled = True
            ExportFaceButton.Enabled = True
            SwapFacesButton.Enabled = True
            DeleteFaceButton.Enabled = True
            KbbEditor.SetFaceProps(SelectedFace, SelectedFaceProps)
            SelectedFace = KbbEditor.FacesOrder(0 + 10 * FacePage)
            LoadSelectedFaceProps()
        Else
            SwapFaces(SelectedFace, KbbEditor.FacesOrder(0 + 10 * FacePage))
        End If
        UpdateImageBuffer()
    End Sub

    Private Sub FaceBox3_Click(sender As Object, e As EventArgs) Handles FaceBox3.Click
        If SwapMode = False Then
            ImportFaceButton.Enabled = True
            ExportFaceButton.Enabled = True
            SwapFacesButton.Enabled = True
            DeleteFaceButton.Enabled = True
            KbbEditor.SetFaceProps(SelectedFace, SelectedFaceProps)
            SelectedFace = KbbEditor.FacesOrder(1 + 10 * FacePage)
            LoadSelectedFaceProps()
        Else
            SwapFaces(SelectedFace, KbbEditor.FacesOrder(1 + 10 * FacePage))
        End If
        UpdateImageBuffer()
    End Sub

    Private Sub FaceBox4_Click(sender As Object, e As EventArgs) Handles FaceBox4.Click
        If SwapMode = False Then
            ImportFaceButton.Enabled = True
            ExportFaceButton.Enabled = True
            SwapFacesButton.Enabled = True
            DeleteFaceButton.Enabled = True
            KbbEditor.SetFaceProps(SelectedFace, SelectedFaceProps)
            SelectedFace = KbbEditor.FacesOrder(2 + 10 * FacePage)
            LoadSelectedFaceProps()
        Else
            SwapFaces(SelectedFace, KbbEditor.FacesOrder(2 + 10 * FacePage))
        End If
        UpdateImageBuffer()
    End Sub

    Private Sub FaceBox5_Click(sender As Object, e As EventArgs) Handles FaceBox5.Click
        If SwapMode = False Then
            ImportFaceButton.Enabled = True
            ExportFaceButton.Enabled = True
            SwapFacesButton.Enabled = True
            DeleteFaceButton.Enabled = True
            KbbEditor.SetFaceProps(SelectedFace, SelectedFaceProps)
            SelectedFace = KbbEditor.FacesOrder(3 + 10 * FacePage)
            LoadSelectedFaceProps()
        Else
            SwapFaces(SelectedFace, KbbEditor.FacesOrder(3 + 10 * FacePage))
        End If
        UpdateImageBuffer()
    End Sub

    Private Sub FaceBox6_Click(sender As Object, e As EventArgs) Handles FaceBox6.Click
        If SwapMode = False Then
            ImportFaceButton.Enabled = True
            ExportFaceButton.Enabled = True
            SwapFacesButton.Enabled = True
            DeleteFaceButton.Enabled = True
            KbbEditor.SetFaceProps(SelectedFace, SelectedFaceProps)
            SelectedFace = KbbEditor.FacesOrder(4 + 10 * FacePage)
            LoadSelectedFaceProps()
        Else
            SwapFaces(SelectedFace, KbbEditor.FacesOrder(4 + 10 * FacePage))
        End If
        UpdateImageBuffer()
    End Sub

    Private Sub FaceBox7_Click(sender As Object, e As EventArgs) Handles FaceBox7.Click
        If SwapMode = False Then
            ImportFaceButton.Enabled = True
            ExportFaceButton.Enabled = True
            SwapFacesButton.Enabled = True
            DeleteFaceButton.Enabled = True
            KbbEditor.SetFaceProps(SelectedFace, SelectedFaceProps)
            SelectedFace = KbbEditor.FacesOrder(5 + 10 * FacePage)
            LoadSelectedFaceProps()
        Else
            SwapFaces(SelectedFace, KbbEditor.FacesOrder(5 + 10 * FacePage))
        End If
        UpdateImageBuffer()
    End Sub

    Private Sub FaceBox8_Click(sender As Object, e As EventArgs) Handles FaceBox8.Click
        If SwapMode = False Then
            ImportFaceButton.Enabled = True
            ExportFaceButton.Enabled = True
            SwapFacesButton.Enabled = True
            DeleteFaceButton.Enabled = True
            KbbEditor.SetFaceProps(SelectedFace, SelectedFaceProps)
            SelectedFace = KbbEditor.FacesOrder(6 + 10 * FacePage)
            LoadSelectedFaceProps()
        Else
            SwapFaces(SelectedFace, KbbEditor.FacesOrder(6 + 10 * FacePage))
        End If
        UpdateImageBuffer()
    End Sub

    Private Sub FaceBox9_Click(sender As Object, e As EventArgs) Handles FaceBox9.Click
        If SwapMode = False Then
            ImportFaceButton.Enabled = True
            ExportFaceButton.Enabled = True
            SwapFacesButton.Enabled = True
            DeleteFaceButton.Enabled = True
            KbbEditor.SetFaceProps(SelectedFace, SelectedFaceProps)
            SelectedFace = KbbEditor.FacesOrder(7 + 10 * FacePage)
            LoadSelectedFaceProps()
        Else
            SwapFaces(SelectedFace, KbbEditor.FacesOrder(7 + 10 * FacePage))
        End If
        UpdateImageBuffer()
    End Sub

    Private Sub FaceBox10_Click(sender As Object, e As EventArgs) Handles FaceBox10.Click
        If SwapMode = False Then
            ImportFaceButton.Enabled = True
            ExportFaceButton.Enabled = True
            SwapFacesButton.Enabled = True
            DeleteFaceButton.Enabled = True
            KbbEditor.SetFaceProps(SelectedFace, SelectedFaceProps)
            SelectedFace = KbbEditor.FacesOrder(8 + 10 * FacePage)
            LoadSelectedFaceProps()
        Else
            SwapFaces(SelectedFace, KbbEditor.FacesOrder(8 + 10 * FacePage))
        End If
        UpdateImageBuffer()
    End Sub

    Private Sub DayBox_ValueChanged(sender As Object, e As EventArgs) Handles DayBox.ValueChanged
        SelectedFaceProps.DayMet = DayBox.Value
    End Sub

    Private Sub MonthBox_ValueChanged(sender As Object, e As EventArgs) Handles MonthBox.ValueChanged
        SelectedFaceProps.MonthMet = MonthBox.Value
        DayBox.Maximum = MonthDaysLUT(MonthBox.Value - 1)
        If MonthBox.Value = 2 Then
            If (YearBox.Value Mod 4 = 0) And ((YearBox.Value Mod 100 <> 0) Or (YearBox.Value Mod 400 = 0)) Then
                DayBox.Maximum = 29
            End If
        End If
    End Sub

    Private Sub YearBox_ValueChanged(sender As Object, e As EventArgs) Handles YearBox.ValueChanged
        SelectedFaceProps.YearMet = YearBox.Value
        If MonthBox.Value = 2 Then
            If (YearBox.Value Mod 4 = 0) And ((YearBox.Value Mod 100 <> 0) Or (YearBox.Value Mod 400 = 0)) Then
                DayBox.Maximum = 29
            Else
                DayBox.Maximum = 28
            End If
        End If
    End Sub

    Private Sub TimesChoosenBox_ValueChanged(sender As Object, e As EventArgs) Handles TimesChoosenBox.ValueChanged
        SelectedFaceProps.TimesChoosen = TimesChoosenBox.Value
    End Sub

    Private Sub AgeBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles AgeBox.SelectedIndexChanged
        If AgeBox.SelectedIndex = 5 Then
            SelectedFaceProps.Age = -1
        Else
            SelectedFaceProps.Age = AgeBox.SelectedIndex
        End If
    End Sub

    Private Sub GenderBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GenderBox.SelectedIndexChanged
        If GenderBox.SelectedIndex = 2 Then
            SelectedFaceProps.Gender = -1
        Else
            SelectedFaceProps.Gender = GenderBox.SelectedIndex
        End If
    End Sub

    Private Sub HorizontalScrollBox_ValueChanged(sender As Object, e As EventArgs) Handles HorizontalScrollBox.ValueChanged
        SelectedFaceProps.XMove = HorizontalScrollBox.Value
        UpdateImageBuffer()
    End Sub

    Private Sub VerticalScrollBox_ValueChanged(sender As Object, e As EventArgs) Handles VerticalScrollBox.ValueChanged
        SelectedFaceProps.YMove = VerticalScrollBox.Value
        UpdateImageBuffer()
    End Sub

    Private Sub HorizontalStretchBox_ValueChanged(sender As Object, e As EventArgs) Handles HorizontalStretchBox.ValueChanged
        SelectedFaceProps.XStretch = HorizontalStretchBox.Value
        UpdateImageBuffer()
    End Sub

    Private Sub VerticalStretchBox_ValueChanged(sender As Object, e As EventArgs) Handles VerticalStretchBox.ValueChanged
        SelectedFaceProps.YStretch = VerticalStretchBox.Value
        UpdateImageBuffer()
    End Sub

    Private Sub RotationBox_ValueChanged(sender As Object, e As EventArgs) Handles RotationBox.ValueChanged
        SelectedFaceProps.Rotation = RotationBox.Value
        UpdateImageBuffer()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            SelectedFaceBox.Image = My.Resources.FH_FCG_COMBO
        Else
            SelectedFaceBox.Image = My.Resources.FaceHole
        End If
    End Sub

    Private Sub FaceEditor_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If SelectedFace <> &HFFFFFFFFUI Then
            KbbEditor.SetFaceProps(SelectedFace, SelectedFaceProps)
        End If
    End Sub

    Private Sub ImportFaceButton_Click(sender As Object, e As EventArgs) Handles ImportFaceButton.Click
        GrayEverything()
        FaceToEdit = KbbEditor.GetFaceImage(SelectedFace)
        UFOEditor.ImportFaceButton.Enabled = False
        ImportFaceForm.IsUFO = False
        ImportFaceForm.Show()
        UpdateImageBuffer()
    End Sub

    Private Sub ExportFaceButton_Click(sender As Object, e As EventArgs) Handles ExportFaceButton.Click
        If (SaveFileDialog1.ShowDialog() = DialogResult.OK) Then
            Dim ExportedFace As Image = KbbEditor.GetFaceImage(SelectedFace)
            ExportedFace.Save(SaveFileDialog1.FileName)
            ExportedFace.Dispose()
        End If
    End Sub

    Private Sub SwapFacesButton_Click(sender As Object, e As EventArgs) Handles SwapFacesButton.Click
        If SwapMode = False Then
            SwapMode = True
            SwapFacesButton.Text = "Abort swap"
            Me.Text = "Select the other face to swap with."
            SelectedFaceBox.Enabled = False
            DayBox.Enabled = False
            MonthBox.Enabled = False
            YearBox.Enabled = False
            TimesChoosenBox.Enabled = False
            AgeBox.Enabled = False
            GenderBox.Enabled = False
            HorizontalScrollBox.Enabled = False
            VerticalScrollBox.Enabled = False
            HorizontalStretchBox.Enabled = False
            VerticalStretchBox.Enabled = False
            RotationBox.Enabled = False
            ImportFaceButton.Enabled = False
            ExportFaceButton.Enabled = False
            DeleteFaceButton.Enabled = False
        Else
            SwapMode = False
            SwapFacesButton.Text = "Swap faces"
            Me.Text = "Face editor"
            FreeEverything()
        End If
        UpdateImageBuffer()
    End Sub

    Sub SwapFaces(FirstFace, OtherFace)
        Dim SwappedFaceProps As KbbEditor.KbbFaceInfo
        SwappedFaceProps = KbbEditor.GetFaceProps(OtherFace)
        SwappedFaceImage = KbbEditor.GetFaceImage(OtherFace)
        KbbEditor.SetFaceProps(FirstFace, SwappedFaceProps)
        KbbEditor.SetFaceProps(OtherFace, SelectedFaceProps)
        KbbEditor.SetFaceImage(OtherFace, KbbEditor.GetFaceImage(FirstFace))
        KbbEditor.SetFaceImage(FirstFace, SwappedFaceImage)
        SelectedFace = OtherFace ' Without this, clicking another face will overwrite the info of the swapped face by the first one.
        ReloadFaces()
        SwapMode = False
        SwapFacesButton.Text = "Swap faces"
        Me.Text = "Face editor"
        FreeEverything()
        UpdateImageBuffer()
        MsgBox("Faces swapped!", vbInformation + vbOKOnly, "Success")
    End Sub

    Private Sub NewFaceButton_Click(sender As Object, e As EventArgs) Handles NewFaceButton.Click
        If KbbEditor.FacesOrder(48) <> &HFFFFFFFFUI Then
            MsgBox("No slots are avaible for a new face." & Chr(&HA) & "Try deleting or replacing another face.", vbInformation + vbOKOnly, "Error while creating new face")
        Else
            NewFaceForm.Show()
        End If
    End Sub

    Private Sub DeleteFaceButton_Click(sender As Object, e As EventArgs) Handles DeleteFaceButton.Click
        Dim Response = MsgBox("Are you sure to delete this face?", vbExclamation + vbYesNo, "Delete face")
        If Response = vbYes Then
            KbbEditor.DeleteFace(SelectedFace)
            SelectedFace = &HFFFFFFFFUI
            SelectedFaceBox.BackgroundImage = Nothing
            ImportFaceButton.Enabled = False
            ExportFaceButton.Enabled = False
            SwapFacesButton.Enabled = False
            DeleteFaceButton.Enabled = False
            If FacePage > 0 Then
                If KbbEditor.FacesOrder(9 + 10 * FacePage) = &HFFFFFFFFUI Then
                    RightPageButton.Enabled = False
                End If
                If KbbEditor.FacesOrder(-1 + 10 * FacePage) = &HFFFFFFFFUI Then
                    RightPageButton.Enabled = False
                    FacePage -= 1
                End If
            End If
            If FacePage = 0 Then
                LeftPageButton.Enabled = False
                FaceBox1.BackgroundImage = UFOThumb
                FaceBox1.Enabled = True
            Else
                FaceBox1.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.FacesOrder(-1 + 10 * FacePage))
                FaceBox1.Enabled = True
            End If
            FaceBox2.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.FacesOrder(0 + 10 * FacePage))
            FaceBox2.Enabled = True
            If KbbEditor.FacesOrder(0 + 10 * FacePage) = &HFFFFFFFFUI Then
                FaceBox2.Enabled = False
            End If
            FaceBox3.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.FacesOrder(1 + 10 * FacePage))
            FaceBox3.Enabled = True
            If KbbEditor.FacesOrder(1 + 10 * FacePage) = &HFFFFFFFFUI Then
                FaceBox3.Enabled = False
            End If
            FaceBox4.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.FacesOrder(2 + 10 * FacePage))
            FaceBox4.Enabled = True
            If KbbEditor.FacesOrder(2 + 10 * FacePage) = &HFFFFFFFFUI Then
                FaceBox4.Enabled = False
            End If
            FaceBox5.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.FacesOrder(3 + 10 * FacePage))
            FaceBox5.Enabled = True
            If KbbEditor.FacesOrder(3 + 10 * FacePage) = &HFFFFFFFFUI Then
                FaceBox5.Enabled = False
            End If
            FaceBox6.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.FacesOrder(4 + 10 * FacePage))
            FaceBox6.Enabled = True
            If KbbEditor.FacesOrder(4 + 10 * FacePage) = &HFFFFFFFFUI Then
                FaceBox6.Enabled = False
            End If
            FaceBox7.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.FacesOrder(5 + 10 * FacePage))
            FaceBox7.Enabled = True
            If KbbEditor.FacesOrder(5 + 10 * FacePage) = &HFFFFFFFFUI Then
                FaceBox7.Enabled = False
            End If
            FaceBox8.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.FacesOrder(6 + 10 * FacePage))
            FaceBox8.Enabled = True
            If KbbEditor.FacesOrder(6 + 10 * FacePage) = &HFFFFFFFFUI Then
                FaceBox8.Enabled = False
            End If
            FaceBox9.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.FacesOrder(7 + 10 * FacePage))
            FaceBox9.Enabled = True
            If KbbEditor.FacesOrder(7 + 10 * FacePage) = &HFFFFFFFFUI Then
                FaceBox9.Enabled = False
            End If
            FaceBox10.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.FacesOrder(8 + 10 * FacePage))
            FaceBox10.Enabled = True
            If KbbEditor.FacesOrder(8 + 10 * FacePage) = &HFFFFFFFFUI Then
                FaceBox10.Enabled = False
            End If
        End If
    End Sub

    Sub GrayEverything()
        LeftPageButton.Enabled = False
        RightPageButton.Enabled = False
        FaceBox1.Enabled = False
        FaceBox2.Enabled = False
        FaceBox3.Enabled = False
        FaceBox4.Enabled = False
        FaceBox5.Enabled = False
        FaceBox6.Enabled = False
        FaceBox7.Enabled = False
        FaceBox8.Enabled = False
        FaceBox9.Enabled = False
        FaceBox10.Enabled = False
        SelectedFaceBox.Enabled = False
        DayBox.Enabled = False
        MonthBox.Enabled = False
        YearBox.Enabled = False
        TimesChoosenBox.Enabled = False
        AgeBox.Enabled = False
        GenderBox.Enabled = False
        HorizontalScrollBox.Enabled = False
        VerticalScrollBox.Enabled = False
        HorizontalStretchBox.Enabled = False
        VerticalStretchBox.Enabled = False
        RotationBox.Enabled = False
        ImportFaceButton.Enabled = False
        ExportFaceButton.Enabled = False
        NewFaceButton.Enabled = False
        SwapFacesButton.Enabled = False
        DeleteFaceButton.Enabled = False
    End Sub

    Public Sub FreeEverything()
        ' Check the current page to prevent an invalid range exception
        If FacePage = 0 Then
            LeftPageButton.Enabled = False
            If KbbEditor.FacesOrder(9 + 10 * FacePage) = &HFFFFFFFFUI Then
                RightPageButton.Enabled = False
            Else
                RightPageButton.Enabled = True
            End If
        ElseIf FacePage = 4 Then
            LeftPageButton.Enabled = True
            RightPageButton.Enabled = False
        Else
            LeftPageButton.Enabled = True
            If KbbEditor.FacesOrder(9 + 10 * FacePage) = &HFFFFFFFFUI Then
                RightPageButton.Enabled = False
            Else
                RightPageButton.Enabled = True
            End If
        End If
        FaceBox1.Enabled = True
        FaceBox2.Enabled = True
        FaceBox3.Enabled = True
        FaceBox4.Enabled = True
        FaceBox5.Enabled = True
        FaceBox6.Enabled = True
        FaceBox7.Enabled = True
        FaceBox8.Enabled = True
        FaceBox9.Enabled = True
        FaceBox10.Enabled = True
        SelectedFaceBox.Enabled = True
        DayBox.Enabled = True
        MonthBox.Enabled = True
        YearBox.Enabled = True
        TimesChoosenBox.Enabled = True
        AgeBox.Enabled = True
        GenderBox.Enabled = True
        HorizontalScrollBox.Enabled = True
        VerticalScrollBox.Enabled = True
        HorizontalStretchBox.Enabled = True
        VerticalStretchBox.Enabled = True
        RotationBox.Enabled = True
        ImportFaceButton.Enabled = True
        ExportFaceButton.Enabled = True
        NewFaceButton.Enabled = True
        SwapFacesButton.Enabled = True
        DeleteFaceButton.Enabled = True
    End Sub

    Public Sub ReloadFaces()
        If FacePage <> 0 Then
            FaceBox1.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.FacesOrder(-1 + 10 * FacePage))
        End If
        FaceBox2.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.FacesOrder(0 + 10 * FacePage))
        If KbbEditor.FacesOrder(0 + 10 * FacePage) <> &HFFFFFFFFUI Then
            FaceBox2.Enabled = True
        End If
        FaceBox3.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.FacesOrder(1 + 10 * FacePage))
        If KbbEditor.FacesOrder(1 + 10 * FacePage) <> &HFFFFFFFFUI Then
            FaceBox3.Enabled = True
        End If
        FaceBox4.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.FacesOrder(2 + 10 * FacePage))
        If KbbEditor.FacesOrder(2 + 10 * FacePage) <> &HFFFFFFFFUI Then
            FaceBox4.Enabled = True
        End If
        FaceBox5.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.FacesOrder(3 + 10 * FacePage))
        If KbbEditor.FacesOrder(3 + 10 * FacePage) <> &HFFFFFFFFUI Then
            FaceBox5.Enabled = True
        End If
        FaceBox6.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.FacesOrder(4 + 10 * FacePage))
        If KbbEditor.FacesOrder(4 + 10 * FacePage) <> &HFFFFFFFFUI Then
            FaceBox6.Enabled = True
        End If
        FaceBox7.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.FacesOrder(5 + 10 * FacePage))
        If KbbEditor.FacesOrder(5 + 10 * FacePage) <> &HFFFFFFFFUI Then
            FaceBox7.Enabled = True
        End If
        FaceBox8.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.FacesOrder(6 + 10 * FacePage))
        If KbbEditor.FacesOrder(6 + 10 * FacePage) <> &HFFFFFFFFUI Then
            FaceBox8.Enabled = True
        End If
        FaceBox9.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.FacesOrder(7 + 10 * FacePage))
        If KbbEditor.FacesOrder(7 + 10 * FacePage) <> &HFFFFFFFFUI Then
            FaceBox9.Enabled = True
        End If
        FaceBox10.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.FacesOrder(8 + 10 * FacePage))
        If KbbEditor.FacesOrder(8 + 10 * FacePage) <> &HFFFFFFFFUI Then
            FaceBox10.Enabled = True
        End If
        If FacePage < 4 Then
            If KbbEditor.FacesOrder(9 + 10 * FacePage) = &HFFFFFFFFUI Then
                RightPageButton.Enabled = False
            Else
                RightPageButton.Enabled = True
            End If
        Else
            RightPageButton.Enabled = False
        End If
    End Sub

    Public Sub ChangeFaceImage()
        KbbEditor.SetFaceImage(SelectedFace, FaceToEdit)
        SelectedFaceBox.BackgroundImage = FaceToEdit
        UpdateImageBuffer()
    End Sub

    Public Sub ReDrawUFOThumb()
        If KbbEditor.UFOFacesOrder(0) = &HFFFFFFFFUI Then
            FaceBox1.Image = Nothing
            FaceBox1.BackgroundImage = Nothing
        Else
            Dim g As Graphics
            g = Graphics.FromImage(UFOThumb)
            g.Clear(Color.Black)

            g.ScaleTransform(0.59375, 0.59375)
            g.DrawImage(KbbEditor.UFOFaceImages(KbbEditor.UFOFacesOrder(0)), 38, 69)

            g.ResetTransform()
            g.DrawImage(My.Resources.FaceUFO, 0, 0)

            FaceBox1.Image = Nothing
            FaceBox1.BackgroundImage = UFOThumb
            FaceBox1.Invalidate()
        End If
    End Sub

    Private Sub UpdateImageBuffer()
        Dim Corners As PointF()

        Dim FacePageCheck As Boolean() = {
            False, False, False, False, False,
            False, False, False, False, False
        }

        If SelectedFace <> &HFFFFFFFFUI Then
            Dim gS As Graphics = Graphics.FromImage(BackBufferS)
            gS.Clear(Color.Black)
            Corners = ApplyTransforms(SelectedFaceProps)
            gS.DrawImage(KbbEditor.GetFaceImage(SelectedFace), Corners)
        End If

        If FacePage > 0 Then
            Dim g As Graphics = Graphics.FromImage(BackBuffer1)
            g.Clear(Color.Black)
            FetchedFace = KbbEditor.FacesOrder(-1 + 10 * FacePage)
            FetchedFaceProps = KbbEditor.GetFaceProps(FetchedFace)
            Corners = ApplyTransforms(FetchedFaceProps)
            g.DrawImage(KbbEditor.GetFaceImage(FetchedFace), Corners)
            FacePageCheck(0) = True
            g.Dispose()
        End If
        If KbbEditor.FacesOrder(0 + 10 * FacePage) <> &HFFFFFFFFUI Then
            Dim g As Graphics = Graphics.FromImage(BackBuffer2)
            g.Clear(Color.Black)
            FetchedFace = KbbEditor.FacesOrder(0 + 10 * FacePage)
            FetchedFaceProps = KbbEditor.GetFaceProps(FetchedFace)
            Corners = ApplyTransforms(FetchedFaceProps)
            g.DrawImage(KbbEditor.GetFaceImage(FetchedFace), Corners)
            FacePageCheck(1) = True
            g.Dispose()
        End If
        If KbbEditor.FacesOrder(1 + 10 * FacePage) <> &HFFFFFFFFUI Then
            Dim g As Graphics = Graphics.FromImage(BackBuffer3)
            g.Clear(Color.Black)
            FetchedFace = KbbEditor.FacesOrder(1 + 10 * FacePage)
            FetchedFaceProps = KbbEditor.GetFaceProps(FetchedFace)
            Corners = ApplyTransforms(FetchedFaceProps)
            g.DrawImage(KbbEditor.GetFaceImage(FetchedFace), Corners)
            FacePageCheck(2) = True
            g.Dispose()
        End If
        If KbbEditor.FacesOrder(2 + 10 * FacePage) <> &HFFFFFFFFUI Then
            Dim g As Graphics = Graphics.FromImage(BackBuffer4)
            g.Clear(Color.Black)
            FetchedFace = KbbEditor.FacesOrder(2 + 10 * FacePage)
            FetchedFaceProps = KbbEditor.GetFaceProps(FetchedFace)
            Corners = ApplyTransforms(FetchedFaceProps)
            g.DrawImage(KbbEditor.GetFaceImage(FetchedFace), Corners)
            FacePageCheck(3) = True
            g.Dispose()
        End If
        If KbbEditor.FacesOrder(3 + 10 * FacePage) <> &HFFFFFFFFUI Then
            Dim g As Graphics = Graphics.FromImage(BackBuffer5)
            g.Clear(Color.Black)
            FetchedFace = KbbEditor.FacesOrder(3 + 10 * FacePage)
            FetchedFaceProps = KbbEditor.GetFaceProps(FetchedFace)
            Corners = ApplyTransforms(FetchedFaceProps)
            g.DrawImage(KbbEditor.GetFaceImage(FetchedFace), Corners)
            FacePageCheck(4) = True
            g.Dispose()
        End If
        If KbbEditor.FacesOrder(4 + 10 * FacePage) <> &HFFFFFFFFUI Then
            Dim g As Graphics = Graphics.FromImage(BackBuffer6)
            g.Clear(Color.Black)
            FetchedFace = KbbEditor.FacesOrder(4 + 10 * FacePage)
            FetchedFaceProps = KbbEditor.GetFaceProps(FetchedFace)
            Corners = ApplyTransforms(FetchedFaceProps)
            g.DrawImage(KbbEditor.GetFaceImage(FetchedFace), Corners)
            FacePageCheck(5) = True
            g.Dispose()
        End If
        If KbbEditor.FacesOrder(5 + 10 * FacePage) <> &HFFFFFFFFUI Then
            Dim g As Graphics = Graphics.FromImage(BackBuffer7)
            g.Clear(Color.Black)
            FetchedFace = KbbEditor.FacesOrder(5 + 10 * FacePage)
            FetchedFaceProps = KbbEditor.GetFaceProps(FetchedFace)
            Corners = ApplyTransforms(FetchedFaceProps)
            g.DrawImage(KbbEditor.GetFaceImage(FetchedFace), Corners)
            FacePageCheck(6) = True
            g.Dispose()
        End If
        If KbbEditor.FacesOrder(6 + 10 * FacePage) <> &HFFFFFFFFUI Then
            Dim g As Graphics = Graphics.FromImage(BackBuffer8)
            g.Clear(Color.Black)
            FetchedFace = KbbEditor.FacesOrder(6 + 10 * FacePage)
            FetchedFaceProps = KbbEditor.GetFaceProps(FetchedFace)
            Corners = ApplyTransforms(FetchedFaceProps)
            g.DrawImage(KbbEditor.GetFaceImage(FetchedFace), Corners)
            FacePageCheck(7) = True
            g.Dispose()
        End If
        If KbbEditor.FacesOrder(7 + 10 * FacePage) <> &HFFFFFFFFUI Then
            Dim g As Graphics = Graphics.FromImage(BackBuffer9)
            g.Clear(Color.Black)
            FetchedFace = KbbEditor.FacesOrder(7 + 10 * FacePage)
            FetchedFaceProps = KbbEditor.GetFaceProps(FetchedFace)
            Corners = ApplyTransforms(FetchedFaceProps)
            g.DrawImage(KbbEditor.GetFaceImage(FetchedFace), Corners)
            FacePageCheck(8) = True
            g.Dispose()
        End If
        If KbbEditor.FacesOrder(8 + 10 * FacePage) <> &HFFFFFFFFUI Then
            Dim g As Graphics = Graphics.FromImage(BackBuffer10)
            g.Clear(Color.Black)
            FetchedFace = KbbEditor.FacesOrder(8 + 10 * FacePage)
            FetchedFaceProps = KbbEditor.GetFaceProps(FetchedFace)
            Corners = ApplyTransforms(FetchedFaceProps)
            g.DrawImage(KbbEditor.GetFaceImage(FetchedFace), Corners)
            FacePageCheck(9) = True
            g.Dispose()
        End If

        ' End draw

        If SelectedFace <> &HFFFFFFFFUI Then
            SelectedFaceBox.BackgroundImage = BackBufferS
            SelectedFaceBox.Invalidate()
        End If

        If FacePage > 0 And FacePageCheck(0) = True Then
            FaceBox1.BackgroundImage = BackBuffer1
            FaceBox1.Invalidate()
        End If
        If FacePageCheck(1) = True Then
            FaceBox2.BackgroundImage = BackBuffer2
            FaceBox2.Invalidate()
        End If
        If FacePageCheck(2) = True Then
            FaceBox3.BackgroundImage = BackBuffer3
            FaceBox3.Invalidate()
        End If
        If FacePageCheck(3) = True Then
            FaceBox4.BackgroundImage = BackBuffer4
            FaceBox4.Invalidate()
        End If
        If FacePageCheck(4) = True Then
            FaceBox5.BackgroundImage = BackBuffer5
            FaceBox5.Invalidate()
        End If
        If FacePageCheck(5) = True Then
            FaceBox6.BackgroundImage = BackBuffer6
            FaceBox6.Invalidate()
        End If
        If FacePageCheck(6) = True Then
            FaceBox7.BackgroundImage = BackBuffer7
            FaceBox7.Invalidate()
        End If
        If FacePageCheck(7) = True Then
            FaceBox8.BackgroundImage = BackBuffer8
            FaceBox8.Invalidate()
        End If
        If FacePageCheck(8) = True Then
            FaceBox9.BackgroundImage = BackBuffer9
            FaceBox9.Invalidate()
        End If
        If FacePageCheck(9) = True Then
            FaceBox10.BackgroundImage = BackBuffer10
            FaceBox10.Invalidate()
        End If
    End Sub

    Function ApplyTransforms(FaceProps As KbbEditor.KbbFaceInfo)
        Dim cx As Double = 64
        Dim cy As Double = 64

        Dim Corners(2) As PointF
        Corners(0) = New PointF(CSng(cx - (64 / FaceProps.XStretch)), CSng(cy - (64 / FaceProps.YStretch)))
        Corners(1) = New PointF(CSng(cx + (64 / FaceProps.XStretch)), CSng(cy - (64 / FaceProps.YStretch)))
        Corners(2) = New PointF(CSng(cx - (64 / FaceProps.XStretch)), CSng(cy + (64 / FaceProps.YStretch)))

        Dim X As Double
        For i = 0 To 2
            X = Corners(i).X
            Corners(i).X = CSng(Corners(i).X * Math.Cos(-FaceProps.Rotation) + Corners(i).Y * Math.Sin(-FaceProps.Rotation))
            Corners(i).Y = CSng((Corners(i).Y * Math.Cos(-FaceProps.Rotation)) - (X * Math.Sin(-FaceProps.Rotation)))
        Next i

        Dim newcx As Double = Corners(2).X + (Corners(1).X - Corners(2).X) / 2
        Dim newcy As Double = Corners(2).Y + (Corners(1).Y - Corners(2).Y) / 2

        For i = 0 To 2
            Corners(i).X = CSng(Corners(i).X + (cx - newcx - (FaceProps.XMove * 128)))
            Corners(i).Y = CSng(Corners(i).Y + (cy - newcy - (FaceProps.YMove * 128)))
        Next i

        Return Corners
    End Function
End Class