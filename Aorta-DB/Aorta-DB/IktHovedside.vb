Public Class IktHovedside
    Private Sub btnNyBruker_Click(sender As Object, e As EventArgs)
        NyBruker.Show()
        Me.Hide()
    End Sub

    Private Sub btnNyAnsatt_Click(sender As Object, e As EventArgs) Handles btnNyAnsatt.Click
        NyAnsatt.Show()
        Me.Hide()
    End Sub
End Class