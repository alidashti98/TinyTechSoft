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
    public class BankAccountTypeDefinition : TinyTech.UI.Control.UIElement.UserControl
    {
        #region Region 
        private UI.Control.UIElement.Panel pnlBankAccountTypeDefinition;
        private UI.Control.UIElement.GroupBox groupBoxBankAccountTypeDefinition;
        private UI.Control.UIElement.Panel pnlButtons;
        private UI.Control.Button.RefreshButton btnRefresh;
        private UI.Control.Button.CancelButton btnCancel;
        private UI.Control.Button.SaveButton btnSave;
        private UI.Control.UIElement.Panel pnlMain;
        private UI.Control.UIElement.DataGridView dgvBankAccountType;
        ConnectionClasses @class = new ConnectionClasses();
        TabManagement @tab = new TabManagement();
        private int MaxID;
        private UI.Control.Label.Label lblBankAccountTypeID;
        private UI.Control.Label.Label lblDescription;
        private UI.Control.TextBox.TextBox txtDescription;
        private UI.Control.TextBox.TextBox txtBankAccountTypeName;
        private UI.Control.TextBox.NumericTextBoxWithSeperator txtBankAccountTypeID;
        private int MaxID_;
        TinyTechEntities DB_Connection = new TinyTechEntities();
        private UI.Control.TextBox.DateControl dateControlBankAccountType;
        private UI.Control.Label.Label lblDate;
        private UI.Control.Label.Label lblBankAccountTypeName;
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

        public BankAccountTypeDefinition()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.pnlMain = new TinyTech.UI.Control.UIElement.Panel();
            this.dgvBankAccountType = new TinyTech.UI.Control.UIElement.DataGridView();
            this.pnlBankAccountTypeDefinition = new TinyTech.UI.Control.UIElement.Panel();
            this.groupBoxBankAccountTypeDefinition = new TinyTech.UI.Control.UIElement.GroupBox();
            this.btnSave = new TinyTech.UI.Control.Button.SaveButton();
            this.btnRefresh = new TinyTech.UI.Control.Button.RefreshButton();
            this.btnCancel = new TinyTech.UI.Control.Button.CancelButton();
            this.dateControlBankAccountType = new TinyTech.UI.Control.TextBox.DateControl();
            this.txtBankAccountTypeName = new TinyTech.UI.Control.TextBox.TextBox();
            this.txtDescription = new TinyTech.UI.Control.TextBox.TextBox();
            this.lblDate = new TinyTech.UI.Control.Label.Label();
            this.txtBankAccountTypeID = new TinyTech.UI.Control.TextBox.NumericTextBoxWithSeperator();
            this.lblBankAccountTypeID = new TinyTech.UI.Control.Label.Label();
            this.lblDescription = new TinyTech.UI.Control.Label.Label();
            this.lblBankAccountTypeName = new TinyTech.UI.Control.Label.Label();
            this.pnlButtons = new TinyTech.UI.Control.UIElement.Panel();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBankAccountType)).BeginInit();
            this.pnlBankAccountTypeDefinition.SuspendLayout();
            this.groupBoxBankAccountTypeDefinition.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.dgvBankAccountType);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.pnlMain.Location = new System.Drawing.Point(0, 138);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlMain.Size = new System.Drawing.Size(800, 362);
            this.pnlMain.TabIndex = 1;
            // 
            // dgvBankAccountType
            // 
            this.dgvBankAccountType.AllowUserToAddRows = false;
            this.dgvBankAccountType.AllowUserToDeleteRows = false;
            this.dgvBankAccountType.AllowUserToOrderColumns = true;
            this.dgvBankAccountType.AllowUserToResizeColumns = false;
            this.dgvBankAccountType.AllowUserToResizeRows = false;
            this.dgvBankAccountType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBankAccountType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBankAccountType.Location = new System.Drawing.Point(0, 0);
            this.dgvBankAccountType.MultiSelect = false;
            this.dgvBankAccountType.Name = "dgvBankAccountType";
            this.dgvBankAccountType.ReadOnly = true;
            this.dgvBankAccountType.RowHeadersVisible = false;
            this.dgvBankAccountType.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvBankAccountType.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBankAccountType.Size = new System.Drawing.Size(800, 362);
            this.dgvBankAccountType.TabIndex = 1;
            // 
            // pnlBankAccountTypeDefinition
            // 
            this.pnlBankAccountTypeDefinition.Controls.Add(this.groupBoxBankAccountTypeDefinition);
            this.pnlBankAccountTypeDefinition.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBankAccountTypeDefinition.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.pnlBankAccountTypeDefinition.Location = new System.Drawing.Point(0, 0);
            this.pnlBankAccountTypeDefinition.Name = "pnlBankAccountTypeDefinition";
            this.pnlBankAccountTypeDefinition.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlBankAccountTypeDefinition.Size = new System.Drawing.Size(800, 138);
            this.pnlBankAccountTypeDefinition.TabIndex = 0;
            // 
            // groupBoxBankAccountTypeDefinition
            // 
            this.groupBoxBankAccountTypeDefinition.Controls.Add(this.lblDate);
            this.groupBoxBankAccountTypeDefinition.Controls.Add(this.dateControlBankAccountType);
            this.groupBoxBankAccountTypeDefinition.Controls.Add(this.txtBankAccountTypeID);
            this.groupBoxBankAccountTypeDefinition.Controls.Add(this.txtDescription);
            this.groupBoxBankAccountTypeDefinition.Controls.Add(this.txtBankAccountTypeName);
            this.groupBoxBankAccountTypeDefinition.Controls.Add(this.lblBankAccountTypeID);
            this.groupBoxBankAccountTypeDefinition.Controls.Add(this.lblDescription);
            this.groupBoxBankAccountTypeDefinition.Controls.Add(this.lblBankAccountTypeName);
            this.groupBoxBankAccountTypeDefinition.Controls.Add(this.pnlButtons);
            this.groupBoxBankAccountTypeDefinition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxBankAccountTypeDefinition.Location = new System.Drawing.Point(0, 0);
            this.groupBoxBankAccountTypeDefinition.Name = "groupBoxBankAccountTypeDefinition";
            this.groupBoxBankAccountTypeDefinition.Size = new System.Drawing.Size(800, 138);
            this.groupBoxBankAccountTypeDefinition.TabIndex = 0;
            this.groupBoxBankAccountTypeDefinition.TabStop = false;
            this.groupBoxBankAccountTypeDefinition.Text = "تعريف نوع حساب";
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
            this.btnCancel.NextControl = this.dateControlBankAccountType;
            this.btnCancel.Size = new System.Drawing.Size(81, 34);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "انصراف";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dateControlBankAccountType
            // 
            this.dateControlBankAccountType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateControlBankAccountType.BackColor = System.Drawing.Color.White;
            this.dateControlBankAccountType.CanGoBackward = true;
            this.dateControlBankAccountType.CanGoForward = false;
            this.dateControlBankAccountType.Location = new System.Drawing.Point(584, 24);
            this.dateControlBankAccountType.Name = "dateControlBankAccountType";
            this.dateControlBankAccountType.NextControl = this.txtBankAccountTypeName;
            this.dateControlBankAccountType.NowShamsi8Character = "97/06/14";
            this.dateControlBankAccountType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateControlBankAccountType.ShamsiNow = "1397/06/14";
            this.dateControlBankAccountType.Size = new System.Drawing.Size(120, 20);
            this.dateControlBankAccountType.TabIndex = 0;
            this.dateControlBankAccountType.Text = "dateControl1";
            this.dateControlBankAccountType.Value10Cahracter = null;
            // 
            // txtBankAccountTypeName
            // 
            this.txtBankAccountTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBankAccountTypeName.BackColor = System.Drawing.Color.White;
            this.txtBankAccountTypeName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBankAccountTypeName.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.txtBankAccountTypeName.ForeColor = System.Drawing.Color.Black;
            this.txtBankAccountTypeName.Location = new System.Drawing.Point(504, 57);
            this.txtBankAccountTypeName.Margin = new System.Windows.Forms.Padding(10);
            this.txtBankAccountTypeName.Name = "txtBankAccountTypeName";
            this.txtBankAccountTypeName.NextControl = this.txtDescription;
            this.txtBankAccountTypeName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtBankAccountTypeName.Size = new System.Drawing.Size(200, 28);
            this.txtBankAccountTypeName.TabIndex = 1;
            this.txtBankAccountTypeName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBankAccountTypeName.TextChanged += new System.EventHandler(this.BankAccountTypeName_TextChanged);
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
            this.txtDescription.NextControl = this.btnSave;
            this.txtDescription.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDescription.Size = new System.Drawing.Size(200, 28);
            this.txtDescription.TabIndex = 2;
            this.txtDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // txtBankAccountTypeID
            // 
            this.txtBankAccountTypeID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBankAccountTypeID.BackColor = System.Drawing.Color.White;
            this.txtBankAccountTypeID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBankAccountTypeID.Enabled = false;
            this.txtBankAccountTypeID.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.txtBankAccountTypeID.ForeColor = System.Drawing.Color.Black;
            this.txtBankAccountTypeID.Location = new System.Drawing.Point(342, 57);
            this.txtBankAccountTypeID.Margin = new System.Windows.Forms.Padding(10);
            this.txtBankAccountTypeID.Name = "txtBankAccountTypeID";
            this.txtBankAccountTypeID.NextControl = null;
            this.txtBankAccountTypeID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtBankAccountTypeID.Size = new System.Drawing.Size(54, 28);
            this.txtBankAccountTypeID.TabIndex = 12;
            this.txtBankAccountTypeID.Text = "0";
            this.txtBankAccountTypeID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBankAccountTypeID.Value = 0D;
            // 
            // lblBankAccountTypeID
            // 
            this.lblBankAccountTypeID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBankAccountTypeID.AutoSize = true;
            this.lblBankAccountTypeID.BackColor = System.Drawing.Color.Transparent;
            this.lblBankAccountTypeID.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.lblBankAccountTypeID.Location = new System.Drawing.Point(409, 59);
            this.lblBankAccountTypeID.Name = "lblBankAccountTypeID";
            this.lblBankAccountTypeID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblBankAccountTypeID.Size = new System.Drawing.Size(82, 20);
            this.lblBankAccountTypeID.TabIndex = 9;
            this.lblBankAccountTypeID.Text = "كد نوع حساب :";
            this.lblBankAccountTypeID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // lblBankAccountTypeName
            // 
            this.lblBankAccountTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBankAccountTypeName.AutoSize = true;
            this.lblBankAccountTypeName.BackColor = System.Drawing.Color.Transparent;
            this.lblBankAccountTypeName.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.lblBankAccountTypeName.Location = new System.Drawing.Point(717, 59);
            this.lblBankAccountTypeName.Name = "lblBankAccountTypeName";
            this.lblBankAccountTypeName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblBankAccountTypeName.Size = new System.Drawing.Size(28, 20);
            this.lblBankAccountTypeName.TabIndex = 7;
            this.lblBankAccountTypeName.Text = "نام :";
            this.lblBankAccountTypeName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // BankAccountTypeDefinition
            // 
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlBankAccountTypeDefinition);
            this.Name = "BankAccountTypeDefinition";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(800, 500);
            this.Tag = "تعريف شماره حساب";
            this.Load += new System.EventHandler(this.BankAccountTypeDefinition_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BankAccountTypeDefinition_KeyDown);
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBankAccountType)).EndInit();
            this.pnlBankAccountTypeDefinition.ResumeLayout(false);
            this.groupBoxBankAccountTypeDefinition.ResumeLayout(false);
            this.groupBoxBankAccountTypeDefinition.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            @tab.CloseTab(this);
        }

        private DataTable BankAccountListDataTable(List<BankAccountType> bankAccountTypeList)
        {
            var dataTable = ToolBox<BankAccountType>.GetDataTable(bankAccountTypeList);
            return dataTable;
        }

        private void ClearForm()
        {
            txtBankAccountTypeName.Text = txtDescription.Text = string.Empty;
        }

        private void BankAccountTypeDefinition_Load(object sender, EventArgs e)
        {
            var bankAccountTypeList = @class.GetBankAccountType(true);
            dgvBankAccountType.DataSource = bankAccountTypeList;//BankAccountListDataTable(bankAccountTypeList);
            SetGridView();
            txtBankAccountTypeID.Text = CalculateMaxId().ToString();
            ClearForm();
            txtBankAccountTypeName.Focus();
        }

        private int CalculateMaxId()
        {
            if (@class.GetBankAccountType().Count <= 0) return 1;
            var max = @class.GetBankAccountType().Max(i => i.ID) + 1;
            return max;
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

            dgvBankAccountType.Columns["ID"].HeaderText = "كد";
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

        private void BankAccountTypeDefinition_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                @tab.CloseTab(this);
            }
        }

        private bool FormValidate()
        {
            if (string.IsNullOrWhiteSpace(txtBankAccountTypeName.Text))
            {
                CustomMessageForm.CustomMessageBox.Show("اخطار", "لطفا نوع حساب را وارد كنيد", "e");
                txtBankAccountTypeName.Focus();
                return false;
            }
            if (@class.GetBankAccountType(true).Count(i => i.Name.Equals(txtBankAccountTypeName.Text.Trim())) > 0)
            {
                CustomMessageForm.CustomMessageBox.Show("اخطار !", $"شماره حساب \"{txtBankAccountTypeName.Text}\" تكراري است!", "e");
                txtBankAccountTypeName.Focus();
                return false;
            }

            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (FormValidate())
            {
                var result = @class.BankAccountTypeDefinition(txtBankAccountTypeName.Text, txtDescription.Text, dateControlBankAccountType.ShamsiValue(), ConnectionClasses.DateServer.ReturnDateServer(), DateTime.Now.ToString("HH:mm:ss"), ConnectionClasses.DateServer.ServerTime(), ConnectionInfo.LoggedInUserId);

                if (result > 0)
                {
                    CustomMessageForm.CustomMessageBox.Show("پيغام سيستم", $"نوع حساب \"{txtBankAccountTypeName.Text}\" با موفقيت ثبت شد", "i");
                    MaxID_ = result;
                    if (int.Parse(txtBankAccountTypeID.Text) != MaxID_)
                    {
                        CustomMessageForm.CustomMessageBox.Show("پيغام سيستم", $"كد نوع حساب به {MaxID_} تغيير يافت", "i");
                    }
                    RefreshForm();
                }
                else if (result == 0)
                {
                    CustomMessageForm.CustomMessageBox.Show("خطا !", $"خطا در تعريف نوع حساب!\n\nلطفا جهت بررسي مشكل با پشتيباني تماس بگيريد", "e");
                }
            }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshForm();
            txtBankAccountTypeName.Focus();
        }

        private void RefreshForm()
        {
            BankAccountTypeDefinition_Load(null, null);
        }

        private void BankAccountTypeName_TextChanged(object sender, EventArgs e)
        {
            var bankAccountTypeList = @class.GetBankAccountType(true).Where(i => i.Name.Contains(txtBankAccountTypeName.Text)).ToList();
            dgvBankAccountType.DataSource = bankAccountTypeList;//BankAccountListDataTable(bankAccountTypeList);
        }
    }
}
