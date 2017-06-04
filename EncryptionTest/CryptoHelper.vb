Imports System.IO
Imports System.Security.Cryptography
Imports System.Text
'对称加密帮助类
Public Class CryptoHelper
    '对称加密算法提供器
    Private encryptor As ICryptoTransform      '加密器对象
    Private decryptor As ICryptoTransform      ' 解密器对象


    Public Sub CryptoHelper(ByVal algorithmName As String, ByVal key As String)
        Dim provider As SymmetricAlgorithm = SymmetricAlgorithm.Create(algorithmName)
        provider.Key = Encoding.UTF8.GetBytes(key)  'key是128bit的字符串，可以有一些特殊字符
        provider.IV = New Byte() {&H12, &H34, &H56, &H78, &H90, &HAB, &HCD, &HEF} '8bit的16进制字节序列

        encryptor = provider.CreateEncryptor()
        decryptor = provider.CreateDecryptor()
    End Sub

    Sub New(ByVal key As String)
        CryptoHelper("TripleDES", key)
    End Sub

    ''' <summary>
    ''' 初始化构造函数
    ''' </summary>
    Sub New()

    End Sub

    ''' <summary>
    ''' 加密算法
    ''' </summary>
    ''' <param name="clearText"></param>
    ''' <returns></returns>
    Public Function Encrypt(ByVal clearText As String) As String
        '创建明文流
        Dim clearBuffer As Byte() = Encoding.UTF8.GetBytes(clearText)
        Dim clearStream As MemoryStream = New MemoryStream(clearBuffer)

        '创建空的密文流
        Dim encryptedStream As MemoryStream = New MemoryStream()
        Dim CryptoStream As CryptoStream = New CryptoStream(encryptedStream, encryptor, CryptoStreamMode.Write)

        '将明文流写入到buffer中
        '将buffer中的数据写入到cryptoStream中
        Dim bytesRead As Integer = 0
        Dim buffer As Byte() = New Byte(clearBuffer.Length) {}
        Do
            bytesRead = clearStream.Read(buffer, 0, clearBuffer.Length)
            CryptoStream.Write(buffer, 0, bytesRead)
        Loop While (bytesRead > 0)

        CryptoStream.FlushFinalBlock()

        '获取加密后的文本
        buffer = encryptedStream.ToArray()
        Dim encryptedText As String = Convert.ToBase64String(buffer)

        Return encryptedText
    End Function

    ''' <summary>
    ''' 解密算法
    ''' </summary>
    ''' <param name="encryptedText"></param>
    ''' <returns></returns>
    Public Function Decrypt(ByVal encryptedText As String) As String
        Dim encryptedBuffer As Byte() = Convert.FromBase64String(encryptedText)
        Dim encryptedStream As Stream = New MemoryStream(encryptedBuffer)

        Dim clearStream As MemoryStream = New MemoryStream()
        Dim CryptoStream As CryptoStream = New CryptoStream(encryptedStream, decryptor, CryptoStreamMode.Read)

        Dim bytesRead As Integer = 0
        Dim buffer As Byte() = New Byte(encryptedBuffer.Length) {}

        Do
            bytesRead = CryptoStream.Read(buffer, 0, encryptedBuffer.Length)
            clearStream.Write(buffer, 0, bytesRead)
        Loop While (bytesRead > 0)

        buffer = clearStream.GetBuffer()
        Dim clearText As String = Encoding.UTF8.GetString(buffer, 0, Int(clearStream.Length))

        Return clearText
    End Function

    ''' <summary>
    ''' 静态函数，不用实例化可直接调用
    ''' </summary>
    ''' <param name="clearText"></param>
    ''' <param name="key"></param>
    ''' <returns></returns>
    Public Shared Function Encrypt(ByVal clearText As String, ByVal key As String) As String
        Dim helper As CryptoHelper = New CryptoHelper(key)
        Return helper.Encrypt(clearText)
    End Function

    Public Shared Function Decrypt(ByVal encryptedText As String, ByVal key As String) As String
        Dim helper As CryptoHelper = New CryptoHelper(key)
        Return helper.Decrypt(encryptedText)
    End Function
End Class
