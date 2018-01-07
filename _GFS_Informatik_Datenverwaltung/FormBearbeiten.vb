Imports System.Data.OleDb

Public Class FormBearbeiten

    ' -- VARIABLENDEFINITION -- '

    Dim connection As New OleDbConnection 'Verbindung zwischen Programm und Datenbank
    Dim command As New OleDbCommand       'Beinhaltet SQL-Befehle, die an die Datenbank gesendet werden
    Dim reader As OleDbDataReader         'Um die ausgewählten Daten auslesen zu können

    ' -- VARIABLENDEFINITION ENDE -- '

Public Function GetRandom(ByVal min As Integer, ByVal max As Integer) As Integer
    Static staticRandomGenerator As New System.Random
    max += 1
    Return staticRandomGenerator.Next(If(min > max, max, min), If(min > max, min, max))
End Function

Private Sub FormBearbeiten_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" & "Data Source=" & Application.StartupPath & "\Ressourcen\Access-Datei\GFS.accdb;"
    command.Connection = connection

    If bearbeitenFensterSender = "kundenkonto_bearbeiten" Then
    '{
        Me.Text = "Bearbeiten"
        lblUeberschriftBearbeitungsfenster.Text = "Bearbeitungsfenster"

        lbl11.Visible = False   'Man benötigt nur 10 Felder, da der Kunde nicht seine ID und sein Geld verändern kann
        lbl12.Visible = False
        txtBox11.Visible = False
        txtBox12.Visible = False

        lbl1.Text = "Nachname:"
        lbl2.Text = "Vorname:"
        lbl3.Text = "E-Mail:"
        lbl4.Text = "Telefonnummer:"
        lbl5.Text = "Land:"
        lbl6.Text = "PLZ:"
        lbl7.Text = "Stadt:"
        lbl8.Text = "Straße:"
        lbl9.Text = "Hausnummer:"
        lbl10.Text = "Passwort:"

        cmdBestaetigen.Text = "Ändern"

        Try
        '{
            connection.Open()
            command.CommandText = "SELECT * FROM kunden WHERE kunden_id = " & kunden_id_module
            Konsole.txtBox.Text += command.CommandText & Environment.NewLine & Environment.NewLine
            ScrollToEnd()
            reader = command.ExecuteReader()

            Do While reader.Read()
            '{
                txtBox1.Text = reader("kunden_name").ToString()
                txtBox2.Text = reader("kunden_vorname").ToString()
                txtBox3.Text = reader("kunden_email").ToString()
                txtBox4.Text = reader("kunden_telefonnummer").ToString()
                txtBox5.Text = reader("kunden_land").ToString()
                txtBox6.Text = reader("kunden_plz").ToString()
                txtBox7.Text = reader("kunden_stadt").ToString()
                txtBox8.Text = reader("kunden_straße").ToString()
                txtBox9.Text = reader("kunden_hausnummer").ToString()
                txtBox10.Text = reader("kunden_passwort").ToString()
            '}
            Loop
            reader.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        '}
        End Try
        connection.Close()
    '}
    ElseIf bearbeitenFensterSender.Contains("suchen_lager") Then
    '{
        Me.Text = "Lager durchsuchen"
        lblUeberschriftBearbeitungsfenster.Text = "Lager durchsuchen"

        lbl7.Visible = False
        lbl8.Visible = False
        lbl9.Visible = False
        lbl10.Visible = False
        lbl11.Visible = False
        lbl12.Visible = False
        txtBox7.Visible = False
        txtBox8.Visible = False
        txtBox9.Visible = False
        txtBox10.Visible = False
        txtBox11.Visible = False
        txtBox12.Visible = False

        lbl1.Text = "Warennummer:"
        lbl2.Text = "Artikel verfügbar:"
        lbl3.Text = "Name:"
        lbl4.Text = "Kategorie:"
        lbl5.Text = "Gewicht:"
        lbl6.Text = "Preis:"

        cmdBestaetigen.Text = "Suchen"
    '}
    ElseIf bearbeitenFensterSender.Contains("suchen_verkaufshistorie") Then
    '{
        Me.Text = "Verkaufshistorie durchsuchen"
        lblUeberschriftBearbeitungsfenster.Text = "Verkaufshistorie durchsuchen"

        lbl7.Visible = False
        lbl8.Visible = False
        lbl9.Visible = False
        lbl10.Visible = False
        lbl11.Visible = False
        lbl12.Visible = False
        txtBox7.Visible = False
        txtBox8.Visible = False
        txtBox9.Visible = False
        txtBox10.Visible = False
        txtBox11.Visible = False
        txtBox12.Visible = False

        lbl1.Text = "Bestellnummer:"
        lbl2.Text = "Kundennummer:"
        lbl3.Text = "Kaufdatum:"
        lbl4.Text = "Warennummer:"
        lbl5.Text = "Verkaufspreis:"
        lbl6.Text = "Anzahl:"

        If bearbeitenFensterSender = "suchen_verkaufshistorie_kunde" Then
            txtBox2.Text = kunden_id_module
        txtBox2.Enabled = False
        End If

        cmdBestaetigen.Text = "Suchen"
    '}
    ElseIf bearbeitenFensterSender = "suchen_offene_bestellungen_kunde" Then
    '{
        Me.Text = "Offene Bestellungen durchsuchen für Kunde " & kunden_id_module
        lblUeberschriftBearbeitungsfenster.Text = "Offene Bestellungen durchsuchen"

        lbl5.Visible = False
        lbl6.Visible = False
        lbl7.Visible = False
        lbl8.Visible = False
        lbl9.Visible = False
        lbl10.Visible = False
        lbl11.Visible = False
        lbl12.Visible = False
        txtBox5.Visible = False
        txtBox6.Visible = False
        txtBox7.Visible = False
        txtBox8.Visible = False
        txtBox9.Visible = False
        txtBox10.Visible = False
        txtBox11.Visible = False
        txtBox12.Visible = False

        txtBox2.Text = kunden_id_module
        txtBox2.Enabled = False

        lbl1.Text = "Bestellnummer:"
        lbl2.Text = "Kundennummer:"
        lbl3.Text = "Warennummer:"
        lbl4.Text = "Anzahl:"

        cmdBestaetigen.Text = "Suchen"
    '}
    ElseIf bearbeitenFensterSender.Contains("suchen_bestellungen") Then
    '{
        Me.Text = "Bestellungen durchsuchen"
        lblUeberschriftBearbeitungsfenster.Text = "Bestellungen durchsuchen"

        lbl5.Visible = False
        lbl6.Visible = False
        lbl7.Visible = False
        lbl8.Visible = False
        lbl9.Visible = False
        lbl10.Visible = False
        lbl11.Visible = False
        lbl12.Visible = False
        txtBox5.Visible = False
        txtBox6.Visible = False
        txtBox7.Visible = False
        txtBox8.Visible = False
        txtBox9.Visible = False
        txtBox10.Visible = False
        txtBox11.Visible = False
        txtBox12.Visible = False

        lbl1.Text = "Bestellnummer:"
        lbl2.Text = "Kundennummer:"
        lbl3.Text = "Warennummer:"
        lbl4.Text = "Anzahl:"

        cmdBestaetigen.Text = "Suchen"
    '}
    ElseIf bearbeitenFensterSender.Contains("suchen_kunden") Then
    '{
        Me.Text = "Kunden durchsuchen"
        lblUeberschriftBearbeitungsfenster.Text = "Kunden durchsuchen"

        lbl1.Text = "Kundennummer:"
        lbl2.Text = "Nachname:"
        lbl3.Text = "Vorname:"
        lbl4.Text = "E-Mail:"
        lbl5.Text = "Telefonnummer:"
        lbl6.Text = "Land:"
        lbl7.Text = "PLZ:"
        lbl8.Text = "Stadt:"
        lbl9.Text = "Straße:"
        lbl10.Text = "Hausnummer:"
        lbl11.Text = "Passwort:"
        lbl12.Text = "Geld:"
    '}
    ElseIf bearbeitenFensterSender.Contains("suchen_drittanbieter") Then
    '{
        Me.Text = "Drittanbieter durchsuchen"
        lblUeberschriftBearbeitungsfenster.Text = "Drittanbieter durchsuchen"

        lbl1.Text = "Warennummer:"
        lbl2.Text = "Anbieternummer:"
        lbl3.Text = "Verkaufspreis:"

        lbl4.Visible = False
        lbl5.Visible = False
        lbl6.Visible = False
        lbl7.Visible = False
        lbl8.Visible = False
        lbl9.Visible = False
        lbl10.Visible = False
        lbl11.Visible = False
        lbl12.Visible = False
        txtBox4.Visible = False
        txtBox5.Visible = False
        txtBox6.Visible = False
        txtBox7.Visible = False
        txtBox8.Visible = False
        txtBox9.Visible = False
        txtBox10.Visible = False
        txtBox11.Visible = False
        txtBox12.Visible = False
    '}
    ElseIf bearbeitenFensterSender.Contains("suchen_nachbestellungen") Then
    '{
        Me.Text = "Nachbestellungen durchsuchen"
        lblUeberschriftBearbeitungsfenster.Text = "Nachbestellungen durchsuchen"

        lbl1.Text = "Nummer:"
        lbl2.Text = "Warennummer:"
        lbl3.Text = "Anzahl:"

        lbl4.Visible = False
        lbl5.Visible = False
        lbl6.Visible = False
        lbl7.Visible = False
        lbl8.Visible = False
        lbl9.Visible = False
        lbl10.Visible = False
        lbl11.Visible = False
        lbl12.Visible = False
        txtBox4.Visible = False
        txtBox5.Visible = False
        txtBox6.Visible = False
        txtBox7.Visible = False
        txtBox8.Visible = False
        txtBox9.Visible = False
        txtBox10.Visible = False
        txtBox11.Visible = False
        txtBox12.Visible = False
        '}
    ElseIf bearbeitenFensterSender.Contains("suchen_passwort") Then
    '{
        Me.Text = "Passwörter durchsuchen"
        lblUeberschriftBearbeitungsfenster.Text = "Passwörter durchsuchen"

        lbl1.Text = "Nummer:"
        lbl2.Text = "Passwort:"
        lbl3.Text = "Beschreibung:"

        lbl4.Visible = False
        lbl5.Visible = False
        lbl6.Visible = False
        lbl7.Visible = False
        lbl8.Visible = False
        lbl9.Visible = False
        lbl10.Visible = False
        lbl11.Visible = False
        lbl12.Visible = False
        txtBox4.Visible = False
        txtBox5.Visible = False
        txtBox6.Visible = False
        txtBox7.Visible = False
        txtBox8.Visible = False
        txtBox9.Visible = False
        txtBox10.Visible = False
        txtBox11.Visible = False
        txtBox12.Visible = False
    '}
    ElseIf bearbeitenFensterSender = "kunden_registrieren" Then
    '{
        Me.Text = "Registrieren"
        lblUeberschriftBearbeitungsfenster.Text = "Registrieren"

        lbl12.Visible = False   'Man benötigt nur 11 Felder, da der Kunde nicht seine ID und sein Geld nicht bestimmen kann (Geld wird per Zufall erstellt)
        txtBox11.Enabled = False
        txtBox12.Visible = False

        lbl1.Text = "Nachname:"
        lbl2.Text = "Vorname:"
        lbl3.Text = "E-Mail:"
        lbl4.Text = "Telefonnummer:"
        lbl5.Text = "Land:"
        lbl6.Text = "PLZ:"
        lbl7.Text = "Stadt:"
        lbl8.Text = "Straße:"
        lbl9.Text = "Hausnummer:"
        lbl10.Text = "Passwort:"
        lbl11.Text = "Geld:"

        txtBox10.PasswordChar = "*"

        Dim geld As Integer = GetRandom(100, 10000)
        txtBox11.Text = geld & " €"

        cmdBestaetigen.Text = "Registrieren"
    '}
    ElseIf bearbeitenFensterSender = "aendern_lager_admin" Then
    '{
        Me.Text = "Lagereintrag ändern [" & artikel_ausgewaehlt & "]"
        lblUeberschriftBearbeitungsfenster.Text = "Lagereinträg ändern"

        lbl7.Visible = False
        lbl8.Visible = False
        lbl9.Visible = False
        lbl10.Visible = False
        lbl11.Visible = False
        lbl12.Visible = False
        txtBox7.Visible = False
        txtBox8.Visible = False
        txtBox9.Visible = False
        txtBox10.Visible = False
        txtBox11.Visible = False
        txtBox12.Visible = False

        lbl1.Text = "Warennummer:"
        lbl2.Text = "Anzahl:"
        lbl3.Text = "Name:"
        lbl4.Text = "Kategorie:"
        lbl5.Text = "Gewicht:"
        lbl6.Text = "Preis:"

        txtBox1.Enabled = False

        cmdBestaetigen.Text = "Ändern"

        Try
        '{
            connection.Open()
            command.CommandText = "SELECT * FROM lager WHERE lager_waren_id = " & artikel_ausgewaehlt & " AND lager_aktiv = True"

            Konsole.txtBox.Text += command.CommandText & Environment.NewLine & Environment.NewLine
            ScrollToEnd()

            reader = command.ExecuteReader()

            Do While reader.Read()
            '{
                txtBox1.Text = reader("lager_waren_id").ToString()
                txtBox2.Text = reader("lager_warenanzahl").ToString()
                txtBox3.Text = reader("lager_warenname").ToString()
                txtBox4.Text = reader("lager_kategorie").ToString()
                txtBox5.Text = reader("lager_warengewicht").ToString()
                txtBox6.Text = reader("lager_waren_verkaufspreis").ToString()
            '}
            Loop
            reader.Close()
        '}
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        connection.Close()
    '}
    ElseIf bearbeitenFensterSender = "aendern_bestellungen_admin" Then
    '{
        Me.Text = "Bestellung ändern"
        lblUeberschriftBearbeitungsfenster.Text = "Bestellung ändern"

        lbl5.Visible = False
        lbl6.Visible = False
        lbl7.Visible = False
        lbl8.Visible = False
        lbl9.Visible = False
        lbl10.Visible = False
        lbl11.Visible = False
        lbl12.Visible = False
        txtBox5.Visible = False
        txtBox6.Visible = False
        txtBox7.Visible = False
        txtBox8.Visible = False
        txtBox9.Visible = False
        txtBox10.Visible = False
        txtBox11.Visible = False
        txtBox12.Visible = False

        lbl1.Text = "Bestellnummer:"
        lbl2.Text = "Kundennummer:"
        lbl3.Text = "Warennummer:"
        lbl4.Text = "Anzahl:"

        txtBox1.Enabled = False

        cmdBestaetigen.Text = "Ändern"

        Try
        '{
            connection.Open()
            command.CommandText = "SELECT * FROM bestellung WHERE bestellung_id = " & artikel_ausgewaehlt & " AND bestellung_offen = True"

            Konsole.txtBox.Text += command.CommandText & Environment.NewLine & Environment.NewLine
            ScrollToEnd()

            reader = command.ExecuteReader()

            Do While reader.Read()
            '{
                txtBox1.Text = reader("bestellung_id").ToString()
                txtBox2.Text = reader("bestellung_kunden_id").ToString()
                txtBox3.Text = reader("bestellung_waren_id").ToString()
                txtBox4.Text = reader("bestellung_anzahl").ToString()
            '}
            Loop
            reader.Close()
        '}
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        connection.Close()
    '}
    ElseIf bearbeitenFensterSender = "aendern_verkaufshistorie_admin" Then
    '{
        Me.Text = "Verkaufshistorie ändern"
        lblUeberschriftBearbeitungsfenster.Text = "Verkaufshistorie ändern"

        lbl7.Visible = False
        lbl8.Visible = False
        lbl9.Visible = False
        lbl10.Visible = False
        lbl11.Visible = False
        lbl12.Visible = False
        txtBox7.Visible = False
        txtBox8.Visible = False
        txtBox9.Visible = False
        txtBox10.Visible = False
        txtBox11.Visible = False
        txtBox12.Visible = False

        lbl1.Text = "Bestellnummer:"
        lbl2.Text = "Kundennummer:"
        lbl3.Text = "Kaufdatum:"
        lbl4.Text = "Warennummer:"
        lbl5.Text = "Verkaufspreis:"
        lbl6.Text = "Anzahl:"

        cmdBestaetigen.Text = "Ändern"

        Try
        '{
            connection.Open()
            command.CommandText = "SELECT * FROM verkaufshistorie WHERE verkaufshistorie_bestellung_id = " & artikel_ausgewaehlt

            Konsole.txtBox.Text += command.CommandText & Environment.NewLine & Environment.NewLine
            ScrollToEnd()

            reader = command.ExecuteReader()

            Do While reader.Read()
            '{
                Dim kaufdatum As DateTime = Convert.ToDateTime(reader("verkaufshistorie_datum"))
                kaufdatum.ToString("dd.MM.yyy")

                txtBox1.Text = reader("verkaufshistorie_bestellung_id").ToString()
                txtBox2.Text = reader("verkaufshistorie_kunden_id").ToString()
                txtBox3.Text = kaufdatum
                txtBox4.Text = reader("verkaufshistorie_waren_id").ToString()
                txtBox5.Text = reader("verkaufshistorie_verkaufspreis").ToString()
                txtBox6.Text = reader("verkaufshistorie_waren_anzahl").ToString()
            '}
            Loop
            reader.Close()
        '}
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        connection.Close()
    '}
    ElseIf bearbeitenFensterSender = "aendern_kunden_admin" Then
    '{
        Me.Text = "Kundenkonto ändern [" & artikel_ausgewaehlt & "]"
        lblUeberschriftBearbeitungsfenster.Text = "Kundenkonto ändern"

        lbl1.Text = "ID:"
        lbl2.Text = "Nachname:"
        lbl3.Text = "Vorname:"
        lbl4.Text = "E-Mail:"
        lbl5.Text = "Telefonnummer:"
        lbl6.Text = "Land:"
        lbl7.Text = "PLZ:"
        lbl8.Text = "Stadt:"
        lbl9.Text = "Straße:"
        lbl10.Text = "Hausnummer:"
        lbl11.Text = "Passwort:"
        lbl12.Text = "Geld:"

        txtBox1.Enabled = False

        cmdBestaetigen.Text = "Ändern"

        Try
        '{
            connection.Open()
            command.CommandText = "SELECT * FROM kunden WHERE kunden_id = " & artikel_ausgewaehlt & " AND kunden_konto_aktiv = True"

            Konsole.txtBox.Text += command.CommandText & Environment.NewLine & Environment.NewLine
            ScrollToEnd()

            reader = command.ExecuteReader()

            Do While reader.Read()
            '{
                txtBox1.Text = reader("kunden_id").ToString()
                txtBox2.Text = reader("kunden_name").ToString()
                txtBox3.Text = reader("kunden_vorname").ToString()
                txtBox4.Text = reader("kunden_email").ToString()
                txtBox5.Text = reader("kunden_telefonnummer").ToString()
                txtBox6.Text = reader("kunden_land").ToString()
                txtBox7.Text = reader("kunden_plz").ToString()
                txtBox8.Text = reader("kunden_stadt").ToString()
                txtBox9.Text = reader("kunden_straße").ToString()
                txtBox10.Text = reader("kunden_hausnummer").ToString()
                txtBox11.Text = reader("kunden_passwort").ToString()
                txtBox12.Text = reader("kunden_geld").ToString()
            '}
            Loop
            reader.Close()
        '}
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        connection.Close()
    '}
    ElseIf bearbeitenFensterSender = "aendern_drittanbieter_admin" Then
    '{
        Me.Text = "Drittanbieter ändern"
        lblUeberschriftBearbeitungsfenster.Text = "Drittanbieter ändern"

        lbl4.Visible = False
        lbl5.Visible = False
        lbl6.Visible = False
        lbl7.Visible = False
        lbl8.Visible = False
        lbl9.Visible = False
        lbl10.Visible = False
        lbl11.Visible = False
        lbl12.Visible = False
        txtBox4.Visible = False
        txtBox5.Visible = False
        txtBox6.Visible = False
        txtBox7.Visible = False
        txtBox8.Visible = False
        txtBox9.Visible = False
        txtBox10.Visible = False
        txtBox11.Visible = False
        txtBox12.Visible = False

        lbl1.Text = "Warennummer:"
        lbl2.Text = "Anbieternummer:"
        lbl3.Text = "Verkaufspreis:"

        cmdBestaetigen.Text = "Ändern"

        Try
        '{
            connection.Open()
            command.CommandText = "SELECT * FROM drittanbieter WHERE drittanbieter_waren_id = " & artikel_ausgewaehlt

            Konsole.txtBox.Text += command.CommandText & Environment.NewLine & Environment.NewLine
            ScrollToEnd()

            reader = command.ExecuteReader()

            Do While reader.Read()
            '{
                txtBox1.Text = reader("drittanbieter_waren_id").ToString()
                txtBox2.Text = reader("drittanbieter_anbieter_id").ToString()
                txtBox3.Text = reader("drittanbieter_verkaufspreis").ToString()
            '}
            Loop
            reader.Close()
        '}
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        connection.Close()
    '}
    ElseIf bearbeitenFensterSender = "aendern_nachbestellungen_admin" Then
    '{
        Me.Text = "Nachbestellung ändern [" & artikel_ausgewaehlt & "]"
        lblUeberschriftBearbeitungsfenster.Text = "Nachbestellung ändern"

        lbl4.Visible = False
        lbl5.Visible = False
        lbl6.Visible = False
        lbl7.Visible = False
        lbl8.Visible = False
        lbl9.Visible = False
        lbl10.Visible = False
        lbl11.Visible = False
        lbl12.Visible = False
        txtBox4.Visible = False
        txtBox5.Visible = False
        txtBox6.Visible = False
        txtBox7.Visible = False
        txtBox8.Visible = False
        txtBox9.Visible = False
        txtBox10.Visible = False
        txtBox11.Visible = False
        txtBox12.Visible = False

        lbl1.Text = "Nummer:"
        lbl2.Text = "Warennummer:"
        lbl3.Text = "Anzahl:"

        txtBox1.Enabled = False

        cmdBestaetigen.Text = "Ändern"

        Try
        '{
            connection.Open()
            command.CommandText = "SELECT * FROM nachbestellungen WHERE nachbestellungen_id = " & artikel_ausgewaehlt

            Konsole.txtBox.Text += command.CommandText & Environment.NewLine & Environment.NewLine
            ScrollToEnd()

            reader = command.ExecuteReader()

            Do While reader.Read()
            '{
                txtBox1.Text = reader("nachbestellungen_id").ToString()
                txtBox2.Text = reader("nachbestellungen_waren_id").ToString()
                txtBox3.Text = reader("nachbestellungen_waren_anzahl").ToString()
            '}
            Loop
            reader.Close()
        '}
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        connection.Close()
    '}
    ElseIf bearbeitenFensterSender = "aendern_passwoerter_admin" Then
    '{
        Me.Text = "Passwort ändern"
        lblUeberschriftBearbeitungsfenster.Text = "Passwort ändern"

        lbl4.Visible = False
        lbl5.Visible = False
        lbl6.Visible = False
        lbl7.Visible = False
        lbl8.Visible = False
        lbl9.Visible = False
        lbl10.Visible = False
        lbl11.Visible = False
        lbl12.Visible = False
        txtBox4.Visible = False
        txtBox5.Visible = False
        txtBox6.Visible = False
        txtBox7.Visible = False
        txtBox8.Visible = False
        txtBox9.Visible = False
        txtBox10.Visible = False
        txtBox11.Visible = False
        txtBox12.Visible = False

        txtBox1.Enabled = False

        lbl1.Text = "ID:"
        lbl2.Text = "Passwort:"
        lbl3.Text = "Beschreibung:"

        cmdBestaetigen.Text = "Ändern"

        Try
        '{
            connection.Open()
            command.CommandText = "SELECT * FROM passwort WHERE passwort_id = " & artikel_ausgewaehlt

            Konsole.txtBox.Text += command.CommandText & Environment.NewLine & Environment.NewLine
            ScrollToEnd()

            reader = command.ExecuteReader()

            Do While reader.Read()
            '{
                txtBox1.Text = reader("passwort_id").ToString()
                txtBox2.Text = reader("passwort").ToString()
                txtBox3.Text = reader("passwort_beschreibung").ToString()
            '}
            Loop
            reader.Close()
        '}
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        connection.Close()
    '}
    ElseIf bearbeitenFensterSender = "aendern_firma_admin" Then
    '{
        Me.Text = "Firma ändern"
        lblUeberschriftBearbeitungsfenster.Text = "Firma ändern"

        lbl8.Visible = False
        lbl9.Visible = False
        lbl10.Visible = False
        lbl11.Visible = False
        lbl12.Visible = False
        txtBox8.Visible = False
        txtBox9.Visible = False
        txtBox10.Visible = False
        txtBox11.Visible = False
        txtBox12.Visible = False

        lbl1.Text = "Budget:"
        lbl2.Text = "Name:"
        lbl3.Text = "Straße:"
        lbl4.Text = "Hausnummer:"
        lbl5.Text = "PLZ:"
        lbl6.Text = "Stadt:"
        lbl7.Text = "Land:"

        cmdBestaetigen.Text = "Ändern"

        Try
        '{
            connection.Open()
            command.CommandText = "SELECT * FROM firma"

            reader = command.ExecuteReader()

            Do While reader.Read()
            '{
                txtBox1.Text = reader("firmen_budget").ToString()
                txtBox2.Text = reader("firmen_name").ToString()
                txtBox3.Text = reader("firmen_straße").ToString()
                txtBox4.Text = reader("firmen_hausnummer").ToString()
                txtBox5.Text = reader("firmen_plz").ToString()
                txtBox6.Text = reader("firmen_stadt").ToString()
                txtBox7.Text = reader("firmen_land").ToString()
            '}
            Loop
            reader.Close()
        '}
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        connection.Close()
    '}
    ElseIf bearbeitenFensterSender = "einfuegen_lager_admin" Then
    '{
        Me.Text = "Einfügen in Lager"
        lblUeberschriftBearbeitungsfenster.Text = "Einfügen in Lager"

        lbl6.Visible = False
        lbl7.Visible = False
        lbl8.Visible = False
        lbl9.Visible = False
        lbl10.Visible = False
        lbl11.Visible = False
        lbl12.Visible = False
        txtBox6.Visible = False
        txtBox7.Visible = False
        txtBox8.Visible = False
        txtBox9.Visible = False
        txtBox10.Visible = False
        txtBox11.Visible = False
        txtBox12.Visible = False

        lbl1.Text = "Anzahl:"
        lbl2.Text = "Name:"
        lbl3.Text = "Kategorie:"
        lbl4.Text = "Gewicht:"
        lbl5.Text = "Verkaufspreis:"

        cmdBestaetigen.Text = "Einfügen"
    '}
    ElseIf bearbeitenFensterSender = "einfuegen_bestellungen_admin" Then
    '{
        Me.Text = "Einfügen in Bestellungen"
        lblUeberschriftBearbeitungsfenster.Text = "Einfügen in Bestellungen"

        lbl4.Visible = False
        lbl5.Visible = False
        lbl6.Visible = False
        lbl7.Visible = False
        lbl8.Visible = False
        lbl9.Visible = False
        lbl10.Visible = False
        lbl11.Visible = False
        lbl12.Visible = False
        txtBox4.Visible = False
        txtBox5.Visible = False
        txtBox6.Visible = False
        txtBox7.Visible = False
        txtBox8.Visible = False
        txtBox9.Visible = False
        txtBox10.Visible = False
        txtBox11.Visible = False
        txtBox12.Visible = False

        lbl1.Text = "Kundennummer:"
        lbl2.Text = "Warennummer:"
        lbl3.Text = "Anzahl:"

        cmdBestaetigen.Text = "Einfügen"
    '}
    ElseIf bearbeitenFensterSender = "einfuegen_verkaufshistorie_admin" Then
    '{
        Me.Text = "Einfügen in Verkaufshistorie"
        lblUeberschriftBearbeitungsfenster.Text = "Einfügen in Verkaufshistorie"

        lbl7.Visible = False
        lbl8.Visible = False
        lbl9.Visible = False
        lbl10.Visible = False
        lbl11.Visible = False
        lbl12.Visible = False
        txtBox7.Visible = False
        txtBox8.Visible = False
        txtBox9.Visible = False
        txtBox10.Visible = False
        txtBox11.Visible = False
        txtBox12.Visible = False

        lbl1.Text = "Bestellnummer:"
        lbl2.Text = "Kundennummer:"
        lbl3.Text = "Datum:"
        lbl4.Text = "Warennummer:"
        lbl5.Text = "Verkaufspreis:"
        lbl6.Text = "Anzahl:"

        cmdBestaetigen.Text = "Einfügen"
    '}
    ElseIf bearbeitenFensterSender = "einfuegen_kunden_admin" Then
    '{
        Me.Text = "Einfügen in Kunden"
        lblUeberschriftBearbeitungsfenster.Text = "Einfügen in Kunden"

        lbl12.Visible = False
        txtBox12.Visible = False

        lbl1.Text = "Name:"
        lbl2.Text = "Vorname:"
        lbl3.Text = "E-Mail:"
        lbl4.Text = "Telefonnummer:"
        lbl5.Text = "Land:"
        lbl6.Text = "PLZ:"
        lbl7.Text = "Stadt:"
        lbl8.Text = "Straße:"
        lbl9.Text = "Hausnummer:"
        lbl10.Text = "Passwort:"
        lbl11.Text = "Geld:"

        cmdBestaetigen.Text = "Einfügen"
    '}
    ElseIf bearbeitenFensterSender = "einfuegen_drittanbieter_admin" Then
    '{
        Me.Text = "Einfügen in Drittanbieter"
        lblUeberschriftBearbeitungsfenster.Text = "Einfügen in Drittanbieter"

        lbl4.Visible = False
        lbl5.Visible = False
        lbl6.Visible = False
        lbl7.Visible = False
        lbl8.Visible = False
        lbl9.Visible = False
        lbl10.Visible = False
        lbl11.Visible = False
        lbl12.Visible = False
        txtBox4.Visible = False
        txtBox5.Visible = False
        txtBox6.Visible = False
        txtBox7.Visible = False
        txtBox8.Visible = False
        txtBox9.Visible = False
        txtBox10.Visible = False
        txtBox11.Visible = False
        txtBox12.Visible = False

        lbl1.Text = "Warennummer:"
        lbl2.Text = "Anbieternummer:"
        lbl3.Text = "Preis:"

        cmdBestaetigen.Text = "Einfügen"
    '}
    ElseIf bearbeitenFensterSender = "einfuegen_nachbestellungen_admin" Then
    '{
        Me.Text = "Einfügen in Nachbestellungen"
        lblUeberschriftBearbeitungsfenster.Text = "Einfügen in Nachbestellungen"

        lbl3.Visible = False
        lbl4.Visible = False
        lbl5.Visible = False
        lbl6.Visible = False
        lbl7.Visible = False
        lbl8.Visible = False
        lbl9.Visible = False
        lbl10.Visible = False
        lbl11.Visible = False
        lbl12.Visible = False
        txtBox3.Visible = False
        txtBox4.Visible = False
        txtBox5.Visible = False
        txtBox6.Visible = False
        txtBox7.Visible = False
        txtBox8.Visible = False
        txtBox9.Visible = False
        txtBox10.Visible = False
        txtBox11.Visible = False
        txtBox12.Visible = False

        lbl1.Text = "Warennummer:"
        lbl2.Text = "Anzahl:"

        cmdBestaetigen.Text = "Einfügen"
    '}
    ElseIf bearbeitenFensterSender = "nachbestellen_versand" Then
    '{
        Me.Text = "Nachbestellen"
        lblUeberschriftBearbeitungsfenster.Text = "Nachbestellen"

        lbl3.Visible = False
        lbl4.Visible = False
        lbl5.Visible = False
        lbl6.Visible = False
        lbl7.Visible = False
        lbl8.Visible = False
        lbl9.Visible = False
        lbl10.Visible = False
        lbl11.Visible = False
        lbl12.Visible = False
        txtBox3.Visible = False
        txtBox4.Visible = False
        txtBox5.Visible = False
        txtBox6.Visible = False
        txtBox7.Visible = False
        txtBox8.Visible = False
        txtBox9.Visible = False
        txtBox10.Visible = False
        txtBox11.Visible = False
        txtBox12.Visible = False

        lbl1.Text = "Warennummer:"
        lbl2.Text = "Anzahl:"

        If Not artikel_ausgewaehlt = Nothing Then
            txtBox1.Text = artikel_ausgewaehlt
        End If

        cmdBestaetigen.Text = "Nachbestellen"
    '}
    ElseIf bearbeitenFensterSender = "einfuegen_budgetverlauf_admin" Then
    '{
        Me.Text = "Budgetverlauf einfügen"
        lblUeberschriftBearbeitungsfenster.Text = "Budgetverlauf einfügen"

        lbl3.Visible = False
        lbl4.Visible = False
        lbl5.Visible = False
        lbl6.Visible = False
        lbl7.Visible = False
        lbl8.Visible = False
        lbl9.Visible = False
        lbl10.Visible = False
        lbl11.Visible = False
        lbl12.Visible = False
        txtBox3.Visible = False
        txtBox4.Visible = False
        txtBox5.Visible = False
        txtBox6.Visible = False
        txtBox7.Visible = False
        txtBox8.Visible = False
        txtBox9.Visible = False
        txtBox10.Visible = False
        txtBox11.Visible = False
        txtBox12.Visible = False

        lbl1.Text = "Wert:"
        lbl2.Text = "Datum:"

        txtBox2.Text = Date.Now

        cmdBestaetigen.Text = "Einfügen"
    '}
    ElseIf bearbeitenFensterSender = "aendern_budgetverlauf_admin" Then
    '{
        Me.Text = "Budgetverlauf ändern"
        lblUeberschriftBearbeitungsfenster.Text = "Budgetverlauf ändern"

        lbl3.Visible = False
        lbl4.Visible = False
        lbl5.Visible = False
        lbl6.Visible = False
        lbl7.Visible = False
        lbl8.Visible = False
        lbl9.Visible = False
        lbl10.Visible = False
        lbl11.Visible = False
        lbl12.Visible = False
        txtBox3.Visible = False
        txtBox4.Visible = False
        txtBox5.Visible = False
        txtBox6.Visible = False
        txtBox7.Visible = False
        txtBox8.Visible = False
        txtBox9.Visible = False
        txtBox10.Visible = False
        txtBox11.Visible = False
        txtBox12.Visible = False

        lbl1.Text = "Wert:"
        lbl2.Text = "Datum:"

        cmdBestaetigen.Text = "Ändern"

        Try
        '{
            connection.Open()
            command.CommandText = "SELECT budgetverlauf_wert, budgetverlauf_datum FROM budgetverlauf WHERE budgetverlauf_id = " & artikel_ausgewaehlt
            Konsole.txtBox.Text += command.CommandText & Environment.NewLine & Environment.NewLine
            ScrollToEnd()
            reader = command.ExecuteReader()

            Do While reader.Read()
            '{
                txtBox1.Text = reader("budgetverlauf_wert").ToString()
                txtBox2.Text = reader("budgetverlauf_datum").ToString()
            '}
            Loop
            reader.Close()
        '}
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        connection.Close()
    '}
    ElseIf bearbeitenFensterSender = "suchen_budgetverlauf_admin" Then
    '{
        Me.Text = "Budgetverlauf durchsuchen"
        lblUeberschriftBearbeitungsfenster.Text = "Budgetverlauf durchsuchen"

        lbl4.Visible = False
        lbl5.Visible = False
        lbl6.Visible = False
        lbl7.Visible = False
        lbl8.Visible = False
        lbl9.Visible = False
        lbl10.Visible = False
        lbl11.Visible = False
        lbl12.Visible = False
        txtBox4.Visible = False
        txtBox5.Visible = False
        txtBox6.Visible = False
        txtBox7.Visible = False
        txtBox8.Visible = False
        txtBox9.Visible = False
        txtBox10.Visible = False
        txtBox11.Visible = False
        txtBox12.Visible = False

        lbl1.Text = "ID:"
        lbl2.Text = "Wert:"
        lbl3.Text = "Datum:"

        cmdBestaetigen.Text = "Suchen"
    '}
    ElseIf bearbeitenFensterSender = "suchen_kontoverlauf_kunde" Then
    '{
        Me.Text = "Kontoverlauf durchsuchen"
        lblUeberschriftBearbeitungsfenster.Text = "Kontoverlauf durchsuchen"

        lbl4.Visible = False
        lbl5.Visible = False
        lbl6.Visible = False
        lbl7.Visible = False
        lbl8.Visible = False
        lbl9.Visible = False
        lbl10.Visible = False
        lbl11.Visible = False
        lbl12.Visible = False
        txtBox4.Visible = False
        txtBox5.Visible = False
        txtBox6.Visible = False
        txtBox7.Visible = False
        txtBox8.Visible = False
        txtBox9.Visible = False
        txtBox10.Visible = False
        txtBox11.Visible = False
        txtBox12.Visible = False

        lbl1.Text = "ID:"
        lbl2.Text = "Wert:"
        lbl3.Text = "Datum:"

        cmdBestaetigen.Text = "Suchen"
    '}
    ElseIf bearbeitenFensterSender = "einfuegen_kontoverlauf_admin" Then
    '{
        Me.Text = "Kontoverlauf einfügen"
        lblUeberschriftBearbeitungsfenster.Text = "Kontoverlauf einfügen"

        lbl4.Visible = False
        lbl5.Visible = False
        lbl6.Visible = False
        lbl7.Visible = False
        lbl8.Visible = False
        lbl9.Visible = False
        lbl10.Visible = False
        lbl11.Visible = False
        lbl12.Visible = False
        txtBox4.Visible = False
        txtBox5.Visible = False
        txtBox6.Visible = False
        txtBox7.Visible = False
        txtBox8.Visible = False
        txtBox9.Visible = False
        txtBox10.Visible = False
        txtBox11.Visible = False
        txtBox12.Visible = False

        lbl1.Text = "Kundennummer:"
        lbl2.Text = "Wert:"
        lbl3.Text = "Datum:"

        txtBox3.Text = Date.Now

        cmdBestaetigen.Text = "Einfügen"
    '}
    ElseIf bearbeitenFensterSender = "aendern_kontoverlauf_admin" Then
    '{
        Me.Text = "Kontoverlauf ändern"
        lblUeberschriftBearbeitungsfenster.Text = "Kontoverlauf ändern"

        lbl4.Visible = False
        lbl5.Visible = False
        lbl6.Visible = False
        lbl7.Visible = False
        lbl8.Visible = False
        lbl9.Visible = False
        lbl10.Visible = False
        lbl11.Visible = False
        lbl12.Visible = False
        txtBox4.Visible = False
        txtBox5.Visible = False
        txtBox6.Visible = False
        txtBox7.Visible = False
        txtBox8.Visible = False
        txtBox9.Visible = False
        txtBox10.Visible = False
        txtBox11.Visible = False
        txtBox12.Visible = False

        lbl1.Text = "Kundennummer:"
        lbl2.Text = "Wert:"
        lbl3.Text = "Datum:"

        cmdBestaetigen.Text = "Ändern"

        Try
        '{
            connection.Open()
            command.CommandText = "SELECT * FROM kontoverlauf WHERE kontoverlauf_id = " & artikel_ausgewaehlt
            Konsole.txtBox.Text += command.CommandText & Environment.NewLine & Environment.NewLine
            ScrollToEnd()
            reader = command.ExecuteReader()

            Do While reader.Read()
            '{
                txtBox1.Text = reader("kontoverlauf_kunden_id").ToString()
                txtBox2.Text = reader("kontoverlauf_wert").ToString()
                txtBox3.Text = reader("kontoverlauf_datum").ToString()
            '}
            Loop
            reader.Close()
        '}
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        connection.Close()
    '}
    End If
