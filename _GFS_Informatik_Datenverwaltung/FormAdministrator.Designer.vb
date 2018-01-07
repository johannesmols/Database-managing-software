<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAdministrator
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
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAdministrator))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.BenutzerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UmmeldenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KonsoleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÖffnenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SchließenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExtrasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AufDerKarteAnzeigenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.cmdEinfuegen = New System.Windows.Forms.Button()
        Me.cmdAendern = New System.Windows.Forms.Button()
        Me.cmdLoeschen = New System.Windows.Forms.Button()
        Me.cmdSuchen = New System.Windows.Forms.Button()
        Me.cmdAllesAnzeigen = New System.Windows.Forms.Button()
        Me.lblBudget = New System.Windows.Forms.Label()
        Me.tabControlAdministrator = New System.Windows.Forms.TabControl()
        Me.tabPageLager = New System.Windows.Forms.TabPage()
        Me.lstViewLager = New System.Windows.Forms.ListView()
        Me.tabPageBestellungen = New System.Windows.Forms.TabPage()
        Me.lstViewBestellungen = New System.Windows.Forms.ListView()
        Me.tabPageVerkaufshistorie = New System.Windows.Forms.TabPage()
        Me.lstViewVerkaufshistorie = New System.Windows.Forms.ListView()
        Me.tabPageKunden = New System.Windows.Forms.TabPage()
        Me.lstViewKunden = New System.Windows.Forms.ListView()
        Me.tabPageDrittanbieter = New System.Windows.Forms.TabPage()
        Me.lstViewDrittanbieter = New System.Windows.Forms.ListView()
        Me.tabPageNachbestellungen = New System.Windows.Forms.TabPage()
        Me.lstViewNachbestellungen = New System.Windows.Forms.ListView()
        Me.tabPagePasswoerter = New System.Windows.Forms.TabPage()
        Me.lstViewPasswoerter = New System.Windows.Forms.ListView()
        Me.tabPageFirma = New System.Windows.Forms.TabPage()
        Me.lstViewFirma = New System.Windows.Forms.ListView()
        Me.tabPageBudgetverlauf = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.lstViewBudgetverlauf = New System.Windows.Forms.ListView()
        Me.chartBudgetverlauf = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.tabPageKontoverlauf = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.lstViewKontoverlauf = New System.Windows.Forms.ListView()
        Me.chartKontoverlauf = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.tabPageCustom = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.cmdAusfuehren = New System.Windows.Forms.Button()
        Me.txtCustomSQLEingabe = New System.Windows.Forms.TextBox()
        Me.lstViewCustom = New System.Windows.Forms.ListView()
        Me.AccessDateiAnzeigenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformationenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.tabControlAdministrator.SuspendLayout()
        Me.tabPageLager.SuspendLayout()
        Me.tabPageBestellungen.SuspendLayout()
        Me.tabPageVerkaufshistorie.SuspendLayout()
        Me.tabPageKunden.SuspendLayout()
        Me.tabPageDrittanbieter.SuspendLayout()
        Me.tabPageNachbestellungen.SuspendLayout()
        Me.tabPagePasswoerter.SuspendLayout()
        Me.tabPageFirma.SuspendLayout()
        Me.tabPageBudgetverlauf.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.chartBudgetverlauf, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPageKontoverlauf.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        CType(Me.chartKontoverlauf, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPageCustom.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BenutzerToolStripMenuItem, Me.KonsoleToolStripMenuItem, Me.ExtrasToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(984, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'BenutzerToolStripMenuItem
        '
        Me.BenutzerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UmmeldenToolStripMenuItem})
        Me.BenutzerToolStripMenuItem.Name = "BenutzerToolStripMenuItem"
        Me.BenutzerToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.BenutzerToolStripMenuItem.Text = "Benutzer"
        '
        'UmmeldenToolStripMenuItem
        '
        Me.UmmeldenToolStripMenuItem.Name = "UmmeldenToolStripMenuItem"
        Me.UmmeldenToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.UmmeldenToolStripMenuItem.Text = "Ummelden"
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
        'ExtrasToolStripMenuItem
        '
        Me.ExtrasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AufDerKarteAnzeigenToolStripMenuItem, Me.AccessDateiAnzeigenToolStripMenuItem, Me.InformationenToolStripMenuItem})
        Me.ExtrasToolStripMenuItem.Name = "ExtrasToolStripMenuItem"
        Me.ExtrasToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.ExtrasToolStripMenuItem.Text = "Extras"
        '
        'AufDerKarteAnzeigenToolStripMenuItem
        '
        Me.AufDerKarteAnzeigenToolStripMenuItem.Name = "AufDerKarteAnzeigenToolStripMenuItem"
        Me.AufDerKarteAnzeigenToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.AufDerKarteAnzeigenToolStripMenuItem.Text = "Auf der Karte anzeigen"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 6
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.cmdEinfuegen, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.cmdAendern, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.cmdLoeschen, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.cmdSuchen, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.cmdAllesAnzeigen, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblBudget, 5, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.tabControlAdministrator, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 24)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(984, 538)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'cmdEinfuegen
        '
        Me.cmdEinfuegen.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.cmdEinfuegen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdEinfuegen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdEinfuegen.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdEinfuegen.Location = New System.Drawing.Point(3, 3)
        Me.cmdEinfuegen.Name = "cmdEinfuegen"
        Me.cmdEinfuegen.Size = New System.Drawing.Size(141, 24)
        Me.cmdEinfuegen.TabIndex = 0
        Me.cmdEinfuegen.Text = "Einfügen"
        Me.cmdEinfuegen.UseVisualStyleBackColor = False
        '
        'cmdAendern
        '
        Me.cmdAendern.BackColor = System.Drawing.Color.Khaki
        Me.cmdAendern.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdAendern.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAendern.Location = New System.Drawing.Point(150, 3)
        Me.cmdAendern.Name = "cmdAendern"
        Me.cmdAendern.Size = New System.Drawing.Size(141, 24)
        Me.cmdAendern.TabIndex = 1
        Me.cmdAendern.Text = "Ändern"
        Me.cmdAendern.UseVisualStyleBackColor = False
        '
        'cmdLoeschen
        '
        Me.cmdLoeschen.BackColor = System.Drawing.Color.LightCoral
        Me.cmdLoeschen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdLoeschen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdLoeschen.Location = New System.Drawing.Point(297, 3)
        Me.cmdLoeschen.Name = "cmdLoeschen"
        Me.cmdLoeschen.Size = New System.Drawing.Size(141, 24)
        Me.cmdLoeschen.TabIndex = 2
        Me.cmdLoeschen.Text = "Löschen"
        Me.cmdLoeschen.UseVisualStyleBackColor = False
        '
        'cmdSuchen
        '
        Me.cmdSuchen.BackColor = System.Drawing.Color.LightBlue
        Me.cmdSuchen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdSuchen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSuchen.Location = New System.Drawing.Point(444, 3)
        Me.cmdSuchen.Name = "cmdSuchen"
        Me.cmdSuchen.Size = New System.Drawing.Size(141, 24)
        Me.cmdSuchen.TabIndex = 3
        Me.cmdSuchen.Text = "Suchen"
        Me.cmdSuchen.UseVisualStyleBackColor = False
        '
        'cmdAllesAnzeigen
        '
        Me.cmdAllesAnzeigen.BackColor = System.Drawing.Color.Wheat
        Me.cmdAllesAnzeigen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdAllesAnzeigen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAllesAnzeigen.Location = New System.Drawing.Point(591, 3)
        Me.cmdAllesAnzeigen.Name = "cmdAllesAnzeigen"
        Me.cmdAllesAnzeigen.Size = New System.Drawing.Size(141, 24)
        Me.cmdAllesAnzeigen.TabIndex = 4
        Me.cmdAllesAnzeigen.Text = "Alles anzeigen"
        Me.cmdAllesAnzeigen.UseVisualStyleBackColor = False
        '
        'lblBudget
        '
        Me.lblBudget.AutoSize = True
        Me.lblBudget.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblBudget.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBudget.ForeColor = System.Drawing.Color.Red
        Me.lblBudget.Location = New System.Drawing.Point(738, 0)
        Me.lblBudget.Name = "lblBudget"
        Me.lblBudget.Size = New System.Drawing.Size(243, 30)
        Me.lblBudget.TabIndex = 5
        Me.lblBudget.Text = "Budget: ##.## €"
        Me.lblBudget.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tabControlAdministrator
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.tabControlAdministrator, 6)
        Me.tabControlAdministrator.Controls.Add(Me.tabPageLager)
        Me.tabControlAdministrator.Controls.Add(Me.tabPageBestellungen)
        Me.tabControlAdministrator.Controls.Add(Me.tabPageVerkaufshistorie)
        Me.tabControlAdministrator.Controls.Add(Me.tabPageKunden)
        Me.tabControlAdministrator.Controls.Add(Me.tabPageDrittanbieter)
        Me.tabControlAdministrator.Controls.Add(Me.tabPageNachbestellungen)
        Me.tabControlAdministrator.Controls.Add(Me.tabPagePasswoerter)
        Me.tabControlAdministrator.Controls.Add(Me.tabPageFirma)
        Me.tabControlAdministrator.Controls.Add(Me.tabPageBudgetverlauf)
        Me.tabControlAdministrator.Controls.Add(Me.tabPageKontoverlauf)
        Me.tabControlAdministrator.Controls.Add(Me.tabPageCustom)
        Me.tabControlAdministrator.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabControlAdministrator.Location = New System.Drawing.Point(3, 33)
        Me.tabControlAdministrator.Name = "tabControlAdministrator"
        Me.tabControlAdministrator.SelectedIndex = 0
        Me.tabControlAdministrator.Size = New System.Drawing.Size(978, 502)
        Me.tabControlAdministrator.TabIndex = 6
        '
        'tabPageLager
        '
        Me.tabPageLager.Controls.Add(Me.lstViewLager)
        Me.tabPageLager.Location = New System.Drawing.Point(4, 22)
        Me.tabPageLager.Name = "tabPageLager"
        Me.tabPageLager.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPageLager.Size = New System.Drawing.Size(970, 476)
        Me.tabPageLager.TabIndex = 0
        Me.tabPageLager.Text = "Lager"
        Me.tabPageLager.UseVisualStyleBackColor = True
        '
        'lstViewLager
        '
        Me.lstViewLager.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstViewLager.FullRowSelect = True
        Me.lstViewLager.GridLines = True
        Me.lstViewLager.Location = New System.Drawing.Point(3, 3)
        Me.lstViewLager.MultiSelect = False
        Me.lstViewLager.Name = "lstViewLager"
        Me.lstViewLager.Size = New System.Drawing.Size(964, 470)
        Me.lstViewLager.TabIndex = 0
        Me.lstViewLager.UseCompatibleStateImageBehavior = False
        Me.lstViewLager.View = System.Windows.Forms.View.Details
        '
        'tabPageBestellungen
        '
        Me.tabPageBestellungen.Controls.Add(Me.lstViewBestellungen)
        Me.tabPageBestellungen.Location = New System.Drawing.Point(4, 22)
        Me.tabPageBestellungen.Name = "tabPageBestellungen"
        Me.tabPageBestellungen.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPageBestellungen.Size = New System.Drawing.Size(970, 476)
        Me.tabPageBestellungen.TabIndex = 1
        Me.tabPageBestellungen.Text = "Bestellungen"
        Me.tabPageBestellungen.UseVisualStyleBackColor = True
        '
        'lstViewBestellungen
        '
        Me.lstViewBestellungen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstViewBestellungen.FullRowSelect = True
        Me.lstViewBestellungen.GridLines = True
        Me.lstViewBestellungen.Location = New System.Drawing.Point(3, 3)
        Me.lstViewBestellungen.MultiSelect = False
        Me.lstViewBestellungen.Name = "lstViewBestellungen"
        Me.lstViewBestellungen.Size = New System.Drawing.Size(964, 470)
        Me.lstViewBestellungen.TabIndex = 0
        Me.lstViewBestellungen.UseCompatibleStateImageBehavior = False
        Me.lstViewBestellungen.View = System.Windows.Forms.View.Details
        '
        'tabPageVerkaufshistorie
        '
        Me.tabPageVerkaufshistorie.Controls.Add(Me.lstViewVerkaufshistorie)
        Me.tabPageVerkaufshistorie.Location = New System.Drawing.Point(4, 22)
        Me.tabPageVerkaufshistorie.Name = "tabPageVerkaufshistorie"
        Me.tabPageVerkaufshistorie.Size = New System.Drawing.Size(970, 476)
        Me.tabPageVerkaufshistorie.TabIndex = 2
        Me.tabPageVerkaufshistorie.Text = "Verkaufshistorie"
        Me.tabPageVerkaufshistorie.UseVisualStyleBackColor = True
        '
        'lstViewVerkaufshistorie
        '
        Me.lstViewVerkaufshistorie.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstViewVerkaufshistorie.FullRowSelect = True
        Me.lstViewVerkaufshistorie.GridLines = True
        Me.lstViewVerkaufshistorie.Location = New System.Drawing.Point(0, 0)
        Me.lstViewVerkaufshistorie.MultiSelect = False
        Me.lstViewVerkaufshistorie.Name = "lstViewVerkaufshistorie"
        Me.lstViewVerkaufshistorie.Size = New System.Drawing.Size(970, 476)
        Me.lstViewVerkaufshistorie.TabIndex = 0
        Me.lstViewVerkaufshistorie.UseCompatibleStateImageBehavior = False
        Me.lstViewVerkaufshistorie.View = System.Windows.Forms.View.Details
        '
        'tabPageKunden
        '
        Me.tabPageKunden.Controls.Add(Me.lstViewKunden)
        Me.tabPageKunden.Location = New System.Drawing.Point(4, 22)
        Me.tabPageKunden.Name = "tabPageKunden"
        Me.tabPageKunden.Size = New System.Drawing.Size(970, 476)
        Me.tabPageKunden.TabIndex = 3
        Me.tabPageKunden.Text = "Kunden"
        Me.tabPageKunden.UseVisualStyleBackColor = True
        '
        'lstViewKunden
        '
        Me.lstViewKunden.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstViewKunden.FullRowSelect = True
        Me.lstViewKunden.GridLines = True
        Me.lstViewKunden.Location = New System.Drawing.Point(0, 0)
        Me.lstViewKunden.MultiSelect = False
        Me.lstViewKunden.Name = "lstViewKunden"
        Me.lstViewKunden.Size = New System.Drawing.Size(970, 476)
        Me.lstViewKunden.TabIndex = 0
        Me.lstViewKunden.UseCompatibleStateImageBehavior = False
        Me.lstViewKunden.View = System.Windows.Forms.View.Details
        '
        'tabPageDrittanbieter
        '
        Me.tabPageDrittanbieter.Controls.Add(Me.lstViewDrittanbieter)
        Me.tabPageDrittanbieter.Location = New System.Drawing.Point(4, 22)
        Me.tabPageDrittanbieter.Name = "tabPageDrittanbieter"
        Me.tabPageDrittanbieter.Size = New System.Drawing.Size(970, 476)
        Me.tabPageDrittanbieter.TabIndex = 4
        Me.tabPageDrittanbieter.Text = "Drittanbieter"
        Me.tabPageDrittanbieter.UseVisualStyleBackColor = True
        '
        'lstViewDrittanbieter
        '
        Me.lstViewDrittanbieter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstViewDrittanbieter.FullRowSelect = True
        Me.lstViewDrittanbieter.GridLines = True
        Me.lstViewDrittanbieter.Location = New System.Drawing.Point(0, 0)
        Me.lstViewDrittanbieter.MultiSelect = False
        Me.lstViewDrittanbieter.Name = "lstViewDrittanbieter"
        Me.lstViewDrittanbieter.Size = New System.Drawing.Size(970, 476)
        Me.lstViewDrittanbieter.TabIndex = 0
        Me.lstViewDrittanbieter.UseCompatibleStateImageBehavior = False
        Me.lstViewDrittanbieter.View = System.Windows.Forms.View.Details
        '
        'tabPageNachbestellungen
        '
        Me.tabPageNachbestellungen.Controls.Add(Me.lstViewNachbestellungen)
        Me.tabPageNachbestellungen.Location = New System.Drawing.Point(4, 22)
        Me.tabPageNachbestellungen.Name = "tabPageNachbestellungen"
        Me.tabPageNachbestellungen.Size = New System.Drawing.Size(970, 476)
        Me.tabPageNachbestellungen.TabIndex = 5
        Me.tabPageNachbestellungen.Text = "Nachbestellungen"
        Me.tabPageNachbestellungen.UseVisualStyleBackColor = True
        '
        'lstViewNachbestellungen
        '
        Me.lstViewNachbestellungen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstViewNachbestellungen.FullRowSelect = True
        Me.lstViewNachbestellungen.GridLines = True
        Me.lstViewNachbestellungen.Location = New System.Drawing.Point(0, 0)
        Me.lstViewNachbestellungen.MultiSelect = False
        Me.lstViewNachbestellungen.Name = "lstViewNachbestellungen"
        Me.lstViewNachbestellungen.Size = New System.Drawing.Size(970, 476)
        Me.lstViewNachbestellungen.TabIndex = 0
        Me.lstViewNachbestellungen.UseCompatibleStateImageBehavior = False
        Me.lstViewNachbestellungen.View = System.Windows.Forms.View.Details
        '
        'tabPagePasswoerter
        '
        Me.tabPagePasswoerter.Controls.Add(Me.lstViewPasswoerter)
        Me.tabPagePasswoerter.Location = New System.Drawing.Point(4, 22)
        Me.tabPagePasswoerter.Name = "tabPagePasswoerter"
        Me.tabPagePasswoerter.Size = New System.Drawing.Size(970, 476)
        Me.tabPagePasswoerter.TabIndex = 6
        Me.tabPagePasswoerter.Text = "Passwörter"
        Me.tabPagePasswoerter.UseVisualStyleBackColor = True
        '
        'lstViewPasswoerter
        '
        Me.lstViewPasswoerter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstViewPasswoerter.FullRowSelect = True
        Me.lstViewPasswoerter.GridLines = True
        Me.lstViewPasswoerter.Location = New System.Drawing.Point(0, 0)
        Me.lstViewPasswoerter.MultiSelect = False
        Me.lstViewPasswoerter.Name = "lstViewPasswoerter"
        Me.lstViewPasswoerter.Size = New System.Drawing.Size(970, 476)
        Me.lstViewPasswoerter.TabIndex = 0
        Me.lstViewPasswoerter.UseCompatibleStateImageBehavior = False
        Me.lstViewPasswoerter.View = System.Windows.Forms.View.Details
        '
        'tabPageFirma
        '
        Me.tabPageFirma.Controls.Add(Me.lstViewFirma)
        Me.tabPageFirma.Location = New System.Drawing.Point(4, 22)
        Me.tabPageFirma.Name = "tabPageFirma"
        Me.tabPageFirma.Size = New System.Drawing.Size(970, 476)
        Me.tabPageFirma.TabIndex = 7
        Me.tabPageFirma.Text = "Firma"
        Me.tabPageFirma.UseVisualStyleBackColor = True
        '
        'lstViewFirma
        '
        Me.lstViewFirma.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstViewFirma.FullRowSelect = True
        Me.lstViewFirma.GridLines = True
        Me.lstViewFirma.Location = New System.Drawing.Point(0, 0)
        Me.lstViewFirma.MultiSelect = False
        Me.lstViewFirma.Name = "lstViewFirma"
        Me.lstViewFirma.Size = New System.Drawing.Size(970, 476)
        Me.lstViewFirma.TabIndex = 0
        Me.lstViewFirma.UseCompatibleStateImageBehavior = False
        Me.lstViewFirma.View = System.Windows.Forms.View.Details
        '
        'tabPageBudgetverlauf
        '
        Me.tabPageBudgetverlauf.Controls.Add(Me.TableLayoutPanel3)
        Me.tabPageBudgetverlauf.Location = New System.Drawing.Point(4, 22)
        Me.tabPageBudgetverlauf.Name = "tabPageBudgetverlauf"
        Me.tabPageBudgetverlauf.Size = New System.Drawing.Size(970, 476)
        Me.tabPageBudgetverlauf.TabIndex = 9
        Me.tabPageBudgetverlauf.Text = "Budgetverlauf"
        Me.tabPageBudgetverlauf.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.lstViewBudgetverlauf, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.chartBudgetverlauf, 1, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(970, 476)
        Me.TableLayoutPanel3.TabIndex = 0
        '
        'lstViewBudgetverlauf
        '
        Me.lstViewBudgetverlauf.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstViewBudgetverlauf.FullRowSelect = True
        Me.lstViewBudgetverlauf.GridLines = True
        Me.lstViewBudgetverlauf.Location = New System.Drawing.Point(3, 3)
        Me.lstViewBudgetverlauf.MultiSelect = False
        Me.lstViewBudgetverlauf.Name = "lstViewBudgetverlauf"
        Me.lstViewBudgetverlauf.Size = New System.Drawing.Size(285, 470)
        Me.lstViewBudgetverlauf.TabIndex = 0
        Me.lstViewBudgetverlauf.UseCompatibleStateImageBehavior = False
        Me.lstViewBudgetverlauf.View = System.Windows.Forms.View.Details
        '
        'chartBudgetverlauf
        '
        ChartArea1.Name = "ChartArea1"
        Me.chartBudgetverlauf.ChartAreas.Add(ChartArea1)
        Me.chartBudgetverlauf.Dock = System.Windows.Forms.DockStyle.Fill
        Legend1.Name = "Legend1"
        Me.chartBudgetverlauf.Legends.Add(Legend1)
        Me.chartBudgetverlauf.Location = New System.Drawing.Point(294, 3)
        Me.chartBudgetverlauf.Name = "chartBudgetverlauf"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.chartBudgetverlauf.Series.Add(Series1)
        Me.chartBudgetverlauf.Size = New System.Drawing.Size(673, 470)
        Me.chartBudgetverlauf.TabIndex = 1
        Me.chartBudgetverlauf.Text = "Budgetverlauf"
        '
        'tabPageKontoverlauf
        '
        Me.tabPageKontoverlauf.Controls.Add(Me.TableLayoutPanel4)
        Me.tabPageKontoverlauf.Location = New System.Drawing.Point(4, 22)
        Me.tabPageKontoverlauf.Name = "tabPageKontoverlauf"
        Me.tabPageKontoverlauf.Size = New System.Drawing.Size(970, 476)
        Me.tabPageKontoverlauf.TabIndex = 10
        Me.tabPageKontoverlauf.Text = "Kontoverlauf"
        Me.tabPageKontoverlauf.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.lstViewKontoverlauf, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.chartKontoverlauf, 1, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(970, 476)
        Me.TableLayoutPanel4.TabIndex = 0
        '
        'lstViewKontoverlauf
        '
        Me.lstViewKontoverlauf.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstViewKontoverlauf.FullRowSelect = True
        Me.lstViewKontoverlauf.GridLines = True
        Me.lstViewKontoverlauf.Location = New System.Drawing.Point(3, 3)
        Me.lstViewKontoverlauf.MultiSelect = False
        Me.lstViewKontoverlauf.Name = "lstViewKontoverlauf"
        Me.lstViewKontoverlauf.Size = New System.Drawing.Size(333, 470)
        Me.lstViewKontoverlauf.TabIndex = 0
        Me.lstViewKontoverlauf.UseCompatibleStateImageBehavior = False
        Me.lstViewKontoverlauf.View = System.Windows.Forms.View.Details
        '
        'chartKontoverlauf
        '
        ChartArea2.Name = "ChartArea1"
        Me.chartKontoverlauf.ChartAreas.Add(ChartArea2)
        Me.chartKontoverlauf.Dock = System.Windows.Forms.DockStyle.Fill
        Legend2.Name = "Legend1"
        Me.chartKontoverlauf.Legends.Add(Legend2)
        Me.chartKontoverlauf.Location = New System.Drawing.Point(342, 3)
        Me.chartKontoverlauf.Name = "chartKontoverlauf"
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Me.chartKontoverlauf.Series.Add(Series2)
        Me.chartKontoverlauf.Size = New System.Drawing.Size(625, 470)
        Me.chartKontoverlauf.TabIndex = 1
        Me.chartKontoverlauf.Text = "Chart1"
        '
        'tabPageCustom
        '
        Me.tabPageCustom.Controls.Add(Me.TableLayoutPanel2)
        Me.tabPageCustom.Location = New System.Drawing.Point(4, 22)
        Me.tabPageCustom.Name = "tabPageCustom"
        Me.tabPageCustom.Size = New System.Drawing.Size(970, 476)
        Me.tabPageCustom.TabIndex = 8
        Me.tabPageCustom.Text = "Custom"
        Me.tabPageCustom.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.cmdAusfuehren, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.txtCustomSQLEingabe, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lstViewCustom, 0, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(970, 476)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'cmdAusfuehren
        '
        Me.cmdAusfuehren.BackColor = System.Drawing.Color.DarkTurquoise
        Me.cmdAusfuehren.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdAusfuehren.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAusfuehren.Location = New System.Drawing.Point(823, 3)
        Me.cmdAusfuehren.Name = "cmdAusfuehren"
        Me.cmdAusfuehren.Size = New System.Drawing.Size(144, 24)
        Me.cmdAusfuehren.TabIndex = 0
        Me.cmdAusfuehren.Text = "Ausführen"
        Me.cmdAusfuehren.UseVisualStyleBackColor = False
        '
        'txtCustomSQLEingabe
        '
        Me.txtCustomSQLEingabe.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtCustomSQLEingabe.Location = New System.Drawing.Point(3, 3)
        Me.txtCustomSQLEingabe.Name = "txtCustomSQLEingabe"
        Me.txtCustomSQLEingabe.Size = New System.Drawing.Size(814, 22)
        Me.txtCustomSQLEingabe.TabIndex = 1
        '
        'lstViewCustom
        '
        Me.TableLayoutPanel2.SetColumnSpan(Me.lstViewCustom, 2)
        Me.lstViewCustom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstViewCustom.FullRowSelect = True
        Me.lstViewCustom.GridLines = True
        Me.lstViewCustom.Location = New System.Drawing.Point(3, 33)
        Me.lstViewCustom.MultiSelect = False
        Me.lstViewCustom.Name = "lstViewCustom"
        Me.lstViewCustom.Size = New System.Drawing.Size(964, 440)
        Me.lstViewCustom.TabIndex = 2
        Me.lstViewCustom.UseCompatibleStateImageBehavior = False
        Me.lstViewCustom.View = System.Windows.Forms.View.Details
        '
        'AccessDateiAnzeigenToolStripMenuItem
        '
        Me.AccessDateiAnzeigenToolStripMenuItem.Name = "AccessDateiAnzeigenToolStripMenuItem"
        Me.AccessDateiAnzeigenToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.AccessDateiAnzeigenToolStripMenuItem.Text = "Access-Datei anzeigen"
        '
        'InformationenToolStripMenuItem
        '
        Me.InformationenToolStripMenuItem.Name = "InformationenToolStripMenuItem"
        Me.InformationenToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.InformationenToolStripMenuItem.Text = "Informationen"
        '
        'FormAdministrator
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
        Me.Name = "FormAdministrator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administrator"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.tabControlAdministrator.ResumeLayout(False)
        Me.tabPageLager.ResumeLayout(False)
        Me.tabPageBestellungen.ResumeLayout(False)
        Me.tabPageVerkaufshistorie.ResumeLayout(False)
        Me.tabPageKunden.ResumeLayout(False)
        Me.tabPageDrittanbieter.ResumeLayout(False)
        Me.tabPageNachbestellungen.ResumeLayout(False)
        Me.tabPagePasswoerter.ResumeLayout(False)
        Me.tabPageFirma.ResumeLayout(False)
        Me.tabPageBudgetverlauf.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        CType(Me.chartBudgetverlauf, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPageKontoverlauf.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        CType(Me.chartKontoverlauf, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPageCustom.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents BenutzerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UmmeldenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents cmdEinfuegen As System.Windows.Forms.Button
    Friend WithEvents cmdAendern As System.Windows.Forms.Button
    Friend WithEvents cmdLoeschen As System.Windows.Forms.Button
    Friend WithEvents cmdSuchen As System.Windows.Forms.Button
    Friend WithEvents cmdAllesAnzeigen As System.Windows.Forms.Button
    Friend WithEvents tabControlAdministrator As System.Windows.Forms.TabControl
    Friend WithEvents tabPageLager As System.Windows.Forms.TabPage
    Friend WithEvents tabPageBestellungen As System.Windows.Forms.TabPage
    Friend WithEvents tabPageVerkaufshistorie As System.Windows.Forms.TabPage
    Friend WithEvents tabPageKunden As System.Windows.Forms.TabPage
    Friend WithEvents tabPageDrittanbieter As System.Windows.Forms.TabPage
    Friend WithEvents tabPageNachbestellungen As System.Windows.Forms.TabPage
    Friend WithEvents tabPagePasswoerter As System.Windows.Forms.TabPage
    Friend WithEvents tabPageFirma As System.Windows.Forms.TabPage
    Friend WithEvents lstViewLager As System.Windows.Forms.ListView
    Friend WithEvents lstViewBestellungen As System.Windows.Forms.ListView
    Friend WithEvents lstViewVerkaufshistorie As System.Windows.Forms.ListView
    Friend WithEvents lstViewKunden As System.Windows.Forms.ListView
    Friend WithEvents lstViewDrittanbieter As System.Windows.Forms.ListView
    Friend WithEvents lstViewNachbestellungen As System.Windows.Forms.ListView
    Friend WithEvents lstViewPasswoerter As System.Windows.Forms.ListView
    Friend WithEvents lstViewFirma As System.Windows.Forms.ListView
    Friend WithEvents KonsoleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ÖffnenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SchließenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tabPageCustom As System.Windows.Forms.TabPage
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents cmdAusfuehren As System.Windows.Forms.Button
    Friend WithEvents txtCustomSQLEingabe As System.Windows.Forms.TextBox
    Friend WithEvents lstViewCustom As System.Windows.Forms.ListView
    Friend WithEvents tabPageBudgetverlauf As System.Windows.Forms.TabPage
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lstViewBudgetverlauf As System.Windows.Forms.ListView
    Friend WithEvents chartBudgetverlauf As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents tabPageKontoverlauf As System.Windows.Forms.TabPage
    Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lstViewKontoverlauf As System.Windows.Forms.ListView
    Friend WithEvents chartKontoverlauf As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents lblBudget As System.Windows.Forms.Label
    Friend WithEvents ExtrasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AufDerKarteAnzeigenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AccessDateiAnzeigenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InformationenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
