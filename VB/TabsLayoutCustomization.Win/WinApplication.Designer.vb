' Developer Express Code Central Example:
' How to Access the Document Manager
' 
' This example demonstrates how to access the Document Manager that the
' MdiShowViewStrategy uses to show Views. You will see how to locate tab captions
' to the left and orient them horizontally. For details, refer to the How to:
' Access the Document Manager
' (http://documentation.devexpress.com/#Xaf/CustomDocument3443) topic in XAF
' documentation.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E4027

Namespace TabsLayoutCustomization.Win
   Partial Public Class TabsLayoutCustomizationWindowsFormsApplication
      ''' <summary> 
      ''' Required designer variable.
      ''' </summary>
      Private components As System.ComponentModel.IContainer = Nothing

      ''' <summary> 
      ''' Clean up any resources being used.
      ''' </summary>
      ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      Protected Overrides Sub Dispose(ByVal disposing As Boolean)
         If disposing AndAlso (components IsNot Nothing) Then
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
         Me.module1 = New DevExpress.ExpressApp.SystemModule.SystemModule()
         Me.module2 = New DevExpress.ExpressApp.Win.SystemModule.SystemWindowsFormsModule()
         Me.module3 = New TabsLayoutCustomization.Module.TabsLayoutCustomizationModule()
         Me.module4 = New TabsLayoutCustomization.Module.Win.TabsLayoutCustomizationWindowsFormsModule()
         DirectCast(Me, System.ComponentModel.ISupportInitialize).BeginInit()
         ' 
         ' TabsLayoutCustomizationWindowsFormsApplication
         ' 
         Me.ApplicationName = "TabsLayoutCustomization"
         Me.Modules.Add(Me.module1)
         Me.Modules.Add(Me.module2)
         Me.Modules.Add(Me.module3)
         Me.Modules.Add(Me.module4)
         DirectCast(Me, System.ComponentModel.ISupportInitialize).EndInit()

      End Sub

      #End Region

      Private module1 As DevExpress.ExpressApp.SystemModule.SystemModule
      Private module2 As DevExpress.ExpressApp.Win.SystemModule.SystemWindowsFormsModule
      Private module3 As TabsLayoutCustomization.Module.TabsLayoutCustomizationModule
      Private module4 As TabsLayoutCustomization.Module.Win.TabsLayoutCustomizationWindowsFormsModule
   End Class
End Namespace
