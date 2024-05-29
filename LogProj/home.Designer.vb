<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class home
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
        Me.pn_home = New System.Windows.Forms.Panel()
        Me.btn_annulee = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.PatAddr = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.patientdyg = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.btn_del = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Allergies = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Gen = New System.Windows.Forms.ComboBox()
        Me.DOBDate = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PatPhone = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PatName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pn_home.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.patientdyg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pn_home
        '
        Me.pn_home.BackColor = System.Drawing.Color.LemonChiffon
        Me.pn_home.Controls.Add(Me.btn_annulee)
        Me.pn_home.Controls.Add(Me.Label11)
        Me.pn_home.Controls.Add(Me.PatAddr)
        Me.pn_home.Controls.Add(Me.Label10)
        Me.pn_home.Controls.Add(Me.Label9)
        Me.pn_home.Controls.Add(Me.PictureBox1)
        Me.pn_home.Controls.Add(Me.Button1)
        Me.pn_home.Controls.Add(Me.patientdyg)
        Me.pn_home.Controls.Add(Me.btn_save)
        Me.pn_home.Controls.Add(Me.btn_edit)
        Me.pn_home.Controls.Add(Me.btn_del)
        Me.pn_home.Controls.Add(Me.Label8)
        Me.pn_home.Controls.Add(Me.Allergies)
        Me.pn_home.Controls.Add(Me.Label7)
        Me.pn_home.Controls.Add(Me.Gen)
        Me.pn_home.Controls.Add(Me.DOBDate)
        Me.pn_home.Controls.Add(Me.Label6)
        Me.pn_home.Controls.Add(Me.Label5)
        Me.pn_home.Controls.Add(Me.PatPhone)
        Me.pn_home.Controls.Add(Me.Label4)
        Me.pn_home.Controls.Add(Me.PatName)
        Me.pn_home.Controls.Add(Me.Label3)
        Me.pn_home.Controls.Add(Me.Label1)
        Me.pn_home.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pn_home.Location = New System.Drawing.Point(0, 0)
        Me.pn_home.Name = "pn_home"
        Me.pn_home.Size = New System.Drawing.Size(1556, 869)
        Me.pn_home.TabIndex = 0
        '
        'btn_annulee
        '
        Me.btn_annulee.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_annulee.BackColor = System.Drawing.Color.LawnGreen
        Me.btn_annulee.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btn_annulee.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_annulee.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_annulee.Font = New System.Drawing.Font("Eurostile Extended", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_annulee.Location = New System.Drawing.Point(1368, 363)
        Me.btn_annulee.Name = "btn_annulee"
        Me.btn_annulee.Size = New System.Drawing.Size(185, 70)
        Me.btn_annulee.TabIndex = 53
        Me.btn_annulee.Text = "Annulee"
        Me.btn_annulee.UseVisualStyleBackColor = False
        Me.btn_annulee.Visible = False
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Eurostile Extended", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(787, 319)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(150, 26)
        Me.Label11.TabIndex = 52
        Me.Label11.Text = "Address :"
        '
        'PatAddr
        '
        Me.PatAddr.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PatAddr.Font = New System.Drawing.Font("Eurostile Extended", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PatAddr.Location = New System.Drawing.Point(792, 358)
        Me.PatAddr.Multiline = True
        Me.PatAddr.Name = "PatAddr"
        Me.PatAddr.Size = New System.Drawing.Size(398, 226)
        Me.PatAddr.TabIndex = 51
        '
        'Label10
        '
        Me.Label10.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Eurostile Extended", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(245, 117)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(379, 31)
        Me.Label10.TabIndex = 50
        Me.Label10.Text = "Dr.Amar Abd Elkarim"
        '
        'Label9
        '
        Me.Label9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Eurostile Extended", 71.99999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(219, 12)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(990, 105)
        Me.Label9.TabIndex = 49
        Me.Label9.Text = "Cabinet dentaire"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.LogProj.My.Resources.Resources._317468212_457648583218410_453638607965996684_n_removebg_preview
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(189, 148)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 48
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Font = New System.Drawing.Font("Eurostile Extended", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(1365, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(179, 112)
        Me.Button1.TabIndex = 45
        Me.Button1.Text = "Système de file d'attente électronique"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'patientdyg
        '
        Me.patientdyg.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.patientdyg.Location = New System.Drawing.Point(0, 663)
        Me.patientdyg.MainView = Me.GridView1
        Me.patientdyg.Name = "patientdyg"
        Me.patientdyg.Size = New System.Drawing.Size(1556, 206)
        Me.patientdyg.TabIndex = 43
        Me.patientdyg.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.ActiveFilterEnabled = False
        Me.GridView1.Appearance.HeaderPanel.BackColor = System.Drawing.Color.OrangeRed
        Me.GridView1.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GridView1.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.Row.Options.UseFont = True
        Me.GridView1.GridControl = Me.patientdyg
        Me.GridView1.Name = "GridView1"
        '
        'btn_save
        '
        Me.btn_save.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_save.BackColor = System.Drawing.Color.LawnGreen
        Me.btn_save.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btn_save.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_save.Font = New System.Drawing.Font("Eurostile Extended", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.Location = New System.Drawing.Point(1365, 439)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(185, 70)
        Me.btn_save.TabIndex = 42
        Me.btn_save.Text = "Enregister"
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'btn_edit
        '
        Me.btn_edit.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_edit.Font = New System.Drawing.Font("Eurostile Extended", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_edit.Location = New System.Drawing.Point(1365, 515)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(185, 69)
        Me.btn_edit.TabIndex = 41
        Me.btn_edit.Text = "Modifier"
        Me.btn_edit.UseVisualStyleBackColor = True
        Me.btn_edit.Visible = False
        '
        'btn_del
        '
        Me.btn_del.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_del.BackColor = System.Drawing.Color.Red
        Me.btn_del.Font = New System.Drawing.Font("Eurostile Extended", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_del.Location = New System.Drawing.Point(1365, 590)
        Me.btn_del.Name = "btn_del"
        Me.btn_del.Size = New System.Drawing.Size(188, 70)
        Me.btn_del.TabIndex = 40
        Me.btn_del.Text = "Supprime"
        Me.btn_del.UseVisualStyleBackColor = False
        Me.btn_del.Visible = False
        '
        'Label8
        '
        Me.Label8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Eurostile Extended", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(654, 621)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(299, 31)
        Me.Label8.TabIndex = 39
        Me.Label8.Text = "Liste de patients"
        '
        'Allergies
        '
        Me.Allergies.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Allergies.Font = New System.Drawing.Font("Eurostile Extended", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Allergies.Location = New System.Drawing.Point(17, 358)
        Me.Allergies.Multiline = True
        Me.Allergies.Name = "Allergies"
        Me.Allergies.Size = New System.Drawing.Size(398, 226)
        Me.Allergies.TabIndex = 38
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Eurostile Extended", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(23, 319)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(328, 26)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "Maladies Chroniques :"
        '
        'Gen
        '
        Me.Gen.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Gen.Font = New System.Drawing.Font("Eurostile Extended", 21.75!)
        Me.Gen.FormattingEnabled = True
        Me.Gen.Items.AddRange(New Object() {"Homme", "Femme"})
        Me.Gen.Location = New System.Drawing.Point(1011, 222)
        Me.Gen.Name = "Gen"
        Me.Gen.Size = New System.Drawing.Size(179, 39)
        Me.Gen.TabIndex = 36
        '
        'DOBDate
        '
        Me.DOBDate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DOBDate.Font = New System.Drawing.Font("Eurostile Extended", 21.75!)
        Me.DOBDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DOBDate.Location = New System.Drawing.Point(329, 223)
        Me.DOBDate.Name = "DOBDate"
        Me.DOBDate.Size = New System.Drawing.Size(376, 40)
        Me.DOBDate.TabIndex = 35
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Eurostile Extended", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(324, 188)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(275, 26)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "Date de naissance"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Eurostile Extended", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(1006, 188)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 26)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Genre:"
        '
        'PatPhone
        '
        Me.PatPhone.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PatPhone.Font = New System.Drawing.Font("Eurostile Extended", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PatPhone.Location = New System.Drawing.Point(711, 222)
        Me.PatPhone.Name = "PatPhone"
        Me.PatPhone.Size = New System.Drawing.Size(294, 40)
        Me.PatPhone.TabIndex = 32
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Eurostile Extended", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(23, 454)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 26)
        Me.Label4.TabIndex = 30
        '
        'PatName
        '
        Me.PatName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PatName.Font = New System.Drawing.Font("Eurostile Extended", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PatName.Location = New System.Drawing.Point(17, 223)
        Me.PatName.Name = "PatName"
        Me.PatName.Size = New System.Drawing.Size(294, 40)
        Me.PatName.TabIndex = 29
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Eurostile Extended", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 188)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(250, 26)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Nom et Prenom:"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Eurostile Extended", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(706, 188)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 26)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Telephone :"
        '
        'home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1556, 869)
        Me.Controls.Add(Me.pn_home)
        Me.Name = "home"
        Me.Text = "home"
        Me.pn_home.ResumeLayout(False)
        Me.pn_home.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.patientdyg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Public WithEvents pn_home As Panel
    Friend WithEvents patientdyg As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btn_save As Button
    Friend WithEvents btn_edit As Button
    Friend WithEvents btn_del As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Allergies As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Gen As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents PatPhone As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents PatName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents PatAddr As TextBox
    Public WithEvents DOBDate As DateTimePicker
    Friend WithEvents btn_annulee As Button
End Class
