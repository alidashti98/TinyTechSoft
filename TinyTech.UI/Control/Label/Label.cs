using System.Drawing;
using System.Windows.Forms;

namespace TinyTech.UI.Control.Label
{
    public class Label : System.Windows.Forms.Label
    {
        public Label()
        {
            InitializeUI();
        }

        private void InitializeUI()
        {
            TextAlign = ContentAlignment.MiddleCenter;
            Font = new Font("IRANSans(FaNum)", 9f, FontStyle.Regular);
            RightToLeft = RightToLeft.Yes;
            BackColor = Color.Transparent;
            this.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.ResumeLayout(false);
        }
    }
}
