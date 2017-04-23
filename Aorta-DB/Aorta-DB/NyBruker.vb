Imports System.ComponentModel
Imports System.Text.RegularExpressions
'side for å lage ny bruker
Public Class NyBruker
    'knapp tilbake
    Private Sub btnTilbake_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
    'funsjon for å skjekke om eposten er valid
    Function validateEmail(emailAddress) As Boolean
        Dim email As New Regex("([\w-+]+(?:\.[\w-+]+)*@(?:[\w-]+\.)+[a-zA-Z]{2,7})")
        If email.IsMatch(emailAddress) Then
            Return True
        Else
            Return False
        End If
    End Function
    'lager ny bruker ved å sende info ti databasen
    Private Sub btnNybruker_Click(sender As Object, e As EventArgs) Handles btnNybruker.Click
        Dim persnr As Decimal
        Dim tlf As Decimal
        Dim postnr As Integer
        If IsNumeric(txtPersonnummer.Text) And txtPersonnummer.Text.Length = 11 Then
            persnr = Convert.ToDecimal(txtPersonnummer.Text)
        Else
            'some error
            MsgBox("invalid personnummer")
            Exit Sub
        End If
        If IsNumeric(txtTelefon.Text) And txtTelefon.Text.Length >= 8 Then
            tlf = Convert.ToDecimal(txtTelefon.Text)
        Else
            'some error
            MsgBox("invalid telefonnummer")
            Exit Sub
        End If
        If Not validateEmail(txtMail.Text) Then
            'some error
            MsgBox("invalid email")
            Exit Sub
        End If
        If IsNumeric(txtPostnummer.Text) And txtPostnummer.Text.Length = 4 Then
            postnr = CInt(txtPostnummer.Text)
        Else
            'some error
            MsgBox("invalid postnummer")
            Exit Sub
        End If
        If Not txtPassord.Text.Length >= 8 Then
            MsgBox("Passord må være lengre enn 8 tegn")
            Exit Sub
        End If

        If txtPassord.Text <> txtBekreftpass.Text Then
            'some error
            MsgBox("Din gjentatt passord er ulik orginalen")
            Exit Sub
        End If
        Try
            create_user(persnr, txtPassord.Text, txtFornavn.Text, txtEtternavn.Text, 0, tlf, txtMail.Text, txtAdresse.Text, postnr, txtPoststed.Text)
            Me.Close()
        Catch ex As Exception
            MsgBox("Bruker allerede eksisterer")
            Exit Sub
        End Try
        Logginn.Show()
        Me.Hide()
    End Sub
    'navigerings knapper
    Private Sub NyBruker_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Me.Hide()
    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Logginn.Show()
        Me.Hide()
    End Sub

    Private Sub logo_Click(sender As Object, e As EventArgs) Handles logo.Click
        Main.Show()
        Me.Close()
    End Sub

    Private Sub btnEgenerklæring_Click(sender As Object, e As EventArgs) Handles btnEgenerklæring.Click
        EgenerklaeringLoggInn.Show()
        Me.Close()
    End Sub

    Private Sub btnKontakt_Click(sender As Object, e As EventArgs) Handles btnKontakt.Click
        MsgBox("Tlf: 12345678" & vbNewLine & "Epost: kontakt@aorta.db")
    End Sub
End Class