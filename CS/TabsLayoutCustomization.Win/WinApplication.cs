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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using DevExpress.ExpressApp.Win;
using DevExpress.ExpressApp.Updating;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Xpo;

namespace TabsLayoutCustomization.Win {
   public partial class TabsLayoutCustomizationWindowsFormsApplication : WinApplication {
      public TabsLayoutCustomizationWindowsFormsApplication() {
         InitializeComponent();
         DelayedViewItemsInitialization = true;
      }

      protected override void CreateDefaultObjectSpaceProvider(CreateCustomObjectSpaceProviderEventArgs args) {
         args.ObjectSpaceProvider = new XPObjectSpaceProvider(args.ConnectionString, args.Connection);
      }
      private void TabsLayoutCustomizationWindowsFormsApplication_DatabaseVersionMismatch(object sender, DevExpress.ExpressApp.DatabaseVersionMismatchEventArgs e) {

            e.Updater.Update();
            e.Handled = true;

      }
      private void TabsLayoutCustomizationWindowsFormsApplication_CustomizeLanguagesList(object sender, CustomizeLanguagesListEventArgs e) {
         string userLanguageName = System.Threading.Thread.CurrentThread.CurrentUICulture.Name;
         if (userLanguageName != "en-US" && e.Languages.IndexOf(userLanguageName) == -1) {
            e.Languages.Add(userLanguageName);
         }
      }
   }
}
