Imports System.ComponentModel
Imports System.Text.RegularExpressions
'side for å lage nye ansattbrukere
Public Class NyAnsatt
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
        If IsNumeric(txtPersonnummer.Text) Then
            persnr = Convert.ToDecimal(txtPersonnummer.Text)
        Else
            'some error
            MsgBox("Ugyldig personnummer")
            Exit Sub
        End If
        If IsNumeric(txtTelefon.Text) And txtTelefon.Text.Length >= 8 Then
            tlf = Convert.ToDecimal(txtTelefon.Text)
        Else
            'some error
            MsgBox("Ugyldig telefonnummer")
            Exit Sub
        End If
        If Not validateEmail(txtMail.Text) Then
            'some error
            MsgBox("Ugyldig email")
            Exit Sub
        End If
        If IsNumeric(txtPostnummer.Text) And txtPostnummer.Text.Length = 4 Then
            postnr = CInt(txtPostnummer.Text)
        Else
            'some error
            MsgBox("Ugyldig postnummer")
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
            create_user(persnr, txtPassord.Text, txtFornavn.Text, txtEtternavn.Text, 1, tlf, txtMail.Text, txtAdresse.Text, postnr, txtPoststed.Text)
            Me.Close()
        Catch ex As Exception
            MsgBox("Bruker allerede eksisterer")
            Exit Sub
        End Try
    End Sub
    'navigerings knapper
    Private Sub NyAnsatt_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Me.Hide()
    End Sub

    Private Sub btnStatistikk_Click(sender As Object, e As EventArgs) Handles btnStatistikk.Click
        IktStatestikk.Show()
        Me.Close()
    End Sub

    Private Sub btnMinSide_Click(sender As Object, e As EventArgs) Handles btnMinSide.Click
        IktHovedside.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Main.Show()
        Me.Close()
    End Sub
End Class