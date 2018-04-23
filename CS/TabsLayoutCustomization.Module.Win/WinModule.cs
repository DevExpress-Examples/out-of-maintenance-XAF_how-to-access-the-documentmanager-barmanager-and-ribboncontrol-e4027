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
using System.Text;
using System.ComponentModel;

using DevExpress.ExpressApp;

namespace TabsLayoutCustomization.Module.Win {
   [ToolboxItemFilter("Xaf.Platform.Win")]
   public sealed partial class TabsLayoutCustomizationWindowsFormsModule : ModuleBase {
      public TabsLayoutCustomizationWindowsFormsModule() {
         InitializeComponent();
      }
   }
}
