<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class sysAdmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sysAdmin))
        Me.pn_user = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.CameraControl1 = New DevExpress.XtraEditors.Camera.CameraControl()
        Me.nbr = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.pn_user.SuspendLayout()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pn_user
        '
        Me.pn_user.BackColor = System.Drawing.SystemColors.Highlight
        Me.pn_user.Controls.Add(Me.Button2)
        Me.pn_user.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.pn_user.Controls.Add(Me.CameraControl1)
        Me.pn_user.Controls.Add(Me.nbr)
        Me.pn_user.Controls.Add(Me.Button1)
        Me.pn_user.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pn_user.Location = New System.Drawing.Point(0, 0)
        Me.pn_user.Name = "pn_user"
        Me.pn_user.Size = New System.Drawing.Size(1312, 741)
        Me.pn_user.TabIndex = 1
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(1167, 706)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(133, 23)
        Me.Button2.TabIndex = 54
        Me.Button2.Text = "Choisir un video"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(41, 256)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(1226, 337)
        Me.AxWindowsMediaPlayer1.TabIndex = 53
        '
        'CameraControl1
        '
        Me.CameraControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.CameraControl1.Location = New System.Drawing.Point(0, 0)
        Me.CameraControl1.Name = "CameraControl1"
        Me.CameraControl1.Size = New System.Drawing.Size(1312, 250)
        Me.CameraControl1.TabIndex = 52
        Me.CameraControl1.Text = " "
        '
        'nbr
        '
        Me.nbr.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nbr.AutoSize = True
        Me.nbr.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.nbr.Font = New System.Drawing.Font("Eurostile Extended", 89.99999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nbr.Location = New System.Drawing.Point(523, 143)
        Me.nbr.Name = "nbr"
        Me.nbr.Size = New System.Drawing.Size(0, 132)
        Me.nbr.TabIndex = 51
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(12, 615)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(476, 114)
        Me.Button1.TabIndex = 50
        Me.Button1.Text = "Suivant"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'sysAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1312, 741)
        Me.Controls.Add(Me.pn_user)
        Me.Name = "sysAdmin"
        Me.Text = "admin"
        Me.pn_user.ResumeLayout(False)
        Me.pn_user.PerformLayout()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pn_user As Panel
    Friend WithEvents nbr As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents CameraControl1 As DevExpress.XtraEditors.Camera.CameraControl
    Friend WithEvents Button2 As Button
    Public WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
End Class
