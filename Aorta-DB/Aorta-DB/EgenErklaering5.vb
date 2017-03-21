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
        CheckBox45.Checked = False
    End Sub
End Class