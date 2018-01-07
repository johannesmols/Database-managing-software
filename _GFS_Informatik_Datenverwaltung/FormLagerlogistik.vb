Imports System.Data.OleDb 'Wird für das Kommunizieren mit der Datenbank benötigt

Public Class FormLagerlogistik

    ' -- VARIABLENDEFINITION -- '

    Dim connection As New OleDbConnection 'Verbindung zwischen Programm und Datenbank
    Dim command As New OleDbCommand       'Beinhaltet SQL-Befehle, die an die Datenbank gesendet werden
    Dim reader As OleDbDataReader         'Um die ausgewählten Daten auslesen zu können

    Dim lagerGeladen As Boolean = False
    Dim drittanbieterGeladen As Boolean = False
    Dim nachbestellungenGeladen As Boolean = False

    Dim ascendORdescend As Boolean = True 'Bestimmt, ob Auf oder Absteigend sortiert werden soll

    ' -- VARIABLENDEFINITION ENDE -- '

Private Sub FormLagerlogistik_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" & "Data Source=" & Application.StartupPath & "\Ressourcen\Access-Datei\GFS.accdb;"
    command.Connection = connection
    'Konsole
    Konsole.txtBox.Text += connection.ConnectionString & Environment.NewLine & Environment.NewLine
    ScrollToEnd()
    'Konsole Ende

    BudgetAnzeigen()
    LagerAnzeigen(Nothing)

    cmdAkzeptieren.BackColor = Color.FromKnownColor(KnownColor.Control)
    cmdAblehnen.BackColor = Color.FromKnownColor(KnownColor.Control)
End Sub

'Wird ausgeführt, wenn ein anderer Reiter ausgewählt wird

Private Sub tabControlLagerlogistik_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tabControlLagerlogistik.SelectedIndexChanged
    If tabControlLagerlogistik.SelectedTab Is tabPageLager Then
    '{
        cmdAkzeptieren.Enabled = False
        cmdAkzeptieren.BackColor = Color.FromKnownColor(KnownColor.Control)
        cmdAblehnen.Enabled = False
        cmdAblehnen.BackColor = Color.FromKnownColor(KnownColor.Control)
        cmdBestellen.Enabled = True
        cmdBestellen.BackColor = Color.Khaki
        cmdSuchen.Enabled = True
        cmdSuchen.BackColor = Color.LightBlue
        cmdAllesAnzeigen.Enabled = True
        cmdAllesAnzeigen.BackColor = Color.Wheat

        If lagerGeladen = False Then
            LagerAnzeigen(Nothing)
        Else
            LagerAnzeigen("lager_erneut_laden")
        End If

        Konsole.txtBox.Text += "Tab Page changed to " & tabControlLagerlogistik.SelectedTab.ToString() & Environment.NewLine & Environment.NewLine
        ScrollToEnd()
    '}
    ElseIf tabControlLagerlogistik.SelectedTab Is tabPageDrittanbieter Then
    '{
        cmdAkzeptieren.Enabled = False
        cmdAkzeptieren.BackColor = Color.FromKnownColor(KnownColor.Control)
        cmdAblehnen.Enabled = False
        cmdAblehnen.BackColor = Color.FromKnownColor(KnownColor.Control)
        cmdBestellen.Enabled = True
        cmdBestellen.BackColor = Color.Khaki
        cmdSuchen.Enabled = True
        cmdSuchen.BackColor = Color.LightBlue
        cmdAllesAnzeigen.Enabled = True
        cmdAllesAnzeigen.BackColor = Color.Wheat

        If drittanbieterGeladen = False Then
            DrittanbieterAnzeigen(Nothing)
        Else
            DrittanbieterAnzeigen("drittanbieter_erneut_laden")
        End If

        Konsole.txtBox.Text += "Tab Page changed to " & tabControlLagerlogistik.SelectedTab.ToString() & Environment.NewLine & Environment.NewLine
        ScrollToEnd()
    '}
    ElseIf tabControlLagerlogistik.SelectedTab Is tabPageNachbestellungen Then
    '{
        cmdAkzeptieren.Enabled = True
        cmdAkzeptieren.BackColor = Color.MediumSeaGreen
        cmdAblehnen.Enabled = True
        cmdAblehnen.BackColor = Color.LightCoral
        cmdBestellen.Enabled = False
        cmdBestellen.BackColor = Color.FromKnownColor(KnownColor.Control)
        cmdSuchen.Enabled = True
        cmdSuchen.BackColor = Color.LightBlue
        cmdAllesAnzeigen.Enabled = True
        cmdAllesAnzeigen.BackColor = Color.Wheat

        If nachbestellungenGeladen = False Then
            NachbestellungenAnzeigen(Nothing)
        Else
            NachbestellungenAnzeigen("nachbestellungen_erneut_laden")
        End If

        Konsole.txtBox.Text += "Tab Page changed to " & tabControlLagerlogistik.SelectedTab.ToString() & Environment.NewLine & Environment.NewLine
        ScrollToEnd()
    '}
    End If
