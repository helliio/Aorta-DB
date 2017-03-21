Imports System.ComponentModel

Public Class EgenerklaeringLoggInn
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnLoggInn.Click
        Debug.Print(login(TxtPersonnummer.Text, txtPassord.Text))
        Dim id As Decimal = login(TxtPersonnummer.Text, txtPassord.Text)
        If id <> 0 Then
            Global_val.bruker = New User(id)
            If bruker.getUserType = 0 Then
                EgenErklaering.Show()
                Me.Hide()
            Else
                MsgBox("Feil brukergruppe")
            End If
        Else
            MsgBox("Ugyldig brukernavn eller passord")
        End If
    End Sub

    Private Sub EgenerklaeringLoggInn_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Main.Show()
        Me.Hide()
    End Sub

    Private Sub EgenerklaeringLoggInn_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class