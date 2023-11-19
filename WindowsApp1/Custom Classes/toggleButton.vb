Public Class toggleButton
    Inherits Button
    Dim isChecked As Boolean = False
    Dim checkColour As Color = Color.Green
    Dim regularColour As Color = Me.BackColor
    Dim varHoverColour As Color = Color.DimGray
    Dim varDownColour As Color = Color.DimGray
    Dim rad As Integer = 4
    Public Sub New()
        Me.Size = New Size(70, 34)
        'Me.FlatStyle = FlatStyle.Flat
        'Me.FlatAppearance.BorderSize = 0
        'Me.FlatAppearance.BorderColor = Me.BackColor
        'Me.FlatAppearance.MouseOverBackColor = Me.BackColor
        'Me.FlatAppearance.MouseDownBackColor = Me.BackColor
        Me.Cursor = Cursors.Hand
        Me.Font = New Font("Trebuchet MS", 10, FontStyle.Regular)
        Me.ForeColor = Color.White
    End Sub
    Private Sub UnderlinedTextButton_MouseEnter(sender As Object, e As EventArgs) Handles Me.MouseEnter
        If Not Me.isChecked Then
            'Me.Font = New Font(Me.Font, Me.Font.Style Or FontStyle.Underline)
            'Refresh()
        End If
    End Sub
    Private Sub UnderlinedTextButton_MouseLeave(sender As Object, e As EventArgs) Handles Me.MouseLeave
        'Me.Font = New Font(Me.Font, Me.Font.Style And Not FontStyle.Underline)
        'Refresh()
    End Sub
    Private Sub toggleButton_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
        e.Graphics.InterpolationMode = Drawing2D.InterpolationMode.Bicubic
        e.Graphics.PixelOffsetMode = Drawing2D.PixelOffsetMode.HighQuality
        e.Graphics.FillRectangle(New SolidBrush(Me.BackColor), 0, 0, e.Graphics.ClipBounds.Width, e.Graphics.ClipBounds.Height)
        If isChecked Then
            e.Graphics.FillPath(New SolidBrush(Me.checkColour), Shapes.getRoundedRectangle(0, 0, e.Graphics.ClipBounds.Width, e.Graphics.ClipBounds.Height, rad))
        ElseIf Operations.MouseIsOverControl(Me) Then
            If MouseButtons.HasFlag(MouseButtons.Left) Then
                e.Graphics.FillPath(New SolidBrush(downColour), Shapes.getRoundedRectangle(0, 0, e.Graphics.ClipBounds.Width, e.Graphics.ClipBounds.Height, rad))
            Else
                e.Graphics.FillPath(New SolidBrush(hoverColour), Shapes.getRoundedRectangle(0, 0, e.Graphics.ClipBounds.Width, e.Graphics.ClipBounds.Height, rad))
            End If
        Else
            e.Graphics.FillPath(New SolidBrush(Me.regularColour), Shapes.getRoundedRectangle(0, 0, e.Graphics.ClipBounds.Width, e.Graphics.ClipBounds.Height, rad))
        End If
        'If caveCreator.MouseIsOverControl(Me, True) AndAlso Not isChecked Then
        'e.Graphics.DrawString(Me.Text, Me.Font, New SolidBrush(Me.ForeColor), New Point(5, e.Graphics.ClipBounds.Height / 2 - TextRenderer.MeasureText(Me.Text, Me.Font).Height / 2))
        'Else

        Dim textSize = TextRenderer.MeasureText(Me.Text, Me.Font)
        If Me.TextAlign = ContentAlignment.MiddleCenter Then
            e.Graphics.DrawString(Me.Text, Me.Font, New SolidBrush(Me.ForeColor), New Point(Me.Width / 2 - (textSize.Width / 2 - 4),
                                                                                            Me.Height / 2 - textSize.Height / 2))
        Else
            e.Graphics.DrawString(Me.Text, Me.Font, New SolidBrush(Me.ForeColor), New Point(5, Me.Height / 2 - textSize.Height / 2))
        End If
        'End If
    End Sub
    Property hoverColour() As Color
        Get
            Return varHoverColour
        End Get
        Set(value As Color)
            varHoverColour = value
            Refresh()
        End Set
    End Property
    Property downColour() As Color
        Get
            Return varDownColour
        End Get
        Set(value As Color)
            varDownColour = value
            Refresh()
        End Set
    End Property
    Property radius() As Integer
        Get
            Return rad
        End Get
        Set(value As Integer)
            rad = value
        End Set
    End Property
    Property checked() As Boolean
        Get
            Return isChecked
        End Get
        Set(value As Boolean)
            isChecked = value
            'If isChecked Then
            '    Me.BackColor = checkColour
            '    Me.FlatAppearance.BorderColor = checkColour
            '    Me.FlatAppearance.MouseOverBackColor = checkColour
            '    Me.FlatAppearance.MouseDownBackColor = checkColour
            '    Me.Font = New Font(Me.Font, Me.Font.Style And Not FontStyle.Underline)
            'Else
            '    Me.BackColor = regularColour
            '    Me.FlatAppearance.BorderColor = regularColour
            '    Me.FlatAppearance.MouseOverBackColor = regularColour
            '    Me.FlatAppearance.MouseDownBackColor = regularColour
            'End If
        End Set
    End Property
    Property backColour() As Color
        Get
            Return regularColour
        End Get
        Set(value As Color)
            regularColour = value
            If Not isChecked Then
                Me.BackColor = value
                Me.FlatAppearance.BorderColor = value
                Me.FlatAppearance.MouseOverBackColor = value
                Me.FlatAppearance.MouseDownBackColor = value
            End If
        End Set
    End Property
    Property checkedBackColour() As Color
        Get
            Return checkColour
        End Get
        Set(value As Color)
            checkColour = value
            If isChecked Then
                'Me.BackColor = checkColour
                Me.FlatAppearance.BorderColor = value
                Me.FlatAppearance.MouseOverBackColor = value
                Me.FlatAppearance.MouseDownBackColor = value
            End If
        End Set
    End Property
    Private Sub toggleButton_Click(sender As Object, e As EventArgs) Handles Me.Click
        If Not sender.checked Then
            For Each tog As Object In sender.parent.controls
                If TypeOf tog Is toggleButton AndAlso tog IsNot sender AndAlso tog.checked Then
                    tog.checked = False
                    tog.refresh()
                End If
            Next
            Me.checked = True
            Refresh()
        End If
    End Sub
End Class
