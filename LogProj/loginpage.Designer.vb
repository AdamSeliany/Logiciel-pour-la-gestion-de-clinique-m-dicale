<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class loginpage
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
        Me.pn_login = New System.Windows.Forms.Panel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.password = New System.Windows.Forms.TextBox()
        Me.username = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pn_login.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pn_login
        '
        Me.pn_login.Controls.Add(Me.LinkLabel1)
        Me.pn_login.Controls.Add(Me.Button1)
        Me.pn_login.Controls.Add(Me.Label3)
        Me.pn_login.Controls.Add(Me.Label2)
        Me.pn_login.Controls.Add(Me.password)
        Me.pn_login.Controls.Add(Me.username)
        Me.pn_login.Controls.Add(Me.Label1)
        Me.pn_login.Controls.Add(Me.Panel1)
        Me.pn_login.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pn_login.Location = New System.Drawing.Point(0, 0)
        Me.pn_login.Name = "pn_login"
        Me.pn_login.Size = New System.Drawing.Size(1146, 559)
        Me.pn_login.TabIndex = 0
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Eurostile Extended", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(725, 441)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(134, 14)
        Me.LinkLabel1.TabIndex = 17
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "il y'a un problem?"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Eurostile Extended", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(744, 384)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 39)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Log In"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Eurostile Extended", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(457, 313)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(220, 26)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Mot de Passe:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Eurostile Extended", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(482, 228)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(180, 26)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "UserName:"
        '
        'password
        '
        Me.password.Font = New System.Drawing.Font("Eurostile Extended", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.password.Location = New System.Drawing.Point(677, 306)
        Me.password.Name = "password"
        Me.password.Size = New System.Drawing.Size(294, 40)
        Me.password.TabIndex = 13
        '
        'username
        '
        Me.username.Font = New System.Drawing.Font("Eurostile Extended", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.username.Location = New System.Drawing.Point(677, 228)
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(294, 40)
        Me.username.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Eurostile Extended", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(419, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(535, 140)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Système de" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "         la gestion"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(395, 559)
        Me.Panel1.TabIndex = 9
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.LogProj.My.Resources.Resources._317468212_457648583218410_453638607965996684_n_removebg_preview1
        Me.PictureBox2.Location = New System.Drawing.Point(42, 254)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(308, 265)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Franklin Gothic Medium", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(32, 60)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(320, 30)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "الجمهورية الجزائرية الديمقراطية الشعبية"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Franklin Gothic Medium", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(23, 100)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(356, 30)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "وزارة الصحة و السكان و إصلاح المستشفيات"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Franklin Gothic Medium", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(45, 141)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(255, 30)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "عيادة الأسنان -الحكيم زين الدين"
        '
        'loginpage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1146, 559)
        Me.Controls.Add(Me.pn_login)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "loginpage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "loginpage"
        Me.pn_login.ResumeLayout(False)
        Me.pn_login.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pn_login As Panel
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents password As TextBox
    Friend WithEvents username As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox2 As PictureBox
End Class
