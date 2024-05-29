<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class treatments
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
        Me.enregister_btn = New System.Windows.Forms.Button()
        Me.modifier_btn = New System.Windows.Forms.Button()
        Me.supp_btn = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TrName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TrPrix = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TrDesc = New System.Windows.Forms.TextBox()
        Me.pn_traitment = New System.Windows.Forms.Panel()
        Me.treatmentdyg = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.pn_traitment.SuspendLayout()
        CType(Me.treatmentdyg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'enregister_btn
        '
        Me.enregister_btn.BackColor = System.Drawing.Color.SpringGreen
        Me.enregister_btn.Font = New System.Drawing.Font("Eurostile Extended", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.enregister_btn.Location = New System.Drawing.Point(410, 341)
        Me.enregister_btn.Name = "enregister_btn"
        Me.enregister_btn.Size = New System.Drawing.Size(132, 39)
        Me.enregister_btn.TabIndex = 56
        Me.enregister_btn.Text = "Enregister"
        Me.enregister_btn.UseVisualStyleBackColor = False
        '
        'modifier_btn
        '
        Me.modifier_btn.Font = New System.Drawing.Font("Eurostile Extended", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.modifier_btn.Location = New System.Drawing.Point(653, 341)
        Me.modifier_btn.Name = "modifier_btn"
        Me.modifier_btn.Size = New System.Drawing.Size(100, 39)
        Me.modifier_btn.TabIndex = 55
        Me.modifier_btn.Text = "Modifier"
        Me.modifier_btn.UseVisualStyleBackColor = True
        '
        'supp_btn
        '
        Me.supp_btn.BackColor = System.Drawing.Color.Crimson
        Me.supp_btn.Font = New System.Drawing.Font("Eurostile Extended", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.supp_btn.Location = New System.Drawing.Point(880, 341)
        Me.supp_btn.Name = "supp_btn"
        Me.supp_btn.Size = New System.Drawing.Size(125, 39)
        Me.supp_btn.TabIndex = 54
        Me.supp_btn.Text = "Supprime"
        Me.supp_btn.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Eurostile Extended", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(578, 406)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(270, 26)
        Me.Label8.TabIndex = 53
        Me.Label8.Text = "Liste de traitment"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Eurostile Extended", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(1000, 79)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(180, 26)
        Me.Label7.TabIndex = 52
        Me.Label7.Text = "Discreption"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Eurostile Extended", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(35, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(173, 26)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "Traitments"
        '
        'TrName
        '
        Me.TrName.Font = New System.Drawing.Font("Eurostile Extended", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TrName.Location = New System.Drawing.Point(53, 118)
        Me.TrName.Name = "TrName"
        Me.TrName.Size = New System.Drawing.Size(294, 40)
        Me.TrName.TabIndex = 60
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Eurostile Extended", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(59, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 26)
        Me.Label3.TabIndex = 59
        Me.Label3.Text = "Name"
        '
        'TrPrix
        '
        Me.TrPrix.Font = New System.Drawing.Font("Eurostile Extended", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TrPrix.Location = New System.Drawing.Point(459, 118)
        Me.TrPrix.Name = "TrPrix"
        Me.TrPrix.Size = New System.Drawing.Size(294, 40)
        Me.TrPrix.TabIndex = 62
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Eurostile Extended", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(465, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 26)
        Me.Label1.TabIndex = 61
        Me.Label1.Text = "Prix(DA)"
        '
        'TrDesc
        '
        Me.TrDesc.Font = New System.Drawing.Font("Eurostile Extended", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TrDesc.Location = New System.Drawing.Point(983, 134)
        Me.TrDesc.Multiline = True
        Me.TrDesc.Name = "TrDesc"
        Me.TrDesc.Size = New System.Drawing.Size(294, 149)
        Me.TrDesc.TabIndex = 63
        '
        'pn_traitment
        '
        Me.pn_traitment.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.pn_traitment.Controls.Add(Me.treatmentdyg)
        Me.pn_traitment.Controls.Add(Me.TrPrix)
        Me.pn_traitment.Controls.Add(Me.TrDesc)
        Me.pn_traitment.Controls.Add(Me.Label1)
        Me.pn_traitment.Controls.Add(Me.Label8)
        Me.pn_traitment.Controls.Add(Me.TrName)
        Me.pn_traitment.Controls.Add(Me.enregister_btn)
        Me.pn_traitment.Controls.Add(Me.Label3)
        Me.pn_traitment.Controls.Add(Me.modifier_btn)
        Me.pn_traitment.Controls.Add(Me.Label2)
        Me.pn_traitment.Controls.Add(Me.Label7)
        Me.pn_traitment.Controls.Add(Me.supp_btn)
        Me.pn_traitment.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pn_traitment.Location = New System.Drawing.Point(0, 0)
        Me.pn_traitment.Name = "pn_traitment"
        Me.pn_traitment.Size = New System.Drawing.Size(1390, 740)
        Me.pn_traitment.TabIndex = 64
        '
        'treatmentdyg
        '
        Me.treatmentdyg.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.treatmentdyg.EmbeddedNavigator.Buttons.Edit.Enabled = False
        Me.treatmentdyg.Location = New System.Drawing.Point(0, 454)
        Me.treatmentdyg.MainView = Me.GridView1
        Me.treatmentdyg.Name = "treatmentdyg"
        Me.treatmentdyg.Size = New System.Drawing.Size(1390, 286)
        Me.treatmentdyg.TabIndex = 64
        Me.treatmentdyg.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 20.25!)
        Me.GridView1.Appearance.Row.Options.UseFont = True
        Me.GridView1.GridControl = Me.treatmentdyg
        Me.GridView1.Name = "GridView1"
        '
        'treatments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1390, 740)
        Me.Controls.Add(Me.pn_traitment)
        Me.Name = "treatments"
        Me.Text = "treatments"
        Me.pn_traitment.ResumeLayout(False)
        Me.pn_traitment.PerformLayout()
        CType(Me.treatmentdyg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents enregister_btn As Button
    Friend WithEvents modifier_btn As Button
    Friend WithEvents supp_btn As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TrName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TrPrix As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TrDesc As TextBox
    Public WithEvents pn_traitment As Panel
    Friend WithEvents treatmentdyg As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
End Class
