using System;
using System.Drawing;
using System.Windows.Forms;

namespace TinyTech.UI.Control.CheckBox
{
    public class CheckBox : System.Windows.Forms.CheckBox
    {
        public System.Windows.Forms.Control NextControl { get; set; }

        public CheckBox()
        {
            InitializeUI();
            Enter += CheckBox_Enter;
            Leave += CheckBox_Leave;
            KeyDown += CheckBox_KeyDown;
        }

        private void CheckBox_Leave(object sender, EventArgs e)
        {
            ForeColor = Color.Black;
        }

        private void CheckBox_Enter(object sender, EventArgs e)
        {
            ForeColor = Color.Orange;
        }

        private void InitializeUI()
        {
            SuspendLayout();
            // 
            // CheckBox
            // 
            Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ResumeLayout(false);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // CheckBox
            // 
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CheckBox_KeyDown);
            this.ResumeLayout(false);

        }

        private void SetNextControl(CheckBox nextControl)
        {
            SendKeys.Send("{TAB}");
        }

        private void CheckBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Return || NextControl == null) return;
            if (!NextControl.Enabled)
            {
                SetNextControl((CheckBox)sender);
                return;
            }

            NextControl.Focus();
        }
    }
}