End Sub


'EVENTHANDLER

Private Sub cmdBestaetigen_Click(sender As Object, e As EventArgs) Handles cmdBestaetigen.Click
    If bearbeitenFensterSender = "kundenkonto_bearbeiten" Then
        AendernKundenkonto()
    ElseIf bearbeitenFensterSender.Contains("suchen_lager") Then
        SucheLager()
    ElseIf bearbeitenFensterSender.Contains("suchen_verkaufshistorie") Then
        SucheVerkaufshistorie()
    ElseIf bearbeitenFensterSender = "suchen_offene_bestellungen_kunde" Then
        SucheOffeneBestellungen()
    ElseIf bearbeitenFensterSender.Contains("suchen_bestellungen") Then
        SucheBestellungen()
    ElseIf bearbeitenFensterSender = "suchen_kunden_admin" Then
        SucheKundenAdmin()
    ElseIf bearbeitenFensterSender.Contains("suchen_drittanbieter") Then
        SucheDrittanbieter()
    ElseIf bearbeitenFensterSender.Contains("suchen_nachbestellungen") Then
        SucheNachbestellungen()
    ElseIf bearbeitenFensterSender = "suchen_passwort_admin" Then
        SuchePasswortAdmin()
    ElseIf bearbeitenFensterSender = "kunden_registrieren" Then
        Registrieren()
    ElseIf bearbeitenFensterSender = "aendern_lager_admin" Then
        AendernLagerAdmin()
    ElseIf bearbeitenFensterSender = "aendern_bestellungen_admin" Then
        AendernBestellungenAdmin()
    ElseIf bearbeitenFensterSender = "aendern_verkaufshistorie_admin" Then
        AendernVerkaufshistorieAdmin()
    ElseIf bearbeitenFensterSender = "aendern_kunden_admin" Then
        AendernKundenAdmin()
    ElseIf bearbeitenFensterSender = "aendern_drittanbieter_admin" Then
        AendernDrittanbieterAdmin()
    ElseIf bearbeitenFensterSender = "aendern_nachbestellungen_admin" Then
        AendernNachbestellungenAdmin()
    ElseIf bearbeitenFensterSender = "aendern_passwoerter_admin" Then
        AendernPasswoerterAdmin()
    ElseIf bearbeitenFensterSender = "aendern_firma_admin" Then
        AendernFirmaAdmin()
    ElseIf bearbeitenFensterSender = "einfuegen_lager_admin" Then
        EinfuegenLager()
    ElseIf bearbeitenFensterSender = "einfuegen_bestellungen_admin" Then
        EinfuegenBestellungen()
    ElseIf bearbeitenFensterSender = "einfuegen_verkaufshistorie_admin" Then
        EinfuegenVerkaufshistorie()
    ElseIf bearbeitenFensterSender = "einfuegen_kunden_admin" Then
        EinfuegenKunden()
    ElseIf bearbeitenFensterSender = "einfuegen_drittanbieter_admin" Then
        EinfuegenDrittanbieter()
    ElseIf bearbeitenFensterSender = "einfuegen_nachbestellungen_admin" Then
        EinfuegenNachbestellungen()
    ElseIf bearbeitenFensterSender = "nachbestellen_versand" Then
        EinfuegenNachbestellungen()
    ElseIf bearbeitenFensterSender = "einfuegen_budgetverlauf_admin" Then
        EinfuegenBudgetverlauf()
    ElseIf bearbeitenFensterSender = "aendern_budgetverlauf_admin" Then
        AendernBudgetverlaufAdmin()
    ElseIf bearbeitenFensterSender = "suchen_budgetverlauf_admin" Then
        SucheBudgetVerlaufAdmin()
    ElseIf bearbeitenFensterSender = "suchen_kontoverlauf_kunde" Then
        SucheKontoVerlaufKunde()
    ElseIf bearbeitenFensterSender = "einfuegen_kontoverlauf_admin" Then
        EinfuegenKontoverlauf()
    ElseIf bearbeitenFensterSender = "aendern_kontoverlauf_admin" Then
        AendernKontoverlaufAdmin()
    End If

    Me.Close()
