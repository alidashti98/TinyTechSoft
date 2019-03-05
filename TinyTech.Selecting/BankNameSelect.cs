using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using TinyTech.Connection;
using TinyTech.UI.Control.MessageBox;
using UserControl = TinyTech.UI.Control.UIElement.UserControl;

namespace TinyTech.Selecting
{
    public class BankNameSelect : UserControl
    {
        #region Region 
        ConnectionClasses @class = new ConnectionClasses();
        private UI.Control.UIElement.GroupBox groupBoxBankNameSelect;
        private UI.Control.UIElement.Panel pnlMain;
        private UI.Control.UIElement.DataGridView dgvBankName;
        private UI.Control.UIElement.Panel pnlBottom;
        private UI.Control.UIElement.Panel pnlTop;
        private UI.Control.TextBox.TextBox txtBankNameSearch;
        private UI.Control.Label.Label lblBankNameSearch;
        private UI.Control.Label.Label lblHelp;
        private List<BankName> info;
        private Container components = null;
        #endregion

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                components?.Dispose();
            }
            base.Dispose(disposing);
        }

        public BankNameSelect(List<BankName> info_)
        {
            InitializeComponent();
            info = info_;
            BankNameSelect_Load(null, null);
        }

        private void InitializeComponent()
        {
            this.groupBoxBankNameSelect = new TinyTech.UI.Control.UIElement.GroupBox();
            this.pnlMain = new TinyTech.UI.Control.UIElement.Panel();
            this.dgvBankName = new TinyTech.UI.Control.UIElement.DataGridView();
            this.pnlBottom = new TinyTech.UI.Control.UIElement.Panel();
            this.lblHelp = new TinyTech.UI.Control.Label.Label();
            this.pnlTop = new TinyTech.UI.Control.UIElement.Panel();
            this.txtBankNameSearch = new TinyTech.UI.Control.TextBox.TextBox();
            this.lblBankNameSearch = new TinyTech.UI.Control.Label.Label();
            this.groupBoxBankNameSelect.SuspendLayout();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBankName)).BeginInit();
            this.pnlBottom.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxBankNameSelect
            // 
            this.groupBoxBankNameSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxBankNameSelect.Controls.Add(this.pnlMain);
            this.groupBoxBankNameSelect.Controls.Add(this.pnlBottom);
            this.groupBoxBankNameSelect.Controls.Add(this.pnlTop);
            this.groupBoxBankNameSelect.Location = new System.Drawing.Point(0, 0);
            this.groupBoxBankNameSelect.Name = "groupBoxBankNameSelect";
            this.groupBoxBankNameSelect.Size = new System.Drawing.Size(750, 500);
            this.groupBoxBankNameSelect.TabIndex = 0;
            this.groupBoxBankNameSelect.TabStop = false;
            this.groupBoxBankNameSelect.Text = "انتخاب نام بانك";
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMain.Controls.Add(this.dgvBankName);
            this.pnlMain.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.pnlMain.Location = new System.Drawing.Point(3, 58);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlMain.Size = new System.Drawing.Size(744, 415);
            this.pnlMain.TabIndex = 5;
            // 
            // dgvBankName
            // 
            this.dgvBankName.AllowUserToAddRows = false;
            this.dgvBankName.AllowUserToDeleteRows = false;
            this.dgvBankName.AllowUserToOrderColumns = true;
            this.dgvBankName.AllowUserToResizeColumns = false;
            this.dgvBankName.AllowUserToResizeRows = false;
            this.dgvBankName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBankName.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBankName.Location = new System.Drawing.Point(0, 0);
            this.dgvBankName.MultiSelect = false;
            this.dgvBankName.Name = "dgvBankName";
            this.dgvBankName.ReadOnly = true;
            this.dgvBankName.RowHeadersVisible = false;
            this.dgvBankName.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvBankName.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBankName.Size = new System.Drawing.Size(744, 415);
            this.dgvBankName.TabIndex = 0;
            this.dgvBankName.DoubleClick += new System.EventHandler(this.dgvBankName_DoubleClick);
            this.dgvBankName.Enter += new System.EventHandler(this.dgvBankName_Enter);
            this.dgvBankName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvBankName_KeyDown);
            // 
            // pnlBottom
            // 
            this.pnlBottom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBottom.Controls.Add(this.lblHelp);
            this.pnlBottom.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.pnlBottom.Location = new System.Drawing.Point(3, 473);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlBottom.Size = new System.Drawing.Size(744, 24);
            this.pnlBottom.TabIndex = 4;
            // 
            // lblHelp
            // 
            this.lblHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHelp.AutoSize = true;
            this.lblHelp.BackColor = System.Drawing.Color.Transparent;
            this.lblHelp.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.lblHelp.Location = new System.Drawing.Point(538, 3);
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblHelp.Size = new System.Drawing.Size(203, 20);
            this.lblHelp.TabIndex = 2;
            this.lblHelp.Text = "انتخاب : Enter            انصراف : Escape";
            this.lblHelp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlTop
            // 
            this.pnlTop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTop.Controls.Add(this.txtBankNameSearch);
            this.pnlTop.Controls.Add(this.lblBankNameSearch);
            this.pnlTop.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.pnlTop.Location = new System.Drawing.Point(3, 24);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlTop.Size = new System.Drawing.Size(744, 34);
            this.pnlTop.TabIndex = 3;
            // 
            // txtBankNameSearch
            // 
            this.txtBankNameSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBankNameSearch.BackColor = System.Drawing.Color.White;
            this.txtBankNameSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBankNameSearch.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.txtBankNameSearch.ForeColor = System.Drawing.Color.Black;
            this.txtBankNameSearch.Location = new System.Drawing.Point(0, 1);
            this.txtBankNameSearch.Margin = new System.Windows.Forms.Padding(10);
            this.txtBankNameSearch.Name = "txtBankNameSearch";
            this.txtBankNameSearch.NextControl = null;
            this.txtBankNameSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtBankNameSearch.Size = new System.Drawing.Size(682, 28);
            this.txtBankNameSearch.TabIndex = 1;
            this.txtBankNameSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBankNameSearch.TextChanged += new System.EventHandler(this.txtBankNameSearch_TextChanged);
            this.txtBankNameSearch.Enter += new System.EventHandler(this.txtBankNameSearch_Enter);
            this.txtBankNameSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBankNameSearch_KeyDown);
            // 
            // lblBankNameSearch
            // 
            this.lblBankNameSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBankNameSearch.AutoSize = true;
            this.lblBankNameSearch.BackColor = System.Drawing.Color.Transparent;
            this.lblBankNameSearch.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.lblBankNameSearch.Location = new System.Drawing.Point(695, 3);
            this.lblBankNameSearch.Name = "lblBankNameSearch";
            this.lblBankNameSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblBankNameSearch.Size = new System.Drawing.Size(46, 20);
            this.lblBankNameSearch.TabIndex = 0;
            this.lblBankNameSearch.Text = "جستجو";
            this.lblBankNameSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BankNameSelect
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.groupBoxBankNameSelect);
            this.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "BankNameSelect";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(750, 500);
            this.Tag = "انتخاب نام بانك";
            this.Load += new System.EventHandler(this.BankNameSelect_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BankNameSelect_KeyDown);
            this.groupBoxBankNameSelect.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBankName)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        private void BankNameSelect_Load(object sender, EventArgs e)
        {
            txtBankNameSearch.Focus();
            var bankNameList = @class.GetBankName().Where(i => i.Active).ToList();
            dgvBankName.DataSource = bankNameList;
            SetGridView();
        }

        private void SetGridView()
        {
            foreach (DataGridViewColumn item in dgvBankName.Columns)
            {
                item.Visible = false;
            }
            dgvBankName.Columns["ID"].Visible = true;
            dgvBankName.Columns["Name"].Visible = true;
            dgvBankName.Columns["Description"].Visible = true;

            dgvBankName.Columns["ID"].HeaderText = "رديف";
            dgvBankName.Columns["Name"].HeaderText = "نام بانك";
            dgvBankName.Columns["Description"].HeaderText = "توضيحات";

            dgvBankName.Columns["ID"].DisplayIndex = 0;
            dgvBankName.Columns["Name"].DisplayIndex = 1;
            dgvBankName.Columns["Description"].DisplayIndex = 2;

            dgvBankName.Columns["ID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvBankName.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvBankName.Columns["Description"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvBankName.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvBankName.Columns["ID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvBankName.Columns["Name"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvBankName.Columns["Description"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            dgvBankName.AutoGenerateColumns = false;

        }

        private void FillBankNameList()
        {
            info.Add((BankName)dgvBankName.CurrentRow?.DataBoundItem);
        }

        private void txtBankNameSearch_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Down:
                    SendKeys.Send("{END}");
                    if (dgvBankName.Rows.Count > 0)
                    {
                        int selected;
                        if (dgvBankName.CurrentRow == null)
                        {
                            selected = 0;
                            dgvBankName.CurrentCell = dgvBankName.Rows[0].Cells["ID"];
                        }
                        else
                        {
                            selected = dgvBankName.CurrentRow.Index;
                        }

                        switch (e.KeyCode)
                        {
                            case Keys.Down:
                                dgvBankName.CurrentCell = selected < dgvBankName.Rows.Count - 1 ? dgvBankName.Rows[selected + 1].Cells["ID"] : dgvBankName.Rows[0].Cells["ID"];
                                break;
                            case Keys.Up:
                                dgvBankName.CurrentCell = selected > 0 ? dgvBankName.Rows[selected - 1].Cells["ID"] : dgvBankName.Rows[dgvBankName.Rows.Count - 1].Cells["ID"];
                                break;
                        }
                    }

                    break;
                case Keys.Up:
                    SendKeys.Send("{END}");
                    if (dgvBankName.Rows.Count > 0)
                    {
                        int selected;
                        if (dgvBankName.CurrentRow == null)
                        {
                            selected = 0;
                            dgvBankName.CurrentCell = dgvBankName.Rows[0].Cells["ID"];
                        }
                        else
                        {
                            selected = dgvBankName.CurrentRow.Index;
                        }

                        switch (e.KeyCode)
                        {
                            case Keys.Down:
                                dgvBankName.CurrentCell = selected < dgvBankName.Rows.Count - 1 ? dgvBankName.Rows[selected + 1].Cells["ID"] : dgvBankName.Rows[0].Cells["ID"];
                                break;
                            case Keys.Up:
                                dgvBankName.CurrentCell = selected > 0 ? dgvBankName.Rows[selected - 1].Cells["ID"] : dgvBankName.Rows[dgvBankName.Rows.Count - 1].Cells["ID"];
                                break;
                        }
                    }

                    break;
                case Keys.Enter when dgvBankName.Rows.Count > 0 && dgvBankName.CurrentRow != null:
                    FillBankNameList();
                    ParentForm?.Close();
                    break;
            }

            switch (e.KeyCode)
            {
                case Keys.Enter when dgvBankName.Rows.Count > 0 && dgvBankName.CurrentRow == null:
                    dgvBankName.Focus();
                    SendKeys.Send("{Enter}");
                    break;
            }
        }

        private void txtBankNameSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var bankNameList = @class.GetBankName().Where(i => i.Name.Contains(txtBankNameSearch.Text)).ToList();
                dgvBankName.DataSource = bankNameList;

                if (dgvBankName.Rows.Count != 0)
                {
                    dgvBankName.CurrentCell = dgvBankName.Rows[0].Cells["ID"];
                }
            }
            catch (Exception ex)
            {
                CustomMessageForm.CustomMessageBox.Show("خطا !", $"خطا در جستجوي ليست استان ها\n\n{ex.Message}", "e");
            }
        }

        private void txtBankNameSearch_Enter(object sender, EventArgs e)
        {
            txtBankNameSearch.SelectAll();
        }

        private void BankNameSelect_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
                CustomMessageForm.CustomMessageBox.Show("راهنماي برنامه",
                    "جهت جستجو در اطلاعات نام بانك ها مي توانيد از امكان جستجو استفاده نماييد\n\nجهت انتخاب نام بانك كليد اينتر و جهت لغو كليد ESC را فشار دهيد",
                    "i");
        }

        private void dgvBankName_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter when dgvBankName.Rows.Count > 0:
                    FillBankNameList();
                    ParentForm?.Close();
                    break;
                case Keys.ControlKey:
                    txtBankNameSearch.Focus();
                    break;
            }
        }

        private void dgvBankName_DoubleClick(object sender, EventArgs e)
        {
            if (dgvBankName.Rows.Count <= 0) return;
            FillBankNameList();
            ParentForm?.Close();
        }

        private void dgvBankName_Enter(object sender, EventArgs e)
        {
            txtBankNameSearch.Focus();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                info.Clear();
                this.ParentForm?.Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
