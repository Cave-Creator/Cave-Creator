<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SublevelGates
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SublevelGates))
        Me.lnk_GateHelp = New System.Windows.Forms.LinkLabel()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.num_GateHP = New System.Windows.Forms.NumericUpDown()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.num_GateWeight = New System.Windows.Forms.NumericUpDown()
        Me.lst_GatesNorm = New System.Windows.Forms.ListBox()
        Me.btn_DeleteAllGates = New System.Windows.Forms.Button()
        Me.btn_DeleteSelectedGate = New System.Windows.Forms.Button()
        Me.btn_AddGate = New System.Windows.Forms.Button()
        Me.lbl_SublevelName = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.num_GateHP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_GateWeight, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lnk_GateHelp
        '
        Me.lnk_GateHelp.AutoSize = True
        Me.lnk_GateHelp.BackColor = System.Drawing.Color.Transparent
        Me.lnk_GateHelp.LinkColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lnk_GateHelp.Location = New System.Drawing.Point(80, 32)
        Me.lnk_GateHelp.Name = "lnk_GateHelp"
        Me.lnk_GateHelp.Size = New System.Drawing.Size(13, 13)
        Me.lnk_GateHelp.TabIndex = 75
        Me.lnk_GateHelp.TabStop = True
        Me.lnk_GateHelp.Text = "?"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.BackColor = System.Drawing.Color.Transparent
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.White
        Me.Label27.Location = New System.Drawing.Point(11, 29)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(71, 20)
        Me.Label27.TabIndex = 74
        Me.Label27.Text = "Gate HP"
        '
        'num_GateHP
        '
        Me.num_GateHP.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.num_GateHP.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.num_GateHP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.num_GateHP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.num_GateHP.ForeColor = System.Drawing.Color.White
        Me.num_GateHP.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.num_GateHP.Location = New System.Drawing.Point(99, 27)
        Me.num_GateHP.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.num_GateHP.Name = "num_GateHP"
        Me.num_GateHP.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.num_GateHP.Size = New System.Drawing.Size(225, 22)
        Me.num_GateHP.TabIndex = 72
        Me.num_GateHP.Value = New Decimal(New Integer() {1000, 0, 0, 0})
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.Color.Transparent
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.White
        Me.Label26.Location = New System.Drawing.Point(12, 160)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(98, 13)
        Me.Label26.TabIndex = 70
        Me.Label26.Text = "Weight (advanced)"
        Me.Label26.Visible = False
        '
        'num_GateWeight
        '
        Me.num_GateWeight.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.num_GateWeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.num_GateWeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.num_GateWeight.ForeColor = System.Drawing.Color.White
        Me.num_GateWeight.Location = New System.Drawing.Point(15, 176)
        Me.num_GateWeight.Maximum = New Decimal(New Integer() {9, 0, 0, 0})
        Me.num_GateWeight.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.num_GateWeight.Name = "num_GateWeight"
        Me.num_GateWeight.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.num_GateWeight.Size = New System.Drawing.Size(116, 22)
        Me.num_GateWeight.TabIndex = 69
        Me.num_GateWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.num_GateWeight.Value = New Decimal(New Integer() {1, 0, 0, 0})
        Me.num_GateWeight.Visible = False
        '
        'lst_GatesNorm
        '
        Me.lst_GatesNorm.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lst_GatesNorm.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lst_GatesNorm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lst_GatesNorm.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_GatesNorm.ForeColor = System.Drawing.Color.White
        Me.lst_GatesNorm.FormattingEnabled = True
        Me.lst_GatesNorm.IntegralHeight = False
        Me.lst_GatesNorm.ItemHeight = 18
        Me.lst_GatesNorm.Location = New System.Drawing.Point(137, 55)
        Me.lst_GatesNorm.Name = "lst_GatesNorm"
        Me.lst_GatesNorm.Size = New System.Drawing.Size(188, 143)
        Me.lst_GatesNorm.TabIndex = 68
        '
        'btn_DeleteAllGates
        '
        Me.btn_DeleteAllGates.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_DeleteAllGates.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.btn_DeleteAllGates.Enabled = False
        Me.btn_DeleteAllGates.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btn_DeleteAllGates.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_DeleteAllGates.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_DeleteAllGates.ForeColor = System.Drawing.Color.White
        Me.btn_DeleteAllGates.Location = New System.Drawing.Point(15, 117)
        Me.btn_DeleteAllGates.Name = "btn_DeleteAllGates"
        Me.btn_DeleteAllGates.Size = New System.Drawing.Size(116, 26)
        Me.btn_DeleteAllGates.TabIndex = 67
        Me.btn_DeleteAllGates.Text = "Delete All"
        Me.btn_DeleteAllGates.UseVisualStyleBackColor = False
        '
        'btn_DeleteSelectedGate
        '
        Me.btn_DeleteSelectedGate.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_DeleteSelectedGate.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.btn_DeleteSelectedGate.Enabled = False
        Me.btn_DeleteSelectedGate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btn_DeleteSelectedGate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_DeleteSelectedGate.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_DeleteSelectedGate.ForeColor = System.Drawing.Color.White
        Me.btn_DeleteSelectedGate.Location = New System.Drawing.Point(15, 86)
        Me.btn_DeleteSelectedGate.Name = "btn_DeleteSelectedGate"
        Me.btn_DeleteSelectedGate.Size = New System.Drawing.Size(116, 26)
        Me.btn_DeleteSelectedGate.TabIndex = 66
        Me.btn_DeleteSelectedGate.Text = "Delete Selected"
        Me.btn_DeleteSelectedGate.UseVisualStyleBackColor = False
        '
        'btn_AddGate
        '
        Me.btn_AddGate.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_AddGate.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.btn_AddGate.Enabled = False
        Me.btn_AddGate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btn_AddGate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_AddGate.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_AddGate.ForeColor = System.Drawing.Color.White
        Me.btn_AddGate.Location = New System.Drawing.Point(15, 55)
        Me.btn_AddGate.Name = "btn_AddGate"
        Me.btn_AddGate.Size = New System.Drawing.Size(116, 26)
        Me.btn_AddGate.TabIndex = 65
        Me.btn_AddGate.Text = "Add"
        Me.btn_AddGate.UseVisualStyleBackColor = False
        '
        'lbl_SublevelName
        '
        Me.lbl_SublevelName.AutoSize = True
        Me.lbl_SublevelName.BackColor = System.Drawing.Color.Transparent
        Me.lbl_SublevelName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_SublevelName.ForeColor = System.Drawing.Color.White
        Me.lbl_SublevelName.Location = New System.Drawing.Point(12, 9)
        Me.lbl_SublevelName.Name = "lbl_SublevelName"
        Me.lbl_SublevelName.Size = New System.Drawing.Size(111, 16)
        Me.lbl_SublevelName.TabIndex = 76
        Me.lbl_SublevelName.Text = "Nothing Selected"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(255, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(70, 32)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Done"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 204)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(339, 56)
        Me.Panel1.TabIndex = 77
        '
        'SublevelGates
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(339, 260)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lnk_GateHelp)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.num_GateHP)
        Me.Controls.Add(Me.btn_AddGate)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.btn_DeleteSelectedGate)
        Me.Controls.Add(Me.num_GateWeight)
        Me.Controls.Add(Me.btn_DeleteAllGates)
        Me.Controls.Add(Me.lst_GatesNorm)
        Me.Controls.Add(Me.lbl_SublevelName)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(355, 299)
        Me.Name = "SublevelGates"
        Me.Text = "Gates"
        CType(Me.num_GateHP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_GateWeight, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lnk_GateHelp As LinkLabel
    Friend WithEvents Label27 As Label
    Friend WithEvents num_GateHP As NumericUpDown
    Friend WithEvents Label26 As Label
    Friend WithEvents num_GateWeight As NumericUpDown
    Friend WithEvents lst_GatesNorm As ListBox
    Friend WithEvents btn_DeleteAllGates As Button
    Friend WithEvents btn_DeleteSelectedGate As Button
    Friend WithEvents btn_AddGate As Button
    Friend WithEvents lbl_SublevelName As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
End Class
