using DevExpress.ExpressApp;
using DevExpress.Utils;
using DevExpress.XtraBars.Ribbon;
using System;

namespace TabsLayoutCustomization.Module.Win.Controllers
{
    // For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppWindowControllertopic.aspx.
    public class RibbonCustomizationWindowController : WindowController
    {
        protected override void OnActivated()
        {
            base.OnActivated();
            Window.TemplateChanged += Window_TemplateChanged;
        }
        private void Window_TemplateChanged(object sender, EventArgs e)
        {
            RibbonForm ribbonForm = Frame.Template as RibbonForm;
            if (ribbonForm != null && ribbonForm.Ribbon != null)
            {
                RibbonControl ribbon = ribbonForm.Ribbon;
                ribbon.PageHeaderMinWidth = 100;
                ribbon.ShowExpandCollapseButton = DefaultBoolean.False;
            }
        }
        protected override void OnDeactivated()
        {
            Window.TemplateChanged -= Window_TemplateChanged;
            base.OnDeactivated();
        }
    }
}
