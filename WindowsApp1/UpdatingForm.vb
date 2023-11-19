Imports System.ComponentModel
Imports System.Net
Public Class UpdatingForm
    Dim wc As New WebClient()
    Dim FinalFilename As String = "Cave Creator.exe"
    Private Sub UpdatingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Select()
        lbl_Bytes.Text = ""
        lbl_Status.Location = New Point(610 - lbl_Status.Width, lbl_Status.Location.Y)

        If MainMenu.versionData(2).Length > 0 Then FinalFilename = MainMenu.versionData(2)

        Try
            AddHandler wc.DownloadProgressChanged, AddressOf UpdateDownloadProgress
            AddHandler wc.DownloadFileCompleted, AddressOf updateDownloaded
            wc.DownloadFileAsync(New Uri("https://www.dropbox.com/s/b8qnvq2faewbw4f/Cave%20Creator.exe?dl=1"),
                                 AppDomain.CurrentDomain.BaseDirectory & "\CaveCreator_Update.dat")
        Catch
            MsgBox("Please check your network connection.")
            Application.Exit()
        End Try


    End Sub
    Sub updateDownloaded(sender As Object, e As AsyncCompletedEventArgs)
        Dim cancelDelete As Boolean = False
        While IO.File.Exists(AppDomain.CurrentDomain.BaseDirectory & "\CaveCreator.bak") AndAlso Not cancelDelete
            Try
                IO.File.Delete(AppDomain.CurrentDomain.BaseDirectory & "\CaveCreator.bak")
            Catch ex As Exception
                If MessageBox.Show("Uh oh... I need to overwrite the file 'CaveCreator.bak' in order to update, but I couldn't... " &
                                "Please make sure the file isn't open in any other applications.", "Error",
                                MessageBoxButtons.RetryCancel) = DialogResult.Cancel Then cancelDelete = True
            End Try
        End While
        If Not cancelDelete Then
            System.IO.File.Move(Application.ExecutablePath, AppDomain.CurrentDomain.BaseDirectory & "\CaveCreator.bak")
            System.IO.File.Copy(AppDomain.CurrentDomain.BaseDirectory & "\CaveCreator_Update.dat", AppDomain.CurrentDomain.BaseDirectory & "\" & FinalFilename, True)
            System.IO.File.Delete(AppDomain.CurrentDomain.BaseDirectory & "\CaveCreator_Update.dat")
            'MsgBox(Application.ExecutablePath)
            Process.Start(AppDomain.CurrentDomain.BaseDirectory & "\" & FinalFilename)
        End If

        Application.Exit()
    End Sub
    Private Sub UpdateDownloadProgress(ByVal sender As Object, ByVal e As DownloadProgressChangedEventArgs)
        Try
            lbl_Bytes.Text = (e.BytesReceived / 1024D / 1024D).ToString("0.00") & "MB's downloaded"
            lbl_Bytes.Location = New Point(610 - lbl_Bytes.Width, lbl_Bytes.Location.Y)
        Catch
            MsgBox("Please check your network connection.")
            Application.Exit()
        End Try
    End Sub
End Class
