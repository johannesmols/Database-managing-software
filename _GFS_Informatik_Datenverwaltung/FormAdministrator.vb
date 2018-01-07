Imports System.Data.OleDb 'Wird für das Kommunizieren mit der Datenbank benötigt
Imports System.Windows.Forms.DataVisualization.Charting 'Wird für Diagramme benötigt

Public Class FormAdministrator

    ' -- VARIABLENDEFINITION -- '

    Dim connection As New OleDbConnection 'Verbindung zwischen Programm und Datenbank
    Dim command As New OleDbCommand       'Beinhaltet SQL-Befehle, die an die Datenbank gesendet werden
    Dim reader As OleDbDataReader         'Um die ausgewählten Daten auslesen zu können

    Dim storeGeladen As Boolean = False
    Dim bestellungenGeladen As Boolean = False
    Dim verkaufshistorieGeladen As Boolean = False
    Dim kundenGeladen As Boolean = False
    Dim drittanbieterGeladen As Boolean = False
    Dim nachbestellungenGeladen As Boolean = False
    Dim passwoerterGeladen As Boolean = False
    Dim firmaGeladen As Boolean = False
    Dim budgetverlaufGeladen As Boolean = False
    Dim kontoverlaufGeladen As Boolean = False

    Dim ascendORdescend As Boolean = True 'Bestimmt, ob Auf oder Absteigend sortiert werden soll

    ' -- VARIABLENDEFINITION ENDE -- '

Private Sub FormAdministrator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" & "Data Source=" & Application.StartupPath & "\Ressourcen\Access-Datei\GFS.accdb;"
    command.Connection = connection
    'Konsole
    Konsole.txtBox.Text += connection.ConnectionString & Environment.NewLine & Environment.NewLine
    ScrollToEnd()
    'Konsole Ende


    AufDerKarteAnzeigenToolStripMenuItem.Enabled = False
    LagerAnzeigen(Nothing) 'Das Lager ist standardmäßig als erstes ausgewählt und muss geladen werden
    FirmenbudgetAnzeigen()
End Sub

'Wird ausgeführt, wenn ein anderer Reiter ausgewählt wird

