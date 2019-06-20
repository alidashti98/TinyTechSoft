using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TinyTech.Connection;
using TinyTech.Selecting;
using TinyTech.UI.Control.MessageBox;
using TinyTech.UI.Control.UIElement;
using CEWorld;

namespace TinyTech.BasicInformation
{
    public class BankAccountDefinition : TinyTech.UI.Control.UIElement.UserControl
    {
        #region Region 
        private UI.Control.UIElement.Panel pnlBankAccountDefinition;
        private UI.Control.UIElement.GroupBox groupBoxBankAccountDefinition;
        private UI.Control.UIElement.Panel pnlButtons;
        private UI.Control.Button.RefreshButton btnRefresh;
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
        private UI.Control.TextBox.TextBox txtPhone2;
        private UI.Control.Label.Label lblPhone2;
        private UI.Control.TextBox.TextBox txtPhone1;
        private UI.Control.Label.Label lblPhone1;
        private UI.Control.TextBox.TextBox txtBranch;
        private UI.Control.Label.Label lblBranch;
        private UI.Control.TextBox.TextBox txtAddress;
        private UI.Control.Label.Label lblAddress;
        private UI.Control.TextBox.NumericTextBoxWithSeperator txtBalance;
        private UI.Control.Label.Label lblBalance;
        private UI.Control.TextBox.NumericTextBoxWithSeperator txtCrediting;
        private UI.Control.Label.Label lblCrediting;
        private UI.Control.TextBox.NumericTextBoxWithSeperator txtDebt;
        private UI.Control.Label.Label lblDebt;
        private UI.Control.TextBox.TextBox txtAccountOwner;
        private UI.Control.Label.Label lblOwnerName;
        private UI.Control.CheckBox.CheckBox chkBankAccountType;
        private UI.Control.TextBox.TextBox txtBankAccountTypeName;
        private UI.Control.CheckBox.CheckBox chkBankName;
        private UI.Control.TextBox.TextBox txtBankName;
        private UI.Control.Label.Label lblBalanceString;
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
            this.chkBankName = new TinyTech.UI.Control.CheckBox.CheckBox();
            this.txtBankName = new TinyTech.UI.Control.TextBox.TextBox();
            this.chkBankAccountType = new TinyTech.UI.Control.CheckBox.CheckBox();
            this.txtBankAccountTypeName = new TinyTech.UI.Control.TextBox.TextBox();
            this.txtPhone2 = new TinyTech.UI.Control.TextBox.TextBox();
            this.txtDebt = new TinyTech.UI.Control.TextBox.NumericTextBoxWithSeperator();
            this.txtCrediting = new TinyTech.UI.Control.TextBox.NumericTextBoxWithSeperator();
            this.txtDescription = new TinyTech.UI.Control.TextBox.TextBox();
            this.btnSave = new TinyTech.UI.Control.Button.SaveButton();
            this.btnRefresh = new TinyTech.UI.Control.Button.RefreshButton();
            this.btnCancel = new TinyTech.UI.Control.Button.CancelButton();
            this.lblPhone2 = new TinyTech.UI.Control.Label.Label();
            this.txtPhone1 = new TinyTech.UI.Control.TextBox.TextBox();
            this.lblPhone1 = new TinyTech.UI.Control.Label.Label();
            this.txtBranch = new TinyTech.UI.Control.TextBox.TextBox();
            this.lblBranch = new TinyTech.UI.Control.Label.Label();
            this.txtAddress = new TinyTech.UI.Control.TextBox.TextBox();
            this.lblAddress = new TinyTech.UI.Control.Label.Label();
            this.txtBalance = new TinyTech.UI.Control.TextBox.NumericTextBoxWithSeperator();
            this.lblBalance = new TinyTech.UI.Control.Label.Label();
            this.lblCrediting = new TinyTech.UI.Control.Label.Label();
            this.lblDebt = new TinyTech.UI.Control.Label.Label();
            this.txtAccountOwner = new TinyTech.UI.Control.TextBox.TextBox();
            this.lblOwnerName = new TinyTech.UI.Control.Label.Label();
            this.lblDate = new TinyTech.UI.Control.Label.Label();
            this.dateControlBankAccount = new TinyTech.UI.Control.TextBox.DateControl();
            this.txtBankAccountNumber = new TinyTech.UI.Control.TextBox.TextBox();
            this.txtBankAccountID = new TinyTech.UI.Control.TextBox.NumericTextBoxWithSeperator();
            this.lblBankAccountID = new TinyTech.UI.Control.Label.Label();
            this.lblDescription = new TinyTech.UI.Control.Label.Label();
            this.lblBankAccountName = new TinyTech.UI.Control.Label.Label();
            this.pnlButtons = new TinyTech.UI.Control.UIElement.Panel();
            this.lblBalanceString = new TinyTech.UI.Control.Label.Label();
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
            this.pnlMain.Location = new System.Drawing.Point(0, 210);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlMain.Size = new System.Drawing.Size(800, 290);
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
            this.dgvBankAccount.Size = new System.Drawing.Size(800, 290);
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
            this.pnlBankAccountDefinition.Size = new System.Drawing.Size(800, 210);
            this.pnlBankAccountDefinition.TabIndex = 0;
            // 
            // groupBoxBankAccountDefinition
            // 
            this.groupBoxBankAccountDefinition.Controls.Add(this.chkBankName);
            this.groupBoxBankAccountDefinition.Controls.Add(this.txtBankName);
            this.groupBoxBankAccountDefinition.Controls.Add(this.chkBankAccountType);
            this.groupBoxBankAccountDefinition.Controls.Add(this.txtBankAccountTypeName);
            this.groupBoxBankAccountDefinition.Controls.Add(this.txtPhone2);
            this.groupBoxBankAccountDefinition.Controls.Add(this.lblPhone2);
            this.groupBoxBankAccountDefinition.Controls.Add(this.txtPhone1);
            this.groupBoxBankAccountDefinition.Controls.Add(this.lblPhone1);
            this.groupBoxBankAccountDefinition.Controls.Add(this.txtBranch);
            this.groupBoxBankAccountDefinition.Controls.Add(this.lblBranch);
            this.groupBoxBankAccountDefinition.Controls.Add(this.txtAddress);
            this.groupBoxBankAccountDefinition.Controls.Add(this.lblAddress);
            this.groupBoxBankAccountDefinition.Controls.Add(this.txtBalance);
            this.groupBoxBankAccountDefinition.Controls.Add(this.lblBalance);
            this.groupBoxBankAccountDefinition.Controls.Add(this.txtCrediting);
            this.groupBoxBankAccountDefinition.Controls.Add(this.lblCrediting);
            this.groupBoxBankAccountDefinition.Controls.Add(this.txtDebt);
            this.groupBoxBankAccountDefinition.Controls.Add(this.lblDebt);
            this.groupBoxBankAccountDefinition.Controls.Add(this.txtAccountOwner);
            this.groupBoxBankAccountDefinition.Controls.Add(this.lblOwnerName);
            this.groupBoxBankAccountDefinition.Controls.Add(this.lblDate);
            this.groupBoxBankAccountDefinition.Controls.Add(this.dateControlBankAccount);
            this.groupBoxBankAccountDefinition.Controls.Add(this.txtBankAccountID);
            this.groupBoxBankAccountDefinition.Controls.Add(this.txtDescription);
            this.groupBoxBankAccountDefinition.Controls.Add(this.txtBankAccountNumber);
            this.groupBoxBankAccountDefinition.Controls.Add(this.lblBankAccountID);
            this.groupBoxBankAccountDefinition.Controls.Add(this.lblDescription);
            this.groupBoxBankAccountDefinition.Controls.Add(this.lblBankAccountName);
            this.groupBoxBankAccountDefinition.Controls.Add(this.pnlButtons);
            this.groupBoxBankAccountDefinition.Controls.Add(this.lblBalanceString);
            this.groupBoxBankAccountDefinition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxBankAccountDefinition.Location = new System.Drawing.Point(0, 0);
            this.groupBoxBankAccountDefinition.Name = "groupBoxBankAccountDefinition";
            this.groupBoxBankAccountDefinition.Size = new System.Drawing.Size(800, 210);
            this.groupBoxBankAccountDefinition.TabIndex = 0;
            this.groupBoxBankAccountDefinition.TabStop = false;
            this.groupBoxBankAccountDefinition.Text = "تعريف شماره حساب";
            // 
            // chkBankName
            // 
            this.chkBankName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkBankName.AutoSize = true;
            this.chkBankName.Location = new System.Drawing.Point(726, 112);
            this.chkBankName.Name = "chkBankName";
            this.chkBankName.Size = new System.Drawing.Size(66, 24);
            this.chkBankName.TabIndex = 3;
            this.chkBankName.Text = "نام بانك";
            this.chkBankName.UseVisualStyleBackColor = true;
            this.chkBankName.CheckedChanged += new System.EventHandler(this.chkBankName_CheckedChanged);
            // 
            // txtBankName
            // 
            this.txtBankName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBankName.BackColor = System.Drawing.Color.White;
            this.txtBankName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBankName.Enabled = false;
            this.txtBankName.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.txtBankName.ForeColor = System.Drawing.Color.Gray;
            this.txtBankName.Location = new System.Drawing.Point(545, 111);
            this.txtBankName.Margin = new System.Windows.Forms.Padding(10);
            this.txtBankName.Name = "txtBankName";
            this.txtBankName.NextControl = null;
            this.txtBankName.ReadOnly = true;
            this.txtBankName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtBankName.Size = new System.Drawing.Size(159, 28);
            this.txtBankName.TabIndex = 38;
            this.txtBankName.Text = "انتخاب نام بانك ...";
            this.txtBankName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chkBankAccountType
            // 
            this.chkBankAccountType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkBankAccountType.AutoSize = true;
            this.chkBankAccountType.Location = new System.Drawing.Point(712, 81);
            this.chkBankAccountType.Name = "chkBankAccountType";
            this.chkBankAccountType.Size = new System.Drawing.Size(80, 24);
            this.chkBankAccountType.TabIndex = 2;
            this.chkBankAccountType.Text = "نوع حساب";
            this.chkBankAccountType.UseVisualStyleBackColor = true;
            this.chkBankAccountType.CheckedChanged += new System.EventHandler(this.chkBankAccountType_CheckedChanged);
            // 
            // txtBankAccountTypeName
            // 
            this.txtBankAccountTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBankAccountTypeName.BackColor = System.Drawing.Color.White;
            this.txtBankAccountTypeName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBankAccountTypeName.Enabled = false;
            this.txtBankAccountTypeName.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.txtBankAccountTypeName.ForeColor = System.Drawing.Color.Gray;
            this.txtBankAccountTypeName.Location = new System.Drawing.Point(545, 80);
            this.txtBankAccountTypeName.Margin = new System.Windows.Forms.Padding(10);
            this.txtBankAccountTypeName.Name = "txtBankAccountTypeName";
            this.txtBankAccountTypeName.NextControl = null;
            this.txtBankAccountTypeName.ReadOnly = true;
            this.txtBankAccountTypeName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtBankAccountTypeName.Size = new System.Drawing.Size(159, 28);
            this.txtBankAccountTypeName.TabIndex = 36;
            this.txtBankAccountTypeName.Text = "انتخاب نوع حساب ...";
            this.txtBankAccountTypeName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPhone2
            // 
            this.txtPhone2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPhone2.BackColor = System.Drawing.Color.White;
            this.txtPhone2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone2.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.txtPhone2.ForeColor = System.Drawing.Color.Black;
            this.txtPhone2.Location = new System.Drawing.Point(13, 81);
            this.txtPhone2.Margin = new System.Windows.Forms.Padding(10);
            this.txtPhone2.Name = "txtPhone2";
            this.txtPhone2.NextControl = this.txtDebt;
            this.txtPhone2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPhone2.Size = new System.Drawing.Size(112, 28);
            this.txtPhone2.TabIndex = 8;
            this.txtPhone2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDebt
            // 
            this.txtDebt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDebt.BackColor = System.Drawing.Color.White;
            this.txtDebt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDebt.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.txtDebt.ForeColor = System.Drawing.Color.Black;
            this.txtDebt.Location = new System.Drawing.Point(362, 111);
            this.txtDebt.Margin = new System.Windows.Forms.Padding(10);
            this.txtDebt.Name = "txtDebt";
            this.txtDebt.NextControl = this.txtCrediting;
            this.txtDebt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDebt.Size = new System.Drawing.Size(120, 28);
            this.txtDebt.TabIndex = 9;
            this.txtDebt.Text = "0";
            this.txtDebt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDebt.Value = 0D;
            this.txtDebt.TextChanged += new System.EventHandler(this.txtDebt_TextChanged);
            // 
            // txtCrediting
            // 
            this.txtCrediting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCrediting.BackColor = System.Drawing.Color.White;
            this.txtCrediting.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCrediting.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.txtCrediting.ForeColor = System.Drawing.Color.Black;
            this.txtCrediting.Location = new System.Drawing.Point(191, 113);
            this.txtCrediting.Margin = new System.Windows.Forms.Padding(10);
            this.txtCrediting.Name = "txtCrediting";
            this.txtCrediting.NextControl = this.txtDescription;
            this.txtCrediting.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCrediting.Size = new System.Drawing.Size(112, 28);
            this.txtCrediting.TabIndex = 10;
            this.txtCrediting.Text = "0";
            this.txtCrediting.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCrediting.Value = 0D;
            this.txtCrediting.TextChanged += new System.EventHandler(this.txtCrediting_TextChanged);
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.BackColor = System.Drawing.Color.White;
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescription.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.txtDescription.ForeColor = System.Drawing.Color.Black;
            this.txtDescription.Location = new System.Drawing.Point(282, 174);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(10);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.NextControl = this.btnSave;
            this.txtDescription.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDescription.Size = new System.Drawing.Size(422, 28);
            this.txtDescription.TabIndex = 11;
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
            this.btnRefresh.TabIndex = 1;
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
            this.btnCancel.NextControl = this.btnSave;
            this.btnCancel.Size = new System.Drawing.Size(81, 34);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "انصراف";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblPhone2
            // 
            this.lblPhone2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPhone2.AutoSize = true;
            this.lblPhone2.BackColor = System.Drawing.Color.Transparent;
            this.lblPhone2.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.lblPhone2.Location = new System.Drawing.Point(138, 83);
            this.lblPhone2.Name = "lblPhone2";
            this.lblPhone2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPhone2.Size = new System.Drawing.Size(41, 20);
            this.lblPhone2.TabIndex = 34;
            this.lblPhone2.Text = "تلفن 2";
            this.lblPhone2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPhone1
            // 
            this.txtPhone1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPhone1.BackColor = System.Drawing.Color.White;
            this.txtPhone1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone1.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.txtPhone1.ForeColor = System.Drawing.Color.Black;
            this.txtPhone1.Location = new System.Drawing.Point(191, 80);
            this.txtPhone1.Margin = new System.Windows.Forms.Padding(10);
            this.txtPhone1.Name = "txtPhone1";
            this.txtPhone1.NextControl = this.txtPhone2;
            this.txtPhone1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPhone1.Size = new System.Drawing.Size(112, 28);
            this.txtPhone1.TabIndex = 7;
            this.txtPhone1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPhone1
            // 
            this.lblPhone1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPhone1.AutoSize = true;
            this.lblPhone1.BackColor = System.Drawing.Color.Transparent;
            this.lblPhone1.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.lblPhone1.Location = new System.Drawing.Point(316, 82);
            this.lblPhone1.Name = "lblPhone1";
            this.lblPhone1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPhone1.Size = new System.Drawing.Size(38, 20);
            this.lblPhone1.TabIndex = 32;
            this.lblPhone1.Text = "تلفن 1";
            this.lblPhone1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBranch
            // 
            this.txtBranch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBranch.BackColor = System.Drawing.Color.White;
            this.txtBranch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBranch.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.txtBranch.ForeColor = System.Drawing.Color.Black;
            this.txtBranch.Location = new System.Drawing.Point(362, 80);
            this.txtBranch.Margin = new System.Windows.Forms.Padding(10);
            this.txtBranch.Name = "txtBranch";
            this.txtBranch.NextControl = this.txtPhone1;
            this.txtBranch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtBranch.Size = new System.Drawing.Size(120, 28);
            this.txtBranch.TabIndex = 6;
            this.txtBranch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblBranch
            // 
            this.lblBranch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBranch.AutoSize = true;
            this.lblBranch.BackColor = System.Drawing.Color.Transparent;
            this.lblBranch.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.lblBranch.Location = new System.Drawing.Point(498, 82);
            this.lblBranch.Name = "lblBranch";
            this.lblBranch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblBranch.Size = new System.Drawing.Size(34, 20);
            this.lblBranch.TabIndex = 30;
            this.lblBranch.Text = "شعبه";
            this.lblBranch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddress.BackColor = System.Drawing.Color.White;
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.txtAddress.ForeColor = System.Drawing.Color.Black;
            this.txtAddress.Location = new System.Drawing.Point(13, 49);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(10);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.NextControl = this.txtBranch;
            this.txtAddress.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtAddress.Size = new System.Drawing.Size(469, 28);
            this.txtAddress.TabIndex = 5;
            this.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblAddress
            // 
            this.lblAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAddress.AutoSize = true;
            this.lblAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblAddress.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.lblAddress.Location = new System.Drawing.Point(495, 51);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblAddress.Size = new System.Drawing.Size(37, 20);
            this.lblAddress.TabIndex = 28;
            this.lblAddress.Text = "آدرس";
            this.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBalance
            // 
            this.txtBalance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBalance.BackColor = System.Drawing.Color.White;
            this.txtBalance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBalance.Enabled = false;
            this.txtBalance.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.txtBalance.ForeColor = System.Drawing.Color.Black;
            this.txtBalance.Location = new System.Drawing.Point(13, 113);
            this.txtBalance.Margin = new System.Windows.Forms.Padding(10);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.NextControl = null;
            this.txtBalance.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtBalance.Size = new System.Drawing.Size(112, 28);
            this.txtBalance.TabIndex = 8;
            this.txtBalance.Text = "0";
            this.txtBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBalance.Value = 0D;
            // 
            // lblBalance
            // 
            this.lblBalance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBalance.AutoSize = true;
            this.lblBalance.BackColor = System.Drawing.Color.Transparent;
            this.lblBalance.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.lblBalance.Location = new System.Drawing.Point(134, 115);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblBalance.Size = new System.Drawing.Size(48, 20);
            this.lblBalance.TabIndex = 25;
            this.lblBalance.Text = "موجودي";
            this.lblBalance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCrediting
            // 
            this.lblCrediting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCrediting.AutoSize = true;
            this.lblCrediting.BackColor = System.Drawing.Color.Transparent;
            this.lblCrediting.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.lblCrediting.Location = new System.Drawing.Point(306, 115);
            this.lblCrediting.Name = "lblCrediting";
            this.lblCrediting.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblCrediting.Size = new System.Drawing.Size(48, 20);
            this.lblCrediting.TabIndex = 23;
            this.lblCrediting.Text = "بستانكار";
            this.lblCrediting.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDebt
            // 
            this.lblDebt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDebt.AutoSize = true;
            this.lblDebt.BackColor = System.Drawing.Color.Transparent;
            this.lblDebt.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.lblDebt.Location = new System.Drawing.Point(498, 113);
            this.lblDebt.Name = "lblDebt";
            this.lblDebt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblDebt.Size = new System.Drawing.Size(41, 20);
            this.lblDebt.TabIndex = 21;
            this.lblDebt.Text = "بدهكار";
            this.lblDebt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAccountOwner
            // 
            this.txtAccountOwner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAccountOwner.BackColor = System.Drawing.Color.White;
            this.txtAccountOwner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAccountOwner.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.txtAccountOwner.ForeColor = System.Drawing.Color.Black;
            this.txtAccountOwner.Location = new System.Drawing.Point(545, 142);
            this.txtAccountOwner.Margin = new System.Windows.Forms.Padding(10);
            this.txtAccountOwner.Name = "txtAccountOwner";
            this.txtAccountOwner.NextControl = this.txtAddress;
            this.txtAccountOwner.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtAccountOwner.Size = new System.Drawing.Size(159, 28);
            this.txtAccountOwner.TabIndex = 4;
            this.txtAccountOwner.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblOwnerName
            // 
            this.lblOwnerName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOwnerName.AutoSize = true;
            this.lblOwnerName.BackColor = System.Drawing.Color.Transparent;
            this.lblOwnerName.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.lblOwnerName.Location = new System.Drawing.Point(713, 144);
            this.lblOwnerName.Name = "lblOwnerName";
            this.lblOwnerName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblOwnerName.Size = new System.Drawing.Size(77, 20);
            this.lblOwnerName.TabIndex = 4;
            this.lblOwnerName.Text = "صاحب حساب";
            this.lblOwnerName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            // dateControlBankAccount
            // 
            this.dateControlBankAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateControlBankAccount.BackColor = System.Drawing.Color.White;
            this.dateControlBankAccount.CanGoBackward = true;
            this.dateControlBankAccount.CanGoForward = false;
            this.dateControlBankAccount.Location = new System.Drawing.Point(584, 24);
            this.dateControlBankAccount.Name = "dateControlBankAccount";
            this.dateControlBankAccount.NextControl = this.txtBankAccountNumber;
            this.dateControlBankAccount.NowShamsi8Character = "97/06/14";
            this.dateControlBankAccount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateControlBankAccount.ShamsiNow = "1397/06/14";
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
            this.txtBankAccountNumber.Location = new System.Drawing.Point(545, 49);
            this.txtBankAccountNumber.Margin = new System.Windows.Forms.Padding(10);
            this.txtBankAccountNumber.Name = "txtBankAccountNumber";
            this.txtBankAccountNumber.NextControl = this.chkBankAccountType;
            this.txtBankAccountNumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtBankAccountNumber.Size = new System.Drawing.Size(159, 28);
            this.txtBankAccountNumber.TabIndex = 1;
            this.txtBankAccountNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBankAccountNumber.TextChanged += new System.EventHandler(this.txtBankAccountNumber_TextChanged);
            // 
            // txtBankAccountID
            // 
            this.txtBankAccountID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBankAccountID.BackColor = System.Drawing.Color.White;
            this.txtBankAccountID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBankAccountID.Enabled = false;
            this.txtBankAccountID.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.txtBankAccountID.ForeColor = System.Drawing.Color.Black;
            this.txtBankAccountID.Location = new System.Drawing.Point(13, 16);
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
            this.lblBankAccountID.Location = new System.Drawing.Point(80, 18);
            this.lblBankAccountID.Name = "lblBankAccountID";
            this.lblBankAccountID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblBankAccountID.Size = new System.Drawing.Size(56, 20);
            this.lblBankAccountID.TabIndex = 9;
            this.lblBankAccountID.Text = "كد حساب";
            this.lblBankAccountID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescription.AutoSize = true;
            this.lblDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblDescription.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.lblDescription.Location = new System.Drawing.Point(717, 176);
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
            this.lblBankAccountName.Location = new System.Drawing.Point(725, 51);
            this.lblBankAccountName.Name = "lblBankAccountName";
            this.lblBankAccountName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblBankAccountName.Size = new System.Drawing.Size(71, 20);
            this.lblBankAccountName.TabIndex = 7;
            this.lblBankAccountName.Text = "شماره حساب";
            this.lblBankAccountName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlButtons
            // 
            this.pnlButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlButtons.Controls.Add(this.btnRefresh);
            this.pnlButtons.Controls.Add(this.btnCancel);
            this.pnlButtons.Controls.Add(this.btnSave);
            this.pnlButtons.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.pnlButtons.Location = new System.Drawing.Point(13, 162);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlButtons.Size = new System.Drawing.Size(258, 40);
            this.pnlButtons.TabIndex = 3;
            // 
            // lblBalanceString
            // 
            this.lblBalanceString.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBalanceString.AutoSize = true;
            this.lblBalanceString.BackColor = System.Drawing.Color.Transparent;
            this.lblBalanceString.Font = new System.Drawing.Font("IRANSans(FaNum)", 7F);
            this.lblBalanceString.Location = new System.Drawing.Point(13, 142);
            this.lblBalanceString.Name = "lblBalanceString";
            this.lblBalanceString.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblBalanceString.Size = new System.Drawing.Size(64, 17);
            this.lblBalanceString.TabIndex = 39;
            this.lblBalanceString.Text = "مبلغ به حروف";
            this.lblBalanceString.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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

