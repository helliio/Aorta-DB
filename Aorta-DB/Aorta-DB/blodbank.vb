Public Class blodbank
    'vindu for å hente eller sette inn blodprodukter
    Private Sub blodbank_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("A")
        ComboBox1.Items.Add("B")
        ComboBox1.Items.Add("O")
        ComboBox1.Items.Add("AB")
        refresh_list()
    End Sub
    'knapp for å legge inn verdier inn i blod prod db
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButtonPlus.Checked And ComboBox1.Text <> "Velg blodtype" Then
            Dim type As String = ComboBox1.Text & "+"
            update_bank(type, NumericRode.Value, NumericPlasma.Value, NumericPlater.Value)
            refresh_list()
        ElseIf RadioButtonMinus.Checked And ComboBox1.Text <> "Velg blodtype" Then
            Dim type As String = ComboBox1.Text & "-"
            update_bank(type, NumericRode.Value, NumericPlasma.Value, NumericPlater.Value)
            refresh_list()
        Else
            MsgBox("Må velge blodtype")
        End If
    End Sub
    'knapp for å trekke fra verdier i blodprod db
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If RadioButtonPlus.Checked And ComboBox1.Text <> "Velg blodtype" Then
            Dim type As String = ComboBox1.Text & "+"
            update_bank(type, -NumericRode.Value, -NumericPlasma.Value, -NumericPlater.Value)
            refresh_list()
        ElseIf RadioButtonMinus.Checked And ComboBox1.Text <> "Velg blodtype" Then
            Dim type As String = ComboBox1.Text & "-"
            update_bank(type, -NumericRode.Value, -NumericPlasma.Value, -NumericPlater.Value)
            refresh_list()
        Else
            MsgBox("Må velge blodtype")
        End If
    End Sub
    'går tilbake til hoved siden
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Ansatt.Show()
        Me.Hide()
    End Sub
    ' checkbokser for å markere hva som blir endret
    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        NumericPlater.Enabled = CheckBox3.Checked
        NumericPlater.Value = 0
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        NumericPlasma.Enabled = CheckBox2.Checked
        NumericPlasma.Value = 0
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        NumericRode.Enabled = CheckBox1.Checked
        NumericRode.Value = 0
    End Sub
    'refreasher listboksen
    Private Sub refresh_list()
        ListBox1.Items.Clear()
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
    'leggerverdier inn i listboksen basert på type fårespørsel
    Private Sub populate_list(type As String)
        Dim liste As ArrayList
        liste = return_bank(type)
        For Each item In liste
            ListBox1.Items.Add(item)
        Next
    End Sub
    'navigerings knapper
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        refresh_list()
    End Sub

    Private Sub btnLoggUt_Click(sender As Object, e As EventArgs) Handles btnLoggUt.Click
        Main.Show()
        Me.Hide()
    End Sub
    Private Sub btnKalender_Click(sender As Object, e As EventArgs) Handles btnKalender.Click
        AnsattKalender.Show()
        Me.Hide()
    End Sub
    Private Sub btnStatestikk_Click(sender As Object, e As EventArgs) Handles btnStatestikk.Click
        statestikk.Show()
        Me.Hide()
    End Sub

    Private Sub btnSjekkBlod_Click(sender As Object, e As EventArgs) Handles btnSjekkBlod.Click
        InnkallingBaserPaaBehov.Show()
        Me.Hide()
    End Sub

    Private Sub btnMinSide_Click(sender As Object, e As EventArgs) Handles btnMinSide.Click
        Ansatt.Show()
        Me.Hide()
    End Sub
End Class