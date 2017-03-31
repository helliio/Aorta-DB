Imports System.ComponentModel

Public Class EgenErklaering7
    Private Sub btnTilbake_Click(sender As Object, e As EventArgs) Handles btnTilbake.Click
        Close()
    End Sub

    Private Sub EgenErklaering7_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        EgenErklaering6.Show()
        Me.Hide()
    End Sub

    Private Sub EgenErklaering7_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Sub clear()
        radbtnja49.Checked = False
        radbtnnei49.Checked = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        EgenErklaering8.Show()
    End Sub
End Class