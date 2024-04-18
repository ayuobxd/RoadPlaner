
Imports System.Diagnostics.Eventing
Imports System.Drawing.Imaging
Imports System.IO
Imports RoadLib
Imports RoadLib.Language
Imports RoadLib.Project


Module Engine
    Dim SetFile As String = "Setting.txt"
    Public project As New Project
    Public Lang As New Language

    Dim LPCount As Integer

    Public LayerT As New List(Of String)
    Public LayerP As New List(Of String)



    Public Structure PointS
        Dim SName As String
        Dim ShowX As Boolean
        Dim ShowY As Boolean
        Dim ShowZ As Boolean
        Dim ShowId As Boolean
        Dim ShowCode As Boolean
        Dim FileS As String
        Dim PosX As Integer
        Dim PosY As Integer
        Dim PosZ As Integer
        Dim PosId As Integer
        Dim PosCode As Integer
        Dim FontS As String
        Dim StationCode As String
    End Structure



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



    Sub GetPoint(File As String, Strct As String, FileN As Integer)
        Dim Reader As New System.IO.StreamReader(File)
        Dim StepString As String
        Do While Reader.Peek() <> -1
            StepString = Reader.ReadLine().ToString

            Dim CORD() As String = StepString.Split(vbTab)
            LPCount += 1

            Select Case Strct
                Case "0"
                    project.AddPointTopo(FileN & "," & LPCount, CORD(0), CORD(1), CORD(2), CORD(3), CORD(4))
                Case "1"
                    project.AddPointTopo(FileN & "," & LPCount, 0, CORD(0), CORD(1), CORD(2), CORD(3))
                Case "2"
                    project.AddPointTopo(FileN & "," & LPCount, CORD(0), CORD(1), CORD(2), CORD(3), 0)
                Case "3"
                    project.AddPointTopo(FileN & "," & LPCount, 0, CORD(0), CORD(1), CORD(2), 0)

            End Select


        Loop


    End Sub



End Module
