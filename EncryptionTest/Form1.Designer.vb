<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LabelXML = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TB_note = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Encryp_private = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TB_public = New System.Windows.Forms.TextBox()
        Me.Encryp_public = New System.Windows.Forms.Button()
        Me.TB_symmetry = New System.Windows.Forms.TextBox()
        Me.ButtonDE = New System.Windows.Forms.Button()
        Me.TB_decrypt = New System.Windows.Forms.TextBox()
        Me.TB_encryt = New System.Windows.Forms.TextBox()
        Me.ButtonEN1 = New System.Windows.Forms.Button()
        Me.BtHashSign = New System.Windows.Forms.Button()
        Me.BtDEhash = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtDEhash)
        Me.GroupBox1.Controls.Add(Me.BtHashSign)
        Me.GroupBox1.Controls.Add(Me.LabelXML)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TB_note)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(488, 83)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "输入区"
        '
        'LabelXML
        '
        Me.LabelXML.AutoSize = True
        Me.LabelXML.Location = New System.Drawing.Point(137, 59)
        Me.LabelXML.Name = "LabelXML"
        Me.LabelXML.Size = New System.Drawing.Size(23, 12)
        Me.LabelXML.TabIndex = 8
        Me.LabelXML.Text = "..."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 12)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "备注"
        '
        'TB_note
        '
        Me.TB_note.Location = New System.Drawing.Point(47, 21)
        Me.TB_note.Name = "TB_note"
        Me.TB_note.Size = New System.Drawing.Size(418, 21)
        Me.TB_note.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(47, 54)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "XML打包"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Encryp_private)
        Me.GroupBox2.Controls.Add(Me.TextBox3)
        Me.GroupBox2.Controls.Add(Me.TB_public)
        Me.GroupBox2.Controls.Add(Me.Encryp_public)
        Me.GroupBox2.Controls.Add(Me.TB_symmetry)
        Me.GroupBox2.Controls.Add(Me.ButtonDE)
        Me.GroupBox2.Controls.Add(Me.TB_decrypt)
        Me.GroupBox2.Controls.Add(Me.TB_encryt)
        Me.GroupBox2.Controls.Add(Me.ButtonEN1)
        Me.GroupBox2.Location = New System.Drawing.Point(0, 89)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(488, 278)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "加密解密"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(328, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(137, 12)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "按日期随机生成对称密钥"
        '
        'Encryp_private
        '
        Me.Encryp_private.Location = New System.Drawing.Point(329, 77)
        Me.Encryp_private.Name = "Encryp_private"
        Me.Encryp_private.Size = New System.Drawing.Size(122, 23)
        Me.Encryp_private.TabIndex = 11
        Me.Encryp_private.Text = "私钥解密对称密钥"
        Me.Encryp_private.UseVisualStyleBackColor = True
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(5, 77)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(301, 21)
        Me.TextBox3.TabIndex = 10
        '
        'TB_public
        '
        Me.TB_public.Location = New System.Drawing.Point(5, 50)
        Me.TB_public.Name = "TB_public"
        Me.TB_public.ReadOnly = True
        Me.TB_public.Size = New System.Drawing.Size(301, 21)
        Me.TB_public.TabIndex = 9
        '
        'Encryp_public
        '
        Me.Encryp_public.Location = New System.Drawing.Point(329, 49)
        Me.Encryp_public.Name = "Encryp_public"
        Me.Encryp_public.Size = New System.Drawing.Size(122, 23)
        Me.Encryp_public.TabIndex = 8
        Me.Encryp_public.Text = "公钥加密对称密钥"
        Me.Encryp_public.UseVisualStyleBackColor = True
        '
        'TB_symmetry
        '
        Me.TB_symmetry.Location = New System.Drawing.Point(6, 23)
        Me.TB_symmetry.Name = "TB_symmetry"
        Me.TB_symmetry.ReadOnly = True
        Me.TB_symmetry.Size = New System.Drawing.Size(300, 21)
        Me.TB_symmetry.TabIndex = 6
        '
        'ButtonDE
        '
        Me.ButtonDE.Location = New System.Drawing.Point(382, 215)
        Me.ButtonDE.Name = "ButtonDE"
        Me.ButtonDE.Size = New System.Drawing.Size(75, 23)
        Me.ButtonDE.TabIndex = 4
        Me.ButtonDE.Text = "解密"
        Me.ButtonDE.UseVisualStyleBackColor = True
        '
        'TB_decrypt
        '
        Me.TB_decrypt.Location = New System.Drawing.Point(6, 192)
        Me.TB_decrypt.Multiline = True
        Me.TB_decrypt.Name = "TB_decrypt"
        Me.TB_decrypt.ReadOnly = True
        Me.TB_decrypt.Size = New System.Drawing.Size(370, 78)
        Me.TB_decrypt.TabIndex = 3
        '
        'TB_encryt
        '
        Me.TB_encryt.Location = New System.Drawing.Point(6, 108)
        Me.TB_encryt.Multiline = True
        Me.TB_encryt.Name = "TB_encryt"
        Me.TB_encryt.ReadOnly = True
        Me.TB_encryt.Size = New System.Drawing.Size(368, 78)
        Me.TB_encryt.TabIndex = 2
        '
        'ButtonEN1
        '
        Me.ButtonEN1.Location = New System.Drawing.Point(380, 135)
        Me.ButtonEN1.Name = "ButtonEN1"
        Me.ButtonEN1.Size = New System.Drawing.Size(75, 23)
        Me.ButtonEN1.TabIndex = 1
        Me.ButtonEN1.Text = "对称加密"
        Me.ButtonEN1.UseVisualStyleBackColor = True
        '
        'BtHashSign
        '
        Me.BtHashSign.Location = New System.Drawing.Point(301, 54)
        Me.BtHashSign.Name = "BtHashSign"
        Me.BtHashSign.Size = New System.Drawing.Size(75, 23)
        Me.BtHashSign.TabIndex = 9
        Me.BtHashSign.Text = "数据签名"
        Me.BtHashSign.UseVisualStyleBackColor = True
        '
        'BtDEhash
        '
        Me.BtDEhash.Location = New System.Drawing.Point(390, 54)
        Me.BtDEhash.Name = "BtDEhash"
        Me.BtDEhash.Size = New System.Drawing.Size(75, 23)
        Me.BtDEhash.TabIndex = 10
        Me.BtDEhash.Text = "验证签名"
        Me.BtDEhash.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(488, 367)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "EncryptionTest"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TB_note As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TB_encryt As TextBox
    Friend WithEvents ButtonEN1 As Button
    Friend WithEvents ButtonDE As Button
    Friend WithEvents TB_decrypt As TextBox
    Friend WithEvents Encryp_private As Button
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TB_public As TextBox
    Friend WithEvents Encryp_public As Button
    Friend WithEvents TB_symmetry As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents LabelXML As Label
    Friend WithEvents BtHashSign As System.Windows.Forms.Button
    Friend WithEvents BtDEhash As System.Windows.Forms.Button
End Class
