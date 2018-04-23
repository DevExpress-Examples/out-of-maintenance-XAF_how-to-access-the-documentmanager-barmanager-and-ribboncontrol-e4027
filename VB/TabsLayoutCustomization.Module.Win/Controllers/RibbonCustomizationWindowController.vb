Imports System
Imports DevExpress.ExpressApp
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.Utils

Namespace TabsLayoutCustomization.Module.Win.Controllers
    ' For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppWindowControllertopic.aspx.
    Public Class RibbonCustomizationWindowController
        Inherits WindowController
        Protected Overrides Sub OnActivated()
            MyBase.OnActivated()
            AddHandler Window.TemplateChanged, AddressOf Window_TemplateChanged
        End Sub
        Private Sub Window_TemplateChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim ribbonForm As RibbonForm = TryCast(Frame.Template, RibbonForm)
            If ribbonForm IsNot Nothing AndAlso ribbonForm.Ribbon IsNot Nothing Then
                Dim ribbon As RibbonControl = ribbonForm.Ribbon
                ribbon.PageHeaderMinWidth = 100
                ribbon.ShowExpandCollapseButton = DefaultBoolean.False
            End If
        End Sub
        Protected Overrides Sub OnDeactivated()
            RemoveHandler Window.TemplateChanged, AddressOf Window_TemplateChanged
            MyBase.OnDeactivated()
        End Sub
    End Class
End Namespace
