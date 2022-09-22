Public Class UFOEditor
    Dim SelectedFace As UInteger = &HFFFFFFFFUI
    Dim SelectedFaceProps As KbbEditor.KbbImportedFaceInfo
    Dim SwappedFaceImage As Bitmap
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

    Sub LoadSelectedFaceProps()
        SelectedFaceBox.BackgroundImage = KbbEditor.GetFaceImage(SelectedFace)
        SelectedFaceProps = KbbEditor.GetUFOFaceProps(SelectedFace)
        NewFaceCB.Checked = SelectedFaceProps.NewFace
        NewFaceCB.Enabled = True
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
        Dim SwappedFaceProps As KbbEditor.KbbImportedFaceInfo
        SwappedFaceProps = KbbEditor.GetUFOFaceProps(OtherFace)
        SwappedFaceImage = KbbEditor.GetFaceImage(OtherFace)
        KbbEditor.SetUFOFaceProps(FirstFace, SwappedFaceProps)
        KbbEditor.SetUFOFaceProps(OtherFace, SelectedFaceProps)
        KbbEditor.SetFaceImage(OtherFace, KbbEditor.GetFaceImage(FirstFace))
        KbbEditor.SetFaceImage(FirstFace, SwappedFaceImage)
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
        FaceBox1.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.UFOFacesOrder(0))
        If KbbEditor.UFOFacesOrder(0) = &HFFFFFFFFUI Then
            FaceBox1.Enabled = False
        End If
        FaceBox2.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.UFOFacesOrder(1))
        If KbbEditor.UFOFacesOrder(1) = &HFFFFFFFFUI Then
            FaceBox2.Enabled = False
        End If
        FaceBox3.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.UFOFacesOrder(2))
        If KbbEditor.UFOFacesOrder(2) = &HFFFFFFFFUI Then
            FaceBox3.Enabled = False
        End If
        FaceBox4.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.UFOFacesOrder(3))
        If KbbEditor.UFOFacesOrder(3) = &HFFFFFFFFUI Then
            FaceBox4.Enabled = False
        End If
        FaceBox5.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.UFOFacesOrder(4))
        If KbbEditor.UFOFacesOrder(4) = &HFFFFFFFFUI Then
            FaceBox5.Enabled = False
        End If
        FaceBox6.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.UFOFacesOrder(5))
        If KbbEditor.UFOFacesOrder(5) = &HFFFFFFFFUI Then
            FaceBox6.Enabled = False
        End If
        FaceBox7.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.UFOFacesOrder(6))
        If KbbEditor.UFOFacesOrder(6) = &HFFFFFFFFUI Then
            FaceBox7.Enabled = False
        End If
        FaceBox8.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.UFOFacesOrder(7))
        If KbbEditor.UFOFacesOrder(7) = &HFFFFFFFFUI Then
            FaceBox8.Enabled = False
        End If
        FaceBox9.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.UFOFacesOrder(8))
        If KbbEditor.UFOFacesOrder(8) = &HFFFFFFFFUI Then
            FaceBox9.Enabled = False
        End If
        FaceBox10.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.UFOFacesOrder(9))
        If KbbEditor.UFOFacesOrder(9) = &HFFFFFFFFUI Then
            FaceBox10.Enabled = False
        End If
    End Sub

    Public Sub ChangeFaceImage()
        KbbEditor.SetFaceImage(SelectedFace, FaceToEdit)
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

    Private Sub ImportFaceButton_Click(sender As Object, e As EventArgs) Handles ImportFaceButton.Click
        GrayEverything()
        FaceToEdit = KbbEditor.GetFaceImage(SelectedFace)
        FaceEditor.ImportFaceButton.Enabled = False
        ImportFaceForm.IsUFO = True
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
            KbbEditor.DeleteFace(SelectedFace)
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
End Class