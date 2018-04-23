Imports Microsoft.VisualBasic
Imports System

Partial Public Class TabsLayoutCustomizationVBWindowsFormsApplication
	''' <summary> 
	''' Required designer variable.
	''' </summary>
	Private components As System.ComponentModel.IContainer = Nothing

	''' <summary> 
	''' Clean up any resources being used.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing AndAlso (Not components Is Nothing) Then
			components.Dispose()
		End If
		MyBase.Dispose(disposing)
	End Sub

#Region "Component Designer generated code"

	''' <summary> 
	''' Required method for Designer support - do not modify 
	''' the contents of this method with the code editor.
	''' </summary>
	Private Sub InitializeComponent()
        Me.module1 = New DevExpress.ExpressApp.SystemModule.SystemModule
        Me.module2 = New DevExpress.ExpressApp.Win.SystemModule.SystemWindowsFormsModule
        Me.module3 = New TabsLayoutCustomizationVB.[Module].TabsLayoutCustomizationVBModule
        Me.module4 = New TabsLayoutCustomizationVB.[Module].Win.TabsLayoutCustomizationVBWindowsFormsModule
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'TabsLayoutCustomizationVBWindowsFormsApplication
        '
        Me.ApplicationName = "TabsLayoutCustomizationVB"
        Me.Modules.Add(Me.module1)
        Me.Modules.Add(Me.module2)
        Me.Modules.Add(Me.module3)
        Me.Modules.Add(Me.module4)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

#End Region

	Private module1 As DevExpress.ExpressApp.SystemModule.SystemModule
    Private module2 As DevExpress.ExpressApp.Win.SystemModule.SystemWindowsFormsModule
	Private module3 As Global.TabsLayoutCustomizationVB.Module.TabsLayoutCustomizationVBModule
	Private module4 As Global.TabsLayoutCustomizationVB.Module.Win.TabsLayoutCustomizationVBWindowsFormsModule
End Class
