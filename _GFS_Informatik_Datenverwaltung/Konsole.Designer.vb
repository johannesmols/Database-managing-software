<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Konsole
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Konsole))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtBox = New System.Windows.Forms.RichTextBox()
        Me.cmdKonsoleLeeren = New System.Windows.Forms.Button()
        Me.cmdSpeichern = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.txtBox, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.cmdKonsoleLeeren, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.cmdSpeichern, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(384, 466)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'txtBox
        '
        Me.txtBox.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TableLayoutPanel1.SetColumnSpan(Me.txtBox, 2)
        Me.txtBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBox.Location = New System.Drawing.Point(3, 3)
        Me.txtBox.Name = "txtBox"
        Me.txtBox.ReadOnly = True
        Me.txtBox.Size = New System.Drawing.Size(378, 430)
        Me.txtBox.TabIndex = 0
        Me.txtBox.Text = ""
        '
        'cmdKonsoleLeeren
        '
        Me.cmdKonsoleLeeren.BackColor = System.Drawing.Color.LightCoral
        Me.cmdKonsoleLeeren.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdKonsoleLeeren.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdKonsoleLeeren.Location = New System.Drawing.Point(3, 439)
        Me.cmdKonsoleLeeren.Name = "cmdKonsoleLeeren"
        Me.cmdKonsoleLeeren.Size = New System.Drawing.Size(186, 24)
        Me.cmdKonsoleLeeren.TabIndex = 1
        Me.cmdKonsoleLeeren.Text = "Konsole leeren"
        Me.cmdKonsoleLeeren.UseVisualStyleBackColor = False
        '
        'cmdSpeichern
        '
        Me.cmdSpeichern.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.cmdSpeichern.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdSpeichern.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSpeichern.Location = New System.Drawing.Point(195, 439)
        Me.cmdSpeichern.Name = "cmdSpeichern"
        Me.cmdSpeichern.Size = New System.Drawing.Size(186, 24)
        Me.cmdSpeichern.TabIndex = 2
        Me.cmdSpeichern.Text = "Speichern"
        Me.cmdSpeichern.UseVisualStyleBackColor = False
        '
        'Konsole
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 466)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(300, 300)
        Me.Name = "Konsole"
        Me.Text = "Konsole"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents txtBox As System.Windows.Forms.RichTextBox
    Friend WithEvents cmdKonsoleLeeren As System.Windows.Forms.Button
    Friend WithEvents cmdSpeichern As System.Windows.Forms.Button
End Class