End Sub

'ÄNDERN

Private Sub AendernLagerAdmin()
    Try
    '{
        connection.Open()
        command.CommandText = "UPDATE lager SET lager_warenanzahl = '" & txtBox2.Text & "', lager_warenname = '" & txtBox3.Text & "', lager_kategorie = '" & txtBox4.Text & "', lager_warengewicht = '" & txtBox5.Text & "', lager_waren_verkaufspreis = '" & txtBox6.Text & "' WHERE lager_waren_id = " & artikel_ausgewaehlt & " AND lager_aktiv = True"

        command.ExecuteNonQuery()

        Konsole.txtBox.Text += command.CommandText & Environment.NewLine & Environment.NewLine
        ScrollToEnd()
    '}
    Catch ex As Exception
        MessageBox.Show(ex.Message)
    End Try
    connection.Close()
    FormAdministrator.LagerAnzeigen("lager_erneut_laden")
End Sub

Private Sub AendernBestellungenAdmin()
    Try
    '{
        connection.Open()
        command.CommandText = "UPDATE bestellung SET bestellung_kunden_id = '" & txtBox2.Text & "', bestellung_waren_id = '" & txtBox3.Text & "', bestellung_anzahl = '" & txtBox4.Text & "' WHERE bestellung_id = " & artikel_ausgewaehlt & " AND bestellung_offen = True"

        command.ExecuteNonQuery()

        Konsole.txtBox.Text += command.CommandText & Environment.NewLine & Environment.NewLine
        ScrollToEnd()
    '}
    Catch ex As Exception
        MsgBox(ex.Message)
    End Try
    connection.Close()
    FormAdministrator.BestellungenAnzeigen("bestellungen_erneut_laden")
