Public Class Main
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLoggInn.Click
        Logginn.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnEgenerklæring.Click
        EgenerklaeringLoggInn.Show()
        Me.Hide()
    End Sub


    Private Sub btnNyBruker_Click(sender As Object, e As EventArgs) Handles btnNyBruker.Click
        NyBruker.Show()
        Me.Hide()
    End Sub
End Class
