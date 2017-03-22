Public Class Blod_pakke
    Private persnr As Decimal
    Private dato As String
    Private type As String
    Public Sub New(ByVal personnummer As Decimal, ByVal type As String)
        persnr = personnummer
        Me.type = type
        dato = erklaring.getDate()
    End Sub
End Class
