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
    public class CustomerGroupDefinition : UserControl
    {
        #region Region 
        private UI.Control.UIElement.Panel pnlCustomerGroupDefinition;
        private UI.Control.UIElement.GroupBox groupBoxCustomerGroupDefinition;
        private UI.Control.UIElement.Panel pnlButtons;
        private UI.Control.Button.RefreshButton btnRefresh;
        private UI.Control.Button.EditButton btnEdit;
        private UI.Control.Button.CancelButton btnCancel;
        private UI.Control.Button.SaveButton btnSave;
        private UI.Control.ComboBox.ComboBox cmbPrice;
        private UI.Control.TextBox.TextBox txtGroupName;
        private UI.Control.Label.Label lblPrice;
        private UI.Control.Label.Label lblGroupName;
        private UI.Control.UIElement.Panel pnlMain;
        private UI.Control.UIElement.DataGridView dgvCustomerGroup;
        private UI.Control.TextBox.TextBox txtDescription;
        private UI.Control.Label.Label lblDescription;
        private UI.Control.TextBox.NumericTextBoxWithSeperator txtGroupID;
        private UI.Control.Label.Label lblGroupID;
        ConnectionClasses @class = new ConnectionClasses();
        TabManagement @tab = new TabManagement();
        private int MaxID;
        private int MaxID_;
        TinyTechEntities DB_Connection = new TinyTechEntities();
        private UI.Control.Label.Label lblDate;
        private UI.Control.TextBox.DateControl dateControlCustomerGroup;
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

        public CustomerGroupDefinition()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.pnlMain = new TinyTech.UI.Control.UIElement.Panel();
            this.dgvCustomerGroup = new TinyTech.UI.Control.UIElement.DataGridView();
            this.pnlCustomerGroupDefinition = new TinyTech.UI.Control.UIElement.Panel();
            this.groupBoxCustomerGroupDefinition = new TinyTech.UI.Control.UIElement.GroupBox();
            this.lblDate = new TinyTech.UI.Control.Label.Label();
            this.dateControlCustomerGroup = new TinyTech.UI.Control.TextBox.DateControl();
            this.txtGroupName = new TinyTech.UI.Control.TextBox.TextBox();
            this.cmbPrice = new TinyTech.UI.Control.ComboBox.ComboBox();
            this.txtDescription = new TinyTech.UI.Control.TextBox.TextBox();
            this.btnSave = new TinyTech.UI.Control.Button.SaveButton();
            this.btnRefresh = new TinyTech.UI.Control.Button.RefreshButton();
            this.btnCancel = new TinyTech.UI.Control.Button.CancelButton();
            this.txtGroupID = new TinyTech.UI.Control.TextBox.NumericTextBoxWithSeperator();
            this.lblGroupID = new TinyTech.UI.Control.Label.Label();
            this.lblDescription = new TinyTech.UI.Control.Label.Label();
            this.pnlButtons = new TinyTech.UI.Control.UIElement.Panel();
            this.btnEdit = new TinyTech.UI.Control.Button.EditButton();
            this.lblPrice = new TinyTech.UI.Control.Label.Label();
            this.lblGroupName = new TinyTech.UI.Control.Label.Label();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerGroup)).BeginInit();
            this.pnlCustomerGroupDefinition.SuspendLayout();
            this.groupBoxCustomerGroupDefinition.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.dgvCustomerGroup);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.pnlMain.Location = new System.Drawing.Point(0, 175);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlMain.Size = new System.Drawing.Size(800, 325);
            this.pnlMain.TabIndex = 1;
            // 
            // dgvCustomerGroup
            // 
            this.dgvCustomerGroup.AllowUserToAddRows = false;
            this.dgvCustomerGroup.AllowUserToDeleteRows = false;
            this.dgvCustomerGroup.AllowUserToOrderColumns = true;
            this.dgvCustomerGroup.AllowUserToResizeColumns = false;
            this.dgvCustomerGroup.AllowUserToResizeRows = false;
            this.dgvCustomerGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomerGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCustomerGroup.Location = new System.Drawing.Point(0, 0);
            this.dgvCustomerGroup.MultiSelect = false;
            this.dgvCustomerGroup.Name = "dgvCustomerGroup";
            this.dgvCustomerGroup.ReadOnly = true;
            this.dgvCustomerGroup.RowHeadersVisible = false;
            this.dgvCustomerGroup.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvCustomerGroup.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomerGroup.Size = new System.Drawing.Size(800, 325);
            this.dgvCustomerGroup.TabIndex = 0;
            // 
            // pnlCustomerGroupDefinition
            // 
            this.pnlCustomerGroupDefinition.Controls.Add(this.groupBoxCustomerGroupDefinition);
            this.pnlCustomerGroupDefinition.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCustomerGroupDefinition.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.pnlCustomerGroupDefinition.Location = new System.Drawing.Point(0, 0);
            this.pnlCustomerGroupDefinition.Name = "pnlCustomerGroupDefinition";
            this.pnlCustomerGroupDefinition.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlCustomerGroupDefinition.Size = new System.Drawing.Size(800, 175);
            this.pnlCustomerGroupDefinition.TabIndex = 0;
            // 
            // groupBoxCustomerGroupDefinition
            // 
            this.groupBoxCustomerGroupDefinition.Controls.Add(this.lblDate);
            this.groupBoxCustomerGroupDefinition.Controls.Add(this.dateControlCustomerGroup);
            this.groupBoxCustomerGroupDefinition.Controls.Add(this.txtGroupID);
            this.groupBoxCustomerGroupDefinition.Controls.Add(this.lblGroupID);
            this.groupBoxCustomerGroupDefinition.Controls.Add(this.txtDescription);
            this.groupBoxCustomerGroupDefinition.Controls.Add(this.lblDescription);
            this.groupBoxCustomerGroupDefinition.Controls.Add(this.pnlButtons);
            this.groupBoxCustomerGroupDefinition.Controls.Add(this.cmbPrice);
            this.groupBoxCustomerGroupDefinition.Controls.Add(this.txtGroupName);
            this.groupBoxCustomerGroupDefinition.Controls.Add(this.lblPrice);
            this.groupBoxCustomerGroupDefinition.Controls.Add(this.lblGroupName);
            this.groupBoxCustomerGroupDefinition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxCustomerGroupDefinition.Location = new System.Drawing.Point(0, 0);
            this.groupBoxCustomerGroupDefinition.Name = "groupBoxCustomerGroupDefinition";
            this.groupBoxCustomerGroupDefinition.Size = new System.Drawing.Size(800, 175);
            this.groupBoxCustomerGroupDefinition.TabIndex = 0;
            this.groupBoxCustomerGroupDefinition.TabStop = false;
            this.groupBoxCustomerGroupDefinition.Text = "تعريف گروه طرف حساب";
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
            this.lblDate.TabIndex = 20;
            this.lblDate.Text = "تاريخ :";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateControlCustomerGroup
            // 
            this.dateControlCustomerGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateControlCustomerGroup.BackColor = System.Drawing.Color.White;
            this.dateControlCustomerGroup.CanGoBackward = true;
            this.dateControlCustomerGroup.CanGoForward = false;
            this.dateControlCustomerGroup.Location = new System.Drawing.Point(565, 27);
            this.dateControlCustomerGroup.Name = "dateControlCustomerGroup";
            this.dateControlCustomerGroup.NextControl = this.txtGroupName;
            this.dateControlCustomerGroup.NowShamsi10Cahracter = "1397/06/14";
            this.dateControlCustomerGroup.NowShamsi8Character = "97/06/14";
            this.dateControlCustomerGroup.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateControlCustomerGroup.Size = new System.Drawing.Size(120, 20);
            this.dateControlCustomerGroup.TabIndex = 0;
            this.dateControlCustomerGroup.Text = "dateControl1";
            this.dateControlCustomerGroup.Value10Cahracter = null;
            this.dateControlCustomerGroup.Value8Character = null;
            // 
            // txtGroupName
            // 
            this.txtGroupName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGroupName.BackColor = System.Drawing.Color.White;
            this.txtGroupName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGroupName.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.txtGroupName.ForeColor = System.Drawing.Color.Black;
            this.txtGroupName.Location = new System.Drawing.Point(485, 60);
            this.txtGroupName.Margin = new System.Windows.Forms.Padding(10);
            this.txtGroupName.Name = "txtGroupName";
            this.txtGroupName.NextControl = this.cmbPrice;
            this.txtGroupName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtGroupName.Size = new System.Drawing.Size(200, 28);
            this.txtGroupName.TabIndex = 1;
            this.txtGroupName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtGroupName.TextChanged += new System.EventHandler(this.txtGroupName_TextChanged);
            // 
            // cmbPrice
            // 
            this.cmbPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbPrice.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbPrice.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbPrice.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.cmbPrice.FormattingEnabled = true;
            this.cmbPrice.Items.AddRange(new object[] {
            "قيمت فروش 1",
            "قيمت فروش 2",
            "قيمت فروش 3",
            "قيمت فروش 4",
            "قيمت فروش 5"});
            this.cmbPrice.Location = new System.Drawing.Point(485, 96);
            this.cmbPrice.Margin = new System.Windows.Forms.Padding(10);
            this.cmbPrice.Name = "cmbPrice";
            this.cmbPrice.NextControl = this.txtDescription;
            this.cmbPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbPrice.Size = new System.Drawing.Size(200, 28);
            this.cmbPrice.TabIndex = 2;
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.BackColor = System.Drawing.Color.White;
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescription.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.txtDescription.ForeColor = System.Drawing.Color.Black;
            this.txtDescription.Location = new System.Drawing.Point(376, 135);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(10);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.NextControl = this.btnSave;
            this.txtDescription.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDescription.Size = new System.Drawing.Size(309, 28);
            this.txtDescription.TabIndex = 3;
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
            this.btnCancel.NextControl = this.dateControlCustomerGroup;
            this.btnCancel.Size = new System.Drawing.Size(81, 34);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "انصراف";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtGroupID
            // 
            this.txtGroupID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGroupID.BackColor = System.Drawing.Color.White;
            this.txtGroupID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGroupID.Enabled = false;
            this.txtGroupID.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.txtGroupID.ForeColor = System.Drawing.Color.Black;
            this.txtGroupID.Location = new System.Drawing.Point(338, 60);
            this.txtGroupID.Margin = new System.Windows.Forms.Padding(10);
            this.txtGroupID.Name = "txtGroupID";
            this.txtGroupID.NextControl = null;
            this.txtGroupID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtGroupID.Size = new System.Drawing.Size(78, 28);
            this.txtGroupID.TabIndex = 10;
            this.txtGroupID.Text = "0";
            this.txtGroupID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtGroupID.Value = 0D;
            // 
            // lblGroupID
            // 
            this.lblGroupID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGroupID.AutoSize = true;
            this.lblGroupID.BackColor = System.Drawing.Color.Transparent;
            this.lblGroupID.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.lblGroupID.Location = new System.Drawing.Point(429, 62);
            this.lblGroupID.Name = "lblGroupID";
            this.lblGroupID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblGroupID.Size = new System.Drawing.Size(50, 20);
            this.lblGroupID.TabIndex = 9;
            this.lblGroupID.Text = "كد گروه :";
            this.lblGroupID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescription.AutoSize = true;
            this.lblDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblDescription.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.lblDescription.Location = new System.Drawing.Point(698, 138);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblDescription.Size = new System.Drawing.Size(60, 20);
            this.lblDescription.TabIndex = 7;
            this.lblDescription.Text = "توضيحات :";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlButtons
            // 
            this.pnlButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlButtons.Controls.Add(this.btnRefresh);
            this.pnlButtons.Controls.Add(this.btnEdit);
            this.pnlButtons.Controls.Add(this.btnCancel);
            this.pnlButtons.Controls.Add(this.btnSave);
            this.pnlButtons.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.pnlButtons.Location = new System.Drawing.Point(6, 123);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlButtons.Size = new System.Drawing.Size(345, 40);
            this.pnlButtons.TabIndex = 4;
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
            // lblPrice
            // 
            this.lblPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.lblPrice.Location = new System.Drawing.Point(698, 99);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPrice.Size = new System.Drawing.Size(96, 20);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "قيمت پيش فرض :";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGroupName
            // 
            this.lblGroupName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGroupName.AutoSize = true;
            this.lblGroupName.BackColor = System.Drawing.Color.Transparent;
            this.lblGroupName.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.lblGroupName.Location = new System.Drawing.Point(698, 62);
            this.lblGroupName.Name = "lblGroupName";
            this.lblGroupName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblGroupName.Size = new System.Drawing.Size(51, 20);
            this.lblGroupName.TabIndex = 0;
            this.lblGroupName.Text = "نام گروه :";
            this.lblGroupName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CustomerGroupDefinition
            // 
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlCustomerGroupDefinition);
            this.Name = "CustomerGroupDefinition";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(800, 500);
            this.Tag = "تعريف گروه طرف حساب";
            this.Load += new System.EventHandler(this.CustomerGroupDefinition_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CustomerGroupDefinition_KeyDown);
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerGroup)).EndInit();
            this.pnlCustomerGroupDefinition.ResumeLayout(false);
            this.groupBoxCustomerGroupDefinition.ResumeLayout(false);
            this.groupBoxCustomerGroupDefinition.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            @tab.CloseTab(this);
        }

        private DataTable CustomerGroupListDataTable(List<CustomerGroup> customerGroupList)
        {
            var dataTable = UI.Control.UIElement.ToolBox<CustomerGroup>.GetDataTable(customerGroupList);
            return dataTable;
        }

        private void CustomerGroupDefinition_Load(object sender, EventArgs e)
        {
            var customerGroupList = @class.GetCustomerGroup().Where(i => i.Active).ToList();
            dgvCustomerGroup.DataSource = CustomerGroupListDataTable(customerGroupList);
            SetGridView();
            txtGroupID.Text = CalculateMaxId().ToString();
            txtGroupName.Focus();
            cmbPrice.SelectedIndex = 0;
            btnEdit.Enabled = false;
        }

        private int CalculateMaxId()
        {
            if (@class.GetCustomerGroup().Count <= 0) return 1;
            var max = @class.GetCustomerGroup().Max(i => i.ID) + 1;
            return max;
        }

        private void SetGridView()
        {
            foreach (DataGridViewColumn item in dgvCustomerGroup.Columns)
            {
                item.Visible = false;
            }
            dgvCustomerGroup.Columns["ID"].Visible = true;
            dgvCustomerGroup.Columns["Name"].Visible = true;
            dgvCustomerGroup.Columns["DefaultSailPrice"].Visible = true;
            dgvCustomerGroup.Columns["Description"].Visible = true;

            dgvCustomerGroup.Columns["ID"].HeaderText = "كد";
            dgvCustomerGroup.Columns["Name"].HeaderText = "نام";
            dgvCustomerGroup.Columns["DefaultSailPrice"].HeaderText = "قيمت پيش فرض";
            dgvCustomerGroup.Columns["Description"].HeaderText = "توضيحات";


            dgvCustomerGroup.Columns["ID"].DisplayIndex = 0;
            dgvCustomerGroup.Columns["Name"].DisplayIndex = 1;
            dgvCustomerGroup.Columns["DefaultSailPrice"].DisplayIndex = 2;
            dgvCustomerGroup.Columns["Description"].DisplayIndex = 3;

            dgvCustomerGroup.Columns["ID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvCustomerGroup.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvCustomerGroup.Columns["DefaultSailPrice"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvCustomerGroup.Columns["Description"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvCustomerGroup.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvCustomerGroup.Columns["ID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvCustomerGroup.Columns["Name"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvCustomerGroup.Columns["DefaultSailPrice"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvCustomerGroup.Columns["Description"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            dgvCustomerGroup.AutoGenerateColumns = false;

        }

        private void CustomerGroupDefinition_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                @tab.CloseTab(this);
            }
        }

        private bool FormValidate()
        {
            if (string.IsNullOrWhiteSpace(txtGroupName.Text))
            {
                CustomMessageForm.CustomMessageBox.Show("اخطار", "لطفا نام گروه طرف حساب را وارد كنيد", "e");
                txtGroupName.Focus();
                return false;
            }
            if (DB_Connection.CustomerGroup.AsNoTracking().Count(i => i.Name.Equals(txtGroupName.Text) && i.Active) > 0)
            {
                CustomMessageForm.CustomMessageBox.Show("اخطار !", $"نام گروه طرف حساب \"{txtGroupName.Text}\" تكراري است!", "e");
                txtGroupName.Focus();
                return false;
            }

            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (FormValidate())
            {
                var result = @class.CustomerGroupDefinition(txtGroupName.Text, cmbPrice.SelectedIndex + 1, txtDescription.Text, dateControlCustomerGroup.Shamsi10CharacteriValue(), ConnectionClasses.DateServer.ReturnDateServer(), ConnectionInfo.LoggedInUserId);

                if (result > 0)
                {
                    CustomMessageForm.CustomMessageBox.Show("پيغام سيستم", $"گروه طرف حساب \"{txtGroupName.Text}\" با موفقيت ثبت شد", "i");
                    MaxID_ = result;
                    if (int.Parse(txtGroupID.Text) != MaxID_)
                    {
                        CustomMessageForm.CustomMessageBox.Show("پيغام سيستم", $"كد گروه طرف حساب به {MaxID_} تغيير يافت", "i");
                    }
                    RefreshForm();
                }
                else if (result == 0)
                {
                    CustomMessageForm.CustomMessageBox.Show("خطا !", $"خطا در تعريف گروه طرف حساب!\n\nلطفا جهت بررسي مشكل با پشتيباني تماس بگيريد", "e");
                }
            }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshForm();
            txtGroupName.Focus();
        }

        private void RefreshForm()
        {
            CustomerGroupDefinition_Load(null, null);
            txtGroupName.Clear();
            cmbPrice.SelectedIndex = 0;
            txtDescription.Clear();
        }

        private void txtGroupName_TextChanged(object sender, EventArgs e)
        {
            var customerGroupList = @class.GetCustomerGroup().Where(i => i.Active && i.Name.Contains(txtGroupName.Text)).ToList();
            dgvCustomerGroup.DataSource = CustomerGroupListDataTable(customerGroupList);
        }
    }
}
