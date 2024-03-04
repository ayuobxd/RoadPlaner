Public Class Language


    Public Structure LangS
        Public French, English, Arabic As String

    End Structure

    Public LangSL As New List(Of LangS)

    Function Lang(LN As String) As String()

        Dim FileFr As String
        Dim FileEn As String
        Dim FileAr As String

        FileFr = "Fr.txt"
        FileEn = "En.txt"
        FileAr = "Ar.txt"

        LangSL.Clear()

        Dim objReaderFr As New System.IO.StreamReader(FileFr)
        Dim objReaderEn As New System.IO.StreamReader(FileEn)
        Dim objReaderAr As New System.IO.StreamReader(FileAr)
        Dim A As String
        Do While objReaderFr.Peek() <> -1 And objReaderEn.Peek() <> -1
            Dim P As LangS
            P.French = objReaderFr.ReadLine()
            P.English = objReaderEn.ReadLine()
            P.Arabic = objReaderAr.ReadLine()
            LangSL.Add(P)
        Loop

        Dim strData(LangSL.Count - 1) As String

        If LN = "Fr" Then
            For i = 0 To LangSL.Count - 1
                strData(i) = LangSL.Item(i).French
            Next i

        ElseIf LN = "En" Then
            For i = 0 To LangSL.Count - 1
                strData(i) = LangSL.Item(i).English
            Next i

        ElseIf LN = "Ar" Then
            For i = 0 To LangSL.Count - 1
                strData(i) = LangSL.Item(i).Arabic
            Next i
        End If
        Return strData

    End Function
End Class
