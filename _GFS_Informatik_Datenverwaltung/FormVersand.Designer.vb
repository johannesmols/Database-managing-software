<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormVersand
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormVersand))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.BenutzerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UmmeldenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KonsoleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÖffnenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SchließenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TabControlVersand = New System.Windows.Forms.TabControl()
        Me.tabPageBestellungen = New System.Windows.Forms.TabPage()
        Me.lstViewBestellungen = New System.Windows.Forms.ListView()
        Me.tabPageLager = New System.Windows.Forms.TabPage()
        Me.lstViewLager = New System.Windows.Forms.ListView()
        Me.tabPageNachbestellungen = New System.Windows.Forms.TabPage()
        Me.lstViewNachbestellungen = New System.Windows.Forms.ListView()
        Me.tabPageVerkaufshistorie = New System.Windows.Forms.TabPage()
        Me.lstViewVerkaufshistorie = New System.Windows.Forms.ListView()
        Me.cmdVerschicken = New System.Windows.Forms.Button()
        Me.cmdAblehnen = New System.Windows.Forms.Button()
        Me.cmdNachbestellen = New System.Windows.Forms.Button()
        Me.cmdSuchen = New System.Windows.Forms.Button()
        Me.cmdAllesAnzeigen = New System.Windows.Forms.Button()
        Me.MenuStrip.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TabControlVersand.SuspendLayout()
        Me.tabPageBestellungen.SuspendLayout()
        Me.tabPageLager.SuspendLayout()
        Me.tabPageNachbestellungen.SuspendLayout()
        Me.tabPageVerkaufshistorie.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BenutzerToolStripMenuItem, Me.KonsoleToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(784, 24)
        Me.MenuStrip.TabIndex = 0
        Me.MenuStrip.Text = "MenuStrip"
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
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 7
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TabControlVersand, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.cmdVerschicken, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.cmdAblehnen, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.cmdNachbestellen, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.cmdSuchen, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.cmdAllesAnzeigen, 4, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 24)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(784, 438)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'TabControlVersand
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.TabControlVersand, 7)
        Me.TabControlVersand.Controls.Add(Me.tabPageBestellungen)
        Me.TabControlVersand.Controls.Add(Me.tabPageLager)
        Me.TabControlVersand.Controls.Add(Me.tabPageNachbestellungen)
        Me.TabControlVersand.Controls.Add(Me.tabPageVerkaufshistorie)
        Me.TabControlVersand.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlVersand.Location = New System.Drawing.Point(3, 33)
        Me.TabControlVersand.Name = "TabControlVersand"
        Me.TabControlVersand.SelectedIndex = 0
        Me.TabControlVersand.Size = New System.Drawing.Size(778, 402)
        Me.TabControlVersand.TabIndex = 0
        '
        'tabPageBestellungen
        '
        Me.tabPageBestellungen.Controls.Add(Me.lstViewBestellungen)
        Me.tabPageBestellungen.Location = New System.Drawing.Point(4, 22)
        Me.tabPageBestellungen.Name = "tabPageBestellungen"
        Me.tabPageBestellungen.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPageBestellungen.Size = New System.Drawing.Size(770, 376)
        Me.tabPageBestellungen.TabIndex = 0
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
        Me.lstViewBestellungen.Size = New System.Drawing.Size(764, 370)
        Me.lstViewBestellungen.TabIndex = 0
        Me.lstViewBestellungen.UseCompatibleStateImageBehavior = False
        Me.lstViewBestellungen.View = System.Windows.Forms.View.Details
        '
        'tabPageLager
        '
        Me.tabPageLager.Controls.Add(Me.lstViewLager)
        Me.tabPageLager.Location = New System.Drawing.Point(4, 22)
        Me.tabPageLager.Name = "tabPageLager"
        Me.tabPageLager.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPageLager.Size = New System.Drawing.Size(770, 376)
        Me.tabPageLager.TabIndex = 1
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
        Me.lstViewLager.Size = New System.Drawing.Size(764, 370)
        Me.lstViewLager.TabIndex = 0
        Me.lstViewLager.UseCompatibleStateImageBehavior = False
        Me.lstViewLager.View = System.Windows.Forms.View.Details
        '
        'tabPageNachbestellungen
        '
        Me.tabPageNachbestellungen.Controls.Add(Me.lstViewNachbestellungen)
        Me.tabPageNachbestellungen.Location = New System.Drawing.Point(4, 22)
        Me.tabPageNachbestellungen.Name = "tabPageNachbestellungen"
        Me.tabPageNachbestellungen.Size = New System.Drawing.Size(770, 376)
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
        Me.lstViewNachbestellungen.Size = New System.Drawing.Size(770, 376)
        Me.lstViewNachbestellungen.TabIndex = 0
        Me.lstViewNachbestellungen.UseCompatibleStateImageBehavior = False
        Me.lstViewNachbestellungen.View = System.Windows.Forms.View.Details
        '
        'tabPageVerkaufshistorie
        '
        Me.tabPageVerkaufshistorie.Controls.Add(Me.lstViewVerkaufshistorie)
        Me.tabPageVerkaufshistorie.Location = New System.Drawing.Point(4, 22)
        Me.tabPageVerkaufshistorie.Name = "tabPageVerkaufshistorie"
        Me.tabPageVerkaufshistorie.Size = New System.Drawing.Size(770, 376)
        Me.tabPageVerkaufshistorie.TabIndex = 3
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
        Me.lstViewVerkaufshistorie.Size = New System.Drawing.Size(770, 376)
        Me.lstViewVerkaufshistorie.TabIndex = 0
        Me.lstViewVerkaufshistorie.UseCompatibleStateImageBehavior = False
        Me.lstViewVerkaufshistorie.View = System.Windows.Forms.View.Details
        '
        'cmdVerschicken
        '
        Me.cmdVerschicken.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.cmdVerschicken.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdVerschicken.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdVerschicken.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdVerschicken.Location = New System.Drawing.Point(3, 3)
        Me.cmdVerschicken.Name = "cmdVerschicken"
        Me.cmdVerschicken.Size = New System.Drawing.Size(111, 24)
        Me.cmdVerschicken.TabIndex = 1
        Me.cmdVerschicken.Text = "Verschicken"
        Me.cmdVerschicken.UseVisualStyleBackColor = False
        '
        'cmdAblehnen
        '
        Me.cmdAblehnen.BackColor = System.Drawing.Color.LightCoral
        Me.cmdAblehnen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdAblehnen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAblehnen.Location = New System.Drawing.Point(120, 3)
        Me.cmdAblehnen.Name = "cmdAblehnen"
        Me.cmdAblehnen.Size = New System.Drawing.Size(111, 24)
        Me.cmdAblehnen.TabIndex = 2
        Me.cmdAblehnen.Text = "Ablehnen"
        Me.cmdAblehnen.UseVisualStyleBackColor = False
        '
        'cmdNachbestellen
        '
        Me.cmdNachbestellen.BackColor = System.Drawing.Color.Khaki
        Me.cmdNachbestellen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdNachbestellen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdNachbestellen.Location = New System.Drawing.Point(237, 3)
        Me.cmdNachbestellen.Name = "cmdNachbestellen"
        Me.cmdNachbestellen.Size = New System.Drawing.Size(111, 24)
        Me.cmdNachbestellen.TabIndex = 3
        Me.cmdNachbestellen.Text = "Nachbestellen"
        Me.cmdNachbestellen.UseVisualStyleBackColor = False
        '
        'cmdSuchen
        '
        Me.cmdSuchen.BackColor = System.Drawing.Color.LightBlue
        Me.cmdSuchen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdSuchen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSuchen.Location = New System.Drawing.Point(354, 3)
        Me.cmdSuchen.Name = "cmdSuchen"
        Me.cmdSuchen.Size = New System.Drawing.Size(111, 24)
        Me.cmdSuchen.TabIndex = 4
        Me.cmdSuchen.Text = "Suchen"
        Me.cmdSuchen.UseVisualStyleBackColor = False
        '
        'cmdAllesAnzeigen
        '
        Me.cmdAllesAnzeigen.BackColor = System.Drawing.Color.Wheat
        Me.cmdAllesAnzeigen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdAllesAnzeigen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAllesAnzeigen.Location = New System.Drawing.Point(471, 3)
        Me.cmdAllesAnzeigen.Name = "cmdAllesAnzeigen"
        Me.cmdAllesAnzeigen.Size = New System.Drawing.Size(111, 24)
        Me.cmdAllesAnzeigen.TabIndex = 5
        Me.cmdAllesAnzeigen.Text = "Alles anzeigen"
        Me.cmdAllesAnzeigen.UseVisualStyleBackColor = False
        '
        'FormVersand
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 462)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.MenuStrip)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip
        Me.MinimumSize = New System.Drawing.Size(800, 500)
        Me.Name = "FormVersand"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Versand"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TabControlVersand.ResumeLayout(False)
        Me.tabPageBestellungen.ResumeLayout(False)
        Me.tabPageLager.ResumeLayout(False)
        Me.tabPageNachbestellungen.ResumeLayout(False)
        Me.tabPageVerkaufshistorie.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

End Sub
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents BenutzerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UmmeldenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KonsoleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ÖffnenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SchließenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TabControlVersand As System.Windows.Forms.TabControl
    Friend WithEvents tabPageBestellungen As System.Windows.Forms.TabPage
    Friend WithEvents tabPageLager As System.Windows.Forms.TabPage
    Friend WithEvents tabPageNachbestellungen As System.Windows.Forms.TabPage
    Friend WithEvents tabPageVerkaufshistorie As System.Windows.Forms.TabPage
    Friend WithEvents cmdVerschicken As System.Windows.Forms.Button
    Friend WithEvents cmdAblehnen As System.Windows.Forms.Button
    Friend WithEvents cmdNachbestellen As System.Windows.Forms.Button
    Friend WithEvents cmdSuchen As System.Windows.Forms.Button
    Friend WithEvents cmdAllesAnzeigen As System.Windows.Forms.Button
    Friend WithEvents lstViewBestellungen As System.Windows.Forms.ListView
    Friend WithEvents lstViewLager As System.Windows.Forms.ListView
    Friend WithEvents lstViewNachbestellungen As System.Windows.Forms.ListView
    Friend WithEvents lstViewVerkaufshistorie As System.Windows.Forms.ListView
End Class