Private Sub tabControl_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tabControlAdministrator.SelectedIndexChanged
    If tabControlAdministrator.SelectedTab Is tabPageLager Then
    '{
        cmdEinfuegen.Enabled = True
        cmdEinfuegen.BackColor = Color.MediumSeaGreen
        cmdAendern.Enabled = True
        cmdAendern.BackColor = Color.Khaki
        cmdLoeschen.Enabled = True
        cmdLoeschen.BackColor = Color.LightCoral
        cmdSuchen.Enabled = True
        cmdSuchen.BackColor = Color.LightBlue
        cmdAllesAnzeigen.Enabled = True
        cmdAllesAnzeigen.BackColor = Color.Wheat

        AufDerKarteAnzeigenToolStripMenuItem.Enabled = False

        If storeGeladen = False Then
            LagerAnzeigen(Nothing)
        Else
            LagerAnzeigen("lager_erneut_laden")
        End If

        Konsole.txtBox.Text += "Tab Page changed to " & tabControlAdministrator.SelectedTab.ToString() & Environment.NewLine & Environment.NewLine
        ScrollToEnd()
    '}
    ElseIf tabControlAdministrator.SelectedTab Is tabPageBestellungen Then
    '{
        cmdEinfuegen.Enabled = True
        cmdEinfuegen.BackColor = Color.MediumSeaGreen
        cmdAendern.Enabled = True
        cmdAendern.BackColor = Color.Khaki
        cmdLoeschen.Enabled = True
        cmdLoeschen.BackColor = Color.LightCoral
        cmdSuchen.Enabled = True
        cmdSuchen.BackColor = Color.LightBlue
        cmdAllesAnzeigen.Enabled = True
        cmdAllesAnzeigen.BackColor = Color.Wheat

        AufDerKarteAnzeigenToolStripMenuItem.Enabled = False

        If bestellungenGeladen = False Then
            BestellungenAnzeigen(Nothing)
        Else
            BestellungenAnzeigen("bestellungen_erneut_laden")
        End If

        Konsole.txtBox.Text += "Tab Page changed to " & tabControlAdministrator.SelectedTab.ToString() & Environment.NewLine & Environment.NewLine
        ScrollToEnd()
    '}
    ElseIf tabControlAdministrator.SelectedTab Is tabPageVerkaufshistorie Then
    '{
        cmdEinfuegen.Enabled = True
        cmdEinfuegen.BackColor = Color.MediumSeaGreen
        cmdAendern.Enabled = True
        cmdAendern.BackColor = Color.Khaki
        cmdLoeschen.Enabled = True
        cmdLoeschen.BackColor = Color.LightCoral
        cmdSuchen.Enabled = True
        cmdSuchen.BackColor = Color.LightBlue
        cmdAllesAnzeigen.Enabled = True
        cmdAllesAnzeigen.BackColor = Color.Wheat

        AufDerKarteAnzeigenToolStripMenuItem.Enabled = False

        If verkaufshistorieGeladen = False Then
            VerkaufshsitorieAnzeigen(Nothing)
        Else
            VerkaufshsitorieAnzeigen("verkaufshistorie_erneut_laden")
        End If

        Konsole.txtBox.Text += "Tab Page changed to " & tabControlAdministrator.SelectedTab.ToString() & Environment.NewLine & Environment.NewLine
        ScrollToEnd()
    '}
    ElseIf tabControlAdministrator.SelectedTab Is tabPageKunden Then
    '{
        cmdEinfuegen.Enabled = True
        cmdEinfuegen.BackColor = Color.MediumSeaGreen
        cmdAendern.Enabled = True
        cmdAendern.BackColor = Color.Khaki
        cmdLoeschen.Enabled = True
        cmdLoeschen.BackColor = Color.LightCoral
        cmdSuchen.Enabled = True
        cmdSuchen.BackColor = Color.LightBlue
        cmdAllesAnzeigen.Enabled = True
        cmdAllesAnzeigen.BackColor = Color.Wheat

        AufDerKarteAnzeigenToolStripMenuItem.Enabled = True

        If kundenGeladen = False Then
            KundenAnzeigen(Nothing)
        Else
            KundenAnzeigen("kundenkonto_erneut_laden")
        End If

        Konsole.txtBox.Text += "Tab Page changed to " & tabControlAdministrator.SelectedTab.ToString() & Environment.NewLine & Environment.NewLine
        ScrollToEnd()
    '}
    ElseIf tabControlAdministrator.SelectedTab Is tabPageDrittanbieter Then
    '{
        cmdEinfuegen.Enabled = True
        cmdEinfuegen.BackColor = Color.MediumSeaGreen
        cmdAendern.Enabled = True
        cmdAendern.BackColor = Color.Khaki
        cmdLoeschen.Enabled = True
        cmdLoeschen.BackColor = Color.LightCoral
        cmdSuchen.Enabled = True
        cmdSuchen.BackColor = Color.LightBlue
        cmdAllesAnzeigen.Enabled = True
        cmdAllesAnzeigen.BackColor = Color.Wheat

        AufDerKarteAnzeigenToolStripMenuItem.Enabled = False

        If drittanbieterGeladen = False Then
            DrittanbieterAnzeigen(Nothing)
        Else
            DrittanbieterAnzeigen("drittanbieter_erneut_laden")
        End If

        Konsole.txtBox.Text += "Tab Page changed to " & tabControlAdministrator.SelectedTab.ToString() & Environment.NewLine & Environment.NewLine
        ScrollToEnd()
    '}
    ElseIf tabControlAdministrator.SelectedTab Is tabPageNachbestellungen Then
    '{
        cmdEinfuegen.Enabled = True
        cmdEinfuegen.BackColor = Color.MediumSeaGreen
        cmdAendern.Enabled = True
        cmdAendern.BackColor = Color.Khaki
        cmdLoeschen.Enabled = True
        cmdLoeschen.BackColor = Color.LightCoral
        cmdSuchen.Enabled = True
        cmdSuchen.BackColor = Color.LightBlue
        cmdAllesAnzeigen.Enabled = True
        cmdAllesAnzeigen.BackColor = Color.Wheat

        AufDerKarteAnzeigenToolStripMenuItem.Enabled = False

        If nachbestellungenGeladen = False Then
            NachbestellungenAnzeigen(Nothing)
        Else
            NachbestellungenAnzeigen("nachbestellungen_erneut_laden")
        End If

        Konsole.txtBox.Text += "Tab Page changed to " & tabControlAdministrator.SelectedTab.ToString() & Environment.NewLine & Environment.NewLine
        ScrollToEnd()
    '}
    ElseIf tabControlAdministrator.SelectedTab Is tabPagePasswoerter Then
    '{
        cmdEinfuegen.Enabled = False
        cmdEinfuegen.BackColor = Color.FromKnownColor(KnownColor.Control)
        cmdAendern.Enabled = True
        cmdAendern.BackColor = Color.Khaki
        cmdLoeschen.Enabled = False
        cmdLoeschen.BackColor = Color.FromKnownColor(KnownColor.Control)
        cmdSuchen.Enabled = True
        cmdSuchen.BackColor = Color.LightBlue
        cmdAllesAnzeigen.Enabled = True
        cmdAllesAnzeigen.BackColor = Color.Wheat

        AufDerKarteAnzeigenToolStripMenuItem.Enabled = False

        If passwoerterGeladen = False Then
            PasswoerterAnzeigen(Nothing)
        Else
            PasswoerterAnzeigen("passwoerter_erneut_laden")
        End If

        Konsole.txtBox.Text += "Tab Page changed to " & tabControlAdministrator.SelectedTab.ToString() & Environment.NewLine & Environment.NewLine
        ScrollToEnd()
    '}
    ElseIf tabControlAdministrator.SelectedTab Is tabPageFirma Then
    '{
        cmdEinfuegen.Enabled = False
        cmdEinfuegen.BackColor = Color.FromKnownColor(KnownColor.Control)
        cmdAendern.Enabled = True
        cmdAendern.BackColor = Color.Khaki
        cmdLoeschen.Enabled = False
        cmdLoeschen.BackColor = Color.FromKnownColor(KnownColor.Control)
        cmdSuchen.Enabled = False
        cmdSuchen.BackColor = Color.FromKnownColor(KnownColor.Control)
        cmdAllesAnzeigen.Enabled = False
        cmdAllesAnzeigen.BackColor = Color.FromKnownColor(KnownColor.Control)

        AufDerKarteAnzeigenToolStripMenuItem.Enabled = True

        If firmaGeladen = False Then
            FirmaAnzeigen(Nothing)
        Else
            FirmaAnzeigen("firma_erneut_laden")
        End If

        Konsole.txtBox.Text += "Tab Page changed to " & tabControlAdministrator.SelectedTab.ToString() & Environment.NewLine & Environment.NewLine
        ScrollToEnd()
    '}
    ElseIf tabControlAdministrator.SelectedTab Is tabPageCustom Then
    '{
        cmdEinfuegen.Enabled = False
        cmdEinfuegen.BackColor = Color.FromKnownColor(KnownColor.Control)
        cmdAendern.Enabled = False
        cmdAendern.BackColor = Color.FromKnownColor(KnownColor.Control)
        cmdLoeschen.Enabled = False
        cmdLoeschen.BackColor = Color.FromKnownColor(KnownColor.Control)
        cmdSuchen.Enabled = False
        cmdSuchen.BackColor = Color.FromKnownColor(KnownColor.Control)
        cmdAllesAnzeigen.Enabled = False
        cmdAllesAnzeigen.BackColor = Color.FromKnownColor(KnownColor.Control)

        AufDerKarteAnzeigenToolStripMenuItem.Enabled = False

        Konsole.txtBox.Text += "Tab Page changed to " & tabControlAdministrator.SelectedTab.ToString() & Environment.NewLine & Environment.NewLine
        ScrollToEnd()

        'Easter-Egg
        txtCustomSQLEingabe.Text = "Select-Befehl hier eingeben"
        txtCustomSQLEingabe.Font = New Font("Consolas", 10, FontStyle.Regular)
        txtCustomSQLEingabe.ForeColor = Color.FromArgb(87, 87, 87)
        lstViewCustom.Items.Clear()
        lstViewCustom.Columns.Clear()
        firstClicked = False
    '}
    ElseIf tabControlAdministrator.SelectedTab Is tabPageBudgetverlauf Then
    '{
        cmdEinfuegen.Enabled = True
        cmdEinfuegen.BackColor = Color.MediumSeaGreen
        cmdAendern.Enabled = True
        cmdAendern.BackColor = Color.Khaki
        cmdLoeschen.Enabled = True
        cmdLoeschen.BackColor = Color.LightCoral
        cmdSuchen.Enabled = True
        cmdSuchen.BackColor = Color.LightBlue
        cmdAllesAnzeigen.Enabled = True
        cmdAllesAnzeigen.BackColor = Color.Wheat

        AufDerKarteAnzeigenToolStripMenuItem.Enabled = False

        If budgetverlaufGeladen = False Then
            BudgetverlaufAnzeigen(Nothing)
        Else
            BudgetverlaufAnzeigen("budgetverlauf_erneut_laden")
        End If
        BudgetverlaufChartAnzeigen()

        Konsole.txtBox.Text += "Tab Page changed to " & tabControlAdministrator.SelectedTab.ToString() & Environment.NewLine & Environment.NewLine
        ScrollToEnd()
    '}
    ElseIf tabControlAdministrator.SelectedTab Is tabPageKontoverlauf Then
    '{
        cmdEinfuegen.Enabled = True
        cmdEinfuegen.BackColor = Color.MediumSeaGreen
        cmdAendern.Enabled = True
        cmdAendern.BackColor = Color.Khaki
        cmdLoeschen.Enabled = True
        cmdLoeschen.BackColor = Color.LightCoral
        cmdSuchen.Enabled = True
        cmdSuchen.BackColor = Color.LightBlue
        cmdAllesAnzeigen.Enabled = True
        cmdAllesAnzeigen.BackColor = Color.Wheat

        AufDerKarteAnzeigenToolStripMenuItem.Enabled = False

        If kontoverlaufGeladen = False Then
            KontoverlaufAnzeigen(Nothing)
        Else
            KontoverlaufAnzeigen("kontoverlauf_erneut_laden")
        End If
        KontoverlaufChartAnzeigen()

        Konsole.txtBox.Text += "Tab Page changed to " & tabControlAdministrator.SelectedTab.ToString() & Environment.NewLine & Environment.NewLine
        ScrollToEnd()
    '}
    End If
End Sub

'ANZEIGEFUNKTIONEN

Public Sub FirmenbudgetAnzeigen()
    Try
    '{
        connection.Open()
        command.CommandText = "SELECT firmen_budget FROM firma"
        Konsole.txtBox.Text += command.CommandText & Environment.NewLine & Environment.NewLine
        ScrollToEnd()

        reader = command.ExecuteReader()

        Do While reader.Read()
        '{
            lblBudget.Text = "Budget: " & reader("firmen_budget") & " €"
        '}
        Loop
        reader.Close()
    '}
    Catch ex As Exception
        MessageBox.Show(ex.Message)
    End Try
    connection.Close()
