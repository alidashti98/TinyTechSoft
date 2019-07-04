using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using TinyTech.Connection;
using TinyTech.UI.Control.MessageBox;
using TinyTech.UI.Control.UIElement;
using TinyTech.Selecting;
using UserControl = TinyTech.UI.Control.UIElement.UserControl;

namespace TinyTech.BasicInformation
{
    public class CityDefinition : UserControl
    {
        #region Region 
        private UI.Control.UIElement.Panel pnlCityDefinition;
        private UI.Control.UIElement.GroupBox groupBoxCityDefinition;
        private UI.Control.UIElement.Panel pnlButtons;
        private UI.Control.Button.RefreshButton btnRefresh;
        private UI.Control.Button.CancelButton btnCancel;
        private UI.Control.Button.SaveButton btnSave;
        private UI.Control.UIElement.Panel pnlMain;
        private UI.Control.UIElement.DataGridView dgvCity;
        ConnectionClasses @class = new ConnectionClasses();
        TabManagement @tab = new TabManagement();
        private int MaxID;
        private UI.Control.Label.Label lblCityName;
        private UI.Control.Label.Label lblCityID;
        private UI.Control.Label.Label lblDescription;
        private UI.Control.TextBox.TextBox txtDescription;
        private UI.Control.TextBox.TextBox txtCityName;
        private UI.Control.TextBox.NumericTextBoxWithSeperator txtCityID;
        private UI.Control.Label.Label lblProvinceName;
        private UI.Control.TextBox.TextBox txtProvinceName;
        private UI.Control.CheckBox.CheckBox chkProvince;
        private int MaxID_;
        TinyTechEntities DB_Connection = new TinyTechEntities();
        private UI.Control.Label.Label lblDate;
        private UI.Control.TextBox.DateControl dateControlCity;
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

