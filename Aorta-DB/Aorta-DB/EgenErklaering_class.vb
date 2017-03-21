Public Class EgenErklaering_class
    Private answer(58) As Boolean
    Private pers As Decimal
    Public Sub New(ByVal personnummer As Decimal)
        pers = personnummer
        For index As Integer = 0 To 58
            answer(index) = False
        Next
    End Sub
    Public Sub setAns(i As Integer)
        answer(i - 1) = True
    End Sub
    Public Function getAns(i As Integer)
        Return answer(i)
    End Function
    Public Sub send()

    End Sub
End Class
