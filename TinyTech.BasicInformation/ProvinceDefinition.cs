using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using TinyTech.Connection;
using TinyTech.UI.Control.MessageBox;
using TinyTech.UI.Control.UIElement;
using UserControl = TinyTech.UI.Control.UIElement.UserControl;

namespace TinyTech.BasicInformation
{
    public class ProvinceDefinition : UserControl
    {
        #region Region 
        private UI.Control.UIElement.Panel pnlProvinceDefinition;
        private UI.Control.UIElement.GroupBox groupBoxProvinceDefinition;
        private UI.Control.UIElement.Panel pnlButtons;
        private UI.Control.Button.RefreshButton btnRefresh;
        private UI.Control.Button.CancelButton btnCancel;
        private UI.Control.Button.SaveButton btnSave;
        private UI.Control.UIElement.Panel pnlMain;
        private UI.Control.UIElement.DataGridView dgvProvince;
        ConnectionClasses @class = new ConnectionClasses();
        TabManagement @tab = new TabManagement();
        private int MaxID;
        private UI.Control.Label.Label lblProvinceName;
        private UI.Control.Label.Label lblProvinceID;
        private UI.Control.Label.Label lblDescription;
        private UI.Control.TextBox.TextBox txtDescription;
        private UI.Control.TextBox.TextBox txtProvinceName;
        private UI.Control.TextBox.NumericTextBoxWithSeperator txtProvinceID;
        private int MaxID_;
        TinyTechEntities DB_Connection = new TinyTechEntities();
        private UI.Control.Label.Label lblDate;
        private UI.Control.TextBox.DateControl dateControlProvince;
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

