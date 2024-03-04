Public Class Project
    Dim ListPointTopo As New List(Of PointTopo)

    Sub AddPointTopo(_Ref As Double, _X As Double, _Y As Double, _Z As Double, _CODE As Double)
        ListPointTopo.Add(New PointTopo(_Ref, _X, _Y, _Z, _CODE))
    End Sub
    Sub ModPointTopo()

    End Sub
    Function RemovePointTopo() As Boolean

    End Function
    Function FindPointTopo() As PointTopo

    End Function
End Class
