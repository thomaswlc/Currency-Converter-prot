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
        Me.lstTransactions = New System.Windows.Forms.ListBox()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Change = New System.Windows.Forms.Label()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.chcCOP = New System.Windows.Forms.CheckBox()
        Me.chcCNY = New System.Windows.Forms.CheckBox()
        Me.chcEUR = New System.Windows.Forms.CheckBox()
        Me.chcUSD = New System.Windows.Forms.CheckBox()
        Me.chcNGN = New System.Windows.Forms.CheckBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lstTransactions
        '
        Me.lstTransactions.FormattingEnabled = True
        Me.lstTransactions.Location = New System.Drawing.Point(491, 174)
        Me.lstTransactions.Name = "lstTransactions"
        Me.lstTransactions.Size = New System.Drawing.Size(297, 264)
        Me.lstTransactions.TabIndex = 33
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(690, 73)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(98, 37)
        Me.btnReset.TabIndex = 32
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(501, 55)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(166, 20)
        Me.txtAmount.TabIndex = 28
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
        Me.Label1.Text = "ANY -----→ GBP"
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
        'Change
        '
        Me.Change.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Change.Location = New System.Drawing.Point(502, 96)
        Me.Change.Name = "Change"
        Me.Change.Size = New System.Drawing.Size(166, 23)
        Me.Change.TabIndex = 40
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
        'chcCOP
        '
        Me.chcCOP.AutoSize = True
        Me.chcCOP.Location = New System.Drawing.Point(12, 121)
        Me.chcCOP.Name = "chcCOP"
        Me.chcCOP.Size = New System.Drawing.Size(48, 17)
        Me.chcCOP.TabIndex = 52
        Me.chcCOP.Text = "COP"
        Me.chcCOP.UseVisualStyleBackColor = True
        '
        'chcCNY
        '
        Me.chcCNY.AutoSize = True
        Me.chcCNY.Location = New System.Drawing.Point(12, 97)
        Me.chcCNY.Name = "chcCNY"
        Me.chcCNY.Size = New System.Drawing.Size(48, 17)
        Me.chcCNY.TabIndex = 51
        Me.chcCNY.Text = "CNY"
        Me.chcCNY.UseVisualStyleBackColor = True
        '
        'chcEUR
        '
        Me.chcEUR.AutoSize = True
        Me.chcEUR.Location = New System.Drawing.Point(12, 73)
        Me.chcEUR.Name = "chcEUR"
        Me.chcEUR.Size = New System.Drawing.Size(49, 17)
        Me.chcEUR.TabIndex = 50
        Me.chcEUR.Text = "EUR"
        Me.chcEUR.UseVisualStyleBackColor = True
        '
        'chcUSD
        '
        Me.chcUSD.AutoSize = True
        Me.chcUSD.Location = New System.Drawing.Point(12, 49)
        Me.chcUSD.Name = "chcUSD"
        Me.chcUSD.Size = New System.Drawing.Size(49, 17)
        Me.chcUSD.TabIndex = 49
        Me.chcUSD.Text = "USD"
        Me.chcUSD.UseVisualStyleBackColor = True
        '
        'chcNGN
        '
        Me.chcNGN.AutoSize = True
        Me.chcNGN.Location = New System.Drawing.Point(12, 145)
        Me.chcNGN.Name = "chcNGN"
        Me.chcNGN.Size = New System.Drawing.Size(50, 17)
        Me.chcNGN.TabIndex = 53
        Me.chcNGN.Text = "NGN"
        Me.chcNGN.UseVisualStyleBackColor = True
        '
        'Program2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.chcNGN)
        Me.Controls.Add(Me.chcCOP)
        Me.Controls.Add(Me.chcCNY)
        Me.Controls.Add(Me.chcEUR)
        Me.Controls.Add(Me.chcUSD)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.Change)
        Me.Controls.Add(Me.lstTransactions)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.txtAmount)
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

    Friend WithEvents lstTransactions As ListBox
    Friend WithEvents btnReset As Button
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Change As Label
    Friend WithEvents btnQuit As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents chcCOP As CheckBox
    Friend WithEvents chcCNY As CheckBox
    Friend WithEvents chcEUR As CheckBox
    Friend WithEvents chcUSD As CheckBox
    Friend WithEvents chcNGN As CheckBox
End Class
