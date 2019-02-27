using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TinyTech.UI.Control.MessageBox;
using TinyTech.Connection;

namespace TinyTech.UI.Control.UIElement
{
    public class UserControl : System.Windows.Forms.UserControl
    {
        #region Region
        ConnectionClasses @class = new ConnectionClasses();
        TabManagement @tab = new TabManagement();
        #endregion

        public Guid guid { get; set; }
        public UserControl()
        {
            guid = Guid.NewGuid();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // UserControl
            // 
            this.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "UserControl";
            this.Size = new System.Drawing.Size(800, 530);
            this.ResumeLayout(false);

        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                tab.CloseTab(this);
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
