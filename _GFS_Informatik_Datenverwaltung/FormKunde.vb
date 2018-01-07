Imports System.Data.OleDb 'Wird für das Kommunizieren mit der Datenbank benötigt
Imports System.Windows.Forms.DataVisualization.Charting 'Wird für Diagramme benötigt


Public Class FormKunde

    ' -- VARIABLENDEFINITION -- '

    Dim connection As New OleDbConnection 'Verbindung zwischen Programm und Datenbank
    Dim command As New OleDbCommand       'Beinhaltet SQL-Befehle, die an die Datenbank gesendet werden
    Dim reader As OleDbDataReader         'Um die ausgewählten Daten auslesen zu können

    Dim storeGeladen As Boolean = False
    Dim kundenkontoGeladen As Boolean = False
    Dim verkaufshistorieGeladen As Boolean = False
    Dim offeneBestellungenGeladen As Boolean = False
    Dim kontoverlaufGeladen As Boolean = False

    Dim ascendORdescend As Boolean = True

    ' -- VARIABLENDEFINITION ENDE -- '

Private Sub FormKunde_Load(sender As Object, e As EventArgs) Handles MyBase.Load
'{
    cmdKontoBearbeiten.Enabled = False 'Die Store-Kategorie ist am Anfang ausgewählt. Der Button darf nur betätigt werden, wenn das Kundenkonto ausgewählt ist
    cmdKontoBearbeiten.BackColor = Color.FromKnownColor(KnownColor.Control)

    connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" & "Data Source=" & Application.StartupPath & "\Ressourcen\Access-Datei\GFS.accdb;"
    command.Connection = connection
    Konsole.txtBox.Text += connection.ConnectionString & Environment.NewLine & Environment.NewLine
    ScrollToEnd()

    LagerAnzeigen(Nothing)

    Me.Text = "Kunde [" & kunden_id_module & "]"

    KontostandAnzeigen()
'}
End Sub

