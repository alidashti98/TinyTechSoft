using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using TinyTech.Connection;
using TinyTech.UI.Control.MessageBox;
using UserControl = TinyTech.UI.Control.UIElement.UserControl;

namespace TinyTech.Selecting
{
    public class BankAccountTypeSelect : UserControl
    {
        #region Region 
        ConnectionClasses @class = new ConnectionClasses();
        private UI.Control.UIElement.GroupBox groupBoxBankAccountTypeSelect;
        private UI.Control.UIElement.Panel pnlMain;
        private UI.Control.UIElement.DataGridView dgvBankAccountType;
        private UI.Control.UIElement.Panel pnlBottom;
        private UI.Control.UIElement.Panel pnlTop;
        private UI.Control.TextBox.TextBox txtBankAccountTypeSearch;
        private UI.Control.Label.Label lblBankAccountTypeSearch;
        private UI.Control.Label.Label lblHelp;
        private List<BankAccountType> info;
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

        public BankAccountTypeSelect(List<BankAccountType> info_)
        {
            InitializeComponent();
            info = info_;
            BankAccountTypeSelect_Load(null, null);
        }

        private void InitializeComponent()
        {
            this.groupBoxBankAccountTypeSelect = new TinyTech.UI.Control.UIElement.GroupBox();
            this.pnlMain = new TinyTech.UI.Control.UIElement.Panel();
            this.dgvBankAccountType = new TinyTech.UI.Control.UIElement.DataGridView();
            this.pnlBottom = new TinyTech.UI.Control.UIElement.Panel();
            this.lblHelp = new TinyTech.UI.Control.Label.Label();
            this.pnlTop = new TinyTech.UI.Control.UIElement.Panel();
            this.txtBankAccountTypeSearch = new TinyTech.UI.Control.TextBox.TextBox();
            this.lblBankAccountTypeSearch = new TinyTech.UI.Control.Label.Label();
            this.groupBoxBankAccountTypeSelect.SuspendLayout();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBankAccountType)).BeginInit();
            this.pnlBottom.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxBankAccountTypeSelect
            // 
            this.groupBoxBankAccountTypeSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxBankAccountTypeSelect.Controls.Add(this.pnlMain);
            this.groupBoxBankAccountTypeSelect.Controls.Add(this.pnlBottom);
            this.groupBoxBankAccountTypeSelect.Controls.Add(this.pnlTop);
            this.groupBoxBankAccountTypeSelect.Location = new System.Drawing.Point(0, 0);
            this.groupBoxBankAccountTypeSelect.Name = "groupBoxBankAccountTypeSelect";
            this.groupBoxBankAccountTypeSelect.Size = new System.Drawing.Size(750, 500);
            this.groupBoxBankAccountTypeSelect.TabIndex = 0;
            this.groupBoxBankAccountTypeSelect.TabStop = false;
            this.groupBoxBankAccountTypeSelect.Text = "انتخاب نوع حساب";
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMain.Controls.Add(this.dgvBankAccountType);
            this.pnlMain.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.pnlMain.Location = new System.Drawing.Point(3, 58);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlMain.Size = new System.Drawing.Size(744, 415);
            this.pnlMain.TabIndex = 5;
            // 
            // dgvBankAccountType
            // 
            this.dgvBankAccountType.AllowUserToAddRows = false;
            this.dgvBankAccountType.AllowUserToDeleteRows = false;
            this.dgvBankAccountType.AllowUserToOrderColumns = true;
            this.dgvBankAccountType.AllowUserToResizeColumns = false;
            this.dgvBankAccountType.AllowUserToResizeRows = false;
            this.dgvBankAccountType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBankAccountType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBankAccountType.Location = new System.Drawing.Point(0, 0);
            this.dgvBankAccountType.MultiSelect = false;
            this.dgvBankAccountType.Name = "dgvBankAccountType";
            this.dgvBankAccountType.ReadOnly = true;
            this.dgvBankAccountType.RowHeadersVisible = false;
            this.dgvBankAccountType.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvBankAccountType.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBankAccountType.Size = new System.Drawing.Size(744, 415);
            this.dgvBankAccountType.TabIndex = 0;
            this.dgvBankAccountType.DoubleClick += new System.EventHandler(this.dgvBankAccountType_DoubleClick);
            this.dgvBankAccountType.Enter += new System.EventHandler(this.dgvBankAccountType_Enter);
            this.dgvBankAccountType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvBankAccountType_KeyDown);
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
            this.pnlTop.Controls.Add(this.txtBankAccountTypeSearch);
            this.pnlTop.Controls.Add(this.lblBankAccountTypeSearch);
            this.pnlTop.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.pnlTop.Location = new System.Drawing.Point(3, 24);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlTop.Size = new System.Drawing.Size(744, 34);
            this.pnlTop.TabIndex = 3;
            // 
            // txtBankAccountTypeSearch
            // 
            this.txtBankAccountTypeSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBankAccountTypeSearch.BackColor = System.Drawing.Color.White;
            this.txtBankAccountTypeSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBankAccountTypeSearch.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.txtBankAccountTypeSearch.ForeColor = System.Drawing.Color.Black;
            this.txtBankAccountTypeSearch.Location = new System.Drawing.Point(0, 1);
            this.txtBankAccountTypeSearch.Margin = new System.Windows.Forms.Padding(10);
            this.txtBankAccountTypeSearch.Name = "txtBankAccountTypeSearch";
            this.txtBankAccountTypeSearch.NextControl = null;
            this.txtBankAccountTypeSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtBankAccountTypeSearch.Size = new System.Drawing.Size(682, 28);
            this.txtBankAccountTypeSearch.TabIndex = 1;
            this.txtBankAccountTypeSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBankAccountTypeSearch.TextChanged += new System.EventHandler(this.txtBankAccountTypeSearch_TextChanged);
            this.txtBankAccountTypeSearch.Enter += new System.EventHandler(this.txtBankAccountTypeSearch_Enter);
            this.txtBankAccountTypeSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBankAccountTypeSearch_KeyDown);
            // 
            // lblBankAccountTypeSearch
            // 
            this.lblBankAccountTypeSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBankAccountTypeSearch.AutoSize = true;
            this.lblBankAccountTypeSearch.BackColor = System.Drawing.Color.Transparent;
            this.lblBankAccountTypeSearch.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.lblBankAccountTypeSearch.Location = new System.Drawing.Point(695, 3);
            this.lblBankAccountTypeSearch.Name = "lblBankAccountTypeSearch";
            this.lblBankAccountTypeSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblBankAccountTypeSearch.Size = new System.Drawing.Size(46, 20);
            this.lblBankAccountTypeSearch.TabIndex = 0;
            this.lblBankAccountTypeSearch.Text = "جستجو";
            this.lblBankAccountTypeSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BankAccountTypeSelect
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.groupBoxBankAccountTypeSelect);
            this.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "BankAccountTypeSelect";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(750, 500);
            this.Tag = "انتخاب نوع حساب";
            this.Load += new System.EventHandler(this.BankAccountTypeSelect_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BankAccountTypeSelect_KeyDown);
            this.groupBoxBankAccountTypeSelect.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBankAccountType)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        private void BankAccountTypeSelect_Load(object sender, EventArgs e)
        {
            txtBankAccountTypeSearch.Focus();
            var bankAccountTypeList = @class.GetBankAccountType().Where(i => i.Active).ToList();
            dgvBankAccountType.DataSource = bankAccountTypeList;
            SetGridView();
        }

        private void SetGridView()
        {
            foreach (DataGridViewColumn item in dgvBankAccountType.Columns)
            {
                item.Visible = false;
            }
            dgvBankAccountType.Columns["ID"].Visible = true;
            dgvBankAccountType.Columns["Name"].Visible = true;
            dgvBankAccountType.Columns["Description"].Visible = true;

            dgvBankAccountType.Columns["ID"].HeaderText = "رديف";
            dgvBankAccountType.Columns["Name"].HeaderText = "نوع حساب";
            dgvBankAccountType.Columns["Description"].HeaderText = "توضيحات";

            dgvBankAccountType.Columns["ID"].DisplayIndex = 0;
            dgvBankAccountType.Columns["Name"].DisplayIndex = 1;
            dgvBankAccountType.Columns["Description"].DisplayIndex = 2;

            dgvBankAccountType.Columns["ID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvBankAccountType.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvBankAccountType.Columns["Description"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvBankAccountType.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvBankAccountType.Columns["ID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvBankAccountType.Columns["Name"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvBankAccountType.Columns["Description"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            dgvBankAccountType.AutoGenerateColumns = false;

        }

        private void FillBankAccountTypeList()
        {
            info.Add((BankAccountType)dgvBankAccountType.CurrentRow?.DataBoundItem);
        }

        private void txtBankAccountTypeSearch_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Down:
                    SendKeys.Send("{END}");
                    if (dgvBankAccountType.Rows.Count > 0)
                    {
                        int selected;
                        if (dgvBankAccountType.CurrentRow == null)
                        {
                            selected = 0;
                            dgvBankAccountType.CurrentCell = dgvBankAccountType.Rows[0].Cells["ID"];
                        }
                        else
                        {
                            selected = dgvBankAccountType.CurrentRow.Index;
                        }

                        switch (e.KeyCode)
                        {
                            case Keys.Down:
                                dgvBankAccountType.CurrentCell = selected < dgvBankAccountType.Rows.Count - 1 ? dgvBankAccountType.Rows[selected + 1].Cells["ID"] : dgvBankAccountType.Rows[0].Cells["ID"];
                                break;
                            case Keys.Up:
                                dgvBankAccountType.CurrentCell = selected > 0 ? dgvBankAccountType.Rows[selected - 1].Cells["ID"] : dgvBankAccountType.Rows[dgvBankAccountType.Rows.Count - 1].Cells["ID"];
                                break;
                        }
                    }

                    break;
                case Keys.Up:
                    SendKeys.Send("{END}");
                    if (dgvBankAccountType.Rows.Count > 0)
                    {
                        int selected;
                        if (dgvBankAccountType.CurrentRow == null)
                        {
                            selected = 0;
                            dgvBankAccountType.CurrentCell = dgvBankAccountType.Rows[0].Cells["ID"];
                        }
                        else
                        {
                            selected = dgvBankAccountType.CurrentRow.Index;
                        }

                        switch (e.KeyCode)
                        {
                            case Keys.Down:
                                dgvBankAccountType.CurrentCell = selected < dgvBankAccountType.Rows.Count - 1 ? dgvBankAccountType.Rows[selected + 1].Cells["ID"] : dgvBankAccountType.Rows[0].Cells["ID"];
                                break;
                            case Keys.Up:
                                dgvBankAccountType.CurrentCell = selected > 0 ? dgvBankAccountType.Rows[selected - 1].Cells["ID"] : dgvBankAccountType.Rows[dgvBankAccountType.Rows.Count - 1].Cells["ID"];
                                break;
                        }
                    }

                    break;
                case Keys.Enter when dgvBankAccountType.Rows.Count > 0 && dgvBankAccountType.CurrentRow != null:
                    FillBankAccountTypeList();
                    ParentForm?.Close();
                    break;
            }

            switch (e.KeyCode)
            {
                case Keys.Enter when dgvBankAccountType.Rows.Count > 0 && dgvBankAccountType.CurrentRow == null:
                    dgvBankAccountType.Focus();
                    SendKeys.Send("{Enter}");
                    break;
            }
        }

        private void txtBankAccountTypeSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var bankAccountTypeList = @class.GetBankAccountType().Where(i => i.Name.Contains(txtBankAccountTypeSearch.Text)).ToList();
                dgvBankAccountType.DataSource = bankAccountTypeList;

                if (dgvBankAccountType.Rows.Count != 0)
                {
                    dgvBankAccountType.CurrentCell = dgvBankAccountType.Rows[0].Cells["ID"];
                }
            }
            catch (Exception ex)
            {
                CustomMessageForm.CustomMessageBox.Show("خطا !", $"خطا در جستجوي ليست استان ها\n\n{ex.Message}", "e");
            }
        }

        private void txtBankAccountTypeSearch_Enter(object sender, EventArgs e)
        {
            txtBankAccountTypeSearch.SelectAll();
        }

        private void BankAccountTypeSelect_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
                CustomMessageForm.CustomMessageBox.Show("راهنماي برنامه",
                    "جهت جستجو در اطلاعات نوع حساب ها مي توانيد از امكان جستجو استفاده نماييد\n\nجهت انتخاب نوع حساب كليد اينتر و جهت لغو كليد ESC را فشار دهيد",
                    "i");
        }

        private void dgvBankAccountType_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter when dgvBankAccountType.Rows.Count > 0:
                    FillBankAccountTypeList();
                    ParentForm?.Close();
                    break;
                case Keys.ControlKey:
                    txtBankAccountTypeSearch.Focus();
                    break;
            }
        }

        private void dgvBankAccountType_DoubleClick(object sender, EventArgs e)
        {
            if (dgvBankAccountType.Rows.Count <= 0) return;
            FillBankAccountTypeList();
            ParentForm?.Close();
        }

        private void dgvBankAccountType_Enter(object sender, EventArgs e)
        {
            txtBankAccountTypeSearch.Focus();
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
