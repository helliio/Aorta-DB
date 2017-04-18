Imports System.ComponentModel

Public Class Logginn
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnLogginn.Click
        'Debug.Print(login(TxtPersonnummer.Text, txtPassord.Text))
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
    End Sub

    Private Sub btnNyBruker_Click(sender As Object, e As EventArgs)
        NyBruker.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnGlemtpassord.Click
        GlemtPassord.Show()
    End Sub



    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        Me.Close()
        Main.Show()
    End Sub

    Private Sub btnNyBruker_Click_1(sender As Object, e As EventArgs)
        Me.Close()
        NyBruker.Show()
    End Sub

    Private Sub btnEgenerklæring_Click(sender As Object, e As EventArgs)
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

    Private Sub btnEgenerklæring_Click_1(sender As Object, e As EventArgs) Handles btnEgenerklæring.Click
        EgenerklaeringLoggInn.Show()
        Me.Close()
    End Sub
    Private Sub logo_Click(sender As Object, e As EventArgs) Handles logo.Click
        Main.Show()
        Me.Close()
    End Sub
End Class