Imports System.ComponentModel

Public Class EgenErklaering
    Private Sub EgenErklaering_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        End
    End Sub

    Private Sub EgenErklaering_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnTilbake_Click(sender As Object, e As EventArgs) Handles btnTilbake.Click
        BrukerHovedside.Show()
        Me.Hide()
        Me.clear()
        EgenErklaering2.clear()
        EgenErklaering3.clear()
        EgenErklaering4.clear()
        EgenErklaering5.clear()
        EgenErklaering6.clear()
        EgenErklaering7.clear()
        EgenErklaering8.clear()
    End Sub
    Public Sub clear()
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox4.Checked = False
        CheckBox5.Checked = False
        CheckBox6.Checked = False
        CheckBox7.Checked = False
        CheckBox8.Checked = False
        CheckBox9.Checked = False
        CheckBox10.Checked = False
        CheckBox11.Checked = False
    End Sub
End Class