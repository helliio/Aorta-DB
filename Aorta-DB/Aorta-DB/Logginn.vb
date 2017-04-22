Imports System.ComponentModel
'loginn side for brukere
Public Class Logginn
    'funsjon for å logge inn brukern til riktig gui
    Private Sub btnLogginn_Click(sender As Object, e As EventArgs) Handles btnLogginn.Click
        Try
            Dim id As Decimal = login(TxtPersonnummer.Text, txtPassord.Text)
            If id <> 0 Then
                Global_val.bruker = New User(id)
                If bruker.getUserType = 0 Then
                    BrukerHovedside.Show()
                    Me.Close()
                ElseIf bruker.getUserType = 1 Then
                    Ansatt.Show()
                    Me.Close()
                ElseIf bruker.getUserType = 2 Then
                    IktHovedside.Show()
                    Me.Close()
                End If
                TxtPersonnummer.Clear()
                txtPassord.Clear()
            Else
                MsgBox("Ugyldig brukernavn eller passord")
            End If
        Catch ex As Exception
            MsgBox("Feil brukernavn eller passord")
        End Try
    End Sub
    'viser glemt passord felter
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnGlemtpassord.Click
        Label4.Visible = True
        TextBox1.Visible = True
        Button2.Visible = True
    End Sub
    'navigerings knapper
    Private Sub btnEgenerklæring_Click(sender As Object, e As EventArgs) Handles btnEgenerklæring.Click
        EgenerklaeringLoggInn.Show()
        Me.Close()
    End Sub

    Private Sub Logginn_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Logginn_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Me.Hide()
    End Sub

    Private Sub btnNyBruker_Click_2(sender As Object, e As EventArgs) Handles btnNyBruker.Click
        NyBruker.Show()
        Me.Close()
    End Sub

    Private Sub logo_Click(sender As Object, e As EventArgs) Handles logo.Click
        Main.Show()
        Me.Close()
    End Sub
    'sender nytt passord til brukern
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim persnr As Decimal
        If IsNumeric(TextBox1.Text) And TextBox1.Text.Length = 11 Then
            persnr = Convert.ToDecimal(TextBox1.Text)
        Else
            'some error
            MsgBox("invalid personnummer")
            Exit Sub
        End If
        send_new_password(persnr)
    End Sub
End Class