<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Program1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.lstTransactions = New System.Windows.Forms.ListBox()
        Me.Change = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.USD = New System.Windows.Forms.CheckBox()
        Me.EUR = New System.Windows.Forms.CheckBox()
        Me.CNY = New System.Windows.Forms.CheckBox()
        Me.COP = New System.Windows.Forms.CheckBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(62, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 23)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "GBP -----→ ANY"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(436, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 17)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Amount:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(444, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 17)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Result:"
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(501, 55)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(166, 20)
        Me.txtAmount.TabIndex = 14
        Me.txtAmount.Text = "0"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(690, 26)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(98, 37)
        Me.btnSave.TabIndex = 17
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(690, 83)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(98, 37)
        Me.btnReset.TabIndex = 18
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'lstTransactions
        '
        Me.lstTransactions.FormattingEnabled = True
        Me.lstTransactions.Location = New System.Drawing.Point(491, 174)
        Me.lstTransactions.Name = "lstTransactions"
        Me.lstTransactions.Size = New System.Drawing.Size(297, 264)
        Me.lstTransactions.TabIndex = 19
        '
        'Change
        '
        Me.Change.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Change.Location = New System.Drawing.Point(502, 99)
        Me.Change.Name = "Change"
        Me.Change.Size = New System.Drawing.Size(166, 23)
        Me.Change.TabIndex = 20
        Me.Change.Text = "0"
        '
        'btnBack
        '
        Me.btnBack.Image = Global.Currency_Converter_prot.My.Resources.Resources._936345
        Me.btnBack.Location = New System.Drawing.Point(12, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(34, 37)
        Me.btnBack.TabIndex = 21
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Currency_Converter_prot.My.Resources.Resources.tb
        Me.PictureBox1.Location = New System.Drawing.Point(12, 193)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(240, 245)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(322, 378)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(94, 60)
        Me.btnQuit.TabIndex = 22
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'USD
        '
        Me.USD.AutoSize = True
        Me.USD.Location = New System.Drawing.Point(208, 51)
        Me.USD.Name = "USD"
        Me.USD.Size = New System.Drawing.Size(49, 17)
        Me.USD.TabIndex = 23
        Me.USD.Text = "USD"
        Me.USD.UseVisualStyleBackColor = True
        '
        'EUR
        '
        Me.EUR.AutoSize = True
        Me.EUR.Location = New System.Drawing.Point(208, 84)
        Me.EUR.Name = "EUR"
        Me.EUR.Size = New System.Drawing.Size(49, 17)
        Me.EUR.TabIndex = 24
        Me.EUR.Text = "EUR"
        Me.EUR.UseVisualStyleBackColor = True
        '
        'CNY
        '
        Me.CNY.AutoSize = True
        Me.CNY.Location = New System.Drawing.Point(208, 117)
        Me.CNY.Name = "CNY"
        Me.CNY.Size = New System.Drawing.Size(48, 17)
        Me.CNY.TabIndex = 25
        Me.CNY.Text = "CNY"
        Me.CNY.UseVisualStyleBackColor = True
        '
        'COP
        '
        Me.COP.AutoSize = True
        Me.COP.Location = New System.Drawing.Point(208, 150)
        Me.COP.Name = "COP"
        Me.COP.Size = New System.Drawing.Size(48, 17)
        Me.COP.TabIndex = 26
        Me.COP.Text = "COP"
        Me.COP.UseVisualStyleBackColor = True
        '
        'Program1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.COP)
        Me.Controls.Add(Me.CNY)
        Me.Controls.Add(Me.EUR)
        Me.Controls.Add(Me.USD)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.Change)
        Me.Controls.Add(Me.lstTransactions)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Program1"
        Me.Text = "Form3"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents lstTransactions As ListBox
    Friend WithEvents Change As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents btnQuit As Button
    Friend WithEvents USD As CheckBox
    Friend WithEvents EUR As CheckBox
    Friend WithEvents CNY As CheckBox
    Friend WithEvents COP As CheckBox
End Class
