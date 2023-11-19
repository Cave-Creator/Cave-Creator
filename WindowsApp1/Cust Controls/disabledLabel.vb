Public Class disabledLabel
    Inherits Label
    Dim brush As Color = Color.White

    Public Sub New()
        Me.SetStyle(ControlStyles.UserPaint, True)
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        If Not Enabled Then
            e.Graphics.DrawString(Text, Font, New SolidBrush(brush), 0F, 0F)
        Else
            MyBase.OnPaint(e)
        End If
    End Sub
    Property DisabledColour() As Color
        Get
            Return brush
        End Get
        Set(value As Color)
            brush = value
        End Set
    End Property
End Class