Private Sub tabControlKunde_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tabControlKunde.SelectedIndexChanged

    If tabControlKunde.SelectedTab Is tabPageStore Then
    '{
        cmdKontoBearbeiten.Enabled = False
        cmdKontoBearbeiten.BackColor = Color.FromKnownColor(KnownColor.Control)
        cmdBestellen.Enabled = True
        cmdBestellen.BackColor = Color.MediumSeaGreen
        cmdSuchen.Enabled = True
        cmdSuchen.BackColor = Color.LightBlue
        cmdAllesAnzeigen.Enabled = True
        cmdAllesAnzeigen.BackColor = Color.LightCoral

        If storeGeladen = False Then
            LagerAnzeigen(Nothing)
        Else
            LagerAnzeigen("lager_erneut_laden")
        End If

        Konsole.txtBox.Text += tabControlKunde.SelectedTab.ToString() & Environment.NewLine & Environment.NewLine
        ScrollToEnd()
    '}
    ElseIf tabControlKunde.SelectedTab Is tabPageKundenkonto Then
    '{
        cmdKontoBearbeiten.Enabled = True
        cmdKontoBearbeiten.BackColor = Color.Khaki
        cmdBestellen.Enabled = False
        cmdBestellen.BackColor = Color.FromKnownColor(KnownColor.Control)
        cmdSuchen.Enabled = False
        cmdSuchen.BackColor = Color.FromKnownColor(KnownColor.Control)
        cmdAllesAnzeigen.Enabled = True
        cmdAllesAnzeigen.BackColor = Color.LightCoral

        If kundenkontoGeladen = False Then
            KundenkontoAnzeigen(Nothing)
        Else
            KundenkontoAnzeigen("kundenkonto_erneut_laden")
        End If

        Konsole.txtBox.Text += tabControlKunde.SelectedTab.ToString() & Environment.NewLine & Environment.NewLine
        ScrollToEnd()
    '}
    ElseIf tabControlKunde.SelectedTab Is tabPageVerkaufshistorie Then
    '{
        cmdKontoBearbeiten.Enabled = False
        cmdKontoBearbeiten.BackColor = Color.FromKnownColor(KnownColor.Control)
        cmdBestellen.Enabled = False
        cmdBestellen.BackColor = Color.FromKnownColor(KnownColor.Control)
        cmdSuchen.Enabled = True
        cmdSuchen.BackColor = Color.LightBlue
        cmdAllesAnzeigen.Enabled = True
        cmdAllesAnzeigen.BackColor = Color.LightCoral

        If verkaufshistorieGeladen = False Then
            VerkaufshistorieAnzeigen(Nothing)
        Else
            VerkaufshistorieAnzeigen("verkaufshistorie_erneut_laden")
        End If

        Konsole.txtBox.Text += tabControlKunde.SelectedTab.ToString() & Environment.NewLine & Environment.NewLine
        ScrollToEnd()
    '}
    ElseIf tabControlKunde.SelectedTab Is tabPageOffeneBestellungen Then
    '{
        cmdKontoBearbeiten.Enabled = False
        cmdKontoBearbeiten.BackColor = Color.FromKnownColor(KnownColor.Control)
        cmdBestellen.Enabled = False
        cmdBestellen.BackColor = Color.FromKnownColor(KnownColor.Control)
        cmdSuchen.Enabled = True
        cmdSuchen.BackColor = Color.LightBlue
        cmdAllesAnzeigen.Enabled = True
        cmdAllesAnzeigen.BackColor = Color.LightCoral

        If offeneBestellungenGeladen = False Then
            OffeneBestellungenAnzeigen(Nothing)
        Else
            OffeneBestellungenAnzeigen("offene_bestellungen_erneut_laden")
        End If

        Konsole.txtBox.Text += tabControlKunde.SelectedTab.ToString() & Environment.NewLine & Environment.NewLine
        ScrollToEnd()
    '}
    ElseIf tabControlKunde.SelectedTab Is tabPageKontoverlauf Then
    '{
        cmdKontoBearbeiten.Enabled = False
        cmdKontoBearbeiten.BackColor = Color.FromKnownColor(KnownColor.Control)
        cmdBestellen.Enabled = False
        cmdBestellen.BackColor = Color.FromKnownColor(KnownColor.Control)
        cmdSuchen.Enabled = True
        cmdSuchen.BackColor = Color.LightBlue
        cmdAllesAnzeigen.Enabled = True
        cmdAllesAnzeigen.BackColor = Color.LightCoral

        If kontoverlaufGeladen = False Then
            KontoverlaufAnzeigen(Nothing)
        Else
            KontoverlaufAnzeigen("kontoverlauf_erneut_laden")
        End If
        KontoverlaufChartAnzeigen()

        Konsole.txtBox.Text += tabControlKunde.SelectedTab.ToString() & Environment.NewLine & Environment.NewLine
        ScrollToEnd()
    '}
    End If

End Sub

Public Sub LagerAnzeigen(befehl As String)
    If storeGeladen = False Or befehl = "lager_erneut_laden" Then
        Try
        '{
            lstViewKundeStore.Items.Clear()

            connection.Open()
            command.CommandText = "SELECT * FROM lager WHERE lager_aktiv = True ORDER BY lager_waren_id"
            Konsole.txtBox.Text += command.CommandText & Environment.NewLine & Environment.NewLine
            ScrollToEnd()

            If befehl <> "lager_erneut_laden" Then
            '{
                lstViewKundeStore.Columns.Add("Warennummer", 100, HorizontalAlignment.Left)
                lstViewKundeStore.Columns.Add("Anzahl verfügbar", 100, HorizontalAlignment.Left)
                lstViewKundeStore.Columns.Add("Name", 200, HorizontalAlignment.Left)
                lstViewKundeStore.Columns.Add("Kategorie", 100, HorizontalAlignment.Left)
                lstViewKundeStore.Columns.Add("Gewicht", 100, HorizontalAlignment.Left)
                lstViewKundeStore.Columns.Add("Preis", 100, HorizontalAlignment.Left)
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
                lstViewKundeStore.Items.Add(lstViewItem)
            '}
            Loop
            reader.Close()
            storeGeladen = True
        '}
        Catch ex As Exception
        '{
            MessageBox.Show(ex.Message)
        '}
        End Try
        connection.Close()
    End If
End Sub

