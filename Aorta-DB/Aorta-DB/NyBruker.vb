﻿Imports System.ComponentModel
Imports System.Text.RegularExpressions

Public Class NyBruker
    Private Sub NyBruker_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub lblNybruker_Click(sender As Object, e As EventArgs) Handles lblNybruker.Click

    End Sub

    Private Sub btnTilbake_Click(sender As Object, e As EventArgs) Handles btnTilbake.Click
        Logginn.Show()
        Me.Hide()
    End Sub
    Function validateEmail(emailAddress) As Boolean

        Dim email As New Regex("([\w-+]+(?:\.[\w-+]+)*@(?:[\w-]+\.)+[a-zA-Z]{2,7})")
        If email.IsMatch(emailAddress) Then
            Return True
        Else
            Return False
        End If
    End Function
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
            Exit Sub
        End If
        Try
            create_user(persnr, txtPassord.Text, txtFornavn.Text, txtEtternavn.Text, 0, tlf, txtMail.Text, txtAdresse.Text, postnr, txtPoststed.Text)
        Catch ex As Exception
            MsgBox("DB error")
            Exit Sub
        End Try
        Logginn.Show()
        Me.Hide()
    End Sub

    Private Sub NyBruker_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        End
    End Sub
End Class