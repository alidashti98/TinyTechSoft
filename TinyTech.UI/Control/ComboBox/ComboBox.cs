using System;
using System.Drawing;
using System.Windows.Forms;

namespace TinyTech.UI.Control.ComboBox
{
    public class ComboBox : System.Windows.Forms.ComboBox
    {
        public System.Windows.Forms.Control NextControl { get; set; }

        public ComboBox()
        {
            InitializeUI();
            KeyDown += ComboBox_KeyDown;
            LostFocus += ComboBox_LostFocus;
            GotFocus += ComboBox_GotFocus;
        }

        private void ComboBox_GotFocus(object sender, EventArgs e)
        {
            BackColor = Color.Orange;
        }

        private void ComboBox_LostFocus(object sender, EventArgs e)
        {
            BackColor = Color.White;
        }

        private void ComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Return || NextControl == null) return;
            if (!NextControl.Enabled)
            {
                SetNextControl((ComboBox) sender);
                return;
            }

            NextControl.Focus();
        }

        private void SetNextControl(ComboBox nextControl)
        {
            SendKeys.Send("{TAB}");
        }

        private void InitializeUI()
        {
            RightToLeft = RightToLeft.Yes;
            AutoSize = true;
            Margin = new Padding(10);
            FormattingEnabled = true;
            Width = 200;
            Height = 34;
            DropDownStyle = ComboBoxStyle.DropDown;
            AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            AutoCompleteSource = AutoCompleteSource.ListItems;
            Font = new Font("IRANSans(FaNum)", 9f, FontStyle.Regular);
            this.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.ResumeLayout(false);
        }
    }
}