Public Sub KundenkontoAnzeigen(befehl As String)
    If kundenkontoGeladen = False Or befehl = "kundenkonto_erneut_laden" Then
        Try
        '{
            lstViewKundeKundenkonto.Items.Clear()

            connection.Open()
            command.CommandText = "SELECT * FROM kunden WHERE kunden_id = " & kunden_id_module & " AND kunden_konto_aktiv = True"
            Konsole.txtBox.Text += command.CommandText & Environment.NewLine & Environment.NewLine
            ScrollToEnd()

            If befehl <> "kundenkonto_erneut_laden" Then
            '{
                lstViewKundeKundenkonto.Columns.Add("Kundennummer", 50, HorizontalAlignment.Left)
                lstViewKundeKundenkonto.Columns.Add("Nachname", 100, HorizontalAlignment.Left)
                lstViewKundeKundenkonto.Columns.Add("Vorname", 100, HorizontalAlignment.Left)
                lstViewKundeKundenkonto.Columns.Add("E-Mail", 140, HorizontalAlignment.Left)
                lstViewKundeKundenkonto.Columns.Add("Telefonnummer", 100, HorizontalAlignment.Left)
                lstViewKundeKundenkonto.Columns.Add("Land", 100, HorizontalAlignment.Left)
                lstViewKundeKundenkonto.Columns.Add("PLZ", 50, HorizontalAlignment.Left)
                lstViewKundeKundenkonto.Columns.Add("Stadt", 100, HorizontalAlignment.Left)
                lstViewKundeKundenkonto.Columns.Add("Straße", 100, HorizontalAlignment.Left)
                lstViewKundeKundenkonto.Columns.Add("Hausnummer", 50, HorizontalAlignment.Left)
                lstViewKundeKundenkonto.Columns.Add("Passwort", 100, HorizontalAlignment.Left)
                lstViewKundeKundenkonto.Columns.Add("Geld", 100, HorizontalAlignment.Left)
            '}
            End If

            reader = command.ExecuteReader()

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
                lstViewKundeKundenkonto.Items.Add(lstViewItem)
            '}
            Loop
            reader.Close()
            kundenkontoGeladen = True
        '}
        Catch ex As Exception
        '{
            MessageBox.Show(ex.Message)
        '}
        End Try
        connection.Close()
    End If
End Sub

Public Sub VerkaufshistorieAnzeigen(befehl As String)
    If verkaufshistorieGeladen = False Or befehl = "verkaufshistorie_erneut_laden" Then
        Try
        '{
            lstViewKundeVerkaufshistorie.Items.Clear()

            connection.Open()
            command.CommandText = "SELECT * FROM verkaufshistorie WHERE verkaufshistorie_kunden_id = " & kunden_id_module
            Konsole.txtBox.Text += command.CommandText & Environment.NewLine & Environment.NewLine
            ScrollToEnd()

            If befehl <> "verkaufshistorie_erneut_laden" Then
            '{
                lstViewKundeVerkaufshistorie.Columns.Add("Bestellungsnummer", 100, HorizontalAlignment.Left)
                lstViewKundeVerkaufshistorie.Columns.Add("Kundennummer", 100, HorizontalAlignment.Left)
                lstViewKundeVerkaufshistorie.Columns.Add("Kaufdatum", 100, HorizontalAlignment.Left)
                lstViewKundeVerkaufshistorie.Columns.Add("Warennummer", 100, HorizontalAlignment.Left)
                lstViewKundeVerkaufshistorie.Columns.Add("Verkaufspreis", 100, HorizontalAlignment.Left)
                lstViewKundeVerkaufshistorie.Columns.Add("Anzahl", 100, HorizontalAlignment.Left)
            '}
            End If

            reader = command.ExecuteReader()

            Dim kaufdatum As DateTime

            Do While reader.Read()
            '{
                kaufdatum = Convert.ToDateTime(reader("verkaufshistorie_datum"))
                kaufdatum.ToString("dd.MM.yyyy")

                Dim lstViewItem As New ListViewItem(reader("verkaufshistorie_bestellung_id").ToString())
                lstViewItem.SubItems.Add(reader("verkaufshistorie_kunden_id").ToString())
                lstViewItem.SubItems.Add(kaufdatum)
                lstViewItem.SubItems.Add(reader("verkaufshistorie_waren_id").ToString())
                lstViewItem.SubItems.Add(reader("verkaufshistorie_verkaufspreis").ToString() & " €")
                lstViewItem.SubItems.Add(reader("verkaufshistorie_waren_anzahl").ToString())
                lstViewKundeVerkaufshistorie.Items.Add(lstViewItem)
            '}
            Loop
            reader.Close()
            verkaufshistorieGeladen = True
        '}
        Catch ex As Exception
        '{
            MessageBox.Show(ex.Message)
        '}
        End Try
        connection.Close()
    End If
