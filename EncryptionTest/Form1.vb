Imports System.Security.Cryptography
Imports System.Text
Imports System.Xml
Imports System.IO

Public Class Form1
    Dim key As String = "*NKG*" + RandomKey()
    Dim helper As CryptoHelper = New CryptoHelper(key)
    Dim myrsa As RSACryptoServiceProvider = New RSACryptoServiceProvider()
    '得到私钥主要保存了RSAParameters中的8各参数
    Dim privateKey As String = myrsa.ToXmlString(True)
    '得到公钥保存了RSAParameters中2个参数
    Dim publicKey As String = myrsa.ToXmlString(False)
    Dim abc As String = ""

    ''' <summary>
    ''' 程序入口
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.TB_symmetry.Text = key
    End Sub

    Private Sub ButtonEN1_Click(sender As Object, e As EventArgs) Handles ButtonEN1.Click
        Dim encryptedText As String = helper.Encrypt(Me.TB_note.Text.Trim)
        Me.TB_encryt.Text = encryptedText
    End Sub

    Private Sub ButtonDE_Click(sender As Object, e As EventArgs) Handles ButtonDE.Click
        Dim clearText As String = CryptoHelper.Decrypt(Me.TB_encryt.Text.Trim, key)
        Me.TB_decrypt.Text = clearText
    End Sub

    ''' <summary>
    ''' 随机生成对称密钥
    ''' </summary>
    ''' <returns></returns>
    Private Function RandomKey() As String
        Dim today As String = DateTime.Now.ToString("yyyyMMdd")
        If StrComp(today, My.Settings.Myday) = 0 Then
            Return My.Settings.Mykey
        Else
            My.Settings.Myday = today
        End If

        Dim result As String = ""

        For i = 0 To 10
            Dim re As String = ""
            Dim k As Integer = Int((25 - 0 + 1) * Rnd())
            Select Case k
                Case 0
                    re = "A"
                Case 1
                    re = "B"
                Case 2
                    re = "C"
                Case 3
                    re = "D"
                Case 4
                    re = "E"
                Case 5
                    re = "F"
                Case 6
                    re = "G"
                Case 7
                    re = "H"
                Case 8
                    re = "I"
                Case 9
                    re = "J"
                Case 10
                    re = "K"
                Case 11
                    re = "L"
                Case 12
                    re = "M"
                Case 13
                    re = "N"
                Case 14
                    re = "O"
                Case 15
                    re = "P"
                Case 16
                    re = "Q"
                Case 17
                    re = "R"
                Case 18
                    re = "S"
                Case 19
                    re = "T"
                Case 20
                    re = "U"
                Case 21
                    re = "V"
                Case 22
                    re = "W"
                Case 23
                    re = "X"
                Case 24
                    re = "Y"
                Case 25
                    re = "Z"
                Case Else
                    MsgBox("密码生成错误")
            End Select

            result += re
        Next

        My.Settings.Mykey = result
        Return result
    End Function

    Private Sub Encryp_public_Click(sender As Object, e As EventArgs) Handles Encryp_public.Click
        Dim rsa = New RSACryptoServiceProvider()
        rsa.FromXmlString(publicKey)
        Dim PlainTextBArray As Byte() = (New UnicodeEncoding()).GetBytes(Me.TB_symmetry.Text.Trim)
        Dim CypherTextBArray As Byte() = myrsa.Encrypt(PlainTextBArray, False)
        Dim Result As String = Convert.ToBase64String(CypherTextBArray)
        Me.TB_public.Text = Result
    End Sub

    Private Sub Encryp_private_Click(sender As Object, e As EventArgs) Handles Encryp_private.Click
        myrsa.FromXmlString(privateKey)
        '把原来加密后的String转换成byte[]
        Dim PlainTextBArray As Byte() = Convert.FromBase64String(Me.TB_public.Text.Trim)
        '使用.NET中的Decrypt方法解密
        Dim DypherTextBArray As Byte() = myrsa.Decrypt(PlainTextBArray, False)
        '转换解密后的byte[]，这就得到了我们原来的加密前的内容了
        Dim Result As String = (New UnicodeEncoding()).GetString(DypherTextBArray)
        Me.TextBox3.Text = Result
    End Sub

    ''' <summary>
    ''' XML打包（实验功能）
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim test As String = "<?xml version=""1.0"" encoding=""utf-8"" standalone=""yes""?> " & _
                             "<hello>" & _
                             "<num1>1</num1>" & _
                             "<num2>2</num2>" & _
                             "</hello>"

        Dim xd As XmlDocument = New XmlDocument()
        xd.LoadXml(test)
        Dim sb As StringBuilder = New StringBuilder()
        Dim sw As StringWriter = New StringWriter(sb)
        Dim xtw As XmlTextWriter = Nothing

        Try
            xtw = New XmlTextWriter(sw)
            xtw.Formatting = Formatting.Indented
            xtw.Indentation = 1
            'xtw.IndentChar = '\t' 
            xd.WriteTo(xtw)
            sb.ToString()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        Finally
            If Not IsNothing(xtw) Then
                xtw.Close()
            End If

        End Try
    End Sub

    ''' <summary>
    ''' 数字签名
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub BtHashSign_Click(sender As Object, e As EventArgs) Handles BtHashSign.Click
        ''转成 Base64 形式的 System.String
        'Dim b As Byte() = Encoding.Default.GetBytes(Me.TB_note.Text.Trim)
        'Dim a As String = Convert.ToBase64String(b)
        Dim str_Private_Key As String = Convert.ToBase64String(myrsa.ExportCspBlob(True))
        abc = HashAndSign(Me.TB_note.Text.Trim, str_Private_Key)
        MsgBox(abc)
    End Sub

    ''' <summary>
    ''' 用公钥匙验证签名
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub BtDEhash_Click(sender As Object, e As EventArgs) Handles BtDEhash.Click
        Dim str_Public_Key As String = Convert.ToBase64String(myrsa.ExportCspBlob(False))
        'Dim ssa As RSACryptoServiceProvider = New RSACryptoServiceProvider()
        'Dim str_Public_Key As String = Convert.ToBase64String(ssa.ExportCspBlob(False))
        MsgBox(VerifySignedHash(Me.TB_decrypt.Text.Trim, abc, str_Public_Key))
    End Sub

    ''' <summary>
    ''' 签名算法
    ''' </summary>
    ''' <param name="str_DataToSign"></param>
    ''' <param name="str_Private_Key"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function HashAndSign(ByVal str_DataToSign As String, ByVal str_Private_Key As String) As String
        Dim ByteConverter As ASCIIEncoding = New ASCIIEncoding()
        Dim DataToSign As Byte() = ByteConverter.GetBytes(str_DataToSign)

        Try
            Dim RSAalg As RSACryptoServiceProvider = New RSACryptoServiceProvider()
            RSAalg.ImportCspBlob(Convert.FromBase64String(str_Private_Key))
            Dim signedData As Byte() = RSAalg.SignData(DataToSign, New SHA1CryptoServiceProvider())
            Dim str_SignedData As String = Convert.ToBase64String(signedData)
            Return str_SignedData
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
            Return Nothing
        End Try
    End Function

    ''' <summary>
    ''' 验证签名算法
    ''' </summary>
    ''' <param name="str_DataToVerify"></param>
    ''' <param name="str_SignedData"></param>
    ''' <param name="str_Public_Key"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function VerifySignedHash(ByVal str_DataToVerify As String, ByVal str_SignedData As String, ByVal str_Public_Key As String) As Boolean
        Dim SignedData As Byte() = Convert.FromBase64String(str_SignedData)
        Dim ByteConverter As ASCIIEncoding = New ASCIIEncoding()
        Dim DataToVerify As Byte() = ByteConverter.GetBytes(str_DataToVerify)

        Try
            Dim RSAalg As RSACryptoServiceProvider = New RSACryptoServiceProvider()
            RSAalg.ImportCspBlob(Convert.FromBase64String(str_Public_Key))

            Return RSAalg.VerifyData(DataToVerify, New SHA1CryptoServiceProvider(), SignedData)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
            Return False
        End Try
    End Function
End Class