End Sub

Public Sub LagerAnzeigen(befehl As String)
    If storeGeladen = False Or befehl = "lager_erneut_laden" Then
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
                lstViewLager.Columns.Add("Name", 300, HorizontalAlignment.Left)
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
            MessageBox.Show(ex.Message)
        End Try
        connection.Close()
    End If
End Sub

Public Sub VerkaufshsitorieAnzeigen(befehl As String)
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

Public Sub KundenAnzeigen(befehl As String)
    If kundenGeladen = False Or befehl = "kundenkonto_erneut_laden" Then
        Try
        '{
            lstViewKunden.Items.Clear()

            connection.Open()
            command.CommandText = "SELECT * FROM kunden WHERE kunden_konto_aktiv = True"
            Konsole.txtBox.Text += command.CommandText & Environment.NewLine & Environment.NewLine
            ScrollToEnd()

            If befehl <> "kundenkonto_erneut_laden" Then
            '{
                lstViewKunden.Columns.Add("Kundennummer", 50, HorizontalAlignment.Left)
                lstViewKunden.Columns.Add("Nachname", 100, HorizontalAlignment.Left)
                lstViewKunden.Columns.Add("Vorname", 100, HorizontalAlignment.Left)
                lstViewKunden.Columns.Add("E-Mail", 140, HorizontalAlignment.Left)
                lstViewKunden.Columns.Add("Telefonnummer", 100, HorizontalAlignment.Left)
                lstViewKunden.Columns.Add("Land", 100, HorizontalAlignment.Left)
                lstViewKunden.Columns.Add("PLZ", 50, HorizontalAlignment.Left)
                lstViewKunden.Columns.Add("Stadt", 100, HorizontalAlignment.Left)
                lstViewKunden.Columns.Add("Straße", 100, HorizontalAlignment.Left)
                lstViewKunden.Columns.Add("Hausnummer", 50, HorizontalAlignment.Left)
                lstViewKunden.Columns.Add("Passwort", 100, HorizontalAlignment.Left)
                lstViewKunden.Columns.Add("Geld", 100, HorizontalAlignment.Left)
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
                lstViewKunden.Items.Add(lstViewItem)
            '}
            Loop
            reader.Close()
            kundenGeladen = True
        '}
        Catch ex As Exception
        '{
            MessageBox.Show(ex.Message)
        '}
        End Try
        connection.Close()
    End If
End Sub

Public Sub DrittanbieterAnzeigen(befehl As String)
    If drittanbieterGeladen = False Or befehl = "drittanbieter_erneut_laden" Then
        Try
        '{
            lstViewDrittanbieter.Items.Clear()

            connection.Open()
            command.CommandText = "SELECT * FROM drittanbieter ORDER BY drittanbieter_waren_id"
            Konsole.txtBox.Text += command.CommandText & Environment.NewLine & Environment.NewLine
            ScrollToEnd()

            If befehl <> "drittanbieter_erneut_laden" Then
            '{
                lstViewDrittanbieter.Columns.Add("Warennummer", 100, HorizontalAlignment.Left)
                lstViewDrittanbieter.Columns.Add("Anbieternummer", 100, HorizontalAlignment.Left)
                lstViewDrittanbieter.Columns.Add("Verkaufspreis", 100, HorizontalAlignment.Left)
            '}
            End If

            reader = command.ExecuteReader()

            Do While reader.Read()
            '{
                Dim lstViewItem As New ListViewItem(reader("drittanbieter_waren_id").ToString())
                lstViewItem.SubItems.Add(reader("drittanbieter_anbieter_id").ToString())
                lstViewItem.SubItems.Add(reader("drittanbieter_verkaufspreis").ToString() & " €")
                lstViewDrittanbieter.Items.Add(lstViewItem)
            '}
            Loop
            reader.Close()
            drittanbieterGeladen = True
        '}
        Catch ex As Exception
            MessageBox.Show(ex.Message)
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

Public Sub PasswoerterAnzeigen(befehl As String)
     If passwoerterGeladen = False Or befehl = "passwoerter_erneut_laden" Then
        Try
        '{
            lstViewPasswoerter.Items.Clear()

            connection.Open()
            command.CommandText = "SELECT * FROM passwort"
            Konsole.txtBox.Text += command.CommandText & Environment.NewLine & Environment.NewLine
            ScrollToEnd()

            If befehl <> "passwoerter_erneut_laden" Then
            '{
                lstViewPasswoerter.Columns.Add("Passwortnummer", 100, HorizontalAlignment.Left)
                lstViewPasswoerter.Columns.Add("Passwort", 100, HorizontalAlignment.Left)
                lstViewPasswoerter.Columns.Add("Beschreibung", 250, HorizontalAlignment.Left)
            '}
            End If

            reader = command.ExecuteReader()

            Do While reader.Read()
            '{
                Dim lstViewItem As New ListViewItem(reader("passwort_id").ToString())
                lstViewItem.SubItems.Add(reader("passwort").ToString())
                lstViewItem.SubItems.Add(reader("passwort_beschreibung").ToString())
                lstViewPasswoerter.Items.Add(lstViewItem)
            '}
            Loop
            reader.Close()
            passwoerterGeladen = True
        '}
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        connection.Close()
     End If
End Sub

Public Sub FirmaAnzeigen(befehl As String)
    If firmaGeladen = False Or befehl = "firma_erneut_laden" Then
        Try
        '{
            lstViewFirma.Items.Clear()

            connection.Open()
            command.CommandText = "SELECT * FROM firma"
            Konsole.txtBox.Text += command.CommandText & Environment.NewLine & Environment.NewLine
            ScrollToEnd()

            If befehl <> "firma_erneut_laden" Then
                lstViewFirma.Columns.Add("Firmenbudget", 100, HorizontalAlignment.Left)
                lstViewFirma.Columns.Add("Firmenname", 100, HorizontalAlignment.Left)
                lstViewFirma.Columns.Add("Straße", 150, HorizontalAlignment.Left)
                lstViewFirma.Columns.Add("Hausnummer", 100, HorizontalAlignment.Left)
                lstViewFirma.Columns.Add("PLZ", 100, HorizontalAlignment.Left)
                lstViewFirma.Columns.Add("Stadt", 100, HorizontalAlignment.Left)
                lstViewFirma.Columns.Add("Land", 100, HorizontalAlignment.Left)
            End If

            reader = command.ExecuteReader()

            Do While reader.Read()
            '{
                Dim lstViewItem As New ListViewItem(reader("firmen_budget").ToString() & " €")
                lstViewItem.SubItems.Add(reader("firmen_name").ToString())
                lstViewItem.SubItems.Add(reader("firmen_straße").ToString())
                lstViewItem.SubItems.Add(reader("firmen_hausnummer").ToString())
                lstViewItem.SubItems.Add(reader("firmen_plz").ToString())
                lstViewItem.SubItems.Add(reader("firmen_stadt").ToString())
                lstViewItem.SubItems.Add(reader("firmen_land").ToString())
                lstViewFirma.Items.Add(lstViewItem)
            '}
            Loop
            reader.Close()
            firmaGeladen = True
        '}
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        connection.Close()
    End If
End Sub

