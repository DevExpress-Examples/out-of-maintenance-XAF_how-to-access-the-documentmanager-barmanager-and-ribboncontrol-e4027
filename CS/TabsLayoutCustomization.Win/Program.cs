using System;
using System.Configuration;
using System.Windows.Forms;

using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Security;
using DevExpress.ExpressApp.Win;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.ExpressApp.Xpo;

namespace TabsLayoutCustomization.Win {
   static class Program {
      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main() {
#if EASYTEST
			DevExpress.ExpressApp.Win.EasyTest.EasyTestRemotingRegistration.Register();
#endif

         Application.EnableVisualStyles();
         Application.SetCompatibleTextRenderingDefault(false);
         EditModelPermission.AlwaysGranted = System.Diagnostics.Debugger.IsAttached;
         TabsLayoutCustomizationWindowsFormsApplication winApplication = new TabsLayoutCustomizationWindowsFormsApplication();
#if EASYTEST
			if(ConfigurationManager.ConnectionStrings["EasyTestConnectionString"] != null) {
				winApplication.ConnectionString = ConfigurationManager.ConnectionStrings["EasyTestConnectionString"].ConnectionString;
			}
#endif
         InMemoryDataStoreProvider.Register();
         winApplication.ConnectionString = InMemoryDataStoreProvider.ConnectionString;
         try {
            winApplication.Setup();
            winApplication.Start();
         }
         catch (Exception e) {
            winApplication.HandleException(e);
         }
      }
   }
}
