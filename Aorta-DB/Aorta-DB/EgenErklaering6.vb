Public Class EgenErklaering6
    Private Sub btnTilbake_Click(sender As Object, e As EventArgs) Handles btnTilbake.Click
        Close()
    End Sub

    Private Sub EgenErklaering6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EgenErklaering5.Show()
        Me.Hide()
    End Sub
    Public Sub clear()
        CheckBox45.Checked = False
        CheckBox46.Checked = False
        CheckBox47.Checked = False
        CheckBox48.Checked = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        erklaring.setAns(45, CheckBox45.Checked)
        erklaring.setAns(46, CheckBox46.Checked)
        erklaring.setAns(47, CheckBox47.Checked)
        erklaring.setAns(48, CheckBox48.Checked)
        EgenErklaering7.Show()
        Me.Hide()
    End Sub
End Class