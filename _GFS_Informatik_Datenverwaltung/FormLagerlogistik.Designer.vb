<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLagerlogistik
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLagerlogistik))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.BenutzerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UmmeldenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KonsoleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÖffnenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SchließenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tableLayoutPanelLagerlogistik = New System.Windows.Forms.TableLayoutPanel()
        Me.cmdAkzeptieren = New System.Windows.Forms.Button()
        Me.cmdAblehnen = New System.Windows.Forms.Button()
        Me.cmdBestellen = New System.Windows.Forms.Button()
        Me.cmdSuchen = New System.Windows.Forms.Button()
        Me.cmdAllesAnzeigen = New System.Windows.Forms.Button()
        Me.lblBudget = New System.Windows.Forms.Label()
        Me.tabControlLagerlogistik = New System.Windows.Forms.TabControl()
        Me.tabPageLager = New System.Windows.Forms.TabPage()
        Me.lstViewLager = New System.Windows.Forms.ListView()
        Me.tabPageDrittanbieter = New System.Windows.Forms.TabPage()
        Me.lstViewDrittanbieter = New System.Windows.Forms.ListView()
        Me.tabPageNachbestellungen = New System.Windows.Forms.TabPage()
        Me.lstViewNachbestellungen = New System.Windows.Forms.ListView()
        Me.MenuStrip1.SuspendLayout()
        Me.tableLayoutPanelLagerlogistik.SuspendLayout()
        Me.tabControlLagerlogistik.SuspendLayout()
        Me.tabPageLager.SuspendLayout()
        Me.tabPageDrittanbieter.SuspendLayout()
        Me.tabPageNachbestellungen.SuspendLayout()
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
        Me.MenuStrip1.Text = "MenuStrip"
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
        Me.UmmeldenToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
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
        'tableLayoutPanelLagerlogistik
        '
        Me.tableLayoutPanelLagerlogistik.ColumnCount = 6
        Me.tableLayoutPanelLagerlogistik.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.tableLayoutPanelLagerlogistik.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.tableLayoutPanelLagerlogistik.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.tableLayoutPanelLagerlogistik.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.tableLayoutPanelLagerlogistik.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.tableLayoutPanelLagerlogistik.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tableLayoutPanelLagerlogistik.Controls.Add(Me.cmdAkzeptieren, 0, 0)
        Me.tableLayoutPanelLagerlogistik.Controls.Add(Me.cmdAblehnen, 1, 0)
        Me.tableLayoutPanelLagerlogistik.Controls.Add(Me.cmdBestellen, 2, 0)
        Me.tableLayoutPanelLagerlogistik.Controls.Add(Me.cmdSuchen, 3, 0)
        Me.tableLayoutPanelLagerlogistik.Controls.Add(Me.cmdAllesAnzeigen, 4, 0)
        Me.tableLayoutPanelLagerlogistik.Controls.Add(Me.lblBudget, 5, 0)
        Me.tableLayoutPanelLagerlogistik.Controls.Add(Me.tabControlLagerlogistik, 0, 1)
        Me.tableLayoutPanelLagerlogistik.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tableLayoutPanelLagerlogistik.Location = New System.Drawing.Point(0, 24)
        Me.tableLayoutPanelLagerlogistik.Name = "tableLayoutPanelLagerlogistik"
        Me.tableLayoutPanelLagerlogistik.RowCount = 2
        Me.tableLayoutPanelLagerlogistik.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tableLayoutPanelLagerlogistik.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableLayoutPanelLagerlogistik.Size = New System.Drawing.Size(984, 538)
        Me.tableLayoutPanelLagerlogistik.TabIndex = 1
        '
        'cmdAkzeptieren
        '
        Me.cmdAkzeptieren.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.cmdAkzeptieren.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdAkzeptieren.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAkzeptieren.Location = New System.Drawing.Point(3, 3)
        Me.cmdAkzeptieren.Name = "cmdAkzeptieren"
        Me.cmdAkzeptieren.Size = New System.Drawing.Size(141, 24)
        Me.cmdAkzeptieren.TabIndex = 0
        Me.cmdAkzeptieren.Text = "Akzeptieren"
        Me.cmdAkzeptieren.UseVisualStyleBackColor = False
        '
        'cmdAblehnen
        '
        Me.cmdAblehnen.BackColor = System.Drawing.Color.LightCoral
        Me.cmdAblehnen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdAblehnen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAblehnen.Location = New System.Drawing.Point(150, 3)
        Me.cmdAblehnen.Name = "cmdAblehnen"
        Me.cmdAblehnen.Size = New System.Drawing.Size(141, 24)
        Me.cmdAblehnen.TabIndex = 1
        Me.cmdAblehnen.Text = "Ablehnen"
        Me.cmdAblehnen.UseVisualStyleBackColor = False
        '
        'cmdBestellen
        '
        Me.cmdBestellen.BackColor = System.Drawing.Color.Khaki
        Me.cmdBestellen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdBestellen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdBestellen.Location = New System.Drawing.Point(297, 3)
        Me.cmdBestellen.Name = "cmdBestellen"
        Me.cmdBestellen.Size = New System.Drawing.Size(141, 24)
        Me.cmdBestellen.TabIndex = 2
        Me.cmdBestellen.Text = "Bestellen"
        Me.cmdBestellen.UseVisualStyleBackColor = False
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
        Me.lblBudget.Text = "Budget: ##.##€"
        Me.lblBudget.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tabControlLagerlogistik
        '
        Me.tableLayoutPanelLagerlogistik.SetColumnSpan(Me.tabControlLagerlogistik, 6)
        Me.tabControlLagerlogistik.Controls.Add(Me.tabPageLager)
        Me.tabControlLagerlogistik.Controls.Add(Me.tabPageDrittanbieter)
        Me.tabControlLagerlogistik.Controls.Add(Me.tabPageNachbestellungen)
        Me.tabControlLagerlogistik.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabControlLagerlogistik.Location = New System.Drawing.Point(3, 33)
        Me.tabControlLagerlogistik.Name = "tabControlLagerlogistik"
        Me.tabControlLagerlogistik.SelectedIndex = 0
        Me.tabControlLagerlogistik.Size = New System.Drawing.Size(978, 502)
        Me.tabControlLagerlogistik.TabIndex = 6
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
        'tabPageDrittanbieter
        '
        Me.tabPageDrittanbieter.Controls.Add(Me.lstViewDrittanbieter)
        Me.tabPageDrittanbieter.Location = New System.Drawing.Point(4, 22)
        Me.tabPageDrittanbieter.Name = "tabPageDrittanbieter"
        Me.tabPageDrittanbieter.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPageDrittanbieter.Size = New System.Drawing.Size(970, 476)
        Me.tabPageDrittanbieter.TabIndex = 1
        Me.tabPageDrittanbieter.Text = "Drittanbieter"
        Me.tabPageDrittanbieter.UseVisualStyleBackColor = True
        '
        'lstViewDrittanbieter
        '
        Me.lstViewDrittanbieter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstViewDrittanbieter.FullRowSelect = True
        Me.lstViewDrittanbieter.GridLines = True
        Me.lstViewDrittanbieter.Location = New System.Drawing.Point(3, 3)
        Me.lstViewDrittanbieter.MultiSelect = False
        Me.lstViewDrittanbieter.Name = "lstViewDrittanbieter"
        Me.lstViewDrittanbieter.Size = New System.Drawing.Size(964, 470)
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
        Me.tabPageNachbestellungen.TabIndex = 2
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
        'FormLagerlogistik
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 562)
        Me.Controls.Add(Me.tableLayoutPanelLagerlogistik)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimumSize = New System.Drawing.Size(800, 500)
        Me.Name = "FormLagerlogistik"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lagerlogistik"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.tableLayoutPanelLagerlogistik.ResumeLayout(False)
        Me.tableLayoutPanelLagerlogistik.PerformLayout()
        Me.tabControlLagerlogistik.ResumeLayout(False)
        Me.tabPageLager.ResumeLayout(False)
        Me.tabPageDrittanbieter.ResumeLayout(False)
        Me.tabPageNachbestellungen.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents BenutzerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KonsoleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ÖffnenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SchließenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UmmeldenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tableLayoutPanelLagerlogistik As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents cmdAkzeptieren As System.Windows.Forms.Button
    Friend WithEvents cmdAblehnen As System.Windows.Forms.Button
    Friend WithEvents cmdBestellen As System.Windows.Forms.Button
    Friend WithEvents cmdSuchen As System.Windows.Forms.Button
    Friend WithEvents cmdAllesAnzeigen As System.Windows.Forms.Button
    Friend WithEvents lblBudget As System.Windows.Forms.Label
    Friend WithEvents tabControlLagerlogistik As System.Windows.Forms.TabControl
    Friend WithEvents tabPageLager As System.Windows.Forms.TabPage
    Friend WithEvents tabPageDrittanbieter As System.Windows.Forms.TabPage
    Friend WithEvents tabPageNachbestellungen As System.Windows.Forms.TabPage
    Friend WithEvents lstViewLager As System.Windows.Forms.ListView
    Friend WithEvents lstViewDrittanbieter As System.Windows.Forms.ListView
    Friend WithEvents lstViewNachbestellungen As System.Windows.Forms.ListView
End Class
