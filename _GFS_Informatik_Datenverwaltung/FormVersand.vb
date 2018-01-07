Imports System.Data.OleDb 'Wird für das Kommunizieren mit der Datenbank benötigt

Public Class FormVersand

    ' -- VARIABLENDEFINITION -- '

    Dim connection As New OleDbConnection 'Verbindung zwischen Programm und Datenbank
    Dim command As New OleDbCommand       'Beinhaltet SQL-Befehle, die an die Datenbank gesendet werden
    Dim reader As OleDbDataReader         'Um die ausgewählten Daten auslesen zu können

    Dim bestellungenGeladen As Boolean = False
    Dim lagerGeladen As Boolean = False
    Dim nachbestellungenGeladen As Boolean = False
    Dim verkaufshistorieGeladen As Boolean = False

    Dim ascendORdescend As Boolean = True 'Bestimmt, ob Auf oder Absteigend sortiert werden soll

    ' -- VARIABLENDEFINITION ENDE -- '

Private Sub FormVersand_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" & "Data Source=" & Application.StartupPath & "\Ressourcen\Access-Datei\GFS.accdb;"
    command.Connection = connection
    'Konsole
    Konsole.txtBox.Text += connection.ConnectionString & Environment.NewLine & Environment.NewLine
    ScrollToEnd()
    'Konsole Ende

    BestellungenAnzeigen(Nothing)
End Sub

Private Sub TabControlVersand_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControlVersand.SelectedIndexChanged
    If TabControlVersand.SelectedTab Is tabPageBestellungen Then
    '{
        cmdVerschicken.Enabled = True
        cmdAblehnen.Enabled = True
        cmdNachbestellen.Enabled = True
        cmdSuchen.Enabled = True
        cmdAllesAnzeigen.Enabled = True

        cmdVerschicken.BackColor = Color.MediumSeaGreen
        cmdAblehnen.BackColor = Color.LightCoral
        cmdNachbestellen.BackColor = Color.Khaki
        cmdSuchen.BackColor = Color.LightBlue
        cmdAllesAnzeigen.BackColor = Color.Wheat

        Konsole.txtBox.Text += "Tab Page changed to " & TabControlVersand.SelectedTab.ToString() & Environment.NewLine & Environment.NewLine
        ScrollToEnd()

        If bestellungenGeladen = False Then
            BestellungenAnzeigen(Nothing)
        Else
            BestellungenAnzeigen("bestellungen_erneut_laden")
        End If
    '}
    ElseIf TabControlVersand.SelectedTab Is tabPageLager Then
    '{
        cmdVerschicken.Enabled = False
        cmdAblehnen.Enabled = False
        cmdNachbestellen.Enabled = True
        cmdSuchen.Enabled = True
        cmdAllesAnzeigen.Enabled = True

        cmdVerschicken.BackColor = Color.FromKnownColor(KnownColor.Control)
        cmdAblehnen.BackColor = Color.FromKnownColor(KnownColor.Control)
        cmdNachbestellen.BackColor = Color.Khaki
        cmdSuchen.BackColor = Color.LightBlue
        cmdAllesAnzeigen.BackColor = Color.Wheat

        Konsole.txtBox.Text += "Tab Page changed to " & TabControlVersand.SelectedTab.ToString() & Environment.NewLine & Environment.NewLine
        ScrollToEnd()

        If lagerGeladen = False Then
            LagerAnzeigen(Nothing)
        Else
            LagerAnzeigen("lager_erneut_laden")
        End If
    '}
    ElseIf TabControlVersand.SelectedTab Is tabPageNachbestellungen Then
    '{
        cmdVerschicken.Enabled = False
        cmdAblehnen.Enabled = False
        cmdNachbestellen.Enabled = True
        cmdSuchen.Enabled = True
        cmdAllesAnzeigen.Enabled = True

        cmdVerschicken.BackColor = Color.FromKnownColor(KnownColor.Control)
        cmdAblehnen.BackColor = Color.FromKnownColor(KnownColor.Control)
        cmdNachbestellen.BackColor = Color.Khaki
        cmdSuchen.BackColor = Color.LightBlue
        cmdAllesAnzeigen.BackColor = Color.Wheat

        Konsole.txtBox.Text += "Tab Page changed to " & TabControlVersand.SelectedTab.ToString() & Environment.NewLine & Environment.NewLine
        ScrollToEnd()

        If nachbestellungenGeladen = False Then
            NachbestellungenAnzeigen(Nothing)
        Else
            NachbestellungenAnzeigen("nachbestellungen_erneut_laden")
        End If
    '}
    ElseIf TabControlVersand.SelectedTab Is tabPageVerkaufshistorie Then
    '{
        cmdVerschicken.Enabled = False
        cmdAblehnen.Enabled = False
        cmdNachbestellen.Enabled = True
        cmdSuchen.Enabled = True
        cmdAllesAnzeigen.Enabled = True

        cmdVerschicken.BackColor = Color.FromKnownColor(KnownColor.Control)
        cmdAblehnen.BackColor = Color.FromKnownColor(KnownColor.Control)
        cmdNachbestellen.BackColor = Color.Khaki
        cmdSuchen.BackColor = Color.LightBlue
        cmdAllesAnzeigen.BackColor = Color.Wheat

        Konsole.txtBox.Text += "Tab Page changed to " & TabControlVersand.SelectedTab.ToString() & Environment.NewLine & Environment.NewLine
        ScrollToEnd()

        If verkaufshistorieGeladen = False Then
            VerkaufshistorieAnzeigen(Nothing)
        Else
            VerkaufshistorieAnzeigen("verkaufshistorie_erneut_laden")
        End If
    '}
    End If
