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
    public class GoodsUnitDefinition : UserControl
    {
        #region Region 
        private UI.Control.UIElement.Panel pnlGoodsUnitDefinition;
        private UI.Control.UIElement.GroupBox groupBoxGoodsUnitDefinition;
        private UI.Control.UIElement.Panel pnlButtons;
        private UI.Control.Button.RefreshButton btnRefresh;
        private UI.Control.Button.CancelButton btnCancel;
        private UI.Control.Button.SaveButton btnSave;
        private UI.Control.UIElement.Panel pnlMain;
        private UI.Control.UIElement.DataGridView dgvGoodsUnit;
        ConnectionClasses @class = new ConnectionClasses();
        TabManagement @tab = new TabManagement();
        private int MaxID;
        private UI.Control.Label.Label lblGoodsUnitName;
        private UI.Control.Label.Label lblGoodsUnitID;
        private UI.Control.Label.Label lblDescription;
        private UI.Control.TextBox.TextBox txtDescription;
        private UI.Control.TextBox.TextBox txtGoodsUnitName;
        private UI.Control.TextBox.NumericTextBoxWithSeperator txtGoodsUnitID;
        private int MaxID_;
        TinyTechEntities DB_Connection = new TinyTechEntities();
        private UI.Control.Label.Label lblDate;
        private UI.Control.TextBox.DateControl dateControlGoodsUnit;
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

        public GoodsUnitDefinition()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.pnlMain = new TinyTech.UI.Control.UIElement.Panel();
            this.dgvGoodsUnit = new TinyTech.UI.Control.UIElement.DataGridView();
            this.pnlGoodsUnitDefinition = new TinyTech.UI.Control.UIElement.Panel();
            this.groupBoxGoodsUnitDefinition = new TinyTech.UI.Control.UIElement.GroupBox();
            this.lblDate = new TinyTech.UI.Control.Label.Label();
            this.dateControlGoodsUnit = new TinyTech.UI.Control.TextBox.DateControl();
            this.txtGoodsUnitName = new TinyTech.UI.Control.TextBox.TextBox();
            this.txtDescription = new TinyTech.UI.Control.TextBox.TextBox();
            this.btnSave = new TinyTech.UI.Control.Button.SaveButton();
            this.btnRefresh = new TinyTech.UI.Control.Button.RefreshButton();
            this.btnCancel = new TinyTech.UI.Control.Button.CancelButton();
            this.txtGoodsUnitID = new TinyTech.UI.Control.TextBox.NumericTextBoxWithSeperator();
            this.lblGoodsUnitID = new TinyTech.UI.Control.Label.Label();
            this.lblDescription = new TinyTech.UI.Control.Label.Label();
            this.lblGoodsUnitName = new TinyTech.UI.Control.Label.Label();
            this.pnlButtons = new TinyTech.UI.Control.UIElement.Panel();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoodsUnit)).BeginInit();
            this.pnlGoodsUnitDefinition.SuspendLayout();
            this.groupBoxGoodsUnitDefinition.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.dgvGoodsUnit);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.pnlMain.Location = new System.Drawing.Point(0, 148);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlMain.Size = new System.Drawing.Size(800, 352);
            this.pnlMain.TabIndex = 1;
            // 
            // dgvGoodsUnit
            // 
            this.dgvGoodsUnit.AllowUserToAddRows = false;
            this.dgvGoodsUnit.AllowUserToDeleteRows = false;
            this.dgvGoodsUnit.AllowUserToOrderColumns = true;
            this.dgvGoodsUnit.AllowUserToResizeColumns = false;
            this.dgvGoodsUnit.AllowUserToResizeRows = false;
            this.dgvGoodsUnit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGoodsUnit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGoodsUnit.Location = new System.Drawing.Point(0, 0);
            this.dgvGoodsUnit.MultiSelect = false;
            this.dgvGoodsUnit.Name = "dgvGoodsUnit";
            this.dgvGoodsUnit.ReadOnly = true;
            this.dgvGoodsUnit.RowHeadersVisible = false;
            this.dgvGoodsUnit.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvGoodsUnit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGoodsUnit.Size = new System.Drawing.Size(800, 352);
            this.dgvGoodsUnit.TabIndex = 1;
            // 
            // pnlGoodsUnitDefinition
            // 
            this.pnlGoodsUnitDefinition.Controls.Add(this.groupBoxGoodsUnitDefinition);
            this.pnlGoodsUnitDefinition.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlGoodsUnitDefinition.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.pnlGoodsUnitDefinition.Location = new System.Drawing.Point(0, 0);
            this.pnlGoodsUnitDefinition.Name = "pnlGoodsUnitDefinition";
            this.pnlGoodsUnitDefinition.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlGoodsUnitDefinition.Size = new System.Drawing.Size(800, 148);
            this.pnlGoodsUnitDefinition.TabIndex = 0;
            // 
            // groupBoxGoodsUnitDefinition
            // 
            this.groupBoxGoodsUnitDefinition.Controls.Add(this.lblDate);
            this.groupBoxGoodsUnitDefinition.Controls.Add(this.dateControlGoodsUnit);
            this.groupBoxGoodsUnitDefinition.Controls.Add(this.txtGoodsUnitID);
            this.groupBoxGoodsUnitDefinition.Controls.Add(this.txtDescription);
            this.groupBoxGoodsUnitDefinition.Controls.Add(this.txtGoodsUnitName);
            this.groupBoxGoodsUnitDefinition.Controls.Add(this.lblGoodsUnitID);
            this.groupBoxGoodsUnitDefinition.Controls.Add(this.lblDescription);
            this.groupBoxGoodsUnitDefinition.Controls.Add(this.lblGoodsUnitName);
            this.groupBoxGoodsUnitDefinition.Controls.Add(this.pnlButtons);
            this.groupBoxGoodsUnitDefinition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxGoodsUnitDefinition.Location = new System.Drawing.Point(0, 0);
            this.groupBoxGoodsUnitDefinition.Name = "groupBoxGoodsUnitDefinition";
            this.groupBoxGoodsUnitDefinition.Size = new System.Drawing.Size(800, 148);
            this.groupBoxGoodsUnitDefinition.TabIndex = 0;
            this.groupBoxGoodsUnitDefinition.TabStop = false;
            this.groupBoxGoodsUnitDefinition.Text = "تعريف واحد كالا";
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.lblDate.Location = new System.Drawing.Point(700, 27);
            this.lblDate.Name = "lblDate";
            this.lblDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblDate.Size = new System.Drawing.Size(40, 20);
            this.lblDate.TabIndex = 24;
            this.lblDate.Text = "تاريخ :";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateControlGoodsUnit
            // 
            this.dateControlGoodsUnit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateControlGoodsUnit.BackColor = System.Drawing.Color.White;
            this.dateControlGoodsUnit.CanGoBackward = true;
            this.dateControlGoodsUnit.CanGoForward = false;
            this.dateControlGoodsUnit.Location = new System.Drawing.Point(567, 27);
            this.dateControlGoodsUnit.Name = "dateControlGoodsUnit";
            this.dateControlGoodsUnit.NextControl = this.txtGoodsUnitName;
            this.dateControlGoodsUnit.NowShamsi8Character = "97/06/14";
            this.dateControlGoodsUnit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateControlGoodsUnit.ShamsiNow = "1397/06/14";
            this.dateControlGoodsUnit.Size = new System.Drawing.Size(120, 20);
            this.dateControlGoodsUnit.TabIndex = 0;
            this.dateControlGoodsUnit.Text = "dateControl1";
            this.dateControlGoodsUnit.Value10Cahracter = null;
            // 
            // txtGoodsUnitName
            // 
            this.txtGoodsUnitName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGoodsUnitName.BackColor = System.Drawing.Color.White;
            this.txtGoodsUnitName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGoodsUnitName.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.txtGoodsUnitName.ForeColor = System.Drawing.Color.Black;
            this.txtGoodsUnitName.Location = new System.Drawing.Point(487, 60);
            this.txtGoodsUnitName.Margin = new System.Windows.Forms.Padding(10);
            this.txtGoodsUnitName.Name = "txtGoodsUnitName";
            this.txtGoodsUnitName.NextControl = this.txtDescription;
            this.txtGoodsUnitName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtGoodsUnitName.Size = new System.Drawing.Size(200, 28);
            this.txtGoodsUnitName.TabIndex = 1;
            this.txtGoodsUnitName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtGoodsUnitName.TextChanged += new System.EventHandler(this.txtGoodsUnitName_TextChanged);
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.BackColor = System.Drawing.Color.White;
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescription.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.txtDescription.ForeColor = System.Drawing.Color.Black;
            this.txtDescription.Location = new System.Drawing.Point(487, 97);
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
            this.btnCancel.NextControl = this.dateControlGoodsUnit;
            this.btnCancel.Size = new System.Drawing.Size(81, 34);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "انصراف";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtGoodsUnitID
            // 
            this.txtGoodsUnitID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGoodsUnitID.BackColor = System.Drawing.Color.White;
            this.txtGoodsUnitID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGoodsUnitID.Enabled = false;
            this.txtGoodsUnitID.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.txtGoodsUnitID.ForeColor = System.Drawing.Color.Black;
            this.txtGoodsUnitID.Location = new System.Drawing.Point(341, 60);
            this.txtGoodsUnitID.Margin = new System.Windows.Forms.Padding(10);
            this.txtGoodsUnitID.Name = "txtGoodsUnitID";
            this.txtGoodsUnitID.NextControl = null;
            this.txtGoodsUnitID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtGoodsUnitID.Size = new System.Drawing.Size(54, 28);
            this.txtGoodsUnitID.TabIndex = 12;
            this.txtGoodsUnitID.Text = "0";
            this.txtGoodsUnitID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtGoodsUnitID.Value = 0D;
            // 
            // lblGoodsUnitID
            // 
            this.lblGoodsUnitID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGoodsUnitID.AutoSize = true;
            this.lblGoodsUnitID.BackColor = System.Drawing.Color.Transparent;
            this.lblGoodsUnitID.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.lblGoodsUnitID.Location = new System.Drawing.Point(408, 62);
            this.lblGoodsUnitID.Name = "lblGoodsUnitID";
            this.lblGoodsUnitID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblGoodsUnitID.Size = new System.Drawing.Size(72, 20);
            this.lblGoodsUnitID.TabIndex = 9;
            this.lblGoodsUnitID.Text = "كد واحد كالا :";
            this.lblGoodsUnitID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescription.AutoSize = true;
            this.lblDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblDescription.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.lblDescription.Location = new System.Drawing.Point(700, 99);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblDescription.Size = new System.Drawing.Size(60, 20);
            this.lblDescription.TabIndex = 8;
            this.lblDescription.Text = "توضيحات :";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGoodsUnitName
            // 
            this.lblGoodsUnitName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGoodsUnitName.AutoSize = true;
            this.lblGoodsUnitName.BackColor = System.Drawing.Color.Transparent;
            this.lblGoodsUnitName.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.lblGoodsUnitName.Location = new System.Drawing.Point(700, 62);
            this.lblGoodsUnitName.Name = "lblGoodsUnitName";
            this.lblGoodsUnitName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblGoodsUnitName.Size = new System.Drawing.Size(73, 20);
            this.lblGoodsUnitName.TabIndex = 7;
            this.lblGoodsUnitName.Text = "نام واحد كالا :";
            this.lblGoodsUnitName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlButtons
            // 
            this.pnlButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlButtons.Controls.Add(this.btnRefresh);
            this.pnlButtons.Controls.Add(this.btnCancel);
            this.pnlButtons.Controls.Add(this.btnSave);
            this.pnlButtons.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.pnlButtons.Location = new System.Drawing.Point(6, 97);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlButtons.Size = new System.Drawing.Size(260, 40);
            this.pnlButtons.TabIndex = 3;
            // 
            // GoodsUnitDefinition
            // 
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlGoodsUnitDefinition);
            this.Name = "GoodsUnitDefinition";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(800, 500);
            this.Tag = "تعريف واحد كالا";
            this.Load += new System.EventHandler(this.GoodsUnitDefinition_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GoodsUnitDefinition_KeyDown);
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoodsUnit)).EndInit();
            this.pnlGoodsUnitDefinition.ResumeLayout(false);
            this.groupBoxGoodsUnitDefinition.ResumeLayout(false);
            this.groupBoxGoodsUnitDefinition.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            @tab.CloseTab(this);
        }

        private DataTable GoodsUnitListDataTable(List<GoodsUnit> goodsUnitList)
        {
            var dataTable = UI.Control.UIElement.ToolBox<GoodsUnit>.GetDataTable(goodsUnitList);
            return dataTable;
        }

        private void GoodsUnitDefinition_Load(object sender, EventArgs e)
        {
            var goodsUnitList = @class.GetGoodsUnit().Where(i => i.Active).ToList();
            dgvGoodsUnit.DataSource = GoodsUnitListDataTable(goodsUnitList);
            SetGridView();
            txtGoodsUnitID.Text = CalculateMaxId().ToString();
            txtGoodsUnitName.Focus();
        }

        private int CalculateMaxId()
        {
            if (@class.GetGoodsUnit().Count <= 0) return 1;
            var max = @class.GetGoodsUnit().Max(i => i.ID) + 1;
            return max;
        }

        private void SetGridView()
        {
            foreach (DataGridViewColumn item in dgvGoodsUnit.Columns)
            {
                item.Visible = false;
            }
            dgvGoodsUnit.Columns["ID"].Visible = true;
            dgvGoodsUnit.Columns["Name"].Visible = true;
            dgvGoodsUnit.Columns["Description"].Visible = true;

            dgvGoodsUnit.Columns["ID"].HeaderText = "كد";
            dgvGoodsUnit.Columns["Name"].HeaderText = "نام";
            dgvGoodsUnit.Columns["Description"].HeaderText = "توضيحات";


            dgvGoodsUnit.Columns["ID"].DisplayIndex = 0;
            dgvGoodsUnit.Columns["Name"].DisplayIndex = 1;
            dgvGoodsUnit.Columns["Description"].DisplayIndex = 3;

            dgvGoodsUnit.Columns["ID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvGoodsUnit.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvGoodsUnit.Columns["Description"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvGoodsUnit.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvGoodsUnit.Columns["ID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvGoodsUnit.Columns["Name"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvGoodsUnit.Columns["Description"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            dgvGoodsUnit.AutoGenerateColumns = false;

        }

        private void GoodsUnitDefinition_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                @tab.CloseTab(this);
            }
        }

        private bool FormValidate()
        {
            if (string.IsNullOrWhiteSpace(txtGoodsUnitName.Text))
            {
                CustomMessageForm.CustomMessageBox.Show("اخطار", "لطفا نام واحد كالا را وارد كنيد", "e");
                txtGoodsUnitName.Focus();
                return false;
            }
            if (DB_Connection.GoodsUnit.AsNoTracking().Count(i => i.Name.Equals(txtGoodsUnitName.Text) && i.Active) > 0)
            {
                CustomMessageForm.CustomMessageBox.Show("اخطار !", $"نام واحد كالا \"{txtGoodsUnitName.Text}\" تكراري است!", "e");
                txtGoodsUnitName.Focus();
                return false;
            }

            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (FormValidate())
            {
                var result = @class.GoodsUnitDefinition(txtGoodsUnitName.Text, txtDescription.Text, dateControlGoodsUnit.ShamsiValue(), ConnectionClasses.DateServer.ReturnDateServer(), DateTime.Now.ToString("HH:mm:ss"), ConnectionClasses.DateServer.ServerTime(), ConnectionInfo.LoggedInUserId);

                if (result > 0)
                {
                    CustomMessageForm.CustomMessageBox.Show("پيغام سيستم", $"واحد كالا \"{txtGoodsUnitName.Text}\" با موفقيت ثبت شد", "i");
                    MaxID_ = result;
                    if (int.Parse(txtGoodsUnitID.Text) != MaxID_)
                    {
                        CustomMessageForm.CustomMessageBox.Show("پيغام سيستم", $"كد واحد كالا به {MaxID_} تغيير يافت", "i");
                    }
                    RefreshForm();
                }
                else if (result == 0)
                {
                    CustomMessageForm.CustomMessageBox.Show("خطا !", $"خطا در تعريف واحد كالا!\n\nلطفا جهت بررسي مشكل با پشتيباني تماس بگيريد", "e");
                }
            }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshForm();
            txtGoodsUnitName.Focus();
        }

        private void RefreshForm()
        {
            GoodsUnitDefinition_Load(null, null);
            txtGoodsUnitName.Clear();
            txtDescription.Clear();
        }

        private void txtGoodsUnitName_TextChanged(object sender, EventArgs e)
        {
            var goodsUnitList = @class.GetGoodsUnit().Where(i => i.Active && i.Name.Contains(txtGoodsUnitName.Text)).ToList();
            dgvGoodsUnit.DataSource = GoodsUnitListDataTable(goodsUnitList);
        }
    }
}
