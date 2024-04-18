Imports System.Text

Imports System.IO

Imports System.Collections.Generic
Imports System.Runtime.ConstrainedExecution
Imports System.Reflection.Emit
Public Class Project


    Public ListPointTopo As New List(Of PointTopo)





    Sub AddPointTopo(_Name As String, _Ref As Integer, _X As Double, _Y As Double, _Z As Double, _CODE As Double)




        ListPointTopo.Add(New PointTopo(_Name, _Ref, _X, _Y, _Z, _CODE))

    End Sub



    Sub ModPointTopo()

    End Sub

    Function RemovePointTopo(v As Integer) As Boolean
        For Each C As PointTopo In ListPointTopo
            If C.Ref = v Then
                ListPointTopo.RemoveAt(v)
            End If

        Next
        Return Nothing
    End Function

    Sub pointW()
        For Each c As PointTopo In ListPointTopo
            Console.WriteLine(c.Name & "_" & c.Ref & "_" & c.X & "_" & c.Y & "_" & c.Z & "_" & c.Code)
        Next
    End Sub

    Public Function FindPointTopo(v As Integer) As PointTopo


        For Each C As PointTopo In ListPointTopo
            If C.Ref = v Then
                Return C
            End If

        Next
        Return Nothing
    End Function
End Class
