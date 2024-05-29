<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class med
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.pn_med = New System.Windows.Forms.Panel()
        Me.medyg = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.MedPrix = New System.Windows.Forms.TextBox()
        Me.MedDesc = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.medName = New System.Windows.Forms.TextBox()
        Me.enregister_btn = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.modifier_btn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.supp_btn = New System.Windows.Forms.Button()
        Me.pn_med.SuspendLayout()
        CType(Me.medyg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pn_med
        '
        Me.pn_med.Controls.Add(Me.medyg)
        Me.pn_med.Controls.Add(Me.MedPrix)
        Me.pn_med.Controls.Add(Me.MedDesc)
        Me.pn_med.Controls.Add(Me.Label1)
        Me.pn_med.Controls.Add(Me.Label8)
        Me.pn_med.Controls.Add(Me.medName)
        Me.pn_med.Controls.Add(Me.enregister_btn)
        Me.pn_med.Controls.Add(Me.Label3)
        Me.pn_med.Controls.Add(Me.modifier_btn)
        Me.pn_med.Controls.Add(Me.Label2)
        Me.pn_med.Controls.Add(Me.Label7)
        Me.pn_med.Controls.Add(Me.supp_btn)
        Me.pn_med.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pn_med.Location = New System.Drawing.Point(0, 0)
        Me.pn_med.Name = "pn_med"
        Me.pn_med.Size = New System.Drawing.Size(1313, 771)
        Me.pn_med.TabIndex = 0
        '
        'medyg
        '
        Me.medyg.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.medyg.EmbeddedNavigator.Buttons.Edit.Enabled = False
        Me.medyg.Location = New System.Drawing.Point(0, 485)
        Me.medyg.MainView = Me.GridView1
        Me.medyg.Name = "medyg"
        Me.medyg.Size = New System.Drawing.Size(1313, 286)
        Me.medyg.TabIndex = 76
        Me.medyg.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 20.25!)
        Me.GridView1.Appearance.Row.Options.UseFont = True
        Me.GridView1.GridControl = Me.medyg
        Me.GridView1.Name = "GridView1"
        '
        'MedPrix
        '
        Me.MedPrix.Font = New System.Drawing.Font("Eurostile Extended", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MedPrix.Location = New System.Drawing.Point(425, 115)
        Me.MedPrix.Name = "MedPrix"
        Me.MedPrix.Size = New System.Drawing.Size(294, 40)
        Me.MedPrix.TabIndex = 74
        '
        'MedDesc
        '
        Me.MedDesc.Font = New System.Drawing.Font("Eurostile Extended", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MedDesc.Location = New System.Drawing.Point(907, 122)
        Me.MedDesc.Multiline = True
        Me.MedDesc.Name = "MedDesc"
        Me.MedDesc.Size = New System.Drawing.Size(294, 149)
        Me.MedDesc.TabIndex = 75
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Eurostile Extended", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(431, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 26)
        Me.Label1.TabIndex = 73
        Me.Label1.Text = "Prix(DA)"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Eurostile Extended", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(496, 441)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(311, 26)
        Me.Label8.TabIndex = 67
        Me.Label8.Text = "Liste de medicament"
        '
        'medName
        '
        Me.medName.Font = New System.Drawing.Font("Eurostile Extended", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.medName.Location = New System.Drawing.Point(30, 115)
        Me.medName.Name = "medName"
        Me.medName.Size = New System.Drawing.Size(294, 40)
        Me.medName.TabIndex = 72
        '
        'enregister_btn
        '
        Me.enregister_btn.BackColor = System.Drawing.Color.SpringGreen
        Me.enregister_btn.Font = New System.Drawing.Font("Eurostile Extended", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.enregister_btn.Location = New System.Drawing.Point(334, 329)
        Me.enregister_btn.Name = "enregister_btn"
        Me.enregister_btn.Size = New System.Drawing.Size(132, 39)
        Me.enregister_btn.TabIndex = 70
        Me.enregister_btn.Text = "Enregister"
        Me.enregister_btn.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Eurostile Extended", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(36, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 26)
        Me.Label3.TabIndex = 71
        Me.Label3.Text = "Name"
        '
        'modifier_btn
        '
        Me.modifier_btn.Font = New System.Drawing.Font("Eurostile Extended", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.modifier_btn.Location = New System.Drawing.Point(577, 329)
        Me.modifier_btn.Name = "modifier_btn"
        Me.modifier_btn.Size = New System.Drawing.Size(100, 39)
        Me.modifier_btn.TabIndex = 69
        Me.modifier_btn.Text = "Modifier"
        Me.modifier_btn.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Eurostile Extended", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(192, 26)
        Me.Label2.TabIndex = 65
        Me.Label2.Text = "medicament"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Eurostile Extended", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(924, 67)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(180, 26)
        Me.Label7.TabIndex = 66
        Me.Label7.Text = "Discreption"
        '
        'supp_btn
        '
        Me.supp_btn.BackColor = System.Drawing.Color.Crimson
        Me.supp_btn.Font = New System.Drawing.Font("Eurostile Extended", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.supp_btn.Location = New System.Drawing.Point(804, 329)
        Me.supp_btn.Name = "supp_btn"
        Me.supp_btn.Size = New System.Drawing.Size(125, 39)
        Me.supp_btn.TabIndex = 68
        Me.supp_btn.Text = "Supprime"
        Me.supp_btn.UseVisualStyleBackColor = False
        '
        'med
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1313, 771)
        Me.Controls.Add(Me.pn_med)
        Me.Name = "med"
        Me.Text = "med"
        Me.pn_med.ResumeLayout(False)
        Me.pn_med.PerformLayout()
        CType(Me.medyg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pn_med As Panel
    Friend WithEvents medyg As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents MedPrix As TextBox
    Friend WithEvents MedDesc As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents medName As TextBox
    Friend WithEvents enregister_btn As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents modifier_btn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents supp_btn As Button
End Class
