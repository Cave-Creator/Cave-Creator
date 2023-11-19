<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SublevelTreasures
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SublevelTreasures))
        Me.num_treasureCount = New System.Windows.Forms.NumericUpDown()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.num_treasureWeight = New System.Windows.Forms.NumericUpDown()
        Me.lst_TreasuresNorm = New System.Windows.Forms.ListBox()
        Me.btn_DeleteAllTreasures = New System.Windows.Forms.Button()
        Me.btn_DeleteSelectedTreasure = New System.Windows.Forms.Button()
        Me.btn_AddTreasure = New System.Windows.Forms.Button()
        Me.cmb_Treasures = New System.Windows.Forms.ComboBox()
        Me.lbl_SublevelName = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.num_treasureCount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_treasureWeight, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'num_treasureCount
        '
        Me.num_treasureCount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.num_treasureCount.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.num_treasureCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.num_treasureCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.num_treasureCount.ForeColor = System.Drawing.Color.White
        Me.num_treasureCount.Location = New System.Drawing.Point(270, 27)
        Me.num_treasureCount.Maximum = New Decimal(New Integer() {9, 0, 0, 0})
        Me.num_treasureCount.Name = "num_treasureCount"
        Me.num_treasureCount.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.num_treasureCount.Size = New System.Drawing.Size(56, 22)
        Me.num_treasureCount.TabIndex = 63
        Me.num_treasureCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.num_treasureCount.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label24
        '
        Me.Label24.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.White
        Me.Label24.Location = New System.Drawing.Point(253, 29)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(16, 20)
        Me.Label24.TabIndex = 62
        Me.Label24.Text = "x"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.White
        Me.Label23.Location = New System.Drawing.Point(12, 160)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(98, 13)
        Me.Label23.TabIndex = 61
        Me.Label23.Text = "Weight (advanced)"
        '
        'num_treasureWeight
        '
        Me.num_treasureWeight.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.num_treasureWeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.num_treasureWeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.num_treasureWeight.ForeColor = System.Drawing.Color.White
        Me.num_treasureWeight.Location = New System.Drawing.Point(15, 176)
        Me.num_treasureWeight.Maximum = New Decimal(New Integer() {9, 0, 0, 0})
        Me.num_treasureWeight.Name = "num_treasureWeight"
        Me.num_treasureWeight.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.num_treasureWeight.Size = New System.Drawing.Size(113, 22)
        Me.num_treasureWeight.TabIndex = 60
        Me.num_treasureWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lst_TreasuresNorm
        '
        Me.lst_TreasuresNorm.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lst_TreasuresNorm.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lst_TreasuresNorm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lst_TreasuresNorm.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_TreasuresNorm.ForeColor = System.Drawing.Color.White
        Me.lst_TreasuresNorm.FormattingEnabled = True
        Me.lst_TreasuresNorm.IntegralHeight = False
        Me.lst_TreasuresNorm.ItemHeight = 18
        Me.lst_TreasuresNorm.Location = New System.Drawing.Point(137, 57)
        Me.lst_TreasuresNorm.Name = "lst_TreasuresNorm"
        Me.lst_TreasuresNorm.Size = New System.Drawing.Size(189, 141)
        Me.lst_TreasuresNorm.TabIndex = 59
        '
        'btn_DeleteAllTreasures
        '
        Me.btn_DeleteAllTreasures.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_DeleteAllTreasures.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_DeleteAllTreasures.Enabled = False
        Me.btn_DeleteAllTreasures.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btn_DeleteAllTreasures.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_DeleteAllTreasures.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_DeleteAllTreasures.ForeColor = System.Drawing.Color.White
        Me.btn_DeleteAllTreasures.Location = New System.Drawing.Point(15, 119)
        Me.btn_DeleteAllTreasures.Name = "btn_DeleteAllTreasures"
        Me.btn_DeleteAllTreasures.Size = New System.Drawing.Size(116, 26)
        Me.btn_DeleteAllTreasures.TabIndex = 58
        Me.btn_DeleteAllTreasures.Text = "Delete All"
        Me.btn_DeleteAllTreasures.UseVisualStyleBackColor = False
        '
        'btn_DeleteSelectedTreasure
        '
        Me.btn_DeleteSelectedTreasure.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_DeleteSelectedTreasure.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_DeleteSelectedTreasure.Enabled = False
        Me.btn_DeleteSelectedTreasure.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btn_DeleteSelectedTreasure.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_DeleteSelectedTreasure.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_DeleteSelectedTreasure.ForeColor = System.Drawing.Color.White
        Me.btn_DeleteSelectedTreasure.Location = New System.Drawing.Point(15, 88)
        Me.btn_DeleteSelectedTreasure.Name = "btn_DeleteSelectedTreasure"
        Me.btn_DeleteSelectedTreasure.Size = New System.Drawing.Size(116, 26)
        Me.btn_DeleteSelectedTreasure.TabIndex = 57
        Me.btn_DeleteSelectedTreasure.Text = "Delete Selected"
        Me.btn_DeleteSelectedTreasure.UseVisualStyleBackColor = False
        '
        'btn_AddTreasure
        '
        Me.btn_AddTreasure.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_AddTreasure.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_AddTreasure.Enabled = False
        Me.btn_AddTreasure.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btn_AddTreasure.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_AddTreasure.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_AddTreasure.ForeColor = System.Drawing.Color.White
        Me.btn_AddTreasure.Location = New System.Drawing.Point(15, 57)
        Me.btn_AddTreasure.Name = "btn_AddTreasure"
        Me.btn_AddTreasure.Size = New System.Drawing.Size(116, 26)
        Me.btn_AddTreasure.TabIndex = 56
        Me.btn_AddTreasure.Text = "Add"
        Me.btn_AddTreasure.UseVisualStyleBackColor = False
        '
        'cmb_Treasures
        '
        Me.cmb_Treasures.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmb_Treasures.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Treasures.FormattingEnabled = True
        Me.cmb_Treasures.Items.AddRange(New Object() {"Abstract Masterpiece", "Activity Arouser", "Adamantine Girdle", "Air Brake", "Alien Billboard", "Amplified Amplifier", "Anti-hiccup Fungus", "Anxious Sprout", "Aquatic Mine", "Arboreal Frippery", "Armored Nut", "Behemoth Jaw", "Boom Cone", "Boss Stone", "Broken Food Master", "Brute Knuckles", "Bug Bait", "Chance Totem", "Child of the Earth", "Chocolate Cushion", "Citrus Lump", "Coiled Launcher", "Colossal Fossil", "Combustion Berry", "Comedy Bomb", "Comfort Cookie", "Compelling Cookie", "Confection Hoop", "Conifer Spire", "Corpulent Nut", "Cosmic Archive", "Courage Reactor", "Creative Inspiration", "Crystal Clover", "Crystal King", "Crystallized Clairvoyance", "Crystallized Telekinesis", "Crystallized Telepathy", "Cupid's Grenade", "Danger Chime", "Decorative Goo", "Diet Doomer", "Dimensional Slicer", "Directory of Destiny", "Disguised Delicacy", "Doomsday Apparatus", "Dream Architect", "Dream Material", "Drone Supplies", "Drought Ender", "Durable Energy Cell", "Emperor Whistle", "Enamel Buster", "Endless Repository", "Essence of Desire", "Essence of Despair", "Essence of Rage", "Essence of True Love", "Essential Furnishing", "Eternal Emerald Eye", "Exhausted Superstick", "Extreme Perspirator", "Favorite Gyro Block", "Five-man Napsack", "Flame of Tomorrow", "Flame Tiller", "Flare Cannon", "Fleeting Art Form", "Fond Gyro Block", "Forged Courage", "Fortified Delicacy", "Fossilized Ursidae", "Frosty Bauble", "Fruit Guard", "Fuel Reservoir", "Furious Adhesive", "Future Orb", "Gemstar Husband", "Gemstar Wife", "Geographic Projection", "Gherkin Gate", "Glee Spinner", "Growshroom", "Gyroid Bust", "Happiness Emblem", "Harmonic Synthesizer", "Healing Cask", "Heavy-Duty Magnetizer", "Hideous Victual", "Hypnotic Platter", "Icon of Progress", "Impediment Scourge", "Impenetrable Cookie", "Imperative Cookie", "Implement of Toil", "Indomitable CPU", "Infernal Vegetable", "Innocence Lost", "Insect Condo", "Invigorator", "Joy Receptacle", "Joyless Jewel", "Justice Alloy", "King of Bugs", "King of Sweets", "Leviathan Feather", "Lip Service", "Lost Gyro Block", "Love Nugget", "Love Sphere", "Luck Wafer", "Lustrous Element", "Manual Honer", "Massage Girdle", "Massive Lid", "Master's Instrument", "Maternal Sculpture", "Meat of Champions", "Meat Satchel", "Memorable Gyro Block", "Memorial Shell", "Merciless Extractor", "Milk Tub", "Mirrored Element", "Mirrored Stage", "Mirth Sphere", "Monster Pump", "Mysterious Remains", "Mystical Disc", "Network Mainbrain", "Nouveau Table", "Nutrient Silo", "Olimarnite Shell", "Omega Flywheel", "Omniscient Sphere", "Onion Replica", "Optical Illustration", "Pale Passion", "Paradoxical Enigma", "Pastry Wheel", "Patience Tester", "Petrified Heart", "Pilgrim Bulb", "Pink Menace", "Pondering Emblem", "Possessed Squash", "Priceless Statue", "Princess Pearl", "Professional Noisemaker", "Proton AA", "Prototype Detector", "Quenching Emblem", "Regal Diamond", "Remembered Old Buddy", "Repair Juggernaut", "Repugnant Appendage", "Rubber Ugly", "Salivatrix", "Science Project", "Scrumptious Shell", "Seed of Greed", "Shock Therapist", "Silencer", "Space Wave Receiver", "Spherical Atlas", "Spiny Alien Treat", "Spirit Flogger", "Spouse Alert", "Stellar Orb", "Stone of Glory", "Strife Monolith", "Stringent Container", "Stupendous Lens", "Succulent Mattress", "Sud Generator", "Sulking Antenna", "Sunseed Berry", "Superstick Textile", "Superstrong Stabilizer", "Survival Ointment", "Sweet Dreamer", "Talisman of Life", "Taste Sensation", "Tear Stone", "Temporal Mechanism", "The Key", "Thirst Activator", "Time Capsule", "Toxic Toadstool", "Treasured Gyro Block", "Triple Sugar Threat", "Universal Com", "Unknown Merit", "Unspeakable Wonder", "Utter Scrap", "Vacuum Processor", "Vorpal Platter", "White Goodness", "Wiggle Noggin", "Worthless Statue", "Yellow Taste Tyrant"})
        Me.cmb_Treasures.Location = New System.Drawing.Point(15, 28)
        Me.cmb_Treasures.Name = "cmb_Treasures"
        Me.cmb_Treasures.Size = New System.Drawing.Size(236, 21)
        Me.cmb_Treasures.TabIndex = 55
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
        Me.lbl_SublevelName.TabIndex = 65
        Me.lbl_SublevelName.Text = "Nothing Selected"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 204)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(339, 56)
        Me.Panel1.TabIndex = 66
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(256, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(70, 32)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Done"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'SublevelTreasures
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(339, 260)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.num_treasureCount)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.cmb_Treasures)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.btn_AddTreasure)
        Me.Controls.Add(Me.num_treasureWeight)
        Me.Controls.Add(Me.btn_DeleteSelectedTreasure)
        Me.Controls.Add(Me.lst_TreasuresNorm)
        Me.Controls.Add(Me.btn_DeleteAllTreasures)
        Me.Controls.Add(Me.lbl_SublevelName)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(355, 299)
        Me.Name = "SublevelTreasures"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Treasures"
        CType(Me.num_treasureCount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_treasureWeight, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents num_treasureCount As NumericUpDown
    Friend WithEvents Label24 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents num_treasureWeight As NumericUpDown
    Friend WithEvents lst_TreasuresNorm As ListBox
    Friend WithEvents btn_DeleteAllTreasures As Button
    Friend WithEvents btn_DeleteSelectedTreasure As Button
    Friend WithEvents btn_AddTreasure As Button
    Friend WithEvents cmb_Treasures As ComboBox
    Friend WithEvents lbl_SublevelName As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
End Class
