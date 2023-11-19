Public Class PictureButton
    Inherits Button
    Dim RegularPicture As Image
    Dim MouseOverPicture As Image
    Dim DisabledPicture As Image
    Dim BackColour As Color = Me.BackColor
    Public Sub New()
        Me.Size = New Size(24, 24)
        Me.FlatStyle = FlatStyle.Flat
        Me.FlatAppearance.BorderSize = 0
        Me.FlatAppearance.BorderColor = Me.BackColour
        Me.FlatAppearance.MouseOverBackColor = Me.BackColour
        Me.FlatAppearance.MouseDownBackColor = Me.BackColour
        Me.Cursor = Cursors.Hand
    End Sub
    Property setBackColour() As Color
        Get
            Return BackColour
        End Get
        Set(value As Color)
            BackColour = value
            Me.BackColor = value
            Me.FlatAppearance.BorderColor = value
            Me.FlatAppearance.MouseOverBackColor = value
            Me.FlatAppearance.MouseDownBackColor = value
        End Set
    End Property
    Property MouseOverImage() As Image
        Get
            Return MouseOverPicture
        End Get
        Set(value As Image)
            MouseOverPicture = value
        End Set
    End Property
    Property RegularImage() As Image
        Get
            Return RegularPicture
        End Get
        Set(value As Image)
            RegularPicture = value
            BackgroundImage = value
        End Set
    End Property
    Property DisabledImage() As Image
        Get
            Return DisabledPicture
        End Get
        Set(value As Image)
            DisabledPicture = value
        End Set
    End Property
    Private Sub PictureButton_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        Me.BackgroundImage = RegularPicture
    End Sub
    Private Sub PictureButton_MouseEnter(sender As Object, e As EventArgs) Handles Me.MouseEnter
        Me.BackgroundImage = MouseOverPicture
    End Sub
    Private Sub PictureButton_MouseLeave(sender As Object, e As EventArgs) Handles Me.MouseLeave
        Me.BackgroundImage = RegularPicture
    End Sub
End Class
