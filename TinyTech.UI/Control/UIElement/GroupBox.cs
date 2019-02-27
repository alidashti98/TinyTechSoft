using System.Windows.Forms;

namespace TinyTech.UI.Control.UIElement
{
    public class GroupBox : System.Windows.Forms.GroupBox
    {
        public GroupBox()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.Dock = DockStyle.Fill;
            this.ResumeLayout(false);
        }
    }
}
