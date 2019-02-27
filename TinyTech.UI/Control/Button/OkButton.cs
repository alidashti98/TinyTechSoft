using System.Drawing;

namespace TinyTech.UI.Control.Button
{
    public class OkButton : Button
    {
        public OkButton()
        {
            InitializeUI();
        }

        private void InitializeUI()
        {
            BackColor = Color.FromArgb(29, 142, 174);
            ForeColor = Color.White;
            TextAlign = ContentAlignment.MiddleCenter;
            Font = new Font("IRANSans(FaNum)", 9f, FontStyle.Regular);
            Text = "تاييد";
        }
    }
}