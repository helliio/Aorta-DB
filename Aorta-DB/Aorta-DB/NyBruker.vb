Public Class NyBruker
    Private Sub NyBruker_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub lblNybruker_Click(sender As Object, e As EventArgs) Handles lblNybruker.Click

    End Sub

    Private Sub btnTilbake_Click(sender As Object, e As EventArgs) Handles btnTilbake.Click
        Logginn.Show()
        Me.Hide()
    End Sub
End Class