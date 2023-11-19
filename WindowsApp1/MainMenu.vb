Imports System.ComponentModel
Imports System.Globalization
Imports System.Net
Public Class MainMenu
    Dim versionString = "Version " & Application.ProductVersion
    Dim newupdate As Boolean = False
    Dim streamstatus As String
    Dim ticks As Integer = 0
    Public feedbacks As Integer = 0
    Dim tmr As New Timer
    Dim tmr2 As New Timer
    Public CustomDirOptions As New List(Of String)
    Protected Overrides ReadOnly Property CreateParams() As CreateParams        'This fixes the glitchy tabs when there's a background image
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or &H2000000
            Return cp
        End Get
    End Property
    Private Sub btn_New_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub btn_LOAD_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub btn_About_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub ScaleImage(p, i)
        If i.Height > p.Height Then
            Dim diff As Integer = i.Height - p.Height
            Dim Resized As Bitmap = New Bitmap(i, New Size(i.Width - diff, i.Height - diff))
            i = Resized
        End If
        If i.Width > p.Width Then
            Dim diff As Integer = i.Width - p.Width
            Dim Resized As Bitmap = New Bitmap(i, New Size(i.Width - diff, i.Height - diff))
            i = Resized
        End If
    End Sub
    Public Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CultureInfo.DefaultThreadCurrentCulture = New CultureInfo("en-US")
        'CultureInfo.CurrentCulture = New CultureInfo("en-US")
        'Dim data As System.IntPtr = Runtime.InteropServices.Marshal.AllocCoTaskMem(My.Resources.Quicksand_SemiBold.Length - 1)
        'Runtime.InteropServices.Marshal.Copy(My.Resources.Quicksand_SemiBold, 0, data, My.Resources.Quicksand_SemiBold.Length)
        'privateFontCollection.AddMemoryFont(data, My.Resources.Quicksand_SemiBold.Length)
        'Runtime.InteropServices.Marshal.FreeCoTaskMem(data)

        'Label5.Font = New Font(privateFontCollection.Families(0), Label5.Font.Size)

        If System.IO.File.Exists(AppDomain.CurrentDomain.BaseDirectory & "\CCp.bak") Then
            System.IO.File.Delete(AppDomain.CurrentDomain.BaseDirectory & "\CCp.bak")
        End If
        If System.IO.File.Exists(AppDomain.CurrentDomain.BaseDirectory & "\CaveCreator.bak") Then
            System.IO.File.Delete(AppDomain.CurrentDomain.BaseDirectory & "\CaveCreator.bak")
        End If
        If System.IO.File.Exists(AppDomain.CurrentDomain.BaseDirectory & "\CaveCreator_Update.dat") Then
            System.IO.File.Delete(AppDomain.CurrentDomain.BaseDirectory & "\CaveCreator_Update.dat")
        End If
        If System.IO.File.Exists(AppDomain.CurrentDomain.BaseDirectory & "\p2ncc.opt") Then
            System.IO.File.Delete(AppDomain.CurrentDomain.BaseDirectory & "\p2ncc.opt")
        End If



        If IO.File.Exists(AppDomain.CurrentDomain.BaseDirectory & "CaveCreator_CustomDirOptions.data") Then
            Dim cust = IO.File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory & "CaveCreator_CustomDirOptions.data")
            If cust.Count >= 3 Then
                CustomDirOptions.AddRange(IO.File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory & "CaveCreator_CustomDirOptions.data"))
                If cust.Count < 4 Then
                    CustomDirOptions.Add("False")
                    IO.File.WriteAllLines(AppDomain.CurrentDomain.BaseDirectory & "CaveCreator_CustomDirOptions.data", CustomDirOptions)
                End If
            Else
                MessageBox.Show("Couldn't find all 3 custom directory options! Reverting to no custom directory options.", "Cave Creator")
            End If
        End If



        ''''''OPTIONS:
        If My.Computer.FileSystem.FileExists(AppDomain.CurrentDomain.BaseDirectory & "\CCP.data") Then
            Dim OptionsFile As String = My.Computer.FileSystem.ReadAllText(AppDomain.CurrentDomain.BaseDirectory & "\CCP.data")
            Dim wrapper3 As New Simple3Des("hsAJAA%#!HJbhk^&A^&76agiA%$##a&AFAA&*A*GAIha8aF1")
            Dim DecryptedOptionsFile As String = wrapper3.DecryptData(OptionsFile)
            If DecryptedOptionsFile.Contains("defaultroot=") AndAlso CustomDirOptions.Count < 3 Then
                Dim defaultroot As String = DecryptedOptionsFile.Substring(DecryptedOptionsFile.IndexOf("defaultroot="), DecryptedOptionsFile.Length - DecryptedOptionsFile.IndexOf("defaultroot="))
                Dim actualdefaultroot As String = defaultroot.Substring(12, defaultroot.IndexOf("
        ") - 12)
                If Not CustomDirOptions.Count >= 3 Then
                    If Not System.IO.Directory.Exists(actualdefaultroot) Then
                        MsgBox("Your default root directory does not exist.
        Go to the options menu and set the new directory.")
                        Dim beforeDefaultroot As String = DecryptedOptionsFile.Substring(0, DecryptedOptionsFile.IndexOf("defaultroot="))
                        Dim afterDefaultroot As String = defaultroot.Substring(defaultroot.IndexOf("
        "), defaultroot.Length - defaultroot.IndexOf("
        "))
                        Dim NewOptionsFile As String = wrapper3.EncryptData(beforeDefaultroot & vbCrLf & afterDefaultroot)
                        My.Computer.FileSystem.WriteAllText(AppDomain.CurrentDomain.BaseDirectory & "\CCP.data", NewOptionsFile, False)


                    End If
                End If

            End If
            If OptionsFile > "" Then
                Dim wrapper As New Simple3Des("hsAJAA%#!HJbhk^&A^&76agiA%$##a&AFAA&*A*GAIha8aF1")
                OptionsFile = wrapper.DecryptData(OptionsFile)
                If OptionsFile.Substring(0, 7) = Application.ProductVersion Then
                Else
                    OptionsFile = Application.ProductVersion & OptionsFile.Substring(7, OptionsFile.Length - 7)
                    OptionsFile = wrapper.EncryptData(OptionsFile)
                    My.Computer.FileSystem.WriteAllText(AppDomain.CurrentDomain.BaseDirectory & "\CCP.data", OptionsFile, False)
                End If
            Else
                OptionsFile = Application.ProductVersion
                Dim wrapper2 As New Simple3Des("hsAJAA%#!HJbhk^&A^&76agiA%$##a&AFAA&*A*GAIha8aF1")
                OptionsFile = wrapper2.EncryptData(OptionsFile)
                My.Computer.FileSystem.WriteAllText(AppDomain.CurrentDomain.BaseDirectory & "\CCP.data", OptionsFile, False)
            End If
        Else
            Dim OptionsFile As String = Application.ProductVersion
            Dim wrapper2 As New Simple3Des("hsAJAA%#!HJbhk^&A^&76agiA%$##a&AFAA&*A*GAIha8aF1")
            OptionsFile = wrapper2.EncryptData(OptionsFile)
            My.Computer.FileSystem.WriteAllText(AppDomain.CurrentDomain.BaseDirectory & "\CCP.data", OptionsFile, False)
        End If
        Try
            checkForUpdate()

        Catch ex As Exception

        End Try
    End Sub
    Public versionData() As String
    Sub checkForUpdate()
        pic_loading.Visible = True
        Cursor = Cursors.WaitCursor
        btn_checkUpdate.Visible = False
        Try
            Dim wc As New WebClient
            wc.DownloadFileAsync(New Uri("https://docs.google.com/spreadsheets/d/14ytqzcwUYuPhNQhewiNG_UsJuugqbgl0DTSj9vvfoLM/export?format=tsv"),
                AppDomain.CurrentDomain.BaseDirectory & "version.dat")
            AddHandler wc.DownloadFileCompleted, Sub()
                                                     pic_loading.Visible = False
                                                     btn_checkUpdate.Visible = True
                                                     Cursor = Cursors.Default
                                                     If IO.File.Exists(AppDomain.CurrentDomain.BaseDirectory & "version.dat") Then
                                                         'check version
                                                         versionData = IO.File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory & "version.dat")(1).Split(vbTab)

                                                         Try
                                                             IO.File.Delete(AppDomain.CurrentDomain.BaseDirectory & "version.dat")
                                                         Catch ex As Exception

                                                         End Try

                                                         If Application.ProductVersion <> versionData(0) Then
                                                             versionString = "Update Available!"
                                                             Label5.Cursor = Cursors.Hand
                                                             Label5.Refresh()
                                                             If MessageBox.Show("Cave Creator Version " & versionData(0) & " is available!" &
                                                                                vbNewLine & vbNewLine & "Changes:" & vbNewLine & versionData(1).Replace("\n", vbNewLine) &
                                                                                vbNewLine & vbNewLine & "Did you want to update?",
                                                                                "Update Available", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                                                                 UpdatingForm.Show()
                                                                 newupdate = True
                                                                 Me.Hide()
                                                                 Form1.Hide()
                                                                 AboutForm.Hide()
                                                                 OptionsMenu.Hide()
                                                             End If
                                                         Else
                                                             versionString = "Version " & Application.ProductVersion
                                                             Label5.Cursor = Cursors.Default
                                                             Label5.Refresh()
                                                         End If
                                                     Else

                                                     End If
                                                 End Sub
        Catch ex As Exception

        End Try

    End Sub
    Private Sub btn_ToggleMusic_Click(sender As Object, e As EventArgs)
    End Sub
    Dim firstTime = True
    Private Sub MainMenu_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.CenterToScreen()

        If firstTime Then
            firstTime = False
            If My.Application.CommandLineArgs.Count = 1 Then
                If IO.File.Exists(My.Application.CommandLineArgs(0)) Then '
                    Form1.Show()
                    Form1.Select()
                    Form1.btn_ReturnToMainMenu.Enabled = True
                    Hide()
                    Form1.MyFile = My.Application.CommandLineArgs.ToArray
                    Form1.LoadDialog.FileName = Form1.MyFile(0)
                    Form1.DragDroppedData()
                End If
            ElseIf My.Application.CommandLineArgs.Count > 1 Then
                MessageBox.Show("Load a cave:" & vbCrLf & vbCrLf &
                                """Path/to/CaveCreator.exe"" ""your/project/file.p2ncc""" &
                                vbCrLf & "OR" & vbCrLf &
                                """Path/to/CaveCreator.exe"" ""your/cave/text/file.txt""",
                                "Cave Creator - Command Line", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub btn_Options_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MainMenu_DragEnter(sender As Object, e As DragEventArgs) Handles Me.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            Dim filename = e.Data.GetData(DataFormats.FileDrop)(0)
            Dim validExt As Boolean = False
            For Each ext In {"p2ncc", "txt"}
                If filename.ToLower.EndsWith("." & ext.ToLower) Then
                    validExt = True
                    Exit For
                End If
            Next
            If validExt Then
                e.Effect = DragDropEffects.Copy
            Else
                e.Effect = DragDropEffects.None
            End If
        End If
    End Sub

    Private Sub MainMenu_DragDrop(sender As Object, e As DragEventArgs) Handles Me.DragDrop
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            Form1.Show()
            Form1.Select()
            Form1.btn_ReturnToMainMenu.Enabled = True
            Hide()
            Form1.MyFile = e.Data.GetData(DataFormats.FileDrop)
            Form1.LoadDialog.FileName = Form1.MyFile(0)
            Form1.DragDroppedData()
        End If
    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Dim tmr As New Timer
        tmr.Interval = 1
        tmr.Start()
        AddHandler tmr.Tick, Sub()
                                 Me.Select()
                                 Me.Opacity -= 0.16
                                 If Me.Opacity <= 0 Then
                                     tmr.Stop()
                                     Me.Opacity = 0
                                     Me.Close()
                                 End If
                             End Sub
    End Sub
    Public Function ScaleImage(ByVal OldImage As Image, ByVal TargetHeight As Integer) As System.Drawing.Image

        Dim NewHeight As Integer = TargetHeight
        Dim NewWidth As Integer = NewHeight / OldImage.Height * OldImage.Width

        'If NewWidth > TargetWidth Then
        '    NewWidth = TargetWidth
        '    NewHeight = NewWidth / OldImage.Width * OldImage.Height
        'End If

        Return New Bitmap(OldImage, NewWidth, NewHeight)

    End Function
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Form1.Show()
        Form1.Select()
        Form1.btn_ReturnToMainMenu.Enabled = True
        Hide()
    End Sub
    Private Sub PictureBox3_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox3.MouseEnter
        PictureBox3.Image = My.Resources.btn_create_hover
    End Sub
    Private Sub PictureBox3_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox3.MouseLeave
        PictureBox3.Image = My.Resources.btn_create_normal
    End Sub
    Private Sub PictureBox3_Paint(sender As Object, e As PaintEventArgs) Handles PictureBox3.Paint
    End Sub
    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        If (Form1.LoadDialog.ShowDialog() = DialogResult.OK) Then
            Form1.Opacity = 0
            Form1.Show()
            Form1.Hide()
            Form1.LoadCaveFiles()
            Form1.MustBeSavedAs = True
            Dim tmr As New Timer
            tmr.Interval = 1
            tmr.Start()
            AddHandler tmr.Tick, Sub()
                                     Me.Opacity -= 0.028
                                     If Me.Opacity <= 0 Then
                                         tmr.Stop()
                                         Me.Opacity = 0
                                         Me.Size = New Size(568, 381)
                                         Form1.Show()
                                         Me.Hide()
                                         Dim tmr2 As New Timer
                                         tmr2.Interval = 1
                                         tmr2.Start()
                                         AddHandler tmr2.Tick, Sub()
                                                                   Form1.Opacity += 0.028
                                                                   If Form1.Opacity >= 1 Then
                                                                       tmr2.Stop()
                                                                       Form1.Opacity = 1
                                                                       Form1.btn_ReturnToMainMenu.Enabled = True
                                                                       Me.CenterToScreen()
                                                                   End If
                                                               End Sub
                                     End If
                                 End Sub

        End If
    End Sub
    Private Sub PictureBox4_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox4.MouseEnter
        PictureBox4.Image = My.Resources.btn_open_hover
    End Sub
    Private Sub PictureBox4_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox4.MouseLeave
        PictureBox4.Image = My.Resources.btn_open_normal
    End Sub
    Private Sub PictureBox4_Paint(sender As Object, e As PaintEventArgs) Handles PictureBox4.Paint
    End Sub

    Private Sub lbl_Status_Click(sender As Object, e As EventArgs) Handles pic_loading.Click

    End Sub

    Private Sub lbl_Status_Paint(sender As Object, e As PaintEventArgs) Handles pic_loading.Paint
        e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
        e.Graphics.InterpolationMode = Drawing2D.InterpolationMode.Bicubic
        e.Graphics.PixelOffsetMode = Drawing2D.PixelOffsetMode.HighQuality
        e.Graphics.DrawEllipse(New Pen(Color.FromArgb(200, 255, 190), 4), 3, 3, 34, 34)
        e.Graphics.FillEllipse(New SolidBrush(Color.FromArgb(200, 255, 190)), 9, 9, 22, 22)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Hide()
    End Sub
    Private Sub PictureBox1_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox1.MouseEnter
        PictureBox1.Image = My.Resources.btn_cavenet_hover
    End Sub

    Private Sub PictureBox1_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox1.MouseLeave
        PictureBox1.Image = My.Resources.btn_cavenet_normal
    End Sub
    Private Sub PictureBox1_Paint(sender As Object, e As PaintEventArgs) Handles PictureBox1.Paint
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)

    End Sub
    Public privateFontCollection As New Drawing.Text.PrivateFontCollection
    Public FamilyName As String
    Private Sub PictureBox2_Paint(sender As Object, e As PaintEventArgs)

    End Sub
    Public Function ResizeImg(ByVal img As Image, ByVal maxwidth As Integer) As Size
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
    Private Sub PictureBox2_Layout(sender As Object, e As LayoutEventArgs)
        'PictureBox2.Image = New Bitmap(My.Resources.bg_title_1, ResizeImg(My.Resources.bg_title_1, PictureBox2.Width))
    End Sub
    Public Function getRoundedRectangle(ByVal x As Int32, ByVal y As Int32, ByVal width As Int32, ByVal height As Int32, ByVal radius As Int32) As Drawing2D.GraphicsPath
        'Create a rectangle
        Dim area As Rectangle = New Rectangle(x, y, width, height)
        Dim path As Drawing2D.GraphicsPath = New Drawing2D.GraphicsPath
        path.FillMode = Drawing2D.FillMode.Alternate
        'Add the corners
        path.AddArc(area.Left, area.Top, radius * 2, radius * 2, 180, 90) 'Upper-Left
        path.AddArc(area.Right - (radius * 2), area.Top, radius * 2, radius * 2, 270, 90) 'Upper-Right
        path.AddArc(area.Right - (radius * 2), area.Bottom - (radius * 2), radius * 2, radius * 2, 0, 90) 'Lower-Right
        path.AddArc(area.Left, area.Bottom - (radius * 2), radius * 2, radius * 2, 90, 90) 'Lower-Left
        path.CloseAllFigures()
        Return path
    End Function
    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        OptionsMenu.Location = New Point(Me.Location.X + ((Me.Width / 2) - OptionsMenu.Width / 2), Me.Location.Y + ((Me.Height / 2) - OptionsMenu.Height / 2))
        OptionsMenu.ShowDialog()
    End Sub
    Private Sub PictureBox5_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox5.MouseEnter
        PictureBox5.Image = My.Resources.btn_options_hover
    End Sub
    Private Sub PictureBox5_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox5.MouseLeave
        PictureBox5.Image = My.Resources.btn_options_normal
    End Sub
    Private Sub PictureBox5_Paint(sender As Object, e As PaintEventArgs) Handles PictureBox5.Paint
    End Sub
    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
    End Sub
    Private Sub PictureBox6_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox6.MouseEnter
        PictureBox6.Image = My.Resources.btn_discord_hover
    End Sub
    Private Sub PictureBox6_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox6.MouseLeave
        PictureBox6.Image = My.Resources.btn_discord_normal
    End Sub
    Private Sub PictureBox6_Paint(sender As Object, e As PaintEventArgs) Handles PictureBox6.Paint
    End Sub
    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        AboutForm.SetDesktopLocation(Me.Location.X + ((Me.Width / 2) - AboutForm.Width / 2), Me.Location.Y + ((Me.Height / 2) - AboutForm.Height / 2))
        AboutForm.Opacity = 0
        AboutForm.ShowDialog()
    End Sub
    Private Sub PictureBox7_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox7.MouseEnter
        PictureBox7.Image = My.Resources.btn_about_hover
    End Sub
    Private Sub PictureBox7_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox7.MouseLeave
        PictureBox7.Image = My.Resources.btn_about_normal
    End Sub
    Private Sub PictureBox7_Paint(sender As Object, e As PaintEventArgs) Handles PictureBox7.Paint
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        If Label5.Cursor = Cursors.Hand Then
            Label5.Cursor = Cursors.Default
            checkForUpdate()
        End If
    End Sub

    Private Sub Label5_Paint(sender As Object, e As PaintEventArgs) Handles Label5.Paint
        e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
        e.Graphics.InterpolationMode = Drawing2D.InterpolationMode.Bicubic
        e.Graphics.PixelOffsetMode = Drawing2D.PixelOffsetMode.HighQuality
        Dim txtSize = e.Graphics.MeasureString(versionString, sender.font)
        e.Graphics.FillPath(New SolidBrush(Color.FromArgb(200, 255, 190)), getRoundedRectangle(0, 0, txtSize.Width, txtSize.Height - 2, 6))
        e.Graphics.DrawString(versionString, sender.font, New SolidBrush(sender.forecolor), New PointF(0, -2))
    End Sub

    Private Sub btn_checkUpdate_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles btn_checkUpdate.LinkClicked
        checkForUpdate()
    End Sub

    Private Sub MainMenu_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        'e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
        'e.Graphics.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
        'e.Graphics.PixelOffsetMode = Drawing2D.PixelOffsetMode.HighQuality
        'e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias

        Dim fontColor As New SolidBrush(Color.FromArgb(200, 255, 190))

        Dim header As String = "Cave Creator"
        Dim headerFont As New Font("Trebuchet MS", 20, FontStyle.Bold)
        Dim headerWidth = e.Graphics.MeasureString(header, headerFont).Width
        e.Graphics.DrawString(header, headerFont, fontColor, New PointF(ClientSize.Width / 2 - headerWidth / 2, 20))

        'Dim body As String = "Made by "
        'Dim bodyFont As New Font("Trebuchet MS", 12)
        'Dim bodyWidth = e.Graphics.MeasureString(body, bodyFont).Width
        'e.Graphics.DrawString(body, bodyFont, fontColor, New PointF(ClientSize.Width / 2 - bodyWidth / 2, 50))
    End Sub

    Private Sub MainMenu_PaddingChanged(sender As Object, e As EventArgs) Handles Me.PaddingChanged

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("https://github.com/Drought-Ender/Drought-Cave-Creator")
    End Sub
End Class