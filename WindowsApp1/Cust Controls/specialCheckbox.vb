Public Class specialCheckbox
    Inherits Panel
    Dim checked As Boolean = False
    Dim lblColour As Color = Color.White
    Dim chk As New PictureBox With {
        .Size = New Size(24, 24),
        .SizeMode = PictureBoxSizeMode.CenterImage,
        .Image = My.Resources.Unchecked_Checkbox_24px_green,
        .Location = New Point(3, 4),
        .Enabled = False
    }
    Dim lbl As New disabledLabel With {
        .AutoSize = True,
        .Location = New Point(30, 6),
        .Font = New Font("Trebuchet MS", 10, FontStyle.Regular),
        .ForeColor = lblColour,
        .DisabledColour = lblColour,
        .Enabled = False
    }
    Public Sub New()
        Me.Size = New Size(310, 34)
        Me.BorderStyle = BorderStyle.None
        Me.Controls.AddRange({chk, lbl})
        Me.Cursor = Cursors.Hand
    End Sub
    Property lblText As String
        Get
            Return lbl.Text
        End Get
        Set(value As String)
            lbl.Text = value
        End Set
    End Property
    Property chkChecked As Boolean
        Get
            Return checked
        End Get
        Set(value As Boolean)
            checked = value
            checkedChanged()
        End Set
    End Property
    Property labelColour As Color
        Get
            Return lblColour
        End Get
        Set(value As Color)
            lblColour = value
            lbl.DisabledColour = value
        End Set
    End Property
    Sub checkedChanged()
        If checked Then
            If Me.Enabled Then
                chk.Image = My.Resources.Checked_Checkbox_24px_green
            Else
                chk.Image = My.Resources.Checked_Checkbox_24px_grey
            End If
        Else
            If Me.Enabled Then
                chk.Image = My.Resources.Unchecked_Checkbox_24px_green
            Else
                chk.Image = My.Resources.Unchecked_Checkbox_24px_grey
            End If
        End If
    End Sub
    Private Sub specialCheckbox_Click(sender As Object, e As EventArgs) Handles Me.Click
        If checked Then
            chkChecked = False
        Else
            chkChecked = True
        End If
    End Sub
    Private Sub specialCheckbox_MouseEnter(sender As Object, e As EventArgs) Handles Me.MouseEnter
        lbl.Font = New Font(lbl.Font, lbl.Font.Style Or FontStyle.Underline)
    End Sub
    Private Sub specialCheckbox_MouseLeave(sender As Object, e As EventArgs) Handles Me.MouseLeave
        lbl.Font = New Font(lbl.Font, lbl.Font.Style And Not FontStyle.Underline)
    End Sub
End Class
