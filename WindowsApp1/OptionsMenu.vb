Imports System.ComponentModel

Public Class OptionsMenu
    Dim Options As String = Application.ProductVersion
    Dim SaveClose As Boolean = True
    Dim ChangesMade As Boolean = False
    Private Sub btn_LoadRoot_Click(sender As Object, e As EventArgs) Handles btn_LoadRoot.Click
        If (Form1.RootBrowserDialog.ShowDialog() = DialogResult.OK) Then
            If System.IO.File.Exists(Form1.RootBrowserDialog.SelectedPath & "\&&systemdata\Start.dol") Then
                If System.IO.Directory.Exists(Form1.RootBrowserDialog.SelectedPath & "\user\Mukki\mapunits\caveinfo") Then
                    txt_RootDirectory.Text = Form1.RootBrowserDialog.SelectedPath

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
defaultroot=" & Form1.RootBrowserDialog.SelectedPath & "
" & AfterPreviousDefaultRoot
                        Else
                            OptionsFile = OptionsFile & "
defaultroot=" & Form1.RootBrowserDialog.SelectedPath & "
"
                        End If
                        Dim wrapper2 As New Simple3Des("hsAJAA%#!HJbhk^&A^&76agiA%$##a&AFAA&*A*GAIha8aF1")
                        OptionsFile = wrapper2.EncryptData(OptionsFile)
                        My.Computer.FileSystem.WriteAllText(AppDomain.CurrentDomain.BaseDirectory & "\CCP.data", OptionsFile, False)

                    Else

                        Dim OptionsFile As String = Application.ProductVersion & "
