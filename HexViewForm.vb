Public Class HexViewForm
    Dim OpenedFile As Byte()
    Dim OpenedFileID As Integer
    Dim SelectedByte As Integer = -1
    Dim SecondByte As Boolean = False
    Dim SelectedImage As Bitmap

    Dim ByteOrderLUT = {
        0, 1, 8, 9, 2, 3, 10, 11,
        16, 17, 24, 25, 18, 19, 26, 27,
        4, 5, 12, 13, 6, 7, 14, 15,
        20, 21, 28, 29, 22, 23, 30, 31,
        32, 33, 40, 41, 34, 35, 42, 43,
        48, 49, 56, 57, 50, 51, 58, 59,
        36, 37, 44, 45, 38, 39, 46, 47,
        52, 53, 60, 61, 54, 55, 62, 63
    }

    Private Sub HexViewForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OpenedFile = KbbEditor.KbbSave
        OpenedFileID = 0
    End Sub

    Private Sub UpdatePictureBox()
        If PictureBox1.Width = 0 Or PictureBox1.Height = 0 Then
            Exit Sub
        End If

        Dim BackBuffer As New Bitmap(PictureBox1.Width, PictureBox1.Height)
        Dim g As Graphics
        g = Graphics.FromImage(BackBuffer)
        g.Clear(Color.White)
        Dim CFont As New Font(Font.FontFamily, 12.0!, FontStyle.Bold)

        Dim MyBrush As New SolidBrush(Color.Teal)
        For i = 0 To CInt((PictureBox1.Height - 8) / 16)
            Dim ao As UInt32 = (VScrollBar1.Value + i) * 16
            Dim BytesToDraw As Integer = 16
            If ao + 16 > OpenedFile.Length Then
                BytesToDraw = OpenedFile.Length - ao
            End If
            If ao < OpenedFile.Length Then
                g.DrawString(ao.ToString("X4"), CFont, MyBrush, New PointF(4, 4 + 16 * i))
            End If
            For j = 0 To BytesToDraw - 1
                Dim BIQ As Byte = OpenedFile(ao + j)
                Dim BIQ_N As Integer = ao + j

                Select Case OpenedFileID
                    Case 0
                        Select Case BIQ_N
                            Case 0 To &HC3F
                                Dim SlotNum As Integer = BIQ_N >> 6
                                ' idk what to do
                        End Select
                    Case 1 To 59
                        Dim Brush_B As New SolidBrush(Color.Black)
                        g.DrawImage(SelectedImage, New Point(500, 4))
                        g.DrawString("Header: " + Hex(BitConverter.ToUInt32(OpenedFile, 0)), Font, Brush_B, New Point(500, 132))
                        g.DrawString("CRC32: " + Hex(BitConverter.ToUInt32(OpenedFile, &H8004)), Font, Brush_B, New Point(500, 144))
                        Select Case SelectedByte
                            Case &H4 To &H8003
                                Dim BIQ1 As Byte = OpenedFile(SelectedByte - (SelectedByte Mod 2))
                                Dim BIQ2 As Byte = OpenedFile(SelectedByte - (SelectedByte Mod 2) + 1)

                                Dim PixelData As UInt16 = 0
                                PixelData += BIQ1
                                PixelData += BIQ2 * 256

                                Dim Blue = (PixelData And &H1F) * 8
                                Dim Green = ((PixelData >> 5) And &H3F) * 4
                                Dim Red = ((PixelData >> 11) And &H1F) * 8

                                Dim Brush_P As New SolidBrush(Color.FromArgb(255, Red, Green, Blue))
                                g.FillRectangle(Brush_P, New Rectangle(660, 4, 48, 48))
                                g.DrawRectangle(New Pen(Color.Red), New Rectangle(660, 4, 48, 48))

                                Dim C_X = Math.Floor((((SelectedByte - 4) / 16) Mod 128) / 8)
                                Dim C_Y = Math.Floor((SelectedByte - 4) / 2048)
                                Dim P_X = Math.Floor(ByteOrderLUT(((SelectedByte - 4 - (SelectedByte Mod 2)) / 2) Mod 64) Mod 8)
                                Dim P_Y = Math.Floor((ByteOrderLUT(((SelectedByte - 4 - (SelectedByte Mod 2)) / 2) Mod 64) - P_X) / 8)
                                g.DrawLine(New Pen(Color.Red), New Point(660, 4), New Point(500 + C_X * 8 + P_X, 4 + C_Y * 8 + P_Y))
                                g.DrawLine(New Pen(Color.Red), New Point(660, 52), New Point(500 + C_X * 8 + P_X, 4 + C_Y * 8 + P_Y))

                                Dim Brush_DT As New SolidBrush(Color.Black)
                                g.DrawString("Cell X:      " + CStr(C_X), Font, Brush_DT, New Point(660, 52))
                                g.DrawString("Cell Y:      " + CStr(C_Y), Font, Brush_DT, New Point(660, 64))
                                g.DrawString("Point X:     " + CStr(P_X), Font, Brush_DT, New Point(660, 76))
                                g.DrawString("Point Y:     " + CStr(P_Y), Font, Brush_DT, New Point(660, 88))
                                g.DrawString("Coordinates: " + CStr(C_X * 8 + P_X) + ", " + CStr(C_Y * 8 + P_Y), Font, Brush_DT, New Point(660, 100))
                                g.DrawString("RGB565:      " + CStr((PixelData >> 11) And &H1F) + ", " + CStr((PixelData >> 5) And &H3F) + ", " + CStr(PixelData And &H1F), Font, Brush_DT, New Point(660, 112))
                                g.DrawString("RGB24:       " + CStr(((PixelData >> 11) And &H1F) * 8) + ", " + CStr(((PixelData >> 5) And &H3F) * 4) + ", " + CStr((PixelData And &H1F) * 8), Font, Brush_DT, New Point(660, 124))
                        End Select
                        Select Case BIQ_N
                            ' Highlight pixel bytes
                            Case &H4 To &H8003
                                If BIQ_N Mod 2 = 0 Then
                                    Dim BIQ2 As Byte = OpenedFile(ao + j + 1)

                                    Dim PixelData As UInt16 = 0
                                    PixelData += BIQ
                                    PixelData += BIQ2 * 256

                                    Dim Blue = (PixelData And &H1F) * 8
                                    Dim Green = ((PixelData >> 5) And &H3F) * 4
                                    Dim Red = ((PixelData >> 11) And &H1F) * 8

                                    Dim Brush_P As New SolidBrush(Color.FromArgb(255, Red, Green, Blue))
                                    g.FillRectangle(Brush_P, New Rectangle(80 + 24 * j, 4 + 16 * i, 48, 16))
                                End If
                            ' Highlight CRC bytes
                            Case &H8004
                                Dim CRC32 As UInteger = KbbEditor.Crc32.ComputeCRC32(OpenedFile, &H0, &H8003)
                                Dim F_CRC32 As UInteger = BitConverter.ToUInt32(OpenedFile, &H8004)
                                If F_CRC32 = CRC32 Then
                                    g.FillRectangle(New SolidBrush(Color.Lime), New Rectangle(80 + 24 * j, 4 + 16 * i, 96, 16))
                                Else
                                    g.FillRectangle(New SolidBrush(Color.Red), New Rectangle(80 + 24 * j, 4 + 16 * i, 96, 16))
                                End If
                        End Select
                End Select

                ' Draw bytes
                g.DrawString(BIQ.ToString("X2"), CFont, MyBrush, New PointF(80 + 24 * j, 4 + 16 * i))

                ' Underline selected byte
                Dim SB_X = (SelectedByte - 16 * VScrollBar1.Value) Mod 16
                Dim SB_Y = Math.Floor((SelectedByte - 16 * VScrollBar1.Value) / 16)
                If SelectedByte <> -1 And SelectedByte < OpenedFile.Length Then
                    If SecondByte Then
                        g.FillRectangle(New SolidBrush(Color.Red), New Rectangle(92 + 24 * SB_X, 20 + 16 * SB_Y, 12, 3))
                    Else
                        g.FillRectangle(New SolidBrush(Color.Red), New Rectangle(80 + 24 * SB_X, 20 + 16 * SB_Y, 12, 3))
                    End If
                End If
            Next
            If BytesToDraw <> 16 Then
                Exit For
            End If
        Next

        ' Swap with FrontBuffer
        PictureBox1.Image = BackBuffer
    End Sub

    Private Sub ToolStripComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ToolStripComboBox1.SelectedIndexChanged
        Dim SelectedFileID = -1
        SelectedByte = -1
        Timer1.Enabled = False
        Dim SI = ToolStripComboBox1.SelectedIndex
        Select Case SI
            Case 0
                OpenedFile = KbbEditor.KbbSave
                OpenedFileID = SI
                SelectedFileID = SI
            Case 1 To 49
                Dim D1 = (SI - 1) Mod 10
                Dim D2 = ((SI - 1) - ((SI - 1) Mod 10)) / 10
                If My.Computer.FileSystem.FileExists(Form1.FolderBrowserDialog1.SelectedPath & "\PhotoF" & CStr(D2) & CStr(D1) & ".dat") Then
                    OpenedFileID = SI
                    SelectedFileID = SI
                    OpenedFile = My.Computer.FileSystem.ReadAllBytes(Form1.FolderBrowserDialog1.SelectedPath & "\PhotoF" & CStr(D2) & CStr(D1) & ".dat")
                    SelectedImage = KbbEditor.FaceImages(SI - 1).Clone()
                Else
                    MsgBox("The selected file doesn't exist.", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Could not read selected file")
                End If
            Case 50 To 59
                Dim D1 = (SI - 50) Mod 10
                Dim D2 = 0 ' It's gonna be 0 obviously
                If My.Computer.FileSystem.FileExists(Form1.FolderBrowserDialog1.SelectedPath & "\PhotoP" & CStr(D2) & CStr(D1) & ".dat") Then
                    OpenedFileID = SI
                    SelectedFileID = SI
                    OpenedFile = My.Computer.FileSystem.ReadAllBytes(Form1.FolderBrowserDialog1.SelectedPath & "\PhotoP" & CStr(D2) & CStr(D1) & ".dat")
                    SelectedImage = KbbEditor.UFOFaceImages(SI - 50).Clone()
                Else
                    MsgBox("The selected file doesn't exist.", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Could not read selected file")
                End If
        End Select
        If SelectedFileID <> -1 Then
            Timer1.Enabled = True
            VScrollBar1.Value = 0
            Dim VS_Max = Math.Floor(OpenedFile.Length / 16)
            If VS_Max >= 14 Then
                VS_Max -= 14
            End If
            VScrollBar1.Maximum = VS_Max
            VScrollBar1.Enabled = True
        End If
        UpdatePictureBox()
    End Sub

    Private Sub SaveFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveFileToolStripMenuItem.Click
        Select Case OpenedFileID
            Case 0
                KbbEditor.KbbSave = OpenedFile
            Case 1 To 49
                Dim D1 = (OpenedFileID - 1) Mod 10
                Dim D2 = ((OpenedFileID - 1) - ((OpenedFileID - 1) Mod 10)) / 10
                My.Computer.FileSystem.WriteAllBytes(Form1.FolderBrowserDialog1.SelectedPath & "\PhotoF" & CStr(D2) & CStr(D1) & ".dat", OpenedFile, False)
            Case 50 To 59
                Dim D1 = (OpenedFileID - 50) Mod 10
                Dim D2 = 0 ' It's gonna be 0 obviously
                My.Computer.FileSystem.WriteAllBytes(Form1.FolderBrowserDialog1.SelectedPath & "\PhotoP" & CStr(D2) & CStr(D1) & ".dat", OpenedFile, False)
        End Select
    End Sub

    Private Sub PictureBox1_MouseWheel(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseWheel
        Dim VS_Val = VScrollBar1.Value
        VS_Val += e.Delta / -40
        If VS_Val < 0 Then
            VScrollBar1.Value = 0
        ElseIf VS_Val > VScrollBar1.Maximum Then
            VScrollBar1.Value = VScrollBar1.Maximum
        Else
            VScrollBar1.Value = VS_Val
        End If
        UpdatePictureBox()
    End Sub

    Private Sub PictureBox1_MouseClick(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseClick
        If e.X >= 80 And e.X < 464 And e.Y > 4 Then
            Dim X = Math.Floor((e.X - 80) / 24)
            Dim Y = Math.Floor((e.Y - 4) / 16)
            SelectedByte = X + Y * 16 + VScrollBar1.Value * 16
            SecondByte = False
            If OpenedFileID >= 1 And OpenedFileID <= 59 Then
                Select Case SelectedByte
                    Case &H8004 To &H8007
                        Dim CRC32 As UInteger = KbbEditor.Crc32.ComputeCRC32(OpenedFile, &H0, &H8003)
                        Dim F_CRC32 As UInteger = BitConverter.ToUInt32(OpenedFile, &H8004)
                        If F_CRC32 <> CRC32 Then
                            If MsgBox("Recompute CRC?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Invalid CRC") = MsgBoxResult.Yes Then
                                KbbEditor.File.ExportUInt32(OpenedFile, &H8004, CRC32)
                            End If
                        End If
                End Select
            End If
        End If
        UpdatePictureBox()
    End Sub

    Private Sub PictureBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        Dim ByteEdited As Boolean = False
        Dim SB_O = SelectedByte
        Dim CharNum = Asc(e.KeyChar)
        If SelectedByte >= 0 And SelectedByte < OpenedFile.Length Then
            Select Case CharNum
                Case &H30 To &H39
                    Dim D_C = CharNum - &H30
                    Dim BIQ As Byte = OpenedFile(SelectedByte)
                    If SecondByte Then
                        OpenedFile(SelectedByte) = (BIQ And &HF0) + D_C
                        SecondByte = False
                        SelectedByte += 1
                    Else
                        OpenedFile(SelectedByte) = (BIQ And &HF) + D_C * &H10
                        SecondByte = True
                    End If
                    ByteEdited = True
                Case &H41 To &H46
                    Dim D_C = CharNum - 55
                    Dim BIQ As Byte = OpenedFile(SelectedByte)
                    If SecondByte Then
                        OpenedFile(SelectedByte) = (BIQ And &HF0) + D_C
                        SecondByte = False
                        SelectedByte += 1
                    Else
                        OpenedFile(SelectedByte) = (BIQ And &HF) + D_C * &H10
                        SecondByte = True
                    End If
                    ByteEdited = True
                Case &H61 To &H66
                    Dim D_C = CharNum - 87
                    Dim BIQ As Byte = OpenedFile(SelectedByte)
                    If SecondByte Then
                        OpenedFile(SelectedByte) = (BIQ And &HF0) + D_C
                        SecondByte = False
                        SelectedByte += 1
                    Else
                        OpenedFile(SelectedByte) = (BIQ And &HF) + D_C * &H10
                        SecondByte = True
                    End If
                    ByteEdited = True
            End Select
        End If
        If ByteEdited Then
            If SB_O >= 4 And SB_O <= &H8003 And OpenedFileID >= 1 And OpenedFileID <= 59 Then
                Dim BIQ1 As Byte = OpenedFile(SB_O - (SB_O Mod 2))
                Dim BIQ2 As Byte = OpenedFile(SB_O - (SB_O Mod 2) + 1)

                Dim PixelData As UInt16 = 0
                PixelData += BIQ1
                PixelData += BIQ2 * 256

                Dim Blue = (PixelData And &H1F) * 8
                Dim Green = ((PixelData >> 5) And &H3F) * 4
                Dim Red = ((PixelData >> 11) And &H1F) * 8

                Dim C_X = Math.Floor((((SB_O - 4) / 16) Mod 128) / 8)
                Dim C_Y = Math.Floor((SB_O - 4) / 2048)
                Dim P_X = Math.Floor(ByteOrderLUT(((SB_O - 4 - (SB_O Mod 2)) / 2) Mod 64) Mod 8)
                Dim P_Y = Math.Floor((ByteOrderLUT(((SB_O - 4 - (SB_O Mod 2)) / 2) Mod 64) - P_X) / 8)

                SelectedImage.SetPixel(C_X * 8 + P_X, C_Y * 8 + P_Y, Color.FromArgb(255, Red, Green, Blue))
            End If
        End If
        UpdatePictureBox()
    End Sub

    Private Sub VScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles VScrollBar1.Scroll
        UpdatePictureBox()
    End Sub
End Class