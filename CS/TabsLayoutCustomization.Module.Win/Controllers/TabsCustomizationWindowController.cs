using System;
using System.Collections.Generic;
using DevExpress.ExpressApp;
using DevExpress.XtraBars.Docking2010;
using DevExpress.XtraBars.Docking2010.Views;
using DevExpress.XtraBars.Docking2010.Views.Tabbed;
using DevExpress.ExpressApp.Templates;

namespace TabsLayoutCustomization.Module.Win.Controllers {
    public class TabsCustomizationWindowController : WindowController {
        public TabsCustomizationWindowController() {
            TargetWindowType = WindowType.Main;
        }
        protected override void OnActivated() {
            base.OnActivated();
            Window.TemplateChanged += Window_TemplateChanged;
        }
        private void Window_TemplateChanged(object sender, EventArgs e) {
            IFrameTemplate template = Window.Template;
            DocumentManager docManager = ((IDocumentsHostWindow)template).DocumentManager;
            docManager.ViewChanged += docManager_ViewChanged;
            CustomizeDocumentManagerView(docManager.View);
        }
        private void docManager_ViewChanged(object sender, ViewEventArgs args) {
            CustomizeDocumentManagerView(args.View);
        }

        private static void CustomizeDocumentManagerView(BaseView view) {
            if(view is TabbedView) {
                ((TabbedView)view).DocumentGroupProperties.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Left;
                ((TabbedView)view).DocumentGroupProperties.HeaderOrientation = DevExpress.XtraTab.TabOrientation.Horizontal;
            }
        }

        protected override void OnDeactivated() {
            Window.TemplateChanged -= Window_TemplateChanged;
            base.OnDeactivated();
        }
    }
}