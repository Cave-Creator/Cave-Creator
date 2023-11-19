Public Class EntityList
    Dim tmr As New Timer With {
        .Interval = 300
    }
    Private Sub txt_SearchEntities_TextChanged(sender As Object, e As EventArgs) Handles txt_SearchEntities.TextChanged
        tmr.Dispose()
        tmr = New Timer With {.Interval = 300}
        tmr.Enabled = True
        AddHandler tmr.Tick, Sub()
                                 tmr.Dispose()
                                 Search()
                             End Sub
    End Sub
    Sub Search()
        Dim SearchText As String = txt_SearchEntities.Text
        If SearchText > "" Then
            SearchText = StrConv(SearchText, VbStrConv.ProperCase)
            txt_SearchEntities.Text = SearchText
            txt_SearchEntities.SelectionStart = txt_SearchEntities.Text.Length + 1
            btn_AnodeBeetle.Visible = False
            btn_AnodeDweevil.Visible = False
            btn_AntennaBeetle.Visible = False
            btn_ArmoredCannonBeetleLarva.Visible = False
            btn_BeadyLongLegs.Visible = False
            btn_Breadbug.Visible = False
            btn_Bulbmin.Visible = False
            btn_BulborbLarva.Visible = False
            btn_BumblingSnitchbug.Visible = False
            btn_BurrowingSnagret.Visible = False
            btn_CareeningDirigibug.Visible = False
            btn_CausticDweevil.Visible = False
            btn_CloakingBurrownit.Visible = False
            btn_CreepingChrysanthemum.Visible = False
            btn_DecoratedCannonBeetle.Visible = False
            btn_Doodlebug.Visible = False
            btn_DwarfBulbear.Visible = False
            btn_DwarfOrangeBulborb.Visible = False
            btn_DwarfRedBulborb.Visible = False
            btn_EmperorBulblax.Visible = False
            btn_EmpressBulblax.Visible = False
            btn_FemaleSheargrub.Visible = False
            btn_FieryBlowhog.Visible = False
            btn_FieryBulblax.Visible = False
            btn_FieryDweevil.Visible = False
            btn_GatlingGroink.Visible = False
            btn_GiantBreadbug.Visible = False
            btn_GreaterSpottedJellyfloat.Visible = False
            btn_HairyBulborb.Visible = False
            btn_HermitCrawmad.Visible = False
            btn_Honeywisp.Visible = False
            btn_IridescentFlintBeetle.Visible = False
            btn_IridescentGlintBeetle.Visible = False
            btn_LesserSpottedJellyfloat.Visible = False
            btn_MaleSheargrub.Visible = False
            btn_Mamuta.Visible = False
            btn_ManatLegs.Visible = False
            btn_Mitite.Visible = False
            btn_MungeDweevil.Visible = False
            btn_OrangeBulborb.Visible = False
            btn_PileatedSnagret.Visible = False
            btn_PuffyBlowhog.Visible = False
            btn_RagingLongLegs.Visible = False
            btn_RangingBloyster.Visible = False
            btn_RedBulborb.Visible = False
            btn_SegmentedCrawbster.Visible = False
            btn_Shearwig.Visible = False
            btn_SkitterLeaf.Visible = False
            btn_SnowBulborb.Visible = False
            btn_SpottyBulbear.Visible = False
            btn_SwoopingSnitchbug.Visible = False
            btn_TitanDweevil.Visible = False
            btn_ToadyBloyster.Visible = False
            btn_UnmarkedSpectralids.Visible = False
            btn_VolatileDweevil.Visible = False
            btn_WaterDumple.Visible = False
            btn_Waterwraith.Visible = False
            btn_WateryBlowhog.Visible = False
            btn_WitheringBlowhog.Visible = False
            btn_Wogpole.Visible = False
            btn_Wollywog.Visible = False
            btn_YellowWollywog.Visible = False
            btn_Bombrock.Visible = False
            btn_Boulder.Visible = False
            btn_BreadbugNest.Visible = False
            btn_Egg.Visible = False
            btn_ElectricalWire.Visible = False
            btn_FireGeyser.Visible = False
            btn_GasPipe.Visible = False
            btn_WaterwraithRollers.Visible = False
            btn_CrimsonCandypopBud.Visible = False
            btn_GoldenCandypopBud.Visible = False
            btn_LapisLazuliCandypopBud.Visible = False
            btn_IvoryCandypopBud.Visible = False
            btn_VioletCandypopBud.Visible = False
            btn_QueenCandypopBud.Visible = False
            btn_ChiyogamiPaper.Visible = False
            btn_Clover.Visible = False
            btn_CommonGlowcap.Visible = False
            btn_Dandelion.Visible = False
            btn_Fiddlehead.Visible = False
            btn_Foxtail.Visible = False
            btn_Horsetail.Visible = False
            btn_Margaret.Visible = False
            btn_SeedingDandelion.Visible = False
            btn_RedGlowstem.Visible = False
            btn_GreenGlowstem.Visible = False
            btn_SmallFigwort.Visible = False
            btn_LargeFigwort.Visible = False
            btn_SmallDyingFigwort.Visible = False
            btn_LargeDyingFigwort.Visible = False
            btn_SmallShoot.Visible = False
            btn_LargeShoot.Visible = False
            If btn_AnodeBeetle.Text.Contains(SearchText) Then btn_AnodeBeetle.Visible = True
            If btn_AnodeDweevil.Text.Contains(SearchText) Then btn_AnodeDweevil.Visible = True
            If btn_ArmoredCannonBeetleLarva.Text.Contains(SearchText) Then btn_ArmoredCannonBeetleLarva.Visible = True
            If btn_BeadyLongLegs.Text.Contains(SearchText) Then btn_BeadyLongLegs.Visible = True
            If btn_Breadbug.Text.Contains(SearchText) Then btn_Breadbug.Visible = True
            If btn_Bulbmin.Text.Contains(SearchText) Then btn_Bulbmin.Visible = True
            If btn_BulborbLarva.Text.Contains(SearchText) Then btn_BulborbLarva.Visible = True
            If btn_BumblingSnitchbug.Text.Contains(SearchText) Then btn_BumblingSnitchbug.Visible = True
            If btn_BurrowingSnagret.Text.Contains(SearchText) Then btn_BurrowingSnagret.Visible = True
            If btn_CareeningDirigibug.Text.Contains(SearchText) Then btn_CareeningDirigibug.Visible = True
            If btn_CausticDweevil.Text.Contains(SearchText) Then btn_CausticDweevil.Visible = True
            If btn_CloakingBurrownit.Text.Contains(SearchText) Then btn_CloakingBurrownit.Visible = True
            If btn_CreepingChrysanthemum.Text.Contains(SearchText) Then btn_CreepingChrysanthemum.Visible = True
            If btn_DecoratedCannonBeetle.Text.Contains(SearchText) Then btn_DecoratedCannonBeetle.Visible = True
            If btn_Doodlebug.Text.Contains(SearchText) Then btn_Doodlebug.Visible = True
            If btn_DwarfBulbear.Text.Contains(SearchText) Then btn_DwarfBulbear.Visible = True
            If btn_DwarfOrangeBulborb.Text.Contains(SearchText) Then btn_DwarfOrangeBulborb.Visible = True
            If btn_DwarfRedBulborb.Text.Contains(SearchText) Then btn_DwarfRedBulborb.Visible = True
            If btn_EmperorBulblax.Text.Contains(SearchText) Then btn_EmperorBulblax.Visible = True
            If btn_EmpressBulblax.Text.Contains(SearchText) Then btn_EmpressBulblax.Visible = True
            If btn_FemaleSheargrub.Text.Contains(SearchText) Then btn_FemaleSheargrub.Visible = True
            If btn_FieryBlowhog.Text.Contains(SearchText) Then btn_FieryBlowhog.Visible = True
            If btn_FieryBulblax.Text.Contains(SearchText) Then btn_FieryBulblax.Visible = True
            If btn_FieryDweevil.Text.Contains(SearchText) Then btn_FieryDweevil.Visible = True
            If btn_GatlingGroink.Text.Contains(SearchText) Then btn_GatlingGroink.Visible = True
            If btn_GiantBreadbug.Text.Contains(SearchText) Then btn_GiantBreadbug.Visible = True
            If btn_GreaterSpottedJellyfloat.Text.Contains(SearchText) Then btn_GreaterSpottedJellyfloat.Visible = True
            If btn_HairyBulborb.Text.Contains(SearchText) Then btn_HairyBulborb.Visible = True
            If btn_HermitCrawmad.Text.Contains(SearchText) Then btn_HermitCrawmad.Visible = True
            If btn_Honeywisp.Text.Contains(SearchText) Then btn_Honeywisp.Visible = True
            If btn_IridescentFlintBeetle.Text.Contains(SearchText) Then btn_IridescentFlintBeetle.Visible = True
            If btn_IridescentGlintBeetle.Text.Contains(SearchText) Then btn_IridescentGlintBeetle.Visible = True
            If btn_LesserSpottedJellyfloat.Text.Contains(SearchText) Then btn_LesserSpottedJellyfloat.Visible = True
            If btn_MaleSheargrub.Text.Contains(SearchText) Then btn_MaleSheargrub.Visible = True
            If btn_Mamuta.Text.Contains(SearchText) Then btn_Mamuta.Visible = True
            If btn_ManatLegs.Text.Contains(SearchText) Then btn_ManatLegs.Visible = True
            If btn_Mitite.Text.Contains(SearchText) Then btn_Mitite.Visible = True
            If btn_MungeDweevil.Text.Contains(SearchText) Then btn_MungeDweevil.Visible = True
            If btn_OrangeBulborb.Text.Contains(SearchText) Then btn_OrangeBulborb.Visible = True
            If btn_PileatedSnagret.Text.Contains(SearchText) Then btn_PileatedSnagret.Visible = True
            If btn_PuffyBlowhog.Text.Contains(SearchText) Then btn_PuffyBlowhog.Visible = True
            If btn_RagingLongLegs.Text.Contains(SearchText) Then btn_RagingLongLegs.Visible = True
            If btn_RangingBloyster.Text.Contains(SearchText) Then btn_RangingBloyster.Visible = True
            If btn_RedBulborb.Text.Contains(SearchText) Then btn_RedBulborb.Visible = True
            If btn_SegmentedCrawbster.Text.Contains(SearchText) Then btn_SegmentedCrawbster.Visible = True
            If btn_Shearwig.Text.Contains(SearchText) Then btn_Shearwig.Visible = True
            If btn_SkitterLeaf.Text.Contains(SearchText) Then btn_SkitterLeaf.Visible = True
            If btn_SnowBulborb.Text.Contains(SearchText) Then btn_SnowBulborb.Visible = True
            If btn_SpottyBulbear.Text.Contains(SearchText) Then btn_SpottyBulbear.Visible = True
            If btn_SwoopingSnitchbug.Text.Contains(SearchText) Then btn_SwoopingSnitchbug.Visible = True
            If btn_TitanDweevil.Text.Contains(SearchText) Then btn_TitanDweevil.Visible = True
            If btn_ToadyBloyster.Text.Contains(SearchText) Then btn_ToadyBloyster.Visible = True
            If btn_UnmarkedSpectralids.Text.Contains(SearchText) Then btn_UnmarkedSpectralids.Visible = True
            If btn_VolatileDweevil.Text.Contains(SearchText) Then btn_VolatileDweevil.Visible = True
            If btn_WaterDumple.Text.Contains(SearchText) Then btn_WaterDumple.Visible = True
            If btn_Waterwraith.Text.Contains(SearchText) Then btn_Waterwraith.Visible = True
            If btn_WateryBlowhog.Text.Contains(SearchText) Then btn_WateryBlowhog.Visible = True
            If btn_WitheringBlowhog.Text.Contains(SearchText) Then btn_WitheringBlowhog.Visible = True
            If btn_Wogpole.Text.Contains(SearchText) Then btn_Wogpole.Visible = True
            If btn_Wollywog.Text.Contains(SearchText) Then btn_Wollywog.Visible = True
            If btn_YellowWollywog.Text.Contains(SearchText) Then btn_YellowWollywog.Visible = True

            If btn_Bombrock.Text.Contains(SearchText) Then btn_Bombrock.Visible = True
            If btn_Boulder.Text.Contains(SearchText) Then btn_Boulder.Visible = True
            If btn_BreadbugNest.Text.Contains(SearchText) Then btn_BreadbugNest.Visible = True
            If btn_Egg.Text.Contains(SearchText) Then btn_Egg.Visible = True
            If btn_ElectricalWire.Text.Contains(SearchText) Then btn_ElectricalWire.Visible = True
            If btn_FireGeyser.Text.Contains(SearchText) Then btn_FireGeyser.Visible = True
            If btn_GasPipe.Text.Contains(SearchText) Then btn_GasPipe.Visible = True
            If btn_WaterwraithRollers.Text.Contains(SearchText) Then btn_WaterwraithRollers.Visible = True
            If btn_CrimsonCandypopBud.Text.Contains(SearchText) Then btn_CrimsonCandypopBud.Visible = True
            If btn_GoldenCandypopBud.Text.Contains(SearchText) Then btn_GoldenCandypopBud.Visible = True
            If btn_LapisLazuliCandypopBud.Text.Contains(SearchText) Then btn_LapisLazuliCandypopBud.Visible = True
            If btn_IvoryCandypopBud.Text.Contains(SearchText) Then btn_IvoryCandypopBud.Visible = True
            If btn_VioletCandypopBud.Text.Contains(SearchText) Then btn_VioletCandypopBud.Visible = True
            If btn_QueenCandypopBud.Text.Contains(SearchText) Then btn_QueenCandypopBud.Visible = True
            If btn_ChiyogamiPaper.Text.Contains(SearchText) Then btn_ChiyogamiPaper.Visible = True
            If btn_Clover.Text.Contains(SearchText) Then btn_Clover.Visible = True
            If btn_CommonGlowcap.Text.Contains(SearchText) Then btn_CommonGlowcap.Visible = True
            If btn_Dandelion.Text.Contains(SearchText) Then btn_Dandelion.Visible = True
            If btn_Fiddlehead.Text.Contains(SearchText) Then btn_Fiddlehead.Visible = True
            If btn_Foxtail.Text.Contains(SearchText) Then btn_Foxtail.Visible = True
            If btn_Horsetail.Text.Contains(SearchText) Then btn_Horsetail.Visible = True
            If btn_Margaret.Text.Contains(SearchText) Then btn_Margaret.Visible = True
            If btn_SeedingDandelion.Text.Contains(SearchText) Then btn_SeedingDandelion.Visible = True
            If btn_RedGlowstem.Text.Contains(SearchText) Then btn_RedGlowstem.Visible = True
            If btn_GreenGlowstem.Text.Contains(SearchText) Then btn_GreenGlowstem.Visible = True
            If btn_SmallFigwort.Text.Contains(SearchText) Then btn_SmallFigwort.Visible = True
            If btn_LargeFigwort.Text.Contains(SearchText) Then btn_LargeFigwort.Visible = True
            If btn_SmallDyingFigwort.Text.Contains(SearchText) Then btn_SmallDyingFigwort.Visible = True
            If btn_LargeDyingFigwort.Text.Contains(SearchText) Then btn_LargeDyingFigwort.Visible = True
            If btn_SmallShoot.Text.Contains(SearchText) Then btn_SmallShoot.Visible = True
            If btn_LargeShoot.Text.Contains(SearchText) Then btn_LargeShoot.Visible = True
        Else
            btn_AnodeBeetle.Visible = True
            btn_AnodeDweevil.Visible = True
            btn_AntennaBeetle.Visible = True
            btn_ArmoredCannonBeetleLarva.Visible = True
            btn_BeadyLongLegs.Visible = True
            btn_Breadbug.Visible = True
            btn_Bulbmin.Visible = True
            btn_BulborbLarva.Visible = True
            btn_BumblingSnitchbug.Visible = True
            btn_BurrowingSnagret.Visible = True
            btn_CareeningDirigibug.Visible = True
            btn_CausticDweevil.Visible = True
            btn_CloakingBurrownit.Visible = True
            btn_CreepingChrysanthemum.Visible = True
            btn_DecoratedCannonBeetle.Visible = True
            btn_Doodlebug.Visible = True
            btn_DwarfBulbear.Visible = True
            btn_DwarfOrangeBulborb.Visible = True
            btn_DwarfRedBulborb.Visible = True
            btn_EmperorBulblax.Visible = True
            btn_EmpressBulblax.Visible = True
            btn_FemaleSheargrub.Visible = True
            btn_FieryBlowhog.Visible = True
            btn_FieryBulblax.Visible = True
            btn_FieryDweevil.Visible = True
            btn_GatlingGroink.Visible = True
            btn_GiantBreadbug.Visible = True
            btn_GreaterSpottedJellyfloat.Visible = True
            btn_HairyBulborb.Visible = True
            btn_HermitCrawmad.Visible = True
            btn_Honeywisp.Visible = True
            btn_IridescentFlintBeetle.Visible = True
            btn_IridescentGlintBeetle.Visible = True
            btn_LesserSpottedJellyfloat.Visible = True
            btn_MaleSheargrub.Visible = True
            btn_Mamuta.Visible = True
            btn_ManatLegs.Visible = True
            btn_Mitite.Visible = True
            btn_MungeDweevil.Visible = True
            btn_OrangeBulborb.Visible = True
            btn_PileatedSnagret.Visible = True
            btn_PuffyBlowhog.Visible = True
            btn_RagingLongLegs.Visible = True
            btn_RangingBloyster.Visible = True
            btn_RedBulborb.Visible = True
            btn_SegmentedCrawbster.Visible = True
            btn_Shearwig.Visible = True
            btn_SkitterLeaf.Visible = True
            btn_SnowBulborb.Visible = True
            btn_SpottyBulbear.Visible = True
            btn_SwoopingSnitchbug.Visible = True
            btn_TitanDweevil.Visible = True
            btn_ToadyBloyster.Visible = True
            btn_UnmarkedSpectralids.Visible = True
            btn_VolatileDweevil.Visible = True
            btn_WaterDumple.Visible = True
            btn_Waterwraith.Visible = True
            btn_WateryBlowhog.Visible = True
            btn_WitheringBlowhog.Visible = True
            btn_Wogpole.Visible = True
            btn_Wollywog.Visible = True
            btn_YellowWollywog.Visible = True
            btn_Bombrock.Visible = True
            btn_Boulder.Visible = True
            btn_BreadbugNest.Visible = True
            btn_Egg.Visible = True
            btn_ElectricalWire.Visible = True
            btn_FireGeyser.Visible = True
            btn_GasPipe.Visible = True
            btn_WaterwraithRollers.Visible = True
            btn_CrimsonCandypopBud.Visible = True
            btn_GoldenCandypopBud.Visible = True
            btn_LapisLazuliCandypopBud.Visible = True
            btn_IvoryCandypopBud.Visible = True
            btn_VioletCandypopBud.Visible = True
            btn_QueenCandypopBud.Visible = True
            btn_ChiyogamiPaper.Visible = True
            btn_Clover.Visible = True
            btn_CommonGlowcap.Visible = True
            btn_Dandelion.Visible = True
            btn_Fiddlehead.Visible = True
            btn_Foxtail.Visible = True
            btn_Horsetail.Visible = True
            btn_Margaret.Visible = True
            btn_SeedingDandelion.Visible = True
            btn_RedGlowstem.Visible = True
            btn_GreenGlowstem.Visible = True
            btn_SmallFigwort.Visible = True
            btn_LargeFigwort.Visible = True
            btn_SmallDyingFigwort.Visible = True
            btn_LargeDyingFigwort.Visible = True
            btn_SmallShoot.Visible = True
            btn_LargeShoot.Visible = True
        End If
    End Sub
    Private Sub btn_RegularEnemiesDropDown_Click(sender As Object, e As EventArgs) Handles btn_RegularEnemiesDropDown.Click
        If btn_RegularEnemiesDropDown.Text = "/\" Then
            pnl_RegularEnemies.Visible = False
            btn_RegularEnemiesDropDown.Text = "\/"
            txt_SearchEntities.Select()
        ElseIf btn_RegularEnemiesDropDown.Text = "\/" Then
            pnl_RegularEnemies.Visible = True
            btn_RegularEnemiesDropDown.Text = "/\"
            txt_SearchEntities.Select()
        End If
    End Sub
    Private Sub btn_BossesDropDown_Click(sender As Object, e As EventArgs) Handles btn_BossesDropDown.Click
        If btn_BossesDropDown.Text = "/\" Then
            pnl_Bosses.Visible = False
            btn_BossesDropDown.Text = "\/"
            txt_SearchEntities.Select()
        ElseIf btn_BossesDropDown.Text = "\/" Then
            pnl_Bosses.Visible = True
            btn_BossesDropDown.Text = "/\"
            txt_SearchEntities.Select()
        End If
    End Sub
    Private Sub btn_RedBulborb_Click(sender As Object, e As EventArgs) Handles btn_RedBulborb.Click
        Form1.EntityNormalName = "Red Bulborb"
        Form1.EntityCodeName = "Chappy"
        Form1.lbl_EntityName.Text = Form1.EntityNormalName
        txt_SearchEntities.Text = ""
        Me.Hide()
        Form1.pic_SelectedEntity.Image = P2CC2.My.Resources.Red_Bulborb_icon
        Form1.Enabled = True
        Form1.Select()
    End Sub
    Private Sub btn_DwarfRedBulborb_Click(sender As Object, e As EventArgs) Handles btn_DwarfRedBulborb.Click
        Form1.EntityNormalName = "Dwarf Red Bulborb"
        Form1.EntityCodeName = "Kochappy"
        Form1.lbl_EntityName.Text = Form1.EntityNormalName
        txt_SearchEntities.Text = ""
        Me.Hide()
        Form1.pic_SelectedEntity.Image = P2CC2.My.Resources.Dwarf_Red_Bulborb_icon
        Form1.Enabled = True
        Form1.Select()
    End Sub
    Private Sub btn_AnodeBeetle_Click(sender As Object, e As EventArgs) Handles btn_AnodeBeetle.Click
        Form1.EntityNormalName = "Anode Beetle"
        Form1.EntityCodeName = "ElecBug"
        Form1.lbl_EntityName.Text = Form1.EntityNormalName
        txt_SearchEntities.Text = ""
        Me.Hide()
        Form1.pic_SelectedEntity.Image = P2CC2.My.Resources.Anode_Beetle_icon
        Form1.Enabled = True
        Form1.Select()
    End Sub

    Private Sub btn_AnodeDweevil_Click(sender As Object, e As EventArgs) Handles btn_AnodeDweevil.Click
        Form1.EntityNormalName = "Anode Dweevil"
        Form1.EntityCodeName = "ElecOtakara"
        Form1.lbl_EntityName.Text = Form1.EntityNormalName
        txt_SearchEntities.Text = ""
        Me.Hide()
        Form1.pic_SelectedEntity.Image = P2CC2.My.Resources.Anode_Dweevil_icon
        Form1.Enabled = True
        Form1.Select()
    End Sub

    Private Sub btn_AntennaBeetle_Click(sender As Object, e As EventArgs) Handles btn_AntennaBeetle.Click
        Form1.EntityNormalName = "Antenna Beetle"
        Form1.EntityCodeName = "Fuefuki"
        Form1.lbl_EntityName.Text = Form1.EntityNormalName
        txt_SearchEntities.Text = ""
        Me.Hide()
        Form1.pic_SelectedEntity.Image = P2CC2.My.Resources.Antenna_Beetle_icon
        Form1.Enabled = True
        Form1.Select()
    End Sub

    Private Sub btn_ArmoredCannonBeetleLarva_Click(sender As Object, e As EventArgs) Handles btn_ArmoredCannonBeetleLarva.Click
        Dim result As Integer = MessageBox.Show("Do you want it to be buried in the ground?", "Armored Cannon Beetle Larva", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button2)
        If result = DialogResult.Yes Then
            Form1.EntityNormalName = "Buried Armored Cannon Beetle Larva"
            Form1.EntityCodeName = "Fkabuto"
            Form1.lbl_EntityName.Text = Form1.EntityNormalName
            txt_SearchEntities.Text = ""
            Me.Hide()
            Form1.pic_SelectedEntity.Image = P2CC2.My.Resources.Armored_Cannon_Beetle_Larva_icon
            Form1.Enabled = True
            Form1.Select()
        End If
        If result = DialogResult.No Then
            Form1.EntityNormalName = "Armored Cannon Beetle Larva"
            Form1.EntityCodeName = "Kabuto"
            Form1.lbl_EntityName.Text = Form1.EntityNormalName
            txt_SearchEntities.Text = ""
            Me.Hide()
            Form1.pic_SelectedEntity.Image = P2CC2.My.Resources.Armored_Cannon_Beetle_Larva_icon
            Form1.Enabled = True
            Form1.Select()
        End If
    End Sub

    Private Sub btn_Breadbug_Click(sender As Object, e As EventArgs) Handles btn_Breadbug.Click
        Form1.EntityNormalName = "Breadbug"
        Form1.EntityCodeName = "PanModoki"
        Form1.lbl_EntityName.Text = Form1.EntityNormalName
        txt_SearchEntities.Text = ""
        Me.Hide()
        Form1.pic_SelectedEntity.Image = P2CC2.My.Resources.Breadbug_icon
        Form1.Enabled = True
        Form1.Select()
    End Sub

    Private Sub btn_Bulbmin_Click(sender As Object, e As EventArgs) Handles btn_Bulbmin.Click
        Form1.EntityNormalName = "Bulbmin"
        Form1.EntityCodeName = "LeafChappy"
        Form1.lbl_EntityName.Text = Form1.EntityNormalName
        txt_SearchEntities.Text = ""
        Me.Hide()
        Form1.pic_SelectedEntity.Image = P2CC2.My.Resources.Bulbmin_icon
        Form1.Enabled = True
        Form1.Select()
    End Sub

    Private Sub btn_BulborbLarva_Click(sender As Object, e As EventArgs) Handles btn_BulborbLarva.Click
        Form1.EntityNormalName = "Bulborb Larva"
        Form1.EntityCodeName = "Baby"
        Form1.lbl_EntityName.Text = Form1.EntityNormalName
        txt_SearchEntities.Text = ""
        Me.Hide()
        Form1.pic_SelectedEntity.Image = P2CC2.My.Resources.Bulborb_Larva_icon
        Form1.Enabled = True
        Form1.Select()
    End Sub

    Private Sub btn_BumblingSnitchbug_Click(sender As Object, e As EventArgs) Handles btn_BumblingSnitchbug.Click
        Form1.EntityNormalName = "Bumbling Snitchbug"
        Form1.EntityCodeName = "Demon"
        Form1.lbl_EntityName.Text = Form1.EntityNormalName
        txt_SearchEntities.Text = ""
        Me.Hide()
        Form1.pic_SelectedEntity.Image = P2CC2.My.Resources.Bumbling_Snitchbug_icon
        Form1.Enabled = True
        Form1.Select()
    End Sub

    Private Sub btn_CareeningDirigibug_Click(sender As Object, e As EventArgs) Handles btn_CareeningDirigibug.Click
        Form1.EntityNormalName = "Careening Dirigibug"
        Form1.EntityCodeName = "BombSarai"
        Form1.lbl_EntityName.Text = Form1.EntityNormalName
        txt_SearchEntities.Text = ""
        Me.Hide()
        Form1.pic_SelectedEntity.Image = P2CC2.My.Resources.Careening_Dirigibug_icon
        Form1.Enabled = True
        Form1.Select()
    End Sub

    Private Sub btn_CausticDweevil_Click(sender As Object, e As EventArgs) Handles btn_CausticDweevil.Click
        Form1.EntityNormalName = "Caustic Dweevil"
        Form1.EntityCodeName = "WaterOtakara"
        Form1.lbl_EntityName.Text = Form1.EntityNormalName
        txt_SearchEntities.Text = ""
        Me.Hide()
        Form1.pic_SelectedEntity.Image = P2CC2.My.Resources.Caustic_Dweevil_icon
        Form1.Enabled = True
        Form1.Select()
    End Sub

    Private Sub btn_CloakingBurrownit_Click(sender As Object, e As EventArgs) Handles btn_CloakingBurrownit.Click
        Form1.EntityNormalName = "Cloaking Burrow-nit"
        Form1.EntityCodeName = "Armor"
        Form1.lbl_EntityName.Text = Form1.EntityNormalName
        txt_SearchEntities.Text = ""
        Me.Hide()
        Form1.pic_SelectedEntity.Image = P2CC2.My.Resources.Cloaking_Burrow_nit_icon
        Form1.Enabled = True
        Form1.Select()
    End Sub

    Private Sub btn_CreepingChrysanthemum_Click(sender As Object, e As EventArgs) Handles btn_CreepingChrysanthemum.Click
        Form1.EntityNormalName = "Creeping Chrysanthemum"
        Form1.EntityCodeName = "Hana"
        Form1.lbl_EntityName.Text = Form1.EntityNormalName
        txt_SearchEntities.Text = ""
        Me.Hide()
        Form1.pic_SelectedEntity.Image = P2CC2.My.Resources.Creeping_Chrysanthemum_icon
        Form1.Enabled = True
        Form1.Select()
    End Sub

    Private Sub btn_DecoratedCannonBeetle_Click(sender As Object, e As EventArgs) Handles btn_DecoratedCannonBeetle.Click
        Form1.EntityNormalName = "Decorated Cannon Beetle"
        Form1.EntityCodeName = "Rkabuto"
        Form1.lbl_EntityName.Text = Form1.EntityNormalName
        txt_SearchEntities.Text = ""
        Me.Hide()
        Form1.pic_SelectedEntity.Image = P2CC2.My.Resources.Decorated_Cannon_Beetle_icon
        Form1.Enabled = True
        Form1.Select()
    End Sub

    Private Sub btn_Doodlebug_Click(sender As Object, e As EventArgs) Handles btn_Doodlebug.Click
        Form1.EntityNormalName = "Doodlebug"
        Form1.EntityCodeName = "Fart"
        Form1.lbl_EntityName.Text = Form1.EntityNormalName
        txt_SearchEntities.Text = ""
        Me.Hide()
        Form1.pic_SelectedEntity.Image = P2CC2.My.Resources.Doodlebug_icon
        Form1.Enabled = True
        Form1.Select()
    End Sub

    Private Sub btn_DwarfBulbear_Click(sender As Object, e As EventArgs) Handles btn_DwarfBulbear.Click
        Form1.EntityNormalName = "Dwarf Bulbear"
        Form1.EntityCodeName = "KumaKochappy"
        Form1.lbl_EntityName.Text = Form1.EntityNormalName
        txt_SearchEntities.Text = ""
        Me.Hide()
        Form1.pic_SelectedEntity.Image = P2CC2.My.Resources.Dwarf_Bulbear_icon
        Form1.Enabled = True
        Form1.Select()
    End Sub

    Private Sub btn_DwarfOrangeBulborb_Click(sender As Object, e As EventArgs) Handles btn_DwarfOrangeBulborb.Click
        Form1.EntityNormalName = "Dwarf Orange Bulborb"
        Form1.EntityCodeName = "BlueKochappy"
        Form1.lbl_EntityName.Text = Form1.EntityNormalName
        txt_SearchEntities.Text = ""
        Me.Hide()
        Form1.pic_SelectedEntity.Image = P2CC2.My.Resources.Dwarf_Orange_Bulborb_icon
        Form1.Enabled = True
        Form1.Select()
    End Sub

    Private Sub btn_FemaleSheargrub_Click(sender As Object, e As EventArgs) Handles btn_FemaleSheargrub.Click
        Form1.EntityNormalName = "Female Sheargrub"
        Form1.EntityCodeName = "UjiA"
        Form1.lbl_EntityName.Text = Form1.EntityNormalName
        txt_SearchEntities.Text = ""
        Me.Hide()
        Form1.pic_SelectedEntity.Image = P2CC2.My.Resources.Female_Sheargrub_icon
        Form1.Enabled = True
        Form1.Select()
    End Sub

    Private Sub btn_FieryBlowhog_Click(sender As Object, e As EventArgs) Handles btn_FieryBlowhog.Click
        Form1.EntityNormalName = "Fiery Blowhog"
        Form1.EntityCodeName = "Tank"
        Form1.lbl_EntityName.Text = Form1.EntityNormalName
        txt_SearchEntities.Text = ""
        Me.Hide()
        Form1.pic_SelectedEntity.Image = P2CC2.My.Resources.Fiery_Blowhog_icon
        Form1.Enabled = True
        Form1.Select()
    End Sub

    Private Sub btn_FieryBulblax_Click(sender As Object, e As EventArgs) Handles btn_FieryBulblax.Click
        Form1.EntityNormalName = "Fiery Bulblax"
        Form1.EntityCodeName = "FireChappy"
        Form1.lbl_EntityName.Text = Form1.EntityNormalName
        txt_SearchEntities.Text = ""
        Me.Hide()
        Form1.pic_SelectedEntity.Image = P2CC2.My.Resources.Fiery_Bulblax_icon
        Form1.Enabled = True
        Form1.Select()
    End Sub

    Private Sub btn_FieryDweevil_Click(sender As Object, e As EventArgs) Handles btn_FieryDweevil.Click
        Form1.EntityNormalName = "Fiery Dweevil"
        Form1.EntityCodeName = "FireOtakara"
        Form1.lbl_EntityName.Text = Form1.EntityNormalName
        txt_SearchEntities.Text = ""
        Me.Hide()
        Form1.pic_SelectedEntity.Image = P2CC2.My.Resources.Fiery_Dweevil_icon
        Form1.Enabled = True
        Form1.Select()
    End Sub

    Private Sub btn_GatlingGroink_Click(sender As Object, e As EventArgs) Handles btn_GatlingGroink.Click
        Dim result As Integer = MessageBox.Show("Do you want it to stay still (like in a tower)?", "Gatling Groink", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button2)
        If result = DialogResult.Yes Then
            Form1.EntityNormalName = "Tower Gatling Groink"
            Form1.EntityCodeName = "FminiHoudai"
            Form1.lbl_EntityName.Text = Form1.EntityNormalName
            txt_SearchEntities.Text = ""
            Me.Hide()
            Form1.pic_SelectedEntity.Image = P2CC2.My.Resources.Gatling_Groink_icon
            Form1.Enabled = True
            Form1.Select()
        End If
        If result = DialogResult.No Then
            Form1.EntityNormalName = "Gatling Groink"
            Form1.EntityCodeName = "MiniHoudai"
            Form1.lbl_EntityName.Text = Form1.EntityNormalName
            txt_SearchEntities.Text = ""
            Me.Hide()
            Form1.pic_SelectedEntity.Image = P2CC2.My.Resources.Gatling_Groink_icon
            Form1.Enabled = True
            Form1.Select()
        End If
    End Sub

    Private Sub btn_GreaterSpottedJellyfloat_Click(sender As Object, e As EventArgs) Handles btn_GreaterSpottedJellyfloat.Click
        Form1.EntityNormalName = "Greater Spotted Jellyfloat"
        Form1.EntityCodeName = "OniKurage"
        Form1.lbl_EntityName.Text = Form1.EntityNormalName
        txt_SearchEntities.Text = ""
        Me.Hide()
        Form1.pic_SelectedEntity.Image = P2CC2.My.Resources.Greater_Spotted_Jellyfloat_icon
        Form1.Enabled = True
        Form1.Select()
    End Sub

    Private Sub btn_HairyBulborb_Click(sender As Object, e As EventArgs) Handles btn_HairyBulborb.Click
        Form1.EntityNormalName = "Hairy Bulborb"
        Form1.EntityCodeName = "YellowChappy"
        Form1.lbl_EntityName.Text = Form1.EntityNormalName
        txt_SearchEntities.Text = ""
        Me.Hide()
        Form1.pic_SelectedEntity.Image = P2CC2.My.Resources.Hairy_Bulborb_icon
        Form1.Enabled = True
        Form1.Select()
    End Sub

    Private Sub btn_HermitCrawmad_Click(sender As Object, e As EventArgs) Handles btn_HermitCrawmad.Click
        Form1.EntityNormalName = "Hermit Crawmad with Nest"
        Form1.EntityCodeName = "Jigumo"
        Form1.lbl_EntityName.Text = Form1.EntityNormalName
        txt_SearchEntities.Text = ""
        Me.Hide()
        Form1.pic_SelectedEntity.Image = P2CC2.My.Resources.Hermit_Crawmad_icon
        Form1.Enabled = True
        Form1.Select()
    End Sub

    Private Sub btn_Honeywisp_Click(sender As Object, e As EventArgs) Handles btn_Honeywisp.Click
        Form1.EntityNormalName = "Honeywisp"
        Form1.EntityCodeName = "Qurione"
        Form1.lbl_EntityName.Text = Form1.EntityNormalName
        txt_SearchEntities.Text = ""
        Me.Hide()
        Form1.pic_SelectedEntity.Image = P2CC2.My.Resources.Honeywisp_icon
        Form1.Enabled = True
        Form1.Select()
    End Sub

    Private Sub btn_IridescentFlintBeetle_Click(sender As Object, e As EventArgs) Handles btn_IridescentFlintBeetle.Click
        Form1.EntityNormalName = "Iridescent Flint Beetle"
        Form1.EntityCodeName = "Kogane"
        Form1.lbl_EntityName.Text = Form1.EntityNormalName
        txt_SearchEntities.Text = ""
        Me.Hide()
        Form1.pic_SelectedEntity.Image = P2CC2.My.Resources.Iridescent_Flint_Beetle_icon
        Form1.Enabled = True
        Form1.Select()
    End Sub

    Private Sub btn_IridescentGlintBeetle_Click(sender As Object, e As EventArgs) Handles btn_IridescentGlintBeetle.Click
        Form1.EntityNormalName = "Iridescent Glint Beetle"
        Form1.EntityCodeName = "Wealthy"
        Form1.lbl_EntityName.Text = Form1.EntityNormalName
        txt_SearchEntities.Text = ""
        Me.Hide()
        Form1.pic_SelectedEntity.Image = P2CC2.My.Resources.Iridescent_Glint_Beetle_icon
        Form1.Enabled = True
        Form1.Select()
    End Sub

    Private Sub btn_LesserSpottedJellyfloat_Click(sender As Object, e As EventArgs) Handles btn_LesserSpottedJellyfloat.Click
        Form1.EntityNormalName = "Lesser Spotted Jellyfloat"
        Form1.EntityCodeName = "Kurage"
        Form1.lbl_EntityName.Text = Form1.EntityNormalName
        txt_SearchEntities.Text = ""
        Me.Hide()
        Form1.pic_SelectedEntity.Image = P2CC2.My.Resources.Lesser_Spotted_Jellyfloat_icon
        Form1.Enabled = True
        Form1.Select()
    End Sub

    Private Sub btn_MaleSheargrub_Click(sender As Object, e As EventArgs) Handles btn_MaleSheargrub.Click
        Form1.EntityNormalName = "Male Sheargrub"
        Form1.EntityCodeName = "UjiB"
        Form1.lbl_EntityName.Text = Form1.EntityNormalName
        txt_SearchEntities.Text = ""
        Me.Hide()
        Form1.pic_SelectedEntity.Image = P2CC2.My.Resources.Male_Sheargrub_icon
        Form1.Enabled = True
        Form1.Select()
    End Sub

    Private Sub btn_Mamuta_Click(sender As Object, e As EventArgs) Handles btn_Mamuta.Click
        Form1.EntityNormalName = "Mamuta"
        Form1.EntityCodeName = "Miulin"
        Form1.lbl_EntityName.Text = Form1.EntityNormalName
        txt_SearchEntities.Text = ""
        Me.Hide()
        Form1.pic_SelectedEntity.Image = P2CC2.My.Resources.Mamuta_icon
        Form1.Enabled = True
        Form1.Select()
    End Sub

    Private Sub btn_Mitite_Click(sender As Object, e As EventArgs) Handles btn_Mitite.Click
        Form1.EntityNormalName = "Mitite"
        Form1.EntityCodeName = "TamagoMushi"
        Form1.lbl_EntityName.Text = Form1.EntityNormalName
        txt_SearchEntities.Text = ""
        Me.Hide()
        Form1.pic_SelectedEntity.Image = P2CC2.My.Resources.Mitite_icon
        Form1.Enabled = True
        Form1.Select()
    End Sub

    Private Sub btn_MungeDweevil_Click(sender As Object, e As EventArgs) Handles btn_MungeDweevil.Click
        Form1.EntityNormalName = "Munge Dweevil"
        Form1.EntityCodeName = "GasOtakara"
        Form1.lbl_EntityName.Text = Form1.EntityNormalName
        txt_SearchEntities.Text = ""
        Me.Hide()
        Form1.pic_SelectedEntity.Image = P2CC2.My.Resources.Munge_Dweevil_icon
        Form1.Enabled = True
        Form1.Select()
    End Sub

    Private Sub btn_OrangeBulborb_Click(sender As Object, e As EventArgs) Handles btn_OrangeBulborb.Click
        Form1.EntityNormalName = "Orange Bulborb"
        Form1.EntityCodeName = "BlueChappy"
        Form1.lbl_EntityName.Text = Form1.EntityNormalName
        txt_SearchEntities.Text = ""
        Me.Hide()
        Form1.pic_SelectedEntity.Image = P2CC2.My.Resources.Orange_Bulborb_icon
        Form1.Enabled = True
        Form1.Select()
    End Sub

    Private Sub btn_PuffyBlowhog_Click(sender As Object, e As EventArgs) Handles btn_PuffyBlowhog.Click
        Form1.EntityNormalName = "Puffy Blowhog"
        Form1.EntityCodeName = "Mar"
        Form1.lbl_EntityName.Text = Form1.EntityNormalName
        txt_SearchEntities.Text = ""
        Me.Hide()
        Form1.pic_SelectedEntity.Image = P2CC2.My.Resources.Puffy_Blowhog_icon
        Form1.Enabled = True
        Form1.Select()
    End Sub

    Private Sub btn_RavenousWhiskerpillar_Click(sender As Object, e As EventArgs)
        Form1.EntityNormalName = "Ravenous Whiskerpillar"
        Form1.EntityCodeName = "ImoMushi"
        Form1.lbl_EntityName.Text = Form1.EntityNormalName
        txt_SearchEntities.Text = ""
        Me.Hide()
        Form1.pic_SelectedEntity.Image = P2CC2.My.Resources.Ravenous_Whiskerpillar_icon
        Form1.Enabled = True
        Form1.Select()
    End Sub

    Private Sub btn_Shearwig_Click(sender As Object, e As EventArgs) Handles btn_Shearwig.Click
        Form1.EntityNormalName = "Shearwig"
        Form1.EntityCodeName = "Tobi"
        Form1.lbl_EntityName.Text = Form1.EntityNormalName
        txt_SearchEntities.Text = ""
        Me.Hide()
        Form1.pic_SelectedEntity.Image = P2CC2.My.Resources.Shearwig_icon
        Form1.Enabled = True
        Form1.Select()
    End Sub

    Private Sub btn_SkitterLeaf_Click(sender As Object, e As EventArgs) Handles btn_SkitterLeaf.Click
        Form1.EntityNormalName = "Skitter Leaf"
        Form1.EntityCodeName = "Sokkuri"
        Form1.lbl_EntityName.Text = Form1.EntityNormalName
        txt_SearchEntities.Text = ""
        Me.Hide()
        Form1.pic_SelectedEntity.Image = P2CC2.My.Resources.Skitter_Leaf_icon
        Form1.Enabled = True
        Form1.Select()
    End Sub

    Private Sub btn_SnowBulborb_Click(sender As Object, e As EventArgs) Handles btn_SnowBulborb.Click
        Form1.EntityNormalName = "Snow Bulborb"
        Form1.EntityCodeName = "YellowKochappy"
        Form1.lbl_EntityName.Text = Form1.EntityNormalName
        txt_SearchEntities.Text = ""
        Me.Hide()
        Form1.pic_SelectedEntity.Image = P2CC2.My.Resources.Snow_Bulborb_icon
        Form1.Enabled = True
        Form1.Select()
    End Sub

    Private Sub btn_SpottyBulbear_Click(sender As Object, e As EventArgs) Handles btn_SpottyBulbear.Click
        Form1.EntityNormalName = "Spotty Bulbear"
        Form1.EntityCodeName = "KumaChappy"
        Form1.lbl_EntityName.Text = Form1.EntityNormalName
        txt_SearchEntities.Text = ""
        Me.Hide()
        Form1.pic_SelectedEntity.Image = P2CC2.My.Resources.Spotty_Bulbear_icon
        Form1.Enabled = True
        Form1.Select()
    End Sub

    Private Sub btn_SwoopingSnitchbug_Click(sender As Object, e As EventArgs) Handles btn_SwoopingSnitchbug.Click
        Form1.EntityNormalName = "Swooping Snitchbug"
        Form1.EntityCodeName = "Sarai"
        Form1.lbl_EntityName.Text = Form1.EntityNormalName
        txt_SearchEntities.Text = ""
        Me.Hide()
        Form1.pic_SelectedEntity.Image = P2CC2.My.Resources.Swooping_Snitchbug_icon
        Form1.Enabled = True
        Form1.Select()
    End Sub

    Private Sub btn_ToadyBloyster_Click(sender As Object, e As EventArgs) Handles btn_ToadyBloyster.Click
        Form1.EntityNormalName = "Toady Bloyster"
        Form1.EntityCodeName = "UmiMushiBlind"
        Form1.lbl_EntityName.Text = Form1.EntityNormalName
        txt_SearchEntities.Text = ""
        Me.Hide()
        Form1.pic_SelectedEntity.Image = P2CC2.My.Resources.Toady_Bloyster_icon
        Form1.Enabled = True
        Form1.Select()
    End Sub

    Private Sub btn_UnmarkedSpectralids_Click(sender As Object, e As EventArgs) Handles btn_UnmarkedSpectralids.Click
        Form1.EntityNormalName = "Unmarked Spectralids"
        Form1.EntityCodeName = "ShijimiChou"
        Form1.lbl_EntityName.Text = Form1.EntityNormalName
        txt_SearchEntities.Text = ""
        Me.Hide()
        Form1.pic_SelectedEntity.Image = P2CC2.My.Resources.Unmarked_Spectralids_icon
        Form1.Enabled = True
        Form1.Select()
    End Sub

    Private Sub btn_VolatileDweevil_Click(sender As Object, e As EventArgs) Handles btn_VolatileDweevil.Click
        Form1.EntityNormalName = "Volatile Dweevil"
        Form1.EntityCodeName = "BombOtakara"
        Form1.lbl_EntityName.Text = Form1.EntityNormalName
        txt_SearchEntities.Text = ""
        Me.Hide()
        Form1.pic_SelectedEntity.Image = P2CC2.My.Resources.Volatile_Dweevil_icon
        Form1.Enabled = True
        Form1.Select()
    End Sub

    Private Sub btn_WaterDumple_Click(sender As Object, e As EventArgs) Handles btn_WaterDumple.Click
        Form1.EntityNormalName = "Water Dumple"
        Form1.EntityCodeName = "Catfish"
        Form1.lbl_EntityName.Text = Form1.EntityNormalName
        txt_SearchEntities.Text = ""
        Me.Hide()
        Form1.pic_SelectedEntity.Image = P2CC2.My.Resources.Water_Dumple_icon
        Form1.Enabled = True
        Form1.Select()
    End Sub

    Private Sub btn_WateryBlowhog_Click(sender As Object, e As EventArgs) Handles btn_WateryBlowhog.Click
        Form1.EntityNormalName = "Watery Blowhog"
        Form1.EntityCodeName = "Wtank"
        Form1.lbl_EntityName.Text = Form1.EntityNormalName
        txt_SearchEntities.Text = ""
        Me.Hide()
        Form1.pic_SelectedEntity.Image = P2CC2.My.Resources.Watery_Blowhog_icon
        Form1.Enabled = True
        Form1.Select()
    End Sub

    Private Sub btn_WitheringBlowhog_Click(sender As Object, e As EventArgs) Handles btn_WitheringBlowhog.Click
        Form1.EntityNormalName = "Withering Blowhog"
        Form1.EntityCodeName = "Hanachirashi"
        Form1.lbl_EntityName.Text = Form1.EntityNormalName
        txt_SearchEntities.Text = ""
        Me.Hide()
        Form1.pic_SelectedEntity.Image = P2CC2.My.Resources.Withering_Blowhog_icon
        Form1.Enabled = True
        Form1.Select()
    End Sub

    Private Sub btn_Wogpole_Click(sender As Object, e As EventArgs) Handles btn_Wogpole.Click
        Form1.EntityNormalName = "Wogpole"
        Form1.EntityCodeName = "Tadpole"
        Form1.lbl_EntityName.Text = Form1.EntityNormalName
        txt_SearchEntities.Text = ""
        Me.Hide()
        Form1.pic_SelectedEntity.Image = P2CC2.My.Resources.Wogpole_icon
        Form1.Enabled = True
        Form1.Select()
    End Sub

    Private Sub btn_Wollywog_Click(sender As Object, e As EventArgs) Handles btn_Wollywog.Click
        Form1.EntityNormalName = "Wollywog"
        Form1.EntityCodeName = "MaroFrog"
        Form1.lbl_EntityName.Text = Form1.EntityNormalName
        txt_SearchEntities.Text = ""
        Me.Hide()
        Form1.pic_SelectedEntity.Image = P2CC2.My.Resources.Wollywog_icon
        Form1.Enabled = True
        Form1.Select()
    End Sub

    Private Sub btn_YellowWollywog_Click(sender As Object, e As EventArgs) Handles btn_YellowWollywog.Click
        Form1.EntityNormalName = "Yellow Wollywog"
        Form1.EntityCodeName = "Frog"
        Form1.lbl_EntityName.Text = Form1.EntityNormalName
        txt_SearchEntities.Text = ""
        Me.Hide()
        Form1.pic_SelectedEntity.Image = P2CC2.My.Resources.Yellow_Wollywog_icon
        Form1.Enabled = True
        Form1.Select()
    End Sub

    Private Sub btn_BeadyLongLegs_Click(sender As Object, e As EventArgs) Handles btn_BeadyLongLegs.Click
        Form1.EntityNormalName = "Beady Long Legs"
        Form1.EntityCodeName = "Damagumo"
        Form1.lbl_EntityName.Text = Form1.EntityNormalName
        txt_SearchEntities.Text = ""
        Me.Hide()
        Form1.pic_SelectedEntity.Image = P2CC2.My.Resources.Beady_Long_Legs_icon
        Form1.Enabled = True
        Form1.Select()
    End Sub

    Private Sub btn_BurrowingSnagret_Click(sender As Object, e As EventArgs) Handles btn_BurrowingSnagret.Click
        Form1.EntityNormalName = "Burrowing Snagret"
        Form1.EntityCodeName = "SnakeCrow"
        Form1.lbl_EntityName.Text = Form1.EntityNormalName
        txt_SearchEntities.Text = ""
        Me.Hide()
        Form1.pic_SelectedEntity.Image = P2CC2.My.Resources.Burrowing_Snagret_icon
        Form1.Enabled = True
        Form1.Select()
    End Sub

    Private Sub btn_EmperorBulblax_Click(sender As Object, e As EventArgs) Handles btn_EmperorBulblax.Click
        Form1.EntityNormalName = "Emperor Bulblax"
        Form1.EntityCodeName = "KingChappy"
        Form1.lbl_EntityName.Text = Form1.EntityNormalName
        txt_SearchEntities.Text = ""
        Me.Hide()
        Form1.pic_SelectedEntity.Image = P2CC2.My.Resources.Emperor_Bulblax_icon
        Form1.Enabled = True
        Form1.Select()
    End Sub

    Private Sub btn_EmpressBulblax_Click(sender As Object, e As EventArgs) Handles btn_EmpressBulblax.Click
        Form1.EntityNormalName = "Empress Bulblax"
        Form1.EntityCodeName = "Queen"
        Form1.lbl_EntityName.Text = Form1.EntityNormalName
        txt_SearchEntities.Text = ""
        Me.Hide()
        Form1.pic_SelectedEntity.Image = P2CC2.My.Resources.Empress_Bulblax_icon
        Form1.Enabled = True
        Form1.Select()
    End Sub

    Private Sub btn_GiantBreadbug_Click(sender As Object, e As EventArgs) Handles btn_GiantBreadbug.Click
        Form1.EntityNormalName = "Giant Breadbug"
        Form1.EntityCodeName = "OoPanModoki"
        Form1.lbl_EntityName.Text = Form1.EntityNormalName
        txt_SearchEntities.Text = ""
        Me.Hide()
        Form1.pic_SelectedEntity.Image = P2CC2.My.Resources.Giant_Breadbug_icon
        Form1.Enabled = True
        Form1.Select()
    End Sub

    Private Sub btn_ManatLegs_Click(sender As Object, e As EventArgs) Handles btn_ManatLegs.Click
        Form1.EntityNormalName = "Man-at-Legs"
        Form1.EntityCodeName = "Houdai"
        Form1.lbl_EntityName.Text = Form1.EntityNormalName
        txt_SearchEntities.Text = ""
        Me.Hide()
        Form1.pic_SelectedEntity.Image = P2CC2.My.Resources.Man_at_Legs_icon
        Form1.Enabled = True
        Form1.Select()
    End Sub

    Private Sub btn_PileatedSnagret_Click(sender As Object, e As EventArgs) Handles btn_PileatedSnagret.Click
        Form1.EntityNormalName = "Pileated Snagret"
        Form1.EntityCodeName = "SnakeWhole"
        Form1.lbl_EntityName.Text = Form1.EntityNormalName
        txt_SearchEntities.Text = ""
        Me.Hide()
        Form1.pic_SelectedEntity.Image = P2CC2.My.Resources.Pileated_Snagret_icon
        Form1.Enabled = True
        Form1.Select()
    End Sub

    Private Sub btn_RagingLongLegs_Click(sender As Object, e As EventArgs) Handles btn_RagingLongLegs.Click
        Form1.EntityNormalName = "Raging Long Legs"
        Form1.EntityCodeName = "BigFoot"
        Form1.lbl_EntityName.Text = Form1.EntityNormalName
        txt_SearchEntities.Text = ""
        Me.Hide()
        Form1.pic_SelectedEntity.Image = P2CC2.My.Resources.Raging_Long_Legs_icon
        Form1.Enabled = True
        Form1.Select()
    End Sub

    Private Sub btn_RangingBloyster_Click(sender As Object, e As EventArgs) Handles btn_RangingBloyster.Click
        Form1.EntityNormalName = "Ranging Bloyster"
        Form1.EntityCodeName = "UmiMushi"
        Form1.lbl_EntityName.Text = Form1.EntityNormalName
        txt_SearchEntities.Text = ""
        Me.Hide()
        Form1.pic_SelectedEntity.Image = P2CC2.My.Resources.Ranging_Bloyster_icon
        Form1.Enabled = True
        Form1.Select()
    End Sub

    Private Sub btn_SegmentedCrawbster_Click(sender As Object, e As EventArgs) Handles btn_SegmentedCrawbster.Click
        Form1.EntityNormalName = "Segmented Crawbster"
        Form1.EntityCodeName = "DangoMushi"
        Form1.lbl_EntityName.Text = Form1.EntityNormalName
        txt_SearchEntities.Text = ""
        Me.Hide()
        Form1.pic_SelectedEntity.Image = P2CC2.My.Resources.Segmented_Crawbster_icon
        Form1.Enabled = True
        Form1.Select()
    End Sub

    Private Sub btn_TitanDweevil_Click(sender As Object, e As EventArgs) Handles btn_TitanDweevil.Click
        Form1.EntityNormalName = "Titan Dweevil"
        Form1.EntityCodeName = "BigTreasure"
        Form1.lbl_EntityName.Text = Form1.EntityNormalName
        txt_SearchEntities.Text = ""
        Me.Hide()
        Form1.pic_SelectedEntity.Image = P2CC2.My.Resources.Titan_Dweevil_icon
        Form1.Enabled = True
        Form1.Select()
    End Sub

    Private Sub btn_Waterwraith_Click(sender As Object, e As EventArgs) Handles btn_Waterwraith.Click
        Form1.EntityNormalName = "Waterwraith"
        Form1.EntityCodeName = "BlackMan"
        Form1.lbl_EntityName.Text = Form1.EntityNormalName
        txt_SearchEntities.Text = ""
        Me.Hide()
        Form1.pic_SelectedEntity.Image = P2CC2.My.Resources.Waterwraith_icon
        Form1.Enabled = True
        Form1.Select()
    End Sub
    Private Sub EntityList_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.Closing
        e.Cancel = True
        txt_SearchEntities.Text = ""
        Me.Hide()
        Form1.Enabled = True
        Form1.Select()
    End Sub

    Private Sub btn_ObjectsDropDown_Click(sender As Object, e As EventArgs) Handles btn_ObjectsDropDown.Click
        If btn_ObjectsDropDown.Text = "/\" Then
            pnl_Objects.Visible = False
            lbl_Decorations.Top -= 167
            btn_DecorationsDropDown.Top -= 167
            pnl_Decorations.Top -= 167
            btn_ObjectsDropDown.Text = "\/"
            txt_SearchEntities.Select()
        ElseIf btn_ObjectsDropDown.Text = "\/" Then
            pnl_Objects.Visible = True
            lbl_Decorations.Top += 167
            btn_DecorationsDropDown.Top += 167
            pnl_Decorations.Top += 167
            btn_ObjectsDropDown.Text = "/\"
            txt_SearchEntities.Select()
        End If
    End Sub

    Private Sub btn_DecorationsDropDown_Click(sender As Object, e As EventArgs) Handles btn_DecorationsDropDown.Click
        If btn_DecorationsDropDown.Text = "/\" Then
            pnl_Decorations.Visible = False
            btn_DecorationsDropDown.Text = "\/"
            txt_SearchEntities.Select()
        ElseIf btn_DecorationsDropDown.Text = "\/" Then
            pnl_Decorations.Visible = True
            btn_DecorationsDropDown.Text = "/\"
            txt_SearchEntities.Select()
        End If
    End Sub

    Private Sub btn_WaterwraithRollers_Click(sender As Object, e As EventArgs) Handles btn_WaterwraithRollers.Click
        Form1.EntityNormalName = "Waterwraith's Wheels Only"
        Form1.EntityCodeName = "Tyre"
        Form1.lbl_EntityName.Text = Form1.EntityNormalName
        txt_SearchEntities.Text = ""
        Me.Hide()
        Form1.pic_SelectedEntity.Image = P2CC2.My.Resources.Waterwraith_icon
        Form1.Enabled = True
        Form1.Select()
    End Sub

    Private Sub btn_BreadbugNest_Click(sender As Object, e As EventArgs) Handles btn_BreadbugNest.Click
        Form1.EntityNormalName = "Breadbug Nest"
        Form1.EntityCodeName = "PanHouse"
        Form1.lbl_EntityName.Text = Form1.EntityNormalName
        txt_SearchEntities.Text = ""
        Me.Hide()
        Form1.pic_SelectedEntity.Image = P2CC2.My.Resources.Breadbug_icon
        Form1.Enabled = True
        Form1.Select()
    End Sub

    Private Sub btn_HermitNest_Click(sender As Object, e As EventArgs) Handles btn_HermitNest.Click
        Form1.EntityNormalName = "Hermit Crawmad's Nest Only"
        Form1.EntityCodeName = "JigumoHouse"
        Form1.lbl_EntityName.Text = Form1.EntityNormalName
        txt_SearchEntities.Text = ""
        Me.Hide()
        Form1.pic_SelectedEntity.Image = P2CC2.My.Resources.Hermit_Crawmad_icon
        Form1.Enabled = True
        Form1.Select()
    End Sub

    Private Sub btn_Bombrock_Click(sender As Object, e As EventArgs) Handles btn_Bombrock.Click
        Form1.EntityNormalName = "Bomb-rock"
        Form1.EntityCodeName = "Bomb"
        Form1.lbl_EntityName.Text = Form1.EntityNormalName
        txt_SearchEntities.Text = ""
        Me.Hide()
        Form1.pic_SelectedEntity.Image = P2CC2.My.Resources.Bomb_rock_icon
        Form1.Enabled = True
        Form1.Select()
    End Sub

    Private Sub btn_Boulder_Click(sender As Object, e As EventArgs) Handles btn_Boulder.Click
        Form1.EntityNormalName = "Boulder"
        Form1.EntityCodeName = "Rock"
        Form1.lbl_EntityName.Text = Form1.EntityNormalName
        txt_SearchEntities.Text = ""
        Me.Hide()
        Form1.pic_SelectedEntity.Image = P2CC2.My.Resources.Boulder_icon
        Form1.Enabled = True
        Form1.Select()
    End Sub

    Private Sub btn_Egg_Click(sender As Object, e As EventArgs) Handles btn_Egg.Click
        Form1.EntityNormalName = "Egg"
        Form1.EntityCodeName = "Egg"
        Form1.lbl_EntityName.Text = Form1.EntityNormalName
        txt_SearchEntities.Text = ""
        Me.Hide()
        Form1.pic_SelectedEntity.Image = P2CC2.My.Resources.egg
        Form1.Enabled = True
        Form1.Select()
    End Sub

    Private Sub btn_ElectricalWire_Click(sender As Object, e As EventArgs) Handles btn_ElectricalWire.Click
        Form1.EntityNormalName = "Electrical Wire"
        Form1.EntityCodeName = "ElecHiba"
        Form1.lbl_EntityName.Text = Form1.EntityNormalName
        txt_SearchEntities.Text = ""
        Me.Hide()
        Form1.pic_SelectedEntity.Image = P2CC2.My.Resources.Electrical_wire_icon
        Form1.Enabled = True
        Form1.Select()
    End Sub

    Private Sub btn_FireGeyser_Click(sender As Object, e As EventArgs) Handles btn_FireGeyser.Click
        Form1.EntityNormalName = "Fire Geyser"
        Form1.EntityCodeName = "Hiba"
        Form1.lbl_EntityName.Text = Form1.EntityNormalName
        txt_SearchEntities.Text = ""
        Me.Hide()
        Form1.pic_SelectedEntity.Image = P2CC2.My.Resources.Fire_geyser_icon
        Form1.Enabled = True
        Form1.Select()
    End Sub

    Private Sub btn_GasPipe_Click(sender As Object, e As EventArgs) Handles btn_GasPipe.Click
        Form1.EntityNormalName = "Gas Pipe"
        Form1.EntityCodeName = "GasHiba"
        Form1.lbl_EntityName.Text = Form1.EntityNormalName
        txt_SearchEntities.Text = ""
        Me.Hide()
        Form1.pic_SelectedEntity.Image = P2CC2.My.Resources.Gas_pipe_icon
        Form1.Enabled = True
        Form1.Select()
    End Sub

    Private Sub btn_CrimsonCandypopBud_Click(sender As Object, e As EventArgs) Handles btn_CrimsonCandypopBud.Click
        Form1.EntityNormalName = "Crimson Candypop Bud"
        Form1.EntityCodeName = "RedPom"
        Form1.lbl_EntityName.Text = Form1.EntityNormalName
        txt_SearchEntities.Text = ""
        Me.Hide()
        Form1.pic_SelectedEntity.Image = P2CC2.My.Resources.Crimson_Candypop_Bud_icon
        Form1.Enabled = True
        Form1.Select()
    End Sub

    Private Sub btn_GoldenCandypopBud_Click(sender As Object, e As EventArgs) Handles btn_GoldenCandypopBud.Click
        Form1.EntityNormalName = "Golden Candypop Bud"
        Form1.EntityCodeName = "YellowPom"
        Form1.lbl_EntityName.Text = Form1.EntityNormalName
        txt_SearchEntities.Text = ""
        Me.Hide()
        Form1.pic_SelectedEntity.Image = P2CC2.My.Resources.Golden_Candypop_Bud_icon
        Form1.Enabled = True
        Form1.Select()
    End Sub

    Private Sub btn_LapisLazuliCandypopBud_Click(sender As Object, e As EventArgs) Handles btn_LapisLazuliCandypopBud.Click
        Form1.EntityNormalName = "Lapis Lazuli Candypop Bud"
        Form1.EntityCodeName = "BluePom"
        Form1.lbl_EntityName.Text = Form1.EntityNormalName
        txt_SearchEntities.Text = ""
        Me.Hide()
        Form1.pic_SelectedEntity.Image = P2CC2.My.Resources.Lapis_Lazuli_Candypop_Bud_icon
        Form1.Enabled = True
        Form1.Select()
    End Sub

    Private Sub btn_IvoryCandypopBud_Click(sender As Object, e As EventArgs) Handles btn_IvoryCandypopBud.Click
        Form1.EntityNormalName = "Ivory Candypop Bud"
        Form1.EntityCodeName = "WhitePom"
        Form1.lbl_EntityName.Text = Form1.EntityNormalName
        txt_SearchEntities.Text = ""
        Me.Hide()
        Form1.pic_SelectedEntity.Image = P2CC2.My.Resources.Ivory_Candypop_Bud_icon
        Form1.Enabled = True
        Form1.Select()
    End Sub

    Private Sub btn_VioletCandypopBud_Click(sender As Object, e As EventArgs) Handles btn_VioletCandypopBud.Click
        Form1.EntityNormalName = "Violet Candypop Bud"
        Form1.EntityCodeName = "BlackPom"
        Form1.lbl_EntityName.Text = Form1.EntityNormalName
        txt_SearchEntities.Text = ""
        Me.Hide()
        Form1.pic_SelectedEntity.Image = P2CC2.My.Resources.Violet_Candypop_Bud_icon
        Form1.Enabled = True
        Form1.Select()
    End Sub

    Private Sub btn_QueenCandypopBud_Click(sender As Object, e As EventArgs) Handles btn_QueenCandypopBud.Click
        Form1.EntityNormalName = "Queen Candypop Bud"
        Form1.EntityCodeName = "RandPom"
        Form1.lbl_EntityName.Text = Form1.EntityNormalName
        txt_SearchEntities.Text = ""
        Me.Hide()
        Form1.pic_SelectedEntity.Image = P2CC2.My.Resources.Queen_Candypop_Bud_icon
        Form1.Enabled = True
        Form1.Select()
    End Sub

    Private Sub btn_ChiyogamiPaper_Click(sender As Object, e As EventArgs) Handles btn_ChiyogamiPaper.Click
        Form1.EntityNormalName = "Chiyogami Paper"
        Form1.EntityCodeName = "Chiyogami"
        Form1.lbl_EntityName.Text = Form1.EntityNormalName
        txt_SearchEntities.Text = ""
        Me.Hide()
        Form1.pic_SelectedEntity.Image = P2CC2.My.Resources.Chiyogamipaper
        Form1.Enabled = True
        Form1.Select()
    End Sub

    Private Sub btn_Clover_Click(sender As Object, e As EventArgs) Handles btn_Clover.Click
        Form1.EntityNormalName = "Clover"
        Form1.EntityCodeName = "Clover"
        Form1.lbl_EntityName.Text = Form1.EntityNormalName
        txt_SearchEntities.Text = ""
        Me.Hide()
        Form1.pic_SelectedEntity.Image = P2CC2.My.Resources.Clover_icon
        Form1.Enabled = True
        Form1.Select()
    End Sub

    Private Sub btn_CommonGlowcap_Click(sender As Object, e As EventArgs) Handles btn_CommonGlowcap.Click
        Form1.EntityNormalName = "Common Glowcap"
        Form1.EntityCodeName = "HikariKinoko"
        Form1.lbl_EntityName.Text = Form1.EntityNormalName
        txt_SearchEntities.Text = ""
        Me.Hide()
        Form1.pic_SelectedEntity.Image = P2CC2.My.Resources.Common_Glowcap_icon
        Form1.Enabled = True
        Form1.Select()
    End Sub

    Private Sub btn_Dandelion_Click(sender As Object, e As EventArgs) Handles btn_Dandelion.Click
        Form1.EntityNormalName = "Dandelion"
        Form1.EntityCodeName = "Tanpopo"
        Form1.lbl_EntityName.Text = Form1.EntityNormalName
        txt_SearchEntities.Text = ""
        Me.Hide()
        Form1.pic_SelectedEntity.Image = P2CC2.My.Resources.Dandelion_icon
        Form1.Enabled = True
        Form1.Select()
    End Sub

    Private Sub btn_Fiddlehead_Click(sender As Object, e As EventArgs) Handles btn_Fiddlehead.Click
        Form1.EntityNormalName = "Fiddlehead"
        Form1.EntityCodeName = "Zenmai"
        Form1.lbl_EntityName.Text = Form1.EntityNormalName
        txt_SearchEntities.Text = ""
        Me.Hide()
        Form1.pic_SelectedEntity.Image = P2CC2.My.Resources.Fiddlehead_icon
        Form1.Enabled = True
        Form1.Select()
    End Sub

    Private Sub btn_Foxtail_Click(sender As Object, e As EventArgs) Handles btn_Foxtail.Click
        Form1.EntityNormalName = "Foxtail"
        Form1.EntityCodeName = "Nekojarashi"
        Form1.lbl_EntityName.Text = Form1.EntityNormalName
        txt_SearchEntities.Text = ""
        Me.Hide()
        Form1.pic_SelectedEntity.Image = P2CC2.My.Resources.Foxtail_icon
        Form1.Enabled = True
        Form1.Select()
    End Sub

    Private Sub btn_Horsetail_Click(sender As Object, e As EventArgs) Handles btn_Horsetail.Click
        Form1.EntityNormalName = "Horsetail"
        Form1.EntityCodeName = "Tukushi"
        Form1.lbl_EntityName.Text = Form1.EntityNormalName
        txt_SearchEntities.Text = ""
        Me.Hide()
        Form1.pic_SelectedEntity.Image = P2CC2.My.Resources.Horsetail_icon
        Form1.Enabled = True
        Form1.Select()
    End Sub

    Private Sub btn_Margaret_Click(sender As Object, e As EventArgs) Handles btn_Margaret.Click
        Form1.EntityNormalName = "Margaret"
        Form1.EntityCodeName = "Magaret"
        Form1.lbl_EntityName.Text = Form1.EntityNormalName
        txt_SearchEntities.Text = ""
        Me.Hide()
        Form1.pic_SelectedEntity.Image = P2CC2.My.Resources.Margaret_icon
        Form1.Enabled = True
        Form1.Select()
    End Sub

    Private Sub btn_SeedingDandelion_Click(sender As Object, e As EventArgs) Handles btn_SeedingDandelion.Click
        Form1.EntityNormalName = "Seeding Dandelion"
        Form1.EntityCodeName = "Watage"
        Form1.lbl_EntityName.Text = Form1.EntityNormalName
        txt_SearchEntities.Text = ""
        Me.Hide()
        Form1.pic_SelectedEntity.Image = P2CC2.My.Resources.Seeding_Dandelion_icon
        Form1.Enabled = True
        Form1.Select()
    End Sub

    Private Sub btn_RedGlowstem_Click(sender As Object, e As EventArgs) Handles btn_RedGlowstem.Click
        Form1.EntityNormalName = "Red Glowstem"
        Form1.EntityCodeName = "DaiodoRed"
        Form1.lbl_EntityName.Text = Form1.EntityNormalName
        txt_SearchEntities.Text = ""
        Me.Hide()
        Form1.pic_SelectedEntity.Image = P2CC2.My.Resources.Glowstem_icon
        Form1.Enabled = True
        Form1.Select()
    End Sub

    Private Sub btn_GreenGlowstem_Click(sender As Object, e As EventArgs) Handles btn_GreenGlowstem.Click
        Form1.EntityNormalName = "Green Glowstem"
        Form1.EntityCodeName = "DaiodoGreen"
        Form1.lbl_EntityName.Text = Form1.EntityNormalName
        txt_SearchEntities.Text = ""
        Me.Hide()
        Form1.pic_SelectedEntity.Image = P2CC2.My.Resources.Glowstem_icon
        Form1.Enabled = True
        Form1.Select()
    End Sub

    Private Sub btn_SmallFigwort_Click(sender As Object, e As EventArgs) Handles btn_SmallFigwort.Click
        Form1.EntityNormalName = "Small Figwort"
        Form1.EntityCodeName = "Ooinu_s"
        Form1.lbl_EntityName.Text = Form1.EntityNormalName
        txt_SearchEntities.Text = ""
        Me.Hide()
        Form1.pic_SelectedEntity.Image = P2CC2.My.Resources.Figwort_icon
        Form1.Enabled = True
        Form1.Select()
    End Sub

    Private Sub btn_LargeFigwort_Click(sender As Object, e As EventArgs) Handles btn_LargeFigwort.Click
        Form1.EntityNormalName = "Large Figwort"
        Form1.EntityCodeName = "Ooinu_l"
        Form1.lbl_EntityName.Text = Form1.EntityNormalName
        txt_SearchEntities.Text = ""
        Me.Hide()
        Form1.pic_SelectedEntity.Image = P2CC2.My.Resources.Figwort_icon
        Form1.Enabled = True
        Form1.Select()
    End Sub

    Private Sub btn_SmallDyingFigwort_Click(sender As Object, e As EventArgs) Handles btn_SmallDyingFigwort.Click
        Form1.EntityNormalName = "Small Dying Figwort"
        Form1.EntityCodeName = "KareOoinu_s"
        Form1.lbl_EntityName.Text = Form1.EntityNormalName
        txt_SearchEntities.Text = ""
        Me.Hide()
        Form1.pic_SelectedEntity.Image = P2CC2.My.Resources.Figwort_icon
        Form1.Enabled = True
        Form1.Select()
    End Sub

    Private Sub btn_LargeDyingFigwort_Click(sender As Object, e As EventArgs) Handles btn_LargeDyingFigwort.Click
        Form1.EntityNormalName = "Large Dying Figwort"
        Form1.EntityCodeName = "KareOoinu_l"
        Form1.lbl_EntityName.Text = Form1.EntityNormalName
        txt_SearchEntities.Text = ""
        Me.Hide()
        Form1.pic_SelectedEntity.Image = P2CC2.My.Resources.Figwort_icon
        Form1.Enabled = True
        Form1.Select()
    End Sub

    Private Sub btn_SmallShoot_Click(sender As Object, e As EventArgs) Handles btn_SmallShoot.Click
        Form1.EntityNormalName = "Small Shoot"
        Form1.EntityCodeName = "Wakame_s"
        Form1.lbl_EntityName.Text = Form1.EntityNormalName
        txt_SearchEntities.Text = ""
        Me.Hide()
        Form1.pic_SelectedEntity.Image = P2CC2.My.Resources.Shoot_icon
        Form1.Enabled = True
        Form1.Select()
    End Sub

    Private Sub btn_LargeShoot_Click(sender As Object, e As EventArgs) Handles btn_LargeShoot.Click
        Form1.EntityNormalName = "Large Shoot"
        Form1.EntityCodeName = "Wakame_l"
        Form1.lbl_EntityName.Text = Form1.EntityNormalName
        txt_SearchEntities.Text = ""
        Me.Hide()
        Form1.pic_SelectedEntity.Image = P2CC2.My.Resources.Shoot_icon
        Form1.Enabled = True
        Form1.Select()
    End Sub
    Dim wasMax = False
    Private Sub EntityList_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        Panel2.Width = ClientSize.Width - 463
        Panel3.Width = ClientSize.Width - 463
        Panel4.Width = ClientSize.Width - 463
        Panel5.Width = ClientSize.Width - 463

        Panel6.Width = ClientSize.Width - 40
        Panel7.Width = ClientSize.Width - 40
        Panel8.Width = ClientSize.Width - 40
        Panel9.Width = ClientSize.Width - 40

        If WindowState = FormWindowState.Normal Then
            If wasMax Then
                wasMax = False
                pnl_RegularEnemies.Visible = False
                pnl_Objects.Visible = False
                pnl_Decorations.Visible = False
                pnl_Bosses.Visible = False

                If btn_RegularEnemiesDropDown.Text = "/\" Then
                    pnl_RegularEnemies.Visible = True
                End If
                If btn_ObjectsDropDown.Text = "/\" Then
                    pnl_Objects.Visible = True
                End If
                If btn_DecorationsDropDown.Text = "/\" Then
                    pnl_Decorations.Visible = True
                End If
                If btn_BossesDropDown.Text = "/\" Then
                    pnl_Bosses.Visible = True
                End If


                Panel1.HorizontalScroll.Maximum = 0
                Panel1.AutoScroll = False
                Panel1.VerticalScroll.Visible = False
                Panel1.AutoScroll = True
            End If
        ElseIf WindowState = FormWindowState.Maximized Then
            wasMax = True
        End If

    End Sub

    Private Sub EntityList_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub EntityList_ResizeBegin(sender As Object, e As EventArgs) Handles Me.ResizeBegin
        pnl_RegularEnemies.Visible = False
        pnl_Objects.Visible = False
        pnl_Decorations.Visible = False
        pnl_Bosses.Visible = False
    End Sub

    Private Sub EntityList_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd

        If btn_RegularEnemiesDropDown.Text = "/\" Then
            pnl_RegularEnemies.Visible = True
        End If
        If btn_ObjectsDropDown.Text = "/\" Then
            pnl_Objects.Visible = True
        End If
        If btn_DecorationsDropDown.Text = "/\" Then
            pnl_Decorations.Visible = True
        End If
        If btn_BossesDropDown.Text = "/\" Then
            pnl_Bosses.Visible = True
        End If


        Panel1.HorizontalScroll.Maximum = 0
        Panel1.AutoScroll = False
        Panel1.VerticalScroll.Visible = False
        Panel1.AutoScroll = True
    End Sub
End Class