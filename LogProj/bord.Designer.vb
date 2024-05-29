<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class bord
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
        Me.components = New System.ComponentModel.Container()
        Me.pn_bord = New System.Windows.Forms.Panel()
        Me.DentistDbVbDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DentistDbVbDataSet = New LogProj.DentistDbVbDataSet()
        Me.patient = New System.Windows.Forms.Label()
        Me.traitment = New System.Windows.Forms.Label()
        Me.ordannance = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pn_bord.SuspendLayout()
        CType(Me.DentistDbVbDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DentistDbVbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pn_bord
        '
        Me.pn_bord.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.pn_bord.Controls.Add(Me.patient)
        Me.pn_bord.Controls.Add(Me.traitment)
        Me.pn_bord.Controls.Add(Me.ordannance)
        Me.pn_bord.Controls.Add(Me.Label3)
        Me.pn_bord.Controls.Add(Me.Label2)
        Me.pn_bord.Controls.Add(Me.Label1)
        Me.pn_bord.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pn_bord.Location = New System.Drawing.Point(0, 0)
        Me.pn_bord.Name = "pn_bord"
        Me.pn_bord.Size = New System.Drawing.Size(1312, 726)
        Me.pn_bord.TabIndex = 0
        '
        'DentistDbVbDataSetBindingSource
        '
        Me.DentistDbVbDataSetBindingSource.DataSource = Me.DentistDbVbDataSet
        Me.DentistDbVbDataSetBindingSource.Position = 0
        '
        'DentistDbVbDataSet
        '
        Me.DentistDbVbDataSet.DataSetName = "DentistDbVbDataSet"
        Me.DentistDbVbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'patient
        '
        Me.patient.AutoSize = True
        Me.patient.Font = New System.Drawing.Font("Eurostile Extended", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.patient.Location = New System.Drawing.Point(752, 184)
        Me.patient.Name = "patient"
        Me.patient.Size = New System.Drawing.Size(83, 38)
        Me.patient.TabIndex = 5
        Me.patient.Text = "null"
        '
        'traitment
        '
        Me.traitment.AutoSize = True
        Me.traitment.Font = New System.Drawing.Font("Eurostile Extended", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.traitment.Location = New System.Drawing.Point(752, 280)
        Me.traitment.Name = "traitment"
        Me.traitment.Size = New System.Drawing.Size(83, 38)
        Me.traitment.TabIndex = 4
        Me.traitment.Text = "null"
        '
        'ordannance
        '
        Me.ordannance.AutoSize = True
        Me.ordannance.Font = New System.Drawing.Font("Eurostile Extended", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ordannance.Location = New System.Drawing.Point(752, 374)
        Me.ordannance.Name = "ordannance"
        Me.ordannance.Size = New System.Drawing.Size(83, 38)
        Me.ordannance.TabIndex = 3
        Me.ordannance.Text = "null"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Eurostile Extended", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(409, 280)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(266, 38)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Treaitment:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Eurostile Extended", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(409, 374)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(263, 38)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Ordannace:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Eurostile Extended", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(409, 181)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(217, 38)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Patients :"
        '
        'bord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1312, 726)
        Me.Controls.Add(Me.pn_bord)
        Me.Name = "bord"
        Me.Text = "bord"
        Me.pn_bord.ResumeLayout(False)
        Me.pn_bord.PerformLayout()
        CType(Me.DentistDbVbDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DentistDbVbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pn_bord As Panel
    Friend WithEvents patient As Label
    Friend WithEvents ordannance As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Public WithEvents traitment As Label
    Friend WithEvents DentistDbVbDataSetBindingSource As BindingSource
    Friend WithEvents DentistDbVbDataSet As DentistDbVbDataSet
End Class
