
Imports System.Diagnostics.Eventing
Imports System.Drawing.Imaging
Imports System.IO
Imports RoadLib
Imports RoadLib.Language

Module Engin
    Dim SetFile As String = "Setting.txt"
    Dim project As New Project
    Function LanguageSettingGet() As String

        Dim SetReader As New System.IO.StreamReader(SetFile)
        Dim LSetting As String
        While SetReader.Peek <> -1
            LSetting = SetReader.ReadLine()
            If InStr(LSetting, "Language=") > 0 Then
                LSetting = Mid(LSetting, 10)
                SetReader.Close()
                Return LSetting

            End If
        End While
        SetReader.Close()
        Dim a As String
        Dim CORD() As String = A.Split(vbTab)
        project.AddPointTopo()

        Return "En"
    End Function
    Sub LanguageSettingSet(LSet As String)
        Dim SettingL As New List(Of String)

        Dim Reader As New System.IO.StreamReader(SetFile)
        Dim StepString As String
        Do While Reader.Peek() <> -1
            StepString = Reader.ReadLine().ToString
            SettingL.Add(StepString)

        Loop

        Reader.Close()
        SettingL.Item(1) = "Language=" & LSet

        Dim File As System.IO.StreamWriter
        File = My.Computer.FileSystem.OpenTextFileWriter(SetFile, False)
        For i = 0 To SettingL.Count - 1
            File.WriteLine(SettingL.Item(i))
        Next
        File.Close()
    End Sub

    Sub DrawPoint()


    End Sub



End Module
