Module Bank_module
    Private type As String
    Private rode_blodlegmer As Integer
    Private plasma As Integer
    Private plater As Integer
    Public Sub refresh_bank(blod_type As String)
        type = blod_type
        Dim liste As ArrayList
        liste = get_bank_db(type)
        rode_blodlegmer = liste(0)
        plasma = liste(1)
        plater = liste(2)
    End Sub
    Public Function return_bank(blod_type As String)
        refresh_bank(blod_type)
        Dim ret As New ArrayList
        ret.Add("type: " & blod_type)
        ret.Add("røde blodlegmer: " & rode_blodlegmer)
        ret.Add("plasma: " & plasma)
        ret.Add("blod plater: " & plater)
        Return ret
    End Function
    Public Sub update_bank(blod_type As String, rode As Integer, plas As Integer, plat As Integer)
        refresh_bank(blod_type)
        rode_blodlegmer += rode
        plasma += plas
        plater += plat
        update_bank_db(type, rode_blodlegmer, plasma, plater)
    End Sub
End Module
