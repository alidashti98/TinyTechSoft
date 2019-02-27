using System;
using System.Drawing;
using System.Windows.Forms;

namespace TinyTech.UI.Control.Button
{
    public class SaveButton : Button
    {
        public SaveButton()
        {
            InitializeUI();
            EnabledChanged += SaveButton_EnabledChanged;
        }

        private void SaveButton_EnabledChanged(object sender, EventArgs e)
        {
            if (!Enabled)
            {
                BackColor = Color.FromArgb(143, 215, 255);
                ForeColor = Color.White;
                return;
            }

            BackColor = Color.FromArgb(0, 140, 231);
            ForeColor = Color.White;
        }

        private void InitializeUI()
        {
            AutoSize = false;
            Margin = new Padding(10);
            FlatAppearance.BorderSize = 1;
            FlatAppearance.BorderColor = Color.FromArgb(0, 140, 231);
            BackColor = Color.FromArgb(0, 140, 231);
            ForeColor = Color.White;
            TextAlign = ContentAlignment.MiddleCenter;
            Font = new Font("IRANSans(FaNum)", 9f, FontStyle.Regular);
            Text = "ثبت";
        }
    }
}