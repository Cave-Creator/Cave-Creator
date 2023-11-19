Public Class RegistryTools
    ' Load all of the saved settings.
    Public Shared Sub LoadAllSettings(ByVal app_name As String, ByVal frm As Form)
        ' Load form settings.
        frm.SetBounds( _
            CInt(GetSetting(app_name, "Settings", "FormLeft", frm.Left)), _
            CInt(GetSetting(app_name, "Settings", "FormTop", frm.Top)), _
            CInt(GetSetting(app_name, "Settings", "FormWidth", frm.Width)), _
            CInt(GetSetting(app_name, "Settings", "FormHeight", frm.Height)))

        Dim state As Integer = CInt(GetSetting(app_name, "Settings", "FormWindowState", CInt(frm.WindowState)))
        frm.WindowState = DirectCast(state, FormWindowState)

        ' Load the controls' values.
        LoadChildSettings(app_name, frm)
    End Sub

    ' Load all child control settings.
    Public Shared Sub LoadChildSettings(ByVal app_name As String, ByVal parent As Control)
        For Each child As Control In parent.Controls
            ' Restore the child's value.
            Select Case (child.GetType().Name)
                Case "TextBox", "ComboBox", "Label"
                    child.Text = GetSetting(app_name, "Settings", child.Name, child.Text)

                Case "CheckBox"
                    Dim chk As CheckBox = DirectCast(child, CheckBox)
                    chk.Checked = Boolean.Parse(
                        GetSetting(app_name, "Settings", child.Name, chk.Checked.ToString()))

                Case "VScrollBar"
                    Dim vscr As VScrollBar = DirectCast(child, VScrollBar)
                    vscr.Value = CInt(GetSetting(app_name, "Settings", child.Name, vscr.Value))

                Case "HScrollBar"
                    Dim hscr As HScrollBar = DirectCast(child, HScrollBar)
                    hscr.Value = CInt(GetSetting(app_name, "Settings", child.Name, hscr.Value))

                Case "NumericUpDown"
                    Dim nud As NumericUpDown = DirectCast(child, NumericUpDown)
                    nud.Value = Decimal.Parse(GetSetting(app_name, "Settings", _
                        child.Name, nud.Value).ToString())

                Case "ListBox"
                    Dim lst As ListBox = DirectCast(child, ListBox)

                    ' Load ListBox items.
                    Dim items As String = GetSetting(app_name, "Settings", _
                        child.Name + ".Items", "").ToString()
                    If (items.Length > 0) Then
                        lst.Items.Clear()
                        Dim separators() As Char = {";"c}
                        For Each item As String In items.Split( _
                                separators, StringSplitOptions.RemoveEmptyEntries)
                            lst.Items.Add(item)
                        Next item
                    End If

                    child.Text = GetSetting(app_name, "Settings", child.Name, child.Text)

                    ' Add other control types here.
            End Select

            ' Recursively restore the child's children.
            LoadChildSettings(app_name, child)
        Next child
    End Sub

    ' Save all of the form's settings.
    Public Shared Sub SaveAllSettings(ByVal app_name As String, ByVal frm As Form)
        ' Save form settings.
        SaveSetting(app_name, "Settings", "FormWindowState", CInt(frm.WindowState))

        If (frm.WindowState = FormWindowState.Normal) Then
            ' Save current bounds.
            SaveSetting(app_name, "Settings", "FormLeft", frm.Left)
            SaveSetting(app_name, "Settings", "FormTop", frm.Top)
            SaveSetting(app_name, "Settings", "FormWidth", frm.Width)
            SaveSetting(app_name, "Settings", "FormHeight", frm.Height)
        Else
            ' Save bounds when we're restored.
            SaveSetting(app_name, "Settings", "FormLeft", frm.RestoreBounds.Left)
            SaveSetting(app_name, "Settings", "FormTop", frm.RestoreBounds.Top)
            SaveSetting(app_name, "Settings", "FormWidth", frm.RestoreBounds.Width)
            SaveSetting(app_name, "Settings", "FormHeight", frm.RestoreBounds.Height)
        End If

        ' Save the controls' values.
        SaveChildSettings(app_name, frm)
    End Sub

    ' Save all child control settings.
    Public Shared Sub SaveChildSettings(ByVal app_name As String, ByVal parent As Control)
        For Each child As Control In parent.Controls
            ' Save the child's value.
            Console.WriteLine(child.GetType().Name) '@

            Select Case (child.GetType().Name)
                Case "TextBox", "ComboBox", "Label"
                    SaveSetting(app_name, "Settings", child.Name, child.Text)

                Case "CheckBox"
                    Dim chk As CheckBox = DirectCast(child, CheckBox)
                    SaveSetting(app_name, "Settings", child.Name, chk.Checked.ToString())

                Case "VScrollBar"
                    Dim vscr As VScrollBar = DirectCast(child, VScrollBar)
                    SaveSetting(app_name, "Settings", child.Name, vscr.Value)

                Case "HScrollBar"
                    Dim hscr As HScrollBar = DirectCast(child, HScrollBar)
                    SaveSetting(app_name, "Settings", child.Name, hscr.Value)

                Case "NumericUpDown"
                    Dim nud As NumericUpDown = DirectCast(child, NumericUpDown)
                    SaveSetting(app_name, "Settings", child.Name, nud.Value)

                Case "ListBox"
                    Dim lst As ListBox = DirectCast(child, ListBox)

                    ' Save ListBox items.
                    Dim items As String = ""
                    For Each item As String In lst.Items
                        items += item + ";"
                    Next item
                    SaveSetting(app_name, "Settings", child.Name + ".Items", items)

                    SaveSetting(app_name, "Settings", child.Name, child.Text)

                    ' Add other control types here.
            End Select


            ' Recursively save the child's children.
            SaveChildSettings(app_name, child)
        Next child
    End Sub
End Class
