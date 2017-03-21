Public Class EgenErklaering_class
    Private answer(58) As Boolean
    Private pers As Decimal
    Private land As String
    Public Sub New(ByVal personnummer As Decimal)
        pers = personnummer
        For index As Integer = 0 To 58
            answer(index) = False
        Next
    End Sub
    Public Sub setAns(i As Integer, val As Boolean)
        answer(i - 1) = val
    End Sub
    Public Function getAns(i As Integer)
        Return answer(i)
    End Function
    Public Sub setLand(inn As String)
        land = inn
    End Sub
    Public Function getLand(inn As String)
        Return land(inn)
    End Function
    Public Sub send()

    End Sub
End Class
