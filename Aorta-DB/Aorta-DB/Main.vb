Public Class Main
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim user As Decimal = 12345678910
        Dim pass As String = "test"
        Debug.Print(DB_module.login(user, pass))
    End Sub
End Class