End Sub

'ANZEIGEFUNKTIONEN

Public Sub BudgetAnzeigen()
    Try
    '{
        connection.Open()
        command.CommandText = "SELECT firmen_budget FROM firma"
        Konsole.txtBox.Text += command.CommandText & Environment.NewLine & Environment.NewLine
        ScrollToEnd()

        reader = command.ExecuteReader()

        Do While reader.Read()
        '{
            lblBudget.Text = "Budget: " & reader("firmen_budget").ToString() & " €"
        '}
        Loop
        reader.Close()
    '}
    Catch ex As Exception
        MsgBox(ex.Message)
    End Try
    connection.Close()
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

'SORTIERFUNKTION

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
        ElseIf selectedLstView = "drittanbieter" Or selectedLstView = "nachbestellungen" Then
            If ascendORdescend = False Then
                command.CommandText = "SELECT * FROM " & selectedLstView & " ORDER BY " & name
                ascendORdescend = True
            ElseIf ascendORdescend = True Then
                command.CommandText = "SELECT * FROM " & selectedLstView & " ORDER BY " & name & " DESC"
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

Private Sub lstViewLager_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles lstViewLager.ColumnClick
    Sortieren(e.Column, tabControlLagerlogistik.SelectedTab.ToString())
End Sub

Private Sub lstViewDrittanbieter_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles lstViewDrittanbieter.ColumnClick
    Sortieren(e.Column, tabControlLagerlogistik.SelectedTab.ToString())
End Sub

Private Sub lstViewNachbestellungen_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles lstViewNachbestellungen.ColumnClick
    Sortieren(e.Column, tabControlLagerlogistik.SelectedTab.ToString())
End Sub

'BUTTONS

Private Sub cmdSuchen_Click(sender As Object, e As EventArgs) Handles cmdSuchen.Click
    If tabControlLagerlogistik.SelectedTab Is tabPageLager Then
        bearbeitenFensterSender = "suchen_lager_lagerlogistik"
    ElseIf tabControlLagerlogistik.SelectedTab Is tabPageDrittanbieter Then
        bearbeitenFensterSender = "suchen_drittanbieter_lagerlogistik"
    ElseIf tabControlLagerlogistik.SelectedTab Is tabPageNachbestellungen Then
        bearbeitenFensterSender = "suchen_nachbestellungen_lagerlogistik"
    End If
    FormBearbeiten.Show()
    Me.Enabled = False
End Sub

Private Sub cmdAllesAnzeigen_Click(sender As Object, e As EventArgs) Handles cmdAllesAnzeigen.Click
    If tabControlLagerlogistik.SelectedTab Is tabPageLager Then
        LagerAnzeigen("lager_erneut_laden")
    ElseIf tabControlLagerlogistik.SelectedTab Is tabPageDrittanbieter Then
        DrittanbieterAnzeigen("drittanbieter_erneut_laden")
    ElseIf tabControlLagerlogistik.SelectedTab Is tabPageNachbestellungen Then
        NachbestellungenAnzeigen("nachbestellungen_erneut_laden")
    End If
End Sub

