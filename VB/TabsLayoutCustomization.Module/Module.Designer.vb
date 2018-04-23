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

Namespace TabsLayoutCustomization.Module
   Partial Public Class TabsLayoutCustomizationModule
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
         ' 
         ' TabsLayoutCustomizationModule
         ' 
         Me.RequiredModuleTypes.Add(GetType(DevExpress.ExpressApp.SystemModule.SystemModule))
      End Sub

      #End Region
   End Class
End Namespace
