Public Class AboutForm
    Private Sub AboutForm_Closing(sender As Object, e As EventArgs) Handles MyBase.Closing
        MainMenu.Enabled = True
        MainMenu.Select()
    End Sub
    Private Sub AboutForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Opacity = 1
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
    End Sub

    Private Sub AboutForm_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Label3.Text = "Version " & Application.ProductVersion
    End Sub
End Class