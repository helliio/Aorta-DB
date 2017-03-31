Public Class Blod_pakke
    Private persnr As Decimal
    Private dato As String
    Private type As String
    Private kommentar As String
    Private hemoglobin As Decimal
    Private hiv As Boolean
    Private hepatitt As Boolean
    Public Sub New(ByVal personnummer As Decimal, ByVal type As String, ByVal hemoglobin As Decimal, ByVal hiv As Boolean, ByVal hepatitt As Boolean, ByVal kommentar As String)
        persnr = personnummer
        Me.kommentar = kommentar
        Me.type = type
        Me.hemoglobin = hemoglobin
        Me.hiv = hiv
        Me.hepatitt = hepatitt
        dato = erklaring.getDate()
    End Sub
    Public Sub send()
        Dim tmp = Split(dato, " ")
        Dim dato_id = CInt(get_appointment_id(tmp(0), tmp(1)))
        erklaring.sendGodkjennErklaring()
        create_blodpack(persnr, dato_id, type, hemoglobin, hiv, hepatitt, kommentar)
    End Sub
End Class
