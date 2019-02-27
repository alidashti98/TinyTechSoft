using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TinyTech.UI.Control.UIElement
{
    public class TabControl : System.Windows.Forms.TabControl
    {
        public TabControl()
        {
            this.Click += TabControl_Click;
        }

        private void TabControl_Click(object sender, EventArgs e)
        {
            //System.Windows.Forms.MessageBox.Show("Test");
            SendKeys.Send("{Tab}");
        }
    }
}