        public ProvinceDefinition()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.pnlMain = new TinyTech.UI.Control.UIElement.Panel();
            this.dgvProvince = new TinyTech.UI.Control.UIElement.DataGridView();
            this.pnlProvinceDefinition = new TinyTech.UI.Control.UIElement.Panel();
            this.groupBoxProvinceDefinition = new TinyTech.UI.Control.UIElement.GroupBox();
            this.lblDate = new TinyTech.UI.Control.Label.Label();
            this.dateControlProvince = new TinyTech.UI.Control.TextBox.DateControl();
            this.txtProvinceName = new TinyTech.UI.Control.TextBox.TextBox();
            this.txtDescription = new TinyTech.UI.Control.TextBox.TextBox();
            this.btnSave = new TinyTech.UI.Control.Button.SaveButton();
            this.btnRefresh = new TinyTech.UI.Control.Button.RefreshButton();
            this.btnCancel = new TinyTech.UI.Control.Button.CancelButton();
            this.txtProvinceID = new TinyTech.UI.Control.TextBox.NumericTextBoxWithSeperator();
            this.lblProvinceID = new TinyTech.UI.Control.Label.Label();
            this.lblDescription = new TinyTech.UI.Control.Label.Label();
            this.lblProvinceName = new TinyTech.UI.Control.Label.Label();
            this.pnlButtons = new TinyTech.UI.Control.UIElement.Panel();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProvince)).BeginInit();
            this.pnlProvinceDefinition.SuspendLayout();
            this.groupBoxProvinceDefinition.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.dgvProvince);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.pnlMain.Location = new System.Drawing.Point(0, 149);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlMain.Size = new System.Drawing.Size(800, 351);
            this.pnlMain.TabIndex = 1;
            // 
            // dgvProvince
            // 
            this.dgvProvince.AllowUserToAddRows = false;
            this.dgvProvince.AllowUserToDeleteRows = false;
            this.dgvProvince.AllowUserToOrderColumns = true;
            this.dgvProvince.AllowUserToResizeColumns = false;
            this.dgvProvince.AllowUserToResizeRows = false;
            this.dgvProvince.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProvince.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProvince.Location = new System.Drawing.Point(0, 0);
            this.dgvProvince.MultiSelect = false;
            this.dgvProvince.Name = "dgvProvince";
            this.dgvProvince.ReadOnly = true;
            this.dgvProvince.RowHeadersVisible = false;
            this.dgvProvince.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvProvince.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProvince.Size = new System.Drawing.Size(800, 351);
            this.dgvProvince.TabIndex = 1;
            // 
            // pnlProvinceDefinition
            // 
            this.pnlProvinceDefinition.Controls.Add(this.groupBoxProvinceDefinition);
            this.pnlProvinceDefinition.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlProvinceDefinition.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.pnlProvinceDefinition.Location = new System.Drawing.Point(0, 0);
            this.pnlProvinceDefinition.Name = "pnlProvinceDefinition";
            this.pnlProvinceDefinition.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlProvinceDefinition.Size = new System.Drawing.Size(800, 149);
            this.pnlProvinceDefinition.TabIndex = 0;
            // 
            // groupBoxProvinceDefinition
            // 
            this.groupBoxProvinceDefinition.Controls.Add(this.lblDate);
            this.groupBoxProvinceDefinition.Controls.Add(this.dateControlProvince);
            this.groupBoxProvinceDefinition.Controls.Add(this.txtProvinceID);
            this.groupBoxProvinceDefinition.Controls.Add(this.txtDescription);
            this.groupBoxProvinceDefinition.Controls.Add(this.txtProvinceName);
            this.groupBoxProvinceDefinition.Controls.Add(this.lblProvinceID);
            this.groupBoxProvinceDefinition.Controls.Add(this.lblDescription);
            this.groupBoxProvinceDefinition.Controls.Add(this.lblProvinceName);
            this.groupBoxProvinceDefinition.Controls.Add(this.pnlButtons);
            this.groupBoxProvinceDefinition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxProvinceDefinition.Location = new System.Drawing.Point(0, 0);
            this.groupBoxProvinceDefinition.Name = "groupBoxProvinceDefinition";
            this.groupBoxProvinceDefinition.Size = new System.Drawing.Size(800, 149);
            this.groupBoxProvinceDefinition.TabIndex = 0;
            this.groupBoxProvinceDefinition.TabStop = false;
            this.groupBoxProvinceDefinition.Text = "تعريف استان";
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.lblDate.Location = new System.Drawing.Point(696, 27);
            this.lblDate.Name = "lblDate";
            this.lblDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblDate.Size = new System.Drawing.Size(40, 20);
            this.lblDate.TabIndex = 26;
            this.lblDate.Text = "تاريخ :";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateControlProvince
            // 
            this.dateControlProvince.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateControlProvince.BackColor = System.Drawing.Color.White;
            this.dateControlProvince.CanGoBackward = true;
            this.dateControlProvince.CanGoForward = false;
            this.dateControlProvince.Location = new System.Drawing.Point(563, 27);
            this.dateControlProvince.Name = "dateControlProvince";
            this.dateControlProvince.NextControl = this.txtProvinceName;
            this.dateControlProvince.NowShamsi8Character = "97/06/14";
            this.dateControlProvince.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateControlProvince.ShamsiNow = "1397/06/14";
            this.dateControlProvince.Size = new System.Drawing.Size(120, 20);
            this.dateControlProvince.TabIndex = 0;
            this.dateControlProvince.Text = "dateControl1";
            this.dateControlProvince.Value10Cahracter = null;
            // 
            // txtProvinceName
            // 
            this.txtProvinceName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProvinceName.BackColor = System.Drawing.Color.White;
            this.txtProvinceName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProvinceName.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.txtProvinceName.ForeColor = System.Drawing.Color.Black;
            this.txtProvinceName.Location = new System.Drawing.Point(483, 60);
            this.txtProvinceName.Margin = new System.Windows.Forms.Padding(10);
            this.txtProvinceName.Name = "txtProvinceName";
            this.txtProvinceName.NextControl = this.txtDescription;
            this.txtProvinceName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtProvinceName.Size = new System.Drawing.Size(200, 28);
            this.txtProvinceName.TabIndex = 1;
            this.txtProvinceName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtProvinceName.TextChanged += new System.EventHandler(this.txtProvinceName_TextChanged);
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.BackColor = System.Drawing.Color.White;
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescription.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.txtDescription.ForeColor = System.Drawing.Color.Black;
            this.txtDescription.Location = new System.Drawing.Point(349, 98);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(10);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.NextControl = this.btnSave;
            this.txtDescription.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDescription.Size = new System.Drawing.Size(334, 28);
            this.txtDescription.TabIndex = 2;
            this.txtDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(231)))));
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(231)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(176, 3);
            this.btnSave.Margin = new System.Windows.Forms.Padding(10);
            this.btnSave.Name = "btnSave";
            this.btnSave.NextControl = this.btnRefresh;
            this.btnSave.Size = new System.Drawing.Size(81, 34);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "ثبت";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(83)))));
            this.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(83)))));
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(90, 3);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(10);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.NextControl = this.btnCancel;
            this.btnRefresh.Size = new System.Drawing.Size(81, 34);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "بروزرساني";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.btnCancel.ForeColor = System.Drawing.Color.Gray;
            this.btnCancel.Location = new System.Drawing.Point(4, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.NextControl = this.dateControlProvince;
            this.btnCancel.Size = new System.Drawing.Size(81, 34);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "انصراف";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtProvinceID
            // 
            this.txtProvinceID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProvinceID.BackColor = System.Drawing.Color.White;
            this.txtProvinceID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProvinceID.Enabled = false;
            this.txtProvinceID.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.txtProvinceID.ForeColor = System.Drawing.Color.Black;
            this.txtProvinceID.Location = new System.Drawing.Point(349, 60);
            this.txtProvinceID.Margin = new System.Windows.Forms.Padding(10);
            this.txtProvinceID.Name = "txtProvinceID";
            this.txtProvinceID.NextControl = null;
            this.txtProvinceID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtProvinceID.Size = new System.Drawing.Size(54, 28);
            this.txtProvinceID.TabIndex = 12;
            this.txtProvinceID.Text = "0";
            this.txtProvinceID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtProvinceID.Value = 0D;
            // 
            // lblProvinceID
            // 
            this.lblProvinceID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProvinceID.AutoSize = true;
            this.lblProvinceID.BackColor = System.Drawing.Color.Transparent;
            this.lblProvinceID.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.lblProvinceID.Location = new System.Drawing.Point(416, 62);
            this.lblProvinceID.Name = "lblProvinceID";
            this.lblProvinceID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblProvinceID.Size = new System.Drawing.Size(58, 20);
            this.lblProvinceID.TabIndex = 9;
            this.lblProvinceID.Text = "كد استان :";
            this.lblProvinceID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescription.AutoSize = true;
            this.lblDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblDescription.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.lblDescription.Location = new System.Drawing.Point(696, 100);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblDescription.Size = new System.Drawing.Size(60, 20);
            this.lblDescription.TabIndex = 8;
            this.lblDescription.Text = "توضيحات :";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProvinceName
            // 
            this.lblProvinceName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProvinceName.AutoSize = true;
            this.lblProvinceName.BackColor = System.Drawing.Color.Transparent;
            this.lblProvinceName.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.lblProvinceName.Location = new System.Drawing.Point(696, 62);
            this.lblProvinceName.Name = "lblProvinceName";
            this.lblProvinceName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblProvinceName.Size = new System.Drawing.Size(59, 20);
            this.lblProvinceName.TabIndex = 7;
            this.lblProvinceName.Text = "نام استان :";
            this.lblProvinceName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlButtons
            // 
            this.pnlButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlButtons.Controls.Add(this.btnRefresh);
            this.pnlButtons.Controls.Add(this.btnCancel);
            this.pnlButtons.Controls.Add(this.btnSave);
            this.pnlButtons.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.pnlButtons.Location = new System.Drawing.Point(6, 104);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlButtons.Size = new System.Drawing.Size(260, 39);
            this.pnlButtons.TabIndex = 3;
            // 
            // ProvinceDefinition
            // 
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlProvinceDefinition);
            this.Name = "ProvinceDefinition";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(800, 500);
            this.Tag = "تعريف استان";
            this.Load += new System.EventHandler(this.ProvinceDefinition_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProvinceDefinition_KeyDown);
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProvince)).EndInit();
            this.pnlProvinceDefinition.ResumeLayout(false);
            this.groupBoxProvinceDefinition.ResumeLayout(false);
            this.groupBoxProvinceDefinition.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            @tab.CloseTab(this);
        }

        private DataTable ProvinceListDataTable(List<Province> provinceList)
        {
            var dataTable = UI.Control.UIElement.ToolBox<Province>.GetDataTable(provinceList);
            return dataTable;
        }

        private void ProvinceDefinition_Load(object sender, EventArgs e)
        {
            var provinceList = @class.GetProvince(true);
            dgvProvince.DataSource = provinceList;
            SetGridView();
            txtProvinceID.Text = CalculateMaxId().ToString();
            txtProvinceName.Focus();
        }

        private int CalculateMaxId()
        {
            if (@class.GetProvince().Count <= 0) return 1;
            var max = @class.GetProvince().Max(i => i.ID) + 1;
            return max;
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

            dgvProvince.Columns["ID"].HeaderText = "كد";
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

        private void ProvinceDefinition_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                @tab.CloseTab(this);
            }
        }

        private bool FormValidate()
        {
            if (string.IsNullOrWhiteSpace(txtProvinceName.Text))
            {
                CustomMessageForm.CustomMessageBox.Show("اخطار", "لطفا نام استان را وارد كنيد", "e");
                txtProvinceName.Focus();
                return false;
            }
            if (@class.GetProvince(true).Count(i => i.Name.Equals(txtProvinceName.Text.Trim())) > 0)
            {
                CustomMessageForm.CustomMessageBox.Show("اخطار !", $"نام استان \"{txtProvinceName.Text.Trim()}\" تكراري است!", "e");
                txtProvinceName.Focus();
                return false;
            }

            return true;
        }

        private void SaveProcess()
        {
            if (FormValidate())
            {
                var result = @class.ProvinceDefinition(txtProvinceName.Text.Trim(), txtDescription.Text.Trim(), dateControlProvince.ShamsiValue(), ConnectionClasses.DateServer.ReturnDateServer(), DateTime.Now.ToString("HH:mm:ss"), ConnectionClasses.DateServer.ServerTime(), ConnectionInfo.LoggedInUserId);

                if (result > 0)
                {
                    CustomMessageForm.CustomMessageBox.Show("پيغام سيستم", $"استان \"{txtProvinceName.Text.Trim()}\" با موفقيت ثبت شد", "i");
                    MaxID_ = result;
                    if (int.Parse(txtProvinceID.Text) != MaxID_)
                    {
                        CustomMessageForm.CustomMessageBox.Show("پيغام سيستم", $"كد استان به {MaxID_} تغيير يافت", "i");
                    }
                    RefreshForm();
                }
                else if (result == 0)
                {
                    CustomMessageForm.CustomMessageBox.Show("خطا !", $"خطا در تعريف استان!\n\nلطفا جهت بررسي مشكل با پشتيباني تماس بگيريد", "e");
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveProcess();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshForm();
            txtProvinceName.Focus();
        }

        private void RefreshForm()
        {
            ProvinceDefinition_Load(null, null);
            txtProvinceName.Clear();
            txtDescription.Clear();
        }

        private void txtProvinceName_TextChanged(object sender, EventArgs e)
        {
            var provinceList = @class.GetProvince(true).Where(i => i.Name.Contains(txtProvinceName.Text.Trim())).ToList();
            dgvProvince.DataSource = provinceList;//ProvinceListDataTable(provinceList);
        }
    }
}
