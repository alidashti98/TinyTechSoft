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
    public class BankNameDefinition : UserControl
    {
        #region Region 
        private UI.Control.UIElement.Panel pnlBankNameDefinition;
        private UI.Control.UIElement.GroupBox groupBoxBankNameDefinition;
        private UI.Control.UIElement.Panel pnlButtons;
        private UI.Control.Button.RefreshButton btnRefresh;
        private UI.Control.Button.CancelButton btnCancel;
        private UI.Control.Button.SaveButton btnSave;
        private UI.Control.UIElement.Panel pnlMain;
        private UI.Control.UIElement.DataGridView dgvBankName;
        ConnectionClasses @class = new ConnectionClasses();
        TabManagement @tab = new TabManagement();
        private int MaxID;
        private UI.Control.Label.Label lblBankNameID;
        private UI.Control.Label.Label lblDescription;
        private UI.Control.TextBox.TextBox txtDescription;
        private UI.Control.TextBox.TextBox txtBankNameName;
        private UI.Control.TextBox.NumericTextBoxWithSeperator txtBankNameID;
        private int MaxID_;
        TinyTechEntities DB_Connection = new TinyTechEntities();
        private UI.Control.TextBox.DateControl dateControlBankName;
        private UI.Control.Label.Label lblDate;
        private UI.Control.Label.Label lblBankNameName;
        private UI.Control.Label.Label lblEditMode;
        private string OldBankNameForEdit = string.Empty;
        private bool EditMode = false;
        private UI.Control.Button.DeleteButton btnDelete;
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

        public BankNameDefinition()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.pnlMain = new TinyTech.UI.Control.UIElement.Panel();
            this.dgvBankName = new TinyTech.UI.Control.UIElement.DataGridView();
            this.pnlBankNameDefinition = new TinyTech.UI.Control.UIElement.Panel();
            this.groupBoxBankNameDefinition = new TinyTech.UI.Control.UIElement.GroupBox();
            this.lblEditMode = new TinyTech.UI.Control.Label.Label();
            this.lblDate = new TinyTech.UI.Control.Label.Label();
            this.dateControlBankName = new TinyTech.UI.Control.TextBox.DateControl();
            this.txtBankNameName = new TinyTech.UI.Control.TextBox.TextBox();
            this.txtDescription = new TinyTech.UI.Control.TextBox.TextBox();
            this.btnSave = new TinyTech.UI.Control.Button.SaveButton();
            this.btnRefresh = new TinyTech.UI.Control.Button.RefreshButton();
            this.btnCancel = new TinyTech.UI.Control.Button.CancelButton();
            this.txtBankNameID = new TinyTech.UI.Control.TextBox.NumericTextBoxWithSeperator();
            this.lblBankNameID = new TinyTech.UI.Control.Label.Label();
            this.lblDescription = new TinyTech.UI.Control.Label.Label();
            this.lblBankNameName = new TinyTech.UI.Control.Label.Label();
            this.pnlButtons = new TinyTech.UI.Control.UIElement.Panel();
            this.btnDelete = new TinyTech.UI.Control.Button.DeleteButton();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBankName)).BeginInit();
            this.pnlBankNameDefinition.SuspendLayout();
            this.groupBoxBankNameDefinition.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.dgvBankName);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.pnlMain.Location = new System.Drawing.Point(0, 140);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlMain.Size = new System.Drawing.Size(800, 360);
            this.pnlMain.TabIndex = 1;
            // 
            // dgvBankName
            // 
            this.dgvBankName.AllowUserToAddRows = false;
            this.dgvBankName.AllowUserToDeleteRows = false;
            this.dgvBankName.AllowUserToOrderColumns = true;
            this.dgvBankName.AllowUserToResizeColumns = false;
            this.dgvBankName.AllowUserToResizeRows = false;
            this.dgvBankName.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBankName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBankName.Location = new System.Drawing.Point(0, 0);
            this.dgvBankName.MultiSelect = false;
            this.dgvBankName.Name = "dgvBankName";
            this.dgvBankName.ReadOnly = true;
            this.dgvBankName.RowHeadersVisible = false;
            this.dgvBankName.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvBankName.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBankName.Size = new System.Drawing.Size(800, 360);
            this.dgvBankName.TabIndex = 1;
            this.dgvBankName.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBankName_CellClick);
            // 
            // pnlBankNameDefinition
            // 
            this.pnlBankNameDefinition.Controls.Add(this.groupBoxBankNameDefinition);
            this.pnlBankNameDefinition.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBankNameDefinition.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.pnlBankNameDefinition.Location = new System.Drawing.Point(0, 0);
            this.pnlBankNameDefinition.Name = "pnlBankNameDefinition";
            this.pnlBankNameDefinition.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlBankNameDefinition.Size = new System.Drawing.Size(800, 140);
            this.pnlBankNameDefinition.TabIndex = 0;
            // 
            // groupBoxBankNameDefinition
            // 
            this.groupBoxBankNameDefinition.Controls.Add(this.lblEditMode);
            this.groupBoxBankNameDefinition.Controls.Add(this.lblDate);
            this.groupBoxBankNameDefinition.Controls.Add(this.dateControlBankName);
            this.groupBoxBankNameDefinition.Controls.Add(this.txtBankNameID);
            this.groupBoxBankNameDefinition.Controls.Add(this.txtDescription);
            this.groupBoxBankNameDefinition.Controls.Add(this.txtBankNameName);
            this.groupBoxBankNameDefinition.Controls.Add(this.lblBankNameID);
            this.groupBoxBankNameDefinition.Controls.Add(this.lblDescription);
            this.groupBoxBankNameDefinition.Controls.Add(this.lblBankNameName);
            this.groupBoxBankNameDefinition.Controls.Add(this.pnlButtons);
            this.groupBoxBankNameDefinition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxBankNameDefinition.Location = new System.Drawing.Point(0, 0);
            this.groupBoxBankNameDefinition.Name = "groupBoxBankNameDefinition";
            this.groupBoxBankNameDefinition.Size = new System.Drawing.Size(800, 140);
            this.groupBoxBankNameDefinition.TabIndex = 0;
            this.groupBoxBankNameDefinition.TabStop = false;
            this.groupBoxBankNameDefinition.Text = "تعريف نام بانك";
            // 
            // lblEditMode
            // 
            this.lblEditMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEditMode.AutoSize = true;
            this.lblEditMode.BackColor = System.Drawing.Color.Red;
            this.lblEditMode.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F, System.Drawing.FontStyle.Bold);
            this.lblEditMode.ForeColor = System.Drawing.Color.White;
            this.lblEditMode.Location = new System.Drawing.Point(182, 59);
            this.lblEditMode.Name = "lblEditMode";
            this.lblEditMode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblEditMode.Size = new System.Drawing.Size(79, 20);
            this.lblEditMode.TabIndex = 14;
            this.lblEditMode.Text = "در حال ويرايش";
            this.lblEditMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.lblDate.Location = new System.Drawing.Point(731, 24);
            this.lblDate.Name = "lblDate";
            this.lblDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblDate.Size = new System.Drawing.Size(40, 20);
            this.lblDate.TabIndex = 13;
            this.lblDate.Text = "تاريخ :";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateControlBankName
            // 
            this.dateControlBankName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateControlBankName.BackColor = System.Drawing.Color.White;
            this.dateControlBankName.CanGoBackward = true;
            this.dateControlBankName.CanGoForward = false;
            this.dateControlBankName.Location = new System.Drawing.Point(598, 24);
            this.dateControlBankName.Name = "dateControlBankName";
            this.dateControlBankName.NextControl = this.txtBankNameName;
            this.dateControlBankName.NowShamsi8Character = "97/06/14";
            this.dateControlBankName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateControlBankName.ShamsiNow = "1397/06/14";
            this.dateControlBankName.Size = new System.Drawing.Size(120, 20);
            this.dateControlBankName.TabIndex = 0;
            this.dateControlBankName.Text = "dateControl1";
            this.dateControlBankName.Value10Cahracter = null;
            // 
            // txtBankNameName
            // 
            this.txtBankNameName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBankNameName.BackColor = System.Drawing.Color.White;
            this.txtBankNameName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBankNameName.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.txtBankNameName.ForeColor = System.Drawing.Color.Black;
            this.txtBankNameName.Location = new System.Drawing.Point(518, 57);
            this.txtBankNameName.Margin = new System.Windows.Forms.Padding(10);
            this.txtBankNameName.Name = "txtBankNameName";
            this.txtBankNameName.NextControl = this.txtDescription;
            this.txtBankNameName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtBankNameName.Size = new System.Drawing.Size(200, 28);
            this.txtBankNameName.TabIndex = 1;
            this.txtBankNameName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBankNameName.TextChanged += new System.EventHandler(this.txtBankNameName_TextChanged);
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.BackColor = System.Drawing.Color.White;
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescription.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.txtDescription.ForeColor = System.Drawing.Color.Black;
            this.txtDescription.Location = new System.Drawing.Point(381, 100);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(10);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.NextControl = this.btnSave;
            this.txtDescription.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDescription.Size = new System.Drawing.Size(337, 28);
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
            this.btnSave.Location = new System.Drawing.Point(172, 3);
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
            this.btnRefresh.Location = new System.Drawing.Point(87, 3);
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
            this.btnCancel.Location = new System.Drawing.Point(2, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.NextControl = this.dateControlBankName;
            this.btnCancel.Size = new System.Drawing.Size(81, 34);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "انصراف";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtBankNameID
            // 
            this.txtBankNameID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBankNameID.BackColor = System.Drawing.Color.White;
            this.txtBankNameID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBankNameID.Enabled = false;
            this.txtBankNameID.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.txtBankNameID.ForeColor = System.Drawing.Color.Black;
            this.txtBankNameID.Location = new System.Drawing.Point(381, 57);
            this.txtBankNameID.Margin = new System.Windows.Forms.Padding(10);
            this.txtBankNameID.Name = "txtBankNameID";
            this.txtBankNameID.NextControl = null;
            this.txtBankNameID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtBankNameID.Size = new System.Drawing.Size(54, 28);
            this.txtBankNameID.TabIndex = 12;
            this.txtBankNameID.Text = "0";
            this.txtBankNameID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBankNameID.Value = 0D;
            // 
            // lblBankNameID
            // 
            this.lblBankNameID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBankNameID.AutoSize = true;
            this.lblBankNameID.BackColor = System.Drawing.Color.Transparent;
            this.lblBankNameID.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.lblBankNameID.Location = new System.Drawing.Point(448, 59);
            this.lblBankNameID.Name = "lblBankNameID";
            this.lblBankNameID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblBankNameID.Size = new System.Drawing.Size(68, 20);
            this.lblBankNameID.TabIndex = 9;
            this.lblBankNameID.Text = "كد نام بانك :";
            this.lblBankNameID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescription.AutoSize = true;
            this.lblDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblDescription.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.lblDescription.Location = new System.Drawing.Point(731, 102);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblDescription.Size = new System.Drawing.Size(60, 20);
            this.lblDescription.TabIndex = 8;
            this.lblDescription.Text = "توضيحات :";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBankNameName
            // 
            this.lblBankNameName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBankNameName.AutoSize = true;
            this.lblBankNameName.BackColor = System.Drawing.Color.Transparent;
            this.lblBankNameName.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.lblBankNameName.Location = new System.Drawing.Point(731, 59);
            this.lblBankNameName.Name = "lblBankNameName";
            this.lblBankNameName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblBankNameName.Size = new System.Drawing.Size(53, 20);
            this.lblBankNameName.TabIndex = 7;
            this.lblBankNameName.Text = "نام بانك :";
            this.lblBankNameName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlButtons
            // 
            this.pnlButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlButtons.Controls.Add(this.btnDelete);
            this.pnlButtons.Controls.Add(this.btnRefresh);
            this.pnlButtons.Controls.Add(this.btnCancel);
            this.pnlButtons.Controls.Add(this.btnSave);
            this.pnlButtons.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.pnlButtons.Location = new System.Drawing.Point(6, 88);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlButtons.Size = new System.Drawing.Size(341, 40);
            this.pnlButtons.TabIndex = 3;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.btnDelete.ForeColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(257, 3);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(10);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.NextControl = null;
            this.btnDelete.Size = new System.Drawing.Size(81, 34);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "حذف";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // BankNameDefinition
            // 
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlBankNameDefinition);
            this.Name = "BankNameDefinition";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(800, 500);
            this.Tag = "تعريف نام بانك";
            this.Load += new System.EventHandler(this.BankNameDefinition_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BankNameDefinition_KeyDown);
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBankName)).EndInit();
            this.pnlBankNameDefinition.ResumeLayout(false);
            this.groupBoxBankNameDefinition.ResumeLayout(false);
            this.groupBoxBankNameDefinition.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (!EditMode)
            {
                @tab.CloseTab(this);
            }
            else if (EditMode)
            {
                RefreshForm();
            }
        }

        private DataTable BankNameListDataTable(List<BankName> BankNameList)
        {
            var dataTable = UI.Control.UIElement.ToolBox<BankName>.GetDataTable(BankNameList);
            return dataTable;
        }

        private void ClearForm()
        {
            txtBankNameName.Text = txtDescription.Text = string.Empty;
            SetEditMode(false);
        }

        private void BankNameDefinition_Load(object sender, EventArgs e)
        {
            var bankNameList = @class.GetBankName(true).ToList();
            dgvBankName.DataSource = bankNameList;//BankNameListDataTable(bankNameList);
            SetGridView();
            txtBankNameID.Text = CalculateMaxId().ToString();
            ClearForm();
            txtBankNameName.Focus();
        }

        private int CalculateMaxId()
        {
            if (@class.GetBankName().Count <= 0) return 1;
            return @class.GetBankName().Max(i => i.ID) + 1;
        }

        private void SetGridView()
        {
            foreach (DataGridViewColumn item in dgvBankName.Columns)
            {
                item.Visible = false;
            }
            dgvBankName.Columns["ID"].Visible = true;
            dgvBankName.Columns["Name"].Visible = true;
            dgvBankName.Columns["Description"].Visible = true;

            dgvBankName.Columns["ID"].HeaderText = "كد";
            dgvBankName.Columns["Name"].HeaderText = "نام";
            dgvBankName.Columns["Description"].HeaderText = "توضيحات";


            dgvBankName.Columns["ID"].DisplayIndex = 0;
            dgvBankName.Columns["Name"].DisplayIndex = 1;
            dgvBankName.Columns["Description"].DisplayIndex = 3;

            dgvBankName.Columns["ID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvBankName.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvBankName.Columns["Description"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvBankName.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvBankName.Columns["ID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvBankName.Columns["Name"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvBankName.Columns["Description"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            dgvBankName.AutoGenerateColumns = false;

        }

        private void BankNameDefinition_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                @tab.CloseTab(this);
            }
        }

        private bool FormValidate(bool Edit)
        {
            if (string.IsNullOrWhiteSpace(txtBankNameName.Text))
            {
                CustomMessageForm.CustomMessageBox.Show("اخطار", "لطفا نام بانك را وارد كنيد", "e");
                txtBankNameName.Focus();
                return false;
            }
            if (!Edit && (@class.GetBankName(true).Count(i => i.Name.Equals(txtBankNameName.Text.Trim())) > 0))
            {
                CustomMessageForm.CustomMessageBox.Show("اخطار !", $"نام بانك \"{txtBankNameName.Text}\" تكراري است!", "e");
                txtBankNameName.Focus();
                return false;
            }
            if (Edit && (@class.GetBankName(true).Count(i => i.Name.Equals(txtBankNameName.Text.Trim()) && i.Name != OldBankNameForEdit) > 0))
            {
                CustomMessageForm.CustomMessageBox.Show("اخطار !", $"نام بانك \"{txtBankNameName.Text}\" تكراري است!", "e");
                txtBankNameName.Focus();
                return false;
            }
            return true;
        }

        private void SaveProcess(bool Edit)
        {
            if (FormValidate(Edit))
            {
                if (!Edit)
                {
                    var result = @class.BankNameDefinition(txtBankNameName.Text, txtDescription.Text, dateControlBankName.ShamsiValue(), ConnectionClasses.DateServer.ReturnDateServer(), DateTime.Now.ToString("HH:mm:ss"), ConnectionClasses.DateServer.ServerTime(), ConnectionInfo.LoggedInUserId);

                    if (result > 0)
                    {
                        CustomMessageForm.CustomMessageBox.Show("پيغام سيستم", $"نام بانك \"{txtBankNameName.Text}\" با موفقيت ثبت شد", "i");
                        MaxID_ = result;
                        if (int.Parse(txtBankNameID.Text) != MaxID_)
                        {
                            CustomMessageForm.CustomMessageBox.Show("پيغام سيستم", $"كد نام بانك به {MaxID_} تغيير يافت", "i");
                        }
                        RefreshForm();
                    }
                    else if (result == 0)
                    {
                        CustomMessageForm.CustomMessageBox.Show("خطا !", $"خطا در تعريف نام بانك!\n\nلطفا جهت بررسي مشكل با پشتيباني تماس بگيريد", "e");
                    }
                }
                else if (Edit)
                {
                    bool result = @class.BankNameModify(int.Parse(txtBankNameID.Text), txtBankNameName.Text, txtDescription.Text);
                    if (result)
                    {
                        CustomMessageForm.CustomMessageBox.Show("پيغام سيستم", $"ويرايش نام بانك با موفقيت انجام شد", "i");
                        RefreshForm();
                    }
                    else if (!result)
                    {
                        CustomMessageForm.CustomMessageBox.Show("خطا !", $"خطا در ويرايش نام بانك!\n\nلطفا جهت بررسي مشكل با پشتيباني تماس بگيريد", "e");
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (EditMode)
            {
                SaveProcess(true);
            }
            else if (!EditMode)
            {
                SaveProcess(false);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshForm();
            txtBankNameName.Focus();
        }

        private void RefreshForm()
        {
            BankNameDefinition_Load(null, null);
        }

        private void txtBankNameName_TextChanged(object sender, EventArgs e)
        {
            var bankNameList = @class.GetBankName(true).Where(i => i.Name.Contains(txtBankNameName.Text)).ToList();
            dgvBankName.DataSource = bankNameList;//BankNameListDataTable(bankNameList);
        }

        private void SetEditMode(bool Status)
        {
            lblEditMode.Visible = btnDelete.Visible = Status;

            if (Status)
            {
                BankName bankNameList = (BankName)dgvBankName.CurrentRow.DataBoundItem;
                txtBankNameID.Text = bankNameList.ID.ToString();
                txtBankNameName.Text = bankNameList.Name;
                txtDescription.Text = bankNameList.Description;
                OldBankNameForEdit = txtBankNameName.Text;
                btnSave.Text = "ثبت تغييرات";
                EditMode = true;
            }
            if (!Status)
            {
                OldBankNameForEdit = string.Empty;
                btnSave.Text = "ثبت";
                EditMode = false;
            }
        }

        private void dgvBankName_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ConnectionClasses.CheckUserPermission(ConnectionInfo.LoggedInUserId, 1))
            {
                if (dgvBankName.DataSource != null && dgvBankName.SelectedRows.Count > 0)
                {
                    SetEditMode(true);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MessageBoxWarning.State = 0;
            if (CustomMessageForm.CustomMessageBox.Show("خروج", "نام بانك مورد نظر حذف شود؟", "w") == DialogResult.Yes)
            {
                if (ConnectionClasses.CheckBeforeDelete(this.Name, int.Parse(txtBankNameID.Text)))
                {
                    bool Result = @class.BankNameDelete(int.Parse(txtBankNameID.Text));

                    if (Result)
                    {
                        CustomMessageForm.CustomMessageBox.Show("پيغام سيستم", $"نام بانك مورد نظر با موفقيت حذف شد", "i");
                        RefreshForm();
                    }
                    else if (!Result)
                    {
                        CustomMessageForm.CustomMessageBox.Show("خطا !", $"خطا در حذف نام بانك!\n\nلطفا جهت بررسي مشكل با پشتيباني تماس بگيريد", "e");
                    }
                }
                else
                {
                    CustomMessageForm.CustomMessageBox.Show("اخطار !", "نام بانك انتخاب شده در حال حاضر در حال استفاده ميباشد و امكان حذف آن وجود ندارد!", "e");
                }
            }
            MessageBoxWarning.State = 1;
        }
    }
}
