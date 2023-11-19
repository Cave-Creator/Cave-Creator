<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lst_Sublevels = New System.Windows.Forms.ListBox()
        Me.cms_SublevelsListbox = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lbl_SublevelTotal = New System.Windows.Forms.Label()
        Me.lst_Sublevel_IDs = New System.Windows.Forms.ListBox()
        Me.lst_SublevelNames = New System.Windows.Forms.ListBox()
        Me.chk_SublevelNameInput = New System.Windows.Forms.CheckBox()
        Me.lst_RegularEntities = New System.Windows.Forms.ListBox()
        Me.btn_MoveSublevelDown = New System.Windows.Forms.Button()
        Me.btn_MoveSublevelUp = New System.Windows.Forms.Button()
        Me.lbl_SublevelID = New System.Windows.Forms.Label()
        Me.btn_RenameSublevel = New System.Windows.Forms.Button()
        Me.lst_RegularEntitiesCounts = New System.Windows.Forms.ListBox()
        Me.btn_RemoveSublevelName = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tbp_SublevelManager = New System.Windows.Forms.TabPage()
        Me.btn_DeleteAllSublevels3 = New System.Windows.Forms.Button()
        Me.btn_RemoveSublevel2 = New System.Windows.Forms.Button()
        Me.btn_AddSublevel2 = New System.Windows.Forms.Button()
        Me.btn_DuplicateSub = New System.Windows.Forms.Button()
        Me.btn_Gates = New System.Windows.Forms.Button()
        Me.btn_Entities = New System.Windows.Forms.Button()
        Me.btn_Treasures = New System.Windows.Forms.Button()
        Me.chk_DeleteSublevelQ = New System.Windows.Forms.CheckBox()
        Me.lbl_TotalEntityCount = New System.Windows.Forms.Label()
        Me.lbl_EntityCount = New System.Windows.Forms.Label()
        Me.btn_SublevelProperties = New System.Windows.Forms.Button()
        Me.lbl_SelectedSublevelTitle = New System.Windows.Forms.Label()
        Me.tbp_ChallengeModeProperties = New System.Windows.Forms.TabPage()
        Me.btn_TimeHelp = New System.Windows.Forms.Button()
        Me.num_TimerTime = New System.Windows.Forms.NumericUpDown()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.lbl_CMsaved = New System.Windows.Forms.Label()
        Me.lst_Times = New System.Windows.Forms.ListBox()
        Me.num_CMPsubCount = New System.Windows.Forms.NumericUpDown()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.chk_CMPadvanced = New System.Windows.Forms.CheckBox()
        Me.btn_ImportChallengeModeProperties = New System.Windows.Forms.Button()
        Me.lbl_PikiCount = New System.Windows.Forms.Label()
        Me.lbl_100pikiReminder = New System.Windows.Forms.Label()
        Me.num_ubs = New System.Windows.Forms.NumericUpDown()
        Me.num_uss = New System.Windows.Forms.NumericUpDown()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.num_cL = New System.Windows.Forms.NumericUpDown()
        Me.num_cF = New System.Windows.Forms.NumericUpDown()
        Me.num_bulbL = New System.Windows.Forms.NumericUpDown()
        Me.num_cB = New System.Windows.Forms.NumericUpDown()
        Me.num_bulbB = New System.Windows.Forms.NumericUpDown()
        Me.num_rL = New System.Windows.Forms.NumericUpDown()
        Me.num_yL = New System.Windows.Forms.NumericUpDown()
        Me.num_bL = New System.Windows.Forms.NumericUpDown()
        Me.num_wL = New System.Windows.Forms.NumericUpDown()
        Me.num_pL = New System.Windows.Forms.NumericUpDown()
        Me.num_rB = New System.Windows.Forms.NumericUpDown()
        Me.num_yB = New System.Windows.Forms.NumericUpDown()
        Me.num_bB = New System.Windows.Forms.NumericUpDown()
        Me.num_wB = New System.Windows.Forms.NumericUpDown()
        Me.num_pF = New System.Windows.Forms.NumericUpDown()
        Me.num_pB = New System.Windows.Forms.NumericUpDown()
        Me.num_wF = New System.Windows.Forms.NumericUpDown()
        Me.num_rF = New System.Windows.Forms.NumericUpDown()
        Me.num_bF = New System.Windows.Forms.NumericUpDown()
        Me.num_yF = New System.Windows.Forms.NumericUpDown()
        Me.num_bulbF = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.pnl_CMPadvanced = New System.Windows.Forms.Panel()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.tbp_ImportManager = New System.Windows.Forms.TabPage()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.chk_ShowAdvanced = New System.Windows.Forms.CheckBox()
        Me.pnl_Controls = New System.Windows.Forms.Panel()
        Me.btn_getBase64 = New System.Windows.Forms.Button()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.btn_CMPcopyCode = New System.Windows.Forms.Button()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.btn_CopyMusicCode = New System.Windows.Forms.Button()
        Me.txt_RootDirectory = New System.Windows.Forms.TextBox()
        Me.lbl_AdditionalOptionsTitle = New System.Windows.Forms.Label()
        Me.btn_ImportCave = New System.Windows.Forms.Button()
        Me.cmb_ReplaceWith = New System.Windows.Forms.ComboBox()
        Me.chk_UseCMproperties = New System.Windows.Forms.CheckBox()
        Me.btn_LoadRoot = New System.Windows.Forms.Button()
        Me.btn_ExportCaveFile = New System.Windows.Forms.Button()
        Me.pnl_Advanced = New System.Windows.Forms.Panel()
        Me.chk_IgnoreTheKey = New System.Windows.Forms.CheckBox()
        Me.chk_IgnoreCaveMusic = New System.Windows.Forms.CheckBox()
        Me.opt_Main = New System.Windows.Forms.RadioButton()
        Me.opt_ChallengeMode = New System.Windows.Forms.RadioButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.opt_EnglishNames = New System.Windows.Forms.RadioButton()
        Me.opt_InternalNames = New System.Windows.Forms.RadioButton()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.lnk_ExportHelp = New System.Windows.Forms.LinkLabel()
        Me.btn_MoveEntityDown = New System.Windows.Forms.Button()
        Me.btn_MoveEntityUp = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.lbl_TotalEntityCountSubEnts = New System.Windows.Forms.Label()
        Me.cmb_Sublevels = New System.Windows.Forms.ComboBox()
        Me.btn_ChooseEntity = New System.Windows.Forms.Button()
        Me.btn_DeleteSelectedEntity = New System.Windows.Forms.Button()
        Me.pic_SelectedEntity = New System.Windows.Forms.PictureBox()
        Me.lbl_EntityName = New System.Windows.Forms.Label()
        Me.lbl_EntityTotalCount = New System.Windows.Forms.Label()
        Me.num_EntityCount = New System.Windows.Forms.NumericUpDown()
        Me.btn_AddEntity = New System.Windows.Forms.Button()
        Me.btn_ClearEntities = New System.Windows.Forms.Button()
        Me.lst_RegularEntitiesNormList = New System.Windows.Forms.ListBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_decoNoWeight = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.lbl_GroupCwarning = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.num_EntityWeight = New System.Windows.Forms.NumericUpDown()
        Me.cmb_DropTreasures = New System.Windows.Forms.ComboBox()
        Me.chk_EntityDropTreasure = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmb_EntitySpawnMethod = New System.Windows.Forms.ComboBox()
        Me.cmb_EntitySpawnLocation = New System.Windows.Forms.ComboBox()
        Me.opt_2PBattle = New System.Windows.Forms.RadioButton()
        Me.lst_TreasureSets = New System.Windows.Forms.ListBox()
        Me.lst_GateSets = New System.Windows.Forms.ListBox()
        Me.lst_Gates = New System.Windows.Forms.ListBox()
        Me.lst_Treasures = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_Debug = New System.Windows.Forms.TextBox()
        Me.pnl_Debug = New System.Windows.Forms.Panel()
        Me.lst_CustomEntityTotal_Check = New System.Windows.Forms.ListBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btn_DebugMode = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_Save = New System.Windows.Forms.Button()
        Me.lst_f2_CustomEntityTotal = New System.Windows.Forms.ListBox()
        Me.lst_totaka_MusicList = New System.Windows.Forms.ListBox()
        Me.opt_CMintNames = New System.Windows.Forms.RadioButton()
        Me.lst_f17_Seesaw = New System.Windows.Forms.ListBox()
        Me.lst_f16_WaterwraithTimer = New System.Windows.Forms.ListBox()
        Me.opt_CMengNames = New System.Windows.Forms.RadioButton()
        Me.lst_f14_DeadEndCount = New System.Windows.Forms.ListBox()
        Me.lst_f13_SolidPlane = New System.Windows.Forms.ListBox()
        Me.cmb_ChallengeModeCaves = New System.Windows.Forms.ComboBox()
        Me.lst_f12_MusicType = New System.Windows.Forms.ListBox()
        Me.lst_f10_CloggedHole = New System.Windows.Forms.ListBox()
        Me.lst_fa_Skybox = New System.Windows.Forms.ListBox()
        Me.lst_f9_LightFile = New System.Windows.Forms.ListBox()
        Me.lst_f8_UnitFile = New System.Windows.Forms.ListBox()
        Me.lst_RegularEntitiesList = New System.Windows.Forms.ListBox()
        Me.lst_f7_Geyser = New System.Windows.Forms.ListBox()
        Me.lst_f6_Ratio = New System.Windows.Forms.ListBox()
        Me.lst_f5_RoomCount = New System.Windows.Forms.ListBox()
        Me.btn_Focus = New System.Windows.Forms.Button()
        Me.lst_RegularEntitiesCountList = New System.Windows.Forms.ListBox()
        Me.SaveAsDialog = New System.Windows.Forms.SaveFileDialog()
        Me.LoadDialog = New System.Windows.Forms.OpenFileDialog()
        Me.ExportAsDialog = New System.Windows.Forms.SaveFileDialog()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btn_CloseEntities = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog_CMP = New System.Windows.Forms.FolderBrowserDialog()
        Me.RootBrowserDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btn_Load = New System.Windows.Forms.ToolStripButton()
        Me.btn_SaveAs = New System.Windows.Forms.ToolStripButton()
        Me.btn_SaveProject = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btn_ReturnToMainMenu = New System.Windows.Forms.ToolStripButton()
        Me.btn_CaveNet = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.pnl_Entities = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.lbl_NoSublevels = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.tmr_Autosave = New System.Windows.Forms.Timer(Me.components)
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.pnl_PROCESSINGTHECAVE = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cms_SublevelsListbox.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.tbp_SublevelManager.SuspendLayout()
        Me.tbp_ChallengeModeProperties.SuspendLayout()
        CType(Me.num_TimerTime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_CMPsubCount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_ubs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_uss, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.num_cL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_cF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_bulbL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_cB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_bulbB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_rL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_yL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_bL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_wL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_pL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_rB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_yB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_bB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_wB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_pF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_pB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_wF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_rF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_bF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_yF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_bulbF, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbp_ImportManager.SuspendLayout()
        Me.pnl_Controls.SuspendLayout()
        Me.pnl_Advanced.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.pic_SelectedEntity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_EntityCount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.num_EntityWeight, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_Debug.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.pnl_Entities.SuspendLayout()
        Me.pnl_PROCESSINGTHECAVE.SuspendLayout()
        Me.SuspendLayout()
        '
        'lst_Sublevels
        '
        Me.lst_Sublevels.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lst_Sublevels.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lst_Sublevels.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lst_Sublevels.ContextMenuStrip = Me.cms_SublevelsListbox
        Me.lst_Sublevels.Cursor = System.Windows.Forms.Cursors.Default
        Me.lst_Sublevels.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_Sublevels.ForeColor = System.Drawing.Color.White
        Me.lst_Sublevels.FormattingEnabled = True
        Me.lst_Sublevels.IntegralHeight = False
        Me.lst_Sublevels.ItemHeight = 22
        Me.lst_Sublevels.Location = New System.Drawing.Point(6, 6)
        Me.lst_Sublevels.Name = "lst_Sublevels"
        Me.lst_Sublevels.Size = New System.Drawing.Size(356, 423)
        Me.lst_Sublevels.TabIndex = 1
        '
        'cms_SublevelsListbox
        '
        Me.cms_SublevelsListbox.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToolStripMenuItem, Me.DeleteToolStripMenuItem})
        Me.cms_SublevelsListbox.Name = "cms_SublevelsListbox"
        Me.cms_SublevelsListbox.Size = New System.Drawing.Size(108, 48)
        '
        'AddToolStripMenuItem
        '
        Me.AddToolStripMenuItem.Image = Global.P2CC2.My.Resources.Resources.Add_New_48px
        Me.AddToolStripMenuItem.Name = "AddToolStripMenuItem"
        Me.AddToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AddToolStripMenuItem.Text = "Add"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Image = Global.P2CC2.My.Resources.Resources.Reduce_48px
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'lbl_SublevelTotal
        '
        Me.lbl_SublevelTotal.AutoSize = True
        Me.lbl_SublevelTotal.BackColor = System.Drawing.Color.Transparent
        Me.lbl_SublevelTotal.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_SublevelTotal.ForeColor = System.Drawing.Color.White
        Me.lbl_SublevelTotal.Location = New System.Drawing.Point(645, 44)
        Me.lbl_SublevelTotal.Name = "lbl_SublevelTotal"
        Me.lbl_SublevelTotal.Size = New System.Drawing.Size(116, 27)
        Me.lbl_SublevelTotal.TabIndex = 2
        Me.lbl_SublevelTotal.Text = "0 Sublevels"
        '
        'lst_Sublevel_IDs
        '
        Me.lst_Sublevel_IDs.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_Sublevel_IDs.FormattingEnabled = True
        Me.lst_Sublevel_IDs.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.lst_Sublevel_IDs.Location = New System.Drawing.Point(3, 3)
        Me.lst_Sublevel_IDs.Name = "lst_Sublevel_IDs"
        Me.lst_Sublevel_IDs.Size = New System.Drawing.Size(453, 30)
        Me.lst_Sublevel_IDs.TabIndex = 5
        '
        'lst_SublevelNames
        '
        Me.lst_SublevelNames.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_SublevelNames.FormattingEnabled = True
        Me.lst_SublevelNames.Location = New System.Drawing.Point(3, 39)
        Me.lst_SublevelNames.Name = "lst_SublevelNames"
        Me.lst_SublevelNames.Size = New System.Drawing.Size(453, 30)
        Me.lst_SublevelNames.TabIndex = 6
        '
        'chk_SublevelNameInput
        '
        Me.chk_SublevelNameInput.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chk_SublevelNameInput.AutoSize = True
        Me.chk_SublevelNameInput.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.chk_SublevelNameInput.Checked = True
        Me.chk_SublevelNameInput.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_SublevelNameInput.Cursor = System.Windows.Forms.Cursors.Default
        Me.chk_SublevelNameInput.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_SublevelNameInput.ForeColor = System.Drawing.Color.White
        Me.chk_SublevelNameInput.Location = New System.Drawing.Point(414, 388)
        Me.chk_SublevelNameInput.Name = "chk_SublevelNameInput"
        Me.chk_SublevelNameInput.Size = New System.Drawing.Size(199, 22)
        Me.chk_SublevelNameInput.TabIndex = 7
        Me.chk_SublevelNameInput.Text = "Don't ask for a sublevel name"
        Me.ToolTip1.SetToolTip(Me.chk_SublevelNameInput, "If checked, you can still add a name later")
        Me.chk_SublevelNameInput.UseVisualStyleBackColor = True
        '
        'lst_RegularEntities
        '
        Me.lst_RegularEntities.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_RegularEntities.FormattingEnabled = True
        Me.lst_RegularEntities.Location = New System.Drawing.Point(3, 75)
        Me.lst_RegularEntities.Name = "lst_RegularEntities"
        Me.lst_RegularEntities.Size = New System.Drawing.Size(453, 30)
        Me.lst_RegularEntities.TabIndex = 16
        '
        'btn_MoveSublevelDown
        '
        Me.btn_MoveSublevelDown.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_MoveSublevelDown.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_MoveSublevelDown.BackgroundImage = Global.P2CC2.My.Resources.Resources.Down_Arrow_20px_dark
        Me.btn_MoveSublevelDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_MoveSublevelDown.Cursor = System.Windows.Forms.Cursors.Default
        Me.btn_MoveSublevelDown.Enabled = False
        Me.btn_MoveSublevelDown.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btn_MoveSublevelDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_MoveSublevelDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_MoveSublevelDown.ForeColor = System.Drawing.Color.White
        Me.btn_MoveSublevelDown.Location = New System.Drawing.Point(368, 190)
        Me.btn_MoveSublevelDown.Name = "btn_MoveSublevelDown"
        Me.btn_MoveSublevelDown.Size = New System.Drawing.Size(40, 40)
        Me.btn_MoveSublevelDown.TabIndex = 18
        Me.ToolTip1.SetToolTip(Me.btn_MoveSublevelDown, "Move the selected sublevel down")
        Me.btn_MoveSublevelDown.UseVisualStyleBackColor = False
        '
        'btn_MoveSublevelUp
        '
        Me.btn_MoveSublevelUp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_MoveSublevelUp.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_MoveSublevelUp.BackgroundImage = Global.P2CC2.My.Resources.Resources.Up_20px_dark
        Me.btn_MoveSublevelUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_MoveSublevelUp.Cursor = System.Windows.Forms.Cursors.Default
        Me.btn_MoveSublevelUp.Enabled = False
        Me.btn_MoveSublevelUp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btn_MoveSublevelUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_MoveSublevelUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_MoveSublevelUp.ForeColor = System.Drawing.Color.White
        Me.btn_MoveSublevelUp.Location = New System.Drawing.Point(368, 144)
        Me.btn_MoveSublevelUp.Name = "btn_MoveSublevelUp"
        Me.btn_MoveSublevelUp.Size = New System.Drawing.Size(40, 40)
        Me.btn_MoveSublevelUp.TabIndex = 19
        Me.ToolTip1.SetToolTip(Me.btn_MoveSublevelUp, "Move the selected sublevel up")
        Me.btn_MoveSublevelUp.UseVisualStyleBackColor = False
        '
        'lbl_SublevelID
        '
        Me.lbl_SublevelID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_SublevelID.AutoSize = True
        Me.lbl_SublevelID.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_SublevelID.ForeColor = System.Drawing.Color.White
        Me.lbl_SublevelID.Location = New System.Drawing.Point(575, 61)
        Me.lbl_SublevelID.Name = "lbl_SublevelID"
        Me.lbl_SublevelID.Size = New System.Drawing.Size(60, 24)
        Me.lbl_SublevelID.TabIndex = 20
        Me.lbl_SublevelID.Text = "ID: S1"
        Me.ToolTip1.SetToolTip(Me.lbl_SublevelID, "This ID is so you can differentiate sublevels which have been moved up/down")
        '
        'btn_RenameSublevel
        '
        Me.btn_RenameSublevel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_RenameSublevel.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_RenameSublevel.Cursor = System.Windows.Forms.Cursors.Default
        Me.btn_RenameSublevel.Enabled = False
        Me.btn_RenameSublevel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btn_RenameSublevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_RenameSublevel.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_RenameSublevel.ForeColor = System.Drawing.Color.White
        Me.btn_RenameSublevel.Location = New System.Drawing.Point(536, 146)
        Me.btn_RenameSublevel.Name = "btn_RenameSublevel"
        Me.btn_RenameSublevel.Size = New System.Drawing.Size(106, 26)
        Me.btn_RenameSublevel.TabIndex = 22
        Me.btn_RenameSublevel.Text = "Rename"
        Me.ToolTip1.SetToolTip(Me.btn_RenameSublevel, "Add/rename the selected sublevel")
        Me.btn_RenameSublevel.UseVisualStyleBackColor = False
        Me.btn_RenameSublevel.Visible = False
        '
        'lst_RegularEntitiesCounts
        '
        Me.lst_RegularEntitiesCounts.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_RegularEntitiesCounts.FormattingEnabled = True
        Me.lst_RegularEntitiesCounts.Location = New System.Drawing.Point(3, 111)
        Me.lst_RegularEntitiesCounts.Name = "lst_RegularEntitiesCounts"
        Me.lst_RegularEntitiesCounts.Size = New System.Drawing.Size(453, 30)
        Me.lst_RegularEntitiesCounts.TabIndex = 23
        '
        'btn_RemoveSublevelName
        '
        Me.btn_RemoveSublevelName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_RemoveSublevelName.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_RemoveSublevelName.Cursor = System.Windows.Forms.Cursors.Default
        Me.btn_RemoveSublevelName.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btn_RemoveSublevelName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_RemoveSublevelName.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_RemoveSublevelName.ForeColor = System.Drawing.Color.White
        Me.btn_RemoveSublevelName.Location = New System.Drawing.Point(536, 178)
        Me.btn_RemoveSublevelName.Name = "btn_RemoveSublevelName"
        Me.btn_RemoveSublevelName.Size = New System.Drawing.Size(106, 26)
        Me.btn_RemoveSublevelName.TabIndex = 24
        Me.btn_RemoveSublevelName.Text = "Clear Name"
        Me.ToolTip1.SetToolTip(Me.btn_RemoveSublevelName, "Clear the selected sublevel's name")
        Me.btn_RemoveSublevelName.UseVisualStyleBackColor = False
        Me.btn_RemoveSublevelName.Visible = False
        '
        'TabControl1
        '
        Me.TabControl1.AllowDrop = True
        Me.TabControl1.Controls.Add(Me.tbp_SublevelManager)
        Me.TabControl1.Controls.Add(Me.tbp_ChallengeModeProperties)
        Me.TabControl1.Controls.Add(Me.tbp_ImportManager)
        Me.TabControl1.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.HotTrack = True
        Me.TabControl1.Location = New System.Drawing.Point(12, 43)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.Padding = New System.Drawing.Point(10, 6)
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.ShowToolTips = True
        Me.TabControl1.Size = New System.Drawing.Size(772, 470)
        Me.TabControl1.TabIndex = 27
        '
        'tbp_SublevelManager
        '
        Me.tbp_SublevelManager.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.tbp_SublevelManager.Controls.Add(Me.btn_MoveSublevelDown)
        Me.tbp_SublevelManager.Controls.Add(Me.btn_MoveSublevelUp)
        Me.tbp_SublevelManager.Controls.Add(Me.btn_DeleteAllSublevels3)
        Me.tbp_SublevelManager.Controls.Add(Me.btn_RemoveSublevel2)
        Me.tbp_SublevelManager.Controls.Add(Me.btn_AddSublevel2)
        Me.tbp_SublevelManager.Controls.Add(Me.btn_DuplicateSub)
        Me.tbp_SublevelManager.Controls.Add(Me.btn_Gates)
        Me.tbp_SublevelManager.Controls.Add(Me.btn_Entities)
        Me.tbp_SublevelManager.Controls.Add(Me.btn_Treasures)
        Me.tbp_SublevelManager.Controls.Add(Me.chk_DeleteSublevelQ)
        Me.tbp_SublevelManager.Controls.Add(Me.lbl_TotalEntityCount)
        Me.tbp_SublevelManager.Controls.Add(Me.lbl_EntityCount)
        Me.tbp_SublevelManager.Controls.Add(Me.btn_SublevelProperties)
        Me.tbp_SublevelManager.Controls.Add(Me.lbl_SelectedSublevelTitle)
        Me.tbp_SublevelManager.Controls.Add(Me.lst_Sublevels)
        Me.tbp_SublevelManager.Controls.Add(Me.btn_RemoveSublevelName)
        Me.tbp_SublevelManager.Controls.Add(Me.chk_SublevelNameInput)
        Me.tbp_SublevelManager.Controls.Add(Me.btn_RenameSublevel)
        Me.tbp_SublevelManager.Controls.Add(Me.lbl_SublevelID)
        Me.tbp_SublevelManager.Location = New System.Drawing.Point(4, 31)
        Me.tbp_SublevelManager.Name = "tbp_SublevelManager"
        Me.tbp_SublevelManager.Padding = New System.Windows.Forms.Padding(3)
        Me.tbp_SublevelManager.Size = New System.Drawing.Size(764, 435)
        Me.tbp_SublevelManager.TabIndex = 0
        Me.tbp_SublevelManager.Text = "Cave Manager"
        Me.tbp_SublevelManager.ToolTipText = "Add, delete, and edit sublevels"
        '
        'btn_DeleteAllSublevels3
        '
        Me.btn_DeleteAllSublevels3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_DeleteAllSublevels3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_DeleteAllSublevels3.BackgroundImage = Global.P2CC2.My.Resources.Resources.Trash_20px
        Me.btn_DeleteAllSublevels3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_DeleteAllSublevels3.Cursor = System.Windows.Forms.Cursors.Default
        Me.btn_DeleteAllSublevels3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btn_DeleteAllSublevels3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_DeleteAllSublevels3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_DeleteAllSublevels3.ForeColor = System.Drawing.Color.White
        Me.btn_DeleteAllSublevels3.Location = New System.Drawing.Point(368, 389)
        Me.btn_DeleteAllSublevels3.Name = "btn_DeleteAllSublevels3"
        Me.btn_DeleteAllSublevels3.Size = New System.Drawing.Size(40, 40)
        Me.btn_DeleteAllSublevels3.TabIndex = 53
        Me.ToolTip1.SetToolTip(Me.btn_DeleteAllSublevels3, "Delete ALL Sublevels")
        Me.btn_DeleteAllSublevels3.UseVisualStyleBackColor = False
        '
        'btn_RemoveSublevel2
        '
        Me.btn_RemoveSublevel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_RemoveSublevel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_RemoveSublevel2.BackgroundImage = Global.P2CC2.My.Resources.Resources.Subtract_20px_dark
        Me.btn_RemoveSublevel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_RemoveSublevel2.Cursor = System.Windows.Forms.Cursors.Default
        Me.btn_RemoveSublevel2.Enabled = False
        Me.btn_RemoveSublevel2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btn_RemoveSublevel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_RemoveSublevel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_RemoveSublevel2.ForeColor = System.Drawing.Color.White
        Me.btn_RemoveSublevel2.Location = New System.Drawing.Point(368, 52)
        Me.btn_RemoveSublevel2.Name = "btn_RemoveSublevel2"
        Me.btn_RemoveSublevel2.Size = New System.Drawing.Size(40, 40)
        Me.btn_RemoveSublevel2.TabIndex = 52
        Me.ToolTip1.SetToolTip(Me.btn_RemoveSublevel2, "Delete Selected Sublevel")
        Me.btn_RemoveSublevel2.UseVisualStyleBackColor = False
        '
        'btn_AddSublevel2
        '
        Me.btn_AddSublevel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_AddSublevel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_AddSublevel2.BackgroundImage = Global.P2CC2.My.Resources.Resources.Plus_Math_20px
        Me.btn_AddSublevel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_AddSublevel2.Cursor = System.Windows.Forms.Cursors.Default
        Me.btn_AddSublevel2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btn_AddSublevel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_AddSublevel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_AddSublevel2.ForeColor = System.Drawing.Color.White
        Me.btn_AddSublevel2.Location = New System.Drawing.Point(368, 6)
        Me.btn_AddSublevel2.Name = "btn_AddSublevel2"
        Me.btn_AddSublevel2.Size = New System.Drawing.Size(40, 40)
        Me.btn_AddSublevel2.TabIndex = 51
        Me.ToolTip1.SetToolTip(Me.btn_AddSublevel2, "Add Sublevel")
        Me.btn_AddSublevel2.UseVisualStyleBackColor = False
        '
        'btn_DuplicateSub
        '
        Me.btn_DuplicateSub.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_DuplicateSub.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_DuplicateSub.BackgroundImage = Global.P2CC2.My.Resources.Resources.Duplicate_20px_dark
        Me.btn_DuplicateSub.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_DuplicateSub.Cursor = System.Windows.Forms.Cursors.Default
        Me.btn_DuplicateSub.Enabled = False
        Me.btn_DuplicateSub.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btn_DuplicateSub.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_DuplicateSub.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_DuplicateSub.ForeColor = System.Drawing.Color.White
        Me.btn_DuplicateSub.Location = New System.Drawing.Point(368, 98)
        Me.btn_DuplicateSub.Name = "btn_DuplicateSub"
        Me.btn_DuplicateSub.Size = New System.Drawing.Size(40, 40)
        Me.btn_DuplicateSub.TabIndex = 50
        Me.ToolTip1.SetToolTip(Me.btn_DuplicateSub, "Duplicate selected sublevel")
        Me.btn_DuplicateSub.UseVisualStyleBackColor = False
        '
        'btn_Gates
        '
        Me.btn_Gates.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Gates.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_Gates.Cursor = System.Windows.Forms.Cursors.Default
        Me.btn_Gates.Enabled = False
        Me.btn_Gates.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btn_Gates.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Gates.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Gates.ForeColor = System.Drawing.Color.White
        Me.btn_Gates.Location = New System.Drawing.Point(589, 268)
        Me.btn_Gates.Name = "btn_Gates"
        Me.btn_Gates.Size = New System.Drawing.Size(106, 37)
        Me.btn_Gates.TabIndex = 49
        Me.btn_Gates.Text = "Gates"
        Me.ToolTip1.SetToolTip(Me.btn_Gates, "View/modify this cave's gates")
        Me.btn_Gates.UseVisualStyleBackColor = False
        '
        'btn_Entities
        '
        Me.btn_Entities.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Entities.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_Entities.Cursor = System.Windows.Forms.Cursors.Default
        Me.btn_Entities.Enabled = False
        Me.btn_Entities.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btn_Entities.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Entities.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Entities.ForeColor = System.Drawing.Color.White
        Me.btn_Entities.Location = New System.Drawing.Point(589, 225)
        Me.btn_Entities.Name = "btn_Entities"
        Me.btn_Entities.Size = New System.Drawing.Size(106, 37)
        Me.btn_Entities.TabIndex = 48
        Me.btn_Entities.Text = "Entities"
        Me.ToolTip1.SetToolTip(Me.btn_Entities, "View/modify this cave's entities")
        Me.btn_Entities.UseVisualStyleBackColor = False
        '
        'btn_Treasures
        '
        Me.btn_Treasures.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Treasures.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_Treasures.Cursor = System.Windows.Forms.Cursors.Default
        Me.btn_Treasures.Enabled = False
        Me.btn_Treasures.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btn_Treasures.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Treasures.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Treasures.ForeColor = System.Drawing.Color.White
        Me.btn_Treasures.Location = New System.Drawing.Point(477, 268)
        Me.btn_Treasures.Name = "btn_Treasures"
        Me.btn_Treasures.Size = New System.Drawing.Size(106, 37)
        Me.btn_Treasures.TabIndex = 47
        Me.btn_Treasures.Text = "Treasures"
        Me.ToolTip1.SetToolTip(Me.btn_Treasures, "View/modify this cave's treasures")
        Me.btn_Treasures.UseVisualStyleBackColor = False
        '
        'chk_DeleteSublevelQ
        '
        Me.chk_DeleteSublevelQ.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chk_DeleteSublevelQ.AutoSize = True
        Me.chk_DeleteSublevelQ.Cursor = System.Windows.Forms.Cursors.Default
        Me.chk_DeleteSublevelQ.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_DeleteSublevelQ.ForeColor = System.Drawing.Color.White
        Me.chk_DeleteSublevelQ.Location = New System.Drawing.Point(414, 407)
        Me.chk_DeleteSublevelQ.Name = "chk_DeleteSublevelQ"
        Me.chk_DeleteSublevelQ.Size = New System.Drawing.Size(235, 22)
        Me.chk_DeleteSublevelQ.TabIndex = 43
        Me.chk_DeleteSublevelQ.Text = "Don't ask before deleting a sublevel"
        Me.ToolTip1.SetToolTip(Me.chk_DeleteSublevelQ, "Doesn't ask before you delete a sublevel (not recommended)")
        Me.chk_DeleteSublevelQ.UseVisualStyleBackColor = True
        '
        'lbl_TotalEntityCount
        '
        Me.lbl_TotalEntityCount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_TotalEntityCount.AutoSize = True
        Me.lbl_TotalEntityCount.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_TotalEntityCount.ForeColor = System.Drawing.Color.White
        Me.lbl_TotalEntityCount.Location = New System.Drawing.Point(540, 118)
        Me.lbl_TotalEntityCount.Name = "lbl_TotalEntityCount"
        Me.lbl_TotalEntityCount.Size = New System.Drawing.Size(114, 22)
        Me.lbl_TotalEntityCount.TabIndex = 42
        Me.lbl_TotalEntityCount.Text = "Total Entities: "
        '
        'lbl_EntityCount
        '
        Me.lbl_EntityCount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_EntityCount.AutoSize = True
        Me.lbl_EntityCount.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_EntityCount.ForeColor = System.Drawing.Color.White
        Me.lbl_EntityCount.Location = New System.Drawing.Point(538, 90)
        Me.lbl_EntityCount.Name = "lbl_EntityCount"
        Me.lbl_EntityCount.Size = New System.Drawing.Size(97, 22)
        Me.lbl_EntityCount.TabIndex = 41
        Me.lbl_EntityCount.Text = "Entity Sets: "
        '
        'btn_SublevelProperties
        '
        Me.btn_SublevelProperties.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_SublevelProperties.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_SublevelProperties.Cursor = System.Windows.Forms.Cursors.Default
        Me.btn_SublevelProperties.Enabled = False
        Me.btn_SublevelProperties.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btn_SublevelProperties.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_SublevelProperties.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_SublevelProperties.ForeColor = System.Drawing.Color.White
        Me.btn_SublevelProperties.Location = New System.Drawing.Point(477, 225)
        Me.btn_SublevelProperties.Name = "btn_SublevelProperties"
        Me.btn_SublevelProperties.Size = New System.Drawing.Size(106, 37)
        Me.btn_SublevelProperties.TabIndex = 31
        Me.btn_SublevelProperties.Text = "Properties"
        Me.ToolTip1.SetToolTip(Me.btn_SublevelProperties, "View/modify the selected sublevel's properties")
        Me.btn_SublevelProperties.UseVisualStyleBackColor = False
        '
        'lbl_SelectedSublevelTitle
        '
        Me.lbl_SelectedSublevelTitle.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_SelectedSublevelTitle.AutoSize = True
        Me.lbl_SelectedSublevelTitle.Font = New System.Drawing.Font("Trebuchet MS", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_SelectedSublevelTitle.ForeColor = System.Drawing.Color.White
        Me.lbl_SelectedSublevelTitle.Location = New System.Drawing.Point(481, 21)
        Me.lbl_SelectedSublevelTitle.Name = "lbl_SelectedSublevelTitle"
        Me.lbl_SelectedSublevelTitle.Size = New System.Drawing.Size(212, 29)
        Me.lbl_SelectedSublevelTitle.TabIndex = 30
        Me.lbl_SelectedSublevelTitle.Text = "Selected Sublevel"
        '
        'tbp_ChallengeModeProperties
        '
        Me.tbp_ChallengeModeProperties.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.tbp_ChallengeModeProperties.Controls.Add(Me.btn_TimeHelp)
        Me.tbp_ChallengeModeProperties.Controls.Add(Me.num_TimerTime)
        Me.tbp_ChallengeModeProperties.Controls.Add(Me.Label22)
        Me.tbp_ChallengeModeProperties.Controls.Add(Me.lbl_CMsaved)
        Me.tbp_ChallengeModeProperties.Controls.Add(Me.lst_Times)
        Me.tbp_ChallengeModeProperties.Controls.Add(Me.num_CMPsubCount)
        Me.tbp_ChallengeModeProperties.Controls.Add(Me.Label19)
        Me.tbp_ChallengeModeProperties.Controls.Add(Me.chk_CMPadvanced)
        Me.tbp_ChallengeModeProperties.Controls.Add(Me.btn_ImportChallengeModeProperties)
        Me.tbp_ChallengeModeProperties.Controls.Add(Me.lbl_PikiCount)
        Me.tbp_ChallengeModeProperties.Controls.Add(Me.lbl_100pikiReminder)
        Me.tbp_ChallengeModeProperties.Controls.Add(Me.num_ubs)
        Me.tbp_ChallengeModeProperties.Controls.Add(Me.num_uss)
        Me.tbp_ChallengeModeProperties.Controls.Add(Me.Label15)
        Me.tbp_ChallengeModeProperties.Controls.Add(Me.Label14)
        Me.tbp_ChallengeModeProperties.Controls.Add(Me.Panel2)
        Me.tbp_ChallengeModeProperties.Controls.Add(Me.pnl_CMPadvanced)
        Me.tbp_ChallengeModeProperties.Controls.Add(Me.Label28)
        Me.tbp_ChallengeModeProperties.Controls.Add(Me.Label27)
        Me.tbp_ChallengeModeProperties.Location = New System.Drawing.Point(4, 31)
        Me.tbp_ChallengeModeProperties.Name = "tbp_ChallengeModeProperties"
        Me.tbp_ChallengeModeProperties.Size = New System.Drawing.Size(764, 435)
        Me.tbp_ChallengeModeProperties.TabIndex = 2
        Me.tbp_ChallengeModeProperties.Text = "Challenge Mode Editor"
        Me.tbp_ChallengeModeProperties.ToolTipText = "Set Challenge Mode properties (Pikmin, sprays, times)"
        '
        'btn_TimeHelp
        '
        Me.btn_TimeHelp.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_TimeHelp.Cursor = System.Windows.Forms.Cursors.Default
        Me.btn_TimeHelp.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_TimeHelp.Location = New System.Drawing.Point(203, 291)
        Me.btn_TimeHelp.Name = "btn_TimeHelp"
        Me.btn_TimeHelp.Size = New System.Drawing.Size(44, 24)
        Me.btn_TimeHelp.TabIndex = 55
        Me.btn_TimeHelp.Text = "Help"
        Me.btn_TimeHelp.UseVisualStyleBackColor = True
        '
        'num_TimerTime
        '
        Me.num_TimerTime.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.num_TimerTime.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.num_TimerTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.num_TimerTime.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.num_TimerTime.ForeColor = System.Drawing.Color.White
        Me.num_TimerTime.Location = New System.Drawing.Point(69, 326)
        Me.num_TimerTime.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.num_TimerTime.Minimum = New Decimal(New Integer() {999999, 0, 0, -2147483648})
        Me.num_TimerTime.Name = "num_TimerTime"
        Me.num_TimerTime.Size = New System.Drawing.Size(71, 26)
        Me.num_TimerTime.TabIndex = 52
        '
        'Label22
        '
        Me.Label22.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label22.AutoSize = True
        Me.Label22.ForeColor = System.Drawing.Color.White
        Me.Label22.Location = New System.Drawing.Point(265, 381)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(234, 32)
        Me.Label22.TabIndex = 51
        Me.Label22.Text = "These will only import if you check the" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "box saying to do so in the Import Manage" &
    "r."
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_CMsaved
        '
        Me.lbl_CMsaved.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lbl_CMsaved.AutoSize = True
        Me.lbl_CMsaved.ForeColor = System.Drawing.Color.Red
        Me.lbl_CMsaved.Location = New System.Drawing.Point(262, 321)
        Me.lbl_CMsaved.Name = "lbl_CMsaved"
        Me.lbl_CMsaved.Size = New System.Drawing.Size(107, 16)
        Me.lbl_CMsaved.TabIndex = 50
        Me.lbl_CMsaved.Text = "Changes not saved"
        '
        'lst_Times
        '
        Me.lst_Times.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lst_Times.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lst_Times.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lst_Times.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_Times.ForeColor = System.Drawing.Color.White
        Me.lst_Times.FormattingEnabled = True
        Me.lst_Times.ItemHeight = 18
        Me.lst_Times.Location = New System.Drawing.Point(69, 159)
        Me.lst_Times.Name = "lst_Times"
        Me.lst_Times.Size = New System.Drawing.Size(178, 128)
        Me.lst_Times.TabIndex = 48
        '
        'num_CMPsubCount
        '
        Me.num_CMPsubCount.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.num_CMPsubCount.BackColor = System.Drawing.Color.Silver
        Me.num_CMPsubCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.num_CMPsubCount.ForeColor = System.Drawing.Color.Black
        Me.num_CMPsubCount.Location = New System.Drawing.Point(553, 223)
        Me.num_CMPsubCount.Name = "num_CMPsubCount"
        Me.num_CMPsubCount.ReadOnly = True
        Me.num_CMPsubCount.Size = New System.Drawing.Size(73, 26)
        Me.num_CMPsubCount.TabIndex = 46
        Me.num_CMPsubCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.num_CMPsubCount.Visible = False
        '
        'Label19
        '
        Me.Label19.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(432, 226)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(116, 22)
        Me.Label19.TabIndex = 45
        Me.Label19.Text = "Sublevel Count"
        Me.Label19.Visible = False
        '
        'chk_CMPadvanced
        '
        Me.chk_CMPadvanced.AutoSize = True
        Me.chk_CMPadvanced.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chk_CMPadvanced.ForeColor = System.Drawing.Color.White
        Me.chk_CMPadvanced.Location = New System.Drawing.Point(11, 413)
        Me.chk_CMPadvanced.Name = "chk_CMPadvanced"
        Me.chk_CMPadvanced.Size = New System.Drawing.Size(155, 20)
        Me.chk_CMPadvanced.TabIndex = 39
        Me.chk_CMPadvanced.Text = "Show advanced options"
        Me.chk_CMPadvanced.UseVisualStyleBackColor = True
        Me.chk_CMPadvanced.Visible = False
        '
        'btn_ImportChallengeModeProperties
        '
        Me.btn_ImportChallengeModeProperties.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btn_ImportChallengeModeProperties.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_ImportChallengeModeProperties.Cursor = System.Windows.Forms.Cursors.Default
        Me.btn_ImportChallengeModeProperties.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btn_ImportChallengeModeProperties.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ImportChallengeModeProperties.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ImportChallengeModeProperties.ForeColor = System.Drawing.Color.White
        Me.btn_ImportChallengeModeProperties.Location = New System.Drawing.Point(265, 337)
        Me.btn_ImportChallengeModeProperties.Name = "btn_ImportChallengeModeProperties"
        Me.btn_ImportChallengeModeProperties.Size = New System.Drawing.Size(234, 41)
        Me.btn_ImportChallengeModeProperties.TabIndex = 35
        Me.btn_ImportChallengeModeProperties.Text = "Save Changes"
        Me.ToolTip1.SetToolTip(Me.btn_ImportChallengeModeProperties, "Save the properties to ready it for import")
        Me.btn_ImportChallengeModeProperties.UseVisualStyleBackColor = False
        '
        'lbl_PikiCount
        '
        Me.lbl_PikiCount.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbl_PikiCount.AutoSize = True
        Me.lbl_PikiCount.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_PikiCount.ForeColor = System.Drawing.Color.White
        Me.lbl_PikiCount.Location = New System.Drawing.Point(641, 92)
        Me.lbl_PikiCount.Name = "lbl_PikiCount"
        Me.lbl_PikiCount.Size = New System.Drawing.Size(82, 24)
        Me.lbl_PikiCount.TabIndex = 34
        Me.lbl_PikiCount.Text = "0 Pikmin"
        '
        'lbl_100pikiReminder
        '
        Me.lbl_100pikiReminder.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbl_100pikiReminder.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_100pikiReminder.ForeColor = System.Drawing.Color.White
        Me.lbl_100pikiReminder.Location = New System.Drawing.Point(638, 116)
        Me.lbl_100pikiReminder.Name = "lbl_100pikiReminder"
        Me.lbl_100pikiReminder.Size = New System.Drawing.Size(128, 108)
        Me.lbl_100pikiReminder.TabIndex = 33
        Me.lbl_100pikiReminder.Text = "Any more than 100 Pikmin will crash the game." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(unless you have hacked it other" &
    "wise)"
        Me.lbl_100pikiReminder.Visible = False
        '
        'num_ubs
        '
        Me.num_ubs.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.num_ubs.BackColor = System.Drawing.Color.Purple
        Me.num_ubs.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.num_ubs.ForeColor = System.Drawing.Color.White
        Me.num_ubs.Location = New System.Drawing.Point(553, 191)
        Me.num_ubs.Name = "num_ubs"
        Me.num_ubs.Size = New System.Drawing.Size(73, 26)
        Me.num_ubs.TabIndex = 28
        Me.num_ubs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'num_uss
        '
        Me.num_uss.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.num_uss.BackColor = System.Drawing.Color.Red
        Me.num_uss.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.num_uss.ForeColor = System.Drawing.Color.White
        Me.num_uss.Location = New System.Drawing.Point(553, 159)
        Me.num_uss.Name = "num_uss"
        Me.num_uss.Size = New System.Drawing.Size(73, 26)
        Me.num_uss.TabIndex = 27
        Me.num_uss.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label15
        '
        Me.Label15.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(414, 193)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(139, 22)
        Me.Label15.TabIndex = 26
        Me.Label15.Text = "Ultra-bitter sprays"
        '
        'Label14
        '
        Me.Label14.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(415, 161)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(134, 22)
        Me.Label14.TabIndex = 25
        Me.Label14.Text = "Ultra-spicy sprays"
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel2.Controls.Add(Me.Label21)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label20)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Location = New System.Drawing.Point(14, 38)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(621, 115)
        Me.Panel2.TabIndex = 24
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.White
        Me.Label21.Location = New System.Drawing.Point(535, 4)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(82, 16)
        Me.Label21.TabIndex = 51
        Me.Label21.Text = "Pik-pik Carrots"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(73, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(36, 22)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Red"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel1.ColumnCount = 7
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.Controls.Add(Me.num_cL, 6, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.num_cF, 6, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.num_bulbL, 5, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.num_cB, 6, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.num_bulbB, 5, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.num_rL, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.num_yL, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.num_bL, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.num_wL, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.num_pL, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.num_rB, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.num_yB, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.num_bB, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.num_wB, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.num_pF, 4, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.num_pB, 4, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.num_wF, 3, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.num_rF, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.num_bF, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.num_yF, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.num_bulbF, 5, 2)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(55, 23)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(563, 90)
        Me.TableLayoutPanel1.TabIndex = 23
        '
        'num_cL
        '
        Me.num_cL.BackColor = System.Drawing.Color.DarkOrange
        Me.num_cL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.num_cL.ForeColor = System.Drawing.Color.White
        Me.num_cL.Location = New System.Drawing.Point(484, 4)
        Me.num_cL.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.num_cL.Name = "num_cL"
        Me.num_cL.Size = New System.Drawing.Size(73, 22)
        Me.num_cL.TabIndex = 50
        Me.num_cL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'num_cF
        '
        Me.num_cF.BackColor = System.Drawing.Color.DarkOrange
        Me.num_cF.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.num_cF.ForeColor = System.Drawing.Color.White
        Me.num_cF.Location = New System.Drawing.Point(484, 62)
        Me.num_cF.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.num_cF.Name = "num_cF"
        Me.num_cF.Size = New System.Drawing.Size(73, 22)
        Me.num_cF.TabIndex = 52
        Me.num_cF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'num_bulbL
        '
        Me.num_bulbL.BackColor = System.Drawing.Color.Lime
        Me.num_bulbL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.num_bulbL.Location = New System.Drawing.Point(404, 4)
        Me.num_bulbL.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.num_bulbL.Name = "num_bulbL"
        Me.num_bulbL.Size = New System.Drawing.Size(73, 22)
        Me.num_bulbL.TabIndex = 47
        Me.num_bulbL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'num_cB
        '
        Me.num_cB.BackColor = System.Drawing.Color.DarkOrange
        Me.num_cB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.num_cB.ForeColor = System.Drawing.Color.White
        Me.num_cB.Location = New System.Drawing.Point(484, 33)
        Me.num_cB.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.num_cB.Name = "num_cB"
        Me.num_cB.Size = New System.Drawing.Size(73, 22)
        Me.num_cB.TabIndex = 51
        Me.num_cB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'num_bulbB
        '
        Me.num_bulbB.BackColor = System.Drawing.Color.Lime
        Me.num_bulbB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.num_bulbB.Location = New System.Drawing.Point(404, 33)
        Me.num_bulbB.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.num_bulbB.Name = "num_bulbB"
        Me.num_bulbB.Size = New System.Drawing.Size(73, 22)
        Me.num_bulbB.TabIndex = 49
        Me.num_bulbB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'num_rL
        '
        Me.num_rL.BackColor = System.Drawing.Color.Red
        Me.num_rL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.num_rL.ForeColor = System.Drawing.Color.White
        Me.num_rL.Location = New System.Drawing.Point(4, 4)
        Me.num_rL.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.num_rL.Name = "num_rL"
        Me.num_rL.Size = New System.Drawing.Size(73, 22)
        Me.num_rL.TabIndex = 0
        Me.num_rL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'num_yL
        '
        Me.num_yL.BackColor = System.Drawing.Color.Yellow
        Me.num_yL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.num_yL.Location = New System.Drawing.Point(84, 4)
        Me.num_yL.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.num_yL.Name = "num_yL"
        Me.num_yL.Size = New System.Drawing.Size(73, 22)
        Me.num_yL.TabIndex = 3
        Me.num_yL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'num_bL
        '
        Me.num_bL.BackColor = System.Drawing.Color.Blue
        Me.num_bL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.num_bL.ForeColor = System.Drawing.Color.White
        Me.num_bL.Location = New System.Drawing.Point(164, 4)
        Me.num_bL.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.num_bL.Name = "num_bL"
        Me.num_bL.Size = New System.Drawing.Size(73, 22)
        Me.num_bL.TabIndex = 6
        Me.num_bL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'num_wL
        '
        Me.num_wL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.num_wL.Location = New System.Drawing.Point(244, 4)
        Me.num_wL.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.num_wL.Name = "num_wL"
        Me.num_wL.Size = New System.Drawing.Size(73, 22)
        Me.num_wL.TabIndex = 9
        Me.num_wL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'num_pL
        '
        Me.num_pL.BackColor = System.Drawing.Color.Purple
        Me.num_pL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.num_pL.ForeColor = System.Drawing.Color.White
        Me.num_pL.Location = New System.Drawing.Point(324, 4)
        Me.num_pL.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.num_pL.Name = "num_pL"
        Me.num_pL.Size = New System.Drawing.Size(73, 22)
        Me.num_pL.TabIndex = 12
        Me.num_pL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'num_rB
        '
        Me.num_rB.BackColor = System.Drawing.Color.Red
        Me.num_rB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.num_rB.ForeColor = System.Drawing.Color.White
        Me.num_rB.Location = New System.Drawing.Point(4, 33)
        Me.num_rB.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.num_rB.Name = "num_rB"
        Me.num_rB.Size = New System.Drawing.Size(73, 22)
        Me.num_rB.TabIndex = 1
        Me.num_rB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'num_yB
        '
        Me.num_yB.BackColor = System.Drawing.Color.Yellow
        Me.num_yB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.num_yB.Location = New System.Drawing.Point(84, 33)
        Me.num_yB.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.num_yB.Name = "num_yB"
        Me.num_yB.Size = New System.Drawing.Size(73, 22)
        Me.num_yB.TabIndex = 4
        Me.num_yB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'num_bB
        '
        Me.num_bB.BackColor = System.Drawing.Color.Blue
        Me.num_bB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.num_bB.ForeColor = System.Drawing.Color.White
        Me.num_bB.Location = New System.Drawing.Point(164, 33)
        Me.num_bB.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.num_bB.Name = "num_bB"
        Me.num_bB.Size = New System.Drawing.Size(73, 22)
        Me.num_bB.TabIndex = 7
        Me.num_bB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'num_wB
        '
        Me.num_wB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.num_wB.Location = New System.Drawing.Point(244, 33)
        Me.num_wB.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.num_wB.Name = "num_wB"
        Me.num_wB.Size = New System.Drawing.Size(73, 22)
        Me.num_wB.TabIndex = 10
        Me.num_wB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'num_pF
        '
        Me.num_pF.BackColor = System.Drawing.Color.Purple
        Me.num_pF.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.num_pF.ForeColor = System.Drawing.Color.White
        Me.num_pF.Location = New System.Drawing.Point(324, 62)
        Me.num_pF.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.num_pF.Name = "num_pF"
        Me.num_pF.Size = New System.Drawing.Size(73, 22)
        Me.num_pF.TabIndex = 14
        Me.num_pF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'num_pB
        '
        Me.num_pB.BackColor = System.Drawing.Color.Purple
        Me.num_pB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.num_pB.ForeColor = System.Drawing.Color.White
        Me.num_pB.Location = New System.Drawing.Point(324, 33)
        Me.num_pB.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.num_pB.Name = "num_pB"
        Me.num_pB.Size = New System.Drawing.Size(73, 22)
        Me.num_pB.TabIndex = 13
        Me.num_pB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'num_wF
        '
        Me.num_wF.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.num_wF.Location = New System.Drawing.Point(244, 62)
        Me.num_wF.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.num_wF.Name = "num_wF"
        Me.num_wF.Size = New System.Drawing.Size(73, 22)
        Me.num_wF.TabIndex = 11
        Me.num_wF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'num_rF
        '
        Me.num_rF.BackColor = System.Drawing.Color.Red
        Me.num_rF.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.num_rF.ForeColor = System.Drawing.Color.White
        Me.num_rF.Location = New System.Drawing.Point(4, 62)
        Me.num_rF.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.num_rF.Name = "num_rF"
        Me.num_rF.Size = New System.Drawing.Size(73, 22)
        Me.num_rF.TabIndex = 2
        Me.num_rF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'num_bF
        '
        Me.num_bF.BackColor = System.Drawing.Color.Blue
        Me.num_bF.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.num_bF.ForeColor = System.Drawing.Color.White
        Me.num_bF.Location = New System.Drawing.Point(164, 62)
        Me.num_bF.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.num_bF.Name = "num_bF"
        Me.num_bF.Size = New System.Drawing.Size(73, 22)
        Me.num_bF.TabIndex = 8
        Me.num_bF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'num_yF
        '
        Me.num_yF.BackColor = System.Drawing.Color.Yellow
        Me.num_yF.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.num_yF.Location = New System.Drawing.Point(84, 62)
        Me.num_yF.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.num_yF.Name = "num_yF"
        Me.num_yF.Size = New System.Drawing.Size(73, 22)
        Me.num_yF.TabIndex = 5
        Me.num_yF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'num_bulbF
        '
        Me.num_bulbF.BackColor = System.Drawing.Color.Lime
        Me.num_bulbF.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.num_bulbF.Location = New System.Drawing.Point(404, 62)
        Me.num_bulbF.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.num_bulbF.Name = "num_bulbF"
        Me.num_bulbF.Size = New System.Drawing.Size(73, 22)
        Me.num_bulbF.TabIndex = 48
        Me.num_bulbF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(19, 29)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 16)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Leaf"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.Location = New System.Drawing.Point(461, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(66, 22)
        Me.Label20.TabIndex = 50
        Me.Label20.Text = "Bulbmin"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(387, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(55, 22)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "Purple"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(21, 58)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 16)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Bud"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(306, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(54, 22)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "White"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(5, 88)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 16)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Flower"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(230, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 22)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Blue"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(146, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 22)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Yellow"
        '
        'pnl_CMPadvanced
        '
        Me.pnl_CMPadvanced.Location = New System.Drawing.Point(14, 373)
        Me.pnl_CMPadvanced.Name = "pnl_CMPadvanced"
        Me.pnl_CMPadvanced.Size = New System.Drawing.Size(167, 35)
        Me.pnl_CMPadvanced.TabIndex = 40
        Me.pnl_CMPadvanced.Visible = False
        '
        'Label28
        '
        Me.Label28.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.White
        Me.Label28.Location = New System.Drawing.Point(66, 288)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(138, 36)
        Me.Label28.TabIndex = 54
        Me.Label28.Text = "Select a sublevel" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "and set its time below"
        '
        'Label27
        '
        Me.Label27.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.White
        Me.Label27.Location = New System.Drawing.Point(141, 328)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(67, 22)
        Me.Label27.TabIndex = 53
        Me.Label27.Text = "Seconds"
        '
        'tbp_ImportManager
        '
        Me.tbp_ImportManager.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.tbp_ImportManager.Controls.Add(Me.Label17)
        Me.tbp_ImportManager.Controls.Add(Me.Panel5)
        Me.tbp_ImportManager.Controls.Add(Me.Panel4)
        Me.tbp_ImportManager.Controls.Add(Me.Label16)
        Me.tbp_ImportManager.Controls.Add(Me.chk_ShowAdvanced)
        Me.tbp_ImportManager.Controls.Add(Me.pnl_Controls)
        Me.tbp_ImportManager.Controls.Add(Me.lnk_ExportHelp)
        Me.tbp_ImportManager.Location = New System.Drawing.Point(4, 31)
        Me.tbp_ImportManager.Name = "tbp_ImportManager"
        Me.tbp_ImportManager.Size = New System.Drawing.Size(764, 435)
        Me.tbp_ImportManager.TabIndex = 5
        Me.tbp_ImportManager.Text = "Import and Export"
        Me.tbp_ImportManager.ToolTipText = "Import cave, music, and other"
        '
        'Label17
        '
        Me.Label17.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(516, 20)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(80, 27)
        Me.Label17.TabIndex = 56
        Me.Label17.Text = "Manual"
        '
        'Panel5
        '
        Me.Panel5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Panel5.Location = New System.Drawing.Point(12, 50)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(737, 1)
        Me.Panel5.TabIndex = 55
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Panel4.Location = New System.Drawing.Point(513, 21)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1, 400)
        Me.Panel4.TabIndex = 54
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(7, 20)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(273, 27)
        Me.Label16.TabIndex = 53
        Me.Label16.Text = "Automatic (recommended)"
        '
        'chk_ShowAdvanced
        '
        Me.chk_ShowAdvanced.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chk_ShowAdvanced.AutoSize = True
        Me.chk_ShowAdvanced.BackColor = System.Drawing.Color.Transparent
        Me.chk_ShowAdvanced.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chk_ShowAdvanced.ForeColor = System.Drawing.Color.White
        Me.chk_ShowAdvanced.Location = New System.Drawing.Point(12, 411)
        Me.chk_ShowAdvanced.Name = "chk_ShowAdvanced"
        Me.chk_ShowAdvanced.Size = New System.Drawing.Size(155, 20)
        Me.chk_ShowAdvanced.TabIndex = 38
        Me.chk_ShowAdvanced.Text = "Show advanced options"
        Me.chk_ShowAdvanced.UseVisualStyleBackColor = False
        Me.chk_ShowAdvanced.Visible = False
        '
        'pnl_Controls
        '
        Me.pnl_Controls.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnl_Controls.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.pnl_Controls.Controls.Add(Me.btn_getBase64)
        Me.pnl_Controls.Controls.Add(Me.Label26)
        Me.pnl_Controls.Controls.Add(Me.btn_CMPcopyCode)
        Me.pnl_Controls.Controls.Add(Me.Label25)
        Me.pnl_Controls.Controls.Add(Me.Label24)
        Me.pnl_Controls.Controls.Add(Me.btn_CopyMusicCode)
        Me.pnl_Controls.Controls.Add(Me.txt_RootDirectory)
        Me.pnl_Controls.Controls.Add(Me.lbl_AdditionalOptionsTitle)
        Me.pnl_Controls.Controls.Add(Me.btn_ImportCave)
        Me.pnl_Controls.Controls.Add(Me.cmb_ReplaceWith)
        Me.pnl_Controls.Controls.Add(Me.chk_UseCMproperties)
        Me.pnl_Controls.Controls.Add(Me.btn_LoadRoot)
        Me.pnl_Controls.Controls.Add(Me.btn_ExportCaveFile)
        Me.pnl_Controls.Controls.Add(Me.pnl_Advanced)
        Me.pnl_Controls.Controls.Add(Me.opt_Main)
        Me.pnl_Controls.Controls.Add(Me.opt_ChallengeMode)
        Me.pnl_Controls.Controls.Add(Me.Panel3)
        Me.pnl_Controls.Controls.Add(Me.Label18)
        Me.pnl_Controls.Location = New System.Drawing.Point(12, 48)
        Me.pnl_Controls.Name = "pnl_Controls"
        Me.pnl_Controls.Size = New System.Drawing.Size(737, 408)
        Me.pnl_Controls.TabIndex = 27
        '
        'btn_getBase64
        '
        Me.btn_getBase64.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_getBase64.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_getBase64.Cursor = System.Windows.Forms.Cursors.Default
        Me.btn_getBase64.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btn_getBase64.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_getBase64.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_getBase64.ForeColor = System.Drawing.Color.White
        Me.btn_getBase64.Location = New System.Drawing.Point(508, 9)
        Me.btn_getBase64.Name = "btn_getBase64"
        Me.btn_getBase64.Size = New System.Drawing.Size(222, 47)
        Me.btn_getBase64.TabIndex = 60
        Me.btn_getBase64.Text = "Copy Base64 Project File" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(for Cave Net)"
        Me.ToolTip1.SetToolTip(Me.btn_getBase64, "Copy this cave's project file to clipboard for Cave Net submission")
        Me.btn_getBase64.UseVisualStyleBackColor = False
        Me.btn_getBase64.Visible = False
        '
        'Label26
        '
        Me.Label26.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label26.Enabled = False
        Me.Label26.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.White
        Me.Label26.Location = New System.Drawing.Point(168, 333)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(176, 18)
        Me.Label26.TabIndex = 59
        Me.Label26.Text = "Export the files into your root"
        '
        'btn_CMPcopyCode
        '
        Me.btn_CMPcopyCode.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_CMPcopyCode.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_CMPcopyCode.Cursor = System.Windows.Forms.Cursors.Default
        Me.btn_CMPcopyCode.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btn_CMPcopyCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_CMPcopyCode.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_CMPcopyCode.ForeColor = System.Drawing.Color.White
        Me.btn_CMPcopyCode.Location = New System.Drawing.Point(509, 87)
        Me.btn_CMPcopyCode.Name = "btn_CMPcopyCode"
        Me.btn_CMPcopyCode.Size = New System.Drawing.Size(221, 33)
        Me.btn_CMPcopyCode.TabIndex = 41
        Me.btn_CMPcopyCode.Text = "Copy Challenge Mode Settings"
        Me.ToolTip1.SetToolTip(Me.btn_CMPcopyCode, "Copy these adjusted properties to clipboard")
        Me.btn_CMPcopyCode.UseVisualStyleBackColor = False
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.White
        Me.Label25.Location = New System.Drawing.Point(-4, 88)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(126, 22)
        Me.Label25.TabIndex = 58
        Me.Label25.Text = "Cave to Replace"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.White
        Me.Label24.Location = New System.Drawing.Point(-5, 13)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(208, 22)
        Me.Label24.TabIndex = 57
        Me.Label24.Text = "Root Directory (GameCube)"
        '
        'btn_CopyMusicCode
        '
        Me.btn_CopyMusicCode.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_CopyMusicCode.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_CopyMusicCode.Cursor = System.Windows.Forms.Cursors.Default
        Me.btn_CopyMusicCode.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btn_CopyMusicCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_CopyMusicCode.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_CopyMusicCode.ForeColor = System.Drawing.Color.White
        Me.btn_CopyMusicCode.Location = New System.Drawing.Point(508, 48)
        Me.btn_CopyMusicCode.Name = "btn_CopyMusicCode"
        Me.btn_CopyMusicCode.Size = New System.Drawing.Size(222, 33)
        Me.btn_CopyMusicCode.TabIndex = 40
        Me.btn_CopyMusicCode.Text = "Copy Music Code"
        Me.btn_CopyMusicCode.UseVisualStyleBackColor = False
        '
        'txt_RootDirectory
        '
        Me.txt_RootDirectory.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_RootDirectory.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_RootDirectory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_RootDirectory.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txt_RootDirectory.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_RootDirectory.ForeColor = System.Drawing.Color.White
        Me.txt_RootDirectory.Location = New System.Drawing.Point(0, 36)
        Me.txt_RootDirectory.Name = "txt_RootDirectory"
        Me.txt_RootDirectory.ReadOnly = True
        Me.txt_RootDirectory.Size = New System.Drawing.Size(423, 23)
        Me.txt_RootDirectory.TabIndex = 26
        Me.txt_RootDirectory.Text = "root\user\Mukki"
        '
        'lbl_AdditionalOptionsTitle
        '
        Me.lbl_AdditionalOptionsTitle.AutoSize = True
        Me.lbl_AdditionalOptionsTitle.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_AdditionalOptionsTitle.ForeColor = System.Drawing.Color.White
        Me.lbl_AdditionalOptionsTitle.Location = New System.Drawing.Point(-4, 190)
        Me.lbl_AdditionalOptionsTitle.Name = "lbl_AdditionalOptionsTitle"
        Me.lbl_AdditionalOptionsTitle.Size = New System.Drawing.Size(141, 22)
        Me.lbl_AdditionalOptionsTitle.TabIndex = 52
        Me.lbl_AdditionalOptionsTitle.Text = "Additional Options"
        '
        'btn_ImportCave
        '
        Me.btn_ImportCave.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btn_ImportCave.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_ImportCave.Cursor = System.Windows.Forms.Cursors.Default
        Me.btn_ImportCave.Enabled = False
        Me.btn_ImportCave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btn_ImportCave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ImportCave.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ImportCave.ForeColor = System.Drawing.Color.White
        Me.btn_ImportCave.Location = New System.Drawing.Point(165, 304)
        Me.btn_ImportCave.Name = "btn_ImportCave"
        Me.btn_ImportCave.Size = New System.Drawing.Size(180, 51)
        Me.btn_ImportCave.TabIndex = 51
        Me.btn_ImportCave.Text = "Import"
        Me.btn_ImportCave.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_ImportCave.UseVisualStyleBackColor = False
        '
        'cmb_ReplaceWith
        '
        Me.cmb_ReplaceWith.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmb_ReplaceWith.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_ReplaceWith.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_ReplaceWith.FormattingEnabled = True
        Me.cmb_ReplaceWith.Location = New System.Drawing.Point(0, 132)
        Me.cmb_ReplaceWith.Name = "cmb_ReplaceWith"
        Me.cmb_ReplaceWith.Size = New System.Drawing.Size(395, 26)
        Me.cmb_ReplaceWith.TabIndex = 40
        Me.ToolTip1.SetToolTip(Me.cmb_ReplaceWith, "Name of the vanilla cave")
        '
        'chk_UseCMproperties
        '
        Me.chk_UseCMproperties.AutoSize = True
        Me.chk_UseCMproperties.Cursor = System.Windows.Forms.Cursors.Default
        Me.chk_UseCMproperties.Enabled = False
        Me.chk_UseCMproperties.ForeColor = System.Drawing.Color.White
        Me.chk_UseCMproperties.Location = New System.Drawing.Point(12, 217)
        Me.chk_UseCMproperties.Name = "chk_UseCMproperties"
        Me.chk_UseCMproperties.Size = New System.Drawing.Size(251, 20)
        Me.chk_UseCMproperties.TabIndex = 9
        Me.chk_UseCMproperties.Text = "Import custom Challenge Mode properties"
        Me.ToolTip1.SetToolTip(Me.chk_UseCMproperties, "Import the custom properties from the Challenge Mode editor")
        Me.chk_UseCMproperties.UseVisualStyleBackColor = True
        '
        'btn_LoadRoot
        '
        Me.btn_LoadRoot.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_LoadRoot.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_LoadRoot.Cursor = System.Windows.Forms.Cursors.Default
        Me.btn_LoadRoot.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btn_LoadRoot.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_LoadRoot.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_LoadRoot.ForeColor = System.Drawing.Color.White
        Me.btn_LoadRoot.Location = New System.Drawing.Point(429, 35)
        Me.btn_LoadRoot.Name = "btn_LoadRoot"
        Me.btn_LoadRoot.Size = New System.Drawing.Size(66, 25)
        Me.btn_LoadRoot.TabIndex = 25
        Me.btn_LoadRoot.Text = "Browse..."
        Me.ToolTip1.SetToolTip(Me.btn_LoadRoot, "Locate the directory of your extracted Pikmin 2 (GCN) root" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Note: Only works if e" &
        "xtraced with GameCube Rebuilder")
        Me.btn_LoadRoot.UseVisualStyleBackColor = False
        '
        'btn_ExportCaveFile
        '
        Me.btn_ExportCaveFile.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_ExportCaveFile.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_ExportCaveFile.Cursor = System.Windows.Forms.Cursors.Default
        Me.btn_ExportCaveFile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btn_ExportCaveFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ExportCaveFile.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ExportCaveFile.ForeColor = System.Drawing.Color.White
        Me.btn_ExportCaveFile.Location = New System.Drawing.Point(508, 9)
        Me.btn_ExportCaveFile.Name = "btn_ExportCaveFile"
        Me.btn_ExportCaveFile.Size = New System.Drawing.Size(222, 33)
        Me.btn_ExportCaveFile.TabIndex = 39
        Me.btn_ExportCaveFile.Text = "Export Cave File"
        Me.btn_ExportCaveFile.UseVisualStyleBackColor = False
        '
        'pnl_Advanced
        '
        Me.pnl_Advanced.Controls.Add(Me.chk_IgnoreTheKey)
        Me.pnl_Advanced.Controls.Add(Me.chk_IgnoreCaveMusic)
        Me.pnl_Advanced.Location = New System.Drawing.Point(9, 240)
        Me.pnl_Advanced.Name = "pnl_Advanced"
        Me.pnl_Advanced.Size = New System.Drawing.Size(386, 58)
        Me.pnl_Advanced.TabIndex = 35
        '
        'chk_IgnoreTheKey
        '
        Me.chk_IgnoreTheKey.AutoSize = True
        Me.chk_IgnoreTheKey.Cursor = System.Windows.Forms.Cursors.Default
        Me.chk_IgnoreTheKey.ForeColor = System.Drawing.Color.White
        Me.chk_IgnoreTheKey.Location = New System.Drawing.Point(3, 0)
        Me.chk_IgnoreTheKey.Name = "chk_IgnoreTheKey"
        Me.chk_IgnoreTheKey.Size = New System.Drawing.Size(380, 20)
        Me.chk_IgnoreTheKey.TabIndex = 9
        Me.chk_IgnoreTheKey.Text = "Don't warn me about sublevels without The Key (Challenge Mode)"
        Me.ToolTip1.SetToolTip(Me.chk_IgnoreTheKey, "If checked, Cave Creator won't let you know you have a Challenge Mode sublevel w" &
        "ithout The Key")
        Me.chk_IgnoreTheKey.UseVisualStyleBackColor = True
        '
        'chk_IgnoreCaveMusic
        '
        Me.chk_IgnoreCaveMusic.AutoSize = True
        Me.chk_IgnoreCaveMusic.Cursor = System.Windows.Forms.Cursors.Default
        Me.chk_IgnoreCaveMusic.ForeColor = System.Drawing.Color.White
        Me.chk_IgnoreCaveMusic.Location = New System.Drawing.Point(3, 23)
        Me.chk_IgnoreCaveMusic.Name = "chk_IgnoreCaveMusic"
        Me.chk_IgnoreCaveMusic.Size = New System.Drawing.Size(155, 20)
        Me.chk_IgnoreCaveMusic.TabIndex = 8
        Me.chk_IgnoreCaveMusic.Text = "Don't import cave music"
        Me.ToolTip1.SetToolTip(Me.chk_IgnoreCaveMusic, "If unsure, leave unchecked")
        Me.chk_IgnoreCaveMusic.UseVisualStyleBackColor = True
        '
        'opt_Main
        '
        Me.opt_Main.AutoSize = True
        Me.opt_Main.Checked = True
        Me.opt_Main.Cursor = System.Windows.Forms.Cursors.Default
        Me.opt_Main.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.opt_Main.ForeColor = System.Drawing.Color.White
        Me.opt_Main.Location = New System.Drawing.Point(0, 108)
        Me.opt_Main.Name = "opt_Main"
        Me.opt_Main.Size = New System.Drawing.Size(91, 22)
        Me.opt_Main.TabIndex = 30
        Me.opt_Main.TabStop = True
        Me.opt_Main.Text = "Story Mode"
        Me.opt_Main.UseVisualStyleBackColor = True
        '
        'opt_ChallengeMode
        '
        Me.opt_ChallengeMode.AutoSize = True
        Me.opt_ChallengeMode.Cursor = System.Windows.Forms.Cursors.Default
        Me.opt_ChallengeMode.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.opt_ChallengeMode.ForeColor = System.Drawing.Color.White
        Me.opt_ChallengeMode.Location = New System.Drawing.Point(93, 108)
        Me.opt_ChallengeMode.Name = "opt_ChallengeMode"
        Me.opt_ChallengeMode.Size = New System.Drawing.Size(117, 22)
        Me.opt_ChallengeMode.TabIndex = 32
        Me.opt_ChallengeMode.Text = "Challenge Mode"
        Me.opt_ChallengeMode.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.Controls.Add(Me.opt_EnglishNames)
        Me.Panel3.Controls.Add(Me.opt_InternalNames)
        Me.Panel3.Location = New System.Drawing.Point(398, 123)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(103, 49)
        Me.Panel3.TabIndex = 34
        '
        'opt_EnglishNames
        '
        Me.opt_EnglishNames.AutoSize = True
        Me.opt_EnglishNames.Checked = True
        Me.opt_EnglishNames.Cursor = System.Windows.Forms.Cursors.Default
        Me.opt_EnglishNames.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.opt_EnglishNames.ForeColor = System.Drawing.Color.White
        Me.opt_EnglishNames.Location = New System.Drawing.Point(3, 4)
        Me.opt_EnglishNames.Name = "opt_EnglishNames"
        Me.opt_EnglishNames.Size = New System.Drawing.Size(94, 20)
        Me.opt_EnglishNames.TabIndex = 2
        Me.opt_EnglishNames.TabStop = True
        Me.opt_EnglishNames.Text = "English Names"
        Me.opt_EnglishNames.UseVisualStyleBackColor = True
        '
        'opt_InternalNames
        '
        Me.opt_InternalNames.AutoSize = True
        Me.opt_InternalNames.Cursor = System.Windows.Forms.Cursors.Default
        Me.opt_InternalNames.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.opt_InternalNames.ForeColor = System.Drawing.Color.White
        Me.opt_InternalNames.Location = New System.Drawing.Point(3, 20)
        Me.opt_InternalNames.Name = "opt_InternalNames"
        Me.opt_InternalNames.Size = New System.Drawing.Size(100, 20)
        Me.opt_InternalNames.TabIndex = 3
        Me.opt_InternalNames.Text = "Internal Names"
        Me.opt_InternalNames.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(-2, 59)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(263, 16)
        Me.Label18.TabIndex = 61
        Me.Label18.Text = "Go to Options to set customised import directories"
        '
        'lnk_ExportHelp
        '
        Me.lnk_ExportHelp.AutoSize = True
        Me.lnk_ExportHelp.BackColor = System.Drawing.Color.Transparent
        Me.lnk_ExportHelp.Location = New System.Drawing.Point(9, 7)
        Me.lnk_ExportHelp.Name = "lnk_ExportHelp"
        Me.lnk_ExportHelp.Size = New System.Drawing.Size(100, 16)
        Me.lnk_ExportHelp.TabIndex = 50
        Me.lnk_ExportHelp.TabStop = True
        Me.lnk_ExportHelp.Text = "How do I export?"
        Me.lnk_ExportHelp.Visible = False
        '
        'btn_MoveEntityDown
        '
        Me.btn_MoveEntityDown.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_MoveEntityDown.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_MoveEntityDown.BackgroundImage = Global.P2CC2.My.Resources.Resources.Down_Arrow_20px_dark
        Me.btn_MoveEntityDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_MoveEntityDown.Cursor = System.Windows.Forms.Cursors.Default
        Me.btn_MoveEntityDown.Enabled = False
        Me.btn_MoveEntityDown.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btn_MoveEntityDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_MoveEntityDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_MoveEntityDown.ForeColor = System.Drawing.Color.White
        Me.btn_MoveEntityDown.Location = New System.Drawing.Point(383, 125)
        Me.btn_MoveEntityDown.Name = "btn_MoveEntityDown"
        Me.btn_MoveEntityDown.Size = New System.Drawing.Size(40, 40)
        Me.btn_MoveEntityDown.TabIndex = 57
        Me.ToolTip1.SetToolTip(Me.btn_MoveEntityDown, "Move the selected entity down")
        Me.btn_MoveEntityDown.UseVisualStyleBackColor = False
        '
        'btn_MoveEntityUp
        '
        Me.btn_MoveEntityUp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_MoveEntityUp.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_MoveEntityUp.BackgroundImage = Global.P2CC2.My.Resources.Resources.Up_20px_dark
        Me.btn_MoveEntityUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_MoveEntityUp.Cursor = System.Windows.Forms.Cursors.Default
        Me.btn_MoveEntityUp.Enabled = False
        Me.btn_MoveEntityUp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btn_MoveEntityUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_MoveEntityUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_MoveEntityUp.ForeColor = System.Drawing.Color.White
        Me.btn_MoveEntityUp.Location = New System.Drawing.Point(383, 76)
        Me.btn_MoveEntityUp.Name = "btn_MoveEntityUp"
        Me.btn_MoveEntityUp.Size = New System.Drawing.Size(40, 40)
        Me.btn_MoveEntityUp.TabIndex = 58
        Me.ToolTip1.SetToolTip(Me.btn_MoveEntityUp, "Move the selected entity up")
        Me.btn_MoveEntityUp.UseVisualStyleBackColor = False
        '
        'ListBox1
        '
        Me.ListBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ListBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.ForeColor = System.Drawing.Color.White
        Me.ListBox1.IntegralHeight = False
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Items.AddRange(New Object() {"[Location] [Fall Method] [Name] x [Amount]"})
        Me.ListBox1.Location = New System.Drawing.Point(3, 46)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.ListBox1.Size = New System.Drawing.Size(420, 24)
        Me.ListBox1.TabIndex = 56
        Me.ToolTip1.SetToolTip(Me.ListBox1, "This is how each entity is displayed in the list")
        '
        'lbl_TotalEntityCountSubEnts
        '
        Me.lbl_TotalEntityCountSubEnts.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_TotalEntityCountSubEnts.AutoSize = True
        Me.lbl_TotalEntityCountSubEnts.BackColor = System.Drawing.Color.Transparent
        Me.lbl_TotalEntityCountSubEnts.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_TotalEntityCountSubEnts.ForeColor = System.Drawing.Color.White
        Me.lbl_TotalEntityCountSubEnts.Location = New System.Drawing.Point(314, 8)
        Me.lbl_TotalEntityCountSubEnts.Name = "lbl_TotalEntityCountSubEnts"
        Me.lbl_TotalEntityCountSubEnts.Size = New System.Drawing.Size(61, 20)
        Me.lbl_TotalEntityCountSubEnts.TabIndex = 50
        Me.lbl_TotalEntityCountSubEnts.Text = "Total: 0"
        '
        'cmb_Sublevels
        '
        Me.cmb_Sublevels.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmb_Sublevels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Sublevels.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Sublevels.FormattingEnabled = True
        Me.cmb_Sublevels.Location = New System.Drawing.Point(114, 7)
        Me.cmb_Sublevels.Name = "cmb_Sublevels"
        Me.cmb_Sublevels.Size = New System.Drawing.Size(104, 24)
        Me.cmb_Sublevels.TabIndex = 49
        '
        'btn_ChooseEntity
        '
        Me.btn_ChooseEntity.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_ChooseEntity.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_ChooseEntity.Cursor = System.Windows.Forms.Cursors.Default
        Me.btn_ChooseEntity.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btn_ChooseEntity.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ChooseEntity.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ChooseEntity.ForeColor = System.Drawing.Color.White
        Me.btn_ChooseEntity.Location = New System.Drawing.Point(436, 114)
        Me.btn_ChooseEntity.Name = "btn_ChooseEntity"
        Me.btn_ChooseEntity.Size = New System.Drawing.Size(70, 26)
        Me.btn_ChooseEntity.TabIndex = 40
        Me.btn_ChooseEntity.Text = "Change"
        Me.ToolTip1.SetToolTip(Me.btn_ChooseEntity, "Click to change the entity to add")
        Me.btn_ChooseEntity.UseVisualStyleBackColor = False
        '
        'btn_DeleteSelectedEntity
        '
        Me.btn_DeleteSelectedEntity.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_DeleteSelectedEntity.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_DeleteSelectedEntity.BackgroundImage = Global.P2CC2.My.Resources.Resources.Subtract_20px
        Me.btn_DeleteSelectedEntity.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_DeleteSelectedEntity.Cursor = System.Windows.Forms.Cursors.Default
        Me.btn_DeleteSelectedEntity.Enabled = False
        Me.btn_DeleteSelectedEntity.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btn_DeleteSelectedEntity.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_DeleteSelectedEntity.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_DeleteSelectedEntity.ForeColor = System.Drawing.Color.White
        Me.btn_DeleteSelectedEntity.Location = New System.Drawing.Point(383, 171)
        Me.btn_DeleteSelectedEntity.Name = "btn_DeleteSelectedEntity"
        Me.btn_DeleteSelectedEntity.Size = New System.Drawing.Size(40, 40)
        Me.btn_DeleteSelectedEntity.TabIndex = 38
        Me.ToolTip1.SetToolTip(Me.btn_DeleteSelectedEntity, "Delete the selected entity (Del)")
        Me.btn_DeleteSelectedEntity.UseVisualStyleBackColor = False
        '
        'pic_SelectedEntity
        '
        Me.pic_SelectedEntity.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pic_SelectedEntity.BackColor = System.Drawing.Color.Transparent
        Me.pic_SelectedEntity.Image = Global.P2CC2.My.Resources.Resources.Red_Bulborb_icon
        Me.pic_SelectedEntity.Location = New System.Drawing.Point(436, 46)
        Me.pic_SelectedEntity.Name = "pic_SelectedEntity"
        Me.pic_SelectedEntity.Size = New System.Drawing.Size(70, 70)
        Me.pic_SelectedEntity.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic_SelectedEntity.TabIndex = 43
        Me.pic_SelectedEntity.TabStop = False
        Me.ToolTip1.SetToolTip(Me.pic_SelectedEntity, "The entity's icon")
        '
        'lbl_EntityName
        '
        Me.lbl_EntityName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_EntityName.AutoSize = True
        Me.lbl_EntityName.BackColor = System.Drawing.Color.Transparent
        Me.lbl_EntityName.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_EntityName.ForeColor = System.Drawing.Color.White
        Me.lbl_EntityName.Location = New System.Drawing.Point(508, 46)
        Me.lbl_EntityName.Name = "lbl_EntityName"
        Me.lbl_EntityName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl_EntityName.Size = New System.Drawing.Size(101, 22)
        Me.lbl_EntityName.TabIndex = 41
        Me.lbl_EntityName.Text = "Red Bulborb"
        Me.lbl_EntityName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTip1.SetToolTip(Me.lbl_EntityName, "The entity's English name")
        '
        'lbl_EntityTotalCount
        '
        Me.lbl_EntityTotalCount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_EntityTotalCount.AutoSize = True
        Me.lbl_EntityTotalCount.BackColor = System.Drawing.Color.Transparent
        Me.lbl_EntityTotalCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_EntityTotalCount.ForeColor = System.Drawing.Color.White
        Me.lbl_EntityTotalCount.Location = New System.Drawing.Point(244, 8)
        Me.lbl_EntityTotalCount.Name = "lbl_EntityTotalCount"
        Me.lbl_EntityTotalCount.Size = New System.Drawing.Size(59, 20)
        Me.lbl_EntityTotalCount.TabIndex = 44
        Me.lbl_EntityTotalCount.Text = "Sets: 0"
        '
        'num_EntityCount
        '
        Me.num_EntityCount.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.num_EntityCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.num_EntityCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.num_EntityCount.ForeColor = System.Drawing.Color.White
        Me.num_EntityCount.Location = New System.Drawing.Point(0, 153)
        Me.num_EntityCount.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.num_EntityCount.Name = "num_EntityCount"
        Me.num_EntityCount.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.num_EntityCount.Size = New System.Drawing.Size(53, 22)
        Me.num_EntityCount.TabIndex = 42
        Me.num_EntityCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.num_EntityCount, "Amount of entities for this set")
        Me.num_EntityCount.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'btn_AddEntity
        '
        Me.btn_AddEntity.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btn_AddEntity.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_AddEntity.Cursor = System.Windows.Forms.Cursors.Default
        Me.btn_AddEntity.Enabled = False
        Me.btn_AddEntity.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btn_AddEntity.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_AddEntity.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_AddEntity.ForeColor = System.Drawing.Color.White
        Me.btn_AddEntity.Location = New System.Drawing.Point(94, 281)
        Me.btn_AddEntity.Name = "btn_AddEntity"
        Me.btn_AddEntity.Size = New System.Drawing.Size(149, 40)
        Me.btn_AddEntity.TabIndex = 36
        Me.btn_AddEntity.Text = "Add to Sublevel"
        Me.ToolTip1.SetToolTip(Me.btn_AddEntity, "Add the adjusted entity parameters above to the sublevel")
        Me.btn_AddEntity.UseVisualStyleBackColor = False
        '
        'btn_ClearEntities
        '
        Me.btn_ClearEntities.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_ClearEntities.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_ClearEntities.BackgroundImage = Global.P2CC2.My.Resources.Resources.Trash_20px
        Me.btn_ClearEntities.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_ClearEntities.Cursor = System.Windows.Forms.Cursors.Default
        Me.btn_ClearEntities.Enabled = False
        Me.btn_ClearEntities.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btn_ClearEntities.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ClearEntities.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ClearEntities.ForeColor = System.Drawing.Color.White
        Me.btn_ClearEntities.Location = New System.Drawing.Point(383, 427)
        Me.btn_ClearEntities.Name = "btn_ClearEntities"
        Me.btn_ClearEntities.Size = New System.Drawing.Size(40, 40)
        Me.btn_ClearEntities.TabIndex = 39
        Me.ToolTip1.SetToolTip(Me.btn_ClearEntities, "Delete all entities in this sublevel")
        Me.btn_ClearEntities.UseVisualStyleBackColor = False
        '
        'lst_RegularEntitiesNormList
        '
        Me.lst_RegularEntitiesNormList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lst_RegularEntitiesNormList.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lst_RegularEntitiesNormList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lst_RegularEntitiesNormList.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_RegularEntitiesNormList.ForeColor = System.Drawing.Color.White
        Me.lst_RegularEntitiesNormList.HorizontalScrollbar = True
        Me.lst_RegularEntitiesNormList.IntegralHeight = False
        Me.lst_RegularEntitiesNormList.ItemHeight = 22
        Me.lst_RegularEntitiesNormList.Location = New System.Drawing.Point(3, 76)
        Me.lst_RegularEntitiesNormList.Name = "lst_RegularEntitiesNormList"
        Me.lst_RegularEntitiesNormList.Size = New System.Drawing.Size(374, 391)
        Me.lst_RegularEntitiesNormList.TabIndex = 45
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.lbl_decoNoWeight)
        Me.Panel1.Controls.Add(Me.Label29)
        Me.Panel1.Controls.Add(Me.lbl_GroupCwarning)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.num_EntityWeight)
        Me.Panel1.Controls.Add(Me.cmb_DropTreasures)
        Me.Panel1.Controls.Add(Me.chk_EntityDropTreasure)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.cmb_EntitySpawnMethod)
        Me.Panel1.Controls.Add(Me.cmb_EntitySpawnLocation)
        Me.Panel1.Controls.Add(Me.btn_AddEntity)
        Me.Panel1.Controls.Add(Me.num_EntityCount)
        Me.Panel1.Location = New System.Drawing.Point(436, 146)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(336, 324)
        Me.Panel1.TabIndex = 53
        '
        'lbl_decoNoWeight
        '
        Me.lbl_decoNoWeight.AutoSize = True
        Me.lbl_decoNoWeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_decoNoWeight.ForeColor = System.Drawing.Color.White
        Me.lbl_decoNoWeight.Location = New System.Drawing.Point(57, 178)
        Me.lbl_decoNoWeight.Name = "lbl_decoNoWeight"
        Me.lbl_decoNoWeight.Size = New System.Drawing.Size(140, 26)
        Me.lbl_decoNoWeight.TabIndex = 60
        Me.lbl_decoNoWeight.Text = "Entities in the decoration" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "location don't have a weight"
        Me.lbl_decoNoWeight.Visible = False
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.White
        Me.Label29.Location = New System.Drawing.Point(-3, 134)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(52, 16)
        Me.Label29.TabIndex = 59
        Me.Label29.Text = "Amount"
        '
        'lbl_GroupCwarning
        '
        Me.lbl_GroupCwarning.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_GroupCwarning.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_GroupCwarning.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lbl_GroupCwarning.Location = New System.Drawing.Point(0, 43)
        Me.lbl_GroupCwarning.Name = "lbl_GroupCwarning"
        Me.lbl_GroupCwarning.Size = New System.Drawing.Size(333, 40)
        Me.lbl_GroupCwarning.TabIndex = 58
        Me.lbl_GroupCwarning.Text = "Some rooms do not have spawn points for Group C." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Only use it if you know what yo" &
    "u're doing."
        Me.lbl_GroupCwarning.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(56, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 16)
        Me.Label3.TabIndex = 57
        Me.Label3.Text = "Weight (advanced)"
        '
        'num_EntityWeight
        '
        Me.num_EntityWeight.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.num_EntityWeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.num_EntityWeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.num_EntityWeight.ForeColor = System.Drawing.Color.White
        Me.num_EntityWeight.Location = New System.Drawing.Point(59, 153)
        Me.num_EntityWeight.Maximum = New Decimal(New Integer() {9, 0, 0, 0})
        Me.num_EntityWeight.Name = "num_EntityWeight"
        Me.num_EntityWeight.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.num_EntityWeight.Size = New System.Drawing.Size(115, 22)
        Me.num_EntityWeight.TabIndex = 56
        Me.num_EntityWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.num_EntityWeight, "If unsure, leave at 0")
        '
        'cmb_DropTreasures
        '
        Me.cmb_DropTreasures.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmb_DropTreasures.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_DropTreasures.Enabled = False
        Me.cmb_DropTreasures.FormattingEnabled = True
        Me.cmb_DropTreasures.Items.AddRange(New Object() {"Abstract Masterpiece", "Activity Arouser", "Adamantine Girdle", "Air Brake", "Alien Billboard", "Amplified Amplifier", "Anti-hiccup Fungus", "Anxious Sprout", "Aquatic Mine", "Arboreal Frippery", "Armored Nut", "Behemoth Jaw", "Boom Cone", "Boss Stone", "Broken Food Master", "Brute Knuckles", "Bug Bait", "Chance Totem", "Child of the Earth", "Chocolate Cushion", "Citrus Lump", "Coiled Launcher", "Colossal Fossil", "Combustion Berry", "Comedy Bomb", "Comfort Cookie", "Compelling Cookie", "Confection Hoop", "Conifer Spire", "Corpulent Nut", "Cosmic Archive", "Courage Reactor", "Creative Inspiration", "Crystal Clover", "Crystal King", "Crystallized Clairvoyance", "Crystallized Telekinesis", "Crystallized Telepathy", "Cupid's Grenade", "Danger Chime", "Decorative Goo", "Diet Doomer", "Dimensional Slicer", "Directory of Destiny", "Disguised Delicacy", "Doomsday Apparatus", "Dream Architect", "Dream Material", "Drone Supplies", "Drought Ender", "Durable Energy Cell", "Emperor Whistle", "Enamel Buster", "Endless Repository", "Essence of Desire", "Essence of Despair", "Essence of Rage", "Essence of True Love", "Essential Furnishing", "Eternal Emerald Eye", "Exhausted Superstick", "Extreme Perspirator", "Favorite Gyro Block", "Five-man Napsack", "Flame of Tomorrow", "Flame Tiller", "Flare Cannon", "Fleeting Art Form", "Fond Gyro Block", "Forged Courage", "Fortified Delicacy", "Fossilized Ursidae", "Frosty Bauble", "Fruit Guard", "Fuel Reservoir", "Furious Adhesive", "Future Orb", "Gemstar Husband", "Gemstar Wife", "Geographic Projection", "Gherkin Gate", "Glee Spinner", "Growshroom", "Gyroid Bust", "Happiness Emblem", "Harmonic Synthesizer", "Healing Cask", "Heavy-Duty Magnetizer", "Hideous Victual", "Hypnotic Platter", "Icon of Progress", "Impediment Scourge", "Impenetrable Cookie", "Imperative Cookie", "Implement of Toil", "Indomitable CPU", "Infernal Vegetable", "Innocence Lost", "Insect Condo", "Invigorator", "Joy Receptacle", "Joyless Jewel", "Justice Alloy", "King of Bugs", "King of Sweets", "Leviathan Feather", "Lip Service", "Lost Gyro Block", "Love Nugget", "Love Sphere", "Luck Wafer", "Lustrous Element", "Manual Honer", "Massage Girdle", "Massive Lid", "Master's Instrument", "Maternal Sculpture", "Meat of Champions", "Meat Satchel", "Memorable Gyro Block", "Memorial Shell", "Merciless Extractor", "Milk Tub", "Mirrored Element", "Mirrored Stage", "Mirth Sphere", "Monster Pump", "Mysterious Remains", "Mystical Disc", "Network Mainbrain", "Nouveau Table", "Nutrient Silo", "Olimarnite Shell", "Omega Flywheel", "Omniscient Sphere", "Onion Replica", "Optical Illustration", "Pale Passion", "Paradoxical Enigma", "Pastry Wheel", "Patience Tester", "Petrified Heart", "Pilgrim Bulb", "Pink Menace", "Pondering Emblem", "Possessed Squash", "Priceless Statue", "Princess Pearl", "Professional Noisemaker", "Proton AA", "Prototype Detector", "Quenching Emblem", "Regal Diamond", "Remembered Old Buddy", "Repair Juggernaut", "Repugnant Appendage", "Rubber Ugly", "Salivatrix", "Science Project", "Scrumptious Shell", "Seed of Greed", "Shock Therapist", "Silencer", "Space Wave Receiver", "Spherical Atlas", "Spiny Alien Treat", "Spirit Flogger", "Spouse Alert", "Stellar Orb", "Stone of Glory", "Strife Monolith", "Stringent Container", "Stupendous Lens", "Succulent Mattress", "Sud Generator", "Sulking Antenna", "Sunseed Berry", "Superstick Textile", "Superstrong Stabilizer", "Survival Ointment", "Sweet Dreamer", "Talisman of Life", "Taste Sensation", "Tear Stone", "Temporal Mechanism", "The Key", "Thirst Activator", "Time Capsule", "Toxic Toadstool", "Treasured Gyro Block", "Triple Sugar Threat", "Universal Com", "Unknown Merit", "Unspeakable Wonder", "Utter Scrap", "Vacuum Processor", "Vorpal Platter", "White Goodness", "Wiggle Noggin", "Worthless Statue", "Yellow Taste Tyrant"})
        Me.cmb_DropTreasures.Location = New System.Drawing.Point(158, 19)
        Me.cmb_DropTreasures.Name = "cmb_DropTreasures"
        Me.cmb_DropTreasures.Size = New System.Drawing.Size(178, 21)
        Me.cmb_DropTreasures.TabIndex = 54
        Me.ToolTip1.SetToolTip(Me.cmb_DropTreasures, "This entity's drop treasure")
        '
        'chk_EntityDropTreasure
        '
        Me.chk_EntityDropTreasure.AutoSize = True
        Me.chk_EntityDropTreasure.Cursor = System.Windows.Forms.Cursors.Default
        Me.chk_EntityDropTreasure.ForeColor = System.Drawing.Color.White
        Me.chk_EntityDropTreasure.Location = New System.Drawing.Point(158, 1)
        Me.chk_EntityDropTreasure.Name = "chk_EntityDropTreasure"
        Me.chk_EntityDropTreasure.Size = New System.Drawing.Size(99, 17)
        Me.chk_EntityDropTreasure.TabIndex = 53
        Me.chk_EntityDropTreasure.Text = "Drops Treasure"
        Me.ToolTip1.SetToolTip(Me.chk_EntityDropTreasure, "Whether or not this entity drops a treasure after dying")
        Me.chk_EntityDropTreasure.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(-3, 81)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 16)
        Me.Label5.TabIndex = 52
        Me.Label5.Text = "Fall Method"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(-3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 16)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "Location"
        '
        'cmb_EntitySpawnMethod
        '
        Me.cmb_EntitySpawnMethod.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmb_EntitySpawnMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_EntitySpawnMethod.FormattingEnabled = True
        Me.cmb_EntitySpawnMethod.Items.AddRange(New Object() {"[N] Normal (doesn't fall)", "[$] Fall (Pikmin/leader nearby)", "[$2] Fall (Pikmin nearby, ignore leaders)", "[$3] Fall (Leader nearby, ignore Pikmin)", "[$4] Fall (Pikmin carrying nearby)", "[$5] Fall (Purple Pikmin causes earthquake)"})
        Me.cmb_EntitySpawnMethod.Location = New System.Drawing.Point(0, 100)
        Me.cmb_EntitySpawnMethod.Name = "cmb_EntitySpawnMethod"
        Me.cmb_EntitySpawnMethod.Size = New System.Drawing.Size(336, 21)
        Me.cmb_EntitySpawnMethod.TabIndex = 51
        Me.ToolTip1.SetToolTip(Me.cmb_EntitySpawnMethod, "How the entity will spawn")
        '
        'cmb_EntitySpawnLocation
        '
        Me.cmb_EntitySpawnLocation.BackColor = System.Drawing.SystemColors.Window
        Me.cmb_EntitySpawnLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_EntitySpawnLocation.FormattingEnabled = True
        Me.cmb_EntitySpawnLocation.Items.AddRange(New Object() {"[A] Group A", "[B] Group B", "[C] Group C (Uncommon)", "[D] Dead Ends", "[H] Hazards", "[P] Plants & Decorations"})
        Me.cmb_EntitySpawnLocation.Location = New System.Drawing.Point(0, 19)
        Me.cmb_EntitySpawnLocation.Name = "cmb_EntitySpawnLocation"
        Me.cmb_EntitySpawnLocation.Size = New System.Drawing.Size(152, 21)
        Me.cmb_EntitySpawnLocation.TabIndex = 46
        Me.ToolTip1.SetToolTip(Me.cmb_EntitySpawnLocation, "The general spawn location")
        '
        'opt_2PBattle
        '
        Me.opt_2PBattle.AutoSize = True
        Me.opt_2PBattle.Cursor = System.Windows.Forms.Cursors.Hand
        Me.opt_2PBattle.ForeColor = System.Drawing.Color.Black
        Me.opt_2PBattle.Location = New System.Drawing.Point(462, 154)
        Me.opt_2PBattle.Name = "opt_2PBattle"
        Me.opt_2PBattle.Size = New System.Drawing.Size(71, 17)
        Me.opt_2PBattle.TabIndex = 33
        Me.opt_2PBattle.Text = "2-P Battle"
        Me.opt_2PBattle.UseVisualStyleBackColor = True
        '
        'lst_TreasureSets
        '
        Me.lst_TreasureSets.FormattingEnabled = True
        Me.lst_TreasureSets.Location = New System.Drawing.Point(462, 3)
        Me.lst_TreasureSets.Name = "lst_TreasureSets"
        Me.lst_TreasureSets.Size = New System.Drawing.Size(61, 43)
        Me.lst_TreasureSets.TabIndex = 61
        '
        'lst_GateSets
        '
        Me.lst_GateSets.FormattingEnabled = True
        Me.lst_GateSets.Location = New System.Drawing.Point(529, 2)
        Me.lst_GateSets.Name = "lst_GateSets"
        Me.lst_GateSets.Size = New System.Drawing.Size(59, 43)
        Me.lst_GateSets.TabIndex = 76
        '
        'lst_Gates
        '
        Me.lst_Gates.FormattingEnabled = True
        Me.lst_Gates.Location = New System.Drawing.Point(529, 51)
        Me.lst_Gates.Name = "lst_Gates"
        Me.lst_Gates.Size = New System.Drawing.Size(59, 69)
        Me.lst_Gates.TabIndex = 75
        '
        'lst_Treasures
        '
        Me.lst_Treasures.FormattingEnabled = True
        Me.lst_Treasures.Location = New System.Drawing.Point(462, 52)
        Me.lst_Treasures.Name = "lst_Treasures"
        Me.lst_Treasures.Size = New System.Drawing.Size(61, 69)
        Me.lst_Treasures.TabIndex = 60
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Black
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(163, 271)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(137, 16)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "DEBUG TEXTBOX:"
        '
        'txt_Debug
        '
        Me.txt_Debug.Location = New System.Drawing.Point(163, 290)
        Me.txt_Debug.Multiline = True
        Me.txt_Debug.Name = "txt_Debug"
        Me.txt_Debug.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_Debug.Size = New System.Drawing.Size(200, 79)
        Me.txt_Debug.TabIndex = 40
        '
        'pnl_Debug
        '
        Me.pnl_Debug.BackColor = System.Drawing.Color.Transparent
        Me.pnl_Debug.Controls.Add(Me.lst_TreasureSets)
        Me.pnl_Debug.Controls.Add(Me.lst_GateSets)
        Me.pnl_Debug.Controls.Add(Me.lst_CustomEntityTotal_Check)
        Me.pnl_Debug.Controls.Add(Me.PictureBox2)
        Me.pnl_Debug.Controls.Add(Me.btn_DebugMode)
        Me.pnl_Debug.Controls.Add(Me.opt_2PBattle)
        Me.pnl_Debug.Controls.Add(Me.PictureBox1)
        Me.pnl_Debug.Controls.Add(Me.lst_Gates)
        Me.pnl_Debug.Controls.Add(Me.btn_Save)
        Me.pnl_Debug.Controls.Add(Me.lst_f2_CustomEntityTotal)
        Me.pnl_Debug.Controls.Add(Me.lst_totaka_MusicList)
        Me.pnl_Debug.Controls.Add(Me.lst_Treasures)
        Me.pnl_Debug.Controls.Add(Me.opt_CMintNames)
        Me.pnl_Debug.Controls.Add(Me.lst_f17_Seesaw)
        Me.pnl_Debug.Controls.Add(Me.lst_f16_WaterwraithTimer)
        Me.pnl_Debug.Controls.Add(Me.opt_CMengNames)
        Me.pnl_Debug.Controls.Add(Me.lst_f14_DeadEndCount)
        Me.pnl_Debug.Controls.Add(Me.lst_f13_SolidPlane)
        Me.pnl_Debug.Controls.Add(Me.cmb_ChallengeModeCaves)
        Me.pnl_Debug.Controls.Add(Me.lst_f12_MusicType)
        Me.pnl_Debug.Controls.Add(Me.lst_f10_CloggedHole)
        Me.pnl_Debug.Controls.Add(Me.lst_fa_Skybox)
        Me.pnl_Debug.Controls.Add(Me.lst_f9_LightFile)
        Me.pnl_Debug.Controls.Add(Me.lst_f8_UnitFile)
        Me.pnl_Debug.Controls.Add(Me.lst_RegularEntitiesList)
        Me.pnl_Debug.Controls.Add(Me.lst_f7_Geyser)
        Me.pnl_Debug.Controls.Add(Me.lst_f6_Ratio)
        Me.pnl_Debug.Controls.Add(Me.lst_f5_RoomCount)
        Me.pnl_Debug.Controls.Add(Me.Label4)
        Me.pnl_Debug.Controls.Add(Me.txt_Debug)
        Me.pnl_Debug.Controls.Add(Me.btn_Focus)
        Me.pnl_Debug.Controls.Add(Me.lst_Sublevel_IDs)
        Me.pnl_Debug.Controls.Add(Me.lst_RegularEntitiesCountList)
        Me.pnl_Debug.Controls.Add(Me.lst_SublevelNames)
        Me.pnl_Debug.Controls.Add(Me.lst_RegularEntitiesCounts)
        Me.pnl_Debug.Controls.Add(Me.lst_RegularEntities)
        Me.pnl_Debug.Location = New System.Drawing.Point(861, 28)
        Me.pnl_Debug.Name = "pnl_Debug"
        Me.pnl_Debug.Size = New System.Drawing.Size(613, 520)
        Me.pnl_Debug.TabIndex = 39
        '
        'lst_CustomEntityTotal_Check
        '
        Me.lst_CustomEntityTotal_Check.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_CustomEntityTotal_Check.FormattingEnabled = True
        Me.lst_CustomEntityTotal_Check.ItemHeight = 9
        Me.lst_CustomEntityTotal_Check.Location = New System.Drawing.Point(68, 271)
        Me.lst_CustomEntityTotal_Check.Name = "lst_CustomEntityTotal_Check"
        Me.lst_CustomEntityTotal_Check.Size = New System.Drawing.Size(59, 49)
        Me.lst_CustomEntityTotal_Check.TabIndex = 57
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = Nothing
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Location = New System.Drawing.Point(43, 541)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(50, 43)
        Me.PictureBox2.TabIndex = 52
        Me.PictureBox2.TabStop = False
        '
        'btn_DebugMode
        '
        Me.btn_DebugMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_DebugMode.Location = New System.Drawing.Point(462, 130)
        Me.btn_DebugMode.Name = "btn_DebugMode"
        Me.btn_DebugMode.Size = New System.Drawing.Size(66, 18)
        Me.btn_DebugMode.TabIndex = 45
        Me.btn_DebugMode.Text = "Debug Mode"
        Me.btn_DebugMode.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(89, 541)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(178, 43)
        Me.PictureBox1.TabIndex = 51
        Me.PictureBox1.TabStop = False
        '
        'btn_Save
        '
        Me.btn_Save.BackColor = System.Drawing.Color.Transparent
        Me.btn_Save.BackgroundImage = Global.P2CC2.My.Resources.Resources.Save_96px
        Me.btn_Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Save.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Save.Enabled = False
        Me.btn_Save.FlatAppearance.BorderSize = 0
        Me.btn_Save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn_Save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Save.Location = New System.Drawing.Point(534, 130)
        Me.btn_Save.Name = "btn_Save"
        Me.btn_Save.Size = New System.Drawing.Size(30, 30)
        Me.btn_Save.TabIndex = 50
        Me.ToolTip1.SetToolTip(Me.btn_Save, "Save")
        Me.btn_Save.UseVisualStyleBackColor = False
        '
        'lst_f2_CustomEntityTotal
        '
        Me.lst_f2_CustomEntityTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_f2_CustomEntityTotal.FormattingEnabled = True
        Me.lst_f2_CustomEntityTotal.ItemHeight = 9
        Me.lst_f2_CustomEntityTotal.Location = New System.Drawing.Point(3, 271)
        Me.lst_f2_CustomEntityTotal.Name = "lst_f2_CustomEntityTotal"
        Me.lst_f2_CustomEntityTotal.Size = New System.Drawing.Size(59, 49)
        Me.lst_f2_CustomEntityTotal.TabIndex = 56
        '
        'lst_totaka_MusicList
        '
        Me.lst_totaka_MusicList.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_totaka_MusicList.FormattingEnabled = True
        Me.lst_totaka_MusicList.ItemHeight = 9
        Me.lst_totaka_MusicList.Location = New System.Drawing.Point(328, 209)
        Me.lst_totaka_MusicList.Name = "lst_totaka_MusicList"
        Me.lst_totaka_MusicList.Size = New System.Drawing.Size(59, 49)
        Me.lst_totaka_MusicList.TabIndex = 55
        '
        'opt_CMintNames
        '
        Me.opt_CMintNames.AutoSize = True
        Me.opt_CMintNames.Cursor = System.Windows.Forms.Cursors.Hand
        Me.opt_CMintNames.Location = New System.Drawing.Point(104, 445)
        Me.opt_CMintNames.Name = "opt_CMintNames"
        Me.opt_CMintNames.Size = New System.Drawing.Size(96, 17)
        Me.opt_CMintNames.TabIndex = 38
        Me.opt_CMintNames.Text = "Internal Names"
        Me.ToolTip1.SetToolTip(Me.opt_CMintNames, "Display internal names of the caves")
        Me.opt_CMintNames.UseVisualStyleBackColor = True
        Me.opt_CMintNames.Visible = False
        '
        'lst_f17_Seesaw
        '
        Me.lst_f17_Seesaw.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_f17_Seesaw.FormattingEnabled = True
        Me.lst_f17_Seesaw.ItemHeight = 9
        Me.lst_f17_Seesaw.Location = New System.Drawing.Point(263, 209)
        Me.lst_f17_Seesaw.Name = "lst_f17_Seesaw"
        Me.lst_f17_Seesaw.Size = New System.Drawing.Size(59, 49)
        Me.lst_f17_Seesaw.TabIndex = 54
        '
        'lst_f16_WaterwraithTimer
        '
        Me.lst_f16_WaterwraithTimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_f16_WaterwraithTimer.FormattingEnabled = True
        Me.lst_f16_WaterwraithTimer.ItemHeight = 9
        Me.lst_f16_WaterwraithTimer.Location = New System.Drawing.Point(198, 209)
        Me.lst_f16_WaterwraithTimer.Name = "lst_f16_WaterwraithTimer"
        Me.lst_f16_WaterwraithTimer.Size = New System.Drawing.Size(59, 49)
        Me.lst_f16_WaterwraithTimer.TabIndex = 53
        '
        'opt_CMengNames
        '
        Me.opt_CMengNames.AutoSize = True
        Me.opt_CMengNames.Checked = True
        Me.opt_CMengNames.Cursor = System.Windows.Forms.Cursors.Hand
        Me.opt_CMengNames.Location = New System.Drawing.Point(3, 445)
        Me.opt_CMengNames.Name = "opt_CMengNames"
        Me.opt_CMengNames.Size = New System.Drawing.Size(95, 17)
        Me.opt_CMengNames.TabIndex = 37
        Me.opt_CMengNames.TabStop = True
        Me.opt_CMengNames.Text = "English Names"
        Me.ToolTip1.SetToolTip(Me.opt_CMengNames, "Display English names of the caves")
        Me.opt_CMengNames.UseVisualStyleBackColor = True
        Me.opt_CMengNames.Visible = False
        '
        'lst_f14_DeadEndCount
        '
        Me.lst_f14_DeadEndCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_f14_DeadEndCount.FormattingEnabled = True
        Me.lst_f14_DeadEndCount.ItemHeight = 9
        Me.lst_f14_DeadEndCount.Location = New System.Drawing.Point(133, 209)
        Me.lst_f14_DeadEndCount.Name = "lst_f14_DeadEndCount"
        Me.lst_f14_DeadEndCount.Size = New System.Drawing.Size(59, 49)
        Me.lst_f14_DeadEndCount.TabIndex = 52
        '
        'lst_f13_SolidPlane
        '
        Me.lst_f13_SolidPlane.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_f13_SolidPlane.FormattingEnabled = True
        Me.lst_f13_SolidPlane.ItemHeight = 9
        Me.lst_f13_SolidPlane.Location = New System.Drawing.Point(68, 209)
        Me.lst_f13_SolidPlane.Name = "lst_f13_SolidPlane"
        Me.lst_f13_SolidPlane.Size = New System.Drawing.Size(59, 49)
        Me.lst_f13_SolidPlane.TabIndex = 51
        '
        'cmb_ChallengeModeCaves
        '
        Me.cmb_ChallengeModeCaves.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_ChallengeModeCaves.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_ChallengeModeCaves.FormattingEnabled = True
        Me.cmb_ChallengeModeCaves.Items.AddRange(New Object() {"Explorer's Cave", "Novice Training", "Lost Toy Box", "Creator's Garden", "Green Hole", "Hot House", "Brawny Abyss", "Red Chasm", "Trampled Garden", "Twilight Garden", "Cryptic Cavern", "Concrete Maze", "Collector's Room", "Dweevil Nest", "Cavernous Abyss", "Snack Pit", "Three Color Training", "Hazard Training", "Cave of Snarls", "The Giant's Bath", "Rumbling Grotto", "Subterranean Lair", "Hidden Garden", "Abduction Den", "Secret Testing Range", "Breeding Ground", "Cave of Pain", "Bully Den", "Sniper Room", "Emperor's Realm"})
        Me.cmb_ChallengeModeCaves.Location = New System.Drawing.Point(3, 468)
        Me.cmb_ChallengeModeCaves.Name = "cmb_ChallengeModeCaves"
        Me.cmb_ChallengeModeCaves.Size = New System.Drawing.Size(234, 24)
        Me.cmb_ChallengeModeCaves.TabIndex = 36
        Me.ToolTip1.SetToolTip(Me.cmb_ChallengeModeCaves, "The cave's properties you want to replace")
        Me.cmb_ChallengeModeCaves.Visible = False
        '
        'lst_f12_MusicType
        '
        Me.lst_f12_MusicType.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_f12_MusicType.FormattingEnabled = True
        Me.lst_f12_MusicType.ItemHeight = 9
        Me.lst_f12_MusicType.Location = New System.Drawing.Point(3, 209)
        Me.lst_f12_MusicType.Name = "lst_f12_MusicType"
        Me.lst_f12_MusicType.Size = New System.Drawing.Size(59, 49)
        Me.lst_f12_MusicType.TabIndex = 50
        '
        'lst_f10_CloggedHole
        '
        Me.lst_f10_CloggedHole.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_f10_CloggedHole.FormattingEnabled = True
        Me.lst_f10_CloggedHole.ItemHeight = 9
        Me.lst_f10_CloggedHole.Location = New System.Drawing.Point(393, 147)
        Me.lst_f10_CloggedHole.Name = "lst_f10_CloggedHole"
        Me.lst_f10_CloggedHole.Size = New System.Drawing.Size(59, 49)
        Me.lst_f10_CloggedHole.TabIndex = 49
        '
        'lst_fa_Skybox
        '
        Me.lst_fa_Skybox.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_fa_Skybox.FormattingEnabled = True
        Me.lst_fa_Skybox.ItemHeight = 9
        Me.lst_fa_Skybox.Location = New System.Drawing.Point(328, 147)
        Me.lst_fa_Skybox.Name = "lst_fa_Skybox"
        Me.lst_fa_Skybox.Size = New System.Drawing.Size(59, 49)
        Me.lst_fa_Skybox.TabIndex = 48
        '
        'lst_f9_LightFile
        '
        Me.lst_f9_LightFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_f9_LightFile.FormattingEnabled = True
        Me.lst_f9_LightFile.ItemHeight = 9
        Me.lst_f9_LightFile.Location = New System.Drawing.Point(263, 147)
        Me.lst_f9_LightFile.Name = "lst_f9_LightFile"
        Me.lst_f9_LightFile.Size = New System.Drawing.Size(59, 49)
        Me.lst_f9_LightFile.TabIndex = 47
        '
        'lst_f8_UnitFile
        '
        Me.lst_f8_UnitFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_f8_UnitFile.FormattingEnabled = True
        Me.lst_f8_UnitFile.ItemHeight = 9
        Me.lst_f8_UnitFile.Location = New System.Drawing.Point(198, 147)
        Me.lst_f8_UnitFile.Name = "lst_f8_UnitFile"
        Me.lst_f8_UnitFile.Size = New System.Drawing.Size(59, 49)
        Me.lst_f8_UnitFile.TabIndex = 46
        '
        'lst_RegularEntitiesList
        '
        Me.lst_RegularEntitiesList.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lst_RegularEntitiesList.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_RegularEntitiesList.FormattingEnabled = True
        Me.lst_RegularEntitiesList.ItemHeight = 16
        Me.lst_RegularEntitiesList.Location = New System.Drawing.Point(3, 387)
        Me.lst_RegularEntitiesList.Name = "lst_RegularEntitiesList"
        Me.lst_RegularEntitiesList.Size = New System.Drawing.Size(153, 52)
        Me.lst_RegularEntitiesList.TabIndex = 37
        '
        'lst_f7_Geyser
        '
        Me.lst_f7_Geyser.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_f7_Geyser.FormattingEnabled = True
        Me.lst_f7_Geyser.ItemHeight = 9
        Me.lst_f7_Geyser.Location = New System.Drawing.Point(133, 147)
        Me.lst_f7_Geyser.Name = "lst_f7_Geyser"
        Me.lst_f7_Geyser.Size = New System.Drawing.Size(59, 49)
        Me.lst_f7_Geyser.TabIndex = 45
        '
        'lst_f6_Ratio
        '
        Me.lst_f6_Ratio.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_f6_Ratio.FormattingEnabled = True
        Me.lst_f6_Ratio.ItemHeight = 9
        Me.lst_f6_Ratio.Location = New System.Drawing.Point(68, 147)
        Me.lst_f6_Ratio.Name = "lst_f6_Ratio"
        Me.lst_f6_Ratio.Size = New System.Drawing.Size(59, 49)
        Me.lst_f6_Ratio.TabIndex = 44
        '
        'lst_f5_RoomCount
        '
        Me.lst_f5_RoomCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_f5_RoomCount.FormattingEnabled = True
        Me.lst_f5_RoomCount.ItemHeight = 9
        Me.lst_f5_RoomCount.Location = New System.Drawing.Point(3, 147)
        Me.lst_f5_RoomCount.Name = "lst_f5_RoomCount"
        Me.lst_f5_RoomCount.Size = New System.Drawing.Size(59, 49)
        Me.lst_f5_RoomCount.TabIndex = 43
        '
        'btn_Focus
        '
        Me.btn_Focus.Location = New System.Drawing.Point(461, 177)
        Me.btn_Focus.Name = "btn_Focus"
        Me.btn_Focus.Size = New System.Drawing.Size(75, 23)
        Me.btn_Focus.TabIndex = 1
        Me.btn_Focus.Text = "I take focus"
        Me.btn_Focus.UseVisualStyleBackColor = True
        '
        'lst_RegularEntitiesCountList
        '
        Me.lst_RegularEntitiesCountList.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_RegularEntitiesCountList.FormattingEnabled = True
        Me.lst_RegularEntitiesCountList.Location = New System.Drawing.Point(3, 325)
        Me.lst_RegularEntitiesCountList.Name = "lst_RegularEntitiesCountList"
        Me.lst_RegularEntitiesCountList.Size = New System.Drawing.Size(153, 56)
        Me.lst_RegularEntitiesCountList.TabIndex = 38
        '
        'SaveAsDialog
        '
        Me.SaveAsDialog.CheckPathExists = False
        Me.SaveAsDialog.DefaultExt = "p2ncc"
        Me.SaveAsDialog.FileName = "New Cave.p2ncc"
        Me.SaveAsDialog.Filter = "New Cave Creator Project File|*.p2ncc"
        Me.SaveAsDialog.RestoreDirectory = True
        '
        'LoadDialog
        '
        Me.LoadDialog.DefaultExt = "p2ncc"
        Me.LoadDialog.Filter = "Cave files|*.p2ncc;*.txt"
        Me.LoadDialog.RestoreDirectory = True
        '
        'ExportAsDialog
        '
        Me.ExportAsDialog.CheckPathExists = False
        Me.ExportAsDialog.DefaultExt = "txt"
        Me.ExportAsDialog.Filter = "Normal text file|*.txt"
        '
        'ToolTip1
        '
        Me.ToolTip1.AutoPopDelay = 5000
        Me.ToolTip1.BackColor = System.Drawing.Color.Black
        Me.ToolTip1.ForeColor = System.Drawing.Color.White
        Me.ToolTip1.InitialDelay = 150
        Me.ToolTip1.ReshowDelay = 100
        Me.ToolTip1.UseAnimation = False
        Me.ToolTip1.UseFading = False
        '
        'btn_CloseEntities
        '
        Me.btn_CloseEntities.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_CloseEntities.BackgroundImage = Global.P2CC2.My.Resources.Resources.Back_20px
        Me.btn_CloseEntities.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_CloseEntities.Cursor = System.Windows.Forms.Cursors.Default
        Me.btn_CloseEntities.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btn_CloseEntities.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_CloseEntities.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_CloseEntities.ForeColor = System.Drawing.Color.White
        Me.btn_CloseEntities.Location = New System.Drawing.Point(3, 3)
        Me.btn_CloseEntities.Name = "btn_CloseEntities"
        Me.btn_CloseEntities.Size = New System.Drawing.Size(30, 30)
        Me.btn_CloseEntities.TabIndex = 80
        Me.ToolTip1.SetToolTip(Me.btn_CloseEntities, "Apply changes and go back")
        Me.btn_CloseEntities.UseVisualStyleBackColor = False
        '
        'FolderBrowserDialog_CMP
        '
        Me.FolderBrowserDialog_CMP.Description = "Locate your extracted Pikmin 2 (GCN) root folder."
        Me.FolderBrowserDialog_CMP.ShowNewFolderButton = False
        '
        'RootBrowserDialog
        '
        Me.RootBrowserDialog.Description = "Locate your extracted Pikmin 2 (GCN) root folder."
        Me.RootBrowserDialog.ShowNewFolderButton = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_Load, Me.btn_SaveAs, Me.btn_SaveProject, Me.ToolStripSeparator1, Me.btn_ReturnToMainMenu, Me.btn_CaveNet, Me.ToolStripButton4, Me.ToolStripSeparator2, Me.ToolStripButton3, Me.ToolStripButton2, Me.ToolStripSeparator4})
        Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(1611, 25)
        Me.ToolStrip1.TabIndex = 54
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btn_Load
        '
        Me.btn_Load.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Load.ForeColor = System.Drawing.Color.White
        Me.btn_Load.Image = Global.P2CC2.My.Resources.Resources.Open_96px
        Me.btn_Load.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_Load.Name = "btn_Load"
        Me.btn_Load.Size = New System.Drawing.Size(65, 22)
        Me.btn_Load.Text = "Open..."
        '
        'btn_SaveAs
        '
        Me.btn_SaveAs.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_SaveAs.ForeColor = System.Drawing.Color.White
        Me.btn_SaveAs.Image = Global.P2CC2.My.Resources.Resources.Save_as_96px
        Me.btn_SaveAs.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_SaveAs.Name = "btn_SaveAs"
        Me.btn_SaveAs.Size = New System.Drawing.Size(75, 22)
        Me.btn_SaveAs.Text = "Save As..."
        '
        'btn_SaveProject
        '
        Me.btn_SaveProject.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_SaveProject.ForeColor = System.Drawing.Color.White
        Me.btn_SaveProject.Image = Global.P2CC2.My.Resources.Resources.Save_96px
        Me.btn_SaveProject.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_SaveProject.Name = "btn_SaveProject"
        Me.btn_SaveProject.Size = New System.Drawing.Size(50, 22)
        Me.btn_SaveProject.Text = "Save"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btn_ReturnToMainMenu
        '
        Me.btn_ReturnToMainMenu.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ReturnToMainMenu.ForeColor = System.Drawing.Color.White
        Me.btn_ReturnToMainMenu.Image = Global.P2CC2.My.Resources.Resources.Home_50px
        Me.btn_ReturnToMainMenu.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_ReturnToMainMenu.Name = "btn_ReturnToMainMenu"
        Me.btn_ReturnToMainMenu.Size = New System.Drawing.Size(79, 22)
        Me.btn_ReturnToMainMenu.Text = "Main Menu"
        '
        'btn_CaveNet
        '
        Me.btn_CaveNet.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_CaveNet.ForeColor = System.Drawing.Color.White
        Me.btn_CaveNet.Image = Global.P2CC2.My.Resources.Resources.Anode_Beetle_icon
        Me.btn_CaveNet.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_CaveNet.Name = "btn_CaveNet"
        Me.btn_CaveNet.Size = New System.Drawing.Size(73, 22)
        Me.btn_CaveNet.Text = "Cave Net"
        Me.btn_CaveNet.Visible = False
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton4.ForeColor = System.Drawing.Color.White
        Me.ToolStripButton4.Image = Global.P2CC2.My.Resources.Resources.Settings_48px
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(66, 22)
        Me.ToolStripButton4.Text = "Options"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton3.ForeColor = System.Drawing.Color.White
        Me.ToolStripButton3.Image = Global.P2CC2.My.Resources.Resources.Help_48px
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(48, 22)
        Me.ToolStripButton3.Text = "Help"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton2.ForeColor = System.Drawing.Color.White
        Me.ToolStripButton2.Image = Global.P2CC2.My.Resources.Resources.Info_48px
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(56, 22)
        Me.ToolStripButton2.Text = "About"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        Me.ToolStripSeparator4.Visible = False
        '
        'pnl_Entities
        '
        Me.pnl_Entities.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.pnl_Entities.Controls.Add(Me.Panel8)
        Me.pnl_Entities.Controls.Add(Me.Panel7)
        Me.pnl_Entities.Controls.Add(Me.Panel6)
        Me.pnl_Entities.Controls.Add(Me.btn_CloseEntities)
        Me.pnl_Entities.Controls.Add(Me.lbl_NoSublevels)
        Me.pnl_Entities.Controls.Add(Me.Label23)
        Me.pnl_Entities.Controls.Add(Me.btn_MoveEntityDown)
        Me.pnl_Entities.Controls.Add(Me.cmb_Sublevels)
        Me.pnl_Entities.Controls.Add(Me.btn_MoveEntityUp)
        Me.pnl_Entities.Controls.Add(Me.Panel1)
        Me.pnl_Entities.Controls.Add(Me.ListBox1)
        Me.pnl_Entities.Controls.Add(Me.lst_RegularEntitiesNormList)
        Me.pnl_Entities.Controls.Add(Me.lbl_TotalEntityCountSubEnts)
        Me.pnl_Entities.Controls.Add(Me.btn_ClearEntities)
        Me.pnl_Entities.Controls.Add(Me.btn_ChooseEntity)
        Me.pnl_Entities.Controls.Add(Me.btn_DeleteSelectedEntity)
        Me.pnl_Entities.Controls.Add(Me.lbl_EntityTotalCount)
        Me.pnl_Entities.Controls.Add(Me.pic_SelectedEntity)
        Me.pnl_Entities.Controls.Add(Me.lbl_EntityName)
        Me.pnl_Entities.Location = New System.Drawing.Point(827, 554)
        Me.pnl_Entities.Name = "pnl_Entities"
        Me.pnl_Entities.Size = New System.Drawing.Size(772, 470)
        Me.pnl_Entities.TabIndex = 55
        Me.pnl_Entities.Visible = False
        '
        'Panel8
        '
        Me.Panel8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel8.BackColor = System.Drawing.Color.White
        Me.Panel8.Location = New System.Drawing.Point(3, 39)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(769, 1)
        Me.Panel8.TabIndex = 84
        '
        'Panel7
        '
        Me.Panel7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel7.BackColor = System.Drawing.Color.White
        Me.Panel7.Location = New System.Drawing.Point(429, 39)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(1, 431)
        Me.Panel7.TabIndex = 83
        '
        'Panel6
        '
        Me.Panel6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel6.BackColor = System.Drawing.Color.White
        Me.Panel6.Location = New System.Drawing.Point(224, 17)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(18, 3)
        Me.Panel6.TabIndex = 81
        '
        'lbl_NoSublevels
        '
        Me.lbl_NoSublevels.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_NoSublevels.AutoSize = True
        Me.lbl_NoSublevels.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_NoSublevels.ForeColor = System.Drawing.Color.Red
        Me.lbl_NoSublevels.Location = New System.Drawing.Point(381, 6)
        Me.lbl_NoSublevels.Name = "lbl_NoSublevels"
        Me.lbl_NoSublevels.Size = New System.Drawing.Size(252, 22)
        Me.lbl_NoSublevels.TabIndex = 79
        Me.lbl_NoSublevels.Text = "You need to add a sublevel first!"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.White
        Me.Label23.Location = New System.Drawing.Point(38, 7)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(70, 24)
        Me.Label23.TabIndex = 59
        Me.Label23.Text = "Entities"
        '
        'tmr_Autosave
        '
        Me.tmr_Autosave.Interval = 60000
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 20
        '
        'pnl_PROCESSINGTHECAVE
        '
        Me.pnl_PROCESSINGTHECAVE.Controls.Add(Me.Label1)
        Me.pnl_PROCESSINGTHECAVE.Location = New System.Drawing.Point(12, 538)
        Me.pnl_PROCESSINGTHECAVE.Name = "pnl_PROCESSINGTHECAVE"
        Me.pnl_PROCESSINGTHECAVE.Size = New System.Drawing.Size(772, 481)
        Me.pnl_PROCESSINGTHECAVE.TabIndex = 58
        Me.pnl_PROCESSINGTHECAVE.Visible = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(316, 227)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Processing..."
        '
        'Form1
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1611, 1031)
        Me.Controls.Add(Me.pnl_PROCESSINGTHECAVE)
        Me.Controls.Add(Me.lbl_SublevelTotal)
        Me.Controls.Add(Me.pnl_Entities)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.pnl_Debug)
        Me.Controls.Add(Me.TabControl1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(800, 516)
        Me.Name = "Form1"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cave Creator"
        Me.cms_SublevelsListbox.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.tbp_SublevelManager.ResumeLayout(False)
        Me.tbp_SublevelManager.PerformLayout()
        Me.tbp_ChallengeModeProperties.ResumeLayout(False)
        Me.tbp_ChallengeModeProperties.PerformLayout()
        CType(Me.num_TimerTime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_CMPsubCount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_ubs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_uss, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.num_cL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_cF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_bulbL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_cB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_bulbB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_rL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_yL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_bL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_wL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_pL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_rB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_yB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_bB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_wB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_pF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_pB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_wF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_rF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_bF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_yF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_bulbF, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbp_ImportManager.ResumeLayout(False)
        Me.tbp_ImportManager.PerformLayout()
        Me.pnl_Controls.ResumeLayout(False)
        Me.pnl_Controls.PerformLayout()
        Me.pnl_Advanced.ResumeLayout(False)
        Me.pnl_Advanced.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.pic_SelectedEntity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_EntityCount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.num_EntityWeight, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_Debug.ResumeLayout(False)
        Me.pnl_Debug.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.pnl_Entities.ResumeLayout(False)
        Me.pnl_Entities.PerformLayout()
        Me.pnl_PROCESSINGTHECAVE.ResumeLayout(False)
        Me.pnl_PROCESSINGTHECAVE.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lst_Sublevels As ListBox
    Friend WithEvents lbl_SublevelTotal As Label
    Friend WithEvents lst_Sublevel_IDs As ListBox
    Friend WithEvents lst_SublevelNames As ListBox
    Friend WithEvents chk_SublevelNameInput As CheckBox
    Friend WithEvents lst_RegularEntities As ListBox
    Friend WithEvents btn_MoveSublevelDown As Button
    Friend WithEvents btn_MoveSublevelUp As Button
    Friend WithEvents lbl_SublevelID As Label
    Friend WithEvents btn_RenameSublevel As Button
    Friend WithEvents lst_RegularEntitiesCounts As ListBox
    Friend WithEvents btn_RemoveSublevelName As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tbp_SublevelManager As TabPage
    Friend WithEvents tbp_ChallengeModeProperties As TabPage
    Friend WithEvents lbl_SelectedSublevelTitle As Label
    Friend WithEvents btn_ChooseEntity As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_AddEntity As Button
    Friend WithEvents btn_DeleteSelectedEntity As Button
    Friend WithEvents cmb_EntitySpawnLocation As ComboBox
    Friend WithEvents btn_ClearEntities As Button
    Friend WithEvents lbl_EntityName As Label
    Friend WithEvents lst_RegularEntitiesNormList As ListBox
    Friend WithEvents num_EntityCount As NumericUpDown
    Friend WithEvents pic_SelectedEntity As PictureBox
    Friend WithEvents lbl_EntityTotalCount As Label
    Friend WithEvents lst_RegularEntitiesCountList As ListBox
    Friend WithEvents lst_RegularEntitiesList As ListBox
    Friend WithEvents cmb_Sublevels As ComboBox
    Friend WithEvents pnl_Debug As Panel
    Friend WithEvents btn_SublevelProperties As Button
    Friend WithEvents SaveAsDialog As SaveFileDialog
    Friend WithEvents LoadDialog As OpenFileDialog
    Friend WithEvents btn_Focus As Button
    Friend WithEvents txt_Debug As TextBox
    Friend WithEvents lbl_EntityCount As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_DebugMode As Button
    Friend WithEvents lbl_TotalEntityCount As Label
    Friend WithEvents lbl_TotalEntityCountSubEnts As Label
    Friend WithEvents ExportAsDialog As SaveFileDialog
    Friend WithEvents lst_f17_Seesaw As ListBox
    Friend WithEvents lst_f16_WaterwraithTimer As ListBox
    Friend WithEvents lst_f14_DeadEndCount As ListBox
    Friend WithEvents lst_f13_SolidPlane As ListBox
    Friend WithEvents lst_f12_MusicType As ListBox
    Friend WithEvents lst_f10_CloggedHole As ListBox
    Friend WithEvents lst_fa_Skybox As ListBox
    Friend WithEvents lst_f9_LightFile As ListBox
    Friend WithEvents lst_f8_UnitFile As ListBox
    Friend WithEvents lst_f7_Geyser As ListBox
    Friend WithEvents lst_f6_Ratio As ListBox
    Friend WithEvents lst_f5_RoomCount As ListBox
    Friend WithEvents lst_totaka_MusicList As ListBox
    Friend WithEvents lst_CustomEntityTotal_Check As ListBox
    Friend WithEvents lst_f2_CustomEntityTotal As ListBox
    Friend WithEvents chk_DeleteSublevelQ As CheckBox
    Friend WithEvents cms_SublevelsListbox As ContextMenuStrip
    Friend WithEvents AddToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lnk_ExportHelp As LinkLabel
    Friend WithEvents Label5 As Label
    Friend WithEvents cmb_EntitySpawnMethod As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents cmb_DropTreasures As ComboBox
    Friend WithEvents chk_EntityDropTreasure As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents num_EntityWeight As NumericUpDown
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents num_pF As NumericUpDown
    Friend WithEvents num_pB As NumericUpDown
    Friend WithEvents num_pL As NumericUpDown
    Friend WithEvents num_wF As NumericUpDown
    Friend WithEvents num_wB As NumericUpDown
    Friend WithEvents num_wL As NumericUpDown
    Friend WithEvents num_bF As NumericUpDown
    Friend WithEvents num_bB As NumericUpDown
    Friend WithEvents num_bL As NumericUpDown
    Friend WithEvents num_yF As NumericUpDown
    Friend WithEvents num_yB As NumericUpDown
    Friend WithEvents num_yL As NumericUpDown
    Friend WithEvents num_rF As NumericUpDown
    Friend WithEvents num_rB As NumericUpDown
    Friend WithEvents num_rL As NumericUpDown
    Friend WithEvents lbl_PikiCount As Label
    Friend WithEvents lbl_100pikiReminder As Label
    Friend WithEvents num_ubs As NumericUpDown
    Friend WithEvents num_uss As NumericUpDown
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btn_ImportChallengeModeProperties As Button
    Friend WithEvents FolderBrowserDialog_CMP As FolderBrowserDialog
    Friend WithEvents chk_CMPadvanced As CheckBox
    Friend WithEvents pnl_CMPadvanced As Panel
    Friend WithEvents btn_CMPcopyCode As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents num_CMPsubCount As NumericUpDown
    Friend WithEvents Label19 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents num_cL As NumericUpDown
    Friend WithEvents num_cF As NumericUpDown
    Friend WithEvents num_bulbL As NumericUpDown
    Friend WithEvents num_cB As NumericUpDown
    Friend WithEvents num_bulbB As NumericUpDown
    Friend WithEvents num_bulbF As NumericUpDown
    Friend WithEvents Label20 As Label
    Friend WithEvents lst_Times As ListBox
    Friend WithEvents tbp_ImportManager As TabPage
    Friend WithEvents txt_RootDirectory As TextBox
    Friend WithEvents btn_LoadRoot As Button
    Friend WithEvents RootBrowserDialog As FolderBrowserDialog
    Friend WithEvents pnl_Controls As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents opt_EnglishNames As RadioButton
    Friend WithEvents opt_InternalNames As RadioButton
    Friend WithEvents opt_2PBattle As RadioButton
    Friend WithEvents opt_ChallengeMode As RadioButton
    Friend WithEvents opt_Main As RadioButton
    Friend WithEvents pnl_Advanced As Panel
    Friend WithEvents chk_IgnoreCaveMusic As CheckBox
    Friend WithEvents chk_ShowAdvanced As CheckBox
    Friend WithEvents btn_CopyMusicCode As Button
    Friend WithEvents btn_ExportCaveFile As Button
    Friend WithEvents chk_UseCMproperties As CheckBox
    Friend WithEvents lbl_CMsaved As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents lbl_GroupCwarning As Label
    Friend WithEvents lst_Treasures As ListBox
    Friend WithEvents lst_TreasureSets As ListBox
    Friend WithEvents lst_GateSets As ListBox
    Friend WithEvents lst_Gates As ListBox
    Friend WithEvents cmb_ReplaceWith As ComboBox
    Friend WithEvents btn_Gates As Button
    Friend WithEvents btn_Entities As Button
    Friend WithEvents btn_Treasures As Button
    Friend WithEvents btn_MoveEntityDown As Button
    Friend WithEvents btn_MoveEntityUp As Button
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btn_Load As ToolStripButton
    Friend WithEvents btn_SaveAs As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents btn_ReturnToMainMenu As ToolStripButton
    Friend WithEvents pnl_Entities As Panel
    Friend WithEvents Label23 As Label
    Friend WithEvents btn_ImportCave As Button
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents lbl_NoSublevels As Label
    Friend WithEvents btn_SaveProject As ToolStripButton
    Friend WithEvents tmr_Autosave As Timer
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents chk_IgnoreTheKey As CheckBox
    Friend WithEvents lbl_AdditionalOptionsTitle As Label
    Friend WithEvents btn_CloseEntities As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Private WithEvents ToolTip1 As ToolTip
    Friend WithEvents btn_CaveNet As ToolStripButton
    Friend WithEvents pnl_PROCESSINGTHECAVE As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label25 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents num_TimerTime As NumericUpDown
    Friend WithEvents btn_TimeHelp As Button
    Friend WithEvents btn_DuplicateSub As Button
    Friend WithEvents btn_AddSublevel2 As Button
    Friend WithEvents btn_DeleteAllSublevels3 As Button
    Friend WithEvents btn_RemoveSublevel2 As Button
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label29 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents btn_Save As Button
    Friend WithEvents opt_CMintNames As RadioButton
    Friend WithEvents opt_CMengNames As RadioButton
    Friend WithEvents cmb_ChallengeModeCaves As ComboBox
    Friend WithEvents lbl_decoNoWeight As Label
    Friend WithEvents btn_getBase64 As Button
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents Label18 As Label
End Class
