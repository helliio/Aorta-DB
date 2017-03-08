Public Class Logginn
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Debug.Print(login(TxtPersonnummer.Text, txtPassord.Text))
    End Sub
End Class