Public Sub BudgetverlaufAnzeigen(befehl As String)
    If budgetverlaufGeladen = False Or befehl = "budgetverlauf_erneut_laden" Then
        Try
        '{
            lstViewBudgetverlauf.Items.Clear()

            connection.Open()
            command.CommandText = "SELECT * FROM budgetverlauf ORDER BY budgetverlauf_datum"
            Konsole.txtBox.Text += command.CommandText & Environment.NewLine & Environment.NewLine
            ScrollToEnd()

            If befehl <> "budgetverlauf_erneut_laden" Then
                lstViewBudgetverlauf.Columns.Add("ID", 50, HorizontalAlignment.Left)
                lstViewBudgetverlauf.Columns.Add("Wert", 100, HorizontalAlignment.Left)
                lstViewBudgetverlauf.Columns.Add("Datum", 130, HorizontalAlignment.Left)
            End If

            reader = command.ExecuteReader()

            Dim datum As DateTime

            Do While reader.Read()
            '{
                datum = Convert.ToDateTime(reader("budgetverlauf_datum"))
                datum.ToString("dd.MM.yyyy")

                Dim lstViewItem As New ListViewItem(reader("budgetverlauf_id").ToString())
                lstViewItem.SubItems.Add(reader("budgetverlauf_wert").ToString() & " €")
                lstViewItem.SubItems.Add(datum)
                lstViewBudgetverlauf.Items.Add(lstViewItem)
            '}
            Loop
            reader.Close()
            budgetverlaufGeladen = True
        '}
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        connection.Close()
    End If
End Sub

Public Sub BudgetverlaufChartAnzeigen()
    Try
    '{
        chartBudgetverlauf.Series.Clear()

        chartBudgetverlauf.Series.Add(New Series("Budget"))
        chartBudgetverlauf.Series(0).ChartType = SeriesChartType.Line
        chartBudgetverlauf.Series(0).Color = Color.Red
        chartBudgetverlauf.Series(0).BorderWidth = 3

        chartBudgetverlauf.Legends(0).Position = New ElementPosition(80, 8, 15, 5)
        chartBudgetverlauf.Legends(0).BorderColor = Color.Transparent
        chartBudgetverlauf.Legends(0).BorderWidth = 1

        chartBudgetverlauf.ChartAreas(0).AxisX.Title = "Datum"
        chartBudgetverlauf.ChartAreas(0).AxisX.TitleAlignment = StringAlignment.Far
        chartBudgetverlauf.ChartAreas(0).AxisX.TitleForeColor = Color.Red
        chartBudgetverlauf.ChartAreas(0).AxisX.IntervalType = DateTimeIntervalType.Auto
        chartBudgetverlauf.ChartAreas(0).AxisX.IntervalAutoMode = IntervalAutoMode.VariableCount
        chartBudgetverlauf.ChartAreas(0).AxisY.Title = "Budget in €"
        chartBudgetverlauf.ChartAreas(0).AxisY.TitleAlignment = StringAlignment.Far
        chartBudgetverlauf.ChartAreas(0).AxisY.TitleForeColor = Color.Red
        chartBudgetverlauf.ChartAreas(0).AxisX.MajorGrid.LineColor = Color.LightGray
        chartBudgetverlauf.ChartAreas(0).AxisY.MajorGrid.LineColor = Color.LightGray

        Dim benoetigtePunkte = lstViewBudgetverlauf.Items.Count

        For counter As Integer = 0 To benoetigtePunkte
            Dim pointX As Date = lstViewBudgetverlauf.Items(counter).SubItems(2).Text.Replace("00:00:00", "")
            Dim pointY As Integer = lstViewBudgetverlauf.Items(counter).SubItems(1).Text
            chartBudgetverlauf.Series(0).Points.AddXY(pointX, pointY)
        Next
    '}
    Catch ex As Exception
        'MsgBox(ex.Message)
        'Ruft nur unnötige Fehler auf
    End Try
End Sub

Public Sub KontoverlaufAnzeigen(befehl As String)
    If kontoverlaufGeladen = False Or befehl = "kontoverlauf_erneut_laden" Then
        Try
        '{
            lstViewKontoverlauf.Items.Clear()

            connection.Open()
            command.CommandText = "SELECT * FROM kontoverlauf ORDER BY kontoverlauf_datum"
            Konsole.txtBox.Text += command.CommandText & Environment.NewLine & Environment.NewLine
            ScrollToEnd()

            If befehl <> "kontoverlauf_erneut_laden" Then
                lstViewKontoverlauf.Columns.Add("ID", 50, HorizontalAlignment.Left)
                lstViewKontoverlauf.Columns.Add("Kunden ID", 50, HorizontalAlignment.Left)
                lstViewKontoverlauf.Columns.Add("Wert", 100, HorizontalAlignment.Left)
                lstViewKontoverlauf.Columns.Add("Datum", 125, HorizontalAlignment.Left)
            End If

            reader = command.ExecuteReader()

            Dim datum As DateTime

            Do While reader.Read()
            '{
                datum = Convert.ToDateTime(reader("kontoverlauf_datum"))
                datum.ToString("dd.MM.yyyy")

                Dim lstViewItem As New ListViewItem(reader("kontoverlauf_id").ToString())
                lstViewItem.SubItems.Add(reader("kontoverlauf_kunden_id").ToString())
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

        '1. Kunden gruppieren
        connection.Open()
        command.CommandText = "SELECT kontoverlauf_kunden_id FROM kontoverlauf GROUP BY kontoverlauf_kunden_id"

        Dim kunden_id_array As New ArrayList()

        reader = command.ExecuteReader()

        Do While reader.Read()
            kunden_id_array.Add(reader("kontoverlauf_kunden_id").ToString())    'Gibt alle vorkommenden Kunden einmal aus
        Loop
        reader.Close()
        connection.Close()

        chartKontoverlauf.Legends(0).Position = New ElementPosition(80, 8, 15, 10)
        chartKontoverlauf.Legends(0).BorderColor = Color.Transparent

        '2. Neue Series für jeden Kunden anlegen
        Dim random As New Random
        Dim randomColor As Color

        For counter As Integer = 0 To kunden_id_array.Count - 1
            chartKontoverlauf.Series.Add(New Series("Konto [" & kunden_id_array.Item(counter) & "]"))
            chartKontoverlauf.Series(counter).ChartType = SeriesChartType.Line

            randomColor = Color.FromArgb(random.Next(0, 256), random.Next(0, 256), random.Next(0, 256))
            chartKontoverlauf.Series(counter).Color = randomColor

            chartKontoverlauf.Series(counter).BorderWidth = 3   'Liniendicke
        Next

        '3. Aussehen anpassen
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

        '4. Werte einfügen
        Dim lstView As New ListView
        lstView.Columns.Add("id")
        lstView.Columns.Add("kunden_id")
        lstView.Columns.Add("wert")
        lstView.Columns.Add("datum")

        For counter As Integer = 0 To kunden_id_array.Count - 1
            connection.Open()
            command.CommandText = "SELECT * FROM kontoverlauf WHERE kontoverlauf_kunden_id = " & kunden_id_array.Item(counter) & " ORDER BY kontoverlauf_datum"
            reader = command.ExecuteReader()

            lstView.Items.Clear()
            Do While reader.Read()
                Dim lstViewItem As New ListViewItem(reader("kontoverlauf_wert").ToString())
                lstViewItem.SubItems.Add(reader("kontoverlauf_datum").ToString())
                lstView.Items.Add(lstViewItem)
            Loop
            reader.Close()
            connection.Close()

            For counter_2 As Integer = 0 To lstView.Items.Count - 1
                Dim pointX As Date = lstView.Items(counter_2).SubItems(1).Text.Replace("00:00:00", "")
                Dim pointY As Integer = lstView.Items(counter_2).SubItems(0).Text
                chartKontoverlauf.Series(counter).Points.AddXY(pointX, pointY)
            Next
        Next
    '}
    Catch ex As Exception
        MsgBox(ex.Message)
    End Try
    connection.Close()