defaultroot=" & Form1.RootBrowserDialog.SelectedPath & "
"
                        Dim wrapper2 As New Simple3Des("hsAJAA%#!HJbhk^&A^&76agiA%$##a&AFAA&*A*GAIha8aF1")
                        OptionsFile = wrapper2.EncryptData(OptionsFile)
                        My.Computer.FileSystem.WriteAllText(AppDomain.CurrentDomain.BaseDirectory & "\CCP.data", OptionsFile, False)
                    End If

                    MainMenu.CustomDirOptions.Clear()
                    If IO.File.Exists(AppDomain.CurrentDomain.BaseDirectory & "CaveCreator_CustomDirOptions.data") Then
                        IO.File.Delete(AppDomain.CurrentDomain.BaseDirectory & "CaveCreator_CustomDirOptions.data")
                    End If
                    Form1.RootDirectory = Form1.RootBrowserDialog.SelectedPath
                    Form1.txt_RootDirectory.Text = Form1.RootDirectory
                    Form1.btn_ImportCave.Enabled = True
                Else
                    MsgBox("Caveinfo was not found, please make sure you extracted your whole ISO and then try again.")
                End If
            Else
                MsgBox("Start.dol was not found, please make sure you extracted your whole ISO and then try again.")
            End If
        End If
    End Sub
    Private Sub btn_SaveOptions_Click(sender As Object, e As EventArgs) 'Handles btn_SaveOptions.Click
        If txt_RootDirectory.Text = "" Then
        Else
            If System.IO.File.Exists(AppDomain.CurrentDomain.BaseDirectory & "\p2ccp.opt") Then
            Else
                MsgBox("p2ccp.opt not found, and thus it will be created.")
            End If
            Dim wrapper As New Simple3Des("hsAJAA%#!HJbhk^&A^&76agiA%$##a&AFAA&*A*GAIha8aF1")
            Options = wrapper.EncryptData(Options)
            My.Computer.FileSystem.WriteAllText(AppDomain.CurrentDomain.BaseDirectory & "\p2ccp.opt", Options, False)
            Form1.RootDirectory = Form1.RootBrowserDialog.SelectedPath
            Form1.txt_RootDirectory.Text = Form1.RootDirectory
            Form1.pnl_Controls.Enabled = True
        End If
        ChangesMade = False
        Me.Close()
    End Sub

    Private Sub OptionsMenu_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If ChangesMade = True Then
            Dim result As Integer = MessageBox.Show("Save changes?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            If result = DialogResult.No Then
                txt_RootDirectory.Text = ""
                ChangesMade = False
                Me.Close()
            Else
                If txt_RootDirectory.Text = "" Then
                Else
                    If System.IO.File.Exists(AppDomain.CurrentDomain.BaseDirectory & "\p2ccp.opt") Then
                    Else
                        MsgBox("p2ccp.opt not found, and thus it will be created.")
                    End If
                    Dim wrapper As New Simple3Des("hsAJAA%#!HJbhk^&A^&76agiA%$##a&AFAA&*A*GAIha8aF1")
                    Options = wrapper.EncryptData(Options)
                    My.Computer.FileSystem.WriteAllText(AppDomain.CurrentDomain.BaseDirectory & "\p2ccp.opt", Options, False)
                    Form1.RootDirectory = Form1.RootBrowserDialog.SelectedPath
                    Form1.txt_RootDirectory.Text = Form1.RootDirectory
                    Form1.pnl_Controls.Enabled = True
                End If
                ChangesMade = False
                Me.Close()
            End If
        End If
    End Sub

    Private Sub OptionsMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If System.IO.File.Exists(AppDomain.CurrentDomain.BaseDirectory & "\CCP.data") Then
            Dim OptionsFile As String = My.Computer.FileSystem.ReadAllText(AppDomain.CurrentDomain.BaseDirectory & "\CCP.data")
            Dim wrapper As New Simple3Des("hsAJAA%#!HJbhk^&A^&76agiA%$##a&AFAA&*A*GAIha8aF1")
            OptionsFile = wrapper.DecryptData(OptionsFile)
            If OptionsFile.Contains("defaultroot=") Then
                Dim BeforePreviousDefaultRoot As String = OptionsFile.Substring(OptionsFile.IndexOf("defaultroot=") + 12, OptionsFile.Length - (OptionsFile.IndexOf("defaultroot=") + 12))
                Dim DefaultRoot As String = BeforePreviousDefaultRoot.Substring(0, BeforePreviousDefaultRoot.IndexOf("
"))
                txt_RootDirectory.Text = DefaultRoot
            End If
            If OptionsFile.Contains("autosave=") Then
                Dim BeforePreviousDefaultRoot As String = OptionsFile.Substring(OptionsFile.IndexOf("autosave=") + 9, OptionsFile.Length - (OptionsFile.IndexOf("autosave=") + 9))
                Dim AutosaveValue As String = BeforePreviousDefaultRoot.Substring(0, BeforePreviousDefaultRoot.IndexOf("
"))
                If AutosaveValue = "true" Then
                    chk_Autosave.Checked = True
                    cmb_Autosave.Enabled = True
                ElseIf AutosaveValue = "false" Then
                    chk_Autosave.Checked = False
                End If
            End If
            If OptionsFile.Contains("asmode=") Then
                Dim BeforePreviousDefaultRoot As String = OptionsFile.Substring(OptionsFile.IndexOf("asmode=") + 7, OptionsFile.Length - (OptionsFile.IndexOf("asmode=") + 7))
                Dim AutosaveMode As String = BeforePreviousDefaultRoot.Substring(0, BeforePreviousDefaultRoot.IndexOf("
"))
                Select Case AutosaveMode
                    Case "0"
                        cmb_Autosave.SelectedIndex = 0
                    Case "1"
                        cmb_Autosave.SelectedIndex = 1
                    Case "2"
                        cmb_Autosave.SelectedIndex = 2
                    Case "3"
                        cmb_Autosave.SelectedIndex = 3
                End Select
            Else
                cmb_Autosave.SelectedIndex = 0
            End If
            If OptionsFile.Contains("doubleclick=") Then
                Dim BeforePreviousDefaultRoot As String = OptionsFile.Substring(OptionsFile.IndexOf("doubleclick=") + 12, OptionsFile.Length - (OptionsFile.IndexOf("doubleclick=") + 12))
                Dim DoubleClickMode As String = BeforePreviousDefaultRoot.Substring(0, BeforePreviousDefaultRoot.IndexOf("
"))
                Select Case DoubleClickMode
                    Case "0"
                        cmb_DoubleClickSublevel.SelectedIndex = 0
                    Case "1"
                        cmb_DoubleClickSublevel.SelectedIndex = 1
                    Case "2"
                        cmb_DoubleClickSublevel.SelectedIndex = 2
                    Case "3"
                        cmb_DoubleClickSublevel.SelectedIndex = 3
                End Select
            Else
                cmb_DoubleClickSublevel.SelectedIndex = 0
            End If


        End If
    End Sub
    Private Sub btn_CancelOptions_Click(sender As Object, e As EventArgs) Handles btn_CancelOptions.Click
        ChangesMade = False
        txt_RootDirectory.Text = ""
        Me.Close()
    End Sub

    Private Sub btn_Reset_Click(sender As Object, e As EventArgs) Handles btn_Reset.Click
        Dim OptionsFile As String = Application.ProductVersion
        Dim wrapper As New Simple3Des("hsAJAA%#!HJbhk^&A^&76agiA%$##a&AFAA&*A*GAIha8aF1")
        OptionsFile = wrapper.EncryptData(OptionsFile)
        My.Computer.FileSystem.WriteAllText(AppDomain.CurrentDomain.BaseDirectory & "\CCP.data", OptionsFile, False)
        txt_RootDirectory.Text = ""
        cmb_Autosave.SelectedIndex = 0
        chk_Autosave.Checked = False
        cmb_Autosave.Enabled = False
        cmb_DoubleClickSublevel.SelectedIndex = 0

        MainMenu.CustomDirOptions.Clear()
        If IO.File.Exists(AppDomain.CurrentDomain.BaseDirectory & "CaveCreator_CustomDirOptions.data") Then
            IO.File.Delete(AppDomain.CurrentDomain.BaseDirectory & "CaveCreator_CustomDirOptions.data")
        End If
    End Sub

    Private Sub btn_CheckForUpdates_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub chk_Autosave_OnValueChange(sender As Object, e As EventArgs) Handles chk_Autosave.CheckedChanged
        Dim AutosaveValue As String
        If chk_Autosave.Checked = True Then
            'If Form1.MustBeSavedAs = True Then MsgBox("Keep in mind that autosaving won't occur until you've saved the project file at least once.")
            cmb_Autosave.Enabled = True
            AutosaveValue = "true"
            Form1.tmr_Autosave.Enabled = True
        Else
            cmb_Autosave.SelectedIndex = 0
            cmb_Autosave.Enabled = False
            AutosaveValue = "false"
            Form1.tmr_Autosave.Enabled = False
        End If
        If My.Computer.FileSystem.FileExists(AppDomain.CurrentDomain.BaseDirectory & "\CCP.data") Then
            Dim OptionsFile As String = My.Computer.FileSystem.ReadAllText(AppDomain.CurrentDomain.BaseDirectory & "\CCP.data")
            Dim wrapper As New Simple3Des("hsAJAA%#!HJbhk^&A^&76agiA%$##a&AFAA&*A*GAIha8aF1")
            OptionsFile = wrapper.DecryptData(OptionsFile)
            If OptionsFile.Contains("autosave=") Then
                Dim BeforePreviousDefaultRoot As String = OptionsFile.Substring(0, OptionsFile.IndexOf("autosave="))
                Dim AutosaveLine As String = OptionsFile.Substring(OptionsFile.IndexOf("autosave="), OptionsFile.Length - OptionsFile.IndexOf("autosave="))
                Dim AfterPreviousDefaultRoot As String = AutosaveLine.Substring(AutosaveLine.IndexOf("
"), AutosaveLine.Length - AutosaveLine.IndexOf("
"))
                OptionsFile = BeforePreviousDefaultRoot & "
autosave=" & AutosaveValue & "
" & AfterPreviousDefaultRoot
            Else
                OptionsFile = OptionsFile & "
autosave=" & AutosaveValue & "
"
            End If
            Dim wrapper2 As New Simple3Des("hsAJAA%#!HJbhk^&A^&76agiA%$##a&AFAA&*A*GAIha8aF1")
            OptionsFile = wrapper2.EncryptData(OptionsFile)
            My.Computer.FileSystem.WriteAllText(AppDomain.CurrentDomain.BaseDirectory & "\CCP.data", OptionsFile, False)

        Else

            Dim OptionsFile As String = Application.ProductVersion & "
autosave=" & AutosaveValue & "
"
            Dim wrapper2 As New Simple3Des("hsAJAA%#!HJbhk^&A^&76agiA%$##a&AFAA&*A*GAIha8aF1")
            OptionsFile = wrapper2.EncryptData(OptionsFile)
            My.Computer.FileSystem.WriteAllText(AppDomain.CurrentDomain.BaseDirectory & "\CCP.data", OptionsFile, False)
        End If
    End Sub
    Private Sub cmb_Autosave_onItemSelected(sender As Object, e As EventArgs) Handles cmb_Autosave.SelectedIndexChanged
        Dim AutosaveMode As String = cmb_Autosave.SelectedIndex.ToString

        Select Case AutosaveMode
            Case "0"
                Form1.tmr_Autosave.Interval = 1800000
            Case "1"
                Form1.tmr_Autosave.Interval = 600000
            Case "2"
                Form1.tmr_Autosave.Interval = 300000
            Case "3"
                Form1.tmr_Autosave.Interval = 60000
        End Select


        If My.Computer.FileSystem.FileExists(AppDomain.CurrentDomain.BaseDirectory & "\CCP.data") Then
            Dim OptionsFile As String = My.Computer.FileSystem.ReadAllText(AppDomain.CurrentDomain.BaseDirectory & "\CCP.data")
            Dim wrapper As New Simple3Des("hsAJAA%#!HJbhk^&A^&76agiA%$##a&AFAA&*A*GAIha8aF1")
            OptionsFile = wrapper.DecryptData(OptionsFile)
            If OptionsFile.Contains("asmode=") Then
                Dim BeforePreviousDefaultRoot As String = OptionsFile.Substring(0, OptionsFile.IndexOf("asmode="))
                Dim AutomodeLine As String = OptionsFile.Substring(OptionsFile.IndexOf("asmode="), OptionsFile.Length - OptionsFile.IndexOf("asmode="))
                Dim AfterPreviousDefaultRoot As String = AutomodeLine.Substring(AutomodeLine.IndexOf("
"), AutomodeLine.Length - AutomodeLine.IndexOf("
"))
                OptionsFile = BeforePreviousDefaultRoot & "
asmode=" & AutosaveMode & "
" & AfterPreviousDefaultRoot
            Else

                OptionsFile = OptionsFile & "
asmode=" & AutosaveMode & "
"
            End If
            Dim wrapper2 As New Simple3Des("hsAJAA%#!HJbhk^&A^&76agiA%$##a&AFAA&*A*GAIha8aF1")
            OptionsFile = wrapper2.EncryptData(OptionsFile)
            My.Computer.FileSystem.WriteAllText(AppDomain.CurrentDomain.BaseDirectory & "\CCP.data", OptionsFile, False)

        Else

            Dim OptionsFile As String = Application.ProductVersion & "
asmode=" & AutosaveMode & "
"
            Dim wrapper2 As New Simple3Des("hsAJAA%#!HJbhk^&A^&76agiA%$##a&AFAA&*A*GAIha8aF1")
            OptionsFile = wrapper2.EncryptData(OptionsFile)
            My.Computer.FileSystem.WriteAllText(AppDomain.CurrentDomain.BaseDirectory & "\CCP.data", OptionsFile, False)
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_DoubleClickSublevel.SelectedIndexChanged
        Dim DoubleClickMode As String = cmb_DoubleClickSublevel.SelectedIndex.ToString

        Form1.DoubleClickMode = cmb_DoubleClickSublevel.SelectedIndex


        If My.Computer.FileSystem.FileExists(AppDomain.CurrentDomain.BaseDirectory & "\CCP.data") Then
            Dim OptionsFile As String = My.Computer.FileSystem.ReadAllText(AppDomain.CurrentDomain.BaseDirectory & "\CCP.data")
            Dim wrapper As New Simple3Des("hsAJAA%#!HJbhk^&A^&76agiA%$##a&AFAA&*A*GAIha8aF1")
            OptionsFile = wrapper.DecryptData(OptionsFile)
            If OptionsFile.Contains("doubleclick=") Then
                Dim BeforePreviousDefaultRoot As String = OptionsFile.Substring(0, OptionsFile.IndexOf("doubleclick="))
                Dim AutomodeLine As String = OptionsFile.Substring(OptionsFile.IndexOf("doubleclick="), OptionsFile.Length - OptionsFile.IndexOf("doubleclick="))
                Dim AfterPreviousDefaultRoot As String = AutomodeLine.Substring(AutomodeLine.IndexOf("
"), AutomodeLine.Length - AutomodeLine.IndexOf("
"))
                OptionsFile = BeforePreviousDefaultRoot & "
doubleclick=" & DoubleClickMode & "
" & AfterPreviousDefaultRoot
            Else

                OptionsFile = OptionsFile & "
doubleclick=" & DoubleClickMode & "
"
            End If
            Dim wrapper2 As New Simple3Des("hsAJAA%#!HJbhk^&A^&76agiA%$##a&AFAA&*A*GAIha8aF1")
            OptionsFile = wrapper2.EncryptData(OptionsFile)
            My.Computer.FileSystem.WriteAllText(AppDomain.CurrentDomain.BaseDirectory & "\CCP.data", OptionsFile, False)

        Else

            Dim OptionsFile As String = Application.ProductVersion & "
doubleclick=" & DoubleClickMode & "
"
            Dim wrapper2 As New Simple3Des("hsAJAA%#!HJbhk^&A^&76agiA%$##a&AFAA&*A*GAIha8aF1")
            OptionsFile = wrapper2.EncryptData(OptionsFile)
            My.Computer.FileSystem.WriteAllText(AppDomain.CurrentDomain.BaseDirectory & "\CCP.data", OptionsFile, False)
        End If
    End Sub
    Private Sub btn_OK_Click(sender As Object, e As EventArgs) Handles btn_OK.Click
        Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CustomDirectoryOptions.txtCaves.Text = ""
        CustomDirectoryOptions.txtChallenge.Text = ""
        CustomDirectoryOptions.txtMusic.Text = ""
        If MainMenu.CustomDirOptions.Count >= 3 Then
            CustomDirectoryOptions.txtCaves.Text = MainMenu.CustomDirOptions(0)
            CustomDirectoryOptions.txtChallenge.Text = MainMenu.CustomDirOptions(1)
            CustomDirectoryOptions.txtMusic.Text = MainMenu.CustomDirOptions(2)
            If MainMenu.CustomDirOptions.Count >= 4 AndAlso MainMenu.CustomDirOptions(3) = "True" Then CustomDirectoryOptions.chk_restructured.Checked = True Else CustomDirectoryOptions.chk_restructured.Checked = False
        End If
        CustomDirectoryOptions.Location = New Point(Me.Location.X + ((Me.Width / 2) - CustomDirectoryOptions.Width / 2), Me.Location.Y + ((Me.Height / 2) - CustomDirectoryOptions.Height / 2))
        CustomDirectoryOptions.ShowDialog()
    End Sub
End Class