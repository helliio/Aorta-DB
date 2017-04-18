Imports System.ComponentModel

Public Class IktStatistikk
    Private Sub btnLoggUt_Click(sender As Object, e As EventArgs) Handles btnLoggUt.Click
        Main.Show()
        Me.Hide()
    End Sub

    Private Sub btnMinSide_Click(sender As Object, e As EventArgs) Handles btnMinSide.Click
        IktHovedside.Show()
        Me.Close()
    End Sub

    Private Sub btnNyAnsatt_Click(sender As Object, e As EventArgs) Handles btnNyAnsatt.Click
        NyAnsatt.Show()
        Me.Close()
    End Sub

    Private Sub IktStatistikk_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Me.Hide()
    End Sub
End Class