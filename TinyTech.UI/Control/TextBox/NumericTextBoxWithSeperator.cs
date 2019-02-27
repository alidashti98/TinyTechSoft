using System;

namespace TinyTech.UI.Control.TextBox
{
    public class NumericTextBoxWithSeperator : NumericTextBox
    {
        public NumericTextBoxWithSeperator()
        {
            TextChanged += NumberTextbox_TextChanged;
        }

        private void NumberTextbox_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(Text, out var num))
            {
                Text = $"{num:N0}";
                SelectionStart = Text.Length;
            }
        }
    }
}
