Imports System
Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Win.Controls
Imports DevExpress.XtraBars

Namespace TabsLayoutCustomization.Module.Win.Controllers
    ' For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppViewControllertopic.aspx.
    Public Class BarManagerCustomizationWindowController
        Inherits Controller

        Protected Overrides Sub OnActivated()
            MyBase.OnActivated()
            AddHandler Frame.TemplateChanged, AddressOf Frame_TemplateChanged
        End Sub
        Private Sub Frame_TemplateChanged(ByVal sender As Object, ByVal e As EventArgs)
            If TypeOf Frame.Template Is IBarManagerHolder Then
                Dim manager As BarManager = DirectCast(Frame.Template, IBarManagerHolder).BarManager
                manager.AllowCustomization = False
            End If
        End Sub
        Protected Overrides Sub OnDeactivated()
            RemoveHandler Frame.TemplateChanged, AddressOf Frame_TemplateChanged
            MyBase.OnDeactivated()
        End Sub
    End Class
End Namespace
