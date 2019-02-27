using System.Drawing;
using System;
using System.Windows.Forms;

namespace TinyTech.UI.Control.TextBox
{
    public class NumericTextBox : TextBox
    {
        #region Fields

        private double _value;
        public bool HavingStar;
        public bool SendTabKey;
        public Color EnterBackColor = Color.Orange;
        public Color LeaveBaCkColor = Color.White;
        public Color EnterForColor = Color.Black;
        public Color LeaveForColor = Color.Black;

        #endregion

        public double Value
        {
            get
            {
                _value = double.Parse(Text.Replace(",", ""));
                return _value;
            }
            set => _value = value;
        }

        private void InitializeUI()
        {
            AutoSize = true;
            Margin = new Padding(10);
            BorderStyle = BorderStyle.FixedSingle;
            Font = new Font("IRANSans(FaNum)", 9f, FontStyle.Regular);
            Text = "0";
            HavingStar = true;
        }

        public NumericTextBox()
        {
            InitializeUI();
            KeyPress += NumberTextbox_KeyPress;
            Enter += NumericTextBox_Enter;
            Leave += NumericTextBox_Leave;
            TextChanged += NumericTextBox_TextChanged;
        }

        private void NumericTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Text != string.Empty) return;
            Text = "0";
            SelectAll();
        }

        private void NumericTextBox_Leave(object sender, EventArgs e)
        {
            BackColor = LeaveBaCkColor;
            ForeColor = LeaveForColor;
            if (Text.Trim() == string.Empty)
            {
                Text = "0";
            }
        }

        private void NumericTextBox_Enter(object sender, EventArgs e)
        {
            SelectionStart = 0;
            BackColor = EnterBackColor;
            ForeColor = EnterForColor;
            SelectionLength = Text.Length;
        }

        private void NumberTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r' && string.IsNullOrWhiteSpace(Text))
            {
                Text = "0";
            }

            if (e.KeyChar == '.')
            {
                e.Handled = true;
                return;
            }

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
    }
}