End Sub

Private Sub AendernVerkaufshistorieAdmin()
    Try
    '{
        connection.Open()
        command.CommandText = "UPDATE verkaufshistorie SET verkaufshistorie_bestellung_id = '" & txtBox1.Text & "',  verkaufshistorie_kunden_id = '" & txtBox2.Text & "', verkaufshistorie_datum = '" & txtBox3.Text & "', verkaufshistorie_waren_id = '" & txtBox4.Text & "', verkaufshistorie_verkaufspreis = '" & txtBox5.Text & "', verkaufshistorie_waren_anzahl = '" & txtBox6.Text & "' WHERE verkaufshistorie_bestellung_id = " & artikel_ausgewaehlt

        command.ExecuteNonQuery()

        Konsole.txtBox.Text += command.CommandText & Environment.NewLine & Environment.NewLine
        ScrollToEnd()
    '}
    Catch ex As Exception
        MsgBox(ex.Message)
    End Try
    connection.Close()
    FormAdministrator.VerkaufshsitorieAnzeigen("verkaufshistorie_erneut_laden")
End Sub

Private Sub AendernKundenAdmin()
    Try
    '{
        connection.Open()
        'CHECK 1: VORHER
        command.CommandText = "SELECT kunden_geld FROM kunden WHERE kunden_id = " & FormAdministrator.lstViewKunden.Items(FormAdministrator.lstViewKunden.FocusedItem.Index).SubItems(0).Text.ToString()
        Konsole.txtBox.Text += command.CommandText & Environment.NewLine & Environment.NewLine
        ScrollToEnd()
        reader = command.ExecuteReader()
        Dim check1 As Integer
        Do While reader.Read()
            check1 = reader("kunden_geld")
        Loop
        reader.Close()


        command.CommandText = "UPDATE kunden SET kunden_name = '" & txtBox2.Text & "', kunden_vorname = '" & txtBox3.Text & "', kunden_email = '" & txtBox4.Text & "', kunden_telefonnummer = '" & txtBox5.Text & "', kunden_land = '" & txtBox6.Text & "', kunden_plz = '" & txtBox7.Text & "', kunden_stadt = '" & txtBox8.Text & "', kunden_straße = '" & txtBox9.Text & "', kunden_hausnummer = '" & txtBox10.Text & "', kunden_passwort = '" & txtBox11.Text & "', kunden_geld = '" & txtBox12.Text & "' WHERE kunden_id = " & artikel_ausgewaehlt

        command.ExecuteNonQuery()

        Konsole.txtBox.Text += command.CommandText & Environment.NewLine & Environment.NewLine
        ScrollToEnd()

        'CHECK 2: NACHHER
        command.CommandText = "SELECT kunden_geld FROM kunden WHERE kunden_id = " & FormAdministrator.lstViewKunden.Items(FormAdministrator.lstViewKunden.FocusedItem.Index).SubItems(0).Text.ToString()
        Konsole.txtBox.Text += command.CommandText & Environment.NewLine & Environment.NewLine
        ScrollToEnd()
        reader = command.ExecuteReader()
        Dim check2 As Integer
        Do While reader.Read()
            check2 = reader("kunden_geld")
        Loop
        reader.Close()

        If check1 <> check2 Then
            command.CommandText = "INSERT INTO kontoverlauf (kontoverlauf_kunden_id, kontoverlauf_wert, kontoverlauf_datum) values ('" & FormAdministrator.lstViewKunden.Items(FormAdministrator.lstViewKunden.FocusedItem.Index).SubItems(0).Text.ToString() & "', '" & check2 & "', '" & Date.Now & "')"
            Konsole.txtBox.Text += command.CommandText & Environment.NewLine & Environment.NewLine
            ScrollToEnd()
            command.ExecuteNonQuery()
        End If
    '}
    Catch ex As Exception
        MsgBox(ex.Message)
    End Try
    connection.Close()
    FormAdministrator.KundenAnzeigen("kundenkonto_erneut_laden")
    FormAdministrator.BudgetverlaufAnzeigen("budgetverlauf_erneut_laden")
    FormAdministrator.BudgetverlaufChartAnzeigen()
