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
    public class RegionSelect : TinyTech.UI.Control.UIElement.UserControl
    {
        #region Region 
        ConnectionClasses @class = new ConnectionClasses();
        private UI.Control.UIElement.GroupBox groupBoxRegionSelect;
        private UI.Control.UIElement.Panel pnlMain;
        private UI.Control.UIElement.DataGridView dgvRegion;
        private UI.Control.UIElement.Panel pnlBottom;
        private UI.Control.UIElement.Panel pnlTop;
        private UI.Control.TextBox.TextBox txtRegionSearch;
        private UI.Control.Label.Label lblRegionSearch;
        private UI.Control.Label.Label lblHelp;
        private List<Region> info;
        private int CityID;
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

        public RegionSelect(List<Region> info_, int CityID_)
        {
            InitializeComponent();
            info = info_;
            CityID = CityID_;
            RegionSelect_Load(null, null);
        }

        private void InitializeComponent()
        {
            this.groupBoxRegionSelect = new TinyTech.UI.Control.UIElement.GroupBox();
            this.pnlMain = new TinyTech.UI.Control.UIElement.Panel();
            this.dgvRegion = new TinyTech.UI.Control.UIElement.DataGridView();
            this.pnlBottom = new TinyTech.UI.Control.UIElement.Panel();
            this.lblHelp = new TinyTech.UI.Control.Label.Label();
            this.pnlTop = new TinyTech.UI.Control.UIElement.Panel();
            this.txtRegionSearch = new TinyTech.UI.Control.TextBox.TextBox();
            this.lblRegionSearch = new TinyTech.UI.Control.Label.Label();
            this.groupBoxRegionSelect.SuspendLayout();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegion)).BeginInit();
            this.pnlBottom.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxRegionSelect
            // 
            this.groupBoxRegionSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxRegionSelect.Controls.Add(this.pnlMain);
            this.groupBoxRegionSelect.Controls.Add(this.pnlBottom);
            this.groupBoxRegionSelect.Controls.Add(this.pnlTop);
            this.groupBoxRegionSelect.Location = new System.Drawing.Point(0, 0);
            this.groupBoxRegionSelect.Name = "groupBoxRegionSelect";
            this.groupBoxRegionSelect.Size = new System.Drawing.Size(750, 500);
            this.groupBoxRegionSelect.TabIndex = 0;
            this.groupBoxRegionSelect.TabStop = false;
            this.groupBoxRegionSelect.Text = "انتخاب منطقه";
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMain.Controls.Add(this.dgvRegion);
            this.pnlMain.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.pnlMain.Location = new System.Drawing.Point(3, 58);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlMain.Size = new System.Drawing.Size(744, 415);
            this.pnlMain.TabIndex = 5;
            // 
            // dgvRegion
            // 
            this.dgvRegion.AllowUserToAddRows = false;
            this.dgvRegion.AllowUserToDeleteRows = false;
            this.dgvRegion.AllowUserToOrderColumns = true;
            this.dgvRegion.AllowUserToResizeColumns = false;
            this.dgvRegion.AllowUserToResizeRows = false;
            this.dgvRegion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRegion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegion.Location = new System.Drawing.Point(0, 0);
            this.dgvRegion.MultiSelect = false;
            this.dgvRegion.Name = "dgvRegion";
            this.dgvRegion.ReadOnly = true;
            this.dgvRegion.RowHeadersVisible = false;
            this.dgvRegion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRegion.Size = new System.Drawing.Size(744, 415);
            this.dgvRegion.TabIndex = 0;
            this.dgvRegion.DoubleClick += new System.EventHandler(this.dgvRegion_DoubleClick);
            this.dgvRegion.Enter += new System.EventHandler(this.dgvRegion_Enter);
            this.dgvRegion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvRegion_KeyDown);
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
            this.pnlTop.Controls.Add(this.txtRegionSearch);
            this.pnlTop.Controls.Add(this.lblRegionSearch);
            this.pnlTop.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.pnlTop.Location = new System.Drawing.Point(3, 24);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlTop.Size = new System.Drawing.Size(744, 34);
            this.pnlTop.TabIndex = 3;
            // 
            // txtRegionSearch
            // 
            this.txtRegionSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRegionSearch.BackColor = System.Drawing.Color.White;
            this.txtRegionSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRegionSearch.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.txtRegionSearch.ForeColor = System.Drawing.Color.Black;
            this.txtRegionSearch.Location = new System.Drawing.Point(0, 1);
            this.txtRegionSearch.Margin = new System.Windows.Forms.Padding(10);
            this.txtRegionSearch.Name = "txtRegionSearch";
            this.txtRegionSearch.NextControl = null;
            this.txtRegionSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtRegionSearch.Size = new System.Drawing.Size(682, 28);
            this.txtRegionSearch.TabIndex = 1;
            this.txtRegionSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRegionSearch.TextChanged += new System.EventHandler(this.txtRegionSearch_TextChanged);
            this.txtRegionSearch.Enter += new System.EventHandler(this.txtRegionSearch_Enter);
            this.txtRegionSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRegionSearch_KeyDown);
            // 
            // lblRegionSearch
            // 
            this.lblRegionSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRegionSearch.AutoSize = true;
            this.lblRegionSearch.BackColor = System.Drawing.Color.Transparent;
            this.lblRegionSearch.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.lblRegionSearch.Location = new System.Drawing.Point(695, 3);
            this.lblRegionSearch.Name = "lblRegionSearch";
            this.lblRegionSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblRegionSearch.Size = new System.Drawing.Size(46, 20);
            this.lblRegionSearch.TabIndex = 0;
            this.lblRegionSearch.Text = "جستجو";
            this.lblRegionSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RegionSelect
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.groupBoxRegionSelect);
            this.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "RegionSelect";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(750, 500);
            this.Tag = "انتخاب منطقه";
            this.Load += new System.EventHandler(this.RegionSelect_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RegionSelect_KeyDown);
            this.groupBoxRegionSelect.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegion)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        private DataTable RegionListDataTable(List<Region> RegionList)
        {
            var dataTable = UI.Control.UIElement.ToolBox<Region>.GetDataTable(RegionList);
            return dataTable;
        }

        private void RegionSelect_Load(object sender, EventArgs e)
        {
            txtRegionSearch.Focus();
            var RegionList = @class.GetRegion(true).Where(i => i.CityID == CityID).ToList();
            dgvRegion.DataSource = RegionList; //RegionListDataTable(RegionList);
            SetGridView();
        }

        private void SetGridView()
        {
            foreach (DataGridViewColumn item in dgvRegion.Columns)
            {
                item.Visible = false;
            }
            dgvRegion.Columns["ID"].Visible = true;
            dgvRegion.Columns["Name"].Visible = true;
            dgvRegion.Columns["Description"].Visible = true;

            dgvRegion.Columns["ID"].HeaderText = "رديف";
            dgvRegion.Columns["Name"].HeaderText = "نام";
            dgvRegion.Columns["Description"].HeaderText = "توضيحات";

            dgvRegion.Columns["ID"].DisplayIndex = 0;
            dgvRegion.Columns["Name"].DisplayIndex = 1;
            dgvRegion.Columns["Description"].DisplayIndex = 2;

            dgvRegion.Columns["ID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvRegion.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvRegion.Columns["Description"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvRegion.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvRegion.Columns["ID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvRegion.Columns["Name"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvRegion.Columns["Description"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            dgvRegion.AutoGenerateColumns = false;

        }

        private void FillRegionList()
        {
            info.Add((Region)dgvRegion.CurrentRow?.DataBoundItem);
        }

        private void txtRegionSearch_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Down:
                    SendKeys.Send("{END}");
                    if (dgvRegion.Rows.Count > 0)
                    {
                        int selected;
                        if (dgvRegion.CurrentRow == null)
                        {
                            selected = 0;
                            dgvRegion.CurrentCell = dgvRegion.Rows[0].Cells["ID"];
                        }
                        else
                        {
                            selected = dgvRegion.CurrentRow.Index;
                        }

                        switch (e.KeyCode)
                        {
                            case Keys.Down:
                                dgvRegion.CurrentCell = selected < dgvRegion.Rows.Count - 1 ? dgvRegion.Rows[selected + 1].Cells["ID"] : dgvRegion.Rows[0].Cells["ID"];
                                break;
                            case Keys.Up:
                                dgvRegion.CurrentCell = selected > 0 ? dgvRegion.Rows[selected - 1].Cells["ID"] : dgvRegion.Rows[dgvRegion.Rows.Count - 1].Cells["ID"];
                                break;
                        }
                    }

                    break;
                case Keys.Up:
                    SendKeys.Send("{END}");
                    if (dgvRegion.Rows.Count > 0)
                    {
                        int selected;
                        if (dgvRegion.CurrentRow == null)
                        {
                            selected = 0;
                            dgvRegion.CurrentCell = dgvRegion.Rows[0].Cells["ID"];
                        }
                        else
                        {
                            selected = dgvRegion.CurrentRow.Index;
                        }

                        switch (e.KeyCode)
                        {
                            case Keys.Down:
                                dgvRegion.CurrentCell = selected < dgvRegion.Rows.Count - 1 ? dgvRegion.Rows[selected + 1].Cells["ID"] : dgvRegion.Rows[0].Cells["ID"];
                                break;
                            case Keys.Up:
                                dgvRegion.CurrentCell = selected > 0 ? dgvRegion.Rows[selected - 1].Cells["ID"] : dgvRegion.Rows[dgvRegion.Rows.Count - 1].Cells["ID"];
                                break;
                        }
                    }

                    break;
                case Keys.Enter when dgvRegion.Rows.Count > 0 && dgvRegion.CurrentRow != null:
                    FillRegionList();
                    ParentForm?.Close();
                    break;
            }

            switch (e.KeyCode)
            {
                case Keys.Enter when dgvRegion.Rows.Count > 0 && dgvRegion.CurrentRow == null:
                    dgvRegion.Focus();
                    SendKeys.Send("{Enter}");
                    break;
            }
        }

        private void txtRegionSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var regionList = @class.GetRegion(true).Where(i => i.CityID == CityID && i.Name.Contains(txtRegionSearch.Text)).ToList();
                dgvRegion.DataSource = regionList; //RegionListDataTable(regionList);

                if (dgvRegion.Rows.Count != 0)
                {
                    dgvRegion.CurrentCell = dgvRegion.Rows[0].Cells["ID"];
                }
            }
            catch (Exception ex)
            {
                CustomMessageForm.CustomMessageBox.Show("خطا !", $"خطا در جستجوي ليست منطقه ها\n\n{ex.Message}", "e");
            }
        }

        private void txtRegionSearch_Enter(object sender, EventArgs e)
        {
            txtRegionSearch.SelectAll();
        }

        private void RegionSelect_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
                CustomMessageForm.CustomMessageBox.Show("راهنماي برنامه",
                    "جهت جستجو در اطلاعات منطقه ها مي توانيد از امكان جستجو استفاده نماييد\n\nجهت انتخاب منطقه كليد اينتر و جهت لغو كليد ESC را فشار دهيد",
                    "i");
        }

        private void dgvRegion_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter when dgvRegion.Rows.Count > 0:
                    FillRegionList();
                    ParentForm?.Close();
                    break;
                case Keys.ControlKey:
                    txtRegionSearch.Focus();
                    break;
            }
        }

        private void dgvRegion_DoubleClick(object sender, EventArgs e)
        {
            if (dgvRegion.Rows.Count <= 0) return;
            FillRegionList();
            ParentForm?.Close();
        }

        private void dgvRegion_Enter(object sender, EventArgs e)
        {
            txtRegionSearch.Focus();
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
