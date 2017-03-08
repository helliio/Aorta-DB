Public Class Main
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim user As Decimal = 12345678910
        Dim pass As String = "test"
        Debug.Print(DB_module.login(user, pass))
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Logginn.Show()
    End Sub
End Class