End Sub

Private Sub AendernDrittanbieterAdmin()
    Try
    '{
        connection.Open()
        command.CommandText = "UPDATE drittanbieter SET drittanbieter_waren_id = '" & txtBox1.Text & "', drittanbieter_anbieter_id = '" & txtBox2.Text & "', drittanbieter_verkaufspreis = '" & txtBox3.Text & "' WHERE drittanbieter_waren_id = " & artikel_ausgewaehlt

        command.ExecuteNonQuery()

        Konsole.txtBox.Text += command.CommandText & Environment.NewLine & Environment.NewLine
        ScrollToEnd()
    '}
    Catch ex As Exception
        MsgBox(ex.Message)
    End Try
    connection.Close()
    FormAdministrator.DrittanbieterAnzeigen("drittanbieter_erneut_laden")
End Sub

Private Sub AendernNachbestellungenAdmin()
    Try
    '{
        connection.Open()
        command.CommandText = "UPDATE nachbestellungen SET nachbestellungen_waren_id = '" & txtBox2.Text & "', nachbestellungen_waren_anzahl = '" & txtBox3.Text & "' WHERE nachbestellungen_id = " & artikel_ausgewaehlt

        command.ExecuteNonQuery()

        Konsole.txtBox.Text += command.CommandText & Environment.NewLine & Environment.NewLine
        ScrollToEnd()
    '}
    Catch ex As Exception
        MsgBox(ex.Message)
    End Try
    connection.Close()
    FormAdministrator.NachbestellungenAnzeigen("nachbestellungen_erneut_laden")
End Sub

Private Sub AendernPasswoerterAdmin()
    Try
    '{
        connection.Open()
        command.CommandText = "UPDATE passwort SET passwort = '" & txtBox2.Text & "', passwort_beschreibung = '" & txtBox3.Text & "' WHERE passwort_id = " & artikel_ausgewaehlt

        command.ExecuteNonQuery()

        Konsole.txtBox.Text += command.CommandText & Environment.NewLine & Environment.NewLine
        ScrollToEnd()
    '}
    Catch ex As Exception
        MsgBox(ex.Message)
    End Try
    connection.Close()
    FormAdministrator.PasswoerterAnzeigen("passwoerter_erneut_laden")
End Sub

Private Sub AendernFirmaAdmin()
    Try
    '{
        connection.Open()
        'CHECK 1: VORHER
        command.CommandText = "SELECT firmen_budget FROM firma"
        reader = command.ExecuteReader()
        Dim check1 As Integer
        Do While reader.Read()
            check1 = reader("firmen_budget")
        Loop
        reader.Close()

        command.CommandText = "UPDATE firma SET firmen_budget = '" & txtBox1.Text & "', firmen_name = '" & txtBox2.Text & "', firmen_straße = '" & txtBox3.Text & "', firmen_hausnummer = '" & txtBox4.Text & "', firmen_plz = '" & txtBox5.Text & "', firmen_stadt = '" & txtBox6.Text & "', firmen_land = '" & txtBox7.Text & "'"
        Konsole.txtBox.Text += command.CommandText & Environment.NewLine & Environment.NewLine
        ScrollToEnd()
        command.ExecuteNonQuery()

        'CHECK 2: NACHHER
        command.CommandText = "SELECT firmen_budget FROM firma"
        reader = command.ExecuteReader()
        Dim check2 As Integer
        Do While reader.Read()
            check2 = reader("firmen_budget")
        Loop
        reader.Close()

        If check1 <> check2 Then
        '{
            command.CommandText = "INSERT INTO budgetverlauf (budgetverlauf_wert, budgetverlauf_datum) values ('" & check2 & "', '" & Date.Now & "')"
            Konsole.txtBox.Text += command.CommandText & Environment.NewLine & Environment.NewLine
            ScrollToEnd()
            command.ExecuteNonQuery()
        '}
        End If
    '}
    Catch ex As Exception
        MsgBox(ex.Message)
    End Try
    connection.Close()
    FormAdministrator.FirmaAnzeigen("firma_erneut_laden")
    FormAdministrator.FirmenbudgetAnzeigen()
    FormAdministrator.BudgetverlaufAnzeigen("budgetverlauf_erneut_laden")
    FormAdministrator.BudgetverlaufChartAnzeigen()
End Sub

Private Sub AendernKundenkonto()
    Try
        '{
            connection.Open()
            command.CommandText = "UPDATE kunden SET kunden_name = '" & txtBox1.Text & "', kunden_vorname = '" & txtBox2.Text & "', kunden_email = '" & txtBox3.Text & "', kunden_telefonnummer = '" & txtBox4.Text & "', kunden_land = '" & txtBox5.Text & "', kunden_plz = '" & txtBox6.Text & "', kunden_stadt = '" & txtBox7.Text & "', kunden_straße = '" & txtBox8.Text & "', kunden_hausnummer = '" & txtBox9.Text & "', kunden_passwort = '" & txtBox10.Text & "' WHERE kunden_id = " & kunden_id_module

            command.ExecuteNonQuery()

            Konsole.txtBox.Text += command.CommandText & Environment.NewLine & Environment.NewLine
            ScrollToEnd()
        '}
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        connection.Close()
        FormKunde.KundenkontoAnzeigen("kundenkonto_erneut_laden")
End Sub

Private Sub AendernBudgetverlaufAdmin()
    Try
    '{
        connection.Open()
        command.CommandText = "UPDATE budgetverlauf SET budgetverlauf_wert = '" & txtBox1.Text & "', budgetverlauf_datum = '" & txtBox2.Text & "' WHERE budgetverlauf_id = " & artikel_ausgewaehlt

        command.ExecuteNonQuery()

        Konsole.txtBox.Text += command.CommandText & Environment.NewLine & Environment.NewLine
        ScrollToEnd()
    '}
    Catch ex As Exception
        MsgBox(ex.Message)
    End Try
    connection.Close()
    FormAdministrator.BudgetverlaufAnzeigen("budgetverlauf_erneut_laden")
    FormAdministrator.BudgetverlaufChartAnzeigen()
End Sub

Private Sub AendernKontoverlaufAdmin()
    Try
    '{
        connection.Open()
        command.CommandText = "UPDATE kontoverlauf SET kontoverlauf_kunden_id = '" & txtBox1.Text & "', kontoverlauf_wert = '" & txtBox2.Text & "', kontoverlauf_datum = '" & txtBox3.Text & "' WHERE kontoverlauf_id = " & artikel_ausgewaehlt

        command.ExecuteNonQuery()

        Konsole.txtBox.Text += command.CommandText & Environment.NewLine & Environment.NewLine
        ScrollToEnd()
    '}
    Catch ex As Exception
        MsgBox(ex.Message)
    End Try
    connection.Close()
    FormAdministrator.KontoverlaufAnzeigen("kontoverlauf_erneut_laden")
    FormAdministrator.KontoverlaufChartAnzeigen()
End Sub


'EINFÜGEN

