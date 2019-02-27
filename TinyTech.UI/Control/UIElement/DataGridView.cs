using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TinyTech.UI.Control.UIElement
{
    public class DataGridView : System.Windows.Forms.DataGridView
    {
        public DataGridView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.AllowUserToAddRows = false;
            this.AllowUserToDeleteRows = false;
            this.AllowUserToOrderColumns = true;
            this.AllowUserToResizeColumns = false;
            this.AllowUserToResizeRows = false;
            this.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MultiSelect = false;
            this.ReadOnly = true;
            this.RowHeadersVisible = false;
            this.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.Dock = DockStyle.Fill;
            this.ResumeLayout(false);
        }
    }
}
