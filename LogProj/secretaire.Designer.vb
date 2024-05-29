<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class secretaire
    Inherits DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm

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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(secretaire))
        Me.FluentDesignFormContainer1 = New DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer()
        Me.AccordionControl2 = New DevExpress.XtraBars.Navigation.AccordionControl()
        Me.btn_pat = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.AccordionControlSeparator1 = New DevExpress.XtraBars.Navigation.AccordionControlSeparator()
        Me.AccordionControlSeparator4 = New DevExpress.XtraBars.Navigation.AccordionControlSeparator()
        Me.btn_rendez = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.AccordionControlSeparator3 = New DevExpress.XtraBars.Navigation.AccordionControlSeparator()
        Me.AccordionControlSeparator5 = New DevExpress.XtraBars.Navigation.AccordionControlSeparator()
        Me.btn_ordonnance = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.AccordionControlSeparator6 = New DevExpress.XtraBars.Navigation.AccordionControlSeparator()
        Me.AccordionControlSeparator7 = New DevExpress.XtraBars.Navigation.AccordionControlSeparator()
        Me.AccordionControlSeparator8 = New DevExpress.XtraBars.Navigation.AccordionControlSeparator()
        Me.btn_parametre = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.FluentDesignFormControl1 = New DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl()
        Me.FluentFormDefaultManager1 = New DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager(Me.components)
        Me.pn_container = New System.Windows.Forms.Panel()
        Me.FluentDesignFormContainer1.SuspendLayout()
        CType(Me.AccordionControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FluentDesignFormControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FluentFormDefaultManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FluentDesignFormContainer1
        '
        Me.FluentDesignFormContainer1.Controls.Add(Me.pn_container)
        Me.FluentDesignFormContainer1.Controls.Add(Me.AccordionControl2)
        Me.FluentDesignFormContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FluentDesignFormContainer1.Location = New System.Drawing.Point(0, 31)
        Me.FluentDesignFormContainer1.Margin = New System.Windows.Forms.Padding(2)
        Me.FluentDesignFormContainer1.Name = "FluentDesignFormContainer1"
        Me.FluentDesignFormContainer1.Size = New System.Drawing.Size(1038, 586)
        Me.FluentDesignFormContainer1.TabIndex = 0
        '
        'AccordionControl2
        '
        Me.AccordionControl2.Dock = System.Windows.Forms.DockStyle.Left
        Me.AccordionControl2.Elements.AddRange(New DevExpress.XtraBars.Navigation.AccordionControlElement() {Me.btn_pat, Me.AccordionControlSeparator4, Me.btn_rendez, Me.AccordionControlSeparator3, Me.AccordionControlSeparator5, Me.btn_ordonnance, Me.AccordionControlSeparator6, Me.AccordionControlSeparator7, Me.AccordionControlSeparator8, Me.btn_parametre})
        Me.AccordionControl2.Location = New System.Drawing.Point(0, 0)
        Me.AccordionControl2.Margin = New System.Windows.Forms.Padding(2)
        Me.AccordionControl2.Name = "AccordionControl2"
        Me.AccordionControl2.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch
        Me.AccordionControl2.Size = New System.Drawing.Size(289, 586)
        Me.AccordionControl2.TabIndex = 2
        Me.AccordionControl2.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu
        '
        'btn_pat
        '
        Me.btn_pat.Appearance.Normal.Font = New System.Drawing.Font("Eurostile Extended", 18.0!)
        Me.btn_pat.Appearance.Normal.Options.UseFont = True
        Me.btn_pat.Elements.AddRange(New DevExpress.XtraBars.Navigation.AccordionControlElement() {Me.AccordionControlSeparator1})
        Me.btn_pat.ImageOptions.Image = CType(resources.GetObject("btn_pat.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_pat.Name = "btn_pat"
        Me.btn_pat.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.btn_pat.Text = "Patients"
        '
        'AccordionControlSeparator1
        '
        Me.AccordionControlSeparator1.Name = "AccordionControlSeparator1"
        Me.AccordionControlSeparator1.Visible = False
        '
        'AccordionControlSeparator4
        '
        Me.AccordionControlSeparator4.Name = "AccordionControlSeparator4"
        '
        'btn_rendez
        '
        Me.btn_rendez.Appearance.Normal.Font = New System.Drawing.Font("Eurostile Extended", 18.0!)
        Me.btn_rendez.Appearance.Normal.Options.UseFont = True
        Me.btn_rendez.ImageOptions.Image = CType(resources.GetObject("btn_rendez.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_rendez.Name = "btn_rendez"
        Me.btn_rendez.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.btn_rendez.Text = "Rendez-vous"
        '
        'AccordionControlSeparator3
        '
        Me.AccordionControlSeparator3.Name = "AccordionControlSeparator3"
        '
        'AccordionControlSeparator5
        '
        Me.AccordionControlSeparator5.Name = "AccordionControlSeparator5"
        '
        'btn_ordonnance
        '
        Me.btn_ordonnance.Appearance.Normal.Font = New System.Drawing.Font("Eurostile Extended", 18.0!)
        Me.btn_ordonnance.Appearance.Normal.Options.UseFont = True
        Me.btn_ordonnance.ImageOptions.Image = CType(resources.GetObject("btn_ordonnance.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_ordonnance.Name = "btn_ordonnance"
        Me.btn_ordonnance.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.btn_ordonnance.Text = "Ordannance"
        '
        'AccordionControlSeparator6
        '
        Me.AccordionControlSeparator6.Name = "AccordionControlSeparator6"
        '
        'AccordionControlSeparator7
        '
        Me.AccordionControlSeparator7.Name = "AccordionControlSeparator7"
        '
        'AccordionControlSeparator8
        '
        Me.AccordionControlSeparator8.Name = "AccordionControlSeparator8"
        '
        'btn_parametre
        '
        Me.btn_parametre.Appearance.Normal.Font = New System.Drawing.Font("Eurostile Extended", 18.0!)
        Me.btn_parametre.Appearance.Normal.Options.UseFont = True
        Me.btn_parametre.ImageOptions.Image = CType(resources.GetObject("btn_parametre.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_parametre.Name = "btn_parametre"
        Me.btn_parametre.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.btn_parametre.Text = "Parametre"
        '
        'FluentDesignFormControl1
        '
        Me.FluentDesignFormControl1.FluentDesignForm = Me
        Me.FluentDesignFormControl1.Location = New System.Drawing.Point(0, 0)
        Me.FluentDesignFormControl1.Manager = Me.FluentFormDefaultManager1
        Me.FluentDesignFormControl1.Margin = New System.Windows.Forms.Padding(2)
        Me.FluentDesignFormControl1.Name = "FluentDesignFormControl1"
        Me.FluentDesignFormControl1.Size = New System.Drawing.Size(1038, 31)
        Me.FluentDesignFormControl1.TabIndex = 2
        Me.FluentDesignFormControl1.TabStop = False
        '
        'FluentFormDefaultManager1
        '
        Me.FluentFormDefaultManager1.DockingEnabled = False
        Me.FluentFormDefaultManager1.Form = Me
        '
        'pn_container
        '
        Me.pn_container.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pn_container.Location = New System.Drawing.Point(289, 0)
        Me.pn_container.Name = "pn_container"
        Me.pn_container.Size = New System.Drawing.Size(749, 586)
        Me.pn_container.TabIndex = 3
        '
        'secretaire
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1038, 617)
        Me.ControlContainer = Me.FluentDesignFormContainer1
        Me.Controls.Add(Me.FluentDesignFormContainer1)
        Me.Controls.Add(Me.FluentDesignFormControl1)
        Me.FluentDesignFormControl = Me.FluentDesignFormControl1
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "secretaire"
        Me.Text = "secretaire"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.FluentDesignFormContainer1.ResumeLayout(False)
        CType(Me.AccordionControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FluentDesignFormControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FluentFormDefaultManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FluentDesignFormContainer1 As DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer
    Friend WithEvents FluentDesignFormControl1 As DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl
    Friend WithEvents FluentFormDefaultManager1 As DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager
    Friend WithEvents AccordionControl2 As DevExpress.XtraBars.Navigation.AccordionControl
    Friend WithEvents btn_pat As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents AccordionControlSeparator1 As DevExpress.XtraBars.Navigation.AccordionControlSeparator
    Friend WithEvents AccordionControlSeparator4 As DevExpress.XtraBars.Navigation.AccordionControlSeparator
    Friend WithEvents btn_rendez As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents AccordionControlSeparator3 As DevExpress.XtraBars.Navigation.AccordionControlSeparator
    Friend WithEvents AccordionControlSeparator5 As DevExpress.XtraBars.Navigation.AccordionControlSeparator
    Friend WithEvents btn_ordonnance As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents AccordionControlSeparator6 As DevExpress.XtraBars.Navigation.AccordionControlSeparator
    Friend WithEvents AccordionControlSeparator7 As DevExpress.XtraBars.Navigation.AccordionControlSeparator
    Friend WithEvents AccordionControlSeparator8 As DevExpress.XtraBars.Navigation.AccordionControlSeparator
    Friend WithEvents btn_parametre As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents pn_container As Panel
End Class
