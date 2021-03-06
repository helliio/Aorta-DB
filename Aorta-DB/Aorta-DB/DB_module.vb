﻿Imports MySql.Data.MySqlClient
'Alt av kobling til database er håntert her i denne modulen
Module DB_module
    Private tilkobling As MySqlConnection
    'Tilkoble databasen
    Private Sub connect_db()
        Try
            tilkobling = New MySqlConnection("Server=mysql.stud.iie.ntnu.no;" & "Database=liangzh;" & "Uid=liangzh;" & "Pwd=vdAZFdty;")
            tilkobling.Open()
        Catch ex As Exception
            MsgBox("Du er ikke kobla til internett eller databasen er nede")
        End Try
    End Sub
    'Avslutte kobling til databasen
    Private Sub close_db()
        tilkobling.Close()
        tilkobling.Dispose()
    End Sub
    'Skjekke om brukernavn og passord er riktig, hvis brukern eksisterer og passord er riktig så retunerer den id-en til brukern, eller så retunerer den 0
    Public Function login(user As Decimal, pass As String)
        Try
            connect_db()
            Dim username As String = user.ToString
            Dim password As String = hash512(pass)
            Dim sqlSporring = "select * from users where username=@username " &
                              "and password=@password"
            Dim sql As New MySqlCommand(sqlSporring, tilkobling)

            sql.Parameters.AddWithValue("@username", username)
            sql.Parameters.AddWithValue("@password", password)

            Dim leser = sql.ExecuteReader()
            If leser.HasRows Then
                close_db()
                Return user
            Else
                close_db()
                Return 0
            End If
        Catch ex As Exception
            MsgBox("Feil brukernavn eller passord")
            Return 0
        End Try
    End Function
    'Denne funsjonen leter etter en bruker og retunerer id-en hvis brukern eksisterer ellers så retunerer den en 0
    Public Function login2(user As Decimal)
        Try
            connect_db()
            Dim username As String = user.ToString
            Dim sqlSporring = "select * from users where username=@username "
            Dim sql As New MySqlCommand(sqlSporring, tilkobling)

            sql.Parameters.AddWithValue("@username", username)

            Dim leser = sql.ExecuteReader()
            If leser.HasRows Then
                close_db()
                Return user
            Else
                close_db()
                Return 0
            End If
        Catch ex As Exception
            MsgBox("Ingen brukere har dette personnummeret")
            Return 0
        End Try
    End Function
    'Lager en ny bruker i databasen
    Public Sub create_user(user As Decimal, pass As String, first_name As String, last_name As String, bruker_type As Integer, tlf As Decimal, mail As String, adress As String, post_code As Integer, city As String)
        connect_db()
        Dim password = hash512(pass)
        Dim sqlSporring = "INSERT INTO users (username, password, first_name, last_name, type, tlf, mail, adress, post_code, city) VALUES (@username, @password, @first_name, @last_name, @type, @tlf, @mail, @adress, @post_code, @city)"
        Dim sql As New MySqlCommand(sqlSporring, tilkobling)

        sql.Parameters.AddWithValue("@username", user)
        sql.Parameters.AddWithValue("@password", password)
        sql.Parameters.AddWithValue("@first_name", first_name)
        sql.Parameters.AddWithValue("@last_name", last_name)
        sql.Parameters.AddWithValue("@type", bruker_type)
        sql.Parameters.AddWithValue("@tlf", tlf)
        sql.Parameters.AddWithValue("@mail", mail)
        sql.Parameters.AddWithValue("@adress", adress)
        sql.Parameters.AddWithValue("@post_code", post_code)
        sql.Parameters.AddWithValue("@city", city)

        sql.ExecuteNonQuery()
        close_db()
    End Sub
    'Sub for å endre passord
    Public Sub update_pass(user As Decimal, pass As String)
        connect_db()
        Dim password = hash512(pass)
        Dim sqlSporring = "UPDATE users SET password = @password WHERE username = @username;"
        Dim sql As New MySqlCommand(sqlSporring, tilkobling)
        sql.Parameters.AddWithValue("@username", user)
        sql.Parameters.AddWithValue("@password", password)
        sql.ExecuteNonQuery()
        close_db()
    End Sub
    'Sub for å legge inn egenerklaring
    Public Sub create_erklaring(personnr As Decimal, date_id As Integer, inn As Array, land As String)
        Try
            Dim sqlSporring = "INSERT INTO erklaring (pers, date_id"
            For i As Integer = 1 To inn.Length
                sqlSporring = sqlSporring & ", check" & i.ToString
            Next
            sqlSporring = sqlSporring & ", land) VALUES (@pers, @date_id"
            For i As Integer = 1 To inn.Length
                sqlSporring = sqlSporring & ", " & inn(i - 1).ToString
            Next
            sqlSporring = sqlSporring & ", @land)"
            connect_db()
            Dim sql As New MySqlCommand(sqlSporring, tilkobling)
            sql.Parameters.AddWithValue("@pers", personnr)
            sql.Parameters.AddWithValue("@date_id", date_id)
            sql.Parameters.AddWithValue("@land", land)
            sql.ExecuteNonQuery()
            close_db()
        Catch ex As Exception
            MsgBox("Du har alledrede gjort egenerklæringen for denne timen")
        End Try
    End Sub
    'Sub for å bestille time
    Public Sub create_appointment(user As Decimal, time As String, dates As String)
        connect_db()
        Dim sqlSporring = "INSERT INTO appointments (username, time, date) VALUES (@username, @time, @date)"
        Dim sql As New MySqlCommand(sqlSporring, tilkobling)
        sql.Parameters.AddWithValue("@username", user)
        sql.Parameters.AddWithValue("@time", time)
        sql.Parameters.AddWithValue("@date", dates)
        sql.ExecuteNonQuery()
        close_db()
    End Sub
    'Sub for å legge inn blodbapkke
    Public Sub create_blodpack(user As Decimal, dato As Integer, type As String, hemoglobin As Decimal, hiv As Boolean, hepatittB As Boolean, hepatittC As Boolean, kommentar As String)
        connect_db()
        Dim sqlSporring = "INSERT INTO blodpakke (pernr, dato, type, hemoglobin, hiv, hepatittB, hepatittC, kommentar) VALUES (@pernr, @dato, @type, @hemoglobin, @hiv, @hepatittB, @hepatittC, @kommentar)"
        Dim sql As New MySqlCommand(sqlSporring, tilkobling)
        sql.Parameters.AddWithValue("@pernr", user)
        sql.Parameters.AddWithValue("@dato", dato)
        sql.Parameters.AddWithValue("@type", type)
        sql.Parameters.AddWithValue("@hemoglobin", hemoglobin)
        sql.Parameters.AddWithValue("@hiv", hiv)
        sql.Parameters.AddWithValue("@hepatittB", hepatittB)
        sql.Parameters.AddWithValue("@hepatittC", hepatittC)
        sql.Parameters.AddWithValue("@kommentar", kommentar)
        sql.ExecuteNonQuery()
        Dim sqlSporring2 = "UPDATE helsesjekk SET type = @type, hiv = @hiv, hepatittB = @hepatittB, hepatittC = @hepatittC WHERE user = @user"
        Dim sql2 As New MySqlCommand(sqlSporring2, tilkobling)
        sql2.Parameters.AddWithValue("@user", user)
        sql2.Parameters.AddWithValue("@type", type)
        sql2.Parameters.AddWithValue("@hiv", hiv)
        sql2.Parameters.AddWithValue("@hepatittB", hepatittB)
        sql2.Parameters.AddWithValue("@hepatittC", hepatittC)
        sql2.ExecuteNonQuery()
        close_db()
    End Sub
    'funsjon for å lese blodpakke
    Public Function get_blodpack(persnr As Decimal, dato As Integer)
        Dim ret As New ArrayList
        connect_db()
        Dim sqlSporring = "SELECT * FROM blodpakke WHERE pernr = @pernr AND dato = @dato"
        Dim sql As New MySqlCommand(sqlSporring, tilkobling)
        sql.Parameters.AddWithValue("@pernr", persnr)
        sql.Parameters.AddWithValue("@dato", dato)
        Dim reader As MySqlDataReader = sql.ExecuteReader
        reader.Read()
        For i As Integer = 0 To 6
            ret.Add(reader.Item(i).ToString())
        Next
        reader.Close()
        close_db()
        Return ret
    End Function
    'Sub for å kanselere en time
    Public Sub cancel_appointment(user As Decimal, time As String, dates As String)
        Try
            connect_db()
            Dim sqlSporring = "DELETE FROM appointments WHERE username = @username AND time = @time AND date = @date"
            Dim sql As New MySqlCommand(sqlSporring, tilkobling)
            sql.Parameters.AddWithValue("@username", user)
            sql.Parameters.AddWithValue("@time", time)
            sql.Parameters.AddWithValue("@date", dates)
            sql.ExecuteNonQuery()
            close_db()
        Catch

        End Try
    End Sub
    'funsjon for å finne brukere basert opå dato
    Public Function get_appointment_user(time As String, dates As String)
        Try
            connect_db()
            Dim sqlSporring = "SELECT username FROM appointments WHERE time = @time AND date = @date"
            Dim sql As New MySqlCommand(sqlSporring, tilkobling)
            sql.Parameters.AddWithValue("@time", time)
            sql.Parameters.AddWithValue("@date", dates)
            Dim reader As MySqlDataReader = sql.ExecuteReader
            reader.Read()
            Return reader.Item(0)
            close_db()
        Catch
            Return 0
        End Try
    End Function
    'henter telefon nummer fra bruker
    Public Function get_user_tlf(user As Decimal)
        connect_db()
        Dim sqlSporring = "SELECT tlf FROM users WHERE username = @user"
        Dim sql As New MySqlCommand(sqlSporring, tilkobling)
        sql.Parameters.AddWithValue("@user", user)
        Dim reader As MySqlDataReader = sql.ExecuteReader
        reader.Read()
        Return reader.Item(0)
        close_db()
    End Function
    'funsjon for å finne time id basert på dato
    Public Function get_appointment_id(time As String, dates As String)
        Try
            connect_db()
            Dim sqlSporring = "SELECT id FROM appointments WHERE time = @time AND date = @date"
            Dim sql As New MySqlCommand(sqlSporring, tilkobling)
            sql.Parameters.AddWithValue("@time", time)
            sql.Parameters.AddWithValue("@date", dates)
            Dim reader As MySqlDataReader = sql.ExecuteReader
            reader.Read()
            Return reader.Item(0)
            close_db()
        Catch
            Return 0
        End Try
    End Function
    'funsjon for å hente mengde regidtrerte donor
    Public Function get_stat_amount_users()
        connect_db()
        Dim sqlSporring = "SELECT Count(*) FROM users WHERE type = 0"
        Dim sql As New MySqlCommand(sqlSporring, tilkobling)
        Dim reader As MySqlDataReader = sql.ExecuteReader
        reader.Read()
        Return reader.Item(0)
        close_db()
    End Function
    'funsjon for å hente mengde donasjoner som har blitt gjort
    Public Function get_stat_amount_donations()
        connect_db()
        Dim sqlSporring = "SELECT Count(*) FROM blodpakke"
        Dim sql As New MySqlCommand(sqlSporring, tilkobling)
        Dim reader As MySqlDataReader = sql.ExecuteReader
        reader.Read()
        Return reader.Item(0)
        close_db()
    End Function
    'fusnjon for å hente time dato basert på bruker
    Public Function get_appointment_date(user As Decimal)
        Dim ret As New ArrayList
        connect_db()
        Dim sqlSporring = "SELECT time, date FROM appointments WHERE username = @persnr ORDER BY date DESC"
        Dim sql As New MySqlCommand(sqlSporring, tilkobling)
        sql.Parameters.AddWithValue("@persnr", user)
        Dim da As New MySqlDataAdapter
        Dim interntabell As New DataTable
        da.SelectCommand = sql
        da.Fill(interntabell)
        close_db()
        Dim rad As DataRow
        Dim tid, dato As String
        For Each rad In interntabell.Rows
            tid = rad("time")
            dato = rad("date")
            ret.Add(tid & " " & dato)
        Next
        Return ret
    End Function
    'funsjon som bare henter dato basert på bruker
    Public Function get_appointment_date_only(user As Decimal)
        Dim ret As New ArrayList
        connect_db()
        Dim sqlSporring = "SELECT date FROM appointments WHERE username = @persnr ORDER BY date DESC"
        Dim sql As New MySqlCommand(sqlSporring, tilkobling)
        sql.Parameters.AddWithValue("@persnr", user)
        Dim da As New MySqlDataAdapter
        Dim interntabell As New DataTable
        da.SelectCommand = sql
        da.Fill(interntabell)
        close_db()
        Dim rad As DataRow
        Dim dato As String
        For Each rad In interntabell.Rows
            dato = rad("date")
            ret.Add(dato)
        Next
        Return ret
    End Function
    'henter time info
    Public Function get_appointment_info(user As Decimal, dato As String)
        Dim ret As New ArrayList
        connect_db()
        Dim sqlSporring = "SELECT type, hemoglobin, hiv, hepatittB, hepatittC, kommentar from blodpakke b, appointments a where b.dato = a.id AND b.pernr = @personnr AND a.date = @date"
        Dim sql As New MySqlCommand(sqlSporring, tilkobling)
        sql.Parameters.AddWithValue("@personnr", user)
        sql.Parameters.AddWithValue("@date", dato)
        Dim reader As MySqlDataReader = sql.ExecuteReader
        reader.Read()
        For i As Integer = 0 To 5
            ret.Add(reader.Item(i))
        Next
        close_db()
        Return ret
    End Function
    'funsjon som retunerer all info om brukern basert på bruker id
    Public Function return_user(persnr As Decimal)
        Dim ret As New ArrayList
        connect_db()
        Dim sqlSporring = "SELECT * FROM users WHERE username = @persnr"
        Dim sql As New MySqlCommand(sqlSporring, tilkobling)
        sql.Parameters.AddWithValue("@persnr", persnr)
        Dim reader As MySqlDataReader = sql.ExecuteReader
        reader.Read()
        For i As Integer = 0 To 9
            ret.Add(reader.Item(i).ToString())
        Next
        close_db()
        Return ret
    End Function
    'funsjon som henter egenerklaring basert på bruker og dato
    Public Function return_erklaring(persnr As Decimal, dato As Integer)
        Dim ret As New ArrayList
        connect_db()
        Dim sqlSporring = "SELECT * FROM erklaring WHERE pers = @pers AND date_id = @date_id"
        Dim sql As New MySqlCommand(sqlSporring, tilkobling)
        sql.Parameters.AddWithValue("@pers", persnr)
        sql.Parameters.AddWithValue("@date_id", dato)
        Dim reader As MySqlDataReader = sql.ExecuteReader
        reader.Read()
        For i As Integer = 3 To 62
            ret.Add(reader.Item(i).ToString())
        Next
        reader.Close()
        close_db()
        Return ret
    End Function
    'setter godkjenning på egenerklaring
    Public Sub update_erklaring_godkjenning(persnr As Decimal, dato As Integer, godkjen As Boolean)
        connect_db()
        Dim sqlSporring = "UPDATE erklaring SET godkjent = @godkjen WHERE pers = @persnr AND date_id = @date_id;"
        Dim sql As New MySqlCommand(sqlSporring, tilkobling)
        sql.Parameters.AddWithValue("@persnr", persnr)
        sql.Parameters.AddWithValue("@date_id", dato)
        sql.Parameters.AddWithValue("@godkjen", godkjen)
        sql.ExecuteNonQuery()
        close_db()
    End Sub
    'oppdaterer blodprodukter
    Public Sub update_bank_db(type As String, rode As Integer, plasma As Integer, plater As Integer)
        connect_db()
        Dim sqlSporring = "UPDATE blodprod SET rode_blodlegemer = @rode, plasma = @plasma, blodplater  = @plater WHERE  type  = @type;"
        Dim sql As New MySqlCommand(sqlSporring, tilkobling)
        sql.Parameters.AddWithValue("@rode", rode)
        sql.Parameters.AddWithValue("@plasma", plasma)
        sql.Parameters.AddWithValue("@plater", plater)
        sql.Parameters.AddWithValue("@type", type)
        sql.ExecuteNonQuery()
        close_db()
    End Sub
    'henter blodprodukter
    Public Function get_bank_db(type As String)
        Dim ret As New ArrayList
        connect_db()
        Dim sqlSporring = "SELECT rode_blodlegemer, plasma, blodplater FROM blodprod WHERE type = @type"
        Dim sql As New MySqlCommand(sqlSporring, tilkobling)
        sql.Parameters.AddWithValue("@type", type)
        Dim reader As MySqlDataReader = sql.ExecuteReader
        reader.Read()
        For i As Integer = 0 To 2
            ret.Add(reader.Item(i))
        Next
        close_db()
        Return ret
    End Function
    'henter timer for ansatte basert på dato
    Public Function get_appointments_ansatt(dates As String)
        Dim timer As New ArrayList
        connect_db()
        Dim sqlSporring = "SELECT time, first_name, last_name, a.username FROM appointments a, users u WHERE a.username = u.username AND date = @date ORDER BY time"
        Dim da As New MySqlDataAdapter
        Dim interntabell As New DataTable
        Dim sql As New MySqlCommand(sqlSporring, tilkobling)
        sql.Parameters.AddWithValue("@date", dates)
        da.SelectCommand = sql
        da.Fill(interntabell)
        close_db()
        Dim rad As DataRow
        Dim time, first_name, last_name, user_name As String
        For Each rad In interntabell.Rows
            Dim timer_rad As New ArrayList
            time = rad("time")
            first_name = rad("first_name")
            last_name = rad("last_name")
            user_name = rad("username")
            timer_rad.Add(time)
            timer_rad.Add(first_name)
            timer_rad.Add(last_name)
            timer_rad.Add(user_name)
            timer.Add(timer_rad)
        Next
        Return timer
    End Function
    'for ansatte til å sette helseskjekk
    Public Sub set_helsesjekk(user As Decimal, type As String, hemoglobin As Decimal, syfilis As Boolean, hiv As Boolean, hepatittB As Boolean, hepatittC As Boolean)
        connect_db()
        Dim sqlSporring = "INSERT INTO helsesjekk (user, type, hemoglobin, syfilis, hiv, hepatittB, hepatittC) VALUES (@user, @type, @hemoglobin, @syfilis, @hiv, @hepatittB, @hepatittC)"
        Dim sql As New MySqlCommand(sqlSporring, tilkobling)
        sql.Parameters.AddWithValue("@user", user)
        sql.Parameters.AddWithValue("@type", type)
        sql.Parameters.AddWithValue("@hemoglobin", hemoglobin)
        sql.Parameters.AddWithValue("@syfilis", syfilis)
        sql.Parameters.AddWithValue("@hiv", hiv)
        sql.Parameters.AddWithValue("@hepatittB", hepatittB)
        sql.Parameters.AddWithValue("@hepatittC", hepatittC)
        sql.ExecuteNonQuery()
        close_db()
    End Sub
    'for ansatte til å oppdatere helseskjekk
    Public Sub update_helsesjekk(user As Decimal, type As String, hemoglobin As Decimal, syfilis As Boolean, hiv As Boolean, hepatittB As Boolean, hepatittC As Boolean)
        connect_db()
        Dim sqlSporring = "UPDATE helsesjekk SET type= @type, hemoglobin = @hemoglobin, syfilis = @syfilis, hiv = @hiv, hepatittB = @hepatittB, hepatittC = @hepatittC WHERE user = @user"
        Dim sql As New MySqlCommand(sqlSporring, tilkobling)
        sql.Parameters.AddWithValue("@user", user)
        sql.Parameters.AddWithValue("@type", type)
        sql.Parameters.AddWithValue("@hemoglobin", hemoglobin)
        sql.Parameters.AddWithValue("@syfilis", syfilis)
        sql.Parameters.AddWithValue("@hiv", hiv)
        sql.Parameters.AddWithValue("@hepatittB", hepatittB)
        sql.Parameters.AddWithValue("@hepatittC", hepatittC)
        sql.ExecuteNonQuery()
        close_db()
    End Sub
    'finner ut om en donor har gjort helseskjekk
    Public Function check_helsesjekk(user As Decimal)
        connect_db()
        Dim username As String = user.ToString
        Dim sqlSporring = "select * from helsesjekk where user = @username "
        Dim sql As New MySqlCommand(sqlSporring, tilkobling)

        sql.Parameters.AddWithValue("@username", username)

        Dim leser = sql.ExecuteReader()
        If leser.HasRows Then
            close_db()
            Return True
        Else
            close_db()
            Return False
        End If
    End Function
    'retunerer helseskjekk
    Public Function find_helsesjekk(user As Decimal)
        Try
            connect_db()
            Dim ret As New ArrayList
            Dim username As String = user.ToString
            Dim sqlSporring = "select type, hemoglobin, syfilis, hiv, hepatittB, hepatittC  from helsesjekk where user = @username"
            Dim sql As New MySqlCommand(sqlSporring, tilkobling)

            sql.Parameters.AddWithValue("@username", username)
            Dim reader As MySqlDataReader = sql.ExecuteReader
            reader.Read()
            For i As Integer = 0 To 5
                ret.Add(reader.Item(i))
            Next
            close_db()
            Return ret
        Catch ex As Exception
            Return 0
        End Try
    End Function
    'skjekker om egenerklaring er gjort
    Public Function check_egenerklaering(user As Decimal)
        connect_db()
        Dim username As String = user.ToString
        Dim sqlSporring = "select * from erklaring where pers = @username "
        Dim sql As New MySqlCommand(sqlSporring, tilkobling)

        sql.Parameters.AddWithValue("@username", username)

        Dim leser = sql.ExecuteReader()
        If leser.HasRows Then
            close_db()
            Return True
        Else
            close_db()
            Return False
        End If
    End Function
    'finner ut om blodtype til bruker
    Public Function find_blodtype(user As String)
        Dim ret As String
        connect_db()
        Dim sqlSporring = "SELECT type FROM helsesjekk WHERE user = @user"
        Dim sql As New MySqlCommand(sqlSporring, tilkobling)
        sql.Parameters.AddWithValue("@user", user)
        Dim reader As MySqlDataReader = sql.ExecuteReader
        reader.Read()

        ret = reader.Item(0)
        close_db()
        Return ret
    End Function
    'henter tid på timer basert på dato
    Public Function get_appointments_user(dates As String)
        Dim timer As New ArrayList
        connect_db()
        Dim sqlSporring = "SELECT time FROM appointments WHERE date = @date ORDER BY time"
        Dim da As New MySqlDataAdapter
        Dim interntabell As New DataTable
        Dim sql As New MySqlCommand(sqlSporring, tilkobling)
        sql.Parameters.AddWithValue("@date", dates)
        da.SelectCommand = sql
        da.Fill(interntabell)
        close_db()
        Dim rad As DataRow
        Dim time As String
        For Each rad In interntabell.Rows
            Dim timer_rad As New ArrayList
            time = rad("time")
            timer_rad.Add(time)
            timer.Add(timer_rad)
        Next
        Return timer
    End Function
    'Henter mengde blod donor basert på blodtype
    Public Function get_stat_blood_type()
        Dim type As New ArrayList
        connect_db()
        Dim sqlSporring = "SELECT type, Count(*) FROM helsesjekk group by type"
        Dim da As New MySqlDataAdapter
        Dim interntabell As New DataTable
        Dim sql As New MySqlCommand(sqlSporring, tilkobling)
        da.SelectCommand = sql
        da.Fill(interntabell)
        close_db()
        Dim rad As DataRow
        Dim btype, count As String
        For Each rad In interntabell.Rows
            Dim outrad As String
            btype = rad("type")
            count = rad("Count(*)")
            outrad = btype & " : " & count
            type.Add(outrad)
        Next
        Return type
    End Function
    'henter blodprodukter basert på blodtype
    Public Function get_Antallblod(blodtype As String)
        Dim ret As New ArrayList
        connect_db()
        Dim sqlSporring = "SELECT type, rode_blodlegemer, plasma, blodplater from blodprod where type = @blodtype"
        Dim sql As New MySqlCommand(sqlSporring, tilkobling)
        sql.Parameters.AddWithValue("@blodtype", blodtype)
        Dim reader As MySqlDataReader = sql.ExecuteReader
        reader.Read()
        For i As Integer = 0 To 3
            ret.Add(reader.Item(i))
        Next
        close_db()
        Return ret
    End Function
    'finne donor basert på blodtype
    Public Function get_blodgiver(type As String)
        Dim blodgiver As New ArrayList
        connect_db()
        Dim sqlSporring = "SELECT first_name, last_name, tlf, user FROM helsesjekk h, users u WHERE u.username = h.user AND h.type = @type"
        Dim da As New MySqlDataAdapter
        Dim interntabell As New DataTable
        Dim sql As New MySqlCommand(sqlSporring, tilkobling)
        sql.Parameters.AddWithValue("@type", type)
        da.SelectCommand = sql
        da.Fill(interntabell)
        close_db()
        Dim rad As DataRow
        Dim first_name, last_name, tlf, bruker As String
        For Each rad In interntabell.Rows
            Dim blodgiver_rad As New ArrayList
            first_name = rad("first_name")
            last_name = rad("last_name")
            tlf = rad("tlf")
            bruker = rad("user")
            blodgiver_rad.Add(first_name)
            blodgiver_rad.Add(last_name)
            blodgiver_rad.Add(tlf)
            blodgiver_rad.Add(bruker)
            blodgiver.Add(blodgiver_rad)
        Next
        Return blodgiver
    End Function
End Module
