Imports System.ComponentModel

Public Class EgenErklaering8
    Private Sub btnTilbake_Click(sender As Object, e As EventArgs) Handles btnTilbake.Click
        Close()
    End Sub

    Private Sub EgenErklaering8_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        EgenErklaering7.Show()
        Me.Hide()
    End Sub

    Private Sub EgenErklaering8_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
    Private Sub send()
        EgenErklaering7.Close()
    End Sub
    Public Sub clear()
        CheckBox51.Checked = False
        CheckBox52.Checked = False
        CheckBox53.Checked = False
        CheckBox54.Checked = False
        CheckBox55.Checked = False
        CheckBox56.Checked = False
        CheckBox57.Checked = False
        CheckBox58.Checked = False
        CheckBox59.Checked = False
        CheckBox60.Checked = False
        TextBox1.Text = ""
    End Sub
End Class