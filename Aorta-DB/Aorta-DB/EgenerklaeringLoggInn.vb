Imports System.ComponentModel

Public Class EgenerklaeringLoggInn
    Private Sub Button2_Click(sender As Object, e As EventArgs)
        'Debug.Print(login(TxtPersonnummer.Text, txtPassord.Text))
        Dim id As Decimal = login(TxtPersonnummer.Text, txtPassord.Text)
        If id <> 0 Then
            Global_val.bruker = New User(id)
            If bruker.getUserType = 0 Then
                EgenErklaering.Show()
                Me.Close()
                TxtPersonnummer.Clear()
                txtPassord.Clear()
            Else
                MsgBox("Feil brukergruppe")
            End If
        Else
            MsgBox("Ugyldig brukernavn eller passord")
        End If
    End Sub

    Private Sub EgenerklaeringLoggInn_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Me.Hide()
        Main.Show()
    End Sub

    Private Sub EgenerklaeringLoggInn_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Close()
        Main.Show()
    End Sub

    Private Sub btnNyBruker_Click(sender As Object, e As EventArgs) Handles btnNyBruker.Click
        NyBruker.Show()
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
End Class