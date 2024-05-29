<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class parametre
    Inherits DevExpress.XtraBars.TabForm

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
        Me.RibbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.ToolbarFormManager1 = New DevExpress.XtraBars.ToolbarForm.ToolbarFormManager(Me.components)
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.FluentDesignFormContainer1 = New DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer()
        Me.pn_parametre = New System.Windows.Forms.Panel()
        Me.TabFormControl1 = New DevExpress.XtraBars.TabFormControl()
        Me.TabFormPage1 = New DevExpress.XtraBars.TabFormPage()
        Me.TabFormContentContainer1 = New DevExpress.XtraBars.TabFormContentContainer()
        CType(Me.ToolbarFormManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabFormControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonPage2
        '
        Me.RibbonPage2.Name = "RibbonPage2"
        Me.RibbonPage2.Text = "RibbonPage2"
        '
        'ToolbarFormManager1
        '
        Me.ToolbarFormManager1.DockControls.Add(Me.barDockControlTop)
        Me.ToolbarFormManager1.DockControls.Add(Me.barDockControlBottom)
        Me.ToolbarFormManager1.DockControls.Add(Me.barDockControlLeft)
        Me.ToolbarFormManager1.DockControls.Add(Me.barDockControlRight)
        Me.ToolbarFormManager1.Form = Me
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.ToolbarFormManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(1131, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 682)
        Me.barDockControlBottom.Manager = Me.ToolbarFormManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(1131, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Manager = Me.ToolbarFormManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 682)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1131, 0)
        Me.barDockControlRight.Manager = Me.ToolbarFormManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 682)
        '
        'FluentDesignFormContainer1
        '
        Me.FluentDesignFormContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FluentDesignFormContainer1.Location = New System.Drawing.Point(0, 71)
        Me.FluentDesignFormContainer1.Name = "FluentDesignFormContainer1"
        Me.FluentDesignFormContainer1.Size = New System.Drawing.Size(1131, 611)
        Me.FluentDesignFormContainer1.TabIndex = 5
        '
        'pn_parametre
        '
        Me.pn_parametre.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pn_parametre.Location = New System.Drawing.Point(0, 71)
        Me.pn_parametre.Name = "pn_parametre"
        Me.pn_parametre.Size = New System.Drawing.Size(1131, 611)
        Me.pn_parametre.TabIndex = 0
        '
        'TabFormControl1
        '
        Me.TabFormControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabFormControl1.Name = "TabFormControl1"
        Me.TabFormControl1.Pages.Add(Me.TabFormPage1)
        Me.TabFormControl1.SelectedPage = Me.TabFormPage1
        Me.TabFormControl1.Size = New System.Drawing.Size(1131, 71)
        Me.TabFormControl1.TabForm = Me
        Me.TabFormControl1.TabIndex = 10
        Me.TabFormControl1.TabStop = False
        '
        'TabFormPage1
        '
        Me.TabFormPage1.ContentContainer = Me.TabFormContentContainer1
        Me.TabFormPage1.Name = "TabFormPage1"
        Me.TabFormPage1.Text = "Page 0"
        '
        'TabFormContentContainer1
        '
        Me.TabFormContentContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabFormContentContainer1.Location = New System.Drawing.Point(0, 71)
        Me.TabFormContentContainer1.Name = "TabFormContentContainer1"
        Me.TabFormContentContainer1.Size = New System.Drawing.Size(1131, 611)
        Me.TabFormContentContainer1.TabIndex = 11
        '
        'parametre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1131, 682)
        Me.Controls.Add(Me.pn_parametre)
        Me.Controls.Add(Me.FluentDesignFormContainer1)
        Me.Controls.Add(Me.TabFormContentContainer1)
        Me.Controls.Add(Me.TabFormControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "parametre"
        Me.TabFormControl = Me.TabFormControl1
        Me.Text = "parametre"
        CType(Me.ToolbarFormManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabFormControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RibbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents ToolbarFormManager1 As DevExpress.XtraBars.ToolbarForm.ToolbarFormManager
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents pn_parametre As Panel
    Friend WithEvents FluentDesignFormContainer1 As DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer
    Friend WithEvents TabFormContentContainer1 As DevExpress.XtraBars.TabFormContentContainer
    Friend WithEvents TabFormControl1 As DevExpress.XtraBars.TabFormControl
    Friend WithEvents TabFormPage1 As DevExpress.XtraBars.TabFormPage
End Class