        private DataTable BankAccountListDataTable(List<ConnectionClasses.BankAccountList> bankAccountList)
        {
            var dataTable = ToolBox<ConnectionClasses.BankAccountList>.GetDataTable(bankAccountList);
            return dataTable;
        }

        private void ClearForm()
        {
            chkBankName.Checked = chkBankAccountType.Checked = false;
            txtBankAccountNumber.Text = txtBranch.Text = txtAccountOwner.Text = txtAddress.Text = txtDebt.Text = txtCrediting.Text = txtDescription.Text = string.Empty;
        }

        private void BankAccountDefinition_Load(object sender, EventArgs e)
        {
            var bankAccountList = @class.GetBankAccount(true);
            dgvBankAccount.DataSource = bankAccountList;//BankAccountListDataTable(bankAccountList);
            SetGridView();
            txtBankAccountID.Text = CalculateMaxId().ToString();
            ClearForm();
            txtBankAccountNumber.Focus();
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
            dgvBankAccount.Columns["BankNameName"].Visible = true;
            dgvBankAccount.Columns["AccountTypeName"].Visible = true;
            dgvBankAccount.Columns["Address"].Visible = true;
            dgvBankAccount.Columns["Branch"].Visible = true;
            dgvBankAccount.Columns["Phone1"].Visible = true;
            dgvBankAccount.Columns["Phone2"].Visible = true;
            dgvBankAccount.Columns["Description"].Visible = true;

            dgvBankAccount.Columns["ID"].HeaderText = "كد";
            dgvBankAccount.Columns["AccountNumber"].HeaderText = "شماره حساب";
            dgvBankAccount.Columns["AccountOwner"].HeaderText = "صاحب حساب";
            dgvBankAccount.Columns["BankNameName"].HeaderText = "نام بانك";
            dgvBankAccount.Columns["AccountTypeName"].HeaderText = "نوع حساب";
            dgvBankAccount.Columns["Address"].HeaderText = "آدرس";
            dgvBankAccount.Columns["Branch"].HeaderText = "شعبه";
            dgvBankAccount.Columns["Phone1"].HeaderText = "تلفن 1";
            dgvBankAccount.Columns["Phone2"].HeaderText = "تلفن 2";
            dgvBankAccount.Columns["Description"].HeaderText = "توضيحات";


            dgvBankAccount.Columns["ID"].DisplayIndex = 0;
            dgvBankAccount.Columns["AccountNumber"].DisplayIndex = 1;
            dgvBankAccount.Columns["AccountOwner"].DisplayIndex = 2;
            dgvBankAccount.Columns["BankNameName"].DisplayIndex = 3;
            dgvBankAccount.Columns["AccountTypeName"].DisplayIndex = 4;
            dgvBankAccount.Columns["Address"].DisplayIndex = 5;
            dgvBankAccount.Columns["Branch"].DisplayIndex = 6;
            dgvBankAccount.Columns["Phone1"].DisplayIndex = 7;
            dgvBankAccount.Columns["Phone2"].DisplayIndex = 8;
            dgvBankAccount.Columns["Description"].DisplayIndex = 9;

            dgvBankAccount.Columns["ID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvBankAccount.Columns["AccountNumber"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvBankAccount.Columns["AccountOwner"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvBankAccount.Columns["BankNameName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvBankAccount.Columns["AccountTypeName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvBankAccount.Columns["Address"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvBankAccount.Columns["Branch"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvBankAccount.Columns["Phone1"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvBankAccount.Columns["Phone2"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvBankAccount.Columns["Description"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvBankAccount.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvBankAccount.Columns["ID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvBankAccount.Columns["AccountNumber"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvBankAccount.Columns["AccountOwner"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvBankAccount.Columns["BankNameName"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvBankAccount.Columns["AccountTypeName"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvBankAccount.Columns["Address"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvBankAccount.Columns["Branch"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvBankAccount.Columns["Phone1"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvBankAccount.Columns["Phone2"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
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
            if (@class.GetBankAccount(true).Count(i => i.AccountNumber.Equals(txtBankAccountNumber.Text.Trim())) > 0)
            {
                CustomMessageForm.CustomMessageBox.Show("اخطار !", $"شماره حساب \"{txtBankAccountNumber.Text}\" تكراري است!", "e");
                txtBankAccountNumber.Focus();
                return false;
            }

            if (!chkBankAccountType.Checked)
            {
                CustomMessageForm.CustomMessageBox.Show("اخطار", "لطفا نوع حساب را انتخاب كنيد", "e");
                chkBankAccountType.Focus();
                return false;
            }

            if (!chkBankName.Checked)
            {
                CustomMessageForm.CustomMessageBox.Show("اخطار", "لطفا نام بانك را انتخاب كنيد", "e");
                chkBankName.Focus();
                return false;
            }

            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (FormValidate())
            {
                var result = @class.BankAccountDefinition(txtBankAccountNumber.Text, txtAccountOwner.Text, int.Parse(txtBankName.Tag.ToString()), txtDescription.Text, decimal.Parse(txtDebt.Text), decimal.Parse(txtCrediting.Text), dateControlBankAccount.ShamsiValue(), ConnectionClasses.DateServer.ReturnDateServer(), DateTime.Now.ToString("HH:mm:ss"), ConnectionClasses.DateServer.ServerTime(), ConnectionInfo.LoggedInUserId, txtAddress.Text, txtBranch.Text, txtPhone1.Text, txtPhone2.Text, int.Parse(txtBankAccountTypeName.Tag.ToString()));

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
        }

        private void txtBankAccountNumber_TextChanged(object sender, EventArgs e)
        {
            var BankAccountList = @class.GetBankAccount(true).Where(i => i.AccountNumber.Contains(txtBankAccountNumber.Text)).ToList();
            dgvBankAccount.DataSource = BankAccountList;//BankAccountListDataTable(BankAccountList);
        }

        private void chkBankAccountType_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBankAccountType.Checked)
            {
                var bankAccountTypeList = new List<BankAccountType>();
                new UserControlLoader(new BankAccountTypeSelect(bankAccountTypeList), true, false, true);

                if (bankAccountTypeList.Count > 0)
                {
                    txtBankAccountTypeName.Text = bankAccountTypeList.FirstOrDefault().Name;
                    txtBankAccountTypeName.Tag = bankAccountTypeList.FirstOrDefault().ID;
                    chkBankName.Focus();
                }
                else
                {
                    txtBankAccountTypeName.Text = "انتخاب نوع حساب ...";
                    txtBankAccountTypeName.Tag = string.Empty;
                    chkBankAccountType.Checked = false;
                    chkBankAccountType.Focus();
                }
            }
            else if (!chkBankAccountType.Checked)
            {
                txtBankAccountTypeName.Text = "انتخاب نوع حساب ...";
                txtBankAccountTypeName.Tag = string.Empty;
            }
        }

        private void chkBankName_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBankName.Checked)
            {
                var bankNameList = new List<BankName>();
                new UserControlLoader(new BankNameSelect(bankNameList), true, false, true);

                if (bankNameList.Count > 0)
                {
                    txtBankName.Text = bankNameList.FirstOrDefault().Name;
                    txtBankName.Tag = bankNameList.FirstOrDefault().ID;
                    txtDescription.Focus();
                    txtAccountOwner.Focus();
                }
                else
                {
                    txtBankName.Text = "انتخاب نام بانك ...";
                    txtBankName.Tag = string.Empty;
                    chkBankName.Checked = false;
                    chkBankName.Focus();
                }
            }
            else if (!chkBankName.Checked)
            {
                txtBankName.Text = "انتخاب نام بانك ...";
                txtBankName.Tag = string.Empty;
            }
        }

        private void CheckDebtCrediting()
        {
            string NumberToString = string.Empty;
            if (txtDebt.Text == "0" && txtCrediting.Text == "0")
            {
                txtDebt.Enabled = txtCrediting.Enabled = true;
                txtBalance.Text = "0";
                txtBalance.ForeColor = lblBalanceString.ForeColor = Color.Black;
                lblBalanceString.Text = "--";
            }

            if (txtDebt.Text != "0")
            {
                txtCrediting.Enabled = false;
                txtBalance.Text = txtDebt.Text;
                NumberToString = @class.ConvertNumberToString(txtBalance.Text,true);
                txtBalance.ForeColor = lblBalanceString.ForeColor = Color.Green;
                lblBalanceString.Text = $"{NumberToString} بدهكار";
            }
            else if (txtCrediting.Text != "0")
            {
                txtDebt.Enabled = false;
                txtBalance.Text = txtCrediting.Text;
                NumberToString = @class.ConvertNumberToString(txtBalance.Text,true);
                txtBalance.ForeColor = lblBalanceString.ForeColor = Color.Red;
                lblBalanceString.Text = $"{NumberToString} بستانكار";
            }
        }

        private void txtDebt_TextChanged(object sender, EventArgs e)
        {
            CheckDebtCrediting();
        }

        private void txtCrediting_TextChanged(object sender, EventArgs e)
        {
            CheckDebtCrediting();
        }
    }
}
