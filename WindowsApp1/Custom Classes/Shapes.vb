Public Class Shapes
    Public Shared Function getRoundedRectangle(ByVal x As Int32, ByVal y As Int32, ByVal width As Int32, ByVal height As Int32, ByVal radius As Int32) As Drawing2D.GraphicsPath
        'Create a rectangle
        Dim area As Rectangle = New Rectangle(x, y, width, height)
        Dim path As Drawing2D.GraphicsPath = New Drawing2D.GraphicsPath
        path.FillMode = Drawing2D.FillMode.Alternate
        'Add the corners
        path.AddArc(area.Left, area.Top, radius * 2, radius * 2, 180, 90) 'Upper-Left
        path.AddArc(area.Right - (radius * 2), area.Top, radius * 2, radius * 2, 270, 90) 'Upper-Right
        path.AddArc(area.Right - (radius * 2), area.Bottom - (radius * 2), radius * 2, radius * 2, 0, 90) 'Lower-Right
        path.AddArc(area.Left, area.Bottom - (radius * 2), radius * 2, radius * 2, 90, 90) 'Lower-Left
        path.CloseAllFigures()

        'Draw the rounded rectangle
        'g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        Return path
    End Function

    Public Shared Function InvertRegion(ByVal region As Region, ByVal width As Integer, ByVal height As Integer) As Region
        Dim mask As Bitmap = New Bitmap(width, height)
        Graphics.FromImage(mask).FillRegion(Brushes.Black, region)
        Dim matchColor As Integer = Color.Black.ToArgb()
        Dim inverted As Region = New System.Drawing.Region()
        inverted.MakeEmpty()
        Dim rc As Rectangle = New Rectangle(0, 0, 0, 0)
        Dim inimage As Boolean = False

        For y As Integer = 0 To mask.Height - 1

            For x As Integer = 0 To mask.Width - 1

                If Not inimage Then

                    If mask.GetPixel(x, y).ToArgb() <> matchColor Then
                        inimage = True
                        rc.X = x
                        rc.Y = y
                        rc.Height = 1
                    End If
                Else

                    If mask.GetPixel(x, y).ToArgb() = matchColor Then
                        inimage = False
                        rc.Width = x - rc.X
                        inverted.Union(rc)
                    End If
                End If
            Next

            If inimage Then
                inimage = False
                rc.Width = mask.Width - rc.X
                inverted.Union(rc)
            End If
        Next

        Return inverted
    End Function
End Class
