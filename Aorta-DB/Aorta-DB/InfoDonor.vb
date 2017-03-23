Imports System.ComponentModel

Public Class InfoDonor
    Private Sub InfoDonor_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Me.Hide()
    End Sub

    Private Sub InfoDonor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnTilbake_Click(sender As Object, e As EventArgs) Handles btnTilbake.Click
        AnsattBrukerOversikt.Show()
        Me.Close()
    End Sub
End Class