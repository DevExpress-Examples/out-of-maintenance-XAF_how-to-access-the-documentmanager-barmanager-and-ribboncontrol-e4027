using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.Persistent.Base;

using DevExpress.XtraBars.Docking2010;
using DevExpress.XtraBars.Docking2010.Views;
using DevExpress.XtraBars.Docking2010.Views.Tabbed;
using DevExpress.ExpressApp.Templates;

namespace TabsLayoutCustomization.Module.Win.Controllers {
   public partial class TabsCustomizationWindowController : WindowController {
      public TabsCustomizationWindowController() {
         InitializeComponent();
         RegisterActions(components);
      }
      protected override void OnActivated() {
         base.OnActivated();
         if (Window.IsMain) {
            Window.TemplateChanged += new EventHandler(Window_TemplateChanged);
         }
      }

      void Window_TemplateChanged(object sender, EventArgs e) {
         IFrameTemplate template = Window.Template;
         DocumentManager docManager = ((IDocumentsHostWindow)template).DocumentManager;
            if (docManager.View is TabbedView) {
               ((TabbedView)docManager.View).DocumentGroupProperties.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Left;
               ((TabbedView)docManager.View).DocumentGroupProperties.HeaderOrientation = DevExpress.XtraTab.TabOrientation.Horizontal;
            }
      }
      protected override void OnDeactivated() {
         Window.TemplateChanged -= new EventHandler(Window_TemplateChanged);
         base.OnDeactivated();
      }
   }
}