End Sub

'ANZEIGEFUNKTIONEN

Public Sub BestellungenAnzeigen(befehl As String)
    If bestellungenGeladen = False Or befehl = "bestellungen_erneut_laden" Then
        Try
        '{
            lstViewBestellungen.Items.Clear()

            connection.Open()
            command.CommandText = "SELECT * FROM bestellung WHERE bestellung_offen = True"
            Konsole.txtBox.Text += command.CommandText & Environment.NewLine & Environment.NewLine
            ScrollToEnd()

            If befehl <> "bestellungen_erneut_laden" Then
            '{
                lstViewBestellungen.Columns.Add("Bestellnummer", 100, HorizontalAlignment.Left)
                lstViewBestellungen.Columns.Add("Kundennummer", 100, HorizontalAlignment.Left)
                lstViewBestellungen.Columns.Add("Warennummer", 100, HorizontalAlignment.Left)
                lstViewBestellungen.Columns.Add("Anzahl", 100, HorizontalAlignment.Left)
            '}
            End If

            reader = command.ExecuteReader()

            Do While reader.Read()
            '{
                Dim lstViewItem As New ListViewItem(reader("bestellung_id").ToString())
                lstViewItem.SubItems.Add(reader("bestellung_kunden_id").ToString())
                lstViewItem.SubItems.Add(reader("bestellung_waren_id").ToString())
                lstViewItem.SubItems.Add(reader("bestellung_anzahl").ToString())
                lstViewBestellungen.Items.Add(lstViewItem)
            '}
            Loop
            reader.Close()
            bestellungenGeladen = True
        '}
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        connection.Close()
    End If
End Sub

Public Sub LagerAnzeigen(befehl As String)
    If lagerGeladen = False Or befehl = "lager_erneut_laden" Then
        Try
        '{
            lstViewLager.Items.Clear()

            connection.Open()
            command.CommandText = "SELECT * FROM lager WHERE lager_aktiv = True ORDER BY lager_waren_id"
            Konsole.txtBox.Text += command.CommandText & Environment.NewLine & Environment.NewLine
            ScrollToEnd()

            If befehl <> "lager_erneut_laden" Then
            '{
                lstViewLager.Columns.Add("Warennummer", 100, HorizontalAlignment.Left)
                lstViewLager.Columns.Add("Anzahl verfügbar", 100, HorizontalAlignment.Left)
                lstViewLager.Columns.Add("Name", 200, HorizontalAlignment.Left)
                lstViewLager.Columns.Add("Kategorie", 100, HorizontalAlignment.Left)
                lstViewLager.Columns.Add("Gewicht", 100, HorizontalAlignment.Left)
                lstViewLager.Columns.Add("Preis", 100, HorizontalAlignment.Left)
            '}
            End If

            reader = command.ExecuteReader()

            Do While reader.Read()
            '{
                Dim lstViewItem As New ListViewItem(reader("lager_waren_id").ToString())
                lstViewItem.SubItems.Add(reader("lager_warenanzahl").ToString())
                lstViewItem.SubItems.Add(reader("lager_warenname").ToString())
                lstViewItem.SubItems.Add(reader("lager_kategorie").ToString())
                lstViewItem.SubItems.Add(reader("lager_warengewicht").ToString() & " kg")
                lstViewItem.SubItems.Add(reader("lager_waren_verkaufspreis").ToString() & " €")
                lstViewLager.Items.Add(lstViewItem)
            '}
            Loop
            reader.Close()
            lagerGeladen = True
        '}
        Catch ex As Exception
        '{
            MessageBox.Show(ex.Message)
        '}
        End Try
        connection.Close()
    End If
