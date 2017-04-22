'hovedside til brukere
Public Class BrukerHovedside
    Private Sub BrukerHovedside_Closing(sender As Object, e As EventArgs) Handles Me.Closing
        Me.Hide()
    End Sub

    Dim timer As Integer = 0
    'laster inn informasjon
    Private Sub BrukerHovedside_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        timer = 0
        Dim list As ArrayList = get_appointment_date(bruker.getPersonnr)
        Dim dt_list As New ArrayList
        Dim d = DateTime.Now
        For Each item In list
            dt_list.Add(CDate(item))
        Next
        For Each item As Date In dt_list
            If item < d Then
                Dim i As String = item.ToString("HH.mm dd.MM.yyyy")
                listboxGivinger.Items.Add(i)
            Else
                Dim i As String = item.ToString("HH.mm dd.MM.yyyy")
                lblNesteTime.Text = i
                timer += 1
            End If
        Next


        lblBruker.Text = bruker.getFornavn() & " " & bruker.getEtternavn()

    End Sub
    'viser bytt passord fletene
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label2.Visible = True
        Label6.Visible = True
        TextBox1.Visible = True
        TextBox2.Visible = True
        Button1.Visible = True
    End Sub
    'loggut knapp
    Private Sub btnLoggUt_Click_1(sender As Object, e As EventArgs) Handles btnLoggUt.Click
        Main.Show()
        Me.Close()
    End Sub
    'tar deg til egenerklarings skjema
    Private Sub btnEgenerklaring_Click(sender As Object, e As EventArgs) Handles btnEgenerklaring.Click
        EgenErklaering.Show()
    End Sub
    'bestill time hvis brukern ikke allerede har en time
    Private Sub btnBestill_Click(sender As Object, e As EventArgs) Handles btnBestill.Click
        If timer = 1 Then
            MsgBox("Du kan ikke ha mer enn en time")
        Else
            TimeBestilling.Show()
            Me.Close()
        End If
    End Sub
    'tar deg til time info side
    Private Sub btnTimeinfo_Click(sender As Object, e As EventArgs) Handles btnTimeinfo.Click
        InfoBruker.Show()
        Me.Close()
    End Sub
    'avbestill time
    Private Sub btnAvbesill_Click(sender As Object, e As EventArgs) Handles btnAvbesill.Click
        Dim dato As String = lblNesteTime.Text
        If timer <> 1 Then
            MsgBox("Du har ingen timer å avbestille")
        Else
            Dim result As Integer = MessageBox.Show("Er du sikker på at du vil avbestille timen ", "Avbestilling", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                Dim list = Split(dato, " ")
                lblNesteTime.Text = ""
                cancel_appointment(bruker.getPersonnr, list(0), list(1))
                timer = 0
            End If
        End If
    End Sub
    'knapp for å bytte passord
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not TextBox1.Text.Length >= 8 Then
            MsgBox("Passord må være lengre enn 8 tegn")
            Exit Sub
        End If
        If TextBox1.Text <> TextBox2.Text Then
            'some error
            Exit Sub
        End If
        update_pass(bruker.getPersonnr, TextBox1.Text)
        MsgBox("Du har byttet passord")
        Label2.Visible = False
        Label6.Visible = False
        TextBox1.Visible = False
        TextBox2.Visible = False
        Button1.Visible = False
    End Sub
End Class