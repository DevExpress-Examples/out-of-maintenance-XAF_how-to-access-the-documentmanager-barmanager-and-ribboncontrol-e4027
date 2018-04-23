// Developer Express Code Central Example:
// How to Access the Document Manager
// 
// This example demonstrates how to access the Document Manager that the
// MdiShowViewStrategy uses to show Views. You will see how to locate tab captions
// to the left and orient them horizontally. For details, refer to the How to:
// Access the Document Manager
// (http://documentation.devexpress.com/#Xaf/CustomDocument3443) topic in XAF
// documentation.
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E4027

namespace TabsLayoutCustomization.Module.Win {
   partial class TabsLayoutCustomizationWindowsFormsModule {
      /// <summary> 
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary> 
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing) {
         if (disposing && (components != null)) {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Component Designer generated code

      /// <summary> 
      /// Required method for Designer support - do not modify 
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent() {
         // 
         // TabsLayoutCustomizationWindowsFormsModule
         // 
         this.RequiredModuleTypes.Add(typeof(TabsLayoutCustomization.Module.TabsLayoutCustomizationModule));
         this.RequiredModuleTypes.Add(typeof(DevExpress.ExpressApp.Win.SystemModule.SystemWindowsFormsModule));

      }

      #endregion
   }
}
