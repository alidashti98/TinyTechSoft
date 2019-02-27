using System.Drawing;
using System.Windows.Forms;

namespace TinyTech.UI.Control.Button
{
    public class DisplayButton : Button
    {
        public DisplayButton()
        {
            InitializeUI();
        }

        private void InitializeUI()
        {
            AutoSize = false;
            Margin = new Padding(10);
            FlatAppearance.BorderSize = 1;
            FlatAppearance.BorderColor = Color.FromArgb(49, 27, 146);
            BackColor = Color.FromArgb(49, 27, 146);
            ForeColor = Color.White;
            TextAlign = ContentAlignment.MiddleCenter;
            Font = new Font("IRANSans(FaNum)", 9f, FontStyle.Regular);
            Text = "نمايش";
        }
    }
}