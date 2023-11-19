Public Class SublevelGates
    Private Sub SublevelGates_Load(sender As Object, e As EventArgs) Handles MyBase.Shown
        Me.Location = New Point(Form1.Location.X + ((Form1.Width / 2) - Me.Width / 2), Form1.Location.Y + ((Form1.Height / 2) - Me.Height / 2))
    End Sub
    Private Sub btn_AddGate_Click(sender As Object, e As EventArgs) Handles btn_AddGate.Click
        Form1.lst_Gates.Items.Add("gate " & num_GateHP.Value & "
" & num_GateWeight.Value)
        lst_GatesNorm.Items.Add("Gate with " & num_GateHP.Value & "HP")
        Dim GateSet As String = Form1.lst_Sublevel_IDs.SelectedItem & " - "
        Dim x As Integer = 0
        While x < Form1.lst_Gates.Items.Count
            Form1.lst_Gates.SelectedIndex = x
            GateSet = GateSet & Form1.lst_Gates.SelectedItem & ";"
            x += 1
        End While
        GateSet = GateSet.Substring(0, GateSet.Length - 1)
        Form1.lst_GateSets.Items.Insert(Form1.lst_GateSets.SelectedIndex, GateSet)
        Form1.lst_GateSets.Items.RemoveAt(Form1.lst_GateSets.SelectedIndex)
        Form1.lst_GateSets.SelectedIndex = Form1.lst_Sublevels.SelectedIndex
        lst_GatesNorm.SelectedIndex = lst_GatesNorm.Items.Count - 1
    End Sub
    Private Sub lst_GatesNorm_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_GatesNorm.SelectedIndexChanged
        Form1.lst_Gates.SelectedIndex = lst_GatesNorm.SelectedIndex
    End Sub
    Private Sub btn_DeleteSelectedGate_Click(sender As Object, e As EventArgs) Handles btn_DeleteSelectedGate.Click
        If lst_GatesNorm.SelectedIndex > -1 Then
            Form1.lst_Gates.Items.RemoveAt(Form1.lst_Gates.SelectedIndex)
            lst_GatesNorm.Items.RemoveAt(lst_GatesNorm.SelectedIndex)
            Dim GateSet As String = Form1.lst_Sublevel_IDs.SelectedItem & " - "
            Dim x As Integer = 0
            While x < Form1.lst_Gates.Items.Count
                Form1.lst_Gates.SelectedIndex = x
                GateSet = GateSet & Form1.lst_Gates.SelectedItem & ";"
                x += 1
            End While
            Form1.lst_Gates.SelectedIndex = -1
            If GateSet.Last = ";" Then GateSet = GateSet.Substring(0, GateSet.Length - 1)
            Form1.lst_GateSets.Items.Insert(Form1.lst_GateSets.SelectedIndex, GateSet)
            Form1.lst_GateSets.Items.RemoveAt(Form1.lst_GateSets.SelectedIndex)
            Form1.lst_GateSets.SelectedIndex = Form1.lst_Sublevels.SelectedIndex
        End If
    End Sub
    Private Sub btn_DeleteAllGates_Click(sender As Object, e As EventArgs) Handles btn_DeleteAllGates.Click
        Form1.lst_Gates.Items.Clear()
        lst_GatesNorm.Items.Clear()
        Form1.lst_GateSets.Items.Insert(Form1.lst_GateSets.SelectedIndex, Form1.lst_Sublevel_IDs.SelectedItem & " - ")
        Form1.lst_GateSets.Items.RemoveAt(Form1.lst_GateSets.SelectedIndex)
        Form1.lst_GateSets.SelectedIndex = Form1.lst_Sublevels.SelectedIndex
    End Sub
    Private Sub lnk_GateHelp_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnk_GateHelp.LinkClicked
        MsgBox("Generally, gate health varies from around 1,000 to 10,000. Red Pikmin do 15 damage per hit, Purple's 20, and the rest 10.")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub
End Class