<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Program2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.COP = New System.Windows.Forms.CheckBox()
        Me.CNY = New System.Windows.Forms.CheckBox()
        Me.EUR = New System.Windows.Forms.CheckBox()
        Me.USD = New System.Windows.Forms.CheckBox()
        Me.GBP = New System.Windows.Forms.CheckBox()
        Me.COP2 = New System.Windows.Forms.CheckBox()
        Me.CNY2 = New System.Windows.Forms.CheckBox()
        Me.EUR2 = New System.Windows.Forms.CheckBox()
        Me.USD2 = New System.Windows.Forms.CheckBox()
        Me.GBP2 = New System.Windows.Forms.CheckBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(491, 174)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(297, 264)
        Me.ListBox1.TabIndex = 33
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(690, 124)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(98, 37)
        Me.Button3.TabIndex = 32
        Me.Button3.Text = "Reset"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(690, 67)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(98, 37)
        Me.Button2.TabIndex = 31
        Me.Button2.Text = "Save"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(690, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(98, 37)
        Me.Button1.TabIndex = 30
        Me.Button1.Text = "Convert"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(501, 55)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(166, 20)
        Me.TextBox1.TabIndex = 28
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(444, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 17)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Result:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(436, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 17)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Amount:"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(62, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 23)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "ANY -----→ ANY"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Currency_Converter_prot.My.Resources.Resources.tb
        Me.PictureBox1.Location = New System.Drawing.Point(12, 193)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(240, 245)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(502, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(166, 23)
        Me.Label4.TabIndex = 40
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(327, 378)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(94, 60)
        Me.btnQuit.TabIndex = 41
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Image = Global.Currency_Converter_prot.My.Resources.Resources._936345
        Me.btnBack.Location = New System.Drawing.Point(12, 5)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(34, 37)
        Me.btnBack.TabIndex = 42
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'COP
        '
        Me.COP.AutoSize = True
        Me.COP.Location = New System.Drawing.Point(12, 153)
        Me.COP.Name = "COP"
        Me.COP.Size = New System.Drawing.Size(48, 17)
        Me.COP.TabIndex = 52
        Me.COP.Text = "COP"
        Me.COP.UseVisualStyleBackColor = True
        '
        'CNY
        '
        Me.CNY.AutoSize = True
        Me.CNY.Location = New System.Drawing.Point(12, 130)
        Me.CNY.Name = "CNY"
        Me.CNY.Size = New System.Drawing.Size(48, 17)
        Me.CNY.TabIndex = 51
        Me.CNY.Text = "CNY"
        Me.CNY.UseVisualStyleBackColor = True
        '
        'EUR
        '
        Me.EUR.AutoSize = True
        Me.EUR.Location = New System.Drawing.Point(12, 104)
        Me.EUR.Name = "EUR"
        Me.EUR.Size = New System.Drawing.Size(49, 17)
        Me.EUR.TabIndex = 50
        Me.EUR.Text = "EUR"
        Me.EUR.UseVisualStyleBackColor = True
        '
        'USD
        '
        Me.USD.AutoSize = True
        Me.USD.Location = New System.Drawing.Point(12, 78)
        Me.USD.Name = "USD"
        Me.USD.Size = New System.Drawing.Size(49, 17)
        Me.USD.TabIndex = 49
        Me.USD.Text = "USD"
        Me.USD.UseVisualStyleBackColor = True
        '
        'GBP
        '
        Me.GBP.AutoSize = True
        Me.GBP.Location = New System.Drawing.Point(12, 52)
        Me.GBP.Name = "GBP"
        Me.GBP.Size = New System.Drawing.Size(48, 17)
        Me.GBP.TabIndex = 48
        Me.GBP.Text = "GBP"
        Me.GBP.UseVisualStyleBackColor = True
        '
        'COP2
        '
        Me.COP2.AutoSize = True
        Me.COP2.Location = New System.Drawing.Point(210, 149)
        Me.COP2.Name = "COP2"
        Me.COP2.Size = New System.Drawing.Size(48, 17)
        Me.COP2.TabIndex = 57
        Me.COP2.Text = "COP"
        Me.COP2.UseVisualStyleBackColor = True
        '
        'CNY2
        '
        Me.CNY2.AutoSize = True
        Me.CNY2.Location = New System.Drawing.Point(210, 126)
        Me.CNY2.Name = "CNY2"
        Me.CNY2.Size = New System.Drawing.Size(48, 17)
        Me.CNY2.TabIndex = 56
        Me.CNY2.Text = "CNY"
        Me.CNY2.UseVisualStyleBackColor = True
        '
        'EUR2
        '
        Me.EUR2.AutoSize = True
        Me.EUR2.Location = New System.Drawing.Point(210, 100)
        Me.EUR2.Name = "EUR2"
        Me.EUR2.Size = New System.Drawing.Size(49, 17)
        Me.EUR2.TabIndex = 55
        Me.EUR2.Text = "EUR"
        Me.EUR2.UseVisualStyleBackColor = True
        '
        'USD2
        '
        Me.USD2.AutoSize = True
        Me.USD2.Location = New System.Drawing.Point(210, 74)
        Me.USD2.Name = "USD2"
        Me.USD2.Size = New System.Drawing.Size(49, 17)
        Me.USD2.TabIndex = 54
        Me.USD2.Text = "USD"
        Me.USD2.UseVisualStyleBackColor = True
        '
        'GBP2
        '
        Me.GBP2.AutoSize = True
        Me.GBP2.Location = New System.Drawing.Point(210, 48)
        Me.GBP2.Name = "GBP2"
        Me.GBP2.Size = New System.Drawing.Size(48, 17)
        Me.GBP2.TabIndex = 53
        Me.GBP2.Text = "GBP"
        Me.GBP2.UseVisualStyleBackColor = True
        '
        'Program2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.COP2)
        Me.Controls.Add(Me.CNY2)
        Me.Controls.Add(Me.EUR2)
        Me.Controls.Add(Me.USD2)
        Me.Controls.Add(Me.GBP2)
        Me.Controls.Add(Me.COP)
        Me.Controls.Add(Me.CNY)
        Me.Controls.Add(Me.EUR)
        Me.Controls.Add(Me.USD)
        Me.Controls.Add(Me.GBP)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Program2"
        Me.Text = "Form4"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnQuit As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents COP As CheckBox
    Friend WithEvents CNY As CheckBox
    Friend WithEvents EUR As CheckBox
    Friend WithEvents USD As CheckBox
    Friend WithEvents GBP As CheckBox
    Friend WithEvents COP2 As CheckBox
    Friend WithEvents CNY2 As CheckBox
    Friend WithEvents EUR2 As CheckBox
    Friend WithEvents USD2 As CheckBox
    Friend WithEvents GBP2 As CheckBox
End Class
