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
        If TextBox1.Text <> "" Then
            erklaring.setAns(50, radbtnja50.Checked)
            erklaring.setAns(51, radbtnja51.Checked)
            erklaring.setAns(52, radbtnja52.Checked)
            erklaring.setAns(53, radbtnja53.Checked)
            erklaring.setAns(54, radbtnja54.Checked)
            erklaring.setAns(55, radbtnja55.Checked)
            erklaring.setAns(56, radbtnja56.Checked)
            erklaring.setAns(57, radbtnja57.Checked)
            erklaring.setAns(58, radbtnja58.Checked)
            erklaring.setAns(59, radbtnja59.Checked)
            erklaring.setLand(TextBox1.Text)
            erklaring.send()
            BrukerHovedside.Show()
            Me.Hide()
        Else
            MsgBox("Du må skrive inn et land i tekstboksen")
        End If
    End Sub
    Private Sub send()
        EgenErklaering7.Close()
    End Sub
    Public Sub clear()
        radbtnja50.Checked = False
        radbtnja51.Checked = False
        radbtnja52.Checked = False
        radbtnja53.Checked = False
        radbtnja54.Checked = False
        radbtnja55.Checked = False
        radbtnja56.Checked = False
        radbtnja57.Checked = False
        radbtnja58.Checked = False
        radbtnja59.Checked = False
        radbtnnei50.Checked = True
        radbtnnei51.Checked = True
        radbtnnei52.Checked = True
        radbtnnei53.Checked = True
        radbtnnei54.Checked = True
        radbtnnei55.Checked = True
        radbtnnei56.Checked = True
        radbtnnei57.Checked = True
        radbtnnei58.Checked = True
        radbtnnei59.Checked = True
        TextBox1.Text = ""
    End Sub
End Class