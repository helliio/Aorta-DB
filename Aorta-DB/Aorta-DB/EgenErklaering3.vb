Imports System.ComponentModel

Public Class EgenErklaering3

    Private Sub btnTilbake_Click(sender As Object, e As EventArgs) Handles btnTilbake.Click
        Close()
    End Sub

    Private Sub EgenErklaering3_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        EgenErklaering2.Show()
        Me.Hide()
    End Sub

    Private Sub EgenErklaering3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Sub clear()
        CheckBox19.Checked = False
        CheckBox20.Checked = False
        CheckBox21.Checked = False
        CheckBox23.Checked = False
        CheckBox24.Checked = False
        CheckBox25.Checked = False
        CheckBox26.Checked = False
        CheckBox27.Checked = False
        CheckBox28.Checked = False
        CheckBox29.Checked = False
    End Sub
End Class