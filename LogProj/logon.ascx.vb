Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Web.UI
Imports DevExpress.ExpressApp.Templates
Imports DevExpress.ExpressApp.Web.Controls
Imports DevExpress.ExpressApp.Web.Templates

Partial Public Class logon
    Inherits TemplateContent
    Implements IXafPopupWindowControlContainer
    Public Overrides ReadOnly Property DefaultContainer() As IActionContainer
        Get
            Return Nothing
        End Get
    End Property
    Public Overrides Sub SetStatus(ByVal statusMessages As ICollection(Of String))
    End Sub
    Public Overrides ReadOnly Property ViewSiteControl() As Object
        Get
            Return VSC
        End Get
    End Property

    Public ReadOnly Property XafPopupWindowControl() As XafPopupWindowControl Implements IXafPopupWindowControlContainer.XafPopupWindowControl
        Get
            Return PopupWindowControl
        End Get
    End Property

End Class
