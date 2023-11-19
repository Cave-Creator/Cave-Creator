
' THIS IS SOOOOOOOOOOOOOOOOOO BAD

Imports System.ComponentModel
Imports System.Globalization

Public Class Form1

    Public LoadInvisible As Boolean = False


    '''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''''' SAVING & LOADING ''''''''''
    '''''''''''''''''''''''''''''''''''''''''''''''''''''
    Dim CaveNeedsToSaveAs As Boolean = True
    Dim LoadedOrSavedAsFileName As String

    '''''''''''''''''''''''''''''''''''''''''''''''''''''
    '' SUBLEVEL COUNT VALUES ''
    '''''''''''''''''''''''''''''''''''''''''''''''''''''
    Dim SublevelTotal As Integer
    Dim SublevelTotalID As Integer
    Dim SublevelSelected As Boolean = False
    Dim SublevelName As String

    '''''''''''''''''''''''''''''''''''''''''''''''''''''
    '' SUBLEVEL ENTITY STUFFF '''
    '''''''''''''''''''''''''''''''''''''''''''''''''''''
    Public EntityCodeName As String = "Chappy"
    Public EntityNormalName As String = "Red Bulborb"

    Dim EntitySpawnDeadEnd As Boolean
    Dim EntityWeight As Integer = 0
    Dim EntityLocation As Integer = 0
    Dim EntityMethod As String = ""

    Public EntityTotalCount As Integer = 0
    Public EntityNormNameList As String
    Dim AllEntitiesDeleted As Boolean = False
    Dim EnteringSubPropsFromEntities As Boolean = False
    Dim EntityContainsDropTreasure As String

    Dim EntityIsDecoration As Boolean
    Dim DecorationChecker As String

    Dim EntityRegCodeListIndex As Integer
    Dim EntityRegCodeListIndexBoolean As Boolean = False

    Dim EntityDropTreasureInternalName As String
    Dim EntityDropTreasureEngName As String


    '''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''     ROOT/IMPORT STUFF     '''
    '''''''''''''''''''''''''''''''''''''''''''''''''''''
    Public RootDirectory As String



    '''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''     OTHER                           '''
    '''''''''''''''''''''''''''''''''''''''''''''''''''''
    Public ClickedAddSublevelWithNameInput As Boolean = False
    Public FullCave As String
    Dim ChallengeModePikminCount As Integer = 0
    Dim CMPcode As String
    Dim CMPtimeCode As String
    Dim CMPfullCode As String = ""
    Dim pressedMainMenu As Boolean = False
    Public MyFile() As String

    Public TreasureExternalName As String
    Public TreasureInternalName As String

    Dim exportwindowshow As Boolean
    Dim CaveFile As String = ""

    Dim MovingEntity As Boolean = False

    Dim AnimationGoing As Boolean = False
    Public MustBeSavedAs As Boolean = True

    Public DoubleClickMode As Integer = 0


    Public Sub DeselectLists()
        lst_Sublevels.SelectedIndex = -1
        lst_Sublevel_IDs.SelectedIndex = -1
        lst_SublevelNames.SelectedIndex = -1
        lst_RegularEntities.SelectedIndex = -1
        lst_RegularEntitiesCounts.SelectedIndex = -1
        lst_RegularEntitiesList.SelectedIndex = -1
        lst_RegularEntitiesCountList.SelectedIndex = -1
        cmb_Sublevels.SelectedIndex = -1
    End Sub
    Private Sub lst_Sublevels_DoubleClick(sender As Object, e As EventArgs) Handles lst_Sublevels.DoubleClick
        If lst_Sublevels.SelectedIndex > -1 Then
            If DoubleClickMode = 0 Then
                SublevelProperties.SetDesktopLocation(Me.Location.X + ((Me.Width / 2) - SublevelProperties.Width / 2), Me.Location.Y + ((Me.Height / 2) - SublevelProperties.Height / 2))
                SublevelProperties.ShowDialog()
            ElseIf DoubleClickMode = 1 Then
                btn_Entities.PerformClick()
            ElseIf DoubleClickMode = 2 Then
                btn_Treasures.PerformClick()
            ElseIf DoubleClickMode = 3 Then
                btn_Gates.PerformClick()
            End If
        End If
    End Sub
    Public Function MouseIsOverControl(ByVal c As Control) As Boolean
        Return c.ClientRectangle.Contains(c.PointToClient(Control.MousePosition))
    End Function
    Private Sub lst_Sublevels_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lst_Sublevels.MouseDown
        If Not MouseIsOverControl(btn_MoveSublevelUp) Then
            If Not MouseIsOverControl(btn_MoveSublevelDown) Then
                lst_Sublevels.SelectedIndex = lst_Sublevels.IndexFromPoint(e.X, e.Y)
            End If
        End If
    End Sub
    Private Sub lst_RegularEntitiesNormList_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lst_RegularEntitiesNormList.MouseDown
        lst_RegularEntitiesNormList.SelectedIndex = lst_RegularEntitiesNormList.IndexFromPoint(e.X, e.Y)
    End Sub
    Private Sub lst_TreasuresNorm_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        SublevelTreasures.lst_TreasuresNorm.SelectedIndex = SublevelTreasures.lst_TreasuresNorm.IndexFromPoint(e.X, e.Y)
    End Sub
    Private Sub lst_GatesNorm_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        SublevelGates.lst_GatesNorm.SelectedIndex = SublevelGates.lst_GatesNorm.IndexFromPoint(e.X, e.Y)
    End Sub

    Private Sub lst_Sublevels_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_Sublevels.SelectedIndexChanged
        If lst_Sublevels.Items.Count > 1 Then
            If lst_Sublevels.SelectedIndex = 0 Then btn_MoveSublevelUp.Enabled = False Else btn_MoveSublevelUp.Enabled = True
            If lst_Sublevels.SelectedIndex = lst_Sublevels.Items.Count - 1 Then btn_MoveSublevelDown.Enabled = False Else btn_MoveSublevelDown.Enabled = True
        Else
            btn_MoveSublevelDown.Enabled = False
            btn_MoveSublevelUp.Enabled = False
        End If
        If lst_Sublevels.SelectedIndex = -1 Then
            btn_DuplicateSub.BackgroundImage = My.Resources.Duplicate_20px_dark
            btn_MoveSublevelDown.Enabled = False
            btn_MoveSublevelUp.Enabled = False
        Else
            btn_DuplicateSub.BackgroundImage = My.Resources.Duplicate_20px
        End If


        Dim ContainsWeightCheck As Boolean = False

        If lst_Sublevels.SelectedIndex > -1 Then
            btn_DuplicateSub.Enabled = True

            SublevelTreasures.lbl_SublevelName.Text = lst_Sublevels.SelectedItem
            SublevelGates.lbl_SublevelName.Text = lst_Sublevels.SelectedItem

            SublevelGates.btn_AddGate.Enabled = True
            SublevelGates.btn_DeleteAllGates.Enabled = True
            SublevelGates.btn_DeleteSelectedGate.Enabled = True
            SublevelTreasures.btn_AddTreasure.Enabled = True
            SublevelTreasures.btn_DeleteAllTreasures.Enabled = True
            SublevelTreasures.btn_DeleteSelectedTreasure.Enabled = True


            DeleteToolStripMenuItem.Text = "Delete " & lst_Sublevels.SelectedItem

            lst_Sublevel_IDs.SelectedIndex = lst_Sublevels.SelectedIndex    'Selects the corresponding index in the identifier list
            lst_SublevelNames.SelectedIndex = lst_Sublevels.SelectedIndex   'Selects the corresponding index in the name list
            lst_RegularEntities.SelectedIndex = lst_Sublevels.SelectedIndex   'Selects the corresponding index in the regular entities list
            lst_RegularEntitiesCounts.SelectedIndex = lst_Sublevels.SelectedIndex   'Selects the corresponding index in the regular entities counts list

            lst_f5_RoomCount.SelectedIndex = lst_Sublevels.SelectedIndex
            lst_f6_Ratio.SelectedIndex = lst_Sublevels.SelectedIndex
            lst_f7_Geyser.SelectedIndex = lst_Sublevels.SelectedIndex
            lst_f8_UnitFile.SelectedIndex = lst_Sublevels.SelectedIndex
            lst_f9_LightFile.SelectedIndex = lst_Sublevels.SelectedIndex
            lst_fa_Skybox.SelectedIndex = lst_Sublevels.SelectedIndex
            lst_f10_CloggedHole.SelectedIndex = lst_Sublevels.SelectedIndex
            lst_f12_MusicType.SelectedIndex = lst_Sublevels.SelectedIndex
            lst_f13_SolidPlane.SelectedIndex = lst_Sublevels.SelectedIndex
            lst_f14_DeadEndCount.SelectedIndex = lst_Sublevels.SelectedIndex
            lst_f16_WaterwraithTimer.SelectedIndex = lst_Sublevels.SelectedIndex
            lst_f17_Seesaw.SelectedIndex = lst_Sublevels.SelectedIndex
            lst_totaka_MusicList.SelectedIndex = lst_Sublevels.SelectedIndex
            lst_CustomEntityTotal_Check.SelectedIndex = lst_Sublevels.SelectedIndex
            lst_f2_CustomEntityTotal.SelectedIndex = lst_Sublevels.SelectedIndex
            lst_TreasureSets.SelectedIndex = lst_Sublevels.SelectedIndex
            lst_GateSets.SelectedIndex = lst_Sublevels.SelectedIndex


            If (lst_Times.Items.Count - 1) < lst_Sublevels.SelectedIndex Then
                num_CMPsubCount.Value = SublevelTotal
                If lst_Times.Items.Count < lst_Sublevels.Items.Count Then
                    For i = lst_Times.Items.Count To lst_Sublevels.Items.Count - 1
                        lst_Times.Items.Add("Sublevel " & (i + 1).ToString & ": 0 seconds")
                    Next
                End If
            End If

            lst_Times.SelectedIndex = lst_Sublevels.SelectedIndex

            'The following is for the Rename/Add Name buttons
            btn_RenameSublevel.Enabled = True
            btn_RenameSublevel.Visible = True
            If lst_SublevelNames.SelectedItem > " " Then
                btn_RemoveSublevelName.Visible = True
                btn_RenameSublevel.Text = "Rename"

            Else
                btn_RemoveSublevelName.Visible = False
                btn_RenameSublevel.Text = "Add Name"
            End If

            lbl_SublevelID.Text = "ID: " & lst_Sublevel_IDs.SelectedItem    'Visually demonstrates the new selected sublevel identifier
            btn_SublevelProperties.Enabled = True
            btn_Entities.Enabled = True
            btn_Gates.Enabled = True
            btn_Treasures.Enabled = True
            btn_RemoveSublevel2.Enabled = True
            btn_RemoveSublevel2.BackgroundImage = My.Resources.Subtract_20px

            'Following is for treasures

            SublevelTreasures.lst_TreasuresNorm.Items.Clear()
            lst_Treasures.Items.Clear()
            Dim TreasureSet As String = lst_TreasureSets.SelectedItem.ToString.Substring(lst_TreasureSets.SelectedItem.ToString.IndexOf("-") + 2, lst_TreasureSets.SelectedItem.ToString.Length - (lst_TreasureSets.SelectedItem.ToString.IndexOf("-") + 2))
            If (TreasureSet.Length > 0) Then
                Dim separators() As Char = {";"c}
                For Each item As String In TreasureSet.Split(
            separators, StringSplitOptions.RemoveEmptyEntries)
                    lst_Treasures.Items.Add(item)
                Next item
            End If

            Dim x As Integer = 0
            While x < lst_Treasures.Items.Count
                lst_Treasures.SelectedIndex = x
                TreasureInternalName = lst_Treasures.SelectedItem.ToString.Substring(0, lst_Treasures.SelectedItem.ToString.Length - 3)
                TreasureConvertInternaltoExternal()
                SublevelTreasures.lst_TreasuresNorm.Items.Add(TreasureExternalName & " x " & lst_Treasures.SelectedItem.ToString.Substring(lst_Treasures.SelectedItem.ToString.Length - 2, 1) & " [weight=" & lst_Treasures.SelectedItem.ToString.Substring(lst_Treasures.SelectedItem.ToString.Length - 1, 1) & "]")
                x += 1
            End While
            lst_Treasures.SelectedIndex = -1

            'following for gates
            SublevelGates.lst_GatesNorm.Items.Clear()
            lst_Gates.Items.Clear()
            Dim GateSet As String = lst_GateSets.SelectedItem.ToString.Substring(lst_GateSets.SelectedItem.ToString.IndexOf("-") + 2, lst_GateSets.SelectedItem.ToString.Length - (lst_GateSets.SelectedItem.ToString.IndexOf("-") + 2))
            If (GateSet.Length > 0) Then
                Dim separators() As Char = {";"c}
                For Each item As String In GateSet.Split(
            separators, StringSplitOptions.RemoveEmptyEntries)
                    lst_Gates.Items.Add(item)
                Next item
            End If


            x = 0
            While x < lst_Gates.Items.Count
                lst_Gates.SelectedIndex = x
                Dim GateHP As String = lst_Gates.SelectedItem
                Dim NumberCheck As Boolean = False
                If GateHP > "" Then
                    If IsNumeric(GateHP.First) Then NumberCheck = True
                    While NumberCheck = False
                        GateHP = GateHP.Substring(1, GateHP.Length - 1)
                        If IsNumeric(GateHP.First) Then NumberCheck = True
                    End While
                    GateHP = GateHP.Substring(0, GateHP.IndexOf("
")).Replace(" ", "").Replace("	", "")
                End If
                SublevelGates.lst_GatesNorm.Items.Add("Gate with " & GateHP & "HP")
                x += 1
            End While
            lst_Treasures.SelectedIndex = -1


            Dim SublevelEntityCounter As Integer = 0
            Dim TotalSublevelEntityCounter As Integer = 0
            Dim RegularEntitiesID2 As String
            Dim i3 As Integer = 0
            While i3 < 999
                i3 += 1
                Dim item2 As Integer = lst_Sublevel_IDs.SelectedItem.ToString.Replace("S", "")
                If item2 = i3 Then
                    RegularEntitiesID2 = "S" & i3
                    i3 = 999
                End If
            End While

            Dim RegularEntitiesWithoutID As String = lst_RegularEntities.SelectedItem.ToString.Replace(RegularEntitiesID2 & " - ", "")
            If RegularEntitiesWithoutID > "" Then

                'The following creates separated strings by finding semi-colons in a single string.
                Dim separators() As Char = {";"c}
                For Each item As String In lst_RegularEntities.SelectedItem.ToString.Split(
                       separators, StringSplitOptions.RemoveEmptyEntries)

                    'The following finds the sublevel identifier string in the selected regular entities listbox item
                    Dim RegularEntitiesID As String
                    Dim i As Integer = 0
                    While i < 999
                        i += 1
                        If lst_RegularEntities.SelectedItem.ToString.StartsWith("S" & i) Then
                            RegularEntitiesID = "S" & i
                            i = 999
                        End If
                    End While

                    'The following removes the sublevel identifier string and then adds the remainder to the regular entities list listbox
                    item = item.Replace(RegularEntitiesID & " - ", "").Replace(RegularEntitiesID & "
 - ", "").Replace(" - ", "")
                    If item > "" Then
                        SublevelEntityCounter += 1
                    End If
                Next item


                'Counts list:
                'The following creates separated strings by finding semi-colons in a single string.
                Dim separators2() As Char = {";"c}
                For Each item2 As String In lst_RegularEntitiesCounts.SelectedItem.ToString.Split(
                       separators2, StringSplitOptions.RemoveEmptyEntries)

                    'The following finds the sublevel identifier string in the selected regular entities listbox item
                    Dim RegularEntitiesID As String
                    Dim i As Integer = 0
                    While i < 999
                        i += 1
                        If lst_RegularEntitiesCounts.SelectedItem.ToString.StartsWith("S" & i) Then
                            RegularEntitiesID = "S" & i
                            i = 999
                        End If
                    End While

                    'The following removes the sublevel identifier string and then adds the remainder to the regular entities list listbox

                    item2 = item2.Replace(RegularEntitiesID2 & " - ", "").Replace(RegularEntitiesID2 & "
 - ", "").Replace(" - ", "")
                    If item2.Contains(" ") Then
                        item2 = item2.Substring(item2.IndexOf(" ") + 1, item2.Length - (item2.IndexOf(" ") + 1)).Replace(" ", "").Replace(" ", "")
                    End If
                    If item2 > "" Then
                        If item2.Contains("weight") Then
                            ContainsWeightCheck = True
                            If item2.Contains(",") Then
                                item2 = item2.Substring(0, item2.IndexOf(","))
                                TotalSublevelEntityCounter += item2
                            End If
                        Else
                            TotalSublevelEntityCounter += item2
                        End If
                    End If
                Next item2
            End If

            If lst_Sublevels.SelectedIndex > -1 Then
                lbl_EntityCount.Text = "Entity Sets: " & SublevelEntityCounter
                If ContainsWeightCheck = True Then
                    lbl_TotalEntityCount.Text = "Total Entities: " & TotalSublevelEntityCounter & " + weighted entities"
                Else
                    lbl_TotalEntityCount.Text = "Total Entities: " & TotalSublevelEntityCounter

                End If
            End If

        Else    'If all items are deselected

            btn_DuplicateSub.Enabled = False

            SublevelGates.lbl_SublevelName.Text = "Nothing Selected"
            SublevelTreasures.lbl_SublevelName.Text = "Nothing Selected"

            SublevelGates.btn_AddGate.Enabled = False
            SublevelGates.btn_DeleteAllGates.Enabled = False
            SublevelGates.btn_DeleteSelectedGate.Enabled = False
            SublevelTreasures.btn_AddTreasure.Enabled = False
            SublevelTreasures.btn_DeleteAllTreasures.Enabled = False
            SublevelTreasures.btn_DeleteSelectedTreasure.Enabled = False


            btn_RenameSublevel.Text = "Select a Sublevel"
            btn_RenameSublevel.Visible = False
            btn_RenameSublevel.Enabled = False
            btn_RemoveSublevelName.Visible = False
            lbl_SublevelID.Text = "Nothing Selected"
            btn_SublevelProperties.Enabled = False
            btn_Entities.Enabled = False
            btn_Gates.Enabled = False
            btn_Treasures.Enabled = False
            btn_RemoveSublevel2.Enabled = False

            SublevelTreasures.lst_TreasuresNorm.Items.Clear()
            lst_Treasures.Items.Clear()
            lst_TreasureSets.SelectedIndex = lst_Sublevels.SelectedIndex
            SublevelGates.lst_GatesNorm.Items.Clear()
            lst_Gates.Items.Clear()
            lst_GateSets.SelectedIndex = lst_Sublevels.SelectedIndex


            lbl_EntityCount.Text = ""
            lbl_TotalEntityCount.Text = ""

            DeleteToolStripMenuItem.Text = "Delete"
        End If



        '''''''' The following just calculates the total entity sets and total entities for selected sublevel section





        lbl_SublevelID.Location = New Point((lbl_SelectedSublevelTitle.Location.X + (lbl_SelectedSublevelTitle.Width / 2)) - (lbl_SublevelID.Width / 2), lbl_SublevelID.Location.Y)
        lbl_TotalEntityCount.Location = New Point((lbl_SelectedSublevelTitle.Location.X + (lbl_SelectedSublevelTitle.Width / 2)) - (lbl_TotalEntityCount.Width / 2), lbl_TotalEntityCount.Location.Y)
        lbl_EntityCount.Location = New Point((lbl_SelectedSublevelTitle.Location.X + (lbl_SelectedSublevelTitle.Width / 2)) - (lbl_EntityCount.Width / 2), lbl_EntityCount.Location.Y)
    End Sub
    Private Sub btn_MoveSublevelDown_Click(sender As Object, e As EventArgs) Handles btn_MoveSublevelDown.Click
        If lst_Sublevels.SelectedIndex = -1 Then
            MsgBox("Please select the sublevel you'd like to move down.")   'In case there is no sublevel selected
        Else    'If there is a sublevel selected
            If lst_Sublevels.Items.Count = 1 Then   'If there is only one item then don't do anything
            Else
                If lst_Sublevels.SelectedIndex = lst_Sublevels.Items.Count - 1 Then 'If the selected item is on the bottom then don't do anything
                Else
                    Dim I = lst_Sublevels.SelectedIndex + 2
                    Dim I2 = lst_Sublevel_IDs.SelectedIndex + 2
                    Dim I3 = lst_SublevelNames.SelectedIndex + 2
                    Dim I4 = lst_RegularEntities.SelectedIndex + 2
                    Dim I5 = lst_RegularEntitiesCounts.SelectedIndex + 2

                    If lst_GateSets.SelectedIndex < lst_GateSets.Items.Count - 1 Then
                        lst_GateSets.Items.Insert(I5, lst_GateSets.SelectedItem)
                        lst_GateSets.Items.RemoveAt(lst_GateSets.SelectedIndex)
                    End If
                    If lst_TreasureSets.SelectedIndex < lst_TreasureSets.Items.Count - 1 Then
                        lst_TreasureSets.Items.Insert(I5, lst_TreasureSets.SelectedItem)
                        lst_TreasureSets.Items.RemoveAt(lst_TreasureSets.SelectedIndex)
                    End If
                    If lst_Sublevels.SelectedIndex < lst_Sublevels.Items.Count - 1 Then
                        lst_Sublevels.Items.Insert(I, lst_Sublevels.SelectedItem)
                        lst_Sublevels.Items.RemoveAt(lst_Sublevels.SelectedIndex)
                    End If
                    If lst_Sublevel_IDs.SelectedIndex < lst_Sublevel_IDs.Items.Count - 1 Then
                        lst_Sublevel_IDs.Items.Insert(I2, lst_Sublevel_IDs.SelectedItem)
                        lst_Sublevel_IDs.Items.RemoveAt(lst_Sublevel_IDs.SelectedIndex)
                    End If
                    If lst_SublevelNames.SelectedIndex < lst_SublevelNames.Items.Count - 1 Then
                        lst_SublevelNames.Items.Insert(I3, lst_SublevelNames.SelectedItem)
                        lst_SublevelNames.Items.RemoveAt(lst_SublevelNames.SelectedIndex)
                    End If
                    If lst_RegularEntities.SelectedIndex < lst_RegularEntities.Items.Count - 1 Then
                        lst_RegularEntities.Items.Insert(I4, lst_RegularEntities.SelectedItem)
                        lst_RegularEntities.Items.RemoveAt(lst_RegularEntities.SelectedIndex)
                    End If
                    If lst_RegularEntitiesCounts.SelectedIndex < lst_RegularEntitiesCounts.Items.Count - 1 Then
                        lst_RegularEntitiesCounts.Items.Insert(I5, lst_RegularEntitiesCounts.SelectedItem)
                        lst_RegularEntitiesCounts.Items.RemoveAt(lst_RegularEntitiesCounts.SelectedIndex)
                    End If
                    If lst_f2_CustomEntityTotal.SelectedIndex < lst_f2_CustomEntityTotal.Items.Count - 1 Then
                        lst_f2_CustomEntityTotal.Items.Insert(I5, lst_f2_CustomEntityTotal.SelectedItem)
                        lst_f2_CustomEntityTotal.Items.RemoveAt(lst_f2_CustomEntityTotal.SelectedIndex)
                    End If
                    If lst_f5_RoomCount.SelectedIndex < lst_f5_RoomCount.Items.Count - 1 Then
                        lst_f5_RoomCount.Items.Insert(I5, lst_f5_RoomCount.SelectedItem)
                        lst_f5_RoomCount.Items.RemoveAt(lst_f5_RoomCount.SelectedIndex)
                    End If
                    If lst_f6_Ratio.SelectedIndex < lst_f6_Ratio.Items.Count - 1 Then
                        lst_f6_Ratio.Items.Insert(I5, lst_f6_Ratio.SelectedItem)
                        lst_f6_Ratio.Items.RemoveAt(lst_f6_Ratio.SelectedIndex)
                    End If
                    If lst_f7_Geyser.SelectedIndex < lst_f7_Geyser.Items.Count - 1 Then
                        lst_f7_Geyser.Items.Insert(I5, lst_f7_Geyser.SelectedItem)
                        lst_f7_Geyser.Items.RemoveAt(lst_f7_Geyser.SelectedIndex)
                    End If
                    If lst_f8_UnitFile.SelectedIndex < lst_f8_UnitFile.Items.Count - 1 Then
                        lst_f8_UnitFile.Items.Insert(I5, lst_f8_UnitFile.SelectedItem)
                        lst_f8_UnitFile.Items.RemoveAt(lst_f8_UnitFile.SelectedIndex)
                    End If
                    If lst_f9_LightFile.SelectedIndex < lst_f9_LightFile.Items.Count - 1 Then
                        lst_f9_LightFile.Items.Insert(I5, lst_f9_LightFile.SelectedItem)
                        lst_f9_LightFile.Items.RemoveAt(lst_f9_LightFile.SelectedIndex)
                    End If
                    If lst_f10_CloggedHole.SelectedIndex < lst_f10_CloggedHole.Items.Count - 1 Then
                        lst_f10_CloggedHole.Items.Insert(I5, lst_f10_CloggedHole.SelectedItem)
                        lst_f10_CloggedHole.Items.RemoveAt(lst_f10_CloggedHole.SelectedIndex)
                    End If
                    If lst_f12_MusicType.SelectedIndex < lst_f12_MusicType.Items.Count - 1 Then
                        lst_f12_MusicType.Items.Insert(I5, lst_f12_MusicType.SelectedItem)
                        lst_f12_MusicType.Items.RemoveAt(lst_f12_MusicType.SelectedIndex)
                    End If
                    If lst_f13_SolidPlane.SelectedIndex < lst_f13_SolidPlane.Items.Count - 1 Then
                        lst_f13_SolidPlane.Items.Insert(I5, lst_f13_SolidPlane.SelectedItem)
                        lst_f13_SolidPlane.Items.RemoveAt(lst_f13_SolidPlane.SelectedIndex)
                    End If
                    If lst_f14_DeadEndCount.SelectedIndex < lst_f14_DeadEndCount.Items.Count - 1 Then
                        lst_f14_DeadEndCount.Items.Insert(I5, lst_f14_DeadEndCount.SelectedItem)
                        lst_f14_DeadEndCount.Items.RemoveAt(lst_f14_DeadEndCount.SelectedIndex)
                    End If
                    If lst_f16_WaterwraithTimer.SelectedIndex < lst_f16_WaterwraithTimer.Items.Count - 1 Then
                        lst_f16_WaterwraithTimer.Items.Insert(I5, lst_f16_WaterwraithTimer.SelectedItem)
                        lst_f16_WaterwraithTimer.Items.RemoveAt(lst_f16_WaterwraithTimer.SelectedIndex)
                    End If
                    If lst_f17_Seesaw.SelectedIndex < lst_f17_Seesaw.Items.Count - 1 Then
                        lst_f17_Seesaw.Items.Insert(I5, lst_f17_Seesaw.SelectedItem)
                        lst_f17_Seesaw.Items.RemoveAt(lst_f17_Seesaw.SelectedIndex)
                    End If
                    If lst_fa_Skybox.SelectedIndex < lst_fa_Skybox.Items.Count - 1 Then
                        lst_fa_Skybox.Items.Insert(I5, lst_fa_Skybox.SelectedItem)
                        lst_fa_Skybox.Items.RemoveAt(lst_fa_Skybox.SelectedIndex)
                    End If
                    If lst_totaka_MusicList.SelectedIndex < lst_totaka_MusicList.Items.Count - 1 Then
                        lst_totaka_MusicList.Items.Insert(I5, lst_totaka_MusicList.SelectedItem)
                        lst_totaka_MusicList.Items.RemoveAt(lst_totaka_MusicList.SelectedIndex)
                    End If
                    If lst_CustomEntityTotal_Check.SelectedIndex < lst_CustomEntityTotal_Check.Items.Count - 1 Then
                        lst_CustomEntityTotal_Check.Items.Insert(I5, lst_CustomEntityTotal_Check.SelectedItem)
                        lst_CustomEntityTotal_Check.Items.RemoveAt(lst_CustomEntityTotal_Check.SelectedIndex)
                    End If



                    'The following calculates the new sublevel count, along with fixing up the listboxes and labels
                    Dim NewSublevelTotal As Integer = 0
                    lst_Sublevels.Items.Clear()
                    While lst_Sublevels.Items.Count < SublevelTotal
                        NewSublevelTotal += 1
                        lst_SublevelNames.SelectedIndex += 1
                        lst_Sublevels.Items.Add("Sublevel " & NewSublevelTotal & lst_SublevelNames.SelectedItem)
                        If SublevelTotal = 1 Then
                            lbl_SublevelTotal.Text = NewSublevelTotal & " Sublevel"
                        Else
                            lbl_SublevelTotal.Text = NewSublevelTotal & " Sublevels"
                        End If
                    End While

                    'The following selects the item that's moved down
                    lst_Sublevels.SelectedIndex = I - 1
                    lst_Sublevel_IDs.SelectedIndex = I2 - 1
                    lst_SublevelNames.SelectedIndex = I3 - 1
                    lst_RegularEntities.SelectedIndex = I4 - 1
                    lst_RegularEntitiesCounts.SelectedIndex = I5 - 1
                    lst_f2_CustomEntityTotal.SelectedIndex = I5 - 1
                    lst_f5_RoomCount.SelectedIndex = I5 - 1
                    lst_f6_Ratio.SelectedIndex = I5 - 1
                    lst_f7_Geyser.SelectedIndex = I5 - 1
                    lst_f8_UnitFile.SelectedIndex = I5 - 1
                    lst_f9_LightFile.SelectedIndex = I5 - 1
                    lst_f10_CloggedHole.SelectedIndex = I5 - 1
                    lst_f12_MusicType.SelectedIndex = I5 - 1
                    lst_f13_SolidPlane.SelectedIndex = I5 - 1
                    lst_f14_DeadEndCount.SelectedIndex = I5 - 1
                    lst_f16_WaterwraithTimer.SelectedIndex = I5 - 1
                    lst_f17_Seesaw.SelectedIndex = I5 - 1
                    lst_fa_Skybox.SelectedIndex = I5 - 1
                    lst_totaka_MusicList.SelectedIndex = I5 - 1
                    lst_CustomEntityTotal_Check.SelectedIndex = I5 - 1
                    lst_TreasureSets.SelectedIndex = I5 - 1
                    lst_GateSets.SelectedIndex = I5 - 1
                End If
            End If
        End If
    End Sub
    Private Sub btn_MoveSublevelUp_Click(sender As Object, e As EventArgs) Handles btn_MoveSublevelUp.Click
        If lst_Sublevels.SelectedIndex = -1 Then
            MsgBox("Please select the sublevel you'd like to move up.") 'In case there is no sublevel selected
        Else    'If there is a sublevel selected
            If lst_Sublevels.Items.Count = 1 Then   'If there is only one item then don't do anything
            Else
                If lst_Sublevels.SelectedIndex = 0 Then     'If the selected item is on the top then don't do anything
                Else
                    Dim I = lst_Sublevels.SelectedIndex - 1
                    Dim I2 = lst_Sublevel_IDs.SelectedIndex - 1
                    Dim I3 = lst_SublevelNames.SelectedIndex - 1
                    Dim I4 = lst_RegularEntities.SelectedIndex - 1
                    Dim I5 = lst_RegularEntitiesCounts.SelectedIndex - 1

                    If lst_GateSets.SelectedIndex > 0 Then
                        lst_GateSets.Items.Insert(I5, lst_GateSets.SelectedItem)
                        lst_GateSets.Items.RemoveAt(lst_GateSets.SelectedIndex)
                    End If
                    If lst_TreasureSets.SelectedIndex > 0 Then
                        lst_TreasureSets.Items.Insert(I5, lst_TreasureSets.SelectedItem)
                        lst_TreasureSets.Items.RemoveAt(lst_TreasureSets.SelectedIndex)
                    End If
                    If lst_Sublevels.SelectedIndex > 0 Then
                        lst_Sublevels.Items.Insert(I, lst_Sublevels.SelectedItem)
                        lst_Sublevels.Items.RemoveAt(lst_Sublevels.SelectedIndex)
                    End If
                    If lst_Sublevel_IDs.SelectedIndex > 0 Then
                        lst_Sublevel_IDs.Items.Insert(I2, lst_Sublevel_IDs.SelectedItem)
                        lst_Sublevel_IDs.Items.RemoveAt(lst_Sublevel_IDs.SelectedIndex)
                    End If
                    If lst_SublevelNames.SelectedIndex > 0 Then
                        lst_SublevelNames.Items.Insert(I3, lst_SublevelNames.SelectedItem)
                        lst_SublevelNames.Items.RemoveAt(lst_SublevelNames.SelectedIndex)
                    End If
                    If lst_RegularEntities.SelectedIndex > 0 Then
                        lst_RegularEntities.Items.Insert(I4, lst_RegularEntities.SelectedItem)
                        lst_RegularEntities.Items.RemoveAt(lst_RegularEntities.SelectedIndex)
                    End If
                    If lst_RegularEntitiesCounts.SelectedIndex > 0 Then
                        lst_RegularEntitiesCounts.Items.Insert(I5, lst_RegularEntitiesCounts.SelectedItem)
                        lst_RegularEntitiesCounts.Items.RemoveAt(lst_RegularEntitiesCounts.SelectedIndex)
                    End If
                    If lst_f2_CustomEntityTotal.SelectedIndex > 0 Then
                        lst_f2_CustomEntityTotal.Items.Insert(I5, lst_f2_CustomEntityTotal.SelectedItem)
                        lst_f2_CustomEntityTotal.Items.RemoveAt(lst_f2_CustomEntityTotal.SelectedIndex)
                    End If
                    If lst_f5_RoomCount.SelectedIndex > 0 Then
                        lst_f5_RoomCount.Items.Insert(I5, lst_f5_RoomCount.SelectedItem)
                        lst_f5_RoomCount.Items.RemoveAt(lst_f5_RoomCount.SelectedIndex)
                    End If
                    If lst_f6_Ratio.SelectedIndex > 0 Then
                        lst_f6_Ratio.Items.Insert(I5, lst_f6_Ratio.SelectedItem)
                        lst_f6_Ratio.Items.RemoveAt(lst_f6_Ratio.SelectedIndex)
                    End If
                    If lst_f7_Geyser.SelectedIndex > 0 Then
                        lst_f7_Geyser.Items.Insert(I5, lst_f7_Geyser.SelectedItem)
                        lst_f7_Geyser.Items.RemoveAt(lst_f7_Geyser.SelectedIndex)
                    End If
                    If lst_f8_UnitFile.SelectedIndex > 0 Then
                        lst_f8_UnitFile.Items.Insert(I5, lst_f8_UnitFile.SelectedItem)
                        lst_f8_UnitFile.Items.RemoveAt(lst_f8_UnitFile.SelectedIndex)
                    End If
                    If lst_f9_LightFile.SelectedIndex > 0 Then
                        lst_f9_LightFile.Items.Insert(I5, lst_f9_LightFile.SelectedItem)
                        lst_f9_LightFile.Items.RemoveAt(lst_f9_LightFile.SelectedIndex)
                    End If
                    If lst_f10_CloggedHole.SelectedIndex > 0 Then
                        lst_f10_CloggedHole.Items.Insert(I5, lst_f10_CloggedHole.SelectedItem)
                        lst_f10_CloggedHole.Items.RemoveAt(lst_f10_CloggedHole.SelectedIndex)
                    End If
                    If lst_f12_MusicType.SelectedIndex > 0 Then
                        lst_f12_MusicType.Items.Insert(I5, lst_f12_MusicType.SelectedItem)
                        lst_f12_MusicType.Items.RemoveAt(lst_f12_MusicType.SelectedIndex)
                    End If
                    If lst_f13_SolidPlane.SelectedIndex > 0 Then
                        lst_f13_SolidPlane.Items.Insert(I5, lst_f13_SolidPlane.SelectedItem)
                        lst_f13_SolidPlane.Items.RemoveAt(lst_f13_SolidPlane.SelectedIndex)
                    End If
                    If lst_f14_DeadEndCount.SelectedIndex > 0 Then
                        lst_f14_DeadEndCount.Items.Insert(I5, lst_f14_DeadEndCount.SelectedItem)
                        lst_f14_DeadEndCount.Items.RemoveAt(lst_f14_DeadEndCount.SelectedIndex)
                    End If
                    If lst_f16_WaterwraithTimer.SelectedIndex > 0 Then
                        lst_f16_WaterwraithTimer.Items.Insert(I5, lst_f16_WaterwraithTimer.SelectedItem)
                        lst_f16_WaterwraithTimer.Items.RemoveAt(lst_f16_WaterwraithTimer.SelectedIndex)
                    End If
                    If lst_f17_Seesaw.SelectedIndex > 0 Then
                        lst_f17_Seesaw.Items.Insert(I5, lst_f17_Seesaw.SelectedItem)
                        lst_f17_Seesaw.Items.RemoveAt(lst_f17_Seesaw.SelectedIndex)
                    End If
                    If lst_fa_Skybox.SelectedIndex > 0 Then
                        lst_fa_Skybox.Items.Insert(I5, lst_fa_Skybox.SelectedItem)
                        lst_fa_Skybox.Items.RemoveAt(lst_fa_Skybox.SelectedIndex)
                    End If
                    If lst_CustomEntityTotal_Check.SelectedIndex > 0 Then
                        lst_CustomEntityTotal_Check.Items.Insert(I5, lst_CustomEntityTotal_Check.SelectedItem)
                        lst_CustomEntityTotal_Check.Items.RemoveAt(lst_CustomEntityTotal_Check.SelectedIndex)
                    End If
                    If lst_totaka_MusicList.SelectedIndex > 0 Then
                        lst_totaka_MusicList.Items.Insert(I5, lst_totaka_MusicList.SelectedItem)
                        lst_totaka_MusicList.Items.RemoveAt(lst_totaka_MusicList.SelectedIndex)
                    End If


                    'The following calculates the new sublevel count, along with fixing up the listboxes and labels
                    Dim NewSublevelTotal As Integer = 0
                    lst_Sublevels.Items.Clear()
                    While lst_Sublevels.Items.Count < SublevelTotal
                        NewSublevelTotal += 1
                        lst_SublevelNames.SelectedIndex += 1
                        lst_Sublevels.Items.Add("Sublevel " & NewSublevelTotal & lst_SublevelNames.SelectedItem)
                        If SublevelTotal = 1 Then
                            lbl_SublevelTotal.Text = NewSublevelTotal & " Sublevel"
                        Else
                            lbl_SublevelTotal.Text = NewSublevelTotal & " Sublevels"
                        End If
                    End While

                    'The following selects the item that's moved up
                    lst_Sublevels.SelectedIndex = I
                    lst_Sublevel_IDs.SelectedIndex = I2
                    lst_SublevelNames.SelectedIndex = I3
                    lst_RegularEntities.SelectedIndex = I4
                    lst_RegularEntitiesCounts.SelectedIndex = I5
                    lst_f2_CustomEntityTotal.SelectedIndex = I5
                    lst_f5_RoomCount.SelectedIndex = I5
                    lst_f6_Ratio.SelectedIndex = I5
                    lst_f7_Geyser.SelectedIndex = I5
                    lst_f8_UnitFile.SelectedIndex = I5
                    lst_f9_LightFile.SelectedIndex = I5
                    lst_f10_CloggedHole.SelectedIndex = I5
                    lst_f12_MusicType.SelectedIndex = I5
                    lst_f13_SolidPlane.SelectedIndex = I5
                    lst_f14_DeadEndCount.SelectedIndex = I5
                    lst_f16_WaterwraithTimer.SelectedIndex = I5
                    lst_f17_Seesaw.SelectedIndex = I5
                    lst_fa_Skybox.SelectedIndex = I5
                    lst_totaka_MusicList.SelectedIndex = I5
                    lst_CustomEntityTotal_Check.SelectedIndex = I5
                    lst_TreasureSets.SelectedIndex = I5
                    lst_GateSets.SelectedIndex = I5
                End If
            End If
        End If
    End Sub
    Private Sub Form1_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.Closing
        If pressedMainMenu = False Then
            e.Cancel = True
            Dim result As Integer = MessageBox.Show("Are you sure you want to quit Cave Creator? Any unsaved progress will be lost.", "Quit", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)
            If result = DialogResult.Yes Then
                SublevelProperties.cmb_Skybox.Items.Clear()
                SublevelProperties.cmb_Skybox.Items.AddRange({"none", "test", "ice", "build", "flooring", "tatami", "hiroba"})
                MainMenu.Close()
            End If
        Else
            SublevelProperties.cmb_Skybox.Items.Clear()
            SublevelProperties.cmb_Skybox.Items.AddRange({"none", "test", "ice", "build", "flooring", "tatami", "hiroba"})
        End If

    End Sub
    Private Sub btn_RenameSublevel_Click(sender As Object, e As EventArgs) Handles btn_RenameSublevel.Click
        Dim NewSublevelName As String = "InvalidCode:gGSgs9a56FAUJHGAhgAK7AbGA8776uha878ga7gG7ga8a8ag7A8AiA8a7tF"
        While NewSublevelName = "InvalidCode:gGSgs9a56FAUJHGAhgAK7AbGA8776uha878ga7gG7ga8a8ag7A8AiA8a7tF"
            NewSublevelName = InputBox("Type the new name for Sublevel " & lst_Sublevels.SelectedIndex + 1 & ".")
            If NewSublevelName.Contains("|") AndAlso NewSublevelName.Contains("{") Then
                MsgBox("The line character | and the open brace character { cannot be used (the open brace } can be used though). Please input a new name.")
                NewSublevelName = "InvalidCode:gGSgs9a56FAUJHGAhgAK7AbGA8776uha878ga7gG7ga8a8ag7A8AiA8a7tF"
            End If
            If NewSublevelName.Contains("|") Then
                MsgBox("The line character | cannot be used. Please input a new name.")
                NewSublevelName = "InvalidCode:gGSgs9a56FAUJHGAhgAK7AbGA8776uha878ga7gG7ga8a8ag7A8AiA8a7tF"
            End If
            If NewSublevelName.Contains("{") Then
                MsgBox("The open brace character { cannot be used (the open brace } can be used though). Please input a new name.")
                NewSublevelName = "InvalidCode:gGSgs9a56FAUJHGAhgAK7AbGA8776uha878ga7gG7ga8a8ag7A8AiA8a7tF"
            End If
        End While

        If NewSublevelName = "" Then
        Else
            lst_SublevelNames.Items(lst_SublevelNames.SelectedIndex) = " - " & NewSublevelName
            lst_SublevelNames.SelectedItem = " - " & NewSublevelName
            lst_Sublevels.Items(lst_Sublevels.SelectedIndex) = "Sublevel " & lst_Sublevel_IDs.SelectedIndex + 1 & lst_SublevelNames.SelectedItem
            lst_Sublevels.SelectedItem = "Sublevel " & lst_Sublevel_IDs.SelectedIndex + 1 & lst_SublevelNames.SelectedItem
        End If
    End Sub
    Protected Overrides ReadOnly Property CreateParams() As CreateParams        'This fixes the glitchy tabs when there's a background image
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or &H2000000
            Return cp
        End Get
    End Property
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CultureInfo.DefaultThreadCurrentCulture = New CultureInfo("en-US")
        CultureInfo.CurrentCulture = New CultureInfo("en-US")

        Text = "Cave Creator " & Application.ProductVersion

        lbl_SublevelID.Text = "Nothing Selected"        'Clears out the selected sublevel identifier label
        lbl_EntityCount.Text = ""        'Clears out the selected sublevel entity count label
        lbl_TotalEntityCount.Text = ""
        pnl_Debug.Location = New Point(0, 0)
        pnl_Debug.Visible = False
        lbl_SublevelID.Location = New Point((lbl_SelectedSublevelTitle.Location.X + (lbl_SelectedSublevelTitle.Width / 2)) - (lbl_SublevelID.Width / 2), lbl_SublevelID.Location.Y)
        lbl_TotalEntityCount.Location = New Point((lbl_SelectedSublevelTitle.Location.X + (lbl_SelectedSublevelTitle.Width / 2)) - (lbl_TotalEntityCount.Width / 2), lbl_TotalEntityCount.Location.Y)
        lbl_EntityCount.Location = New Point((lbl_SelectedSublevelTitle.Location.X + (lbl_SelectedSublevelTitle.Width / 2)) - (lbl_EntityCount.Width / 2), lbl_EntityCount.Location.Y)
        Me.Size = New Size(810, 562)
        Me.CenterToScreen()
        pnl_Entities.Visible = False
        TabControl1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right Or AnchorStyles.Top
        pnl_Entities.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right Or AnchorStyles.Top
        lbl_SublevelTotal.Anchor = AnchorStyles.Right Or AnchorStyles.Top
        pnl_PROCESSINGTHECAVE.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right Or AnchorStyles.Top


        'btn_ExportCaveFile.Location = New Point(390, 408)
        'btn_CopyMusicCode.Location = New Point(390, 407)
        'pnl_Advanced.Visible = True
        'btn_ExportCaveFile.Visible = True
        'btn_CopyMusicCode.Visible = True
        'btn_ImportCave.Left = 240
        'btn_ExportCaveFile.Location = New Point(390, 268)
        'btn_CopyMusicCode.Location = New Point(390, 297)
        'chk_ShowAdvanced.Enabled = True
        'btn_ImportCave.Location = New Point(215, 268)




        cmb_EntitySpawnLocation.SelectedIndex = 0
        cmb_EntitySpawnMethod.SelectedIndex = 0
        cmb_DropTreasures.SelectedIndex = 0
        SublevelTreasures.cmb_Treasures.SelectedIndex = 0
        'cmb_ChallengeModeCaves.SelectedIndex = 0
        'Dim CMCcurrentindex As Integer = cmb_ChallengeModeCaves.SelectedIndex
        'cmb_ChallengeModeCaves.Items.Clear()
        'cmb_ChallengeModeCaves.Items.Add("Explorer's Cave")
        'cmb_ChallengeModeCaves.Items.Add("Novice Training")
        'cmb_ChallengeModeCaves.Items.Add("Lost Toy Box")
        'cmb_ChallengeModeCaves.Items.Add("Creator's Garden")
        'cmb_ChallengeModeCaves.Items.Add("Green Hole")
        'cmb_ChallengeModeCaves.Items.Add("Hot House")
        'cmb_ChallengeModeCaves.Items.Add("Brawny Abyss")
        'cmb_ChallengeModeCaves.Items.Add("Red Chasm")
        'cmb_ChallengeModeCaves.Items.Add("Trampled Garden")
        'cmb_ChallengeModeCaves.Items.Add("Twilight Garden")
        'cmb_ChallengeModeCaves.Items.Add("Cryptic Cavern")
        'cmb_ChallengeModeCaves.Items.Add("Concrete Maze")
        'cmb_ChallengeModeCaves.Items.Add("Collector's Room")
        'cmb_ChallengeModeCaves.Items.Add("Dweevil Nest")
        'cmb_ChallengeModeCaves.Items.Add("Cavernous Abyss")
        'cmb_ChallengeModeCaves.Items.Add("Snack Pit")
        'cmb_ChallengeModeCaves.Items.Add("Three Color Training")
        'cmb_ChallengeModeCaves.Items.Add("Hazard Training")
        'cmb_ChallengeModeCaves.Items.Add("Cave of Snarls")
        'cmb_ChallengeModeCaves.Items.Add("The Giant's Bath")
        'cmb_ChallengeModeCaves.Items.Add("Rumbling Grotto")
        'cmb_ChallengeModeCaves.Items.Add("Subterranean Lair")
        'cmb_ChallengeModeCaves.Items.Add("Hidden Garden")
        'cmb_ChallengeModeCaves.Items.Add("Abduction Den")
        'cmb_ChallengeModeCaves.Items.Add("Secret Testing Range")
        'cmb_ChallengeModeCaves.Items.Add("Breeding Ground")
        'cmb_ChallengeModeCaves.Items.Add("Cave of Pain")
        'cmb_ChallengeModeCaves.Items.Add("Bully Den")
        'cmb_ChallengeModeCaves.Items.Add("Sniper Room")
        'cmb_ChallengeModeCaves.Items.Add("Emperor's Realm")
        'cmb_ChallengeModeCaves.SelectedIndex = CMCcurrentindex


        txt_RootDirectory.Text = ""
        cmb_ReplaceWith.SelectedIndex = 0

        loadOptions()


        ToolTip1.BackColor = Color.Red
        Me.Select()
    End Sub
    Public Sub loadOptions()
        If System.IO.File.Exists(AppDomain.CurrentDomain.BaseDirectory & "\CCP.data") Then
            Dim OptionsFile As String = My.Computer.FileSystem.ReadAllText(AppDomain.CurrentDomain.BaseDirectory & "\CCP.data")
            Dim wrapper As New Simple3Des("hsAJAA%#!HJbhk^&A^&76agiA%$##a&AFAA&*A*GAIha8aF1")
            OptionsFile = wrapper.DecryptData(OptionsFile)

            If OptionsFile.Contains("defaultroot=") Then
                Dim BeforePreviousDefaultRoot As String = OptionsFile.Substring(OptionsFile.IndexOf("defaultroot=") + 12, OptionsFile.Length - (OptionsFile.IndexOf("defaultroot=") + 12))
                Dim DefaultRoot As String = BeforePreviousDefaultRoot.Substring(0, BeforePreviousDefaultRoot.IndexOf("
"))
                txt_RootDirectory.Text = DefaultRoot
                btn_ImportCave.Enabled = True
                RootDirectory = DefaultRoot
            End If

            If OptionsFile.Contains("autosave=") Then
                Dim BeforePreviousDefaultRoot As String = OptionsFile.Substring(OptionsFile.IndexOf("autosave=") + 9, OptionsFile.Length - (OptionsFile.IndexOf("autosave=") + 9))
                Dim AutosaveValue As String = BeforePreviousDefaultRoot.Substring(0, BeforePreviousDefaultRoot.IndexOf("
"))
                If AutosaveValue = "true" Then
                    tmr_Autosave.Enabled = True
                ElseIf AutosaveValue = "false" Then
                    tmr_Autosave.Enabled = False
                End If
            End If
            If OptionsFile.Contains("asmode=") Then
                Dim BeforePreviousDefaultRoot As String = OptionsFile.Substring(OptionsFile.IndexOf("asmode=") + 7, OptionsFile.Length - (OptionsFile.IndexOf("asmode=") + 7))
                Dim AutosaveMode As String = BeforePreviousDefaultRoot.Substring(0, BeforePreviousDefaultRoot.IndexOf("
"))
                Select Case AutosaveMode
                    Case "0"
                        tmr_Autosave.Interval = 1800000
                    Case "1"
                        tmr_Autosave.Interval = 600000
                    Case "2"
                        tmr_Autosave.Interval = 300000
                    Case "3"
                        tmr_Autosave.Interval = 60000
                End Select
            Else
                tmr_Autosave.Interval = 1800000
            End If
            If OptionsFile.Contains("doubleclick=") Then
                Dim BeforePreviousDefaultRoot As String = OptionsFile.Substring(OptionsFile.IndexOf("doubleclick=") + 12, OptionsFile.Length - (OptionsFile.IndexOf("doubleclick=") + 12))
                Dim DoubleClickOption As String = BeforePreviousDefaultRoot.Substring(0, BeforePreviousDefaultRoot.IndexOf("
"))
                Select Case DoubleClickOption
                    Case "0"
                        DoubleClickMode = 0
                    Case "1"
                        DoubleClickMode = 1
                    Case "2"
                        DoubleClickMode = 2
                    Case "3"
                        DoubleClickMode = 3
                End Select
            End If
        End If
    End Sub
    Private Sub btn_RemoveSublevelName_Click(sender As Object, e As EventArgs) Handles btn_RemoveSublevelName.Click
        lst_SublevelNames.Items(lst_SublevelNames.SelectedIndex) = " "
        lst_SublevelNames.SelectedIndex = lst_SublevelNames.SelectedIndex
        lst_Sublevels.Items(lst_Sublevels.SelectedIndex) = "Sublevel " & lst_Sublevel_IDs.SelectedIndex + 1 & lst_SublevelNames.SelectedItem
        lst_Sublevels.SelectedItem = "Sublevel " & lst_Sublevel_IDs.SelectedIndex + 1 & lst_SublevelNames.SelectedItem
    End Sub
    Private Sub btn_AddSublevel2_Click(sender As Object, e As EventArgs) Handles btn_AddSublevel2.Click
        ImportingCM = True
        If SublevelTotal = 0 Then
            lst_RegularEntitiesCounts.Items.Clear()
        End If
        If chk_SublevelNameInput.Checked = False Then
            ClickedAddSublevelWithNameInput = True
            SublevelName = "InvalidCode:gGSgs9a56FAUJHGAhgAK7AbGA8776uha878ga7gG7ga8a8ag7A8AiA8a7tF"
            While SublevelName = "InvalidCode:gGSgs9a56FAUJHGAhgAK7AbGA8776uha878ga7gG7ga8a8ag7A8AiA8a7tF"
                SublevelName = InputBox("Name your sublevel so you can distinguish it from other sublevels." & vbCrLf & vbCrLf & "This will not be present in-game.")
                If SublevelName.Contains("|") AndAlso SublevelName.Contains("{") Then
                    MsgBox("The line character | and the open brace character { cannot be used (the close brace } can be used though). Please input a new name.")
                    SublevelName = "InvalidCode:gGSgs9a56FAUJHGAhgAK7AbGA8776uha878ga7gG7ga8a8ag7A8AiA8a7tF"
                End If
                If SublevelName.Contains("|") Then
                    MsgBox("The line character | cannot be used. Please input a new name.")
                    SublevelName = "InvalidCode:gGSgs9a56FAUJHGAhgAK7AbGA8776uha878ga7gG7ga8a8ag7A8AiA8a7tF"
                End If
                If SublevelName.Contains("{") Then
                    MsgBox("The open brace character { cannot be used (the close brace } can be used though). Please input a new name.")
                    SublevelName = "InvalidCode:gGSgs9a56FAUJHGAhgAK7AbGA8776uha878ga7gG7ga8a8ag7A8AiA8a7tF"
                End If
            End While

            If SublevelName = "" Then
            Else
                SublevelName = " - " & SublevelName
                If lst_Sublevels.SelectedIndex > -1 Then
                    DeselectLists()
                End If
                SublevelTotal += 1
                SublevelTotalID += 1
                lst_Sublevels.Items.Add("Sublevel " & SublevelTotal & SublevelName)
                lst_Sublevel_IDs.Items.Add("S" & SublevelTotalID)
                lst_SublevelNames.Items.Add(SublevelName)
                If SublevelTotal = 1 Then
                    lbl_SublevelTotal.Text = SublevelTotal & " Sublevel"
                Else
                    lbl_SublevelTotal.Text = SublevelTotal & " Sublevels"
                End If
                lst_Sublevel_IDs.SelectedIndex = lst_Sublevel_IDs.Items.Count - 1
                lst_RegularEntities.Items.Add(lst_Sublevel_IDs.SelectedItem & " - ")
                lst_RegularEntitiesCounts.Items.Add(lst_Sublevel_IDs.SelectedItem & " - ")

                lst_f5_RoomCount.Items.Add("1")
                lst_f6_Ratio.Items.Add("0.12")
                lst_f7_Geyser.Items.Add("0")
                lst_f8_UnitFile.Items.Add("1_ABE_ari_metal.txt")
                lst_f9_LightFile.Items.Add("normal_light_lv0.ini")
                lst_fa_Skybox.Items.Add("none")
                lst_f10_CloggedHole.Items.Add("0")
                lst_f12_MusicType.Items.Add("0")
                lst_f13_SolidPlane.Items.Add("0")
                lst_f14_DeadEndCount.Items.Add("50")
                lst_f16_WaterwraithTimer.Items.Add("0")
                lst_f17_Seesaw.Items.Add("0")
                lst_totaka_MusicList.Items.Add("caveconc_00_0.cnd")
                lst_f2_CustomEntityTotal.Items.Add("0")
                lst_CustomEntityTotal_Check.Items.Add("0")

                lst_Times.Items.Add("Sublevel " & lst_Sublevels.Items.Count.ToString & ": 0 seconds")



                lst_f5_RoomCount.SelectedIndex = lst_Sublevels.Items.Count - 1
                lst_f6_Ratio.SelectedIndex = lst_Sublevels.Items.Count - 1
                lst_f7_Geyser.SelectedIndex = lst_Sublevels.Items.Count - 1
                lst_f8_UnitFile.SelectedIndex = lst_Sublevels.Items.Count - 1
                lst_f9_LightFile.SelectedIndex = lst_Sublevels.Items.Count - 1
                lst_fa_Skybox.SelectedIndex = lst_Sublevels.Items.Count - 1
                lst_f10_CloggedHole.SelectedIndex = lst_Sublevels.Items.Count - 1
                lst_f12_MusicType.SelectedIndex = lst_Sublevels.Items.Count - 1
                lst_f13_SolidPlane.SelectedIndex = lst_Sublevels.Items.Count - 1
                lst_f14_DeadEndCount.SelectedIndex = lst_Sublevels.Items.Count - 1
                lst_f16_WaterwraithTimer.SelectedIndex = lst_Sublevels.Items.Count - 1
                lst_f17_Seesaw.SelectedIndex = lst_Sublevels.Items.Count - 1
                lst_totaka_MusicList.SelectedIndex = lst_Sublevels.Items.Count - 1
                lst_f2_CustomEntityTotal.SelectedIndex = lst_Sublevels.Items.Count - 1
                lst_CustomEntityTotal_Check.SelectedIndex = lst_Sublevels.Items.Count - 1

                lst_TreasureSets.Items.Add(lst_Sublevel_IDs.SelectedItem & " - ")
                lst_TreasureSets.SelectedIndex = lst_Sublevels.Items.Count - 1
                lst_GateSets.Items.Add(lst_Sublevel_IDs.SelectedItem & " - ")
                lst_GateSets.SelectedIndex = lst_Sublevels.Items.Count - 1


                lst_Sublevel_IDs.SelectedIndex = -1
                lst_Sublevels.SelectedIndex = lst_Sublevels.Items.Count - 1
            End If
        Else
            ClickedAddSublevelWithNameInput = False
            If lst_Sublevels.SelectedIndex > -1 Then
                DeselectLists()
            End If
            SublevelTotal += 1
            SublevelTotalID += 1
            lst_Sublevels.Items.Add("Sublevel " & SublevelTotal)
            lst_Sublevel_IDs.Items.Add("S" & SublevelTotalID)
            SublevelName = " "
            lst_SublevelNames.Items.Add(SublevelName)
            If SublevelTotal = 1 Then
                lbl_SublevelTotal.Text = SublevelTotal & " Sublevel"
            Else
                lbl_SublevelTotal.Text = SublevelTotal & " Sublevels"
            End If
            lst_Sublevel_IDs.SelectedIndex = lst_Sublevel_IDs.Items.Count - 1
            lst_RegularEntities.Items.Add(lst_Sublevel_IDs.SelectedItem & " - ")
            lst_RegularEntitiesCounts.Items.Add(lst_Sublevel_IDs.SelectedItem & " - ")

            lst_f5_RoomCount.Items.Add("1")
            lst_f6_Ratio.Items.Add("0.12")
            lst_f7_Geyser.Items.Add("0")
            lst_f8_UnitFile.Items.Add("1_ABE_ari_metal.txt")
            lst_f9_LightFile.Items.Add("normal_light_lv0.ini")
            lst_fa_Skybox.Items.Add("none")
            lst_f10_CloggedHole.Items.Add("0")
            lst_f12_MusicType.Items.Add("0")
            lst_f13_SolidPlane.Items.Add("0")
            lst_f14_DeadEndCount.Items.Add("50")
            lst_f16_WaterwraithTimer.Items.Add("0")
            lst_f17_Seesaw.Items.Add("0")
            lst_totaka_MusicList.Items.Add("caveconc_00_0.cnd")
            lst_f2_CustomEntityTotal.Items.Add("null")
            lst_CustomEntityTotal_Check.Items.Add("0")


            lst_Times.Items.Add("Sublevel " & lst_Sublevels.Items.Count.ToString & ": 0 seconds")



            lst_f5_RoomCount.SelectedIndex = lst_Sublevels.Items.Count - 1
            lst_f6_Ratio.SelectedIndex = lst_Sublevels.Items.Count - 1
            lst_f7_Geyser.SelectedIndex = lst_Sublevels.Items.Count - 1
            lst_f8_UnitFile.SelectedIndex = lst_Sublevels.Items.Count - 1
            lst_f9_LightFile.SelectedIndex = lst_Sublevels.Items.Count - 1
            lst_fa_Skybox.SelectedIndex = lst_Sublevels.Items.Count - 1
            lst_f10_CloggedHole.SelectedIndex = lst_Sublevels.Items.Count - 1
            lst_f12_MusicType.SelectedIndex = lst_Sublevels.Items.Count - 1
            lst_f13_SolidPlane.SelectedIndex = lst_Sublevels.Items.Count - 1
            lst_f14_DeadEndCount.SelectedIndex = lst_Sublevels.Items.Count - 1
            lst_f16_WaterwraithTimer.SelectedIndex = lst_Sublevels.Items.Count - 1
            lst_f17_Seesaw.SelectedIndex = lst_Sublevels.Items.Count - 1
            lst_totaka_MusicList.SelectedIndex = lst_Sublevels.Items.Count - 1
            lst_f2_CustomEntityTotal.SelectedIndex = lst_Sublevels.Items.Count - 1
            lst_CustomEntityTotal_Check.SelectedIndex = lst_Sublevels.Items.Count - 1

            lst_TreasureSets.Items.Add(lst_Sublevel_IDs.SelectedItem & " - ")
            lst_TreasureSets.SelectedIndex = lst_Sublevels.Items.Count - 1
            lst_GateSets.Items.Add(lst_Sublevel_IDs.SelectedItem & " - ")
            lst_GateSets.SelectedIndex = lst_Sublevels.Items.Count - 1


            lst_Sublevel_IDs.SelectedIndex = -1
            lst_Sublevels.SelectedIndex = lst_Sublevels.Items.Count - 1
        End If

        If lst_Sublevels.Items.Count = 0 Then
            btn_Save.Enabled = False
        Else
            btn_SaveAs.Enabled = True
            If CaveNeedsToSaveAs = False Then btn_Save.Enabled = True
        End If
        ImportingCM = False
    End Sub
    Private Sub btn_RemoveSublevel_Click(sender As Object, e As EventArgs) Handles btn_RemoveSublevel2.Click
        ImportingCM = True
        Dim YesDeleteSublevel As Boolean = False
        If lst_Sublevels.SelectedIndex > -1 Then
            If chk_DeleteSublevelQ.Checked = True Then
                YesDeleteSublevel = True
                ClickedAddSublevelWithNameInput = False
            Else
                ClickedAddSublevelWithNameInput = True
                Dim result As Integer = MessageBox.Show("Are you sure you want to delete " & lst_Sublevels.SelectedItem & "?" & vbCrLf & vbCrLf & "This will be permanent.", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)
                If result = DialogResult.Yes Then
                    YesDeleteSublevel = True
                End If
            End If
        End If

        If YesDeleteSublevel = True Then
            SublevelTotal -= 1
            If SublevelTotal = 1 Then
                lbl_SublevelTotal.Text = SublevelTotal & " Sublevel"
            Else
                lbl_SublevelTotal.Text = SublevelTotal & " Sublevels"
            End If
            '''''' THIS AREA WILL BE DEDICATED TO CLEARING OUT THE DATA FROM THE EDIT SUBLEVEL SECTION, THEN IT WILL SHIFT THE DATA FROM SUBLEVELS AFTER THE DELETED ONE DOWN
            lst_TreasureSets.Items.RemoveAt(lst_TreasureSets.SelectedIndex)












            lst_Sublevels.Items.RemoveAt(lst_Sublevels.SelectedIndex) ''''' THIS IS REMOVAL OF THAT PARTICULAR SUBLEVEL FROM THE LISTBOX
            lst_Sublevel_IDs.Items.RemoveAt(lst_Sublevel_IDs.SelectedIndex)
            lst_SublevelNames.Items.RemoveAt(lst_SublevelNames.SelectedIndex)
            lst_RegularEntities.Items.RemoveAt(lst_RegularEntities.SelectedIndex)
            lst_RegularEntitiesCounts.Items.RemoveAt(lst_RegularEntitiesCounts.SelectedIndex)

            lst_f2_CustomEntityTotal.Items.RemoveAt(lst_f2_CustomEntityTotal.SelectedIndex)
            lst_f5_RoomCount.Items.RemoveAt(lst_f5_RoomCount.SelectedIndex)
            lst_f6_Ratio.Items.RemoveAt(lst_f6_Ratio.SelectedIndex)
            lst_f7_Geyser.Items.RemoveAt(lst_f7_Geyser.SelectedIndex)
            lst_f8_UnitFile.Items.RemoveAt(lst_f8_UnitFile.SelectedIndex)
            lst_f9_LightFile.Items.RemoveAt(lst_f9_LightFile.SelectedIndex)
            lst_f10_CloggedHole.Items.RemoveAt(lst_f10_CloggedHole.SelectedIndex)
            lst_f12_MusicType.Items.RemoveAt(lst_f12_MusicType.SelectedIndex)
            lst_f13_SolidPlane.Items.RemoveAt(lst_f13_SolidPlane.SelectedIndex)
            lst_f14_DeadEndCount.Items.RemoveAt(lst_f14_DeadEndCount.SelectedIndex)
            lst_f16_WaterwraithTimer.Items.RemoveAt(lst_f16_WaterwraithTimer.SelectedIndex)
            lst_f17_Seesaw.Items.RemoveAt(lst_f17_Seesaw.SelectedIndex)
            lst_fa_Skybox.Items.RemoveAt(lst_fa_Skybox.SelectedIndex)
            lst_totaka_MusicList.Items.RemoveAt(lst_totaka_MusicList.SelectedIndex)
            lst_CustomEntityTotal_Check.Items.RemoveAt(lst_CustomEntityTotal_Check.SelectedIndex)


            lst_Times.Items.RemoveAt(lst_Times.SelectedIndex)

            Dim timeslist As New List(Of Integer)
            For Each subleveltime In lst_Times.Items
                Dim actualtime = subleveltime.ToString.Substring(subleveltime.ToString.IndexOf(": ") + 2)
                actualtime = actualtime.Substring(0, actualtime.IndexOf(" seconds"))
                timeslist.Add(Integer.Parse(actualtime))
            Next
            lst_Times.Items.Clear()

            For i = 0 To timeslist.Count - 1
                lst_Times.Items.Add("Sublevel " & (i + 1).ToString & ": " & timeslist(i).ToString & " seconds")
            Next




            Dim NewSublevelTotal As Integer = 0
            lst_Sublevels.Items.Clear()
            lst_SublevelNames.SelectedIndex = -1
            While lst_Sublevels.Items.Count < SublevelTotal
                NewSublevelTotal += 1
                lst_SublevelNames.SelectedIndex += 1
                lst_Sublevels.Items.Add("Sublevel " & NewSublevelTotal & lst_SublevelNames.SelectedItem)
                If SublevelTotal = 1 Then
                    lbl_SublevelTotal.Text = NewSublevelTotal & " Sublevel"
                Else
                    lbl_SublevelTotal.Text = NewSublevelTotal & " Sublevels"
                End If
            End While
            lst_SublevelNames.SelectedIndex = -1
        End If


        If lst_Sublevels.Items.Count = 0 Then
            btn_Save.Enabled = False
        Else
            btn_SaveAs.Enabled = True
            If CaveNeedsToSaveAs = False Then btn_Save.Enabled = True
        End If
        ImportingCM = False
    End Sub
    Private Sub btn_DeleteAllSublevels3_Click(sender As Object, e As EventArgs) Handles btn_DeleteAllSublevels3.Click

        If lst_Sublevels.Items.Count = 0 Then
        Else
            ClickedAddSublevelWithNameInput = True

            Dim result As Integer = MessageBox.Show("Are you sure you want to delete all of your sublevels?" & vbCrLf & vbCrLf & "This will be permanent.", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)
            If result = DialogResult.Yes Then
                SublevelTotal = 0
                SublevelTotalID = 0
                lbl_SublevelTotal.Text = SublevelTotal & " Sublevels"
                If lst_Sublevels.Items.Count > 0 Then
                    lst_Sublevels.SelectedIndex = 0
                    lst_Sublevels.Items.RemoveAt(lst_Sublevels.SelectedIndex)
                End If
                lst_TreasureSets.Items.Clear()
                lst_Sublevels.Items.Clear()
                lst_Sublevel_IDs.Items.Clear()
                lst_SublevelNames.Items.Clear()
                lst_RegularEntities.Items.Clear()
                lst_RegularEntitiesCounts.Items.Clear()
                lst_f2_CustomEntityTotal.Items.Clear()
                lst_f5_RoomCount.Items.Clear()
                lst_f6_Ratio.Items.Clear()
                lst_f7_Geyser.Items.Clear()
                lst_f8_UnitFile.Items.Clear()
                lst_f9_LightFile.Items.Clear()
                lst_f10_CloggedHole.Items.Clear()
                lst_f12_MusicType.Items.Clear()
                lst_f13_SolidPlane.Items.Clear()
                lst_f14_DeadEndCount.Items.Clear()
                lst_f16_WaterwraithTimer.Items.Clear()
                lst_f17_Seesaw.Items.Clear()
                lst_fa_Skybox.Items.Clear()
                lst_CustomEntityTotal_Check.Items.Clear()
                lst_totaka_MusicList.Items.Clear()
                lst_TreasureSets.Items.Clear()
                lst_GateSets.Items.Clear()
                lst_Times.Items.Clear()

                btn_Save.Enabled = False
            End If

            If lst_Sublevels.Items.Count = 0 Then
                btn_Save.Enabled = False
            Else
                btn_SaveAs.Enabled = True
                If CaveNeedsToSaveAs = False Then btn_Save.Enabled = True
            End If

        End If
    End Sub
    Private Sub btn_AddEntity_Click(sender As Object, e As EventArgs) Handles btn_AddEntity.Click
        Dim DropTreasureCode As String = ""
        If chk_EntityDropTreasure.Checked = True Then
            If cmb_DropTreasures.SelectedItem = "Rubber Ugly" Then DropTreasureCode = "ahiru"
            If cmb_DropTreasures.SelectedItem = "Insect Condo" Then DropTreasureCode = "apple"
            If cmb_DropTreasures.SelectedItem = "Meat Satchel" Then DropTreasureCode = "apple_blue"
            If cmb_DropTreasures.SelectedItem = "Coiled Launcher" Then DropTreasureCode = "bane"
            If cmb_DropTreasures.SelectedItem = "Confection Hoop" Then DropTreasureCode = "baum_kuchen"
            If cmb_DropTreasures.SelectedItem = "Omniscient Sphere" Then DropTreasureCode = "be_dama_red"
            If cmb_DropTreasures.SelectedItem = "Love Sphere" Then DropTreasureCode = "be_dama_yellow"
            If cmb_DropTreasures.SelectedItem = "Mirth Sphere" Then DropTreasureCode = "be_dama_blue"
            If cmb_DropTreasures.SelectedItem = "Maternal Sculpture" Then DropTreasureCode = "bell"
            If cmb_DropTreasures.SelectedItem = "Stupendous Lens" Then DropTreasureCode = "bey_goma"
            If cmb_DropTreasures.SelectedItem = "Leviathan Feather" Then DropTreasureCode = "bird_hane"
            If cmb_DropTreasures.SelectedItem = "Superstrong Stabilizer" Then DropTreasureCode = "bolt"
            If cmb_DropTreasures.SelectedItem = "Space Wave Receiver" Then DropTreasureCode = "channel"
            If cmb_DropTreasures.SelectedItem = "Joy Receptacle" Then DropTreasureCode = "chess_king_black"
            If cmb_DropTreasures.SelectedItem = "Worthless Statue" Then DropTreasureCode = "chess_king_white"
            If cmb_DropTreasures.SelectedItem = "Priceless Statue" Then DropTreasureCode = "chess_queen_black"
            If cmb_DropTreasures.SelectedItem = "Triple Sugar Threat" Then DropTreasureCode = "chess_queen_white"
            If cmb_DropTreasures.SelectedItem = "King of Sweets" Then DropTreasureCode = "chocolate"
            If cmb_DropTreasures.SelectedItem = "Diet Doomer" Then DropTreasureCode = "chocoichigo"
            If cmb_DropTreasures.SelectedItem = "Pale Passion" Then DropTreasureCode = "chocowhite"
            If cmb_DropTreasures.SelectedItem = "Boom Cone" Then DropTreasureCode = "compact"
            If cmb_DropTreasures.SelectedItem = "Bug Bait" Then DropTreasureCode = "cookie"
            If cmb_DropTreasures.SelectedItem = "Milk Tub" Then DropTreasureCode = "creap"
            If cmb_DropTreasures.SelectedItem = "Petrified Heart" Then DropTreasureCode = "diamond_red"
            If cmb_DropTreasures.SelectedItem = "Regal Diamond" Then DropTreasureCode = "diamond_blue"
            If cmb_DropTreasures.SelectedItem = "Princess Pearl" Then DropTreasureCode = "diamond_green"
            If cmb_DropTreasures.SelectedItem = "Silencer" Then DropTreasureCode = "doll"
            If cmb_DropTreasures.SelectedItem = "Armored Nut" Then DropTreasureCode = "donguri"
            If cmb_DropTreasures.SelectedItem = "Chocolate Cushion" Then DropTreasureCode = "donutschoco"
            If cmb_DropTreasures.SelectedItem = "Sweet Dreamer" Then DropTreasureCode = "donutsichigo"
            If cmb_DropTreasures.SelectedItem = "Cosmic Archive" Then DropTreasureCode = "donutswhite"
            If cmb_DropTreasures.SelectedItem = "Cupid's Grenade" Then DropTreasureCode = "flower_red"
            If cmb_DropTreasures.SelectedItem = "Science Project" Then DropTreasureCode = "flower_blue"
            If cmb_DropTreasures.SelectedItem = "Manual Honer" Then DropTreasureCode = "toy_gentle"
            If cmb_DropTreasures.SelectedItem = "Broken Food Master" Then DropTreasureCode = "toy_lady"
            If cmb_DropTreasures.SelectedItem = "Sud Generator" Then DropTreasureCode = "toy_dog"
            If cmb_DropTreasures.SelectedItem = "Wiggle Noggin" Then DropTreasureCode = "toy_cat"
            If cmb_DropTreasures.SelectedItem = "Omega Flywheel" Then DropTreasureCode = "gear"
            If cmb_DropTreasures.SelectedItem = "Lustrous Element" Then DropTreasureCode = "gold_medal"
            If cmb_DropTreasures.SelectedItem = "Superstick Textile" Then DropTreasureCode = "gum_tape"
            If cmb_DropTreasures.SelectedItem = "Possessed Squash" Then DropTreasureCode = "halloween"
            If cmb_DropTreasures.SelectedItem = "Gyroid Bust" Then DropTreasureCode = "haniwa"
            If cmb_DropTreasures.SelectedItem = "Sunseed Berry" Then DropTreasureCode = "ichigo"
            If cmb_DropTreasures.SelectedItem = "Glee Spinner" Then DropTreasureCode = "juji_key"
            If cmb_DropTreasures.SelectedItem = "Decorative Goo" Then DropTreasureCode = "kan"
            If cmb_DropTreasures.SelectedItem = "Anti-hiccup Fungus" Then DropTreasureCode = "kinoko"
            If cmb_DropTreasures.SelectedItem = "Crystal King" Then DropTreasureCode = "kouseki_suisyou"
            If cmb_DropTreasures.SelectedItem = "Fossilized Ursidae" Then DropTreasureCode = "kumakibori"
            If cmb_DropTreasures.SelectedItem = "Time Capsule" Then DropTreasureCode = "locket"
            If cmb_DropTreasures.SelectedItem = "Olimarnite Shell" Then DropTreasureCode = "makigai"
            If cmb_DropTreasures.SelectedItem = "Conifer Spire" Then DropTreasureCode = "matu_bokkuri"
            If cmb_DropTreasures.SelectedItem = "Abstract Masterpiece" Then DropTreasureCode = "milk_cap"
            If cmb_DropTreasures.SelectedItem = "Arboreal Frippery" Then DropTreasureCode = "momiji_normal"
            If cmb_DropTreasures.SelectedItem = "Onion Replica" Then DropTreasureCode = "momiji_kare"
            If cmb_DropTreasures.SelectedItem = "Infernal Vegetable" Then DropTreasureCode = "momiji_red"
            If cmb_DropTreasures.SelectedItem = "Adamantine Girdle" Then DropTreasureCode = "nut"
            If cmb_DropTreasures.SelectedItem = "Directory of Destiny" Then DropTreasureCode = "tatebue"
            If cmb_DropTreasures.SelectedItem = "Colossal Fossil" Then DropTreasureCode = "saru_head"
            If cmb_DropTreasures.SelectedItem = "Invigorator" Then DropTreasureCode = "sensya"
            If cmb_DropTreasures.SelectedItem = "Vacuum Processor" Then DropTreasureCode = "sinkukan"
            If cmb_DropTreasures.SelectedItem = "Mirrored Element" Then DropTreasureCode = "silver_medal"
            If cmb_DropTreasures.SelectedItem = "Nouveau Table" Then DropTreasureCode = "tel_dial"
            If cmb_DropTreasures.SelectedItem = "Pink Menace" Then DropTreasureCode = "toy_ring_a_red"
            If cmb_DropTreasures.SelectedItem = "Frosty Bauble" Then DropTreasureCode = "toy_ring_a_blue"
            If cmb_DropTreasures.SelectedItem = "Gemstar Husband" Then DropTreasureCode = "toy_ring_a_green"
            If cmb_DropTreasures.SelectedItem = "Gemstar Wife" Then DropTreasureCode = "toy_ring_b_red"
            If cmb_DropTreasures.SelectedItem = "Universal Com" Then DropTreasureCode = "toy_ring_b_blue"
            If cmb_DropTreasures.SelectedItem = "Joyless Jewel" Then DropTreasureCode = "toy_ring_b_green"
            If cmb_DropTreasures.SelectedItem = "Fleeting Art Form" Then DropTreasureCode = "toy_ring_c_red"
            If cmb_DropTreasures.SelectedItem = "Innocence Lost" Then DropTreasureCode = "toy_ring_c_green"
            If cmb_DropTreasures.SelectedItem = "Icon of Progress" Then DropTreasureCode = "toy_ring_c_blue"
            If cmb_DropTreasures.SelectedItem = "Unspeakable Wonder" Then DropTreasureCode = "toy_teala"
            If cmb_DropTreasures.SelectedItem = "Aquatic Mine" Then DropTreasureCode = "turi_uki"
            If cmb_DropTreasures.SelectedItem = "Temporal Mechanism" Then DropTreasureCode = "watch"
            If cmb_DropTreasures.SelectedItem = "Essential Furnishing" Then DropTreasureCode = "Xmas_item"
            If cmb_DropTreasures.SelectedItem = "Flame Tiller" Then DropTreasureCode = "yoyo_red"
            If cmb_DropTreasures.SelectedItem = "Doomsday Apparatus" Then DropTreasureCode = "yoyo_yellow"
            If cmb_DropTreasures.SelectedItem = "Impediment Scourge" Then DropTreasureCode = "yoyo_blue"
            If cmb_DropTreasures.SelectedItem = "Future Orb" Then DropTreasureCode = "flask"
            If cmb_DropTreasures.SelectedItem = "Shock Therapist" Then DropTreasureCode = "elec"
            If cmb_DropTreasures.SelectedItem = "Flare Cannon" Then DropTreasureCode = "fire"
            If cmb_DropTreasures.SelectedItem = "Comedy Bomb" Then DropTreasureCode = "gas"
            If cmb_DropTreasures.SelectedItem = "Monster Pump" Then DropTreasureCode = "water"
            If cmb_DropTreasures.SelectedItem = "Mystical Disc" Then DropTreasureCode = "mojiban"
            If cmb_DropTreasures.SelectedItem = "Vorpal Platter" Then DropTreasureCode = "futa_a_gold"
            If cmb_DropTreasures.SelectedItem = "Taste Sensation" Then DropTreasureCode = "futa_a_silver"
            If cmb_DropTreasures.SelectedItem = "Lip Service" Then DropTreasureCode = "kan_b_gold"
            If cmb_DropTreasures.SelectedItem = "Utter Scrap" Then DropTreasureCode = "kan_b_silver"
            If cmb_DropTreasures.SelectedItem = "Paradoxical Enigma" Then DropTreasureCode = "ahiru_head"
            If cmb_DropTreasures.SelectedItem = "King of Bugs" Then DropTreasureCode = "loozy"
            If cmb_DropTreasures.SelectedItem = "Essence of Rage" Then DropTreasureCode = "teala_dia_a"
            If cmb_DropTreasures.SelectedItem = "Essence of Despair" Then DropTreasureCode = "teala_dia_b"
            If cmb_DropTreasures.SelectedItem = "Essence of True Love" Then DropTreasureCode = "teala_dia_c"
            If cmb_DropTreasures.SelectedItem = "Essence of Desire" Then DropTreasureCode = "teala_dia_d"
            If cmb_DropTreasures.SelectedItem = "Citrus Lump" Then DropTreasureCode = "dia_a_red"
            If cmb_DropTreasures.SelectedItem = "Behemoth Jaw" Then DropTreasureCode = "dia_a_blue"
            If cmb_DropTreasures.SelectedItem = "Anxious Sprout" Then DropTreasureCode = "dia_a_green"
            If cmb_DropTreasures.SelectedItem = "Implement of Toil" Then DropTreasureCode = "dia_b_red"
            If cmb_DropTreasures.SelectedItem = "Luck Wafer" Then DropTreasureCode = "dia_b_blue"
            If cmb_DropTreasures.SelectedItem = "Meat of Champions" Then DropTreasureCode = "dia_b_green"
            If cmb_DropTreasures.SelectedItem = "Talisman of Life" Then DropTreasureCode = "dia_c_red"
            If cmb_DropTreasures.SelectedItem = "Strife Monolith" Then DropTreasureCode = "dia_c_green"
            If cmb_DropTreasures.SelectedItem = "Boss Stone" Then DropTreasureCode = "dia_c_blue"
            If cmb_DropTreasures.SelectedItem = "Toxic Toadstool" Then DropTreasureCode = "kinoko_doku"
            If cmb_DropTreasures.SelectedItem = "Growshroom" Then DropTreasureCode = "kinoko_tubu"
            If cmb_DropTreasures.SelectedItem = "Indomitable CPU" Then DropTreasureCode = "sinkukan_b"
            If cmb_DropTreasures.SelectedItem = "Network Mainbrain" Then DropTreasureCode = "sinkukan_c"
            If cmb_DropTreasures.SelectedItem = "Repair Juggernaut" Then DropTreasureCode = "bolt_l"
            If cmb_DropTreasures.SelectedItem = "Exhausted Superstick" Then DropTreasureCode = "gum_tape_s"
            If cmb_DropTreasures.SelectedItem = "Pastry Wheel" Then DropTreasureCode = "baum_kuchen_s"
            If cmb_DropTreasures.SelectedItem = "Combustion Berry" Then DropTreasureCode = "ichigo_l"
            If cmb_DropTreasures.SelectedItem = "Imperative Cookie" Then DropTreasureCode = "cookie_m_l"
            If cmb_DropTreasures.SelectedItem = "Compelling Cookie" Then DropTreasureCode = "cookie_u"
            If cmb_DropTreasures.SelectedItem = "Impenetrable Cookie" Then DropTreasureCode = "cookie_u_l"
            If cmb_DropTreasures.SelectedItem = "Comfort Cookie" Then DropTreasureCode = "cookie_s"
            If cmb_DropTreasures.SelectedItem = "Succulent Mattress" Then DropTreasureCode = "cookie_s_l"
            If cmb_DropTreasures.SelectedItem = "Corpulent Nut" Then DropTreasureCode = "donguri_l"
            If cmb_DropTreasures.SelectedItem = "Alien Billboard" Then DropTreasureCode = "fire_helmet"
            If cmb_DropTreasures.SelectedItem = "Massage Girdle" Then DropTreasureCode = "nut_l"
            If cmb_DropTreasures.SelectedItem = "Crystallized Telepathy" Then DropTreasureCode = "be_dama_red_l"
            If cmb_DropTreasures.SelectedItem = "Crystallized Telekinesis" Then DropTreasureCode = "be_dama_yellow_l"
            If cmb_DropTreasures.SelectedItem = "Crystallized Clairvoyance" Then DropTreasureCode = "be_dama_blue_l"
            If cmb_DropTreasures.SelectedItem = "Eternal Emerald Eye" Then DropTreasureCode = "diamond_red_l"
            If cmb_DropTreasures.SelectedItem = "Tear Stone" Then DropTreasureCode = "diamond_blue_l"
            If cmb_DropTreasures.SelectedItem = "Crystal Clover" Then DropTreasureCode = "diamond_green_l"
            If cmb_DropTreasures.SelectedItem = "Danger Chime" Then DropTreasureCode = "bell_red"
            If cmb_DropTreasures.SelectedItem = "Sulking Antenna" Then DropTreasureCode = "bell_blue"
            If cmb_DropTreasures.SelectedItem = "Spouse Alert" Then DropTreasureCode = "bell_yellow"
            If cmb_DropTreasures.SelectedItem = "Master's Instrument" Then DropTreasureCode = "bane_red"
            If cmb_DropTreasures.SelectedItem = "Extreme Perspirator" Then DropTreasureCode = "bane_blue"
            If cmb_DropTreasures.SelectedItem = "Pilgrim Bulb" Then DropTreasureCode = "bane_yellow"
            If cmb_DropTreasures.SelectedItem = "Stone of Glory" Then DropTreasureCode = "juji_key_fc"
            If cmb_DropTreasures.SelectedItem = "Furious Adhesive" Then DropTreasureCode = "tape_red"
            If cmb_DropTreasures.SelectedItem = "Quenching Emblem" Then DropTreasureCode = "tape_yellow"
            If cmb_DropTreasures.SelectedItem = "Flame of Tomorrow" Then DropTreasureCode = "tape_blue"
            If cmb_DropTreasures.SelectedItem = "Love Nugget" Then DropTreasureCode = "leaf_normal"
            If cmb_DropTreasures.SelectedItem = "Child of the Earth" Then DropTreasureCode = "leaf_yellow"
            If cmb_DropTreasures.SelectedItem = "Disguised Delicacy" Then DropTreasureCode = "leaf_kare"
            If cmb_DropTreasures.SelectedItem = "Proton AA" Then DropTreasureCode = "denchi_3_red"
            If cmb_DropTreasures.SelectedItem = "Fuel Reservoir" Then DropTreasureCode = "denchi_3_black"
            If cmb_DropTreasures.SelectedItem = "Optical Illustration" Then DropTreasureCode = "denchi_2_red"
            If cmb_DropTreasures.SelectedItem = "Durable Energy Cell" Then DropTreasureCode = "denchi_2_black"
            If cmb_DropTreasures.SelectedItem = "Courage Reactor" Then DropTreasureCode = "denchi_1_red"
            If cmb_DropTreasures.SelectedItem = "Thirst Activator" Then DropTreasureCode = "denchi_1_black"
            If cmb_DropTreasures.SelectedItem = "Harmonic Synthesizer" Then DropTreasureCode = "castanets"
            If cmb_DropTreasures.SelectedItem = "Merciless Extractor" Then DropTreasureCode = "otama"
            If cmb_DropTreasures.SelectedItem = "Remembered Old Buddy" Then DropTreasureCode = "robot_head"
            If cmb_DropTreasures.SelectedItem = "Fond Gyro Block" Then DropTreasureCode = "j_block_red"
            If cmb_DropTreasures.SelectedItem = "Memorable Gyro Block" Then DropTreasureCode = "j_block_yellow"
            If cmb_DropTreasures.SelectedItem = "Lost Gyro Block" Then DropTreasureCode = "j_block_green"
            If cmb_DropTreasures.SelectedItem = "Favorite Gyro Block" Then DropTreasureCode = "j_block_blue"
            If cmb_DropTreasures.SelectedItem = "Treasured Gyro Block" Then DropTreasureCode = "j_block_white"
            If cmb_DropTreasures.SelectedItem = "Fortified Delicacy" Then DropTreasureCode = "akagai"
            If cmb_DropTreasures.SelectedItem = "Scrumptious Shell" Then DropTreasureCode = "hotate"
            If cmb_DropTreasures.SelectedItem = "Memorial Shell" Then DropTreasureCode = "sinjyu"
            If cmb_DropTreasures.SelectedItem = "Chance Totem" Then DropTreasureCode = "donutschoco_s"
            If cmb_DropTreasures.SelectedItem = "Dream Architect" Then DropTreasureCode = "donutsichigo_s"
            If cmb_DropTreasures.SelectedItem = "Spiny Alien Treat" Then DropTreasureCode = "donutswhite_s"
            If cmb_DropTreasures.SelectedItem = "Spirit Flogger" Then DropTreasureCode = "gear_silver"
            If cmb_DropTreasures.SelectedItem = "Mirrored Stage" Then DropTreasureCode = "compact_make"
            If cmb_DropTreasures.SelectedItem = "Enamel Buster" Then DropTreasureCode = "chocolate_l"
            If cmb_DropTreasures.SelectedItem = "Drought Ender" Then DropTreasureCode = "chocoichigo_l"
            If cmb_DropTreasures.SelectedItem = "White Goodness" Then DropTreasureCode = "chocowhite_l"
            If cmb_DropTreasures.SelectedItem = "Salivatrix" Then DropTreasureCode = "g_futa_kyodo"
            If cmb_DropTreasures.SelectedItem = "Creative Inspiration" Then DropTreasureCode = "g_futa_titiyas"
            If cmb_DropTreasures.SelectedItem = "Massive Lid" Then DropTreasureCode = "g_futa_kyusyu"
            If cmb_DropTreasures.SelectedItem = "Happiness Emblem" Then DropTreasureCode = "g_futa_sikoku"
            If cmb_DropTreasures.SelectedItem = "Survival Ointment" Then DropTreasureCode = "g_futa_kajiwara"
            If cmb_DropTreasures.SelectedItem = "Mysterious Remains" Then DropTreasureCode = "g_futa_koiwai"
            If cmb_DropTreasures.SelectedItem = "Dimensional Slicer" Then DropTreasureCode = "g_futa_hirosima"
            If cmb_DropTreasures.SelectedItem = "Yellow Taste Tyrant" Then DropTreasureCode = "g_futa_kyosin"
            If cmb_DropTreasures.SelectedItem = "Hypnotic Platter" Then DropTreasureCode = "g_futa_sakotani"
            If cmb_DropTreasures.SelectedItem = "Gherkin Gate" Then DropTreasureCode = "g_futa_daisen"
            If cmb_DropTreasures.SelectedItem = "Healing Cask" Then DropTreasureCode = "g_futa_hiruzen"
            If cmb_DropTreasures.SelectedItem = "Pondering Emblem" Then DropTreasureCode = "g_futa_kitaama"
            If cmb_DropTreasures.SelectedItem = "Activity Arouser" Then DropTreasureCode = "g_futa_nihonraku"
            If cmb_DropTreasures.SelectedItem = "Stringent Container" Then DropTreasureCode = "kan_maruha"
            If cmb_DropTreasures.SelectedItem = "Patience Tester" Then DropTreasureCode = "kan_nichiro"
            If cmb_DropTreasures.SelectedItem = "Endless Repository" Then DropTreasureCode = "kan_iwate"
            If cmb_DropTreasures.SelectedItem = "Fruit Guard" Then DropTreasureCode = "kan_kyokuyo"
            If cmb_DropTreasures.SelectedItem = "Nutrient Silo" Then DropTreasureCode = "kan_meidiya"
            If cmb_DropTreasures.SelectedItem = "Drone Supplies" Then DropTreasureCode = "kan_imuraya"
            If cmb_DropTreasures.SelectedItem = "Unknown Merit" Then DropTreasureCode = "wadou_kaichin"
            If cmb_DropTreasures.SelectedItem = "Seed of Greed" Then DropTreasureCode = "kuri"
            If cmb_DropTreasures.SelectedItem = "Heavy-Duty Magnetizer" Then DropTreasureCode = "uji_jisyaku"
            If cmb_DropTreasures.SelectedItem = "Air Brake" Then DropTreasureCode = "badminton"
            If cmb_DropTreasures.SelectedItem = "Hideous Victual" Then DropTreasureCode = "medama_yaki"
            If cmb_DropTreasures.SelectedItem = "Emperor Whistle" Then DropTreasureCode = "whistle"
            If cmb_DropTreasures.SelectedItem = "Brute Knuckles" Then DropTreasureCode = "fue_a"
            If cmb_DropTreasures.SelectedItem = "Dream Material" Then DropTreasureCode = "fue_b"
            If cmb_DropTreasures.SelectedItem = "Amplified Amplifier" Then DropTreasureCode = "fue_wide"
            If cmb_DropTreasures.SelectedItem = "Professional Noisemaker" Then DropTreasureCode = "fue_pullout"
            If cmb_DropTreasures.SelectedItem = "Stellar Orb" Then DropTreasureCode = "light_a"
            If cmb_DropTreasures.SelectedItem = "Justice Alloy" Then DropTreasureCode = "suit_powerup"
            If cmb_DropTreasures.SelectedItem = "Forged Courage" Then DropTreasureCode = "suit_fire"
            If cmb_DropTreasures.SelectedItem = "Repugnant Appendage" Then DropTreasureCode = "dashboots"
            If cmb_DropTreasures.SelectedItem = "Prototype Detector" Then DropTreasureCode = "radar_a"
            If cmb_DropTreasures.SelectedItem = "Five-man Napsack" Then DropTreasureCode = "radar_b"
            If cmb_DropTreasures.SelectedItem = "Spherical Atlas" Then DropTreasureCode = "map01"
            If cmb_DropTreasures.SelectedItem = "Geographic Projection" Then DropTreasureCode = "map02"
            If cmb_DropTreasures.SelectedItem = "The Key" Then DropTreasureCode = "key"

            DropTreasureCode = "_" & DropTreasureCode
        End If

        Dim EntityLabelLocation As String = "[Unknown] "
        Dim EntityLabelMethod As String = "[Unknown] "
        If lst_RegularEntitiesList.SelectedIndex > -1 Then

            Select Case lst_RegularEntitiesList.SelectedItem.ToString.Last
                Case "0"
                    EntityLabelLocation = "[A] "
                Case "1"
                    EntityLabelLocation = "[B] "
                Case "8"
                    EntityLabelLocation = "[C] "
                Case "6"
                    EntityLabelLocation = "[P] "
                Case "5"
                    EntityLabelLocation = "[H] "
                Case "9"
                    EntityLabelLocation = "[D] "
            End Select


            Select Case lst_RegularEntitiesList.SelectedItem.ToString.First
                Case "$"
                    EntityLabelMethod = "[$] "
                    Select Case lst_RegularEntitiesList.SelectedItem.ToString.Chars(1)
                        Case "2"
                            EntityLabelMethod = "[$2] "
                        Case "3"
                            EntityLabelMethod = "[$3] "
                        Case "4"
                            EntityLabelMethod = "[$4] "
                        Case "5"
                            EntityLabelMethod = "[$5] "
                    End Select
                Case <> "$"
                    EntityLabelMethod = "[N] "
            End Select
        End If
        Dim EntityCountPlaceholder As String = ""
        EntityCountPlaceholder = num_EntityCount.Value.ToString
        If cmb_EntitySpawnLocation.SelectedIndex = 5 Then
            lst_RegularEntitiesList.Items.Add(EntityMethod & EntityCodeName & DropTreasureCode & " " &
                                              EntityCountPlaceholder & vbCrLf & EntityLocation)
        Else
            lst_RegularEntitiesList.Items.Add(EntityMethod & EntityCodeName & DropTreasureCode & " " &
                                              EntityCountPlaceholder & num_EntityWeight.Value & vbCrLf & EntityLocation)
        End If
        If num_EntityWeight.Value > 0 Then
            lst_RegularEntitiesNormList.Items.Add(EntityLabelLocation & EntityLabelMethod & EntityNormalName & " x " & EntityCountPlaceholder & "")
            lst_RegularEntitiesCountList.Items.Add(EntityCountPlaceholder & " [weight=" & num_EntityWeight.Value & "]")
        Else
            lst_RegularEntitiesNormList.Items.Add(EntityLabelLocation & EntityLabelMethod & EntityNormalName & " x " & EntityCountPlaceholder)
            lst_RegularEntitiesCountList.Items.Add(EntityCountPlaceholder)
        End If



        EntityTotalCount += 1
        lbl_EntityTotalCount.Text = "Sets: " & EntityTotalCount



        EnterSublevelManager()
        EnterSublevelEntities()
        btn_AddEntity.Select()
    End Sub
    Private Sub btn_DeleteSelectedEntity_Click(sender As Object, e As EventArgs) Handles btn_DeleteSelectedEntity.Click
        If lst_RegularEntitiesList.SelectedIndex > -1 Then
            lst_RegularEntitiesList.Items.RemoveAt(lst_RegularEntitiesList.SelectedIndex)
            lst_RegularEntitiesCountList.Items.RemoveAt(lst_RegularEntitiesCountList.SelectedIndex)
            '' THE "NORM LIST" MUST ALWAYS BE REMOVED LAST!
            lst_RegularEntitiesNormList.Items.RemoveAt(lst_RegularEntitiesNormList.SelectedIndex)

            EntityTotalCount -= 1
            lbl_EntityTotalCount.Text = "Sets: " & EntityTotalCount
            If lst_RegularEntitiesList.Items.Count = 0 Then
                AllEntitiesDeleted = True
            End If

            EnterSublevelManager()
            EnterSublevelEntities()
            btn_DeleteSelectedEntity.Select()
        End If
    End Sub
    Private Sub btn_ClearEntities_Click(sender As Object, e As EventArgs) Handles btn_ClearEntities.Click
        If lst_RegularEntitiesList.Items.Count > 0 Then
            If MessageBox.Show("Are you sure you want to remove all entities from this sublevel?",
                               "Remove All Entities (Sublevel " & cmb_Sublevels.SelectedIndex + 1 & ")",
                               MessageBoxButtons.YesNo) = DialogResult.Yes Then
                lst_RegularEntitiesList.Items.Clear()
                lst_RegularEntitiesCountList.Items.Clear()
                '' THE "NORM LIST" MUST ALWAYS BE REMOVED LAST!
                lst_RegularEntitiesNormList.Items.Clear()
                AllEntitiesDeleted = True

                EntityTotalCount = 0
                lbl_EntityTotalCount.Text = "Sets: " & EntityTotalCount

                EnterSublevelManager()
                EnterSublevelEntities()

                btn_ClearEntities.Select()
            End If
        End If
    End Sub
    Private Sub btn_ChooseEntity_Click(sender As Object, e As EventArgs) Handles btn_ChooseEntity.Click
        EntityList.ShowDialog()
    End Sub
    Private Sub lst_RegularEntitiesNormList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_RegularEntitiesNormList.SelectedIndexChanged
        If lst_RegularEntitiesNormList.Items.Count > 1 Then
            If lst_RegularEntitiesNormList.SelectedIndex = 0 Then btn_MoveEntityUp.Enabled = False Else btn_MoveEntityUp.Enabled = True
            If lst_RegularEntitiesNormList.SelectedIndex = lst_RegularEntitiesNormList.Items.Count - 1 Then btn_MoveEntityDown.Enabled = False Else btn_MoveEntityDown.Enabled = True
        Else
            btn_MoveEntityDown.Enabled = False
            btn_MoveEntityUp.Enabled = False
        End If
        If lst_RegularEntitiesNormList.SelectedIndex = -1 Then
            btn_MoveEntityDown.Enabled = False
            btn_MoveEntityUp.Enabled = False
        End If
        If MovingEntity = False Then
            lst_RegularEntitiesList.SelectedIndex = lst_RegularEntitiesNormList.SelectedIndex
            lst_RegularEntitiesCountList.SelectedIndex = lst_RegularEntitiesNormList.SelectedIndex
        End If
    End Sub
    Public Sub ConvertInternalToNormal()
        Dim InternalEntitiyName As String = lst_RegularEntitiesList.SelectedItem
        InternalEntitiyName = InternalEntitiyName.Replace("$", "")
        Dim LetterCheck As Boolean = False
        If System.Text.RegularExpressions.Regex.IsMatch(InternalEntitiyName.Last, "^[A-Z ]+$") Then LetterCheck = True
        If System.Text.RegularExpressions.Regex.IsMatch(InternalEntitiyName.Last, "^[a-z ]+$") Then LetterCheck = True
        While LetterCheck = False
            InternalEntitiyName = InternalEntitiyName.TrimEnd(InternalEntitiyName.Last)
            If System.Text.RegularExpressions.Regex.IsMatch(InternalEntitiyName.Last, "^[A-Z ]+$") Then LetterCheck = True
            If System.Text.RegularExpressions.Regex.IsMatch(InternalEntitiyName.Last, "^[a-z ]+$") Then LetterCheck = True
        End While
        LetterCheck = False
        If System.Text.RegularExpressions.Regex.IsMatch(InternalEntitiyName.First, "^[A-Z ]+$") Then LetterCheck = True
        If System.Text.RegularExpressions.Regex.IsMatch(InternalEntitiyName.First, "^[a-z ]+$") Then LetterCheck = True
        While LetterCheck = False
            InternalEntitiyName = InternalEntitiyName.TrimStart(InternalEntitiyName.First)
            If System.Text.RegularExpressions.Regex.IsMatch(InternalEntitiyName.First, "^[A-Z ]+$") Then LetterCheck = True
            If System.Text.RegularExpressions.Regex.IsMatch(InternalEntitiyName.First, "^[a-z ]+$") Then LetterCheck = True
        End While
        EntityContainsDropTreasure = ""
        If InternalEntitiyName.Contains("_") Then
            If InternalEntitiyName.EndsWith("_l ") Then
                Dim CheckIfTreasure As String = InternalEntitiyName.Substring(0, InternalEntitiyName.IndexOf("_l"))
                If CheckIfTreasure.Contains("_") Then
                    EntityContainsDropTreasure = InternalEntitiyName
                    InternalEntitiyName = InternalEntitiyName.Substring(0, InternalEntitiyName.IndexOf("_"))
                    EntityDropTreasureInternalName = EntityContainsDropTreasure.Replace(InternalEntitiyName, "")
                End If
            ElseIf InternalEntitiyName.EndsWith("_s ") Then
                Dim CheckIfTreasure As String = InternalEntitiyName.Substring(0, InternalEntitiyName.IndexOf("_s"))
                If CheckIfTreasure.Contains("_") Then
                    EntityContainsDropTreasure = InternalEntitiyName
                    InternalEntitiyName = InternalEntitiyName.Substring(0, InternalEntitiyName.IndexOf("_"))
                    EntityDropTreasureInternalName = EntityContainsDropTreasure.Replace(InternalEntitiyName, "")
                End If
            Else
                EntityContainsDropTreasure = InternalEntitiyName
                InternalEntitiyName = InternalEntitiyName.Substring(0, InternalEntitiyName.IndexOf("_"))
                EntityDropTreasureInternalName = EntityContainsDropTreasure.Replace(InternalEntitiyName, "")
            End If
        End If
        If InternalEntitiyName > "" Then
            EntityNormNameList = "Unfound: " & InternalEntitiyName
        End If

        InternalEntitiyName = InternalEntitiyName.Replace(" ", "")

        '''''' REGULAR ENTITIES & BOSSES''''''
        If InternalEntitiyName = "ElecBug" Then EntityNormNameList = "Anode Beetle"
        If InternalEntitiyName = "ElecOtakara" Then EntityNormNameList = "Anode Dweevil"
        If InternalEntitiyName = "Fuefuki" Then EntityNormNameList = "Antenna Beetle"
        If InternalEntitiyName = "Fkabuto" Then EntityNormNameList = "Buried Armored Cannon Beetle Larva"
        If InternalEntitiyName = "Kabuto" Then EntityNormNameList = "Armored Cannon Beetle Larva"
        If InternalEntitiyName = "Damagumo" Then EntityNormNameList = "Beady Long Legs"
        If InternalEntitiyName = "PanModoki" Then EntityNormNameList = "Breadbug"
        If InternalEntitiyName = "PanHouse" Then EntityNormNameList = "Breadbug Nest"
        If InternalEntitiyName = "LeafChappy" Then EntityNormNameList = "Bulbmin"
        If InternalEntitiyName = "Baby" Then EntityNormNameList = "Bulborb Larva"
        If InternalEntitiyName = "Demon" Then EntityNormNameList = "Bumbling Snitchbug"
        If InternalEntitiyName = "SnakeCrow" Then EntityNormNameList = "Burrowing Snagret"
        If InternalEntitiyName = "BombSarai" Then EntityNormNameList = "Careening Dirigibug"
        If InternalEntitiyName = "WaterOtakara" Then EntityNormNameList = "Caustic Dweevil"
        If InternalEntitiyName = "Armor" Then EntityNormNameList = "Cloaking Burrow-nit"
        If InternalEntitiyName = "Hana" Then EntityNormNameList = "Creeping Chrysanthemum"
        If InternalEntitiyName = "Rkabuto" Then EntityNormNameList = "Decorated Cannon Beetle"
        If InternalEntitiyName = "Fart" Then EntityNormNameList = "Doodlebug"
        If InternalEntitiyName = "KumaKochappy" Then EntityNormNameList = "Dwarf Bulbear"
        If InternalEntitiyName = "BlueKochappy" Then EntityNormNameList = "Dwarf Orange Bulborb"
        If InternalEntitiyName = "Kochappy" Then EntityNormNameList = "Dwarf Red Bulborb"
        If InternalEntitiyName = "KingChappy" Then EntityNormNameList = "Emperor Bulblax"
        If InternalEntitiyName = "Queen" Then EntityNormNameList = "Empress Bulblax"
        If InternalEntitiyName = "UjiA" Then EntityNormNameList = "Female Sheargrub"
        If InternalEntitiyName = "Tank" Then EntityNormNameList = "Fiery Blowhog"
        If InternalEntitiyName = "FireChappy" Then EntityNormNameList = "Fiery Bulblax"
        If InternalEntitiyName = "FireOtakara" Then EntityNormNameList = "Fiery Dweevil"
        If InternalEntitiyName = "MiniHoudai" Then EntityNormNameList = "Gatling Groink"
        If InternalEntitiyName = "FminiHoudai" Then EntityNormNameList = "Tower Gatling Groink"
        If InternalEntitiyName = "OoPanModoki" Then EntityNormNameList = "Giant Breadbug"
        If InternalEntitiyName = "OniKurage" Then EntityNormNameList = "Greater Spotted Jellyfloat"
        If InternalEntitiyName = "YellowChappy" Then EntityNormNameList = "Hairy Bulborb"
        If InternalEntitiyName = "Jigumo" Then EntityNormNameList = "Hermit Crawmad"
        If InternalEntitiyName = "Qurione" Then EntityNormNameList = "Honeywisp"
        If InternalEntitiyName = "Kogane" Then EntityNormNameList = "Iridescent Flint Beetle"
        If InternalEntitiyName = "Wealthy" Then EntityNormNameList = "Iridescent Glint Beetle"
        If InternalEntitiyName = "Kurage" Then EntityNormNameList = "Lesser Spotted Jellyfloat"
        If InternalEntitiyName = "UjiB" Then EntityNormNameList = "Male Sheargrub"
        If InternalEntitiyName = "Houdai" Then EntityNormNameList = "Man-at-Legs"
        If InternalEntitiyName = "Miulin" Then EntityNormNameList = "Mamuta"
        If InternalEntitiyName = "TamagoMushi" Then EntityNormNameList = "Mitite"
        If InternalEntitiyName = "GasOtakara" Then EntityNormNameList = "Munge Dweevil"
        If InternalEntitiyName = "BlueChappy" Then EntityNormNameList = "Orange Bulborb"
        If InternalEntitiyName = "SnakeWhole" Then EntityNormNameList = "Pileated Snagret"
        If InternalEntitiyName = "Mar" Then EntityNormNameList = "Puffy Blowhog"
        If InternalEntitiyName = "BigFoot" Then EntityNormNameList = "Raging Long Legs"
        If InternalEntitiyName = "ImoMushi" Then EntityNormNameList = "Ravenous Whiskerpillar"
        If InternalEntitiyName = "Chappy" Then EntityNormNameList = "Red Bulborb"
        If InternalEntitiyName = "DangoMushi" Then EntityNormNameList = "Segmented Crawbster"
        If InternalEntitiyName = "Tobi" Then EntityNormNameList = "Shearwig"
        If InternalEntitiyName = "Sokkuri" Then EntityNormNameList = "Skitter Leaf"
        If InternalEntitiyName = "YellowKochappy" Then EntityNormNameList = "Snow Bulborb"
        If InternalEntitiyName = "KumaChappy" Then EntityNormNameList = "Spotty Bulbear"
        If InternalEntitiyName = "Sarai" Then EntityNormNameList = "Swooping Snitchbug"
        If InternalEntitiyName = "BigTreasure" Then EntityNormNameList = "Titan Dweevil"
        If InternalEntitiyName = "UmiMushiBlind" Then EntityNormNameList = "Toady Bloyster"
        If InternalEntitiyName = "UmiMushi" Then EntityNormNameList = "Ranging Bloyster"
        If InternalEntitiyName = "ShijimiChou" Then EntityNormNameList = "Unmarked Spectralids"
        If InternalEntitiyName = "BombOtakara" Then EntityNormNameList = "Volatile Dweevil"
        If InternalEntitiyName = "Catfish" Then EntityNormNameList = "Water Dumple"
        If InternalEntitiyName = "BlackMan" Then EntityNormNameList = "Waterwraith"
        If InternalEntitiyName = "Tyre" Then EntityNormNameList = "Waterwraith's Wheels Only"
        If InternalEntitiyName = "Wtank" Then EntityNormNameList = "Watery Blowhog"
        If InternalEntitiyName = "Hanachirashi" Then EntityNormNameList = "Withering Blowhog"
        If InternalEntitiyName = "Tadpole" Then EntityNormNameList = "Wogpole"
        If InternalEntitiyName = "MaroFrog" Then EntityNormNameList = "Wollywog"
        If InternalEntitiyName = "Frog" Then EntityNormNameList = "Yellow Wollywog"

        '''''' OBJECTS ''''''
        If InternalEntitiyName = "Bomb" Then EntityNormNameList = "Bomb-rock"
        If InternalEntitiyName = "Egg" Then EntityNormNameList = "Egg"
        If InternalEntitiyName = "ElecHiba" Then EntityNormNameList = "Electrical Wire"
        If InternalEntitiyName = "GasHiba" Then EntityNormNameList = "Gas Pipe"
        If InternalEntitiyName = "Hiba" Then EntityNormNameList = "Fire Geyser"
        If InternalEntitiyName = "JigumoHouse" Then EntityNormNameList = "Hermit Crawmad (Nest Only)"
        If InternalEntitiyName = "PanHouse" Then EntityNormNameList = "Breadbug (Nest Only)"
        If InternalEntitiyName = "Rock" Then EntityNormNameList = "Boulder"
        If InternalEntitiyName = "Stone" Then EntityNormNameList = "Lithopod Boulder"
        If InternalEntitiyName = "Tyre" Then EntityNormNameList = "Waterwraith Rollers"

        If InternalEntitiyName = "RandPom" Then EntityNormNameList = "Queen Candypop Bud"
        If InternalEntitiyName = "BluePom" Then EntityNormNameList = "Lapis Lazuli Candypop Bud"
        If InternalEntitiyName = "WhitePom" Then EntityNormNameList = "Ivory Candypop Bud"
        If InternalEntitiyName = "YellowPom" Then EntityNormNameList = "Golden Candypop Bud"
        If InternalEntitiyName = "RedPom" Then EntityNormNameList = "Crimson Candypop Bud"
        If InternalEntitiyName = "BlackPom" Then EntityNormNameList = "Violet Candypop Bud"

        If InternalEntitiyName = "Pelplant" Then EntityNormNameList = "2-P Battle: Pellet Posy"

        '''''' DECORATIONS ''''''
        If InternalEntitiyName = "Clover" Then EntityNormNameList = "Clover"
        If InternalEntitiyName = "HikariKinoko" Then EntityNormNameList = "Common Glowcap"
        If InternalEntitiyName = "Tanpopo" Then EntityNormNameList = "Dandelion"
        If InternalEntitiyName = "Zenmai" Then EntityNormNameList = "Fiddlehead"
        If InternalEntitiyName = "Ooinu_s" Then EntityNormNameList = "Small Figwort"
        If InternalEntitiyName = "KareOoinu_s" Then EntityNormNameList = "Small Dying Figwort"
        If InternalEntitiyName = "Ooinu_l" Then EntityNormNameList = "Large Figwort"
        If InternalEntitiyName = "KareOoinu_l" Then EntityNormNameList = "Large Dying Figwort"
        If InternalEntitiyName = "Nekojarashi" Then EntityNormNameList = "Foxtail"
        If InternalEntitiyName = "DaiodoGreen" Then EntityNormNameList = "Green Glowstem"
        If InternalEntitiyName = "DaiodoRed" Then EntityNormNameList = "Red Glowstem"
        If InternalEntitiyName = "Tukushi" Then EntityNormNameList = "Horsetail"
        If InternalEntitiyName = "Magaret" Then EntityNormNameList = "Magaret"
        If InternalEntitiyName = "Watage" Then EntityNormNameList = "Seeding Dandelion"
        If InternalEntitiyName = "Wakame_s" Then EntityNormNameList = "Small Shoot"
        If InternalEntitiyName = "Wakame_l" Then EntityNormNameList = "Large Shoot"
        If InternalEntitiyName = "Chiyogami" Then EntityNormNameList = "Chiyogami Paper"

        If EntityNormNameList = "Unfound: " & InternalEntitiyName Then
            MsgBox("Internal name was not found, and thus not translated.")
        End If
    End Sub
    Private Sub DecorationDetermination()
        If DecorationChecker = "Clover" Then EntityIsDecoration = True
        If DecorationChecker = "HikariKinoko" Then EntityIsDecoration = True
        If DecorationChecker = "Tanpopo" Then EntityIsDecoration = True
        If DecorationChecker = "Zenmai" Then EntityIsDecoration = True
        If DecorationChecker = "Ooinu_s" Then EntityIsDecoration = True
        If DecorationChecker = "KareOoinu_s" Then EntityIsDecoration = True
        If DecorationChecker = "Ooinu_l" Then EntityIsDecoration = True
        If DecorationChecker = "KareOoinu_l" Then EntityIsDecoration = True
        If DecorationChecker = "Nekojarashi" Then EntityIsDecoration = True
        If DecorationChecker = "DaiodoGreen" Then EntityIsDecoration = True
        If DecorationChecker = "DaiodoRed" Then EntityIsDecoration = True
        If DecorationChecker = "Tukushi" Then EntityIsDecoration = True
        If DecorationChecker = "Magaret" Then EntityIsDecoration = True
        If DecorationChecker = "Watage" Then EntityIsDecoration = True
        If DecorationChecker = "Wakame_s" Then EntityIsDecoration = True
        If DecorationChecker = "Wakame_l" Then EntityIsDecoration = True
        If DecorationChecker = "Chiyogami" Then EntityIsDecoration = True
    End Sub
    Private Sub tbp_SublevelEntities_Enter(sender As Object, e As EventArgs)

        EnterSublevelEntities()
        If cmb_Sublevels.SelectedIndex = -1 Then lst_RegularEntitiesNormList.Items.Clear()
    End Sub
    Private Sub EnterSublevelEntities()
        'The following cleans up the combobox to stay updated'''''''''''''''''''''''''''''''''''''''''''
        cmb_Sublevels.Items.Clear()
        Dim CurrentSublevelSelectedIndex As Integer = lst_Sublevels.SelectedIndex
        Dim i As Integer = 0
        lst_Sublevels.SelectedIndex = -1
        While i < lst_Sublevels.Items.Count
            i += 1
            lst_Sublevels.SelectedIndex += 1
            cmb_Sublevels.Items.Add(lst_Sublevels.SelectedItem)
        End While
        lst_Sublevels.SelectedIndex = CurrentSublevelSelectedIndex
        cmb_Sublevels.SelectedIndex = lst_Sublevels.SelectedIndex
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        If lst_Sublevels.SelectedIndex > -1 Then
            cmb_Sublevels.SelectedIndex = lst_Sublevels.SelectedIndex

            SelectSublevelThroughCombo()

        Else
            DeselectLists()
        End If

        If cmb_Sublevels.SelectedIndex > -1 Then
            btn_AddEntity.Enabled = True
            btn_DeleteSelectedEntity.Enabled = True
            btn_ClearEntities.Enabled = True
        Else
            btn_AddEntity.Enabled = False
            btn_DeleteSelectedEntity.Enabled = False
            btn_ClearEntities.Enabled = False
        End If
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        EnteringSubPropsFromEntities = True

    End Sub
    Private Sub tbp_SublevelManager_Enter(sender As Object, e As EventArgs) Handles tbp_SublevelManager.Enter
        EnterSublevelManager()
    End Sub

    Private Sub EnterSublevelManager()
        If EnteringSubPropsFromEntities = True Then
            Dim CurrentlySublevelSelected As Integer = lst_Sublevels.SelectedIndex
            cmb_Sublevels.SelectedIndex = -1
            cmb_Sublevels.SelectedIndex = -1
            lst_Sublevels.SelectedIndex = CurrentlySublevelSelected
        End If
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        If MovingEntity = False Then
            lst_RegularEntitiesNormList.Items.Clear()
        End If
        lst_RegularEntitiesList.Items.Clear()
        lst_RegularEntitiesCountList.Items.Clear()
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        AllEntitiesDeleted = False
        EnteringSubPropsFromEntities = False
    End Sub
    Private Sub cmb_Sublevels_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_Sublevels.SelectedIndexChanged
        btn_AddEntity.Text = "Add to Sublevel " & (cmb_Sublevels.SelectedIndex + 1).ToString
        SelectSublevelThroughCombo()
    End Sub
    Private Sub SelectSublevelThroughCombo()
        If lst_RegularEntitiesList.Items.Count > 0 Then
            lst_RegularEntitiesList.SelectedIndex = 0
            If lst_RegularEntitiesList.SelectedItem > " " Then
                lst_RegularEntitiesList.SelectedIndex = -1
                lst_RegularEntitiesCountList.SelectedIndex = -1
                Dim i As Integer = 0
                Dim item As String
                Dim countitem As String
                While i < lst_RegularEntitiesList.Items.Count
                    i += 1
                    lst_RegularEntitiesList.SelectedIndex += 1
                    lst_RegularEntitiesCountList.SelectedIndex += 1
                    If lst_RegularEntitiesList.SelectedIndex = lst_RegularEntitiesList.Items.Count - 1 Then
                        item = item & lst_RegularEntitiesList.SelectedItem
                        countitem = countitem & lst_RegularEntitiesCountList.SelectedItem
                        i = lst_RegularEntitiesList.Items.Count

                        'The following finds the sublevel identifier string in the selected regular entities listbox item
                        Dim RegularEntitiesID As String
                        Dim i2 As Integer = 0
                        While i2 < 999
                            i2 += 1
                            Dim item2 As Integer = lst_Sublevel_IDs.SelectedItem.ToString.Replace("S", "")
                            If item2 = i2 Then
                                RegularEntitiesID = "S" & i2

                                i2 = 999
                            End If
                        End While

                        Dim InsertedItem As Integer = lst_RegularEntities.SelectedIndex
                        Dim InsertedCountItem As Integer = lst_RegularEntities.SelectedIndex

                        'MsgBox(RegularEntitiesID & " - " & item)

                        lst_RegularEntities.Items.Insert(lst_RegularEntities.SelectedIndex, RegularEntitiesID & " - " & item)
                        lst_RegularEntities.Items.RemoveAt(lst_RegularEntities.SelectedIndex)
                        lst_RegularEntities.SelectedIndex = InsertedItem

                        lst_RegularEntitiesCounts.Items.Insert(lst_RegularEntitiesCounts.SelectedIndex, RegularEntitiesID & " - " & countitem)
                        lst_RegularEntitiesCounts.Items.RemoveAt(lst_RegularEntitiesCounts.SelectedIndex)
                        lst_RegularEntitiesCounts.SelectedIndex = InsertedCountItem

                    Else
                        item = item & lst_RegularEntitiesList.SelectedItem & ";"
                        countitem = countitem & lst_RegularEntitiesCountList.SelectedItem & ";"
                    End If
                End While
            Else
            End If
        Else
            'The following WILL ensure complete clearness if all entities are removed
            If lst_Sublevels.SelectedIndex = -1 Then

            Else
                If AllEntitiesDeleted = True Then

                    Dim InsertedItem As Integer = lst_RegularEntities.SelectedIndex
                    Dim InsertedCountItem As Integer = lst_RegularEntitiesCounts.SelectedIndex

                    lst_RegularEntities.Items.Insert(lst_RegularEntities.SelectedIndex, lst_Sublevel_IDs.SelectedItem & " - ")
                    lst_RegularEntities.Items.RemoveAt(lst_RegularEntities.SelectedIndex)
                    lst_RegularEntities.SelectedIndex = InsertedItem

                    lst_RegularEntitiesCounts.Items.Insert(lst_RegularEntitiesCounts.SelectedIndex, lst_Sublevel_IDs.SelectedItem & " - ")
                    lst_RegularEntitiesCounts.Items.RemoveAt(lst_RegularEntitiesCounts.SelectedIndex)
                    lst_RegularEntitiesCounts.SelectedIndex = InsertedCountItem

                    AllEntitiesDeleted = False
                End If
            End If
        End If


        lst_Sublevels.SelectedIndex = cmb_Sublevels.SelectedIndex

        lst_RegularEntitiesList.Items.Clear()
        lst_RegularEntitiesCountList.Items.Clear()
        lst_RegularEntitiesNormList.Items.Clear()

        Dim RegularEntitiesID2 As String
        Dim i3 As String = 0
        While i3 < 999
            i3 += 1
            Dim item As Integer = lst_Sublevel_IDs.SelectedItem.ToString.Replace("S", "")
            If item = i3 Then
                RegularEntitiesID2 = "S" & i3
                i3 = 999
            End If
        End While



        Dim RegularEntitiesWithoutID As String = lst_RegularEntities.SelectedItem.ToString.Replace(RegularEntitiesID2 & " - ", "")
        If RegularEntitiesWithoutID > "" Then

            'The following creates separated strings by finding semi-colons in a single string.
            Dim separators() As Char = {";"c}
            For Each item As String In lst_RegularEntities.SelectedItem.ToString.Split(
                   separators, StringSplitOptions.RemoveEmptyEntries)

                'The following finds the sublevel identifier string in the selected regular entities listbox item
                'Dim RegularEntitiesID As String
                'Dim i As Integer = 0
                'While i < 999
                '    i += 1
                '    If lst_RegularEntities.SelectedItem.ToString.StartsWith("S" & i) Then
                '        RegularEntitiesID = "S" & i
                '        i = 999
                '    End If
                'End While
                '
                'MsgBox(RegularEntitiesID2)
                'MsgBox(RegularEntitiesID)

                'The following removes the sublevel identifier string and then adds the remainder to the regular entities list listbox
                item = item.Replace(RegularEntitiesID2 & " - ", "").Replace(RegularEntitiesID2 & "
 - ", "").Replace(" - ", "")
                If item > "" Then
                    lst_RegularEntitiesList.Items.Add(item)
                End If
            Next item



            'Counts list:
            'The following creates separated strings by finding semi-colons in a single string.
            Dim separators2() As Char = {";"c}
            For Each item2 As String In lst_RegularEntitiesCounts.SelectedItem.ToString.Split(
                   separators2, StringSplitOptions.RemoveEmptyEntries)

                'The following finds the sublevel identifier string in the selected regular entities listbox item
                'Dim RegularEntitiesID As String
                'Dim i As Integer = 0
                'While i < 999
                '    i += 1
                '    If lst_RegularEntitiesCounts.SelectedItem.ToString.StartsWith("S" & i) Then
                '        RegularEntitiesID = "S" & i
                '        i = 999
                '    End If
                'End While

                'The following removes the sublevel identifier string and then adds the remainder to the regular entities list listbox
                item2 = item2.Replace(RegularEntitiesID2 & " - ", "").Replace(RegularEntitiesID2 & "
 - ", "").Replace(" - ", "")
                If item2 > "" Then
                    lst_RegularEntitiesCountList.Items.Add(item2)
                End If
            Next item2


            lst_RegularEntitiesList.SelectedIndex = -1
            lst_RegularEntitiesCountList.SelectedIndex = -1
            Dim i2 As Integer = 0
            While i2 < lst_RegularEntitiesList.Items.Count
                i2 += 1


                'MsgBox(lst_RegularEntitiesCountList.SelectedItem & vbCrLf & lst_RegularEntitiesList.SelectedItem)
                lst_RegularEntitiesList.SelectedIndex += 1
                'MsgBox(lst_RegularEntitiesList.SelectedItem)
                lst_RegularEntitiesCountList.SelectedIndex += 1
                ConvertInternalToNormal()

                Dim EntityLabelLocation As String = "[Unknown] "
                Select Case lst_RegularEntitiesList.SelectedItem.ToString.Last
                    Case "0"
                        EntityLabelLocation = "[A] "
                    Case "1"
                        EntityLabelLocation = "[B] "
                    Case "8"
                        EntityLabelLocation = "[C] "
                    Case "6"
                        EntityLabelLocation = "[P] "
                    Case "5"
                        EntityLabelLocation = "[H] "
                    Case "9"
                        EntityLabelLocation = "[D] "
                End Select

                Dim EntityLabelMethod As String = "[Unknown] "
                Select Case lst_RegularEntitiesList.SelectedItem.ToString.First
                    Case "$"
                        EntityLabelMethod = "[$] "
                        Select Case lst_RegularEntitiesList.SelectedItem.ToString.Chars(1)
                            Case "2"
                                EntityLabelMethod = "[$2] "
                            Case "3"
                                EntityLabelMethod = "[$3] "
                            Case "4"
                                EntityLabelMethod = "[$4] "
                            Case "5"
                                EntityLabelMethod = "[$5] "
                        End Select
                    Case <> "$"
                        EntityLabelMethod = "[N] "
                End Select
                If EntityDropTreasureInternalName > "" Then
                    EntityDropTreasureInternalName = EntityDropTreasureInternalName.Replace(" ", "")
                    EntityDropTreasureInternalName = EntityDropTreasureInternalName.Substring(1, EntityDropTreasureInternalName.Length - 1)
                End If

                ConvertInternalTreasureToEng()
                If EntityContainsDropTreasure > "" Then
                    If lst_RegularEntitiesCountList.SelectedItem.startswith("weight") Then
                        lst_RegularEntitiesNormList.Items.Add(EntityLabelLocation & EntityLabelMethod & EntityNormNameList & " (Drops " & EntityDropTreasureEngName & ")" & ", " & lst_RegularEntitiesCountList.SelectedItem)
                    Else
                        lst_RegularEntitiesNormList.Items.Add(EntityLabelLocation & EntityLabelMethod & EntityNormNameList & " (Drops " & EntityDropTreasureEngName & ")" & " x " & lst_RegularEntitiesCountList.SelectedItem)
                    End If
                Else
                    If lst_RegularEntitiesCountList.SelectedItem.startswith("weight") Then
                        lst_RegularEntitiesNormList.Items.Add(EntityLabelLocation & EntityLabelMethod & EntityNormNameList & ", " & lst_RegularEntitiesCountList.SelectedItem)
                    Else
                        lst_RegularEntitiesNormList.Items.Add(EntityLabelLocation & EntityLabelMethod & EntityNormNameList & " x " & lst_RegularEntitiesCountList.SelectedItem)
                    End If
                End If

            End While
            lst_RegularEntitiesList.SelectedIndex = -1
            lst_RegularEntitiesCountList.SelectedIndex = -1
        End If
        If cmb_Sublevels.SelectedIndex > -1 Then
            btn_AddEntity.Enabled = True
            btn_DeleteSelectedEntity.Enabled = True
            btn_ClearEntities.Enabled = True
        Else
            btn_AddEntity.Enabled = False
            btn_DeleteSelectedEntity.Enabled = False
            btn_ClearEntities.Enabled = False
        End If




        Dim ContainsWeightCheck As Boolean = False

        ''''The following just calculates the real total entity count for the selected sublevel section

        Dim SublevelEntityCounter As Integer = 0
        Dim TotalSublevelEntityCounter As Integer = 0
        Dim MinusTheDash As String = lst_RegularEntities.SelectedItem.ToString.Substring(0, lst_RegularEntities.SelectedItem.ToString.IndexOf("-") - 1)
        i3 = 0
        While i3 < 999
            i3 += 1
            If MinusTheDash.StartsWith("S" & i3) Then
                If MinusTheDash.EndsWith(i3.ToString.Chars(i3.ToString.Length - 1)) Then
                    RegularEntitiesID2 = "S" & i3
                    i3 = 999
                End If
            End If
        End While

        RegularEntitiesWithoutID = lst_RegularEntities.SelectedItem.ToString.Replace(RegularEntitiesID2 & " - ", "")
        If RegularEntitiesWithoutID > "" Then

            'The following creates separated strings by finding semi-colons in a single string.
            Dim separators() As Char = {";"c}
            For Each item As String In lst_RegularEntities.SelectedItem.ToString.Split(
                   separators, StringSplitOptions.RemoveEmptyEntries)

                'The following finds the sublevel identifier string in the selected regular entities listbox item
                Dim RegularEntitiesID As String
                Dim i As Integer = 0
                While i < 999
                    i += 1
                    If lst_RegularEntities.SelectedItem.ToString.StartsWith("S" & i) Then
                        RegularEntitiesID = "S" & i
                        i = 999

                    End If
                End While

                'The following removes the sublevel identifier string and then adds the remainder to the regular entities list listbox
                item = item.Replace(RegularEntitiesID & " - ", "").Replace(RegularEntitiesID & "
 - ", "").Replace(" - ", "")
                If item > "" Then
                    SublevelEntityCounter += 1
                End If
            Next item


            'Counts list:
            'The following creates separated strings by finding semi-colons in a single string.
            Dim separators2() As Char = {";"c}
            For Each item2 As String In lst_RegularEntitiesCounts.SelectedItem.ToString.Split(
                   separators2, StringSplitOptions.RemoveEmptyEntries)

                'The following finds the sublevel identifier string in the selected regular entities listbox item
                'Dim RegularEntitiesID As String
                'Dim i As Integer = 0
                'While i < 999
                '    i += 1
                '    If lst_RegularEntitiesCounts.SelectedItem.ToString.StartsWith("S" & i) Then
                '        RegularEntitiesID = "S" & i
                '        i = 999
                '
                '    End If
                'End While

                'The following removes the sublevel identifier string and then adds the remainder to the regular entities list listbox
                item2 = item2.Replace(MinusTheDash & " - ", "").Replace(MinusTheDash & "
 - ", "").Replace(" - ", "")
                If item2.Contains(" ") Then
                    item2 = item2.Substring(item2.IndexOf(" ") + 1, item2.Length - (item2.IndexOf(" ") + 1)).Replace(" ", "").Replace(" ", "")
                End If
                If item2 > "" Then
                    If item2.Contains("weight") Then
                        ContainsWeightCheck = True
                        If item2.Contains(",") Then
                            item2 = item2.Substring(0, item2.IndexOf(","))
                            TotalSublevelEntityCounter += item2
                        End If
                    Else
                        TotalSublevelEntityCounter += item2
                    End If
                End If
            Next item2
        End If

        If lst_Sublevels.SelectedIndex > -1 Then
            lbl_EntityCount.Text = "Entity Sets: " & SublevelEntityCounter
            EntityTotalCount = lst_RegularEntitiesList.Items.Count()
            lbl_EntityTotalCount.Text = "Sets: " & EntityTotalCount

            If ContainsWeightCheck = True Then
                lbl_TotalEntityCount.Text = "Total Entities: " & TotalSublevelEntityCounter & " + weighted entities"
                lbl_TotalEntityCountSubEnts.Text = "Total: " & TotalSublevelEntityCounter & " + weighted entities"
            Else
                lbl_TotalEntityCount.Text = "Total Entities: " & TotalSublevelEntityCounter
                lbl_TotalEntityCountSubEnts.Text = "Total: " & TotalSublevelEntityCounter
            End If
        End If

        lbl_SublevelID.Location = New Point((lbl_SelectedSublevelTitle.Location.X + (lbl_SelectedSublevelTitle.Width / 2)) - (lbl_SublevelID.Width / 2), lbl_SublevelID.Location.Y)
        lbl_TotalEntityCount.Location = New Point((lbl_SelectedSublevelTitle.Location.X + (lbl_SelectedSublevelTitle.Width / 2)) - (lbl_TotalEntityCount.Width / 2), lbl_TotalEntityCount.Location.Y)
        lbl_EntityCount.Location = New Point((lbl_SelectedSublevelTitle.Location.X + (lbl_SelectedSublevelTitle.Width / 2)) - (lbl_EntityCount.Width / 2), lbl_EntityCount.Location.Y)

        lst_RegularEntitiesNormList.SelectedIndex = -1
        Dim i9 As Integer = 0
        While i9 < lst_RegularEntitiesNormList.Items.Count
            lst_RegularEntitiesNormList.SelectedIndex += 1
            i9 += 1
            If lst_RegularEntitiesNormList.SelectedItem.ToString.Contains("x  [") Then
                lst_RegularEntitiesNormList.Items.Insert(lst_RegularEntitiesNormList.SelectedIndex, lst_RegularEntitiesNormList.SelectedItem.ToString.Replace("x  [", "["))
                lst_RegularEntitiesNormList.Items.RemoveAt(lst_RegularEntitiesNormList.SelectedIndex)
                lst_RegularEntitiesNormList.SelectedIndex = i9 - 1
            End If
        End While
        lst_RegularEntitiesNormList.SelectedIndex = -1
    End Sub
    Private Sub ConvertInternalTreasureToEng()
        If EntityDropTreasureInternalName = "ahiru" Then EntityDropTreasureEngName = "Rubber Ugly"
        If EntityDropTreasureInternalName = "apple" Then EntityDropTreasureEngName = "Insect Condo"
        If EntityDropTreasureInternalName = "apple_blue" Then EntityDropTreasureEngName = "Meat Satchel"
        If EntityDropTreasureInternalName = "bane" Then EntityDropTreasureEngName = "Coiled Launcher"
        If EntityDropTreasureInternalName = "baum_kuchen" Then EntityDropTreasureEngName = "Confection Hoop"
        If EntityDropTreasureInternalName = "be_dama_red" Then EntityDropTreasureEngName = "Omniscient Sphere"
        If EntityDropTreasureInternalName = "be_dama_yellow" Then EntityDropTreasureEngName = "Love Sphere"
        If EntityDropTreasureInternalName = "be_dama_blue" Then EntityDropTreasureEngName = "Mirth Sphere"
        If EntityDropTreasureInternalName = "bell" Then EntityDropTreasureEngName = "Maternal Sculpture"
        If EntityDropTreasureInternalName = "bey_goma" Then EntityDropTreasureEngName = "Stupendous Lens"
        If EntityDropTreasureInternalName = "bird_hane" Then EntityDropTreasureEngName = "Leviathan Feather"
        If EntityDropTreasureInternalName = "bolt" Then EntityDropTreasureEngName = "Superstrong Stabilizer"
        If EntityDropTreasureInternalName = "channel" Then EntityDropTreasureEngName = "Space Wave Receiver"
        If EntityDropTreasureInternalName = "chess_king_black" Then EntityDropTreasureEngName = "Joy Receptacle"
        If EntityDropTreasureInternalName = "chess_king_white" Then EntityDropTreasureEngName = "Worthless Statue"
        If EntityDropTreasureInternalName = "chess_queen_black" Then EntityDropTreasureEngName = "Priceless Statue"
        If EntityDropTreasureInternalName = "chess_queen_white" Then EntityDropTreasureEngName = "Triple Sugar Threat"
        If EntityDropTreasureInternalName = "chocolate" Then EntityDropTreasureEngName = "King of Sweets"
        If EntityDropTreasureInternalName = "chocoichigo" Then EntityDropTreasureEngName = "Diet Doomer"
        If EntityDropTreasureInternalName = "chocowhite" Then EntityDropTreasureEngName = "Pale Passion"
        If EntityDropTreasureInternalName = "compact" Then EntityDropTreasureEngName = "Boom Cone"
        If EntityDropTreasureInternalName = "cookie" Then EntityDropTreasureEngName = "Bug Bait"
        If EntityDropTreasureInternalName = "creap" Then EntityDropTreasureEngName = "Milk Tub"
        If EntityDropTreasureInternalName = "diamond_red" Then EntityDropTreasureEngName = "Petrified Heart"
        If EntityDropTreasureInternalName = "diamond_blue" Then EntityDropTreasureEngName = "Regal Diamond"
        If EntityDropTreasureInternalName = "diamond_green" Then EntityDropTreasureEngName = "Princess Pearl"
        If EntityDropTreasureInternalName = "doll" Then EntityDropTreasureEngName = "Silencer"
        If EntityDropTreasureInternalName = "donguri" Then EntityDropTreasureEngName = "Armored Nut"
        If EntityDropTreasureInternalName = "donutschoco" Then EntityDropTreasureEngName = "Chocolate Cushion"
        If EntityDropTreasureInternalName = "donutsichigo" Then EntityDropTreasureEngName = "Sweet Dreamer"
        If EntityDropTreasureInternalName = "donutswhite" Then EntityDropTreasureEngName = "Cosmic Archive"
        If EntityDropTreasureInternalName = "flower_red" Then EntityDropTreasureEngName = "Cupid's Grenade"
        If EntityDropTreasureInternalName = "flower_blue" Then EntityDropTreasureEngName = "Science Project"
        If EntityDropTreasureInternalName = "toy_gentle" Then EntityDropTreasureEngName = "Manual Honer"
        If EntityDropTreasureInternalName = "toy_lady" Then EntityDropTreasureEngName = "Broken Food Master"
        If EntityDropTreasureInternalName = "toy_dog" Then EntityDropTreasureEngName = "Sud Generator"
        If EntityDropTreasureInternalName = "toy_cat" Then EntityDropTreasureEngName = "Wiggle Noggin"
        If EntityDropTreasureInternalName = "gear" Then EntityDropTreasureEngName = "Omega Flywheel"
        If EntityDropTreasureInternalName = "gold_medal" Then EntityDropTreasureEngName = "Lustrous Element"
        If EntityDropTreasureInternalName = "gum_tape" Then EntityDropTreasureEngName = "Superstick Textile"
        If EntityDropTreasureInternalName = "halloween" Then EntityDropTreasureEngName = "Possessed Squash"
        If EntityDropTreasureInternalName = "haniwa" Then EntityDropTreasureEngName = "Gyroid Bust"
        If EntityDropTreasureInternalName = "ichigo" Then EntityDropTreasureEngName = "Sunseed Berry"
        If EntityDropTreasureInternalName = "juji_key" Then EntityDropTreasureEngName = "Glee Spinner"
        If EntityDropTreasureInternalName = "kan" Then EntityDropTreasureEngName = "Decorative Goo"
        If EntityDropTreasureInternalName = "kinoko" Then EntityDropTreasureEngName = "Anti-hiccup Fungus"
        If EntityDropTreasureInternalName = "kouseki_suisyou" Then EntityDropTreasureEngName = "Crystal King"
        If EntityDropTreasureInternalName = "kumakibori" Then EntityDropTreasureEngName = "Fossilized Ursidae"
        If EntityDropTreasureInternalName = "locket" Then EntityDropTreasureEngName = "Time Capsule"
        If EntityDropTreasureInternalName = "makigai" Then EntityDropTreasureEngName = "Olimarnite Shell"
        If EntityDropTreasureInternalName = "matu_bokkuri" Then EntityDropTreasureEngName = "Conifer Spire"
        If EntityDropTreasureInternalName = "milk_cap" Then EntityDropTreasureEngName = "Abstract Masterpiece"
        If EntityDropTreasureInternalName = "momiji_normal" Then EntityDropTreasureEngName = "Arboreal Frippery"
        If EntityDropTreasureInternalName = "momiji_kare" Then EntityDropTreasureEngName = "Onion Replica"
        If EntityDropTreasureInternalName = "momiji_red" Then EntityDropTreasureEngName = "Infernal Vegetable"
        If EntityDropTreasureInternalName = "nut" Then EntityDropTreasureEngName = "Adamantine Girdle"
        If EntityDropTreasureInternalName = "tatebue" Then EntityDropTreasureEngName = "Directory of Destiny"
        If EntityDropTreasureInternalName = "saru_head" Then EntityDropTreasureEngName = "Colossal Fossil"
        If EntityDropTreasureInternalName = "sensya" Then EntityDropTreasureEngName = "Invigorator"
        If EntityDropTreasureInternalName = "sinkukan" Then EntityDropTreasureEngName = "Vacuum Processor"
        If EntityDropTreasureInternalName = "silver_medal" Then EntityDropTreasureEngName = "Mirrored Element"
        If EntityDropTreasureInternalName = "tel_dial" Then EntityDropTreasureEngName = "Nouveau Table"
        If EntityDropTreasureInternalName = "toy_ring_a_red" Then EntityDropTreasureEngName = "Pink Menace"
        If EntityDropTreasureInternalName = "toy_ring_a_blue" Then EntityDropTreasureEngName = "Frosty Bauble"
        If EntityDropTreasureInternalName = "toy_ring_a_green" Then EntityDropTreasureEngName = "Gemstar Husband"
        If EntityDropTreasureInternalName = "toy_ring_b_red" Then EntityDropTreasureEngName = "Gemstar Wife"
        If EntityDropTreasureInternalName = "toy_ring_b_blue" Then EntityDropTreasureEngName = "Universal Com"
        If EntityDropTreasureInternalName = "toy_ring_b_green" Then EntityDropTreasureEngName = "Joyless Jewel"
        If EntityDropTreasureInternalName = "toy_ring_c_red" Then EntityDropTreasureEngName = "Fleeting Art Form"
        If EntityDropTreasureInternalName = "toy_ring_c_green" Then EntityDropTreasureEngName = "Innocence Lost"
        If EntityDropTreasureInternalName = "toy_ring_c_blue" Then EntityDropTreasureEngName = "Icon of Progress"
        If EntityDropTreasureInternalName = "toy_teala" Then EntityDropTreasureEngName = "Unspeakable Wonder"
        If EntityDropTreasureInternalName = "turi_uki" Then EntityDropTreasureEngName = "Aquatic Mine"
        If EntityDropTreasureInternalName = "watch" Then EntityDropTreasureEngName = "Temporal Mechanism"
        If EntityDropTreasureInternalName = "Xmas_item" Then EntityDropTreasureEngName = "Essential Furnishing"
        If EntityDropTreasureInternalName = "yoyo_red" Then EntityDropTreasureEngName = "Flame Tiller"
        If EntityDropTreasureInternalName = "yoyo_yellow" Then EntityDropTreasureEngName = "Doomsday Apparatus"
        If EntityDropTreasureInternalName = "yoyo_blue" Then EntityDropTreasureEngName = "Impediment Scourge"
        If EntityDropTreasureInternalName = "flask" Then EntityDropTreasureEngName = "Future Orb"
        If EntityDropTreasureInternalName = "elec" Then EntityDropTreasureEngName = "Shock Therapist"
        If EntityDropTreasureInternalName = "fire" Then EntityDropTreasureEngName = "Flare Cannon"
        If EntityDropTreasureInternalName = "gas" Then EntityDropTreasureEngName = "Comedy Bomb"
        If EntityDropTreasureInternalName = "water" Then EntityDropTreasureEngName = "Monster Pump"
        If EntityDropTreasureInternalName = "mojiban" Then EntityDropTreasureEngName = "Mystical Disc"
        If EntityDropTreasureInternalName = "futa_a_gold" Then EntityDropTreasureEngName = "Vorpal Platter"
        If EntityDropTreasureInternalName = "futa_a_silver" Then EntityDropTreasureEngName = "Taste Sensation"
        If EntityDropTreasureInternalName = "kan_b_gold" Then EntityDropTreasureEngName = "Lip Service"
        If EntityDropTreasureInternalName = "kan_b_silver" Then EntityDropTreasureEngName = "Utter Scrap"
        If EntityDropTreasureInternalName = "ahiru_head" Then EntityDropTreasureEngName = "Paradoxical Enigma"
        If EntityDropTreasureInternalName = "loozy" Then EntityDropTreasureEngName = "King of Bugs"
        If EntityDropTreasureInternalName = "teala_dia_a" Then EntityDropTreasureEngName = "Essence of Rage"
        If EntityDropTreasureInternalName = "teala_dia_b" Then EntityDropTreasureEngName = "Essence of Despair"
        If EntityDropTreasureInternalName = "teala_dia_c" Then EntityDropTreasureEngName = "Essence of True Love"
        If EntityDropTreasureInternalName = "teala_dia_d" Then EntityDropTreasureEngName = "Essence of Desire"
        If EntityDropTreasureInternalName = "dia_a_red" Then EntityDropTreasureEngName = "Citrus Lump"
        If EntityDropTreasureInternalName = "dia_a_blue" Then EntityDropTreasureEngName = "Behemoth Jaw"
        If EntityDropTreasureInternalName = "dia_a_green" Then EntityDropTreasureEngName = "Anxious Sprout"
        If EntityDropTreasureInternalName = "dia_b_red" Then EntityDropTreasureEngName = "Implement of Toil"
        If EntityDropTreasureInternalName = "dia_b_blue" Then EntityDropTreasureEngName = "Luck Wafer"
        If EntityDropTreasureInternalName = "dia_b_green" Then EntityDropTreasureEngName = "Meat of Champions"
        If EntityDropTreasureInternalName = "dia_c_red" Then EntityDropTreasureEngName = "Talisman of Life"
        If EntityDropTreasureInternalName = "dia_c_green" Then EntityDropTreasureEngName = "Strife Monolith"
        If EntityDropTreasureInternalName = "dia_c_blue" Then EntityDropTreasureEngName = "Boss Stone"
        If EntityDropTreasureInternalName = "kinoko_doku" Then EntityDropTreasureEngName = "Toxic Toadstool"
        If EntityDropTreasureInternalName = "kinoko_tubu" Then EntityDropTreasureEngName = "Growshroom"
        If EntityDropTreasureInternalName = "sinkukan_b" Then EntityDropTreasureEngName = "Indomitable CPU"
        If EntityDropTreasureInternalName = "sinkukan_c" Then EntityDropTreasureEngName = "Network Mainbrain"
        If EntityDropTreasureInternalName = "bolt_l" Then EntityDropTreasureEngName = "Repair Juggernaut"
        If EntityDropTreasureInternalName = "gum_tape_s" Then EntityDropTreasureEngName = "Exhausted Superstick"
        If EntityDropTreasureInternalName = "baum_kuchen_s" Then EntityDropTreasureEngName = "Pastry Wheel"
        If EntityDropTreasureInternalName = "ichigo_l" Then EntityDropTreasureEngName = "Combustion Berry"
        If EntityDropTreasureInternalName = "cookie_m_l" Then EntityDropTreasureEngName = "Imperative Cookie"
        If EntityDropTreasureInternalName = "cookie_u" Then EntityDropTreasureEngName = "Compelling Cookie"
        If EntityDropTreasureInternalName = "cookie_u_l" Then EntityDropTreasureEngName = "Impenetrable Cookie"
        If EntityDropTreasureInternalName = "cookie_s" Then EntityDropTreasureEngName = "Comfort Cookie"
        If EntityDropTreasureInternalName = "cookie_s_l" Then EntityDropTreasureEngName = "Succulent Mattress"
        If EntityDropTreasureInternalName = "donguri_l" Then EntityDropTreasureEngName = "Corpulent Nut"
        If EntityDropTreasureInternalName = "fire_helmet" Then EntityDropTreasureEngName = "Alien Billboard"
        If EntityDropTreasureInternalName = "nut_l" Then EntityDropTreasureEngName = "Massage Girdle"
        If EntityDropTreasureInternalName = "be_dama_red_l" Then EntityDropTreasureEngName = "Crystallized Telepathy"
        If EntityDropTreasureInternalName = "be_dama_yellow_l" Then EntityDropTreasureEngName = "Crystallized Telekinesis"
        If EntityDropTreasureInternalName = "be_dama_blue_l" Then EntityDropTreasureEngName = "Crystallized Clairvoyance"
        If EntityDropTreasureInternalName = "diamond_red_l" Then EntityDropTreasureEngName = "Eternal Emerald Eye"
        If EntityDropTreasureInternalName = "diamond_blue_l" Then EntityDropTreasureEngName = "Tear Stone"
        If EntityDropTreasureInternalName = "diamond_green_l" Then EntityDropTreasureEngName = "Crystal Clover"
        If EntityDropTreasureInternalName = "bell_red" Then EntityDropTreasureEngName = "Danger Chime"
        If EntityDropTreasureInternalName = "bell_blue" Then EntityDropTreasureEngName = "Sulking Antenna"
        If EntityDropTreasureInternalName = "bell_yellow" Then EntityDropTreasureEngName = "Spouse Alert"
        If EntityDropTreasureInternalName = "bane_red" Then EntityDropTreasureEngName = "Master's Instrument"
        If EntityDropTreasureInternalName = "bane_blue" Then EntityDropTreasureEngName = "Extreme Perspirator"
        If EntityDropTreasureInternalName = "bane_yellow" Then EntityDropTreasureEngName = "Pilgrim Bulb"
        If EntityDropTreasureInternalName = "juji_key_fc" Then EntityDropTreasureEngName = "Stone of Glory"
        If EntityDropTreasureInternalName = "tape_red" Then EntityDropTreasureEngName = "Furious Adhesive"
        If EntityDropTreasureInternalName = "tape_yellow" Then EntityDropTreasureEngName = "Quenching Emblem"
        If EntityDropTreasureInternalName = "tape_blue" Then EntityDropTreasureEngName = "Flame of Tomorrow"
        If EntityDropTreasureInternalName = "leaf_normal" Then EntityDropTreasureEngName = "Love Nugget"
        If EntityDropTreasureInternalName = "leaf_yellow" Then EntityDropTreasureEngName = "Child of the Earth"
        If EntityDropTreasureInternalName = "leaf_kare" Then EntityDropTreasureEngName = "Disguised Delicacy"
        If EntityDropTreasureInternalName = "denchi_3_red" Then EntityDropTreasureEngName = "Proton AA"
        If EntityDropTreasureInternalName = "denchi_3_black" Then EntityDropTreasureEngName = "Fuel Reservoir"
        If EntityDropTreasureInternalName = "denchi_2_red" Then EntityDropTreasureEngName = "Optical Illustration"
        If EntityDropTreasureInternalName = "denchi_2_black" Then EntityDropTreasureEngName = "Durable Energy Cell"
        If EntityDropTreasureInternalName = "denchi_1_red" Then EntityDropTreasureEngName = "Courage Reactor"
        If EntityDropTreasureInternalName = "denchi_1_black" Then EntityDropTreasureEngName = "Thirst Activator"
        If EntityDropTreasureInternalName = "castanets" Then EntityDropTreasureEngName = "Harmonic Synthesizer"
        If EntityDropTreasureInternalName = "otama" Then EntityDropTreasureEngName = "Merciless Extractor"
        If EntityDropTreasureInternalName = "robot_head" Then EntityDropTreasureEngName = "Remembered Old Buddy"
        If EntityDropTreasureInternalName = "j_block_red" Then EntityDropTreasureEngName = "Fond Gyro Block"
        If EntityDropTreasureInternalName = "j_block_yellow" Then EntityDropTreasureEngName = "Memorable Gyro Block"
        If EntityDropTreasureInternalName = "j_block_green" Then EntityDropTreasureEngName = "Lost Gyro Block"
        If EntityDropTreasureInternalName = "j_block_blue" Then EntityDropTreasureEngName = "Favorite Gyro Block"
        If EntityDropTreasureInternalName = "j_block_white" Then EntityDropTreasureEngName = "Treasured Gyro Block"
        If EntityDropTreasureInternalName = "akagai" Then EntityDropTreasureEngName = "Fortified Delicacy"
        If EntityDropTreasureInternalName = "hotate" Then EntityDropTreasureEngName = "Scrumptious Shell"
        If EntityDropTreasureInternalName = "sinjyu" Then EntityDropTreasureEngName = "Memorial Shell"
        If EntityDropTreasureInternalName = "donutschoco_s" Then EntityDropTreasureEngName = "Chance Totem"
        If EntityDropTreasureInternalName = "donutsichigo_s" Then EntityDropTreasureEngName = "Dream Architect"
        If EntityDropTreasureInternalName = "donutswhite_s" Then EntityDropTreasureEngName = "Spiny Alien Treat"
        If EntityDropTreasureInternalName = "gear_silver" Then EntityDropTreasureEngName = "Spirit Flogger"
        If EntityDropTreasureInternalName = "compact_make" Then EntityDropTreasureEngName = "Mirrored Stage"
        If EntityDropTreasureInternalName = "chocolate_l" Then EntityDropTreasureEngName = "Enamel Buster"
        If EntityDropTreasureInternalName = "chocoichigo_l" Then EntityDropTreasureEngName = "Drought Ender"
        If EntityDropTreasureInternalName = "chocowhite_l" Then EntityDropTreasureEngName = "White Goodness"
        If EntityDropTreasureInternalName = "g_futa_kyodo" Then EntityDropTreasureEngName = "Salivatrix"
        If EntityDropTreasureInternalName = "g_futa_titiyas" Then EntityDropTreasureEngName = "Creative Inspiration"
        If EntityDropTreasureInternalName = "g_futa_kyusyu" Then EntityDropTreasureEngName = "Massive Lid"
        If EntityDropTreasureInternalName = "g_futa_sikoku" Then EntityDropTreasureEngName = "Happiness Emblem"
        If EntityDropTreasureInternalName = "g_futa_kajiwara" Then EntityDropTreasureEngName = "Survival Ointment"
        If EntityDropTreasureInternalName = "g_futa_koiwai" Then EntityDropTreasureEngName = "Mysterious Remains"
        If EntityDropTreasureInternalName = "g_futa_hirosima" Then EntityDropTreasureEngName = "Dimensional Slicer"
        If EntityDropTreasureInternalName = "g_futa_kyosin" Then EntityDropTreasureEngName = "Yellow Taste Tyrant"
        If EntityDropTreasureInternalName = "g_futa_sakotani" Then EntityDropTreasureEngName = "Hypnotic Platter"
        If EntityDropTreasureInternalName = "g_futa_daisen" Then EntityDropTreasureEngName = "Gherkin Gate"
        If EntityDropTreasureInternalName = "g_futa_hiruzen" Then EntityDropTreasureEngName = "Healing Cask"
        If EntityDropTreasureInternalName = "g_futa_kitaama" Then EntityDropTreasureEngName = "Pondering Emblem"
        If EntityDropTreasureInternalName = "g_futa_nihonraku" Then EntityDropTreasureEngName = "Activity Arouser"
        If EntityDropTreasureInternalName = "kan_maruha" Then EntityDropTreasureEngName = "Stringent Container"
        If EntityDropTreasureInternalName = "kan_nichiro" Then EntityDropTreasureEngName = "Patience Tester"
        If EntityDropTreasureInternalName = "kan_iwate" Then EntityDropTreasureEngName = "Endless Repository"
        If EntityDropTreasureInternalName = "kan_kyokuyo" Then EntityDropTreasureEngName = "Fruit Guard"
        If EntityDropTreasureInternalName = "kan_meidiya" Then EntityDropTreasureEngName = "Nutrient Silo"
        If EntityDropTreasureInternalName = "kan_imuraya" Then EntityDropTreasureEngName = "Drone Supplies"
        If EntityDropTreasureInternalName = "wadou_kaichin" Then EntityDropTreasureEngName = "Unknown Merit"
        If EntityDropTreasureInternalName = "kuri" Then EntityDropTreasureEngName = "Seed of Greed"
        If EntityDropTreasureInternalName = "uji_jisyaku" Then EntityDropTreasureEngName = "Heavy-Duty Magnetizer"
        If EntityDropTreasureInternalName = "badminton" Then EntityDropTreasureEngName = "Air Brake"
        If EntityDropTreasureInternalName = "medama_yaki" Then EntityDropTreasureEngName = "Hideous Victual"
        If EntityDropTreasureInternalName = "whistle" Then EntityDropTreasureEngName = "Emperor Whistle"
        If EntityDropTreasureInternalName = "fue_a" Then EntityDropTreasureEngName = "Brute Knuckles"
        If EntityDropTreasureInternalName = "fue_b" Then EntityDropTreasureEngName = "Dream Material"
        If EntityDropTreasureInternalName = "fue_wide" Then EntityDropTreasureEngName = "Amplified Amplifier"
        If EntityDropTreasureInternalName = "fue_pullout" Then EntityDropTreasureEngName = "Professional Noisemaker"
        If EntityDropTreasureInternalName = "light_a" Then EntityDropTreasureEngName = "Stellar Orb"
        If EntityDropTreasureInternalName = "suit_powerup" Then EntityDropTreasureEngName = "Justice Alloy"
        If EntityDropTreasureInternalName = "suit_fire" Then EntityDropTreasureEngName = "Forged Courage"
        If EntityDropTreasureInternalName = "dashboots" Then EntityDropTreasureEngName = "Repugnant Appendage"
        If EntityDropTreasureInternalName = "radar_a" Then EntityDropTreasureEngName = "Prototype Detector"
        If EntityDropTreasureInternalName = "radar_b" Then EntityDropTreasureEngName = "Five-man Napsack"
        If EntityDropTreasureInternalName = "map" Then EntityDropTreasureEngName = "Spherical Atlas"
        If EntityDropTreasureInternalName = "map02" Then EntityDropTreasureEngName = "Geographic Projection"
        If EntityDropTreasureInternalName = "key" Then EntityDropTreasureEngName = "The Key"
    End Sub
    Private Sub btn_SublevelProperties_Click(sender As Object, e As EventArgs) Handles btn_SublevelProperties.Click
        SublevelProperties.SetDesktopLocation(Me.Location.X + ((Me.Width / 2) - SublevelProperties.Width / 2), Me.Location.Y + ((Me.Height / 2) - SublevelProperties.Height / 2))
        SublevelProperties.ShowDialog()
    End Sub
    Public Sub SaveData()
        Dim VersionCode As String = "sjhds87adhshf8afhuDs9fys87df6sd5f7udhf8s93hj334jk"
        Dim ListSublevels As String
        Dim i As Integer = 0
        lst_Sublevels.SelectedIndex = -1
        While i < lst_Sublevels.Items.Count
            i += 1
            lst_Sublevels.SelectedIndex += 1
            If i = 1 Then
                ListSublevels = lst_Sublevels.SelectedItem
            Else
                ListSublevels = ListSublevels & "^" & lst_Sublevels.SelectedItem
            End If
        End While

        Dim ListSublevelIDs As String
        i = 0
        lst_Sublevel_IDs.SelectedIndex = -1
        While i < lst_Sublevel_IDs.Items.Count
            i += 1
            lst_Sublevel_IDs.SelectedIndex += 1
            If i = 1 Then
                ListSublevelIDs = "{1" & lst_Sublevel_IDs.SelectedItem
            Else
                ListSublevelIDs = ListSublevelIDs & "^" & lst_Sublevel_IDs.SelectedItem
            End If
        End While

        Dim ListSublevelNames As String
        i = 0
        lst_SublevelNames.SelectedIndex = -1
        While i < lst_SublevelNames.Items.Count
            i += 1
            lst_SublevelNames.SelectedIndex += 1
            If i = 1 Then
                ListSublevelNames = "{2" & lst_SublevelNames.SelectedItem
            Else
                ListSublevelNames = ListSublevelNames & "^" & lst_SublevelNames.SelectedItem
            End If
        End While

        Dim ListRegularEntities As String
        i = 0
        lst_RegularEntities.SelectedIndex = -1
        While i < lst_RegularEntities.Items.Count
            i += 1
            lst_RegularEntities.SelectedIndex += 1
            If i = 1 Then
                ListRegularEntities = "{3" & lst_RegularEntities.SelectedItem
            Else
                ListRegularEntities = ListRegularEntities & "^" & lst_RegularEntities.SelectedItem
            End If
        End While

        Dim ListRegularEntitiesCounts As String
        i = 0
        lst_RegularEntitiesCounts.SelectedIndex = -1
        While i < lst_RegularEntitiesCounts.Items.Count
            i += 1
            lst_RegularEntitiesCounts.SelectedIndex += 1
            If i = 1 Then
                ListRegularEntitiesCounts = "{4" & lst_RegularEntitiesCounts.SelectedItem
            Else
                ListRegularEntitiesCounts = ListRegularEntitiesCounts & "^" & lst_RegularEntitiesCounts.SelectedItem
            End If
        End While

        Dim Listf2 As String
        i = 0
        lst_f2_CustomEntityTotal.SelectedIndex = -1
        While i < lst_f2_CustomEntityTotal.Items.Count
            i += 1
            lst_f2_CustomEntityTotal.SelectedIndex += 1
            If i = 1 Then
                Listf2 = "{7" & lst_f2_CustomEntityTotal.SelectedItem
            Else
                Listf2 = Listf2 & "^" & lst_f2_CustomEntityTotal.SelectedItem
            End If
        End While

        Dim Listf5 As String
        i = 0
        lst_f5_RoomCount.SelectedIndex = -1
        While i < lst_f5_RoomCount.Items.Count
            i += 1
            lst_f5_RoomCount.SelectedIndex += 1
            If i = 1 Then
                Listf5 = "{8" & lst_f5_RoomCount.SelectedItem
            Else
                Listf5 = Listf5 & "^" & lst_f5_RoomCount.SelectedItem
            End If
        End While

        Dim Listf6 As String
        i = 0
        lst_f6_Ratio.SelectedIndex = -1
        While i < lst_f6_Ratio.Items.Count
            i += 1
            lst_f6_Ratio.SelectedIndex += 1
            If i = 1 Then
                Listf6 = "{9" & lst_f6_Ratio.SelectedItem
            Else
                Listf6 = Listf6 & "^" & lst_f6_Ratio.SelectedItem
            End If
        End While

        Dim Listf7 As String
        i = 0
        lst_f7_Geyser.SelectedIndex = -1
        While i < lst_f7_Geyser.Items.Count
            i += 1
            lst_f7_Geyser.SelectedIndex += 1
            If i = 1 Then
                Listf7 = "{10" & lst_f7_Geyser.SelectedItem
            Else
                Listf7 = Listf7 & "^" & lst_f7_Geyser.SelectedItem
            End If
        End While

        Dim Listf8 As String
        i = 0
        lst_f8_UnitFile.SelectedIndex = -1
        While i < lst_f8_UnitFile.Items.Count
            i += 1
            lst_f8_UnitFile.SelectedIndex += 1
            If i = 1 Then
                Listf8 = "{11" & lst_f8_UnitFile.SelectedItem
            Else
                Listf8 = Listf8 & "^" & lst_f8_UnitFile.SelectedItem
            End If
        End While

        Dim Listf9 As String
        i = 0
        lst_f9_LightFile.SelectedIndex = -1
        While i < lst_f9_LightFile.Items.Count
            i += 1
            lst_f9_LightFile.SelectedIndex += 1
            If i = 1 Then
                Listf9 = "{12" & lst_f9_LightFile.SelectedItem
            Else
                Listf9 = Listf9 & "^" & lst_f9_LightFile.SelectedItem
            End If
        End While

        Dim Listfa As String
        i = 0
        lst_fa_Skybox.SelectedIndex = -1
        While i < lst_fa_Skybox.Items.Count
            i += 1
            lst_fa_Skybox.SelectedIndex += 1
            If i = 1 Then
                Listfa = "{13" & lst_fa_Skybox.SelectedItem
            Else
                Listfa = Listfa & "^" & lst_fa_Skybox.SelectedItem
            End If
        End While

        Dim Listf10 As String
        i = 0
        lst_f10_CloggedHole.SelectedIndex = -1
        While i < lst_f10_CloggedHole.Items.Count
            i += 1
            lst_f10_CloggedHole.SelectedIndex += 1
            If i = 1 Then
                Listf10 = "{14" & lst_f10_CloggedHole.SelectedItem
            Else
                Listf10 = Listf10 & "^" & lst_f10_CloggedHole.SelectedItem
            End If
        End While

        Dim Listf12 As String
        i = 0
        lst_f12_MusicType.SelectedIndex = -1
        While i < lst_f12_MusicType.Items.Count
            i += 1
            lst_f12_MusicType.SelectedIndex += 1
            If i = 1 Then
                Listf12 = "{15" & lst_f12_MusicType.SelectedItem
            Else
                Listf12 = Listf12 & "^" & lst_f12_MusicType.SelectedItem
            End If
        End While

        Dim Listf13 As String
        i = 0
        lst_f13_SolidPlane.SelectedIndex = -1
        While i < lst_f13_SolidPlane.Items.Count
            i += 1
            lst_f13_SolidPlane.SelectedIndex += 1
            If i = 1 Then
                Listf13 = "{16" & lst_f13_SolidPlane.SelectedItem
            Else
                Listf13 = Listf13 & "^" & lst_f13_SolidPlane.SelectedItem
            End If
        End While

        Dim Listf14 As String
        i = 0
        lst_f14_DeadEndCount.SelectedIndex = -1
        While i < lst_f14_DeadEndCount.Items.Count
            i += 1
            lst_f14_DeadEndCount.SelectedIndex += 1
            If i = 1 Then
                Listf14 = "{17" & lst_f14_DeadEndCount.SelectedItem
            Else
                Listf14 = Listf14 & "^" & lst_f14_DeadEndCount.SelectedItem
            End If
        End While

        Dim Listf16 As String
        i = 0
        lst_f16_WaterwraithTimer.SelectedIndex = -1
        While i < lst_f16_WaterwraithTimer.Items.Count
            i += 1
            lst_f16_WaterwraithTimer.SelectedIndex += 1
            If i = 1 Then
                Listf16 = "{18" & lst_f16_WaterwraithTimer.SelectedItem
            Else
                Listf16 = Listf16 & "^" & lst_f16_WaterwraithTimer.SelectedItem
            End If
        End While

        Dim Listf17 As String
        i = 0
        lst_f17_Seesaw.SelectedIndex = -1
        While i < lst_f17_Seesaw.Items.Count
            i += 1
            lst_f17_Seesaw.SelectedIndex += 1
            If i = 1 Then
                Listf17 = "{19" & lst_f17_Seesaw.SelectedItem
            Else
                Listf17 = Listf17 & "^" & lst_f17_Seesaw.SelectedItem
            End If
        End While

        Dim ListTotaka_MusicList As String
        i = 0
        lst_totaka_MusicList.SelectedIndex = -1
        While i < lst_totaka_MusicList.Items.Count
            i += 1
            lst_totaka_MusicList.SelectedIndex += 1
            If i = 1 Then
                ListTotaka_MusicList = "{20" & lst_totaka_MusicList.SelectedItem
            Else
                ListTotaka_MusicList = ListTotaka_MusicList & "^" & lst_totaka_MusicList.SelectedItem
            End If
        End While

        Dim ListCustomEntityTotal_Check As String
        i = 0
        lst_CustomEntityTotal_Check.SelectedIndex = -1
        While i < lst_CustomEntityTotal_Check.Items.Count
            i += 1
            lst_CustomEntityTotal_Check.SelectedIndex += 1
            If i = 1 Then
                ListCustomEntityTotal_Check = "{21" & lst_CustomEntityTotal_Check.SelectedItem
            Else
                ListCustomEntityTotal_Check = ListCustomEntityTotal_Check & "^" & lst_CustomEntityTotal_Check.SelectedItem
            End If
        End While

        Dim ListTreasureSets As String
        i = 0
        lst_TreasureSets.SelectedIndex = -1
        While i < lst_TreasureSets.Items.Count
            i += 1
            lst_TreasureSets.SelectedIndex += 1
            If i = 1 Then
                ListTreasureSets = "{22" & lst_TreasureSets.SelectedItem
            Else
                ListTreasureSets = ListTreasureSets & "^" & lst_TreasureSets.SelectedItem
            End If
        End While

        Dim ListGateSets As String
        i = 0
        lst_GateSets.SelectedIndex = -1
        While i < lst_GateSets.Items.Count
            i += 1
            lst_GateSets.SelectedIndex += 1
            If i = 1 Then
                ListGateSets = "{23" & lst_GateSets.SelectedItem
            Else
                ListGateSets = ListGateSets & "^" & lst_GateSets.SelectedItem
            End If
        End While

        Dim ListCMTimes As String
        i = 0
        lst_Times.SelectedIndex = -1
        While i < lst_Times.Items.Count
            i += 1
            lst_Times.SelectedIndex += 1
            If i = 1 Then
                ListCMTimes = lst_Times.SelectedItem
            Else
                ListCMTimes = ListCMTimes & "^" & lst_Times.SelectedItem
            End If
        End While
        Dim CMpropsSaved As String = "0"
        If lbl_CMsaved.ForeColor = Color.Green Then
            CMpropsSaved = "1"
        End If


        Dim SaveDataFile As String = ListSublevels & vbCrLf & ListSublevelIDs & ListSublevelNames & ListRegularEntities & ListRegularEntitiesCounts & "{5" & SublevelTotalID & "{6" & "VersionCode: sjhds87adhshf8afhuDs9fys87df6sd5f7udhf8s93hj334jk" & Listf2 & Listf5 & Listf6 & Listf7 & Listf8 & Listf9 & Listfa & Listf10 & Listf12 & Listf13 & Listf14 & Listf16 & Listf17 & ListTotaka_MusicList & ListCustomEntityTotal_Check & ListTreasureSets & ListGateSets & "{24" & num_rL.Value & "{25" & num_rB.Value & "{26" & num_rF.Value & "{27" & num_bL.Value & "{28" & num_bB.Value & "{29" & num_bF.Value & "{30" & num_yL.Value & "{31" & num_yB.Value & "{32" & num_yF.Value & "{33" & num_wL.Value & "{34" & num_wB.Value & "{35" & num_wF.Value & "{36" & num_pL.Value & "{37" & num_pB.Value & "{38" & num_pF.Value & "{39" & num_bulbL.Value & "{40" & num_bulbB.Value & "{41" & num_bulbF.Value & "{42" & num_cL.Value & "{43" & num_cB.Value & "{44" & num_cF.Value & "{45" & num_uss.Value & "{46" & num_ubs.Value & "{47" & num_CMPsubCount.Value & "{48" & ListCMTimes & "{49" & CMpropsSaved & "{50"

        Dim wrapper As New Simple3Des("hsAJAA%#!HJbhk^&A^&76agiA%$##a&AFAA&*A*GAIha8aF1")
        Dim cipherText As String = wrapper.EncryptData(SaveDataFile)

        'MsgBox("The cipher text is: " & cipherText)
        If copyOnly Then
            copyOnly = False
            Dim CompStr As New clsCompressedString(System.Text.Encoding.UTF8)
            CompStr.UnCompressed = SaveDataFile
            Clipboard.SetText(CompStr.Compressed)
            MsgBox("Copied Project File to clipboard (for Cave Net submissions)!")
        Else
            My.Computer.FileSystem.WriteAllText(LoadedOrSavedAsFileName, cipherText, False)
        End If
    End Sub
    Dim copyOnly As Boolean = False
    Private Sub btn_SaveAs_Click(sender As Object, e As EventArgs) Handles btn_SaveAs.Click
        btn_Focus.Select()
        Dim InSubEnts As Boolean = False
        If lst_Sublevels.Items.Count > 0 Then
            If (SaveAsDialog.ShowDialog() = DialogResult.OK) Then
                MustBeSavedAs = False
                If TabControl1.SelectedTab.Name = "tbp_SublevelEntities" Then
                    InSubEnts = True
                    TabControl1.SelectedTab = tbp_SublevelManager
                    TabControl1.SelectedTab = tbp_ImportManager
                End If
                CaveNeedsToSaveAs = False
                btn_Save.Enabled = True
                LoadedOrSavedAsFileName = SaveAsDialog.FileName
                SaveData()
            End If
            If InSubEnts = True Then
                MsgBox("error, sorry no explanation bc i dont know")
            End If

        Else
            MsgBox("There are no sublevels.")
        End If
    End Sub
    Private Sub btn_Load_Click(sender As Object, e As EventArgs) Handles btn_Load.Click
        ClickedAddSublevelWithNameInput = True
        Dim result As Integer
        If lst_Sublevels.Items.Count > 0 Then
            result = MessageBox.Show("Are you sure you want to abandon your current cave?" & vbCrLf & vbCrLf & "This will be permanent.", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)
        Else
            result = DialogResult.Yes
        End If
        If result = DialogResult.Yes Then
            MustBeSavedAs = True
            If pnl_Entities.Location = New Point(12, 43) Then
                btn_CloseEntities.PerformClick()
            End If
            lst_Sublevels.SelectedIndex = -1
            If (LoadDialog.ShowDialog() = DialogResult.OK) Then
                TabControl1.SelectedTab = tbp_SublevelManager
                SublevelTotal = 0
                SublevelTotalID = 0
                lbl_SublevelTotal.Text = SublevelTotal & " Sublevels"
                If lst_Sublevels.Items.Count > 0 Then
                    lst_Sublevels.SelectedIndex = 0
                    lst_Sublevels.Items.RemoveAt(lst_Sublevels.SelectedIndex)
                End If
                lst_Sublevels.Items.Clear()
                lst_Sublevel_IDs.Items.Clear()
                lst_SublevelNames.Items.Clear()
                lst_RegularEntities.Items.Clear()
                lst_RegularEntitiesCounts.Items.Clear()
                lbl_SublevelID.Text = "Nothing Selected"
                lbl_EntityCount.Text = ""
                lbl_TotalEntityCount.Text = ""
                lst_RegularEntitiesNormList.Items.Clear()
                lst_Sublevels.Items.Clear()
                lst_Sublevel_IDs.Items.Clear()
                lst_SublevelNames.Items.Clear()
                lst_RegularEntities.Items.Clear()
                lst_RegularEntitiesCounts.Items.Clear()
                lst_f2_CustomEntityTotal.Items.Clear()
                lst_f5_RoomCount.Items.Clear()
                lst_f6_Ratio.Items.Clear()
                lst_f7_Geyser.Items.Clear()
                lst_f8_UnitFile.Items.Clear()
                lst_f9_LightFile.Items.Clear()
                lst_f10_CloggedHole.Items.Clear()
                lst_f12_MusicType.Items.Clear()
                lst_f13_SolidPlane.Items.Clear()
                lst_f14_DeadEndCount.Items.Clear()
                lst_f16_WaterwraithTimer.Items.Clear()
                lst_f17_Seesaw.Items.Clear()
                lst_fa_Skybox.Items.Clear()
                lst_CustomEntityTotal_Check.Items.Clear()
                lst_totaka_MusicList.Items.Clear()
                lst_TreasureSets.Items.Clear()
                lst_GateSets.Items.Clear()
                lst_Times.Items.Clear()

                LoadCaveFiles()
            End If

            If lst_Sublevels.Items.Count = 0 Then
                btn_Save.Enabled = False
            Else
                btn_SaveAs.Enabled = True
                If CaveNeedsToSaveAs = False Then btn_Save.Enabled = True
            End If

        End If
    End Sub
    Public Sub LoadCaveFiles()
        Dim LoadedData As String
        If LoadDialog.FileName.EndsWith(".p2ncc") Then
            Dim cipherText As String = My.Computer.FileSystem.ReadAllText(LoadDialog.FileName)
            Dim wrapper As New Simple3Des("hsAJAA%#!HJbhk^&A^&76agiA%$##a&AFAA&*A*GAIha8aF1")

            'DecryptData throws if the wrong password Is used.
            Try
                LoadedData = wrapper.DecryptData(cipherText)
            Catch ex As Exception
                MsgBox("Cave Creator failed to open this project file.")
                Exit Sub
            End Try
            Clipboard.SetText(LoadedData)
            'MsgBox("set!")
            'LoadedData = My.Computer.FileSystem.ReadAllText(LoadDialog.FileName)

            If IO.File.Exists(AppDomain.CurrentDomain.BaseDirectory & "\CCPcavenetdonotusethisname_specialNewSnowflake.p2ncc") Then
                IO.File.Delete(AppDomain.CurrentDomain.BaseDirectory & "\CCPcavenetdonotusethisname_specialNewSnowflake.p2ncc")
            End If
        Else
            LoadedData = My.Computer.FileSystem.ReadAllText(LoadDialog.FileName)
        End If

        If LoadedData.Contains("sjhds87adhshf8afhuDs9fys87df6sd5f7udhf8s93hj334jk") Then



            CaveNeedsToSaveAs = False
            btn_Save.Enabled = True
            LoadedOrSavedAsFileName = LoadDialog.FileName

            Dim ListSublevels = LoadedData.Substring(0, LoadedData.IndexOf("{1"))

            Dim ListSublevelIDs = LoadedData.Substring(ListSublevels.Length + 2, LoadedData.Length - (ListSublevels.Length + 2))
            ListSublevelIDs = ListSublevelIDs.Substring(0, ListSublevelIDs.IndexOf("{2"))

            Dim ListSublevelNames = LoadedData.Substring(ListSublevels.Length + ListSublevelIDs.Length + 4, LoadedData.Length - ((ListSublevels.Length + ListSublevelIDs.Length) + 4))
            ListSublevelNames = ListSublevelNames.Substring(0, ListSublevelNames.IndexOf("{3"))

            Dim ListRegularEntities = LoadedData.Substring(ListSublevels.Length + ListSublevelIDs.Length + ListSublevelNames.Length + 6, LoadedData.Length - ((ListSublevels.Length + ListSublevelIDs.Length + ListSublevelNames.Length) + 6))
            ListRegularEntities = ListRegularEntities.Substring(0, ListRegularEntities.IndexOf("{4"))

            Dim ListRegularEntitiesCounts = LoadedData.Substring(ListSublevels.Length + ListSublevelIDs.Length + ListSublevelNames.Length + ListRegularEntities.Length + 8, LoadedData.Length - ((ListSublevels.Length + ListSublevelIDs.Length + ListSublevelNames.Length + ListRegularEntities.Length) + 8))
            ListRegularEntitiesCounts = ListRegularEntitiesCounts.Substring(0, ListRegularEntitiesCounts.IndexOf("{5"))

            Dim NewTotalSublevelID = LoadedData.Substring(ListSublevels.Length + ListSublevelIDs.Length + ListSublevelNames.Length + ListRegularEntities.Length + ListRegularEntitiesCounts.Length + 10, LoadedData.Length - ((ListSublevels.Length + ListSublevelIDs.Length + ListSublevelNames.Length + ListRegularEntities.Length + ListRegularEntitiesCounts.Length) + 10))
            NewTotalSublevelID = NewTotalSublevelID.Substring(0, NewTotalSublevelID.IndexOf("{6"))

            Dim Listf2 = LoadedData.Substring(LoadedData.IndexOf("{7") + 2, LoadedData.IndexOf("{8") - (LoadedData.IndexOf("{7") + 2))

            Dim Listf5 = LoadedData.Substring(LoadedData.IndexOf("{8") + 2, LoadedData.IndexOf("{9") - (LoadedData.IndexOf("{8") + 2))

            Dim Listf6 = LoadedData.Substring(LoadedData.IndexOf("{9") + 2, LoadedData.IndexOf("{10") - (LoadedData.IndexOf("{9") + 2))

            Dim Listf7 = LoadedData.Substring(LoadedData.IndexOf("{10") + 3, LoadedData.IndexOf("{11") - (LoadedData.IndexOf("{10") + 3))
            Dim Listf8 = LoadedData.Substring(LoadedData.IndexOf("{11") + 3, LoadedData.IndexOf("{12") - (LoadedData.IndexOf("{11") + 3))
            Dim Listf9 = LoadedData.Substring(LoadedData.IndexOf("{12") + 3, LoadedData.IndexOf("{13") - (LoadedData.IndexOf("{12") + 3))
            Dim Listfa = LoadedData.Substring(LoadedData.IndexOf("{13") + 3, LoadedData.IndexOf("{14") - (LoadedData.IndexOf("{13") + 3))
            Dim Listf10 = LoadedData.Substring(LoadedData.IndexOf("{14") + 3, LoadedData.IndexOf("{15") - (LoadedData.IndexOf("{14") + 3))
            Dim Listf12 = LoadedData.Substring(LoadedData.IndexOf("{15") + 3, LoadedData.IndexOf("{16") - (LoadedData.IndexOf("{15") + 3))
            Dim Listf13 = LoadedData.Substring(LoadedData.IndexOf("{16") + 3, LoadedData.IndexOf("{17") - (LoadedData.IndexOf("{16") + 3))
            Dim Listf14 = LoadedData.Substring(LoadedData.IndexOf("{17") + 3, LoadedData.IndexOf("{18") - (LoadedData.IndexOf("{17") + 3))
            Dim Listf16 = LoadedData.Substring(LoadedData.IndexOf("{18") + 3, LoadedData.IndexOf("{19") - (LoadedData.IndexOf("{18") + 3))
            Dim Listf17 = LoadedData.Substring(LoadedData.IndexOf("{19") + 3, LoadedData.IndexOf("{20") - (LoadedData.IndexOf("{19") + 3))
            Dim ListTotaka_MusicList = LoadedData.Substring(LoadedData.IndexOf("{20") + 3, LoadedData.IndexOf("{21") - (LoadedData.IndexOf("{20") + 3))
            Dim ListCustomEntityTotal_ChecK = LoadedData.Substring(LoadedData.IndexOf("{21") + 3, LoadedData.IndexOf("{22") - (LoadedData.IndexOf("{21") + 3))
            Dim ListTreasureSets = LoadedData.Substring(LoadedData.IndexOf("{22") + 3, LoadedData.IndexOf("{23") - (LoadedData.IndexOf("{22") + 3))
            Dim ListGateSets = LoadedData.Substring(LoadedData.IndexOf("{23") + 3, LoadedData.IndexOf("{24") - (LoadedData.IndexOf("{23") + 3))



            num_rL.Value = Integer.Parse(LoadedData.Substring(LoadedData.IndexOf("{24") + 3, LoadedData.IndexOf("{25") - (LoadedData.IndexOf("{24") + 3)))
            num_rB.Value = Integer.Parse(LoadedData.Substring(LoadedData.IndexOf("{25") + 3, LoadedData.IndexOf("{26") - (LoadedData.IndexOf("{25") + 3)))
            num_rF.Value = Integer.Parse(LoadedData.Substring(LoadedData.IndexOf("{26") + 3, LoadedData.IndexOf("{27") - (LoadedData.IndexOf("{26") + 3)))
            num_bL.Value = Integer.Parse(LoadedData.Substring(LoadedData.IndexOf("{27") + 3, LoadedData.IndexOf("{28") - (LoadedData.IndexOf("{27") + 3)))
            num_bB.Value = Integer.Parse(LoadedData.Substring(LoadedData.IndexOf("{28") + 3, LoadedData.IndexOf("{29") - (LoadedData.IndexOf("{28") + 3)))
            num_bF.Value = Integer.Parse(LoadedData.Substring(LoadedData.IndexOf("{29") + 3, LoadedData.IndexOf("{30") - (LoadedData.IndexOf("{29") + 3)))
            num_yL.Value = Integer.Parse(LoadedData.Substring(LoadedData.IndexOf("{30") + 3, LoadedData.IndexOf("{31") - (LoadedData.IndexOf("{30") + 3)))
            num_yB.Value = Integer.Parse(LoadedData.Substring(LoadedData.IndexOf("{31") + 3, LoadedData.IndexOf("{32") - (LoadedData.IndexOf("{31") + 3)))
            num_yF.Value = Integer.Parse(LoadedData.Substring(LoadedData.IndexOf("{32") + 3, LoadedData.IndexOf("{33") - (LoadedData.IndexOf("{32") + 3)))
            num_wL.Value = Integer.Parse(LoadedData.Substring(LoadedData.IndexOf("{33") + 3, LoadedData.IndexOf("{34") - (LoadedData.IndexOf("{33") + 3)))
            num_wB.Value = Integer.Parse(LoadedData.Substring(LoadedData.IndexOf("{34") + 3, LoadedData.IndexOf("{35") - (LoadedData.IndexOf("{34") + 3)))
            num_wF.Value = Integer.Parse(LoadedData.Substring(LoadedData.IndexOf("{35") + 3, LoadedData.IndexOf("{36") - (LoadedData.IndexOf("{35") + 3)))
            num_pL.Value = Integer.Parse(LoadedData.Substring(LoadedData.IndexOf("{36") + 3, LoadedData.IndexOf("{37") - (LoadedData.IndexOf("{36") + 3)))
            num_pB.Value = Integer.Parse(LoadedData.Substring(LoadedData.IndexOf("{37") + 3, LoadedData.IndexOf("{38") - (LoadedData.IndexOf("{37") + 3)))
            num_pF.Value = Integer.Parse(LoadedData.Substring(LoadedData.IndexOf("{38") + 3, LoadedData.IndexOf("{39") - (LoadedData.IndexOf("{38") + 3)))
            num_bulbL.Value = Integer.Parse(LoadedData.Substring(LoadedData.IndexOf("{39") + 3, LoadedData.IndexOf("{40") - (LoadedData.IndexOf("{39") + 3)))
            num_bulbB.Value = Integer.Parse(LoadedData.Substring(LoadedData.IndexOf("{40") + 3, LoadedData.IndexOf("{41") - (LoadedData.IndexOf("{40") + 3)))
            num_bulbF.Value = Integer.Parse(LoadedData.Substring(LoadedData.IndexOf("{41") + 3, LoadedData.IndexOf("{42") - (LoadedData.IndexOf("{41") + 3)))
            num_cL.Value = Integer.Parse(LoadedData.Substring(LoadedData.IndexOf("{42") + 3, LoadedData.IndexOf("{43") - (LoadedData.IndexOf("{42") + 3)))
            num_cB.Value = Integer.Parse(LoadedData.Substring(LoadedData.IndexOf("{43") + 3, LoadedData.IndexOf("{44") - (LoadedData.IndexOf("{43") + 3)))
            num_cF.Value = Integer.Parse(LoadedData.Substring(LoadedData.IndexOf("{44") + 3, LoadedData.IndexOf("{45") - (LoadedData.IndexOf("{44") + 3)))
            num_uss.Value = Integer.Parse(LoadedData.Substring(LoadedData.IndexOf("{45") + 3, LoadedData.IndexOf("{46") - (LoadedData.IndexOf("{45") + 3)))
            num_ubs.Value = Integer.Parse(LoadedData.Substring(LoadedData.IndexOf("{46") + 3, LoadedData.IndexOf("{47") - (LoadedData.IndexOf("{46") + 3)))
            num_CMPsubCount.Value = Integer.Parse(LoadedData.Substring(LoadedData.IndexOf("{47") + 3, LoadedData.IndexOf("{48") - (LoadedData.IndexOf("{47") + 3)))

            Dim ListCMtimes = LoadedData.Substring(LoadedData.IndexOf("{48") + 3, LoadedData.IndexOf("{49") - (LoadedData.IndexOf("{48") + 3))




            If (ListSublevels.Length > 0) Then
                Dim separators() As Char = {"^"c}
                For Each item As String In ListSublevels.Split(
            separators, StringSplitOptions.RemoveEmptyEntries)
                    lst_Sublevels.Items.Add(item)
                    SublevelTotal += 1
                    lbl_SublevelTotal.Text = SublevelTotal & " Sublevels"
                Next item
            End If

            If (ListSublevelIDs.Length > 0) Then
                Dim separators() As Char = {"^"c}
                For Each item As String In ListSublevelIDs.Split(
            separators, StringSplitOptions.RemoveEmptyEntries)
                    lst_Sublevel_IDs.Items.Add(item)
                Next item
            End If

            If (ListSublevelNames.Length > 0) Then
                Dim separators() As Char = {"^"c}
                For Each item As String In ListSublevelNames.Split(
            separators, StringSplitOptions.RemoveEmptyEntries)
                    lst_SublevelNames.Items.Add(item)
                Next item
            End If

            If (ListRegularEntities.Length > 0) Then
                Dim separators() As Char = {"^"c}
                For Each item As String In ListRegularEntities.Split(
            separators, StringSplitOptions.RemoveEmptyEntries)
                    lst_RegularEntities.Items.Add(item)
                Next item
            End If

            If (ListRegularEntitiesCounts.Length > 0) Then
                Dim separators() As Char = {"^"c}
                For Each item As String In ListRegularEntitiesCounts.Split(
            separators, StringSplitOptions.RemoveEmptyEntries)
                    lst_RegularEntitiesCounts.Items.Add(item)
                Next item
            End If

            If (Listf2.Length > 0) Then
                Dim separators() As Char = {"^"c}
                For Each item As String In Listf2.Split(
            separators, StringSplitOptions.RemoveEmptyEntries)
                    lst_f2_CustomEntityTotal.Items.Add(item)
                Next item
            End If

            If (Listf5.Length > 0) Then
                Dim separators() As Char = {"^"c}
                For Each item As String In Listf5.Split(
            separators, StringSplitOptions.RemoveEmptyEntries)
                    lst_f5_RoomCount.Items.Add(item)
                Next item
            End If

            If (Listf6.Length > 0) Then
                Dim separators() As Char = {"^"c}
                For Each item As String In Listf6.Split(
            separators, StringSplitOptions.RemoveEmptyEntries)
                    lst_f6_Ratio.Items.Add(item)
                Next item
            End If

            If (Listf7.Length > 0) Then
                Dim separators() As Char = {"^"c}
                For Each item As String In Listf7.Split(
            separators, StringSplitOptions.RemoveEmptyEntries)
                    lst_f7_Geyser.Items.Add(item)
                Next item
            End If
            If (Listf8.Length > 0) Then
                Dim separators() As Char = {"^"c}
                For Each item As String In Listf8.Split(
            separators, StringSplitOptions.RemoveEmptyEntries)
                    lst_f8_UnitFile.Items.Add(item)
                Next item
            End If
            If (Listf9.Length > 0) Then
                Dim separators() As Char = {"^"c}
                For Each item As String In Listf9.Split(
            separators, StringSplitOptions.RemoveEmptyEntries)
                    lst_f9_LightFile.Items.Add(item)
                Next item
            End If
            If (Listfa.Length > 0) Then
                Dim separators() As Char = {"^"c}
                For Each item As String In Listfa.Split(
            separators, StringSplitOptions.RemoveEmptyEntries)
                    lst_fa_Skybox.Items.Add(item)
                Next item
            End If
            If (Listf10.Length > 0) Then
                Dim separators() As Char = {"^"c}
                For Each item As String In Listf10.Split(
            separators, StringSplitOptions.RemoveEmptyEntries)
                    lst_f10_CloggedHole.Items.Add(item)
                Next item
            End If
            If (Listf12.Length > 0) Then
                Dim separators() As Char = {"^"c}
                For Each item As String In Listf12.Split(
            separators, StringSplitOptions.RemoveEmptyEntries)
                    lst_f12_MusicType.Items.Add(item)
                Next item
            End If
            If (Listf13.Length > 0) Then
                Dim separators() As Char = {"^"c}
                For Each item As String In Listf13.Split(
            separators, StringSplitOptions.RemoveEmptyEntries)
                    lst_f13_SolidPlane.Items.Add(item)
                Next item
            End If
            If (Listf14.Length > 0) Then
                Dim separators() As Char = {"^"c}
                For Each item As String In Listf14.Split(
            separators, StringSplitOptions.RemoveEmptyEntries)
                    lst_f14_DeadEndCount.Items.Add(item)
                Next item
            End If
            If (Listf16.Length > 0) Then
                Dim separators() As Char = {"^"c}
                For Each item As String In Listf16.Split(
            separators, StringSplitOptions.RemoveEmptyEntries)
                    lst_f16_WaterwraithTimer.Items.Add(item)
                Next item
            End If
            If (Listf17.Length > 0) Then
                Dim separators() As Char = {"^"c}
                For Each item As String In Listf17.Split(
            separators, StringSplitOptions.RemoveEmptyEntries)
                    lst_f17_Seesaw.Items.Add(item)
                Next item
            End If
            If (ListTotaka_MusicList.Length > 0) Then
                Dim separators() As Char = {"^"c}
                For Each item As String In ListTotaka_MusicList.Split(
            separators, StringSplitOptions.RemoveEmptyEntries)
                    lst_totaka_MusicList.Items.Add(item)
                Next item
            End If
            If (ListCustomEntityTotal_ChecK.Length > 0) Then
                Dim separators() As Char = {"^"c}
                For Each item As String In ListCustomEntityTotal_ChecK.Split(
            separators, StringSplitOptions.RemoveEmptyEntries)
                    lst_CustomEntityTotal_Check.Items.Add(item)
                Next item
            End If
            If (ListTreasureSets.Length > 0) Then
                Dim separators() As Char = {"^"c}
                For Each item As String In ListTreasureSets.Split(
            separators, StringSplitOptions.RemoveEmptyEntries)
                    lst_TreasureSets.Items.Add(item)
                Next item
            End If
            If (ListGateSets.Length > 0) Then
                Dim separators() As Char = {"^"c}
                For Each item As String In ListGateSets.Split(
            separators, StringSplitOptions.RemoveEmptyEntries)
                    lst_GateSets.Items.Add(item)
                Next item
            End If
            If (ListCMtimes.Length > 0) Then
                Dim separators() As Char = {"^"c}
                For Each item As String In ListCMtimes.Split(
            separators, StringSplitOptions.RemoveEmptyEntries)
                    lst_Times.Items.Add(item)
                Next item
            End If



            If LoadedData.Contains("{50") Then
                Dim CMsavedBool As String = LoadedData.Substring(LoadedData.IndexOf("{49") + 3, LoadedData.IndexOf("{50") - (LoadedData.IndexOf("{49") + 3))
                If CMsavedBool = "1" Then
                    GenerateCMPcode()
                    lbl_CMsaved.Text = "Saved"
                    lbl_CMsaved.ForeColor = Color.Green
                    If opt_ChallengeMode.Checked = True Then
                        chk_UseCMproperties.Checked = True
                    End If
                End If
            End If


            SublevelTotalID = NewTotalSublevelID

            cmb_Sublevels.SelectedIndex = -1

            DeselectLists()

            MustBeSavedAs = False

        ElseIf LoadedData.Contains("{f000}") AndAlso LoadedData.Contains("{f001}") AndAlso LoadedData.Contains("{f002}") AndAlso LoadedData.Contains("{f003}") AndAlso LoadedData.Contains("{f004}") AndAlso LoadedData.Contains("{c000} 4 ") Then

            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            'The following returns the cave's sublevel count
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            Dim NewTotalSublevelID = LoadedData.Substring(0, LoadedData.IndexOf("{_eof}"))
            NewTotalSublevelID = NewTotalSublevelID.Replace("{c000} 4 ", ">")
            NewTotalSublevelID = NewTotalSublevelID.Substring(NewTotalSublevelID.IndexOf(">") + 1, 2)
            NewTotalSublevelID = NewTotalSublevelID.Replace(" ", "").Replace("#", "")
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''



            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            'The following does the magic
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            While SublevelTotalID < Integer.Parse(NewTotalSublevelID)

                'The following is only temporary, it needs to be added in alone



                SublevelTotal += 1

                lst_Sublevels.Items.Add("Sublevel " & SublevelTotal)
                lst_Sublevel_IDs.Items.Add("S" & SublevelTotalID + 1)
                lst_SublevelNames.Items.Add(" ")
                If SublevelTotal = 1 Then
                    lbl_SublevelTotal.Text = SublevelTotal & " Sublevel"
                Else
                    lbl_SublevelTotal.Text = SublevelTotal & " Sublevels"
                End If
                lst_Sublevel_IDs.SelectedIndex = lst_Sublevel_IDs.Items.Count - 1


                Dim SublevelContents As String = LoadedData.Substring(LoadedData.IndexOf("{_eof}"), LoadedData.Length - LoadedData.IndexOf("{_eof}"))
                SublevelContents = SublevelContents.Substring(7, SublevelContents.Length - 7)

                If SublevelContents.Contains("{f000} 4 " & SublevelTotalID) Then
                    SublevelContents = SublevelContents.Substring(SublevelContents.IndexOf("{f000} 4 " & SublevelTotalID), SublevelContents.Length - SublevelContents.IndexOf("{f000} 4 " & SublevelTotalID))

                    ''''''''' having trouble with the ratio.... im thinking remove the # notes and then just substring every enter character and do it like that?

                    Dim SublevelProperties As String = SublevelContents.Substring(0, SublevelContents.IndexOf("{_eof}"))

                    While SublevelProperties.Contains("#")
                        Dim NotesForThisSection As String = SublevelProperties.Substring(SublevelProperties.IndexOf("#"), SublevelProperties.Length - (1 + SublevelProperties.IndexOf("#")))
                        SublevelProperties = SublevelProperties.Replace(NotesForThisSection.Substring(0, NotesForThisSection.IndexOf("
")), "")
                    End While

                    Dim NewSublevelProperties As String = SublevelProperties

                    SublevelProperties = SublevelProperties.Substring(SublevelProperties.IndexOf("{f005} 4 ") + 9, SublevelProperties.Length - (SublevelProperties.IndexOf("{f005} 4 ") + 9))
                    lst_f5_RoomCount.Items.Add(SublevelProperties.Substring(0, SublevelProperties.IndexOf("
")).Replace(" ", "").Replace("
", "").Replace("	", ""))
                    SublevelProperties = NewSublevelProperties
                    SublevelProperties = SublevelProperties.Substring(SublevelProperties.IndexOf("{f006} 4 ") + 9, SublevelProperties.Length - (SublevelProperties.IndexOf("{f006} 4 ") + 9))
                    lst_f6_Ratio.Items.Add(SublevelProperties.Substring(0, SublevelProperties.IndexOf("
")).Replace(" ", "").Replace("
", "").Replace("	", ""))
                    SublevelProperties = NewSublevelProperties
                    SublevelProperties = SublevelProperties.Substring(SublevelProperties.IndexOf("{f007} 4 ") + 9, SublevelProperties.Length - (SublevelProperties.IndexOf("{f007} 4 ") + 9))
                    lst_f7_Geyser.Items.Add(SublevelProperties.Substring(0, SublevelProperties.IndexOf("
")).Replace(" ", "").Replace("
", "").Replace("	", ""))
                    SublevelProperties = NewSublevelProperties
                    SublevelProperties = SublevelProperties.Substring(SublevelProperties.IndexOf("{f008} -1 ") + 10, SublevelProperties.Length - (SublevelProperties.IndexOf("{f008} -1 ") + 10))
                    lst_f8_UnitFile.Items.Add(SublevelProperties.Substring(0, SublevelProperties.IndexOf("
")).Replace(" ", "").Replace("
", "").Replace("	", ""))
                    SublevelProperties = NewSublevelProperties
                    SublevelProperties = SublevelProperties.Substring(SublevelProperties.IndexOf("{f009} -1 ") + 10, SublevelProperties.Length - (SublevelProperties.IndexOf("{f009} -1 ") + 10))
                    lst_f9_LightFile.Items.Add(SublevelProperties.Substring(0, SublevelProperties.IndexOf("
")).Replace(" ", "").Replace("
", "").Replace("	", ""))
                    SublevelProperties = NewSublevelProperties
                    SublevelProperties = SublevelProperties.Substring(SublevelProperties.IndexOf("{f00A} -1 ") + 10, SublevelProperties.Length - (SublevelProperties.IndexOf("{f00A} -1 ") + 10))
                    lst_fa_Skybox.Items.Add(SublevelProperties.Substring(0, SublevelProperties.IndexOf("
")).Replace(" ", "").Replace("
", "").Replace("	", ""))
                    SublevelProperties = NewSublevelProperties
                    SublevelProperties = SublevelProperties.Substring(SublevelProperties.IndexOf("{f010} 4 ") + 9, SublevelProperties.Length - (SublevelProperties.IndexOf("{f010} 4 ") + 9))
                    lst_f10_CloggedHole.Items.Add(SublevelProperties.Substring(0, SublevelProperties.IndexOf("
")).Replace(" ", "").Replace("
", "").Replace("	", ""))
                    SublevelProperties = NewSublevelProperties
                    SublevelProperties = SublevelProperties.Substring(SublevelProperties.IndexOf("{f012} 4 ") + 9, SublevelProperties.Length - (SublevelProperties.IndexOf("{f012} 4 ") + 9))
                    lst_f12_MusicType.Items.Add(SublevelProperties.Substring(0, SublevelProperties.IndexOf("
")).Replace(" ", "").Replace("
", "").Replace("	", ""))
                    SublevelProperties = NewSublevelProperties
                    SublevelProperties = SublevelProperties.Substring(SublevelProperties.IndexOf("{f013} 4 ") + 9, SublevelProperties.Length - (SublevelProperties.IndexOf("{f013} 4 ") + 9))
                    lst_f13_SolidPlane.Items.Add(SublevelProperties.Substring(0, SublevelProperties.IndexOf("
")).Replace(" ", "").Replace("
", "").Replace("	", ""))
                    SublevelProperties = NewSublevelProperties
                    SublevelProperties = SublevelProperties.Substring(SublevelProperties.IndexOf("{f014} 4 ") + 9, SublevelProperties.Length - (SublevelProperties.IndexOf("{f014} 4 ") + 9))
                    lst_f14_DeadEndCount.Items.Add(SublevelProperties.Substring(0, SublevelProperties.IndexOf("
")).Replace(" ", "").Replace("
", "").Replace("	", ""))
                    SublevelProperties = NewSublevelProperties
                    SublevelProperties = SublevelProperties.Substring(SublevelProperties.IndexOf("{f016} 4 ") + 9, SublevelProperties.Length - (SublevelProperties.IndexOf("{f016} 4 ") + 9))
                    lst_f16_WaterwraithTimer.Items.Add(SublevelProperties.Substring(0, SublevelProperties.IndexOf("
")).Replace(" ", "").Replace("
", "").Replace("	", ""))
                    SublevelProperties = NewSublevelProperties
                    SublevelProperties = SublevelProperties.Substring(SublevelProperties.IndexOf("{f017} 4 ") + 9, SublevelProperties.Length - (SublevelProperties.IndexOf("{f017} 4 ") + 9))
                    lst_f17_Seesaw.Items.Add(SublevelProperties.Substring(0, SublevelProperties.IndexOf("
")).Replace(" ", "").Replace("
", "").Replace("	", ""))
                    SublevelProperties = NewSublevelProperties
                    SublevelProperties = SublevelProperties.Substring(SublevelProperties.IndexOf("{f002} 4 ") + 9, SublevelProperties.Length - (SublevelProperties.IndexOf("{f002} 4 ") + 9))
                    lst_f2_CustomEntityTotal.Items.Add(SublevelProperties.Substring(0, SublevelProperties.IndexOf("
")).Replace(" ", "").Replace("
", "").Replace("	", ""))
                    lst_CustomEntityTotal_Check.Items.Add("1")
                    lst_totaka_MusicList.Items.Add("caveconc_00_0.cnd")

                    SublevelContents = SublevelContents.Substring(SublevelContents.IndexOf("{_eof}"), SublevelContents.Length - SublevelContents.IndexOf("{_eof}"))
                    SublevelContents = SublevelContents.Substring(7, SublevelContents.Length - 7)

                    If SublevelTotalID = NewTotalSublevelID - 1 Then
                        SublevelContents = SublevelContents.Substring(SublevelContents.IndexOf("{") + 2, SublevelContents.Length - SublevelContents.IndexOf("{") - 2)
                    Else
                        SublevelContents = SublevelContents.Substring(SublevelContents.IndexOf("{") + 2, SublevelContents.IndexOf("{f000}") - 2)
                    End If


                    '''''Following is for treasures
                    Dim SublevelTreasureInfo As String = SublevelContents.Substring(SublevelContents.IndexOf("}") + 1, SublevelContents.Length - (SublevelContents.IndexOf("}") + 1))
                    SublevelTreasureInfo = SublevelTreasureInfo.Substring(0, SublevelTreasureInfo.IndexOf("}") - 1)
                    SublevelTreasureInfo = SublevelTreasureInfo.Substring(SublevelTreasureInfo.IndexOf("{"), SublevelTreasureInfo.Length - SublevelTreasureInfo.IndexOf("{"))


                    Dim NumberCheck As Boolean = False
                    If IsNumeric(SublevelTreasureInfo.First) Then NumberCheck = True
                    While NumberCheck = False
                        SublevelTreasureInfo = SublevelTreasureInfo.TrimStart(SublevelTreasureInfo.First)
                        If IsNumeric(SublevelTreasureInfo.First) Then NumberCheck = True
                    End While

                    While SublevelTreasureInfo.Contains("#")
                        Dim SubTreasureInfoTest As String = SublevelTreasureInfo.Substring(SublevelTreasureInfo.IndexOf("#"), SublevelTreasureInfo.Length - (SublevelTreasureInfo.IndexOf("#") + 1))
                        If SubTreasureInfoTest.Contains("
") Then
                            SubTreasureInfoTest = SubTreasureInfoTest.Substring(0, SubTreasureInfoTest.IndexOf("
") + 1)
                        End If
                        SublevelTreasureInfo = SublevelTreasureInfo.Replace(SubTreasureInfoTest, "")
                    End While

                    SublevelTreasureInfo = SublevelTreasureInfo.Replace("	", "")
                    Dim TreasureInfoLines() As String = SublevelTreasureInfo.Split(Environment.NewLine.ToCharArray, System.StringSplitOptions.RemoveEmptyEntries)
                    TreasureInfoLines(0) = TreasureInfoLines(0).Replace(" ", "").Replace("	", "")
                    Dim TreasureInfoCount As Integer = Integer.Parse(TreasureInfoLines(0))
                    Dim x As Integer = 0
                    Dim line As Integer = 1
                    Dim AllTreasureInfoBuddies As String = ""
                    While x < TreasureInfoCount
                        NumberCheck = False
                        If IsNumeric(TreasureInfoLines(line).Last) Then NumberCheck = True
                        While NumberCheck = False
                            TreasureInfoLines(line) = TreasureInfoLines(line).TrimEnd(TreasureInfoLines(line).Last)
                            If IsNumeric(TreasureInfoLines(line).Last) Then NumberCheck = True
                        End While
                        AllTreasureInfoBuddies = AllTreasureInfoBuddies & TreasureInfoLines(line) & ";"
                        x += 1
                        line += 1
                    End While

                    'following for gates
                    Dim SublevelGateInfo As String = SublevelContents.Substring(SublevelContents.IndexOf("}") + 1, SublevelContents.Length - (SublevelContents.IndexOf("}") + 1))
                    SublevelGateInfo = SublevelGateInfo.Substring(SublevelGateInfo.IndexOf("}") + 1, SublevelGateInfo.Length - (SublevelGateInfo.IndexOf("}") + 1))
                    SublevelGateInfo = SublevelGateInfo.Substring(0, SublevelGateInfo.IndexOf("}") - 1)
                    SublevelGateInfo = SublevelGateInfo.Substring(SublevelGateInfo.IndexOf("{"), SublevelGateInfo.Length - SublevelGateInfo.IndexOf("{"))

                    NumberCheck = False
                    If IsNumeric(SublevelGateInfo.First) Then NumberCheck = True
                    While NumberCheck = False
                        SublevelGateInfo = SublevelGateInfo.TrimStart(SublevelGateInfo.First)
                        If IsNumeric(SublevelGateInfo.First) Then NumberCheck = True
                    End While

                    While SublevelGateInfo.Contains("#")
                        Dim SubTreasureInfoTest As String = SublevelGateInfo.Substring(SublevelGateInfo.IndexOf("#"), SublevelGateInfo.Length - (SublevelGateInfo.IndexOf("#") + 1))
                        If SubTreasureInfoTest.Contains("
") Then
                            SubTreasureInfoTest = SubTreasureInfoTest.Substring(0, SubTreasureInfoTest.IndexOf("
") + 1)
                        End If
                        SublevelGateInfo = SublevelGateInfo.Replace(SubTreasureInfoTest, "")
                    End While

                    SublevelGateInfo = SublevelGateInfo.Replace("	", "")
                    Dim GateInfoLines() As String = SublevelGateInfo.Split(Environment.NewLine.ToCharArray, System.StringSplitOptions.RemoveEmptyEntries)
                    GateInfoLines(0) = GateInfoLines(0).Replace(" ", "").Replace("	", "")
                    Dim GateInfoCount As Integer = Integer.Parse(GateInfoLines(0))
                    x = 0
                    line = 1
                    Dim AllGateInfoBuddies As String = ""
                    While x < GateInfoCount
                        NumberCheck = False
                        If IsNumeric(GateInfoLines(line).Last) Then NumberCheck = True
                        While NumberCheck = False
                            GateInfoLines(line) = GateInfoLines(line).TrimEnd(GateInfoLines(line).Last)
                            If IsNumeric(GateInfoLines(line).Last) Then NumberCheck = True
                        End While
                        NumberCheck = False
                        If IsNumeric(GateInfoLines(line + 1).Last) Then NumberCheck = True
                        While NumberCheck = False
                            GateInfoLines(line + 1) = GateInfoLines(line + 1).TrimEnd(GateInfoLines(line + 1).Last)
                            If IsNumeric(GateInfoLines(line + 1).Last) Then NumberCheck = True
                        End While
                        AllGateInfoBuddies = AllGateInfoBuddies & GateInfoLines(line) & "
" & GateInfoLines(line + 1) & ";"
                        x += 1
                        line += 2
                    End While




                    ''''Following is for cAPinfo

                    Dim SublevelCapInfo As String = SublevelContents.Substring(SublevelContents.IndexOf("}") + 1, SublevelContents.Length - (SublevelContents.IndexOf("}") + 1))
                    SublevelCapInfo = SublevelCapInfo.Substring(SublevelCapInfo.IndexOf("}") + 1, SublevelCapInfo.Length - (SublevelCapInfo.IndexOf("}") + 1))
                    SublevelCapInfo = SublevelCapInfo.Substring(SublevelCapInfo.IndexOf("}") + 1, SublevelCapInfo.Length - (SublevelCapInfo.IndexOf("}") + 1))
                    SublevelCapInfo = SublevelCapInfo.Substring(0, SublevelCapInfo.IndexOf("}") - 1)
                    SublevelCapInfo = SublevelCapInfo.Substring(SublevelCapInfo.IndexOf("{"), SublevelCapInfo.Length - SublevelCapInfo.IndexOf("{"))

                    NumberCheck = False
                    If IsNumeric(SublevelCapInfo.First) Then NumberCheck = True
                    While NumberCheck = False
                        SublevelCapInfo = SublevelCapInfo.TrimStart(SublevelCapInfo.First)
                        If IsNumeric(SublevelCapInfo.First) Then NumberCheck = True
                    End While

                    While SublevelCapInfo.Contains("#")
                        Dim subcapinfofiletest As String = SublevelCapInfo.Substring(SublevelCapInfo.IndexOf("#"), SublevelCapInfo.Length - (SublevelCapInfo.IndexOf("#") + 1))
                        If subcapinfofiletest.Contains("
") Then
                            subcapinfofiletest = subcapinfofiletest.Substring(0, subcapinfofiletest.IndexOf("
") + 1)
                        End If
                        SublevelCapInfo = SublevelCapInfo.Replace(subcapinfofiletest, "")
                    End While

                    SublevelCapInfo = SublevelCapInfo.Replace("	", "")

                    Dim CapInfoTextLines() As String = SublevelCapInfo.Split(Environment.NewLine.ToCharArray, System.StringSplitOptions.RemoveEmptyEntries)
                    CapInfoTextLines(0) = CapInfoTextLines(0).Replace(" ", "").Replace("	", "")
                    Dim SubCapInfoCount As Integer = Integer.Parse(CapInfoTextLines(0))
                    x = 0
                    line = 2
                    Dim allcapinfobuddies As String = ""
                    Dim allcapinfocounts As String = ""

                    While x < SubCapInfoCount
                        NumberCheck = False
                        If IsNumeric(CapInfoTextLines(line).Last) Then NumberCheck = True
                        While NumberCheck = False
                            CapInfoTextLines(line) = CapInfoTextLines(line).TrimEnd(CapInfoTextLines(line).Last)
                            If IsNumeric(CapInfoTextLines(line).Last) Then NumberCheck = True
                        End While
                        allcapinfobuddies = allcapinfobuddies & CapInfoTextLines(line) & "9;"

                        Dim determiningthecountval As String = CapInfoTextLines(line)

                        If determiningthecountval.Contains("$") Then
                            determiningthecountval = determiningthecountval.Substring(2, determiningthecountval.Length - 2)
                        End If

                        NumberCheck = False
                        If IsNumeric(determiningthecountval.First) Then NumberCheck = True
                        While NumberCheck = False
                            determiningthecountval = determiningthecountval.TrimStart(determiningthecountval.First)
                            If IsNumeric(determiningthecountval.First) Then NumberCheck = True
                        End While

                        NumberCheck = False
                        If IsNumeric(determiningthecountval.Last) Then NumberCheck = True
                        While NumberCheck = False
                            determiningthecountval = determiningthecountval.TrimEnd(determiningthecountval.Last)
                            If IsNumeric(determiningthecountval.Last) Then NumberCheck = True
                        End While

                        If determiningthecountval.Last = "0" Then
                            allcapinfocounts = allcapinfocounts & determiningthecountval.Substring(0, determiningthecountval.Length - 1) & ";"
                        Else
                            allcapinfocounts = allcapinfocounts & determiningthecountval.Substring(0, determiningthecountval.Length - 1) & " [weight=" & determiningthecountval.Last & "]" & ";"
                        End If

                        line += 3
                        x += 1
                    End While








                    '''''end of capinfo



                    Dim Padding As String

                    Padding = SublevelContents.Substring(0, SublevelContents.IndexOf("
") + 1)

                    Dim SublevelEntities As String = SublevelContents.Replace(Padding, "")
                    SublevelEntities = SublevelEntities.Replace("	", "")
                    SublevelEntities = SublevelEntities.Substring(0, SublevelEntities.IndexOf("}") - 1)
                    Dim LetterCheck As Boolean = False



                    If SublevelEntities > "" Then

                        'If System.Text.RegularExpressions.Regex.IsMatch(SublevelEntities.First, "^[A-Z ]+$") Then LetterCheck = True
                        'If System.Text.RegularExpressions.Regex.IsMatch(SublevelEntities.First, "^[a-z ]+$") Then LetterCheck = True
                        'While LetterCheck = False
                        '    SublevelEntities = SublevelEntities.TrimStart(SublevelEntities.First)
                        '    If System.Text.RegularExpressions.Regex.IsMatch(SublevelEntities.First, "^[A-Z ]+$") Then LetterCheck = True
                        '    If System.Text.RegularExpressions.Regex.IsMatch(SublevelEntities.First, "^[a-z ]+$") Then LetterCheck = True
                        'End While

                        Dim CaveNotes As String
                        If SublevelEntities.IndexOf("
") - SublevelEntities.IndexOf("#") < 1 Then

                        Else
                            If SublevelEntities.Contains("#") Then
                                CaveNotes = SublevelEntities.Substring(SublevelEntities.IndexOf("#"), SublevelEntities.IndexOf("
") - SublevelEntities.IndexOf("#"))
                                SublevelEntities = SublevelEntities.Replace(CaveNotes, "")
                            End If
                        End If

                        SublevelEntities = SublevelEntities.Replace(" #", "").Replace("# ", "").Replace("#", "").Replace("num", "").Replace("weight", "").Replace("type", "")
                        NumberCheck = False
                        If IsNumeric(SublevelEntities.Last) Then NumberCheck = True
                        While NumberCheck = False
                            SublevelEntities = SublevelEntities.TrimEnd(SublevelEntities.Last)
                            If IsNumeric(SublevelEntities.Last) Then NumberCheck = True
                        End While


                        Dim AllSublevelEntities As String = ""
                        Dim AllSublevelEntityCounts As String = ""
                        Dim EntityTextLines() As String = SublevelEntities.Split(Environment.NewLine.ToCharArray, System.StringSplitOptions.RemoveEmptyEntries)
                        Dim EntityCountTextLines() As String = SublevelEntities.Split(Environment.NewLine.ToCharArray, System.StringSplitOptions.RemoveEmptyEntries)
                        Dim linecount As Integer = 0


                        Dim item As String = ""
                        Dim item2 As String = ""
                        Dim item3 As String = ""
                        Dim item5 As String = ""
                        Dim i As Integer = 0
                        Dim i2 As Integer = 0
                        Dim i3 As Integer = 0
                        While i = 0

                            If EntityTextLines.Count > i2 Then
                                If EntityTextLines(i3 + 1).Contains("CCID") Then
                                    CaveNotes = EntityTextLines(i3 + 1).Substring(EntityTextLines(i3 + 1).IndexOf("CCID"), EntityTextLines(i3 + 1).Length - EntityTextLines(i3 + 1).IndexOf("CCID"))
                                    EntityTextLines(i3 + 1) = EntityTextLines(i3 + 1).Replace(CaveNotes, "")
                                End If


                                item = EntityTextLines(i3)
                                item2 = EntityTextLines(i3 + 1)
                                item3 = EntityCountTextLines(i3).Replace("$", "")

                                NumberCheck = False
                                If IsNumeric(item.Last) Then NumberCheck = True
                                While NumberCheck = False
                                    item = item.TrimEnd(item.Last)
                                    If IsNumeric(item.Last) Then NumberCheck = True
                                End While
                                NumberCheck = False
                                If IsNumeric(item2.Last) Then NumberCheck = True
                                While NumberCheck = False
                                    item2 = item2.TrimEnd(item2.Last)
                                    If IsNumeric(item2.Last) Then NumberCheck = True
                                End While

                                LetterCheck = False
                                If System.Text.RegularExpressions.Regex.IsMatch(item3.First, "^[A-Z ]+$") Then LetterCheck = True
                                If System.Text.RegularExpressions.Regex.IsMatch(item3.First, "^[a-z ]+$") Then LetterCheck = True
                                While LetterCheck = False
                                    item3 = item3.TrimStart(item3.First)
                                    If System.Text.RegularExpressions.Regex.IsMatch(item3.First, "^[A-Z ]+$") Then LetterCheck = True
                                    If System.Text.RegularExpressions.Regex.IsMatch(item3.First, "^[a-z ]+$") Then LetterCheck = True
                                End While
                                NumberCheck = False
                                If IsNumeric(item3.First) Then NumberCheck = True
                                While NumberCheck = False
                                    item3 = item3.TrimStart(item3.First)
                                    If IsNumeric(item3.First) Then NumberCheck = True
                                End While
                                NumberCheck = False
                                If IsNumeric(item3.Last) Then NumberCheck = True
                                While NumberCheck = False
                                    item3 = item3.TrimEnd(item3.Last)
                                    If IsNumeric(item3.Last) Then NumberCheck = True
                                End While
                                If item3.Contains(" ") Then
                                    item3 = item3.Substring(item3.IndexOf(" ") + 1, item3.Length - (item3.IndexOf(" ") + 1)).Replace(" ", "").Replace(" ", "")
                                End If
                                If item3.Length > 1 Then
                                    If item2 <> "6" Then
                                        If item3.Last = "0" Then
                                            item3 = item3.TrimEnd(item3.Last)
                                        Else
                                            item5 = item3.Substring(item3.Length - 1, 1)
                                            item3 = item3.Substring(0, item3.Length - 1)
                                            item3 = item3 & " [weight=" & item5 & "]"
                                        End If
                                    End If
                                Else
                                    Dim item4 As String = item
                                    LetterCheck = False
                                    If System.Text.RegularExpressions.Regex.IsMatch(item4.Last, "^[A-Z ]+$") Then LetterCheck = True
                                    If System.Text.RegularExpressions.Regex.IsMatch(item4.Last, "^[a-z ]+$") Then LetterCheck = True
                                    While LetterCheck = False
                                        item4 = item4.TrimEnd(item4.Last)
                                        If System.Text.RegularExpressions.Regex.IsMatch(item4.Last, "^[A-Z ]+$") Then LetterCheck = True
                                        If System.Text.RegularExpressions.Regex.IsMatch(item4.Last, "^[a-z ]+$") Then LetterCheck = True
                                    End While
                                    item4 = item4.Replace("$", "").Replace(" ", "")
                                    EntityIsDecoration = False
                                    If item2 = "6" Then EntityIsDecoration = True
                                    DecorationChecker = item4
                                    DecorationDetermination()
                                    If EntityIsDecoration = False Then
                                        item3 = " [weight=" & item3 & "]"
                                    End If
                                End If

                                i2 += 2
                                i3 += 2
                            Else
                                i = 1
                            End If

                            If i = 0 Then
                                AllSublevelEntities = AllSublevelEntities & item & item2 & ";"
                                AllSublevelEntityCounts = AllSublevelEntityCounts & item3 & ";"
                            End If
                        End While



                        SublevelTotalID += 1


                        AllSublevelEntities = AllSublevelEntities & allcapinfobuddies
                        AllSublevelEntityCounts = AllSublevelEntityCounts & allcapinfocounts

                        If AllSublevelEntities.Last = ";" Then AllSublevelEntities = AllSublevelEntities.TrimEnd(AllSublevelEntities.Last)
                        If AllSublevelEntityCounts.Last = ";" Then AllSublevelEntityCounts = AllSublevelEntityCounts.TrimEnd(AllSublevelEntityCounts.Last)
                        AllSublevelEntityCounts = AllSublevelEntityCounts.Replace(";;", ";")
                        AllSublevelEntities = AllSublevelEntities.Replace(";;", ";")
                        lst_RegularEntities.Items.Add(lst_Sublevel_IDs.SelectedItem & " - " & AllSublevelEntities)
                        lst_RegularEntitiesCounts.Items.Add(lst_Sublevel_IDs.SelectedItem & " - " & AllSublevelEntityCounts)
                        If AllTreasureInfoBuddies.Length > 0 Then
                            If AllTreasureInfoBuddies.Last = ";" Then AllTreasureInfoBuddies = AllTreasureInfoBuddies.TrimEnd(AllTreasureInfoBuddies.Last)
                            lst_TreasureSets.Items.Add(lst_Sublevel_IDs.SelectedItem & " - " & AllTreasureInfoBuddies)
                        Else
                            lst_TreasureSets.Items.Add(lst_Sublevel_IDs.SelectedItem & " - ")
                        End If
                        If AllGateInfoBuddies.Length > 0 Then
                            If AllGateInfoBuddies.Last = ";" Then AllGateInfoBuddies = AllGateInfoBuddies.TrimEnd(AllGateInfoBuddies.Last)
                            lst_GateSets.Items.Add(lst_Sublevel_IDs.SelectedItem & " - " & AllGateInfoBuddies)
                        Else
                            lst_GateSets.Items.Add(lst_Sublevel_IDs.SelectedItem & " - ")
                        End If

                        lst_Sublevel_IDs.SelectedIndex = -1
                        lst_Sublevels.SelectedIndex = lst_Sublevels.Items.Count - 1
                    Else
                        SublevelTotalID += 1
                        lst_RegularEntities.Items.Add(lst_Sublevel_IDs.SelectedItem & " - ")
                        lst_RegularEntitiesCounts.Items.Add(lst_Sublevel_IDs.SelectedItem & " - ")
                        lst_TreasureSets.Items.Add(lst_Sublevel_IDs.SelectedItem & " - ")
                        lst_GateSets.Items.Add(lst_Sublevel_IDs.SelectedItem & " - ")
                        lst_Sublevel_IDs.SelectedIndex = -1
                        lst_Sublevels.SelectedIndex = lst_Sublevels.Items.Count - 1
                    End If
                Else
                    MsgBox("There appears to be an issue with {f000} on Sublevel " & SublevelTotal & " in this cave file.")
                    SublevelTotal = 99999999
                    SublevelTotalID = 99999999

                    lst_Sublevels.Items.Clear()
                    lst_Sublevel_IDs.Items.Clear()
                    lst_SublevelNames.Items.Clear()
                    lst_RegularEntities.Items.Clear()
                    lst_RegularEntitiesCounts.Items.Clear()
                    lst_f2_CustomEntityTotal.Items.Clear()
                    lst_f5_RoomCount.Items.Clear()
                    lst_f6_Ratio.Items.Clear()
                    lst_f7_Geyser.Items.Clear()
                    lst_f8_UnitFile.Items.Clear()
                    lst_f9_LightFile.Items.Clear()
                    lst_f10_CloggedHole.Items.Clear()
                    lst_f12_MusicType.Items.Clear()
                    lst_f13_SolidPlane.Items.Clear()
                    lst_f14_DeadEndCount.Items.Clear()
                    lst_f16_WaterwraithTimer.Items.Clear()
                    lst_f17_Seesaw.Items.Clear()
                    lst_fa_Skybox.Items.Clear()
                    lst_CustomEntityTotal_Check.Items.Clear()
                    lst_totaka_MusicList.Items.Clear()

                    btn_Save.Enabled = False
                End If

            End While

            If SublevelTotal < 99999999 Then
                lbl_SublevelTotal.Text = SublevelTotal & " Sublevels"
                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            Else
                SublevelTotal = 0
                SublevelTotalID = 0
            End If


            cmb_Sublevels.SelectedIndex = -1

            DeselectLists()

        Else

            MsgBox("This file is incompatible with Cave Creator.")

        End If

        lbl_SublevelID.Text = "Nothing Selected"
        lbl_EntityCount.Text = ""
        lbl_TotalEntityCount.Text = ""
        lst_RegularEntitiesNormList.Items.Clear()
    End Sub
    Private Sub btn_Save_Click(sender As Object, e As EventArgs) Handles btn_Save.Click
        btn_Focus.Select()
        SaveData()
    End Sub
    Private Sub btn_DebugMode_Click(sender As Object, e As EventArgs) Handles btn_DebugMode.Click
        If btn_DebugMode.Text = "Debug Mode" Then
            Me.MaximumSize = New Size(0, 0)
            pnl_Debug.Location = New Point(1000, 52)
            pnl_Debug.Visible = True
            btn_DebugMode.Text = "Normal Mode"
            Me.Size = New Size(1506, 600)
            Me.CenterToScreen()
        Else
            pnl_Debug.Location = New Point(0, 0)
            pnl_Debug.Visible = False
            btn_DebugMode.Text = "Debug Mode"
            Me.Size = New Size(810, 562)
            Me.MaximumSize = New Size(810, 562)
            Me.CenterToScreen()
        End If

        Me.DoubleBuffered = True
    End Sub
    Private Sub btn_Export_Click(sender As Object, e As EventArgs)
        If lst_Sublevels.Items.Count = 0 Then
            MsgBox("You need at least one sublevel.")
        Else
        End If
    End Sub
    Private Sub AddToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem.Click
        If SublevelTotal = 0 Then
            lst_RegularEntitiesCounts.Items.Clear()
        End If
        If chk_SublevelNameInput.Checked = False Then
            ClickedAddSublevelWithNameInput = True
            btn_AddSublevel2.Size = New Size(30, 30)
            btn_AddSublevel2.Location = New Point(6, 354)
            SublevelName = "InvalidCode:gGSgs9a56FAUJHGAhgAK7AbGA8776uha878ga7gG7ga8a8ag7A8AiA8a7tF"
            While SublevelName = "InvalidCode:gGSgs9a56FAUJHGAhgAK7AbGA8776uha878ga7gG7ga8a8ag7A8AiA8a7tF"
                SublevelName = InputBox("Name your sublevel so you can distinguish it from other sublevels." & vbCrLf & vbCrLf & "This will not be present in-game.")
                If SublevelName.Contains("|") AndAlso SublevelName.Contains("{") Then
                    MsgBox("The line character | and the open brace character { cannot be used (the close brace } can be used though). Please input a new name.")
                    SublevelName = "InvalidCode:gGSgs9a56FAUJHGAhgAK7AbGA8776uha878ga7gG7ga8a8ag7A8AiA8a7tF"
                End If
                If SublevelName.Contains("|") Then
                    MsgBox("The line character | cannot be used. Please input a new name.")
                    SublevelName = "InvalidCode:gGSgs9a56FAUJHGAhgAK7AbGA8776uha878ga7gG7ga8a8ag7A8AiA8a7tF"
                End If
                If SublevelName.Contains("{") Then
                    MsgBox("The open brace character { cannot be used (the close brace } can be used though). Please input a new name.")
                    SublevelName = "InvalidCode:gGSgs9a56FAUJHGAhgAK7AbGA8776uha878ga7gG7ga8a8ag7A8AiA8a7tF"
                End If
            End While

            btn_AddSublevel2.Size = New Size(30, 30)
            btn_AddSublevel2.Location = New Point(6, 354)
            If SublevelName = "" Then
            Else
                SublevelName = " - " & SublevelName
                If lst_Sublevels.SelectedIndex > -1 Then
                    DeselectLists()
                End If
                SublevelTotal += 1
                SublevelTotalID += 1
                lst_Sublevels.Items.Add("Sublevel " & SublevelTotal & SublevelName)
                lst_Sublevel_IDs.Items.Add("S" & SublevelTotalID)
                lst_SublevelNames.Items.Add(SublevelName)
                If SublevelTotal = 1 Then
                    lbl_SublevelTotal.Text = SublevelTotal & " Sublevel"
                Else
                    lbl_SublevelTotal.Text = SublevelTotal & " Sublevels"
                End If
                lst_Sublevel_IDs.SelectedIndex = lst_Sublevel_IDs.Items.Count - 1
                lst_RegularEntities.Items.Add(lst_Sublevel_IDs.SelectedItem & " - ")
                lst_RegularEntitiesCounts.Items.Add(lst_Sublevel_IDs.SelectedItem & " - ")

                lst_f5_RoomCount.Items.Add("1")
                lst_f6_Ratio.Items.Add("0.1")
                lst_f7_Geyser.Items.Add("0")
                lst_f8_UnitFile.Items.Add("1_ABE_ari_metal.txt")
                lst_f9_LightFile.Items.Add("normal_light_lv0.ini")
                lst_fa_Skybox.Items.Add("none")
                lst_f10_CloggedHole.Items.Add("0")
                lst_f12_MusicType.Items.Add("0")
                lst_f13_SolidPlane.Items.Add("0")
                lst_f14_DeadEndCount.Items.Add("50")
                lst_f16_WaterwraithTimer.Items.Add("0")
                lst_f17_Seesaw.Items.Add("0")
                lst_totaka_MusicList.Items.Add("caveconc_00_0.cnd")
                lst_f2_CustomEntityTotal.Items.Add("0")
                lst_CustomEntityTotal_Check.Items.Add("0")

                lst_f5_RoomCount.SelectedIndex = lst_Sublevels.Items.Count - 1
                lst_f6_Ratio.SelectedIndex = lst_Sublevels.Items.Count - 1
                lst_f7_Geyser.SelectedIndex = lst_Sublevels.Items.Count - 1
                lst_f8_UnitFile.SelectedIndex = lst_Sublevels.Items.Count - 1
                lst_f9_LightFile.SelectedIndex = lst_Sublevels.Items.Count - 1
                lst_fa_Skybox.SelectedIndex = lst_Sublevels.Items.Count - 1
                lst_f10_CloggedHole.SelectedIndex = lst_Sublevels.Items.Count - 1
                lst_f12_MusicType.SelectedIndex = lst_Sublevels.Items.Count - 1
                lst_f13_SolidPlane.SelectedIndex = lst_Sublevels.Items.Count - 1
                lst_f14_DeadEndCount.SelectedIndex = lst_Sublevels.Items.Count - 1
                lst_f16_WaterwraithTimer.SelectedIndex = lst_Sublevels.Items.Count - 1
                lst_f17_Seesaw.SelectedIndex = lst_Sublevels.Items.Count - 1
                lst_totaka_MusicList.SelectedIndex = lst_Sublevels.Items.Count - 1
                lst_f2_CustomEntityTotal.SelectedIndex = lst_Sublevels.Items.Count - 1
                lst_CustomEntityTotal_Check.SelectedIndex = lst_Sublevels.Items.Count - 1

                lst_TreasureSets.Items.Add(lst_Sublevel_IDs.SelectedItem & " - ")
                lst_TreasureSets.SelectedIndex = lst_Sublevels.Items.Count - 1
                lst_GateSets.Items.Add(lst_Sublevel_IDs.SelectedItem & " - ")
                lst_GateSets.SelectedIndex = lst_Sublevels.Items.Count - 1


                lst_Sublevel_IDs.SelectedIndex = -1
                lst_Sublevels.SelectedIndex = lst_Sublevels.Items.Count - 1
            End If
        Else
            ClickedAddSublevelWithNameInput = False
            If lst_Sublevels.SelectedIndex > -1 Then
                DeselectLists()
            End If
            SublevelTotal += 1
            SublevelTotalID += 1
            lst_Sublevels.Items.Add("Sublevel " & SublevelTotal)
            lst_Sublevel_IDs.Items.Add("S" & SublevelTotalID)
            SublevelName = " "
            lst_SublevelNames.Items.Add(SublevelName)
            If SublevelTotal = 1 Then
                lbl_SublevelTotal.Text = SublevelTotal & " Sublevel"
            Else
                lbl_SublevelTotal.Text = SublevelTotal & " Sublevels"
            End If
            lst_Sublevel_IDs.SelectedIndex = lst_Sublevel_IDs.Items.Count - 1
            lst_RegularEntities.Items.Add(lst_Sublevel_IDs.SelectedItem & " - ")
            lst_RegularEntitiesCounts.Items.Add(lst_Sublevel_IDs.SelectedItem & " - ")

            lst_f5_RoomCount.Items.Add("1")
            lst_f6_Ratio.Items.Add("0.2")
            lst_f7_Geyser.Items.Add("0")
            lst_f8_UnitFile.Items.Add("1_ABE_ari_metal.txt")
            lst_f9_LightFile.Items.Add("normal_light_lv0.ini")
            lst_fa_Skybox.Items.Add("none")
            lst_f10_CloggedHole.Items.Add("0")
            lst_f12_MusicType.Items.Add("0")
            lst_f13_SolidPlane.Items.Add("0")
            lst_f14_DeadEndCount.Items.Add("50")
            lst_f16_WaterwraithTimer.Items.Add("0")
            lst_f17_Seesaw.Items.Add("0")
            lst_totaka_MusicList.Items.Add("caveconc_00_0.cnd")
            lst_f2_CustomEntityTotal.Items.Add("null")
            lst_CustomEntityTotal_Check.Items.Add("0")

            lst_f5_RoomCount.SelectedIndex = lst_Sublevels.Items.Count - 1
            lst_f6_Ratio.SelectedIndex = lst_Sublevels.Items.Count - 1
            lst_f7_Geyser.SelectedIndex = lst_Sublevels.Items.Count - 1
            lst_f8_UnitFile.SelectedIndex = lst_Sublevels.Items.Count - 1
            lst_f9_LightFile.SelectedIndex = lst_Sublevels.Items.Count - 1
            lst_fa_Skybox.SelectedIndex = lst_Sublevels.Items.Count - 1
            lst_f10_CloggedHole.SelectedIndex = lst_Sublevels.Items.Count - 1
            lst_f12_MusicType.SelectedIndex = lst_Sublevels.Items.Count - 1
            lst_f13_SolidPlane.SelectedIndex = lst_Sublevels.Items.Count - 1
            lst_f14_DeadEndCount.SelectedIndex = lst_Sublevels.Items.Count - 1
            lst_f16_WaterwraithTimer.SelectedIndex = lst_Sublevels.Items.Count - 1
            lst_f17_Seesaw.SelectedIndex = lst_Sublevels.Items.Count - 1
            lst_totaka_MusicList.SelectedIndex = lst_Sublevels.Items.Count - 1
            lst_f2_CustomEntityTotal.SelectedIndex = lst_Sublevels.Items.Count - 1
            lst_CustomEntityTotal_Check.SelectedIndex = lst_Sublevels.Items.Count - 1

            lst_TreasureSets.Items.Add(lst_Sublevel_IDs.SelectedItem & " - ")
            lst_TreasureSets.SelectedIndex = lst_Sublevels.Items.Count - 1
            lst_GateSets.Items.Add(lst_Sublevel_IDs.SelectedItem & " - ")
            lst_GateSets.SelectedIndex = lst_Sublevels.Items.Count - 1


            lst_Sublevel_IDs.SelectedIndex = -1
            lst_Sublevels.SelectedIndex = lst_Sublevels.Items.Count - 1
        End If

        If lst_Sublevels.Items.Count = 0 Then
            btn_Save.Enabled = False
        Else
            btn_SaveAs.Enabled = True
            If CaveNeedsToSaveAs = False Then btn_Save.Enabled = True
        End If
    End Sub
    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        Dim YesDeleteSublevel As Boolean = False
        If lst_Sublevels.SelectedIndex > -1 Then
            If chk_DeleteSublevelQ.Checked = True Then
                YesDeleteSublevel = True
                ClickedAddSublevelWithNameInput = False
            Else
                ClickedAddSublevelWithNameInput = True
                Dim result As Integer = MessageBox.Show("Are you sure you want to delete " & lst_Sublevels.SelectedItem & "?" & vbCrLf & vbCrLf & "This will be permanent.", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)
                btn_RemoveSublevel2.Size = New Size(30, 30)
                btn_RemoveSublevel2.Location = New Point(42, 354)
                If result = DialogResult.Yes Then
                    YesDeleteSublevel = True
                End If
            End If
        End If

        If YesDeleteSublevel = True Then
            SublevelTotal -= 1
            If SublevelTotal = 1 Then
                lbl_SublevelTotal.Text = SublevelTotal & " Sublevel"
            Else
                lbl_SublevelTotal.Text = SublevelTotal & " Sublevels"
            End If
            '''''' THIS AREA WILL BE DEDICATED TO CLEARING OUT THE DATA FROM THE EDIT SUBLEVEL SECTION, THEN IT WILL SHIFT THE DATA FROM SUBLEVELS AFTER THE DELETED ONE DOWN
            lst_TreasureSets.Items.RemoveAt(lst_TreasureSets.SelectedIndex)
            lst_Sublevels.Items.RemoveAt(lst_Sublevels.SelectedIndex) ''''' THIS IS REMOVAL OF THAT PARTICULAR SUBLEVEL FROM THE LISTBOX
            lst_Sublevel_IDs.Items.RemoveAt(lst_Sublevel_IDs.SelectedIndex)
            lst_SublevelNames.Items.RemoveAt(lst_SublevelNames.SelectedIndex)
            lst_RegularEntities.Items.RemoveAt(lst_RegularEntities.SelectedIndex)
            lst_RegularEntitiesCounts.Items.RemoveAt(lst_RegularEntitiesCounts.SelectedIndex)

            lst_f2_CustomEntityTotal.Items.RemoveAt(lst_f2_CustomEntityTotal.SelectedIndex)
            lst_f5_RoomCount.Items.RemoveAt(lst_f5_RoomCount.SelectedIndex)
            lst_f6_Ratio.Items.RemoveAt(lst_f6_Ratio.SelectedIndex)
            lst_f7_Geyser.Items.RemoveAt(lst_f7_Geyser.SelectedIndex)
            lst_f8_UnitFile.Items.RemoveAt(lst_f8_UnitFile.SelectedIndex)
            lst_f9_LightFile.Items.RemoveAt(lst_f9_LightFile.SelectedIndex)
            lst_f10_CloggedHole.Items.RemoveAt(lst_f10_CloggedHole.SelectedIndex)
            lst_f12_MusicType.Items.RemoveAt(lst_f12_MusicType.SelectedIndex)
            lst_f13_SolidPlane.Items.RemoveAt(lst_f13_SolidPlane.SelectedIndex)
            lst_f14_DeadEndCount.Items.RemoveAt(lst_f14_DeadEndCount.SelectedIndex)
            lst_f16_WaterwraithTimer.Items.RemoveAt(lst_f16_WaterwraithTimer.SelectedIndex)
            lst_f17_Seesaw.Items.RemoveAt(lst_f17_Seesaw.SelectedIndex)
            lst_fa_Skybox.Items.RemoveAt(lst_fa_Skybox.SelectedIndex)
            lst_totaka_MusicList.Items.RemoveAt(lst_totaka_MusicList.SelectedIndex)
            lst_CustomEntityTotal_Check.Items.RemoveAt(lst_CustomEntityTotal_Check.SelectedIndex)


            Dim NewSublevelTotal As Integer = 0
            lst_Sublevels.Items.Clear()
            lst_SublevelNames.SelectedIndex = -1
            While lst_Sublevels.Items.Count < SublevelTotal
                NewSublevelTotal += 1
                lst_SublevelNames.SelectedIndex += 1
                lst_Sublevels.Items.Add("Sublevel " & NewSublevelTotal & lst_SublevelNames.SelectedItem)
                If SublevelTotal = 1 Then
                    lbl_SublevelTotal.Text = NewSublevelTotal & " Sublevel"
                Else
                    lbl_SublevelTotal.Text = NewSublevelTotal & " Sublevels"
                End If
            End While
            lst_SublevelNames.SelectedIndex = -1
        End If


        If lst_Sublevels.Items.Count = 0 Then
            btn_Save.Enabled = False
        Else
            btn_SaveAs.Enabled = True
            If CaveNeedsToSaveAs = False Then btn_Save.Enabled = True
        End If
    End Sub
    Public Sub ExportCave()
        TabControl1.SelectedTab = tbp_SublevelManager
        FullCave = "# CaveInfo
{
	{c000} 4 " & SublevelTotal & " 	# SublevelCount
	{_eof} 
}
" & SublevelTotal & " "
        lst_Sublevels.SelectedIndex = -1
        cmb_Sublevels.SelectedIndex = -1



        pnl_PROCESSINGTHECAVE.Location = TabControl1.Location
        pnl_PROCESSINGTHECAVE.Visible = True

        Dim i As Integer = 0
        While i < SublevelTotal


            Dim HasKey As Boolean = False
            i += 1
            lst_Sublevels.SelectedIndex = i - 1
            cmb_Sublevels.SelectedIndex = i - 1
            EnterSublevelEntities()
            'If cmb_Sublevels.SelectedIndex = -1 Then lst_RegularEntitiesNormList.Items.Clear()
            'MsgBox(cmb_Sublevels.Items.Item(i))
            Dim CavesEntitiesFinalTotal As Integer
            If lst_CustomEntityTotal_Check.SelectedItem = 0 Then
                CavesEntitiesFinalTotal = lbl_TotalEntityCount.Text.Replace("Total Entities: ", "").Replace(" + weighted entities", "")
            Else
                CavesEntitiesFinalTotal = lst_f2_CustomEntityTotal.SelectedItem
            End If

            FullCave = FullCave & "# FloorInfo
{
	{f000} 4 " & i - 1 & " # CurrentSublevelIndex
	{f001} 4 " & i - 1 & " # CurrentSublevelIndex
	{f002} 4 " & CavesEntitiesFinalTotal & " # EntityTotal
	{f003} 4 " & lst_Treasures.Items.Count & " # TreasureTotal
	{f004} 4 " & lst_Gates.Items.Count & " # GateTotal
	{f005} 4 " & lst_f5_RoomCount.SelectedItem & " # RoomTotal
	{f006} 4 " & lst_f6_Ratio.SelectedItem & " # CorridorRatio
	{f007} 4 " & lst_f7_Geyser.SelectedItem & " # Geyser
	{f008} -1 " & lst_f8_UnitFile.SelectedItem & " # UnitFile
	{f009} -1 " & lst_f9_LightFile.SelectedItem & " # LightFile
	{f00A} -1 " & lst_fa_Skybox.SelectedItem & " # Skybox
	{f010} 4 " & lst_f10_CloggedHole.SelectedItem & " # CloggedHole
	{f011} 4 0 # Unknown
	{f012} 4 " & lst_f12_MusicType.SelectedItem & " # MusicType
	{f013} 4 " & lst_f13_SolidPlane.SelectedItem & " # SolidPlane
    {f014} 4 " & lst_f14_DeadEndCount.SelectedItem & " # DeadEndTotal
	{f015} 4 1 # Version(0=IgnoreCapInfo)
	{f016} 4 " & lst_f16_WaterwraithTimer.SelectedItem & " # WaterwraithTimer
	{f017} 4 " & lst_f17_Seesaw.SelectedItem & " # Seesaw(1=True)
	{_eof} 
}
# TekiInfo
{
	"

            Dim EntitySection As String = ""
            Dim CapInfo As String = " # num"
            Dim HashNumEntVal As Integer = 0
            Dim HashNumCapVal As Integer = 0

            lst_RegularEntitiesList.SelectedIndex = -1
            Dim i2 As Integer = 0
            While i2 < lst_RegularEntitiesList.Items.Count
                i2 += 1
                lst_RegularEntitiesList.SelectedIndex += 1
                If lst_RegularEntitiesList.SelectedItem.ToString.Last = "9" Then
                    HashNumCapVal += 1
                    If lst_RegularEntitiesList.SelectedItem.ToString.Contains("
") Then
                        CapInfo = CapInfo & "
	" & "0 # captype
	" & lst_RegularEntitiesList.SelectedItem.ToString.Substring(0, lst_RegularEntitiesList.SelectedItem.ToString.IndexOf("
")) & " # weight
	1 # type"
                    Else
                        CapInfo = CapInfo & "
	" & "0 # captype
	" & lst_RegularEntitiesList.SelectedItem.ToString.Substring(0, lst_RegularEntitiesList.SelectedItem.ToString.Length - 2) & " # weight
	1 # type"
                    End If



                Else
                    HashNumEntVal += 1
                    If lst_RegularEntitiesList.SelectedIndex = i2 Then
                        EntitySection = EntitySection & "	" & lst_RegularEntitiesList.SelectedItem & " # type
"
                    Else
                        If lst_RegularEntitiesList.SelectedItem.contains("
") Then
                            EntitySection = EntitySection & "	" & lst_RegularEntitiesList.SelectedItem.ToString.Substring(0, lst_RegularEntitiesList.SelectedItem.ToString.Length - 3) & " # weight
	" & lst_RegularEntitiesList.SelectedItem.ToString.Substring(lst_RegularEntitiesList.SelectedItem.ToString.Length - 1, 1) & " # type
"
                        Else
                            EntitySection = EntitySection & "	" & lst_RegularEntitiesList.SelectedItem.ToString.Substring(0, lst_RegularEntitiesList.SelectedItem.ToString.Length - 1) & " # weight
	" & lst_RegularEntitiesList.SelectedItem.ToString.Substring(lst_RegularEntitiesList.SelectedItem.ToString.Length - 1, 1) & " # type
"
                        End If
                    End If
                End If
                If chk_IgnoreTheKey.Checked = False Then
                    If HasKey = False Then
                        If EntitySection.Contains("key") Then
                            HasKey = True
                        Else
                            HasKey = False
                        End If
                    End If
                End If
                If chk_IgnoreTheKey.Checked = False Then
                    If HasKey = False Then
                        If CapInfo.Contains("key") Then
                            HasKey = True
                        Else
                            HasKey = False
                        End If
                    End If
                End If
            End While


            FullCave = FullCave & HashNumEntVal & " # num
" & EntitySection


            TabControl1.SelectedTab = tbp_SublevelManager

            FullCave = FullCave & "}
# ItemInfo
{
	" & lst_Treasures.Items.Count & " # num
"
            lst_Treasures.SelectedIndex = -1
            Dim TreasureInfo As String = ""
            Dim x2 As Integer = 0
            While x2 < lst_Treasures.Items.Count
                lst_Treasures.SelectedIndex += 1
                TreasureInfo = TreasureInfo & "	" & lst_Treasures.SelectedItem & " # weight
"
                x2 += 1
            End While
            lst_Treasures.SelectedIndex = -1
            If chk_IgnoreTheKey.Checked = False Then
                If HasKey = False Then
                    If TreasureInfo.Contains("key") Then
                        HasKey = True
                    Else
                        HasKey = False
                    End If
                End If
            End If

            FullCave = FullCave & TreasureInfo & "}
# GateInfo
{
	" & lst_Gates.Items.Count & " # num
"
            lst_Gates.SelectedIndex = -1
            Dim GateInfo As String = ""
            Dim x3 As Integer = 0
            While x3 < lst_Gates.Items.Count
                lst_Gates.SelectedIndex += 1
                GateInfo = GateInfo & "	" & lst_Gates.SelectedItem.ToString.Substring(0, lst_Gates.SelectedItem.ToString.IndexOf("
")) & " # life
	1 # weight
"
                x3 += 1
            End While
            lst_Gates.SelectedIndex = -1
            EnterSublevelEntities()
            If cmb_Sublevels.SelectedIndex = -1 Then lst_RegularEntitiesNormList.Items.Clear()

            If chk_IgnoreTheKey.Checked = False Then
                If HasKey = False Then
                    If GateInfo.Contains("key") Then
                        HasKey = True
                    Else
                        HasKey = False
                    End If
                End If
            End If

            FullCave = FullCave & GateInfo & "}
# CapInfo
{
	" & HashNumCapVal & CapInfo & "
}
"
            EnterSublevelManager()
            Dim caveProcessProgress As Integer = (i / SublevelTotal) * 100

            If chk_IgnoreTheKey.Checked = False Then
                If opt_ChallengeMode.Checked = False Then
                    HasKey = True
                End If
                If HasKey = False Then
                    Dim sublevelwithoutkey As Integer = i
                    i = SublevelTotal
                    TabControl1.SelectedTab = tbp_ImportManager
                    pnl_PROCESSINGTHECAVE.Visible = False
                    Me.Opacity = 1
                    Me.Show()
                    Me.Visible = True
                    Me.ShowInTaskbar = True
                    MsgBox("Sublevel " & sublevelwithoutkey.ToString & " does not contain The Key!
All sublevels in a Challenge Mode cave must contain The Key.

Cave was not imported.")
                End If
            Else
                HasKey = True
            End If

            If HasKey = True Then
                If i = SublevelTotal Then

                    TabControl1.SelectedTab = tbp_ImportManager
                    'Me.Opacity = 1
                    'ExportCaveProcess.btn_OK.Enabled = True
                    'ExportCaveProcess.lbl_ProcessingSublevels.Text = " Processing complete!"
                    'ExportCaveProcess.lbl_pleaseWait.Text = ""
                    'Me.Show()
                    'Me.Visible = True
                    'Me.ShowInTaskbar = True
                    'ExportCaveProcess.Select()
                    pnl_PROCESSINGTHECAVE.Visible = False
                    If exportwindowshow = True Then
                        If (ExportAsDialog.ShowDialog() = DialogResult.OK) Then
                            My.Computer.FileSystem.WriteAllText(ExportAsDialog.FileName, FullCave, False, System.Text.Encoding.GetEncoding(932))
                        End If
                    Else

                        If MainMenu.CustomDirOptions.Count >= 3 Then
                            My.Computer.FileSystem.WriteAllText(MainMenu.CustomDirOptions(0) & CaveFile, FullCave, False, System.Text.Encoding.GetEncoding(932))
                        Else
                            My.Computer.FileSystem.WriteAllText(RootDirectory & "\user\Mukki\mapunits\caveinfo\" & CaveFile, FullCave, False, System.Text.Encoding.GetEncoding(932))
                        End If
                        'MsgBox("Processing complete.")
                        If ProcessCaveMessage = False Then
                            ProcessCaveMessage = True
                            CloseWithoutClosingDONTASKTOSAVE()
                        End If
                    End If

                    'ExportCaveProcess.Visible = False
                    'ExportCaveProcess.ShowDialog()
                    'ExportCaveProcess.btn_OK.Enabled = False
                    'ExportCaveProcess.lbl_ProcessingSublevels.Text = "Processing sublevels..."
                    'ExportCaveProcess.lbl_pleaseWait.Text = "Please wait"
                End If
            End If
        End While
    End Sub
    Sub CloseWithoutClosingDONTASKTOSAVE()
        pressedMainMenu = True
        Dim result As Integer = DialogResult.Yes
        If result = DialogResult.Yes Then
            SublevelTotal = 0
            SublevelTotalID = 0
            lbl_SublevelTotal.Text = SublevelTotal & " Sublevels"
            If lst_Sublevels.Items.Count > 0 Then
                lst_Sublevels.SelectedIndex = 0
                lst_Sublevels.Items.RemoveAt(lst_Sublevels.SelectedIndex)
            End If
            lst_Sublevels.Items.Clear()
            lst_Sublevel_IDs.Items.Clear()
            lst_SublevelNames.Items.Clear()
            lst_RegularEntities.Items.Clear()
            lst_RegularEntitiesCounts.Items.Clear()
            lst_f2_CustomEntityTotal.Items.Clear()
            lst_f5_RoomCount.Items.Clear()
            lst_f6_Ratio.Items.Clear()
            lst_f7_Geyser.Items.Clear()
            lst_f8_UnitFile.Items.Clear()
            lst_f9_LightFile.Items.Clear()
            lst_f10_CloggedHole.Items.Clear()
            lst_f12_MusicType.Items.Clear()
            lst_f12_MusicType.Items.Clear()
            lst_f13_SolidPlane.Items.Clear()
            lst_f14_DeadEndCount.Items.Clear()
            lst_f16_WaterwraithTimer.Items.Clear()
            lst_f17_Seesaw.Items.Clear()
            lst_fa_Skybox.Items.Clear()
            lst_CustomEntityTotal_Check.Items.Clear()
            lst_totaka_MusicList.Items.Clear()

            btn_Save.Enabled = False


            Me.Refresh()
            Me.Hide()
            SublevelGates.Close()
            SublevelTreasures.Close()
            Me.Close()
        End If
        pressedMainMenu = False
    End Sub
    Public ProcessCaveMessage As Boolean = True
    Private Sub btn_ReturnToMainMenu_Click(sender As Object, e As EventArgs) Handles btn_ReturnToMainMenu.Click
        pressedMainMenu = True
        Dim result As Integer
        If lst_Sublevels.Items.Count > 0 Then
            result = MessageBox.Show("Are you sure you want to delete all of your sublevels?" & vbCrLf & vbCrLf & "This will be permanent.", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)
        Else
            result = DialogResult.Yes
        End If
        If result = DialogResult.Yes Then
            SublevelTotal = 0
            SublevelTotalID = 0
            lbl_SublevelTotal.Text = SublevelTotal & " Sublevels"
            If lst_Sublevels.Items.Count > 0 Then
                lst_Sublevels.SelectedIndex = 0
                lst_Sublevels.Items.RemoveAt(lst_Sublevels.SelectedIndex)
            End If
            lst_Sublevels.Items.Clear()
            lst_Sublevel_IDs.Items.Clear()
            lst_SublevelNames.Items.Clear()
            lst_RegularEntities.Items.Clear()
            lst_RegularEntitiesCounts.Items.Clear()
            lst_f2_CustomEntityTotal.Items.Clear()
            lst_f5_RoomCount.Items.Clear()
            lst_f6_Ratio.Items.Clear()
            lst_f7_Geyser.Items.Clear()
            lst_f8_UnitFile.Items.Clear()
            lst_f9_LightFile.Items.Clear()
            lst_f10_CloggedHole.Items.Clear()
            lst_f12_MusicType.Items.Clear()
            lst_f12_MusicType.Items.Clear()
            lst_f13_SolidPlane.Items.Clear()
            lst_f14_DeadEndCount.Items.Clear()
            lst_f16_WaterwraithTimer.Items.Clear()
            lst_f17_Seesaw.Items.Clear()
            lst_fa_Skybox.Items.Clear()
            lst_CustomEntityTotal_Check.Items.Clear()
            lst_totaka_MusicList.Items.Clear()

            btn_Save.Enabled = False


            Me.Refresh()
            Me.Hide()
            SublevelGates.Close()
            SublevelTreasures.Close()
            btn_Focus.Select()
            MainMenu.Show()
            MainMenu.Select()
            'MainMenu.Size = New Size(548, 344)
            Dim tmr As New Timer
            tmr.Interval = 1
            tmr.Start()
            AddHandler tmr.Tick, Sub()
                                     MainMenu.Select()
                                     MainMenu.Opacity += 0.08
                                     If MainMenu.Opacity >= 1 Then
                                         tmr.Stop()
                                         MainMenu.Opacity = 1
                                         btn_ReturnToMainMenu.Enabled = False
                                     End If
                                 End Sub
            MainMenu.Select()
            Me.Close()
        End If
        pressedMainMenu = False
    End Sub

    Private Sub lnk_ExportHelp_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnk_ExportHelp.LinkClicked
        MsgBox("Did you know this tool can import everything properly for you? You just need to load your root folder into the Cave Importer (bottom-right), choose which cave to replace and then click import.


However, you may be wanting to export the cave's text file and import it manually or share it.

In the case of sharing, it's recommended that you save your cave as a project file and share that as it allows other users to easily import everything correctly.

Otherwise, if you really want the text file, open up the Cave Importer and check the box that says ""Show advanced options"". A new button will appear allowing you to export the standalone file, copy music code, or other advanced importing features.")
    End Sub
    Private Sub cmb_EntitySpawnLocation_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_EntitySpawnLocation.SelectedIndexChanged
        EntitySpawnDeadEnd = False
        lbl_GroupCwarning.Visible = False
        num_EntityWeight.Enabled = True
        lbl_decoNoWeight.Visible = False
        EntityLocation = 0
        Select Case cmb_EntitySpawnLocation.SelectedIndex
            Case 0
                EntityLocation = 0
            Case 1
                EntityLocation = 1
            Case 2
                EntityLocation = 8
                lbl_GroupCwarning.Visible = True
            Case 3
                EntitySpawnDeadEnd = True
                EntityLocation = 9
            Case 4
                EntityLocation = 5
            Case 5
                EntityLocation = 6
                num_EntityWeight.Enabled = False
                lbl_decoNoWeight.Visible = True

                num_EntityWeight.Value = 0
        End Select
    End Sub

    Private Sub cmb_EntitySpawnMethod_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_EntitySpawnMethod.SelectedIndexChanged
        EntityMethod = ""
        Select Case cmb_EntitySpawnMethod.SelectedIndex
            Case 0
                EntityMethod = ""
            Case 1
                EntityMethod = "$"
            Case 2
                EntityMethod = "$2"
            Case 3
                EntityMethod = "$3"
            Case 4
                EntityMethod = "$4"
            Case 5
                EntityMethod = "$5"
        End Select
    End Sub

    Private Sub chk_EntityDropTreasure_CheckedChanged(sender As Object, e As EventArgs) Handles chk_EntityDropTreasure.CheckedChanged
        Select Case chk_EntityDropTreasure.Checked
            Case True
                cmb_DropTreasures.Enabled = True
            Case False
                cmb_DropTreasures.Enabled = False
        End Select
    End Sub
    Private Sub lst_RegularEntitiesList_Click(sender As Object, e As EventArgs) Handles lst_RegularEntitiesList.Click
        EntityRegCodeListIndexBoolean = True
        lst_RegularEntitiesList.SelectedIndex = EntityRegCodeListIndex
        lst_RegularEntitiesNormList.Select()
        lst_RegularEntitiesNormList.SelectedIndex = EntityRegCodeListIndex
        EntityRegCodeListIndexBoolean = False
    End Sub
    Private Sub lst_RegularEntitiesList_DoubleClick(sender As Object, e As EventArgs) Handles lst_RegularEntitiesList.DoubleClick
        EntityRegCodeListIndexBoolean = True
        lst_RegularEntitiesList.SelectedIndex = EntityRegCodeListIndex
        lst_RegularEntitiesNormList.Select()
        lst_RegularEntitiesNormList.SelectedIndex = EntityRegCodeListIndex
        EntityRegCodeListIndexBoolean = False
    End Sub
    Private Sub lst_RegularEntitiesList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_RegularEntitiesList.SelectedIndexChanged
        'If EntityRegCodeListIndexBoolean = False Then EntityRegCodeListIndex = lst_RegularEntitiesList.SelectedIndex
    End Sub
    Private Sub CountChallengeModePikmin()
        ChallengeModePikminCount = num_bB.Value + num_bF.Value + num_bL.Value + num_rB.Value + num_rF.Value + num_rL.Value + num_yB.Value + num_yF.Value + num_yL.Value + num_wB.Value + num_wF.Value + num_wL.Value + num_pB.Value + num_pF.Value + num_pL.Value + num_bulbL.Value + num_bulbB.Value + num_bulbF.Value + num_cL.Value + num_cB.Value + num_cF.Value
        lbl_PikiCount.Text = ChallengeModePikminCount & " Pikmin"
        If ChallengeModePikminCount > 100 Then
            lbl_PikiCount.ForeColor = Color.Red
            lbl_100pikiReminder.Visible = True
        Else
            lbl_PikiCount.ForeColor = Color.White

            lbl_100pikiReminder.Visible = False
        End If
        CMunsavedNow()


        If lst_Times.Items.Count > 0 Then
            IMPORTCHallengeMode()
        End If
    End Sub
    Private Sub CMunsavedNow()
        lbl_CMsaved.Text = "Changes not saved"
        lbl_CMsaved.ForeColor = Color.Red
        If lbl_CMsaved.ForeColor = Color.Red Then
            chk_UseCMproperties.Checked = False
        End If
    End Sub
    Private Sub num_rL_ValueChanged(sender As Object, e As EventArgs) Handles num_rL.ValueChanged
        CountChallengeModePikmin()
    End Sub

    Private Sub num_rB_ValueChanged(sender As Object, e As EventArgs) Handles num_rB.ValueChanged
        CountChallengeModePikmin()
    End Sub

    Private Sub num_rF_ValueChanged(sender As Object, e As EventArgs) Handles num_rF.ValueChanged
        CountChallengeModePikmin()
    End Sub

    Private Sub num_yL_ValueChanged(sender As Object, e As EventArgs) Handles num_yL.ValueChanged
        CountChallengeModePikmin()
    End Sub

    Private Sub num_yB_ValueChanged(sender As Object, e As EventArgs) Handles num_yB.ValueChanged
        CountChallengeModePikmin()
    End Sub

    Private Sub num_yF_ValueChanged(sender As Object, e As EventArgs) Handles num_yF.ValueChanged
        CountChallengeModePikmin()
    End Sub

    Private Sub num_bL_ValueChanged(sender As Object, e As EventArgs) Handles num_bL.ValueChanged
        CountChallengeModePikmin()
    End Sub

    Private Sub num_bB_ValueChanged(sender As Object, e As EventArgs) Handles num_bB.ValueChanged
        CountChallengeModePikmin()
    End Sub

    Private Sub num_bF_ValueChanged(sender As Object, e As EventArgs) Handles num_bF.ValueChanged
        CountChallengeModePikmin()
    End Sub

    Private Sub num_wL_ValueChanged(sender As Object, e As EventArgs) Handles num_wL.ValueChanged
        CountChallengeModePikmin()
    End Sub

    Private Sub num_wB_ValueChanged(sender As Object, e As EventArgs) Handles num_wB.ValueChanged
        CountChallengeModePikmin()
    End Sub

    Private Sub num_wF_ValueChanged(sender As Object, e As EventArgs) Handles num_wF.ValueChanged
        CountChallengeModePikmin()
    End Sub

    Private Sub num_pL_ValueChanged(sender As Object, e As EventArgs) Handles num_pL.ValueChanged
        CountChallengeModePikmin()
    End Sub

    Private Sub num_pB_ValueChanged(sender As Object, e As EventArgs) Handles num_pB.ValueChanged
        CountChallengeModePikmin()
    End Sub

    Private Sub num_pF_ValueChanged(sender As Object, e As EventArgs) Handles num_pF.ValueChanged
        CountChallengeModePikmin()
    End Sub
    Public Function GetNthIndex(searchString As String, charToFind As Char, n As Integer) As Integer
        Dim charIndexPair = searchString.Select(Function(c, i) New With {.Character = c, .Index = i}) _
                                    .Where(Function(x) x.Character = charToFind) _
                                    .ElementAtOrDefault(n - 1)
        Return If(charIndexPair IsNot Nothing, charIndexPair.Index, -1)
    End Function
    Sub IMPORTCHallengeMode()
        ImportingCM = True
        Dim currentTimeSelected = lst_Times.SelectedIndex
        If lst_Times.Items.Count <> num_CMPsubCount.Value Then
            MsgBox("The amount of times you have must be the same as the amount of sublevels you have.")
        ElseIf num_CMPsubCount.Value = 0 Then
            MsgBox("You must have at least one sublevel.")
        Else
            If num_CMPsubCount.Value = 0 Then
                MsgBox("The sublevel count paramater must be greater than 0.")
            Else
                GenerateCMPcode()
                lbl_CMsaved.Text = "Saved"
                lbl_CMsaved.ForeColor = Color.Green
                If opt_ChallengeMode.Checked = True Then
                    chk_UseCMproperties.Checked = True
                End If
            End If
        End If
        ImportingCM = False
        updatingCMtime = False
        lst_Times.SelectedIndex = currentTimeSelected
    End Sub
    Private Sub btn_ImportChallengeModeProperties_Click(sender As Object, e As EventArgs) Handles btn_ImportChallengeModeProperties.Click
        IMPORTCHallengeMode()
    End Sub

    Private Sub opt_CMengNames_CheckedChanged(sender As Object, e As EventArgs) Handles opt_CMengNames.CheckedChanged
        Dim CMCcurrentindex As Integer = cmb_ChallengeModeCaves.SelectedIndex
        cmb_ChallengeModeCaves.Items.Clear()
        cmb_ChallengeModeCaves.Items.Add("Explorer's Cave")
        cmb_ChallengeModeCaves.Items.Add("Novice Training")
        cmb_ChallengeModeCaves.Items.Add("Lost Toy Box")
        cmb_ChallengeModeCaves.Items.Add("Creator's Garden")
        cmb_ChallengeModeCaves.Items.Add("Green Hole")
        cmb_ChallengeModeCaves.Items.Add("Hot House")
        cmb_ChallengeModeCaves.Items.Add("Brawny Abyss")
        cmb_ChallengeModeCaves.Items.Add("Red Chasm")
        cmb_ChallengeModeCaves.Items.Add("Trampled Garden")
        cmb_ChallengeModeCaves.Items.Add("Twilight Garden")
        cmb_ChallengeModeCaves.Items.Add("Cryptic Cavern")
        cmb_ChallengeModeCaves.Items.Add("Concrete Maze")
        cmb_ChallengeModeCaves.Items.Add("Collector's Room")
        cmb_ChallengeModeCaves.Items.Add("Dweevil Nest")
        cmb_ChallengeModeCaves.Items.Add("Cavernous Abyss")
        cmb_ChallengeModeCaves.Items.Add("Snack Pit")
        cmb_ChallengeModeCaves.Items.Add("Three Color Training")
        cmb_ChallengeModeCaves.Items.Add("Hazard Training")
        cmb_ChallengeModeCaves.Items.Add("Cave of Snarls")
        cmb_ChallengeModeCaves.Items.Add("The Giant's Bath")
        cmb_ChallengeModeCaves.Items.Add("Rumbling Grotto")
        cmb_ChallengeModeCaves.Items.Add("Subterranean Lair")
        cmb_ChallengeModeCaves.Items.Add("Hidden Garden")
        cmb_ChallengeModeCaves.Items.Add("Abduction Den")
        cmb_ChallengeModeCaves.Items.Add("Secret Testing Range")
        cmb_ChallengeModeCaves.Items.Add("Breeding Ground")
        cmb_ChallengeModeCaves.Items.Add("Cave of Pain")
        cmb_ChallengeModeCaves.Items.Add("Bully Den")
        cmb_ChallengeModeCaves.Items.Add("Sniper Room")
        cmb_ChallengeModeCaves.Items.Add("Emperor's Realm")
        cmb_ChallengeModeCaves.SelectedIndex = CMCcurrentindex
    End Sub

    Private Sub opt_CMintNames_CheckedChanged(sender As Object, e As EventArgs) Handles opt_CMintNames.CheckedChanged
        Dim CMCcurrentindex As Integer = cmb_ChallengeModeCaves.SelectedIndex
        cmb_ChallengeModeCaves.Items.Clear()
        cmb_ChallengeModeCaves.Items.Add("ch_ABEM_tutorial.txt")
        cmb_ChallengeModeCaves.Items.Add("ch_NARI_07whitepurple.txt")
        cmb_ChallengeModeCaves.Items.Add("ch_NARI_03toy.txt")
        cmb_ChallengeModeCaves.Items.Add("ch_NARI_01kusachi.txt")
        cmb_ChallengeModeCaves.Items.Add("ch_ABEM_LeafChappy.txt")
        cmb_ChallengeModeCaves.Items.Add("ch_NARI_05start3easy.txt")
        cmb_ChallengeModeCaves.Items.Add("ch_MUKI_metal.txt")
        cmb_ChallengeModeCaves.Items.Add("ch_MAT_limited_time.txt")
        cmb_ChallengeModeCaves.Items.Add("ch_MAT_t_hunter_hana.txt")
        cmb_ChallengeModeCaves.Items.Add("ch_MUKI_damagumo.txt")
        cmb_ChallengeModeCaves.Items.Add("ch_MAT_t_hunter_enemy.txt")
        cmb_ChallengeModeCaves.Items.Add("ch_MAT_conc_cave.txt")
        cmb_ChallengeModeCaves.Items.Add("ch_NARI_04series.txt")
        cmb_ChallengeModeCaves.Items.Add("ch_MAT_t_hunter_otakara.txt")
        cmb_ChallengeModeCaves.Items.Add("ch_MUKI_bigfoot.txt")
        cmb_ChallengeModeCaves.Items.Add("ch_MIYA_oopan.txt")
        cmb_ChallengeModeCaves.Items.Add("ch_MAT_yellow_purple_white.txt")
        cmb_ChallengeModeCaves.Items.Add("ch_MUKI_redblue.txt")
        cmb_ChallengeModeCaves.Items.Add("ch_NARI_08tobasare.txt")
        cmb_ChallengeModeCaves.Items.Add("ch_NARI_02tile.txt")
        cmb_ChallengeModeCaves.Items.Add("ch_MAT_crawler.txt")
        cmb_ChallengeModeCaves.Items.Add("ch_MAT_route_rover.txt")
        cmb_ChallengeModeCaves.Items.Add("ch_MUKI_enemyzero.txt")
        cmb_ChallengeModeCaves.Items.Add("ch_NARI_09suikomi.txt")
        cmb_ChallengeModeCaves.Items.Add("ch_MUKI_houdai.txt")
        cmb_ChallengeModeCaves.Items.Add("ch_NARI_06start3hard.txt")
        cmb_ChallengeModeCaves.Items.Add("ch_MAT_flier.txt")
        cmb_ChallengeModeCaves.Items.Add("ch_MIYA_trap.txt")
        cmb_ChallengeModeCaves.Items.Add("ch_MUKI_bombing.txt")
        cmb_ChallengeModeCaves.Items.Add("ch_MUKI_king.txt")
        cmb_ChallengeModeCaves.SelectedIndex = CMCcurrentindex
    End Sub

    Private Sub chk_CMPadvanced_CheckedChanged(sender As Object, e As EventArgs) Handles chk_CMPadvanced.CheckedChanged
        Select Case chk_CMPadvanced.Checked
            Case True
                pnl_CMPadvanced.Visible = True
            Case False
                pnl_CMPadvanced.Visible = False
        End Select
    End Sub

    Private Sub btn_CMPcopyCode_Click(sender As Object, e As EventArgs) Handles btn_CMPcopyCode.Click
        btn_CopyMusicCode.Enabled = False
        If lbl_CMsaved.ForeColor = Color.Red Then
            MsgBox("Please save your changes.")
        Else
            GenerateCMPcode()
            Clipboard.SetText(CMPcode)
            CopiedToClipboard.txt_Copied.Text = CMPcode
            CopiedToClipboard.Location = New Point(Me.Location.X + ((Me.Width / 2) - CopiedToClipboard.Width / 2), Me.Location.Y + ((Me.Height / 2) - CopiedToClipboard.Height / 2))
            CopiedToClipboard.ShowDialog()
        End If
        btn_CopyMusicCode.Enabled = True
    End Sub
    Private Sub GenerateCMPcode()
        Dim namecheck As Integer
        If opt_CMintNames.Checked = True Then
            namecheck = 1
        Else
            namecheck = 0
        End If
        opt_CMintNames.Checked = True
        CMPcode = "	" & num_bL.Value & " # bL
	" & num_bB.Value & " # bB
	" & num_bF.Value & " # bF
	" & num_rL.Value & " # rL
	" & num_rB.Value & " # rB
	" & num_rF.Value & " # rF
	" & num_yL.Value & " # yL
	" & num_yB.Value & " # yB
	" & num_yF.Value & " # yF
	" & num_pL.Value & " # pL
	" & num_pB.Value & " # pB
	" & num_pF.Value & " # pF
	" & num_wL.Value & " # wL
	" & num_wB.Value & " # wB
	" & num_wF.Value & " # wF
	" & num_bulbL.Value & " # bulbL
	" & num_bulbB.Value & " # bulbB
	" & num_bulbF.Value & " # bulbF
	" & num_cL.Value & " # cL
	" & num_cB.Value & " # cB
	" & num_cF.Value & " # cF
	0 # time (unused)
	" & num_ubs.Value & " # bitter
	" & num_uss.Value & " # spicy
	" & num_CMPsubCount.Value & " # subcount
	0 # otakara num (unknown)
	0 # CaveCreator2Dindex_THIS-SHOULD-BE-REPLACED"
        Dim CMPtimeCodeNew As String = ""
        Dim i As Integer = 0
        While i < lst_Times.Items.Count
            lst_Times.SelectedIndex = i
            i += 1
            Dim TimePiece As String = lst_Times.SelectedItem.ToString.Substring(lst_Times.SelectedItem.ToString.IndexOf(":") + 2, (lst_Times.SelectedItem.ToString.Length - (lst_Times.SelectedItem.ToString.IndexOf(":") + 2)) - 8)
            CMPtimeCodeNew = CMPtimeCodeNew & "
	" & TimePiece & " # sublevel " & i & " time"
        End While
        lst_Times.SelectedIndex = -1
        CMPcode = CMPcode & CMPtimeCodeNew
        If namecheck = 0 Then opt_CMengNames.Checked = True
    End Sub

    Private Sub tbp_ChallengeModeProperties_Enter(sender As Object, e As EventArgs) Handles tbp_ChallengeModeProperties.Enter
        num_CMPsubCount.Value = SublevelTotal
        If lst_Times.Items.Count < lst_Sublevels.Items.Count Then
            For i = lst_Times.Items.Count To lst_Sublevels.Items.Count - 1
                lst_Times.Items.Add("Sublevel " & (i + 1).ToString & ": 0 seconds")
            Next
        End If
    End Sub

    Private Sub num_bulbL_ValueChanged(sender As Object, e As EventArgs) Handles num_bulbL.ValueChanged
        CountChallengeModePikmin()
    End Sub

    Private Sub num_bulbB_ValueChanged(sender As Object, e As EventArgs) Handles num_bulbB.ValueChanged
        CountChallengeModePikmin()
    End Sub

    Private Sub num_bulbF_ValueChanged(sender As Object, e As EventArgs) Handles num_bulbF.ValueChanged
        CountChallengeModePikmin()
    End Sub

    Private Sub num_cL_ValueChanged(sender As Object, e As EventArgs) Handles num_cL.ValueChanged
        CountChallengeModePikmin()
    End Sub

    Private Sub num_cB_ValueChanged(sender As Object, e As EventArgs) Handles num_cB.ValueChanged
        CountChallengeModePikmin()
    End Sub

    Private Sub num_cF_ValueChanged(sender As Object, e As EventArgs) Handles num_cF.ValueChanged
        CountChallengeModePikmin()
    End Sub

    Private Sub btn_SetTimes_Click(sender As Object, e As EventArgs)
        If num_CMPsubCount.Value = 0 Then
            MsgBox("The sublevel count paramater must be greater than 0.")
        Else
            Dim i As Integer = lst_Times.Items.Count
            Dim CMtimes(num_CMPsubCount.Value) As String
            While i < num_CMPsubCount.Value
                i += 1
                If i = 1 Then
                    Dim i2 As Integer = 0
                    While IsNumeric(CMtimes(i - 1)) = False
                        CMtimes(i - 1) = InputBox("How many seconds does the first sublevel begin with? (0 = Infinite)")
                        If IsNumeric(CMtimes(i - 1)) = False Then
                            If CMtimes(i - 1) = "" Then
                                CMtimes(i - 1) = "1"
                                i2 = 1
                            Else
                                MsgBox("Please only use numbers.")
                            End If
                        End If
                    End While
                    If i2 = 1 Then
                        i = num_CMPsubCount.Value
                    Else
                        lst_Times.Items.Add("Sublevel " & i & ": " & CMtimes(i - 1) & " seconds")
                        CMPtimeCode = "
	" & CMtimes(i - 1) & " # sublevel " & i & " time"
                        CMunsavedNow()
                    End If
                Else
                    Dim i2 As Integer = 0
                    While IsNumeric(CMtimes(i - 1)) = False
                        CMtimes(i - 1) = InputBox("How many seconds are added to the timer when the player reaches sublevel " & i & "? (0 = No increase)")
                        If IsNumeric(CMtimes(i - 1)) = False Then
                            If CMtimes(i - 1) = "" Then
                                CMtimes(i - 1) = "1"
                                i2 = 1
                            Else
                                MsgBox("Please only use numbers.")
                            End If
                        End If
                    End While
                    If i2 = 1 Then
                        i = num_CMPsubCount.Value
                    Else
                        lst_Times.Items.Add("Sublevel " & i & ": " & CMtimes(i - 1) & " seconds")
                        CMPtimeCode = CMPtimeCode & "
	" & CMtimes(i - 1) & " # sublevel " & i & " time"
                        CMunsavedNow()
                    End If
                End If
            End While
        End If
    End Sub
    Private Sub btn_LoadRoot_Click(sender As Object, e As EventArgs) Handles btn_LoadRoot.Click
        If (RootBrowserDialog.ShowDialog() = DialogResult.OK) Then
            If System.IO.Directory.Exists(RootBrowserDialog.SelectedPath & "\user\Mukki\mapunits\caveinfo") Then
                RootDirectory = RootBrowserDialog.SelectedPath
                txt_RootDirectory.Text = RootDirectory
                btn_ImportCave.Enabled = True
                Dim result As Integer = MessageBox.Show("Do you want to set this as the default root directory?", "Cave Creator - Set Default Root", MessageBoxButtons.YesNo)
                If result = DialogResult.Yes Then
                    If My.Computer.FileSystem.FileExists(AppDomain.CurrentDomain.BaseDirectory & "\CCP.data") Then
                        Dim OptionsFile As String = My.Computer.FileSystem.ReadAllText(AppDomain.CurrentDomain.BaseDirectory & "\CCP.data")
                        Dim wrapper As New Simple3Des("hsAJAA%#!HJbhk^&A^&76agiA%$##a&AFAA&*A*GAIha8aF1")
                        OptionsFile = wrapper.DecryptData(OptionsFile)
                        If OptionsFile.Contains("defaultroot=") Then
                            Dim BeforePreviousDefaultRoot As String = OptionsFile.Substring(0, OptionsFile.IndexOf("defaultroot="))
                            Dim DefaultRootLine As String = OptionsFile.Substring(OptionsFile.IndexOf("defaultroot="), OptionsFile.Length - OptionsFile.IndexOf("defaultroot="))
                            Dim AfterPreviousDefaultRoot As String = DefaultRootLine.Substring(DefaultRootLine.IndexOf("
"), DefaultRootLine.Length - DefaultRootLine.IndexOf("
"))
                            OptionsFile = BeforePreviousDefaultRoot & "
defaultroot=" & RootBrowserDialog.SelectedPath & "
" & AfterPreviousDefaultRoot
                        Else
                            OptionsFile = OptionsFile & "
defaultroot=" & RootBrowserDialog.SelectedPath & "
"
                        End If
                        Dim wrapper2 As New Simple3Des("hsAJAA%#!HJbhk^&A^&76agiA%$##a&AFAA&*A*GAIha8aF1")
                        OptionsFile = wrapper2.EncryptData(OptionsFile)
                        My.Computer.FileSystem.WriteAllText(AppDomain.CurrentDomain.BaseDirectory & "\CCP.data", OptionsFile, False)

                    Else

                        Dim OptionsFile As String = Application.ProductVersion & "
defaultroot=" & RootBrowserDialog.SelectedPath & "
"
                        Dim wrapper2 As New Simple3Des("hsAJAA%#!HJbhk^&A^&76agiA%$##a&AFAA&*A*GAIha8aF1")
                        OptionsFile = wrapper2.EncryptData(OptionsFile)
                        My.Computer.FileSystem.WriteAllText(AppDomain.CurrentDomain.BaseDirectory & "\CCP.data", OptionsFile, False)
                    End If

                    MainMenu.CustomDirOptions.Clear()
                    If IO.File.Exists(AppDomain.CurrentDomain.BaseDirectory & "CaveCreator_CustomDirOptions.data") Then
                        IO.File.Delete(AppDomain.CurrentDomain.BaseDirectory & "CaveCreator_CustomDirOptions.data")
                    End If
                End If
            Else
                MessageBox.Show("""user\Mukki\mapunits\caveinfo"" was not found.
Please make sure you extract your entire Pikmin 2 ISO (via GameCube Rebuilder) and then try again.", "Cave Creator - Root Directory")
            End If
        End If
    End Sub
    Sub ClickedImportCave()
        'NONE
        'OF
        'THIS
        'IS USED!!!!!!!!!!!!!!!!!!!!!!!!
        'Refer to the btn_import click event.



        If lst_Sublevels.Items.Count = 0 Then
            MsgBox("There are no sublevels.")
        Else
            pnl_Controls.Enabled = False
            btn_ExportCaveFile.Enabled = False
            btn_CopyMusicCode.Enabled = False
            EnterSublevelEntities()
            If cmb_Sublevels.SelectedIndex = -1 Then lst_RegularEntitiesNormList.Items.Clear()
            TabControl1.SelectedTab = tbp_SublevelManager
            TabControl1.SelectedTab = tbp_ImportManager
            exportwindowshow = False
            CaveFile = "CCplus_UnspecifiedCaveFile.txt"
            Dim TotakaBgmFileName As String = "CCplus_UnspecifiedBGMfile"
            Dim BgmFile As String = "An error has occured with CC+ and this file has not been imported properly."

            If opt_Main.Checked = True Then
                Select Case cmb_ReplaceWith.SelectedIndex
                    Case 0
                        CaveFile = "tutorial_1.txt"
                    Case 1
                        CaveFile = "tutorial_2.txt"
                    Case 2
                        CaveFile = "tutorial_3.txt"
                    Case 3
                        CaveFile = "forest_1.txt"
                    Case 4
                        CaveFile = "forest_2.txt"
                    Case 5
                        CaveFile = "forest_3.txt"
                    Case 6
                        CaveFile = "forest_4.txt"
                    Case 7
                        CaveFile = "yakushima_1.txt"
                    Case 8
                        CaveFile = "yakushima_2.txt"
                    Case 9
                        CaveFile = "yakushima_3.txt"
                    Case 10
                        CaveFile = "yakushima_4.txt"
                    Case 11
                        CaveFile = "last_1.txt"
                    Case 12
                        CaveFile = "last_2.txt"
                    Case 13
                        CaveFile = "last_3.txt"
                End Select
            ElseIf opt_ChallengeMode.Checked = True Then
                Select Case cmb_ReplaceWith.SelectedIndex
                    Case 0
                        CaveFile = "ch_ABEM_tutorial.txt"
                    Case 1
                        CaveFile = "ch_NARI_07whitepurple.txt"
                    Case 2
                        CaveFile = "ch_NARI_03toy.txt"
                    Case 3
                        CaveFile = "ch_NARI_01kusachi.txt"
                    Case 4
                        CaveFile = "ch_ABEM_LeafChappy.txt"
                    Case 5
                        CaveFile = "ch_NARI_05start3easy.txt"
                    Case 6
                        CaveFile = "ch_MUKI_metal.txt"
                    Case 7
                        CaveFile = "ch_MAT_limited_time.txt"
                    Case 8
                        CaveFile = "ch_MAT_t_hunter_hana.txt"
                    Case 9
                        CaveFile = "ch_MUKI_damagumo.txt"
                    Case 10
                        CaveFile = "ch_MAT_t_hunter_enemy.txt"
                    Case 11
                        CaveFile = "ch_MAT_conc_cave.txt"
                    Case 12
                        CaveFile = "ch_NARI_04series.txt"
                    Case 13
                        CaveFile = "ch_MAT_t_hunter_otakara.txt"
                    Case 14
                        CaveFile = "ch_MUKI_bigfoot.txt"
                    Case 15
                        CaveFile = "ch_MIYA_oopan.txt"
                    Case 16
                        CaveFile = "ch_MAT_yellow_purple_white.txt"
                    Case 17
                        CaveFile = "ch_MUKI_redblue.txt"
                    Case 18
                        CaveFile = "ch_NARI_08tobasare.txt"
                    Case 19
                        CaveFile = "ch_NARI_02tile.txt"
                    Case 20
                        CaveFile = "ch_MAT_crawler.txt"
                    Case 21
                        CaveFile = "ch_MAT_route_rover.txt"
                    Case 22
                        CaveFile = "ch_MUKI_enemyzero.txt"
                    Case 23
                        CaveFile = "ch_NARI_09suikomi.txt"
                    Case 24
                        CaveFile = "ch_MUKI_houdai.txt"
                    Case 25
                        CaveFile = "ch_NARI_06start3hard.txt"
                    Case 26
                        CaveFile = "ch_MAT_flier.txt"
                    Case 27
                        CaveFile = "ch_MIYA_trap.txt"
                    Case 28
                        CaveFile = "ch_MUKI_bombing.txt"
                    Case 29
                        CaveFile = "ch_MUKI_king.txt"
                End Select
            ElseIf opt_2PBattle.Checked = True Then
                CaveFile = "VS.txt"
            End If

            If opt_2PBattle.Checked = True Then
            Else
                If chk_IgnoreCaveMusic.Checked = False Then
                    If CaveFile.StartsWith("tutorial") Then
                        TotakaBgmFileName = "BgmList_Tutorial.txt"
                    ElseIf CaveFile.StartsWith("forest") Then
                        TotakaBgmFileName = "BgmList_Forest.txt"
                    ElseIf CaveFile.StartsWith("yakushima") Then
                        TotakaBgmFileName = "BgmList_Yakushima.txt"
                    ElseIf CaveFile.StartsWith("last") Then
                        TotakaBgmFileName = "BgmList_Last.txt"
                    ElseIf CaveFile.StartsWith("ch_") Then
                        If MainMenu.CustomDirOptions.Count >= 4 AndAlso MainMenu.CustomDirOptions(3) = "True" Then TotakaBgmFileName = "BgmList_Challenge.txt" Else TotakaBgmFileName = "ChallengeBgmList.txt"
                    ElseIf CaveFile = "VS.txt" Then
                        TotakaBgmFileName = "VS.txt"
                    End If
                    If TotakaBgmFileName = "VS.txt" Then
                    Else
                        If MainMenu.CustomDirOptions.Count >= 3 Then
                            BgmFile = My.Computer.FileSystem.ReadAllText(MainMenu.CustomDirOptions(2) & TotakaBgmFileName)
                        Else
                            BgmFile = My.Computer.FileSystem.ReadAllText(RootDirectory & "\user\Totaka\" & TotakaBgmFileName)
                        End If

                    End If
                    While BgmFile.Contains("#")
                        Dim bgmfiletest As String = BgmFile.Substring(BgmFile.IndexOf("#"), BgmFile.Length - (BgmFile.IndexOf("#") + 1))
                        Dim BgmFileNotes As String = bgmfiletest.Substring(0, bgmfiletest.IndexOf("
"))
                        BgmFile = BgmFile.Replace(BgmFileNotes, "")
                    End While
                    Dim SongName As String = "{
	" & lst_Sublevels.Items.Count & "
	"
                    lst_Sublevels.SelectedIndex = -1
                    Dim i As Integer = 0
                    While i < lst_Sublevels.Items.Count
                        i += 1
                        lst_Sublevels.SelectedIndex += 1

                        If i = lst_Sublevels.Items.Count Then
                            SongName = SongName & lst_totaka_MusicList.SelectedItem & "
}"
                        Else
                            SongName = SongName & lst_totaka_MusicList.SelectedItem & "
	"
                        End If
                    End While

                    '''''''THIS DOESNT WORK FOR CHALLENGE MODE YET!!!
                    Dim ReplaceThisPartOfBgmList As String
                    Dim CaveFileMinustxt As String = CaveFile.Substring(0, CaveFile.IndexOf("."))
                    Select Case CaveFileMinustxt.Last
                        Case "1"
                            Dim AfterSection As String = BgmFile.Substring(BgmFile.IndexOf("}") + 1, BgmFile.Length - BgmFile.IndexOf("}") - 1)
                            ReplaceThisPartOfBgmList = BgmFile.Substring(BgmFile.IndexOf("{"), (BgmFile.Length - BgmFile.IndexOf("{")) - AfterSection.Length)
                            If CaveFile.Contains("tutorial") Then
                                BgmFile = "3

"
                            ElseIf CaveFile.Contains("last") Then
                                BgmFile = "3

"
                            Else
                                BgmFile = "4

"
                            End If
                            BgmFile = BgmFile & SongName & AfterSection
                        Case "2"
                            Dim SkipFirst As String = BgmFile.Substring(BgmFile.IndexOf("}") + 1, BgmFile.Length - (BgmFile.IndexOf("}") + 1))
                            Dim FirstPart As String = BgmFile.Substring(BgmFile.IndexOf("{"), BgmFile.Length - BgmFile.IndexOf("{"))
                            FirstPart = FirstPart.Substring(0, FirstPart.IndexOf("}") + 1)
                            Dim AfterSection As String = SkipFirst.Substring(SkipFirst.IndexOf("}") + 1, SkipFirst.Length - SkipFirst.IndexOf("}") - 1)
                            ReplaceThisPartOfBgmList = SkipFirst.Substring(SkipFirst.IndexOf("{"), (SkipFirst.Length - SkipFirst.IndexOf("{")) - AfterSection.Length)
                            If CaveFile.Contains("tutorial") Then
                                BgmFile = "3

"
                            ElseIf CaveFile.Contains("last") Then
                                BgmFile = "3

"
                            Else
                                BgmFile = "4

"
                            End If
                            BgmFile = BgmFile & FirstPart & "

" & SongName & AfterSection
                        Case "3"
                            Dim SkipFirst As String = BgmFile.Substring(BgmFile.IndexOf("}") + 1, BgmFile.Length - BgmFile.IndexOf("}") - 1)
                            Dim FirstPart As String = BgmFile.Substring(BgmFile.IndexOf("{"), BgmFile.Length - BgmFile.IndexOf("{"))
                            FirstPart = FirstPart.Substring(0, FirstPart.IndexOf("}") + 1)
                            Dim SkipSecond As String = SkipFirst.Substring(SkipFirst.IndexOf("}") + 1, SkipFirst.Length - SkipFirst.IndexOf("}") - 1)
                            Dim SecondPart As String = SkipFirst.Substring(SkipFirst.IndexOf("{"), SkipFirst.Length - SkipFirst.IndexOf("{"))
                            SecondPart = SecondPart.Substring(0, SecondPart.IndexOf("}") + 1)
                            Dim AfterSection As String = SkipSecond.Substring(SkipSecond.IndexOf("}") + 1, SkipSecond.Length - SkipSecond.IndexOf("}") - 1)
                            ReplaceThisPartOfBgmList = SkipSecond.Substring(SkipSecond.IndexOf("{"), (SkipSecond.Length - SkipSecond.IndexOf("{")) - AfterSection.Length)
                            If CaveFile.Contains("tutorial") Then
                                BgmFile = "3

"
                            ElseIf CaveFile.Contains("last") Then
                                BgmFile = "3

"
                            Else
                                BgmFile = "4

"
                            End If
                            BgmFile = BgmFile & FirstPart & "

" & SecondPart & "

" & SongName & AfterSection
                        Case "4"
                            Dim SkipFirst As String = BgmFile.Substring(BgmFile.IndexOf("}") + 1, BgmFile.Length - BgmFile.IndexOf("}") - 1)
                            Dim FirstPart As String = BgmFile.Substring(BgmFile.IndexOf("{"), BgmFile.Length - BgmFile.IndexOf("{"))
                            FirstPart = FirstPart.Substring(0, FirstPart.IndexOf("}") + 1)
                            Dim SkipSecond As String = SkipFirst.Substring(SkipFirst.IndexOf("}") + 1, SkipFirst.Length - SkipFirst.IndexOf("}") - 1)
                            Dim SecondPart As String = SkipFirst.Substring(SkipFirst.IndexOf("{"), SkipFirst.Length - SkipFirst.IndexOf("{"))
                            SecondPart = SecondPart.Substring(0, SecondPart.IndexOf("}") + 1)
                            Dim SkipThird As String = SkipSecond.Substring(SkipSecond.IndexOf("}") + 1, SkipSecond.Length - SkipSecond.IndexOf("}") - 1)
                            Dim ThirdPart As String = SkipSecond.Substring(SkipSecond.IndexOf("{"), SkipSecond.Length - SkipSecond.IndexOf("{"))
                            ThirdPart = ThirdPart.Substring(0, ThirdPart.IndexOf("}") + 1)
                            Dim AfterSection As String = SkipThird.Substring(SkipThird.IndexOf("}") + 1, SkipThird.Length - SkipThird.IndexOf("}") - 1)
                            ReplaceThisPartOfBgmList = SkipThird.Substring(SkipThird.IndexOf("{"), (SkipThird.Length - SkipThird.IndexOf("{")) - AfterSection.Length)
                            If CaveFile.Contains("tutorial") Then
                                BgmFile = "3

"
                            ElseIf CaveFile.Contains("last") Then
                                BgmFile = "3

"
                            Else
                                BgmFile = "4

"
                            End If
                            BgmFile = BgmFile & FirstPart & "

" & SecondPart & "

" & ThirdPart & "

" & SongName & AfterSection
                    End Select


                    If TotakaBgmFileName = "ChallengeBgmList.txt" OrElse TotakaBgmFileName = "BgmList_Challenge.txt" Then
                        Dim FirstPartLength As Integer = GetNthIndexNew(BgmFile, "{"c, cmb_ReplaceWith.SelectedIndex + 1)
                        Dim LastPartLength As Integer = GetNthIndexNew(BgmFile, "{"c, cmb_ReplaceWith.SelectedIndex + 2)
                        Dim LastSection As String = ""
                        Dim FirstSection As String = BgmFile.Substring(0, FirstPartLength)
                        If LastPartLength >= 0 Then
                            LastSection = BgmFile.Substring(LastPartLength, BgmFile.Length - (LastPartLength))
                        End If


                        BgmFile = FirstSection & SongName & "

" & LastSection
                        Dim source As String = BgmFile
                        Dim stringSeparators() As String = {"
"}

                        Dim result() As String
                        result = source.Split(stringSeparators,
                      StringSplitOptions.RemoveEmptyEntries)
                        BgmFile = String.Join("
", result)

                    End If

                End If
            End If


            If chk_UseCMproperties.Checked = True Then
                Dim OriginalCMPfullCode As String
                Dim stagesFilename As String = "stages.txt"
                If MainMenu.CustomDirOptions.Count >= 4 AndAlso MainMenu.CustomDirOptions(3) = "True" Then stagesFilename = "stages_ch.ini"
                If MainMenu.CustomDirOptions.Count >= 3 Then
                    OriginalCMPfullCode = My.Computer.FileSystem.ReadAllText(MainMenu.CustomDirOptions(1) & stagesFilename)
                Else
                    OriginalCMPfullCode = My.Computer.FileSystem.ReadAllText(RootDirectory & "\user\Matoba\challenge\" & stagesFilename)
                End If

                Dim i As Integer = cmb_ReplaceWith.SelectedIndex + 1

                Dim index As Integer = GetNthIndex(OriginalCMPfullCode, "{", i)
                Dim index2 As Integer = GetNthIndex(OriginalCMPfullCode, "}", i)
                Dim NewCMPcode As String = "{
	4 # version
	" & CaveFile & " # cave file
	# PikiCounter
" & CMPcode
                Dim FirstmInecrafter As String = OriginalCMPfullCode.Substring(0, index2)
                Dim Minecraftboy69 As String = OriginalCMPfullCode.Substring(index, FirstmInecrafter.Length - index)
                Dim Minecraftboy69Lines() As String = Minecraftboy69.Split(Environment.NewLine.ToCharArray, System.StringSplitOptions.RemoveEmptyEntries)
                'MsgBox(Minecraftboy69Lines(30))
                NewCMPcode = NewCMPcode.Replace("0 # CaveCreator2Dindex_THIS-SHOULD-BE-REPLACED", Minecraftboy69Lines(30))
                CMPfullCode = OriginalCMPfullCode.Substring(0, index) & vbCrLf & NewCMPcode & vbCrLf & OriginalCMPfullCode.Substring(index2, OriginalCMPfullCode.Length - (index2))

                If MainMenu.CustomDirOptions.Count >= 3 Then
                    My.Computer.FileSystem.WriteAllText(MainMenu.CustomDirOptions(1) & stagesFilename, CMPfullCode, False, System.Text.Encoding.GetEncoding(932))
                Else
                    My.Computer.FileSystem.WriteAllText(RootDirectory & "\user\Matoba\challenge\" & stagesFilename, CMPfullCode, False, System.Text.Encoding.GetEncoding(932))
                End If
            End If
            If TotakaBgmFileName = "VS.txt" Then
            Else
                If MainMenu.CustomDirOptions.Count >= 3 Then
                    My.Computer.FileSystem.WriteAllText(MainMenu.CustomDirOptions(2) & TotakaBgmFileName, BgmFile, False, System.Text.Encoding.GetEncoding(932))
                Else
                    My.Computer.FileSystem.WriteAllText(RootDirectory & "\user\Totaka\" & TotakaBgmFileName, BgmFile, False, System.Text.Encoding.GetEncoding(932))
                End If
            End If

            exportwindowshow = False

            'Me.Opacity = 0


            'ExportCaveProcess.Show()
            ExportCave()
        End If
        pnl_Controls.Enabled = True
        btn_ExportCaveFile.Enabled = True
        btn_CopyMusicCode.Enabled = True
    End Sub
    Private Sub btn_ImportCave_Click(sender As Object, e As EventArgs) Handles btn_ImportCave.Click

        If lst_Sublevels.Items.Count = 0 Then
            MsgBox("There are no sublevels.")
        Else
            Dim cancelnow As Boolean = False
            pnl_Controls.Enabled = False
            btn_ExportCaveFile.Enabled = False
            btn_CopyMusicCode.Enabled = False
            EnterSublevelEntities()
            If cmb_Sublevels.SelectedIndex = -1 Then lst_RegularEntitiesNormList.Items.Clear()
            TabControl1.SelectedTab = tbp_SublevelManager
            TabControl1.SelectedTab = tbp_ImportManager
            exportwindowshow = False
            CaveFile = "CCplus_UnspecifiedCaveFile.txt"
            Dim TotakaBgmFileName As String = "CCplus_UnspecifiedBGMfile"
            Dim BgmFile As String = "An error has occured with CC+ and this file has not been imported properly."

            If opt_Main.Checked = True Then
                Select Case cmb_ReplaceWith.SelectedIndex
                    Case 0
                        CaveFile = "tutorial_1.txt"
                    Case 1
                        CaveFile = "tutorial_2.txt"
                    Case 2
                        CaveFile = "tutorial_3.txt"
                    Case 3
                        CaveFile = "forest_1.txt"
                    Case 4
                        CaveFile = "forest_2.txt"
                    Case 5
                        CaveFile = "forest_3.txt"
                    Case 6
                        CaveFile = "forest_4.txt"
                    Case 7
                        CaveFile = "yakushima_1.txt"
                    Case 8
                        CaveFile = "yakushima_2.txt"
                    Case 9
                        CaveFile = "yakushima_3.txt"
                    Case 10
                        CaveFile = "yakushima_4.txt"
                    Case 11
                        CaveFile = "last_1.txt"
                    Case 12
                        CaveFile = "last_2.txt"
                    Case 13
                        CaveFile = "last_3.txt"
                End Select
            ElseIf opt_ChallengeMode.Checked = True Then
                Select Case cmb_ReplaceWith.SelectedIndex
                    Case 0
                        CaveFile = "ch_ABEM_tutorial.txt"
                    Case 1
                        CaveFile = "ch_NARI_07whitepurple.txt"
                    Case 2
                        CaveFile = "ch_NARI_03toy.txt"
                    Case 3
                        CaveFile = "ch_NARI_01kusachi.txt"
                    Case 4
                        CaveFile = "ch_ABEM_LeafChappy.txt"
                    Case 5
                        CaveFile = "ch_NARI_05start3easy.txt"
                    Case 6
                        CaveFile = "ch_MUKI_metal.txt"
                    Case 7
                        CaveFile = "ch_MAT_limited_time.txt"
                    Case 8
                        CaveFile = "ch_MAT_t_hunter_hana.txt"
                    Case 9
                        CaveFile = "ch_MUKI_damagumo.txt"
                    Case 10
                        CaveFile = "ch_MAT_t_hunter_enemy.txt"
                    Case 11
                        CaveFile = "ch_MAT_conc_cave.txt"
                    Case 12
                        CaveFile = "ch_NARI_04series.txt"
                    Case 13
                        CaveFile = "ch_MAT_t_hunter_otakara.txt"
                    Case 14
                        CaveFile = "ch_MUKI_bigfoot.txt"
                    Case 15
                        CaveFile = "ch_MIYA_oopan.txt"
                    Case 16
                        CaveFile = "ch_MAT_yellow_purple_white.txt"
                    Case 17
                        CaveFile = "ch_MUKI_redblue.txt"
                    Case 18
                        CaveFile = "ch_NARI_08tobasare.txt"
                    Case 19
                        CaveFile = "ch_NARI_02tile.txt"
                    Case 20
                        CaveFile = "ch_MAT_crawler.txt"
                    Case 21
                        CaveFile = "ch_MAT_route_rover.txt"
                    Case 22
                        CaveFile = "ch_MUKI_enemyzero.txt"
                    Case 23
                        CaveFile = "ch_NARI_09suikomi.txt"
                    Case 24
                        CaveFile = "ch_MUKI_houdai.txt"
                    Case 25
                        CaveFile = "ch_NARI_06start3hard.txt"
                    Case 26
                        CaveFile = "ch_MAT_flier.txt"
                    Case 27
                        CaveFile = "ch_MIYA_trap.txt"
                    Case 28
                        CaveFile = "ch_MUKI_bombing.txt"
                    Case 29
                        CaveFile = "ch_MUKI_king.txt"
                End Select
            ElseIf opt_2PBattle.Checked = True Then
                CaveFile = "VS.txt"
            End If

            If opt_2PBattle.Checked = True Then
            Else

                If chk_IgnoreCaveMusic.Checked = False Then
                    If CaveFile.StartsWith("tutorial") Then
                        TotakaBgmFileName = "BgmList_Tutorial.txt"
                    ElseIf CaveFile.StartsWith("forest") Then
                        TotakaBgmFileName = "BgmList_Forest.txt"
                    ElseIf CaveFile.StartsWith("yakushima") Then
                        TotakaBgmFileName = "BgmList_Yakushima.txt"
                    ElseIf CaveFile.StartsWith("last") Then
                        TotakaBgmFileName = "BgmList_Last.txt"
                    ElseIf CaveFile.StartsWith("ch_") Then
                        If MainMenu.CustomDirOptions.Count >= 4 AndAlso MainMenu.CustomDirOptions(3) = "True" Then TotakaBgmFileName = "BgmList_Challenge.txt" Else TotakaBgmFileName = "ChallengeBgmList.txt"
                    ElseIf CaveFile = "VS.txt" Then
                        TotakaBgmFileName = "VS.txt"
                    End If
                    If TotakaBgmFileName = "VS.txt" Then
                    Else
                        If MainMenu.CustomDirOptions.Count >= 3 Then
                            Try
                                BgmFile = My.Computer.FileSystem.ReadAllText(MainMenu.CustomDirOptions(2) & TotakaBgmFileName)
                            Catch ex As Exception
                                MsgBox("Couldn't find '" & TotakaBgmFileName & "' inside your custom music directory!")
                                cancelnow = True
                            End Try
                        Else
                            BgmFile = My.Computer.FileSystem.ReadAllText(RootDirectory & "\user\Totaka\" & TotakaBgmFileName)
                        End If

                    End If
                    If cancelnow = False Then
                        While BgmFile.Contains("#")
                            Dim bgmfiletest As String = BgmFile.Substring(BgmFile.IndexOf("#"), BgmFile.Length - (BgmFile.IndexOf("#") + 1))
                            Dim BgmFileNotes As String = bgmfiletest.Substring(0, bgmfiletest.IndexOf("
"))
                            BgmFile = BgmFile.Replace(BgmFileNotes, "")
                        End While
                        Dim SongName As String = "{
	" & lst_Sublevels.Items.Count & "
	"
                        lst_Sublevels.SelectedIndex = -1
                        Dim i As Integer = 0
                        While i < lst_Sublevels.Items.Count
                            i += 1
                            lst_Sublevels.SelectedIndex += 1

                            If i = lst_Sublevels.Items.Count Then
                                SongName = SongName & lst_totaka_MusicList.SelectedItem & "
}"
                            Else
                                SongName = SongName & lst_totaka_MusicList.SelectedItem & "
	"
                            End If
                        End While

                        '''''''THIS DOESNT WORK FOR CHALLENGE MODE YET!!!
                        Dim ReplaceThisPartOfBgmList As String
                        Dim CaveFileMinustxt As String = CaveFile.Substring(0, CaveFile.IndexOf("."))
                        Select Case CaveFileMinustxt.Last
                            Case "1"
                                Dim AfterSection As String = BgmFile.Substring(BgmFile.IndexOf("}") + 1, BgmFile.Length - BgmFile.IndexOf("}") - 1)
                                ReplaceThisPartOfBgmList = BgmFile.Substring(BgmFile.IndexOf("{"), (BgmFile.Length - BgmFile.IndexOf("{")) - AfterSection.Length)
                                If CaveFile.Contains("tutorial") Then
                                    BgmFile = "3

"
                                ElseIf CaveFile.Contains("last") Then
                                    BgmFile = "3

"
                                Else
                                    BgmFile = "4

"
                                End If
                                BgmFile = BgmFile & SongName & AfterSection
                            Case "2"
                                Dim SkipFirst As String = BgmFile.Substring(BgmFile.IndexOf("}") + 1, BgmFile.Length - (BgmFile.IndexOf("}") + 1))
                                Dim FirstPart As String = BgmFile.Substring(BgmFile.IndexOf("{"), BgmFile.Length - BgmFile.IndexOf("{"))
                                FirstPart = FirstPart.Substring(0, FirstPart.IndexOf("}") + 1)
                                Dim AfterSection As String = SkipFirst.Substring(SkipFirst.IndexOf("}") + 1, SkipFirst.Length - SkipFirst.IndexOf("}") - 1)
                                ReplaceThisPartOfBgmList = SkipFirst.Substring(SkipFirst.IndexOf("{"), (SkipFirst.Length - SkipFirst.IndexOf("{")) - AfterSection.Length)
                                If CaveFile.Contains("tutorial") Then
                                    BgmFile = "3

"
                                ElseIf CaveFile.Contains("last") Then
                                    BgmFile = "3

"
                                Else
                                    BgmFile = "4

"
                                End If
                                BgmFile = BgmFile & FirstPart & "

" & SongName & AfterSection
                            Case "3"
                                Dim SkipFirst As String = BgmFile.Substring(BgmFile.IndexOf("}") + 1, BgmFile.Length - BgmFile.IndexOf("}") - 1)
                                Dim FirstPart As String = BgmFile.Substring(BgmFile.IndexOf("{"), BgmFile.Length - BgmFile.IndexOf("{"))
                                FirstPart = FirstPart.Substring(0, FirstPart.IndexOf("}") + 1)
                                Dim SkipSecond As String = SkipFirst.Substring(SkipFirst.IndexOf("}") + 1, SkipFirst.Length - SkipFirst.IndexOf("}") - 1)
                                Dim SecondPart As String = SkipFirst.Substring(SkipFirst.IndexOf("{"), SkipFirst.Length - SkipFirst.IndexOf("{"))
                                SecondPart = SecondPart.Substring(0, SecondPart.IndexOf("}") + 1)
                                Dim AfterSection As String = SkipSecond.Substring(SkipSecond.IndexOf("}") + 1, SkipSecond.Length - SkipSecond.IndexOf("}") - 1)
                                ReplaceThisPartOfBgmList = SkipSecond.Substring(SkipSecond.IndexOf("{"), (SkipSecond.Length - SkipSecond.IndexOf("{")) - AfterSection.Length)
                                If CaveFile.Contains("tutorial") Then
                                    BgmFile = "3

"
                                ElseIf CaveFile.Contains("last") Then
                                    BgmFile = "3

"
                                Else
                                    BgmFile = "4

"
                                End If
                                BgmFile = BgmFile & FirstPart & "

" & SecondPart & "

" & SongName & AfterSection
                            Case "4"
                                Dim SkipFirst As String = BgmFile.Substring(BgmFile.IndexOf("}") + 1, BgmFile.Length - BgmFile.IndexOf("}") - 1)
                                Dim FirstPart As String = BgmFile.Substring(BgmFile.IndexOf("{"), BgmFile.Length - BgmFile.IndexOf("{"))
                                FirstPart = FirstPart.Substring(0, FirstPart.IndexOf("}") + 1)
                                Dim SkipSecond As String = SkipFirst.Substring(SkipFirst.IndexOf("}") + 1, SkipFirst.Length - SkipFirst.IndexOf("}") - 1)
                                Dim SecondPart As String = SkipFirst.Substring(SkipFirst.IndexOf("{"), SkipFirst.Length - SkipFirst.IndexOf("{"))
                                SecondPart = SecondPart.Substring(0, SecondPart.IndexOf("}") + 1)
                                Dim SkipThird As String = SkipSecond.Substring(SkipSecond.IndexOf("}") + 1, SkipSecond.Length - SkipSecond.IndexOf("}") - 1)
                                Dim ThirdPart As String = SkipSecond.Substring(SkipSecond.IndexOf("{"), SkipSecond.Length - SkipSecond.IndexOf("{"))
                                ThirdPart = ThirdPart.Substring(0, ThirdPart.IndexOf("}") + 1)
                                Dim AfterSection As String = SkipThird.Substring(SkipThird.IndexOf("}") + 1, SkipThird.Length - SkipThird.IndexOf("}") - 1)
                                ReplaceThisPartOfBgmList = SkipThird.Substring(SkipThird.IndexOf("{"), (SkipThird.Length - SkipThird.IndexOf("{")) - AfterSection.Length)
                                If CaveFile.Contains("tutorial") Then
                                    BgmFile = "3

"
                                ElseIf CaveFile.Contains("last") Then
                                    BgmFile = "3

"
                                Else
                                    BgmFile = "4

"
                                End If
                                BgmFile = BgmFile & FirstPart & "

" & SecondPart & "

" & ThirdPart & "

" & SongName & AfterSection
                        End Select


                        If TotakaBgmFileName = "ChallengeBgmList.txt" OrElse TotakaBgmFileName = "BgmList_Challenge.txt" Then
                            Dim FirstPartLength As Integer = GetNthIndexNew(BgmFile, "{"c, cmb_ReplaceWith.SelectedIndex + 1)
                            Dim LastPartLength As Integer = GetNthIndexNew(BgmFile, "{"c, cmb_ReplaceWith.SelectedIndex + 2)
                            Dim FirstSection As String = BgmFile.Substring(0, FirstPartLength)
                            Dim LastSection As String = ""
                            If LastPartLength >= 0 Then
                                LastSection = BgmFile.Substring(LastPartLength, BgmFile.Length - (LastPartLength))
                            End If


                            BgmFile = FirstSection & SongName & "

" & LastSection
                            Dim source As String = BgmFile
                            Dim stringSeparators() As String = {"
"}

                            Dim result() As String
                            result = source.Split(stringSeparators,
                      StringSplitOptions.RemoveEmptyEntries)
                            BgmFile = String.Join("
", result)

                        End If

                    End If
                End If
            End If

            If chk_UseCMproperties.Checked = True Then
                Dim OriginalCMPfullCode As String
                Dim stagesFilename As String = "stages.txt"
                If MainMenu.CustomDirOptions.Count >= 4 AndAlso MainMenu.CustomDirOptions(3) = "True" Then stagesFilename = "stages_ch.ini"
                If MainMenu.CustomDirOptions.Count >= 3 Then
                    Try
                        OriginalCMPfullCode = My.Computer.FileSystem.ReadAllText(MainMenu.CustomDirOptions(1) & stagesFilename)
                    Catch ex As Exception
                        MsgBox("Couldn't find '" & stagesFilename & "' inside your custom Challenge Mode Parameters directory!")
                        cancelnow = True
                    End Try

                Else
                    OriginalCMPfullCode = My.Computer.FileSystem.ReadAllText(RootDirectory & "\user\Matoba\challenge\" & stagesFilename)
                End If
                If cancelnow = False Then
                    Dim i As Integer = cmb_ReplaceWith.SelectedIndex + 1

                    Dim index As Integer = GetNthIndex(OriginalCMPfullCode, "{", i)
                    Dim index2 As Integer = GetNthIndex(OriginalCMPfullCode, "}", i)
                    Dim NewCMPcode As String = "{
	4 # version
	" & CaveFile & " # cave file
	# PikiCounter
" & CMPcode
                    Dim FirstmInecrafter As String = OriginalCMPfullCode.Substring(0, index2)
                    Dim Minecraftboy69 As String = OriginalCMPfullCode.Substring(index, FirstmInecrafter.Length - index)
                    Dim Minecraftboy69Lines() As String = Minecraftboy69.Split(Environment.NewLine.ToCharArray, System.StringSplitOptions.RemoveEmptyEntries)
                    NewCMPcode = NewCMPcode.Replace("	0 # CaveCreator2Dindex_THIS-SHOULD-BE-REPLACED", Minecraftboy69Lines(30))
                    CMPfullCode = OriginalCMPfullCode.Substring(0, index) & NewCMPcode & vbCrLf & OriginalCMPfullCode.Substring(index2, OriginalCMPfullCode.Length - (index2))

                    If MainMenu.CustomDirOptions.Count >= 3 Then
                        My.Computer.FileSystem.WriteAllText(MainMenu.CustomDirOptions(1) & stagesFilename, CMPfullCode, False, System.Text.Encoding.GetEncoding(932))
                    Else
                        My.Computer.FileSystem.WriteAllText(RootDirectory & "\user\Matoba\challenge\" & stagesFilename, CMPfullCode, False, System.Text.Encoding.GetEncoding(932))
                    End If
                End If
            End If
            If cancelnow = False Then
                If TotakaBgmFileName = "VS.txt" Then
                Else
                    If MainMenu.CustomDirOptions.Count >= 3 Then
                        My.Computer.FileSystem.WriteAllText(MainMenu.CustomDirOptions(2) & TotakaBgmFileName, BgmFile, False, System.Text.Encoding.GetEncoding(932))
                    Else
                        My.Computer.FileSystem.WriteAllText(RootDirectory & "\user\Totaka\" & TotakaBgmFileName, BgmFile, False, System.Text.Encoding.GetEncoding(932))
                    End If
                End If
                If cancelnow = False Then
                    exportwindowshow = False

                    'Me.Opacity = 0


                    'ExportCaveProcess.Show()
                    ExportCave()
                End If
            End If
        End If
        pnl_Controls.Enabled = True
        btn_ExportCaveFile.Enabled = True
        btn_CopyMusicCode.Enabled = True
    End Sub
    Public Function GetNthIndexNew(searchString As String, charToFind As Char, n As Integer) As Integer
        Dim charIndexPair = searchString.Select(Function(c, i) New With {.Character = c, .Index = i}) _
                                    .Where(Function(x) x.Character = charToFind) _
                                    .ElementAtOrDefault(n - 1)
        Return If(charIndexPair IsNot Nothing, charIndexPair.Index, -1)
    End Function

    Private Sub chk_ShowAdvanced_CheckedChanged(sender As Object, e As EventArgs) Handles chk_ShowAdvanced.CheckedChanged
        chk_ShowAdvanced.Enabled = False

        If chk_ShowAdvanced.Checked = True Then
            btn_ExportCaveFile.Location = New Point(390, 408)
            btn_CopyMusicCode.Location = New Point(390, 407)
            pnl_Advanced.Visible = True
            btn_ExportCaveFile.Visible = True
            btn_CopyMusicCode.Visible = True
            btn_ImportCave.Left = 240
            btn_ExportCaveFile.Location = New Point(390, 268)
            btn_CopyMusicCode.Location = New Point(390, 297)
            chk_ShowAdvanced.Enabled = True
            btn_ImportCave.Location = New Point(215, 268)
        Else
            btn_CopyMusicCode.Location = New Point(390, 407)
            btn_ImportCave.Location = New Point(285, 268)
            chk_ShowAdvanced.Enabled = True
            chk_IgnoreCaveMusic.Checked = False
            chk_IgnoreTheKey.Checked = False
            pnl_Advanced.Visible = False
            btn_ExportCaveFile.Visible = False
            btn_CopyMusicCode.Visible = False
            btn_ExportCaveFile.Location = New Point(390, 408)
        End If
    End Sub
    Private Sub btn_ExportCaveFile_Click(sender As Object, e As EventArgs) Handles btn_ExportCaveFile.Click

        If lst_Sublevels.Items.Count = 0 Then
            MsgBox("There are no sublevels.")
        Else
            pnl_Controls.Enabled = False
            btn_ExportCaveFile.Enabled = False
            btn_CopyMusicCode.Enabled = False
            EnterSublevelEntities()
            If cmb_Sublevels.SelectedIndex = -1 Then lst_RegularEntitiesNormList.Items.Clear()
            TabControl1.SelectedTab = tbp_SublevelManager
            TabControl1.SelectedTab = tbp_ImportManager
            exportwindowshow = True
            'ExportCaveProcess.Location = New Point(Me.Location.X + ((Me.Width / 2) - ExportCaveProcess.Width / 2), Me.Location.Y + ((Me.Height / 2) - ExportCaveProcess.Height / 2))
            '
            ''Me.Opacity = 0
            '
            ''ExportCaveProcess.Show()
            'ExportCaveProcess.lbl_Percentage.Text = "0%"
            'ExportCaveProcess.pgb_Process.Value = 0
            ''ExportCaveProcess.Show()
            ExportCave()
        End If
        pnl_Controls.Enabled = True
        btn_ExportCaveFile.Enabled = True
        btn_CopyMusicCode.Enabled = True
    End Sub
    Private Sub btn_CopyMusicCode_Click(sender As Object, e As EventArgs) Handles btn_CopyMusicCode.Click

        If lst_Sublevels.Items.Count = 0 Then
            MsgBox("There are no sublevels.")
        Else
            btn_CopyMusicCode.Enabled = False
            Dim SongName As String = "{
	" & lst_Sublevels.Items.Count & "
	"

            lst_Sublevels.SelectedIndex = -1
            Dim i As Integer = 0
            While i < lst_Sublevels.Items.Count
                i += 1
                lst_Sublevels.SelectedIndex += 1

                If i = lst_Sublevels.Items.Count Then
                    SongName = SongName & lst_totaka_MusicList.SelectedItem & "
}"
                Else
                    SongName = SongName & lst_totaka_MusicList.SelectedItem & "
	"
                End If
            End While
            Clipboard.SetText(SongName)
            CopiedToClipboard.txt_Copied.Text = SongName
            CopiedToClipboard.Location = New Point(Me.Location.X + ((Me.Width / 2) - CopiedToClipboard.Width / 2), Me.Location.Y + ((Me.Height / 2) - CopiedToClipboard.Height / 2))
            CopiedToClipboard.ShowDialog()
        End If
        btn_CopyMusicCode.Enabled = True
    End Sub

    Private Sub opt_ChallengeMode_CheckedChanged(sender As Object, e As EventArgs) Handles opt_ChallengeMode.CheckedChanged
        If opt_ChallengeMode.Checked = True Then
            chk_UseCMproperties.Enabled = True
            If lbl_CMsaved.ForeColor = Color.Green Then
                chk_UseCMproperties.Checked = True
            End If
        Else
            chk_UseCMproperties.Enabled = False
            chk_UseCMproperties.Checked = False
        End If
        SetCaveNameList()
    End Sub

    Private Sub btn_ResetTimes_Click(sender As Object, e As EventArgs)
        lst_Times.Items.Clear()
        CMunsavedNow()
    End Sub

    Private Sub num_CMPsubCount_ValueChanged(sender As Object, e As EventArgs) Handles num_CMPsubCount.ValueChanged
        If lst_Times.Items.Count > num_CMPsubCount.Value Then
            Dim i As Integer = 0
            While i <= (lst_Times.Items.Count - num_CMPsubCount.Value)
                i += 1
                lst_Times.Items.RemoveAt(lst_Times.Items.Count - 1)
            End While
            'MsgBox("One or more times have been removed from the list to match the sublevel count parameter.")
        End If
        CMunsavedNow()
    End Sub
    Private Sub chk_UseCMproperties_CheckedChanged(sender As Object, e As EventArgs) Handles chk_UseCMproperties.CheckedChanged
        Select Case chk_UseCMproperties.Checked
            Case True
                If lbl_CMsaved.ForeColor = Color.Red Then
                    Dim result As Integer = MessageBox.Show("You have not saved your custom Challenge Mode properties.

Would you like to jump to the editor?", "Note",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Exclamation,
            MessageBoxDefaultButton.Button1)
                    If result = DialogResult.Yes Then TabControl1.SelectedTab = tbp_ChallengeModeProperties
                    btn_Focus.Select()
                    chk_UseCMproperties.Checked = False
                End If
        End Select
    End Sub
    Private Sub SetCaveNameList()
        Dim CurrentlySelectedIndex As Integer = cmb_ReplaceWith.SelectedIndex
        cmb_ReplaceWith.Items.Clear()
        Select Case opt_EnglishNames.Checked
            Case True
                If opt_Main.Checked = True Then
                    chk_IgnoreTheKey.Checked = False
                    chk_IgnoreTheKey.Enabled = False
                    cmb_ReplaceWith.Items.Add("Emergence Cave")
                    cmb_ReplaceWith.Items.Add("Subterranean Complex")
                    cmb_ReplaceWith.Items.Add("Frontier Cavern")
                    cmb_ReplaceWith.Items.Add("Hole of Beasts")
                    cmb_ReplaceWith.Items.Add("White Flower Garden")
                    cmb_ReplaceWith.Items.Add("Bulbax Kingdom")
                    cmb_ReplaceWith.Items.Add("Snagret Hole")
                    cmb_ReplaceWith.Items.Add("Citadel of Spiders")
                    cmb_ReplaceWith.Items.Add("Glutton's Kitchen")
                    cmb_ReplaceWith.Items.Add("Shower Room")
                    cmb_ReplaceWith.Items.Add("Submerged Castle")
                    cmb_ReplaceWith.Items.Add("Cavern of Chaos")
                    cmb_ReplaceWith.Items.Add("Hole of Heroes")
                    cmb_ReplaceWith.Items.Add("Dream Den")
                ElseIf opt_ChallengeMode.Checked = True Then
                    chk_IgnoreTheKey.Enabled = True
                    cmb_ReplaceWith.Items.Add("Explorer's Cave")
                    cmb_ReplaceWith.Items.Add("Novice Training")
                    cmb_ReplaceWith.Items.Add("Lost Toy Box")
                    cmb_ReplaceWith.Items.Add("Creator's Garden")
                    cmb_ReplaceWith.Items.Add("Green Hole")
                    cmb_ReplaceWith.Items.Add("Hot House")
                    cmb_ReplaceWith.Items.Add("Brawny Abyss")
                    cmb_ReplaceWith.Items.Add("Red Chasm")
                    cmb_ReplaceWith.Items.Add("Trampled Garden")
                    cmb_ReplaceWith.Items.Add("Twilight Garden")
                    cmb_ReplaceWith.Items.Add("Cryptic Cavern")
                    cmb_ReplaceWith.Items.Add("Concrete Maze")
                    cmb_ReplaceWith.Items.Add("Collector's Room")
                    cmb_ReplaceWith.Items.Add("Dweevil Nest")
                    cmb_ReplaceWith.Items.Add("Cavernous Abyss")
                    cmb_ReplaceWith.Items.Add("Snack Pit")
                    cmb_ReplaceWith.Items.Add("Three Color Training")
                    cmb_ReplaceWith.Items.Add("Hazard Training")
                    cmb_ReplaceWith.Items.Add("Cave of Snarls")
                    cmb_ReplaceWith.Items.Add("The Giant's Bath")
                    cmb_ReplaceWith.Items.Add("Rumbling Grotto")
                    cmb_ReplaceWith.Items.Add("Subterranean Lair")
                    cmb_ReplaceWith.Items.Add("Hidden Garden")
                    cmb_ReplaceWith.Items.Add("Abduction Den")
                    cmb_ReplaceWith.Items.Add("Secret Testing Range")
                    cmb_ReplaceWith.Items.Add("Breeding Ground")
                    cmb_ReplaceWith.Items.Add("Cave of Pain")
                    cmb_ReplaceWith.Items.Add("Bully Den")
                    cmb_ReplaceWith.Items.Add("Sniper Room")
                    cmb_ReplaceWith.Items.Add("Emperor's Realm")
                ElseIf opt_2PBattle.Checked = True Then
                    chk_IgnoreTheKey.Checked = False
                    chk_IgnoreTheKey.Enabled = False
                    cmb_ReplaceWith.Items.Add("Battle Field")
                    cmb_ReplaceWith.Items.Add("War Path")
                    cmb_ReplaceWith.Items.Add("Carpet Plain")
                    cmb_ReplaceWith.Items.Add("Angle Maze")
                    cmb_ReplaceWith.Items.Add("Colosseum")
                    cmb_ReplaceWith.Items.Add("Rusty Gulch")
                    cmb_ReplaceWith.Items.Add("Brawl Yard")
                    cmb_ReplaceWith.Items.Add("Tile Lands")
                    cmb_ReplaceWith.Items.Add("Dim Labyrinth")
                    cmb_ReplaceWith.Items.Add("Hostile Territory")
                End If
            Case False
                If opt_Main.Checked = True Then
                    chk_IgnoreTheKey.Checked = False
                    chk_IgnoreTheKey.Enabled = False
                    cmb_ReplaceWith.Items.Add("tutorial_1")
                    cmb_ReplaceWith.Items.Add("tutorial_2")
                    cmb_ReplaceWith.Items.Add("tutorial_3")
                    cmb_ReplaceWith.Items.Add("forest_1")
                    cmb_ReplaceWith.Items.Add("forest_2")
                    cmb_ReplaceWith.Items.Add("forest_3")
                    cmb_ReplaceWith.Items.Add("forest_4")
                    cmb_ReplaceWith.Items.Add("yakushima_1")
                    cmb_ReplaceWith.Items.Add("yakushima_2")
                    cmb_ReplaceWith.Items.Add("yakushima_3")
                    cmb_ReplaceWith.Items.Add("yakushima_4")
                    cmb_ReplaceWith.Items.Add("last_1")
                    cmb_ReplaceWith.Items.Add("last_2")
                    cmb_ReplaceWith.Items.Add("last_3")
                ElseIf opt_ChallengeMode.Checked = True Then
                    chk_IgnoreTheKey.Enabled = True
                    cmb_ReplaceWith.Items.Add("ch_ABEM_tutorial.txt")
                    cmb_ReplaceWith.Items.Add("ch_NARI_07whitepurple.txt")
                    cmb_ReplaceWith.Items.Add("ch_NARI_03toy.txt")
                    cmb_ReplaceWith.Items.Add("ch_NARI_01kusachi.txt")
                    cmb_ReplaceWith.Items.Add("ch_ABEM_LeafChappy.txt")
                    cmb_ReplaceWith.Items.Add("ch_NARI_05start3easy.txt")
                    cmb_ReplaceWith.Items.Add("ch_MUKI_metal.txt")
                    cmb_ReplaceWith.Items.Add("ch_MAT_limited_time.txt")
                    cmb_ReplaceWith.Items.Add("ch_MAT_t_hunter_hana.txt")
                    cmb_ReplaceWith.Items.Add("ch_MUKI_damagumo.txt")
                    cmb_ReplaceWith.Items.Add("ch_MAT_t_hunter_enemy.txt")
                    cmb_ReplaceWith.Items.Add("ch_MAT_conc_cave.txt")
                    cmb_ReplaceWith.Items.Add("ch_NARI_04series.txt")
                    cmb_ReplaceWith.Items.Add("ch_MAT_t_hunter_otakara.txt")
                    cmb_ReplaceWith.Items.Add("ch_MUKI_bigfoot.txt")
                    cmb_ReplaceWith.Items.Add("ch_MIYA_oopan.txt")
                    cmb_ReplaceWith.Items.Add("ch_MAT_yellow_purple_white.txt")
                    cmb_ReplaceWith.Items.Add("ch_MUKI_redblue.txt")
                    cmb_ReplaceWith.Items.Add("ch_NARI_08tobasare.txt")
                    cmb_ReplaceWith.Items.Add("ch_NARI_02tile.txt")
                    cmb_ReplaceWith.Items.Add("ch_MAT_crawler.txt")
                    cmb_ReplaceWith.Items.Add("ch_MAT_route_rover.txt")
                    cmb_ReplaceWith.Items.Add("ch_MUKI_enemyzero.txt")
                    cmb_ReplaceWith.Items.Add("ch_NARI_09suikomi.txt")
                    cmb_ReplaceWith.Items.Add("ch_MUKI_houdai.txt")
                    cmb_ReplaceWith.Items.Add("ch_NARI_06start3hard.txt")
                    cmb_ReplaceWith.Items.Add("ch_MAT_flier.txt")
                    cmb_ReplaceWith.Items.Add("ch_MIYA_trap.txt")
                    cmb_ReplaceWith.Items.Add("ch_MUKI_bombing.txt")
                    cmb_ReplaceWith.Items.Add("ch_MUKI_king.txt")
                ElseIf opt_2PBattle.Checked = True Then
                    chk_IgnoreTheKey.Checked = False
                    chk_IgnoreTheKey.Enabled = False
                    cmb_ReplaceWith.Items.Add("vs_`otegaru")
                    cmb_ReplaceWith.Items.Add("vs_2_ujyaujya")
                    cmb_ReplaceWith.Items.Add("vs_3_hirobiro")
                    cmb_ReplaceWith.Items.Add("vs_4_karakuchi")
                    cmb_ReplaceWith.Items.Add("vs_5_semai")
                    cmb_ReplaceWith.Items.Add("vs_6_hiyahiya")
                    cmb_ReplaceWith.Items.Add("vs_7_nobinobi")
                    cmb_ReplaceWith.Items.Add("vs_8_kakukaku")
                    cmb_ReplaceWith.Items.Add("vs_9_meiro")
                    cmb_ReplaceWith.Items.Add("vs_10_tile")
                End If
        End Select
        If cmb_ReplaceWith.Items.Count < CurrentlySelectedIndex + 1 Then
            cmb_ReplaceWith.SelectedIndex = cmb_ReplaceWith.Items.Count - 1
        Else
            cmb_ReplaceWith.SelectedIndex = CurrentlySelectedIndex
        End If
    End Sub
    Private Sub opt_EnglishNames_CheckedChanged(sender As Object, e As EventArgs) Handles opt_EnglishNames.CheckedChanged
        SetCaveNameList()
    End Sub
    Private Sub opt_InternalNames_CheckedChanged(sender As Object, e As EventArgs) Handles opt_InternalNames.CheckedChanged
        SetCaveNameList()
    End Sub
    Private Sub opt_Main_CheckedChanged(sender As Object, e As EventArgs) Handles opt_Main.CheckedChanged
        SetCaveNameList()
    End Sub
    Private Sub opt_2PBattle_CheckedChanged(sender As Object, e As EventArgs) Handles opt_2PBattle.CheckedChanged
        SetCaveNameList()
    End Sub

    Private Sub num_uss_ValueChanged(sender As Object, e As EventArgs) Handles num_uss.ValueChanged
        CMunsavedNow()
        If lst_Times.Items.Count > 0 Then
            IMPORTCHallengeMode()
        End If
    End Sub

    Private Sub num_ubs_ValueChanged(sender As Object, e As EventArgs) Handles num_ubs.ValueChanged
        CMunsavedNow()
        If lst_Times.Items.Count > 0 Then
            IMPORTCHallengeMode()
        End If
    End Sub
    Private Sub btn_Options_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        OptionsMenu.SetDesktopLocation(Me.Location.X + ((Me.Width / 2) - OptionsMenu.Width / 2), Me.Location.Y + ((Me.Height / 2) - OptionsMenu.Height / 2))
        OptionsMenu.ShowDialog()
        loadOptions()
    End Sub
    Private Sub TabControl1_DragEnter(sender As Object, e As DragEventArgs) Handles TabControl1.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then e.Effect = DragDropEffects.All
    End Sub
    Public Sub DragDroppedData()




        Dim result As Integer
        If lst_Sublevels.Items.Count > 0 Then
            result = MessageBox.Show("Are you sure you want to abandon your current cave?" & vbCrLf & vbCrLf & "This will be permanent.", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)
        Else
            result = DialogResult.Yes
        End If
        If result = DialogResult.Yes Then
            If btn_Entities.Enabled = False Then
                Dim tmr As New Timer
                tmr.Interval = 1
                tmr.Start()
                AddHandler tmr.Tick, Sub()
                                         pnl_Entities.Location = New Point(pnl_Entities.Location.X + 10, pnl_Entities.Location.Y)
                                         If pnl_Entities.Location.X >= 50 Then
                                             tmr.Stop()
                                             Dim tmr2 As New Timer
                                             tmr2.Interval = 1
                                             tmr2.Start()
                                             AddHandler tmr2.Tick, Sub()
                                                                       pnl_Entities.Location = New Point(pnl_Entities.Location.X + 40, pnl_Entities.Location.Y)
                                                                       If pnl_Entities.Location.X >= 600 Then
                                                                           tmr2.Stop()
                                                                           lbl_SublevelTotal.BackColor = Color.Transparent
                                                                           lbl_SublevelTotal.Location = New Point(645, 44)
                                                                           Dim tmr3 As New Timer
                                                                           tmr3.Interval = 1
                                                                           tmr3.Start()
                                                                           AddHandler tmr3.Tick, Sub()
                                                                                                     pnl_Entities.Location = New Point(pnl_Entities.Location.X + 20, pnl_Entities.Location.Y)
                                                                                                     If pnl_Entities.Location.X >= 827 Then
                                                                                                         tmr3.Stop()
                                                                                                         pnl_Entities.Location = New Point(827, 554)
                                                                                                         pnl_Entities.Visible = False
                                                                                                         EnterSublevelManager()
                                                                                                         pnl_Entities.Location = New Point(827, 554)
                                                                                                         btn_Entities.Enabled = True
                                                                                                     End If
                                                                                                 End Sub
                                                                       End If
                                                                   End Sub
                                         End If
                                     End Sub
            End If
            TabControl1.SelectedTab = tbp_SublevelManager
            SublevelTotal = 0
            SublevelTotalID = 0
            lbl_SublevelTotal.Text = SublevelTotal & " Sublevels"
            If lst_Sublevels.Items.Count > 0 Then
                lst_Sublevels.SelectedIndex = 0
                lst_Sublevels.Items.RemoveAt(lst_Sublevels.SelectedIndex)
            End If
            lst_Sublevels.Items.Clear()
            lst_Sublevel_IDs.Items.Clear()
            lst_SublevelNames.Items.Clear()
            lst_RegularEntities.Items.Clear()
            lst_RegularEntitiesCounts.Items.Clear()
            lbl_SublevelID.Text = "Nothing Selected"
            lbl_EntityCount.Text = ""
            lbl_TotalEntityCount.Text = ""
            lst_RegularEntitiesNormList.Items.Clear()
            lst_Sublevels.Items.Clear()
            lst_Sublevel_IDs.Items.Clear()
            lst_SublevelNames.Items.Clear()
            lst_RegularEntities.Items.Clear()
            lst_RegularEntitiesCounts.Items.Clear()
            lst_f2_CustomEntityTotal.Items.Clear()
            lst_f5_RoomCount.Items.Clear()
            lst_f6_Ratio.Items.Clear()
            lst_f7_Geyser.Items.Clear()
            lst_f8_UnitFile.Items.Clear()
            lst_f9_LightFile.Items.Clear()
            lst_f10_CloggedHole.Items.Clear()
            lst_f12_MusicType.Items.Clear()
            lst_f13_SolidPlane.Items.Clear()
            lst_f14_DeadEndCount.Items.Clear()
            lst_f16_WaterwraithTimer.Items.Clear()
            lst_f17_Seesaw.Items.Clear()
            lst_fa_Skybox.Items.Clear()
            lst_CustomEntityTotal_Check.Items.Clear()
            lst_totaka_MusicList.Items.Clear()
            lst_TreasureSets.Items.Clear()
            lst_GateSets.Items.Clear()
            lst_Times.Items.Clear()

            LoadCaveFiles()

            If lst_Sublevels.Items.Count = 0 Then
                btn_Save.Enabled = False
            Else
                btn_SaveAs.Enabled = True
                If CaveNeedsToSaveAs = False Then btn_Save.Enabled = True
            End If
        End If
    End Sub
    Private Sub TabControl1_DragDrop(sender As Object, e As DragEventArgs) Handles TabControl1.DragDrop
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            MyFile = e.Data.GetData(DataFormats.FileDrop)
            LoadDialog.FileName = MyFile(0)
            DragDroppedData()
        End If
    End Sub
    Public Sub TreasureConvertExternaltoInternal()
        If TreasureExternalName = "Rubber Ugly" Then TreasureInternalName = "ahiru"
        If TreasureExternalName = "Insect Condo" Then TreasureInternalName = "apple"
        If TreasureExternalName = "Meat Satchel" Then TreasureInternalName = "apple_blue"
        If TreasureExternalName = "Coiled Launcher" Then TreasureInternalName = "bane"
        If TreasureExternalName = "Confection Hoop" Then TreasureInternalName = "baum_kuchen"
        If TreasureExternalName = "Omniscient Sphere" Then TreasureInternalName = "be_dama_red"
        If TreasureExternalName = "Love Sphere" Then TreasureInternalName = "be_dama_yellow"
        If TreasureExternalName = "Mirth Sphere" Then TreasureInternalName = "be_dama_blue"
        If TreasureExternalName = "Maternal Sculpture" Then TreasureInternalName = "bell"
        If TreasureExternalName = "Stupendous Lens" Then TreasureInternalName = "bey_goma"
        If TreasureExternalName = "Leviathan Feather" Then TreasureInternalName = "bird_hane"
        If TreasureExternalName = "Superstrong Stabilizer" Then TreasureInternalName = "bolt"
        If TreasureExternalName = "Space Wave Receiver" Then TreasureInternalName = "channel"
        If TreasureExternalName = "Joy Receptacle" Then TreasureInternalName = "chess_king_black"
        If TreasureExternalName = "Worthless Statue" Then TreasureInternalName = "chess_king_white"
        If TreasureExternalName = "Priceless Statue" Then TreasureInternalName = "chess_queen_black"
        If TreasureExternalName = "Triple Sugar Threat" Then TreasureInternalName = "chess_queen_white"
        If TreasureExternalName = "King of Sweets" Then TreasureInternalName = "chocolate"
        If TreasureExternalName = "Diet Doomer" Then TreasureInternalName = "chocoichigo"
        If TreasureExternalName = "Pale Passion" Then TreasureInternalName = "chocowhite"
        If TreasureExternalName = "Boom Cone" Then TreasureInternalName = "compact"
        If TreasureExternalName = "Bug Bait" Then TreasureInternalName = "cookie"
        If TreasureExternalName = "Milk Tub" Then TreasureInternalName = "creap"
        If TreasureExternalName = "Petrified Heart" Then TreasureInternalName = "diamond_red"
        If TreasureExternalName = "Regal Diamond" Then TreasureInternalName = "diamond_blue"
        If TreasureExternalName = "Princess Pearl" Then TreasureInternalName = "diamond_green"
        If TreasureExternalName = "Silencer" Then TreasureInternalName = "doll"
        If TreasureExternalName = "Armored Nut" Then TreasureInternalName = "donguri"
        If TreasureExternalName = "Chocolate Cushion" Then TreasureInternalName = "donutschoco"
        If TreasureExternalName = "Sweet Dreamer" Then TreasureInternalName = "donutsichigo"
        If TreasureExternalName = "Cosmic Archive" Then TreasureInternalName = "donutswhite"
        If TreasureExternalName = "Cupid's Grenade" Then TreasureInternalName = "flower_red"
        If TreasureExternalName = "Science Project" Then TreasureInternalName = "flower_blue"
        If TreasureExternalName = "Manual Honer" Then TreasureInternalName = "toy_gentle"
        If TreasureExternalName = "Broken Food Master" Then TreasureInternalName = "toy_lady"
        If TreasureExternalName = "Sud Generator" Then TreasureInternalName = "toy_dog"
        If TreasureExternalName = "Wiggle Noggin" Then TreasureInternalName = "toy_cat"
        If TreasureExternalName = "Omega Flywheel" Then TreasureInternalName = "gear"
        If TreasureExternalName = "Lustrous Element" Then TreasureInternalName = "gold_medal"
        If TreasureExternalName = "Superstick Textile" Then TreasureInternalName = "gum_tape"
        If TreasureExternalName = "Possessed Squash" Then TreasureInternalName = "halloween"
        If TreasureExternalName = "Gyroid Bust" Then TreasureInternalName = "haniwa"
        If TreasureExternalName = "Sunseed Berry" Then TreasureInternalName = "ichigo"
        If TreasureExternalName = "Glee Spinner" Then TreasureInternalName = "juji_key"
        If TreasureExternalName = "Decorative Goo" Then TreasureInternalName = "kan"
        If TreasureExternalName = "Anti-hiccup Fungus" Then TreasureInternalName = "kinoko"
        If TreasureExternalName = "Crystal King" Then TreasureInternalName = "kouseki_suisyou"
        If TreasureExternalName = "Fossilized Ursidae" Then TreasureInternalName = "kumakibori"
        If TreasureExternalName = "Time Capsule" Then TreasureInternalName = "locket"
        If TreasureExternalName = "Olimarnite Shell" Then TreasureInternalName = "makigai"
        If TreasureExternalName = "Conifer Spire" Then TreasureInternalName = "matu_bokkuri"
        If TreasureExternalName = "Abstract Masterpiece" Then TreasureInternalName = "milk_cap"
        If TreasureExternalName = "Arboreal Frippery" Then TreasureInternalName = "momiji_normal"
        If TreasureExternalName = "Onion Replica" Then TreasureInternalName = "momiji_kare"
        If TreasureExternalName = "Infernal Vegetable" Then TreasureInternalName = "momiji_red"
        If TreasureExternalName = "Adamantine Girdle" Then TreasureInternalName = "nut"
        If TreasureExternalName = "Directory of Destiny" Then TreasureInternalName = "tatebue"
        If TreasureExternalName = "Colossal Fossil" Then TreasureInternalName = "saru_head"
        If TreasureExternalName = "Invigorator" Then TreasureInternalName = "sensya"
        If TreasureExternalName = "Vacuum Processor" Then TreasureInternalName = "sinkukan"
        If TreasureExternalName = "Mirrored Element" Then TreasureInternalName = "silver_medal"
        If TreasureExternalName = "Nouveau Table" Then TreasureInternalName = "tel_dial"
        If TreasureExternalName = "Pink Menace" Then TreasureInternalName = "toy_ring_a_red"
        If TreasureExternalName = "Frosty Bauble" Then TreasureInternalName = "toy_ring_a_blue"
        If TreasureExternalName = "Gemstar Husband" Then TreasureInternalName = "toy_ring_a_green"
        If TreasureExternalName = "Gemstar Wife" Then TreasureInternalName = "toy_ring_b_red"
        If TreasureExternalName = "Universal Com" Then TreasureInternalName = "toy_ring_b_blue"
        If TreasureExternalName = "Joyless Jewel" Then TreasureInternalName = "toy_ring_b_green"
        If TreasureExternalName = "Fleeting Art Form" Then TreasureInternalName = "toy_ring_c_red"
        If TreasureExternalName = "Innocence Lost" Then TreasureInternalName = "toy_ring_c_green"
        If TreasureExternalName = "Icon of Progress" Then TreasureInternalName = "toy_ring_c_blue"
        If TreasureExternalName = "Unspeakable Wonder" Then TreasureInternalName = "toy_teala"
        If TreasureExternalName = "Aquatic Mine" Then TreasureInternalName = "turi_uki"
        If TreasureExternalName = "Temporal Mechanism" Then TreasureInternalName = "watch"
        If TreasureExternalName = "Essential Furnishing" Then TreasureInternalName = "Xmas_item"
        If TreasureExternalName = "Flame Tiller" Then TreasureInternalName = "yoyo_red"
        If TreasureExternalName = "Doomsday Apparatus" Then TreasureInternalName = "yoyo_yellow"
        If TreasureExternalName = "Impediment Scourge" Then TreasureInternalName = "yoyo_blue"
        If TreasureExternalName = "Future Orb" Then TreasureInternalName = "flask"
        If TreasureExternalName = "Shock Therapist" Then TreasureInternalName = "elec"
        If TreasureExternalName = "Flare Cannon" Then TreasureInternalName = "fire"
        If TreasureExternalName = "Comedy Bomb" Then TreasureInternalName = "gas"
        If TreasureExternalName = "Monster Pump" Then TreasureInternalName = "water"
        If TreasureExternalName = "Mystical Disc" Then TreasureInternalName = "mojiban"
        If TreasureExternalName = "Vorpal Platter" Then TreasureInternalName = "futa_a_gold"
        If TreasureExternalName = "Taste Sensation" Then TreasureInternalName = "futa_a_silver"
        If TreasureExternalName = "Lip Service" Then TreasureInternalName = "kan_b_gold"
        If TreasureExternalName = "Utter Scrap" Then TreasureInternalName = "kan_b_silver"
        If TreasureExternalName = "Paradoxical Enigma" Then TreasureInternalName = "ahiru_head"
        If TreasureExternalName = "King of Bugs" Then TreasureInternalName = "loozy"
        If TreasureExternalName = "Essence of Rage" Then TreasureInternalName = "teala_dia_a"
        If TreasureExternalName = "Essence of Despair" Then TreasureInternalName = "teala_dia_b"
        If TreasureExternalName = "Essence of True Love" Then TreasureInternalName = "teala_dia_c"
        If TreasureExternalName = "Essence of Desire" Then TreasureInternalName = "teala_dia_d"
        If TreasureExternalName = "Citrus Lump" Then TreasureInternalName = "dia_a_red"
        If TreasureExternalName = "Behemoth Jaw" Then TreasureInternalName = "dia_a_blue"
        If TreasureExternalName = "Anxious Sprout" Then TreasureInternalName = "dia_a_green"
        If TreasureExternalName = "Implement of Toil" Then TreasureInternalName = "dia_b_red"
        If TreasureExternalName = "Luck Wafer" Then TreasureInternalName = "dia_b_blue"
        If TreasureExternalName = "Meat of Champions" Then TreasureInternalName = "dia_b_green"
        If TreasureExternalName = "Talisman of Life" Then TreasureInternalName = "dia_c_red"
        If TreasureExternalName = "Strife Monolith" Then TreasureInternalName = "dia_c_green"
        If TreasureExternalName = "Boss Stone" Then TreasureInternalName = "dia_c_blue"
        If TreasureExternalName = "Toxic Toadstool" Then TreasureInternalName = "kinoko_doku"
        If TreasureExternalName = "Growshroom" Then TreasureInternalName = "kinoko_tubu"
        If TreasureExternalName = "Indomitable CPU" Then TreasureInternalName = "sinkukan_b"
        If TreasureExternalName = "Network Mainbrain" Then TreasureInternalName = "sinkukan_c"
        If TreasureExternalName = "Repair Juggernaut" Then TreasureInternalName = "bolt_l"
        If TreasureExternalName = "Exhausted Superstick" Then TreasureInternalName = "gum_tape_s"
        If TreasureExternalName = "Pastry Wheel" Then TreasureInternalName = "baum_kuchen_s"
        If TreasureExternalName = "Combustion Berry" Then TreasureInternalName = "ichigo_l"
        If TreasureExternalName = "Imperative Cookie" Then TreasureInternalName = "cookie_m_l"
        If TreasureExternalName = "Compelling Cookie" Then TreasureInternalName = "cookie_u"
        If TreasureExternalName = "Impenetrable Cookie" Then TreasureInternalName = "cookie_u_l"
        If TreasureExternalName = "Comfort Cookie" Then TreasureInternalName = "cookie_s"
        If TreasureExternalName = "Succulent Mattress" Then TreasureInternalName = "cookie_s_l"
        If TreasureExternalName = "Corpulent Nut" Then TreasureInternalName = "donguri_l"
        If TreasureExternalName = "Alien Billboard" Then TreasureInternalName = "fire_helmet"
        If TreasureExternalName = "Massage Girdle" Then TreasureInternalName = "nut_l"
        If TreasureExternalName = "Crystallized Telepathy" Then TreasureInternalName = "be_dama_red_l"
        If TreasureExternalName = "Crystallized Telekinesis" Then TreasureInternalName = "be_dama_yellow_l"
        If TreasureExternalName = "Crystallized Clairvoyance" Then TreasureInternalName = "be_dama_blue_l"
        If TreasureExternalName = "Eternal Emerald Eye" Then TreasureInternalName = "diamond_red_l"
        If TreasureExternalName = "Tear Stone" Then TreasureInternalName = "diamond_blue_l"
        If TreasureExternalName = "Crystal Clover" Then TreasureInternalName = "diamond_green_l"
        If TreasureExternalName = "Danger Chime" Then TreasureInternalName = "bell_red"
        If TreasureExternalName = "Sulking Antenna" Then TreasureInternalName = "bell_blue"
        If TreasureExternalName = "Spouse Alert" Then TreasureInternalName = "bell_yellow"
        If TreasureExternalName = "Master's Instrument" Then TreasureInternalName = "bane_red"
        If TreasureExternalName = "Extreme Perspirator" Then TreasureInternalName = "bane_blue"
        If TreasureExternalName = "Pilgrim Bulb" Then TreasureInternalName = "bane_yellow"
        If TreasureExternalName = "Stone of Glory" Then TreasureInternalName = "juji_key_fc"
        If TreasureExternalName = "Furious Adhesive" Then TreasureInternalName = "tape_red"
        If TreasureExternalName = "Quenching Emblem" Then TreasureInternalName = "tape_yellow"
        If TreasureExternalName = "Flame of Tomorrow" Then TreasureInternalName = "tape_blue"
        If TreasureExternalName = "Love Nugget" Then TreasureInternalName = "leaf_normal"
        If TreasureExternalName = "Child of the Earth" Then TreasureInternalName = "leaf_yellow"
        If TreasureExternalName = "Disguised Delicacy" Then TreasureInternalName = "leaf_kare"
        If TreasureExternalName = "Proton AA" Then TreasureInternalName = "denchi_3_red"
        If TreasureExternalName = "Fuel Reservoir" Then TreasureInternalName = "denchi_3_black"
        If TreasureExternalName = "Optical Illustration" Then TreasureInternalName = "denchi_2_red"
        If TreasureExternalName = "Durable Energy Cell" Then TreasureInternalName = "denchi_2_black"
        If TreasureExternalName = "Courage Reactor" Then TreasureInternalName = "denchi_1_red"
        If TreasureExternalName = "Thirst Activator" Then TreasureInternalName = "denchi_1_black"
        If TreasureExternalName = "Harmonic Synthesizer" Then TreasureInternalName = "castanets"
        If TreasureExternalName = "Merciless Extractor" Then TreasureInternalName = "otama"
        If TreasureExternalName = "Remembered Old Buddy" Then TreasureInternalName = "robot_head"
        If TreasureExternalName = "Fond Gyro Block" Then TreasureInternalName = "j_block_red"
        If TreasureExternalName = "Memorable Gyro Block" Then TreasureInternalName = "j_block_yellow"
        If TreasureExternalName = "Lost Gyro Block" Then TreasureInternalName = "j_block_green"
        If TreasureExternalName = "Favorite Gyro Block" Then TreasureInternalName = "j_block_blue"
        If TreasureExternalName = "Treasured Gyro Block" Then TreasureInternalName = "j_block_white"
        If TreasureExternalName = "Fortified Delicacy" Then TreasureInternalName = "akagai"
        If TreasureExternalName = "Scrumptious Shell" Then TreasureInternalName = "hotate"
        If TreasureExternalName = "Memorial Shell" Then TreasureInternalName = "sinjyu"
        If TreasureExternalName = "Chance Totem" Then TreasureInternalName = "donutschoco_s"
        If TreasureExternalName = "Dream Architect" Then TreasureInternalName = "donutsichigo_s"
        If TreasureExternalName = "Spiny Alien Treat" Then TreasureInternalName = "donutswhite_s"
        If TreasureExternalName = "Spirit Flogger" Then TreasureInternalName = "gear_silver"
        If TreasureExternalName = "Mirrored Stage" Then TreasureInternalName = "compact_make"
        If TreasureExternalName = "Enamel Buster" Then TreasureInternalName = "chocolate_l"
        If TreasureExternalName = "Drought Ender" Then TreasureInternalName = "chocoichigo_l"
        If TreasureExternalName = "White Goodness" Then TreasureInternalName = "chocowhite_l"
        If TreasureExternalName = "Salivatrix" Then TreasureInternalName = "g_futa_kyodo"
        If TreasureExternalName = "Creative Inspiration" Then TreasureInternalName = "g_futa_titiyas"
        If TreasureExternalName = "Massive Lid" Then TreasureInternalName = "g_futa_kyusyu"
        If TreasureExternalName = "Happiness Emblem" Then TreasureInternalName = "g_futa_sikoku"
        If TreasureExternalName = "Survival Ointment" Then TreasureInternalName = "g_futa_kajiwara"
        If TreasureExternalName = "Mysterious Remains" Then TreasureInternalName = "g_futa_koiwai"
        If TreasureExternalName = "Dimensional Slicer" Then TreasureInternalName = "g_futa_hirosima"
        If TreasureExternalName = "Yellow Taste Tyrant" Then TreasureInternalName = "g_futa_kyosin"
        If TreasureExternalName = "Hypnotic Platter" Then TreasureInternalName = "g_futa_sakotani"
        If TreasureExternalName = "Gherkin Gate" Then TreasureInternalName = "g_futa_daisen"
        If TreasureExternalName = "Healing Cask" Then TreasureInternalName = "g_futa_hiruzen"
        If TreasureExternalName = "Pondering Emblem" Then TreasureInternalName = "g_futa_kitaama"
        If TreasureExternalName = "Activity Arouser" Then TreasureInternalName = "g_futa_nihonraku"
        If TreasureExternalName = "Stringent Container" Then TreasureInternalName = "kan_maruha"
        If TreasureExternalName = "Patience Tester" Then TreasureInternalName = "kan_nichiro"
        If TreasureExternalName = "Endless Repository" Then TreasureInternalName = "kan_iwate"
        If TreasureExternalName = "Fruit Guard" Then TreasureInternalName = "kan_kyokuyo"
        If TreasureExternalName = "Nutrient Silo" Then TreasureInternalName = "kan_meidiya"
        If TreasureExternalName = "Drone Supplies" Then TreasureInternalName = "kan_imuraya"
        If TreasureExternalName = "Unknown Merit" Then TreasureInternalName = "wadou_kaichin"
        If TreasureExternalName = "Seed of Greed" Then TreasureInternalName = "kuri"
        If TreasureExternalName = "Heavy-Duty Magnetizer" Then TreasureInternalName = "uji_jisyaku"
        If TreasureExternalName = "Air Brake" Then TreasureInternalName = "badminton"
        If TreasureExternalName = "Hideous Victual" Then TreasureInternalName = "medama_yaki"
        If TreasureExternalName = "Emperor Whistle" Then TreasureInternalName = "whistle"
        If TreasureExternalName = "Brute Knuckles" Then TreasureInternalName = "fue_a"
        If TreasureExternalName = "Dream Material" Then TreasureInternalName = "fue_b"
        If TreasureExternalName = "Amplified Amplifier" Then TreasureInternalName = "fue_wide"
        If TreasureExternalName = "Professional Noisemaker" Then TreasureInternalName = "fue_pullout"
        If TreasureExternalName = "Stellar Orb" Then TreasureInternalName = "light_a"
        If TreasureExternalName = "Justice Alloy" Then TreasureInternalName = "suit_powerup"
        If TreasureExternalName = "Forged Courage" Then TreasureInternalName = "suit_fire"
        If TreasureExternalName = "Repugnant Appendage" Then TreasureInternalName = "dashboots"
        If TreasureExternalName = "Prototype Detector" Then TreasureInternalName = "radar_a"
        If TreasureExternalName = "Five-man Napsack" Then TreasureInternalName = "radar_b"
        If TreasureExternalName = "Spherical Atlas" Then TreasureInternalName = "map01"
        If TreasureExternalName = "Geographic Projection" Then TreasureInternalName = "map02"
        If TreasureExternalName = "The Key" Then TreasureInternalName = "key"
    End Sub
    Public Sub TreasureConvertInternaltoExternal()
        If TreasureInternalName = "ahiru" Then TreasureExternalName = "Rubber Ugly"
        If TreasureInternalName = "apple" Then TreasureExternalName = "Insect Condo"
        If TreasureInternalName = "apple_blue" Then TreasureExternalName = "Meat Satchel"
        If TreasureInternalName = "bane" Then TreasureExternalName = "Coiled Launcher"
        If TreasureInternalName = "baum_kuchen" Then TreasureExternalName = "Confection Hoop"
        If TreasureInternalName = "be_dama_red" Then TreasureExternalName = "Omniscient Sphere"
        If TreasureInternalName = "be_dama_yellow" Then TreasureExternalName = "Love Sphere"
        If TreasureInternalName = "be_dama_blue" Then TreasureExternalName = "Mirth Sphere"
        If TreasureInternalName = "bell" Then TreasureExternalName = "Maternal Sculpture"
        If TreasureInternalName = "bey_goma" Then TreasureExternalName = "Stupendous Lens"
        If TreasureInternalName = "bird_hane" Then TreasureExternalName = "Leviathan Feather"
        If TreasureInternalName = "bolt" Then TreasureExternalName = "Superstrong Stabilizer"
        If TreasureInternalName = "channel" Then TreasureExternalName = "Space Wave Receiver"
        If TreasureInternalName = "chess_king_black" Then TreasureExternalName = "Joy Receptacle"
        If TreasureInternalName = "chess_king_white" Then TreasureExternalName = "Worthless Statue"
        If TreasureInternalName = "chess_queen_black" Then TreasureExternalName = "Priceless Statue"
        If TreasureInternalName = "chess_queen_white" Then TreasureExternalName = "Triple Sugar Threat"
        If TreasureInternalName = "chocolate" Then TreasureExternalName = "King of Sweets"
        If TreasureInternalName = "chocoichigo" Then TreasureExternalName = "Diet Doomer"
        If TreasureInternalName = "chocowhite" Then TreasureExternalName = "Pale Passion"
        If TreasureInternalName = "compact" Then TreasureExternalName = "Boom Cone"
        If TreasureInternalName = "cookie" Then TreasureExternalName = "Bug Bait"
        If TreasureInternalName = "creap" Then TreasureExternalName = "Milk Tub"
        If TreasureInternalName = "diamond_red" Then TreasureExternalName = "Petrified Heart"
        If TreasureInternalName = "diamond_blue" Then TreasureExternalName = "Regal Diamond"
        If TreasureInternalName = "diamond_green" Then TreasureExternalName = "Princess Pearl"
        If TreasureInternalName = "doll" Then TreasureExternalName = "Silencer"
        If TreasureInternalName = "donguri" Then TreasureExternalName = "Armored Nut"
        If TreasureInternalName = "donutschoco" Then TreasureExternalName = "Chocolate Cushion"
        If TreasureInternalName = "donutsichigo" Then TreasureExternalName = "Sweet Dreamer"
        If TreasureInternalName = "donutswhite" Then TreasureExternalName = "Cosmic Archive"
        If TreasureInternalName = "flower_red" Then TreasureExternalName = "Cupid's Grenade"
        If TreasureInternalName = "flower_blue" Then TreasureExternalName = "Science Project"
        If TreasureInternalName = "toy_gentle" Then TreasureExternalName = "Manual Honer"
        If TreasureInternalName = "toy_lady" Then TreasureExternalName = "Broken Food Master"
        If TreasureInternalName = "toy_dog" Then TreasureExternalName = "Sud Generator"
        If TreasureInternalName = "toy_cat" Then TreasureExternalName = "Wiggle Noggin"
        If TreasureInternalName = "gear" Then TreasureExternalName = "Omega Flywheel"
        If TreasureInternalName = "gold_medal" Then TreasureExternalName = "Lustrous Element"
        If TreasureInternalName = "gum_tape" Then TreasureExternalName = "Superstick Textile"
        If TreasureInternalName = "halloween" Then TreasureExternalName = "Possessed Squash"
        If TreasureInternalName = "haniwa" Then TreasureExternalName = "Gyroid Bust"
        If TreasureInternalName = "ichigo" Then TreasureExternalName = "Sunseed Berry"
        If TreasureInternalName = "juji_key" Then TreasureExternalName = "Glee Spinner"
        If TreasureInternalName = "kan" Then TreasureExternalName = "Decorative Goo"
        If TreasureInternalName = "kinoko" Then TreasureExternalName = "Anti-hiccup Fungus"
        If TreasureInternalName = "kouseki_suisyou" Then TreasureExternalName = "Crystal King"
        If TreasureInternalName = "kumakibori" Then TreasureExternalName = "Fossilized Ursidae"
        If TreasureInternalName = "locket" Then TreasureExternalName = "Time Capsule"
        If TreasureInternalName = "makigai" Then TreasureExternalName = "Olimarnite Shell"
        If TreasureInternalName = "matu_bokkuri" Then TreasureExternalName = "Conifer Spire"
        If TreasureInternalName = "milk_cap" Then TreasureExternalName = "Abstract Masterpiece"
        If TreasureInternalName = "momiji_normal" Then TreasureExternalName = "Arboreal Frippery"
        If TreasureInternalName = "momiji_kare" Then TreasureExternalName = "Onion Replica"
        If TreasureInternalName = "momiji_red" Then TreasureExternalName = "Infernal Vegetable"
        If TreasureInternalName = "nut" Then TreasureExternalName = "Adamantine Girdle"
        If TreasureInternalName = "tatebue" Then TreasureExternalName = "Directory of Destiny"
        If TreasureInternalName = "saru_head" Then TreasureExternalName = "Colossal Fossil"
        If TreasureInternalName = "sensya" Then TreasureExternalName = "Invigorator"
        If TreasureInternalName = "sinkukan" Then TreasureExternalName = "Vacuum Processor"
        If TreasureInternalName = "silver_medal" Then TreasureExternalName = "Mirrored Element"
        If TreasureInternalName = "tel_dial" Then TreasureExternalName = "Nouveau Table"
        If TreasureInternalName = "toy_ring_a_red" Then TreasureExternalName = "Pink Menace"
        If TreasureInternalName = "toy_ring_a_blue" Then TreasureExternalName = "Frosty Bauble"
        If TreasureInternalName = "toy_ring_a_green" Then TreasureExternalName = "Gemstar Husband"
        If TreasureInternalName = "toy_ring_b_red" Then TreasureExternalName = "Gemstar Wife"
        If TreasureInternalName = "toy_ring_b_blue" Then TreasureExternalName = "Universal Com"
        If TreasureInternalName = "toy_ring_b_green" Then TreasureExternalName = "Joyless Jewel"
        If TreasureInternalName = "toy_ring_c_red" Then TreasureExternalName = "Fleeting Art Form"
        If TreasureInternalName = "toy_ring_c_green" Then TreasureExternalName = "Innocence Lost"
        If TreasureInternalName = "toy_ring_c_blue" Then TreasureExternalName = "Icon of Progress"
        If TreasureInternalName = "toy_teala" Then TreasureExternalName = "Unspeakable Wonder"
        If TreasureInternalName = "turi_uki" Then TreasureExternalName = "Aquatic Mine"
        If TreasureInternalName = "watch" Then TreasureExternalName = "Temporal Mechanism"
        If TreasureInternalName = "Xmas_item" Then TreasureExternalName = "Essential Furnishing"
        If TreasureInternalName = "yoyo_red" Then TreasureExternalName = "Flame Tiller"
        If TreasureInternalName = "yoyo_yellow" Then TreasureExternalName = "Doomsday Apparatus"
        If TreasureInternalName = "yoyo_blue" Then TreasureExternalName = "Impediment Scourge"
        If TreasureInternalName = "flask" Then TreasureExternalName = "Future Orb"
        If TreasureInternalName = "elec" Then TreasureExternalName = "Shock Therapist"
        If TreasureInternalName = "fire" Then TreasureExternalName = "Flare Cannon"
        If TreasureInternalName = "gas" Then TreasureExternalName = "Comedy Bomb"
        If TreasureInternalName = "water" Then TreasureExternalName = "Monster Pump"
        If TreasureInternalName = "mojiban" Then TreasureExternalName = "Mystical Disc"
        If TreasureInternalName = "futa_a_gold" Then TreasureExternalName = "Vorpal Platter"
        If TreasureInternalName = "futa_a_silver" Then TreasureExternalName = "Taste Sensation"
        If TreasureInternalName = "kan_b_gold" Then TreasureExternalName = "Lip Service"
        If TreasureInternalName = "kan_b_silver" Then TreasureExternalName = "Utter Scrap"
        If TreasureInternalName = "ahiru_head" Then TreasureExternalName = "Paradoxical Enigma"
        If TreasureInternalName = "loozy" Then TreasureExternalName = "King of Bugs"
        If TreasureInternalName = "teala_dia_a" Then TreasureExternalName = "Essence of Rage"
        If TreasureInternalName = "teala_dia_b" Then TreasureExternalName = "Essence of Despair"
        If TreasureInternalName = "teala_dia_c" Then TreasureExternalName = "Essence of True Love"
        If TreasureInternalName = "teala_dia_d" Then TreasureExternalName = "Essence of Desire"
        If TreasureInternalName = "dia_a_red" Then TreasureExternalName = "Citrus Lump"
        If TreasureInternalName = "dia_a_blue" Then TreasureExternalName = "Behemoth Jaw"
        If TreasureInternalName = "dia_a_green" Then TreasureExternalName = "Anxious Sprout"
        If TreasureInternalName = "dia_b_red" Then TreasureExternalName = "Implement of Toil"
        If TreasureInternalName = "dia_b_blue" Then TreasureExternalName = "Luck Wafer"
        If TreasureInternalName = "dia_b_green" Then TreasureExternalName = "Meat of Champions"
        If TreasureInternalName = "dia_c_red" Then TreasureExternalName = "Talisman of Life"
        If TreasureInternalName = "dia_c_green" Then TreasureExternalName = "Strife Monolith"
        If TreasureInternalName = "dia_c_blue" Then TreasureExternalName = "Boss Stone"
        If TreasureInternalName = "kinoko_doku" Then TreasureExternalName = "Toxic Toadstool"
        If TreasureInternalName = "kinoko_tubu" Then TreasureExternalName = "Growshroom"
        If TreasureInternalName = "sinkukan_b" Then TreasureExternalName = "Indomitable CPU"
        If TreasureInternalName = "sinkukan_c" Then TreasureExternalName = "Network Mainbrain"
        If TreasureInternalName = "bolt_l" Then TreasureExternalName = "Repair Juggernaut"
        If TreasureInternalName = "gum_tape_s" Then TreasureExternalName = "Exhausted Superstick"
        If TreasureInternalName = "baum_kuchen_s" Then TreasureExternalName = "Pastry Wheel"
        If TreasureInternalName = "ichigo_l" Then TreasureExternalName = "Combustion Berry"
        If TreasureInternalName = "cookie_m_l" Then TreasureExternalName = "Imperative Cookie"
        If TreasureInternalName = "cookie_u" Then TreasureExternalName = "Compelling Cookie"
        If TreasureInternalName = "cookie_u_l" Then TreasureExternalName = "Impenetrable Cookie"
        If TreasureInternalName = "cookie_s" Then TreasureExternalName = "Comfort Cookie"
        If TreasureInternalName = "cookie_s_l" Then TreasureExternalName = "Succulent Mattress"
        If TreasureInternalName = "donguri_l" Then TreasureExternalName = "Corpulent Nut"
        If TreasureInternalName = "fire_helmet" Then TreasureExternalName = "Alien Billboard"
        If TreasureInternalName = "nut_l" Then TreasureExternalName = "Massage Girdle"
        If TreasureInternalName = "be_dama_red_l" Then TreasureExternalName = "Crystallized Telepathy"
        If TreasureInternalName = "be_dama_yellow_l" Then TreasureExternalName = "Crystallized Telekinesis"
        If TreasureInternalName = "be_dama_blue_l" Then TreasureExternalName = "Crystallized Clairvoyance"
        If TreasureInternalName = "diamond_red_l" Then TreasureExternalName = "Eternal Emerald Eye"
        If TreasureInternalName = "diamond_blue_l" Then TreasureExternalName = "Tear Stone"
        If TreasureInternalName = "diamond_green_l" Then TreasureExternalName = "Crystal Clover"
        If TreasureInternalName = "bell_red" Then TreasureExternalName = "Danger Chime"
        If TreasureInternalName = "bell_blue" Then TreasureExternalName = "Sulking Antenna"
        If TreasureInternalName = "bell_yellow" Then TreasureExternalName = "Spouse Alert"
        If TreasureInternalName = "bane_red" Then TreasureExternalName = "Master's Instrument"
        If TreasureInternalName = "bane_blue" Then TreasureExternalName = "Extreme Perspirator"
        If TreasureInternalName = "bane_yellow" Then TreasureExternalName = "Pilgrim Bulb"
        If TreasureInternalName = "juji_key_fc" Then TreasureExternalName = "Stone of Glory"
        If TreasureInternalName = "tape_red" Then TreasureExternalName = "Furious Adhesive"
        If TreasureInternalName = "tape_yellow" Then TreasureExternalName = "Quenching Emblem"
        If TreasureInternalName = "tape_blue" Then TreasureExternalName = "Flame of Tomorrow"
        If TreasureInternalName = "leaf_normal" Then TreasureExternalName = "Love Nugget"
        If TreasureInternalName = "leaf_yellow" Then TreasureExternalName = "Child of the Earth"
        If TreasureInternalName = "leaf_kare" Then TreasureExternalName = "Disguised Delicacy"
        If TreasureInternalName = "denchi_3_red" Then TreasureExternalName = "Proton AA"
        If TreasureInternalName = "denchi_3_black" Then TreasureExternalName = "Fuel Reservoir"
        If TreasureInternalName = "denchi_2_red" Then TreasureExternalName = "Optical Illustration"
        If TreasureInternalName = "denchi_2_black" Then TreasureExternalName = "Durable Energy Cell"
        If TreasureInternalName = "denchi_1_red" Then TreasureExternalName = "Courage Reactor"
        If TreasureInternalName = "denchi_1_black" Then TreasureExternalName = "Thirst Activator"
        If TreasureInternalName = "castanets" Then TreasureExternalName = "Harmonic Synthesizer"
        If TreasureInternalName = "otama" Then TreasureExternalName = "Merciless Extractor"
        If TreasureInternalName = "robot_head" Then TreasureExternalName = "Remembered Old Buddy"
        If TreasureInternalName = "j_block_red" Then TreasureExternalName = "Fond Gyro Block"
        If TreasureInternalName = "j_block_yellow" Then TreasureExternalName = "Memorable Gyro Block"
        If TreasureInternalName = "j_block_green" Then TreasureExternalName = "Lost Gyro Block"
        If TreasureInternalName = "j_block_blue" Then TreasureExternalName = "Favorite Gyro Block"
        If TreasureInternalName = "j_block_white" Then TreasureExternalName = "Treasured Gyro Block"
        If TreasureInternalName = "akagai" Then TreasureExternalName = "Fortified Delicacy"
        If TreasureInternalName = "hotate" Then TreasureExternalName = "Scrumptious Shell"
        If TreasureInternalName = "sinjyu" Then TreasureExternalName = "Memorial Shell"
        If TreasureInternalName = "donutschoco_s" Then TreasureExternalName = "Chance Totem"
        If TreasureInternalName = "donutsichigo_s" Then TreasureExternalName = "Dream Architect"
        If TreasureInternalName = "donutswhite_s" Then TreasureExternalName = "Spiny Alien Treat"
        If TreasureInternalName = "gear_silver" Then TreasureExternalName = "Spirit Flogger"
        If TreasureInternalName = "compact_make" Then TreasureExternalName = "Mirrored Stage"
        If TreasureInternalName = "chocolate_l" Then TreasureExternalName = "Enamel Buster"
        If TreasureInternalName = "chocoichigo_l" Then TreasureExternalName = "Drought Ender"
        If TreasureInternalName = "chocowhite_l" Then TreasureExternalName = "White Goodness"
        If TreasureInternalName = "g_futa_kyodo" Then TreasureExternalName = "Salivatrix"
        If TreasureInternalName = "g_futa_titiyas" Then TreasureExternalName = "Creative Inspiration"
        If TreasureInternalName = "g_futa_kyusyu" Then TreasureExternalName = "Massive Lid"
        If TreasureInternalName = "g_futa_sikoku" Then TreasureExternalName = "Happiness Emblem"
        If TreasureInternalName = "g_futa_kajiwara" Then TreasureExternalName = "Survival Ointment"
        If TreasureInternalName = "g_futa_koiwai" Then TreasureExternalName = "Mysterious Remains"
        If TreasureInternalName = "g_futa_hirosima" Then TreasureExternalName = "Dimensional Slicer"
        If TreasureInternalName = "g_futa_kyosin" Then TreasureExternalName = "Yellow Taste Tyrant"
        If TreasureInternalName = "g_futa_sakotani" Then TreasureExternalName = "Hypnotic Platter"
        If TreasureInternalName = "g_futa_daisen" Then TreasureExternalName = "Gherkin Gate"
        If TreasureInternalName = "g_futa_hiruzen" Then TreasureExternalName = "Healing Cask"
        If TreasureInternalName = "g_futa_kitaama" Then TreasureExternalName = "Pondering Emblem"
        If TreasureInternalName = "g_futa_nihonraku" Then TreasureExternalName = "Activity Arouser"
        If TreasureInternalName = "kan_maruha" Then TreasureExternalName = "Stringent Container"
        If TreasureInternalName = "kan_nichiro" Then TreasureExternalName = "Patience Tester"
        If TreasureInternalName = "kan_iwate" Then TreasureExternalName = "Endless Repository"
        If TreasureInternalName = "kan_kyokuyo" Then TreasureExternalName = "Fruit Guard"
        If TreasureInternalName = "kan_meidiya" Then TreasureExternalName = "Nutrient Silo"
        If TreasureInternalName = "kan_imuraya" Then TreasureExternalName = "Drone Supplies"
        If TreasureInternalName = "wadou_kaichin" Then TreasureExternalName = "Unknown Merit"
        If TreasureInternalName = "kuri" Then TreasureExternalName = "Seed of Greed"
        If TreasureInternalName = "uji_jisyaku" Then TreasureExternalName = "Heavy-Duty Magnetizer"
        If TreasureInternalName = "badminton" Then TreasureExternalName = "Air Brake"
        If TreasureInternalName = "medama_yaki" Then TreasureExternalName = "Hideous Victual"
        If TreasureInternalName = "whistle" Then TreasureExternalName = "Emperor Whistle"
        If TreasureInternalName = "fue_a" Then TreasureExternalName = "Brute Knuckles"
        If TreasureInternalName = "fue_b" Then TreasureExternalName = "Dream Material"
        If TreasureInternalName = "fue_wide" Then TreasureExternalName = "Amplified Amplifier"
        If TreasureInternalName = "fue_pullout" Then TreasureExternalName = "Professional Noisemaker"
        If TreasureInternalName = "light_a" Then TreasureExternalName = "Stellar Orb"
        If TreasureInternalName = "suit_powerup" Then TreasureExternalName = "Justice Alloy"
        If TreasureInternalName = "suit_fire" Then TreasureExternalName = "Forged Courage"
        If TreasureInternalName = "dashboots" Then TreasureExternalName = "Repugnant Appendage"
        If TreasureInternalName = "radar_a" Then TreasureExternalName = "Prototype Detector"
        If TreasureInternalName = "radar_b" Then TreasureExternalName = "Five-man Napsack"
        If TreasureInternalName = "map01" Then TreasureExternalName = "Spherical Atlas"
        If TreasureInternalName = "map02" Then TreasureExternalName = "Geographic Projection"
        If TreasureInternalName = "key" Then TreasureExternalName = "The Key"
    End Sub
    Private Sub Label25_Click(sender As Object, e As EventArgs)
    End Sub
    Private Sub btn_SaveAs_MouseEnter(sender As Object, e As EventArgs) Handles btn_SaveAs.MouseEnter
        If lst_Sublevels.Items.Count > 0 Then
            btn_SaveAs.Enabled = True
        End If
    End Sub
    Private Sub lst_Sublevels_KeyDown(sender As Object, e As KeyEventArgs) Handles lst_Sublevels.KeyDown
        If e.KeyCode = Keys.Delete Then
            btn_RemoveSublevel2.PerformClick()
        End If
    End Sub
    Private Sub lst_GatesNorm_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Delete Then
            SublevelGates.btn_DeleteSelectedGate.PerformClick()
        End If
    End Sub

    Private Sub lst_TreasuresNorm_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Delete Then
            SublevelTreasures.btn_DeleteSelectedTreasure.PerformClick()
        End If
    End Sub

    Private Sub lst_RegularEntitiesNormList_KeyDown(sender As Object, e As KeyEventArgs) Handles lst_RegularEntitiesNormList.KeyDown
        If e.KeyCode = Keys.Delete Then
            btn_DeleteSelectedEntity.PerformClick()
        End If
    End Sub

    Private Sub btn_ABOUT_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        AboutForm.SetDesktopLocation(Me.Location.X + ((Me.Width / 2) - AboutForm.Width / 2), Me.Location.Y + ((Me.Height / 2) - AboutForm.Height / 2))
        AboutForm.Opacity = 0
        AboutForm.ShowDialog()
    End Sub

    Private Sub btn_Entities_Click(sender As Object, e As EventArgs) Handles btn_Entities.Click
        btn_CloseEntities.Enabled = False
        pnl_Entities.BringToFront()
        lbl_SublevelTotal.BringToFront()
        If lst_Sublevels.Items.Count = 0 Then
            lbl_NoSublevels.Visible = True
        Else
            lbl_NoSublevels.Visible = False
        End If
        btn_Entities.Enabled = False
        btn_Focus.Select()
        EnterSublevelEntities()
        pnl_Entities.Location = New Point(12, 43)
        If cmb_Sublevels.SelectedIndex = -1 Then lst_RegularEntitiesNormList.Items.Clear()
        pnl_Entities.Visible = True
        'lbl_SublevelTotal.BackColor = Color.FromArgb(255, 64, 64, 64)
        'lbl_SublevelTotal.Top = 48
        btn_CloseEntities.Enabled = True
    End Sub

    Private Sub btn_Treasures_Click(sender As Object, e As EventArgs) Handles btn_Treasures.Click
        SublevelTreasures.ShowDialog()
        SublevelTreasures.Select()
    End Sub

    Private Sub btn_Gates_Click(sender As Object, e As EventArgs) Handles btn_Gates.Click
        SublevelGates.ShowDialog()
        SublevelGates.Select()
    End Sub

    Private Sub btn_CloseEntities_Click(sender As Object, e As EventArgs) Handles btn_CloseEntities.Click
        'lbl_SublevelTotal.BackColor = Color.Transparent
        'lbl_SublevelTotal.Top = 44
        pnl_Entities.Location = New Point(827, 554)
        pnl_Entities.Visible = False
        EnterSublevelManager()
        pnl_Entities.Location = New Point(827, 554)
        btn_Entities.Enabled = True
    End Sub

    Private Sub btn_MoveEntityUp_Click(sender As Object, e As EventArgs) Handles btn_MoveEntityUp.Click
        MovingEntity = True
        Dim i = lst_RegularEntitiesList.SelectedIndex - 1
        If lst_RegularEntitiesList.SelectedIndex > 0 Then
            lst_RegularEntitiesList.Items.Insert(i, lst_RegularEntitiesList.SelectedItem)
            lst_RegularEntitiesList.Items.RemoveAt(lst_RegularEntitiesList.SelectedIndex)
        End If
        If lst_RegularEntitiesCountList.SelectedIndex > 0 Then
            lst_RegularEntitiesCountList.Items.Insert(i, lst_RegularEntitiesCountList.SelectedItem)
            lst_RegularEntitiesCountList.Items.RemoveAt(lst_RegularEntitiesCountList.SelectedIndex)
        End If
        EnterSublevelManager()
        EnterSublevelEntities()
        MovingEntity = False
        lst_RegularEntitiesNormList.SelectedIndex = i
        btn_MoveEntityUp.Select()
    End Sub

    Private Sub btn_MoveEntityDown_Click(sender As Object, e As EventArgs) Handles btn_MoveEntityDown.Click
        MovingEntity = True
        Dim i = lst_RegularEntitiesList.SelectedIndex + 2
        If lst_RegularEntitiesList.SelectedIndex < lst_RegularEntitiesList.Items.Count - 1 Then
            lst_RegularEntitiesList.Items.Insert(i, lst_RegularEntitiesList.SelectedItem)
            lst_RegularEntitiesList.Items.RemoveAt(lst_RegularEntitiesList.SelectedIndex)
        End If
        If lst_RegularEntitiesCountList.SelectedIndex < lst_RegularEntitiesCountList.Items.Count - 1 Then
            lst_RegularEntitiesCountList.Items.Insert(i, lst_RegularEntitiesCountList.SelectedItem)
            lst_RegularEntitiesCountList.Items.RemoveAt(lst_RegularEntitiesCountList.SelectedIndex)
        End If
        EnterSublevelManager()
        EnterSublevelEntities()
        MovingEntity = False
        lst_RegularEntitiesNormList.SelectedIndex = i - 1
        btn_MoveEntityDown.Select()
    End Sub

    Private Sub btn_GeneralHelp_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        MsgBox("General Help for Cave Creator



Saving, Importing, and Exporting:


Saving - as a CC+ project file. If you are sharing your cave, it is recommended you share the CC+ project file because it stores music and challenge mode properties data, and also allows for other users to easily import.

Importing - set your root directory (either in Options or in the Import Manager) and let CC+ do all the work for you.

Exporting - save the standalone cave text file for manual importing or sharing with advanced users. Check ""Show advanced options"" in the Import Manager and a button will appear to export the cave text file.


Loading Caves:

You can either click Open, or you can just drag-and-drop your file onto the window. Supported file types are .txt and .p2ncc. Text files are for specifically caveinfo files only, and .p2ncc files are CC+ projects.


Visit the Pikmin Technical Knowledge Base for more information:
https://pikmintkb.com/Cave_Creator%2B")
    End Sub



    Private Sub btn_SaveProject_Click(sender As Object, e As EventArgs) Handles btn_SaveProject.Click
        If MustBeSavedAs = True Then
            btn_SaveAs.PerformClick()
        Else
            If Not autosaving Then LoadedOrSavedAsFileName = SaveAsDialog.FileName
            SaveData()
        End If
    End Sub
    Dim autosaving As Boolean = False
    Private Sub tmr_Autosave_Tick(sender As Object, e As EventArgs) Handles tmr_Autosave.Tick
        tmr_Autosave.Stop()
        autosaving = True
        If Not MustBeSavedAs Then
            If Not IO.Directory.Exists(IO.Path.GetDirectoryName(LoadedOrSavedAsFileName) & "\Cave Creator Auto-Save\") Then
                IO.Directory.CreateDirectory(IO.Path.GetDirectoryName(LoadedOrSavedAsFileName) & "\Cave Creator Auto-Save\")
            End If
            Dim prevName As String = LoadedOrSavedAsFileName

            Dim d As Date = Date.Now()

            LoadedOrSavedAsFileName = IO.Path.GetDirectoryName(prevName) & "\Cave Creator Auto-Save\" & IO.Path.GetFileNameWithoutExtension(LoadedOrSavedAsFileName) &
                " (" & d.ToString("d-MMM-yyyy_h-mtt") & ").p2ncc"
            '" (" & d.Day.ToString() & "-" & getMonth(d.Month) & "-" & d.Year.ToString() & "_" & d.ToString("hh-mmtt") & ").p2ncc"
            SaveData()
            LoadedOrSavedAsFileName = prevName
        End If
        autosaving = False
        tmr_Autosave.Start()
    End Sub
    Function getMonth(m) As String
        Select Case m
            Case 1
                Return "Jan"
            Case 2
                Return "Feb"
            Case 3
                Return "Mar"
            Case 4
                Return "Apr"
            Case 5
                Return "May"
            Case 6
                Return "Jun"
            Case 7
                Return "Jul"
            Case 8
                Return "Aug"
            Case 9
                Return "Sep"
            Case 10
                Return "Oct"
            Case 11
                Return "Nov"
            Case 12
                Return "Dec"
        End Select
        Return m.ToString()
    End Function
    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

        ExportCave()
    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        'MsgBox(e.ProgressPercentage.ToString())
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted

    End Sub

    Private Sub btn_Bugs_feedback_extras_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub lbl_CMsaved_TextChanged(sender As Object, e As EventArgs) Handles lbl_CMsaved.TextChanged
        If lbl_CMsaved.ForeColor = Color.Red Then
            chk_UseCMproperties.Checked = False
        End If
    End Sub

    Private Sub btn_ChallengeMode2_Click(sender As Object, e As EventArgs)
        opt_ChallengeMode.Checked = True
    End Sub

    Private Sub btn_StoryMode2_Click(sender As Object, e As EventArgs)
        opt_Main.Checked = True
    End Sub

    Private Sub tbp_ImportManager_Enter(sender As Object, e As EventArgs) Handles tbp_ImportManager.Enter
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
    End Sub
    Private Sub chk_DarkMode_CheckedChanged(sender As Object, e As EventArgs)
        'Select Case chk_DarkMode.Checked
        '    Case True
        '        ToolStrip1.BackColor = Color.Black
        '        chk_DarkMode.BackColor = Color.Black
        '        chk_DarkMode.ForeColor = Color.White
        '        btn_Load.ForeColor = Color.White
        '        btn_SaveAs.ForeColor = Color.White
        '        btn_SaveProject.ForeColor = Color.White
        '        btn_ReturnToMainMenu.ForeColor = Color.White
        '        btn_Options.ForeColor = Color.White
        '        btn_GeneralHelp.ForeColor = Color.White
        '        btn_About.ForeColor = Color.White
        '        btn_Bugs_feedback_extras.ForeColor = Color.White
        '        btn_CaveNet.ForeColor = Color.White
        '        opt_Main.ForeColor = Color.White
        '        opt_ChallengeMode.ForeColor = Color.White
        '
        '
        '        ''''''SublevelManager
        '        tbp_SublevelManager.BackColor = Color.FromArgb(255, 64, 64, 64)
        '        tbp_ChallengeModeProperties.BackColor = Color.FromArgb(255, 64, 64, 64)
        '        tbp_ImportManager.BackColor = Color.FromArgb(255, 64, 64, 64)
        '
        '        lst_Sublevels.BackColor = Color.FromArgb(255, 100, 100, 100)
        '        lst_Sublevels.ForeColor = Color.White
        '
        '        lbl_SelectedSublevelTitle.ForeColor = Color.White
        '        lbl_SublevelID.ForeColor = Color.White
        '        lbl_EntityCount.ForeColor = Color.White
        '        lbl_TotalEntityCount.ForeColor = Color.White
        '        chk_SublevelNameInput.ForeColor = Color.White
        '        chk_DeleteSublevelQ.ForeColor = Color.White
        '
        '        ''''''ChallengeModeEditor
        '        chk_CMPadvanced.ForeColor = Color.White
        '
        '        lbl_100pikiReminder.ForeColor = Color.White
        '        If lbl_PikiCount.ForeColor = Color.Black Then
        '            lbl_PikiCount.ForeColor = Color.White
        '        End If
        '        Label8.ForeColor = Color.White
        '        Label19.ForeColor = Color.White
        '        Label15.ForeColor = Color.White
        '        Label14.ForeColor = Color.White
        '        Label22.ForeColor = Color.White
        '        Label6.ForeColor = Color.White
        '        Label7.ForeColor = Color.White
        '        Label9.ForeColor = Color.White
        '        Label10.ForeColor = Color.White
        '        Label11.ForeColor = Color.White
        '        Label12.ForeColor = Color.White
        '        Label13.ForeColor = Color.White
        '        Label20.ForeColor = Color.White
        '        Label21.ForeColor = Color.White
        '        lst_Times.BackColor = Color.FromArgb(255, 100, 100, 100)
        '        lst_Times.ForeColor = Color.White
        '
        '        ''''''ImportManager
        '        lbl_AdditionalOptionsTitle.ForeColor = Color.White
        '        opt_InternalNames.ForeColor = Color.White
        '        opt_EnglishNames.ForeColor = Color.White
        '
        '        chk_ShowAdvanced.ForeColor = Color.White
        '        chk_IgnoreCaveMusic.ForeColor = Color.White
        '        chk_IgnoreTheKey.ForeColor = Color.White
        '        chk_UseCMproperties.ForeColor = Color.White
        '
        '        txt_RootDirectory.BackColor = Color.FromArgb(255, 100, 100, 100)
        '        txt_RootDirectory.ForeColor = Color.White
        '    Case False
        'ToolStrip1.BackColor = Color.White
        ''chk_DarkMode.BackColor = Color.White
        ''Mode.ForeColor = Color.Black
        'btn_Load.ForeColor = Color.Black
        '        btn_SaveAs.ForeColor = Color.Black
        '        btn_SaveProject.ForeColor = Color.Black
        '        btn_ReturnToMainMenu.ForeColor = Color.Black
        'ToolStripButton4.ForeColor = Color.Black
        'ToolStripButton3.ForeColor = Color.Black
        'ToolStripButton2.ForeColor = Color.Black
        'btn_Bugs_feedback_extras.ForeColor = Color.Black
        '        btn_CaveNet.ForeColor = Color.Black
        '        opt_Main.ForeColor = Color.Black
        '        opt_ChallengeMode.ForeColor = Color.Black
        '
        '
        '        tbp_SublevelManager.BackColor = Color.White
        '        tbp_ChallengeModeProperties.BackColor = Color.White
        '        tbp_ImportManager.BackColor = Color.White
        '
        '        lst_Sublevels.BackColor = Color.White
        '        lst_Sublevels.ForeColor = Color.Black
        '
        '        lbl_SelectedSublevelTitle.ForeColor = Color.Black
        '        lbl_SublevelID.ForeColor = Color.Black
        '        lbl_EntityCount.ForeColor = Color.Black
        '        lbl_TotalEntityCount.ForeColor = Color.Black
        '        chk_SublevelNameInput.ForeColor = Color.Black
        '        chk_DeleteSublevelQ.ForeColor = Color.Black
        '
        '        ''''''ChallengeModeEditor
        '        chk_CMPadvanced.ForeColor = Color.Black
        '
        '        lbl_100pikiReminder.ForeColor = Color.Black
        '        If lbl_PikiCount.ForeColor = Color.White Then
        '            lbl_PikiCount.ForeColor = Color.Black
        '        End If
        '        Label8.ForeColor = Color.Black
        '        Label19.ForeColor = Color.Black
        '        Label15.ForeColor = Color.Black
        '        Label14.ForeColor = Color.Black
        '        Label22.ForeColor = Color.Black
        '        Label6.ForeColor = Color.Black
        '        Label7.ForeColor = Color.Black
        '        Label9.ForeColor = Color.Black
        '        Label10.ForeColor = Color.Black
        '        Label11.ForeColor = Color.Black
        '        Label12.ForeColor = Color.Black
        '        Label13.ForeColor = Color.Black
        '        Label20.ForeColor = Color.Black
        '        Label21.ForeColor = Color.Black
        '        lst_Times.BackColor = Color.White
        '        lst_Times.ForeColor = Color.Black
        '
        '        ''''''ImportManager
        '        lbl_AdditionalOptionsTitle.ForeColor = Color.Black
        '        opt_InternalNames.ForeColor = Color.Black
        '        opt_EnglishNames.ForeColor = Color.Black
        '
        '        chk_ShowAdvanced.ForeColor = Color.Black
        '        chk_IgnoreCaveMusic.ForeColor = Color.Black
        '        chk_IgnoreTheKey.ForeColor = Color.Black
        '        chk_UseCMproperties.ForeColor = Color.Black
        '
        '        txt_RootDirectory.BackColor = Color.WhiteSmoke
        '        txt_RootDirectory.ForeColor = Color.Black
        'End Select
    End Sub

    Private Sub btn_CaveNet_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btn_CaveNet_Click_1(sender As Object, e As EventArgs) Handles btn_CaveNet.Click
        btn_ReturnToMainMenu.PerformClick()
        Me.Hide()
        MainMenu.Hide()
    End Sub
    Dim updatingCMtime As Boolean = False
    Private Sub lst_Times_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_Times.SelectedIndexChanged
        If ImportingCM = False Then
            lst_Sublevels.SelectedIndex = lst_Times.SelectedIndex

            If lst_Times.SelectedIndex > -1 Then
                num_TimerTime.Enabled = True

                Dim timeslist As New List(Of Integer)
                For Each subleveltime In lst_Times.Items
                    Dim actualtime = subleveltime.ToString.Substring(subleveltime.ToString.IndexOf(": ") + 2)
                    actualtime = actualtime.Substring(0, actualtime.IndexOf(" seconds"))
                    timeslist.Add(Integer.Parse(actualtime))
                Next
                num_TimerTime.Value = timeslist(lst_Times.SelectedIndex)
            Else
                num_TimerTime.Enabled = False
            End If
        End If
    End Sub
    Dim ImportingCM As Boolean = False
    Private Sub num_TimerTime_ValueChanged(sender As Object, e As EventArgs) Handles num_TimerTime.ValueChanged
        If ImportingCM = False Then
            If lst_Times.SelectedIndex > -1 Then
                Dim timeslist As New List(Of Integer)
                For Each subleveltime In lst_Times.Items
                    Dim actualtime = subleveltime.ToString.Substring(subleveltime.ToString.IndexOf(": ") + 2)
                    actualtime = actualtime.Substring(0, actualtime.IndexOf(" seconds"))
                    timeslist.Add(Integer.Parse(actualtime))
                Next

                timeslist(lst_Times.SelectedIndex) = num_TimerTime.Value

                lst_Times.Items.Clear()

                For i = 0 To timeslist.Count - 1
                    lst_Times.Items.Add("Sublevel " & (i + 1).ToString & ": " & timeslist(i).ToString & " seconds")
                Next

                lst_Times.SelectedIndex = lst_Sublevels.SelectedIndex

                updatingCMtime = True
                IMPORTCHallengeMode()
            Else
                num_TimerTime.Value = 0
            End If
        End If

    End Sub

    Private Sub btn_TimeHelp_Click(sender As Object, e As EventArgs) Handles btn_TimeHelp.Click
        MessageBox.Show("Help with Challenge Mode times:

INFINITE TIME: Give every sublevel EXACTLY 0 seconds.

The player's time will start with Sublevel 1's time, and then the time that's set for every sublevel after that is ADDED to the timer. Each sublevel does not have it's own individual time.

If you want to just have one simple timer for the whole cave, then only set the first sublevel's time to that, and leave the rest of the sublevel's at 0 seconds (no time is added)

Additionally, you can set the time to a negative number! This will literally take time off when entering a sublevel. If you finish the first sublevel with 50 seconds remaining, and the second sublevel is set to -20 seconds, then entering that second sublevel will drop you down to only 30 seconds remaining.",
"Cave Creator - Time Help")
    End Sub

    Private Sub btn_DuplicateSub_Click(sender As Object, e As EventArgs) Handles btn_DuplicateSub.Click
        SublevelName = " - " & " Duplicate of Sublevel " & lst_Sublevels.SelectedIndex + 1
        'If lst_Sublevels.SelectedIndex > -1 Then
        '    DeselectLists()
        'End If
        SublevelTotal += 1
        SublevelTotalID += 1
        lst_Sublevels.Items.Add("Sublevel " & SublevelTotal & SublevelName)
        lst_Sublevel_IDs.Items.Add("S" & SublevelTotalID)
        lst_SublevelNames.Items.Add(SublevelName)
        If SublevelTotal = 1 Then
            lbl_SublevelTotal.Text = SublevelTotal & " Sublevel"
        Else
            lbl_SublevelTotal.Text = SublevelTotal & " Sublevels"
        End If
        lst_Sublevel_IDs.SelectedIndex = lst_Sublevel_IDs.Items.Count - 1



        lst_TreasureSets.Items.Add(lst_Sublevel_IDs.SelectedItem & " - " & lst_TreasureSets.SelectedItem.ToString.Substring(lst_TreasureSets.SelectedItem.ToString.IndexOf(" - ") + 3))
        lst_TreasureSets.SelectedIndex = lst_Sublevels.Items.Count - 1

        lst_GateSets.Items.Add(lst_Sublevel_IDs.SelectedItem & " - " & lst_GateSets.SelectedItem.ToString.Substring(lst_GateSets.SelectedItem.ToString.IndexOf(" - ") + 3))
        lst_GateSets.SelectedIndex = lst_Sublevels.Items.Count - 1

        lst_RegularEntities.Items.Add(lst_Sublevel_IDs.SelectedItem & " - " & lst_RegularEntities.SelectedItem.ToString.Substring(lst_RegularEntities.SelectedItem.ToString.IndexOf(" - ") + 3))

        lst_RegularEntitiesCounts.Items.Add(lst_Sublevel_IDs.SelectedItem & " - " & lst_RegularEntitiesCounts.SelectedItem.ToString.Substring(lst_RegularEntitiesCounts.SelectedItem.ToString.IndexOf(" - ") + 3))

        lst_f5_RoomCount.Items.Add(lst_f5_RoomCount.SelectedItem)
        lst_f6_Ratio.Items.Add(lst_f6_Ratio.SelectedItem)
        lst_f7_Geyser.Items.Add(lst_f7_Geyser.SelectedItem)
        lst_f8_UnitFile.Items.Add(lst_f8_UnitFile.SelectedItem)
        lst_f9_LightFile.Items.Add(lst_f9_LightFile.SelectedItem)
        lst_fa_Skybox.Items.Add(lst_fa_Skybox.SelectedItem)
        lst_f10_CloggedHole.Items.Add(lst_f10_CloggedHole.SelectedItem)
        lst_f12_MusicType.Items.Add(lst_f12_MusicType.SelectedItem)
        lst_f13_SolidPlane.Items.Add(lst_f13_SolidPlane.SelectedItem)
        lst_f14_DeadEndCount.Items.Add(lst_f14_DeadEndCount.SelectedItem)
        lst_f16_WaterwraithTimer.Items.Add(lst_f16_WaterwraithTimer.SelectedItem)
        lst_f17_Seesaw.Items.Add(lst_f17_Seesaw.SelectedItem)
        lst_totaka_MusicList.Items.Add(lst_totaka_MusicList.SelectedItem)
        lst_f2_CustomEntityTotal.Items.Add(lst_f2_CustomEntityTotal.SelectedItem)
        lst_CustomEntityTotal_Check.Items.Add(lst_CustomEntityTotal_Check.SelectedItem)

        lst_Times.Items.Add(lst_Times.SelectedItem)



        lst_f5_RoomCount.SelectedIndex = lst_Sublevels.Items.Count - 1
        lst_f6_Ratio.SelectedIndex = lst_Sublevels.Items.Count - 1
        lst_f7_Geyser.SelectedIndex = lst_Sublevels.Items.Count - 1
        lst_f8_UnitFile.SelectedIndex = lst_Sublevels.Items.Count - 1
        lst_f9_LightFile.SelectedIndex = lst_Sublevels.Items.Count - 1
        lst_fa_Skybox.SelectedIndex = lst_Sublevels.Items.Count - 1
        lst_f10_CloggedHole.SelectedIndex = lst_Sublevels.Items.Count - 1
        lst_f12_MusicType.SelectedIndex = lst_Sublevels.Items.Count - 1
        lst_f13_SolidPlane.SelectedIndex = lst_Sublevels.Items.Count - 1
        lst_f14_DeadEndCount.SelectedIndex = lst_Sublevels.Items.Count - 1
        lst_f16_WaterwraithTimer.SelectedIndex = lst_Sublevels.Items.Count - 1
        lst_f17_Seesaw.SelectedIndex = lst_Sublevels.Items.Count - 1
        lst_totaka_MusicList.SelectedIndex = lst_Sublevels.Items.Count - 1
        lst_f2_CustomEntityTotal.SelectedIndex = lst_Sublevels.Items.Count - 1
        lst_CustomEntityTotal_Check.SelectedIndex = lst_Sublevels.Items.Count - 1



        lst_Sublevel_IDs.SelectedIndex = -1
        lst_Sublevels.SelectedIndex = lst_Sublevels.Items.Count - 1

        If lst_Sublevels.Items.Count = 0 Then
            btn_Save.Enabled = False
        Else
            btn_SaveAs.Enabled = True
            If CaveNeedsToSaveAs = False Then btn_Save.Enabled = True
        End If
        ImportingCM = False
    End Sub
    Private Sub btn_MoveSublevelUp_EnabledChanged(sender As Object, e As EventArgs) Handles btn_MoveSublevelUp.EnabledChanged
        If sender.enabled Then
            sender.backgroundimage = My.Resources.Up_20px
        Else
            sender.backgroundimage = My.Resources.Up_20px_dark
        End If
    End Sub
    Private Sub btn_MoveSublevelDown_EnabledChanged(sender As Object, e As EventArgs) Handles btn_MoveSublevelDown.EnabledChanged
        If sender.enabled Then
            sender.backgroundimage = My.Resources.Down_Arrow_20px
        Else
            sender.backgroundimage = My.Resources.Down_Arrow_20px_dark
        End If
    End Sub
    Private Sub btn_MoveEntityUp_EnabledChanged(sender As Object, e As EventArgs) Handles btn_MoveEntityUp.EnabledChanged
        If sender.enabled Then
            sender.backgroundimage = My.Resources.Up_20px
        Else
            sender.backgroundimage = My.Resources.Up_20px_dark
        End If
    End Sub
    Private Sub btn_MoveEntityDown_EnabledChanged(sender As Object, e As EventArgs) Handles btn_MoveEntityDown.EnabledChanged
        If sender.enabled Then
            sender.backgroundimage = My.Resources.Down_Arrow_20px
        Else
            sender.backgroundimage = My.Resources.Down_Arrow_20px_dark
        End If
    End Sub

    Private Sub btn_RemoveSublevel2_EnabledChanged(sender As Object, e As EventArgs) Handles btn_RemoveSublevel2.EnabledChanged
        If sender.enabled Then
            sender.backgroundimage = My.Resources.Subtract_20px
        Else
            sender.backgroundimage = My.Resources.Subtract_20px_dark
        End If
    End Sub

    Private Sub Form1_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        lbl_100pikiReminder.Width = (TabControl1.Width - 638) - (Panel2.Left - 14)
    End Sub

    Private Sub btn_getBase64_Click(sender As Object, e As EventArgs) Handles btn_getBase64.Click
        If lst_Sublevels.Items.Count = 0 Then
            MsgBox("There are no sublevels.")
        ElseIf lst_Sublevels.Items.Count > 100 Then
            MsgBox("Maximum sublevel size for Cave Net is 100")
        Else

            Cursor = Cursors.WaitCursor
            copyOnly = True
            SaveData()
            Cursor = Cursors.Default
        End If
    End Sub
End Class