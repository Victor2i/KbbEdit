Public Class ScoreEditor
    ReadOnly Stage1 As Int32 = 0
    ReadOnly Stage2 As Int32 = 1
    ReadOnly Stage3 As Int32 = 2
    ReadOnly Stage4 As Int32 = 3
    ReadOnly BonusStage As Int32 = 4
    ReadOnly ExtraStage As Int32 = 5
    ReadOnly SAFStage1 As Int32 = 6
    ReadOnly SAFStage2 As Int32 = 7
    ReadOnly SAFBonusStage As Int32 = 8
    ReadOnly InitStage As Int32 = 9

    Public SelectedStage = -1

    ReadOnly StageLockStates = {
        2,
        KbbEditor.KbbSaveInfo.Stage2Unlocked,
        KbbEditor.KbbSaveInfo.Stage3Unlocked,
        KbbEditor.KbbSaveInfo.Stage4Unlocked,
        KbbEditor.KbbSaveInfo.BonusStageUnlocked,
        KbbEditor.KbbSaveInfo.ExtraStageUnlocked,
        KbbEditor.KbbSaveInfo.SAFStage1Unlocked,
        KbbEditor.KbbSaveInfo.SAFStage2Unlocked,
        KbbEditor.KbbSaveInfo.SAFBonusStageUnlocked,
        2
    }

    ReadOnly StageOtherLockStates = {
        KbbEditor.KbbSaveInfo.Stage1UnlockAnim,
        KbbEditor.KbbSaveInfo.Stage2UnlockAnim,
        KbbEditor.KbbSaveInfo.Stage3UnlockAnim,
        KbbEditor.KbbSaveInfo.Stage4UnlockAnim,
        KbbEditor.KbbSaveInfo.BonusStageUnlockAnim,
        KbbEditor.KbbSaveInfo.ExtraStageUnlockAnim,
        KbbEditor.KbbSaveInfo.SAFStage1UnlockAnim,
        KbbEditor.KbbSaveInfo.SAFStage2UnlockAnim,
        KbbEditor.KbbSaveInfo.SAFBonusStageUnlockAnim,
        2
    }

    Private Sub LoadScoreData(Stage)
        SelectedStage = Stage
        MaxComboBox.Text = KbbEditor.KbbScores(Stage).BestCombo
        ScoreBox1.Text = KbbEditor.KbbScores(Stage).Score1
        ScoreBox2.Text = KbbEditor.KbbScores(Stage).Score2
        ScoreBox3.Text = KbbEditor.KbbScores(Stage).Score3
        ScoreBox4.Text = KbbEditor.KbbScores(Stage).Score4
        ScoreBox5.Text = KbbEditor.KbbScores(Stage).Score5
        If KbbEditor.KbbScores(Stage).Score1FID <> &HFFFFFFFFUI Then
            FacePicture1.Image = My.Resources.FaceHole
            FacePicture1.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.KbbScores(Stage).Score1FID)
        Else
            FacePicture1.Image = My.Resources.NoFace
        End If
        If KbbEditor.KbbScores(Stage).Score2FID <> &HFFFFFFFFUI Then
            FacePicture2.Image = My.Resources.FaceHole
            FacePicture2.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.KbbScores(Stage).Score2FID)
        Else
            FacePicture2.Image = My.Resources.NoFace
        End If
        If KbbEditor.KbbScores(Stage).Score3FID <> &HFFFFFFFFUI Then
            FacePicture3.Image = My.Resources.FaceHole
            FacePicture3.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.KbbScores(Stage).Score3FID)
        Else
            FacePicture3.Image = My.Resources.NoFace
        End If
        If KbbEditor.KbbScores(Stage).Score4FID <> &HFFFFFFFFUI Then
            FacePicture4.Image = My.Resources.FaceHole
            FacePicture4.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.KbbScores(Stage).Score4FID)
        Else
            FacePicture4.Image = My.Resources.NoFace
        End If
        If KbbEditor.KbbScores(Stage).Score5FID <> &HFFFFFFFFUI Then
            FacePicture5.Image = My.Resources.FaceHole
            FacePicture5.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.KbbScores(Stage).Score5FID)
        Else
            FacePicture5.Image = My.Resources.NoFace
        End If
        If Stage = Stage1 Then
            LevelLockCheckBox.Checked = CheckState.Checked
            LevelLockCheckBox.Enabled = False
            LevelAnimCheckBox.Checked = StageOtherLockStates(Stage)
            LevelAnimCheckBox.Enabled = True
        ElseIf Stage = InitStage Then
            LevelLockCheckBox.Checked = CheckState.Checked
            LevelLockCheckBox.Enabled = False
            LevelAnimCheckBox.Checked = CheckState.Indeterminate
            LevelAnimCheckBox.Enabled = False
        Else
            LevelLockCheckBox.Checked = StageLockStates(Stage)
            LevelLockCheckBox.Enabled = True
            LevelAnimCheckBox.Checked = StageOtherLockStates(Stage)
            LevelAnimCheckBox.Enabled = True
        End If
        LevelAnimCheckBox.Checked = StageOtherLockStates(Stage)
        LevelWinCheckBox.Checked = KbbEditor.KbbScores(Stage).StageBeaten
    End Sub

    Private Sub ScoreEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FacePicture1.Image = My.Resources.NoFace
        FacePicture2.Image = My.Resources.NoFace
        FacePicture3.Image = My.Resources.NoFace
        FacePicture4.Image = My.Resources.NoFace
        FacePicture5.Image = My.Resources.NoFace
    End Sub

    Private Sub GrayAllButtons()
        Stage1Button.BackgroundImage = My.Resources.Stage1
        Stage2Button.BackgroundImage = My.Resources.Stage2
        Stage3Button.BackgroundImage = My.Resources.Stage3
        Stage4Button.BackgroundImage = My.Resources.Stage4
        BonusStageButton.BackgroundImage = My.Resources.BonusStage
        ExtraStageButton.BackgroundImage = My.Resources.ExtraStage
        SAFStage1Button.BackgroundImage = My.Resources.Stage1
        SAFStage2Button.BackgroundImage = My.Resources.OtherStage
        SAFBonusStageButton.BackgroundImage = My.Resources.BonusStage
    End Sub

    Public Sub UnlockEverything(EnableOption As Boolean)
        Stage1Button.Enabled = EnableOption
        Stage2Button.Enabled = EnableOption
        Stage3Button.Enabled = EnableOption
        Stage4Button.Enabled = EnableOption
        BonusStageButton.Enabled = EnableOption
        ExtraStageButton.Enabled = EnableOption
        SAFStage1Button.Enabled = EnableOption
        SAFStage2Button.Enabled = EnableOption
        SAFBonusStageButton.Enabled = EnableOption
        FacePicture1.Enabled = EnableOption
        FacePicture2.Enabled = EnableOption
        FacePicture3.Enabled = EnableOption
        FacePicture4.Enabled = EnableOption
        FacePicture5.Enabled = EnableOption
        ScoreBox1.Enabled = EnableOption
        ScoreBox2.Enabled = EnableOption
        ScoreBox3.Enabled = EnableOption
        ScoreBox4.Enabled = EnableOption
        ScoreBox5.Enabled = EnableOption
        LevelLockCheckBox.Enabled = EnableOption
    End Sub

    Private Sub Stage1Button_Click(sender As Object, e As EventArgs) Handles Stage1Button.Click
        LoadScoreData(Stage1)
        GrayAllButtons()
        Stage1Button.BackgroundImage = My.Resources.Stage1Select
    End Sub

    Private Sub Stage2Button_Click(sender As Object, e As EventArgs) Handles Stage2Button.Click
        LoadScoreData(Stage2)
        GrayAllButtons()
        Stage2Button.BackgroundImage = My.Resources.Stage2Select
    End Sub

    Private Sub Stage3Button_Click(sender As Object, e As EventArgs) Handles Stage3Button.Click
        LoadScoreData(Stage3)
        GrayAllButtons()
        Stage3Button.BackgroundImage = My.Resources.Stage3Select
    End Sub

    Private Sub Stage4Button_Click(sender As Object, e As EventArgs) Handles Stage4Button.Click
        LoadScoreData(Stage4)
        GrayAllButtons()
        Stage4Button.BackgroundImage = My.Resources.Stage4Select
    End Sub

    Private Sub BonusStageButton_Click(sender As Object, e As EventArgs) Handles BonusStageButton.Click
        LoadScoreData(BonusStage)
        GrayAllButtons()
        BonusStageButton.BackgroundImage = My.Resources.BonusStageSelect
    End Sub

    Private Sub ExtraStageButton_Click(sender As Object, e As EventArgs) Handles ExtraStageButton.Click
        LoadScoreData(ExtraStage)
        GrayAllButtons()
        ExtraStageButton.BackgroundImage = My.Resources.ExtraStageSelect
    End Sub

    Private Sub SAFStage1Button_Click(sender As Object, e As EventArgs) Handles SAFStage1Button.Click
        LoadScoreData(SAFStage1)
        GrayAllButtons()
        SAFStage1Button.BackgroundImage = My.Resources.Stage1Select
    End Sub

    Private Sub SAFStage2Button_Click(sender As Object, e As EventArgs) Handles SAFStage2Button.Click
        LoadScoreData(SAFStage2)
        GrayAllButtons()
        SAFStage2Button.BackgroundImage = My.Resources.OtherStageSelect
    End Sub

    Private Sub SAFBonusStageButton_Click(sender As Object, e As EventArgs) Handles SAFBonusStageButton.Click
        LoadScoreData(SAFBonusStage)
        GrayAllButtons()
        SAFBonusStageButton.BackgroundImage = My.Resources.BonusStageSelect
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LoadScoreData(InitStage)
        GrayAllButtons()
    End Sub

    Private Sub LevelWinCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles LevelWinCheckBox.CheckedChanged
        If LevelWinCheckBox.Checked = False Then
            KbbEditor.KbbScores(SelectedStage).StageBeaten = False
        Else
            KbbEditor.KbbScores(SelectedStage).StageBeaten = True
        End If
    End Sub

    Private Sub LevelLockCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles LevelLockCheckBox.CheckedChanged
        If LevelLockCheckBox.Checked = False Then
            StageLockStates(SelectedStage) = False
        Else
            StageLockStates(SelectedStage) = True
        End If
    End Sub

    Private Sub LevelAnimCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles LevelAnimCheckBox.CheckedChanged
        If LevelLockCheckBox.Checked = False Then
            StageOtherLockStates(SelectedStage) = False
        Else
            StageOtherLockStates(SelectedStage) = True
        End If
    End Sub

    Private Sub ScoreBox1_ValueChanged(sender As Object, e As EventArgs) Handles ScoreBox1.ValueChanged
        KbbEditor.KbbScores(SelectedStage).Score1 = ScoreBox1.Value
    End Sub

    Private Sub ScoreBox2_ValueChanged(sender As Object, e As EventArgs) Handles ScoreBox2.ValueChanged
        KbbEditor.KbbScores(SelectedStage).Score2 = ScoreBox2.Value
    End Sub

    Private Sub ScoreBox3_ValueChanged(sender As Object, e As EventArgs) Handles ScoreBox3.ValueChanged
        KbbEditor.KbbScores(SelectedStage).Score3 = ScoreBox3.Value
    End Sub

    Private Sub ScoreBox4_ValueChanged(sender As Object, e As EventArgs) Handles ScoreBox4.ValueChanged
        KbbEditor.KbbScores(SelectedStage).Score4 = ScoreBox4.Value
    End Sub

    Private Sub ScoreBox5_ValueChanged(sender As Object, e As EventArgs) Handles ScoreBox5.ValueChanged
        KbbEditor.KbbScores(SelectedStage).Score5 = ScoreBox5.Value
    End Sub

    Private Sub BestComboBox_ValueChanged(sender As Object, e As EventArgs) Handles MaxComboBox.ValueChanged
        KbbEditor.KbbScores(SelectedStage).BestCombo = MaxComboBox.Value
    End Sub

    Private Sub FacePicture1_Click(sender As Object, e As EventArgs) Handles FacePicture1.Click
        UnlockEverything(False)
        ScoreEditorSelectFace.FTCindex = 1
        ScoreEditorSelectFace.Show()
    End Sub

    Private Sub FacePicture2_Click(sender As Object, e As EventArgs) Handles FacePicture2.Click
        UnlockEverything(False)
        ScoreEditorSelectFace.FTCindex = 2
        ScoreEditorSelectFace.Show()
    End Sub

    Private Sub FacePicture3_Click(sender As Object, e As EventArgs) Handles FacePicture3.Click
        UnlockEverything(False)
        ScoreEditorSelectFace.FTCindex = 3
        ScoreEditorSelectFace.Show()
    End Sub

    Private Sub FacePicture4_Click(sender As Object, e As EventArgs) Handles FacePicture4.Click
        UnlockEverything(False)
        ScoreEditorSelectFace.FTCindex = 4
        ScoreEditorSelectFace.Show()
    End Sub

    Private Sub FacePicture5_Click(sender As Object, e As EventArgs) Handles FacePicture5.Click
        UnlockEverything(False)
        ScoreEditorSelectFace.FTCindex = 5
        ScoreEditorSelectFace.Show()
    End Sub

    Private Sub ScoreEditor_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        KbbEditor.KbbSaveInfo.Stage2Unlocked = StageLockStates(1)
        KbbEditor.KbbSaveInfo.Stage3Unlocked = StageLockStates(2)
        KbbEditor.KbbSaveInfo.Stage4Unlocked = StageLockStates(3)
        KbbEditor.KbbSaveInfo.BonusStageUnlocked = StageLockStates(4)
        KbbEditor.KbbSaveInfo.ExtraStageUnlocked = StageLockStates(5)
        KbbEditor.KbbSaveInfo.SAFStage1Unlocked = StageLockStates(6)
        KbbEditor.KbbSaveInfo.SAFStage2Unlocked = StageLockStates(7)
        KbbEditor.KbbSaveInfo.SAFBonusStageUnlocked = StageLockStates(8)
        KbbEditor.KbbSaveInfo.Stage1UnlockAnim = StageOtherLockStates(0)
        KbbEditor.KbbSaveInfo.Stage2UnlockAnim = StageOtherLockStates(1)
        KbbEditor.KbbSaveInfo.Stage3UnlockAnim = StageOtherLockStates(2)
        KbbEditor.KbbSaveInfo.Stage4UnlockAnim = StageOtherLockStates(3)
        KbbEditor.KbbSaveInfo.BonusStageUnlockAnim = StageOtherLockStates(4)
        KbbEditor.KbbSaveInfo.ExtraStageUnlockAnim = StageOtherLockStates(5)
        KbbEditor.KbbSaveInfo.SAFStage1UnlockAnim = StageOtherLockStates(6)
        KbbEditor.KbbSaveInfo.SAFStage2UnlockAnim = StageOtherLockStates(7)
        KbbEditor.KbbSaveInfo.SAFBonusStageUnlockAnim = StageOtherLockStates(8)
    End Sub
End Class