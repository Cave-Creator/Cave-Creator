Public Class CustomDirectoryOptions
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If txtCaves.Text.Length > 0 AndAlso txtChallenge.Text.Length > 0 AndAlso txtMusic.Text.Length > 0 Then
            IO.File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory & "CaveCreator_CustomDirOptions.data", txtCaves.Text &
                                 If(txtCaves.Text.EndsWith("\"), "", "\") & vbCrLf & txtChallenge.Text & If(txtChallenge.Text.EndsWith("\"), "", "\") & vbCrLf & txtMusic.Text & If(txtMusic.Text.EndsWith("\"), "", "\") & vbCrLf & chk_restructured.Checked.ToString())


            'disgusting options file writing
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
defaultroot=" & "Using Custom Directory Options!" & "
" & AfterPreviousDefaultRoot
                Else
                    OptionsFile = OptionsFile & "
defaultroot=" & "Using Custom Directory Options!" & "
"
                End If
                Dim wrapper2 As New Simple3Des("hsAJAA%#!HJbhk^&A^&76agiA%$##a&AFAA&*A*GAIha8aF1")
                OptionsFile = wrapper2.EncryptData(OptionsFile)
                My.Computer.FileSystem.WriteAllText(AppDomain.CurrentDomain.BaseDirectory & "\CCP.data", OptionsFile, False)

            Else

                Dim OptionsFile As String = Application.ProductVersion & "
defaultroot=" & "Using Custom Directory Options!" & "
"
                Dim wrapper2 As New Simple3Des("hsAJAA%#!HJbhk^&A^&76agiA%$##a&AFAA&*A*GAIha8aF1")
                OptionsFile = wrapper2.EncryptData(OptionsFile)
                My.Computer.FileSystem.WriteAllText(AppDomain.CurrentDomain.BaseDirectory & "\CCP.data", OptionsFile, False)
            End If
            'end disgust

            OptionsMenu.txt_RootDirectory.Text = "Using Custom Directory Options!"
            Form1.txt_RootDirectory.Text = "Using Custom Directory Options!"


            MainMenu.CustomDirOptions.Clear()
            MainMenu.CustomDirOptions.AddRange(IO.File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory & "CaveCreator_CustomDirOptions.data"))

            Close()

        Else
            MessageBox.Show("You must fill in all the directories!", "Custom Directory Options")
        End If
    End Sub
    Private Sub btn_LoadRoot_Click(sender As Object, e As EventArgs) Handles btn_LoadRoot.Click
        Dim browser As New Microsoft.WindowsAPICodePack.Dialogs.CommonOpenFileDialog
        browser.IsFolderPicker = True
        If browser.ShowDialog() = Microsoft.WindowsAPICodePack.Dialogs.CommonFileDialogResult.Ok Then
            txtCaves.Text = browser.FileName
        End If
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        txtCaves.Text = ""
        txtChallenge.Text = ""
        txtMusic.Text = ""
        Close()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim browser As New Microsoft.WindowsAPICodePack.Dialogs.CommonOpenFileDialog
        browser.IsFolderPicker = True
        If browser.ShowDialog() = Microsoft.WindowsAPICodePack.Dialogs.CommonFileDialogResult.Ok Then
            txtChallenge.Text = browser.FileName
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim browser As New Microsoft.WindowsAPICodePack.Dialogs.CommonOpenFileDialog
        browser.IsFolderPicker = True
        If browser.ShowDialog() = Microsoft.WindowsAPICodePack.Dialogs.CommonFileDialogResult.Ok Then
            txtMusic.Text = browser.FileName
        End If
    End Sub

    Private Sub CustomDirectoryOptions_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class