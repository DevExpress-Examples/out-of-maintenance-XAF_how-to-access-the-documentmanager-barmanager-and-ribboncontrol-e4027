using System;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Win.Controls;
using DevExpress.XtraBars;

namespace TabsLayoutCustomization.Module.Win.Controllers {
    // For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppViewControllertopic.aspx.
    public class BarManagerCustomizationWindowController : Controller
    {
        protected override void OnActivated()
        {
            base.OnActivated();
            Frame.TemplateChanged += Frame_TemplateChanged;
        }
        private void Frame_TemplateChanged(object sender, EventArgs e)
        {
            if (Frame.Template is IBarManagerHolder)
            {
                BarManager manager = ((IBarManagerHolder)Frame.Template).BarManager;
                manager.AllowCustomization = false;
            }
        }
        protected override void OnDeactivated()
        {
            Frame.TemplateChanged -= Frame_TemplateChanged;
            base.OnDeactivated();
        }
    }
}
