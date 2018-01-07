<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormKunde
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormKunde))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.BenutzerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UmmeldenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KontoLöschenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KonsoleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÖffnenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SchließenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.cmdBestellen = New System.Windows.Forms.Button()
        Me.cmdKontoBearbeiten = New System.Windows.Forms.Button()
        Me.lblKonto = New System.Windows.Forms.Label()
        Me.tabControlKunde = New System.Windows.Forms.TabControl()
        Me.tabPageStore = New System.Windows.Forms.TabPage()
        Me.lstViewKundeStore = New System.Windows.Forms.ListView()
        Me.tabPageKundenkonto = New System.Windows.Forms.TabPage()
        Me.lstViewKundeKundenkonto = New System.Windows.Forms.ListView()
        Me.tabPageVerkaufshistorie = New System.Windows.Forms.TabPage()
        Me.lstViewKundeVerkaufshistorie = New System.Windows.Forms.ListView()
        Me.tabPageOffeneBestellungen = New System.Windows.Forms.TabPage()
        Me.lstViewOffeneBestellungen = New System.Windows.Forms.ListView()
        Me.tabPageKontoverlauf = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.lstViewKontoverlauf = New System.Windows.Forms.ListView()
        Me.chartKontoverlauf = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.cmdSuchen = New System.Windows.Forms.Button()
        Me.cmdAllesAnzeigen = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.tabControlKunde.SuspendLayout()
        Me.tabPageStore.SuspendLayout()
        Me.tabPageKundenkonto.SuspendLayout()
        Me.tabPageVerkaufshistorie.SuspendLayout()
        Me.tabPageOffeneBestellungen.SuspendLayout()
        Me.tabPageKontoverlauf.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.chartKontoverlauf, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BenutzerToolStripMenuItem, Me.KonsoleToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(984, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'BenutzerToolStripMenuItem
        '
        Me.BenutzerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UmmeldenToolStripMenuItem, Me.KontoLöschenToolStripMenuItem})
        Me.BenutzerToolStripMenuItem.Name = "BenutzerToolStripMenuItem"
        Me.BenutzerToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.BenutzerToolStripMenuItem.Text = "Benutzer"
        '
        'UmmeldenToolStripMenuItem
        '
        Me.UmmeldenToolStripMenuItem.Name = "UmmeldenToolStripMenuItem"
        Me.UmmeldenToolStripMenuItem.ShortcutKeyDisplayString = ""
        Me.UmmeldenToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.UmmeldenToolStripMenuItem.Text = "Ummelden"
        Me.UmmeldenToolStripMenuItem.ToolTipText = "Den Benutzer wechseln"
        '
        'KontoLöschenToolStripMenuItem
        '
        Me.KontoLöschenToolStripMenuItem.Name = "KontoLöschenToolStripMenuItem"
        Me.KontoLöschenToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.KontoLöschenToolStripMenuItem.Text = "Konto löschen"
        '
        'KonsoleToolStripMenuItem
        '
        Me.KonsoleToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ÖffnenToolStripMenuItem, Me.SchließenToolStripMenuItem})
        Me.KonsoleToolStripMenuItem.Name = "KonsoleToolStripMenuItem"
        Me.KonsoleToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.KonsoleToolStripMenuItem.Text = "Konsole"
        '
        'ÖffnenToolStripMenuItem
        '
        Me.ÖffnenToolStripMenuItem.Name = "ÖffnenToolStripMenuItem"
        Me.ÖffnenToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.ÖffnenToolStripMenuItem.Text = "Öffnen"
        '
        'SchließenToolStripMenuItem
        '
        Me.SchließenToolStripMenuItem.Name = "SchließenToolStripMenuItem"
        Me.SchließenToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.SchließenToolStripMenuItem.Text = "Schließen"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 6
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.cmdBestellen, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.cmdKontoBearbeiten, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblKonto, 5, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.tabControlKunde, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.cmdSuchen, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.cmdAllesAnzeigen, 3, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 24)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(984, 538)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'cmdBestellen
        '
        Me.cmdBestellen.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.cmdBestellen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdBestellen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdBestellen.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBestellen.Location = New System.Drawing.Point(3, 3)
        Me.cmdBestellen.Name = "cmdBestellen"
        Me.cmdBestellen.Size = New System.Drawing.Size(141, 24)
        Me.cmdBestellen.TabIndex = 0
        Me.cmdBestellen.Text = "Bestellen"
        Me.cmdBestellen.UseVisualStyleBackColor = False
        '
        'cmdKontoBearbeiten
        '
        Me.cmdKontoBearbeiten.BackColor = System.Drawing.Color.Khaki
        Me.cmdKontoBearbeiten.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdKontoBearbeiten.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdKontoBearbeiten.Location = New System.Drawing.Point(150, 3)
        Me.cmdKontoBearbeiten.Name = "cmdKontoBearbeiten"
        Me.cmdKontoBearbeiten.Size = New System.Drawing.Size(141, 24)
        Me.cmdKontoBearbeiten.TabIndex = 1
        Me.cmdKontoBearbeiten.Text = "Konto bearbeiten"
        Me.cmdKontoBearbeiten.UseVisualStyleBackColor = False
        '
        'lblKonto
        '
        Me.lblKonto.AutoSize = True
        Me.lblKonto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblKonto.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKonto.ForeColor = System.Drawing.Color.Red
        Me.lblKonto.Location = New System.Drawing.Point(787, 0)
        Me.lblKonto.Name = "lblKonto"
        Me.lblKonto.Size = New System.Drawing.Size(194, 30)
        Me.lblKonto.TabIndex = 2
        Me.lblKonto.Text = "Konto: ##.## €"
        Me.lblKonto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tabControlKunde
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.tabControlKunde, 6)
        Me.tabControlKunde.Controls.Add(Me.tabPageStore)
        Me.tabControlKunde.Controls.Add(Me.tabPageKundenkonto)
        Me.tabControlKunde.Controls.Add(Me.tabPageVerkaufshistorie)
        Me.tabControlKunde.Controls.Add(Me.tabPageOffeneBestellungen)
        Me.tabControlKunde.Controls.Add(Me.tabPageKontoverlauf)
        Me.tabControlKunde.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabControlKunde.Location = New System.Drawing.Point(3, 33)
        Me.tabControlKunde.Name = "tabControlKunde"
        Me.tabControlKunde.SelectedIndex = 0
        Me.tabControlKunde.Size = New System.Drawing.Size(978, 502)
        Me.tabControlKunde.TabIndex = 3
        '
        'tabPageStore
        '
        Me.tabPageStore.Controls.Add(Me.lstViewKundeStore)
        Me.tabPageStore.Location = New System.Drawing.Point(4, 22)
        Me.tabPageStore.Name = "tabPageStore"
        Me.tabPageStore.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPageStore.Size = New System.Drawing.Size(970, 476)
        Me.tabPageStore.TabIndex = 0
        Me.tabPageStore.Text = "Store"
        Me.tabPageStore.UseVisualStyleBackColor = True
        '
        'lstViewKundeStore
        '
        Me.lstViewKundeStore.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstViewKundeStore.FullRowSelect = True
        Me.lstViewKundeStore.GridLines = True
        Me.lstViewKundeStore.Location = New System.Drawing.Point(3, 3)
        Me.lstViewKundeStore.MultiSelect = False
        Me.lstViewKundeStore.Name = "lstViewKundeStore"
        Me.lstViewKundeStore.Size = New System.Drawing.Size(964, 470)
        Me.lstViewKundeStore.TabIndex = 0
        Me.lstViewKundeStore.UseCompatibleStateImageBehavior = False
        Me.lstViewKundeStore.View = System.Windows.Forms.View.Details
        '
        'tabPageKundenkonto
        '
        Me.tabPageKundenkonto.Controls.Add(Me.lstViewKundeKundenkonto)
        Me.tabPageKundenkonto.Location = New System.Drawing.Point(4, 22)
        Me.tabPageKundenkonto.Name = "tabPageKundenkonto"
        Me.tabPageKundenkonto.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPageKundenkonto.Size = New System.Drawing.Size(970, 476)
        Me.tabPageKundenkonto.TabIndex = 1
        Me.tabPageKundenkonto.Text = "Kundenkonto"
        Me.tabPageKundenkonto.UseVisualStyleBackColor = True
        '
        'lstViewKundeKundenkonto
        '
        Me.lstViewKundeKundenkonto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstViewKundeKundenkonto.FullRowSelect = True
        Me.lstViewKundeKundenkonto.GridLines = True
        Me.lstViewKundeKundenkonto.Location = New System.Drawing.Point(3, 3)
        Me.lstViewKundeKundenkonto.MultiSelect = False
        Me.lstViewKundeKundenkonto.Name = "lstViewKundeKundenkonto"
        Me.lstViewKundeKundenkonto.Size = New System.Drawing.Size(964, 470)
        Me.lstViewKundeKundenkonto.TabIndex = 0
        Me.lstViewKundeKundenkonto.UseCompatibleStateImageBehavior = False
        Me.lstViewKundeKundenkonto.View = System.Windows.Forms.View.Details
        '
        'tabPageVerkaufshistorie
        '
        Me.tabPageVerkaufshistorie.Controls.Add(Me.lstViewKundeVerkaufshistorie)
        Me.tabPageVerkaufshistorie.Location = New System.Drawing.Point(4, 22)
        Me.tabPageVerkaufshistorie.Name = "tabPageVerkaufshistorie"
        Me.tabPageVerkaufshistorie.Size = New System.Drawing.Size(970, 476)
        Me.tabPageVerkaufshistorie.TabIndex = 2
        Me.tabPageVerkaufshistorie.Text = "Verkaufshistorie"
        Me.tabPageVerkaufshistorie.UseVisualStyleBackColor = True
        '
        'lstViewKundeVerkaufshistorie
        '
        Me.lstViewKundeVerkaufshistorie.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstViewKundeVerkaufshistorie.FullRowSelect = True
        Me.lstViewKundeVerkaufshistorie.GridLines = True
        Me.lstViewKundeVerkaufshistorie.Location = New System.Drawing.Point(0, 0)
        Me.lstViewKundeVerkaufshistorie.MultiSelect = False
        Me.lstViewKundeVerkaufshistorie.Name = "lstViewKundeVerkaufshistorie"
        Me.lstViewKundeVerkaufshistorie.Size = New System.Drawing.Size(970, 476)
        Me.lstViewKundeVerkaufshistorie.TabIndex = 0
        Me.lstViewKundeVerkaufshistorie.UseCompatibleStateImageBehavior = False
        Me.lstViewKundeVerkaufshistorie.View = System.Windows.Forms.View.Details
        '
        'tabPageOffeneBestellungen
        '
        Me.tabPageOffeneBestellungen.Controls.Add(Me.lstViewOffeneBestellungen)
        Me.tabPageOffeneBestellungen.Location = New System.Drawing.Point(4, 22)
        Me.tabPageOffeneBestellungen.Name = "tabPageOffeneBestellungen"
        Me.tabPageOffeneBestellungen.Size = New System.Drawing.Size(970, 476)
        Me.tabPageOffeneBestellungen.TabIndex = 3
        Me.tabPageOffeneBestellungen.Text = "Offene Bestellungen"
        Me.tabPageOffeneBestellungen.UseVisualStyleBackColor = True
        '
        'lstViewOffeneBestellungen
        '
        Me.lstViewOffeneBestellungen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstViewOffeneBestellungen.FullRowSelect = True
        Me.lstViewOffeneBestellungen.GridLines = True
        Me.lstViewOffeneBestellungen.Location = New System.Drawing.Point(0, 0)
        Me.lstViewOffeneBestellungen.MultiSelect = False
        Me.lstViewOffeneBestellungen.Name = "lstViewOffeneBestellungen"
        Me.lstViewOffeneBestellungen.Size = New System.Drawing.Size(970, 476)
        Me.lstViewOffeneBestellungen.TabIndex = 0
        Me.lstViewOffeneBestellungen.UseCompatibleStateImageBehavior = False
        Me.lstViewOffeneBestellungen.View = System.Windows.Forms.View.Details
        '
        'tabPageKontoverlauf
        '
        Me.tabPageKontoverlauf.BackColor = System.Drawing.Color.Transparent
        Me.tabPageKontoverlauf.Controls.Add(Me.TableLayoutPanel2)
        Me.tabPageKontoverlauf.Location = New System.Drawing.Point(4, 22)
        Me.tabPageKontoverlauf.Name = "tabPageKontoverlauf"
        Me.tabPageKontoverlauf.Size = New System.Drawing.Size(970, 476)
        Me.tabPageKontoverlauf.TabIndex = 4
        Me.tabPageKontoverlauf.Text = "Kontoverlauf"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.lstViewKontoverlauf, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.chartKontoverlauf, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(970, 476)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'lstViewKontoverlauf
        '
        Me.lstViewKontoverlauf.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstViewKontoverlauf.FullRowSelect = True
        Me.lstViewKontoverlauf.GridLines = True
        Me.lstViewKontoverlauf.Location = New System.Drawing.Point(3, 3)
        Me.lstViewKontoverlauf.MultiSelect = False
        Me.lstViewKontoverlauf.Name = "lstViewKontoverlauf"
        Me.lstViewKontoverlauf.Size = New System.Drawing.Size(285, 470)
        Me.lstViewKontoverlauf.TabIndex = 0
        Me.lstViewKontoverlauf.UseCompatibleStateImageBehavior = False
        Me.lstViewKontoverlauf.View = System.Windows.Forms.View.Details
        '
        'chartKontoverlauf
        '
        ChartArea1.Name = "ChartArea1"
        Me.chartKontoverlauf.ChartAreas.Add(ChartArea1)
        Me.chartKontoverlauf.Dock = System.Windows.Forms.DockStyle.Fill
        Legend1.Name = "Legend1"
        Me.chartKontoverlauf.Legends.Add(Legend1)
        Me.chartKontoverlauf.Location = New System.Drawing.Point(294, 3)
        Me.chartKontoverlauf.Name = "chartKontoverlauf"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.chartKontoverlauf.Series.Add(Series1)
        Me.chartKontoverlauf.Size = New System.Drawing.Size(673, 470)
        Me.chartKontoverlauf.TabIndex = 1
        Me.chartKontoverlauf.Text = "Kontoverlauf"
        '
        'cmdSuchen
        '
        Me.cmdSuchen.BackColor = System.Drawing.Color.LightBlue
        Me.cmdSuchen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdSuchen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSuchen.Location = New System.Drawing.Point(297, 3)
        Me.cmdSuchen.Name = "cmdSuchen"
        Me.cmdSuchen.Size = New System.Drawing.Size(141, 24)
        Me.cmdSuchen.TabIndex = 4
        Me.cmdSuchen.Text = "Suchen"
        Me.cmdSuchen.UseVisualStyleBackColor = False
        '
        'cmdAllesAnzeigen
        '
        Me.cmdAllesAnzeigen.BackColor = System.Drawing.Color.LightCoral
        Me.cmdAllesAnzeigen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdAllesAnzeigen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAllesAnzeigen.Location = New System.Drawing.Point(444, 3)
        Me.cmdAllesAnzeigen.Name = "cmdAllesAnzeigen"
        Me.cmdAllesAnzeigen.Size = New System.Drawing.Size(141, 24)
        Me.cmdAllesAnzeigen.TabIndex = 5
        Me.cmdAllesAnzeigen.Text = "Alles anzeigen"
        Me.cmdAllesAnzeigen.UseVisualStyleBackColor = False
        '
        'FormKunde
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 562)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimumSize = New System.Drawing.Size(800, 500)
        Me.Name = "FormKunde"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Kunde"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.tabControlKunde.ResumeLayout(False)
        Me.tabPageStore.ResumeLayout(False)
        Me.tabPageKundenkonto.ResumeLayout(False)
        Me.tabPageVerkaufshistorie.ResumeLayout(False)
        Me.tabPageOffeneBestellungen.ResumeLayout(False)
        Me.tabPageKontoverlauf.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        CType(Me.chartKontoverlauf, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents BenutzerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UmmeldenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents cmdBestellen As System.Windows.Forms.Button
    Friend WithEvents cmdKontoBearbeiten As System.Windows.Forms.Button
    Friend WithEvents lblKonto As System.Windows.Forms.Label
    Friend WithEvents tabControlKunde As System.Windows.Forms.TabControl
    Friend WithEvents tabPageStore As System.Windows.Forms.TabPage
    Friend WithEvents tabPageKundenkonto As System.Windows.Forms.TabPage
    Friend WithEvents tabPageVerkaufshistorie As System.Windows.Forms.TabPage
    Friend WithEvents lstViewKundeStore As System.Windows.Forms.ListView
    Friend WithEvents lstViewKundeKundenkonto As System.Windows.Forms.ListView
    Friend WithEvents lstViewKundeVerkaufshistorie As System.Windows.Forms.ListView
    Friend WithEvents cmdSuchen As System.Windows.Forms.Button
    Friend WithEvents cmdAllesAnzeigen As System.Windows.Forms.Button
    Friend WithEvents tabPageOffeneBestellungen As System.Windows.Forms.TabPage
    Friend WithEvents lstViewOffeneBestellungen As System.Windows.Forms.ListView
    Friend WithEvents KonsoleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ÖffnenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SchließenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KontoLöschenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tabPageKontoverlauf As System.Windows.Forms.TabPage
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lstViewKontoverlauf As System.Windows.Forms.ListView
    Friend WithEvents chartKontoverlauf As System.Windows.Forms.DataVisualization.Charting.Chart
End Class
