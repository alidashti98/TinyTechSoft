using System.Drawing;
using System.Windows.Forms;

namespace TinyTech.UI.Control.Button
{
    public class ExitButton : Button
    {
        public ExitButton()
        {
            InitializeUI();
        }

        private void InitializeUI()
        {
            AutoSize = false;
            Margin = new Padding(10);
            FlatAppearance.BorderSize = 1;
            FlatAppearance.BorderColor = Color.FromArgb(158, 158, 158);
            BackColor = Color.FromArgb(158, 158, 158);
            ForeColor = Color.White;
            TextAlign = ContentAlignment.MiddleCenter;
            Font = new Font("IRANSans(FaNum)", 9f, FontStyle.Regular);
            Text = "خروج";
        }
    }
}