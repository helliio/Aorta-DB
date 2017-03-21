Public Class EgenErklaering6
    Private Sub btnTilbake_Click(sender As Object, e As EventArgs) Handles btnTilbake.Click
        Close()
    End Sub

    Private Sub EgenErklaering6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EgenErklaering5.Show()
        Me.Hide()
    End Sub
    Public Sub clear()
        CheckBox46.Checked = False
        CheckBox47.Checked = False
        CheckBox48.Checked = False
        CheckBox49.Checked = False
    End Sub
End Class