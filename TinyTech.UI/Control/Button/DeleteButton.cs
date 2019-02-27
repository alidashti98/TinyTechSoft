using System;
using System.Drawing;
using System.Windows.Forms;

namespace TinyTech.UI.Control.Button
{
    public class DeleteButton : Button
    {
        public DeleteButton()
        {
            InitializeUI();
            Leave += DeleteButton_Leave;
        }

        private void DeleteButton_Leave(object sender, EventArgs e)
        {
            FlatAppearance.BorderColor = Color.Red;
            FlatAppearance.BorderSize = 1;
        }

        private void InitializeUI()
        {
            AutoSize = false;
            Margin = new Padding(10);
            FlatAppearance.BorderSize = 1;
            FlatAppearance.BorderColor = Color.Red;
            BackColor = Color.White;
            ForeColor = Color.Red;
            TextAlign = ContentAlignment.MiddleCenter;
            Font = new Font("IRANSans(FaNum)", 9f, FontStyle.Regular);
            Text = "حذف";
        }
    }
}