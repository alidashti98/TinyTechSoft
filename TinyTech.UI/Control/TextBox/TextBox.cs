using System;
using System.Drawing;
using System.Windows.Forms;

namespace TinyTech.UI.Control.TextBox
{
    public class TextBox : System.Windows.Forms.TextBox
    {
        public System.Windows.Forms.Control NextControl { get; set; }

        public TextBox()
        {
            InitializeUI();
            KeyPress += TextBox_KeyPress;
            Enter += TextBox_Enter;
            Leave += TextBox_Leave;
            KeyDown += TextBox_KeyDown;
            TextChanged += TextBox_TextChanged;
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            if (HavingStar && (Text.Contains("*") | Text.Contains("/")))
            {
                Text = Text.Replace("*", "");
                Text = Text.Replace("/", "");
                SelectionStart = Text.Length;
            }
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                SelectAll();
            }

            if (!HavingStar) return;
            switch (e.KeyCode)
            {
                case Keys.Multiply:
                    Text += "00";
                    SelectionStart = Text.Length;
                    break;
                case Keys.Divide:
                    Text += "000";
                    SelectionStart = Text.Length;
                    break;
            }
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            BackColor = LeaveBaCkColor;
            ForeColor = LeaveForColor;
        }

        private void TextBox_Enter(object sender, EventArgs e)
        {
            BackColor = EnterBackColor;
            ForeColor = EnterForColor;
        }

        private void InitializeUI()
        {
            AutoSize = true;
            Margin = new Padding(10);
            RightToLeft = RightToLeft.Yes;
            BorderStyle = BorderStyle.FixedSingle;
            Width = 200;
            Height = 34;
            TextAlign = HorizontalAlignment.Center;
            Font = new Font("IRANSans(FaNum)", 9f, FontStyle.Regular);
            BackColor = LeaveBaCkColor;
            ForeColor = LeaveForColor;
            this.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.ResumeLayout(false);
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\r' || NextControl == null) return;
            if (!NextControl.Enabled || SendTabKey)
            {
                SetNextControl((TextBox)sender);
                return;
            }
            NextControl.Focus();
        }

        private void SetNextControl(TextBox nextControl)
        {
            SendKeys.Send("{TAB}");
        }

        public bool HavingStar;
        public bool SendTabKey;
        public Color EnterBackColor = Color.Orange;
        public Color LeaveBaCkColor = Color.White;
        public Color EnterForColor = Color.Black;
        public Color LeaveForColor = Color.Black;
    }
}
