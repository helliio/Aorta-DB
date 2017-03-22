Imports System.ComponentModel

Public Class EgenErklaering
    Private Sub EgenErklaering_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        BrukerHovedside.Show()
        Me.Hide()
    End Sub

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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        erklaring.setAns(1, CheckBox1.Checked)
        erklaring.setAns(2, CheckBox2.Checked)
        erklaring.setAns(3, CheckBox3.Checked)
        erklaring.setAns(4, CheckBox4.Checked)
        erklaring.setAns(5, CheckBox5.Checked)
        erklaring.setAns(6, CheckBox6.Checked)
        erklaring.setAns(7, CheckBox7.Checked)
        erklaring.setAns(8, CheckBox8.Checked)
        erklaring.setAns(9, CheckBox9.Checked)
        erklaring.setAns(10, CheckBox10.Checked)
        erklaring.setAns(11, CheckBox11.Checked)
        EgenErklaering2.Show()
        Me.Hide()
    End Sub
End Class