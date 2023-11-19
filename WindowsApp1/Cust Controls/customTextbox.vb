Public Class customTextbox
    Inherits Panel
    Dim BackColourVar As Color = Color.FromArgb(64, 64, 64)
    Dim textBoxVar As String = "Textbox Text"
    Dim textBoxForeColour As Color = Color.White
    Dim textBox As New TextBox With {
        .AutoSize = False,
        .Anchor = AnchorStyles.Left Or AnchorStyles.Right,
        .Font = New Font("Trebuchet MS", 12, FontStyle.Regular),
        .Size = New Size(300, 22),
        .Location = New Point(4, 6),
        .Text = textBoxVar,
        .BorderStyle = BorderStyle.None
    }
    Dim dontTriggerTabStop As Boolean = False
    Sub txtChanged(sender As Object, e As EventArgs)
        Me.textBoxText = textBox.Text
        If Not dontTriggerTabStop Then
            Me.TabStop = True
            Me.TabStop = False
        End If
    End Sub
    Public Sub New()
        Me.Size = New Size(308, 34)
        Me.BorderStyle = BorderStyle.None
        Me.BackColor = BackColourVar
        Me.Cursor = Cursors.IBeam
        Me.Controls.Add(textBox)
        AddHandler textBox.TextChanged, AddressOf txtChanged
    End Sub
    Property doesntTiggerTabStopChanged() As Boolean
        Get
            Return dontTriggerTabStop
        End Get
        Set(value As Boolean)
            dontTriggerTabStop = value
        End Set
    End Property
    Property backColour() As Color
        Get
            Return BackColourVar
        End Get
        Set(value As Color)
            BackColourVar = value
            textBox.BackColor = Color.FromArgb(64, 64, 64)
            Me.BackColor = value
        End Set
    End Property
    Property textBoxText() As String
        Get
            Return textBoxVar
        End Get
        Set(value As String)
            textBoxVar = value
            textBox.Text = value
        End Set
    End Property
    Property textBoxTextColour() As Color
        Get
            Return textBoxForeColour
        End Get
        Set(value As Color)
            textBoxForeColour = value
            textBox.ForeColor = value
        End Set
    End Property
    Private Sub customTextbox_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        textBox.Select()
        textBox.SelectionStart = textBox.GetCharIndexFromPosition(e.Location)
        textBox.SelectionLength = 0
    End Sub

    Private Sub customTextbox_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        e.Graphics.FillRectangle(New SolidBrush(backColour), DisplayRectangle)
        e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
        e.Graphics.InterpolationMode = Drawing2D.InterpolationMode.Bicubic
        e.Graphics.PixelOffsetMode = Drawing2D.PixelOffsetMode.HighQuality
        e.Graphics.FillPath(New SolidBrush(Color.FromArgb(64, 64, 64)), Shapes.getRoundedRectangle(0, 0, DisplayRectangle.Width, DisplayRectangle.Height, 4))
    End Sub
End Class
