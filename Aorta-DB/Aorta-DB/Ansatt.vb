Imports System.ComponentModel

Public Class Ansatt
    Private Sub Ansatt_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Logginn.Show()
        Me.Hide()
    End Sub

    Private Sub Ansatt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dag = Format(Date.Now(), "dd.MM.yyyy")
        lblAnsatt.Text = "Velkommen " & bruker.getFornavn() & " " & bruker.getEtternavn()
        Dim dagensTimer As ArrayList
        dagensTimer = get_appointments_ansatt(dag)
        For Each item In dagensTimer
            Dim out As String
            out = item(0) & " " & item(1) & " " & item(2)
            listGivninger.Items.Add(out)
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnLoggUt.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Global_val.giver_id = CDec(TextBox1.Text)
        BlodGivning.Show()
        Me.Hide()
    End Sub

    Private Sub btnSok_Click(sender As Object, e As EventArgs) Handles btnSok.Click
        Dim id As Decimal = login2(txtSok.Text)
        If id <> 0 Then
            Global_val.bruker = New User(id)
            If bruker.getUserType = 0 Then
                AnsattBrukerOversikt.Show()
                Me.Hide()
            End If
        End If

    End Sub

    Private Sub btnGivninger_Click(sender As Object, e As EventArgs) Handles btnGivninger.Click
        AnsattKalender.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub
End Class