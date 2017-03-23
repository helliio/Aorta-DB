Imports System.ComponentModel

Public Class BlodGivning
    Dim liste As New ArrayList
    Private Sub BlodGivning_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Ja")
        ComboBox1.Items.Add("Nei")
        Global_val.erklaring = New EgenErklaering_class(giver_id)
        Dim list As ArrayList = get_appointment_date(giver_id)
        'Debug.Print(giver_id)
        Dim dt_list As New ArrayList
        Dim d = DateTime.Now
        For Each item In list
            dt_list.Add(CDate(item))
        Next
        For Each item As Date In dt_list
            If item >= d Then
                Dim i As String = item.ToString("HH.mm dd.MM.yyyy")
                Label2.Text = i
                erklaring.setDate(i)
                'Debug.Print(i)
            End If
        Next
        get_erklaring()
    End Sub

    Private Sub get_erklaring()
        listboxEgenerklæring.Items.Clear()
        liste.Add("Vennligst besvar:") '0'
        liste.Add("- Har du fått informasjon om blodgivning?") '1'1
        liste.Add("- Føler du deg frisk nå?") '2'2
        liste.Add("- Hvis du har gitt blod tidligere, har du vært frisk i perioden fra forrige blodgivning og til nå?") '3'3
        liste.Add("- Veier du 50 kg eller mer?") '4'4
        liste.Add("- Har du åpne sår, eksem eller hudsykdom?") '5'5
        liste.Add("- Har du piercing i slimhinne?") '6'6
        '----------'
        liste.Add("Har du i løpet av de siste fire uker:") '7'
        liste.Add("- brukt medisiner?") '8'7
        liste.Add("- vært syk eller hatt feber?") '9'8
        liste.Add("- hatt løs avføring?") '10'9
        liste.Add("- fått vaksine?") '11'10
        liste.Add("- vært hos tannlege eller tannpleier?") '12'11
        '----------'
        liste.Add("Har du i løpet av de siste seks måneder:") '13'
        liste.Add("- vært til legeundersøkelse eller på sykehus, eller fått behandling for noen sykdom?") '14'12
        liste.Add("- fått behandling med sprøyter?") '15'13
        liste.Add("- hatt kjønnssykdom, eller fått behandling for kjønnssykdom?") '16'14
        liste.Add("- hatt seksuell kontakt med person med HIVinfeksjon eller hepatitt B eller hepatitt C, eller med person som har hatt positiv test for en av disse sykdommene?") '17'15
        liste.Add("- hatt seksuell kontakt med person som bruker eller har brukt dopingmidler eller narkotiske midler som sprøyter?") '18'16
        liste.Add("- hatt seksuell kontakt med prostituerte eller tidligere prostituerte?") '19'17
        liste.Add("- blitt tatovert, fått piercing eller tatt hull i ørene?") '20'18
        liste.Add("- fått akupunktur?") '21'19
        liste.Add("- stukket eller skåret deg på gjenstander som var forurenset med blod eller kroppsvæsker") '22'20
        liste.Add("- bodd i samme husstand som en person som har hepatitt B?") '23'21
        liste.Add("- fått blodsøl på slimhinner eller skadet hud?") '24'22
        liste.Add("- blitt bitt av flått?") '25'23
        liste.Add("- hatt seksualpartner som har bodd mer enn ett år sammenhengende utenfor Vest-Europa ?") '26'24
        liste.Add("- hatt seksualpartner som har vært i Afrika?") '27'25
        liste.Add("- hatt seksuell kontakt med en person som har fått blod eller blodprodukter utenfor Norden?") '28'26
        liste.Add("- hatt ny seksualpartner?") '29'27
        liste.Add("- vært utenfor Vest-Europa?") '30'28
        '----------'
        liste.Add("Har du i løpet av de siste to år:") '31'
        liste.Add("- hatt sjeldne eller alvorlige infeksjonssykdommer?") '32'29
        '----------'
        liste.Add("Har du på noe tidspunkt gjennom livet") '33'
        liste.Add("- hatt, hjerte-, lever-, eller lungesykdom?") '34'30
        liste.Add("- hatt kreft?") '35'31
        liste.Add("- hatt blødningstendens?") '36'32
        liste.Add("- hatt allergi mot mat eller medisiner?") '37'33
        liste.Add("- hatt malaria?") '38'34
        liste.Add("- hatt tropesykdommer?") '39'35
        liste.Add("- hatt hepatitt (gulsott), HIV-infeksjon eller AIDS?") '40'36
        liste.Add("- hatt positiv prøve for hepatitt (gulsott) eller HIVinfeksjon?") '41'37
        liste.Add("- fått blodoverføring?") '42'38
        liste.Add("- fått veksthormon?") '43'39
        liste.Add("- fått hornhinnetransplantat?") '44'40
        liste.Add("- hatt syfilis?") '45'41
        liste.Add("- hatt alvorlig sykdom som ikke er nevnt her?") '46'42
        liste.Add("- brukt dopingmidler eller narkotiske midler som sprøyter?") '47'43
        liste.Add("- mottatt penger eller narkotika som gjenytelse for sex?") '48'44
        '----------'
        liste.Add("Besvares av kvinner:") '49'
        liste.Add("- Er du gravid?") '50'45
        liste.Add("- Har du vært gravid i løpet av de siste tolv måneder, eller ammer du nå?") '51'46
        liste.Add("- Hvis du har gitt blod tidligere, har du vært gravid siden forrige blodgivning?") '52'47
        liste.Add("- Har du i løpet av de siste seks måneder hatt seksuell kontakt med en mann som du vet har hatt seksuell kontakt med andre menn?") '53'48
        '----------'
        liste.Add("Besvares av menn:") '54'
        liste.Add("- Har eller har du hatt seksuell kontakt med andre menn?") '55'49
        '----------'
        liste.Add("Besvar også:") '56'
        liste.Add("- Har du brukt narkotika en eller flere ganger de siste 12 måneder?") '57'50
        liste.Add("- Har du eller noen i familien hatt Creutzfeldt-Jakob sykdom eller variant CJD?") '58'51
        liste.Add("- Har du oppholdt deg i Storbritannia i mer enn ett år til sammen i perioden mellom 1980 og 1996?") '59'52
        liste.Add("- Har du i løpet av de siste tre år vært i områder der malaria forekommer?") '60'53
        liste.Add("- Har du oppholdt deg sammenhengende i minst seks måneder i områder der malaria forekommer?") '61'54
        liste.Add("- Har du oppholdt deg i Afrika i mer enn fem år til sammen?") '62'55
        liste.Add("- Er du eller din mor født i Amerika sør for USA?") '63'56
        liste.Add("- Godtar du at anonymiserte prøver av ditt blod kan brukes til forskning?") '64'57
        liste.Add("- Har du deltatt i medikamentforsøk de siste 12 måneder?") '65'58
        liste.Add("- Jeg samtykker i at mitt plasma føres ut av Norge for legemiddelproduksjon.") '66'59
        liste.Add("- I hvilke(t) land er du født og oppvokst?") '67'60
        Try
            Dim svar = erklaring.get_ans_db()
            Dim counter As Integer = 0
            For i As Integer = 0 To liste.Count - 1
                If i <> 0 And i <> 7 And i <> 13 And i <> 31 And i <> 33 And i <> 49 And i <> 54 And i <> 56 Then
                    'Debug.Print(svar(counter))
                    If counter = 59 Then
                        liste(i) = liste(i) & " : " & svar(counter)
                    ElseIf svar(counter) Then
                        liste(i) = liste(i) & " : ja"
                    Else
                        liste(i) = liste(i) & " : nei"
                    End If
                    counter += 1
                End If
            Next
            For Each item As String In liste
                listboxEgenerklæring.Items.Add(item)
            Next
        Catch ex As Exception
            listboxEgenerklæring.Items.Clear()
            listboxEgenerklæring.Items.Add("Egen Erklaering finnes ikke")
        End Try
    End Sub

    Private Sub btnNeste_Click(sender As Object, e As EventArgs) Handles btnNeste.Click
        If ComboBox1.Text = "Nei" Then
            Ansatt.Show()
            Me.Hide()
        ElseIf ComboBox1.Text = "Ja" Then
            BlodGivning2.Show()
            Me.Hide()
        Else
            MsgBox("Velg Godkjenning")
        End If
    End Sub

    Private Sub btnOppdater_Click(sender As Object, e As EventArgs) Handles btnOppdater.Click
        get_erklaring()
    End Sub

    Private Sub btnTilbake_Click(sender As Object, e As EventArgs) Handles btnTilbake.Click
        Close()
    End Sub

    Private Sub BlodGivning_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        AnsattBrukerOversikt.Show()
        listboxEgenerklæring.Items.Clear()
    End Sub
End Class