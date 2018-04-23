Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.ExpressApp
Imports System.Windows.Forms
Imports DevExpress.ExpressApp.Win.Templates.Ribbon
Imports DevExpress.ExpressApp.Win.Controls
Imports DevExpress.XtraBars

Namespace TabsLayoutCustomization.Module.Win.Controllers
    ' For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppViewControllertopic.aspx.
    Public Class BarManagerCustomizationWindowController
        Inherits WindowController

        Public Sub New()
            TargetWindowType = WindowType.Main
        End Sub
        Protected Overrides Sub OnActivated()
            MyBase.OnActivated()
            AddHandler Window.TemplateChanged, AddressOf Window_TemplateChanged
        End Sub
        Private Sub Window_TemplateChanged(ByVal sender As Object, ByVal e As EventArgs)
            If Not(TypeOf Frame.Template Is MainRibbonFormV2) Then
                AddHandler CType(Frame.Template, Form).Load, AddressOf Form_Load
            End If
        End Sub
        Private Sub Form_Load(ByVal sender As Object, ByVal e As EventArgs)
            Dim manager As BarManager = DirectCast(sender, IBarManagerHolder).BarManager
            manager.AllowMoveBarOnToolbar = False
        End Sub
        Protected Overrides Sub OnDeactivated()
            RemoveHandler Window.TemplateChanged, AddressOf Window_TemplateChanged
            MyBase.OnDeactivated()
        End Sub
    End Class
End Namespace
