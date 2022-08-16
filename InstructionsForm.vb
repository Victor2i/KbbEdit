Public Class InstructionsForm
    Dim Index = -1

    Private Sub InstructionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Index = 0
        PictureBox1.Image = InstructionImages(Index)
        HelpLabel.Text = InstructionStrings(Index)
    End Sub

    Dim InstructionImages = {
        My.Resources.Ins0,
        My.Resources.Ins1,
        My.Resources.Ins2,
        My.Resources.Ins3,
        My.Resources.Ins4,
        My.Resources.Ins5,
        My.Resources.Ins6,
        My.Resources.Ins7,
        My.Resources.Ins8,
        My.Resources.Ins9,
        My.Resources.Ins10,
        My.Resources.Ins11,
        My.Resources.Ins0,
        My.Resources.Ins0,
        My.Resources.Ins12,
        My.Resources.Ins13
    }

    Dim InstructionStrings = {
        My.Resources.String1,
        My.Resources.String2,
        My.Resources.String3,
        My.Resources.String4,
        My.Resources.String5,
        My.Resources.String6,
        My.Resources.String7,
        My.Resources.String8,
        My.Resources.String9,
        My.Resources.String10,
        My.Resources.String11,
        My.Resources.String12,
        My.Resources.String13,
        My.Resources.String14,
        My.Resources.String15,
        My.Resources.String16
    }

    Private Sub PrevButton_Click(sender As Object, e As EventArgs) Handles PrevButton.Click
        Index -= 1
        If Index = 0 Then
            PrevButton.Enabled = False
        End If
        If Index = 14 Then
            NextButton.Enabled = True
        End If
        PictureBox1.Image = InstructionImages(Index)
        HelpLabel.Text = InstructionStrings(Index)
    End Sub

    Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles NextButton.Click
        Index += 1
        If Index = 1 Then
            PrevButton.Enabled = True
        End If
        If Index = 15 Then
            NextButton.Enabled = False
        End If
        PictureBox1.Image = InstructionImages(Index)
        HelpLabel.Text = InstructionStrings(Index)
    End Sub
End Class