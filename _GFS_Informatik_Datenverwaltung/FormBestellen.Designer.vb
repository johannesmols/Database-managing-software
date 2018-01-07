<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBestellen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormBestellen))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblKontoAnzeige = New System.Windows.Forms.Label()
        Me.lblKonto = New System.Windows.Forms.Label()
        Me.lblLand = New System.Windows.Forms.Label()
        Me.lblPLZStadt = New System.Windows.Forms.Label()
        Me.lblStraßeHausnummer = New System.Windows.Forms.Label()
        Me.lblGesamtpreisAnzeige = New System.Windows.Forms.Label()
        Me.lblArtikelpreisAnzeige = New System.Windows.Forms.Label()
        Me.lblArtikelnameAnzeige = New System.Windows.Forms.Label()
        Me.lblGesamtpreis = New System.Windows.Forms.Label()
        Me.lblArtikelpreis = New System.Windows.Forms.Label()
        Me.lblArtikelanzahl = New System.Windows.Forms.Label()
        Me.lblArtikelname = New System.Windows.Forms.Label()
        Me.lblUeberschriftBestellen = New System.Windows.Forms.Label()
        Me.lblArtikelnummer = New System.Windows.Forms.Label()
        Me.lblLieferadresse = New System.Windows.Forms.Label()
        Me.lblArtikelnummerAnzeige = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.numAnzahl = New System.Windows.Forms.NumericUpDown()
        Me.cmdBestellen = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.numAnzahl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lblKontoAnzeige, 3, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.lblKonto, 2, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.lblLand, 4, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.lblPLZStadt, 4, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.lblStraßeHausnummer, 4, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.lblGesamtpreisAnzeige, 1, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.lblArtikelpreisAnzeige, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.lblArtikelnameAnzeige, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.lblGesamtpreis, 0, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.lblArtikelpreis, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.lblArtikelanzahl, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.lblArtikelname, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.lblUeberschriftBestellen, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblArtikelnummer, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lblLieferadresse, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lblArtikelnummerAnzeige, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lblName, 3, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.numAnzahl, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.cmdBestellen, 0, 9)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 11
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(584, 264)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'lblKontoAnzeige
        '
        Me.lblKontoAnzeige.AutoSize = True
        Me.lblKontoAnzeige.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblKontoAnzeige.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKontoAnzeige.ForeColor = System.Drawing.Color.Red
        Me.lblKontoAnzeige.Location = New System.Drawing.Point(410, 180)
        Me.lblKontoAnzeige.Name = "lblKontoAnzeige"
        Me.lblKontoAnzeige.Size = New System.Drawing.Size(171, 30)
        Me.lblKontoAnzeige.TabIndex = 18
        Me.lblKontoAnzeige.Text = "int"
        Me.lblKontoAnzeige.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblKonto
        '
        Me.lblKonto.AutoSize = True
        Me.lblKonto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblKonto.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKonto.Location = New System.Drawing.Point(294, 180)
        Me.lblKonto.Name = "lblKonto"
        Me.lblKonto.Size = New System.Drawing.Size(110, 30)
        Me.lblKonto.TabIndex = 17
        Me.lblKonto.Text = "Konto:"
        Me.lblKonto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblLand
        '
        Me.lblLand.AutoSize = True
        Me.lblLand.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblLand.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLand.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblLand.Location = New System.Drawing.Point(410, 140)
        Me.lblLand.Name = "lblLand"
        Me.lblLand.Size = New System.Drawing.Size(171, 30)
        Me.lblLand.TabIndex = 15
        Me.lblLand.Text = "Land"
        Me.lblLand.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPLZStadt
        '
        Me.lblPLZStadt.AutoSize = True
        Me.lblPLZStadt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblPLZStadt.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPLZStadt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblPLZStadt.Location = New System.Drawing.Point(410, 110)
        Me.lblPLZStadt.Name = "lblPLZStadt"
        Me.lblPLZStadt.Size = New System.Drawing.Size(171, 30)
        Me.lblPLZStadt.TabIndex = 14
        Me.lblPLZStadt.Text = "PLZ/Stadt"
        Me.lblPLZStadt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblStraßeHausnummer
        '
        Me.lblStraßeHausnummer.AutoSize = True
        Me.lblStraßeHausnummer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblStraßeHausnummer.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStraßeHausnummer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblStraßeHausnummer.Location = New System.Drawing.Point(410, 80)
        Me.lblStraßeHausnummer.Name = "lblStraßeHausnummer"
        Me.lblStraßeHausnummer.Size = New System.Drawing.Size(171, 30)
        Me.lblStraßeHausnummer.TabIndex = 13
        Me.lblStraßeHausnummer.Text = "Straße/Hausnummer"
        Me.lblStraßeHausnummer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblGesamtpreisAnzeige
        '
        Me.lblGesamtpreisAnzeige.AutoSize = True
        Me.lblGesamtpreisAnzeige.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblGesamtpreisAnzeige.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGesamtpreisAnzeige.ForeColor = System.Drawing.Color.Red
        Me.lblGesamtpreisAnzeige.Location = New System.Drawing.Point(178, 180)
        Me.lblGesamtpreisAnzeige.Name = "lblGesamtpreisAnzeige"
        Me.lblGesamtpreisAnzeige.Size = New System.Drawing.Size(110, 30)
        Me.lblGesamtpreisAnzeige.TabIndex = 11
        Me.lblGesamtpreisAnzeige.Text = "int"
        Me.lblGesamtpreisAnzeige.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblArtikelpreisAnzeige
        '
        Me.lblArtikelpreisAnzeige.AutoSize = True
        Me.lblArtikelpreisAnzeige.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblArtikelpreisAnzeige.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArtikelpreisAnzeige.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblArtikelpreisAnzeige.Location = New System.Drawing.Point(178, 140)
        Me.lblArtikelpreisAnzeige.Name = "lblArtikelpreisAnzeige"
        Me.lblArtikelpreisAnzeige.Size = New System.Drawing.Size(110, 30)
        Me.lblArtikelpreisAnzeige.TabIndex = 10
        Me.lblArtikelpreisAnzeige.Text = "int"
        Me.lblArtikelpreisAnzeige.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblArtikelnameAnzeige
        '
        Me.lblArtikelnameAnzeige.AutoSize = True
        Me.lblArtikelnameAnzeige.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblArtikelnameAnzeige.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArtikelnameAnzeige.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblArtikelnameAnzeige.Location = New System.Drawing.Point(178, 80)
        Me.lblArtikelnameAnzeige.Name = "lblArtikelnameAnzeige"
        Me.lblArtikelnameAnzeige.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblArtikelnameAnzeige.Size = New System.Drawing.Size(110, 30)
        Me.lblArtikelnameAnzeige.TabIndex = 8
        Me.lblArtikelnameAnzeige.Text = "string"
        Me.lblArtikelnameAnzeige.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblGesamtpreis
        '
        Me.lblGesamtpreis.AutoSize = True
        Me.lblGesamtpreis.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblGesamtpreis.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGesamtpreis.Location = New System.Drawing.Point(3, 180)
        Me.lblGesamtpreis.Name = "lblGesamtpreis"
        Me.lblGesamtpreis.Size = New System.Drawing.Size(169, 30)
        Me.lblGesamtpreis.TabIndex = 5
        Me.lblGesamtpreis.Text = "Gesamtpreis:"
        Me.lblGesamtpreis.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblArtikelpreis
        '
        Me.lblArtikelpreis.AutoSize = True
        Me.lblArtikelpreis.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblArtikelpreis.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArtikelpreis.Location = New System.Drawing.Point(3, 140)
        Me.lblArtikelpreis.Name = "lblArtikelpreis"
        Me.lblArtikelpreis.Size = New System.Drawing.Size(169, 30)
        Me.lblArtikelpreis.TabIndex = 4
        Me.lblArtikelpreis.Text = "Artikelpreis:"
        Me.lblArtikelpreis.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblArtikelanzahl
        '
        Me.lblArtikelanzahl.AutoSize = True
        Me.lblArtikelanzahl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblArtikelanzahl.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArtikelanzahl.Location = New System.Drawing.Point(3, 110)
        Me.lblArtikelanzahl.Name = "lblArtikelanzahl"
        Me.lblArtikelanzahl.Size = New System.Drawing.Size(169, 30)
        Me.lblArtikelanzahl.TabIndex = 3
        Me.lblArtikelanzahl.Text = "Artikelanzahl:"
        Me.lblArtikelanzahl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblArtikelname
        '
        Me.lblArtikelname.AutoSize = True
        Me.lblArtikelname.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblArtikelname.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArtikelname.Location = New System.Drawing.Point(3, 80)
        Me.lblArtikelname.Name = "lblArtikelname"
        Me.lblArtikelname.Size = New System.Drawing.Size(169, 30)
        Me.lblArtikelname.TabIndex = 2
        Me.lblArtikelname.Text = "Artikelname:"
        Me.lblArtikelname.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblUeberschriftBestellen
        '
        Me.lblUeberschriftBestellen.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.lblUeberschriftBestellen, 4)
        Me.lblUeberschriftBestellen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblUeberschriftBestellen.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUeberschriftBestellen.ForeColor = System.Drawing.Color.Red
        Me.lblUeberschriftBestellen.Location = New System.Drawing.Point(3, 0)
        Me.lblUeberschriftBestellen.Name = "lblUeberschriftBestellen"
        Me.lblUeberschriftBestellen.Size = New System.Drawing.Size(578, 40)
        Me.lblUeberschriftBestellen.TabIndex = 0
        Me.lblUeberschriftBestellen.Text = "Artikel bestellen"
        Me.lblUeberschriftBestellen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblArtikelnummer
        '
        Me.lblArtikelnummer.AutoSize = True
        Me.lblArtikelnummer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblArtikelnummer.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArtikelnummer.Location = New System.Drawing.Point(3, 50)
        Me.lblArtikelnummer.Name = "lblArtikelnummer"
        Me.lblArtikelnummer.Size = New System.Drawing.Size(169, 30)
        Me.lblArtikelnummer.TabIndex = 1
        Me.lblArtikelnummer.Text = "Artikelnummer:"
        Me.lblArtikelnummer.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblLieferadresse
        '
        Me.lblLieferadresse.AutoSize = True
        Me.lblLieferadresse.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblLieferadresse.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLieferadresse.Location = New System.Drawing.Point(294, 50)
        Me.lblLieferadresse.Name = "lblLieferadresse"
        Me.lblLieferadresse.Size = New System.Drawing.Size(110, 30)
        Me.lblLieferadresse.TabIndex = 6
        Me.lblLieferadresse.Text = "Lieferadresse:"
        Me.lblLieferadresse.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblArtikelnummerAnzeige
        '
        Me.lblArtikelnummerAnzeige.AutoSize = True
        Me.lblArtikelnummerAnzeige.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblArtikelnummerAnzeige.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArtikelnummerAnzeige.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblArtikelnummerAnzeige.Location = New System.Drawing.Point(178, 50)
        Me.lblArtikelnummerAnzeige.Name = "lblArtikelnummerAnzeige"
        Me.lblArtikelnummerAnzeige.Size = New System.Drawing.Size(110, 30)
        Me.lblArtikelnummerAnzeige.TabIndex = 7
        Me.lblArtikelnummerAnzeige.Text = "int"
        Me.lblArtikelnummerAnzeige.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblName.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblName.Location = New System.Drawing.Point(410, 50)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(171, 30)
        Me.lblName.TabIndex = 12
        Me.lblName.Text = "Name"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'numAnzahl
        '
        Me.numAnzahl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.numAnzahl.Location = New System.Drawing.Point(178, 113)
        Me.numAnzahl.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.numAnzahl.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numAnzahl.Name = "numAnzahl"
        Me.numAnzahl.Size = New System.Drawing.Size(110, 22)
        Me.numAnzahl.TabIndex = 16
        Me.numAnzahl.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'cmdBestellen
        '
        Me.cmdBestellen.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.TableLayoutPanel1.SetColumnSpan(Me.cmdBestellen, 4)
        Me.cmdBestellen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdBestellen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdBestellen.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBestellen.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdBestellen.Location = New System.Drawing.Point(3, 223)
        Me.cmdBestellen.Name = "cmdBestellen"
        Me.cmdBestellen.Size = New System.Drawing.Size(578, 34)
        Me.cmdBestellen.TabIndex = 19
        Me.cmdBestellen.Text = "Kostenpflichtig bestellen"
        Me.cmdBestellen.UseVisualStyleBackColor = False
        '
        'FormBestellen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 264)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormBestellen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bestellen"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.numAnzahl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblUeberschriftBestellen As System.Windows.Forms.Label
    Friend WithEvents lblGesamtpreis As System.Windows.Forms.Label
    Friend WithEvents lblArtikelpreis As System.Windows.Forms.Label
    Friend WithEvents lblArtikelanzahl As System.Windows.Forms.Label
    Friend WithEvents lblArtikelname As System.Windows.Forms.Label
    Friend WithEvents lblArtikelnummer As System.Windows.Forms.Label
    Friend WithEvents lblLieferadresse As System.Windows.Forms.Label
    Friend WithEvents lblArtikelnameAnzeige As System.Windows.Forms.Label
    Friend WithEvents lblArtikelnummerAnzeige As System.Windows.Forms.Label
    Friend WithEvents lblGesamtpreisAnzeige As System.Windows.Forms.Label
    Friend WithEvents lblArtikelpreisAnzeige As System.Windows.Forms.Label
    Friend WithEvents lblLand As System.Windows.Forms.Label
    Friend WithEvents lblPLZStadt As System.Windows.Forms.Label
    Friend WithEvents lblStraßeHausnummer As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents numAnzahl As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblKontoAnzeige As System.Windows.Forms.Label
    Friend WithEvents lblKonto As System.Windows.Forms.Label
    Friend WithEvents cmdBestellen As System.Windows.Forms.Button
End Class
