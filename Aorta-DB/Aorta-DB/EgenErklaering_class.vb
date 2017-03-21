Public Class EgenErklaering_class
    Private answer(59) As Boolean
    Private pers As Decimal
    Public Sub New(ByVal personnummer As Decimal)
        pers = personnummer
        For index As Integer = 0 To 59
            answer(index) = False
        Next
    End Sub
    Public Sub setAns(i As Integer)
        answer(i) = True
    End Sub
    Public Function getAns(i As Integer)
        Return answer(i)
    End Function
    Public Sub send()

    End Sub
End Class
