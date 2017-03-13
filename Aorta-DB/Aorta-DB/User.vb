Public Class User
    Private personnr As Decimal
    Private type As Integer
    Private fornavn As String
    Private etternavn As String
    Private list As New ArrayList
    Public Sub New(ByVal personnummer As Decimal)
        list = return_user(personnummer)
        personnr = list(0)
        type = list(4)
        fornavn = list(2)
        etternavn = list(3)
    End Sub
End Class
