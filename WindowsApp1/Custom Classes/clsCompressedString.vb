'String Compression Class
Public Class clsCompressedString

  'Only strings, no byte arrays are held within the class instance.
  'That avoids unnecessary conversions when requesting data more than
  'once from the class instance, without giving any new input.
  Private _UnCompressed As String = String.Empty
  Private _Compressed As String = String.Empty
  Private _TextEncoding As System.Text.Encoding = System.Text.Encoding.UTF8
  Private _PrefixForCompressedString As String = String.Empty
  Private _SuffixForCompressedString As String = String.Empty
  Private _Passphrase As String = String.Empty
  Private _CompressedGiven As Boolean = False

  Public Enum InputDataTypeClass
    Compressed = 1
    UnCompressed = 2
  End Enum

  Public Property UnCompressed() As String
    Get
      Return Me._UnCompressed
    End Get
    Set(ByVal value As String)
      Me._UnCompressed = value
      'Remember that uncompressed data was initially given
      Me._CompressedGiven = False
      'With the uncompressed data set we can start compression right away
      Me.Compress()
    End Set
  End Property

  Public Property Compressed() As String
    Get
      'If required, add prefix and/or suffix to the compressed string before returning it
      Dim Result As String = Me._Compressed
      If Result.Length > 0 Then
        If Me._PrefixForCompressedString.Length > 0 Then Result = Me._PrefixForCompressedString & Result
        If Me._SuffixForCompressedString.Length > 0 Then Result = Result & Me._SuffixForCompressedString
      End If
      Return Result
    End Get
    Set(ByVal value As String)
      'If required, remove prefix and/or suffix from the given compressed string
      Dim Result As String = value
      If Result.Length > 0 And Result.Length > (Me._PrefixForCompressedString.Length + Me._SuffixForCompressedString.Length) Then
        If Me._PrefixForCompressedString.Length > 0 Then
          Result = value.Substring(Me._PrefixForCompressedString.Length, Result.Length - Me._PrefixForCompressedString.Length)
        End If
        If Me._SuffixForCompressedString.Length > 0 Then
          Result = Result.Substring(0, Result.Length - Me._SuffixForCompressedString.Length)
        End If
      End If
      Me._Compressed = Result
      'Remember that compressed data was initially given
      Me._CompressedGiven = True
      'With the compressed data set we can start decompression right away
      Me.Decompress()
    End Set
  End Property

  Public Property TextEncoding() As System.Text.Encoding
    Get
      Return Me._TextEncoding
    End Get
    Set(ByVal value As System.Text.Encoding)
      Me._TextEncoding = value
    End Set
  End Property

  Public ReadOnly Property UnCompressed_Size() As Long
    Get
      Return Me._UnCompressed.Length
    End Get
  End Property

  Public ReadOnly Property Compressed_Size() As Long
    Get
      Return Me._Compressed.Length
    End Get
  End Property

  Public ReadOnly Property Compression_Ratio() As Double
    Get
      Dim Result As Double = 0
      If Me._Compressed.Length > 0 And Me._UnCompressed.Length > 0 Then
        Result = Me._Compressed.Length / Me._UnCompressed.Length
        Result = Math.Round(Result, 2, MidpointRounding.AwayFromZero)
      End If
      Return Result
    End Get
  End Property

  Public Property PrefixForCompressedString() As String
    Get
      Return Me._PrefixForCompressedString
    End Get
    Set(ByVal value As String)
      Me._PrefixForCompressedString = value
    End Set
  End Property

  Public Property SuffixForCompressedString() As String
    Get
      Return Me._SuffixForCompressedString
    End Get
    Set(ByVal value As String)
      Me._SuffixForCompressedString = value
    End Set
  End Property

  Public Property Passphrase() As String
    Get
      Return Me._Passphrase
    End Get
    Set(ByVal value As String)
      Me._Passphrase = value
      'With a new passphrase we possibly need to do a de-/compress,
      'if any data is available - depending on the desired direction.
      If Me._CompressedGiven Then
        If Me._Compressed.Length > 0 Then
          Me.Decompress()
        Else
          Me._UnCompressed = String.Empty
        End If
      Else
        If Me._UnCompressed.Length > 0 Then
          Me.Compress()
        Else
          Me._Compressed = String.Empty
        End If
      End If
    End Set
  End Property

  'No Parameters given
  Public Sub New()

  End Sub

  'Only TextEncoding given
  Public Sub New(ByVal TextEncoding As System.Text.Encoding)

    Me._TextEncoding = TextEncoding

  End Sub

  'Direct Compression/Decompression
  Public Sub New(ByVal TextEncoding As System.Text.Encoding, ByVal InputString As String, ByVal InputDataType As InputDataTypeClass, Optional ByVal Passphrase As String = "", Optional ByVal PrefixForCompressedString As String = "", Optional ByVal SuffixForCompressedString As String = "")

    Me._TextEncoding = TextEncoding
    Me._PrefixForCompressedString = PrefixForCompressedString
    Me._SuffixForCompressedString = SuffixForCompressedString
    Me._Passphrase = Passphrase

    Select Case InputDataType
      Case InputDataTypeClass.UnCompressed
        Me._UnCompressed = InputString
        Me.Compress()
      Case InputDataTypeClass.Compressed
        Dim Result As String = InputString
        If Result.Length > 0 And Result.Length > (Me._PrefixForCompressedString.Length + Me._SuffixForCompressedString.Length) Then
          If Me._PrefixForCompressedString.Length > 0 Then
            Result = InputString.Substring(Me._PrefixForCompressedString.Length, Result.Length - Me._PrefixForCompressedString.Length)
          End If
          If Me._SuffixForCompressedString.Length > 0 Then
            Result = Result.Substring(0, Result.Length - Me._SuffixForCompressedString.Length)
          End If
        End If
        Me._Compressed = Result
        Me._CompressedGiven = True
        Me.Decompress()
    End Select

  End Sub

  Private Sub Compress()

    If Me._UnCompressed.Length = 0 Then
      Me._Compressed = String.Empty
      Exit Sub
    End If

    Dim Result As String = String.Empty

    Try

      'Convert the uncompressed string into a byte array
      Dim UnZippedData As Byte() = Me._TextEncoding.GetBytes(Me._UnCompressed)

      'Compress the byte array
      Dim MS As New System.IO.MemoryStream()
      Dim GZip As New System.IO.Compression.GZipStream(MS, System.IO.Compression.CompressionMode.Compress)
      GZip.Write(UnZippedData, 0, UnZippedData.Length)
      'Don't FLUSH here - it possibly leads to data loss!
      GZip.Close()

      Dim ZippedData As Byte()

      'Encrypt the compressed byte array, if required
      If Me._Passphrase.Length > 0 Then
        ZippedData = Encrypt(MS.ToArray())
      Else
        ZippedData = MS.ToArray()
      End If

      'Convert the compressed byte array back to a string
      Result = System.Convert.ToBase64String(ZippedData)

      MS.Close()
      GZip.Dispose()
      MS.Dispose()

    Catch ex As Exception
      'Keep quiet - in case of an exception an empty string is returned
    Finally
      Me._Compressed = Result
    End Try

  End Sub

  Private Sub Decompress()

    If Me._Compressed.Length = 0 Then
      Me._UnCompressed = String.Empty
      Exit Sub
    End If

    Dim Result As String = String.Empty

    Try
      Dim ZippedData As Byte()

      'Convert the compressed string into a byte array and decrypt the array if required
      If Me._Passphrase.Length > 0 Then
        ZippedData = Decrypt(System.Convert.FromBase64String(Me._Compressed))
      Else
        ZippedData = System.Convert.FromBase64String(Me._Compressed)
      End If

      'Decompress the byte array
      Dim objMemStream As New IO.MemoryStream(ZippedData)
      Dim objGZipStream As New System.IO.Compression.GZipStream(objMemStream, System.IO.Compression.CompressionMode.Decompress)
      Dim sizeBytes(3) As Byte

      objMemStream.Position = objMemStream.Length - 5
      objMemStream.Read(sizeBytes, 0, 4)

      Dim iOutputSize As Integer = BitConverter.ToInt32(sizeBytes, 0)

      objMemStream.Position = 0

      Dim UnZippedData(iOutputSize - 1) As Byte

      objGZipStream.Read(UnZippedData, 0, iOutputSize)

      objGZipStream.Dispose()
      objMemStream.Dispose()

      'Convert the decompressed byte array back to a string
      Result = Me._TextEncoding.GetString(UnZippedData)

    Catch ex As Exception

    Finally
      Me._UnCompressed = Result
    End Try

  End Sub

  Private Function Encrypt(ByVal PlainData As Byte()) As Byte()

    Dim Result As Byte()

    Try

      Dim Enc As New System.Security.Cryptography.RijndaelManaged
      Enc.KeySize = 256
      Enc.Key = Me.Encryption_Key()
      Enc.IV = Me.Encryption_IV()

      Dim memoryStream As New IO.MemoryStream
      Dim cryptoStream As Security.Cryptography.CryptoStream
      cryptoStream = New Security.Cryptography.CryptoStream(memoryStream, Enc.CreateEncryptor, Security.Cryptography.CryptoStreamMode.Write)
      cryptoStream.Write(PlainData, 0, PlainData.Length)
      cryptoStream.FlushFinalBlock()
      Result = memoryStream.ToArray()
      cryptoStream.Close()
      memoryStream.Close()
      cryptoStream.Dispose()
      memoryStream.Dispose()

    Catch ex As Exception
      Result = Nothing
    End Try

    Return Result

  End Function

  Private Function Decrypt(ByVal EncData As Byte()) As Byte()

    Dim Result As Byte()

    Try
      Dim Enc As New System.Security.Cryptography.RijndaelManaged
      Enc.KeySize = 256
      Enc.Key = Me.Encryption_Key()
      Enc.IV = Me.Encryption_IV()

      Dim memoryStream As New IO.MemoryStream(EncData)
      Dim cryptoStream As Security.Cryptography.CryptoStream
      cryptoStream = New Security.Cryptography.CryptoStream(memoryStream, Enc.CreateDecryptor, Security.Cryptography.CryptoStreamMode.Read)

      Dim TempDecryptArr As Byte()
      ReDim TempDecryptArr(EncData.Length)
      Dim decryptedByteCount As Integer
      decryptedByteCount = cryptoStream.Read(TempDecryptArr, 0, EncData.Length)

      cryptoStream.Close()
      memoryStream.Close()
      cryptoStream.Dispose()
      memoryStream.Dispose()

      ReDim Result(decryptedByteCount)
      Array.Copy(TempDecryptArr, Result, decryptedByteCount)
    Catch ex As Exception
      Result = Nothing
    End Try

    Return Result

  End Function

  Private Function Encryption_Key() As Byte()

    'Generate a byte array of required length as the encryption key.
    'A SHA256 hash of the passphrase has just the required length. It is used twice in a manner of self-salting.
    Dim SHA256 As New System.Security.Cryptography.SHA256Managed
    Dim L1 As String = System.Convert.ToBase64String(SHA256.ComputeHash(Me._TextEncoding.GetBytes(Me._Passphrase)))
    Dim L2 As String = Me.Passphrase & L1
    Dim Result As Byte() = SHA256.ComputeHash(Me._TextEncoding.GetBytes(L2))
    Return Result

  End Function

  Private Function Encryption_IV() As Byte()

    'Generate a byte array of required length as the iv.
    'A MD5 hash of the passphrase has just the required length. It is used twice in a manner of self-salting.
    Dim MD5 As New System.Security.Cryptography.MD5CryptoServiceProvider
    Dim L1 As String = System.Convert.ToBase64String(MD5.ComputeHash(Me._TextEncoding.GetBytes(Me._Passphrase)))
    Dim L2 As String = Me.Passphrase & L1
    Dim Result As Byte() = MD5.ComputeHash(Me._TextEncoding.GetBytes(L2))
    Return Result

  End Function

End Class
