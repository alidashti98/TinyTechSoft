using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TinyTech.Connection;
using TinyTech.UI.Control.MessageBox;
using TinyTech.UI.Control.UIElement;

namespace TinyTech.BasicInformation
{
    public class CurrencyDefinition : TinyTech.UI.Control.UIElement.UserControl
    {
        #region Region 
        private UI.Control.UIElement.Panel pnlCurrencyDefinition;
        private UI.Control.UIElement.GroupBox groupBoxCurrencyDefinition;
        private UI.Control.UIElement.Panel pnlButtons;
        private UI.Control.Button.RefreshButton btnRefresh;
        private UI.Control.Button.CancelButton btnCancel;
        private UI.Control.Button.SaveButton btnSave;
        private UI.Control.UIElement.Panel pnlMain;
        private UI.Control.UIElement.DataGridView dgvCurrency;
        ConnectionClasses @class = new ConnectionClasses();
        TabManagement @tab = new TabManagement();
        private int MaxID;
        private UI.Control.Label.Label lblCurrencyID;
        private UI.Control.Label.Label lblDescription;
        private UI.Control.TextBox.TextBox txtDescription;
        private UI.Control.TextBox.TextBox txtCurrencyName;
        private UI.Control.TextBox.NumericTextBoxWithSeperator txtCurrencyID;
        private int MaxID_;
        TinyTechEntities DB_Connection = new TinyTechEntities();
        private UI.Control.TextBox.DateControl dateControlCurrency;
        private UI.Control.Label.Label lblDate;
        private UI.Control.Label.Label lblCurrencyName;
        private UI.Control.Label.Label lblDefaultCurrency;
        private UI.Control.CheckBox.CheckBox chkIsDefault;
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

