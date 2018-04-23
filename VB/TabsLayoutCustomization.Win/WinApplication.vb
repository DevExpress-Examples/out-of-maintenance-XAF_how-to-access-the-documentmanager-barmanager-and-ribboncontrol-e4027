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

Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports DevExpress.ExpressApp.Win
Imports DevExpress.ExpressApp.Updating
Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Xpo

Namespace TabsLayoutCustomization.Win
   Partial Public Class TabsLayoutCustomizationWindowsFormsApplication
       Inherits WinApplication

      Public Sub New()
         InitializeComponent()
            DelayedViewItemsInitialization = True
            UseLightStyle = True
        End Sub

      Protected Overrides Sub CreateDefaultObjectSpaceProvider(ByVal args As CreateCustomObjectSpaceProviderEventArgs)
         args.ObjectSpaceProvider = New XPObjectSpaceProvider(args.ConnectionString, args.Connection)
      End Sub
      Private Sub TabsLayoutCustomizationWindowsFormsApplication_DatabaseVersionMismatch(ByVal sender As Object, ByVal e As DevExpress.ExpressApp.DatabaseVersionMismatchEventArgs) Handles Me.DatabaseVersionMismatch

            e.Updater.Update()
            e.Handled = True

      End Sub
      Private Sub TabsLayoutCustomizationWindowsFormsApplication_CustomizeLanguagesList(ByVal sender As Object, ByVal e As CustomizeLanguagesListEventArgs) Handles Me.CustomizeLanguagesList
         Dim userLanguageName As String = System.Threading.Thread.CurrentThread.CurrentUICulture.Name
         If userLanguageName <> "en-US" AndAlso e.Languages.IndexOf(userLanguageName) = -1 Then
            e.Languages.Add(userLanguageName)
         End If
      End Sub
   End Class
End Namespace
