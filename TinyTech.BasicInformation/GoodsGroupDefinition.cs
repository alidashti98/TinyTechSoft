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
    public class GoodsGroupDefinition : UserControl
    {
        #region Region 
        private UI.Control.UIElement.Panel pnlGoodsGroupDefinition;
        private UI.Control.UIElement.GroupBox groupBoxGoodsGroupDefinition;
        private UI.Control.UIElement.Panel pnlButtons;
        private UI.Control.Button.RefreshButton btnRefresh;
        private UI.Control.Button.CancelButton btnCancel;
        private UI.Control.Button.SaveButton btnSave;
        private UI.Control.UIElement.Panel pnlMain;
        private UI.Control.UIElement.DataGridView dgvGoodsGroup;
        ConnectionClasses @class = new ConnectionClasses();
        TabManagement @tab = new TabManagement();
        private int MaxID;
        private UI.Control.Label.Label lblGoodsGroupName;
        private UI.Control.Label.Label lblGoodsGroupID;
        private UI.Control.Label.Label lblDescription;
        private UI.Control.TextBox.TextBox txtDescription;
        private UI.Control.TextBox.TextBox txtGoodsGroupName;
        private UI.Control.TextBox.NumericTextBoxWithSeperator txtGoodsGroupID;
        private int MaxID_;
        TinyTechEntities DB_Connection = new TinyTechEntities();
        private Container components = null;
        private UI.Control.Label.Label lblCanNegative;
        private UI.Control.UIElement.Panel pnlCanNegative;
        private UI.Control.RadioButton.RadioButton radioCanNotNegative;
        private UI.Control.RadioButton.RadioButton radioCanNegative;
        private UI.Control.Label.Label lblDate;
        private UI.Control.TextBox.DateControl dateControlGoodsGroup;
        private bool CanNegative = true;
        #endregion

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                components?.Dispose();
            }
            base.Dispose(disposing);
        }

        public GoodsGroupDefinition()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.pnlMain = new TinyTech.UI.Control.UIElement.Panel();
            this.dgvGoodsGroup = new TinyTech.UI.Control.UIElement.DataGridView();
            this.pnlGoodsGroupDefinition = new TinyTech.UI.Control.UIElement.Panel();
            this.groupBoxGoodsGroupDefinition = new TinyTech.UI.Control.UIElement.GroupBox();
            this.lblDate = new TinyTech.UI.Control.Label.Label();
            this.dateControlGoodsGroup = new TinyTech.UI.Control.TextBox.DateControl();
            this.txtGoodsGroupName = new TinyTech.UI.Control.TextBox.TextBox();
            this.pnlCanNegative = new TinyTech.UI.Control.UIElement.Panel();
            this.radioCanNotNegative = new TinyTech.UI.Control.RadioButton.RadioButton();
            this.txtDescription = new TinyTech.UI.Control.TextBox.TextBox();
            this.btnSave = new TinyTech.UI.Control.Button.SaveButton();
            this.btnRefresh = new TinyTech.UI.Control.Button.RefreshButton();
            this.btnCancel = new TinyTech.UI.Control.Button.CancelButton();
            this.radioCanNegative = new TinyTech.UI.Control.RadioButton.RadioButton();
            this.lblCanNegative = new TinyTech.UI.Control.Label.Label();
            this.txtGoodsGroupID = new TinyTech.UI.Control.TextBox.NumericTextBoxWithSeperator();
            this.lblGoodsGroupID = new TinyTech.UI.Control.Label.Label();
            this.lblDescription = new TinyTech.UI.Control.Label.Label();
            this.lblGoodsGroupName = new TinyTech.UI.Control.Label.Label();
            this.pnlButtons = new TinyTech.UI.Control.UIElement.Panel();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoodsGroup)).BeginInit();
            this.pnlGoodsGroupDefinition.SuspendLayout();
            this.groupBoxGoodsGroupDefinition.SuspendLayout();
            this.pnlCanNegative.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.dgvGoodsGroup);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.pnlMain.Location = new System.Drawing.Point(0, 171);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlMain.Size = new System.Drawing.Size(800, 329);
            this.pnlMain.TabIndex = 1;
            // 
            // dgvGoodsGroup
            // 
            this.dgvGoodsGroup.AllowUserToAddRows = false;
            this.dgvGoodsGroup.AllowUserToDeleteRows = false;
            this.dgvGoodsGroup.AllowUserToOrderColumns = true;
            this.dgvGoodsGroup.AllowUserToResizeColumns = false;
            this.dgvGoodsGroup.AllowUserToResizeRows = false;
            this.dgvGoodsGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGoodsGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGoodsGroup.Location = new System.Drawing.Point(0, 0);
            this.dgvGoodsGroup.MultiSelect = false;
            this.dgvGoodsGroup.Name = "dgvGoodsGroup";
            this.dgvGoodsGroup.ReadOnly = true;
            this.dgvGoodsGroup.RowHeadersVisible = false;
            this.dgvGoodsGroup.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvGoodsGroup.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGoodsGroup.Size = new System.Drawing.Size(800, 329);
            this.dgvGoodsGroup.TabIndex = 1;
            // 
            // pnlGoodsGroupDefinition
            // 
            this.pnlGoodsGroupDefinition.Controls.Add(this.groupBoxGoodsGroupDefinition);
            this.pnlGoodsGroupDefinition.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlGoodsGroupDefinition.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.pnlGoodsGroupDefinition.Location = new System.Drawing.Point(0, 0);
            this.pnlGoodsGroupDefinition.Name = "pnlGoodsGroupDefinition";
            this.pnlGoodsGroupDefinition.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlGoodsGroupDefinition.Size = new System.Drawing.Size(800, 171);
            this.pnlGoodsGroupDefinition.TabIndex = 0;
            // 
            // groupBoxGoodsGroupDefinition
            // 
            this.groupBoxGoodsGroupDefinition.Controls.Add(this.lblDate);
            this.groupBoxGoodsGroupDefinition.Controls.Add(this.dateControlGoodsGroup);
            this.groupBoxGoodsGroupDefinition.Controls.Add(this.lblCanNegative);
            this.groupBoxGoodsGroupDefinition.Controls.Add(this.pnlCanNegative);
            this.groupBoxGoodsGroupDefinition.Controls.Add(this.txtGoodsGroupID);
            this.groupBoxGoodsGroupDefinition.Controls.Add(this.txtDescription);
            this.groupBoxGoodsGroupDefinition.Controls.Add(this.txtGoodsGroupName);
            this.groupBoxGoodsGroupDefinition.Controls.Add(this.lblGoodsGroupID);
            this.groupBoxGoodsGroupDefinition.Controls.Add(this.lblDescription);
            this.groupBoxGoodsGroupDefinition.Controls.Add(this.lblGoodsGroupName);
            this.groupBoxGoodsGroupDefinition.Controls.Add(this.pnlButtons);
            this.groupBoxGoodsGroupDefinition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxGoodsGroupDefinition.Location = new System.Drawing.Point(0, 0);
            this.groupBoxGoodsGroupDefinition.Name = "groupBoxGoodsGroupDefinition";
            this.groupBoxGoodsGroupDefinition.Size = new System.Drawing.Size(800, 171);
            this.groupBoxGoodsGroupDefinition.TabIndex = 0;
            this.groupBoxGoodsGroupDefinition.TabStop = false;
            this.groupBoxGoodsGroupDefinition.Text = "تعريف گروه كالا";
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.lblDate.Location = new System.Drawing.Point(704, 27);
            this.lblDate.Name = "lblDate";
            this.lblDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblDate.Size = new System.Drawing.Size(40, 20);
            this.lblDate.TabIndex = 22;
            this.lblDate.Text = "تاريخ :";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateControlGoodsGroup
            // 
            this.dateControlGoodsGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateControlGoodsGroup.BackColor = System.Drawing.Color.White;
            this.dateControlGoodsGroup.CanGoBackward = true;
            this.dateControlGoodsGroup.CanGoForward = false;
            this.dateControlGoodsGroup.Location = new System.Drawing.Point(571, 27);
            this.dateControlGoodsGroup.Name = "dateControlGoodsGroup";
            this.dateControlGoodsGroup.NextControl = this.txtGoodsGroupName;
            this.dateControlGoodsGroup.NowShamsi8Character = "97/06/14";
            this.dateControlGoodsGroup.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateControlGoodsGroup.ShamsiNow = "1397/06/14";
            this.dateControlGoodsGroup.Size = new System.Drawing.Size(120, 20);
            this.dateControlGoodsGroup.TabIndex = 0;
            this.dateControlGoodsGroup.Text = "dateControl1";
            this.dateControlGoodsGroup.Value10Cahracter = null;
            // 
            // txtGoodsGroupName
            // 
            this.txtGoodsGroupName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGoodsGroupName.BackColor = System.Drawing.Color.White;
            this.txtGoodsGroupName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGoodsGroupName.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.txtGoodsGroupName.ForeColor = System.Drawing.Color.Black;
            this.txtGoodsGroupName.Location = new System.Drawing.Point(491, 60);
            this.txtGoodsGroupName.Margin = new System.Windows.Forms.Padding(10);
            this.txtGoodsGroupName.Name = "txtGoodsGroupName";
            this.txtGoodsGroupName.NextControl = this.pnlCanNegative;
            this.txtGoodsGroupName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtGoodsGroupName.Size = new System.Drawing.Size(200, 28);
            this.txtGoodsGroupName.TabIndex = 1;
            this.txtGoodsGroupName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtGoodsGroupName.TextChanged += new System.EventHandler(this.txtGoodsGroupName_TextChanged);
            // 
            // pnlCanNegative
            // 
            this.pnlCanNegative.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCanNegative.Controls.Add(this.radioCanNotNegative);
            this.pnlCanNegative.Controls.Add(this.radioCanNegative);
            this.pnlCanNegative.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.pnlCanNegative.Location = new System.Drawing.Point(560, 94);
            this.pnlCanNegative.Name = "pnlCanNegative";
            this.pnlCanNegative.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlCanNegative.Size = new System.Drawing.Size(131, 36);
            this.pnlCanNegative.TabIndex = 2;
            this.pnlCanNegative.Enter += new System.EventHandler(this.pnlCanNegative_Enter);
            // 
            // radioCanNotNegative
            // 
            this.radioCanNotNegative.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioCanNotNegative.AutoSize = true;
            this.radioCanNotNegative.BackColor = System.Drawing.Color.Transparent;
            this.radioCanNotNegative.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.radioCanNotNegative.Location = new System.Drawing.Point(5, 6);
            this.radioCanNotNegative.Name = "radioCanNotNegative";
            this.radioCanNotNegative.NextControl = this.txtDescription;
            this.radioCanNotNegative.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioCanNotNegative.Size = new System.Drawing.Size(43, 24);
            this.radioCanNotNegative.TabIndex = 1;
            this.radioCanNotNegative.TabStop = true;
            this.radioCanNotNegative.Text = "خير";
            this.radioCanNotNegative.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioCanNotNegative.UseVisualStyleBackColor = false;
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.BackColor = System.Drawing.Color.White;
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescription.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.txtDescription.ForeColor = System.Drawing.Color.Black;
            this.txtDescription.Location = new System.Drawing.Point(491, 135);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(10);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.NextControl = this.btnSave;
            this.txtDescription.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDescription.Size = new System.Drawing.Size(200, 28);
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
            this.btnCancel.NextControl = this.dateControlGoodsGroup;
            this.btnCancel.Size = new System.Drawing.Size(81, 34);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "انصراف";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // radioCanNegative
            // 
            this.radioCanNegative.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioCanNegative.AutoSize = true;
            this.radioCanNegative.BackColor = System.Drawing.Color.Transparent;
            this.radioCanNegative.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.radioCanNegative.Location = new System.Drawing.Point(74, 6);
            this.radioCanNegative.Name = "radioCanNegative";
            this.radioCanNegative.NextControl = this.txtDescription;
            this.radioCanNegative.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioCanNegative.Size = new System.Drawing.Size(40, 24);
            this.radioCanNegative.TabIndex = 0;
            this.radioCanNegative.TabStop = true;
            this.radioCanNegative.Text = "بله";
            this.radioCanNegative.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioCanNegative.UseVisualStyleBackColor = false;
            this.radioCanNegative.CheckedChanged += new System.EventHandler(this.radioCanNegative_CheckedChanged);
            // 
            // lblCanNegative
            // 
            this.lblCanNegative.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCanNegative.AutoSize = true;
            this.lblCanNegative.BackColor = System.Drawing.Color.Transparent;
            this.lblCanNegative.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.lblCanNegative.Location = new System.Drawing.Point(704, 102);
            this.lblCanNegative.Name = "lblCanNegative";
            this.lblCanNegative.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblCanNegative.Size = new System.Drawing.Size(96, 20);
            this.lblCanNegative.TabIndex = 16;
            this.lblCanNegative.Text = "امكان منفي شدن :";
            this.lblCanNegative.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtGoodsGroupID
            // 
            this.txtGoodsGroupID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGoodsGroupID.BackColor = System.Drawing.Color.White;
            this.txtGoodsGroupID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGoodsGroupID.Enabled = false;
            this.txtGoodsGroupID.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.txtGoodsGroupID.ForeColor = System.Drawing.Color.Black;
            this.txtGoodsGroupID.Location = new System.Drawing.Point(352, 60);
            this.txtGoodsGroupID.Margin = new System.Windows.Forms.Padding(10);
            this.txtGoodsGroupID.Name = "txtGoodsGroupID";
            this.txtGoodsGroupID.NextControl = null;
            this.txtGoodsGroupID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtGoodsGroupID.Size = new System.Drawing.Size(54, 28);
            this.txtGoodsGroupID.TabIndex = 12;
            this.txtGoodsGroupID.Text = "0";
            this.txtGoodsGroupID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtGoodsGroupID.Value = 0D;
            // 
            // lblGoodsGroupID
            // 
            this.lblGoodsGroupID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGoodsGroupID.AutoSize = true;
            this.lblGoodsGroupID.BackColor = System.Drawing.Color.Transparent;
            this.lblGoodsGroupID.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.lblGoodsGroupID.Location = new System.Drawing.Point(419, 62);
            this.lblGoodsGroupID.Name = "lblGoodsGroupID";
            this.lblGoodsGroupID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblGoodsGroupID.Size = new System.Drawing.Size(68, 20);
            this.lblGoodsGroupID.TabIndex = 9;
            this.lblGoodsGroupID.Text = "كد گروه كالا :";
            this.lblGoodsGroupID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescription.AutoSize = true;
            this.lblDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblDescription.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.lblDescription.Location = new System.Drawing.Point(704, 137);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblDescription.Size = new System.Drawing.Size(60, 20);
            this.lblDescription.TabIndex = 8;
            this.lblDescription.Text = "توضيحات :";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGoodsGroupName
            // 
            this.lblGoodsGroupName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGoodsGroupName.AutoSize = true;
            this.lblGoodsGroupName.BackColor = System.Drawing.Color.Transparent;
            this.lblGoodsGroupName.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.lblGoodsGroupName.Location = new System.Drawing.Point(704, 62);
            this.lblGoodsGroupName.Name = "lblGoodsGroupName";
            this.lblGoodsGroupName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblGoodsGroupName.Size = new System.Drawing.Size(69, 20);
            this.lblGoodsGroupName.TabIndex = 7;
            this.lblGoodsGroupName.Text = "نام گروه كالا :";
            this.lblGoodsGroupName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.pnlButtons.Size = new System.Drawing.Size(260, 40);
            this.pnlButtons.TabIndex = 4;
            // 
            // GoodsGroupDefinition
            // 
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlGoodsGroupDefinition);
            this.Name = "GoodsGroupDefinition";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(800, 500);
            this.Tag = "تعريف گروه كالا";
            this.Load += new System.EventHandler(this.GoodsGroupDefinition_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GoodsGroupDefinition_KeyDown);
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoodsGroup)).EndInit();
            this.pnlGoodsGroupDefinition.ResumeLayout(false);
            this.groupBoxGoodsGroupDefinition.ResumeLayout(false);
            this.groupBoxGoodsGroupDefinition.PerformLayout();
            this.pnlCanNegative.ResumeLayout(false);
            this.pnlCanNegative.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            @tab.CloseTab(this);
        }

        private DataTable GoodsGroupListDataTable(List<GoodsGroup> goodsGroupList)
        {
            var dataTable = UI.Control.UIElement.ToolBox<GoodsGroup>.GetDataTable(goodsGroupList);
            return dataTable;
        }

        private void GoodsGroupDefinition_Load(object sender, EventArgs e)
        {
            var goodsGroupList = @class.GetGoodsGroup().Where(i => i.Active).ToList();
            dgvGoodsGroup.DataSource = GoodsGroupListDataTable(goodsGroupList);
            SetGridView();
            txtGoodsGroupID.Text = CalculateMaxId().ToString();
            txtGoodsGroupName.Focus();
            radioCanNegative.Checked = true;
        }

        private int CalculateMaxId()
        {
            if (@class.GetGoodsGroup().Count <= 0) return 1;
            var max = @class.GetGoodsGroup().Max(i => i.ID) + 1;
            return max;
        }

        private void SetGridView()
        {
            foreach (DataGridViewColumn item in dgvGoodsGroup.Columns)
            {
                item.Visible = false;
            }
            dgvGoodsGroup.Columns["ID"].Visible = true;
            dgvGoodsGroup.Columns["Name"].Visible = true;
            dgvGoodsGroup.Columns["Description"].Visible = true;

            dgvGoodsGroup.Columns["ID"].HeaderText = "كد";
            dgvGoodsGroup.Columns["Name"].HeaderText = "نام";
            dgvGoodsGroup.Columns["Description"].HeaderText = "توضيحات";


            dgvGoodsGroup.Columns["ID"].DisplayIndex = 0;
            dgvGoodsGroup.Columns["Name"].DisplayIndex = 1;
            dgvGoodsGroup.Columns["Description"].DisplayIndex = 3;

            dgvGoodsGroup.Columns["ID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvGoodsGroup.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvGoodsGroup.Columns["Description"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvGoodsGroup.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvGoodsGroup.Columns["ID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvGoodsGroup.Columns["Name"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvGoodsGroup.Columns["Description"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            dgvGoodsGroup.AutoGenerateColumns = false;

        }

        private void GoodsGroupDefinition_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                @tab.CloseTab(this);
            }
        }

        private bool FormValidate()
        {
            if (string.IsNullOrWhiteSpace(txtGoodsGroupName.Text))
            {
                CustomMessageForm.CustomMessageBox.Show("اخطار", "لطفا نام گروه كالا را وارد كنيد", "e");
                txtGoodsGroupName.Focus();
                return false;
            }
            if (DB_Connection.GoodsGroup.AsNoTracking().Count(i => i.Name.Equals(txtGoodsGroupName.Text) && i.Active) > 0)
            {
                CustomMessageForm.CustomMessageBox.Show("اخطار !", $"نام گروه كالا \"{txtGoodsGroupName.Text}\" تكراري است!", "e");
                txtGoodsGroupName.Focus();
                return false;
            }

            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (FormValidate())
            {
                var result = @class.GoodsGroupDefinition(txtGoodsGroupName.Text, CanNegative, txtDescription.Text, dateControlGoodsGroup.ShamsiValue(), ConnectionClasses.DateServer.ReturnDateServer(), DateTime.Now.ToString("HH:mm:ss"), ConnectionClasses.DateServer.ServerTime(), ConnectionInfo.LoggedInUserId);

                if (result > 0)
                {
                    CustomMessageForm.CustomMessageBox.Show("پيغام سيستم", $"گروه كالا \"{txtGoodsGroupName.Text}\" با موفقيت ثبت شد", "i");
                    MaxID_ = result;
                    if (int.Parse(txtGoodsGroupID.Text) != MaxID_)
                    {
                        CustomMessageForm.CustomMessageBox.Show("پيغام سيستم", $"كد گروه كالا به {MaxID_} تغيير يافت", "i");
                    }
                    RefreshForm();
                }
                else if (result == 0)
                {
                    CustomMessageForm.CustomMessageBox.Show("خطا !", $"خطا در تعريف گروه كالا!\n\nلطفا جهت بررسي مشكل با پشتيباني تماس بگيريد", "e");
                }
            }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshForm();
            txtGoodsGroupName.Focus();
        }

        private void RefreshForm()
        {
            GoodsGroupDefinition_Load(null, null);
            txtGoodsGroupName.Clear();
            txtDescription.Clear();
        }

        private void txtGoodsGroupName_TextChanged(object sender, EventArgs e)
        {
            var goodsGroupList = @class.GetGoodsGroup().Where(i => i.Active && i.Name.Contains(txtGoodsGroupName.Text)).ToList();
            dgvGoodsGroup.DataSource = GoodsGroupListDataTable(goodsGroupList);
        }

        private void radioCanNegative_CheckedChanged(object sender, EventArgs e)
        {
            if (radioCanNegative.Checked)
            {
                radioCanNotNegative.Checked = false;
                CanNegative = true;
            }
            else if (radioCanNotNegative.Checked)
            {
                radioCanNegative.Checked = false;
                CanNegative = false;
            }
        }

        private void pnlCanNegative_Enter(object sender, EventArgs e)
        {
            if (radioCanNegative.Checked)
            {
                radioCanNegative.Focus();
            }
            else if (radioCanNotNegative.Checked)
            {
                radioCanNotNegative.Focus();
            }
        }
    }
}