Private Sub Registrieren()
    Try
    '{
        connection.Open()

        'Schauen, ob die E-Mail schon verwendet wurde
        command.CommandText = "SELECT kunden_email FROM kunden"
        Konsole.txtBox.Text += command.CommandText & Environment.NewLine & Environment.NewLine
        ScrollToEnd()
        reader = command.ExecuteReader()
        Do While reader.Read()
            If reader("kunden_email").ToString() = txtBox3.Text.ToString() Then
                MsgBox("E-Mail bereits verwendet", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
        Loop
        reader.Close()

        command.CommandText = "INSERT into kunden (kunden_name, kunden_vorname, kunden_email, kunden_telefonnummer, kunden_land, kunden_plz, kunden_stadt, kunden_straße, kunden_hausnummer, kunden_passwort, kunden_geld, kunden_konto_aktiv) values ('" & txtBox1.Text & "', '" & txtBox2.Text & "', '" & txtBox3.Text & "', '" & txtBox4.Text & "', '" & txtBox5.Text & "', '" & txtBox6.Text & "', '" & txtBox7.Text & "', '" & txtBox8.Text & "', '" & txtBox9.Text & "', '" & txtBox10.Text & "', '" & txtBox11.Text.Substring(0, txtBox11.Text.Length - 2) & "', '1');"
        Konsole.txtBox.Text += command.CommandText & Environment.NewLine & Environment.NewLine
        ScrollToEnd()

        Dim anzahl As Integer = command.ExecuteNonQuery()

        If anzahl > 0 Then
            MessageBox.Show("Vielen Dank für ihre Registrierung!")
            'Me.Close()
        End If
    '}
    Catch ex As Exception
        MsgBox(ex.Message)
    End Try
    connection.Close()
End Sub

Private Sub EinfuegenLager()
    Try
    '{
        connection.Open()

        command.CommandText = "INSERT into lager (lager_warenanzahl, lager_warenname, lager_kategorie, lager_warengewicht, lager_waren_verkaufspreis, lager_aktiv) values ('" & txtBox1.Text & "', '" & txtBox2.Text & "', '" & txtBox3.Text & "', '" & txtBox4.Text.Replace(".", ",") & "', '" & txtBox5.Text & "', '1');"

        Konsole.txtBox.Text += command.CommandText & Environment.NewLine & Environment.NewLine
        ScrollToEnd()

        command.ExecuteNonQuery()
    '}
    Catch ex As Exception
        MsgBox(ex.Message)
    End Try
    connection.Close()
    FormAdministrator.LagerAnzeigen("lager_erneut_laden")
End Sub

Private Sub EinfuegenBestellungen()
    Try
    '{
        connection.Open()

        command.CommandText = "INSERT into bestellung (bestellung_kunden_id, bestellung_waren_id, bestellung_anzahl, bestellung_offen) values ('" & txtBox1.Text & "', '" & txtBox2.Text & "', '" & txtBox3.Text & "', '1');"

        Konsole.txtBox.Text += command.CommandText & Environment.NewLine & Environment.NewLine
        ScrollToEnd()

        command.ExecuteNonQuery()
    '}
    Catch ex As Exception
        MsgBox(ex.Message)
    End Try
    connection.Close()
    FormAdministrator.BestellungenAnzeigen("bestellungen_erneut_laden")
End Sub

Private Sub EinfuegenVerkaufshistorie()
    Try
    '{
        connection.Open()

        command.CommandText = "INSERT into verkaufshistorie (verkaufshistorie_bestellung_id, verkaufshistorie_kunden_id, verkaufshistorie_datum, verkaufshistorie_waren_id, verkaufshistorie_verkaufspreis, verkaufshistorie_waren_anzahl) values ('" & txtBox1.Text & "', '" & txtBox2.Text & "', '" & txtBox3.Text & "', '" & txtBox4.Text & "', '" & txtBox5.Text & "', '" & txtBox6.Text & "');"

        Konsole.txtBox.Text += command.CommandText & Environment.NewLine & Environment.NewLine
        ScrollToEnd()

        command.ExecuteNonQuery()
    '}
    Catch ex As Exception
        MsgBox(ex.Message)
    End Try
    connection.Close()
    FormAdministrator.VerkaufshsitorieAnzeigen("verkaufshistorie_erneut_laden")
End Sub

Private Sub EinfuegenKunden()
    Try
    '{
        connection.Open()

        command.CommandText = "INSERT into kunden (kunden_name, kunden_vorname, kunden_email, kunden_telefonnummer, kunden_land, kunden_plz, kunden_stadt, kunden_straße, kunden_hausnummer, kunden_passwort, kunden_geld, kunden_konto_aktiv) values ('" & txtBox1.Text & "', '" & txtBox2.Text & "', '" & txtBox3.Text & "', '" & txtBox4.Text & "', '" & txtBox5.Text & "', '" & txtBox6.Text & "', '" & txtBox7.Text & "', '" & txtBox8.Text & "', '" & txtBox9.Text & "', '" & txtBox10.Text & "', '" & txtBox11.Text & "', '1');"

        Konsole.txtBox.Text += command.CommandText & Environment.NewLine & Environment.NewLine
        ScrollToEnd()

        command.ExecuteNonQuery()
    '}
    Catch ex As Exception
        MsgBox(ex.Message)
    End Try
    connection.Close()
    FormAdministrator.KundenAnzeigen("kundenkonto_erneut_laden")
End Sub

Private Sub EinfuegenDrittanbieter()
    Try
    '{
        connection.Open()

        command.CommandText = "INSERT into drittanbieter (drittanbieter_waren_id, drittanbieter_anbieter_id, drittanbieter_verkaufspreis) values ('" & txtBox1.Text & "', '" & txtBox2.Text & "', '" & txtBox3.Text & "');"

        Konsole.txtBox.Text += command.CommandText & Environment.NewLine & Environment.NewLine
        ScrollToEnd()

        command.ExecuteNonQuery()
    '}
    Catch ex As Exception
        MsgBox(ex.Message)
    End Try
    connection.Close()
    FormAdministrator.DrittanbieterAnzeigen("drittanbieter_erneut_laden")
End Sub

Private Sub EinfuegenNachbestellungen()
    Try
    '{
        connection.Open()

        command.CommandText = "INSERT into nachbestellungen (nachbestellungen_waren_id, nachbestellungen_waren_anzahl) values ('" & txtBox1.Text & "', '" & txtBox2.Text & "');"

        Konsole.txtBox.Text += command.CommandText & Environment.NewLine & Environment.NewLine
        ScrollToEnd()

        command.ExecuteNonQuery()
    '}
    Catch ex As Exception
        MsgBox(ex.Message)
    End Try
    connection.Close()
    If bearbeitenFensterSender = "einfuegen_nachbestellungen_admin" Then
        FormAdministrator.NachbestellungenAnzeigen("nachbestellungen_erneut_laden")
    ElseIf bearbeitenFensterSender = "nachbestellen_versand" Then
        FormVersand.NachbestellungenAnzeigen("nachbestellungen_erneut_laden")
    End If
End Sub

Private Sub EinfuegenBudgetverlauf()
    Try
    '{
        connection.Open()

        command.CommandText = "INSERT INTO budgetverlauf (budgetverlauf_wert, budgetverlauf_datum) values ('" & txtBox1.Text & "', '" & txtBox2.Text & "');"

        Konsole.txtBox.Text += command.CommandText & Environment.NewLine & Environment.NewLine
        ScrollToEnd()

        command.ExecuteNonQuery()
    '}
    Catch ex As Exception
        MsgBox(ex.Message)
    End Try
    connection.Close()
    FormAdministrator.BudgetverlaufAnzeigen("budgetverlauf_erneut_laden")
    FormAdministrator.BudgetverlaufChartAnzeigen()
End Sub

Private Sub EinfuegenKontoverlauf()
    Try
    '{
        connection.Open()

        command.CommandText = "INSERT INTO kontoverlauf (kontoverlauf_kunden_id, kontoverlauf_wert, kontoverlauf_datum) values ('" & txtBox1.Text & "', '" & txtBox2.Text & "', '" & txtBox3.Text & "')"

        Konsole.txtBox.Text += command.CommandText & Environment.NewLine & Environment.NewLine
        ScrollToEnd()

        command.ExecuteNonQuery()
    '}
    Catch ex As Exception
        MsgBox(ex.Message)
    End Try
    connection.Close()
    FormAdministrator.KontoverlaufAnzeigen("kontoverlauf_erneut_laden")
    FormAdministrator.KontoverlaufChartAnzeigen()
End Sub

'SUCHEN

Private Sub SucheLager()
    Try
            '{
                connection.Open()
                Dim sqlString As String = "SELECT * FROM lager WHERE "

                If Not String.IsNullOrWhiteSpace(txtBox1.Text) Then
                    sqlString += "lager_waren_id = @p1 AND "
                    command.Parameters.AddWithValue("@p1", txtBox1.Text)
                End If
                If Not String.IsNullOrWhiteSpace(txtBox2.Text) Then
                    sqlString += "lager_warenanzahl = @p2 AND "
                    command.Parameters.AddWithValue("@p2", txtBox2.Text)
                End If
                If Not String.IsNullOrWhiteSpace(txtBox3.Text) Then
                    sqlString += "lager_warenname LIKE @p3 AND "
                    command.Parameters.AddWithValue("@p3", "%" & txtBox3.Text & "%")
                End If
                If Not String.IsNullOrWhiteSpace(txtBox4.Text) Then
                    sqlString += "lager_kategorie LIKE @p4 AND "
                    command.Parameters.AddWithValue("@p4", "%" & txtBox4.Text & "%")
                End If
                If Not String.IsNullOrWhiteSpace(txtBox5.Text) Then
                    sqlString += "lager_warengewicht LIKE @p5 AND "
                    command.Parameters.AddWithValue("@p5", txtBox4.Text & "%")
                End If
                If Not String.IsNullOrWhiteSpace(txtBox6.Text) Then
                    sqlString += "lager_waren_verkaufspreis = @p6 AND "
                    command.Parameters.AddWithValue("@p6", txtBox5.Text)
                End If

                'Das letzte AND entfernen, falls eins existiert
                If sqlString.EndsWith(" AND ") Then
                    'sqlString = sqlString.Substring(0, sqlString.Length - 5)
                    sqlString += "lager_aktiv = True"
                End If
                'Das WHERE entfernen, falls kein Feld ausgefüllt wurde
                If sqlString.EndsWith(" WHERE ") Then
                    sqlString += "lager_aktiv = True"
                    'sqlString = sqlString.Substring(0, sqlString.Length - 7)
                End If
                command.CommandText = sqlString
                Konsole.txtBox.Text += command.CommandText & Environment.NewLine & Environment.NewLine
                ScrollToEnd()

                If bearbeitenFensterSender = "suchen_lager_kunde" Then
                    FormKunde.lstViewKundeStore.Items.Clear()
                ElseIf bearbeitenFensterSender = "suchen_lager_admin" Then
                    FormAdministrator.lstViewLager.Items.Clear()
                ElseIf bearbeitenFensterSender = "suchen_lager_versand" Then
                    FormVersand.lstViewLager.Items.Clear()
                ElseIf bearbeitenFensterSender = "suchen_lager_lagerlogistik" Then
                    FormLagerlogistik.lstViewLager.Items.Clear()
                End If

                reader = command.ExecuteReader()

                Do While reader.Read()
                    Dim lstViewItem As New ListViewItem(reader("lager_waren_id").ToString())
                    lstViewItem.SubItems.Add(reader("lager_warenanzahl").ToString())
                    lstViewItem.SubItems.Add(reader("lager_warenname").ToString())
                    lstViewItem.SubItems.Add(reader("lager_kategorie").ToString())
                    lstViewItem.SubItems.Add(reader("lager_warengewicht").ToString() & " kg")
                    lstViewItem.SubItems.Add(reader("lager_waren_verkaufspreis").ToString() & " €")

                    If bearbeitenFensterSender = "suchen_lager_kunde" Then
                        FormKunde.lstViewKundeStore.Items.Add(lstViewItem)
                    ElseIf bearbeitenFensterSender = "suchen_lager_admin" Then
                        FormAdministrator.lstViewLager.Items.Add(lstViewItem)
                    ElseIf bearbeitenFensterSender = "suchen_lager_versand" Then
                        FormVersand.lstViewLager.Items.Add(lstViewItem)
                    ElseIf bearbeitenFensterSender = "suchen_lager_lagerlogistik" Then
                        FormLagerlogistik.lstViewLager.Items.Add(lstViewItem)
                    End If
                Loop
                reader.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            '}
            End Try
            connection.Close()
End Sub

Private Sub SucheVerkaufshistorie()
    Try
        '{
            connection.Open()
            Dim sqlString As String = "SELECT * FROM verkaufshistorie WHERE "

            If Not String.IsNullOrWhiteSpace(txtBox1.Text) Then
                sqlString += "verkaufshistorie_bestellung_id = @p1 AND "
                command.Parameters.AddWithValue("@p1", txtBox1.Text)
            End If
            If bearbeitenFensterSender = "suchen_verkaufshistorie_admin" Or bearbeitenFensterSender = "suchen_verkaufshistorie_versand" Then
                If Not String.IsNullOrWhiteSpace(txtBox2.Text) Then
                     sqlString += "verkaufshistorie_kunden_id = @p2 AND "
                     command.Parameters.AddWithValue("@p2", txtBox2.Text)
                End If
            End If
            If Not String.IsNullOrWhiteSpace(txtBox3.Text) Then
                sqlString += "verkaufshistorie_datum LIKE @p2 AND "
                command.Parameters.AddWithValue("@p2", "%" & txtBox3.Text & "%")
            End If
            If Not String.IsNullOrWhiteSpace(txtBox4.Text) Then
                sqlString += "verkaufshistorie_waren_id = @p3 AND "
                command.Parameters.AddWithValue("@p3", txtBox4.Text)
            End If
            If Not String.IsNullOrWhiteSpace(txtBox5.Text) Then
                sqlString += "verkaufshistorie_verkaufspreis LIKE @p4 AND "
                command.Parameters.AddWithValue("@p4", txtBox5.Text & "%")
            End If
            If Not String.IsNullOrWhiteSpace(txtBox6.Text) Then
                sqlString += "verkaufshistorie_waren_anzahl = @p5 AND "
                command.Parameters.AddWithValue("@p5", txtBox6.Text)
            End If
            If sqlString.EndsWith(" AND ") Then
                If bearbeitenFensterSender = "suchen_verkaufshistorie_kunde" Then
                    sqlString += "verkaufshistorie_kunden_id = " & kunden_id_module
                ElseIf bearbeitenFensterSender = "suchen_verkaufshistorie_admin" Or bearbeitenFensterSender = "suchen_verkaufshistorie_versand" Then
                    sqlString = sqlString.Substring(0, sqlString.Length - 5)
                End If
            End If
            'Das WHERE entfernen, falls kein Feld ausgefüllt wurde
            If sqlString.EndsWith(" WHERE ") Then
                If bearbeitenFensterSender = "suchen_verkaufshistorie_kunde" Then
                    sqlString += "verkaufshistorie_kunden_id = " & kunden_id_module
                ElseIf bearbeitenFensterSender = "suchen_verkaufshistorie_admin" Or bearbeitenFensterSender = "suchen_verkaufshistorie_versand" Then
                    sqlString = sqlString.Substring(0, sqlString.Length - 7)
                End If
            End If

            command.CommandText = sqlString
            Konsole.txtBox.Text += command.CommandText & Environment.NewLine & Environment.NewLine
            ScrollToEnd()

            reader = command.ExecuteReader()

            If bearbeitenFensterSender = "suchen_verkaufshistorie_kunde" Then
                FormKunde.lstViewKundeVerkaufshistorie.Items.Clear()
            ElseIf bearbeitenFensterSender = "suchen_verkaufshistorie_admin" Then
                FormAdministrator.lstViewVerkaufshistorie.Items.Clear()
            ElseIf bearbeitenFensterSender = "suchen_verkaufshistorie_versand" Then
                FormVersand.lstViewVerkaufshistorie.Items.Clear()
            End If

            Do While reader.Read()
            '{
                Dim lstViewItem As New ListViewItem(reader("verkaufshistorie_bestellung_id").ToString())
                lstViewItem.SubItems.Add(reader("verkaufshistorie_kunden_id").ToString())
                Dim kaufdatum As DateTime
                kaufdatum = Convert.ToDateTime(reader("verkaufshistorie_datum"))
                kaufdatum.ToString("dd.MM.yyyy")
                lstViewItem.SubItems.Add(kaufdatum)
                lstViewItem.SubItems.Add(reader("verkaufshistorie_waren_id").ToString())
                lstViewItem.SubItems.Add(reader("verkaufshistorie_verkaufspreis").ToString() & " €")
                lstViewItem.SubItems.Add(reader("verkaufshistorie_waren_anzahl").ToString())

                If bearbeitenFensterSender = "suchen_verkaufshistorie_kunde" Then
                    FormKunde.lstViewKundeVerkaufshistorie.Items.Add(lstViewItem)
                ElseIf bearbeitenFensterSender = "suchen_verkaufshistorie_admin" Then
                    FormAdministrator.lstViewVerkaufshistorie.Items.Add(lstViewItem)
                ElseIf bearbeitenFensterSender = "suchen_verkaufshistorie_versand" Then
                    FormVersand.lstViewVerkaufshistorie.Items.Add(lstViewItem)
                End If
            '}
            Loop
            reader.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        '}
        End Try
        connection.Close()
End Sub

Private Sub SucheOffeneBestellungen()
    Try
        '{
            connection.Open()
            Dim sqlString As String = "SELECT * FROM bestellung WHERE "

            If Not String.IsNullOrWhiteSpace(txtBox1.Text) Then
                sqlString += "bestellung_id LIKE @p1 AND "
                command.Parameters.AddWithValue("@p1", txtBox1.Text)
            End If
            If Not String.IsNullOrWhiteSpace(txtBox3.Text) Then
                sqlString += "bestellung_waren_id LIKE @p2 AND "
                command.Parameters.AddWithValue("@p2", txtBox3.Text)
            End If
            If Not String.IsNullOrWhiteSpace(txtBox4.Text) Then
                sqlString += "bestellung_anzahl LIKE @p3 AND "
                command.Parameters.AddWithValue("@p3", txtBox4.Text)
            End If
            If sqlString.EndsWith(" AND ") Then
                sqlString += "bestellung_kunden_id = " & kunden_id_module & " AND bestellung_offen = True"
            End If
            'Das WHERE entfernen, falls kein Feld ausgefüllt wurde
            If sqlString.EndsWith(" WHERE ") Then
                sqlString += "bestellung_kunden_id = " & kunden_id_module & " AND bestellung_offen = True"
            End If

            command.CommandText = sqlString
            Konsole.txtBox.Text += command.CommandText & Environment.NewLine & Environment.NewLine
            ScrollToEnd()

            reader = command.ExecuteReader()

            FormKunde.lstViewOffeneBestellungen.Items.Clear()
            Do While reader.Read()
            '{
                Dim lstViewItem As New ListViewItem(reader("bestellung_id").ToString())
                lstViewItem.SubItems.Add(reader("bestellung_kunden_id").ToString())
                lstViewItem.SubItems.Add(reader("bestellung_waren_id").ToString())
                lstViewItem.SubItems.Add(reader("bestellung_anzahl").ToString())
                FormKunde.lstViewOffeneBestellungen.Items.Add(lstViewItem)
            '}
            Loop
            reader.Close()
        '}
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        connection.Close()
End Sub

Private Sub SucheBestellungen()
    Try
        '{
            connection.Open()
            Dim sqlString As String = "SELECT * FROM bestellung WHERE "

            If Not String.IsNullOrWhiteSpace(txtBox1.Text) Then
                sqlString = sqlString & "bestellung_id LIKE @p1 AND "
                command.Parameters.AddWithValue("@p1", txtBox1.Text)
            End If
            If Not String.IsNullOrWhiteSpace(txtBox2.Text) Then
                sqlString += "bestellung_kunden_id LIKE @p2 AND "
                command.Parameters.AddWithValue("@p2", txtBox2.Text)
            End If
            If Not String.IsNullOrWhiteSpace(txtBox3.Text) Then
                sqlString += "bestellung_waren_id LIKE @p3 AND "
                command.Parameters.AddWithValue("@p3", txtBox3.Text)
            End If
            If Not String.IsNullOrWhiteSpace(txtBox4.Text) Then
                sqlString += "bestellung_anzahl LIKE @p4 AND "
                command.Parameters.AddWithValue("@p4", txtBox4.Text)
            End If
            If sqlString.EndsWith(" AND ") Then
                'sqlString = sqlString.Substring(0, sqlString.Length - 5)
                sqlString += "bestellung_offen = True"
            End If
            If sqlString.EndsWith(" WHERE ") Then
                'sqlString.Substring(0, sqlString.Length - 7)
                sqlString += "bestellung_offen = True"
            End If

            command.CommandText = sqlString
            Konsole.txtBox.Text += command.CommandText & Environment.NewLine & Environment.NewLine
            ScrollToEnd()
            reader = command.ExecuteReader()

            If bearbeitenFensterSender = "suchen_bestellungen_admin" Then
                FormAdministrator.lstViewBestellungen.Items.Clear()
            ElseIf bearbeitenFensterSender = "suchen_bestellungen_versand" Then
                FormVersand.lstViewBestellungen.Items.Clear()
            End If

            Do While reader.Read()
            '{
                Dim lstViewItem As New ListViewItem(reader("bestellung_id").ToString())
                lstViewItem.SubItems.Add(reader("bestellung_kunden_id").ToString())
                lstViewItem.SubItems.Add(reader("bestellung_waren_id").ToString())
                lstViewItem.SubItems.Add(reader("bestellung_anzahl").ToString())

                If bearbeitenFensterSender = "suchen_bestellungen_admin" Then
                    FormAdministrator.lstViewBestellungen.Items.Add(lstViewItem)
                ElseIf bearbeitenFensterSender = "suchen_bestellungen_versand" Then
                    FormVersand.lstViewBestellungen.Items.Add(lstViewItem)
                End If
            '}
            Loop
            reader.Close()
        '}
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        connection.Close()
End Sub

Private Sub SucheKundenAdmin()
    Try
    '{
        connection.Open()
        Dim sqlString As String = "SELECT * FROM kunden WHERE "

        If Not String.IsNullOrWhiteSpace(txtBox1.Text) Then
            sqlString += "kunden_id = @p1 AND "
            command.Parameters.AddWithValue("@p1", txtBox1.Text)
        End If
        If Not String.IsNullOrWhiteSpace(txtBox2.Text) Then
            sqlString += "kunden_name LIKE @p2 AND "
            command.Parameters.AddWithValue("@p2", "%" & txtBox2.Text & "%")
        End If
        If Not String.IsNullOrWhiteSpace(txtBox3.Text) Then
            sqlString += "kunden_vorname LIKE @p3 AND "
            command.Parameters.AddWithValue("@p3", "%" & txtBox3.Text & "%")
        End If
        If Not String.IsNullOrWhiteSpace(txtBox4.Text) Then
            sqlString += "kunden_email LIKE @p4 AND "
            command.Parameters.AddWithValue("@p4", "%" & txtBox4.Text & "%")
        End If
        If Not String.IsNullOrWhiteSpace(txtBox5.Text) Then
            sqlString += "kunden_telefonnummer LIKE @p5 AND "
            command.Parameters.AddWithValue("@p5", "%" & txtBox5.Text & "%")
        End If
        If Not String.IsNullOrWhiteSpace(txtBox6.Text) Then
            sqlString += "kunden_land LIKE @p6 AND "
            command.Parameters.AddWithValue("@p6", "%" & txtBox6.Text & "%")
        End If
        If Not String.IsNullOrWhiteSpace(txtBox7.Text) Then
            sqlString += "kunden_plz = @p7 AND "
            command.Parameters.AddWithValue("@p7", "%" & txtBox7.Text & "%")
        End If
        If Not String.IsNullOrWhiteSpace(txtBox8.Text) Then
            sqlString += "kunden_stadt LIKE @p8 AND "
            command.Parameters.AddWithValue("@p8", "%" & txtBox8.Text & "%")
        End If
        If Not String.IsNullOrWhiteSpace(txtBox9.Text) Then
            sqlString += "kunden_straße LIKE @p9 AND "
            command.Parameters.AddWithValue("@p9", "%" & txtBox9.Text & "%")
        End If
        If Not String.IsNullOrWhiteSpace(txtBox10.Text) Then
            sqlString += "kunden_hausnummer = @p10 AND "
            command.Parameters.AddWithValue("@p10", "%" & txtBox10.Text & "%")
        End If
        If Not String.IsNullOrWhiteSpace(txtBox11.Text) Then
            sqlString += "kunden_passwort LIKE @p11 AND "
            command.Parameters.AddWithValue("@p11", "%" & txtBox11.Text & "%")
        End If
        If Not String.IsNullOrWhiteSpace(txtBox12.Text) Then
            sqlString += "kunden_geld LIKE @p12 AND "
            command.Parameters.AddWithValue("@p12", "%" & txtBox12.Text & "%")
        End If

        If sqlString.EndsWith(" AND ") Then
            'sqlString = sqlString.Substring(0, sqlString.Length - 5)
            sqlString += "kunden_konto_aktiv = True"
        End If
        If sqlString.EndsWith(" WHERE ") Then
            'sqlString.Substring(0, sqlString.Length - 7)
            sqlString += "kunden_konto_aktiv = True"
        End If

        command.CommandText = sqlString
        Konsole.txtBox.Text += command.CommandText & Environment.NewLine & Environment.NewLine
        ScrollToEnd()
        reader = command.ExecuteReader()

        FormAdministrator.lstViewKunden.Items.Clear()

        Do While reader.Read()
        '{
            Dim lstViewItem As New ListViewItem(reader("kunden_id").ToString())
            lstViewItem.SubItems.Add(reader("kunden_name").ToString())
            lstViewItem.SubItems.Add(reader("kunden_vorname").ToString())
            lstViewItem.SubItems.Add(reader("kunden_email").ToString())
            lstViewItem.SubItems.Add(reader("kunden_telefonnummer").ToString())
            lstViewItem.SubItems.Add(reader("kunden_land").ToString())
            lstViewItem.SubItems.Add(reader("kunden_plz").ToString())
            lstViewItem.SubItems.Add(reader("kunden_stadt").ToString())
            lstViewItem.SubItems.Add(reader("kunden_straße").ToString())
            lstViewItem.SubItems.Add(reader("kunden_hausnummer").ToString())
            lstViewItem.SubItems.Add(reader("kunden_passwort").ToString())
            lstViewItem.SubItems.Add(reader("kunden_geld").ToString() & " €")
            FormAdministrator.lstViewKunden.Items.Add(lstViewItem)
        '}
        Loop
        reader.Close()
    '}
    Catch ex As Exception
        MessageBox.Show(ex.Message)
    End Try
    connection.Close()
End Sub

Private Sub SucheDrittanbieter()
    Try
    '{
        connection.Open()
        Dim sqlString As String = "SELECT * FROM drittanbieter WHERE "

        If Not String.IsNullOrWhiteSpace(txtBox1.Text) Then
            sqlString += "drittanbieter_waren_id = @p1 AND "
            command.Parameters.AddWithValue("@p1", txtBox1.Text)
        End If
        If Not String.IsNullOrWhiteSpace(txtBox2.Text) Then
            sqlString += "drittanbieter_anbieter_id = @p2 AND "
            command.Parameters.AddWithValue("@p2", txtBox2.Text)
        End If
        If Not String.IsNullOrWhiteSpace(txtBox3.Text) Then
            sqlString += "drittanbieter_verkaufspreis = @p3 AND "
            command.Parameters.AddWithValue("@p3", txtBox3.Text)
        End If

        If sqlString.EndsWith(" AND ") Then
            sqlString = sqlString.Substring(0, sqlString.Length - 5)
        End If
        If sqlString.EndsWith(" WHERE ") Then
            sqlString = sqlString.Substring(0, sqlString.Length - 7)
        End If

        command.CommandText = sqlString
        Konsole.txtBox.Text += command.CommandText & Environment.NewLine & Environment.NewLine
        ScrollToEnd()
        reader = command.ExecuteReader()

        If bearbeitenFensterSender = "suchen_drittanbieter_admin" Then
            FormAdministrator.lstViewDrittanbieter.Items.Clear()
        ElseIf bearbeitenFensterSender = "suchen_drittanbieter_lagerlogistik" Then
            FormLagerlogistik.lstViewDrittanbieter.Items.Clear()
        End If

        Do While reader.Read()
        '{
            Dim lstViewItem As New ListViewItem(reader("drittanbieter_waren_id").ToString())
            lstViewItem.SubItems.Add(reader("drittanbieter_anbieter_id").ToString())
            lstViewItem.SubItems.Add(reader("drittanbieter_verkaufspreis").ToString() & " €")

            If bearbeitenFensterSender = "suchen_drittanbieter_admin" Then
                FormAdministrator.lstViewDrittanbieter.Items.Add(lstViewItem)
            ElseIf bearbeitenFensterSender = "suchen_drittanbieter_lagerlogistik" Then
                FormLagerlogistik.lstViewDrittanbieter.Items.Add(lstViewItem)
            End If
        '}
        Loop
        reader.Close()
    '}
    Catch ex As Exception
        MsgBox(ex.Message)
    End Try
    connection.Close()
End Sub

Private Sub SucheNachbestellungen()
    Try
    '{
        connection.Open()
        Dim sqlString As String = "SELECT * FROM nachbestellungen WHERE "

        If Not String.IsNullOrWhiteSpace(txtBox1.Text) Then
            sqlString += "nachbestellungen_id = @p1 AND "
            command.Parameters.AddWithValue("@p1", txtBox1.Text)
        End If
        If Not String.IsNullOrWhiteSpace(txtBox2.Text) Then
            sqlString += "nachbestellungen_waren_id = @p2 AND "
            command.Parameters.AddWithValue("@p2", txtBox2.Text)
        End If
        If Not String.IsNullOrWhiteSpace(txtBox3.Text) Then
            sqlString += "nachbestellungen_waren_anzahl = @p3 AND "
            command.Parameters.AddWithValue("@p3", txtBox3.Text)
        End If

        If sqlString.EndsWith(" AND ") Then
            sqlString = sqlString.Substring(0, sqlString.Length - 5)
        End If
        If sqlString.EndsWith(" WHERE ") Then
            sqlString = sqlString.Substring(0, sqlString.Length - 7)
        End If

        command.CommandText = sqlString
        Konsole.txtBox.Text += command.CommandText & Environment.NewLine & Environment.NewLine
        ScrollToEnd()
        reader = command.ExecuteReader()

        If bearbeitenFensterSender = "suchen_nachbestellungen_admin" Then
            FormAdministrator.lstViewNachbestellungen.Items.Clear()
        ElseIf bearbeitenFensterSender = "suchen_nachbestellungen_versand" Then
            FormVersand.lstViewNachbestellungen.Items.Clear()
        ElseIf bearbeitenFensterSender = "suchen_nachbestellungen_lagerlogistik" Then
            FormLagerlogistik.lstViewNachbestellungen.Items.Clear()
        End If

        Do While reader.Read()
        '{
            Dim lstViewItem As New ListViewItem(reader("nachbestellungen_id").ToString())
            lstViewItem.SubItems.Add(reader("nachbestellungen_waren_id").ToString())
            lstViewItem.SubItems.Add(reader("nachbestellungen_waren_anzahl").ToString())

            If bearbeitenFensterSender = "suchen_nachbestellungen_admin" Then
                FormAdministrator.lstViewNachbestellungen.Items.Add(lstViewItem)
            ElseIf bearbeitenFensterSender = "suchen_nachbestellungen_versand" Then
                FormVersand.lstViewNachbestellungen.Items.Add(lstViewItem)
            ElseIf bearbeitenFensterSender = "suchen_nachbestellungen_lagerlogistik" Then
                FormLagerlogistik.lstViewNachbestellungen.Items.Add(lstViewItem)
            End If
        '}
        Loop
        reader.Close()
    '}
    Catch ex As Exception
        MsgBox(ex.Message)
    End Try
    connection.Close()
End Sub

Private Sub SuchePasswortAdmin()
    Try
    '{
        connection.Open()
        Dim sqlString As String = "SELECT * FROM passwort WHERE "

        If Not String.IsNullOrWhiteSpace(txtBox1.Text) Then
            sqlString += "passwort_id = @p1 AND "
            command.Parameters.AddWithValue("@p1", txtBox1.Text)
        End If
        If Not String.IsNullOrWhiteSpace(txtBox2.Text) Then
            sqlString += "passwort LIKE @p2 AND "
            command.Parameters.AddWithValue("@p2", "%" & txtBox2.Text & "%")
        End If
        If Not String.IsNullOrWhiteSpace(txtBox3.Text) Then
            sqlString += "passwort_beschreibung LIKE @p3 AND "
            command.Parameters.AddWithValue("@p3", "%" & txtBox3.Text & "%")
        End If

        If sqlString.EndsWith(" AND ") Then
            sqlString = sqlString.Substring(0, sqlString.Length - 5)
        End If
        If sqlString.EndsWith(" WHERE ") Then
            sqlString = sqlString.Substring(0, sqlString.Length - 7)
        End If

        command.CommandText = sqlString
        Konsole.txtBox.Text += command.CommandText & Environment.NewLine & Environment.NewLine
        ScrollToEnd()
        reader = command.ExecuteReader()

        FormAdministrator.lstViewPasswoerter.Items.Clear()

        Do While reader.Read()
        '{
            Dim lstViewItem As New ListViewItem(reader("passwort_id").ToString())
            lstViewItem.SubItems.Add(reader("passwort").ToString())
            lstViewItem.SubItems.Add(reader("passwort_beschreibung").ToString())
            FormAdministrator.lstViewPasswoerter.Items.Add(lstViewItem)
        '}
        Loop
        reader.Close()
    '}
    Catch ex As Exception
        MsgBox(ex.Message)
    End Try
    connection.Close()
End Sub

Private Sub SucheBudgetVerlaufAdmin()
    Try
    '{
        connection.Open()
        Dim sqlString As String = "SELECT * FROM budgetverlauf WHERE "

        If Not String.IsNullOrWhiteSpace(txtBox1.Text) Then
            sqlString += "budgetverlauf_id = @p1 AND "
            command.Parameters.AddWithValue("@p1", txtBox1.Text)
        End If
        If Not String.IsNullOrWhiteSpace(txtBox2.Text) Then
            sqlString += "budgetverlauf_wert = @p2 AND "
            command.Parameters.AddWithValue("@p2", txtBox2.Text)
        End If
        If Not String.IsNullOrWhiteSpace(txtBox3.Text) Then
            sqlString += "budgetverlauf_datum = @p3 AND "
            command.Parameters.AddWithValue("@p3", txtBox3.Text)
        End If

        If sqlString.EndsWith(" AND ") Then
            sqlString = sqlString.Substring(0, sqlString.Length - 5)
        End If
        If sqlString.EndsWith(" WHERE ") Then
            sqlString = sqlString.Substring(0, sqlString.Length - 7)
        End If

        command.CommandText = sqlString
        Konsole.txtBox.Text += command.CommandText & Environment.NewLine & Environment.NewLine
        ScrollToEnd()
        reader = command.ExecuteReader()

        FormAdministrator.lstViewBudgetverlauf.Items.Clear()

        Do While reader.Read()
        '{
            Dim lstViewItem As New ListViewItem(reader("budgetverlauf_id").ToString())
            lstViewItem.SubItems.Add(reader("budgetverlauf_wert").ToString() & " €")
            lstViewItem.SubItems.Add(reader("budgetverlauf_datum").ToShortDateString())
            FormAdministrator.lstViewBudgetverlauf.Items.Add(lstViewItem)
        '}
        Loop
        reader.Close()
    '}
    Catch ex As Exception
        MsgBox(ex.Message)
    End Try
    connection.Close()
End Sub

Private Sub SucheKontoVerlaufKunde()
    Try
    '{
        connection.Open()
        Dim sqlString As String = "SELECT * FROM kontoverlauf WHERE "

        If Not String.IsNullOrWhiteSpace(txtBox1.Text) Then
            sqlString += "kontoverlauf_id = @p1 AND "
            command.Parameters.AddWithValue("@p2", txtBox1.Text)
        End If
        If Not String.IsNullOrWhiteSpace(txtBox2.Text) Then
            sqlString += "kontoverlauf_wert = @p2 AND "
            command.Parameters.AddWithValue("@p2", txtBox2.Text)
        End If
        If Not String.IsNullOrWhiteSpace(txtBox3.Text) Then
            sqlString += "kontoverlauf_datum = @p3 AND "
            command.Parameters.AddWithValue("@p3", txtBox3.Text)
        End If

        If sqlString.EndsWith(" AND ") Then
            sqlString = sqlString.Substring(0, sqlString.Length - 5)
        End If
        If sqlString.EndsWith(" WHERE ") Then
            sqlString = sqlString.Substring(0, sqlString.Length - 7)
        End If

        command.CommandText = sqlString
        Konsole.txtBox.Text += command.CommandText & Environment.NewLine & Environment.NewLine
        ScrollToEnd()
        reader = command.ExecuteReader()

        FormKunde.lstViewKontoverlauf.Items.Clear()

        Do While reader.Read()
        '{
            Dim lstViewItem As New ListViewItem(reader("kontoverlauf_id").ToString())
            lstViewItem.SubItems.Add(reader("kontoverlauf_wert").ToString() & " €")
            lstViewItem.SubItems.Add(reader("kontoverlauf_datum").ToString())
            FormKunde.lstViewKontoverlauf.Items.Add(lstViewItem)
        '}
        Loop
        reader.Close()
    '}
    Catch ex As Exception
        MsgBox(ex.Message)
    End Try
    connection.Close()
End Sub


'WIRD BEIM SCHLIEßEN AUSGEFÜHRT

Private Sub FormBearbeiten_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
    FormKunde.Enabled = True
    FormAdministrator.Enabled = True
    FormVersand.Enabled = True
    FormLagerlogistik.Enabled = True

    txtBox1.Enabled = True
    txtBox2.Enabled = True
    txtBox3.Enabled = True
    txtBox4.Enabled = True
    txtBox5.Enabled = True
    txtBox6.Enabled = True
    txtBox7.Enabled = True
    txtBox8.Enabled = True
    txtBox9.Enabled = True
    txtBox10.Enabled = True
    txtBox11.Enabled = True
    txtBox12.Enabled = True

    If bearbeitenFensterSender = "kunden_registrieren" Then
        FormAnmeldung.Show()
    End If
End Sub

End Class
