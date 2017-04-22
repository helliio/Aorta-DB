Imports System.ComponentModel
'login side som tar deg rett til egenerklaring utfylling
Public Class EgenerklaeringLoggInn
    Private Sub EgenerklaeringLoggInn_Closing(sender As Object, e As CancelEventArgs) Handles MyBase.Closing
        Me.Hide()
    End Sub
    'navigerings knapper
    Private Sub btnNyBruker_Click(sender As Object, e As EventArgs) Handles btnNyBruker.Click
        NyBruker.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Logginn.Show()
        Me.Close()
    End Sub

    Private Sub logo_Click(sender As Object, e As EventArgs) Handles logo.Click
        Main.Show()
        Me.Close()
    End Sub
    'login knapp, fungerer samme som den på login siden
    Private Sub btnLogginn_Click(sender As Object, e As EventArgs) Handles btnLogginn.Click
        Try
            Dim id As Decimal = login(TxtPersonnummer.Text, txtPassord.Text)
            If id <> 0 Then
                Global_val.bruker = New User(id)
                If bruker.getUserType = 0 Then
                    EgenErklaering.Show()
                    Me.Close()
                ElseIf bruker.getUserType = 1 Or bruker.getUserType = 2 Then
                    MsgBox("Feil brukergruppe")
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
End Class