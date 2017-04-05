Imports System.ComponentModel

Public Class EgenErklaering6
    Private Sub btnTilbake_Click(sender As Object, e As EventArgs)
        Close()
    End Sub


    Public Sub clear()
        radbtnja45.Checked = False
        radbtnja46.Checked = False
        radbtnja47.Checked = False
        radbtnja48.Checked = False
        radbtnnei45.Checked = True
        radbtnnei46.Checked = True
        radbtnnei47.Checked = True
        radbtnnei48.Checked = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        erklaring.setAns(45, radbtnja45.Checked)
        erklaring.setAns(46, radbtnja46.Checked)
        erklaring.setAns(47, radbtnja47.Checked)
        erklaring.setAns(48, radbtnja48.Checked)
        EgenErklaering7.Show()
        Me.Hide()
    End Sub

    Private Sub EgenErklaering6_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        EgenErklaering5.Show()
        Me.Hide()
    End Sub
End Class