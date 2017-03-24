Imports System.ComponentModel

Public Class EgenErklaering4
    Private Sub btnTilbake_Click(sender As Object, e As EventArgs) Handles btnTilbake.Click
        Close()
    End Sub

    Private Sub EgenErklaering4_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        EgenErklaering3.Show()
        Me.Hide()
    End Sub

    Private Sub EgenErklaering4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Sub clear()
        radbtnja29.Checked = False
        radbtnnei29.Checked = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        erklaring.setAns(29, radbtnja29.Checked)
        EgenErklaering5.Show()
        Me.Hide()
    End Sub


End Class