Public Class Main
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim d = DateTime.Now
        Debug.Print(d.ToString("HH:mm dd/MM/yyyy"))
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLoggInn.Click
        Logginn.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnEgenerklæring.Click
        EgenerklaeringLoggInn.Show()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        BlodGivning.Show()
    End Sub


End Class