End Sub

Public Sub NachbestellungenAnzeigen(befehl As String)
    If nachbestellungenGeladen = False Or befehl = "nachbestellungen_erneut_laden" Then
        Try
        '{
            lstViewNachbestellungen.Items.Clear()

            connection.Open()
            command.CommandText = "SELECT * FROM nachbestellungen"
            Konsole.txtBox.Text += command.CommandText & Environment.NewLine & Environment.NewLine
            ScrollToEnd()

            If befehl <> "nachbestellungen_erneut_laden" Then
            '{
                lstViewNachbestellungen.Columns.Add("Nachbestellungsnummer", 150, HorizontalAlignment.Left)
                lstViewNachbestellungen.Columns.Add("Warennummer", 150, HorizontalAlignment.Left)
                lstViewNachbestellungen.Columns.Add("Anzahl", 150, HorizontalAlignment.Left)
            '}
            End If

            reader = command.ExecuteReader()

            Do While reader.Read()
            '{
                Dim lstViewItem As New ListViewItem(reader("nachbestellungen_id").ToString())
                lstViewItem.SubItems.Add(reader("nachbestellungen_waren_id").ToString())
                lstViewItem.SubItems.Add(reader("nachbestellungen_waren_anzahl").ToString())
                lstViewNachbestellungen.Items.Add(lstViewItem)
            '}
            Loop
            reader.Close()
            nachbestellungenGeladen = True
        '}
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        connection.Close()
    End If
End Sub

Public Sub VerkaufshistorieAnzeigen(befehl As String)
    If verkaufshistorieGeladen = False Or befehl = "verkaufshistorie_erneut_laden" Then
        Try
        '{
            lstViewVerkaufshistorie.Items.Clear()

            connection.Open()
            command.CommandText = "SELECT * FROM verkaufshistorie"
            Konsole.txtBox.Text += command.CommandText & Environment.NewLine & Environment.NewLine
            ScrollToEnd()

            If befehl <> "verkaufshistorie_erneut_laden" Then
            '{
                lstViewVerkaufshistorie.Columns.Add("Bestellnummer", 100, HorizontalAlignment.Left)
                lstViewVerkaufshistorie.Columns.Add("Kundennummer", 100, HorizontalAlignment.Left)
                lstViewVerkaufshistorie.Columns.Add("Bestelldatum", 100, HorizontalAlignment.Left)
                lstViewVerkaufshistorie.Columns.Add("Warennummer", 100, HorizontalAlignment.Left)
                lstViewVerkaufshistorie.Columns.Add("Verkaufspreis", 100, HorizontalAlignment.Left)
                lstViewVerkaufshistorie.Columns.Add("Anzahl", 100, HorizontalAlignment.Left)
            '}
            End If

            reader = command.ExecuteReader()

            Dim kaufdatum As DateTime

            Do While reader.Read()
            '{
                kaufdatum = Convert.ToDateTime(reader("verkaufshistorie_datum"))
                kaufdatum.ToString("dd.MM.yyy")

                Dim lstViewItem As New ListViewItem(reader("verkaufshistorie_bestellung_id").ToString())
                lstViewItem.SubItems.Add(reader("verkaufshistorie_kunden_id").ToString())
                lstViewItem.SubItems.Add(kaufdatum)
                lstViewItem.SubItems.Add(reader("verkaufshistorie_waren_id").ToString())
                lstViewItem.SubItems.Add(reader("verkaufshistorie_verkaufspreis").ToString() & " €")
                lstViewItem.SubItems.Add(reader("verkaufshistorie_waren_anzahl").ToString())
                lstViewVerkaufshistorie.Items.Add(lstViewItem)
            '}
            Loop
            reader.Close()
            verkaufshistorieGeladen = True
        '}
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        connection.Close()
    End If
End Sub

'BUTTONS