        public CityDefinition()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.pnlMain = new TinyTech.UI.Control.UIElement.Panel();
            this.dgvCity = new TinyTech.UI.Control.UIElement.DataGridView();
            this.pnlCityDefinition = new TinyTech.UI.Control.UIElement.Panel();
            this.groupBoxCityDefinition = new TinyTech.UI.Control.UIElement.GroupBox();
            this.lblDate = new TinyTech.UI.Control.Label.Label();
            this.dateControlCity = new TinyTech.UI.Control.TextBox.DateControl();
            this.chkProvince = new TinyTech.UI.Control.CheckBox.CheckBox();
            this.txtProvinceName = new TinyTech.UI.Control.TextBox.TextBox();
            this.lblProvinceName = new TinyTech.UI.Control.Label.Label();
            this.txtCityID = new TinyTech.UI.Control.TextBox.NumericTextBoxWithSeperator();
            this.txtDescription = new TinyTech.UI.Control.TextBox.TextBox();
            this.btnSave = new TinyTech.UI.Control.Button.SaveButton();
            this.btnRefresh = new TinyTech.UI.Control.Button.RefreshButton();
            this.btnCancel = new TinyTech.UI.Control.Button.CancelButton();
            this.txtCityName = new TinyTech.UI.Control.TextBox.TextBox();
            this.lblCityID = new TinyTech.UI.Control.Label.Label();
            this.lblDescription = new TinyTech.UI.Control.Label.Label();
            this.lblCityName = new TinyTech.UI.Control.Label.Label();
            this.pnlButtons = new TinyTech.UI.Control.UIElement.Panel();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCity)).BeginInit();
            this.pnlCityDefinition.SuspendLayout();
            this.groupBoxCityDefinition.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.dgvCity);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.pnlMain.Location = new System.Drawing.Point(0, 189);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlMain.Size = new System.Drawing.Size(800, 311);
            this.pnlMain.TabIndex = 1;
            // 
            // dgvCity
            // 
            this.dgvCity.AllowUserToAddRows = false;
            this.dgvCity.AllowUserToDeleteRows = false;
            this.dgvCity.AllowUserToOrderColumns = true;
            this.dgvCity.AllowUserToResizeColumns = false;
            this.dgvCity.AllowUserToResizeRows = false;
            this.dgvCity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCity.Location = new System.Drawing.Point(0, 0);
            this.dgvCity.MultiSelect = false;
            this.dgvCity.Name = "dgvCity";
            this.dgvCity.ReadOnly = true;
            this.dgvCity.RowHeadersVisible = false;
            this.dgvCity.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvCity.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCity.Size = new System.Drawing.Size(800, 311);
            this.dgvCity.TabIndex = 0;
            // 
            // pnlCityDefinition
            // 
            this.pnlCityDefinition.Controls.Add(this.groupBoxCityDefinition);
            this.pnlCityDefinition.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCityDefinition.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.pnlCityDefinition.Location = new System.Drawing.Point(0, 0);
            this.pnlCityDefinition.Name = "pnlCityDefinition";
            this.pnlCityDefinition.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlCityDefinition.Size = new System.Drawing.Size(800, 189);
            this.pnlCityDefinition.TabIndex = 0;
            // 
            // groupBoxCityDefinition
            // 
            this.groupBoxCityDefinition.Controls.Add(this.lblDate);
            this.groupBoxCityDefinition.Controls.Add(this.dateControlCity);
            this.groupBoxCityDefinition.Controls.Add(this.chkProvince);
            this.groupBoxCityDefinition.Controls.Add(this.txtProvinceName);
            this.groupBoxCityDefinition.Controls.Add(this.lblProvinceName);
            this.groupBoxCityDefinition.Controls.Add(this.txtCityID);
            this.groupBoxCityDefinition.Controls.Add(this.txtDescription);
            this.groupBoxCityDefinition.Controls.Add(this.txtCityName);
            this.groupBoxCityDefinition.Controls.Add(this.lblCityID);
            this.groupBoxCityDefinition.Controls.Add(this.lblDescription);
            this.groupBoxCityDefinition.Controls.Add(this.lblCityName);
            this.groupBoxCityDefinition.Controls.Add(this.pnlButtons);
            this.groupBoxCityDefinition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxCityDefinition.Location = new System.Drawing.Point(0, 0);
            this.groupBoxCityDefinition.Name = "groupBoxCityDefinition";
            this.groupBoxCityDefinition.Size = new System.Drawing.Size(800, 189);
            this.groupBoxCityDefinition.TabIndex = 0;
            this.groupBoxCityDefinition.TabStop = false;
            this.groupBoxCityDefinition.Text = "تعريف شهر";
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.lblDate.Location = new System.Drawing.Point(698, 27);
            this.lblDate.Name = "lblDate";
            this.lblDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblDate.Size = new System.Drawing.Size(40, 20);
            this.lblDate.TabIndex = 18;
            this.lblDate.Text = "تاريخ :";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateControlCity
            // 
            this.dateControlCity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateControlCity.BackColor = System.Drawing.Color.White;
            this.dateControlCity.CanGoBackward = true;
            this.dateControlCity.CanGoForward = false;
            this.dateControlCity.Location = new System.Drawing.Point(565, 27);
            this.dateControlCity.Name = "dateControlCity";
            this.dateControlCity.NextControl = this.chkProvince;
            this.dateControlCity.NowShamsi8Character = "97/06/14";
            this.dateControlCity.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateControlCity.ShamsiNow = "1397/06/14";
            this.dateControlCity.Size = new System.Drawing.Size(120, 20);
            this.dateControlCity.TabIndex = 0;
            this.dateControlCity.Text = "dateControl1";
            this.dateControlCity.Value10Cahracter = null;
            // 
            // chkProvince
            // 
            this.chkProvince.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkProvince.AutoSize = true;
            this.chkProvince.Location = new System.Drawing.Point(629, 61);
            this.chkProvince.Name = "chkProvince";
            this.chkProvince.NextControl = null;
            this.chkProvince.Size = new System.Drawing.Size(56, 24);
            this.chkProvince.TabIndex = 1;
            this.chkProvince.Text = "استان";
            this.chkProvince.UseVisualStyleBackColor = true;
            this.chkProvince.CheckedChanged += new System.EventHandler(this.chkProvince_CheckedChanged);
            // 
            // txtProvinceName
            // 
            this.txtProvinceName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProvinceName.BackColor = System.Drawing.Color.White;
            this.txtProvinceName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProvinceName.Enabled = false;
            this.txtProvinceName.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.txtProvinceName.ForeColor = System.Drawing.Color.Gray;
            this.txtProvinceName.Location = new System.Drawing.Point(473, 60);
            this.txtProvinceName.Margin = new System.Windows.Forms.Padding(10);
            this.txtProvinceName.Name = "txtProvinceName";
            this.txtProvinceName.NextControl = null;
            this.txtProvinceName.ReadOnly = true;
            this.txtProvinceName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtProvinceName.Size = new System.Drawing.Size(143, 28);
            this.txtProvinceName.TabIndex = 16;
            this.txtProvinceName.Text = "انتخاب استان ...";
            this.txtProvinceName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblProvinceName
            // 
            this.lblProvinceName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProvinceName.AutoSize = true;
            this.lblProvinceName.BackColor = System.Drawing.Color.Transparent;
            this.lblProvinceName.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.lblProvinceName.Location = new System.Drawing.Point(698, 62);
            this.lblProvinceName.Name = "lblProvinceName";
            this.lblProvinceName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblProvinceName.Size = new System.Drawing.Size(59, 20);
            this.lblProvinceName.TabIndex = 13;
            this.lblProvinceName.Text = "نام استان :";
            this.lblProvinceName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCityID
            // 
            this.txtCityID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCityID.BackColor = System.Drawing.Color.White;
            this.txtCityID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCityID.Enabled = false;
            this.txtCityID.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.txtCityID.ForeColor = System.Drawing.Color.Black;
            this.txtCityID.Location = new System.Drawing.Point(339, 98);
            this.txtCityID.Margin = new System.Windows.Forms.Padding(10);
            this.txtCityID.Name = "txtCityID";
            this.txtCityID.NextControl = null;
            this.txtCityID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCityID.Size = new System.Drawing.Size(70, 28);
            this.txtCityID.TabIndex = 12;
            this.txtCityID.Text = "0";
            this.txtCityID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCityID.Value = 0D;
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.BackColor = System.Drawing.Color.White;
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescription.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.txtDescription.ForeColor = System.Drawing.Color.Black;
            this.txtDescription.Location = new System.Drawing.Point(278, 137);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(10);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.NextControl = this.btnSave;
            this.txtDescription.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDescription.Size = new System.Drawing.Size(407, 28);
            this.txtDescription.TabIndex = 3;
            this.txtDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(231)))));
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(141)))), ((int)(((byte)(231)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(175, 3);
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
            this.btnRefresh.Location = new System.Drawing.Point(89, 3);
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
            this.btnCancel.Location = new System.Drawing.Point(3, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.NextControl = this.dateControlCity;
            this.btnCancel.Size = new System.Drawing.Size(81, 34);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "انصراف";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtCityName
            // 
            this.txtCityName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCityName.BackColor = System.Drawing.Color.White;
            this.txtCityName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCityName.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.txtCityName.ForeColor = System.Drawing.Color.Black;
            this.txtCityName.Location = new System.Drawing.Point(473, 98);
            this.txtCityName.Margin = new System.Windows.Forms.Padding(10);
            this.txtCityName.Name = "txtCityName";
            this.txtCityName.NextControl = this.txtDescription;
            this.txtCityName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCityName.Size = new System.Drawing.Size(212, 28);
            this.txtCityName.TabIndex = 2;
            this.txtCityName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCityName.TextChanged += new System.EventHandler(this.txtCityName_TextChanged);
            // 
            // lblCityID
            // 
            this.lblCityID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCityID.AutoSize = true;
            this.lblCityID.BackColor = System.Drawing.Color.Transparent;
            this.lblCityID.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.lblCityID.Location = new System.Drawing.Point(422, 100);
            this.lblCityID.Name = "lblCityID";
            this.lblCityID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblCityID.Size = new System.Drawing.Size(48, 20);
            this.lblCityID.TabIndex = 9;
            this.lblCityID.Text = "كد شهر :";
            this.lblCityID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescription.AutoSize = true;
            this.lblDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblDescription.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.lblDescription.Location = new System.Drawing.Point(698, 139);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblDescription.Size = new System.Drawing.Size(60, 20);
            this.lblDescription.TabIndex = 8;
            this.lblDescription.Text = "توضيحات :";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCityName
            // 
            this.lblCityName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCityName.AutoSize = true;
            this.lblCityName.BackColor = System.Drawing.Color.Transparent;
            this.lblCityName.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.lblCityName.Location = new System.Drawing.Point(698, 100);
            this.lblCityName.Name = "lblCityName";
            this.lblCityName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblCityName.Size = new System.Drawing.Size(49, 20);
            this.lblCityName.TabIndex = 7;
            this.lblCityName.Text = "نام شهر :";
            this.lblCityName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlButtons
            // 
            this.pnlButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlButtons.Controls.Add(this.btnRefresh);
            this.pnlButtons.Controls.Add(this.btnCancel);
            this.pnlButtons.Controls.Add(this.btnSave);
            this.pnlButtons.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.pnlButtons.Location = new System.Drawing.Point(6, 137);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlButtons.Size = new System.Drawing.Size(259, 40);
            this.pnlButtons.TabIndex = 4;
            // 
            // CityDefinition
            // 
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlCityDefinition);
            this.Name = "CityDefinition";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(800, 500);
            this.Tag = "تعريف شهر";
            this.Load += new System.EventHandler(this.CityDefinition_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CityDefinition_KeyDown);
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCity)).EndInit();
            this.pnlCityDefinition.ResumeLayout(false);
            this.groupBoxCityDefinition.ResumeLayout(false);
            this.groupBoxCityDefinition.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            @tab.CloseTab(this);
        }

        private void DisableForm()
        {
            txtCityName.Enabled = false;
            txtDescription.Enabled = false;
            btnSave.Enabled = false;
            btnRefresh.Enabled = false;
        }

        private DataTable CityListDataTable(List<City> cityList)
        {
            var dataTable = ToolBox<City>.GetDataTable(cityList);
            return dataTable;
        }

        private void CityDefinition_Load(object sender, EventArgs e)
        {
            var cityList = @class.GetCity(true).ToList();
            dgvCity.DataSource = cityList;//CityListDataTable(cityList);
            SetGridView();
            txtCityID.Text = CalculateMaxId().ToString();
            chkProvince.Focus();
        }

        private int CalculateMaxId()
        {
            if (@class.GetCity().Count <= 0) return 1;
            var max = @class.GetCity().Max(i => i.ID) + 1;
            return max;
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

            dgvCity.Columns["ID"].HeaderText = "كد";
            dgvCity.Columns["Name"].HeaderText = "نام";
            dgvCity.Columns["Description"].HeaderText = "توضيحات";


            dgvCity.Columns["ID"].DisplayIndex = 0;
            dgvCity.Columns["Name"].DisplayIndex = 1;
            dgvCity.Columns["Description"].DisplayIndex = 3;

            dgvCity.Columns["ID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvCity.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvCity.Columns["Description"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvCity.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvCity.Columns["ID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvCity.Columns["Name"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvCity.Columns["Description"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            dgvCity.AutoGenerateColumns = false;

        }

        private void CityDefinition_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                @tab.CloseTab(this);
            }
        }

        private bool FormValidate()
        {
            if (!chkProvince.Checked)
            {
                CustomMessageForm.CustomMessageBox.Show("اخطار !", $"استان انتخاب نشده است! لطفا ابتدا استان را انتخاب كنيد", "e");
                chkProvince.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCityName.Text))
            {
                CustomMessageForm.CustomMessageBox.Show("اخطار", "لطفا نام شهر را وارد كنيد", "e");
                txtCityName.Focus();
                return false;
            }

            if (@class.GetCity(true).Count(i => i.Name.Equals(txtCityName.Text)) > 0)
            {
                CustomMessageForm.CustomMessageBox.Show("اخطار !", $"نام شهر \"{txtCityName.Text}\" تكراري است!", "e");
                txtCityName.Focus();
                return false;
            }

            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (FormValidate())
            {
                var result = @class.CityDefinition(txtCityName.Text, int.Parse(txtProvinceName.Tag.ToString()), txtDescription.Text, dateControlCity.ShamsiValue(), ConnectionClasses.DateServer.ReturnDateServer(), DateTime.Now.ToString("HH:mm:ss"), ConnectionClasses.DateServer.ServerTime(), ConnectionInfo.LoggedInUserId);

                if (result > 0)
                {
                    CustomMessageForm.CustomMessageBox.Show("پيغام سيستم", $"شهر \"{txtCityName.Text}\" با موفقيت ثبت شد", "i");
                    MaxID_ = result;
                    if (int.Parse(txtCityID.Text) != MaxID_)
                    {
                        CustomMessageForm.CustomMessageBox.Show("پيغام سيستم", $"كد شهر به {MaxID_} تغيير يافت", "i");
                    }
                    RefreshForm();
                }
                else if (result == 0)
                {
                    CustomMessageForm.CustomMessageBox.Show("خطا !", $"خطا در تعريف شهر!\n\nلطفا جهت بررسي مشكل با پشتيباني تماس بگيريد", "e");
                }
            }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshForm();
        }

        private void RefreshForm()
        {
            CityDefinition_Load(null, null);
            txtCityName.Clear();
            txtDescription.Clear();
            chkProvince.Checked = false;
        }

        private void txtCityName_TextChanged(object sender, EventArgs e)
        {
            var cityList = @class.GetCity(true).Where(i => i.Name.Contains(txtCityName.Text)).ToList();
            dgvCity.DataSource = cityList; //CityListDataTable(cityList);
        }

        private void chkProvince_CheckedChanged(object sender, EventArgs e)
        {
            var provinceList = new List<Province>();
            new UserControlLoader(new ProvinceSelect(provinceList), true, false, true);

            if (provinceList.Count() > 0)
            {
                txtProvinceName.Text = provinceList.FirstOrDefault().Name;
                txtProvinceName.Tag = provinceList.FirstOrDefault().ID;
                var cityList = @class.GetCity(true).Where(i => i.ProvinceID == int.Parse(txtProvinceName.Tag.ToString())).ToList();
                dgvCity.DataSource = cityList;
                txtCityName.Focus();
            }
            else
            {
                txtProvinceName.Text = "انتخاب استان ...";
                txtProvinceName.Tag = string.Empty;
                chkProvince.Checked = false;
                var cityList = @class.GetCity(true).ToList();
                dgvCity.DataSource = cityList;//CityListDataTable(cityList);
                chkProvince.Focus();
                DisableForm();
            }
        }
    }
}
