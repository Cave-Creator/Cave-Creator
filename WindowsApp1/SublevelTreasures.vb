Imports System.ComponentModel

Public Class SublevelTreasures
    Private Sub lst_TreasuresNorm_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_TreasuresNorm.SelectedIndexChanged
        Form1.lst_Treasures.SelectedIndex = lst_TreasuresNorm.SelectedIndex
    End Sub

    Private Sub btn_DeleteSelectedTreasure_Click(sender As Object, e As EventArgs) Handles btn_DeleteSelectedTreasure.Click
        If lst_TreasuresNorm.SelectedIndex > -1 Then
            Form1.lst_Treasures.Items.RemoveAt(Form1.lst_Treasures.SelectedIndex)
            lst_TreasuresNorm.Items.RemoveAt(lst_TreasuresNorm.SelectedIndex)
            Dim TreasureSet As String = Form1.lst_Sublevel_IDs.SelectedItem & " - "
            Dim x As Integer = 0
            While x < Form1.lst_Treasures.Items.Count
                Form1.lst_Treasures.SelectedIndex = x
                TreasureSet = TreasureSet & Form1.lst_Treasures.SelectedItem & ";"
                x += 1
            End While
            Form1.lst_Treasures.SelectedIndex = -1
            If TreasureSet.Last = ";" Then TreasureSet = TreasureSet.Substring(0, TreasureSet.Length - 1)
            Form1.lst_TreasureSets.Items.Insert(Form1.lst_TreasureSets.SelectedIndex, TreasureSet)
            Form1.lst_TreasureSets.Items.RemoveAt(Form1.lst_TreasureSets.SelectedIndex)
            Form1.lst_TreasureSets.SelectedIndex = Form1.lst_Sublevels.SelectedIndex
        End If
    End Sub

    Private Sub btn_DeleteAllTreasures_Click(sender As Object, e As EventArgs) Handles btn_DeleteAllTreasures.Click
        Form1.lst_Treasures.Items.Clear()
        lst_TreasuresNorm.Items.Clear()
        Form1.lst_TreasureSets.Items.Insert(Form1.lst_TreasureSets.SelectedIndex, Form1.lst_Sublevel_IDs.SelectedItem & " - ")
        Form1.lst_TreasureSets.Items.RemoveAt(Form1.lst_TreasureSets.SelectedIndex)
        Form1.lst_TreasureSets.SelectedIndex = Form1.lst_Sublevels.SelectedIndex
    End Sub

    Private Sub btn_AddTreasure_Click(sender As Object, e As EventArgs) Handles btn_AddTreasure.Click
        Form1.TreasureExternalName = cmb_Treasures.SelectedItem
        Form1.TreasureConvertExternaltoInternal()
        Form1.lst_Treasures.Items.Add(Form1.TreasureInternalName & " " & num_treasureCount.Value & num_treasureWeight.Value)
        lst_TreasuresNorm.Items.Add(Form1.TreasureExternalName & " x " & num_treasureCount.Value & " [weight=" & num_treasureWeight.Value & "]")
        Dim TreasureSet As String = Form1.lst_Sublevel_IDs.SelectedItem & " - "
        Dim x As Integer = 0
        While x < Form1.lst_Treasures.Items.Count
            Form1.lst_Treasures.SelectedIndex = x
            TreasureSet = TreasureSet & Form1.lst_Treasures.SelectedItem & ";"
            x += 1
        End While
        TreasureSet = TreasureSet.Substring(0, TreasureSet.Length - 1)
        Form1.lst_TreasureSets.Items.Insert(Form1.lst_TreasureSets.SelectedIndex, TreasureSet)
        Form1.lst_TreasureSets.Items.RemoveAt(Form1.lst_TreasureSets.SelectedIndex)
        Form1.lst_TreasureSets.SelectedIndex = Form1.lst_Sublevels.SelectedIndex
        lst_TreasuresNorm.SelectedIndex = lst_TreasuresNorm.Items.Count - 1
    End Sub
    Private Sub SublevelTreasures_Load(sender As Object, e As EventArgs) Handles MyBase.Shown
        Me.Location = New Point(Form1.Location.X + ((Form1.Width / 2) - Me.Width / 2), Form1.Location.Y + ((Form1.Height / 2) - Me.Height / 2))
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub
End Class