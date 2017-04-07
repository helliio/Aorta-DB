Imports System.ComponentModel

Public Class TimeInfoAnsatt
    Private Sub btnTilbake_Click(sender As Object, e As EventArgs) Handles btnTilbake.Click
        Me.Close()
        AnsattBrukerOversikt.Show()
    End Sub

    Private Sub TimeInfoAnsatt_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Me.Hide()
    End Sub


End Class