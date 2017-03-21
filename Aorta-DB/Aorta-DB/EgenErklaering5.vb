Imports System.ComponentModel

Public Class EgenErklaering5
    Private Sub btnTilbake_Click(sender As Object, e As EventArgs) Handles btnTilbake.Click
        Close()
    End Sub

    Private Sub EgenErklaering5_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        EgenErklaering4.Show()
        Me.Hide()
    End Sub

    Private Sub EgenErklaering5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Sub clear()
        CheckBox30.Checked = False
        CheckBox31.Checked = False
        CheckBox32.Checked = False
        CheckBox33.Checked = False
        CheckBox34.Checked = False
        CheckBox35.Checked = False
        CheckBox36.Checked = False
        CheckBox37.Checked = False
        CheckBox38.Checked = False
        CheckBox39.Checked = False
        CheckBox40.Checked = False
        CheckBox41.Checked = False
        CheckBox42.Checked = False
        CheckBox43.Checked = False
        CheckBox44.Checked = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        erklaring.setAns(30, CheckBox30.Checked)
        erklaring.setAns(31, CheckBox31.Checked)
        erklaring.setAns(32, CheckBox32.Checked)
        erklaring.setAns(33, CheckBox33.Checked)
        erklaring.setAns(34, CheckBox34.Checked)
        erklaring.setAns(35, CheckBox35.Checked)
        erklaring.setAns(36, CheckBox36.Checked)
        erklaring.setAns(37, CheckBox37.Checked)
        erklaring.setAns(38, CheckBox38.Checked)
        erklaring.setAns(39, CheckBox39.Checked)
        erklaring.setAns(40, CheckBox40.Checked)
        EgenErklaering6.Show()
        Me.Hide()
    End Sub
End Class