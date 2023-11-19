Public Class UnderlinedTextButton
    Inherits Button
    Public Sub New()
        Me.Size = New Size(70, 34)
        Me.FlatStyle = FlatStyle.Flat
        Me.FlatAppearance.BorderSize = 0
        Me.FlatAppearance.BorderColor = Me.BackColor
        Me.FlatAppearance.MouseOverBackColor = Me.BackColor
        Me.FlatAppearance.MouseDownBackColor = Me.BackColor
        Me.Cursor = Cursors.Hand
        Me.Font = New Font("Trebuchet MS", 10, FontStyle.Regular)
        Me.ForeColor = Color.White
    End Sub
    Private Sub UnderlinedTextButton_MouseEnter(sender As Object, e As EventArgs) Handles Me.MouseEnter
        Me.Font = New Font(Me.Font, Me.Font.Style Or FontStyle.Underline)
    End Sub
    Private Sub UnderlinedTextButton_MouseLeave(sender As Object, e As EventArgs) Handles Me.MouseLeave
        Me.Font = New Font(Me.Font, Me.Font.Style And Not FontStyle.Underline)
    End Sub
End Class
