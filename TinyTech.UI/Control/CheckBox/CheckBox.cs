using System;
using System.Drawing;
using System.Windows.Forms;

namespace TinyTech.UI.Control.CheckBox
{
    public class CheckBox : System.Windows.Forms.CheckBox
    {
        public CheckBox()
        {
            InitializeUI();
            Enter += CheckBox_Enter;
            Leave += CheckBox_Leave;
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
    }
}
