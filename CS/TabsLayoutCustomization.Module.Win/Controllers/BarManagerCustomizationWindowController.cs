using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.ExpressApp;
using System.Windows.Forms;
using DevExpress.ExpressApp.Win.Templates.Ribbon;
using DevExpress.ExpressApp.Win.Controls;
using DevExpress.XtraBars;

namespace TabsLayoutCustomization.Module.Win.Controllers {
    // For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppViewControllertopic.aspx.
    public class BarManagerCustomizationWindowController : WindowController {
        public BarManagerCustomizationWindowController() {
            TargetWindowType = WindowType.Main;
        }
        protected override void OnActivated() {
            base.OnActivated();
            Window.TemplateChanged += Window_TemplateChanged;
        }
        private void Window_TemplateChanged(object sender, EventArgs e) {
            if (!(Frame.Template is MainRibbonFormV2))
                ((Form)Frame.Template).Load += Form_Load;
        }
        private void Form_Load(object sender, EventArgs e) {
            BarManager manager = ((IBarManagerHolder)sender).BarManager;
            manager.AllowMoveBarOnToolbar = false;
        }
        protected override void OnDeactivated() {
            Window.TemplateChanged -= Window_TemplateChanged;
            base.OnDeactivated();
        }
    }
}
