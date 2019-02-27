using System.Drawing;
using System.Windows.Forms;

namespace TinyTech.UI.Control.Button
{
    public class PrintButton : Button
    {
        public PrintButton()
        {
            InitializeUI();
        }

        private void InitializeUI()
        {
            AutoSize = false;
            Margin = new Padding(10);
            FlatAppearance.BorderSize = 1;
            FlatAppearance.BorderColor = Color.FromArgb(98, 0, 234);
            BackColor = Color.FromArgb(98, 0, 234);
            ForeColor = Color.White;
            TextAlign = ContentAlignment.MiddleCenter;
            Font = new Font("IRANSans(FaNum)", 9f, FontStyle.Regular);
            Text = "چاپ";
        }
    }
}