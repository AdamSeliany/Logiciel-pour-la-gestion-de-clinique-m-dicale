<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ordannance
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ordannance))
        Me.pn_ordanance = New System.Windows.Forms.Panel()
        Me.btn_print = New System.Windows.Forms.Button()
        Me.ordo = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.patient_btn = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Qty = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_prix = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TreatNameTb = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.MedChc = New System.Windows.Forms.CheckedListBox()
        Me.pn_ordanance.SuspendLayout()
        CType(Me.ordo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pn_ordanance
        '
        Me.pn_ordanance.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.pn_ordanance.Controls.Add(Me.MedChc)
        Me.pn_ordanance.Controls.Add(Me.btn_print)
        Me.pn_ordanance.Controls.Add(Me.ordo)
        Me.pn_ordanance.Controls.Add(Me.patient_btn)
        Me.pn_ordanance.Controls.Add(Me.Label5)
        Me.pn_ordanance.Controls.Add(Me.Qty)
        Me.pn_ordanance.Controls.Add(Me.Label4)
        Me.pn_ordanance.Controls.Add(Me.btn_prix)
        Me.pn_ordanance.Controls.Add(Me.Label1)
        Me.pn_ordanance.Controls.Add(Me.TreatNameTb)
        Me.pn_ordanance.Controls.Add(Me.Label3)
        Me.pn_ordanance.Controls.Add(Me.Button3)
        Me.pn_ordanance.Controls.Add(Me.Button2)
        Me.pn_ordanance.Controls.Add(Me.Button1)
        Me.pn_ordanance.Controls.Add(Me.Label8)
        Me.pn_ordanance.Controls.Add(Me.Label7)
        Me.pn_ordanance.Controls.Add(Me.Label2)
        Me.pn_ordanance.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pn_ordanance.Location = New System.Drawing.Point(0, 0)
        Me.pn_ordanance.Name = "pn_ordanance"
        Me.pn_ordanance.Size = New System.Drawing.Size(1390, 740)
        Me.pn_ordanance.TabIndex = 0
        '
        'btn_print
        '
        Me.btn_print.Font = New System.Drawing.Font("Eurostile Extended", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_print.Location = New System.Drawing.Point(982, 317)
        Me.btn_print.Name = "btn_print"
        Me.btn_print.Size = New System.Drawing.Size(132, 39)
        Me.btn_print.TabIndex = 81
        Me.btn_print.Text = "Print"
        Me.btn_print.UseVisualStyleBackColor = True
        '
        'ordo
        '
        Me.ordo.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ordo.Location = New System.Drawing.Point(0, 454)
        Me.ordo.MainView = Me.GridView1
        Me.ordo.Name = "ordo"
        Me.ordo.Size = New System.Drawing.Size(1390, 286)
        Me.ordo.TabIndex = 80
        Me.ordo.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.ColumnFilterButton.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.ColumnFilterButton.Options.UseFont = True
        Me.GridView1.Appearance.FixedLine.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.FixedLine.Options.UseFont = True
        Me.GridView1.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 20.25!)
        Me.GridView1.Appearance.Row.Options.UseFont = True
        Me.GridView1.Appearance.SelectedRow.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.SelectedRow.Options.UseFont = True
        Me.GridView1.Appearance.TopNewRow.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.TopNewRow.Options.UseFont = True
        Me.GridView1.Appearance.VertLine.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.VertLine.Options.UseFont = True
        Me.GridView1.GridControl = Me.ordo
        Me.GridView1.Name = "GridView1"
        '
        'patient_btn
        '
        Me.patient_btn.Font = New System.Drawing.Font("Eurostile Extended", 21.75!)
        Me.patient_btn.FormattingEnabled = True
        Me.patient_btn.Location = New System.Drawing.Point(477, 110)
        Me.patient_btn.Name = "patient_btn"
        Me.patient_btn.Size = New System.Drawing.Size(294, 39)
        Me.patient_btn.TabIndex = 79
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Eurostile Extended", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(483, 71)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 26)
        Me.Label5.TabIndex = 78
        Me.Label5.Text = "Patient"
        '
        'Qty
        '
        Me.Qty.Font = New System.Drawing.Font("Eurostile Extended", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Qty.Location = New System.Drawing.Point(477, 214)
        Me.Qty.Name = "Qty"
        Me.Qty.Size = New System.Drawing.Size(294, 40)
        Me.Qty.TabIndex = 77
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Eurostile Extended", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(472, 175)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(137, 26)
        Me.Label4.TabIndex = 76
        Me.Label4.Text = "Quantité"
        '
        'btn_prix
        '
        Me.btn_prix.Enabled = False
        Me.btn_prix.Font = New System.Drawing.Font("Eurostile Extended", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_prix.Location = New System.Drawing.Point(60, 214)
        Me.btn_prix.Name = "btn_prix"
        Me.btn_prix.Size = New System.Drawing.Size(294, 40)
        Me.btn_prix.TabIndex = 74
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Eurostile Extended", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(66, 175)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 26)
        Me.Label1.TabIndex = 73
        Me.Label1.Text = "Prix"
        '
        'TreatNameTb
        '
        Me.TreatNameTb.Enabled = False
        Me.TreatNameTb.Font = New System.Drawing.Font("Eurostile Extended", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreatNameTb.Location = New System.Drawing.Point(60, 109)
        Me.TreatNameTb.Name = "TreatNameTb"
        Me.TreatNameTb.Size = New System.Drawing.Size(294, 40)
        Me.TreatNameTb.TabIndex = 72
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Eurostile Extended", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(66, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(156, 26)
        Me.Label3.TabIndex = 71
        Me.Label3.Text = "Traitment"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.Button3.Font = New System.Drawing.Font("Eurostile Extended", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(408, 316)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(132, 39)
        Me.Button3.TabIndex = 69
        Me.Button3.Text = "Enregister"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Eurostile Extended", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(621, 317)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 39)
        Me.Button2.TabIndex = 68
        Me.Button2.Text = "Modifier"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Eurostile Extended", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(802, 317)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(135, 39)
        Me.Button1.TabIndex = 67
        Me.Button1.Text = "Réinitialiser"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Eurostile Extended", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(555, 391)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(324, 26)
        Me.Label8.TabIndex = 66
        Me.Label8.Text = "Liste des Ordannance"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Eurostile Extended", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(953, 70)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(211, 26)
        Me.Label7.TabIndex = 65
        Me.Label7.Text = "Médicaments"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Eurostile Extended", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(42, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(188, 26)
        Me.Label2.TabIndex = 64
        Me.Label2.Text = "Ordanncane"
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'MedChc
        '
        Me.MedChc.Font = New System.Drawing.Font("Eurostile Extended", 21.75!)
        Me.MedChc.FormattingEnabled = True
        Me.MedChc.Location = New System.Drawing.Point(913, 109)
        Me.MedChc.Name = "MedChc"
        Me.MedChc.Size = New System.Drawing.Size(293, 179)
        Me.MedChc.TabIndex = 87
        '
        'ordannance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1390, 740)
        Me.Controls.Add(Me.pn_ordanance)
        Me.Name = "ordannance"
        Me.Text = "ordannance"
        Me.pn_ordanance.ResumeLayout(False)
        Me.pn_ordanance.PerformLayout()
        CType(Me.ordo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pn_ordanance As Panel
    Friend WithEvents Qty As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_prix As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TreatNameTb As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents patient_btn As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ordo As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btn_print As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents MedChc As CheckedListBox
End Class
