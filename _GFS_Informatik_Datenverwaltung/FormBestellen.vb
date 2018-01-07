Imports System.Data.OleDb

Public Class FormBestellen

    ' -- VARIABLENDEFINITION -- '

    Dim connection As New OleDbConnection 'Verbindung zwischen Programm und Datenbank
    Dim command As New OleDbCommand       'Beinhaltet SQL-Befehle, die an die Datenbank gesendet werden
    Dim reader As OleDbDataReader         'Um die ausgewählten Daten auslesen zu können

    Dim artikelpreis As Double
    Dim gesamtpreis As Double
    Dim konto As Double

    ' -- VARIABLENDEFINITION ENDE -- '

Private Sub Bestellen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" & "Data Source=" & Application.StartupPath & "\Ressourcen\Access-Datei\GFS.accdb;"
    command.Connection = connection

    If bestellenFensterSender = "kunde_bestellen" Then
    '{
        Me.Text = "Bestellen [" & kunden_id_module & "]"

        lblArtikelnummerAnzeige.Text = artikel_ausgewaehlt

        Try
        '{
            connection.Open()
            command.CommandText = "SELECT lager_warenname, lager_waren_verkaufspreis, kunden_name, kunden_vorname, kunden_land, kunden_plz, kunden_stadt, kunden_straße, kunden_hausnummer, kunden_geld FROM lager, kunden WHERE kunden_id = " & kunden_id_module & " AND lager_waren_id = " & artikel_ausgewaehlt
            Konsole.txtBox.Text += command.CommandText & Environment.NewLine & Environment.NewLine
            ScrollToEnd()

            reader = command.ExecuteReader()

            Do While reader.Read()
            '{
                lblArtikelnameAnzeige.Text = reader("lager_warenname")
                lblArtikelpreisAnzeige.Text = reader("lager_waren_verkaufspreis") & " €"
                artikelpreis = reader("lager_waren_verkaufspreis")
                lblName.Text = reader("kunden_vorname") & " " & reader("kunden_name")
                lblStraßeHausnummer.Text = reader("kunden_straße") & " " & reader("kunden_hausnummer")
                lblPLZStadt.Text = reader("kunden_plz") & " " & reader("kunden_stadt")
                lblLand.Text = reader("kunden_land")
                lblKontoAnzeige.Text = reader("kunden_geld") & " €"
                konto = reader("kunden_geld")

                gesamtpreis = artikelpreis * numAnzahl.Value
                lblGesamtpreisAnzeige.Text = gesamtpreis & " €"
                '}
            Loop
            reader.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        '}
        End Try
        connection.Close()
    '}
    ElseIf bestellenFensterSender = "bestellen_lagerlogistik" Then
    '{
        Me.Text = "Bestellen"

        If Not artikel_ausgewaehlt = Nothing Then
        '{
            lblArtikelnummerAnzeige.Text = artikel_ausgewaehlt

            Try
            '{
                connection.Open()
                    command.CommandText = "SELECT lager_warenname, drittanbieter_verkaufspreis, firmen_name, firmen_land, firmen_plz, firmen_stadt, firmen_straße, firmen_hausnummer, firmen_budget FROM lager, drittanbieter, firma WHERE lager_waren_id = " & artikel_ausgewaehlt & " AND drittanbieter_waren_id = " & artikel_ausgewaehlt
                Konsole.txtBox.Text += command.CommandText & Environment.NewLine & Environment.NewLine
                ScrollToEnd()

                reader = command.ExecuteReader()

                Do While reader.Read
                '{
                    lblArtikelnameAnzeige.Text = reader("lager_warenname")
                        lblArtikelpreisAnzeige.Text = reader("drittanbieter_verkaufspreis") & " €"
                        artikelpreis = reader("drittanbieter_verkaufspreis")
                    lblName.Text = reader("firmen_name")
                    lblStraßeHausnummer.Text = reader("firmen_straße") & " " & reader("firmen_hausnummer")
                    lblPLZStadt.Text = reader("firmen_plz") & " " & reader("firmen_stadt")
                    lblLand.Text = reader("firmen_land").ToString()
                    lblKontoAnzeige.Text = reader("firmen_budget") & " €"
                    konto = reader("firmen_budget")

                    gesamtpreis = artikelpreis * numAnzahl.Value
                    lblGesamtpreisAnzeige.Text = gesamtpreis & " €"
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
    '}
    End If
