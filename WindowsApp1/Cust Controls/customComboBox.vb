Public Class customComboBox
    Inherits Panel
    Dim itemsList As String()
    Dim backColourVar As Color = Color.FromArgb(64, 64, 64)
    Dim cmbHeightVar As Integer = 460
    Dim cmb As New ComboBox With {
        .BackColor = Color.FromArgb(64, 64, 64),
        .Font = New Font("Trebuchet MS", 12, FontStyle.Regular),
        .FlatStyle = FlatStyle.Flat,
        .Size = New Size(192, 22),
        .Location = New Point(3, 0),
        .DropDownStyle = ComboBoxStyle.DropDownList,
        .ForeColor = Color.White,
        .DrawMode = DrawMode.OwnerDrawFixed,
        .Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right Or AnchorStyles.Top
    }
    Dim dropArrow As New PictureButton With {
        .Size = New Size(20, 20),
        .RegularImage = My.Resources.Chevron_Down_22px_grey,
        .MouseOverImage = My.Resources.Chevron_Down_22px_white,
        .BackgroundImageLayout = ImageLayout.Center,
        .Location = New Point(175, 0),
        .setBackColour = backColourVar,
        .Anchor = AnchorStyles.Right Or AnchorStyles.Top Or AnchorStyles.Bottom
        }
    Dim topCover As New Panel With {
        .Size = New Size(192, 3),
        .BackColor = backColourVar,
        .Location = New Point(3, 0),
        .Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right}
    Dim leftCover As New Panel With {
        .Size = New Size(3, 28),
        .BackColor = backColourVar,
        .Location = New Point(3, 1),
        .Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Bottom}
    Dim bottomCover As New Panel With {
        .Size = New Size(192, 4),
        .BackColor = backColourVar,
        .Location = New Point(3, 26),
        .Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right}
    Sub dropDown(sender As Object, e As EventArgs)
        cmb.DroppedDown = True
    End Sub
    Sub droppedDown(sender As Object, e As EventArgs)
        cmb.DropDownHeight = cmbHeightVar
    End Sub
    Sub cmb_drawItem(ByVal sender As Object, ByVal e As DrawItemEventArgs)
        If e.Index > -1 Then
            'Manipulating the Item rectangle
            Dim rect As Rectangle = e.Bounds
            If e.State And DrawItemState.Selected Then
                'Modify the Rectangle color...
                If e.State And DrawItemState.ComboBoxEdit Then
                    e.Graphics.FillRectangle(New SolidBrush(Color.FromArgb(64, 64, 64)), rect)
                Else
                    e.Graphics.FillRectangle(New SolidBrush(Color.FromArgb(51, 51, 51)), rect) 'change the selected color you like
                End If

            Else
                'By default the item will be ligthPink background.... not pretty but for showing the example
                e.Graphics.FillRectangle(New SolidBrush(Color.FromArgb(64, 64, 64)), rect)
            End If
            Dim ItemText As String = cmb.Items(e.Index)
            'Draw the text in a black Brush...could be any color
            Dim ItemTextBrush As Brush = Brushes.White
            e.Graphics.DrawString(ItemText, cmb.Font, ItemTextBrush, rect.X, rect.Y)
        End If
    End Sub
    Sub changedIndex(sender As Object, e As EventArgs)
        Me.TabStop = True
        Me.TabStop = False
    End Sub
    Public Sub New()
        Me.Size = New Size(200, 30)
        Me.BorderStyle = BorderStyle.None
        Me.BackColor = backColourVar
        AddHandler dropArrow.Click, AddressOf dropDown
        AddHandler cmb.DrawItem, AddressOf cmb_drawItem
        AddHandler cmb.DropDown, AddressOf droppedDown
        AddHandler cmb.SelectedIndexChanged, AddressOf changedIndex
        Me.Controls.AddRange({bottomCover, topCover, leftCover, dropArrow, cmb})
    End Sub

    Private Sub customComboBox_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        e.Graphics.FillRectangle(New SolidBrush(backColour), DisplayRectangle)
        e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
        e.Graphics.InterpolationMode = Drawing2D.InterpolationMode.Bicubic
        e.Graphics.PixelOffsetMode = Drawing2D.PixelOffsetMode.HighQuality
        e.Graphics.FillPath(New SolidBrush(Color.FromArgb(64, 64, 64)), Shapes.getRoundedRectangle(0, 0, DisplayRectangle.Width, DisplayRectangle.Height, 4))
    End Sub

    Property selectedIndex() As Integer
        Get
            Return cmb.SelectedIndex
        End Get
        Set(value As Integer)
            cmb.SelectedIndex = value
        End Set
    End Property
    Property cmbHeight() As Integer
        Get
            Return cmbHeightVar
        End Get
        Set(value As Integer)
            cmbHeightVar = value
            cmb.DropDownHeight = value
        End Set
    End Property
    Property backColour() As Color
        Get
            Return backColourVar
        End Get
        Set(value As Color)
            backColourVar = value
            Me.BackColor = value
            cmb.BackColor = Color.FromArgb(64, 64, 64)

        End Set
    End Property
    Property items() As String()
        Get
            Return itemsList
        End Get
        Set(value As String())
            itemsList = value
            cmb.Items.Clear()
            If value IsNot Nothing Then
                cmb.Items.AddRange(value)
            End If
        End Set
    End Property
End Class
