<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.usertxt = New System.Windows.Forms.TextBox()
        Me.passtxt = New System.Windows.Forms.TextBox()
        Me.loginbtn = New System.Windows.Forms.Button()
        Me.exitbtn = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MV Boli", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(69, 249)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "USERNAME:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("MV Boli", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(67, 310)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "PASSWORD:"
        '
        'usertxt
        '
        Me.usertxt.Location = New System.Drawing.Point(563, 250)
        Me.usertxt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.usertxt.Name = "usertxt"
        Me.usertxt.Size = New System.Drawing.Size(193, 22)
        Me.usertxt.TabIndex = 3
        '
        'passtxt
        '
        Me.passtxt.Location = New System.Drawing.Point(563, 313)
        Me.passtxt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.passtxt.Name = "passtxt"
        Me.passtxt.Size = New System.Drawing.Size(193, 22)
        Me.passtxt.TabIndex = 4
        '
        'loginbtn
        '
        Me.loginbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.loginbtn.Font = New System.Drawing.Font("MV Boli", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginbtn.ForeColor = System.Drawing.Color.White
        Me.loginbtn.Location = New System.Drawing.Point(176, 375)
        Me.loginbtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.loginbtn.Name = "loginbtn"
        Me.loginbtn.Size = New System.Drawing.Size(156, 36)
        Me.loginbtn.TabIndex = 6
        Me.loginbtn.Text = "LOGIN"
        Me.loginbtn.UseVisualStyleBackColor = True
        '
        'exitbtn
        '
        Me.exitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.exitbtn.Font = New System.Drawing.Font("MV Boli", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exitbtn.ForeColor = System.Drawing.Color.White
        Me.exitbtn.Location = New System.Drawing.Point(206, 430)
        Me.exitbtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.exitbtn.Name = "exitbtn"
        Me.exitbtn.Size = New System.Drawing.Size(89, 34)
        Me.exitbtn.TabIndex = 7
        Me.exitbtn.Text = "EXIT"
        Me.exitbtn.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Navy
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.loginbtn)
        Me.Panel1.Controls.Add(Me.exitbtn)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Location = New System.Drawing.Point(337, -1)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(509, 492)
        Me.Panel1.TabIndex = 8
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Free_Space.My.Resources.Resources.stthomaslogo_
        Me.PictureBox2.Location = New System.Drawing.Point(10, 23)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(485, 108)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Image = Global.Free_Space.My.Resources.Resources._448562085_861573929336675_8854716818231168218_n
        Me.PictureBox1.Location = New System.Drawing.Point(-43, -1)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(383, 492)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Free_Space.My.Resources.Resources.FreeSpace__1__removebg_preview
        Me.PictureBox3.Location = New System.Drawing.Point(146, 100)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(186, 173)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 8
        Me.PictureBox3.TabStop = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(844, 491)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.passtxt)
        Me.Controls.Add(Me.usertxt)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Login"
        Me.Text = "Login"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents usertxt As TextBox
    Friend WithEvents passtxt As TextBox
    Friend WithEvents loginbtn As Button
    Friend WithEvents exitbtn As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox3 As PictureBox
End Class
