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
        radbtnja12.Checked = False
        radbtnja13.Checked = False
        radbtnja14.Checked = False
        radbtnja15.Checked = False
        radbtnja16.Checked = False
        radbtnja17.Checked = False
        radbtnja18.Checked = False
        radbtnnei12.Checked = True
        radbtnnei13.Checked = True
        radbtnnei14.Checked = True
        radbtnnei15.Checked = True
        radbtnnei16.Checked = True
        radbtnnei17.Checked = True
        radbtnnei18.Checked = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        erklaring.setAns(12, radbtnja12.Checked)
        erklaring.setAns(13, radbtnja13.Checked)
        erklaring.setAns(14, radbtnja14.Checked)
        erklaring.setAns(15, radbtnja15.Checked)
        erklaring.setAns(16, radbtnja16.Checked)
        erklaring.setAns(17, radbtnja17.Checked)
        erklaring.setAns(18, radbtnja18.Checked)
        EgenErklaering3.Show()
        Me.Hide()
    End Sub


End Class