End Sub

Public Sub OffeneBestellungenAnzeigen(befehl As String)
    If offeneBestellungenGeladen = False Or befehl = "offene_bestellungen_erneut_laden" Then
        Try
        '{
            lstViewOffeneBestellungen.Items.Clear()

            connection.Open()
            command.CommandText = "SELECT * FROM bestellung WHERE bestellung_kunden_id = " & kunden_id_module & " AND bestellung_offen = True"
            Konsole.txtBox.Text += command.CommandText & Environment.NewLine & Environment.NewLine
            ScrollToEnd()

            If befehl <> "offene_bestellungen_erneut_laden" Then
            '{
                lstViewOffeneBestellungen.Columns.Add("Bestellnummer", 100, HorizontalAlignment.Left)
                lstViewOffeneBestellungen.Columns.Add("Kundennummer", 100, HorizontalAlignment.Left)
                lstViewOffeneBestellungen.Columns.Add("Warennummer", 100, HorizontalAlignment.Left)
                lstViewOffeneBestellungen.Columns.Add("Warenanzahl", 100, HorizontalAlignment.Left)
            '}
            End If

            reader = command.ExecuteReader()

            Do While reader.Read()
            '{
                Dim lstViewItem As New ListViewItem(reader("bestellung_id").ToString())
                lstViewItem.SubItems.Add(reader("bestellung_kunden_id").ToString())
                lstViewItem.SubItems.Add(reader("bestellung_waren_id").ToString())
                lstViewItem.SubItems.Add(reader("bestellung_anzahl").ToString())
                lstViewOffeneBestellungen.Items.Add(lstViewItem)
            '}
            Loop
            reader.Close()
            offeneBestellungenGeladen = True
        '}
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        connection.Close()
    End If
End Sub

Private Sub KontostandAnzeigen()
    Try
    '{
        connection.Open()
        command.CommandText = "SELECT kunden_geld FROM kunden WHERE kunden_id = " & kunden_id_module
        Konsole.txtBox.Text += command.CommandText & Environment.NewLine & Environment.NewLine
        ScrollToEnd()

        reader = command.ExecuteReader()

        Do While reader.Read()
            lblKonto.Text = "Konto: " & reader("kunden_geld") & " €"
        Loop
        reader.Close()
    Catch ex As Exception
        MessageBox.Show(ex.Message)
    '}
    End Try
    connection.Close()
End Sub

Public Sub KontoverlaufAnzeigen(befehl As String)
    If kontoverlaufGeladen = False Or befehl = "kontoverlauf_erneut_laden" Then
        Try
        '{
            lstViewKontoverlauf.Items.Clear()

            connection.Open()
            command.CommandText = "SELECT * FROM kontoverlauf WHERE kontoverlauf_kunden_id = " & kunden_id_module & " ORDER BY kontoverlauf_datum"
            Konsole.txtBox.Text += command.CommandText & Environment.NewLine & Environment.NewLine
            ScrollToEnd()

            If befehl <> "kontoverlauf_erneut_laden" Then
            '{
                lstViewKontoverlauf.Columns.Add("ID", 50, HorizontalAlignment.Left)
                lstViewKontoverlauf.Columns.Add("Wert", 100, HorizontalAlignment.Left)
                lstViewKontoverlauf.Columns.Add("Datum", 130, HorizontalAlignment.Left)
            '}
            End If

            reader = command.ExecuteReader()

            Dim datum As DateTime

            Do While reader.Read()
            '{
                datum = Convert.ToDateTime(reader("kontoverlauf_datum"))
                datum.ToString("dd.MM.yyy")

                Dim lstViewItem As New ListViewItem(reader("kontoverlauf_id").ToString())
                lstViewItem.SubItems.Add(reader("kontoverlauf_wert").ToString() & " €")
                lstViewItem.SubItems.Add(datum)
                lstViewKontoverlauf.Items.Add(lstViewItem)
            '}
            Loop
            reader.Close()
            kontoverlaufGeladen = True
        '}
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        connection.Close()
    End If
