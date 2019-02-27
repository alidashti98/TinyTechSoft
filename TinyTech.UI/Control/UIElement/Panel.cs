using System.Drawing;
using System.Windows.Forms;

namespace TinyTech.UI.Control.UIElement
{
    public class Panel : System.Windows.Forms.Panel
    {
        public Panel()
        {
           InitializeUI();
        }

        private void InitializeUI()
        {
            Font = new Font("IRANSans(FaNum)", 9f, FontStyle.Regular);
            RightToLeft = RightToLeft.Yes;
            this.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.Dock = DockStyle.Fill;
            this.ResumeLayout(false);
            this.Size = new System.Drawing.Size(800, 500);
        }
    }
}
