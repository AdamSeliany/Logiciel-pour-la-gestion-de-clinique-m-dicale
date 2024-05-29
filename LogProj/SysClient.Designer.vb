<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SysClient
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SysClient))
        Me.pn_client = New System.Windows.Forms.Panel()
        Me.lab_client = New System.Windows.Forms.Label()
        Me.AxWindowsMediaPlayer2 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pn_client.SuspendLayout()
        CType(Me.AxWindowsMediaPlayer2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pn_client
        '
        Me.pn_client.Controls.Add(Me.Label1)
        Me.pn_client.Controls.Add(Me.PictureBox1)
        Me.pn_client.Controls.Add(Me.Label10)
        Me.pn_client.Controls.Add(Me.Label9)
        Me.pn_client.Controls.Add(Me.AxWindowsMediaPlayer2)
        Me.pn_client.Controls.Add(Me.lab_client)
        Me.pn_client.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pn_client.Location = New System.Drawing.Point(0, 0)
        Me.pn_client.Name = "pn_client"
        Me.pn_client.Size = New System.Drawing.Size(1400, 767)
        Me.pn_client.TabIndex = 0
        '
        'lab_client
        '
        Me.lab_client.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lab_client.AutoSize = True
        Me.lab_client.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lab_client.Font = New System.Drawing.Font("Eurostile Extended", 89.99999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lab_client.Location = New System.Drawing.Point(127, 474)
        Me.lab_client.Name = "lab_client"
        Me.lab_client.Size = New System.Drawing.Size(257, 132)
        Me.lab_client.TabIndex = 50
        Me.lab_client.Text = "32"
        '
        'AxWindowsMediaPlayer2
        '
        Me.AxWindowsMediaPlayer2.Enabled = True
        Me.AxWindowsMediaPlayer2.Location = New System.Drawing.Point(503, 194)
        Me.AxWindowsMediaPlayer2.Name = "AxWindowsMediaPlayer2"
        Me.AxWindowsMediaPlayer2.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer2.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer2.Size = New System.Drawing.Size(894, 570)
        Me.AxWindowsMediaPlayer2.TabIndex = 54
        '
        'Label10
        '
        Me.Label10.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Eurostile Extended", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(245, 126)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(379, 31)
        Me.Label10.TabIndex = 56
        Me.Label10.Text = "Dr.Amar Abd Elkarim"
        '
        'Label9
        '
        Me.Label9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Eurostile Extended", 71.99999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(223, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(990, 105)
        Me.Label9.TabIndex = 55
        Me.Label9.Text = "Cabinet dentaire"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.LogProj.My.Resources.Resources._317468212_457648583218410_453638607965996684_n_removebg_preview
        Me.PictureBox1.Location = New System.Drawing.Point(28, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(189, 148)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 57
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 307)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(467, 109)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "Ticket N="
        '
        'SysClient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(1400, 767)
        Me.Controls.Add(Me.pn_client)
        Me.Name = "SysClient"
        Me.Text = "client"
        Me.pn_client.ResumeLayout(False)
        Me.pn_client.PerformLayout()
        CType(Me.AxWindowsMediaPlayer2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lab_client As Label
    Friend WithEvents AxWindowsMediaPlayer2 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Public WithEvents pn_client As Panel
End Class
