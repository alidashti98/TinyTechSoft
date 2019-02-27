using System;
using System.Drawing;
using System.Windows.Forms;

namespace TinyTech.UI.Control.Button
{
    public class EditButton : Button
    {
        public EditButton()
        {
            InitializeUI();
            EnabledChanged += EditButton_EnabledChanged;
        }

        private void EditButton_EnabledChanged(object sender, EventArgs e)
        {
            BackColor = (Enabled ? Color.Green : Color.FromArgb(203, 240, 197));
        }

        private void InitializeUI()
        {
            AutoSize = false;
            Margin = new Padding(10);
            FlatAppearance.BorderSize = 1;
            FlatAppearance.BorderColor = Color.Green;
            BackColor = Color.Green;
            ForeColor = Color.White;
            TextAlign = ContentAlignment.MiddleCenter;
            Font = new Font("IRANSans(FaNum)", 9f, FontStyle.Regular);
            Text = "ويرايش";
        }
    }
}