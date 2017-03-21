Imports System.ComponentModel

Public Class EgenErklaering2
    Private Sub EgenErklaering2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnTilbake_Click(sender As Object, e As EventArgs) Handles btnTilbake.Click
        Close()
    End Sub

    Private Sub EgenErklaering2_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        EgenErklaering.Show()
        Me.Hide()
    End Sub
    Public Sub clear()
        CheckBox12.Checked = False
        CheckBox13.Checked = False
        CheckBox14.Checked = False
        CheckBox15.Checked = False
        CheckBox16.Checked = False
        CheckBox17.Checked = False
        CheckBox18.Checked = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        erklaring.setAns(12, CheckBox12.Checked)
        erklaring.setAns(13, CheckBox13.Checked)
        erklaring.setAns(14, CheckBox14.Checked)
        erklaring.setAns(15, CheckBox15.Checked)
        erklaring.setAns(16, CheckBox16.Checked)
        erklaring.setAns(17, CheckBox17.Checked)
        erklaring.setAns(18, CheckBox18.Checked)
        EgenErklaering3.Show()
        Me.Hide()
    End Sub
End Class