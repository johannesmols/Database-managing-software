<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAnmeldung
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAnmeldung))
        Me.tblLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblUeberschriftAnmeldung = New System.Windows.Forms.Label()
        Me.boxAccountauswahl = New System.Windows.Forms.GroupBox()
        Me.tblLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.optKunde = New System.Windows.Forms.RadioButton()
        Me.optVersand = New System.Windows.Forms.RadioButton()
        Me.optLagerlogistik = New System.Windows.Forms.RadioButton()
        Me.optAdministrator = New System.Windows.Forms.RadioButton()
        Me.boxAnmeldung = New System.Windows.Forms.GroupBox()
        Me.tblLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtPasswort = New System.Windows.Forms.TextBox()
        Me.cmdAnmelden = New System.Windows.Forms.Button()
        Me.lblAnmeldeError = New System.Windows.Forms.Label()
        Me.cmdRegistrieren = New System.Windows.Forms.Button()
        Me.tblLayoutPanel1.SuspendLayout
        Me.boxAccountauswahl.SuspendLayout
        Me.tblLayoutPanel2.SuspendLayout
        Me.boxAnmeldung.SuspendLayout
        Me.tblLayoutPanel3.SuspendLayout
        Me.SuspendLayout
        '
        'tblLayoutPanel1
        '
        Me.tblLayoutPanel1.ColumnCount = 2
        Me.tblLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.tblLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.tblLayoutPanel1.Controls.Add(Me.lblUeberschriftAnmeldung, 0, 0)
        Me.tblLayoutPanel1.Controls.Add(Me.boxAccountauswahl, 0, 1)
        Me.tblLayoutPanel1.Controls.Add(Me.boxAnmeldung, 1, 1)
        Me.tblLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.tblLayoutPanel1.Name = "tblLayoutPanel1"
        Me.tblLayoutPanel1.RowCount = 2
        Me.tblLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50!))
        Me.tblLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tblLayoutPanel1.Size = New System.Drawing.Size(584, 366)
        Me.tblLayoutPanel1.TabIndex = 0
        '
        'lblUeberschriftAnmeldung
        '
        Me.lblUeberschriftAnmeldung.AutoSize = true
        Me.lblUeberschriftAnmeldung.BackColor = System.Drawing.SystemColors.Control
        Me.tblLayoutPanel1.SetColumnSpan(Me.lblUeberschriftAnmeldung, 2)
        Me.lblUeberschriftAnmeldung.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblUeberschriftAnmeldung.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblUeberschriftAnmeldung.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblUeberschriftAnmeldung.Location = New System.Drawing.Point(3, 0)
        Me.lblUeberschriftAnmeldung.Name = "lblUeberschriftAnmeldung"
        Me.lblUeberschriftAnmeldung.Size = New System.Drawing.Size(578, 50)
        Me.lblUeberschriftAnmeldung.TabIndex = 0
        Me.lblUeberschriftAnmeldung.Text = "Melden Sie sich bitte mit ihrem Account an"
        Me.lblUeberschriftAnmeldung.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'boxAccountauswahl
        '
        Me.boxAccountauswahl.Controls.Add(Me.tblLayoutPanel2)
        Me.boxAccountauswahl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.boxAccountauswahl.Font = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.boxAccountauswahl.ForeColor = System.Drawing.Color.Red
        Me.boxAccountauswahl.Location = New System.Drawing.Point(3, 53)
        Me.boxAccountauswahl.Name = "boxAccountauswahl"
        Me.boxAccountauswahl.Size = New System.Drawing.Size(286, 310)
        Me.boxAccountauswahl.TabIndex = 1
        Me.boxAccountauswahl.TabStop = false
        Me.boxAccountauswahl.Text = "Accountauswahl"
        '
        'tblLayoutPanel2
        '
        Me.tblLayoutPanel2.ColumnCount = 1
        Me.tblLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tblLayoutPanel2.Controls.Add(Me.optKunde, 0, 1)
        Me.tblLayoutPanel2.Controls.Add(Me.optVersand, 0, 2)
        Me.tblLayoutPanel2.Controls.Add(Me.optLagerlogistik, 0, 3)
        Me.tblLayoutPanel2.Controls.Add(Me.optAdministrator, 0, 4)
        Me.tblLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblLayoutPanel2.Location = New System.Drawing.Point(3, 25)
        Me.tblLayoutPanel2.Name = "tblLayoutPanel2"
        Me.tblLayoutPanel2.RowCount = 7
        Me.tblLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10!))
        Me.tblLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35!))
        Me.tblLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35!))
        Me.tblLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35!))
        Me.tblLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35!))
        Me.tblLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100!))
        Me.tblLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20!))
        Me.tblLayoutPanel2.Size = New System.Drawing.Size(280, 282)
        Me.tblLayoutPanel2.TabIndex = 0
        '
        'optKunde
        '
        Me.optKunde.AutoSize = true
        Me.optKunde.Dock = System.Windows.Forms.DockStyle.Fill
        Me.optKunde.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optKunde.Location = New System.Drawing.Point(10, 13)
        Me.optKunde.Margin = New System.Windows.Forms.Padding(10, 3, 3, 3)
        Me.optKunde.Name = "optKunde"
        Me.optKunde.Size = New System.Drawing.Size(267, 29)
        Me.optKunde.TabIndex = 0
        Me.optKunde.TabStop = true
        Me.optKunde.Text = "Kunde"
        Me.optKunde.UseVisualStyleBackColor = true
        '
        'optVersand
        '
        Me.optVersand.AutoSize = true
        Me.optVersand.Dock = System.Windows.Forms.DockStyle.Fill
        Me.optVersand.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optVersand.Location = New System.Drawing.Point(10, 48)
        Me.optVersand.Margin = New System.Windows.Forms.Padding(10, 3, 3, 3)
        Me.optVersand.Name = "optVersand"
        Me.optVersand.Size = New System.Drawing.Size(267, 29)
        Me.optVersand.TabIndex = 1
        Me.optVersand.TabStop = true
        Me.optVersand.Text = "Versand"
        Me.optVersand.UseVisualStyleBackColor = true
        '
        'optLagerlogistik
        '
        Me.optLagerlogistik.AutoSize = true
        Me.optLagerlogistik.Dock = System.Windows.Forms.DockStyle.Fill
        Me.optLagerlogistik.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optLagerlogistik.Location = New System.Drawing.Point(10, 83)
        Me.optLagerlogistik.Margin = New System.Windows.Forms.Padding(10, 3, 3, 3)
        Me.optLagerlogistik.Name = "optLagerlogistik"
        Me.optLagerlogistik.Size = New System.Drawing.Size(267, 29)
        Me.optLagerlogistik.TabIndex = 2
        Me.optLagerlogistik.TabStop = true
        Me.optLagerlogistik.Text = "Lagerlogistik"
        Me.optLagerlogistik.UseVisualStyleBackColor = true
        '
        'optAdministrator
        '
        Me.optAdministrator.AutoSize = true
        Me.optAdministrator.Dock = System.Windows.Forms.DockStyle.Fill
        Me.optAdministrator.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optAdministrator.Location = New System.Drawing.Point(10, 118)
        Me.optAdministrator.Margin = New System.Windows.Forms.Padding(10, 3, 3, 3)
        Me.optAdministrator.Name = "optAdministrator"
        Me.optAdministrator.Size = New System.Drawing.Size(267, 29)
        Me.optAdministrator.TabIndex = 3
        Me.optAdministrator.TabStop = true
        Me.optAdministrator.Text = "Administrator"
        Me.optAdministrator.UseVisualStyleBackColor = true
        '
        'boxAnmeldung
        '
        Me.boxAnmeldung.BackColor = System.Drawing.SystemColors.Control
        Me.boxAnmeldung.Controls.Add(Me.tblLayoutPanel3)
        Me.boxAnmeldung.Dock = System.Windows.Forms.DockStyle.Fill
        Me.boxAnmeldung.Font = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.boxAnmeldung.ForeColor = System.Drawing.Color.Red
        Me.boxAnmeldung.Location = New System.Drawing.Point(295, 53)
        Me.boxAnmeldung.Name = "boxAnmeldung"
        Me.boxAnmeldung.Size = New System.Drawing.Size(286, 310)
        Me.boxAnmeldung.TabIndex = 2
        Me.boxAnmeldung.TabStop = false
        Me.boxAnmeldung.Text = "Anmeldung"
        '
        'tblLayoutPanel3
        '
        Me.tblLayoutPanel3.ColumnCount = 2
        Me.tblLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25!))
        Me.tblLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75!))
        Me.tblLayoutPanel3.Controls.Add(Me.lblEmail, 0, 1)
        Me.tblLayoutPanel3.Controls.Add(Me.Label1, 0, 2)
        Me.tblLayoutPanel3.Controls.Add(Me.txtEmail, 1, 1)
        Me.tblLayoutPanel3.Controls.Add(Me.txtPasswort, 1, 2)
        Me.tblLayoutPanel3.Controls.Add(Me.cmdAnmelden, 0, 3)
        Me.tblLayoutPanel3.Controls.Add(Me.lblAnmeldeError, 0, 5)
        Me.tblLayoutPanel3.Controls.Add(Me.cmdRegistrieren, 0, 8)
        Me.tblLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblLayoutPanel3.Location = New System.Drawing.Point(3, 25)
        Me.tblLayoutPanel3.Name = "tblLayoutPanel3"
        Me.tblLayoutPanel3.RowCount = 9
        Me.tblLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10!))
        Me.tblLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30!))
        Me.tblLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30!))
        Me.tblLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35!))
        Me.tblLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10!))
        Me.tblLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40!))
        Me.tblLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20!))
        Me.tblLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70!))
        Me.tblLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20!))
        Me.tblLayoutPanel3.Size = New System.Drawing.Size(280, 282)
        Me.tblLayoutPanel3.TabIndex = 0
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = true
        Me.lblEmail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblEmail.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblEmail.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblEmail.Location = New System.Drawing.Point(10, 10)
        Me.lblEmail.Margin = New System.Windows.Forms.Padding(10, 0, 3, 0)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(57, 30)
        Me.lblEmail.TabIndex = 0
        Me.lblEmail.Text = "E-Mail: "
        Me.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(10, 40)
        Me.Label1.Margin = New System.Windows.Forms.Padding(10, 0, 3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 30)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Passwort: "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtEmail
        '
        Me.txtEmail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtEmail.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtEmail.Location = New System.Drawing.Point(73, 13)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(3, 3, 10, 3)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(197, 25)
        Me.txtEmail.TabIndex = 2
        '
        'txtPasswort
        '
        Me.txtPasswort.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtPasswort.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtPasswort.Location = New System.Drawing.Point(73, 43)
        Me.txtPasswort.Margin = New System.Windows.Forms.Padding(3, 3, 10, 3)
        Me.txtPasswort.Name = "txtPasswort"
        Me.txtPasswort.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPasswort.Size = New System.Drawing.Size(197, 25)
        Me.txtPasswort.TabIndex = 3
        '
        'cmdAnmelden
        '
        Me.cmdAnmelden.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.tblLayoutPanel3.SetColumnSpan(Me.cmdAnmelden, 2)
        Me.cmdAnmelden.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdAnmelden.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAnmelden.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cmdAnmelden.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdAnmelden.Location = New System.Drawing.Point(10, 73)
        Me.cmdAnmelden.Margin = New System.Windows.Forms.Padding(10, 3, 10, 3)
        Me.cmdAnmelden.Name = "cmdAnmelden"
        Me.cmdAnmelden.Size = New System.Drawing.Size(260, 29)
        Me.cmdAnmelden.TabIndex = 4
        Me.cmdAnmelden.Text = "Anmelden"
        Me.cmdAnmelden.UseVisualStyleBackColor = false
        '
        'lblAnmeldeError
        '
        Me.lblAnmeldeError.AutoSize = true
        Me.tblLayoutPanel3.SetColumnSpan(Me.lblAnmeldeError, 2)
        Me.lblAnmeldeError.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblAnmeldeError.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblAnmeldeError.Location = New System.Drawing.Point(3, 115)
        Me.lblAnmeldeError.Name = "lblAnmeldeError"
        Me.lblAnmeldeError.Size = New System.Drawing.Size(274, 40)
        Me.lblAnmeldeError.TabIndex = 5
        Me.lblAnmeldeError.Text = "-"
        Me.lblAnmeldeError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmdRegistrieren
        '
        Me.cmdRegistrieren.BackColor = System.Drawing.SystemColors.Control
        Me.tblLayoutPanel3.SetColumnSpan(Me.cmdRegistrieren, 2)
        Me.cmdRegistrieren.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdRegistrieren.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdRegistrieren.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cmdRegistrieren.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmdRegistrieren.Location = New System.Drawing.Point(3, 248)
        Me.cmdRegistrieren.Name = "cmdRegistrieren"
        Me.cmdRegistrieren.Size = New System.Drawing.Size(274, 31)
        Me.cmdRegistrieren.TabIndex = 6
        Me.cmdRegistrieren.Text = "Noch kein Konto? Hier registrieren"
        Me.cmdRegistrieren.UseVisualStyleBackColor = false
        Me.cmdRegistrieren.Visible = false
        '
        'FormAnmeldung
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 366)
        Me.Controls.Add(Me.tblLayoutPanel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(600, 400)
        Me.MinimumSize = New System.Drawing.Size(600, 400)
        Me.Name = "FormAnmeldung"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Anmeldung"
        Me.tblLayoutPanel1.ResumeLayout(false)
        Me.tblLayoutPanel1.PerformLayout
        Me.boxAccountauswahl.ResumeLayout(false)
        Me.tblLayoutPanel2.ResumeLayout(false)
        Me.tblLayoutPanel2.PerformLayout
        Me.boxAnmeldung.ResumeLayout(false)
        Me.tblLayoutPanel3.ResumeLayout(false)
        Me.tblLayoutPanel3.PerformLayout
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents tblLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblUeberschriftAnmeldung As System.Windows.Forms.Label
    Friend WithEvents boxAccountauswahl As System.Windows.Forms.GroupBox
    Friend WithEvents boxAnmeldung As System.Windows.Forms.GroupBox
    Friend WithEvents tblLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents optKunde As System.Windows.Forms.RadioButton
    Friend WithEvents optVersand As System.Windows.Forms.RadioButton
    Friend WithEvents optLagerlogistik As System.Windows.Forms.RadioButton
    Friend WithEvents optAdministrator As System.Windows.Forms.RadioButton
    Friend WithEvents tblLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtPasswort As System.Windows.Forms.TextBox
    Friend WithEvents cmdAnmelden As System.Windows.Forms.Button
    Friend WithEvents lblAnmeldeError As System.Windows.Forms.Label
    Friend WithEvents cmdRegistrieren As System.Windows.Forms.Button

End Class
