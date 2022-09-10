Public Class ScoreEditorSelectFace
    Public FTCindex As Integer ' Face to change index.
    Dim FacePage As Integer

    Private Sub ScoreEditorSelectFace_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            If FTCindex = 1 Then
                KbbEditor.KbbScores(ScoreEditor.SelectedStage).Score1FID = KbbEditor.FacesOrder(-1 + 10 * FacePage)
                ScoreEditor.FacePicture1.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.FacesOrder(-1 + 10 * FacePage))
            ElseIf FTCindex = 2 Then
                KbbEditor.KbbScores(ScoreEditor.SelectedStage).Score2FID = KbbEditor.FacesOrder(-1 + 10 * FacePage)
                ScoreEditor.FacePicture2.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.FacesOrder(-1 + 10 * FacePage))
            ElseIf FTCindex = 3 Then
                KbbEditor.KbbScores(ScoreEditor.SelectedStage).Score3FID = KbbEditor.FacesOrder(-1 + 10 * FacePage)
                ScoreEditor.FacePicture3.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.FacesOrder(-1 + 10 * FacePage))
            ElseIf FTCindex = 4 Then
                KbbEditor.KbbScores(ScoreEditor.SelectedStage).Score4FID = KbbEditor.FacesOrder(-1 + 10 * FacePage)
                ScoreEditor.FacePicture4.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.FacesOrder(-1 + 10 * FacePage))
            ElseIf FTCindex = 5 Then
                KbbEditor.KbbScores(ScoreEditor.SelectedStage).Score5FID = KbbEditor.FacesOrder(-1 + 10 * FacePage)
                ScoreEditor.FacePicture5.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.FacesOrder(-1 + 10 * FacePage))
            End If
            Hide()
            ScoreEditor.UnlockEverything(True)
        Else
            ' At page 0 slot 1, the UFO is there, no reason to select it.
        End If
    End Sub

    Private Sub FaceBox2_Click(sender As Object, e As EventArgs) Handles FaceBox2.Click
        If FTCindex = 1 Then
            KbbEditor.KbbScores(ScoreEditor.SelectedStage).Score1FID = KbbEditor.FacesOrder(0 + 10 * FacePage)
            ScoreEditor.FacePicture1.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.FacesOrder(0 + 10 * FacePage))
        ElseIf FTCindex = 2 Then
            KbbEditor.KbbScores(ScoreEditor.SelectedStage).Score2FID = KbbEditor.FacesOrder(0 + 10 * FacePage)
            ScoreEditor.FacePicture2.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.FacesOrder(0 + 10 * FacePage))
        ElseIf FTCindex = 3 Then
            KbbEditor.KbbScores(ScoreEditor.SelectedStage).Score3FID = KbbEditor.FacesOrder(0 + 10 * FacePage)
            ScoreEditor.FacePicture3.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.FacesOrder(0 + 10 * FacePage))
        ElseIf FTCindex = 4 Then
            KbbEditor.KbbScores(ScoreEditor.SelectedStage).Score4FID = KbbEditor.FacesOrder(0 + 10 * FacePage)
            ScoreEditor.FacePicture4.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.FacesOrder(0 + 10 * FacePage))
        ElseIf FTCindex = 5 Then
            KbbEditor.KbbScores(ScoreEditor.SelectedStage).Score5FID = KbbEditor.FacesOrder(0 + 10 * FacePage)
            ScoreEditor.FacePicture5.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.FacesOrder(0 + 10 * FacePage))
        End If
        Hide()
        ScoreEditor.UnlockEverything(True)
    End Sub

    Private Sub FaceBox3_Click(sender As Object, e As EventArgs) Handles FaceBox3.Click
        If FTCindex = 1 Then
            KbbEditor.KbbScores(ScoreEditor.SelectedStage).Score1FID = KbbEditor.FacesOrder(1 + 10 * FacePage)
            ScoreEditor.FacePicture1.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.FacesOrder(1 + 10 * FacePage))
        ElseIf FTCindex = 2 Then
            KbbEditor.KbbScores(ScoreEditor.SelectedStage).Score2FID = KbbEditor.FacesOrder(1 + 10 * FacePage)
            ScoreEditor.FacePicture2.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.FacesOrder(1 + 10 * FacePage))
        ElseIf FTCindex = 3 Then
            KbbEditor.KbbScores(ScoreEditor.SelectedStage).Score3FID = KbbEditor.FacesOrder(1 + 10 * FacePage)
            ScoreEditor.FacePicture3.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.FacesOrder(1 + 10 * FacePage))
        ElseIf FTCindex = 4 Then
            KbbEditor.KbbScores(ScoreEditor.SelectedStage).Score4FID = KbbEditor.FacesOrder(1 + 10 * FacePage)
            ScoreEditor.FacePicture4.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.FacesOrder(1 + 10 * FacePage))
        ElseIf FTCindex = 5 Then
            KbbEditor.KbbScores(ScoreEditor.SelectedStage).Score5FID = KbbEditor.FacesOrder(1 + 10 * FacePage)
            ScoreEditor.FacePicture5.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.FacesOrder(1 + 10 * FacePage))
        End If
        Hide()
        ScoreEditor.UnlockEverything(True)
    End Sub

    Private Sub FaceBox4_Click(sender As Object, e As EventArgs) Handles FaceBox4.Click
        If FTCindex = 1 Then
            KbbEditor.KbbScores(ScoreEditor.SelectedStage).Score1FID = KbbEditor.FacesOrder(2 + 10 * FacePage)
            ScoreEditor.FacePicture1.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.FacesOrder(2 + 10 * FacePage))
        ElseIf FTCindex = 2 Then
            KbbEditor.KbbScores(ScoreEditor.SelectedStage).Score2FID = KbbEditor.FacesOrder(2 + 10 * FacePage)
            ScoreEditor.FacePicture2.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.FacesOrder(2 + 10 * FacePage))
        ElseIf FTCindex = 3 Then
            KbbEditor.KbbScores(ScoreEditor.SelectedStage).Score3FID = KbbEditor.FacesOrder(2 + 10 * FacePage)
            ScoreEditor.FacePicture3.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.FacesOrder(2 + 10 * FacePage))
        ElseIf FTCindex = 4 Then
            KbbEditor.KbbScores(ScoreEditor.SelectedStage).Score4FID = KbbEditor.FacesOrder(2 + 10 * FacePage)
            ScoreEditor.FacePicture4.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.FacesOrder(2 + 10 * FacePage))
        ElseIf FTCindex = 5 Then
            KbbEditor.KbbScores(ScoreEditor.SelectedStage).Score5FID = KbbEditor.FacesOrder(2 + 10 * FacePage)
            ScoreEditor.FacePicture5.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.FacesOrder(2 + 10 * FacePage))
        End If
        Hide()
        ScoreEditor.UnlockEverything(True)
    End Sub

    Private Sub FaceBox5_Click(sender As Object, e As EventArgs) Handles FaceBox5.Click
        If FTCindex = 1 Then
            KbbEditor.KbbScores(ScoreEditor.SelectedStage).Score1FID = KbbEditor.FacesOrder(3 + 10 * FacePage)
            ScoreEditor.FacePicture1.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.FacesOrder(3 + 10 * FacePage))
        ElseIf FTCindex = 2 Then
            KbbEditor.KbbScores(ScoreEditor.SelectedStage).Score2FID = KbbEditor.FacesOrder(3 + 10 * FacePage)
            ScoreEditor.FacePicture2.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.FacesOrder(3 + 10 * FacePage))
        ElseIf FTCindex = 3 Then
            KbbEditor.KbbScores(ScoreEditor.SelectedStage).Score3FID = KbbEditor.FacesOrder(3 + 10 * FacePage)
            ScoreEditor.FacePicture3.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.FacesOrder(3 + 10 * FacePage))
        ElseIf FTCindex = 4 Then
            KbbEditor.KbbScores(ScoreEditor.SelectedStage).Score4FID = KbbEditor.FacesOrder(3 + 10 * FacePage)
            ScoreEditor.FacePicture4.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.FacesOrder(3 + 10 * FacePage))
        ElseIf FTCindex = 5 Then
            KbbEditor.KbbScores(ScoreEditor.SelectedStage).Score5FID = KbbEditor.FacesOrder(3 + 10 * FacePage)
            ScoreEditor.FacePicture5.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.FacesOrder(3 + 10 * FacePage))
        End If
        Hide()
        ScoreEditor.UnlockEverything(True)
    End Sub

    Private Sub FaceBox6_Click(sender As Object, e As EventArgs) Handles FaceBox6.Click
        If FTCindex = 1 Then
            KbbEditor.KbbScores(ScoreEditor.SelectedStage).Score1FID = KbbEditor.FacesOrder(4 + 10 * FacePage)
            ScoreEditor.FacePicture1.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.FacesOrder(4 + 10 * FacePage))
        ElseIf FTCindex = 2 Then
            KbbEditor.KbbScores(ScoreEditor.SelectedStage).Score2FID = KbbEditor.FacesOrder(4 + 10 * FacePage)
            ScoreEditor.FacePicture2.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.FacesOrder(4 + 10 * FacePage))
        ElseIf FTCindex = 3 Then
            KbbEditor.KbbScores(ScoreEditor.SelectedStage).Score3FID = KbbEditor.FacesOrder(4 + 10 * FacePage)
            ScoreEditor.FacePicture3.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.FacesOrder(4 + 10 * FacePage))
        ElseIf FTCindex = 4 Then
            KbbEditor.KbbScores(ScoreEditor.SelectedStage).Score4FID = KbbEditor.FacesOrder(4 + 10 * FacePage)
            ScoreEditor.FacePicture4.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.FacesOrder(4 + 10 * FacePage))
        ElseIf FTCindex = 5 Then
            KbbEditor.KbbScores(ScoreEditor.SelectedStage).Score5FID = KbbEditor.FacesOrder(4 + 10 * FacePage)
            ScoreEditor.FacePicture5.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.FacesOrder(4 + 10 * FacePage))
        End If
        Hide()
        ScoreEditor.UnlockEverything(True)
    End Sub

    Private Sub FaceBox7_Click(sender As Object, e As EventArgs) Handles FaceBox7.Click
        If FTCindex = 1 Then
            KbbEditor.KbbScores(ScoreEditor.SelectedStage).Score1FID = KbbEditor.FacesOrder(5 + 10 * FacePage)
            ScoreEditor.FacePicture1.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.FacesOrder(5 + 10 * FacePage))
        ElseIf FTCindex = 2 Then
            KbbEditor.KbbScores(ScoreEditor.SelectedStage).Score2FID = KbbEditor.FacesOrder(5 + 10 * FacePage)
            ScoreEditor.FacePicture2.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.FacesOrder(5 + 10 * FacePage))
        ElseIf FTCindex = 3 Then
            KbbEditor.KbbScores(ScoreEditor.SelectedStage).Score3FID = KbbEditor.FacesOrder(5 + 10 * FacePage)
            ScoreEditor.FacePicture3.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.FacesOrder(5 + 10 * FacePage))
        ElseIf FTCindex = 4 Then
            KbbEditor.KbbScores(ScoreEditor.SelectedStage).Score4FID = KbbEditor.FacesOrder(5 + 10 * FacePage)
            ScoreEditor.FacePicture4.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.FacesOrder(5 + 10 * FacePage))
        ElseIf FTCindex = 5 Then
            KbbEditor.KbbScores(ScoreEditor.SelectedStage).Score5FID = KbbEditor.FacesOrder(5 + 10 * FacePage)
            ScoreEditor.FacePicture5.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.FacesOrder(5 + 10 * FacePage))
        End If
        Hide()
        ScoreEditor.UnlockEverything(True)
    End Sub

    Private Sub FaceBox8_Click(sender As Object, e As EventArgs) Handles FaceBox8.Click
        If FTCindex = 1 Then
            KbbEditor.KbbScores(ScoreEditor.SelectedStage).Score1FID = KbbEditor.FacesOrder(6 + 10 * FacePage)
            ScoreEditor.FacePicture1.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.FacesOrder(6 + 10 * FacePage))
        ElseIf FTCindex = 2 Then
            KbbEditor.KbbScores(ScoreEditor.SelectedStage).Score2FID = KbbEditor.FacesOrder(6 + 10 * FacePage)
            ScoreEditor.FacePicture2.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.FacesOrder(6 + 10 * FacePage))
        ElseIf FTCindex = 3 Then
            KbbEditor.KbbScores(ScoreEditor.SelectedStage).Score3FID = KbbEditor.FacesOrder(6 + 10 * FacePage)
            ScoreEditor.FacePicture3.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.FacesOrder(6 + 10 * FacePage))
        ElseIf FTCindex = 4 Then
            KbbEditor.KbbScores(ScoreEditor.SelectedStage).Score4FID = KbbEditor.FacesOrder(6 + 10 * FacePage)
            ScoreEditor.FacePicture4.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.FacesOrder(6 + 10 * FacePage))
        ElseIf FTCindex = 5 Then
            KbbEditor.KbbScores(ScoreEditor.SelectedStage).Score5FID = KbbEditor.FacesOrder(6 + 10 * FacePage)
            ScoreEditor.FacePicture5.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.FacesOrder(6 + 10 * FacePage))
        End If
        Hide()
        ScoreEditor.UnlockEverything(True)
    End Sub

    Private Sub FaceBox9_Click(sender As Object, e As EventArgs) Handles FaceBox9.Click
        If FTCindex = 1 Then
            KbbEditor.KbbScores(ScoreEditor.SelectedStage).Score1FID = KbbEditor.FacesOrder(7 + 10 * FacePage)
            ScoreEditor.FacePicture1.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.FacesOrder(7 + 10 * FacePage))
        ElseIf FTCindex = 2 Then
            KbbEditor.KbbScores(ScoreEditor.SelectedStage).Score2FID = KbbEditor.FacesOrder(7 + 10 * FacePage)
            ScoreEditor.FacePicture2.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.FacesOrder(7 + 10 * FacePage))
        ElseIf FTCindex = 3 Then
            KbbEditor.KbbScores(ScoreEditor.SelectedStage).Score3FID = KbbEditor.FacesOrder(7 + 10 * FacePage)
            ScoreEditor.FacePicture3.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.FacesOrder(7 + 10 * FacePage))
        ElseIf FTCindex = 4 Then
            KbbEditor.KbbScores(ScoreEditor.SelectedStage).Score4FID = KbbEditor.FacesOrder(7 + 10 * FacePage)
            ScoreEditor.FacePicture4.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.FacesOrder(7 + 10 * FacePage))
        ElseIf FTCindex = 5 Then
            KbbEditor.KbbScores(ScoreEditor.SelectedStage).Score5FID = KbbEditor.FacesOrder(7 + 10 * FacePage)
            ScoreEditor.FacePicture5.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.FacesOrder(7 + 10 * FacePage))
        End If
        Hide()
        ScoreEditor.UnlockEverything(True)
    End Sub

    Private Sub FaceBox10_Click(sender As Object, e As EventArgs) Handles FaceBox10.Click
        If FTCindex = 1 Then
            KbbEditor.KbbScores(ScoreEditor.SelectedStage).Score1FID = KbbEditor.FacesOrder(8 + 10 * FacePage)
            ScoreEditor.FacePicture1.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.FacesOrder(8 + 10 * FacePage))
        ElseIf FTCindex = 2 Then
            KbbEditor.KbbScores(ScoreEditor.SelectedStage).Score2FID = KbbEditor.FacesOrder(8 + 10 * FacePage)
            ScoreEditor.FacePicture2.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.FacesOrder(8 + 10 * FacePage))
        ElseIf FTCindex = 3 Then
            KbbEditor.KbbScores(ScoreEditor.SelectedStage).Score3FID = KbbEditor.FacesOrder(8 + 10 * FacePage)
            ScoreEditor.FacePicture3.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.FacesOrder(8 + 10 * FacePage))
        ElseIf FTCindex = 4 Then
            KbbEditor.KbbScores(ScoreEditor.SelectedStage).Score4FID = KbbEditor.FacesOrder(8 + 10 * FacePage)
            ScoreEditor.FacePicture4.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.FacesOrder(8 + 10 * FacePage))
        ElseIf FTCindex = 5 Then
            KbbEditor.KbbScores(ScoreEditor.SelectedStage).Score5FID = KbbEditor.FacesOrder(8 + 10 * FacePage)
            ScoreEditor.FacePicture5.BackgroundImage = KbbEditor.GetFaceImage(KbbEditor.FacesOrder(8 + 10 * FacePage))
        End If
        Hide()
        ScoreEditor.UnlockEverything(True)
    End Sub

    Private Sub AbortButton_Click(sender As Object, e As EventArgs) Handles AbortButton.Click
        Hide()
        ScoreEditor.UnlockEverything(True)
    End Sub
End Class