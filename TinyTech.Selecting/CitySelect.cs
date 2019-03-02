using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using TinyTech.Connection;
using TinyTech.UI.Control.MessageBox;

namespace TinyTech.Selecting
{
    public class CitySelect : TinyTech.UI.Control.UIElement.UserControl
    {
        #region Region 
        ConnectionClasses @class = new ConnectionClasses();
        private UI.Control.UIElement.GroupBox groupBoxCitySelect;
        private UI.Control.UIElement.Panel pnlMain;
        private UI.Control.UIElement.DataGridView dgvCity;
        private UI.Control.UIElement.Panel pnlBottom;
        private UI.Control.UIElement.Panel pnlTop;
        private UI.Control.TextBox.TextBox txtCitySearch;
        private UI.Control.Label.Label lblCitySearch;
        private UI.Control.Label.Label lblHelp;
        private ArrayList info;
        private int ProvinceID;
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
        public CitySelect(ArrayList info_, int ProvinceID_)
        {
            InitializeComponent();
            info = info_;
            ProvinceID = ProvinceID_;
            CitySelect_Load(null, null);
        }

        private void InitializeComponent()
        {
            this.groupBoxCitySelect = new TinyTech.UI.Control.UIElement.GroupBox();
            this.pnlMain = new TinyTech.UI.Control.UIElement.Panel();
            this.dgvCity = new TinyTech.UI.Control.UIElement.DataGridView();
            this.pnlBottom = new TinyTech.UI.Control.UIElement.Panel();
            this.lblHelp = new TinyTech.UI.Control.Label.Label();
            this.pnlTop = new TinyTech.UI.Control.UIElement.Panel();
            this.txtCitySearch = new TinyTech.UI.Control.TextBox.TextBox();
            this.lblCitySearch = new TinyTech.UI.Control.Label.Label();
            this.groupBoxCitySelect.SuspendLayout();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCity)).BeginInit();
            this.pnlBottom.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCitySelect
            // 
            this.groupBoxCitySelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxCitySelect.Controls.Add(this.pnlMain);
            this.groupBoxCitySelect.Controls.Add(this.pnlBottom);
            this.groupBoxCitySelect.Controls.Add(this.pnlTop);
            this.groupBoxCitySelect.Location = new System.Drawing.Point(0, 0);
            this.groupBoxCitySelect.Name = "groupBoxCitySelect";
            this.groupBoxCitySelect.Size = new System.Drawing.Size(750, 500);
            this.groupBoxCitySelect.TabIndex = 0;
            this.groupBoxCitySelect.TabStop = false;
            this.groupBoxCitySelect.Text = "انتخاب شهر";
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMain.Controls.Add(this.dgvCity);
            this.pnlMain.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.pnlMain.Location = new System.Drawing.Point(3, 58);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlMain.Size = new System.Drawing.Size(744, 415);
            this.pnlMain.TabIndex = 5;
            // 
            // dgvCity
            // 
            this.dgvCity.AllowUserToAddRows = false;
            this.dgvCity.AllowUserToDeleteRows = false;
            this.dgvCity.AllowUserToOrderColumns = true;
            this.dgvCity.AllowUserToResizeColumns = false;
            this.dgvCity.AllowUserToResizeRows = false;
            this.dgvCity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCity.Location = new System.Drawing.Point(0, 0);
            this.dgvCity.MultiSelect = false;
            this.dgvCity.Name = "dgvCity";
            this.dgvCity.ReadOnly = true;
            this.dgvCity.RowHeadersVisible = false;
            this.dgvCity.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCity.Size = new System.Drawing.Size(744, 415);
            this.dgvCity.TabIndex = 0;
            this.dgvCity.DoubleClick += new System.EventHandler(this.dgvCity_DoubleClick);
            this.dgvCity.Enter += new System.EventHandler(this.dgvCity_Enter);
            this.dgvCity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvCity_KeyDown);
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
            this.pnlTop.Controls.Add(this.txtCitySearch);
            this.pnlTop.Controls.Add(this.lblCitySearch);
            this.pnlTop.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.pnlTop.Location = new System.Drawing.Point(3, 24);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlTop.Size = new System.Drawing.Size(744, 34);
            this.pnlTop.TabIndex = 3;
            // 
            // txtCitySearch
            // 
            this.txtCitySearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCitySearch.BackColor = System.Drawing.Color.White;
            this.txtCitySearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCitySearch.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.txtCitySearch.ForeColor = System.Drawing.Color.Black;
            this.txtCitySearch.Location = new System.Drawing.Point(0, 1);
            this.txtCitySearch.Margin = new System.Windows.Forms.Padding(10);
            this.txtCitySearch.Name = "txtCitySearch";
            this.txtCitySearch.NextControl = null;
            this.txtCitySearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCitySearch.Size = new System.Drawing.Size(682, 28);
            this.txtCitySearch.TabIndex = 1;
            this.txtCitySearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCitySearch.TextChanged += new System.EventHandler(this.txtCitySearch_TextChanged);
            this.txtCitySearch.Enter += new System.EventHandler(this.txtCitySearch_Enter);
            this.txtCitySearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCitySearch_KeyDown);
            // 
            // lblCitySearch
            // 
            this.lblCitySearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCitySearch.AutoSize = true;
            this.lblCitySearch.BackColor = System.Drawing.Color.Transparent;
            this.lblCitySearch.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.lblCitySearch.Location = new System.Drawing.Point(695, 3);
            this.lblCitySearch.Name = "lblCitySearch";
            this.lblCitySearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblCitySearch.Size = new System.Drawing.Size(46, 20);
            this.lblCitySearch.TabIndex = 0;
            this.lblCitySearch.Text = "جستجو";
            this.lblCitySearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CitySelect
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.groupBoxCitySelect);
            this.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "CitySelect";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(750, 500);
            this.Tag = "انتخاب شهر";
            this.Load += new System.EventHandler(this.CitySelect_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CitySelect_KeyDown);
            this.groupBoxCitySelect.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCity)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        private DataTable CityListDataTable(List<ConnectionClasses.CityList> cityList)
        {
            var dataTable = UI.Control.UIElement.ToolBox<ConnectionClasses.CityList>.GetDataTable(cityList);
            return dataTable;
        }

        private void CitySelect_Load(object sender, EventArgs e)
        {
            txtCitySearch.Focus();
            var cityList = @class.GetCity().Where(i => i.Active && i.ProvinceID == ProvinceID).ToList();
            dgvCity.DataSource = CityListDataTable(cityList);
            SetGridView();
        }

        private void SetGridView()
        {
            foreach (DataGridViewColumn item in dgvCity.Columns)
            {
                item.Visible = false;
            }
            dgvCity.Columns["ID"].Visible = true;
            dgvCity.Columns["Name"].Visible = true;
            dgvCity.Columns["Description"].Visible = true;

            dgvCity.Columns["ID"].HeaderText = "رديف";
            dgvCity.Columns["Name"].HeaderText = "نام";
            dgvCity.Columns["Description"].HeaderText = "توضيحات";

            dgvCity.Columns["ID"].DisplayIndex = 0;
            dgvCity.Columns["Name"].DisplayIndex = 1;
            dgvCity.Columns["Description"].DisplayIndex = 2;

            dgvCity.Columns["ID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvCity.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvCity.Columns["Description"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvCity.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvCity.Columns["ID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvCity.Columns["Name"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvCity.Columns["Description"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            dgvCity.AutoGenerateColumns = false;

        }

        private void txtCitySearch_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Down:
                    SendKeys.Send("{END}");
                    if (dgvCity.Rows.Count > 0)
                    {
                        int selected;
                        if (dgvCity.CurrentRow == null)
                        {
                            selected = 0;
                            dgvCity.CurrentCell = dgvCity.Rows[0].Cells["ID"];
                        }
                        else
                        {
                            selected = dgvCity.CurrentRow.Index;
                        }

                        switch (e.KeyCode)
                        {
                            case Keys.Down:
                                dgvCity.CurrentCell = selected < dgvCity.Rows.Count - 1 ? dgvCity.Rows[selected + 1].Cells["ID"] : dgvCity.Rows[0].Cells["ID"];
                                break;
                            case Keys.Up:
                                dgvCity.CurrentCell = selected > 0 ? dgvCity.Rows[selected - 1].Cells["ID"] : dgvCity.Rows[dgvCity.Rows.Count - 1].Cells["ID"];
                                break;
                        }
                    }

                    break;
                case Keys.Up:
                    SendKeys.Send("{END}");
                    if (dgvCity.Rows.Count > 0)
                    {
                        int selected;
                        if (dgvCity.CurrentRow == null)
                        {
                            selected = 0;
                            dgvCity.CurrentCell = dgvCity.Rows[0].Cells["ID"];
                        }
                        else
                        {
                            selected = dgvCity.CurrentRow.Index;
                        }

                        switch (e.KeyCode)
                        {
                            case Keys.Down:
                                dgvCity.CurrentCell = selected < dgvCity.Rows.Count - 1 ? dgvCity.Rows[selected + 1].Cells["ID"] : dgvCity.Rows[0].Cells["ID"];
                                break;
                            case Keys.Up:
                                dgvCity.CurrentCell = selected > 0 ? dgvCity.Rows[selected - 1].Cells["ID"] : dgvCity.Rows[dgvCity.Rows.Count - 1].Cells["ID"];
                                break;
                        }
                    }

                    break;
                case Keys.Enter when dgvCity.Rows.Count > 0 && dgvCity.CurrentRow != null:
                    info.Add(dgvCity.CurrentRow.Cells["ID"].Value);
                    info.Add(dgvCity.CurrentRow.Cells["Name"].Value);

                    ParentForm?.Close();
                    break;
            }

            switch (e.KeyCode)
            {
                case Keys.Enter when dgvCity.Rows.Count > 0 && dgvCity.CurrentRow == null:
                    dgvCity.Focus();
                    SendKeys.Send("{Enter}");
                    break;
            }
        }

        private void txtCitySearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var cityList = @class.GetCity().Where(i => i.Active && i.ProvinceID == ProvinceID && i.Name.Contains(txtCitySearch.Text)).ToList();
                dgvCity.DataSource = CityListDataTable(cityList);

                if (dgvCity.Rows.Count != 0)
                {
                    dgvCity.CurrentCell = dgvCity.Rows[0].Cells["ID"];
                }
            }
            catch (Exception ex)
            {
                CustomMessageForm.CustomMessageBox.Show("خطا !", $"خطا در جستجوي ليست شهر ها\n\n{ex.Message}", "e");
            }
        }

        private void txtCitySearch_Enter(object sender, EventArgs e)
        {
            txtCitySearch.SelectAll();
        }

        private void CitySelect_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
                CustomMessageForm.CustomMessageBox.Show("راهنماي برنامه",
                    "جهت جستجو در اطلاعات شهر ها مي توانيد از امكان جستجو استفاده نماييد\n\nجهت انتخاب شهر كليد اينتر و جهت لغو كليد ESC را فشار دهيد",
                    "i");
        }

        private void dgvCity_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter when dgvCity.Rows.Count > 0:
                    info.Add(dgvCity.CurrentRow?.Cells["ID"].Value);
                    info.Add(dgvCity.CurrentRow?.Cells["Name"].Value);
                    ParentForm?.Close();
                    break;
                case Keys.ControlKey:
                    txtCitySearch.Focus();
                    break;
            }
        }

        private void dgvCity_DoubleClick(object sender, EventArgs e)
        {
            if (dgvCity.Rows.Count <= 0) return;
            info.Add(dgvCity.CurrentRow?.Cells["ID"].Value);
            info.Add(dgvCity.CurrentRow?.Cells["Name"].Value);
            ParentForm?.Close();
        }

        private void dgvCity_Enter(object sender, EventArgs e)
        {
            txtCitySearch.Focus();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Escape:
                    info.Clear();
                    this.ParentForm?.Close();
                    return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
