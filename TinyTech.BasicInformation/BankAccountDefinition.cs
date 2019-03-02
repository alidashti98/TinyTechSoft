using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using TinyTech.Connection;
using TinyTech.UI.Control.MessageBox;
using TinyTech.UI.Control.UIElement;

namespace TinyTech.BasicInformation
{
    public class BankAccountDefinition : TinyTech.UI.Control.UIElement.UserControl
    {
        #region Region 
        private UI.Control.UIElement.Panel pnlBankAccountDefinition;
        private UI.Control.UIElement.GroupBox groupBoxBankAccountDefinition;
        private UI.Control.UIElement.Panel pnlButtons;
        private UI.Control.Button.RefreshButton btnRefresh;
        private UI.Control.Button.EditButton btnEdit;
        private UI.Control.Button.CancelButton btnCancel;
        private UI.Control.Button.SaveButton btnSave;
        private UI.Control.UIElement.Panel pnlMain;
        private UI.Control.UIElement.DataGridView dgvBankAccount;
        ConnectionClasses @class = new ConnectionClasses();
        TabManagement @tab = new TabManagement();
        private int MaxID;
        private UI.Control.Label.Label lblBankAccountID;
        private UI.Control.Label.Label lblDescription;
        private UI.Control.TextBox.TextBox txtDescription;
        private UI.Control.TextBox.TextBox txtBankAccountNumber;
        private UI.Control.TextBox.NumericTextBoxWithSeperator txtBankAccountID;
        private int MaxID_;
        TinyTechEntities DB_Connection = new TinyTechEntities();
        private UI.Control.TextBox.DateControl dateControlBankAccount;
        private UI.Control.Label.Label lblDate;
        private UI.Control.Label.Label lblBankAccountName;
        private UI.Control.Label.Label lblAccountType;
        private UI.Control.ComboBox.ComboBox cmbAccountType;
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