End Sub

Public Sub KontoverlaufChartAnzeigen()
    Try
    '{
        chartKontoverlauf.Series.Clear()

        chartKontoverlauf.Series.Add(New Series("Konto"))
        chartKontoverlauf.Series(0).ChartType = SeriesChartType.Line
        chartKontoverlauf.Series(0).Color = Color.Red
        chartKontoverlauf.Series(0).BorderWidth = 3

        chartKontoverlauf.Legends(0).Position = New ElementPosition(80, 8, 15, 5)
        chartKontoverlauf.Legends(0).BorderColor = Color.Transparent
        chartKontoverlauf.Legends(0).BorderWidth = 1

        chartKontoverlauf.ChartAreas(0).AxisX.Title = "Datum"
        chartKontoverlauf.ChartAreas(0).AxisX.TitleAlignment = StringAlignment.Far
        chartKontoverlauf.ChartAreas(0).AxisX.TitleForeColor = Color.Red
        chartKontoverlauf.ChartAreas(0).AxisX.IntervalType = DateTimeIntervalType.Auto
        chartKontoverlauf.ChartAreas(0).AxisX.IntervalAutoMode = IntervalAutoMode.VariableCount
        chartKontoverlauf.ChartAreas(0).AxisY.Title = "Kontostand in €"
        chartKontoverlauf.ChartAreas(0).AxisY.TitleAlignment = StringAlignment.Far
        chartKontoverlauf.ChartAreas(0).AxisY.TitleForeColor = Color.Red
        chartKontoverlauf.ChartAreas(0).AxisX.MajorGrid.LineColor = Color.LightGray
        chartKontoverlauf.ChartAreas(0).AxisY.MajorGrid.LineColor = Color.LightGray

        For counter As Integer = 0 To lstViewKontoverlauf.Items.Count - 1
            Dim pointX As Date = lstViewKontoverlauf.Items(counter).SubItems(2).Text.Replace("00:00:00", "")
            Dim pointY As Integer = lstViewKontoverlauf.Items(counter).SubItems(1).Text
            chartKontoverlauf.Series(0).Points.AddXY(pointX, pointY)
        Next
    '}
    Catch ex As Exception
        'MsgBox(ex.Message)
        'Ruft nur unnötige Fehler auf
    End Try
End Sub

'TOOLSTRIP FUNKTIONEN

Private Sub ÖffnenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ÖffnenToolStripMenuItem.Click
    Konsole.Show()
End Sub

Private Sub SchließenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SchließenToolStripMenuItem.Click
    Konsole.Close()
End Sub

Private Sub UmmeldenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UmmeldenToolStripMenuItem.Click
    FormAnmeldung.Show()
    Me.Close()
End Sub