Private Sub cmdAblehnen_Click(sender As Object, e As EventArgs) Handles cmdAblehnen.Click
    Try
    '{
        connection.Open()
        command.CommandText = "UPDATE bestellung SET bestellung_offen = False WHERE bestellung_id = " & lstViewBestellungen.Items(lstViewBestellungen.FocusedItem.Index).SubItems(0).Text
        command.ExecuteNonQuery()

        Konsole.txtBox.Text += command.CommandText & Environment.NewLine & Environment.NewLine
        ScrollToEnd()
    '}
    Catch ex As Exception
        MessageBox.Show("Bitte wählen Sie einen Eintrag aus der Liste aus", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End Try
    connection.Close()
    BestellungenAnzeigen("bestellungen_erneut_laden")
End Sub

Private Sub cmdVerschicken_Click(sender As Object, e As EventArgs) Handles cmdVerschicken.Click
    Try
    '{
        connection.Open()

        Dim bestell_id As Integer = lstViewBestellungen.Items(lstViewBestellungen.FocusedItem.Index).SubItems(0).Text
        Dim bestell_kunden_id As Integer = lstViewBestellungen.Items(lstViewBestellungen.FocusedItem.Index).SubItems(1).Text
        Dim bestell_waren_id As Integer = lstViewBestellungen.Items(lstViewBestellungen.FocusedItem.Index).SubItems(2).Text
        Dim bestell_anzahl As Integer = lstViewBestellungen.Items(lstViewBestellungen.FocusedItem.Index).SubItems(3).Text

        Dim preis As Integer = Nothing
        Dim kunden_geld As Integer = Nothing
        Dim firmen_budget As Integer = Nothing
        Dim lager_anzahl As Integer = Nothing
        Dim gesamtpreis As Integer = Nothing

        Try
        '{
            'preis

            command.CommandText = "SELECT lager_waren_verkaufspreis FROM lager WHERE lager_waren_id = " & bestell_waren_id
            Konsole.txtBox.Text += command.CommandText & Environment.NewLine & Environment.NewLine
            ScrollToEnd()
            reader = command.ExecuteReader()

            Do While reader.Read()
                preis = reader("lager_waren_verkaufspreis")
            Loop
            reader.Close()
            Konsole.txtBox.Text += "Preis: " & preis & " €" & Environment.NewLine & Environment.NewLine
            ScrollToEnd()

            'kunden_geld

            command.CommandText = "SELECT kunden_geld FROM kunden WHERE kunden_id = " & bestell_kunden_id
            Konsole.txtBox.Text += command.CommandText & Environment.NewLine & Environment.NewLine
            ScrollToEnd()
            reader = command.ExecuteReader()

            Do While reader.Read
                kunden_geld = reader("kunden_geld")
            Loop
            reader.Close()
            Konsole.txtBox.Text += "Kundengeld: " & kunden_geld & " €" & Environment.NewLine & Environment.NewLine
            ScrollToEnd()

            'firmen_budget

            command.CommandText = "SELECT firmen_budget FROM firma"
            Konsole.txtBox.Text += command.CommandText & Environment.NewLine & Environment.NewLine
            ScrollToEnd()
            reader = command.ExecuteReader()

            Do While reader.Read()
                firmen_budget = reader("firmen_budget")
            Loop
            reader.Close()

            Konsole.txtBox.Text += "Firmenbudget: " & kunden_geld & " €" & Environment.NewLine & Environment.NewLine
            ScrollToEnd()

            'lager_anzahl

            command.CommandText = "SELECT lager_warenanzahl FROM lager WHERE lager_waren_id = " & bestell_waren_id
            Konsole.txtBox.Text += command.CommandText & Environment.NewLine & Environment.NewLine
            ScrollToEnd()
            reader = command.ExecuteReader()

            Do While reader.Read()
                lager_anzahl = reader("lager_warenanzahl")
            Loop
            reader.Close()

            Konsole.txtBox.Text += "Lageranzahl: " & lager_anzahl & Environment.NewLine & Environment.NewLine
            ScrollToEnd()
        '}
        Catch ex As Exception
            MessageBox.Show("Bitte wählen Sie einen Eintrag aus der Liste aus", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try


        If bestell_anzahl <= lager_anzahl Then
        '{
            '1. Bestellung löschen
            command.CommandText = "UPDATE bestellung SET bestellung_offen = False WHERE bestellung_id = " & bestell_id
            command.ExecuteNonQuery()

            Konsole.txtBox.Text += command.CommandText & Environment.NewLine & Environment.NewLine
            ScrollToEnd()

            '2. Zu Verkaufshistorie hinzufügen
            gesamtpreis = bestell_anzahl * preis
            Konsole.txtBox.Text += "Gesamtpreis: " & gesamtpreis & " €" & Environment.NewLine & Environment.NewLine
            ScrollToEnd()
            command.CommandText = "INSERT INTO verkaufshistorie (verkaufshistorie_bestellung_id, verkaufshistorie_kunden_id, verkaufshistorie_datum, verkaufshistorie_waren_id, verkaufshistorie_verkaufspreis, verkaufshistorie_waren_anzahl) VALUES ('" & bestell_id & "', '" & bestell_kunden_id & "', '" & Date.Now.Date() & "', '" & bestell_waren_id & "', '" & gesamtpreis & "', '" & bestell_anzahl & "');"
            command.ExecuteNonQuery()

            Konsole.txtBox.Text += command.CommandText & Environment.NewLine & Environment.NewLine
            ScrollToEnd()

            '3. Kunden Geld abheben
            command.CommandText = "UPDATE kunden SET kunden_geld = " & kunden_geld - gesamtpreis & " WHERE kunden_id = " & bestell_kunden_id
            command.ExecuteNonQuery()

            Konsole.txtBox.Text += command.CommandText & Environment.NewLine & Environment.NewLine
            ScrollToEnd()

            '4. Firma Geld hinzufügen
            command.CommandText = "UPDATE firma SET firmen_budget = " & firmen_budget + gesamtpreis
            command.ExecuteNonQuery()

            Konsole.txtBox.Text += command.CommandText & Environment.NewLine & Environment.NewLine
            ScrollToEnd()

            '5. Waren vom Lager abziehen
            command.CommandText = "UPDATE lager SET lager_warenanzahl = " & lager_anzahl - bestell_anzahl & " WHERE lager_waren_id = " & bestell_waren_id
            command.ExecuteNonQuery()

            Konsole.txtBox.Text += command.CommandText & Environment.NewLine & Environment.NewLine
            ScrollToEnd()

            '6. Budget zu Budgetverlauf hinzufügen
            command.CommandText = "INSERT INTO budgetverlauf (budgetverlauf_wert, budgetverlauf_datum) values ('" & firmen_budget + gesamtpreis & "', '" & Date.Now & "')"
            Konsole.txtBox.Text += command.CommandText & Environment.NewLine & Environment.NewLine
            ScrollToEnd()
            command.ExecuteNonQuery()

            '7. Kontoverlauf des Kunden updaten
            command.CommandText = "INSERT INTO kontoverlauf (kontoverlauf_kunden_id, kontoverlauf_wert, kontoverlauf_datum) values ('" & bestell_kunden_id & "', '" & kunden_geld - gesamtpreis & "', '" & Date.Now & "')"
            Konsole.txtBox.Text += command.CommandText & Environment.NewLine & Environment.NewLine
            ScrollToEnd()
            command.ExecuteNonQuery()
    '}
    Else
        MsgBox("Nicht genügend Waren vorhanden!")
    End If
    '}
    Catch ex As Exception
        MsgBox(ex.Message)
    End Try
    connection.Close()
    BestellungenAnzeigen("bestellungen_erneut_laden")
    LagerAnzeigen("lager_erneut_laden")
End Sub

Private Sub cmdNachbestellen_Click(sender As Object, e As EventArgs) Handles cmdNachbestellen.Click
    Try
        artikel_ausgewaehlt = lstViewLager.Items(lstViewLager.FocusedItem.Index).SubItems(0).Text
    Catch ex As Exception
        artikel_ausgewaehlt = Nothing
    End Try
    bearbeitenFensterSender = "nachbestellen_versand"
    FormBearbeiten.Show()
    Me.Enabled = False
End Sub

'SORTIERFUNKTIONEN

Private Sub Sortieren(Column As Integer, lstView As String)
    Dim name As String = Nothing 'Name der geklickten Spalte
    Dim selectedLstView As String = Nothing 'Als Parameter für die Sortierfunktion

    Try
    '{
        If lstView.Contains("Bestellungen") Then
            selectedLstView = "bestellung"
            lstViewBestellungen.Items.Clear()
            Select Case Column
                Case 0
                    Name = "bestellung_id"
                Case 1
                    Name = "bestellung_kunden_id"
                Case 2
                    Name = "bestellung_waren_id"
                Case 3
                    Name = "bestellung_anzahl"
            End Select
        ElseIf lstView.Contains("Lager") Then
            selectedLstView = "lager"
            lstViewLager.Items.Clear()
            Select Case Column
                Case 0
                    Name = "lager_waren_id"
                Case 1
                    Name = "lager_warenanzahl"
                Case 2
                    name = "lager_warenname"
                Case 3
                    name = "lager_kategorie"
                Case 3
                    name = "lager_warengewicht"
                Case 4
                    Name = "lager_waren_verkaufspreis"
            End Select
        ElseIf lstView.Contains("Nachbestellungen") Then
            selectedLstView = "nachbestellungen"
            lstViewNachbestellungen.Items.Clear()
            Select Case Column
                Case 0
                    Name = "nachbestellungen_id"
                Case 1
                    Name = "nachbestellungen_waren_id"
                Case 2
                    Name = "nachbestellungen_waren_anzahl"
            End Select
        ElseIf lstView.Contains("Verkaufshistorie") Then
            selectedLstView = "verkaufshistorie"
            lstViewVerkaufshistorie.Items.Clear()
            Select Case Column
                Case 0
                    Name = "verkaufshistorie_bestellung_id"
                Case 1
                    Name = "verkaufshistorie_kunden_id"
                Case 2
                    Name = "verkaufshistorie_datum"
                Case 3
                    Name = "verkaufshistorie_waren_id"
                Case 4
                    Name = "verkaufshistorie_verkaufspreis"
                Case 5
                    Name = "verkaufshistorie_waren_anzahl"
            End Select
        Else
            MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        Konsole.txtBox.Text += "Column clicked: " & Name & Environment.NewLine & Environment.NewLine
        ScrollToEnd()

        connection.Open()
        If selectedLstView = "lager" Then
            If ascendORdescend = False Then
                command.CommandText = "SELECT * FROM " & selectedLstView & " WHERE lager_aktiv = True ORDER BY " & name
                ascendORdescend = True
            ElseIf ascendORdescend = True Then
                command.CommandText = "SELECT * FROM " & selectedLstView & " WHERE lager_aktiv = True ORDER BY " & name & " DESC"
                ascendORdescend = False
            End If
        ElseIf selectedLstView = "verkaufshistorie" Or selectedLstView = "nachbestellungen" Then
            If ascendORdescend = False Then
                command.CommandText = "SELECT * FROM " & selectedLstView & " ORDER BY " & name
                ascendORdescend = True
            ElseIf ascendORdescend = True Then
                command.CommandText = "SELECT * FROM " & selectedLstView & " ORDER BY " & name & " DESC"
                ascendORdescend = False
            End If
        ElseIf selectedLstView = "bestellung" Then
            If ascendORdescend = False Then
                command.CommandText = "SELECT * FROM " & selectedLstView & " WHERE bestellung_offen = True ORDER BY " & name
                ascendORdescend = True
            ElseIf ascendORdescend = True Then
                command.CommandText = "SELECT * FROM " & selectedLstView & " WHERE bestellung_offen = True ORDER BY " & name & " DESC"
                ascendORdescend = False
            End If
        End If
        Konsole.txtBox.Text += command.CommandText & Environment.NewLine & Environment.NewLine
        ScrollToEnd()

        reader = command.ExecuteReader()

        Do While reader.Read()
        '{
            If selectedLstView = "lager" Then
                Dim lstViewItem As New ListViewItem(reader("lager_waren_id").ToString())
                lstViewItem.SubItems.Add(reader("lager_warenanzahl").ToString())
                lstViewItem.SubItems.Add(reader("lager_warenname").ToString())
                lstViewItem.SubItems.Add(reader("lager_kategorie").ToString())
                lstViewItem.SubItems.Add(reader("lager_warengewicht").ToString() & " kg")
                lstViewItem.SubItems.Add(reader("lager_waren_verkaufspreis").ToString() & " €")
                lstViewLager.Items.Add(lstViewItem)
            ElseIf selectedLstView = "bestellung" Then
                Dim lstViewItem As New ListViewItem(reader("bestellung_id").ToString())
                lstViewItem.SubItems.Add(reader("bestellung_kunden_id").ToString())
                lstViewItem.SubItems.Add(reader("bestellung_waren_id").ToString())
                lstViewItem.SubItems.Add(reader("bestellung_anzahl").ToString())
                lstViewBestellungen.Items.Add(lstViewItem)
            ElseIf selectedLstView = "verkaufshistorie" Then
                Dim lstViewItem As New ListViewItem(reader("verkaufshistorie_bestellung_id").ToString())
                lstViewItem.SubItems.Add(reader("verkaufshistorie_kunden_id").ToString())
                Dim kaufdatum As DateTime
                kaufdatum = Convert.ToDateTime(reader("verkaufshistorie_datum"))
                kaufdatum.ToString("dd.MM.yyyy")
                lstViewItem.SubItems.Add(kaufdatum)
                lstViewItem.SubItems.Add(reader("verkaufshistorie_waren_id").ToString())
                lstViewItem.SubItems.Add(reader("verkaufshistorie_verkaufspreis").ToString() & " €")
                lstViewItem.SubItems.Add(reader("verkaufshistorie_waren_anzahl").ToString())
                lstViewVerkaufshistorie.Items.Add(lstViewItem)
            ElseIf selectedLstView = "nachbestellungen" Then
                Dim lstViewItem As New ListViewItem(reader("nachbestellungen_id").ToString())
                lstViewItem.SubItems.Add(reader("nachbestellungen_waren_id").ToString())
                lstViewItem.SubItems.Add(reader("nachbestellungen_waren_anzahl").ToString())
                lstViewNachbestellungen.Items.Add(lstViewItem)
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

Private Sub lstViewBestellungen_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles lstViewBestellungen.ColumnClick
    Sortieren(e.Column, TabControlVersand.SelectedTab.ToString())
End Sub

Private Sub lstViewLager_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles lstViewLager.ColumnClick
    Sortieren(e.Column, TabControlVersand.SelectedTab.ToString())
End Sub

Private Sub lstViewNachbestellungen_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles lstViewNachbestellungen.ColumnClick
    Sortieren(e.Column, TabControlVersand.SelectedTab.ToString())
End Sub

Private Sub lstViewVerkaufshistorie_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles lstViewVerkaufshistorie.ColumnClick
    Sortieren(e.Column, TabControlVersand.SelectedTab.ToString())
End Sub

'SUCHEN

Private Sub cmdSuchen_Click(sender As Object, e As EventArgs) Handles cmdSuchen.Click
    If TabControlVersand.SelectedTab Is tabPageBestellungen Then
         bearbeitenFensterSender = "suchen_bestellungen_versand"
    ElseIf TabControlVersand.SelectedTab Is tabPageLager Then
        bearbeitenFensterSender = "suchen_lager_versand"
    ElseIf TabControlVersand.SelectedTab Is tabPageNachbestellungen Then
        bearbeitenFensterSender = "suchen_nachbestellungen_versand"
    ElseIf TabControlVersand.SelectedTab Is tabPageVerkaufshistorie Then
        bearbeitenFensterSender = "suchen_verkaufshistorie_versand"
    End If
    FormBearbeiten.Show()
    Me.Enabled = False
End Sub

'ALLES ANZEIGEN

Private Sub cmdAllesAnzeigen_Click(sender As Object, e As EventArgs) Handles cmdAllesAnzeigen.Click
    If TabControlVersand.SelectedTab Is tabPageBestellungen Then
    '{
        BestellungenAnzeigen("bestellungen_erneut_laden")
    '}
    ElseIf TabControlVersand.SelectedTab Is tabPageLager Then
    '{
        LagerAnzeigen("lager_erneut_laden")
    '}
    ElseIf TabControlVersand.SelectedTab Is tabPageNachbestellungen Then
    '{
        NachbestellungenAnzeigen("nachbestellungen_erneut_laden")
    '}
    ElseIf TabControlVersand.SelectedTab Is tabPageVerkaufshistorie Then
    '{
        VerkaufshistorieAnzeigen("verkaufshistorie_erneut_laden")
    '}
    End If
End Sub

'TOOLSTRIP

Private Sub UmmeldenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UmmeldenToolStripMenuItem.Click
    FormAnmeldung.Show()
    Me.Close()
End Sub

Private Sub ÖffnenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ÖffnenToolStripMenuItem.Click
    Konsole.Show()
End Sub

Private Sub SchließenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SchließenToolStripMenuItem.Click
    Konsole.Close()
End Sub

'WIRD BEIM SCHLIEßEN AUSGEFÜHRT

Private Sub FormVersand_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
    Konsole.Close()
End Sub

End Class