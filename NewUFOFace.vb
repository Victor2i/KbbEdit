﻿Imports System.Drawing.Drawing2D
Imports System.IO

Public Class NewUFOFace
    Dim BackBuffer As New Bitmap(128, 128)
    Public IsUFO As Boolean = False
    Dim SelectedImage As Image
    Dim ImageInterpolationMode As Integer
    Dim ImageMatrix As New Matrix()
    Dim IsMouseDown As Boolean = False
    Dim MousePoint As Point

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

        ' End draw

        PictureBox1.BackgroundImage = BackBuffer
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

        KbbEditor.NewUFOFace(BackBuffer)

        UFOEditor.ReloadFaces()
        Close()
    End Sub
End Class