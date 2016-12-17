Imports System.Security.Cryptography
Imports System.Text
Public Class GenHash
    'Genera el hash dependiendo del algoritmo que se le pase, Ejemlo: MD5CryptoServiceProvider y después el texto
    Public Function ComputeHashOfString(Of T As HashAlgorithm)(ByVal str As String,
                                                                              Optional ByVal enc As Encoding = Nothing) As String
        If (enc Is Nothing) Then
            enc = Encoding.Default
        End If
        Using algorithm As HashAlgorithm = DirectCast(Activator.CreateInstance(GetType(T)), HashAlgorithm)
            Dim data As Byte() = enc.GetBytes(str)
            Dim hash As Byte() = algorithm.ComputeHash(data)
            Dim sb As New StringBuilder(capacity:=hash.Length * 2)
            For Each b As Byte In hash
                sb.Append(b.ToString("X2"))
            Next
            Return sb.ToString.ToLower()
        End Using

    End Function
    Private Sub tboriginal_TextChanged(sender As Object, e As EventArgs) Handles tboriginal.TextChanged
        'Obtengo el hash a partir del texto ingresado en la casilla tboriginal
        md5tbresultado.Text = ComputeHashOfString(Of MD5CryptoServiceProvider)(tboriginal.Text)
        sha1tbresultado.Text = ComputeHashOfString(Of SHA1CryptoServiceProvider)(tboriginal.Text)
        sha5tbresultado.Text = ComputeHashOfString(Of SHA512CryptoServiceProvider)(tboriginal.Text)
    End Sub
End Class
