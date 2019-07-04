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
    public class ProvinceSelect : UserControl
    {
        #region Region 
        ConnectionClasses @class = new ConnectionClasses();
        private UI.Control.UIElement.GroupBox groupBoxProvinceSelect;
        private UI.Control.UIElement.Panel pnlMain;
        private UI.Control.UIElement.DataGridView dgvProvince;
        private UI.Control.UIElement.Panel pnlBottom;
        private UI.Control.UIElement.Panel pnlTop;
        private UI.Control.TextBox.TextBox txtProvinceSearch;
        private UI.Control.Label.Label lblProvinceSearch;
        private UI.Control.Label.Label lblHelp;
        private List<Province> info;
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

        public ProvinceSelect(List<Province> info_)
        {
            InitializeComponent();
            info = info_;
            ProvinceSelect_Load(null, null);
        }

        private void InitializeComponent()
        {
            this.groupBoxProvinceSelect = new TinyTech.UI.Control.UIElement.GroupBox();
            this.pnlMain = new TinyTech.UI.Control.UIElement.Panel();
            this.dgvProvince = new TinyTech.UI.Control.UIElement.DataGridView();
            this.pnlBottom = new TinyTech.UI.Control.UIElement.Panel();
            this.lblHelp = new TinyTech.UI.Control.Label.Label();
            this.pnlTop = new TinyTech.UI.Control.UIElement.Panel();
            this.txtProvinceSearch = new TinyTech.UI.Control.TextBox.TextBox();
            this.lblProvinceSearch = new TinyTech.UI.Control.Label.Label();
            this.groupBoxProvinceSelect.SuspendLayout();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProvince)).BeginInit();
            this.pnlBottom.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxProvinceSelect
            // 
            this.groupBoxProvinceSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxProvinceSelect.Controls.Add(this.pnlMain);
            this.groupBoxProvinceSelect.Controls.Add(this.pnlBottom);
            this.groupBoxProvinceSelect.Controls.Add(this.pnlTop);
            this.groupBoxProvinceSelect.Location = new System.Drawing.Point(0, 0);
            this.groupBoxProvinceSelect.Name = "groupBoxProvinceSelect";
            this.groupBoxProvinceSelect.Size = new System.Drawing.Size(750, 500);
            this.groupBoxProvinceSelect.TabIndex = 0;
            this.groupBoxProvinceSelect.TabStop = false;
            this.groupBoxProvinceSelect.Text = "انتخاب استان";
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMain.Controls.Add(this.dgvProvince);
            this.pnlMain.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.pnlMain.Location = new System.Drawing.Point(3, 58);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlMain.Size = new System.Drawing.Size(744, 415);
            this.pnlMain.TabIndex = 5;
            // 
            // dgvProvince
            // 
            this.dgvProvince.AllowUserToAddRows = false;
            this.dgvProvince.AllowUserToDeleteRows = false;
            this.dgvProvince.AllowUserToOrderColumns = true;
            this.dgvProvince.AllowUserToResizeColumns = false;
            this.dgvProvince.AllowUserToResizeRows = false;
            this.dgvProvince.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProvince.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProvince.Location = new System.Drawing.Point(0, 0);
            this.dgvProvince.MultiSelect = false;
            this.dgvProvince.Name = "dgvProvince";
            this.dgvProvince.ReadOnly = true;
            this.dgvProvince.RowHeadersVisible = false;
            this.dgvProvince.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProvince.Size = new System.Drawing.Size(744, 415);
            this.dgvProvince.TabIndex = 0;
            this.dgvProvince.DoubleClick += new System.EventHandler(this.dgvProvince_DoubleClick);
            this.dgvProvince.Enter += new System.EventHandler(this.dgvProvince_Enter);
            this.dgvProvince.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvProvince_KeyDown);
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
            this.pnlTop.Controls.Add(this.txtProvinceSearch);
            this.pnlTop.Controls.Add(this.lblProvinceSearch);
            this.pnlTop.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.pnlTop.Location = new System.Drawing.Point(3, 24);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlTop.Size = new System.Drawing.Size(744, 34);
            this.pnlTop.TabIndex = 3;
            // 
            // txtProvinceSearch
            // 
            this.txtProvinceSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProvinceSearch.BackColor = System.Drawing.Color.White;
            this.txtProvinceSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProvinceSearch.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.txtProvinceSearch.ForeColor = System.Drawing.Color.Black;
            this.txtProvinceSearch.Location = new System.Drawing.Point(0, 1);
            this.txtProvinceSearch.Margin = new System.Windows.Forms.Padding(10);
            this.txtProvinceSearch.Name = "txtProvinceSearch";
            this.txtProvinceSearch.NextControl = null;
            this.txtProvinceSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtProvinceSearch.Size = new System.Drawing.Size(682, 28);
            this.txtProvinceSearch.TabIndex = 1;
            this.txtProvinceSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtProvinceSearch.TextChanged += new System.EventHandler(this.txtProvinceSearch_TextChanged);
            this.txtProvinceSearch.Enter += new System.EventHandler(this.txtProvinceSearch_Enter);
            this.txtProvinceSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProvinceSearch_KeyDown);
            // 
            // lblProvinceSearch
            // 
            this.lblProvinceSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProvinceSearch.AutoSize = true;
            this.lblProvinceSearch.BackColor = System.Drawing.Color.Transparent;
            this.lblProvinceSearch.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.lblProvinceSearch.Location = new System.Drawing.Point(695, 3);
            this.lblProvinceSearch.Name = "lblProvinceSearch";
            this.lblProvinceSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblProvinceSearch.Size = new System.Drawing.Size(46, 20);
            this.lblProvinceSearch.TabIndex = 0;
            this.lblProvinceSearch.Text = "جستجو";
            this.lblProvinceSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProvinceSelect
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.groupBoxProvinceSelect);
            this.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "ProvinceSelect";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(750, 500);
            this.Tag = "انتخاب استان";
            this.Load += new System.EventHandler(this.ProvinceSelect_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProvinceSelect_KeyDown);
            this.groupBoxProvinceSelect.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProvince)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        private DataTable ProvinceListDataTable(List<Province> provinceList)
        {
            var dataTable = UI.Control.UIElement.ToolBox<Province>.GetDataTable(provinceList);
            return dataTable;
        }

        private void ProvinceSelect_Load(object sender, EventArgs e)
        {
            txtProvinceSearch.Focus();
            var provinceList = @class.GetProvince(true).ToList();
            dgvProvince.DataSource = provinceList; //ProvinceListDataTable(provinceList);
            SetGridView();
        }

        private void SetGridView()
        {
            foreach (DataGridViewColumn item in dgvProvince.Columns)
            {
                item.Visible = false;
            }
            dgvProvince.Columns["ID"].Visible = true;
            dgvProvince.Columns["Name"].Visible = true;
            dgvProvince.Columns["Description"].Visible = true;

            dgvProvince.Columns["ID"].HeaderText = "رديف";
            dgvProvince.Columns["Name"].HeaderText = "نام";
            dgvProvince.Columns["Description"].HeaderText = "توضيحات";

            dgvProvince.Columns["ID"].DisplayIndex = 0;
            dgvProvince.Columns["Name"].DisplayIndex = 1;
            dgvProvince.Columns["Description"].DisplayIndex = 2;

            dgvProvince.Columns["ID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvProvince.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvProvince.Columns["Description"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvProvince.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvProvince.Columns["ID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProvince.Columns["Name"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvProvince.Columns["Description"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            dgvProvince.AutoGenerateColumns = false;

        }

        private void txtProvinceSearch_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Down:
                    SendKeys.Send("{END}");
                    if (dgvProvince.Rows.Count > 0)
                    {
                        int selected;
                        if (dgvProvince.CurrentRow == null)
                        {
                            selected = 0;
                            dgvProvince.CurrentCell = dgvProvince.Rows[0].Cells["ID"];
                        }
                        else
                        {
                            selected = dgvProvince.CurrentRow.Index;
                        }

                        switch (e.KeyCode)
                        {
                            case Keys.Down:
                                dgvProvince.CurrentCell = selected < dgvProvince.Rows.Count - 1 ? dgvProvince.Rows[selected + 1].Cells["ID"] : dgvProvince.Rows[0].Cells["ID"];
                                break;
                            case Keys.Up:
                                dgvProvince.CurrentCell = selected > 0 ? dgvProvince.Rows[selected - 1].Cells["ID"] : dgvProvince.Rows[dgvProvince.Rows.Count - 1].Cells["ID"];
                                break;
                        }
                    }

                    break;
                case Keys.Up:
                    SendKeys.Send("{END}");
                    if (dgvProvince.Rows.Count > 0)
                    {
                        int selected;
                        if (dgvProvince.CurrentRow == null)
                        {
                            selected = 0;
                            dgvProvince.CurrentCell = dgvProvince.Rows[0].Cells["ID"];
                        }
                        else
                        {
                            selected = dgvProvince.CurrentRow.Index;
                        }

                        switch (e.KeyCode)
                        {
                            case Keys.Down:
                                dgvProvince.CurrentCell = selected < dgvProvince.Rows.Count - 1 ? dgvProvince.Rows[selected + 1].Cells["ID"] : dgvProvince.Rows[0].Cells["ID"];
                                break;
                            case Keys.Up:
                                dgvProvince.CurrentCell = selected > 0 ? dgvProvince.Rows[selected - 1].Cells["ID"] : dgvProvince.Rows[dgvProvince.Rows.Count - 1].Cells["ID"];
                                break;
                        }
                    }

                    break;
                case Keys.Enter when dgvProvince.Rows.Count > 0 && dgvProvince.CurrentRow != null:
                    FillProvinceList();
                    ParentForm?.Close();
                    break;
            }

            switch (e.KeyCode)
            {
                case Keys.Enter when dgvProvince.Rows.Count > 0 && dgvProvince.CurrentRow == null:
                    dgvProvince.Focus();
                    SendKeys.Send("{Enter}");
                    break;
            }
        }

        private void FillProvinceList()
        {
            info.Add((Province)dgvProvince.CurrentRow?.DataBoundItem);
        }

        private void txtProvinceSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var provinceList = @class.GetProvince(true).Where(i => i.Name.Contains(txtProvinceSearch.Text)).ToList();
                dgvProvince.DataSource = provinceList; //ProvinceListDataTable(provinceList);

                if (dgvProvince.Rows.Count != 0)
                {
                    dgvProvince.CurrentCell = dgvProvince.Rows[0].Cells["ID"];
                }
            }
            catch (Exception ex)
            {
                CustomMessageForm.CustomMessageBox.Show("خطا !", $"خطا در جستجوي ليست استان ها\n\n{ex.Message}", "e");
            }
        }

        private void txtProvinceSearch_Enter(object sender, EventArgs e)
        {
            txtProvinceSearch.SelectAll();
        }

        private void ProvinceSelect_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
                CustomMessageForm.CustomMessageBox.Show("راهنماي برنامه",
                    "جهت جستجو در اطلاعات استان ها مي توانيد از امكان جستجو استفاده نماييد\n\nجهت انتخاب استان كليد اينتر و جهت لغو كليد ESC را فشار دهيد",
                    "i");
        }

        private void dgvProvince_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter when dgvProvince.Rows.Count > 0:
                    FillProvinceList();
                    ParentForm?.Close();
                    break;
                case Keys.ControlKey:
                    txtProvinceSearch.Focus();
                    break;
            }
        }

        private void dgvProvince_DoubleClick(object sender, EventArgs e)
        {
            if (dgvProvince.Rows.Count <= 0) return;
            FillProvinceList();
            ParentForm?.Close();
        }

        private void dgvProvince_Enter(object sender, EventArgs e)
        {
            txtProvinceSearch.Focus();
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
