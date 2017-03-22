Public Class Main
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLoggInn.Click
        Logginn.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnEgenerklæring.Click
        EgenerklaeringLoggInn.Show()
    End Sub
End Class
