using System;
using System.Drawing;
using System.Windows.Forms;

namespace TinyTech.UI.Control.Button
{
    public class Button : System.Windows.Forms.Button
    {
        public System.Windows.Forms.Control NextControl { get; set; }

        public Button()
        {
            InitializeUI();
            Enter += Button_Enter;
            Leave += Button_Leave;
            KeyDown += Button_KeyDown;
        }

        private void Button_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                NextControl?.Focus();
            }
        }

        private void Button_Leave(object sender, EventArgs e)
        {
            FlatAppearance.BorderColor = Color.DarkGray;
            FlatAppearance.BorderSize = 1;
        }

        private void Button_Enter(object sender, EventArgs e)
        {
            FlatAppearance.BorderColor = Color.DarkOrange;
            FlatAppearance.BorderSize = 1;
        }

        private void InitializeUI()
        {
            FlatStyle = FlatStyle.Flat;
            Font = new Font("IRANSans(FaNum)", 9f, FontStyle.Regular);
            TextAlign = ContentAlignment.MiddleCenter;
            Width = 81;
            Height = 34;
            this.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.ResumeLayout(false);
        }
    }
}
