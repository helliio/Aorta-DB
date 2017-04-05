Public Class BrukerHovedside
    Private Sub BrukerHovedside_Closing(sender As Object, e As EventArgs) Handles Me.Closing
        Me.Hide()
    End Sub

    Dim timer As Integer = 0

    Private Sub BrukerHovedside_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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


        lblBruker.Text = "Velkommen, " & bruker.getFornavn() & " " & bruker.getEtternavn()
        'listboxInfo.Items.Add("Blodtype: ")
        'listboxInfo.Items.Add("Antall givninger: " & list.Count)
        'listboxInfo.Items.Add("Neste givning: "

    End Sub

    Private Sub btnInfo_Click(sender As Object, e As EventArgs)
        InfoBruker.Show()
        Me.Hide()
    End Sub

    Private Sub btnLoggUt_Click(sender As Object, e As EventArgs) 
        Main.Show()
        Me.Close()
    End Sub
    Private Sub btnAvbestill_Click(sender As Object, e As EventArgs)
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

    Private Sub btnEgenerklæring_Click(sender As Object, e As EventArgs)
        If timer <> 1 Then
            MsgBox("Du må ha bestilt en time for å gjøre egenerklæringen")
        Else
            EgenErklaering.Show()
            Me.Hide()
        End If
    End Sub
    Private Sub btnNyBruker_Click(sender As Object, e As EventArgs) 
        If timer <> 1 Then
            MsgBox("Du må ha bestilt en time for å gjøre egenerklæringen")
        Else
            EgenErklaering.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub btnBestill_click(sender As Object, e As EventArgs) 
        If timer = 1 Then
            MsgBox("Du kan ikke ha mer enn en time")
        Else
            TimeBestilling.Show()
            Me.Close()
        End If
    End Sub

    Private Sub btnAvbestill2_Click(sender As Object, e As EventArgs) 
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

    Private Sub btnMinSide_Click(sender As Object, e As EventArgs) 
        Me.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        InfoBruker.Show()
    End Sub


End Class