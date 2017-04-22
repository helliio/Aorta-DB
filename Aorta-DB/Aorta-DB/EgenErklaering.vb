Imports System.ComponentModel
'egenerklarings skjema første side
Public Class EgenErklaering
    Private Sub EgenErklaering_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
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
    'laster inn data som paker til hvilken bruker og time egenerklaringen tilhører også generer en nytt object som er en egenerklaring
    Private Sub EgenErklaering_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Global_val.erklaring = New EgenErklaering_class(bruker.getPersonnr)
        Dim timer = 0
        Dim list As ArrayList = get_appointment_date(bruker.getPersonnr)
        Dim dt_list As New ArrayList
        Dim d = DateTime.Now
        For Each item In list
            dt_list.Add(CDate(item))
        Next
        For Each item As Date In dt_list
            If item >= d Then
                Dim i As String = item.ToString("HH.mm dd.MM.yyyy")
                Label14.Text = i
                erklaring.setDate(i)
                timer += 1
            End If
        Next
        If timer <> 1 Then
            MsgBox("Du har ingen time, bestill en time før du kan gjøre egenerklæringen")
            Me.Close()
        End If
    End Sub
    'knapp tilbake
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
    'reset radio knapper
    Public Sub clear()
        radbtnja1.Checked = False
        radbtnja2.Checked = False
        radbtnja3.Checked = False
        radbtnja4.Checked = False
        radbtnja5.Checked = False
        radbtnja6.Checked = False
        radbtnja7.Checked = False
        radbtnja8.Checked = False
        radbtnja9.Checked = False
        radbtnja10.Checked = False
        radbtnja11.Checked = False
        radbtnnei1.Checked = True
        radbtnnei2.Checked = True
        radbtnnei3.Checked = True
        radbtnnei4.Checked = True
        radbtnnei5.Checked = True
        radbtnnei6.Checked = True
        radbtnnei7.Checked = True
        radbtnnei8.Checked = True
        radbtnnei9.Checked = True
        radbtnnei10.Checked = True
        radbtnnei11.Checked = True
    End Sub
    'knapp til neste side alle neste knapper i egenerklaring setter også verdier i egenerklarings klassen
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        erklaring.setAns(1, radbtnja1.Checked)
        erklaring.setAns(2, radbtnja2.Checked)
        erklaring.setAns(3, radbtnja3.Checked)
        erklaring.setAns(4, radbtnja4.Checked)
        erklaring.setAns(5, radbtnja5.Checked)
        erklaring.setAns(6, radbtnja6.Checked)
        erklaring.setAns(7, radbtnja7.Checked)
        erklaring.setAns(8, radbtnja8.Checked)
        erklaring.setAns(9, radbtnja9.Checked)
        erklaring.setAns(10, radbtnja10.Checked)
        erklaring.setAns(11, radbtnja11.Checked)
        EgenErklaering2.Show()
        Me.Hide()
    End Sub
    'navigerings knapper
    Private Sub btnLoggUt_Click(sender As Object, e As EventArgs) Handles btnLoggUt.Click
        Main.Show()
        Me.Close()
    End Sub

    Private Sub btnBestill_Click(sender As Object, e As EventArgs) Handles btnBestill.Click
        MsgBox("Du kan ikke ha mer enn en time")
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