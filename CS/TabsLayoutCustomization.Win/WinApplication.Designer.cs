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

namespace TabsLayoutCustomization.Win {
   partial class TabsLayoutCustomizationWindowsFormsApplication {
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
         this.module1 = new DevExpress.ExpressApp.SystemModule.SystemModule();
         this.module2 = new DevExpress.ExpressApp.Win.SystemModule.SystemWindowsFormsModule();
         this.module3 = new TabsLayoutCustomization.Module.TabsLayoutCustomizationModule();
         this.module4 = new TabsLayoutCustomization.Module.Win.TabsLayoutCustomizationWindowsFormsModule();
         ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
         // 
         // TabsLayoutCustomizationWindowsFormsApplication
         // 
         this.ApplicationName = "TabsLayoutCustomization";
         this.Modules.Add(this.module1);
         this.Modules.Add(this.module2);
         this.Modules.Add(this.module3);
         this.Modules.Add(this.module4);
         this.CustomizeLanguagesList += new System.EventHandler<DevExpress.ExpressApp.CustomizeLanguagesListEventArgs>(this.TabsLayoutCustomizationWindowsFormsApplication_CustomizeLanguagesList);
         this.DatabaseVersionMismatch += new System.EventHandler<DevExpress.ExpressApp.DatabaseVersionMismatchEventArgs>(this.TabsLayoutCustomizationWindowsFormsApplication_DatabaseVersionMismatch);
         ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

      }

      #endregion

      private DevExpress.ExpressApp.SystemModule.SystemModule module1;
      private DevExpress.ExpressApp.Win.SystemModule.SystemWindowsFormsModule module2;
      private TabsLayoutCustomization.Module.TabsLayoutCustomizationModule module3;
      private TabsLayoutCustomization.Module.Win.TabsLayoutCustomizationWindowsFormsModule module4;
   }
}
