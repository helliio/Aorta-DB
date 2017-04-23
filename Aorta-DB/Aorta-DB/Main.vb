'første side brukern ser når programmet starte opp
Public Class Main
    'knapp til loginn skjerm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLoggInn.Click
        Logginn.Show()
        Me.Hide()
    End Sub
    'knapp til egenerklaring loginn skjerm
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnEgenerklæring.Click
        EgenerklaeringLoggInn.Show()
        Me.Hide()
    End Sub
    'knapp til bruker registrering
    Private Sub btnNyBruker_Click(sender As Object, e As EventArgs) Handles btnNyBruker.Click
        NyBruker.Show()
        Me.Hide()
    End Sub

    Private Sub btnKontakt_Click(sender As Object, e As EventArgs) Handles btnKontakt.Click
        MsgBox("Tlf: 12345678" & vbNewLine & "Epost: kontakt@aorta.db")
    End Sub
End Class
