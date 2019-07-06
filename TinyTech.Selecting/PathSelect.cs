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
    public class PathSelect : TinyTech.UI.Control.UIElement.UserControl
    {
        #region Region 
        ConnectionClasses @class = new ConnectionClasses();
        private UI.Control.UIElement.GroupBox groupBoxPathSelect;
        private UI.Control.UIElement.Panel pnlMain;
        private UI.Control.UIElement.DataGridView dgvPath;
        private UI.Control.UIElement.Panel pnlBottom;
        private UI.Control.UIElement.Panel pnlTop;
        private UI.Control.TextBox.TextBox txtPathSearch;
        private UI.Control.Label.Label lblPathSearch;
        private UI.Control.Label.Label lblHelp;
        private List<Path> info;
        private int RegionID;
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

        public PathSelect(List<Path> info_, int RegionID_)
        {
            InitializeComponent();
            info = info_;
            RegionID = RegionID_;
            PathSelect_Load(null, null);
        }

        private void InitializeComponent()
        {
            this.groupBoxPathSelect = new TinyTech.UI.Control.UIElement.GroupBox();
            this.pnlMain = new TinyTech.UI.Control.UIElement.Panel();
            this.dgvPath = new TinyTech.UI.Control.UIElement.DataGridView();
            this.pnlBottom = new TinyTech.UI.Control.UIElement.Panel();
            this.lblHelp = new TinyTech.UI.Control.Label.Label();
            this.pnlTop = new TinyTech.UI.Control.UIElement.Panel();
            this.txtPathSearch = new TinyTech.UI.Control.TextBox.TextBox();
            this.lblPathSearch = new TinyTech.UI.Control.Label.Label();
            this.groupBoxPathSelect.SuspendLayout();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPath)).BeginInit();
            this.pnlBottom.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxPathSelect
            // 
            this.groupBoxPathSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxPathSelect.Controls.Add(this.pnlMain);
            this.groupBoxPathSelect.Controls.Add(this.pnlBottom);
            this.groupBoxPathSelect.Controls.Add(this.pnlTop);
            this.groupBoxPathSelect.Location = new System.Drawing.Point(0, 0);
            this.groupBoxPathSelect.Name = "groupBoxPathSelect";
            this.groupBoxPathSelect.Size = new System.Drawing.Size(750, 500);
            this.groupBoxPathSelect.TabIndex = 0;
            this.groupBoxPathSelect.TabStop = false;
            this.groupBoxPathSelect.Text = "انتخاب مسير";
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMain.Controls.Add(this.dgvPath);
            this.pnlMain.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.pnlMain.Location = new System.Drawing.Point(3, 58);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlMain.Size = new System.Drawing.Size(744, 415);
            this.pnlMain.TabIndex = 5;
            // 
            // dgvPath
            // 
            this.dgvPath.AllowUserToAddRows = false;
            this.dgvPath.AllowUserToDeleteRows = false;
            this.dgvPath.AllowUserToOrderColumns = true;
            this.dgvPath.AllowUserToResizeColumns = false;
            this.dgvPath.AllowUserToResizeRows = false;
            this.dgvPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPath.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPath.Location = new System.Drawing.Point(0, 0);
            this.dgvPath.MultiSelect = false;
            this.dgvPath.Name = "dgvPath";
            this.dgvPath.ReadOnly = true;
            this.dgvPath.RowHeadersVisible = false;
            this.dgvPath.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPath.Size = new System.Drawing.Size(744, 415);
            this.dgvPath.TabIndex = 0;
            this.dgvPath.DoubleClick += new System.EventHandler(this.dgvPath_DoubleClick);
            this.dgvPath.Enter += new System.EventHandler(this.dgvPath_Enter);
            this.dgvPath.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvPath_KeyDown);
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
            this.pnlTop.Controls.Add(this.txtPathSearch);
            this.pnlTop.Controls.Add(this.lblPathSearch);
            this.pnlTop.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.pnlTop.Location = new System.Drawing.Point(3, 24);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlTop.Size = new System.Drawing.Size(744, 34);
            this.pnlTop.TabIndex = 3;
            // 
            // txtPathSearch
            // 
            this.txtPathSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPathSearch.BackColor = System.Drawing.Color.White;
            this.txtPathSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPathSearch.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.txtPathSearch.ForeColor = System.Drawing.Color.Black;
            this.txtPathSearch.Location = new System.Drawing.Point(0, 1);
            this.txtPathSearch.Margin = new System.Windows.Forms.Padding(10);
            this.txtPathSearch.Name = "txtPathSearch";
            this.txtPathSearch.NextControl = null;
            this.txtPathSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPathSearch.Size = new System.Drawing.Size(682, 28);
            this.txtPathSearch.TabIndex = 1;
            this.txtPathSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPathSearch.TextChanged += new System.EventHandler(this.txtPathSearch_TextChanged);
            this.txtPathSearch.Enter += new System.EventHandler(this.txtPathSearch_Enter);
            this.txtPathSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPathSearch_KeyDown);
            // 
            // lblPathSearch
            // 
            this.lblPathSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPathSearch.AutoSize = true;
            this.lblPathSearch.BackColor = System.Drawing.Color.Transparent;
            this.lblPathSearch.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.lblPathSearch.Location = new System.Drawing.Point(695, 3);
            this.lblPathSearch.Name = "lblPathSearch";
            this.lblPathSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPathSearch.Size = new System.Drawing.Size(46, 20);
            this.lblPathSearch.TabIndex = 0;
            this.lblPathSearch.Text = "جستجو";
            this.lblPathSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PathSelect
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.groupBoxPathSelect);
            this.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "PathSelect";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(750, 500);
            this.Tag = "انتخاب مسير";
            this.Load += new System.EventHandler(this.PathSelect_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PathSelect_KeyDown);
            this.groupBoxPathSelect.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPath)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        private DataTable PathListDataTable(List<Path> PathList)
        {
            var dataTable = UI.Control.UIElement.ToolBox<Path>.GetDataTable(PathList);
            return dataTable;
        }

        private void PathSelect_Load(object sender, EventArgs e)
        {
            txtPathSearch.Focus();
            var pathList = @class.GetPath(true).Where(i => i.RegionID == RegionID).ToList();
            dgvPath.DataSource = pathList; //PathListDataTable(PathList);
            SetGridView();
        }

        private void SetGridView()
        {
            foreach (DataGridViewColumn item in dgvPath.Columns)
            {
                item.Visible = false;
            }
            dgvPath.Columns["ID"].Visible = true;
            dgvPath.Columns["Name"].Visible = true;
            dgvPath.Columns["Description"].Visible = true;

            dgvPath.Columns["ID"].HeaderText = "رديف";
            dgvPath.Columns["Name"].HeaderText = "نام";
            dgvPath.Columns["Description"].HeaderText = "توضيحات";

            dgvPath.Columns["ID"].DisplayIndex = 0;
            dgvPath.Columns["Name"].DisplayIndex = 1;
            dgvPath.Columns["Description"].DisplayIndex = 2;

            dgvPath.Columns["ID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvPath.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvPath.Columns["Description"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvPath.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvPath.Columns["ID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPath.Columns["Name"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvPath.Columns["Description"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            dgvPath.AutoGenerateColumns = false;

        }

        private void FillPathList()
        {
            info.Add((Path)dgvPath.CurrentRow?.DataBoundItem);
        }

        private void txtPathSearch_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Down:
                    SendKeys.Send("{END}");
                    if (dgvPath.Rows.Count > 0)
                    {
                        int selected;
                        if (dgvPath.CurrentRow == null)
                        {
                            selected = 0;
                            dgvPath.CurrentCell = dgvPath.Rows[0].Cells["ID"];
                        }
                        else
                        {
                            selected = dgvPath.CurrentRow.Index;
                        }

                        switch (e.KeyCode)
                        {
                            case Keys.Down:
                                dgvPath.CurrentCell = selected < dgvPath.Rows.Count - 1 ? dgvPath.Rows[selected + 1].Cells["ID"] : dgvPath.Rows[0].Cells["ID"];
                                break;
                            case Keys.Up:
                                dgvPath.CurrentCell = selected > 0 ? dgvPath.Rows[selected - 1].Cells["ID"] : dgvPath.Rows[dgvPath.Rows.Count - 1].Cells["ID"];
                                break;
                        }
                    }

                    break;
                case Keys.Up:
                    SendKeys.Send("{END}");
                    if (dgvPath.Rows.Count > 0)
                    {
                        int selected;
                        if (dgvPath.CurrentRow == null)
                        {
                            selected = 0;
                            dgvPath.CurrentCell = dgvPath.Rows[0].Cells["ID"];
                        }
                        else
                        {
                            selected = dgvPath.CurrentRow.Index;
                        }

                        switch (e.KeyCode)
                        {
                            case Keys.Down:
                                dgvPath.CurrentCell = selected < dgvPath.Rows.Count - 1 ? dgvPath.Rows[selected + 1].Cells["ID"] : dgvPath.Rows[0].Cells["ID"];
                                break;
                            case Keys.Up:
                                dgvPath.CurrentCell = selected > 0 ? dgvPath.Rows[selected - 1].Cells["ID"] : dgvPath.Rows[dgvPath.Rows.Count - 1].Cells["ID"];
                                break;
                        }
                    }

                    break;
                case Keys.Enter when dgvPath.Rows.Count > 0 && dgvPath.CurrentRow != null:
                    FillPathList();
                    ParentForm?.Close();
                    break;
            }

            switch (e.KeyCode)
            {
                case Keys.Enter when dgvPath.Rows.Count > 0 && dgvPath.CurrentRow == null:
                    dgvPath.Focus();
                    SendKeys.Send("{Enter}");
                    break;
            }
        }

        private void txtPathSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var pathList = @class.GetPath(true).Where(i => i.RegionID == RegionID && i.Name.Contains(txtPathSearch.Text)).ToList();
                dgvPath.DataSource = pathList; //PathListDataTable(PathList);

                if (dgvPath.Rows.Count != 0)
                {
                    dgvPath.CurrentCell = dgvPath.Rows[0].Cells["ID"];
                }
            }
            catch (Exception ex)
            {
                CustomMessageForm.CustomMessageBox.Show("خطا !", $"خطا در جستجوي ليست مسير ها\n\n{ex.Message}", "e");
            }
        }

        private void txtPathSearch_Enter(object sender, EventArgs e)
        {
            txtPathSearch.SelectAll();
        }

        private void PathSelect_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
                CustomMessageForm.CustomMessageBox.Show("راهنماي برنامه",
                    "جهت جستجو در اطلاعات مسير ها مي توانيد از امكان جستجو استفاده نماييد\n\nجهت انتخاب مسير كليد اينتر و جهت لغو كليد ESC را فشار دهيد",
                    "i");
        }

        private void dgvPath_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter when dgvPath.Rows.Count > 0:
                    FillPathList();
                    ParentForm?.Close();
                    break;
                case Keys.ControlKey:
                    txtPathSearch.Focus();
                    break;
            }
        }

        private void dgvPath_DoubleClick(object sender, EventArgs e)
        {
            if (dgvPath.Rows.Count <= 0) return;
            FillPathList();
            ParentForm?.Close();
        }

        private void dgvPath_Enter(object sender, EventArgs e)
        {
            txtPathSearch.Focus();
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
