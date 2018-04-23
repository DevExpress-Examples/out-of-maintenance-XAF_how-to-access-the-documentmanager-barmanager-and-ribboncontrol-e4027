Imports System
Imports System.ComponentModel
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Text

Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Actions
Imports DevExpress.Persistent.Base

Imports DevExpress.XtraBars.Docking2010
Imports DevExpress.ExpressApp.Templates
Imports DevExpress.XtraBars.Docking2010.Views.Tabbed

Public Class TabsCustomizationWindowController
	Inherits DevExpress.ExpressApp.WindowController

	Public Sub New()
		MyBase.New()

		'This call is required by the Component Designer.
		InitializeComponent()
		RegisterActions(components)

    End Sub
    Protected Overrides Sub OnActivated()
        MyBase.OnActivated()
        If Window.IsMain Then
            AddHandler Window.TemplateChanged, AddressOf Window_TemplateChanged
        End If
    End Sub
    Private Sub Window_TemplateChanged(ByVal sender As Object, ByVal e As EventArgs)
        Dim template As IFrameTemplate = Window.Template
        Dim docManager As DocumentManager = (CType(template, IDocumentsHostWindow)).DocumentManager
        If TypeOf docManager.View Is TabbedView Then
            CType(docManager.View, TabbedView).DocumentGroupProperties.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Left
            CType(docManager.View, TabbedView).DocumentGroupProperties.HeaderOrientation = DevExpress.XtraTab.TabOrientation.Horizontal
        End If
    End Sub


    Protected Overrides Sub OnDeactivated()
        RemoveHandler Window.TemplateChanged, AddressOf Window_TemplateChanged
        MyBase.OnDeactivated()
    End Sub
End Class
