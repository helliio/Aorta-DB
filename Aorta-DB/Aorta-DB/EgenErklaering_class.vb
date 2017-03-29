Public Class EgenErklaering_class
    Private answer(58) As Boolean
    Private pers As Decimal
    Private land As String
    Private dato As String
    Private godkjent As Boolean = False
    Public Sub New(ByVal personnummer As Decimal)
        pers = personnummer
        For index As Integer = 0 To 58
            answer(index) = False
        Next
    End Sub
    Public Sub setAns(i As Integer, val As Boolean)
        answer(i - 1) = val
    End Sub
    Public Function getAns(i As Integer)
        Return answer(i)
    End Function
    Public Sub setLand(inn As String)
        land = inn
    End Sub
    Public Function getLand(inn As String)
        Return land(inn)
    End Function
    Public Function getDate()
        Return dato
    End Function
    Public Sub setDate(str As String)
        'Debug.Print(str)
        dato = str
    End Sub
    Public Sub setGodkjenneing()
        godkjent = True
    End Sub
    Public Function get_ans_db()
        'Debug.Print(dato)
        Dim tmp = Split(dato, " ")
        Dim id = CInt(get_appointment_id(tmp(0), tmp(1)))
        Return return_erklaring(pers, id)
    End Function
    Public Sub send()
        Dim tmp = Split(dato, " ")
        Dim id = CInt(get_appointment_id(tmp(0), tmp(1)))
        create_erklaring(pers, id, answer, land)
    End Sub
    Public Sub sendGodkjennErklaring()
        Dim tmp = Split(dato, " ")
        Dim id = CInt(get_appointment_id(tmp(0), tmp(1)))
        update_erklaring_godkjenning(pers, id, godkjent)
    End Sub
End Class
