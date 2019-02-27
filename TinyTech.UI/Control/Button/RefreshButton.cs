using System.Drawing;
using System.Windows.Forms;

namespace TinyTech.UI.Control.Button
{
    public class RefreshButton : Button
    {
        public RefreshButton()
        {
            InitializeUI();
        }

        private void InitializeUI()
        {
            AutoSize = false;
            Margin = new Padding(10);
            FlatAppearance.BorderSize = 1;
            FlatAppearance.BorderColor = Color.FromArgb(0, 200, 83);
            BackColor = Color.FromArgb(0, 200, 83);
            ForeColor = Color.White;
            TextAlign = ContentAlignment.MiddleCenter;
            Font = new Font("IRANSans(FaNum)", 9f, FontStyle.Regular);
            Text = "بروزرساني";
        }
    }
}