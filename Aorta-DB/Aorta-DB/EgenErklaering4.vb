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
        CheckBox30.Checked = False
    End Sub
End Class