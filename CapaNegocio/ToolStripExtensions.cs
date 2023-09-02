using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaNegocio
{
    public static class ToolStripExtensions
    {
        public static IEnumerable<ToolStripItem> AllItems(this ToolStrip toolStrip)
        {
            return toolStrip.Items.Flatten();
        }
        public static IEnumerable<ToolStripItem> Flatten(this ToolStripItemCollection items)
        {
            foreach (ToolStripItem item in items)
            {
                if (item is ToolStripDropDownItem)
                    foreach (ToolStripItem subitem in
                        ((ToolStripDropDownItem)item).DropDownItems.Flatten())
                        yield return subitem;
                yield return item;
            }
        }
    }

    public static class ControlExtensions
    {
        public static IEnumerable<Control> AllControls(this Control control)
        {
            foreach (Control c in control.Controls)
            {
                yield return c;
                foreach (Control child in c.Controls)
                    yield return child;
            }
        }
    }
    
}
