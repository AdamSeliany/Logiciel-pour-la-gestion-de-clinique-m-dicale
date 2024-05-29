<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rendez_vous
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
        Me.pn_rendezvous = New System.Windows.Forms.Panel()
        Me.time_btn = New DevExpress.XtraEditors.TimeEdit()
        Me.rendervous = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.treat_btn = New System.Windows.Forms.ComboBox()
        Me.save_btn = New System.Windows.Forms.Button()
        Me.modifier_btn = New System.Windows.Forms.Button()
        Me.supp_btn = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.patient_btn = New System.Windows.Forms.ComboBox()
        Me.date_btn = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pn_rendezvous.SuspendLayout()
        CType(Me.time_btn.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rendervous, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pn_rendezvous
        '
        Me.pn_rendezvous.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.pn_rendezvous.Controls.Add(Me.time_btn)
        Me.pn_rendezvous.Controls.Add(Me.rendervous)
        Me.pn_rendezvous.Controls.Add(Me.Label1)
        Me.pn_rendezvous.Controls.Add(Me.treat_btn)
        Me.pn_rendezvous.Controls.Add(Me.save_btn)
        Me.pn_rendezvous.Controls.Add(Me.modifier_btn)
        Me.pn_rendezvous.Controls.Add(Me.supp_btn)
        Me.pn_rendezvous.Controls.Add(Me.Label8)
        Me.pn_rendezvous.Controls.Add(Me.Label7)
        Me.pn_rendezvous.Controls.Add(Me.patient_btn)
        Me.pn_rendezvous.Controls.Add(Me.date_btn)
        Me.pn_rendezvous.Controls.Add(Me.Label6)
        Me.pn_rendezvous.Controls.Add(Me.Label3)
        Me.pn_rendezvous.Controls.Add(Me.Label2)
        Me.pn_rendezvous.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pn_rendezvous.Location = New System.Drawing.Point(0, 0)
        Me.pn_rendezvous.Name = "pn_rendezvous"
        Me.pn_rendezvous.Size = New System.Drawing.Size(1390, 740)
        Me.pn_rendezvous.TabIndex = 0
        '
        'time_btn
        '
        Me.time_btn.EditValue = New Date(2024, 2, 22, 0, 0, 0, 0)
        Me.time_btn.Location = New System.Drawing.Point(399, 228)
        Me.time_btn.Name = "time_btn"
        Me.time_btn.Properties.Appearance.Font = New System.Drawing.Font("Eurostile Extended", 21.75!)
        Me.time_btn.Properties.Appearance.Options.UseFont = True
        Me.time_btn.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.time_btn.Size = New System.Drawing.Size(275, 38)
        Me.time_btn.TabIndex = 48
        '
        'rendervous
        '
        Me.rendervous.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.rendervous.Location = New System.Drawing.Point(0, 454)
        Me.rendervous.MainView = Me.GridView1
        Me.rendervous.Name = "rendervous"
        Me.rendervous.Size = New System.Drawing.Size(1390, 286)
        Me.rendervous.TabIndex = 47
        Me.rendervous.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 20.25!)
        Me.GridView1.Appearance.Row.Options.UseFont = True
        Me.GridView1.GridControl = Me.rendervous
        Me.GridView1.Name = "GridView1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Eurostile Extended", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(268, 240)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 26)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "Time"
        '
        'treat_btn
        '
        Me.treat_btn.Font = New System.Drawing.Font("Eurostile Extended", 21.75!)
        Me.treat_btn.FormattingEnabled = True
        Me.treat_btn.Location = New System.Drawing.Point(921, 116)
        Me.treat_btn.Name = "treat_btn"
        Me.treat_btn.Size = New System.Drawing.Size(294, 39)
        Me.treat_btn.TabIndex = 44
        '
        'save_btn
        '
        Me.save_btn.Font = New System.Drawing.Font("Eurostile Extended", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.save_btn.Location = New System.Drawing.Point(383, 317)
        Me.save_btn.Name = "save_btn"
        Me.save_btn.Size = New System.Drawing.Size(132, 39)
        Me.save_btn.TabIndex = 42
        Me.save_btn.Text = "Enregister"
        Me.save_btn.UseVisualStyleBackColor = True
        '
        'modifier_btn
        '
        Me.modifier_btn.Font = New System.Drawing.Font("Eurostile Extended", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.modifier_btn.Location = New System.Drawing.Point(596, 318)
        Me.modifier_btn.Name = "modifier_btn"
        Me.modifier_btn.Size = New System.Drawing.Size(100, 39)
        Me.modifier_btn.TabIndex = 41
        Me.modifier_btn.Text = "Modifier"
        Me.modifier_btn.UseVisualStyleBackColor = True
        '
        'supp_btn
        '
        Me.supp_btn.Font = New System.Drawing.Font("Eurostile Extended", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.supp_btn.Location = New System.Drawing.Point(777, 318)
        Me.supp_btn.Name = "supp_btn"
        Me.supp_btn.Size = New System.Drawing.Size(125, 39)
        Me.supp_btn.TabIndex = 40
        Me.supp_btn.Text = "Supprime"
        Me.supp_btn.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Eurostile Extended", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(530, 392)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(250, 26)
        Me.Label8.TabIndex = 39
        Me.Label8.Text = "Liste de patients"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Eurostile Extended", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(973, 71)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(168, 26)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "Treatment"
        '
        'patient_btn
        '
        Me.patient_btn.Font = New System.Drawing.Font("Eurostile Extended", 21.75!)
        Me.patient_btn.FormattingEnabled = True
        Me.patient_btn.Location = New System.Drawing.Point(12, 116)
        Me.patient_btn.Name = "patient_btn"
        Me.patient_btn.Size = New System.Drawing.Size(294, 39)
        Me.patient_btn.TabIndex = 36
        '
        'date_btn
        '
        Me.date_btn.Font = New System.Drawing.Font("Eurostile Extended", 21.75!)
        Me.date_btn.Location = New System.Drawing.Point(399, 116)
        Me.date_btn.Name = "date_btn"
        Me.date_btn.Size = New System.Drawing.Size(381, 40)
        Me.date_btn.TabIndex = 35
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Eurostile Extended", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(530, 71)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 26)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "Date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Eurostile Extended", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(85, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 26)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Patient"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Eurostile Extended", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(198, 26)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Rendez-Vous"
        '
        'rendez_vous
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1390, 740)
        Me.Controls.Add(Me.pn_rendezvous)
        Me.Name = "rendez_vous"
        Me.Text = "rendez_vous"
        Me.pn_rendezvous.ResumeLayout(False)
        Me.pn_rendezvous.PerformLayout()
        CType(Me.time_btn.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rendervous, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pn_rendezvous As Panel
    Friend WithEvents save_btn As Button
    Friend WithEvents modifier_btn As Button
    Friend WithEvents supp_btn As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents patient_btn As ComboBox
    Friend WithEvents date_btn As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents treat_btn As ComboBox
    Friend WithEvents rendervous As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents time_btn As DevExpress.XtraEditors.TimeEdit
End Class