Private Sub cmdBestellen_Click(sender As Object, e As EventArgs) Handles cmdBestellen.Click
    artikel_ausgewaehlt = Nothing
    If tabControlLagerlogistik.SelectedTab Is tabPageLager Then
        Try
            artikel_ausgewaehlt = lstViewLager.Items(lstViewLager.FocusedItem.Index).SubItems(0).Text
            bestellenFensterSender = "bestellen_lagerlogistik"
            FormBestellen.Show()
            Me.Enabled = False
        Catch ex As Exception
            MessageBox.Show("Bitte wählen Sie einen Eintrag aus der Liste aus", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    ElseIf tabControlLagerlogistik.SelectedTab Is tabPageDrittanbieter Then
        Try
            artikel_ausgewaehlt = lstViewDrittanbieter.Items(lstViewDrittanbieter.FocusedItem.Index).SubItems(0).Text
            bestellenFensterSender = "bestellen_lagerlogistik"
            FormBestellen.Show()
            Me.Enabled = False
        Catch ex As Exception
            MessageBox.Show("Bitte wählen Sie einen Eintrag aus der Liste aus", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End If
End Sub

Private Sub cmdAkzeptieren_Click(sender As Object, e As EventArgs) Handles cmdAkzeptieren.Click
    Try
    '{
        connection.Open()
        command.CommandText = "SELECT lager_waren_verkaufspreis, firmen_budget FROM lager, firma WHERE lager_waren_id = " & lstViewNachbestellungen.Items(lstViewNachbestellungen.FocusedItem.Index).SubItems(1).Text
        Konsole.txtBox.Text += command.CommandText & Environment.NewLine & Environment.NewLine
        ScrollToEnd()
        reader = command.ExecuteReader()

        Dim verkaufspreis As Integer
        Dim budget As Integer

        Do While reader.Read()
        '{
            verkaufspreis = reader("lager_waren_verkaufspreis")
            budget = reader("firmen_budget")
        '}
        Loop
        reader.Close()

        Dim gesamtpreis As Integer = verkaufspreis * lstViewNachbestellungen.Items(lstViewNachbestellungen.FocusedItem.Index).SubItems(2).Text
        Konsole.txtBox.Text += "Gesamtpreis: " & gesamtpreis & Environment.NewLine & Environment.NewLine
        ScrollToEnd()

        If gesamtpreis <= budget Then
        '{
            If MessageBox.Show("Sind Sie sich sicher?", "Löschen", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            '{
                '1. Lager auffüllen
                command.CommandText = "SELECT lager_warenanzahl FROM lager WHERE lager_waren_id = " & lstViewNachbestellungen.Items(lstViewNachbestellungen.FocusedItem.Index).SubItems(1).Text
                Konsole.txtBox.Text += command.CommandText & Environment.NewLine & Environment.NewLine
                ScrollToEnd()
                reader = command.ExecuteReader()
                Dim vorhandeneAnzahl As Integer
                Do While reader.Read()
                    vorhandeneAnzahl = reader("lager_warenanzahl")
                Loop
                reader.Close()

                command.CommandText = "UPDATE lager SET lager_warenanzahl = '" & vorhandeneAnzahl + lstViewNachbestellungen.Items(lstViewNachbestellungen.FocusedItem.Index).SubItems(2).Text & "' WHERE lager_waren_id = " & lstViewNachbestellungen.Items(lstViewNachbestellungen.FocusedItem.Index).SubItems(1).Text
                Konsole.txtBox.Text += command.CommandText & Environment.NewLine & Environment.NewLine
                ScrollToEnd()
                command.ExecuteNonQuery()

                '2. Geld abbuchen
                command.CommandText = "UPDATE firma SET firmen_budget = '" & budget - gesamtpreis & "'"
                Konsole.txtBox.Text += command.CommandText & Environment.NewLine & Environment.NewLine
                ScrollToEnd()
                command.ExecuteNonQuery()

                '3. Kontostand auf Budgetverlauf übertragen
                command.CommandText = "INSERT INTO budgetverlauf (budgetverlauf_wert, budgetverlauf_datum) values ('" & budget - gesamtpreis & "', '" & Date.Now & "')"
                Konsole.txtBox.Text += command.CommandText & Environment.NewLine & Environment.NewLine
                ScrollToEnd()
                command.ExecuteNonQuery()

                '4. Nachbestellung löschen
                command.CommandText = "DELETE FROM nachbestellungen WHERE nachbestellungen_id = " & lstViewNachbestellungen.Items(lstViewNachbestellungen.FocusedItem.Index).SubItems(0).Text
                Konsole.txtBox.Text += command.CommandText & Environment.NewLine & Environment.NewLine
                ScrollToEnd()
                command.ExecuteNonQuery()
            '}
            End If
        '}
        End If
    '}
    Catch ex As Exception
        MessageBox.Show("Bitte wählen Sie einen Eintrag aus der Liste aus", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End Try
    connection.Close()
    BudgetAnzeigen()
    NachbestellungenAnzeigen("nachbestellungen_erneut_laden")
    LagerAnzeigen("lager_erneut_laden")
End Sub

Private Sub cmdAblehnen_Click(sender As Object, e As EventArgs) Handles cmdAblehnen.Click
        Try
        '{
            connection.Open()
            command.CommandText = "DELETE FROM nachbestellungen WHERE nachbestellungen_id = " & lstViewNachbestellungen.Items(lstViewNachbestellungen.FocusedItem.Index).SubItems(0).Text
            Konsole.txtBox.Text += command.CommandText & Environment.NewLine & Environment.NewLine
            ScrollToEnd()
            If MessageBox.Show("Sind Sie sich sicher?", "Löschen", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                command.ExecuteNonQuery()
            End If
        '}
        Catch ex As Exception
            MessageBox.Show("Bitte wählen Sie einen Eintrag aus der Liste aus", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
        connection.Close()
        NachbestellungenAnzeigen("nachbestellungen_erneut_laden")
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

'EVENTHANDLER

Private Sub FormLagerlogistik_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
    Konsole.Close()
End Sub

End Class