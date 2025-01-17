Public Class Form1
    Dim FileOpened = False

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Application.EnableVisualStyles()
#If DEBUG Then
        Text = "KbbEdit [DEBUG]"
#End If
#If Not DEBUG Then
        MenuStrip1.Items.RemoveByKey("HexViewToolStripMenuItem")
#End If
    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
        InstructionsForm.Show()
    End Sub

    Private Sub LinksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LinksToolStripMenuItem.Click
        LinksForm.Show()
    End Sub

    Private Sub OpenFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenFileToolStripMenuItem.Click
        If FileOpened Then
            If MsgBox("Quit changes to currently open save?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "") <> MsgBoxResult.Yes Then
                Exit Sub
            End If
        End If

        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False

        If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
            Dim FilePath = FolderBrowserDialog1.SelectedPath & "\Kbb.dat"
            If My.Computer.FileSystem.FileExists(FilePath) = False Then
                MsgBox("Fatal error: Kbb.dat doesn't exist in this folder.", vbOKOnly + vbCritical, "Error while importing save file")
                Exit Sub
            End If
            Dim FileData As Byte() = My.Computer.FileSystem.ReadAllBytes(FilePath)
            If FileData.Length = 5520 Then
                KbbEditor.KbbSave = FileData
                If KbbEditor.Crc32.ComputeCRC32(KbbEditor.KbbSave, 0, &H1587) <> BitConverter.ToUInt32(KbbEditor.KbbSave, &H1588) Then
                    If MsgBox("The file's CRC32 is invalid. Recompute it?", vbYesNo + vbExclamation, "Error while importing save file") = vbYes Then
                        KbbEditor.KbbCRC = KbbEditor.Crc32.ComputeCRC32(KbbEditor.KbbSave, 0, &H1587)
                    End If
                End If
                KbbEditor.LoadSave()

                If KbbEditor.KbbSave.Length = 5520 Then
                    Button1.Enabled = True
                    Button2.Enabled = True
                    Button3.Enabled = True

                    FileOpened = True
                End If
            Else
                MsgBox("Your file is invalid! Make sure you selected the correct one.", vbOKOnly + vbCritical, "Error while importing save file")
            End If
        End If
    End Sub

    Private Sub NewSaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewSaveToolStripMenuItem.Click
        If FileOpened Then
            If MsgBox("Quit changes to currently open save?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "") <> MsgBoxResult.Yes Then
                Exit Sub
            End If
        End If

        KbbEditor.KbbSave = My.Resources.Kbbempty.Clone()
        KbbEditor.LoadSave()

        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True

        FileOpened = True
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        If FileOpened Then
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False

            KbbEditor.SaveData()

            MsgBox("Successfully saved!", vbOKOnly + vbInformation, "")

            Button1.Enabled = True
            Button2.Enabled = True
            Button3.Enabled = True
        Else
            MsgBox("Please open a save first!", vbOKOnly + vbExclamation, "Error while saving save file")
        End If
    End Sub

    Private Sub QuitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitToolStripMenuItem.Click
        If MsgBox("Unsaved changes will be lost.", vbYesNo + vbExclamation, "Before closing") = vbYes Then
            Close()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ScoreEditor.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FaceEditor.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MsgBox("Sorry... Not implemented yet!" & Chr(&HA) & "Make sure to check our GitHub repo or our Discord server for updates!", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Cannot use")
    End Sub

    Private Sub HexViewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HexViewToolStripMenuItem.Click
        If KbbEditor.Loaded = True Then
            HexViewForm.Show()
        End If
    End Sub
End Class