Private Sub KontoLöschenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KontoLöschenToolStripMenuItem.Click
    If MessageBox.Show("Sind Sie sich sicher, dass Sie ihr Konto löschen wollen?", "Konto löschen", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
        Try
        '{
            connection.Open()

            command.CommandText = "UPDATE kunden set kunden_konto_aktiv = False WHERE kunden_id = " & kunden_id_module
            Konsole.txtBox.Text += command.CommandText & Environment.NewLine & Environment.NewLine
            ScrollToEnd()

            Dim anzahl As Integer = command.ExecuteNonQuery()

            If anzahl > 0 Then
                'Datensatz gelöscht
                FormAnmeldung.Show()
                Me.Close()
            End If
        '}
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        connection.Close()
    End If
End Sub

'SORTIERFUNKTION

Private Sub Sortieren(Column As Integer, lstView As String)
    Try
    '{
        Dim name As String = Nothing 'Name der geklickten Spalte
        Dim selectedLstView As String = Nothing 'Als Parameter für die Sortierfunktion

        If lstView.Contains("Store") Then
            selectedLstView = "lager"
            lstViewKundeStore.Items.Clear()
            Select Case Column
                Case 0
                    name = "lager_waren_id"
                Case 1
                    name = "lager_warenanzahl"
                Case 2
                    name = "lager_warenname"
                Case 3
                    name = "lager_kategorie"
                Case 4
                    name = "lager_warengewicht"
                Case 5
                    name = "lager_waren_verkaufspreis"
            End Select
        ElseIf lstView.Contains("Verkaufshistorie") Then
            selectedLstView = "verkaufshistorie"
            lstViewKundeVerkaufshistorie.Items.Clear()
            Select Case Column
                Case 0
                    name = "verkaufshistorie_bestellung_id"
                Case 1
                    name = "verkaufshistorie_kunden_id"
                Case 2
                    name = "verkaufshistorie_datum"
                Case 3
                    name = "verkaufshistorie_waren_id"
                Case 4
                    name = "verkaufshistorie_verkaufspreis"
                Case 5
                    name = "verkaufshistorie_waren_anzahl"
            End Select
        ElseIf lstView.Contains("Offene") Then
            selectedLstView = "bestellung"
            lstViewOffeneBestellungen.Items.Clear()
            Select Case Column
                Case 0
                    name = "bestellung_id"
                Case 1
                    name = "bestellung_kunden_id"
                Case 2
                    name = "bestellung_waren_id"
                Case 3
                    name = "bestellung_anzahl"
            End Select
        ElseIf lstView.Contains("Kontoverlauf") Then
            selectedLstView = "kontoverlauf"
            lstViewKontoverlauf.Items.Clear()
            Select Case Column
                Case 0
                    name = "kontoverlauf_id"
                Case 1
                    name = "kontoverlauf_wert"
                Case 2
                    name = "kontoverlauf_datum"
            End Select
        Else
            MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        Konsole.txtBox.Text += "Column clicked: " & name & Environment.NewLine & Environment.NewLine

        connection.Open()

        If selectedLstView = "lager" Then
            If ascendORdescend = False Then
                command.CommandText = "SELECT * FROM " & selectedLstView & " WHERE lager_aktiv = True ORDER BY " & name
                ascendORdescend = True
            ElseIf ascendORdescend = True Then
                command.CommandText = "SELECT * FROM " & selectedLstView & " WHERE lager_aktiv = True ORDER BY " & name & " DESC"
                ascendORdescend = False
            End If
        ElseIf selectedLstView = "verkaufshistorie" Then
            If ascendORdescend = False Then
                command.CommandText = "SELECT * FROM " & selectedLstView & " WHERE verkaufshistorie_kunden_id = " & kunden_id_module & " ORDER BY " & name
                ascendORdescend = True
            ElseIf ascendORdescend = True Then
                command.CommandText = "SELECT * FROM " & selectedLstView & " WHERE verkaufshistorie_kunden_id = " & kunden_id_module & " ORDER BY " & name & " DESC"
                ascendORdescend = False
            End If
        ElseIf selectedLstView = "bestellung" Then
            If ascendORdescend = False Then
                command.CommandText = "SELECT * FROM " & selectedLstView & " WHERE bestellung_kunden_id = " & kunden_id_module & " AND bestellung_offen = True ORDER BY " & name
                ascendORdescend = True
            ElseIf ascendORdescend = True Then
                command.CommandText = "SELECT * FROM " & selectedLstView & " WHERE bestellung_kunden_id = " & kunden_id_module & " AND bestellung_offen = True ORDER BY " & name & " DESC"
                ascendORdescend = False
            End If
        ElseIf selectedLstView = "kontoverlauf" Then
            If ascendORdescend = False Then
                command.CommandText = "SELECT * FROM " & selectedLstView & " WHERE kontoverlauf_kunden_id = " & kunden_id_module & " ORDER BY " & name
                ascendORdescend = True
            ElseIf ascendORdescend = True Then
                command.CommandText = "SELECT * FROM " & selectedLstView & " WHERE kontoverlauf_kunden_id = " & kunden_id_module & " ORDER BY " & name & " DESC"
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
                lstViewKundeStore.Items.Add(lstViewItem)
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
                lstViewKundeVerkaufshistorie.Items.Add(lstViewItem)
            ElseIf selectedLstView = "bestellung" Then
                Dim lstViewItem As New ListViewItem(reader("bestellung_id").ToString())
                lstViewItem.SubItems.Add(reader("bestellung_kunden_id").ToString())
                lstViewItem.SubItems.Add(reader("bestellung_waren_id").ToString())
                lstViewItem.SubItems.Add(reader("bestellung_anzahl").ToString())
                lstViewOffeneBestellungen.Items.Add(lstViewItem)
            ElseIf selectedLstView = "kontoverlauf" Then
                Dim lstViewItem As New ListViewItem(reader("kontoverlauf_id").ToString())
                lstViewItem.SubItems.Add(reader("kontoverlauf_wert".ToString()) & " €")
                Dim datum As DateTime
                datum = Convert.ToDateTime(reader("kontoverlauf_datum"))
                datum.ToString("dd.MM.yyy")
                lstViewItem.SubItems.Add(datum)
                lstViewKontoverlauf.Items.Add(lstViewItem)
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

Private Sub lstViewKundeVerkaufshistorie_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles lstViewKundeVerkaufshistorie.ColumnClick
    Sortieren(e.Column, tabControlKunde.SelectedTab.ToString())
End Sub

Private Sub lstViewOffeneBestellungen_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles lstViewOffeneBestellungen.ColumnClick
    Sortieren(e.Column, tabControlKunde.SelectedTab.ToString())
End Sub

Private Sub lstViewKundeStore_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles lstViewKundeStore.ColumnClick
    Sortieren(e.Column, tabControlKunde.SelectedTab.ToString())
End Sub

Private Sub lstViewKontoverlauf_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles lstViewKontoverlauf.ColumnClick
    Sortieren(e.Column, tabControlKunde.SelectedTab.ToString())
End Sub

'KONTO BEARBEITEN

Private Sub cmdKontoBearbeiten_Click(sender As Object, e As EventArgs) Handles cmdKontoBearbeiten.Click
    bearbeitenFensterSender = "kundenkonto_bearbeiten"
    FormBearbeiten.Show()
    Me.Enabled = False
End Sub

'BESTELLEN

Private Sub cmdBestellen_Click(sender As Object, e As EventArgs) Handles cmdBestellen.Click
    Try
        artikel_ausgewaehlt = lstViewKundeStore.Items(lstViewKundeStore.FocusedItem.Index).SubItems(0).Text
        bestellenFensterSender = "kunde_bestellen"
        FormBestellen.Show()
        Me.Enabled = False
    Catch ex As Exception
        MessageBox.Show("Bitte wählen Sie einen Eintrag aus der Liste aus", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End Try
End Sub

'SUCHEN

Private Sub cmdSuchen_Click(sender As Object, e As EventArgs) Handles cmdSuchen.Click
    If tabControlKunde.SelectedTab Is tabPageStore Then
        bearbeitenFensterSender = "suchen_lager_kunde"
    ElseIf tabControlKunde.SelectedTab Is tabPageVerkaufshistorie Then
        bearbeitenFensterSender = "suchen_verkaufshistorie_kunde"
    ElseIf tabControlKunde.SelectedTab Is tabPageOffeneBestellungen Then
        bearbeitenFensterSender = "suchen_offene_bestellungen_kunde"
    ElseIf tabControlKunde.SelectedTab Is tabPageKontoverlauf Then
        bearbeitenFensterSender = "suchen_kontoverlauf_kunde"
    End If
    FormBearbeiten.Show()
    Me.Enabled = False
End Sub

'ALLES ANZEIGEN

Private Sub cmdAllesAnzeigen_Click(sender As Object, e As EventArgs) Handles cmdAllesAnzeigen.Click
    If tabControlKunde.SelectedTab Is tabPageStore Then
        LagerAnzeigen("lager_erneut_laden")
    ElseIf tabControlKunde.SelectedTab Is tabPageKundenkonto Then
        KundenkontoAnzeigen("kundenkonto_erneut_laden")
    ElseIf tabControlKunde.SelectedTab Is tabPageVerkaufshistorie Then
        VerkaufshistorieAnzeigen("verkaufshistorie_erneut_laden")
    ElseIf tabControlKunde.SelectedTab Is tabPageOffeneBestellungen Then
        OffeneBestellungenAnzeigen("offene_bestellungen_erneut_laden")
    ElseIf tabControlKunde.SelectedTab Is tabPageKontoverlauf Then
        KontoverlaufAnzeigen("kontoverlauf_erneut_laden")
        KontoverlaufChartAnzeigen()
    End If
End Sub



Private Sub FormKunde_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
    Konsole.Close()
End Sub

End Class