Partial Public Class start
    Inherits DevExpress.XtraEditors.XtraForm

    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.pn_start = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.progressbar = New System.Windows.Forms.ProgressBar()
        Me.pn_start.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'pn_start
        '
        Me.pn_start.Controls.Add(Me.Label10)
        Me.pn_start.Controls.Add(Me.Label9)
        Me.pn_start.Controls.Add(Me.Label2)
        Me.pn_start.Controls.Add(Me.progressbar)
        Me.pn_start.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pn_start.Location = New System.Drawing.Point(0, 0)
        Me.pn_start.Name = "pn_start"
        Me.pn_start.Size = New System.Drawing.Size(1000, 594)
        Me.pn_start.TabIndex = 0
        '
        'Label10
        '
        Me.Label10.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Eurostile Extended", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(28, 110)
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
        Me.Label9.Location = New System.Drawing.Point(2, 5)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(990, 105)
        Me.Label9.TabIndex = 55
        Me.Label9.Text = "Cabinet dentaire"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(844, 503)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(148, 14)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "AdamSeliani 2024"
        '
        'progressbar
        '
        Me.progressbar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.progressbar.Location = New System.Drawing.Point(0, 524)
        Me.progressbar.Name = "progressbar"
        Me.progressbar.Size = New System.Drawing.Size(1000, 70)
        Me.progressbar.TabIndex = 53
        '
        'start
        '
        Me.Appearance.ForeColor = System.Drawing.Color.Gray
        Me.Appearance.Options.UseFont = True
        Me.Appearance.Options.UseForeColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 594)
        Me.Controls.Add(Me.pn_start)
        Me.Font = New System.Drawing.Font("Eurostile Extended", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.Name = "start"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.pn_start.ResumeLayout(False)
        Me.pn_start.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents pn_start As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents progressbar As ProgressBar

#End Region

End Class
