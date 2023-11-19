Public Class Operations
    Function getFormCenter(formToCenter As Form, formToCenterOn As Form) As Point
        Return New Point(formToCenterOn.Location.X + (formToCenterOn.Width / 2 - formToCenter.Width / 2),
                         formToCenterOn.Location.Y + (formToCenterOn.Height / 2 - formToCenter.Height / 2))
    End Function
    Sub showCenteredDialog(formToCenter As Form, formToCenterOn As Form)
        formToCenter.Location = getFormCenter(formToCenter, formToCenterOn)
        formToCenter.ShowDialog()
    End Sub
    Public Shared Function GetNthIndex(searchString As String, charToFind As Char, n As Integer) As Integer
        Dim charIndexPair = searchString.Select(Function(c, i) New With {.Character = c, .Index = i}) _
                                    .Where(Function(x) x.Character = charToFind) _
                                    .ElementAtOrDefault(n - 1)
        Return If(charIndexPair IsNot Nothing, charIndexPair.Index, -1)
    End Function
    Public Shared Function CountCharacter(ByVal value As String, ByVal ch As Char) As Integer
        Dim cnt As Integer = 0
        For Each c As Char In value
            If c = ch Then
                cnt += 1
            End If
        Next
        Return cnt
    End Function
    Public Shared Function GetImageFile(ByVal fn As String) As Image
        If IO.File.Exists(fn) Then
            Dim img As Image = Image.FromFile(fn)
            Dim bm As New Bitmap(width:=img.Width, height:=img.Height, format:=img.PixelFormat)
            Using g As Graphics = Graphics.FromImage(bm)
                g.DrawImage(img, Point.Empty)
            End Using
            img.Dispose()
            Return bm
        Else
            MessageBox.Show("Nice try!, but " & fn & "does not exist.  Returning Nothing")
            Return Nothing
        End If
    End Function
    Public Shared Function ResizeImg(ByVal img As Image, ByVal maxwidth As Integer)
        Dim original As Image = img
        Dim intWidth As Integer = original.Width : Dim intHeight As Integer = original.Height
        Dim newWidth, newHeight As Integer
        If intWidth > maxwidth Then
            newWidth = maxwidth
            newHeight = maxwidth * (intHeight / intWidth)
            Dim newSize As New Size(newWidth, newHeight)
            Return newSize
        Else
            Return New Size(original.Width, original.Height)
        End If
    End Function
    Public Shared Function MouseIsOverControl(ByVal c As Control, Optional useRegion As Boolean = False) As Boolean
        If useRegion Then
            If c.Region IsNot Nothing Then
                Return c.Region.IsVisible(c.PointToClient(Control.MousePosition))
            Else
                Return False
            End If
        Else
            Return c.ClientRectangle.Contains(c.PointToClient(Control.MousePosition))
        End If
    End Function

    Public Shared Function compressString(ByVal value As String) As String
        Dim byteArray As Byte() = New Byte(value.Length - 1) {}
        Dim indexBA As Integer = 0

        For Each item As Char In value.ToCharArray()
            byteArray(Math.Min(System.Threading.Interlocked.Increment(indexBA), indexBA - 1)) = AscW(item)
        Next

        Dim ms As System.IO.MemoryStream = New System.IO.MemoryStream()
        Dim sw As System.IO.Compression.GZipStream = New System.IO.Compression.GZipStream(ms, System.IO.Compression.CompressionMode.Compress)
        sw.Write(byteArray, 0, byteArray.Length)
        sw.Close()
        byteArray = ms.ToArray()
        Dim sB As System.Text.StringBuilder = New System.Text.StringBuilder(byteArray.Length)

        For Each item As Byte In byteArray
            sB.Append(ChrW(item))
        Next

        ms.Close()
        sw.Dispose()
        ms.Dispose()
        Return sB.ToString()
    End Function

    Public Shared Function decompressString(ByVal value As String) As String
        Dim byteArray As Byte() = New Byte(value.Length - 1) {}
        Dim indexBA As Integer = 0

        For Each item As Char In value.ToCharArray()
            byteArray(Math.Min(System.Threading.Interlocked.Increment(indexBA), indexBA - 1)) = AscW(item)
        Next

        Dim ms As System.IO.MemoryStream = New System.IO.MemoryStream(byteArray)
        Dim sr As System.IO.Compression.GZipStream = New System.IO.Compression.GZipStream(ms, System.IO.Compression.CompressionMode.Decompress)
        byteArray = New Byte(byteArray.Length - 1) {}
        Dim rByte As Integer = sr.Read(byteArray, 0, byteArray.Length)
        Dim sB As System.Text.StringBuilder = New System.Text.StringBuilder(rByte)

        For i As Integer = 0 To rByte - 1
            sB.Append(ChrW(byteArray(i)))
        Next

        sr.Close()
        ms.Close()
        sr.Dispose()
        ms.Dispose()
        Return sB.ToString()
    End Function
End Class
