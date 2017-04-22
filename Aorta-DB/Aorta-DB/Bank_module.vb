'module som hånterer info om blodbanken
Module Bank_module
    Private type As String
    Private rode_blodlegmer As Integer
    Private plasma As Integer
    Private plater As Integer
    'hente info fra db og legger inn i private variabler
    Public Sub refresh_bank(blod_type As String)
        type = blod_type
        Dim liste As ArrayList
        liste = get_bank_db(type)
        rode_blodlegmer = liste(0)
        plasma = liste(1)
        plater = liste(2)
    End Sub
    'mer eller mindre en get funsjon for å hente varibalene, det retuneres en arraylist
    Public Function return_bank(blod_type As String)
        refresh_bank(blod_type)
        Dim ret As New ArrayList
        ret.Add("type: " & blod_type)
        ret.Add("røde blodlegmer: " & rode_blodlegmer)
        ret.Add("plasma: " & plasma)
        ret.Add("blod plater: " & plater)
        Return ret
    End Function
    'funsjon som sender oppdaterte info tilbake til databasen
    Public Sub update_bank(blod_type As String, rode As Integer, plas As Integer, plat As Integer)
        refresh_bank(blod_type)
        rode_blodlegmer += rode
        plasma += plas
        plater += plat
        update_bank_db(type, rode_blodlegmer, plasma, plater)
    End Sub
End Module
