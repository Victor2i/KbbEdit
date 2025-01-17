Public Class UFOEditor
    Dim SelectedFace As UInteger = &HFFFFFFFFUI
    Dim SelectedFaceProps As KbbEditor.KbbUFOFaceInfo
    Public FaceToEdit As New Bitmap(128, 128)
    Dim SwapMode As Boolean = False

    Private Sub UFOEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReloadFaces()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            SelectedFaceBox.Image = My.Resources.face_calibrate_guide
        Else
            SelectedFaceBox.Image = Nothing
        End If
    End Sub

    Dim MinDate As New Date(1707, 9, 22, 0, 12, 44)
    Dim MaxDate As New Date(2292, 4, 10, 23, 47, 16)
    Dim ZeroDate As New Date(2000, 1, 1, 0, 0, 0)
    Function ConvertSeconds2Date(val As Int64) As Date
        val = Math.Clamp(val, -9223372036L, 9223372036L)
        Return ZeroDate.AddSeconds(val)
    End Function

    Function ConvertDate2Seconds(val As Date) As Int64
        Return -CLng((ZeroDate - val).TotalSeconds)
    End Function

    Sub LoadSelectedFaceProps()
        SelectedFaceBox.BackgroundImage = KbbEditor.GetFaceImage(SelectedFace, True)
        SelectedFaceProps = KbbEditor.GetUFOFaceProps(SelectedFace)
        NewFaceCB.Checked = SelectedFaceProps.NewFace
        NewFaceCB.Enabled = True
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
        DateTimePicker1.Value = ConvertSeconds2Date(SelectedFaceProps.CaptureDate)
    End Sub

    Private Sub FaceBox1_Click(sender As Object, e As EventArgs) Handles FaceBox1.Click
        If SwapMode = False Then
            ImportFaceButton.Enabled = True
            ExportFaceButton.Enabled = True
            SwapFacesButton.Enabled = True
            DeleteFaceButton.Enabled = True
            KbbEditor.SetUFOFaceProps(SelectedFace, SelectedFaceProps)
            SelectedFace = KbbEditor.UFOFacesOrder(0)
            LoadSelectedFaceProps()
        Else
            SwapFaces(SelectedFace, KbbEditor.UFOFacesOrder(0))
        End If
    End Sub

    Private Sub FaceBox2_Click(sender As Object, e As EventArgs) Handles FaceBox2.Click
        If SwapMode = False Then
            ImportFaceButton.Enabled = True
            ExportFaceButton.Enabled = True
            SwapFacesButton.Enabled = True
            DeleteFaceButton.Enabled = True
            KbbEditor.SetUFOFaceProps(SelectedFace, SelectedFaceProps)
            SelectedFace = KbbEditor.UFOFacesOrder(1)
            LoadSelectedFaceProps()
        Else
            SwapFaces(SelectedFace, KbbEditor.UFOFacesOrder(1))
        End If
    End Sub

    Private Sub FaceBox3_Click(sender As Object, e As EventArgs) Handles FaceBox3.Click
        If SwapMode = False Then
            ImportFaceButton.Enabled = True
            ExportFaceButton.Enabled = True
            SwapFacesButton.Enabled = True
            DeleteFaceButton.Enabled = True
            KbbEditor.SetUFOFaceProps(SelectedFace, SelectedFaceProps)
            SelectedFace = KbbEditor.UFOFacesOrder(2)
            LoadSelectedFaceProps()
        Else
            SwapFaces(SelectedFace, KbbEditor.UFOFacesOrder(2))
        End If
    End Sub

    Private Sub FaceBox4_Click(sender As Object, e As EventArgs) Handles FaceBox4.Click
        If SwapMode = False Then
            ImportFaceButton.Enabled = True
            ExportFaceButton.Enabled = True
            SwapFacesButton.Enabled = True
            DeleteFaceButton.Enabled = True
            KbbEditor.SetUFOFaceProps(SelectedFace, SelectedFaceProps)
            SelectedFace = KbbEditor.UFOFacesOrder(3)
            LoadSelectedFaceProps()
        Else
            SwapFaces(SelectedFace, KbbEditor.UFOFacesOrder(3))
        End If
    End Sub

    Private Sub FaceBox5_Click(sender As Object, e As EventArgs) Handles FaceBox5.Click
        If SwapMode = False Then
            ImportFaceButton.Enabled = True
            ExportFaceButton.Enabled = True
            SwapFacesButton.Enabled = True
            DeleteFaceButton.Enabled = True
            KbbEditor.SetUFOFaceProps(SelectedFace, SelectedFaceProps)
            SelectedFace = KbbEditor.UFOFacesOrder(4)
            LoadSelectedFaceProps()
        Else
            SwapFaces(SelectedFace, KbbEditor.UFOFacesOrder(4))
        End If
    End Sub

    Private Sub FaceBox6_Click(sender As Object, e As EventArgs) Handles FaceBox6.Click
        If SwapMode = False Then
            ImportFaceButton.Enabled = True
            ExportFaceButton.Enabled = True
            SwapFacesButton.Enabled = True
            DeleteFaceButton.Enabled = True
            KbbEditor.SetUFOFaceProps(SelectedFace, SelectedFaceProps)
            SelectedFace = KbbEditor.UFOFacesOrder(5)
            LoadSelectedFaceProps()
        Else
            SwapFaces(SelectedFace, KbbEditor.UFOFacesOrder(5))
        End If
    End Sub

    Private Sub FaceBox7_Click(sender As Object, e As EventArgs) Handles FaceBox7.Click
        If SwapMode = False Then
            ImportFaceButton.Enabled = True
            ExportFaceButton.Enabled = True
            SwapFacesButton.Enabled = True
            DeleteFaceButton.Enabled = True
            KbbEditor.SetUFOFaceProps(SelectedFace, SelectedFaceProps)
            SelectedFace = KbbEditor.UFOFacesOrder(6)
            LoadSelectedFaceProps()
        Else
            SwapFaces(SelectedFace, KbbEditor.UFOFacesOrder(6))
        End If
    End Sub

    Private Sub FaceBox8_Click(sender As Object, e As EventArgs) Handles FaceBox8.Click
        If SwapMode = False Then
            ImportFaceButton.Enabled = True
            ExportFaceButton.Enabled = True
            SwapFacesButton.Enabled = True
            DeleteFaceButton.Enabled = True
            KbbEditor.SetUFOFaceProps(SelectedFace, SelectedFaceProps)
            SelectedFace = KbbEditor.UFOFacesOrder(7)
            LoadSelectedFaceProps()
        Else
            SwapFaces(SelectedFace, KbbEditor.UFOFacesOrder(7))
        End If
    End Sub

    Private Sub FaceBox9_Click(sender As Object, e As EventArgs) Handles FaceBox9.Click
        If SwapMode = False Then
            ImportFaceButton.Enabled = True
            ExportFaceButton.Enabled = True
            SwapFacesButton.Enabled = True
            DeleteFaceButton.Enabled = True
            KbbEditor.SetUFOFaceProps(SelectedFace, SelectedFaceProps)
            SelectedFace = KbbEditor.UFOFacesOrder(8)
            LoadSelectedFaceProps()
        Else
            SwapFaces(SelectedFace, KbbEditor.UFOFacesOrder(8))
        End If
    End Sub

    Private Sub FaceBox10_Click(sender As Object, e As EventArgs) Handles FaceBox10.Click
        If SwapMode = False Then
            ImportFaceButton.Enabled = True
            ExportFaceButton.Enabled = True
            SwapFacesButton.Enabled = True
            DeleteFaceButton.Enabled = True
            KbbEditor.SetUFOFaceProps(SelectedFace, SelectedFaceProps)
            SelectedFace = KbbEditor.UFOFacesOrder(9)
            LoadSelectedFaceProps()
        Else
            SwapFaces(SelectedFace, KbbEditor.UFOFacesOrder(9))
        End If
    End Sub

    Sub SwapFaces(FirstFace, OtherFace)
        Dim SwappedFaceProps As KbbEditor.KbbUFOFaceInfo
        Dim SwappedFaceImage As Bitmap
        SwappedFaceProps = KbbEditor.GetUFOFaceProps(OtherFace)
        SwappedFaceImage = KbbEditor.GetFaceImage(OtherFace, True)
        KbbEditor.SetUFOFaceProps(FirstFace, SwappedFaceProps)
        KbbEditor.SetUFOFaceProps(OtherFace, SelectedFaceProps)
        KbbEditor.SetFaceImage(OtherFace, KbbEditor.GetFaceImage(FirstFace, True), True)
        KbbEditor.SetFaceImage(FirstFace, SwappedFaceImage, True)
        SelectedFace = OtherFace ' Without this, clicking another face will overwrite the info of the swapped face by the first one.
        ReloadFaces()
        SwapMode = False
        SwapFacesButton.Text = "Swap faces"
        Me.Text = "UFO Crew"
        FreeEverything()
        MsgBox("Faces swapped!", vbInformation + vbOKOnly, "Success")
    End Sub

    Sub GrayEverything()
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
        ImportFaceButton.Enabled = False
        ExportFaceButton.Enabled = False
        NewFaceButton.Enabled = False
        SwapFacesButton.Enabled = False
        DeleteFaceButton.Enabled = False
        NewFaceCB.Enabled = False
    End Sub

    Public Sub FreeEverything()
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
        ImportFaceButton.Enabled = True
        ExportFaceButton.Enabled = True
        NewFaceButton.Enabled = True
        SwapFacesButton.Enabled = True
        DeleteFaceButton.Enabled = True
        NewFaceCB.Enabled = True
    End Sub

    Public Sub ReloadFaces()
        FaceBox1.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.UFOFacesOrder(0), True)
        If KbbEditor.UFOFacesOrder(0) = &HFFFFFFFFUI Then
            FaceBox1.Enabled = False
        End If
        FaceBox2.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.UFOFacesOrder(1), True)
        If KbbEditor.UFOFacesOrder(1) = &HFFFFFFFFUI Then
            FaceBox2.Enabled = False
        End If
        FaceBox3.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.UFOFacesOrder(2), True)
        If KbbEditor.UFOFacesOrder(2) = &HFFFFFFFFUI Then
            FaceBox3.Enabled = False
        End If
        FaceBox4.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.UFOFacesOrder(3), True)
        If KbbEditor.UFOFacesOrder(3) = &HFFFFFFFFUI Then
            FaceBox4.Enabled = False
        End If
        FaceBox5.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.UFOFacesOrder(4), True)
        If KbbEditor.UFOFacesOrder(4) = &HFFFFFFFFUI Then
            FaceBox5.Enabled = False
        End If
        FaceBox6.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.UFOFacesOrder(5), True)
        If KbbEditor.UFOFacesOrder(5) = &HFFFFFFFFUI Then
            FaceBox6.Enabled = False
        End If
        FaceBox7.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.UFOFacesOrder(6), True)
        If KbbEditor.UFOFacesOrder(6) = &HFFFFFFFFUI Then
            FaceBox7.Enabled = False
        End If
        FaceBox8.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.UFOFacesOrder(7), True)
        If KbbEditor.UFOFacesOrder(7) = &HFFFFFFFFUI Then
            FaceBox8.Enabled = False
        End If
        FaceBox9.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.UFOFacesOrder(8), True)
        If KbbEditor.UFOFacesOrder(8) = &HFFFFFFFFUI Then
            FaceBox9.Enabled = False
        End If
        FaceBox10.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.UFOFacesOrder(9), True)
        If KbbEditor.UFOFacesOrder(9) = &HFFFFFFFFUI Then
            FaceBox10.Enabled = False
        End If
    End Sub

    Public Sub ChangeFaceImage()
        KbbEditor.SetFaceImage(SelectedFace, FaceToEdit, True)
        SelectedFaceBox.BackgroundImage = FaceToEdit
        ReloadFaces()
    End Sub

    Private Sub NewFaceCB_CheckedChanged(sender As Object, e As EventArgs) Handles NewFaceCB.CheckedChanged
        If NewFaceCB.Checked = True Then
            SelectedFaceProps.NewFace = True
        Else
            SelectedFaceProps.NewFace = False
        End If
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

    Private Sub ImportFaceButton_Click(sender As Object, e As EventArgs) Handles ImportFaceButton.Click
        GrayEverything()
        FaceToEdit = KbbEditor.GetFaceImage(SelectedFace, True)
        FaceEditor.ImportFaceButton.Enabled = False
        ImportFaceForm.IsUFO = True
        ImportFaceForm.Show()
    End Sub

    Private Sub ExportFaceButton_Click(sender As Object, e As EventArgs) Handles ExportFaceButton.Click
        If (SaveFileDialog1.ShowDialog() = DialogResult.OK) Then
            Dim ExportedFace As Image = KbbEditor.GetFaceImage(SelectedFace)
            ExportedFace.Save(SaveFileDialog1.FileName)
            ExportedFace.Dispose()
        End If
    End Sub

    Private Sub NewFaceButton_Click(sender As Object, e As EventArgs) Handles NewFaceButton.Click
        If KbbEditor.UFOFacesOrder(9) <> &HFFFFFFFFUI Then
            MsgBox("No slots are avaible for a new UFO crew face." & Chr(&HA) & "Try deleting or replacing another face.", vbInformation + vbOKOnly, "Error while creating new UFO crew face")
        Else
            NewUFOFace.Show()
        End If
    End Sub

    Private Sub SwapFacesButton_Click(sender As Object, e As EventArgs) Handles SwapFacesButton.Click
        If SwapMode = False Then
            SwapMode = True
            SwapFacesButton.Text = "Abort swap"
            Me.Text = "Select the other face to swap with."
            NewFaceCB.Enabled = False
            ImportFaceButton.Enabled = False
            ExportFaceButton.Enabled = False
            DeleteFaceButton.Enabled = False
        Else
            SwapMode = False
            SwapFacesButton.Text = "Swap faces"
            Me.Text = "UFO Crew"
            FreeEverything()
        End If
    End Sub

    Private Sub DeleteFaceButton_Click(sender As Object, e As EventArgs) Handles DeleteFaceButton.Click
        Dim Response = MsgBox("Are you sure to delete this face?", vbExclamation + vbYesNo, "Delete face")
        If Response = vbYes Then
            KbbEditor.DeleteFace(SelectedFace, True)
            SelectedFace = &HFFFFFFFFUI
            SelectedFaceBox.BackgroundImage = Nothing
            ImportFaceButton.Enabled = False
            ExportFaceButton.Enabled = False
            SwapFacesButton.Enabled = False
            DeleteFaceButton.Enabled = False
            FaceEditor.ReDrawUFOThumb()
            ReloadFaces()
        End If
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        SelectedFaceProps.CaptureDate = ConvertDate2Seconds(DateTimePicker1.Value)
    End Sub
End Class