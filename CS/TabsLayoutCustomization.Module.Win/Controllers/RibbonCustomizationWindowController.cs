using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Win.Templates.Ribbon;
using DevExpress.XtraBars.Ribbon;
using System.Windows.Forms;

namespace TabsLayoutCustomization.Module.Win.Controllers {
    // For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppWindowControllertopic.aspx.
    public class RibbonCustomizationWindowController : WindowController {
        public RibbonCustomizationWindowController() {
            TargetWindowType = WindowType.Main;
        }
        protected override void OnActivated() {
            base.OnActivated();
            Window.TemplateChanged += Window_TemplateChanged;
        }
        private void Window_TemplateChanged(object sender, EventArgs e) {
            if (Frame.Template is MainRibbonFormV2)
                ((Form)Frame.Template).Load += Form_Load;
        }
        private void Form_Load(object sender, EventArgs e) {
            RibbonControl Ribbon = ((MainRibbonFormV2)sender).Ribbon;
            Ribbon.PageHeaderMinWidth = 100;
            Ribbon.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
        }
        protected override void OnDeactivated() {
            Window.TemplateChanged -= Window_TemplateChanged;
            base.OnDeactivated();
        }
    }
}
