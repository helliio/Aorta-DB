Public Class Logginn
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Debug.Print(login(TxtPersonnummer.Text, txtPassord.Text))
    End Sub

    Private Sub btnNyBruker_Click(sender As Object, e As EventArgs) Handles btnNyBruker.Click
        NyBruker.Show()
        Me.Hide()
    End Sub

    Private Sub Logginn_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class