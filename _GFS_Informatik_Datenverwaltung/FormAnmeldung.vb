Imports System.Data.OleDb 'Wird für das Kommunizieren mit der Datenbank benötigt

Public Class FormAnmeldung

    ' -- VARIABLENDEFINITION -- '

    Dim connection As New OleDbConnection 'Verbindung zwischen Programm und Datenbank
    Dim command As New OleDbCommand       'Beinhaltet SQL-Befehle, die an die Datenbank gesendet werden
    Dim reader As OleDbDataReader         'Um die ausgewählten Daten auslesen zu können

    ' -- VARIABLENDEFINITION ENDE -- '

Private Sub FormAnmeldung_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '{
        connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" & "Data Source=" & Application.StartupPath & "\Ressourcen\Access-Datei\GFS.accdb;"
        command.Connection = connection

        lblAnmeldeError.Text = ""
    '}
    End Sub

Private Sub CheckedChanged(sender As Object, e As EventArgs) Handles optVersand.CheckedChanged, optLagerlogistik.CheckedChanged, optKunde.CheckedChanged, optAdministrator.CheckedChanged
    '{
        If optKunde.Checked Then
            txtEmail.Enabled = True
            txtPasswort.Visible = True
            cmdRegistrieren.Visible = True
            txtEmail.Text = ""
            txtPasswort.Text = ""
            lblAnmeldeError.Text = ""
        ElseIf optVersand.Checked Then
            txtEmail.Enabled = False
            txtPasswort.Enabled = True
            cmdRegistrieren.Visible = False
            txtEmail.Text = ""
            txtPasswort.Text = ""
            lblAnmeldeError.Text = ""
        ElseIf optLagerlogistik.Checked Then
            txtEmail.Enabled = False
            txtPasswort.Enabled = True
            cmdRegistrieren.Visible = False
            txtEmail.Text = ""
            txtPasswort.Text = ""
            lblAnmeldeError.Text = ""
        ElseIf optAdministrator.Checked Then
            txtEmail.Enabled = False
            txtPasswort.Enabled = True
            cmdRegistrieren.Visible = False
            txtEmail.Text = ""
            txtPasswort.Text = ""
            lblAnmeldeError.Text = ""
        End If
    '}
    End Sub


    Dim email As String = "."
    Dim passwort As String = "."
    Public kunden_id As Integer

    Dim passwort_id As Integer
    Dim passwort_string As String = "."

Public Sub cmdAnmelden_Click(sender As Object, e As EventArgs) Handles cmdAnmelden.Click
        If optKunde.Checked Then
        '{
            If Not (String.IsNullOrWhiteSpace(txtEmail.Text)) Or (String.IsNullOrWhiteSpace(txtPasswort.Text)) Then
                    Try
                    '{
                        connection.Open()
                        command.CommandText = "SELECT kunden_email, kunden_passwort, kunden_id FROM kunden WHERE kunden_email = '" & txtEmail.Text & "' AND kunden_konto_aktiv = True"

                        reader = command.ExecuteReader

                        Do While reader.Read()
                        '{
                            email = reader("kunden_email")
                            passwort = reader("kunden_passwort")
                            kunden_id = reader("kunden_id")
                            kunden_id_module = kunden_id    'Damit andere Klassen darauf zugreifen können
                            lblAnmeldeError.Text = ""
                        '}
                        Loop
                        reader.Close()
                    '}
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    End Try
                End If
                connection.Close()

                If (txtEmail.Text = email) And (txtPasswort.Text = passwort) Then
                    'Neues Fenster öffnen, wo der Kunde sein Profil sieht und Bestellungen aufgeben kann
                    FormKunde.Show()
                    Me.Close()
                Else
                    lblAnmeldeError.Text = "Anmeldedaten inkorrekt"
                End If
            '}
        ElseIf optVersand.Checked Then
        '{
            If Not String.IsNullOrWhiteSpace(txtPasswort.Text) Then
                Try
                '{
                    connection.Open()
                    command.CommandText = "SELECT passwort_id, passwort FROM passwort WHERE passwort_id = 1"

                    reader = command.ExecuteReader()

                    Do While reader.Read()
                    '{
                        passwort_id = reader("passwort_id").ToString()
                        passwort_string = reader("passwort").ToString()
                        lblAnmeldeError.Text = ""
                    '}
                    Loop
                    reader.Close()
                '}
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                connection.Close()

                If txtPasswort.Text = passwort_string Then
                    'Neues Versandfenster öffnen
                    FormVersand.Show()
                    Me.Close()
                Else
                    lblAnmeldeError.Text = "Anmeldedaten inkorrekt"
                End If
            End If
        '}
        ElseIf optLagerlogistik.Checked Then
        '{
            If Not String.IsNullOrWhiteSpace(txtPasswort.Text) Then
                Try
                '{
                    connection.Open()
                    command.CommandText = "SELECT passwort_id, passwort FROM passwort WHERE passwort_id = 2"

                    reader = command.ExecuteReader()

                    Do While reader.Read()
                    '{
                        passwort_id = reader("passwort_id").ToString()
                        passwort_string = reader("passwort").ToString()
                        lblAnmeldeError.Text = ""
                    '}
                    Loop
                    reader.Close()
                '}
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                connection.Close()

                If txtPasswort.Text = passwort_string Then
                    'Neues Lagerlogistikfenster öffnen
                    FormLagerlogistik.Show()
                    Me.Close()
                Else
                    lblAnmeldeError.Text = "Anmeldedaten inkorrekt"
                End If
            End If
        '}
        ElseIf optAdministrator.Checked Then
        '{
            If Not String.IsNullOrWhiteSpace(txtPasswort.Text) Then
                    Try
                    '{
                        connection.Open()
                        command.CommandText = "SELECT passwort_id, passwort FROM passwort WHERE passwort_id = 3"

                        reader = command.ExecuteReader()

                        Do While reader.Read()
                        '{
                            passwort_id = reader("passwort_id").ToString()
                            passwort_string = reader("passwort").ToString()
                            lblAnmeldeError.Text = ""
                        '}
                        Loop
                        reader.Close()
                    '}
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    End Try
                End If
                connection.Close()

                If txtPasswort.Text = passwort_string Then
                    'Neues Administratorfenster öffnen
                    FormAdministrator.Show()
                    Me.Close()
                Else
                    lblAnmeldeError.Text = "Anmeldedaten inkorrekt"
                End If
            '}
        End If
End Sub

Private Sub cmdRegistrieren_Click(sender As Object, e As EventArgs) Handles cmdRegistrieren.Click
    bearbeitenFensterSender = "kunden_registrieren"
    FormBearbeiten.Show()
    Me.Close()
End Sub

End Class