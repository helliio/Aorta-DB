Public Class Blod_pakke
    Private persnr As Decimal
    Private dato As String
    Private type As String
    Private kommentar As String
    Public Sub New(ByVal personnummer As Decimal, ByVal type As String, ByVal kommentar As String)
        persnr = personnummer
        Me.kommentar = kommentar
        Me.type = type
        dato = erklaring.getDate()
    End Sub
    Public Sub send()
        Dim tmp = Split(dato, " ")
        Dim id = CInt(get_appointment_id(tmp(0), tmp(1)))
        'send code here
    End Sub
End Class