        public BankAccountDefinition()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.pnlMain = new TinyTech.UI.Control.UIElement.Panel();
            this.dgvBankAccount = new TinyTech.UI.Control.UIElement.DataGridView();
            this.pnlBankAccountDefinition = new TinyTech.UI.Control.UIElement.Panel();
            this.groupBoxBankAccountDefinition = new TinyTech.UI.Control.UIElement.GroupBox();
            this.cmbAccountType = new TinyTech.UI.Control.ComboBox.ComboBox();
            this.txtDescription = new TinyTech.UI.Control.TextBox.TextBox();
            this.btnSave = new TinyTech.UI.Control.Button.SaveButton();
            this.btnRefresh = new TinyTech.UI.Control.Button.RefreshButton();
            this.btnCancel = new TinyTech.UI.Control.Button.CancelButton();
            this.dateControlBankAccount = new TinyTech.UI.Control.TextBox.DateControl();
            this.txtBankAccountNumber = new TinyTech.UI.Control.TextBox.TextBox();
            this.lblAccountType = new TinyTech.UI.Control.Label.Label();
            this.lblDate = new TinyTech.UI.Control.Label.Label();
            this.txtBankAccountID = new TinyTech.UI.Control.TextBox.NumericTextBoxWithSeperator();
            this.lblBankAccountID = new TinyTech.UI.Control.Label.Label();
            this.lblDescription = new TinyTech.UI.Control.Label.Label();
            this.lblBankAccountName = new TinyTech.UI.Control.Label.Label();
            this.pnlButtons = new TinyTech.UI.Control.UIElement.Panel();
            this.btnEdit = new TinyTech.UI.Control.Button.EditButton();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBankAccount)).BeginInit();
            this.pnlBankAccountDefinition.SuspendLayout();
            this.groupBoxBankAccountDefinition.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.dgvBankAccount);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.pnlMain.Location = new System.Drawing.Point(0, 253);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlMain.Size = new System.Drawing.Size(800, 247);
            this.pnlMain.TabIndex = 1;
            // 
            // dgvBankAccount
            // 
            this.dgvBankAccount.AllowUserToAddRows = false;
            this.dgvBankAccount.AllowUserToDeleteRows = false;
            this.dgvBankAccount.AllowUserToOrderColumns = true;
            this.dgvBankAccount.AllowUserToResizeColumns = false;
            this.dgvBankAccount.AllowUserToResizeRows = false;
            this.dgvBankAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBankAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBankAccount.Location = new System.Drawing.Point(0, 0);
            this.dgvBankAccount.MultiSelect = false;
            this.dgvBankAccount.Name = "dgvBankAccount";
            this.dgvBankAccount.ReadOnly = true;
            this.dgvBankAccount.RowHeadersVisible = false;
            this.dgvBankAccount.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvBankAccount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBankAccount.Size = new System.Drawing.Size(800, 247);
            this.dgvBankAccount.TabIndex = 1;
            // 
            // pnlBankAccountDefinition
            // 
            this.pnlBankAccountDefinition.Controls.Add(this.groupBoxBankAccountDefinition);
            this.pnlBankAccountDefinition.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBankAccountDefinition.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.pnlBankAccountDefinition.Location = new System.Drawing.Point(0, 0);
            this.pnlBankAccountDefinition.Name = "pnlBankAccountDefinition";
            this.pnlBankAccountDefinition.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlBankAccountDefinition.Size = new System.Drawing.Size(800, 253);
            this.pnlBankAccountDefinition.TabIndex = 0;
            // 
            // groupBoxBankAccountDefinition
            // 
            this.groupBoxBankAccountDefinition.Controls.Add(this.cmbAccountType);
            this.groupBoxBankAccountDefinition.Controls.Add(this.lblAccountType);
            this.groupBoxBankAccountDefinition.Controls.Add(this.lblDate);
            this.groupBoxBankAccountDefinition.Controls.Add(this.dateControlBankAccount);
            this.groupBoxBankAccountDefinition.Controls.Add(this.txtBankAccountID);
            this.groupBoxBankAccountDefinition.Controls.Add(this.txtDescription);
            this.groupBoxBankAccountDefinition.Controls.Add(this.txtBankAccountNumber);
            this.groupBoxBankAccountDefinition.Controls.Add(this.lblBankAccountID);
            this.groupBoxBankAccountDefinition.Controls.Add(this.lblDescription);
            this.groupBoxBankAccountDefinition.Controls.Add(this.lblBankAccountName);
            this.groupBoxBankAccountDefinition.Controls.Add(this.pnlButtons);
            this.groupBoxBankAccountDefinition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxBankAccountDefinition.Location = new System.Drawing.Point(0, 0);
            this.groupBoxBankAccountDefinition.Name = "groupBoxBankAccountDefinition";
            this.groupBoxBankAccountDefinition.Size = new System.Drawing.Size(800, 253);
            this.groupBoxBankAccountDefinition.TabIndex = 0;
            this.groupBoxBankAccountDefinition.TabStop = false;
            this.groupBoxBankAccountDefinition.Text = "تعريف شماره حساب";
            // 
            // cmbAccountType
            // 
            this.cmbAccountType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbAccountType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbAccountType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbAccountType.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.cmbAccountType.FormattingEnabled = true;
            this.cmbAccountType.Location = new System.Drawing.Point(504, 95);
            this.cmbAccountType.Margin = new System.Windows.Forms.Padding(10);
            this.cmbAccountType.Name = "cmbAccountType";
            this.cmbAccountType.NextControl = this.txtDescription;
            this.cmbAccountType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbAccountType.Size = new System.Drawing.Size(200, 28);
            this.cmbAccountType.TabIndex = 15;
            this.cmbAccountType.DropDown += new System.EventHandler(this.cmbAccountType_DropDown);
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.BackColor = System.Drawing.Color.White;
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescription.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.txtDescription.ForeColor = System.Drawing.Color.Black;
            this.txtDescription.Location = new System.Drawing.Point(504, 134);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(10);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.NextControl = this.btnSave;
            this.txtDescription.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDescription.Size = new System.Drawing.Size(200, 28);
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
            this.btnSave.Location = new System.Drawing.Point(261, 3);
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
            this.btnCancel.NextControl = this.dateControlBankAccount;
            this.btnCancel.Size = new System.Drawing.Size(81, 34);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "انصراف";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dateControlBankAccount
            // 
            this.dateControlBankAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateControlBankAccount.BackColor = System.Drawing.Color.White;
            this.dateControlBankAccount.CanGoBackward = true;
            this.dateControlBankAccount.CanGoForward = false;
            this.dateControlBankAccount.Location = new System.Drawing.Point(584, 24);
            this.dateControlBankAccount.Name = "dateControlBankAccount";
            this.dateControlBankAccount.NextControl = this.txtBankAccountNumber;
            this.dateControlBankAccount.ShamsiNow = "1397/06/14";
            this.dateControlBankAccount.NowShamsi8Character = "97/06/14";
            this.dateControlBankAccount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateControlBankAccount.Size = new System.Drawing.Size(120, 20);
            this.dateControlBankAccount.TabIndex = 0;
            this.dateControlBankAccount.Text = "dateControl1";
            this.dateControlBankAccount.Value10Cahracter = null;
            // 
            // txtBankAccountNumber
            // 
            this.txtBankAccountNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBankAccountNumber.BackColor = System.Drawing.Color.White;
            this.txtBankAccountNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBankAccountNumber.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.txtBankAccountNumber.ForeColor = System.Drawing.Color.Black;
            this.txtBankAccountNumber.Location = new System.Drawing.Point(504, 57);
            this.txtBankAccountNumber.Margin = new System.Windows.Forms.Padding(10);
            this.txtBankAccountNumber.Name = "txtBankAccountNumber";
            this.txtBankAccountNumber.NextControl = this.txtDescription;
            this.txtBankAccountNumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtBankAccountNumber.Size = new System.Drawing.Size(200, 28);
            this.txtBankAccountNumber.TabIndex = 1;
            this.txtBankAccountNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBankAccountNumber.TextChanged += new System.EventHandler(this.txtBankAccountNumber_TextChanged);
            // 
            // lblAccountType
            // 
            this.lblAccountType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAccountType.AutoSize = true;
            this.lblAccountType.BackColor = System.Drawing.Color.Transparent;
            this.lblAccountType.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.lblAccountType.Location = new System.Drawing.Point(717, 98);
            this.lblAccountType.Name = "lblAccountType";
            this.lblAccountType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblAccountType.Size = new System.Drawing.Size(67, 20);
            this.lblAccountType.TabIndex = 14;
            this.lblAccountType.Text = "نوع حساب :";
            this.lblAccountType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // txtBankAccountID
            // 
            this.txtBankAccountID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBankAccountID.BackColor = System.Drawing.Color.White;
            this.txtBankAccountID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBankAccountID.Enabled = false;
            this.txtBankAccountID.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.txtBankAccountID.ForeColor = System.Drawing.Color.Black;
            this.txtBankAccountID.Location = new System.Drawing.Point(341, 57);
            this.txtBankAccountID.Margin = new System.Windows.Forms.Padding(10);
            this.txtBankAccountID.Name = "txtBankAccountID";
            this.txtBankAccountID.NextControl = null;
            this.txtBankAccountID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtBankAccountID.Size = new System.Drawing.Size(54, 28);
            this.txtBankAccountID.TabIndex = 12;
            this.txtBankAccountID.Text = "0";
            this.txtBankAccountID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBankAccountID.Value = 0D;
            // 
            // lblBankAccountID
            // 
            this.lblBankAccountID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBankAccountID.AutoSize = true;
            this.lblBankAccountID.BackColor = System.Drawing.Color.Transparent;
            this.lblBankAccountID.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.lblBankAccountID.Location = new System.Drawing.Point(408, 59);
            this.lblBankAccountID.Name = "lblBankAccountID";
            this.lblBankAccountID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblBankAccountID.Size = new System.Drawing.Size(92, 20);
            this.lblBankAccountID.TabIndex = 9;
            this.lblBankAccountID.Text = "كد شماره حساب :";
            this.lblBankAccountID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescription.AutoSize = true;
            this.lblDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblDescription.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.lblDescription.Location = new System.Drawing.Point(717, 136);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblDescription.Size = new System.Drawing.Size(60, 20);
            this.lblDescription.TabIndex = 8;
            this.lblDescription.Text = "توضيحات :";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBankAccountName
            // 
            this.lblBankAccountName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBankAccountName.AutoSize = true;
            this.lblBankAccountName.BackColor = System.Drawing.Color.Transparent;
            this.lblBankAccountName.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.lblBankAccountName.Location = new System.Drawing.Point(717, 59);
            this.lblBankAccountName.Name = "lblBankAccountName";
            this.lblBankAccountName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblBankAccountName.Size = new System.Drawing.Size(77, 20);
            this.lblBankAccountName.TabIndex = 7;
            this.lblBankAccountName.Text = "شماره حساب :";
            this.lblBankAccountName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlButtons
            // 
            this.pnlButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlButtons.Controls.Add(this.btnRefresh);
            this.pnlButtons.Controls.Add(this.btnEdit);
            this.pnlButtons.Controls.Add(this.btnCancel);
            this.pnlButtons.Controls.Add(this.btnSave);
            this.pnlButtons.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.pnlButtons.Location = new System.Drawing.Point(6, 88);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlButtons.Size = new System.Drawing.Size(345, 40);
            this.pnlButtons.TabIndex = 3;
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.BackColor = System.Drawing.Color.Green;
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(175, 3);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(10);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.NextControl = null;
            this.btnEdit.Size = new System.Drawing.Size(81, 34);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "ويرايش";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // BankAccountDefinition
            // 
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlBankAccountDefinition);
            this.Name = "BankAccountDefinition";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(800, 500);
            this.Tag = "تعريف شماره حساب";
            this.Load += new System.EventHandler(this.BankAccountDefinition_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BankAccountDefinition_KeyDown);
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBankAccount)).EndInit();
            this.pnlBankAccountDefinition.ResumeLayout(false);
            this.groupBoxBankAccountDefinition.ResumeLayout(false);
            this.groupBoxBankAccountDefinition.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            @tab.CloseTab(this);
        }

        private DataTable BankAccountListDataTable(List<BankAccount> bankAccountList)
        {
            var dataTable = UI.Control.UIElement.ToolBox<BankAccount>.GetDataTable(bankAccountList);
            return dataTable;
        }

        private void BankAccountDefinition_Load(object sender, EventArgs e)
        {
            FillAccountType();
            var bankAccountList = @class.GetBankAccount();
            dgvBankAccount.DataSource = BankAccountListDataTable(bankAccountList);
            SetGridView();
            txtBankAccountID.Text = CalculateMaxId().ToString();
            txtBankAccountNumber.Focus();
            btnEdit.Enabled = false;
        }

        private void FillAccountType()
        {
            var bankAccountType = @class.GetBankAccountType().Where(i => i.Active).ToList();
            cmbAccountType.DataSource = bankAccountType;
        }

        private int CalculateMaxId()
        {
            if (@class.GetBankAccount().Count <= 0) return 1;
            var max = @class.GetBankAccount().Max(i => i.ID) + 1;
            return max;
        }

        private void SetGridView()
        {
            foreach (DataGridViewColumn item in dgvBankAccount.Columns)
            {
                item.Visible = false;
            }
            dgvBankAccount.Columns["ID"].Visible = true;
            dgvBankAccount.Columns["AccountNumber"].Visible = true;
            dgvBankAccount.Columns["AccountOwner"].Visible = true;
            dgvBankAccount.Columns["Description"].Visible = true;

            dgvBankAccount.Columns["ID"].HeaderText = "كد";
            dgvBankAccount.Columns["Name"].HeaderText = "نام";
            dgvBankAccount.Columns["Description"].HeaderText = "توضيحات";


            dgvBankAccount.Columns["ID"].DisplayIndex = 0;
            dgvBankAccount.Columns["Name"].DisplayIndex = 1;
            dgvBankAccount.Columns["Description"].DisplayIndex = 3;

            dgvBankAccount.Columns["ID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvBankAccount.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvBankAccount.Columns["Description"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvBankAccount.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvBankAccount.Columns["ID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvBankAccount.Columns["Name"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvBankAccount.Columns["Description"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            dgvBankAccount.AutoGenerateColumns = false;

        }

        private void BankAccountDefinition_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                @tab.CloseTab(this);
            }
        }

        private bool FormValidate()
        {
            if (string.IsNullOrWhiteSpace(txtBankAccountNumber.Text))
            {
                CustomMessageForm.CustomMessageBox.Show("اخطار", "لطفا شماره حساب را وارد كنيد", "e");
                txtBankAccountNumber.Focus();
                return false;
            }
            if (DB_Connection.BankAccount.AsNoTracking().Count(i => i.AccountNumber.Equals(txtBankAccountNumber.Text) && i.Active) > 0)
            {
                CustomMessageForm.CustomMessageBox.Show("اخطار !", $"شماره حساب \"{txtBankAccountNumber.Text}\" تكراري است!", "e");
                txtBankAccountNumber.Focus();
                return false;
            }

            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (FormValidate())
            {
                var result = @class.BankAccountDefinition(txtBankAccountNumber.Text, txtDescription.Text, dateControlBankAccount.ShamsiValue(), ConnectionClasses.DateServer.ReturnDateServer(), ConnectionInfo.LoggedInUserId);

                if (result > 0)
                {
                    CustomMessageForm.CustomMessageBox.Show("پيغام سيستم", $"شماره حساب \"{txtBankAccountNumber.Text}\" با موفقيت ثبت شد", "i");
                    MaxID_ = result;
                    if (int.Parse(txtBankAccountID.Text) != MaxID_)
                    {
                        CustomMessageForm.CustomMessageBox.Show("پيغام سيستم", $"كد شماره حساب به {MaxID_} تغيير يافت", "i");
                    }
                    RefreshForm();
                }
                else if (result == 0)
                {
                    CustomMessageForm.CustomMessageBox.Show("خطا !", $"خطا در تعريف شماره حساب!\n\nلطفا جهت بررسي مشكل با پشتيباني تماس بگيريد", "e");
                }
            }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshForm();
            txtBankAccountNumber.Focus();
        }

        private void RefreshForm()
        {
            BankAccountDefinition_Load(null, null);
            txtBankAccountNumber.Clear();
            txtDescription.Clear();
        }

        private void txtBankAccountNumber_TextChanged(object sender, EventArgs e)
        {
            //var BankAccountList = @class.GetBankAccount().Where(i => i.Active && i.Name.Contains(txtBankAccountNumber.Text)).ToList();
            //dgvBankAccount.DataSource = BankAccountListDataTable(BankAccountList);
        }

        private void cmbAccountType_DropDown(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
        }
    }
}
