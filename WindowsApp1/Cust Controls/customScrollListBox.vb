Imports System.Runtime.InteropServices

Public Class customScrollListBox
    Inherits ListBox

    Public Sub Scroll(ByVal percentage As Single)
        If (percentage < 0.0!) Then
            Throw New ArgumentException(Nothing, "percentage")
        End If

        ' Sends the scroll / set position Windows message
        Const WM_VSCROLL As Integer = &H115
        Const SB_THUMBPOSITION As Integer = 4
        Dim wp As Integer = CInt(((percentage * MyBase.Items.Count) * 65536.0!)) + SB_THUMBPOSITION
        customScrollListBox.SendMessage(MyBase.Handle, WM_VSCROLL, New IntPtr(wp), IntPtr.Zero)
    End Sub

    <DllImport("user32.dll")>
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr
    End Function

    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            ' Removes the vertical scroll window style
            Dim p As CreateParams = MyBase.CreateParams
            Const WS_VSCROLL As Integer = &H200000
            p.Style = (p.Style And -WS_VSCROLL)
            Return p
        End Get
    End Property

End Class