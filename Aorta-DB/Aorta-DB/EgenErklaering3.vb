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
        CheckBox22.Checked = False
        CheckBox23.Checked = False
        CheckBox24.Checked = False
        CheckBox25.Checked = False
        CheckBox26.Checked = False
        CheckBox27.Checked = False
        CheckBox28.Checked = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        erklaring.setAns(19, CheckBox19.Checked)
        erklaring.setAns(20, CheckBox20.Checked)
        erklaring.setAns(21, CheckBox21.Checked)
        erklaring.setAns(22, CheckBox22.Checked)
        erklaring.setAns(23, CheckBox22.Checked)
        erklaring.setAns(24, CheckBox23.Checked)
        erklaring.setAns(25, CheckBox24.Checked)
        erklaring.setAns(26, CheckBox25.Checked)
        erklaring.setAns(27, CheckBox26.Checked)
        erklaring.setAns(28, CheckBox27.Checked)
        EgenErklaering4.Show()
        Me.Hide()
    End Sub
End Class