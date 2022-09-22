Imports System.Security.Cryptography

Public Class KbbEditor
    Public Shared KbbSave As Byte()
    Public Shared Saved As Boolean
    Public Shared KbbCRC As UInt32
    Public Shared KbbFaces(48) As KbbFaceInfo
    Public Shared FacesOrder(48) As UInt32
    Public Shared UFOFacesOrder(9) As UInt32
    Public Shared KbbScores(9) As Score
    Public Shared KbbImportedFaces(9) As KbbImportedFaceInfo
    Public Shared UFOFaceRawImages(9) As KbbFace
    Public Shared FaceRawImages(48) As KbbFace
    Public Shared UFOFaceImages(9) As Bitmap
    Public Shared FaceImages(48) As Bitmap
    Public Shared AvailableFRIslots As Boolean() = {
        True, True, True, True, True, True, True, True,
        True, True, True, True, True, True, True, True,
        True, True, True, True, True, True, True, True,
        True, True, True, True, True, True, True, True,
        True, True, True, True, True, True, True, True,
        True, True, True, True, True, True, True, True, True
    }
    Public Shared AvailableUFOFRIslots As Boolean() = {
        True, True, True, True, True,
        True, True, True, True, True
    }

    Public Class KbbSaveInfo
        Public Shared MakeUFOAppear As Boolean
        Public Shared UFOStage As Byte
        Public Shared NextFaceID As UInt32
        Public Shared NextImportedFaceID As UInt32
        Public Shared SAFFriendFaces As UInt32
        Public Shared ScenesUnlocked As UInt32
        Public Shared LastLoadScene As UInt32
        Public Shared SneakySnapsEnabled As Boolean
        Public Shared FaceCollectionVisible As Boolean
        Public Shared Stage2Unlocked As Boolean
        Public Shared Stage3Unlocked As Boolean
        Public Shared Stage4Unlocked As Boolean
        Public Shared BonusStageUnlocked As Boolean
        Public Shared ExtraStageUnlocked As Boolean
        Public Shared SAFStage2Unlocked As Boolean
        Public Shared SAFBonusStageUnlocked As Boolean
        Public Shared SAFStage1Unlocked As Boolean
        Public Shared Stage1FaceSelectionUnlocked As Boolean
        Public Shared Stage2FaceSelectionUnlocked As Boolean
        Public Shared Stage3FaceSelectionUnlocked As Boolean
        Public Shared Stage4FaceSelectionUnlocked As Boolean
        Public Shared ResetRedArrowInvisible As Boolean
        Public Shared UFOUnlocked As Boolean
        Public Shared Stage2UnlockingSeen As Boolean
        Public Shared Stage3UnlockingSeen As Boolean
        Public Shared Stage4UnlockingSeen As Boolean
        Public Shared BonusStageUnlockingSeen As Boolean
        Public Shared ExtraStageUnlockingSeen As Boolean
        Public Shared SAFStage2UnlockingSeen As Boolean
        Public Shared SAFBonusStageUnlockingSeen As Boolean
        Public Shared UFOAlreadySeen As Boolean
        Public Shared SAFStage1UnlockingSeen As Boolean
        Public Shared FaceChoosingAdvice As Boolean
        Public Shared SAFNewSeen As Boolean
        Public Shared Stage1UnlockingSeen As Boolean
        Public Shared UFONewSeen As Boolean
        Public Shared FaceCollectionNewFaceSeen As Boolean
        Public Shared SneakySnapsUsable As Boolean
    End Class

    Public Structure KbbFaceInfo
        Public FaceID As UInt32
        Public YearMet As Int16
        Public MonthMet As SByte
        Public DayMet As SByte
        Public TimesChoosen As UInt16
        Public Age As Int16
        Public Gender As Int16
        Public XMove As Single
        Public YMove As Single
        Public XStretch As Single
        Public YStretch As Single
        Public Rotation As Single
        Public FRIindex As Int16 ' Used by editor
    End Structure

    Public Structure Score
        Public Score1FID As UInt32
        Public Score1 As UInt32
        Public Score2FID As UInt32
        Public Score2 As UInt32
        Public Score3FID As UInt32
        Public Score3 As UInt32
        Public Score4FID As UInt32
        Public Score4 As UInt32
        Public Score5FID As UInt32
        Public Score5 As UInt32
        Public BestCombo As UInt16
    End Structure

    Public Structure KbbImportedFaceInfo
        Public FaceID As UInt32
        Public CaptureDate As Int64
        Public NewFace As Boolean
        Public FRIindex As Int16 ' Used by editor
    End Structure

    Public Structure KbbFace
        Public Pad As UInt32
        Public TextureData() As Byte
        Public CRC32 As UInt32
    End Structure

    Public Class Crc32
        Shared table As UInteger()

        Shared Sub New()
            Dim polynomial As UInteger = &HEDB88320UI
            table = New UInteger(255) {}
            Dim temp As UInteger
            For i As UInteger = 0 To table.Length - 1
                temp = i
                For j As Integer = 8 To 1 Step -1
                    If (temp And 1) = 1 Then
                        temp = CUInt((temp >> 1) Xor polynomial)
                    Else
                        temp >>= 1
                    End If
                Next
                table(i) = temp
            Next
        End Sub

        Public Shared Function ComputeCRC32(data As Byte(), datastart As UInt16, dataend As UInt16) As UInteger
            Dim crc32 As UInteger = &HFFFFFFFFUI
            For i As Integer = datastart To dataend
                Dim index As Byte = CByte((crc32 And &HFF) Xor data(i))
                crc32 = CUInt((crc32 >> 8) Xor table(index))
            Next
            Return Not crc32
        End Function
    End Class

    Public Class File
        Public Shared Sub ExportInt16(data As Byte(), index As UInt16, var As Int16)
            Dim Ex16Bytes As Byte()
            Ex16Bytes = BitConverter.GetBytes(var)
            data(index) = Ex16Bytes(0)
            data(index + 1) = Ex16Bytes(1)
        End Sub

        Public Shared Sub ExportUInt16(data As Byte(), index As UInt16, var As UInt16)
            Dim Ex16Bytes As Byte()
            Ex16Bytes = BitConverter.GetBytes(var)
            data(index) = Ex16Bytes(0)
            data(index + 1) = Ex16Bytes(1)
        End Sub

        Public Shared Sub ExportInt32(data As Byte(), index As UInt16, var As Int32)
            Dim Ex32Bytes As Byte()
            Ex32Bytes = BitConverter.GetBytes(var)
            data(index) = Ex32Bytes(0)
            data(index + 1) = Ex32Bytes(1)
            data(index + 2) = Ex32Bytes(2)
            data(index + 3) = Ex32Bytes(3)
        End Sub

        Public Shared Sub ExportUInt32(data As Byte(), index As UInt16, var As UInt32)
            Dim Ex32Bytes As Byte()
            Ex32Bytes = BitConverter.GetBytes(var)
            data(index) = Ex32Bytes(0)
            data(index + 1) = Ex32Bytes(1)
            data(index + 2) = Ex32Bytes(2)
            data(index + 3) = Ex32Bytes(3)
        End Sub

        Public Shared Sub ExportFloat(data As Byte(), index As UInt16, var As Single)
            Dim FloatBytes As Byte()
            FloatBytes = BitConverter.GetBytes(var)
            data(index) = FloatBytes(0)
            data(index + 1) = FloatBytes(1)
            data(index + 2) = FloatBytes(2)
            data(index + 3) = FloatBytes(3)
        End Sub
    End Class

    Public Shared ReadOnly ByteOrderLUT = {
        0, 1, 8, 9, 2, 3, 10, 11,
        16, 17, 24, 25, 18, 19, 26, 27,
        4, 5, 12, 13, 6, 7, 14, 15,
        20, 21, 28, 29, 22, 23, 30, 31,
        32, 33, 40, 41, 34, 35, 42, 43,
        48, 49, 56, 57, 50, 51, 58, 59,
        36, 37, 44, 45, 38, 39, 46, 47,
        52, 53, 60, 61, 54, 55, 62, 63
    }

    Public Shared Function DecodeRawFaceData(InData)
        Dim OutImage As New Bitmap(128, 128)

        Dim InOff As UInt16 = 0

        For tY As Int16 = 0 To 15
            For tX As Int16 = 0 To 15
                For pX As Int16 = 0 To 63
                    Dim X = ByteOrderLUT(pX) Mod 8
                    Dim Y = (ByteOrderLUT(pX) - X) / 8

                    Dim PixelData As UInt16 = 0
                    PixelData += InData(InOff)
                    PixelData += InData(InOff + 1) * 256

                    Dim B = (PixelData And &H1F) * 8
                    Dim G = ((PixelData >> 5) And &H3F) * 4
                    Dim R = ((PixelData >> 11) And &H1F) * 8

                    OutImage.SetPixel(tX * 8 + X, tY * 8 + Y, Color.FromArgb(255, R, G, B))

                    InOff += 2
                Next
            Next
        Next

        Return OutImage
    End Function

    Public Shared Function EncodeRawFaceData(InImage As Bitmap)
        Dim Output As Byte()
        ReDim Output(&H7FFF)

        Dim OutOff As UInt16 = 0

        InImage = FixFacePixelData(InImage)

        For tY As Int16 = 0 To 15
            For tX As Int16 = 0 To 15
                For pX As Int16 = 0 To 63
                    Dim X = ByteOrderLUT(pX) Mod 8
                    Dim Y = (ByteOrderLUT(pX) - X) / 8

                    Dim PixelData As UInt16 = 0

                    PixelData += Math.Floor(InImage.GetPixel(tX * 8 + X, tY * 8 + Y).B / 8)
                    PixelData += InImage.GetPixel(tX * 8 + X, tY * 8 + Y).G * 8
                    PixelData += InImage.GetPixel(tX * 8 + X, tY * 8 + Y).R * 256

                    Output(OutOff) = PixelData And &HFF
                    Output(OutOff + 1) = (PixelData And &HFF00) / 256

                    OutOff += 2
                Next
            Next
        Next

        Return Output
    End Function

    Public Shared Function FixFacePixelData(InImage As Bitmap) ' Only works for faces you imported from your computer
        For Y As Int16 = 0 To 127
            For X As Int16 = 0 To 127
                Dim R = InImage.GetPixel(X, Y).R
                Dim G = InImage.GetPixel(X, Y).G
                Dim B = InImage.GetPixel(X, Y).B

                If InImage.GetPixel(X, Y).R Mod 8 > 0 Then
                    R -= R Mod 8
                    InImage.SetPixel(X, Y, Color.FromArgb(255, R, G, B))
                End If

                If InImage.GetPixel(X, Y).G Mod 4 > 0 Then
                    G -= G Mod 4
                    InImage.SetPixel(X, Y, Color.FromArgb(255, R, G, B))
                End If

                If InImage.GetPixel(X, Y).B Mod 8 > 0 Then
                    B -= B Mod 8
                    InImage.SetPixel(X, Y, Color.FromArgb(255, R, G, B))
                End If
            Next
        Next
        Return InImage
    End Function

    Public Shared Function GetFaceImage(FID As UInt32)
        If FID = &HFFFFFFFFUI Then
            Return My.Resources.NoFace
        ElseIf FID = &HFFFFFFFEUI Then
            Return My.Resources.UnknownFace
        ElseIf FID = &HFFFFFFFDUI Then
            Return My.Resources.UnknownFace2
        ElseIf FID = &HFFFFFFFCUI Then
            Return My.Resources.DummyFace
        End If
        ' These IDs above are special for the game, they display the faces differently.
        If FID < 10 Then
            For i = 0 To 9
                If KbbImportedFaces(i).FaceID = FID Then
                    If KbbImportedFaces(i).FRIindex <> -1 Then
                        Return UFOFaceImages(KbbImportedFaces(i).FRIindex)
                    End If
                End If
            Next
        End If
        For i = 0 To 48
            If KbbFaces(i).FaceID = FID Then
                If KbbFaces(i).FRIindex <> -1 Then
                    Return FaceImages(KbbFaces(i).FRIindex)
                End If
            End If
        Next
        Return My.Resources.NoFace
    End Function

    Public Shared Function SetFaceImage(FID As UInt32, NewImage As Bitmap)
        If FID = &HFFFFFFFFUI Then
            Return My.Resources.NoFace
        End If
        If FID < 10 Then
            For i = 0 To 9
                If KbbImportedFaces(i).FaceID = FID Then
                    If KbbFaces(i).FRIindex <> -1 Then
                        UFOFaceImages(KbbImportedFaces(i).FRIindex) = NewImage
                    End If
                    Exit For
                End If
            Next
        End If
        For i = 0 To 48
            If KbbFaces(i).FaceID = FID Then
                If KbbFaces(i).FRIindex <> -1 Then
                    FaceImages(KbbFaces(i).FRIindex) = NewImage
                    Exit For
                End If
            End If
        Next
        If FID = &HFFFFFFFEUI Then
            Return My.Resources.UnknownFace
        ElseIf FID = &HFFFFFFFDUI Then
            Return My.Resources.UnknownFace2
        ElseIf FID = &HFFFFFFFCUI Then
            Return My.Resources.DummyFace
        End If
        Return NewImage
    End Function

    Public Shared Function GetFaceProps(FID As UInt32)
        For i = 0 To 48
            If KbbFaces(i).FaceID = FID Then
                Dim FaceProperties As KbbFaceInfo

                FaceProperties.FaceID = KbbFaces(i).FaceID
                FaceProperties.DayMet = KbbFaces(i).DayMet
                FaceProperties.MonthMet = KbbFaces(i).MonthMet
                FaceProperties.YearMet = KbbFaces(i).YearMet
                FaceProperties.TimesChoosen = KbbFaces(i).TimesChoosen
                FaceProperties.Age = KbbFaces(i).Age
                FaceProperties.Gender = KbbFaces(i).Gender
                FaceProperties.XMove = KbbFaces(i).XMove
                FaceProperties.YMove = KbbFaces(i).YMove
                FaceProperties.XStretch = KbbFaces(i).XStretch
                FaceProperties.YStretch = KbbFaces(i).YStretch
                FaceProperties.Rotation = KbbFaces(i).Rotation

                Return FaceProperties
            End If
        Next
        Return -1
    End Function

    Public Shared Sub SetFaceProps(FID As UInt32, InInfoData As KbbFaceInfo)
        For i = 0 To 48
            If KbbFaces(i).FaceID = FID Then
                KbbFaces(i).DayMet = InInfoData.DayMet
                KbbFaces(i).MonthMet = InInfoData.MonthMet
                KbbFaces(i).YearMet = InInfoData.YearMet
                KbbFaces(i).TimesChoosen = InInfoData.TimesChoosen
                KbbFaces(i).Age = InInfoData.Age
                KbbFaces(i).Gender = InInfoData.Gender
                KbbFaces(i).XMove = InInfoData.XMove
                KbbFaces(i).YMove = InInfoData.YMove
                KbbFaces(i).XStretch = InInfoData.XStretch
                KbbFaces(i).YStretch = InInfoData.YStretch
                KbbFaces(i).Rotation = InInfoData.Rotation
                Exit For
            End If
        Next
    End Sub

    Public Shared Function GetUFOFaceProps(FID As UInt32)
        For i = 0 To 9
            If KbbImportedFaces(i).FaceID = FID Then
                Dim FaceProperties As KbbImportedFaceInfo

                FaceProperties.NewFace = KbbImportedFaces(i).NewFace

                Return FaceProperties
            End If
        Next
        Return -1
    End Function

    Public Shared Sub SetUFOFaceProps(FID As UInt32, InInfoData As KbbImportedFaceInfo)
        For i = 0 To 9
            If KbbImportedFaces(i).FaceID = FID Then
                KbbImportedFaces(i).NewFace = InInfoData.NewFace
            End If
        Next
    End Sub

    Public Shared Sub NewFace(FaceImage As Bitmap, FaceProps As KbbFaceInfo)
        Dim OK As Boolean = False
        For i = 0 To 48
            If KbbFaces(i).FaceID = &HFFFFFFFFUI Then
                KbbFaces(i) = FaceProps
                KbbFaces(i).FaceID = KbbSaveInfo.NextFaceID ' Give an ID to the face
                KbbSaveInfo.NextFaceID += 1
                Dim FacesReOrder(48) As UInt32
                Dim Offset = 0
                For j = 0 To FacesOrder.Length - 2
                    If FacesOrder(j) > KbbFaces(i).FaceID Then
                        Offset = 1
                        If FacesOrder(j - 1) < KbbFaces(i).FaceID Then
                            FacesReOrder(j) = KbbFaces(i).FaceID
                        End If
                    End If
                    FacesReOrder(j + Offset) = FacesOrder(j)
                Next
                FacesOrder = FacesReOrder
                For j = 0 To 48
                    If AvailableFRIslots(j) = True Then
                        FaceImages(j) = FaceImage
                        AvailableFRIslots(j) = False
                        KbbFaces(i).FRIindex = j
                        OK = True
                        Exit For
                    End If
                Next
            End If
            If OK = True Then
                Exit Sub
            End If
        Next
    End Sub

    Public Shared Sub NewUFOFace(FaceImage As Bitmap)
        Dim OK As Boolean = False
        For i = 0 To 9
            ' To do: do the code
            If OK = True Then
                Exit Sub
            End If
        Next
    End Sub

    Public Shared Sub DeleteFace(FID As UInt32)
        If FID = &HFFFFFFFFUI Then
            MsgBox("Face is null", vbCritical + vbOK, "Error while deleting face")
        End If
        If FID < 10 Then
            For i = 0 To 9
                If KbbImportedFaces(i).FaceID = FID Then
                    AvailableUFOFRIslots(KbbImportedFaces(i).FRIindex) = True
                    KbbImportedFaces(i).FRIindex = -1
                    KbbImportedFaces(i).FaceID = &HFFFFFFFFUI
                    KbbImportedFaces(i).NewFace = True
                    Dim FacesReOrder(9) As UInt32
                    Dim Offset = 0
                    For j = 0 To UFOFacesOrder.Length - 1
                        If UFOFacesOrder(j) = FID Then
                            Offset += 1
                        Else
                            FacesReOrder(j - Offset) = UFOFacesOrder(j)
                        End If
                    Next
                    UFOFacesOrder = FacesReOrder
                    UFOFacesOrder(9) = &HFFFFFFFFUI
                    Exit Sub
                End If
            Next
        End If
        For i = 0 To 48
            If KbbFaces(i).FaceID = FID Then
                If KbbFaces(i).FRIindex <> -1 Then
                    AvailableFRIslots(KbbFaces(i).FRIindex) = True
                    KbbFaces(i).FRIindex = -1
                    KbbFaces(i).FaceID = &HFFFFFFFFUI
                    KbbFaces(i).YearMet = 0
                    KbbFaces(i).MonthMet = 0
                    KbbFaces(i).DayMet = 0
                    KbbFaces(i).TimesChoosen = 0
                    KbbFaces(i).Age = -1
                    KbbFaces(i).Gender = -1
                    KbbFaces(i).XMove = 0
                    KbbFaces(i).YMove = 0
                    KbbFaces(i).XStretch = 1
                    KbbFaces(i).YStretch = 1
                    KbbFaces(i).Rotation = 0
                    Dim FacesReOrder(48) As UInt32
                    Dim Offset = 0
                    For j = 0 To FacesOrder.Length - 1
                        If FacesOrder(j) = FID Then
                            Offset += 1
                        Else
                            FacesReOrder(j - Offset) = FacesOrder(j)
                        End If
                    Next
                    FacesOrder = FacesReOrder
                    FacesOrder(48) = &HFFFFFFFFUI
                    Exit Sub
                End If
            End If
        Next
    End Sub

    Public Shared Sub LoadSave()
        KbbSaveInfo.MakeUFOAppear = BitConverter.ToBoolean(KbbSave, &H10C8)
        KbbSaveInfo.UFOStage = KbbSave(&H10C9)
        KbbSaveInfo.NextFaceID = BitConverter.ToUInt32(KbbSave, &H10CC)
        KbbSaveInfo.NextImportedFaceID = BitConverter.ToUInt32(KbbSave, &H10D0)
        KbbSaveInfo.SAFFriendFaces = BitConverter.ToUInt32(KbbSave, &H10E8)
        KbbSaveInfo.ScenesUnlocked = BitConverter.ToUInt32(KbbSave, &H10EC)
        KbbSaveInfo.LastLoadScene = BitConverter.ToUInt32(KbbSave, &H10F0)
        KbbSaveInfo.SneakySnapsEnabled = BitConverter.ToBoolean(KbbSave, &H10F8)
        KbbSaveInfo.FaceCollectionVisible = BitConverter.ToBoolean(KbbSave, &H1100)
        KbbSaveInfo.Stage2Unlocked = BitConverter.ToBoolean(KbbSave, &H1103)
        KbbSaveInfo.Stage3Unlocked = BitConverter.ToBoolean(KbbSave, &H1105)
        KbbSaveInfo.Stage4Unlocked = BitConverter.ToBoolean(KbbSave, &H1106)
        KbbSaveInfo.BonusStageUnlocked = BitConverter.ToBoolean(KbbSave, &H1107)
        KbbSaveInfo.ExtraStageUnlocked = BitConverter.ToBoolean(KbbSave, &H1108)
        KbbSaveInfo.SAFStage2Unlocked = BitConverter.ToBoolean(KbbSave, &H1109)
        KbbSaveInfo.SAFBonusStageUnlocked = BitConverter.ToBoolean(KbbSave, &H110A)
        KbbSaveInfo.SAFStage1Unlocked = BitConverter.ToBoolean(KbbSave, &H110B)
        KbbSaveInfo.Stage1FaceSelectionUnlocked = BitConverter.ToBoolean(KbbSave, &H110D)
        KbbSaveInfo.Stage2FaceSelectionUnlocked = BitConverter.ToBoolean(KbbSave, &H110E)
        KbbSaveInfo.Stage3FaceSelectionUnlocked = BitConverter.ToBoolean(KbbSave, &H110F)
        KbbSaveInfo.Stage4FaceSelectionUnlocked = BitConverter.ToBoolean(KbbSave, &H1110)
        KbbSaveInfo.ResetRedArrowInvisible = BitConverter.ToBoolean(KbbSave, &H1128)
        KbbSaveInfo.UFOUnlocked = BitConverter.ToBoolean(KbbSave, &H112A)
        KbbSaveInfo.Stage2UnlockingSeen = BitConverter.ToBoolean(KbbSave, &H112B)
        KbbSaveInfo.Stage3UnlockingSeen = BitConverter.ToBoolean(KbbSave, &H112C)
        KbbSaveInfo.Stage4UnlockingSeen = BitConverter.ToBoolean(KbbSave, &H112D)
        KbbSaveInfo.BonusStageUnlockingSeen = BitConverter.ToBoolean(KbbSave, &H112E)
        KbbSaveInfo.ExtraStageUnlockingSeen = BitConverter.ToBoolean(KbbSave, &H112F)
        KbbSaveInfo.SAFStage2UnlockingSeen = BitConverter.ToBoolean(KbbSave, &H1130)
        KbbSaveInfo.SAFBonusStageUnlockingSeen = BitConverter.ToBoolean(KbbSave, &H1131)
        KbbSaveInfo.UFOAlreadySeen = BitConverter.ToBoolean(KbbSave, &H1132)
        KbbSaveInfo.SAFStage1UnlockingSeen = BitConverter.ToBoolean(KbbSave, &H1134)
        KbbSaveInfo.FaceChoosingAdvice = BitConverter.ToBoolean(KbbSave, &H113A)
        KbbSaveInfo.SAFNewSeen = BitConverter.ToBoolean(KbbSave, &H113B)
        KbbSaveInfo.Stage1UnlockingSeen = BitConverter.ToBoolean(KbbSave, &H113C)
        KbbSaveInfo.UFONewSeen = BitConverter.ToBoolean(KbbSave, &H1144)
        KbbSaveInfo.FaceCollectionNewFaceSeen = BitConverter.ToBoolean(KbbSave, &H1146)
        KbbSaveInfo.SneakySnapsUsable = BitConverter.ToBoolean(KbbSave, &H1147)

        Dim FRIindex = 0 ' Index used to locate faster the image/raw image of a face.

        For i = 0 To 9 ' Load UFO faces
            KbbImportedFaces(i).FaceID = BitConverter.ToUInt32(KbbSave, &HDF8 + (i * &H28))

            KbbImportedFaces(i).FRIindex = -1
            If My.Computer.FileSystem.FileExists(Form1.FolderBrowserDialog1.SelectedPath + "\PhotoP" + CStr(CInt(Math.Floor(i / 10))) + CStr(i Mod 10) + ".dat") Then
                Dim Buffer As Byte()
                Dim NIFace As KbbFace

                Buffer = My.Computer.FileSystem.ReadAllBytes(Form1.FolderBrowserDialog1.SelectedPath + "\PhotoP" + CStr(CInt(Math.Floor(i / 10))) + CStr(i Mod 10) + ".dat")

                NIFace.Pad = BitConverter.ToUInt32(Buffer, 0)
                ReDim NIFace.TextureData(&H7FFF)
                Array.ConstrainedCopy(Buffer, 4, NIFace.TextureData, 0, &H8000)
                NIFace.CRC32 = BitConverter.ToUInt32(Buffer, &H8004)

                UFOFaceRawImages(FRIindex) = NIFace

                KbbImportedFaces(i).FRIindex = FRIindex
                AvailableFRIslots(FRIindex) = False
            End If

            KbbImportedFaces(i).CaptureDate = BitConverter.ToInt64(KbbSave, &HE08 + (i * &H28))
            KbbImportedFaces(i).NewFace = BitConverter.ToBoolean(KbbSave, &HE1C + (i * &H28))

            FRIindex += 1
        Next
        FRIindex = 0
        For i = 0 To 48 ' Load saved faces
            KbbFaces(i).FaceID = BitConverter.ToUInt32(KbbSave, &H0 + (i * &H40))

            KbbFaces(i).FRIindex = -1
            If My.Computer.FileSystem.FileExists(Form1.FolderBrowserDialog1.SelectedPath + "\PhotoF" + CStr(CInt(Math.Floor(i / 10))) + CStr(i Mod 10) + ".dat") Then
                Dim Buffer As Byte()
                Dim NFace As KbbFace

                Buffer = My.Computer.FileSystem.ReadAllBytes(Form1.FolderBrowserDialog1.SelectedPath + "\PhotoF" + CStr(CInt(Math.Floor(i / 10))) + CStr(i Mod 10) + ".dat")

                NFace.Pad = BitConverter.ToUInt32(Buffer, 0)
                ReDim NFace.TextureData(&H7FFF)
                Array.ConstrainedCopy(Buffer, 4, NFace.TextureData, 0, &H8000)
                NFace.CRC32 = BitConverter.ToUInt32(Buffer, &H8004)

                FaceRawImages(FRIindex) = NFace

                KbbFaces(i).FRIindex = FRIindex
                AvailableFRIslots(FRIindex) = False
            End If

            KbbFaces(i).YearMet = BitConverter.ToInt16(KbbSave, &H4 + (i * &H40))
            KbbFaces(i).MonthMet = KbbSave(&H6 + (i * &H40))
            KbbFaces(i).DayMet = KbbSave(&H7 + (i * &H40))
            KbbFaces(i).TimesChoosen = BitConverter.ToUInt16(KbbSave, &H8 + (i * &H40))
            KbbFaces(i).Age = BitConverter.ToInt16(KbbSave, &HC + (i * &H40))
            KbbFaces(i).Gender = BitConverter.ToInt16(KbbSave, &HE + (i * &H40))
            KbbFaces(i).XMove = BitConverter.ToSingle(KbbSave, &H10 + (i * &H40))
            KbbFaces(i).YMove = BitConverter.ToSingle(KbbSave, &H14 + (i * &H40))
            KbbFaces(i).XStretch = BitConverter.ToSingle(KbbSave, &H18 + (i * &H40))
            KbbFaces(i).YStretch = BitConverter.ToSingle(KbbSave, &H1C + (i * &H40))
            KbbFaces(i).Rotation = BitConverter.ToSingle(KbbSave, &H20 + (i * &H40))

            FRIindex += 1
        Next
        For j = 0 To 48 ' Reorder the faces in an array
            Dim SmallestID As UInt32 = &HFFFFFFFFUI
            For i = 0 To 48 ' Check every face for their ID
                If j > 0 Then ' If we already placed the smallest ID of all faces...
                    If KbbFaces(i).FaceID < SmallestID Then
                        If FacesOrder(j - 1) < KbbFaces(i).FaceID Then
                            SmallestID = KbbFaces(i).FaceID
                        End If
                    End If
                Else ' If we haven't found the smallest ID of all faces yet...
                    If KbbFaces(i).FaceID < SmallestID Then
                        SmallestID = KbbFaces(i).FaceID
                    End If
                End If
            Next
            FacesOrder(j) = SmallestID ' Put the smallest ID we found into the j slot of the array
        Next
        For j = 0 To 9 ' Reorder the UFO crew faces in an array
            Dim SmallestID As UInt32 = &HFFFFFFFFUI
            For i = 0 To 9 ' Check every face for their ID
                If j > 0 Then ' If we already placed the smallest ID of all faces...
                    If KbbImportedFaces(i).FaceID < SmallestID Then
                        If UFOFacesOrder(j - 1) < KbbImportedFaces(i).FaceID Then
                            SmallestID = KbbImportedFaces(i).FaceID
                        End If
                    End If
                Else ' If we haven't found the smallest ID of all faces yet...
                    If KbbImportedFaces(i).FaceID < SmallestID Then
                        SmallestID = KbbImportedFaces(i).FaceID
                    End If
                End If
            Next
            UFOFacesOrder(j) = SmallestID ' Put the smallest ID we found into the j slot of the array
        Next

        For i = 0 To 9 ' Load score data for every stage
            KbbScores(i).Score1FID = BitConverter.ToUInt32(KbbSave, &HC40 + (i * &H2C))
            KbbScores(i).Score1 = BitConverter.ToUInt32(KbbSave, &HC44 + (i * &H2C))
            KbbScores(i).Score2FID = BitConverter.ToUInt32(KbbSave, &HC48 + (i * &H2C))
            KbbScores(i).Score2 = BitConverter.ToUInt32(KbbSave, &HC4C + (i * &H2C))
            KbbScores(i).Score3FID = BitConverter.ToUInt32(KbbSave, &HC50 + (i * &H2C))
            KbbScores(i).Score3 = BitConverter.ToUInt32(KbbSave, &HC54 + (i * &H2C))
            KbbScores(i).Score4FID = BitConverter.ToUInt32(KbbSave, &HC58 + (i * &H2C))
            KbbScores(i).Score4 = BitConverter.ToUInt32(KbbSave, &HC5C + (i * &H2C))
            KbbScores(i).Score5FID = BitConverter.ToUInt32(KbbSave, &HC60 + (i * &H2C))
            KbbScores(i).Score5 = BitConverter.ToUInt32(KbbSave, &HC64 + (i * &H2C))
            KbbScores(i).BestCombo = BitConverter.ToUInt16(KbbSave, &HC68 + (i * &H2C))
        Next
        For i = 0 To 9 ' Decode UFO faces
            If KbbImportedFaces(i).FRIindex <> -1 Then
                UFOFaceImages(KbbImportedFaces(i).FRIindex) = DecodeRawFaceData(UFOFaceRawImages(KbbImportedFaces(i).FRIindex).TextureData)
            End If
        Next
        For i = 0 To 48 ' Decode saved faces
            If KbbFaces(i).FRIindex <> -1 Then
                FaceImages(KbbFaces(i).FRIindex) = DecodeRawFaceData(FaceRawImages(KbbFaces(i).FRIindex).TextureData)
            End If
        Next
    End Sub

    Public Shared Sub SaveSave() ' The name of the function... 🤣
        KbbSave(&H10C8) = CByte(KbbSaveInfo.MakeUFOAppear)
        KbbSave(&H10C9) = KbbSaveInfo.UFOStage
        File.ExportUInt32(KbbSave, &H10CC, KbbSaveInfo.NextFaceID)
        File.ExportUInt32(KbbSave, &H10D0, KbbSaveInfo.NextImportedFaceID)
        File.ExportUInt32(KbbSave, &H10E8, KbbSaveInfo.SAFFriendFaces)
        File.ExportUInt32(KbbSave, &H10EC, KbbSaveInfo.ScenesUnlocked)
        File.ExportUInt32(KbbSave, &H10F0, KbbSaveInfo.LastLoadScene)
        KbbSave(&H10F8) = CByte(KbbSaveInfo.SneakySnapsEnabled)
        KbbSave(&H1100) = CByte(KbbSaveInfo.FaceCollectionVisible)
        KbbSave(&H1103) = CByte(KbbSaveInfo.Stage2Unlocked)
        KbbSave(&H1105) = CByte(KbbSaveInfo.Stage3Unlocked)
        KbbSave(&H1106) = CByte(KbbSaveInfo.Stage4Unlocked)
        KbbSave(&H1107) = CByte(KbbSaveInfo.BonusStageUnlocked)
        KbbSave(&H1108) = CByte(KbbSaveInfo.ExtraStageUnlocked)
        KbbSave(&H1109) = CByte(KbbSaveInfo.SAFStage2Unlocked)
        KbbSave(&H110A) = CByte(KbbSaveInfo.SAFBonusStageUnlocked)
        KbbSave(&H110B) = CByte(KbbSaveInfo.SAFStage1Unlocked)
        KbbSave(&H110D) = CByte(KbbSaveInfo.Stage1FaceSelectionUnlocked)
        KbbSave(&H110E) = CByte(KbbSaveInfo.Stage2FaceSelectionUnlocked)
        KbbSave(&H110F) = CByte(KbbSaveInfo.Stage3FaceSelectionUnlocked)
        KbbSave(&H1110) = CByte(KbbSaveInfo.Stage4FaceSelectionUnlocked)
        KbbSave(&H1128) = CByte(KbbSaveInfo.ResetRedArrowInvisible)
        KbbSave(&H112A) = CByte(KbbSaveInfo.UFOUnlocked)
        KbbSave(&H112B) = CByte(KbbSaveInfo.Stage2UnlockingSeen)
        KbbSave(&H112C) = CByte(KbbSaveInfo.Stage3UnlockingSeen)
        KbbSave(&H112D) = CByte(KbbSaveInfo.Stage4UnlockingSeen)
        KbbSave(&H112E) = CByte(KbbSaveInfo.BonusStageUnlockingSeen)
        KbbSave(&H112F) = CByte(KbbSaveInfo.ExtraStageUnlockingSeen)
        KbbSave(&H1130) = CByte(KbbSaveInfo.SAFStage2UnlockingSeen)
        KbbSave(&H1131) = CByte(KbbSaveInfo.SAFBonusStageUnlockingSeen)
        KbbSave(&H1132) = CByte(KbbSaveInfo.UFOAlreadySeen)
        KbbSave(&H1134) = CByte(KbbSaveInfo.SAFStage1UnlockingSeen)
        KbbSave(&H113A) = CByte(KbbSaveInfo.FaceChoosingAdvice)
        KbbSave(&H113B) = CByte(KbbSaveInfo.SAFNewSeen)
        KbbSave(&H113C) = CByte(KbbSaveInfo.Stage1UnlockingSeen)
        KbbSave(&H1144) = CByte(KbbSaveInfo.UFONewSeen)
        KbbSave(&H1146) = CByte(KbbSaveInfo.FaceCollectionNewFaceSeen)
        KbbSave(&H1147) = CByte(KbbSaveInfo.SneakySnapsUsable)

        For i = 0 To 9 ' Save UFO faces
            File.ExportUInt32(KbbSave, &HDF8 + (i * &H28), KbbImportedFaces(i).FaceID)

            If KbbImportedFaces(i).FRIindex <> -1 Then
                Dim OutData As Byte()
                ReDim OutData(&H8007)

                Array.ConstrainedCopy(KbbEditor.EncodeRawFaceData(KbbEditor.UFOFaceImages(KbbImportedFaces(i).FRIindex)), 0, OutData, 4, &H8000)
                Dim OutDataCRC = KbbEditor.Crc32.ComputeCRC32(OutData, 0, &H8003)

                File.ExportUInt32(OutData, &H8004, OutDataCRC)

                My.Computer.FileSystem.WriteAllBytes(Form1.FolderBrowserDialog1.SelectedPath & "\PhotoP" + CStr(CInt(Math.Floor(i / 10))) + CStr(i Mod 10) + ".dat", OutData, False)
            End If

            ' File.ExportInt64(KbbSave, &HE08 + (i * &H28), KbbImportedFaces(i).CaptureDate)
            KbbSave(&HE1C + (i * &H28)) = CByte(KbbImportedFaces(i).NewFace)
        Next

        For i = 0 To 48 ' Save faces
            File.ExportUInt32(KbbSave, &H0 + (i * &H40), KbbFaces(i).FaceID)

            If KbbFaces(i).FRIindex <> -1 Then
                Dim OutData As Byte()
                ReDim OutData(&H8007)

                Array.ConstrainedCopy(KbbEditor.EncodeRawFaceData(KbbEditor.FaceImages(KbbFaces(i).FRIindex)), 0, OutData, 4, &H8000)
                Dim OutDataCRC = KbbEditor.Crc32.ComputeCRC32(OutData, 0, &H8003)

                File.ExportUInt32(OutData, &H8004, OutDataCRC)

                My.Computer.FileSystem.WriteAllBytes(Form1.FolderBrowserDialog1.SelectedPath & "\PhotoF" + CStr(CInt(Math.Floor(i / 10))) + CStr(i Mod 10) + ".dat", OutData, False)
            End If

            File.ExportInt16(KbbSave, &H4 + (i * &H40), KbbFaces(i).YearMet)
            KbbSave(&H6 + (i * &H40)) = KbbFaces(i).MonthMet
            KbbSave(&H7 + (i * &H40)) = KbbFaces(i).DayMet

            File.ExportUInt16(KbbSave, &H8 + (i * &H40), KbbFaces(i).TimesChoosen)
            File.ExportInt16(KbbSave, &HC + (i * &H40), KbbFaces(i).Age)
            File.ExportInt16(KbbSave, &HE + (i * &H40), KbbFaces(i).Gender)
            File.ExportFloat(KbbSave, &H10 + (i * &H40), KbbFaces(i).XMove)
            File.ExportFloat(KbbSave, &H14 + (i * &H40), KbbFaces(i).YMove)
            File.ExportFloat(KbbSave, &H18 + (i * &H40), KbbFaces(i).XStretch)
            File.ExportFloat(KbbSave, &H1C + (i * &H40), KbbFaces(i).YStretch)
            File.ExportFloat(KbbSave, &H20 + (i * &H40), KbbFaces(i).Rotation)
        Next

        For i = 0 To 9 ' Save score data for every stage
            File.ExportUInt32(KbbSave, &HC40 + (i * &H2C), KbbScores(i).Score1FID)
            File.ExportUInt32(KbbSave, &HC44 + (i * &H2C), KbbScores(i).Score1)
            File.ExportUInt32(KbbSave, &HC48 + (i * &H2C), KbbScores(i).Score2FID)
            File.ExportUInt32(KbbSave, &HC4C + (i * &H2C), KbbScores(i).Score2)
            File.ExportUInt32(KbbSave, &HC50 + (i * &H2C), KbbScores(i).Score3FID)
            File.ExportUInt32(KbbSave, &HC54 + (i * &H2C), KbbScores(i).Score3)
            File.ExportUInt32(KbbSave, &HC58 + (i * &H2C), KbbScores(i).Score4FID)
            File.ExportUInt32(KbbSave, &HC5C + (i * &H2C), KbbScores(i).Score4)
            File.ExportUInt32(KbbSave, &HC60 + (i * &H2C), KbbScores(i).Score5FID)
            File.ExportUInt32(KbbSave, &HC64 + (i * &H2C), KbbScores(i).Score5)
            File.ExportUInt16(KbbSave, &HC68 + (i * &H2C), KbbScores(i).BestCombo)
        Next

        KbbCRC = KbbEditor.Crc32.ComputeCRC32(KbbSave, 0, &H1587) ' Finally, compute save CRC
        File.ExportUInt32(KbbSave, &H1588, KbbCRC)

        My.Computer.FileSystem.WriteAllBytes(Form1.FolderBrowserDialog1.SelectedPath & "\Kbb.dat", KbbSave, False)
    End Sub
End Class