Public Class toggleButtonList
    Inherits Panel
    Dim autoHeight As Boolean = True
    Dim regularColour As Color = Me.BackColor
    Dim checkedColour As Color = Color.Green
    Dim itemHeightVar As Integer = 34
    Dim itemList As String()
    Dim selected As Integer = 0
    Dim fonts As Font = New Font("Trebuchet MS", 10, FontStyle.Regular)
    Dim spacerColour As Color = Color.FromArgb(51, 51, 51)
    Dim txtAlign As ContentAlignment = ContentAlignment.MiddleCenter
    Public Sub New()
        Me.Size = New Size(170, 270)
        Me.BackColor = regularColour
        'Me.BorderStyle = BorderStyle.FixedSingle
    End Sub
    Property textAlign() As ContentAlignment
        Get
            Return txtAlign
        End Get
        Set(value As ContentAlignment)
            txtAlign = value
            For Each ctrl As Object In Me.Controls
                If TypeOf ctrl Is toggleButton Then
                    ctrl.TextAlign = value
                End If
            Next
        End Set
    End Property
    Property separatorColour() As Color
        Get
            Return spacerColour
        End Get
        Set(value As Color)
            spacerColour = value
            For Each ctrl As Object In Me.Controls
                If TypeOf ctrl Is Panel Then
                    ctrl.backcolor = value
                End If
            Next
        End Set
    End Property
    Property backColour() As Color
        Get
            Return regularColour
        End Get
        Set(value As Color)
            regularColour = value
            Me.BackColor = value
            For Each ctrl As Object In Me.Controls
                If TypeOf ctrl Is toggleButton Then
                    ctrl.backColour = value
                End If
            Next
        End Set
    End Property
    Property checkColour() As Color
        Get
            Return checkedColour
        End Get
        Set(value As Color)
            checkedColour = value
            For Each ctrl As Object In Me.Controls
                If TypeOf ctrl Is toggleButton Then
                    ctrl.checkedBackColour = value
                End If
            Next
        End Set
    End Property
    Property itemFont() As Font
        Get
            Return fonts
        End Get
        Set(value As Font)
            fonts = value
            For Each ctrl As Object In Me.Controls
                If TypeOf ctrl Is toggleButton Then
                    ctrl.Font = value
                End If
            Next
        End Set
    End Property
    Property itemHeight() As Integer
        Get
            Return itemHeightVar
        End Get
        Set(value As Integer)
            itemHeightVar = value
            setItems()
        End Set
    End Property
    Sub indexChanged(sender As Object, e As EventArgs)
        Dim index = Me.Controls.IndexOf(sender)
        If Not selectedIndex = index Then
            selectedIndex = index
        End If
    End Sub
    Private Sub toggleButtonList_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
        e.Graphics.InterpolationMode = Drawing2D.InterpolationMode.Bicubic
        e.Graphics.PixelOffsetMode = Drawing2D.PixelOffsetMode.HighQuality
        e.Graphics.DrawPath(New Pen(Color.Silver, 2), Shapes.getRoundedRectangle(2, 2, e.ClipRectangle.Width - 4, e.ClipRectangle.Height - 4, 6))
    End Sub

    Property selectedIndex() As Integer
        Get
            Return selected
        End Get
        Set(value As Integer)
            selected = value
            Dim i As Integer = 0
            For Each ctrl As Object In Me.Controls
                If TypeOf ctrl Is toggleButton Then
                    If i = value Then
                        ctrl.checked = True
                    Else
                        ctrl.checked = False
                    End If
                End If
                i += 1
            Next
            Me.TabStop = True
            Me.TabStop = False
        End Set
    End Property
    Property automaticHeight() As Boolean
        Get
            Return autoHeight
        End Get
        Set(value As Boolean)
            autoHeight = value
        End Set
    End Property
    Sub setItems()
        Me.Controls.Clear()
        If Me.items IsNot Nothing Then
            Dim i As Integer = 0
            For Each item As String In Me.items
                If Not item = " " Then
                    Dim tog As New toggleButton With {.backColour = regularColour, .checkedBackColour = checkedColour,
                                        .Text = item, .Size = New Size(Me.Width - 10, itemHeightVar),
                                        .Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right,
                                        .Location = New Point(5, i * itemHeightVar + 5), .Font = fonts,
                                        .TextAlign = Me.textAlign}
                    If i = Me.selectedIndex Then tog.checked = True
                    AddHandler tog.Click, AddressOf indexChanged
                    Me.Controls.Add(tog)
                Else
                    Dim pnl As New Panel With {.Size = New Size(Me.Width - 4, 2), .BackColor = spacerColour,
                        .Location = New Point(2, (i * itemHeightVar) + (itemHeightVar / 2) - 1)}
                    Me.Controls.Add(pnl)
                End If

                i += 1
            Next
            If Not Me.items.Count = 0 AndAlso Me.automaticHeight Then
                Me.Height = Me.items.Count * itemHeightVar + 10
            End If
        End If
    End Sub

    Private Sub toggleButtonList_ParentChanged(sender As Object, e As EventArgs) Handles Me.ParentChanged

    End Sub

    Property items() As String()
        Get
            Return itemList
        End Get
        Set(value As String())
            itemList = value
            setItems()
        End Set
    End Property
End Class
