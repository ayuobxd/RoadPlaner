
Imports System.Diagnostics.Eventing
Imports System.Drawing.Imaging
Imports System.IO
Imports RoadLib
Imports RoadLib.Language

Module Engin
    Function LanguageSettingSet() As String
        Dim SetFile As String

        SetFile = "Setting.txt"

        Dim SetReader As New System.IO.StreamReader(SetFile)
        Dim LSetting As String
        While SetReader.Peek <> -1
            LSetting = SetReader.ReadLine()
            If InStr(LSetting, "Language=") > 0 Then
                LSetting = Mid(LSetting, 10)
                Return LSetting
            End If
        End While
        SetReader.Close()




    End Function
End Module
