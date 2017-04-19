Imports System.ComponentModel

Public Class IktHovedside
    Private Sub btnNyAnsatt_Click(sender As Object, e As EventArgs) Handles btnNyAnsatt.Click
        NyAnsatt.Show()
        Me.Hide()
    End Sub

    Private Sub btnLoggUt_Click(sender As Object, e As EventArgs) Handles btnLoggUt.Click
        Main.Show()
        Me.Close()
    End Sub

    Private Sub IktHovedside_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Me.Hide()
    End Sub

    Private Sub btnStatistikk_Click(sender As Object, e As EventArgs) Handles btnStatistikk.Click
        IktStatestikk.Show()
        Me.Hide()
    End Sub
End Class