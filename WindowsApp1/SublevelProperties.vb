Public Class SublevelProperties
    Dim ChangesMade As Boolean = False
    Dim Loading As Boolean = True
    Private Sub SublevelProperties_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.Closing
        If chk_f7_Geyser.Checked = True Then
            Form1.lst_f7_Geyser.Items.Insert(Form1.lst_f7_Geyser.SelectedIndex, "1")
            Form1.lst_f7_Geyser.Items.RemoveAt(Form1.lst_f7_Geyser.SelectedIndex)
        Else
            Form1.lst_f7_Geyser.Items.Insert(Form1.lst_f7_Geyser.SelectedIndex, "0")
            Form1.lst_f7_Geyser.Items.RemoveAt(Form1.lst_f7_Geyser.SelectedIndex)
        End If
        Form1.lst_f7_Geyser.SelectedIndex = Form1.lst_Sublevels.SelectedIndex


        If chk_f10_CloggedHole.Checked = True Then
            Form1.lst_f10_CloggedHole.Items.Insert(Form1.lst_f10_CloggedHole.SelectedIndex, "1")
            Form1.lst_f10_CloggedHole.Items.RemoveAt(Form1.lst_f10_CloggedHole.SelectedIndex)
        Else
            Form1.lst_f10_CloggedHole.Items.Insert(Form1.lst_f10_CloggedHole.SelectedIndex, "0")
            Form1.lst_f10_CloggedHole.Items.RemoveAt(Form1.lst_f10_CloggedHole.SelectedIndex)
        End If
        Form1.lst_f10_CloggedHole.SelectedIndex = Form1.lst_Sublevels.SelectedIndex


        If chk_f13_SolidPlane.Checked = True Then
            Form1.lst_f13_SolidPlane.Items.Insert(Form1.lst_f13_SolidPlane.SelectedIndex, "1")
            Form1.lst_f13_SolidPlane.Items.RemoveAt(Form1.lst_f13_SolidPlane.SelectedIndex)
        Else
            Form1.lst_f13_SolidPlane.Items.Insert(Form1.lst_f13_SolidPlane.SelectedIndex, "0")
            Form1.lst_f13_SolidPlane.Items.RemoveAt(Form1.lst_f13_SolidPlane.SelectedIndex)
        End If
        Form1.lst_f13_SolidPlane.SelectedIndex = Form1.lst_Sublevels.SelectedIndex


        If chk_f17_Seesaw.Checked = True Then
            Form1.lst_f17_Seesaw.Items.Insert(Form1.lst_f17_Seesaw.SelectedIndex, "1")
            Form1.lst_f17_Seesaw.Items.RemoveAt(Form1.lst_f17_Seesaw.SelectedIndex)
        Else
            Form1.lst_f17_Seesaw.Items.Insert(Form1.lst_f17_Seesaw.SelectedIndex, "0")
            Form1.lst_f17_Seesaw.Items.RemoveAt(Form1.lst_f17_Seesaw.SelectedIndex)
        End If
        Form1.lst_f17_Seesaw.SelectedIndex = Form1.lst_Sublevels.SelectedIndex


        If chk_NoMusic.Checked = True Then
            Form1.lst_f12_MusicType.Items.Insert(Form1.lst_f12_MusicType.SelectedIndex, "1")
            Form1.lst_f12_MusicType.Items.RemoveAt(Form1.lst_f12_MusicType.SelectedIndex)
        Else
            Form1.lst_f12_MusicType.Items.Insert(Form1.lst_f12_MusicType.SelectedIndex, "0")
            Form1.lst_f12_MusicType.Items.RemoveAt(Form1.lst_f12_MusicType.SelectedIndex)
        End If
        Form1.lst_f12_MusicType.SelectedIndex = Form1.lst_Sublevels.SelectedIndex


        If chk_CustomEntityTotal.Checked = True Then
            Form1.lst_CustomEntityTotal_Check.Items.Insert(Form1.lst_CustomEntityTotal_Check.SelectedIndex, "1")
            Form1.lst_CustomEntityTotal_Check.Items.RemoveAt(Form1.lst_CustomEntityTotal_Check.SelectedIndex)

            Form1.lst_f2_CustomEntityTotal.Items.Insert(Form1.lst_f2_CustomEntityTotal.SelectedIndex, num_CustomEntityTotal.Value)
            Form1.lst_f2_CustomEntityTotal.Items.RemoveAt(Form1.lst_f2_CustomEntityTotal.SelectedIndex)
        Else
            Form1.lst_CustomEntityTotal_Check.Items.Insert(Form1.lst_CustomEntityTotal_Check.SelectedIndex, "0")
            Form1.lst_CustomEntityTotal_Check.Items.RemoveAt(Form1.lst_CustomEntityTotal_Check.SelectedIndex)
        End If
        Form1.lst_CustomEntityTotal_Check.SelectedIndex = Form1.lst_Sublevels.SelectedIndex
        Form1.lst_f2_CustomEntityTotal.SelectedIndex = Form1.lst_Sublevels.SelectedIndex


        Form1.lst_f5_RoomCount.Items.Insert(Form1.lst_f5_RoomCount.SelectedIndex, num_RoomCount.Value)
        Form1.lst_f5_RoomCount.Items.RemoveAt(Form1.lst_f5_RoomCount.SelectedIndex)
        Form1.lst_f5_RoomCount.SelectedIndex = Form1.lst_Sublevels.SelectedIndex


        Form1.lst_f16_WaterwraithTimer.Items.Insert(Form1.lst_f16_WaterwraithTimer.SelectedIndex, num_WaterwraithTimer.Value)
        Form1.lst_f16_WaterwraithTimer.Items.RemoveAt(Form1.lst_f16_WaterwraithTimer.SelectedIndex)
        Form1.lst_f16_WaterwraithTimer.SelectedIndex = Form1.lst_Sublevels.SelectedIndex


        Form1.lst_f8_UnitFile.Items.Insert(Form1.lst_f8_UnitFile.SelectedIndex, cmb_UnitFile.SelectedItem)
        Form1.lst_f8_UnitFile.Items.RemoveAt(Form1.lst_f8_UnitFile.SelectedIndex)
        Form1.lst_f8_UnitFile.SelectedIndex = Form1.lst_Sublevels.SelectedIndex


        Form1.lst_f9_LightFile.Items.Insert(Form1.lst_f9_LightFile.SelectedIndex, cmb_LightFile.SelectedItem)
        Form1.lst_f9_LightFile.Items.RemoveAt(Form1.lst_f9_LightFile.SelectedIndex)
        Form1.lst_f9_LightFile.SelectedIndex = Form1.lst_Sublevels.SelectedIndex


        Form1.lst_f6_Ratio.Items.Insert(Form1.lst_f6_Ratio.SelectedIndex, num_Ratio.Value)
        Form1.lst_f6_Ratio.Items.RemoveAt(Form1.lst_f6_Ratio.SelectedIndex)
        Form1.lst_f6_Ratio.SelectedIndex = Form1.lst_Sublevels.SelectedIndex


        Form1.lst_f14_DeadEndCount.Items.Insert(Form1.lst_f14_DeadEndCount.SelectedIndex, num_DeadEnds.Value)
        Form1.lst_f14_DeadEndCount.Items.RemoveAt(Form1.lst_f14_DeadEndCount.SelectedIndex)
        Form1.lst_f14_DeadEndCount.SelectedIndex = Form1.lst_Sublevels.SelectedIndex

        Dim ConvertedSkybox As String = "none"
        ConvertedSkybox = cmb_Skybox.SelectedItem

        Form1.lst_fa_Skybox.Items.Insert(Form1.lst_fa_Skybox.SelectedIndex, ConvertedSkybox)
        Form1.lst_fa_Skybox.Items.RemoveAt(Form1.lst_fa_Skybox.SelectedIndex)
        Form1.lst_fa_Skybox.SelectedIndex = Form1.lst_Sublevels.SelectedIndex


        Form1.lst_totaka_MusicList.Items.Insert(Form1.lst_totaka_MusicList.SelectedIndex, cmb_MusicSongFile.SelectedItem)
        Form1.lst_totaka_MusicList.Items.RemoveAt(Form1.lst_totaka_MusicList.SelectedIndex)
        Form1.lst_totaka_MusicList.SelectedIndex = Form1.lst_Sublevels.SelectedIndex



        ChangesMade = False



        If ChangesMade = True Then
            e.Cancel = True
            Dim result As Integer = MessageBox.Show("Are you sure you want cancel any changes you made?", "Close Sublevel Properties", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)
            If result = DialogResult.Yes Then
                ChangesMade = False
                e.Cancel = False
                Form1.Enabled = True
                Form1.Select()
            End If
        Else
            Form1.Enabled = True
            Form1.Select()
        End If
    End Sub
    Private Sub SublevelProperties_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim str As String = ""
        For Each item As String In cmb_MusicSongFile.Items
            str += """" & item & """," & vbCrLf
        Next
        Loading = True
        'Me.Opacity = 0
        lbl_SublevelName.Text = Form1.lst_Sublevels.SelectedItem



        If Form1.lst_f7_Geyser.SelectedItem = "1" Then
            chk_f7_Geyser.Checked = True
        ElseIf Form1.lst_f7_Geyser.SelectedItem = "0" Then
            chk_f7_Geyser.Checked = False
        End If

        If Form1.lst_f12_MusicType.SelectedItem = "1" Then
            chk_NoMusic.Checked = True
        ElseIf Form1.lst_f12_MusicType.SelectedItem = "0" Then
            chk_NoMusic.Checked = False
        End If

        If cmb_UnitFile.Items.Contains(Form1.lst_f8_UnitFile.SelectedItem) Then
            cmb_UnitFile.SelectedItem = Form1.lst_f8_UnitFile.SelectedItem
        Else
            MsgBox("Unit filename was not found in the list and so it's being added now.")
            cmb_UnitFile.Items.Add(Form1.lst_f8_UnitFile.SelectedItem)
            cmb_UnitFile.SelectedItem = Form1.lst_f8_UnitFile.SelectedItem
        End If

        If cmb_LightFile.Items.Contains(Form1.lst_f9_LightFile.SelectedItem) Then
            cmb_LightFile.SelectedItem = Form1.lst_f9_LightFile.SelectedItem
        Else
            MsgBox("Light filename was not found in the list and so it's being added now.")
            cmb_LightFile.Items.Add(Form1.lst_f9_LightFile.SelectedItem)
            cmb_LightFile.SelectedItem = Form1.lst_f9_LightFile.SelectedItem
        End If

        If cmb_LightFile.Items.Contains(Form1.lst_f9_LightFile.SelectedItem) Then
            cmb_LightFile.SelectedItem = Form1.lst_f9_LightFile.SelectedItem
        Else
            MsgBox("Light filename was not found in the list and so it's being added now.")
            cmb_LightFile.Items.Add(Form1.lst_f9_LightFile.SelectedItem)
            cmb_LightFile.SelectedItem = Form1.lst_f9_LightFile.SelectedItem
        End If

        If cmb_MusicSongFile.Items.Contains(Form1.lst_totaka_MusicList.SelectedItem) Then
            cmb_MusicSongFile.SelectedItem = Form1.lst_totaka_MusicList.SelectedItem
        Else
            MsgBox("Music filename was not found in the list and so it's being added now.")
            cmb_MusicSongFile.Items.Add(Form1.lst_totaka_MusicList.SelectedItem)
            cmb_MusicSongFile.SelectedItem = Form1.lst_totaka_MusicList.SelectedItem
        End If

        If Form1.lst_f10_CloggedHole.SelectedItem = "1" Then
            chk_f10_CloggedHole.Checked = True
        ElseIf Form1.lst_f10_CloggedHole.SelectedItem = "0" Then
            chk_f10_CloggedHole.Checked = False
        End If

        If Form1.lst_f13_SolidPlane.SelectedItem = "1" Then
            chk_f13_SolidPlane.Checked = True
        ElseIf Form1.lst_f13_SolidPlane.SelectedItem = "0" Then
            chk_f13_SolidPlane.Checked = False
        End If

        If Form1.lst_f17_Seesaw.SelectedItem = "1" Then
            chk_f17_Seesaw.Checked = True
        ElseIf Form1.lst_f17_Seesaw.SelectedItem = "0" Then
            chk_f17_Seesaw.Checked = False
        End If

        If Form1.lst_CustomEntityTotal_Check.SelectedItem = "1" Then
            chk_CustomEntityTotal.Checked = True
            num_CustomEntityTotal.Value = Form1.lst_f2_CustomEntityTotal.SelectedItem
        ElseIf Form1.lst_CustomEntityTotal_Check.SelectedItem = "0" Then
            chk_CustomEntityTotal.Checked = False
            If Form1.lbl_TotalEntityCount.Text.Contains("weight") Then
                num_CustomEntityTotal.Value = Form1.lbl_TotalEntityCount.Text.Substring(Form1.lbl_TotalEntityCount.Text.IndexOf(":") + 2, (Form1.lbl_TotalEntityCount.Text.IndexOf("+") - 1) - (Form1.lbl_TotalEntityCount.Text.IndexOf(":") + 2))
            Else
                num_CustomEntityTotal.Value = Form1.lbl_TotalEntityCount.Text.Substring(Form1.lbl_TotalEntityCount.Text.IndexOf(":") + 2, Form1.lbl_TotalEntityCount.Text.Length - (Form1.lbl_TotalEntityCount.Text.IndexOf(":") + 2))
            End If
        End If

        num_RoomCount.Value = Form1.lst_f5_RoomCount.SelectedItem

        num_Ratio.Value = Form1.lst_f6_Ratio.SelectedItem

        num_DeadEnds.Value = Form1.lst_f14_DeadEndCount.SelectedItem

        num_WaterwraithTimer.Value = Form1.lst_f16_WaterwraithTimer.SelectedItem

        If cmb_Skybox.Items.Contains(Form1.lst_fa_Skybox.SelectedItem) Then
            cmb_Skybox.SelectedItem = Form1.lst_fa_Skybox.SelectedItem
        Else
            MsgBox("Skybox filename was not found in the list and so it's being added now.")
            cmb_Skybox.Items.Add(Form1.lst_fa_Skybox.SelectedItem)
            cmb_Skybox.SelectedItem = Form1.lst_fa_Skybox.SelectedItem
        End If
    End Sub
    Private Sub btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        ChangesMade = False
        Dim tmr As New Timer
        tmr.Interval = 1
        tmr.Start()
        AddHandler tmr.Tick, Sub()
                                 Me.Size = New Size(Me.Width, Me.Height - 25)
                                 Me.Opacity -= 0.04
                                 If Me.Height <= 10 Then
                                     Me.Opacity = 0
                                     tmr.Stop()
                                     Me.Close()
                                     Form1.Enabled = True
                                     Form1.Select()
                                     Me.Size = New Size(423, 601)
                                 End If
                             End Sub
    End Sub
    Private Sub btn_SaveChanges_Click(sender As Object, e As EventArgs) Handles btn_SaveChanges.Click


        If chk_f7_Geyser.Checked = True Then
            Form1.lst_f7_Geyser.Items.Insert(Form1.lst_f7_Geyser.SelectedIndex, "1")
            Form1.lst_f7_Geyser.Items.RemoveAt(Form1.lst_f7_Geyser.SelectedIndex)
        Else
            Form1.lst_f7_Geyser.Items.Insert(Form1.lst_f7_Geyser.SelectedIndex, "0")
            Form1.lst_f7_Geyser.Items.RemoveAt(Form1.lst_f7_Geyser.SelectedIndex)
        End If
        Form1.lst_f7_Geyser.SelectedIndex = Form1.lst_Sublevels.SelectedIndex


        If chk_f10_CloggedHole.Checked = True Then
            Form1.lst_f10_CloggedHole.Items.Insert(Form1.lst_f10_CloggedHole.SelectedIndex, "1")
            Form1.lst_f10_CloggedHole.Items.RemoveAt(Form1.lst_f10_CloggedHole.SelectedIndex)
        Else
            Form1.lst_f10_CloggedHole.Items.Insert(Form1.lst_f10_CloggedHole.SelectedIndex, "0")
            Form1.lst_f10_CloggedHole.Items.RemoveAt(Form1.lst_f10_CloggedHole.SelectedIndex)
        End If
        Form1.lst_f10_CloggedHole.SelectedIndex = Form1.lst_Sublevels.SelectedIndex


        If chk_f13_SolidPlane.Checked = True Then
            Form1.lst_f13_SolidPlane.Items.Insert(Form1.lst_f13_SolidPlane.SelectedIndex, "1")
            Form1.lst_f13_SolidPlane.Items.RemoveAt(Form1.lst_f13_SolidPlane.SelectedIndex)
        Else
            Form1.lst_f13_SolidPlane.Items.Insert(Form1.lst_f13_SolidPlane.SelectedIndex, "0")
            Form1.lst_f13_SolidPlane.Items.RemoveAt(Form1.lst_f13_SolidPlane.SelectedIndex)
        End If
        Form1.lst_f13_SolidPlane.SelectedIndex = Form1.lst_Sublevels.SelectedIndex


        If chk_f17_Seesaw.Checked = True Then
            Form1.lst_f17_Seesaw.Items.Insert(Form1.lst_f17_Seesaw.SelectedIndex, "1")
            Form1.lst_f17_Seesaw.Items.RemoveAt(Form1.lst_f17_Seesaw.SelectedIndex)
        Else
            Form1.lst_f17_Seesaw.Items.Insert(Form1.lst_f17_Seesaw.SelectedIndex, "0")
            Form1.lst_f17_Seesaw.Items.RemoveAt(Form1.lst_f17_Seesaw.SelectedIndex)
        End If
        Form1.lst_f17_Seesaw.SelectedIndex = Form1.lst_Sublevels.SelectedIndex


        If chk_NoMusic.Checked = True Then
            Form1.lst_f12_MusicType.Items.Insert(Form1.lst_f12_MusicType.SelectedIndex, "1")
            Form1.lst_f12_MusicType.Items.RemoveAt(Form1.lst_f12_MusicType.SelectedIndex)
        Else
            Form1.lst_f12_MusicType.Items.Insert(Form1.lst_f12_MusicType.SelectedIndex, "0")
            Form1.lst_f12_MusicType.Items.RemoveAt(Form1.lst_f12_MusicType.SelectedIndex)
        End If
        Form1.lst_f12_MusicType.SelectedIndex = Form1.lst_Sublevels.SelectedIndex


        If chk_CustomEntityTotal.Checked = True Then
            Form1.lst_CustomEntityTotal_Check.Items.Insert(Form1.lst_CustomEntityTotal_Check.SelectedIndex, "1")
            Form1.lst_CustomEntityTotal_Check.Items.RemoveAt(Form1.lst_CustomEntityTotal_Check.SelectedIndex)

            Form1.lst_f2_CustomEntityTotal.Items.Insert(Form1.lst_f2_CustomEntityTotal.SelectedIndex, num_CustomEntityTotal.Value)
            Form1.lst_f2_CustomEntityTotal.Items.RemoveAt(Form1.lst_f2_CustomEntityTotal.SelectedIndex)
        Else
            Form1.lst_CustomEntityTotal_Check.Items.Insert(Form1.lst_CustomEntityTotal_Check.SelectedIndex, "0")
            Form1.lst_CustomEntityTotal_Check.Items.RemoveAt(Form1.lst_CustomEntityTotal_Check.SelectedIndex)
        End If
        Form1.lst_CustomEntityTotal_Check.SelectedIndex = Form1.lst_Sublevels.SelectedIndex
        Form1.lst_f2_CustomEntityTotal.SelectedIndex = Form1.lst_Sublevels.SelectedIndex


        Form1.lst_f5_RoomCount.Items.Insert(Form1.lst_f5_RoomCount.SelectedIndex, num_RoomCount.Value)
        Form1.lst_f5_RoomCount.Items.RemoveAt(Form1.lst_f5_RoomCount.SelectedIndex)
        Form1.lst_f5_RoomCount.SelectedIndex = Form1.lst_Sublevels.SelectedIndex


        Form1.lst_f16_WaterwraithTimer.Items.Insert(Form1.lst_f16_WaterwraithTimer.SelectedIndex, num_WaterwraithTimer.Value)
        Form1.lst_f16_WaterwraithTimer.Items.RemoveAt(Form1.lst_f16_WaterwraithTimer.SelectedIndex)
        Form1.lst_f16_WaterwraithTimer.SelectedIndex = Form1.lst_Sublevels.SelectedIndex


        Form1.lst_f8_UnitFile.Items.Insert(Form1.lst_f8_UnitFile.SelectedIndex, cmb_UnitFile.SelectedItem)
        Form1.lst_f8_UnitFile.Items.RemoveAt(Form1.lst_f8_UnitFile.SelectedIndex)
        Form1.lst_f8_UnitFile.SelectedIndex = Form1.lst_Sublevels.SelectedIndex


        Form1.lst_f9_LightFile.Items.Insert(Form1.lst_f9_LightFile.SelectedIndex, cmb_LightFile.SelectedItem)
        Form1.lst_f9_LightFile.Items.RemoveAt(Form1.lst_f9_LightFile.SelectedIndex)
        Form1.lst_f9_LightFile.SelectedIndex = Form1.lst_Sublevels.SelectedIndex


        Form1.lst_f6_Ratio.Items.Insert(Form1.lst_f6_Ratio.SelectedIndex, num_Ratio.Value)
        Form1.lst_f6_Ratio.Items.RemoveAt(Form1.lst_f6_Ratio.SelectedIndex)
        Form1.lst_f6_Ratio.SelectedIndex = Form1.lst_Sublevels.SelectedIndex


        Form1.lst_f14_DeadEndCount.Items.Insert(Form1.lst_f14_DeadEndCount.SelectedIndex, num_DeadEnds.Value)
        Form1.lst_f14_DeadEndCount.Items.RemoveAt(Form1.lst_f14_DeadEndCount.SelectedIndex)
        Form1.lst_f14_DeadEndCount.SelectedIndex = Form1.lst_Sublevels.SelectedIndex

        Dim ConvertedSkybox As String = "none"
        ConvertedSkybox = cmb_Skybox.SelectedItem

        Form1.lst_fa_Skybox.Items.Insert(Form1.lst_fa_Skybox.SelectedIndex, ConvertedSkybox)
        Form1.lst_fa_Skybox.Items.RemoveAt(Form1.lst_fa_Skybox.SelectedIndex)
        Form1.lst_fa_Skybox.SelectedIndex = Form1.lst_Sublevels.SelectedIndex


        Form1.lst_totaka_MusicList.Items.Insert(Form1.lst_totaka_MusicList.SelectedIndex, cmb_MusicSongFile.SelectedItem)
        Form1.lst_totaka_MusicList.Items.RemoveAt(Form1.lst_totaka_MusicList.SelectedIndex)
        Form1.lst_totaka_MusicList.SelectedIndex = Form1.lst_Sublevels.SelectedIndex



        ChangesMade = False

        'Dim tmr As New Timer
        'tmr.Interval = 1
        'tmr.Start()
        'AddHandler tmr.Tick, Sub()
        '                         Me.Size = New Size(Me.Width, Me.Height - 25)
        '                         Me.Opacity -= 0.04
        '                         If Me.Height <= 10 Then
        '                             Me.Opacity = 0
        '                             tmr.Stop()
        '                             Me.Close()
        '                             Form1.Enabled = True
        '                             Form1.Select()
        '                             Me.Size = New Size(423, 601)
        '                         End If
        '                     End Sub

    End Sub
    Private Sub chk_f7_Geyser_Click(sender As Object, e As EventArgs) Handles chk_f7_Geyser.CheckedChanged
        ChangesWereMade()
    End Sub
    Private Sub chk_f10_CloggedHole_Click(sender As Object, e As EventArgs) Handles chk_f10_CloggedHole.CheckedChanged
        ChangesWereMade()
    End Sub
    Private Sub chk_f13_SolidPlane_CheckedChanged(sender As Object, e As EventArgs) Handles chk_f13_SolidPlane.CheckedChanged
        ChangesWereMade()
    End Sub
    Private Sub chk_f17_Seesaw_CheckedChanged(sender As Object, e As EventArgs) Handles chk_f17_Seesaw.CheckedChanged
        ChangesWereMade()
    End Sub
    Private Sub chk_CustomEntityTotal_CheckedChanged(sender As Object, e As EventArgs) Handles chk_CustomEntityTotal.CheckedChanged
        ChangesWereMade()
        If chk_CustomEntityTotal.Checked = True Then
            num_CustomEntityTotal.Enabled = True
        Else
            num_CustomEntityTotal.Enabled = False
        End If
    End Sub
    Private Sub lnk_WhatIsUnit_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnk_WhatIsUnit.LinkClicked
        System.Diagnostics.Process.Start("https://pikmintkb.com/wiki/Cave_unit_definition_file")
    End Sub

    Private Sub lnk_LightScreenshots_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnk_LightScreenshots.LinkClicked
        System.Diagnostics.Process.Start("https://pikmintkb.com/wiki/Pikmin_2_cave_lighting_files#Vanilla_Light_File_Gallery")
    End Sub

    Private Sub lnk_MusicSongList_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnk_MusicSongList.LinkClicked
        MsgBox("The following web page only lists what is used in the vanilla game, the rest are unused variations.")
        System.Diagnostics.Process.Start("https://www.pikminwiki.com/Music_in_Pikmin_2#Caves")
    End Sub
    Private Sub cmb_UnitFile_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_UnitFile.SelectedIndexChanged
        ChangesWereMade()
        If cmb_UnitFile.SelectedIndex >= 282 Then
            Button1.Enabled = False
        Else
            Button1.Enabled = True
        End If
    End Sub

    Private Sub cmb_LightFile_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_LightFile.SelectedIndexChanged
        ChangesWereMade()
    End Sub
    Private Sub cmb_MusicSongFile_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_MusicSongFile.SelectedIndexChanged
        ChangesWereMade()
    End Sub
    Private Sub btn_AddUnitFile_Click(sender As Object, e As EventArgs) Handles btn_AddUnitFile.Click
        Dim UnitFileName As String = InputBox("Type the name of your file, without the '.txt'.")
        If UnitFileName > "" Then
            UnitFileName = UnitFileName & ".txt"
            If cmb_UnitFile.Items.Contains(UnitFileName) Then
                MsgBox("There is already a unit file called """ & UnitFileName & """ in the list.

It will now be selected.")
                cmb_UnitFile.SelectedItem = UnitFileName
            Else
                cmb_UnitFile.Items.Add(UnitFileName)
                cmb_UnitFile.SelectedItem = UnitFileName
            End If
        End If
    End Sub
    Private Sub btn_AddLightFile_Click(sender As Object, e As EventArgs) Handles btn_AddLightFile.Click
        Dim LightFileName As String = InputBox("Type the name of your file, without the '.ini'.")
        If LightFileName > "" Then
            LightFileName = LightFileName & ".ini"
            If cmb_LightFile.Items.Contains(LightFileName) Then
                MsgBox("There is already a light file called """ & LightFileName & """ in the list.

It will now be selected.")
                cmb_LightFile.SelectedItem = LightFileName
            Else
                cmb_LightFile.Items.Add(LightFileName)
                cmb_LightFile.SelectedItem = LightFileName
            End If
        End If
    End Sub

    Private Sub lnk_RoomCountHelp_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnk_RoomCountHelp.LinkClicked
        MsgBox("Room Count:

Rooms are the individual pieces that form a sublevel. In-game; the moment you enter a new room, the map screen (initial pause menu) will be updated with the bird's-eye view of that new room.

This parameter allows you to specify how many rooms you want your sublevel to contain.


Reference 1: The first vanilla sublevel in Hole of Beasts (Awakening Wood) has two rooms - they're identical but one is rotated (automatically) to connect to the first.

Reference 2: The second vanilla sublevel in Emergence Cave (Valley of Repose) has one room - it's a single, but very large room which cannot cannect to any other rooms.

--------------------------------------------------------------------------------------------

Important Note: The higher you set this, the longer it'll take to load your sublevel - along with that, it'll also increase the possibility of crashing.

Recommended Maximum: 7 (across all room types)")
    End Sub

    Private Sub lnk_RatioHelp_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnk_RatioHelp.LinkClicked
        MsgBox("Corridor-to-Room Ratio:

'Corridors' refers to the long (or short) hallways and turns that connect rooms to each other.

This parameter acts like a ratio; where zero will be absolutely no corridors, and one will be lots and lots of corridors.


Reference 1: The fourth vanilla sublevel in White Flower Garden (Awakening Wood) has several small rooms. The ratio for this sublevel being 0.1, all these small rooms connect to each other with turns, giving it that maze-like feeling. If the ratio was set to zero, there would be an increase in dead ends (less room connection through corridors) and the sublevel overall would lose it's natural appeal.

Reference 2: The fourth vanilla sublevel in Snagret Hole (Awakening Wood) has a few metal rooms. The ratio for this sublevel being 0.05, only a small amount of room exits connect to other rooms.

Reference 3: Through making a sublevel spawn with the ratio set to one, depending on the room types, this will either create labyrinths or extremely long hallways all over the place.

--------------------------------------------------------------------------------------------

Important Note: The higher you set this, the longer it'll take to load your sublevel - along with that, it'll also increase the possibility of crashing.

To Avoid Crashing: Ensure your room count is low - usually three rooms is the max that will work with a ratio of one.

Recommended Balance: 0.12")
    End Sub
    Private Sub lnk_MaxDeadEndsHelp_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnk_MaxDeadEndsHelp.LinkClicked
        MsgBox("Maximum Dead Ends:

Dead ends appear at exits in a room that aren't connected to other rooms.

This parameter allows you to specify a maximum of dead ends you want your sublevel to contain.

--------------------------------------------------------------------------------------------

Important Note: Setting this to zero will result in open exits in any rooms containing exits (most of them).

Recommended Count: 100 (to avoid any possible gaps to an abyss)")
    End Sub

    Private Sub lnk_SkyboxHelp_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnk_SkyboxHelp.LinkClicked
        MsgBox("Skybox:

The skybox is the surrounding environment model, where none is just black.


'build' - Steel: Typically used with the metal theme.

'flooring' - Wooden Floor: Typically used with the toybox theme, along with a solid plane.

'hiroba' - Garden: Typically used with the garden (pebbles) theme, along with a solid plane.

'ice' - Ice Cavern: Typically used with the metal theme in a snowy stage (such as Subterranean Complex, Valley of Repose).

'tatami' - Carpet: Typically used with the toybox theme, along with a solid plane.

'test' - Cavern: Typically used with the metal theme.

If you see anything other than the above, that means this sublevel contains a custom skybox (the cave will crash if you don't have it).

--------------------------------------------------------------------------------------------

Important Note: Most rooms are meant to be used without a skybox (none), these inlude concrete (conc), dirt (tsuchi), snow (snow), snow bricks (renga), and tile (tile).

The other types that are to be used with skyboxes are metal (metal), toybox (toy), and garden (kusachi).")
    End Sub
    Private Sub lnk_CloggedHoleHelp_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnk_CloggedHoleHelp.LinkClicked
        MsgBox("Clogged Hole:

A clogged hole is when there's a rock-like formation blocking the hole to the next sublevel, and thus requires Pikmin to destroy it to proceed with the cave.

This parameter allows you to choose whether or not you want your sublevel to contain a clogged hole.


For reference: Sublevel 2 - Submerged Castle, Perplexing Pool")
    End Sub
    Private Sub lnk_SolidPlaneHelp_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnk_SolidPlaneHelp.LinkClicked
        MsgBox("Solid Plane:

A solid plane will give the out-of-room areas a collision plane, made for the outdoor (garden) and toybox (wooden floor and carpet) themes as they allow Pikmin to get out into that area. It is not recommended for use on metal-themed stages as they are traditionally meant to allow Pikmin to fall down and die.

This parameter allows you to choose whether or not you want your sublevel to contain a solid plane.


For reference: Sublevel 1 - Dream Den, Wistful Wild")
    End Sub
    Private Sub lnk_SeesawHelp_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnk_SeesawHelp.LinkClicked
        MsgBox("Seesaw:

A seesaw in Pikmin 2 is two connected blocks, where one goes up when the other is weighed down by the leader and/or Pikmin. This is an unused feature in caves, probably because of it's RNG - it will spawn literally anywhere, you may even start inside of one.

This parameter allows you to choose whether or not you want your sublevel to contain a seesaw.


For reference: Awakening Wood (nearby White Flower Garden) and Perplexing Pool (nearby Glutton's Kitchen)")
    End Sub
    Private Sub lnk_CustomEntityTotalHelp_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnk_CustomEntityTotalHelp.LinkClicked
        MsgBox("Custom Entity Count:

This is a specified maximum value for your cave's entity count (not including dead ends) and is only important if you understand and want to use spawn distribution weight.


Spawn Distribution Weight:

(From the Pikmin Technical Knowledge Base) Some types of entities may come up more often than others. For instance, a developer could want a cave where the enemy slots are filled randomly, with each one having a 90% chance of being a Red Bulborb, and 10% chance of being a Wollywog. This is known as weighted random distribution. In Pikmin 2, every entity has a weight value that goes from 0 to 9. If an entity's weight value is 0, that entity will not be picked.


For an example, visit: https://pikmintkb.com/wiki/Cave_spawning#Weighted_distribution")
    End Sub
    Private Sub chk_NoMusic_CheckedChanged(sender As Object, e As EventArgs) Handles chk_NoMusic.CheckedChanged
        ChangesWereMade()
        If chk_NoMusic.Checked = True Then
            cmb_MusicSongFile.Enabled = False
        Else
            cmb_MusicSongFile.Enabled = True
        End If
    End Sub
    Private Sub num_RoomCount_ValueChanged(sender As Object, e As EventArgs) Handles num_RoomCount.ValueChanged
        ChangesWereMade()
    End Sub
    Private Sub num_Ratio_ValueChanged(sender As Object, e As EventArgs) Handles num_Ratio.ValueChanged
        ChangesWereMade()
    End Sub
    Private Sub num_DeadEnds_ValueChanged(sender As Object, e As EventArgs) Handles num_DeadEnds.ValueChanged
        ChangesWereMade()
    End Sub
    Private Sub cmb_Skybox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_Skybox.SelectedIndexChanged
        ChangesWereMade()
    End Sub
    Private Sub lnk_GeyserHelp_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnk_GeyserHelp.LinkClicked
        MsgBox("Geyser:

Geysers are an optional addition to your sublevel in case you feel it's necessary. Commonly, these are found on rest sublevels in the vanilla game.")
    End Sub

    Private Sub lnk_WaterwraithHelp_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnk_WaterwraithHelp.LinkClicked
        MsgBox("Waterwraith Timer:

This is the time (in seconds) the player needs to be waiting in the sublevel before the Waterwraith(s) fall from the sky.

NOTE: If you don't actually set any Waterwraith's to spawn (in Sublevel Entities), then nothing will happen when the timer is done.

Setting this to 0 means it will immediately fall from the sky.")
    End Sub

    Private Sub btn_AddMusicFile_Click(sender As Object, e As EventArgs) Handles btn_AddMusicFile.Click
        Dim MusicFileName As String = InputBox("Type the name of your file, without the '.cnd'.")
        If MusicFileName > "" Then
            MusicFileName = MusicFileName & ".cnd"
            If cmb_MusicSongFile.Items.Contains(MusicFileName) Then
                MsgBox("There is already a music file called """ & MusicFileName & """ in the list.

It will now be selected.")
                cmb_MusicSongFile.SelectedItem = MusicFileName
            Else
                cmb_MusicSongFile.Items.Add(MusicFileName)
                cmb_MusicSongFile.SelectedItem = MusicFileName
            End If
        End If
    End Sub

    Private Sub btn_AddSkybox_Click(sender As Object, e As EventArgs) Handles btn_AddSkybox.Click
        Dim SkyboxFileName As String = InputBox("Type the name of your file, without the '.szs'.")
        If SkyboxFileName > "" Then
            If cmb_Skybox.Items.Contains(SkyboxFileName) Then
                MsgBox("There is already a skybox called """ & SkyboxFileName & """ in the list.

It will now be selected.")
                cmb_Skybox.SelectedItem = SkyboxFileName
            Else
                cmb_Skybox.Items.Add(SkyboxFileName)
                cmb_Skybox.SelectedItem = SkyboxFileName
            End If
        End If
    End Sub
    Sub ChangesWereMade()
        If Loading = False Then
            ChangesMade = True
            btn_SaveChanges.PerformClick()
        End If
    End Sub

    Private Sub SublevelProperties_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Loading = False
    End Sub

    Private Sub num_CustomEntityTotal_ValueChanged(sender As Object, e As EventArgs) Handles num_CustomEntityTotal.ValueChanged
        ChangesWereMade()
    End Sub
    Public Function GetImageFile(ByVal fn As String) As Image
        If IO.File.Exists(fn) Then
            Dim img As Image = Image.FromFile(fn)
            Dim bm As New Bitmap(width:=img.Width, height:=img.Height, format:=img.PixelFormat)
            Using g As Graphics = Graphics.FromImage(bm)
                g.DrawImage(img, Point.Empty)
            End Using
            img.Dispose()
            Return bm
        Else
            MessageBox.Show("Nice try!, but " & fn & "does not exist.  Returning Nothing")
            Return Nothing
        End If
    End Function
    Public Function ResizeImg(ByVal img As Image, ByVal maxwidth As Integer)
        Dim original As Image = img
        Dim intWidth As Integer = original.Width : Dim intHeight As Integer = original.Height
        Dim newWidth, newHeight As Integer
        If intWidth > maxwidth Then
            newWidth = maxwidth
            newHeight = maxwidth * (intHeight / intWidth)
            Dim newSize As New Size(newWidth, newHeight)
            Return newSize
        Else
            Return New Size(original.Width, original.Height)
        End If
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim filenames = "1_ABE_ari_metal.txt
1_ABE_king_tsuchi.txt
1_ABE_manp_boss_conc.txt
1_ABE_mid1_boss_tsuchi.txt
1_ABE_mid1_metal.txt
1_ABE_mid1_tsuchi.txt
1_ABE_vshit67_toy.txt
1_MAT_cent2_tsuchi.txt
1_MAT_danh_conc.txt
1_MAT_h446_metal.txt
1_MAT_hit224_cap_icap_metal.txt
1_MAT_ike_kusachi.txt
1_MAT_manp_2_conc.txt
1_MAT_manp_conc.txt
1_MAT_manq_2_conc.txt
1_MAT_manq_conc.txt
1_MAT_mid2_metal.txt
1_MAT_mid2_tsuchi.txt
1_MAT_north_boss_tsuchi.txt
1_MAT_north_tsuchi.txt
1_MAT_tower2_toy.txt
1_MAT_vs_drypool_tile.txt
1_MIYA_big_kusachi.txt
1_MIYA_bunki_tile.txt
1_MIYA_manh2_conc.txt
1_MIYA_mid_toy.txt
1_NARI_4x4b_conc.txt
1_NARI_4x4c_conc.txt
1_NARI_hit6x6_toy.txt
1_NARI_hit6x7_toy.txt
1_NARI_north4_tsuchi.txt
1_NARI_ud_tile.txt
1_units_5x5a_kusachi.txt
1_units_a_conc.txt
1_units_a_tile.txt
1_units_big2_kusachi.txt
1_units_boss_tsuchi.txt
1_units_bunki_2_tile.txt
1_units_bunki_tile.txt
1_units_cent2_tsuchi.txt
1_units_cent3_tsuchi.txt
1_units_cent_tsuchi.txt
1_units_dangomushi_tile.txt
1_units_DKumo_conc.txt
1_units_hit224_metal.txt
1_units_hit6x6_yakushima_toy.txt
1_units_houdai2_metal.txt
1_units_houdai_metal.txt
1_units_ike4_tsuchi.txt
1_units_king_tsuchi.txt
1_units_large_toy.txt
1_units_manh_boss_conc.txt
1_units_manh_conc.txt
1_units_mid2_snow.txt
1_units_mid2_tsuchi.txt
1_units_mid_kusachi.txt
1_units_nobo2_metal.txt
1_units_nobo_metal.txt
1_units_north_metal.txt
1_units_north_snow.txt
1_units_north_tutorial_snow.txt
1_units_opan_toy.txt
1_units_otakara_tile.txt
1_units_purple_snow.txt
1_units_queen_b_tsuchi.txt
1_units_queen_c_tsuchi.txt
1_units_sara_toy.txt
1_units_snake_tsuchi.txt
1_units_spiral_conc.txt
1_units_torigoya_kusachi.txt
1_units_tower2_toy.txt
1_units_tower_toy.txt
1_units_white_metal.txt
1_unit_16x17r_conc.txt
2_ABE_a_dry_tile.txt
2_ABE_blk_cent2_tsuchi.txt
2_ABE_blk_hit3_tsuchi.txt
2_ABE_bunki_manp_tile.txt
2_ABE_d_dry_tile.txt
2_ABE_hit1_hit3_tsuchi.txt
2_ABE_mid1_nor3_tsuchi.txt
2_ABE_mid_big_kusachi.txt
2_ABE_nobo2_nor22_metal.txt
2_ABE_nor1_cen2_metal.txt
2_ABE_nor1_hit43_metal.txt
2_ABE_norhiba_blkhiba_tsuchi.txt
2_ABE_north_snow_manh2.txt
2_ABE_units_5x5a_mid_kusachi.txt
2_MAT_5x5_mid_kusachi.txt
2_MAT_ari_cent_metal.txt
2_MAT_a_b_conc.txt
2_MAT_a_m_conc.txt
2_MAT_cent_mid2_tsuchi.txt
2_MAT_cent_north_boss_tsuchi.txt
2_MAT_cent_north_tsuchi.txt
2_MAT_f_k_conc.txt
2_MAT_h224_h443_tekiF_metal.txt
2_MAT_h335_h447_metal.txt
2_MAT_hit3_nor4_tsuchi.txt
2_MAT_hit4_nor2_tsuchi.txt
2_MAT_hit4_north_metal.txt
2_MAT_kingA_kingB_tsuchi.txt
2_MAT_manp_manq_conc.txt
2_MAT_mid1_nor2_tsuchi.txt
2_MAT_mid2_h443_tekiF_metal.txt
2_MAT_sak1_sak2_snow.txt
2_MAT_sak2_nor1_tsuchi.txt
2_MAT_tak22_nor22_tile.txt
2_NARI_hit3_nor3_tsuchi.txt
2_NARI_hit4x7_small_toy.txt
2_NARI_nor3_mid2_tsuchi.txt
2_units_473_663_toy.txt
2_units_5x5a_big_tekiF_kusachi.txt
2_units_ari1_nor2_metal.txt
2_units_ari_hit443_metal.txt
2_units_ari_nobo_metal.txt
2_units_blk1_nor4_tsuchi.txt
2_units_cent_mid1_tsuchi.txt
2_units_cent_mid2_tsuchi.txt
2_units_cent_nor1_metal.txt
2_units_cent_north_tsuchi.txt
2_units_gw_l_conc.txt
2_units_hit47_hit67_toy.txt
2_units_ike2_hit1_tsuchi.txt
2_units_ike2_ike3_snow.txt
2_units_ike2_ike4_tsuchi.txt
2_units_kingA_norhiba_tsuchi.txt
2_units_mid1_nor22_metal.txt
2_units_mid2_north_metal.txt
2_units_mid2_north_snow.txt
2_units_mid2_north_tsuchi.txt
2_units_mid_ike_kusachi.txt
2_units_northF_pool_tile.txt
2_units_north_dry_tile.txt
2_units_north_pool_tile.txt
2_units_north_ud_tile.txt
2_units_nor_tekiF_metal.txt
2_units_Oashi_d_conc.txt
2_units_Oashi_s_yuko_conc.txt
2_units_pool_dry_tile.txt
2_units_sara_sara2_toy.txt
2_units_small2_mid2_toy.txt
2_units_tak22_yuko_tile.txt
2_units_tako_north_tile.txt
2_units_ud_dry_tile.txt
3_ABE_5X5a_ike_big_kusachi.txt
3_ABE_5X5a_ike_mid_kusachi.txt
3_ABE_blk_uzu1_mid2_tsuchi.txt
3_ABE_b_f_g_conc.txt
3_ABE_cent_4x4_mid1_metal.txt
3_ABE_dpool_nor_ud_tile.txt
3_ABE_d_pypen_dani_conc.txt
3_ABE_hit3_ike1_blk1.txt
3_ABE_mid1_blk1_nor3_tsuchi.txt
3_ABE_mid2_hit34_hit43_metal.txt
3_ABE_mid2_hit3_hit5_metal.txt
3_ABE_mid2_hit446_hit344.txt
3_ABE_mid2_norhiba_blkhiba_tsuchi.txt
3_ABE_sak1_sak2_hit1_tsuchi.txt
3_MAT_ari_h224_h443_tower_metal.txt
3_MAT_ari_h446_h443_tower_metal.txt
3_MAT_a_h_m_renga.txt
3_MAT_cent_mid1_mid2_tsuchi.txt
3_MAT_cnt2_nor3_uzu1_tsuchi.txt
3_MAT_d_g_m_renga.txt
3_MAT_d_i_m_conc.txt
3_MAT_f_k_o_conc.txt
3_MAT_hit2_blk1_nor3_tsuchi.txt
3_MAT_hit2_blk1_nor4_tsuchi.txt
3_MAT_hit2_hit3_blk1_snow.txt
3_MAT_hit34_sak2_uzu1_snow.txt
3_MAT_hit34_sak2_uzu1_tsuchi.txt
3_MAT_hit47_hit66_hit67_toy.txt
3_MAT_ike2_hit1_hit3_tsuchi.txt
3_MAT_ike3_mid2_sak1_snow.txt
3_MAT_mid1_mid2_uzu1_snow.txt
3_MAT_nor4_hit2_blk1_snow.txt
3_MAT_nor4_ike1_ike2_tsuchi.txt
3_units_ari_hit446_447metal.txt
3_units_a_d_north_tile.txt
3_units_a_l_yuko_tile.txt
3_units_cent_cent2_north_tsuchi.txt
3_units_cent_h235_tower_metal.txt
3_units_cent_mid2_north_tsuchi.txt
3_units_d_f_ujikou_tile.txt
3_units_f_g_l_conc.txt
3_units_f_g_m_conc.txt
3_units_f_k_pypes_conc.txt
3_units_f_l_o_conc.txt
3_units_f_m_bomb_conc.txt
3_units_h335_h344_tekiF_metal.txt
3_units_h_k_pypes_conc.txt
3_units_mid1_hit1_ike2_tsuchi.txt
3_units_mid2_hit6_hit7_metal.txt
3_units_north_ike2_hitode_tsuchi.txt
3_units_north_mid1_mid2_tsuchi.txt
3_units_north_ud_pool_tile.txt
3_units_pool_nor_ujikou_tile.txt
3_units_small2_small_mid_toy.txt
3_units_small_mid_large_toy.txt
4_ABE_a_b_c_dani_conc.txt
4_ABE_a_b_e_m_conc.txt
4_ABE_d_pypeo_pypen_dani_conc.txt
4_ABE_hit6x6_hit4x7_mid8_sml5_toy.txt
4_ABE_ike1_ike2_blk1_cnt_tsuchi.txt
4_ABE_mid1_h443_h447_h335_metal.txt
4_MAT_c_d_k_n_conc.txt
4_MAT_hit4_nor4_ike2_blk1_tsuchi.txt
4_MAT_mid1_mid2_ike1_ike3_tsuchi.txt
4_MAT_mid1_mid2_sak2_uzu1_snow.txt
4_MAT_mid2_nor4_ike1_sak2_tsuchi.txt
4_MAT_nor3_mid1_hit3_sak1_tsuchi.txt
4_MAT_nor3_nor4_ike2_blk1_tsuchi.txt
4_MAT_nor4_hit4_ike2_blk1_tsuchi.txt
4_MAT_sak2_cen1_blk1_nor4_tsuchi.txt
4_NARI_4x4eg_hitm_manp_conc.txt
4_NARI_all_hitode.txt
4_NARI_danh_norjk_pypn_conc.txt
4_units_a_b_c_d_conc.txt
4_units_a_d_e_h_conc.txt
4_units_a_d_f_l_tile.txt
4_units_a_g_l_m_conc.txt
4_units_b_f_g_h_conc.txt
4_units_cent_north_mid1_mid2_tsuchi.txt
4_units_c_e_j_l_conc.txt
4_units_c_j_k_l_conc.txt
4_units_c_l_n_o_conc.txt
4_units_d_j_n_o_conc.txt
4_units_f_g_h_l_conc.txt
4_units_f_g_i_spiral_conc.txt
4_units_mid1_blk1_sak2_uzu1_tsuchi.txt
4_units_mid1_cent_hit3_hit4_metal.txt
4_units_mid1_mid2_hit1_sak1_tsuchi.txt
4_units_mid2_north_hit3_hit5_metal.txt
4_units_nobo_hit224_235_344_metal.txt
4_units_north_ud_pool_dry_tile.txt
4_units_sak1_ike2_blk1_nor4_tsuchi.txt
5_ABE_a_b_c_f_dani_conc.txt
5_ABE_a_d_g_h_j_conc.txt
5_ABE_nor3_hit1_sak1_blk1_mid2_tsuchi.txt
5_NARI_nor1_nor2_nor3_hit1_hit2_tsuchi.txt
5_NARI_sak1_sak2_nor1_uzu_hit1_tsuchi.txt
5_units_hit2_hit3_hit4_nor2_nor3_tsuchi.txt
5_units_mid1_ari1_hit5_hit3_cent_metal.txt
5_units_mid2_cent_hit4_hit5_nor2_metal.txt
5_units_pype_conc.txt
6_ABE_a_d_g_h_j_o_conc.txt
7_ABE_b_c_f_g_i_l_pypn_conc.txt
all_MAT_4x4_conc.txt
all_NARI-ike-north_tsuchi.txt
all_units.txt
all_units_conc.txt
all_units_hitode_toy.txt
all_units_kusachi.txt
all_units_metal.txt
all_units_renga.txt
all_units_snow.txt
all_units_tile.txt
all_units_toy.txt
all_units_tsuchi.txt
all_units_water-ike4.txt
all_units_water_tsuchi.txt
E3_units_metal.txt
E3_units_tsuchi.txt
units.txt
units_tekitest.txt
units_test.txt
units_test_conc.txt
units_test_metal.txt
units_test_snow.txt
units_test_tsuchi.txt
units_test_tsuchi_conc.txt
vs_10_test_tile.txt
vs_1_tsuchi.txt
vs_2_snow.txt
vs_3_toy.txt
vs_4_metal.txt
vs_5_conc.txt
vs_6_nobo_metal.txt
vs_7_kusachi.txt
vs_8_spiral_conc.txt
vs_9_tsuchi.txt".Split(vbCrLf)
        Dim filenames2 = "cap_conc.jpg
cap_kusachi.jpg
cap_metal.jpg
cap_pipe.jpg
cap_snow.jpg
cap_toy.jpg
cap_tsuchi.jpg
item_cap_conc.jpg
item_cap_kusachi.jpg
item_cap_metal.jpg
item_cap_pipe.jpg
item_cap_snow.jpg
item_cap_toy.jpg
item_cap_tsuchi.jpg
item_way3_conc.jpg
item_way3_metal.jpg
item_way3_tsuchi.jpg
item_way4_conc.jpg
item_way4_metal.jpg
item_way4_tsuchi.jpg
item_wayl_conc.jpg
item_wayl_metal.jpg
item_wayl_tsuchi.jpg
room_16x17r_conc.jpg
room_4x4a_4_conc.jpg
room_4x4a_4_renga.jpg
room_4x4a_4_tile.jpg
room_4x4b_4_conc.jpg
room_4x4c_4_conc.jpg
room_4x4d_4_conc.jpg
room_4x4d_4_renga.jpg
room_4x4d_4_tile.jpg
room_4x4e_4_conc.jpg
room_4x4f_4_conc.jpg
room_4x4f_4_tile.jpg
room_4x4g_4_conc.jpg
room_4x4g_4_renga.jpg
room_4x4g_water_4_conc.jpg
room_5x5a_2_kusachi.jpg
room_5x5a_2_tekiF_kusachi.jpg
room_ari1_3_metal.jpg
room_big2_kusachi.jpg
room_big_kusachi.jpg
room_big_tekiF_kusachi.jpg
room_block1_3_hiba_tsuchi.jpg
room_block1_3_snow.jpg
room_block1_3_tsuchi.jpg
room_boss_1_tsuchi.jpg
room_bunki7x7_8_tile.jpg
room_cent2_4_metal.jpg
room_cent2_4_tsuchi.jpg
room_cent3_4_tsuchi.jpg
room_cent_4_mat_tsuchi.jpg
room_cent_4_metal.jpg
room_cent_4_tsuchi.jpg
room_dan4x4h_2_conc.jpg
room_dan4x4h_2_renga.jpg
room_dan4x4i_3_conc.jpg
room_dangomushi_tile.jpg
room_DKumo16x10t_conc.jpg
room_drypool5x5_5_tile.jpg
room_hebi12x12_1_tsuchi.jpg
room_hitode1_5_tsuchi.jpg
room_hitode2x2_4_metal.jpg
room_hitode2x3_5_metal.jpg
room_hitode2_5_snow.jpg
room_hitode2_5_tsuchi.jpg
room_hitode3x3m_5_conc.jpg
room_hitode3x3m_5_renga.jpg
room_hitode3x3_5_metal.jpg
room_hitode3x4_4_metal.jpg
room_hitode3_4_snow.jpg
room_hitode3_4_tsuchi.jpg
room_hitode4x4_3_metal.jpg
room_hitode4x4_6_metal.jpg
room_hitode4x4_7_metal.jpg
room_hitode4x4_tekiF_3_metal.jpg
room_hitode4x4_tower_3_metal.jpg
room_hitode4x7_3_toy.jpg
room_hitode4_4_tsuchi.jpg
room_hitode6x6_3_toy.jpg
room_hitode6x6_yakushima_3_toy.jpg
room_hitode6x7_4_toy.jpg
room_houdai2_1_metal.jpg
room_houdai_1_metal.jpg
room_ike1_2_tsuchi.jpg
room_ike2_4_tsuchi.jpg
room_ike3_2_snow.jpg
room_ike3_2_tsuchi.jpg
room_ike4_5_tsuchi.jpg
room_ike_kusachi.jpg
room_kingchap_a_tsuchi.jpg
room_kingchap_b_tsuchi.jpg
room_kingchp_tsuchi.jpg
room_large_7_toy.jpg
room_manh7x7p_9_conc.jpg
room_manh7x7p_boss_conc.jpg
room_manh7x7q_8_conc.jpg
room_manh_2_conc.jpg
room_manh_boss_conc.jpg
room_mid1_6_boss_tsuchi.jpg
room_mid1_6_metal.jpg
room_mid1_6_snow.jpg
room_mid1_6_tsuchi.jpg
room_mid2_3_metal.jpg
room_mid2_3_snow.jpg
room_mid2_3_tsuchi.jpg
room_mid2_8_toy.jpg
room_mid_8_toy.jpg
room_mid_kusachi.jpg
room_mid_sara2_8_toy.jpg
room_mid_sara_8_toy.jpg
room_mid_tower2_8_toy.jpg
room_mid_tower_8_toy.jpg
room_nobo1_4_metal.jpg
room_nobo2_4_metal.jpg
room_north2x2_1_metal.jpg
room_north2x2_1_tekiF_tile.jpg
room_north2x2_1_tile.jpg
room_north2_1_tsuchi.jpg
room_north3_1_tsuchi.jpg
room_north4x4j_1_conc.jpg
room_north4x4k_1_bomb_conc.jpg
room_north4x4k_1_conc.jpg
room_north4x4l_1_conc.jpg
room_north4x4l_1_tile.jpg
room_north4_1_snow.jpg
room_north4_1_tsuchi.jpg
room_north_1_hiba_tsuchi.jpg
room_north_1_mat_tsuchi.jpg
room_north_1_metal.jpg
room_north_1_snow.jpg
room_north_1_tsuchi.jpg
room_north_tutorial_1_snow.jpg
room_Oashi8x9_conc.jpg
room_Oashi8x9_s_conc.jpg
room_oootakara_tile.jpg
room_opan_toy.jpg
room_pool5x5_5_tile.jpg
room_purple14x14_snow.jpg
room_pype10x18s_conc.jpg
room_pype3x4n_2_conc.jpg
room_pype4x4o_3_conc.jpg
room_queen_b_tsuchi.jpg
room_queen_c_tsuchi.jpg
room_saka1_1_snow.jpg
room_saka1_1_tsuchi.jpg
room_saka2_2_snow.jpg
room_saka2_2_tsuchi.jpg
room_small2_5_toy.jpg
room_small_5_toy.jpg
room_spiral_1_conc.jpg
room_tako2x2_8_tekiF_tile.jpg
room_tako2x2_8_tile.jpg
room_torigoya_kusachi.jpg
room_ud4x4_2_tile.jpg
room_uzu1_1_snow.jpg
room_uzu1_1_tsuchi.jpg
room_u_jikou1_4x4_2_tile.jpg
room_vs_5x5a_2_kusachi.jpg
room_vs_big2_kusachi.jpg
room_vs_big_kusachi.jpg
room_vs_bunki7x7_8_tile.jpg
room_vs_drypool5x5_5_tile.jpg
room_vs_hitode2x3_5_metal.jpg
room_vs_hitode3x3m_5_conc.jpg
room_vs_hitode4x4_6_metal.jpg
room_vs_hitode6x7_4_toy.jpg
room_vs_ike3_2_snow.jpg
room_vs_mid1_6_tsuchi.jpg
room_vs_mid_kusachi.jpg
room_vs_mid_sara2_8_toy.jpg
room_vs_nobo2_4_metal.jpg
room_vs_north2x2_1_tile.jpg
room_vs_north_1_metal.jpg
room_vs_saka2_2_snow.jpg
room_vs_spiral_1_conc.jpg
room_vs_yukoana1_5x3_2_tile.jpg
room_white14x12_metal.jpg
room_yukoana1_5x3_2_tile.jpg
way2x2_conc.jpg
way2x2_kusachi.jpg
way2x2_metal.jpg
way2x2_pipe.jpg
way2x2_snow.jpg
way2x2_toy.jpg
way2x2_tsuchi.jpg
way2_conc.jpg
way2_kusachi.jpg
way2_metal.jpg
way2_pipe.jpg
way2_snow.jpg
way2_toy.jpg
way2_tsuchi.jpg
way3_conc.jpg
way3_kusachi.jpg
way3_metal.jpg
way3_pipe.jpg
way3_snow.jpg
way3_toy.jpg
way3_tsuchi.jpg
way4_conc.jpg
way4_kusachi.jpg
way4_metal.jpg
way4_pipe.jpg
way4_snow.jpg
way4_toy.jpg
way4_tsuchi.jpg
way6_tsuchi.jpg
wayl_conc.jpg
wayl_kusachi.jpg
wayl_metal.jpg
wayl_pipe.jpg
wayl_snow.jpg
wayl_toy.jpg
wayl_tsuchi.jpg".Split(vbCrLf)
        Dim abort = False
        For Each filename In filenames
            If Not IO.File.Exists(AppDomain.CurrentDomain.BaseDirectory & "CaveCreatorUnits\all\" & filename.Replace(vbCr, "").Replace(vbLf, "").Replace(vbNewLine, "").Replace(Environment.NewLine, "")) Then
                abort = True
                Exit For
            End If
        Next
        For Each filename In filenames2
            If Not IO.File.Exists(AppDomain.CurrentDomain.BaseDirectory & "CaveCreatorUnits\thumbnails\" & filename.Replace(vbCr, "").Replace(vbLf, "").Replace(vbNewLine, "").Replace(Environment.NewLine, "")) Then
                abort = True
                Exit For
            End If
        Next
        If abort = True Then
        Else
            Dim lst As New List(Of String)
            For Each line In IO.File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory & "CaveCreatorUnits\all\" & cmb_UnitFile.SelectedItem)
                If line.StartsWith("# ") Then
                    lst.Add(line.Replace("# ", ""))
                End If
            Next
            For Each unit As String In lst
                Dim newPic As New PictureBox
                newPic.Image = GetImageFile(AppDomain.CurrentDomain.BaseDirectory & "CaveCreatorUnits\thumbnails\" & unit & ".jpg")
                newPic.Size = ResizeImg(newPic.Image, 70)
                newPic.SizeMode = PictureBoxSizeMode.StretchImage

            Next
        End If
    End Sub

    Private Sub num_WaterwraithTimer_ValueChanged(sender As Object, e As EventArgs) Handles num_WaterwraithTimer.ValueChanged
        ChangesWereMade()
    End Sub

    Private Sub chk_CustomTreasureTotal_CheckedChanged(sender As Object, e As EventArgs) Handles chk_CustomTreasureTotal.CheckedChanged
        ChangesWereMade()
        If chk_CustomEntityTotal.Checked = True Then
            num_CustomEntityTotal.Enabled = True
        Else
            num_CustomEntityTotal.Enabled = False
        End If
    End Sub
End Class