End Sub

' SORTIERFUNKTION ---------------------------------------------

Private Sub Sortieren(Column As Integer, lstView As String)
    Try
    '{
        Dim name As String = Nothing 'Name der geklickten Spalte
        Dim selectedLstView As String = Nothing 'Als Parameter für die Sortierfunktion

        If lstView.Contains("Lager") Then
            selectedLstView = "lager"
            lstViewLager.Items.Clear()
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
        ElseIf lstView.Contains("Bestellung") Then
            selectedLstView = "bestellung"
            lstViewBestellungen.Items.Clear()
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
        ElseIf lstView.Contains("Verkaufshistorie") Then
            selectedLstView = "verkaufshistorie"
            lstViewVerkaufshistorie.Items.Clear()
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
        ElseIf lstView.Contains("Kunde") Then
            selectedLstView = "kunden"
            lstViewKunden.Items.Clear()
            Select Case Column
                Case 0
                    name = "kunden_id"
                Case 1
                    name = "kunden_name"
                Case 2
                    name = "kunden_vorname"
                Case 3
                    name = "kunden_email"
                Case 4
                    name = "kunden_telefonnummer"
                Case 5
                    name = "kunden_land"
                Case 6
                    name = "kunden_plz"
                Case 7
                    name = "kunden_stadt"
                Case 8
                    name = "kunden_straße"
                Case 9
                    name = "kunden_hausnummer"
                Case 10
                    name = "kunden_passwort"
                Case 11
                    name = "kunden_geld"
            End Select
        ElseIf lstView.Contains("Drittanbieter") Then
            selectedLstView = "drittanbieter"
            lstViewDrittanbieter.Items.Clear()
            Select Case Column
                Case 0
                    name = "drittanbieter_waren_id"
                Case 1
                    name = "drittanbieter_anbieter_id"
                Case 2
                    name = "drittanbieter_verkaufspreis"
            End Select
        ElseIf lstView.Contains("Nachbestellung") Then
            selectedLstView = "nachbestellungen"
            lstViewNachbestellungen.Items.Clear()
            Select Case Column
                Case 0
                    name = "nachbestellungen_id"
                Case 1
                    name = "nachbestellungen_waren_id"
                Case 2
                    name = "nachbestellungen_waren_anzahl"
            End Select
        ElseIf lstView.Contains("Passwörter") Then
            selectedLstView = "passwort"
            lstViewPasswoerter.Items.Clear()
            Select Case Column
                Case 0
                    name = "passwort_id"
                Case 1
                    name = "passwort"
                Case 2
                     name = "passwort_beschreibung"
            End Select
        ElseIf lstView.Contains("Firma") Then
            selectedLstView = "firma"
            lstViewFirma.Items.Clear()
            Select Case Column
                Case 0
                    name = "firmen_budget"
                Case 1
                    name = "firmen_name"
                Case 2
                    name = "firmen_straße"
                Case 3
                    name = "firmen_hausnummer"
                Case 4
                    name = "firmen_plz"
                Case 5
                    name = "firmen_stadt"
                Case 6
                    name = "firmen_land"
            End Select
        ElseIf lstView.Contains("Budgetverlauf") Then
            selectedLstView = "budgetverlauf"
            lstViewBudgetverlauf.Items.Clear()
            Select Case Column
                Case 0
                    name = "budgetverlauf_id"
                Case 1
                    name = "budgetverlauf_wert"
                Case 2
                    name = "budgetverlauf_datum"
            End Select
        ElseIf lstView.Contains("Kontoverlauf") Then
            selectedLstView = "kontoverlauf"
            lstViewKontoverlauf.Items.Clear()
            Select Case Column
                Case 0
                    name = "kontoverlauf_id"
                Case 1
                    name = "kontoverlauf_kunden_id"
                Case 2
                    name = "kontoverlauf_wert"
                Case 3
                    name = "kontoverlauf_datum"
            End Select
        Else
            MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        Konsole.txtBox.Text += "Column clicked: " & name & Environment.NewLine & Environment.NewLine
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
        ElseIf selectedLstView = "verkaufshistorie" Or selectedLstView = "drittanbieter" Or selectedLstView = "nachbestellungen" Or selectedLstView = "passwort" Or selectedLstView = "budgetverlauf" Or selectedLstView = "kontoverlauf" Then
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
        ElseIf selectedLstView = "kunden" Then
            If ascendORdescend = False Then
                command.CommandText = "SELECT * FROM " & selectedLstView & " WHERE kunden_konto_aktiv = True ORDER BY " & name
                ascendORdescend = True
            ElseIf ascendORdescend = True Then
                command.CommandText = "SELECT * FROM " & selectedLstView & " WHERE kunden_konto_aktiv = True ORDER BY " & name & " DESC"
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
            ElseIf selectedLstView = "kunden" Then
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
                lstViewKunden.Items.Add(lstViewItem)
            ElseIf selectedLstView = "drittanbieter" Then
                Dim lstViewItem As New ListViewItem(reader("drittanbieter_waren_id").ToString())
                lstViewItem.SubItems.Add(reader("drittanbieter_anbieter_id").ToString())
                lstViewItem.SubItems.Add(reader("drittanbieter_verkaufspreis").ToString() & " €")
                lstViewDrittanbieter.Items.Add(lstViewItem)
            ElseIf selectedLstView = "nachbestellungen" Then
                Dim lstViewItem As New ListViewItem(reader("nachbestellungen_id").ToString())
                lstViewItem.SubItems.Add(reader("nachbestellungen_waren_id").ToString())
                lstViewItem.SubItems.Add(reader("nachbestellungen_waren_anzahl").ToString())
                lstViewNachbestellungen.Items.Add(lstViewItem)
            ElseIf selectedLstView = "passwort" Then
                Dim lstViewItem As New ListViewItem(reader("passwort_id").ToString())
                lstViewItem.SubItems.Add(reader("passwort").ToString())
                lstViewItem.SubItems.Add(reader("passwort_beschreibung").ToString())
                lstViewPasswoerter.Items.Add(lstViewItem)
            ElseIf selectedLstView = "firma" Then
                Dim lstViewItem As New ListViewItem(reader("firmen_budget").ToString() & " €")
                lstViewItem.SubItems.Add(reader("firmen_name").ToString())
                lstViewItem.SubItems.Add(reader("firmen_straße").ToString())
                lstViewItem.SubItems.Add(reader("firmen_hausnummer").ToString())
                lstViewItem.SubItems.Add(reader("firmen_plz").ToString())
                lstViewItem.SubItems.Add(reader("firmen_stadt").ToString())
                lstViewItem.SubItems.Add(reader("firmen_land").ToString())
                lstViewFirma.Items.Add(lstViewItem)
            ElseIf selectedLstView = "budgetverlauf" Then
                Dim datum As DateTime
                datum = Convert.ToDateTime(reader("budgetverlauf_datum"))
                datum.ToString("dd.MM.yyyy")
                Dim lstViewItem As New ListViewItem(reader("budgetverlauf_id").ToString())
                lstViewItem.SubItems.Add(reader("budgetverlauf_wert").ToString() & " €")
                lstViewItem.SubItems.Add(datum)
                lstViewBudgetverlauf.Items.Add(lstViewItem)
            ElseIf selectedLstView = "kontoverlauf" Then
                Dim datum As DateTime
                datum = Convert.ToDateTime(reader("kontoverlauf_datum"))
                datum.ToString("dd.MM.yyyy")
                Dim lstViewItem As New ListViewItem(reader("kontoverlauf_id").ToString())
                lstViewItem.SubItems.Add(reader("kontoverlauf_kunden_id").ToString())
                lstViewItem.SubItems.Add(reader("kontoverlauf_wert").ToString())
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

