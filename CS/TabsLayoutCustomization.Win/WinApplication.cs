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