End Sub

Private Sub numAnzahl_ValueChanged(sender As Object, e As EventArgs) Handles numAnzahl.ValueChanged
    If Me.Visible = True Then
        gesamtpreis = artikelpreis * numAnzahl.Value
        lblGesamtpreisAnzeige.Text = gesamtpreis & " €"
    End If
End Sub

Private Sub cmdBestellen_Click(sender As Object, e As EventArgs) Handles cmdBestellen.Click
    If bestellenFensterSender = "kunde_bestellen" Then
    '{
        If gesamtpreis <= konto Then
            Try
            '{
                connection.Open()
                command.CommandText = "INSERT into bestellung (bestellung_kunden_id, bestellung_waren_id, bestellung_anzahl, bestellung_offen) values ('" & kunden_id_module & "', '" & artikel_ausgewaehlt & "', '" & numAnzahl.Value & "', '1');"

                Konsole.txtBox.Text += command.CommandText & Environment.NewLine & Environment.NewLine
                ScrollToEnd()

                Dim anzahl As Integer = command.ExecuteNonQuery()
                If anzahl > 0 Then
                    MessageBox.Show("Vielen Dank für Ihre Bestellung!")
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            '}
            End Try
            connection.Close()
            Me.Close()
        Else
            MessageBox.Show("Sie sind leider zu arm, um sich das leisten zu können", "Armutswarnung", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    '}
    ElseIf bestellenFensterSender = "bestellen_lagerlogistik" Then
    '{
        If gesamtpreis <= konto Then
            Try
            '{
                connection.Open()

                '1. Lager auffüllen
                Dim anzahl As Integer
                command.CommandText = "SELECT lager_warenanzahl FROM lager WHERE lager_waren_id = " & artikel_ausgewaehlt
                Konsole.txtBox.Text += command.CommandText & Environment.NewLine & Environment.NewLine
                ScrollToEnd()
                reader = command.ExecuteReader()

                Do While reader.Read()
                    anzahl = reader("lager_warenanzahl")
                Loop
                reader.Close()
                Konsole.txtBox.Text += "Anzahl vorhanden: " & anzahl & Environment.NewLine & Environment.NewLine
                ScrollToEnd()

                command.CommandText = "UPDATE lager SET lager_warenanzahl = " & anzahl + numAnzahl.Value & " WHERE lager_waren_id = " & artikel_ausgewaehlt
                Konsole.txtBox.Text += command.CommandText & Environment.NewLine & Environment.NewLine
                ScrollToEnd()
                command.ExecuteNonQuery()

                '2. Geld abziehen
                Dim budgetNachRechnung As Integer = konto - gesamtpreis

                command.CommandText = "UPDATE firma SET firmen_budget = " & budgetNachRechnung
                Konsole.txtBox.Text += command.CommandText & Environment.NewLine & Environment.NewLine
                ScrollToEnd()
                command.ExecuteNonQuery()

                FormLagerlogistik.LagerAnzeigen("lager_erneut_laden")
                FormLagerlogistik.DrittanbieterAnzeigen("drittanbieter_erneut_laden")
                FormLagerlogistik.BudgetAnzeigen()  'Funktioniert nicht
                FormLagerlogistik.lblBudget.Text = "Budget: " & budgetNachRechnung & " €"

                '3. Budget in Budgetverlauf übertragen
                command.CommandText = "INSERT INTO budgetverlauf (budgetverlauf_wert, budgetverlauf_datum) values ('" & konto - gesamtpreis & "', '" & Date.Now & "')"
                Konsole.txtBox.Text += command.CommandText & Environment.NewLine & Environment.NewLine
                ScrollToEnd()
                command.ExecuteNonQuery()
            '}
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            connection.Close()
            Me.Close()
        Else
            MessageBox.Show("Sie sind leider zu arm, um sich das leisten zu können", "Armutswarnung", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    '}
    End If
End Sub

Private Sub FormBestellen_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
    FormKunde.Enabled = True
    FormLagerlogistik.Enabled = True
End Sub

End Class