Private Sub lstViewLager_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles lstViewLager.ColumnClick
    Sortieren(e.Column, tabControlAdministrator.SelectedTab.ToString())
End Sub

Private Sub lstViewBestellungen_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles lstViewBestellungen.ColumnClick
    Sortieren(e.Column, tabControlAdministrator.SelectedTab.ToString())
End Sub

Private Sub lstViewVerkaufshistorie_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles lstViewVerkaufshistorie.ColumnClick
    Sortieren(e.Column, tabControlAdministrator.SelectedTab.ToString())
End Sub

Private Sub lstViewKunden_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles lstViewKunden.ColumnClick
    Sortieren(e.Column, tabControlAdministrator.SelectedTab.ToString())
End Sub

Private Sub lstViewDrittanbieter_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles lstViewDrittanbieter.ColumnClick
    Sortieren(e.Column, tabControlAdministrator.SelectedTab.ToString())
End Sub

Private Sub lstViewNachbestellungen_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles lstViewNachbestellungen.ColumnClick
    Sortieren(e.Column, tabControlAdministrator.SelectedTab.ToString())
End Sub

Private Sub lstViewPasswoerter_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles lstViewPasswoerter.ColumnClick
    Sortieren(e.Column, tabControlAdministrator.SelectedTab.ToString())
End Sub

Private Sub lstViewFirma_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles lstViewFirma.ColumnClick
    Sortieren(e.Column, tabControlAdministrator.SelectedTab.ToString())
End Sub

Private Sub lstViewBudgetverlauf_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles lstViewBudgetverlauf.ColumnClick
    Sortieren(e.Column, tabControlAdministrator.SelectedTab.ToString())
End Sub

Private Sub lstViewKontoverlauf_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles lstViewKontoverlauf.ColumnClick
    Sortieren(e.Column, tabControlAdministrator.SelectedTab.ToString())
End Sub

'ENDE SORTIEREN -------------------------------------------------------------------------

'EINFÜGEN

Private Sub cmdEinfuegen_Click(sender As Object, e As EventArgs) Handles cmdEinfuegen.Click
    Try
    '{
        If tabControlAdministrator.SelectedTab Is tabPageLager Then
            bearbeitenFensterSender = "einfuegen_lager_admin"
            FormBearbeiten.Show()
            Me.Enabled = False
        ElseIf tabControlAdministrator.SelectedTab Is tabPageBestellungen Then
            bearbeitenFensterSender = "einfuegen_bestellungen_admin"
            FormBearbeiten.Show()
            Me.Enabled = False
        ElseIf tabControlAdministrator.SelectedTab Is tabPageVerkaufshistorie Then
            bearbeitenFensterSender = "einfuegen_verkaufshistorie_admin"
            FormBearbeiten.Show()
            Me.Enabled = False
        ElseIf tabControlAdministrator.SelectedTab Is tabPageKunden Then
            bearbeitenFensterSender = "einfuegen_kunden_admin"
            FormBearbeiten.Show()
            Me.Enabled = False
        ElseIf tabControlAdministrator.SelectedTab Is tabPageDrittanbieter Then
            bearbeitenFensterSender = "einfuegen_drittanbieter_admin"
            FormBearbeiten.Show()
            Me.Enabled = False
        ElseIf tabControlAdministrator.SelectedTab Is tabPageNachbestellungen Then
            bearbeitenFensterSender = "einfuegen_nachbestellungen_admin"
            FormBearbeiten.Show()
            Me.Enabled = False
        ElseIf tabControlAdministrator.SelectedTab Is tabPageBudgetverlauf Then
            bearbeitenFensterSender = "einfuegen_budgetverlauf_admin"
            FormBearbeiten.Show()
            Me.Enabled = False
        ElseIf tabControlAdministrator.SelectedTab Is tabPageKontoverlauf Then
            bearbeitenFensterSender = "einfuegen_kontoverlauf_admin"
            FormBearbeiten.Show()
            Me.Enabled = False
        End If
    '}
    Catch ex As Exception
        MsgBox("Bitte wählen Sie einen Eintrag aus der Liste aus")
    End Try
End Sub


'ÄNDERN

