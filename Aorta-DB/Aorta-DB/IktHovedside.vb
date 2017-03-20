Imports System.ComponentModel

Public Class IktHovedside

    Private Sub btnNyBruker_Click(sender As Object, e As EventArgs)
        NyBruker.Show()
        Me.Hide()
    End Sub

    Private Sub btnNyAnsatt_Click(sender As Object, e As EventArgs) Handles btnNyAnsatt.Click
        NyAnsatt.Show()
        Me.Hide()
    End Sub

    Private Sub btnLoggUt_Click(sender As Object, e As EventArgs) Handles btnLoggUt.Click
        Me.Close()
    End Sub

    Private Sub IktHovedside_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub IktHovedside_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Logginn.Show()
        Me.Hide()
    End Sub
End Class