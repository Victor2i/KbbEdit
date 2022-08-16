Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Application.EnableVisualStyles()
    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
        InstructionsForm.Show()
    End Sub

    Private Sub LinksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LinksToolStripMenuItem.Click
        LinksForm.Show()
    End Sub

    Private Sub OpenFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenFileToolStripMenuItem.Click
        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False

        If (FolderBrowserDialog1.ShowDialog() = DialogResult.OK) Then
            If My.Computer.FileSystem.ReadAllBytes(FolderBrowserDialog1.SelectedPath & "\Kbb.dat").Length = 5520 Then
                KbbEditor.KbbSave = My.Computer.FileSystem.ReadAllBytes(FolderBrowserDialog1.SelectedPath & "\Kbb.dat")
                If KbbEditor.Crc32.ComputeCRC32(KbbEditor.KbbSave, 0, &H1587) <> BitConverter.ToUInt32(KbbEditor.KbbSave, &H1588) Then
                    If MsgBox("The file's CRC32 is invalid. Recompute it?", vbYesNo + vbExclamation, "Error while importing save file") = vbYes Then
                        KbbEditor.KbbCRC = KbbEditor.Crc32.ComputeCRC32(KbbEditor.KbbSave, 0, &H1587)
                    End If
                End If
                KbbEditor.LoadSave()
            Else
                MsgBox("Your file is invalid! Make sure you selected the correct one.", vbOKOnly + vbCritical, "Error while importing save file")
            End If
        End If
        If KbbEditor.KbbSave.Length = 5520 Then
            Button1.Enabled = True
            Button2.Enabled = True
            Button3.Enabled = True
        End If
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False

        KbbEditor.SaveSave()

        MsgBox("Successfully saved!", vbOKOnly + vbInformation)

        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ScoreEditor.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("Sorry... Not implemented yet!" & Chr(&HA) & "Make sure to check our GitHub repo or our Discord server for updates!", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Cannot use")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MsgBox("Sorry... Not implemented yet!" & Chr(&HA) & "Make sure to check our GitHub repo or our Discord server for updates!", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Cannot use")
    End Sub
End Class
