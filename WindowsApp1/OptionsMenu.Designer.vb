<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class OptionsMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OptionsMenu))
        Me.txt_RootDirectory = New System.Windows.Forms.TextBox()
        Me.btn_LoadRoot = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_Reset = New System.Windows.Forms.Button()
        Me.btn_CancelOptions = New System.Windows.Forms.Button()
        Me.chk_Autosave = New System.Windows.Forms.CheckBox()
        Me.cmb_Autosave = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmb_DoubleClickSublevel = New System.Windows.Forms.ComboBox()
        Me.btn_OK = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txt_RootDirectory
        '
        Me.txt_RootDirectory.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_RootDirectory.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_RootDirectory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_RootDirectory.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_RootDirectory.ForeColor = System.Drawing.Color.White
        Me.txt_RootDirectory.Location = New System.Drawing.Point(12, 27)
        Me.txt_RootDirectory.Name = "txt_RootDirectory"
        Me.txt_RootDirectory.ReadOnly = True
        Me.txt_RootDirectory.Size = New System.Drawing.Size(253, 26)
        Me.txt_RootDirectory.TabIndex = 28
        '
        'btn_LoadRoot
        '
        Me.btn_LoadRoot.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_LoadRoot.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_LoadRoot.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.btn_LoadRoot.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btn_LoadRoot.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_LoadRoot.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_LoadRoot.ForeColor = System.Drawing.Color.White
        Me.btn_LoadRoot.Location = New System.Drawing.Point(271, 27)
        Me.btn_LoadRoot.Name = "btn_LoadRoot"
        Me.btn_LoadRoot.Size = New System.Drawing.Size(66, 26)
        Me.btn_LoadRoot.TabIndex = 27
        Me.btn_LoadRoot.Text = "Browse..."
        Me.btn_LoadRoot.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(9, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 18)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Default root directory"
        '
        'btn_Reset
        '
        Me.btn_Reset.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Reset.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_Reset.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.btn_Reset.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btn_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Reset.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Reset.ForeColor = System.Drawing.Color.White
        Me.btn_Reset.Location = New System.Drawing.Point(12, 256)
        Me.btn_Reset.Name = "btn_Reset"
        Me.btn_Reset.Size = New System.Drawing.Size(128, 26)
        Me.btn_Reset.TabIndex = 33
        Me.btn_Reset.Text = "Reset to Default"
        Me.btn_Reset.UseVisualStyleBackColor = False
        '
        'btn_CancelOptions
        '
        Me.btn_CancelOptions.BackColor = System.Drawing.Color.Red
        Me.btn_CancelOptions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_CancelOptions.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_CancelOptions.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_CancelOptions.ForeColor = System.Drawing.Color.White
        Me.btn_CancelOptions.Location = New System.Drawing.Point(245, 518)
        Me.btn_CancelOptions.Name = "btn_CancelOptions"
        Me.btn_CancelOptions.Size = New System.Drawing.Size(61, 26)
        Me.btn_CancelOptions.TabIndex = 38
        Me.btn_CancelOptions.Text = "Cancel"
        Me.btn_CancelOptions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_CancelOptions.UseVisualStyleBackColor = False
        Me.btn_CancelOptions.Visible = False
        '
        'chk_Autosave
        '
        Me.chk_Autosave.BackColor = System.Drawing.Color.Transparent
        Me.chk_Autosave.Cursor = System.Windows.Forms.Cursors.Default
        Me.chk_Autosave.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_Autosave.ForeColor = System.Drawing.Color.White
        Me.chk_Autosave.Location = New System.Drawing.Point(12, 115)
        Me.chk_Autosave.Name = "chk_Autosave"
        Me.chk_Autosave.Size = New System.Drawing.Size(85, 20)
        Me.chk_Autosave.TabIndex = 42
        Me.chk_Autosave.Text = "Autosave"
        Me.chk_Autosave.UseVisualStyleBackColor = False
        '
        'cmb_Autosave
        '
        Me.cmb_Autosave.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmb_Autosave.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Autosave.Enabled = False
        Me.cmb_Autosave.FormattingEnabled = True
        Me.cmb_Autosave.Items.AddRange(New Object() {"Every 30 minutes", "Every 10 minutes", "Every 5 minutes", "Every minute"})
        Me.cmb_Autosave.Location = New System.Drawing.Point(94, 114)
        Me.cmb_Autosave.Name = "cmb_Autosave"
        Me.cmb_Autosave.Size = New System.Drawing.Size(243, 21)
        Me.cmb_Autosave.TabIndex = 43
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(9, 168)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(229, 18)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "Double-clicking a sublevel opens...."
        '
        'cmb_DoubleClickSublevel
        '
        Me.cmb_DoubleClickSublevel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmb_DoubleClickSublevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_DoubleClickSublevel.FormattingEnabled = True
        Me.cmb_DoubleClickSublevel.Items.AddRange(New Object() {"Properties", "Entities", "Treasures", "Gates"})
        Me.cmb_DoubleClickSublevel.Location = New System.Drawing.Point(12, 189)
        Me.cmb_DoubleClickSublevel.Name = "cmb_DoubleClickSublevel"
        Me.cmb_DoubleClickSublevel.Size = New System.Drawing.Size(325, 21)
        Me.cmb_DoubleClickSublevel.TabIndex = 45
        '
        'btn_OK
        '
        Me.btn_OK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_OK.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_OK.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.btn_OK.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btn_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_OK.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_OK.ForeColor = System.Drawing.Color.White
        Me.btn_OK.Location = New System.Drawing.Point(262, 256)
        Me.btn_OK.Name = "btn_OK"
        Me.btn_OK.Size = New System.Drawing.Size(75, 26)
        Me.btn_OK.TabIndex = 46
        Me.btn_OK.Text = "OK"
        Me.btn_OK.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(12, 59)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(325, 26)
        Me.Button1.TabIndex = 47
        Me.Button1.Text = "Custom Directory Options..."
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(9, 138)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(258, 16)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "Save your project at least once to start autosave"
        '
        'OptionsMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(349, 291)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_OK)
        Me.Controls.Add(Me.cmb_DoubleClickSublevel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmb_Autosave)
        Me.Controls.Add(Me.chk_Autosave)
        Me.Controls.Add(Me.btn_CancelOptions)
        Me.Controls.Add(Me.btn_Reset)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_RootDirectory)
        Me.Controls.Add(Me.btn_LoadRoot)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(365, 330)
        Me.Name = "OptionsMenu"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Options"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_RootDirectory As TextBox
    Friend WithEvents btn_LoadRoot As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_Reset As Button
    Friend WithEvents btn_CancelOptions As Button
    Friend WithEvents chk_Autosave As CheckBox
    Friend WithEvents cmb_Autosave As ComboBox
    Friend WithEvents cmb_DoubleClickSublevel As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_OK As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
End Class
