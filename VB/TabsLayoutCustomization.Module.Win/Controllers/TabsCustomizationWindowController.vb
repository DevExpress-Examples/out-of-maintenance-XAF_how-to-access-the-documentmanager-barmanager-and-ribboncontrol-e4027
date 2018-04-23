Imports System
Imports System.Collections.Generic
Imports DevExpress.ExpressApp
Imports DevExpress.XtraBars.Docking2010
Imports DevExpress.XtraBars.Docking2010.Views
Imports DevExpress.XtraBars.Docking2010.Views.Tabbed
Imports DevExpress.ExpressApp.Templates

Namespace TabsLayoutCustomization.Module.Win.Controllers
    Public Class TabsCustomizationWindowController
        Inherits WindowController

        Public Sub New()
            TargetWindowType = WindowType.Main
        End Sub
        Protected Overrides Sub OnActivated()
            MyBase.OnActivated()
            AddHandler Window.TemplateChanged, AddressOf Window_TemplateChanged
        End Sub
        Private Sub Window_TemplateChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim template As IFrameTemplate = Window.Template
            Dim docManager As DocumentManager = DirectCast(template, IDocumentsHostWindow).DocumentManager
            AddHandler docManager.ViewChanged, AddressOf docManager_ViewChanged
            CustomizeDocumentManagerView(docManager.View)
        End Sub
        Private Sub docManager_ViewChanged(ByVal sender As Object, ByVal args As ViewEventArgs)
            CustomizeDocumentManagerView(args.View)
        End Sub

        Private Shared Sub CustomizeDocumentManagerView(ByVal view As BaseView)
            If TypeOf view Is TabbedView Then
                CType(view, TabbedView).DocumentGroupProperties.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Left
                CType(view, TabbedView).DocumentGroupProperties.HeaderOrientation = DevExpress.XtraTab.TabOrientation.Horizontal
            End If
        End Sub

        Protected Overrides Sub OnDeactivated()
            RemoveHandler Window.TemplateChanged, AddressOf Window_TemplateChanged
            MyBase.OnDeactivated()
        End Sub
    End Class
End Namespace