Private Sub cmdAendern_Click(sender As Object, e As EventArgs) Handles cmdAendern.Click
    Try
    '{
        If tabControlAdministrator.SelectedTab Is tabPageLager Then
            artikel_ausgewaehlt = lstViewLager.Items(lstViewLager.FocusedItem.Index).SubItems(0).Text
            bearbeitenFensterSender = "aendern_lager_admin"
            FormBearbeiten.Show()
            Me.Enabled = False
        ElseIf tabControlAdministrator.SelectedTab Is tabPageBestellungen Then
            artikel_ausgewaehlt = lstViewBestellungen.Items(lstViewBestellungen.FocusedItem.Index).SubItems(0).Text
            bearbeitenFensterSender = "aendern_bestellungen_admin"
            FormBearbeiten.Show()
            Me.Enabled = False
        ElseIf tabControlAdministrator.SelectedTab Is tabPageVerkaufshistorie Then
            artikel_ausgewaehlt = lstViewVerkaufshistorie.Items(lstViewVerkaufshistorie.FocusedItem.Index).SubItems(0).Text
            bearbeitenFensterSender = "aendern_verkaufshistorie_admin"
            FormBearbeiten.Show()
            Me.Enabled = False
        ElseIf tabControlAdministrator.SelectedTab Is tabPageKunden Then
            artikel_ausgewaehlt = lstViewKunden.Items(lstViewKunden.FocusedItem.Index).SubItems(0).Text
            bearbeitenFensterSender = "aendern_kunden_admin"
            FormBearbeiten.Show()
            Me.Enabled = False
        ElseIf tabControlAdministrator.SelectedTab Is tabPageDrittanbieter Then
            artikel_ausgewaehlt = lstViewDrittanbieter.Items(lstViewDrittanbieter.FocusedItem.Index).SubItems(0).Text
            bearbeitenFensterSender = "aendern_drittanbieter_admin"
            FormBearbeiten.Show()
            Me.Enabled = False
        ElseIf tabControlAdministrator.SelectedTab Is tabPageNachbestellungen Then
            artikel_ausgewaehlt = lstViewNachbestellungen.Items(lstViewNachbestellungen.FocusedItem.Index).SubItems(0).Text
            bearbeitenFensterSender = "aendern_nachbestellungen_admin"
            FormBearbeiten.Show()
            Me.Enabled = False
        ElseIf tabControlAdministrator.SelectedTab Is tabPagePasswoerter Then
            artikel_ausgewaehlt = lstViewPasswoerter.Items(lstViewPasswoerter.FocusedItem.Index).SubItems(0).Text
            bearbeitenFensterSender = "aendern_passwoerter_admin"
            FormBearbeiten.Show()
            Me.Enabled = False
        ElseIf tabControlAdministrator.SelectedTab Is tabPageFirma Then
            bearbeitenFensterSender = "aendern_firma_admin"
            FormBearbeiten.Show()
            Me.Enabled = False
        ElseIf tabControlAdministrator.SelectedTab Is tabPageBudgetverlauf Then
            artikel_ausgewaehlt = lstViewBudgetverlauf.Items(lstViewBudgetverlauf.FocusedItem.Index).SubItems(0).Text
            bearbeitenFensterSender = "aendern_budgetverlauf_admin"
            FormBearbeiten.Show()
            Me.Enabled = False
        ElseIf tabControlAdministrator.SelectedTab Is tabPageKontoverlauf Then
            artikel_ausgewaehlt = lstViewKontoverlauf.Items(lstViewKontoverlauf.FocusedItem.Index).SubItems(0).Text
            bearbeitenFensterSender = "aendern_kontoverlauf_admin"
            FormBearbeiten.Show()
            Me.Enabled = False
        End If
    '}
    Catch ex As Exception
        MessageBox.Show("Bitte wählen Sie einen Eintrag aus der Liste aus", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End Try
End Sub


'LÖSCHEN

Private Sub cmdLoeschen_Click(sender As Object, e As EventArgs) Handles cmdLoeschen.Click
     If tabControlAdministrator.SelectedTab Is tabPageLager Then
        Loeschen("lager")
     ElseIf tabControlAdministrator.SelectedTab Is tabPageBestellungen Then
        Loeschen("bestellung")
     ElseIf tabControlAdministrator.SelectedTab Is tabPageVerkaufshistorie Then
        Loeschen("verkaufshistorie")
     ElseIf tabControlAdministrator.SelectedTab Is tabPageKunden Then
        Loeschen("kunden")
     ElseIf tabControlAdministrator.SelectedTab Is tabPageDrittanbieter Then
        Loeschen("drittanbieter")
     ElseIf tabControlAdministrator.SelectedTab Is tabPageNachbestellungen Then
        Loeschen("nachbestellungen")
     ElseIf tabControlAdministrator.SelectedTab Is tabPageBudgetverlauf Then
        Loeschen("budgetverlauf")
     ElseIf tabControlAdministrator.SelectedTab Is tabPageKontoverlauf Then
        Loeschen("kontoverlauf")
     End If
End Sub

Private Sub Loeschen(sender As String)
    If sender = "lager" Or sender = "kunden" Or sender = "bestellung" Then
        'Einträge können durch AutoWert nicht gelöscht werden, müssen also deaktiviert werden
        Try
        '{
            connection.Open()

            If sender = "lager" Then
                command.CommandText = "UPDATE " & sender & " SET lager_aktiv = False WHERE lager_waren_id = " & lstViewLager.FocusedItem.Text
            ElseIf sender = "kunden" Then
                command.CommandText = "UPDATE " & sender & " SET kunden_konto_aktiv = False WHERE kunden_id = " & lstViewKunden.FocusedItem.Text
            ElseIf sender = "bestellung" Then
                command.CommandText = "UPDATE " & sender & " SET bestellung_offen = False WHERE bestellung_id = " & lstViewBestellungen.FocusedItem.Text
            End If
            Konsole.txtBox.Text += command.CommandText & Environment.NewLine & Environment.NewLine
            ScrollToEnd()

            Dim anzahl As Integer
            If MessageBox.Show("Sind Sie sich sicher?", "Löschen", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                anzahl = command.ExecuteNonQuery()
            End If

            connection.Close()

            If anzahl > 0 Then
                'Datensatz versteckt
                If sender = "lager" Then
                    LagerAnzeigen("lager_erneut_laden")
                ElseIf sender = "kunden" Then
                    KundenAnzeigen("kundenkonto_erneut_laden")
                ElseIf sender = "bestellung" Then
                    BestellungenAnzeigen("bestellungen_erneut_laden")
                End If
            End If
        '}
        Catch ex As Exception
            MessageBox.Show("Bitte wählen Sie einen Eintrag aus der Liste aus", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
        connection.Close()
    ElseIf sender = "verkaufshistorie" Or sender = "drittanbieter" Or sender = "nachbestellungen" Or sender = "budgetverlauf" Or sender = "kontoverlauf" Then
        Try
        '{
            connection.Open()

            If sender = "verkaufshistorie" Then
                command.CommandText = "DELETE FROM " & sender & " WHERE verkaufshistorie_bestellung_id = " & lstViewVerkaufshistorie.FocusedItem.Text
            ElseIf sender = "drittanbieter" Then
                command.CommandText = "DELETE FROM " & sender & " WHERE drittanbieter_waren_id = " & lstViewDrittanbieter.FocusedItem.Text
            ElseIf sender = "nachbestellungen" Then
                command.CommandText = "DELETE FROM " & sender & " WHERE nachbestellungen_id = " & lstViewNachbestellungen.FocusedItem.Text
            ElseIf sender = "budgetverlauf" Then
                command.CommandText = "DELETE FROM " & sender & " WHERE budgetverlauf_id = " & lstViewBudgetverlauf.FocusedItem.Text
            ElseIf sender = "kontoverlauf" Then
                command.CommandText = "DELETE FROM " & sender & " WHERE kontoverlauf_id = " & lstViewKontoverlauf.FocusedItem.Text
            End If
            Konsole.txtBox.Text += command.CommandText & Environment.NewLine & Environment.NewLine
            ScrollToEnd()

            Dim anzahl As Integer
            If MessageBox.Show("Sind Sie sich sicher?", "Löschen", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                anzahl = command.ExecuteNonQuery()
            End If

            connection.Close()

            If anzahl > 0 Then
                'Datensatz gelöscht
                If sender = "verkaufshistorie" Then
                    VerkaufshsitorieAnzeigen("verkaufshistorie_erneut_laden")
                ElseIf sender = "drittanbieter" Then
                    DrittanbieterAnzeigen("drittanbieter_erneut_laden")
                ElseIf sender = "nachbestellungen" Then
                    NachbestellungenAnzeigen("nachbestellungen_erneut_laden")
                ElseIf sender = "budgetverlauf" Then
                    BudgetverlaufAnzeigen("budgetverlauf_erneut_laden")
                    BudgetverlaufChartAnzeigen()
                ElseIf sender = "kontoverlauf" Then
                    KontoverlaufAnzeigen("kontoverlauf_erneut_laden")
                    KontoverlaufChartAnzeigen()
                End If
            End If
        '}
        Catch ex As Exception
            MessageBox.Show("Bitte wählen Sie einen Eintrag aus der Liste aus", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
        connection.Close()
    End If
End Sub


'SUCHEN

Private Sub cmdSuchen_Click(sender As Object, e As EventArgs) Handles cmdSuchen.Click
    If tabControlAdministrator.SelectedTab Is tabPageLager Then
        bearbeitenFensterSender = "suchen_lager_admin"
    ElseIf tabControlAdministrator.SelectedTab Is tabPageVerkaufshistorie Then
        bearbeitenFensterSender = "suchen_verkaufshistorie_admin"
    ElseIf tabControlAdministrator.SelectedTab Is tabPageBestellungen Then
        bearbeitenFensterSender = "suchen_bestellungen_admin"
    ElseIf tabControlAdministrator.SelectedTab Is tabPageKunden Then
        bearbeitenFensterSender = "suchen_kunden_admin"
    ElseIf tabControlAdministrator.SelectedTab Is tabPageDrittanbieter Then
        bearbeitenFensterSender = "suchen_drittanbieter_admin"
    ElseIf tabControlAdministrator.SelectedTab Is tabPageNachbestellungen Then
        bearbeitenFensterSender = "suchen_nachbestellungen_admin"
    ElseIf tabControlAdministrator.SelectedTab Is tabPagePasswoerter Then
        bearbeitenFensterSender = "suchen_passwort_admin"
    ElseIf tabControlAdministrator.SelectedTab Is tabPageBudgetverlauf Then
        bearbeitenFensterSender = "suchen_budgetverlauf_admin"
    End If
    FormBearbeiten.Show()
    Me.Enabled = False
End Sub


'TOOLSTRIP ITEMS

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

Private Sub AufDerKarteAnzeigenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AufDerKarteAnzeigenToolStripMenuItem.Click
    Try
    '{
        If tabControlAdministrator.SelectedTab Is tabPageKunden Then
        '{
            artikel_ausgewaehlt = lstViewKunden.FocusedItem.Index

            Dim url As String = "https://www.google.de/maps/search/"

            For counter As Integer = 5 To 9
                url += lstViewKunden.Items(artikel_ausgewaehlt).SubItems(counter).Text.ToString() & "+"
            Next
            If url.EndsWith("+") Then
                url = url.Substring(0, url.Length - 1)
            End If

            Process.Start(url)
        '}
        ElseIf tabControlAdministrator.SelectedTab Is tabPageFirma Then
        '{
            Dim url As String = "https://www.google.de/maps/search/"

            For counter As Integer = 2 To 6
                url += lstViewFirma.Items(0).SubItems(counter).Text.ToString() & "+"
            Next
            If url.EndsWith("+") Then
                url = url.Substring(0, url.Length - 1)
            End If

            Process.Start(url)
        '}
        End If
    '}
    Catch ex As Exception
        MessageBox.Show("Bitte wählen Sie einen Eintrag aus der Liste aus", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End Try
    connection.Close()
End Sub

'ALLES ANZEIGEN

Private Sub cmdAllesAnzeigen_Click(sender As Object, e As EventArgs) Handles cmdAllesAnzeigen.Click
    If tabControlAdministrator.SelectedTab Is tabPageLager Then
        LagerAnzeigen("lager_erneut_laden")
    ElseIf tabControlAdministrator.SelectedTab Is tabPageBestellungen Then
        BestellungenAnzeigen("bestellungen_erneut_laden")
    ElseIf tabControlAdministrator.SelectedTab Is tabPageVerkaufshistorie Then
        VerkaufshsitorieAnzeigen("verkaufshistorie_erneut_laden")
    ElseIf tabControlAdministrator.SelectedTab Is tabPageKunden Then
        KundenAnzeigen("kundenkonto_erneut_laden")
    ElseIf tabControlAdministrator.SelectedTab Is tabPageDrittanbieter Then
        DrittanbieterAnzeigen("drittanbieter_erneut_laden")
    ElseIf tabControlAdministrator.SelectedTab Is tabPageNachbestellungen Then
        NachbestellungenAnzeigen("nachbestellungen_erneut_laden")
    ElseIf tabControlAdministrator.SelectedTab Is tabPagePasswoerter Then
        PasswoerterAnzeigen("passwoerter_erneut_laden")
    ElseIf tabControlAdministrator.SelectedTab Is tabPageFirma Then
        FirmaAnzeigen("firma_erneut_laden")
    ElseIf tabControlAdministrator.SelectedTab Is tabPageBudgetverlauf Then
        BudgetverlaufAnzeigen("budgetverlauf_erneut_laden")
        BudgetverlaufChartAnzeigen()
    ElseIf tabControlAdministrator.SelectedTab Is tabPageKontoverlauf Then
        KontoverlaufAnzeigen("kontoverlauf_erneut_laden")
        KontoverlaufChartAnzeigen()
    End If
End Sub

'WIRD BEIM SCHLIEßEN DES FENSTERS AUFGERUFEN

Private Sub FormAdministrator_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
    Konsole.Close()
    End Sub

'CUSTOM SQL-EINGABE

Private Sub cmdAusfuehren_Click(sender As Object, e As EventArgs) Handles cmdAusfuehren.Click
    If firstClicked = False Then
        txtCustomSQLEingabe_Click(Nothing, Nothing)
        Exit Sub
    End If

    Try
        connection.Open()

        lstViewCustom.Items.Clear()
        lstViewCustom.Columns.Clear()

        '1. Insgesamt mögliche Spalten hinzufügen
        For counter As Integer = 0 To 54 'Insgesamt 55 mögliche Spalten
            lstViewCustom.Columns.Add(Nothing, 100, HorizontalAlignment.Left)
        Next

        Dim sqlString As String = txtCustomSQLEingabe.Text
        command.CommandText = sqlString
        Konsole.txtBox.Text += command.CommandText & Environment.NewLine & Environment.NewLine
        ScrollToEnd()

        If sqlString.ToUpper.StartsWith("SELECT") Then
            reader = command.ExecuteReader()
        End If

        '2. Spalten Namen zuordnen
        Do While reader.Read()
        '{
            Try
                For counter As Integer = 0 To 54
                    lstViewCustom.Columns(counter).Text = reader.GetName(counter)
                Next
            Catch ex As Exception
                'Es wird eine Out of Range Exception auftreten, da nicht für alle 55 Spalten ein Name angegeben ist (solange nicht alle Tabellen ausgewählt wurden). Deshalb darf hier nichts stehen, damit das Programm einfach weiter macht
            End Try
        '}
        Loop
        reader.Close()

        '3. Überflüssige Spalten verstecken (lassen sich nicht löschen)
        Try
            For counter As Integer = 0 To 54
                If lstViewCustom.Columns(counter).Text = Nothing Then
                    lstViewCustom.Columns(counter).Width = 0
                End If
            Next
        Catch ex As Exception
            'Out of Range Exception
        End Try

        command.CommandText = sqlString
        If sqlString.ToUpper.StartsWith("SELECT") Then
            reader = command.ExecuteReader()
        End If

        '4. Spalten zählen
        Dim columnCounter As Integer = 0
        For Each header As ColumnHeader In lstViewCustom.Columns
            If header.Width > 0 Then
                columnCounter += 1
            End If
        Next

        '5. Daten in die Tabelle einfügen
        Do While reader.Read()
            Try
                Dim title As String = reader.GetName(0).ToString()
                Dim lstViewItem As New ListViewItem(reader(title).ToString())
                For counter As Integer = 1 To columnCounter - 1
                    Dim title_2 As String = reader.GetName(counter).ToString()
                    lstViewItem.SubItems.Add(reader(title_2).ToString())
                Next
                lstViewCustom.Items.Add(lstViewItem)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Loop
        reader.Close()
    Catch ex As Exception
        MsgBox(ex.Message)
    End Try
    connection.Close()
End Sub

'Easter-Eggs

Dim firstClicked As Boolean = False

Private Sub txtCustomSQLEingabe_Click(sender As Object, e As EventArgs) Handles txtCustomSQLEingabe.Click
'{
    If Not firstClicked Then
        firstClicked = True
        txtCustomSQLEingabe.Text = Nothing
        txtCustomSQLEingabe.ForeColor = Color.Black
        lstViewCustom.Items.Clear()
        lstViewCustom.Columns.Clear()
    End If
'}
End Sub

Private Sub AccessDateiAnzeigenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AccessDateiAnzeigenToolStripMenuItem.Click
    Process.Start("explorer.exe", Application.StartupPath & "\Ressourcen\Access-Datei\")
End Sub

Private Sub InformationenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InformationenToolStripMenuItem.Click
    MessageBox.Show("© Johannes Mols 2014", "Informationen", MessageBoxButtons.OK, MessageBoxIcon.Information)
End Sub

End Class