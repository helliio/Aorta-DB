Imports System.ComponentModel

Public Class IktStatestikk
    Private Sub IktStatestikk_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Me.Hide()
    End Sub

    Private Sub btnLoggUt_Click(sender As Object, e As EventArgs) Handles btnLoggUt.Click
        Main.Show()
        Me.Close()
    End Sub

    Private Sub btnNyAnsatt_Click(sender As Object, e As EventArgs) Handles btnNyAnsatt.Click
        NyAnsatt.Show()
        Me.Close()
    End Sub

    Private Sub btnMinSide_Click(sender As Object, e As EventArgs) Handles btnMinSide.Click
        IktHovedside.Show()
        Me.Close()
    End Sub

    Private Sub IktStatestikk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresh_list()
    End Sub
    Private Sub refresh_list()
        ListBox1.Items.Clear()
        ListBox1.Items.Add("Mengde donor pr blod type")
        Dim type As ArrayList = get_stat_blood_type()
        For Each item In type
            ListBox1.Items.Add(item)
        Next
        ListBox1.Items.Add(" ")
        ListBox1.Items.Add("Mengde regristrete brukere: " & get_stat_amount_users())
        ListBox1.Items.Add(" ")
        ListBox1.Items.Add("Totale donasjoner: " & get_stat_amount_donations())
        ListBox1.Items.Add(" ")
        ListBox1.Items.Add("Blodbank Status")
        ListBox1.Items.Add("--------------------")
        populate_list("A+")
        ListBox1.Items.Add("--------------------")
        populate_list("A-")
        ListBox1.Items.Add("--------------------")
        populate_list("B+")
        ListBox1.Items.Add("--------------------")
        populate_list("B-")
        ListBox1.Items.Add("--------------------")
        populate_list("O+")
        ListBox1.Items.Add("--------------------")
        populate_list("O-")
        ListBox1.Items.Add("--------------------")
        populate_list("AB+")
        ListBox1.Items.Add("--------------------")
        populate_list("AB-")
    End Sub
    Private Sub populate_list(type As String)
        Dim liste As ArrayList
        liste = return_bank(type)
        For Each item In liste
            ListBox1.Items.Add(item)
        Next
    End Sub
End Class