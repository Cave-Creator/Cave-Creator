Public Class ColourButton
    Inherits Button
    Dim faceColour As Color = Color.FromArgb(0, 128, 0)
    Dim rad As Integer = 4
    Public Sub New()
        Me.Size = New Size(120, 34)

        'Me.FlatStyle = FlatStyle.Flat
        'Me.FlatAppearance.BorderSize = 0
        'Me.BackColor = faceColour
        'Me.FlatAppearance.BorderColor = faceColour

        'Me.FlatAppearance.MouseOverBackColor = Color.FromArgb(ra, ga, ba)
        'Me.FlatAppearance.MouseDownBackColor = Color.FromArgb(rb, gb, bb)
        Me.Cursor = Cursors.Hand
        Me.Font = New Font("Trebuchet MS", 10, FontStyle.Regular)
        Me.ForeColor = Color.White
    End Sub
    'Protected Overrides Sub OnPaint(pevent As PaintEventArgs)
    '    'MyBase.OnPaint(pevent)
    '    '
    'End Sub
    Private Sub ColourButton_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim ra = faceColour.R - 12
        Dim ga = faceColour.G - 12
        Dim ba = faceColour.B - 12
        If ra < 0 Then ra = 0
        If ga < 0 Then ga = 0
        If ba < 0 Then ba = 0
        Dim rb = faceColour.R - 24
        Dim gb = faceColour.G - 24
        Dim bb = faceColour.B - 24
        If rb < 0 Then rb = 0
        If gb < 0 Then gb = 0
        If bb < 0 Then bb = 0
        Dim b As New SolidBrush(faceColour)
        If Region IsNot Nothing AndAlso Region.IsVisible(PointToClient(MousePosition)) Then
            If MouseButtons.HasFlag(MouseButtons.Left) Then
                b = New SolidBrush(Color.FromArgb(rb, gb, bb))
            Else
                b = New SolidBrush(Color.FromArgb(ra, ga, ba))
            End If
        End If

        e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
        e.Graphics.InterpolationMode = Drawing2D.InterpolationMode.Bicubic
        e.Graphics.PixelOffsetMode = Drawing2D.PixelOffsetMode.HighQuality
        e.Graphics.FillRectangle(New SolidBrush(Me.BackColor), 0, 0, e.Graphics.ClipBounds.Width, e.Graphics.ClipBounds.Height)
        e.Graphics.FillPath(b, Shapes.getRoundedRectangle(0, 0, e.Graphics.ClipBounds.Width, e.Graphics.ClipBounds.Height, rad))
        e.Graphics.DrawString(Me.Text, Me.Font, New SolidBrush(Me.ForeColor), New Point(e.ClipRectangle.Width / 2 - TextRenderer.MeasureText(Me.Text, Me.Font).Width / 2 + 5, e.Graphics.ClipBounds.Height / 2 - TextRenderer.MeasureText(Me.Text, Me.Font).Height / 2))
        Dim severus = rad - 4
        If severus <= 0 Then
            severus = 1
        End If
        Me.Region = New Region(Shapes.getRoundedRectangle(0, 0, Me.Width, Me.Height, severus))
    End Sub
    'Dim movedIn As Boolean = False
    Private Sub ColourButton_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If Region IsNot Nothing AndAlso Region.IsVisible(e.Location) Then
            Refresh()
            Cursor = Cursors.Hand
            'movedIn = True
        Else
            Refresh()
            Cursor = Cursors.Default
            'movedIn = False
        End If
    End Sub

    Property radius() As Integer
        Get
            Return rad
        End Get
        Set(value As Integer)
            rad = value
        End Set
    End Property
    Property colour() As Color
        Get
            Return faceColour
        End Get
        Set(value As Color)
            faceColour = value
            'Me.BackColor = faceColour
            'Me.FlatAppearance.BorderColor = faceColour
            'Dim ra = faceColour.R - 12
            'Dim ga = faceColour.G - 12
            'Dim ba = faceColour.B - 12
            'If ra < 0 Then ra = 0
            'If ga < 0 Then ga = 0
            'If ba < 0 Then ba = 0
            'Dim rb = faceColour.R - 24
            'Dim gb = faceColour.G - 24
            'Dim bb = faceColour.B - 24
            'If rb < 0 Then rb = 0
            'If gb < 0 Then gb = 0
            'If bb < 0 Then bb = 0
            'Me.FlatAppearance.MouseOverBackColor = Color.FromArgb(ra, ga, ba)
            'Me.FlatAppearance.MouseDownBackColor = Color.FromArgb(rb, gb, bb)
        End Set
    End Property
End Class
