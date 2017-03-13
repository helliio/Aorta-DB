Public Class Logginn
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Debug.Print(login(TxtPersonnummer.Text, txtPassord.Text))
        'BrukerHovedside.Show()
        Me.Hide()
    End Sub

    Private Sub btnNyBruker_Click(sender As Object, e As EventArgs) Handles btnNyBruker.Click
        NyBruker.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Ansatt.Show()
        Me.Hide()
    End Sub
End Class