using System.Drawing;
using System.Windows.Forms;

namespace TinyTech.UI.Control.RadioButton
{
    public class RadioButton : System.Windows.Forms.RadioButton
    {
        public System.Windows.Forms.Control NextControl { get; set; }

        public RadioButton()
        {
            InitializeUI();
        }

        private void InitializeUI()
        {
            TextAlign = ContentAlignment.MiddleCenter;
            Font = new Font("IRANSans(FaNum)", 9f, FontStyle.Regular);
            RightToLeft = RightToLeft.Yes;
            BackColor = Color.Transparent;
            Enter += RadioButton_Enter;
            Leave += RadioButton_Leave;
            KeyPress += RadioButton_KeyPress;
            this.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.ResumeLayout(false);
        }

        private void RadioButton_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\r' || NextControl == null) return;
            if (!NextControl.Enabled || SendTabKey)
            {
                SetNextControl((RadioButton)sender);
                return;
            }
            NextControl.Focus();
        }

        private void RadioButton_Leave(object sender, System.EventArgs e)
        {
            ForeColor = LeaveForColor;
        }

        private void RadioButton_Enter(object sender, System.EventArgs e)
        {
            ForeColor = EnterForColor;
        }

        private void SetNextControl(RadioButton nextControl)
        {
            SendKeys.Send("{TAB}");
        }

        public bool SendTabKey;
        public Color EnterForColor = Color.Orange;
        public Color LeaveForColor = Color.Black;
    }
}
