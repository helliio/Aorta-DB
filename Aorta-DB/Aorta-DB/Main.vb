Public Class Main
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLoggInn.Click
        Logginn.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnEgenerklæring.Click
        EgenerklaeringLoggInn.Show()
        Me.Hide()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class
