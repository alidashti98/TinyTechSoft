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
    public class PeopleGroupDefinition : UserControl
    {
        #region Region 
        private UI.Control.UIElement.Panel pnlPeopleGroupDefinition;
        private UI.Control.UIElement.GroupBox groupBoxPeopleGroupDefinition;
        private UI.Control.UIElement.Panel pnlButtons;
        private UI.Control.Button.RefreshButton btnRefresh;
        private UI.Control.Button.CancelButton btnCancel;
        private UI.Control.Button.SaveButton btnSave;
        private UI.Control.ComboBox.ComboBox cmbPrice;
        private UI.Control.TextBox.TextBox txtGroupName;
        private UI.Control.Label.Label lblPrice;
        private UI.Control.Label.Label lblGroupName;
        private UI.Control.UIElement.Panel pnlMain;
        private UI.Control.UIElement.DataGridView dgvPeopleGroup;
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
        private UI.Control.TextBox.DateControl dateControlPeopleGroup;
        private UI.Control.ComboBox.ComboBox cmbGroupType;
        private UI.Control.Label.Label lblGroupType;
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

        public PeopleGroupDefinition()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.pnlMain = new TinyTech.UI.Control.UIElement.Panel();
            this.dgvPeopleGroup = new TinyTech.UI.Control.UIElement.DataGridView();
            this.pnlPeopleGroupDefinition = new TinyTech.UI.Control.UIElement.Panel();
            this.groupBoxPeopleGroupDefinition = new TinyTech.UI.Control.UIElement.GroupBox();
            this.cmbGroupType = new TinyTech.UI.Control.ComboBox.ComboBox();
            this.cmbPrice = new TinyTech.UI.Control.ComboBox.ComboBox();
            this.txtDescription = new TinyTech.UI.Control.TextBox.TextBox();
            this.btnSave = new TinyTech.UI.Control.Button.SaveButton();
            this.btnRefresh = new TinyTech.UI.Control.Button.RefreshButton();
            this.btnCancel = new TinyTech.UI.Control.Button.CancelButton();
            this.dateControlPeopleGroup = new TinyTech.UI.Control.TextBox.DateControl();
            this.txtGroupName = new TinyTech.UI.Control.TextBox.TextBox();
            this.lblGroupType = new TinyTech.UI.Control.Label.Label();
            this.lblDate = new TinyTech.UI.Control.Label.Label();
            this.txtGroupID = new TinyTech.UI.Control.TextBox.NumericTextBoxWithSeperator();
            this.lblGroupID = new TinyTech.UI.Control.Label.Label();
            this.lblDescription = new TinyTech.UI.Control.Label.Label();
            this.pnlButtons = new TinyTech.UI.Control.UIElement.Panel();
            this.lblPrice = new TinyTech.UI.Control.Label.Label();
            this.lblGroupName = new TinyTech.UI.Control.Label.Label();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeopleGroup)).BeginInit();
            this.pnlPeopleGroupDefinition.SuspendLayout();
            this.groupBoxPeopleGroupDefinition.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.dgvPeopleGroup);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.pnlMain.Location = new System.Drawing.Point(0, 175);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlMain.Size = new System.Drawing.Size(800, 325);
            this.pnlMain.TabIndex = 1;
            // 
            // dgvPeopleGroup
            // 
            this.dgvPeopleGroup.AllowUserToAddRows = false;
            this.dgvPeopleGroup.AllowUserToDeleteRows = false;
            this.dgvPeopleGroup.AllowUserToOrderColumns = true;
            this.dgvPeopleGroup.AllowUserToResizeColumns = false;
            this.dgvPeopleGroup.AllowUserToResizeRows = false;
            this.dgvPeopleGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeopleGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPeopleGroup.Location = new System.Drawing.Point(0, 0);
            this.dgvPeopleGroup.MultiSelect = false;
            this.dgvPeopleGroup.Name = "dgvPeopleGroup";
            this.dgvPeopleGroup.ReadOnly = true;
            this.dgvPeopleGroup.RowHeadersVisible = false;
            this.dgvPeopleGroup.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPeopleGroup.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPeopleGroup.Size = new System.Drawing.Size(800, 325);
            this.dgvPeopleGroup.TabIndex = 0;
            // 
            // pnlPeopleGroupDefinition
            // 
            this.pnlPeopleGroupDefinition.Controls.Add(this.groupBoxPeopleGroupDefinition);
            this.pnlPeopleGroupDefinition.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPeopleGroupDefinition.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.pnlPeopleGroupDefinition.Location = new System.Drawing.Point(0, 0);
            this.pnlPeopleGroupDefinition.Name = "pnlPeopleGroupDefinition";
            this.pnlPeopleGroupDefinition.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlPeopleGroupDefinition.Size = new System.Drawing.Size(800, 175);
            this.pnlPeopleGroupDefinition.TabIndex = 0;
            // 
            // groupBoxPeopleGroupDefinition
            // 
            this.groupBoxPeopleGroupDefinition.Controls.Add(this.cmbGroupType);
            this.groupBoxPeopleGroupDefinition.Controls.Add(this.lblGroupType);
            this.groupBoxPeopleGroupDefinition.Controls.Add(this.lblDate);
            this.groupBoxPeopleGroupDefinition.Controls.Add(this.dateControlPeopleGroup);
            this.groupBoxPeopleGroupDefinition.Controls.Add(this.txtGroupID);
            this.groupBoxPeopleGroupDefinition.Controls.Add(this.lblGroupID);
            this.groupBoxPeopleGroupDefinition.Controls.Add(this.txtDescription);
            this.groupBoxPeopleGroupDefinition.Controls.Add(this.lblDescription);
            this.groupBoxPeopleGroupDefinition.Controls.Add(this.pnlButtons);
            this.groupBoxPeopleGroupDefinition.Controls.Add(this.cmbPrice);
            this.groupBoxPeopleGroupDefinition.Controls.Add(this.txtGroupName);
            this.groupBoxPeopleGroupDefinition.Controls.Add(this.lblPrice);
            this.groupBoxPeopleGroupDefinition.Controls.Add(this.lblGroupName);
            this.groupBoxPeopleGroupDefinition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxPeopleGroupDefinition.Location = new System.Drawing.Point(0, 0);
            this.groupBoxPeopleGroupDefinition.Name = "groupBoxPeopleGroupDefinition";
            this.groupBoxPeopleGroupDefinition.Size = new System.Drawing.Size(800, 175);
            this.groupBoxPeopleGroupDefinition.TabIndex = 0;
            this.groupBoxPeopleGroupDefinition.TabStop = false;
            this.groupBoxPeopleGroupDefinition.Text = "تعريف گروه طرف حساب";
            // 
            // cmbGroupType
            // 
            this.cmbGroupType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbGroupType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbGroupType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbGroupType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGroupType.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.cmbGroupType.FormattingEnabled = true;
            this.cmbGroupType.Items.AddRange(new object[] {
            "مشتريان",
            "تأمين كنندگان"});
            this.cmbGroupType.Location = new System.Drawing.Point(529, 93);
            this.cmbGroupType.Margin = new System.Windows.Forms.Padding(10);
            this.cmbGroupType.Name = "cmbGroupType";
            this.cmbGroupType.NextControl = this.cmbPrice;
            this.cmbGroupType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbGroupType.Size = new System.Drawing.Size(156, 28);
            this.cmbGroupType.TabIndex = 21;
            this.cmbGroupType.Enter += new System.EventHandler(this.cmbGroupType_Enter);
            // 
            // cmbPrice
            // 
            this.cmbPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbPrice.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbPrice.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbPrice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPrice.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.cmbPrice.FormattingEnabled = true;
            this.cmbPrice.Items.AddRange(new object[] {
            "قيمت فروش 1",
            "قيمت فروش 2",
            "قيمت فروش 3",
            "قيمت فروش 4",
            "قيمت فروش 5"});
            this.cmbPrice.Location = new System.Drawing.Point(292, 92);
            this.cmbPrice.Margin = new System.Windows.Forms.Padding(10);
            this.cmbPrice.Name = "cmbPrice";
            this.cmbPrice.NextControl = this.txtDescription;
            this.cmbPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbPrice.Size = new System.Drawing.Size(115, 28);
            this.cmbPrice.TabIndex = 2;
            this.cmbPrice.Enter += new System.EventHandler(this.cmbPrice_Enter);
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.BackColor = System.Drawing.Color.White;
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescription.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.txtDescription.ForeColor = System.Drawing.Color.Black;
            this.txtDescription.Location = new System.Drawing.Point(282, 126);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(10);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.NextControl = this.btnSave;
            this.txtDescription.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDescription.Size = new System.Drawing.Size(403, 28);
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
            this.btnCancel.NextControl = this.dateControlPeopleGroup;
            this.btnCancel.Size = new System.Drawing.Size(81, 34);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "انصراف";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dateControlPeopleGroup
            // 
            this.dateControlPeopleGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateControlPeopleGroup.BackColor = System.Drawing.Color.White;
            this.dateControlPeopleGroup.CanGoBackward = true;
            this.dateControlPeopleGroup.CanGoForward = false;
            this.dateControlPeopleGroup.Location = new System.Drawing.Point(565, 27);
            this.dateControlPeopleGroup.Name = "dateControlPeopleGroup";
            this.dateControlPeopleGroup.NextControl = this.txtGroupName;
            this.dateControlPeopleGroup.NowShamsi8Character = "97/06/14";
            this.dateControlPeopleGroup.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateControlPeopleGroup.ShamsiNow = "1397/06/14";
            this.dateControlPeopleGroup.Size = new System.Drawing.Size(120, 20);
            this.dateControlPeopleGroup.TabIndex = 0;
            this.dateControlPeopleGroup.Text = "dateControl1";
            this.dateControlPeopleGroup.Value10Cahracter = null;
            // 
            // txtGroupName
            // 
            this.txtGroupName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGroupName.BackColor = System.Drawing.Color.White;
            this.txtGroupName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGroupName.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.txtGroupName.ForeColor = System.Drawing.Color.Black;
            this.txtGroupName.Location = new System.Drawing.Point(446, 60);
            this.txtGroupName.Margin = new System.Windows.Forms.Padding(10);
            this.txtGroupName.Name = "txtGroupName";
            this.txtGroupName.NextControl = this.cmbGroupType;
            this.txtGroupName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtGroupName.Size = new System.Drawing.Size(239, 28);
            this.txtGroupName.TabIndex = 1;
            this.txtGroupName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtGroupName.TextChanged += new System.EventHandler(this.txtGroupName_TextChanged);
            // 
            // lblGroupType
            // 
            this.lblGroupType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGroupType.AutoSize = true;
            this.lblGroupType.BackColor = System.Drawing.Color.Transparent;
            this.lblGroupType.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.lblGroupType.Location = new System.Drawing.Point(698, 96);
            this.lblGroupType.Name = "lblGroupType";
            this.lblGroupType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblGroupType.Size = new System.Drawing.Size(55, 20);
            this.lblGroupType.TabIndex = 22;
            this.lblGroupType.Text = "نوع گروه :";
            this.lblGroupType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // txtGroupID
            // 
            this.txtGroupID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGroupID.BackColor = System.Drawing.Color.White;
            this.txtGroupID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGroupID.Enabled = false;
            this.txtGroupID.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.txtGroupID.ForeColor = System.Drawing.Color.Black;
            this.txtGroupID.Location = new System.Drawing.Point(292, 60);
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
            this.lblGroupID.Location = new System.Drawing.Point(383, 62);
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
            this.lblDescription.Location = new System.Drawing.Point(698, 129);
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
            this.pnlButtons.Controls.Add(this.btnCancel);
            this.pnlButtons.Controls.Add(this.btnSave);
            this.pnlButtons.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.pnlButtons.Location = new System.Drawing.Point(6, 123);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlButtons.Size = new System.Drawing.Size(259, 40);
            this.pnlButtons.TabIndex = 4;
            // 
            // lblPrice
            // 
            this.lblPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.lblPrice.Location = new System.Drawing.Point(420, 95);
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
            // PeopleGroupDefinition
            // 
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlPeopleGroupDefinition);
            this.Name = "PeopleGroupDefinition";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(800, 500);
            this.Tag = "تعريف گروه طرف حساب";
            this.Load += new System.EventHandler(this.PeopleGroupDefinition_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PeopleGroupDefinition_KeyDown);
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeopleGroup)).EndInit();
            this.pnlPeopleGroupDefinition.ResumeLayout(false);
            this.groupBoxPeopleGroupDefinition.ResumeLayout(false);
            this.groupBoxPeopleGroupDefinition.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            @tab.CloseTab(this);
        }

        private DataTable PeopleGroupListDataTable(List<PeopleGroup> PeopleGroupList)
        {
            var dataTable = UI.Control.UIElement.ToolBox<PeopleGroup>.GetDataTable(PeopleGroupList);
            return dataTable;
        }

        private void PeopleGroupDefinition_Load(object sender, EventArgs e)
        {
            var peopleGroupList = @class.GetPeopleGroup(true).ToList();
            dgvPeopleGroup.DataSource = peopleGroupList; //PeopleGroupListDataTable(PeopleGroupList);
            SetGridView();
            txtGroupID.Text = CalculateMaxId().ToString();
            txtGroupName.Focus();
            cmbPrice.SelectedIndex = cmbGroupType.SelectedIndex = 0;
        }

        private int CalculateMaxId()
        {
            if (@class.GetPeopleGroup().Count <= 0) return 1;
            var max = @class.GetPeopleGroup().Max(i => i.ID) + 1;
            return max;
        }

        private void SetGridView()
        {
            foreach (DataGridViewColumn item in dgvPeopleGroup.Columns)
            {
                item.Visible = false;
            }
            dgvPeopleGroup.Columns["ID"].Visible = true;
            dgvPeopleGroup.Columns["Name"].Visible = true;
            //dgvPeopleGroup.Columns["ParrentID"].Visible = true;
            dgvPeopleGroup.Columns["DefaultSailPrice"].Visible = true;
            dgvPeopleGroup.Columns["Description"].Visible = true;

            dgvPeopleGroup.Columns["ID"].HeaderText = "كد";
            dgvPeopleGroup.Columns["Name"].HeaderText = "نام";
            //dgvPeopleGroup.Columns["ParrentID"].HeaderText = "نوع گروه";
            dgvPeopleGroup.Columns["DefaultSailPrice"].HeaderText = "قيمت پيش فرض";
            dgvPeopleGroup.Columns["Description"].HeaderText = "توضيحات";


            dgvPeopleGroup.Columns["ID"].DisplayIndex = 0;
            dgvPeopleGroup.Columns["Name"].DisplayIndex = 1;
            //dgvPeopleGroup.Columns["ParrentID"].DisplayIndex = 2;
            dgvPeopleGroup.Columns["DefaultSailPrice"].DisplayIndex = 3;
            dgvPeopleGroup.Columns["Description"].DisplayIndex = 4;

            dgvPeopleGroup.Columns["ID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvPeopleGroup.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //dgvPeopleGroup.Columns["ParrentID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvPeopleGroup.Columns["DefaultSailPrice"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvPeopleGroup.Columns["Description"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvPeopleGroup.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvPeopleGroup.Columns["ID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPeopleGroup.Columns["Name"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            //dgvPeopleGroup.Columns["ParrentID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPeopleGroup.Columns["DefaultSailPrice"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPeopleGroup.Columns["Description"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            dgvPeopleGroup.AutoGenerateColumns = false;
        }

        private void PeopleGroupDefinition_KeyDown(object sender, KeyEventArgs e)
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
            if (@class.GetPeopleGroup(true).Count(i => i.Name.Equals(txtGroupName.Text)) > 0)
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
                var result = @class.PeopleGroupDefinition(txtGroupName.Text, cmbPrice.SelectedIndex + 1, txtDescription.Text, cmbGroupType.SelectedIndex + 1, dateControlPeopleGroup.ShamsiValue(), ConnectionClasses.DateServer.ReturnDateServer(), DateTime.Now.ToString("HH:mm:ss"), ConnectionClasses.DateServer.ServerTime(), ConnectionInfo.LoggedInUserId);

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
            PeopleGroupDefinition_Load(null, null);
            txtGroupName.Text = txtDescription.Text = string.Empty;
        }

        private void txtGroupName_TextChanged(object sender, EventArgs e)
        {
            var peopleGroupList = @class.GetPeopleGroup(true).Where(i => i.Name.Contains(txtGroupName.Text)).ToList();
            dgvPeopleGroup.DataSource = peopleGroupList; //PeopleGroupListDataTable(PeopleGroupList);
        }

        private void cmbGroupType_Enter(object sender, EventArgs e)
        {
            cmbGroupType.DroppedDown = true;
        }

        private void cmbPrice_Enter(object sender, EventArgs e)
        {
            cmbPrice.DroppedDown = true;
        }
    }
}
