Imports System.Drawing.Drawing2D
Imports System.Drawing
Imports System.ComponentModel

Public Class FaceEditor
    Dim FacePage As Integer
    Dim SelectedFace As UInteger = &HFFFFFFFFUI
    Dim SelectedFaceProps As KbbEditor.KbbFaceInfo
    Public FaceToEdit As New Bitmap(128, 128)

    Dim BackBuffer As New Bitmap(128, 128) ' For later use

    Private Sub FaceEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FacePage = 0
        LeftPageButton.Enabled = False
        FaceBox1.BackgroundImage = Nothing
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
    End Sub

    Private Sub LeftPageButton_Click(sender As Object, e As EventArgs) Handles LeftPageButton.Click
        FacePage -= 1
        If FacePage = 3 Then
            RightPageButton.Enabled = True
        End If
        If FacePage = 0 Then
            LeftPageButton.Enabled = False
            FaceBox1.BackgroundImage = Nothing
            FaceBox1.Enabled = False
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
    End Sub

    Private Sub RightPageButton_Click(sender As Object, e As EventArgs) Handles RightPageButton.Click
        FacePage += 1
        If FacePage = 1 Then
            LeftPageButton.Enabled = True
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
        If KbbEditor.FacesOrder(9 + 10 * FacePage) = &HFFFFFFFFUI Then
            RightPageButton.Enabled = False
        Else
            RightPageButton.Enabled = True
        End If
    End Sub

    Private Sub FaceBox1_Click(sender As Object, e As EventArgs) Handles FaceBox1.Click
        If FacePage > 0 Then
            ImportFaceButton.Enabled = True
            ExportFaceButton.Enabled = True
            DeleteFaceButton.Enabled = True
            KbbEditor.SetFaceProps(SelectedFace, SelectedFaceProps)
            SelectedFace = KbbEditor.FacesOrder(-1 + 10 * FacePage)
            SelectedFaceBox.BackgroundImage = KbbEditor.GetFaceImage(SelectedFace)
            SelectedFaceProps = KbbEditor.GetFaceProps(SelectedFace)
            DayBox.Value = SelectedFaceProps.DayMet
            MonthBox.Value = SelectedFaceProps.MonthMet
            YearBox.Value = SelectedFaceProps.YearMet
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
        Else
            ' At page 0 slot 1, the UFO is there, no reason to select it.
        End If
    End Sub

    Private Sub FaceBox2_Click(sender As Object, e As EventArgs) Handles FaceBox2.Click
        ImportFaceButton.Enabled = True
        ExportFaceButton.Enabled = True
        DeleteFaceButton.Enabled = True
        KbbEditor.SetFaceProps(SelectedFace, SelectedFaceProps)
        SelectedFace = KbbEditor.FacesOrder(0 + 10 * FacePage)
        SelectedFaceBox.BackgroundImage = KbbEditor.GetFaceImage(SelectedFace)
        SelectedFaceProps = KbbEditor.GetFaceProps(SelectedFace)
        DayBox.Value = SelectedFaceProps.DayMet
        MonthBox.Value = SelectedFaceProps.MonthMet
        YearBox.Value = SelectedFaceProps.YearMet
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
    End Sub

    Private Sub FaceBox3_Click(sender As Object, e As EventArgs) Handles FaceBox3.Click
        ImportFaceButton.Enabled = True
        ExportFaceButton.Enabled = True
        DeleteFaceButton.Enabled = True
        KbbEditor.SetFaceProps(SelectedFace, SelectedFaceProps)
        SelectedFace = KbbEditor.FacesOrder(1 + 10 * FacePage)
        SelectedFaceBox.BackgroundImage = KbbEditor.GetFaceImage(SelectedFace)
        SelectedFaceProps = KbbEditor.GetFaceProps(SelectedFace)
        DayBox.Value = SelectedFaceProps.DayMet
        MonthBox.Value = SelectedFaceProps.MonthMet
        YearBox.Value = SelectedFaceProps.YearMet
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
    End Sub

    Private Sub FaceBox4_Click(sender As Object, e As EventArgs) Handles FaceBox4.Click
        ImportFaceButton.Enabled = True
        ExportFaceButton.Enabled = True
        DeleteFaceButton.Enabled = True
        KbbEditor.SetFaceProps(SelectedFace, SelectedFaceProps)
        SelectedFace = KbbEditor.FacesOrder(2 + 10 * FacePage)
        SelectedFaceBox.BackgroundImage = KbbEditor.GetFaceImage(SelectedFace)
        SelectedFaceProps = KbbEditor.GetFaceProps(SelectedFace)
        DayBox.Value = SelectedFaceProps.DayMet
        MonthBox.Value = SelectedFaceProps.MonthMet
        YearBox.Value = SelectedFaceProps.YearMet
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
    End Sub

    Private Sub FaceBox5_Click(sender As Object, e As EventArgs) Handles FaceBox5.Click
        ImportFaceButton.Enabled = True
        ExportFaceButton.Enabled = True
        DeleteFaceButton.Enabled = True
        KbbEditor.SetFaceProps(SelectedFace, SelectedFaceProps)
        SelectedFace = KbbEditor.FacesOrder(3 + 10 * FacePage)
        SelectedFaceBox.BackgroundImage = KbbEditor.GetFaceImage(SelectedFace)
        SelectedFaceProps = KbbEditor.GetFaceProps(SelectedFace)
        DayBox.Value = SelectedFaceProps.DayMet
        MonthBox.Value = SelectedFaceProps.MonthMet
        YearBox.Value = SelectedFaceProps.YearMet
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
    End Sub

    Private Sub FaceBox6_Click(sender As Object, e As EventArgs) Handles FaceBox6.Click
        ImportFaceButton.Enabled = True
        ExportFaceButton.Enabled = True
        DeleteFaceButton.Enabled = True
        KbbEditor.SetFaceProps(SelectedFace, SelectedFaceProps)
        SelectedFace = KbbEditor.FacesOrder(4 + 10 * FacePage)
        SelectedFaceBox.BackgroundImage = KbbEditor.GetFaceImage(SelectedFace)
        SelectedFaceProps = KbbEditor.GetFaceProps(SelectedFace)
        DayBox.Value = SelectedFaceProps.DayMet
        MonthBox.Value = SelectedFaceProps.MonthMet
        YearBox.Value = SelectedFaceProps.YearMet
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
    End Sub

    Private Sub FaceBox7_Click(sender As Object, e As EventArgs) Handles FaceBox7.Click
        ImportFaceButton.Enabled = True
        ExportFaceButton.Enabled = True
        DeleteFaceButton.Enabled = True
        KbbEditor.SetFaceProps(SelectedFace, SelectedFaceProps)
        SelectedFace = KbbEditor.FacesOrder(5 + 10 * FacePage)
        SelectedFaceBox.BackgroundImage = KbbEditor.GetFaceImage(SelectedFace)
        SelectedFaceProps = KbbEditor.GetFaceProps(SelectedFace)
        DayBox.Value = SelectedFaceProps.DayMet
        MonthBox.Value = SelectedFaceProps.MonthMet
        YearBox.Value = SelectedFaceProps.YearMet
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
    End Sub

    Private Sub FaceBox8_Click(sender As Object, e As EventArgs) Handles FaceBox8.Click
        ImportFaceButton.Enabled = True
        ExportFaceButton.Enabled = True
        DeleteFaceButton.Enabled = True
        KbbEditor.SetFaceProps(SelectedFace, SelectedFaceProps)
        SelectedFace = KbbEditor.FacesOrder(6 + 10 * FacePage)
        SelectedFaceBox.BackgroundImage = KbbEditor.GetFaceImage(SelectedFace)
        SelectedFaceProps = KbbEditor.GetFaceProps(SelectedFace)
        DayBox.Value = SelectedFaceProps.DayMet
        MonthBox.Value = SelectedFaceProps.MonthMet
        YearBox.Value = SelectedFaceProps.YearMet
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
    End Sub

    Private Sub FaceBox9_Click(sender As Object, e As EventArgs) Handles FaceBox9.Click
        ImportFaceButton.Enabled = True
        ExportFaceButton.Enabled = True
        DeleteFaceButton.Enabled = True
        KbbEditor.SetFaceProps(SelectedFace, SelectedFaceProps)
        SelectedFace = KbbEditor.FacesOrder(7 + 10 * FacePage)
        SelectedFaceBox.BackgroundImage = KbbEditor.GetFaceImage(SelectedFace)
        SelectedFaceProps = KbbEditor.GetFaceProps(SelectedFace)
        DayBox.Value = SelectedFaceProps.DayMet
        MonthBox.Value = SelectedFaceProps.MonthMet
        YearBox.Value = SelectedFaceProps.YearMet
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
    End Sub

    Private Sub FaceBox10_Click(sender As Object, e As EventArgs) Handles FaceBox10.Click
        ImportFaceButton.Enabled = True
        ExportFaceButton.Enabled = True
        DeleteFaceButton.Enabled = True
        KbbEditor.SetFaceProps(SelectedFace, SelectedFaceProps)
        SelectedFace = KbbEditor.FacesOrder(8 + 10 * FacePage)
        SelectedFaceBox.BackgroundImage = KbbEditor.GetFaceImage(SelectedFace)
        SelectedFaceProps = KbbEditor.GetFaceProps(SelectedFace)
        DayBox.Value = SelectedFaceProps.DayMet
        MonthBox.Value = SelectedFaceProps.MonthMet
        YearBox.Value = SelectedFaceProps.YearMet
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
    End Sub

    Private Sub DayBox_ValueChanged(sender As Object, e As EventArgs) Handles DayBox.ValueChanged
        SelectedFaceProps.DayMet = DayBox.Value
    End Sub

    Private Sub MonthBox_ValueChanged(sender As Object, e As EventArgs) Handles MonthBox.ValueChanged
        SelectedFaceProps.MonthMet = MonthBox.Value
    End Sub

    Private Sub YearBox_ValueChanged(sender As Object, e As EventArgs) Handles YearBox.ValueChanged
        SelectedFaceProps.YearMet = YearBox.Value
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
    End Sub

    Private Sub VerticalScrollBox_ValueChanged(sender As Object, e As EventArgs) Handles VerticalScrollBox.ValueChanged
        SelectedFaceProps.YMove = VerticalScrollBox.Value
    End Sub

    Private Sub HorizontalStretchBox_ValueChanged(sender As Object, e As EventArgs) Handles HorizontalStretchBox.ValueChanged
        SelectedFaceProps.XStretch = HorizontalStretchBox.Value
    End Sub

    Private Sub VerticalStretchBox_ValueChanged(sender As Object, e As EventArgs) Handles VerticalStretchBox.ValueChanged
        SelectedFaceProps.YStretch = VerticalStretchBox.Value
    End Sub

    Private Sub RotationBox_ValueChanged(sender As Object, e As EventArgs) Handles RotationBox.ValueChanged
        SelectedFaceProps.Rotation = RotationBox.Value
    End Sub

    Private Sub FaceEditor_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If SelectedFace <> &HFFFFFFFFUI Then
            KbbEditor.SetFaceProps(SelectedFace, SelectedFaceProps)
        End If
    End Sub

    Private Sub ImportFaceButton_Click(sender As Object, e As EventArgs) Handles ImportFaceButton.Click
        GrayEverything()
        FaceToEdit = KbbEditor.GetFaceImage(SelectedFace)
        ImportFaceForm.Show()
    End Sub

    Private Sub ExportFaceButton_Click(sender As Object, e As EventArgs) Handles ExportFaceButton.Click
        If (SaveFileDialog1.ShowDialog() = DialogResult.OK) Then
            Dim ExportedFace As Image = KbbEditor.GetFaceImage(SelectedFace)
            Dim PathBytes = System.Text.Encoding.Unicode.GetBytes(SaveFileDialog1.FileName)
            Dim OutFormat As String = ""
            Dim DotLoc As Integer = PathBytes.Length - 2
            While ChrW(PathBytes(DotLoc)) <> "."
                If DotLoc > 0 Then
                    DotLoc -= 2
                Else
                    Exit While
                End If
            End While
            DotLoc += 2
            While DotLoc < PathBytes.Length
                If PathBytes(DotLoc) >= &H61 And PathBytes(DotLoc) <= &H7A And PathBytes(DotLoc + 1) = &H0 Then
                    OutFormat += ChrW(PathBytes(DotLoc) - &H20)
                Else
                    OutFormat += ChrW(PathBytes(DotLoc))
                End If
                DotLoc += 2
            End While
            Select Case OutFormat
                Case "BMP"
                    ExportedFace.Save(SaveFileDialog1.FileName, Imaging.ImageFormat.Bmp)
                Case "JPG", "JPEG"
                    ExportedFace.Save(SaveFileDialog1.FileName, Imaging.ImageFormat.Jpeg)
                Case "PNG"
                    ExportedFace.Save(SaveFileDialog1.FileName, Imaging.ImageFormat.Png)
                Case Else
                    MsgBox("Sorry... This file format is not supported!", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Error while saving face as image")
            End Select
        End If
    End Sub

    Private Sub DeleteFaceButton_Click(sender As Object, e As EventArgs) Handles DeleteFaceButton.Click
        Dim Response = MsgBox("Are you sure to delete this face?", vbExclamation + vbYesNo, "Delete face")
        If Response = vbYes Then
            KbbEditor.DeleteFace(SelectedFace)
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
                FaceBox1.BackgroundImage = Nothing
                FaceBox1.Enabled = False
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
        DeleteFaceButton.Enabled = True
    End Sub

    Public Sub ChangeFaceImage()
        KbbEditor.SetFaceImage(SelectedFace, FaceToEdit)
        SelectedFaceBox.BackgroundImage = FaceToEdit
        If FacePage <> 0 Then
            FaceBox1.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.FacesOrder(-1 + 10 * FacePage))
        End If
        FaceBox2.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.FacesOrder(0 + 10 * FacePage))
        FaceBox3.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.FacesOrder(1 + 10 * FacePage))
        FaceBox4.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.FacesOrder(2 + 10 * FacePage))
        FaceBox5.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.FacesOrder(3 + 10 * FacePage))
        FaceBox6.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.FacesOrder(4 + 10 * FacePage))
        FaceBox7.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.FacesOrder(5 + 10 * FacePage))
        FaceBox8.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.FacesOrder(6 + 10 * FacePage))
        FaceBox9.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.FacesOrder(7 + 10 * FacePage))
        FaceBox10.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.FacesOrder(8 + 10 * FacePage))
    End Sub

    ' The following code will be used to render the faces with their transform

    'Private Sub UpdateImageBuffer_Tick(sender As Object, e As EventArgs) Handles UpdateImageBuffer.Tick
    '    Dim g As Graphics
    '    g = Graphics.FromImage(BackBuffer)
    '    g.Clear(Color.Black)
    '    
    '    Dim ImgOffX As Single = 64 - SelectedImage.Width / 2
    '    Dim ImgOffY As Single = 64 - SelectedImage.Height / 2
    '    g.DrawImage(My.Resources.DummyFace, New Point(ImgOffX, ImgOffY))
    '
    '    ' End draw
    '
    '    SelectedFaceBox.BackgroundImage = BackBuffer
    '    SelectedFaceBox.Invalidate()
    'End Sub
End Class