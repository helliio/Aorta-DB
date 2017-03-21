Public Class Main
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim booooo(3) As Boolean
        booooo(0) = True
        booooo(1) = True
        booooo(2) = True
        booooo(3) = True
        DB_module.create_erklaring(1234324, booooo, "kjdshfdsfwf")
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLoggInn.Click
        Logginn.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnEgenerklæring.Click
        EgenerklaeringLoggInn.Show()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        TimeBestilling.Show()
    End Sub


End Class