        public CurrencyDefinition()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.pnlMain = new TinyTech.UI.Control.UIElement.Panel();
            this.dgvCurrency = new TinyTech.UI.Control.UIElement.DataGridView();
            this.pnlCurrencyDefinition = new TinyTech.UI.Control.UIElement.Panel();
            this.groupBoxCurrencyDefinition = new TinyTech.UI.Control.UIElement.GroupBox();
            this.chkIsDefault = new TinyTech.UI.Control.CheckBox.CheckBox();
            this.btnSave = new TinyTech.UI.Control.Button.SaveButton();
            this.btnRefresh = new TinyTech.UI.Control.Button.RefreshButton();
            this.btnCancel = new TinyTech.UI.Control.Button.CancelButton();
            this.dateControlCurrency = new TinyTech.UI.Control.TextBox.DateControl();
            this.txtCurrencyName = new TinyTech.UI.Control.TextBox.TextBox();
            this.txtDescription = new TinyTech.UI.Control.TextBox.TextBox();
            this.lblDefaultCurrency = new TinyTech.UI.Control.Label.Label();
            this.lblDate = new TinyTech.UI.Control.Label.Label();
            this.txtCurrencyID = new TinyTech.UI.Control.TextBox.NumericTextBoxWithSeperator();
            this.lblCurrencyID = new TinyTech.UI.Control.Label.Label();
            this.lblDescription = new TinyTech.UI.Control.Label.Label();
            this.lblCurrencyName = new TinyTech.UI.Control.Label.Label();
            this.pnlButtons = new TinyTech.UI.Control.UIElement.Panel();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrency)).BeginInit();
            this.pnlCurrencyDefinition.SuspendLayout();
            this.groupBoxCurrencyDefinition.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.dgvCurrency);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.pnlMain.Location = new System.Drawing.Point(0, 138);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlMain.Size = new System.Drawing.Size(800, 362);
            this.pnlMain.TabIndex = 1;
            // 
            // dgvCurrency
            // 
            this.dgvCurrency.AllowUserToAddRows = false;
            this.dgvCurrency.AllowUserToDeleteRows = false;
            this.dgvCurrency.AllowUserToOrderColumns = true;
            this.dgvCurrency.AllowUserToResizeColumns = false;
            this.dgvCurrency.AllowUserToResizeRows = false;
            this.dgvCurrency.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCurrency.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCurrency.Location = new System.Drawing.Point(0, 0);
            this.dgvCurrency.MultiSelect = false;
            this.dgvCurrency.Name = "dgvCurrency";
            this.dgvCurrency.ReadOnly = true;
            this.dgvCurrency.RowHeadersVisible = false;
            this.dgvCurrency.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvCurrency.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCurrency.Size = new System.Drawing.Size(800, 362);
            this.dgvCurrency.TabIndex = 1;
            // 
            // pnlCurrencyDefinition
            // 
            this.pnlCurrencyDefinition.Controls.Add(this.groupBoxCurrencyDefinition);
            this.pnlCurrencyDefinition.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCurrencyDefinition.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.pnlCurrencyDefinition.Location = new System.Drawing.Point(0, 0);
            this.pnlCurrencyDefinition.Name = "pnlCurrencyDefinition";
            this.pnlCurrencyDefinition.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlCurrencyDefinition.Size = new System.Drawing.Size(800, 138);
            this.pnlCurrencyDefinition.TabIndex = 0;
            // 
            // groupBoxCurrencyDefinition
            // 
            this.groupBoxCurrencyDefinition.Controls.Add(this.chkIsDefault);
            this.groupBoxCurrencyDefinition.Controls.Add(this.lblDefaultCurrency);
            this.groupBoxCurrencyDefinition.Controls.Add(this.lblDate);
            this.groupBoxCurrencyDefinition.Controls.Add(this.dateControlCurrency);
            this.groupBoxCurrencyDefinition.Controls.Add(this.txtCurrencyID);
            this.groupBoxCurrencyDefinition.Controls.Add(this.txtDescription);
            this.groupBoxCurrencyDefinition.Controls.Add(this.txtCurrencyName);
            this.groupBoxCurrencyDefinition.Controls.Add(this.lblCurrencyID);
            this.groupBoxCurrencyDefinition.Controls.Add(this.lblDescription);
            this.groupBoxCurrencyDefinition.Controls.Add(this.lblCurrencyName);
            this.groupBoxCurrencyDefinition.Controls.Add(this.pnlButtons);
            this.groupBoxCurrencyDefinition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxCurrencyDefinition.Location = new System.Drawing.Point(0, 0);
            this.groupBoxCurrencyDefinition.Name = "groupBoxCurrencyDefinition";
            this.groupBoxCurrencyDefinition.Size = new System.Drawing.Size(800, 138);
            this.groupBoxCurrencyDefinition.TabIndex = 0;
            this.groupBoxCurrencyDefinition.TabStop = false;
            this.groupBoxCurrencyDefinition.Text = "تعريف واحد پول";
            // 
            // chkIsDefault
            // 
            this.chkIsDefault.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkIsDefault.AutoSize = true;
            this.chkIsDefault.Location = new System.Drawing.Point(353, 97);
            this.chkIsDefault.Name = "chkIsDefault";
            this.chkIsDefault.NextControl = this.btnSave;
            this.chkIsDefault.Size = new System.Drawing.Size(127, 24);
            this.chkIsDefault.TabIndex = 16;
            this.chkIsDefault.Text = "واحد پول پيش فرض";
            this.chkIsDefault.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(231)))));
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(231)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(174, 3);
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
            this.btnCancel.NextControl = this.dateControlCurrency;
            this.btnCancel.Size = new System.Drawing.Size(81, 34);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "انصراف";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dateControlCurrency
            // 
            this.dateControlCurrency.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateControlCurrency.BackColor = System.Drawing.Color.White;
            this.dateControlCurrency.CanGoBackward = true;
            this.dateControlCurrency.CanGoForward = false;
            this.dateControlCurrency.Location = new System.Drawing.Point(584, 24);
            this.dateControlCurrency.Name = "dateControlCurrency";
            this.dateControlCurrency.NextControl = this.txtCurrencyName;
            this.dateControlCurrency.NowShamsi8Character = "97/06/14";
            this.dateControlCurrency.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateControlCurrency.ShamsiNow = "1397/06/14";
            this.dateControlCurrency.Size = new System.Drawing.Size(120, 20);
            this.dateControlCurrency.TabIndex = 0;
            this.dateControlCurrency.Text = "dateControl1";
            this.dateControlCurrency.Value10Cahracter = null;
            // 
            // txtCurrencyName
            // 
            this.txtCurrencyName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCurrencyName.BackColor = System.Drawing.Color.White;
            this.txtCurrencyName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCurrencyName.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.txtCurrencyName.ForeColor = System.Drawing.Color.Black;
            this.txtCurrencyName.Location = new System.Drawing.Point(504, 57);
            this.txtCurrencyName.Margin = new System.Windows.Forms.Padding(10);
            this.txtCurrencyName.Name = "txtCurrencyName";
            this.txtCurrencyName.NextControl = this.txtDescription;
            this.txtCurrencyName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCurrencyName.Size = new System.Drawing.Size(200, 28);
            this.txtCurrencyName.TabIndex = 1;
            this.txtCurrencyName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCurrencyName.TextChanged += new System.EventHandler(this.CurrencyName_TextChanged);
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.BackColor = System.Drawing.Color.White;
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescription.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.txtDescription.ForeColor = System.Drawing.Color.Black;
            this.txtDescription.Location = new System.Drawing.Point(504, 96);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(10);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.NextControl = this.chkIsDefault;
            this.txtDescription.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDescription.Size = new System.Drawing.Size(200, 28);
            this.txtDescription.TabIndex = 2;
            this.txtDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDefaultCurrency
            // 
            this.lblDefaultCurrency.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDefaultCurrency.AutoSize = true;
            this.lblDefaultCurrency.BackColor = System.Drawing.Color.Transparent;
            this.lblDefaultCurrency.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.lblDefaultCurrency.Location = new System.Drawing.Point(6, 59);
            this.lblDefaultCurrency.Name = "lblDefaultCurrency";
            this.lblDefaultCurrency.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblDefaultCurrency.Size = new System.Drawing.Size(108, 20);
            this.lblDefaultCurrency.TabIndex = 15;
            this.lblDefaultCurrency.Text = "واحد پول پيش فرض";
            this.lblDefaultCurrency.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.lblDate.Location = new System.Drawing.Point(717, 24);
            this.lblDate.Name = "lblDate";
            this.lblDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblDate.Size = new System.Drawing.Size(40, 20);
            this.lblDate.TabIndex = 13;
            this.lblDate.Text = "تاريخ :";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCurrencyID
            // 
            this.txtCurrencyID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCurrencyID.BackColor = System.Drawing.Color.White;
            this.txtCurrencyID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCurrencyID.Enabled = false;
            this.txtCurrencyID.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.txtCurrencyID.ForeColor = System.Drawing.Color.Black;
            this.txtCurrencyID.Location = new System.Drawing.Point(342, 57);
            this.txtCurrencyID.Margin = new System.Windows.Forms.Padding(10);
            this.txtCurrencyID.Name = "txtCurrencyID";
            this.txtCurrencyID.NextControl = null;
            this.txtCurrencyID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCurrencyID.Size = new System.Drawing.Size(54, 28);
            this.txtCurrencyID.TabIndex = 12;
            this.txtCurrencyID.Text = "0";
            this.txtCurrencyID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCurrencyID.Value = 0D;
            // 
            // lblCurrencyID
            // 
            this.lblCurrencyID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCurrencyID.AutoSize = true;
            this.lblCurrencyID.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrencyID.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.lblCurrencyID.Location = new System.Drawing.Point(409, 59);
            this.lblCurrencyID.Name = "lblCurrencyID";
            this.lblCurrencyID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblCurrencyID.Size = new System.Drawing.Size(75, 20);
            this.lblCurrencyID.TabIndex = 9;
            this.lblCurrencyID.Text = "كد واحد پول :";
            this.lblCurrencyID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescription.AutoSize = true;
            this.lblDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblDescription.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.lblDescription.Location = new System.Drawing.Point(717, 98);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblDescription.Size = new System.Drawing.Size(60, 20);
            this.lblDescription.TabIndex = 8;
            this.lblDescription.Text = "توضيحات :";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCurrencyName
            // 
            this.lblCurrencyName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCurrencyName.AutoSize = true;
            this.lblCurrencyName.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrencyName.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.lblCurrencyName.Location = new System.Drawing.Point(717, 59);
            this.lblCurrencyName.Name = "lblCurrencyName";
            this.lblCurrencyName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblCurrencyName.Size = new System.Drawing.Size(28, 20);
            this.lblCurrencyName.TabIndex = 7;
            this.lblCurrencyName.Text = "نام :";
            this.lblCurrencyName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlButtons
            // 
            this.pnlButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlButtons.Controls.Add(this.btnRefresh);
            this.pnlButtons.Controls.Add(this.btnCancel);
            this.pnlButtons.Controls.Add(this.btnSave);
            this.pnlButtons.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.pnlButtons.Location = new System.Drawing.Point(6, 84);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlButtons.Size = new System.Drawing.Size(258, 40);
            this.pnlButtons.TabIndex = 3;
            // 
            // CurrencyDefinition
            // 
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlCurrencyDefinition);
            this.Name = "CurrencyDefinition";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(800, 500);
            this.Tag = "تعريف واحد پول";
            this.Load += new System.EventHandler(this.CurrencyDefinition_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CurrencyDefinition_KeyDown);
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrency)).EndInit();
            this.pnlCurrencyDefinition.ResumeLayout(false);
            this.groupBoxCurrencyDefinition.ResumeLayout(false);
            this.groupBoxCurrencyDefinition.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            @tab.CloseTab(this);
        }

        private DataTable CurrencyDataTable(List<Currency> CurrencyList)
        {
            var dataTable = ToolBox<Currency>.GetDataTable(CurrencyList);
            return dataTable;
        }

        private void ClearForm()
        {
            txtCurrencyName.Text = txtDescription.Text = string.Empty;
            chkIsDefault.Checked = false;
        }

        private bool CheckDefaultCurrency()
        {
            var currency = @class.GetCurrency(true).Count(i => i.IsDefault);
            if (currency == 1)
            {
                return true;
            }
            return false;
        }

        private void CurrencyDefinition_Load(object sender, EventArgs e)
        {
            var CurrencyList = @class.GetCurrency(true);
            dgvCurrency.DataSource = CurrencyList;//CurrencyDataTable(CurrencyList);
            SetGridView();
            txtCurrencyID.Text = CalculateMaxId().ToString();
            ClearForm();
            txtCurrencyName.Focus();
            if (CheckDefaultCurrency())
            {
                lblDefaultCurrency.BackColor = Color.Green;
                lblDefaultCurrency.ForeColor = Color.White;
                lblDefaultCurrency.Text = $"واحد پول پيش فرض شما \"{CurrencyList.FirstOrDefault(i => i.IsDefault).Name}\" مي باشد";
            }
            else
            {
                lblDefaultCurrency.BackColor = Color.Red;
                lblDefaultCurrency.ForeColor = Color.White;
                lblDefaultCurrency.Text = "واحد پول پيش فرض تعيين نشده است";
            }
        }

        private int CalculateMaxId()
        {
            if (@class.GetCurrency().Count <= 0) return 1;
            var max = @class.GetCurrency().Max(i => i.ID) + 1;
            return max;
        }

        private void SetGridView()
        {
            foreach (DataGridViewColumn item in dgvCurrency.Columns)
            {
                item.Visible = false;
            }

            dgvCurrency.Columns["ID"].Visible = true;
            dgvCurrency.Columns["Name"].Visible = true;
            dgvCurrency.Columns["Description"].Visible = true;

            dgvCurrency.Columns["ID"].HeaderText = "كد";
            dgvCurrency.Columns["Name"].HeaderText = "واحد پول";
            dgvCurrency.Columns["Description"].HeaderText = "توضيحات";

            dgvCurrency.Columns["ID"].DisplayIndex = 0;
            dgvCurrency.Columns["Name"].DisplayIndex = 1;
            dgvCurrency.Columns["Description"].DisplayIndex = 2;

            dgvCurrency.Columns["ID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvCurrency.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvCurrency.Columns["Description"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvCurrency.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvCurrency.Columns["ID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvCurrency.Columns["Name"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvCurrency.Columns["Description"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            dgvCurrency.AutoGenerateColumns = false;
        }

        private void CurrencyDefinition_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                @tab.CloseTab(this);
            }
        }

        private bool FormValidate()
        {
            if (string.IsNullOrWhiteSpace(txtCurrencyName.Text))
            {
                CustomMessageForm.CustomMessageBox.Show("اخطار", "لطفا واحد پول را وارد كنيد", "e");
                txtCurrencyName.Focus();
                return false;
            }
            if (@class.GetCurrency(true).Count(i => i.Name.Equals(txtCurrencyName.Text.Trim())) > 0)
            {
                CustomMessageForm.CustomMessageBox.Show("اخطار !", $"واحد پول \"{txtCurrencyName.Text}\" تكراري است!", "e");
                txtCurrencyName.Focus();
                return false;
            }

            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (FormValidate())
            {
                var result = @class.CurrencyDefinition(txtCurrencyName.Text, txtDescription.Text, chkIsDefault.Checked, dateControlCurrency.ShamsiValue(), ConnectionClasses.DateServer.ReturnDateServer(), DateTime.Now.ToString("HH:mm:ss"), ConnectionClasses.DateServer.ServerTime(), ConnectionInfo.LoggedInUserId);

                if (result > 0)
                {
                    CustomMessageForm.CustomMessageBox.Show("پيغام سيستم", $"واحد پول \"{txtCurrencyName.Text}\" با موفقيت ثبت شد", "i");
                    MaxID_ = result;
                    if (int.Parse(txtCurrencyID.Text) != MaxID_)
                    {
                        CustomMessageForm.CustomMessageBox.Show("پيغام سيستم", $"كد واحد پول به {MaxID_} تغيير يافت", "i");
                    }
                    RefreshForm();
                }
                else if (result == 0)
                {
                    CustomMessageForm.CustomMessageBox.Show("خطا !", $"خطا در تعريف واحد پول!\n\nلطفا جهت بررسي مشكل با پشتيباني تماس بگيريد", "e");
                }
            }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshForm();
            txtCurrencyName.Focus();
        }

        private void RefreshForm()
        {
            CurrencyDefinition_Load(null, null);
        }

        private void CurrencyName_TextChanged(object sender, EventArgs e)
        {
            var CurrencyList = @class.GetCurrency(true).Where(i => i.Name.Contains(txtCurrencyName.Text)).ToList();
            dgvCurrency.DataSource = CurrencyList;//CurrencyDataTable(CurrencyList);
        }
    }
}
