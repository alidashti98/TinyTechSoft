using System;
using System.Drawing;

namespace TinyTech.UI.Control.Button
{
    public class CancelButton : Button
    {
        public CancelButton()
        {
            InitializeUI();
            EnabledChanged += CancelButton_EnabledChanged;
        }

        private void CancelButton_EnabledChanged(object sender, EventArgs e)
        {
            if (!Enabled)
            {
                BackColor = Color.White;
                ForeColor = Color.Gray;
                return;
            }
            BackColor = Color.White;
            ForeColor = Color.Gray;
        }

        private void InitializeUI()
        {
            BackColor = Color.White;
            ForeColor = Color.Gray;
            Text = "انصراف";
            TextAlign = ContentAlignment.MiddleCenter;
            Font = new Font("IRANSans(FaNum)", 9f, FontStyle.Regular);
        }
    }
}
