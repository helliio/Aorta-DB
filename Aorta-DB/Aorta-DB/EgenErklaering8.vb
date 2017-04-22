Imports System.ComponentModel
'siste side til egenerklaringen
Public Class EgenErklaering8
    'knapp tilbake
    Private Sub btnTilbake_Click(sender As Object, e As EventArgs) Handles btnTilbake.Click
        EgenErklaering7.Show()
        Me.Hide()
    End Sub
    'hånterer lunking av siden
    Private Sub EgenErklaering8_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Me.Hide()
        Me.clear()
        EgenErklaering2.clear()
        EgenErklaering3.clear()
        EgenErklaering4.clear()
        EgenErklaering5.clear()
        EgenErklaering6.clear()
        EgenErklaering7.clear()
        EgenErklaering.clear()
    End Sub
    'sneder egenerklaringen ti databasen
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
            Me.Close()
        Else
            MsgBox("Du må skrive inn et land i tekstboksen")
        End If
    End Sub
    'resetter radiokanppene
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
    'navigerings knapper
    Private Sub btnLoggUt_Click(sender As Object, e As EventArgs) Handles btnLoggUt.Click
        Main.Show()
        Me.Close()
    End Sub

    Private Sub btnBestill_Click(sender As Object, e As EventArgs) Handles btnBestill.Click
        MsgBox("Du kan ikke ha mer enn en time")
    End Sub

    Private Sub btnAvbestill2_Click(sender As Object, e As EventArgs)
        MsgBox("Du kan ikke avbestille timen på dette tidspunktet. Gå ut av egenerklæringen og prøv igjen")
    End Sub

    Private Sub btnTimeinfo_Click(sender As Object, e As EventArgs) Handles btnTimeinfo.Click
        InfoBruker.Show()
        Me.Close()
    End Sub

    Private Sub btnMinSide_Click(sender As Object, e As EventArgs) Handles btnMinSide.Click
        BrukerHovedside.Show()
        Me.Close()
    End Sub
End Class