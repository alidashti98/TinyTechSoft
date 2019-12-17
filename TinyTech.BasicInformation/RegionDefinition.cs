using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using TinyTech.Connection;
using TinyTech.Selecting;
using TinyTech.UI.Control.MessageBox;
using TinyTech.UI.Control.UIElement;

namespace TinyTech.UI.UserControl
{
    public class RegionDefinition : Control.UIElement.UserControl
    {
        #region Region 
        private Control.UIElement.Panel pnlRegionDefinition;
        private Control.UIElement.GroupBox groupBoxRegionDefinition;
        private Control.UIElement.Panel pnlButtons;
        private Control.Button.RefreshButton btnRefresh;
        private Control.Button.CancelButton btnCancel;
        private Control.Button.SaveButton btnSave;
        private Control.UIElement.Panel pnlMain;
        private Control.UIElement.DataGridView dgvRegion;
        ConnectionClasses @class = new ConnectionClasses();
        TabManagement @tab = new TabManagement();
        private int MaxID;
        private Control.Label.Label lblRegionName;
        private Control.Label.Label lblRegionID;
        private Control.Label.Label lblDescription;
        private Control.TextBox.TextBox txtDescription;
        private Control.TextBox.TextBox txtRegionName;
        private Control.TextBox.NumericTextBoxWithSeperator txtRegionID;
        private Control.Label.Label lblProvinceName;
        private Control.TextBox.TextBox txtProvinceName;
        private Control.CheckBox.CheckBox chkProvince;
        private Control.CheckBox.CheckBox chkCityName;
        private Control.TextBox.TextBox txtCityName;
        private Control.Label.Label lblCityName;
        private int MaxID_;
        private Container components = null;
        private Control.Label.Label lblDate;
        private Control.TextBox.DateControl dateControlRegion;
        TinyTechEntities DB_Connection = new TinyTechEntities();
        #endregion

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                components?.Dispose();
            }
            base.Dispose(disposing);
        }

        public RegionDefinition()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.pnlMain = new TinyTech.UI.Control.UIElement.Panel();
            this.dgvRegion = new TinyTech.UI.Control.UIElement.DataGridView();
            this.pnlRegionDefinition = new TinyTech.UI.Control.UIElement.Panel();
            this.groupBoxRegionDefinition = new TinyTech.UI.Control.UIElement.GroupBox();
            this.lblDate = new TinyTech.UI.Control.Label.Label();
            this.dateControlRegion = new TinyTech.UI.Control.TextBox.DateControl();
            this.chkProvince = new TinyTech.UI.Control.CheckBox.CheckBox();
            this.chkCityName = new TinyTech.UI.Control.CheckBox.CheckBox();
            this.txtCityName = new TinyTech.UI.Control.TextBox.TextBox();
            this.lblCityName = new TinyTech.UI.Control.Label.Label();
            this.txtProvinceName = new TinyTech.UI.Control.TextBox.TextBox();
            this.lblProvinceName = new TinyTech.UI.Control.Label.Label();
            this.txtRegionID = new TinyTech.UI.Control.TextBox.NumericTextBoxWithSeperator();
            this.txtDescription = new TinyTech.UI.Control.TextBox.TextBox();
            this.btnSave = new TinyTech.UI.Control.Button.SaveButton();
            this.btnRefresh = new TinyTech.UI.Control.Button.RefreshButton();
            this.btnCancel = new TinyTech.UI.Control.Button.CancelButton();
            this.txtRegionName = new TinyTech.UI.Control.TextBox.TextBox();
            this.lblRegionID = new TinyTech.UI.Control.Label.Label();
            this.lblDescription = new TinyTech.UI.Control.Label.Label();
            this.lblRegionName = new TinyTech.UI.Control.Label.Label();
            this.pnlButtons = new TinyTech.UI.Control.UIElement.Panel();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegion)).BeginInit();
            this.pnlRegionDefinition.SuspendLayout();
            this.groupBoxRegionDefinition.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.dgvRegion);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.pnlMain.Location = new System.Drawing.Point(0, 218);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlMain.Size = new System.Drawing.Size(800, 282);
            this.pnlMain.TabIndex = 1;
            // 
            // dgvRegion
            // 
            this.dgvRegion.AllowUserToAddRows = false;
            this.dgvRegion.AllowUserToDeleteRows = false;
            this.dgvRegion.AllowUserToOrderColumns = true;
            this.dgvRegion.AllowUserToResizeColumns = false;
            this.dgvRegion.AllowUserToResizeRows = false;
            this.dgvRegion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRegion.Location = new System.Drawing.Point(0, 0);
            this.dgvRegion.MultiSelect = false;
            this.dgvRegion.Name = "dgvRegion";
            this.dgvRegion.ReadOnly = true;
            this.dgvRegion.RowHeadersVisible = false;
            this.dgvRegion.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvRegion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRegion.Size = new System.Drawing.Size(800, 282);
            this.dgvRegion.TabIndex = 0;
            // 
            // pnlRegionDefinition
            // 
            this.pnlRegionDefinition.Controls.Add(this.groupBoxRegionDefinition);
            this.pnlRegionDefinition.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRegionDefinition.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.pnlRegionDefinition.Location = new System.Drawing.Point(0, 0);
            this.pnlRegionDefinition.Name = "pnlRegionDefinition";
            this.pnlRegionDefinition.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlRegionDefinition.Size = new System.Drawing.Size(800, 218);
            this.pnlRegionDefinition.TabIndex = 0;
            // 
            // groupBoxRegionDefinition
            // 
            this.groupBoxRegionDefinition.Controls.Add(this.lblDate);
            this.groupBoxRegionDefinition.Controls.Add(this.dateControlRegion);
            this.groupBoxRegionDefinition.Controls.Add(this.chkCityName);
            this.groupBoxRegionDefinition.Controls.Add(this.txtCityName);
            this.groupBoxRegionDefinition.Controls.Add(this.lblCityName);
            this.groupBoxRegionDefinition.Controls.Add(this.chkProvince);
            this.groupBoxRegionDefinition.Controls.Add(this.txtProvinceName);
            this.groupBoxRegionDefinition.Controls.Add(this.lblProvinceName);
            this.groupBoxRegionDefinition.Controls.Add(this.txtRegionID);
            this.groupBoxRegionDefinition.Controls.Add(this.txtDescription);
            this.groupBoxRegionDefinition.Controls.Add(this.txtRegionName);
            this.groupBoxRegionDefinition.Controls.Add(this.lblRegionID);
            this.groupBoxRegionDefinition.Controls.Add(this.lblDescription);
            this.groupBoxRegionDefinition.Controls.Add(this.lblRegionName);
            this.groupBoxRegionDefinition.Controls.Add(this.pnlButtons);
            this.groupBoxRegionDefinition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxRegionDefinition.Location = new System.Drawing.Point(0, 0);
            this.groupBoxRegionDefinition.Name = "groupBoxRegionDefinition";
            this.groupBoxRegionDefinition.Size = new System.Drawing.Size(800, 218);
            this.groupBoxRegionDefinition.TabIndex = 0;
            this.groupBoxRegionDefinition.TabStop = false;
            this.groupBoxRegionDefinition.Text = "تعريف منطقه";
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.lblDate.Location = new System.Drawing.Point(718, 27);
            this.lblDate.Name = "lblDate";
            this.lblDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblDate.Size = new System.Drawing.Size(40, 20);
            this.lblDate.TabIndex = 26;
            this.lblDate.Text = "تاريخ :";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateControlRegion
            // 
            this.dateControlRegion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateControlRegion.BackColor = System.Drawing.Color.White;
            this.dateControlRegion.CanGoBackward = true;
            this.dateControlRegion.CanGoForward = false;
            this.dateControlRegion.Enabled = false;
            this.dateControlRegion.Location = new System.Drawing.Point(585, 27);
            this.dateControlRegion.Name = "dateControlRegion";
            this.dateControlRegion.NextControl = this.chkProvince;
            this.dateControlRegion.NowShamsi8Character = "97/06/14";
            this.dateControlRegion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateControlRegion.ShamsiNow = "1397/06/14";
            this.dateControlRegion.Size = new System.Drawing.Size(120, 20);
            this.dateControlRegion.TabIndex = 0;
            this.dateControlRegion.Text = "dateControl1";
            this.dateControlRegion.Value10Cahracter = null;
            // 
            // chkProvince
            // 
            this.chkProvince.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkProvince.AutoSize = true;
            this.chkProvince.Location = new System.Drawing.Point(649, 60);
            this.chkProvince.Name = "chkProvince";
            this.chkProvince.NextControl = null;
            this.chkProvince.Size = new System.Drawing.Size(56, 24);
            this.chkProvince.TabIndex = 1;
            this.chkProvince.Text = "استان";
            this.chkProvince.UseVisualStyleBackColor = true;
            this.chkProvince.CheckedChanged += new System.EventHandler(this.chkProvince_CheckedChanged);
            // 
            // chkCityName
            // 
            this.chkCityName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkCityName.AutoSize = true;
            this.chkCityName.Location = new System.Drawing.Point(659, 98);
            this.chkCityName.Name = "chkCityName";
            this.chkCityName.NextControl = null;
            this.chkCityName.Size = new System.Drawing.Size(46, 24);
            this.chkCityName.TabIndex = 2;
            this.chkCityName.Text = "شهر";
            this.chkCityName.UseVisualStyleBackColor = true;
            this.chkCityName.CheckedChanged += new System.EventHandler(this.chkCityName_CheckedChanged);
            // 
            // txtCityName
            // 
            this.txtCityName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCityName.BackColor = System.Drawing.Color.White;
            this.txtCityName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCityName.Enabled = false;
            this.txtCityName.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.txtCityName.ForeColor = System.Drawing.Color.Gray;
            this.txtCityName.Location = new System.Drawing.Point(361, 97);
            this.txtCityName.Margin = new System.Windows.Forms.Padding(10);
            this.txtCityName.Name = "txtCityName";
            this.txtCityName.NextControl = null;
            this.txtCityName.ReadOnly = true;
            this.txtCityName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCityName.Size = new System.Drawing.Size(275, 28);
            this.txtCityName.TabIndex = 19;
            this.txtCityName.Text = "انتخاب شهر ...";
            this.txtCityName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCityName
            // 
            this.lblCityName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCityName.AutoSize = true;
            this.lblCityName.BackColor = System.Drawing.Color.Transparent;
            this.lblCityName.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.lblCityName.Location = new System.Drawing.Point(718, 99);
            this.lblCityName.Name = "lblCityName";
            this.lblCityName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblCityName.Size = new System.Drawing.Size(49, 20);
            this.lblCityName.TabIndex = 18;
            this.lblCityName.Text = "نام شهر :";
            this.lblCityName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtProvinceName
            // 
            this.txtProvinceName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProvinceName.BackColor = System.Drawing.Color.White;
            this.txtProvinceName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProvinceName.Enabled = false;
            this.txtProvinceName.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.txtProvinceName.ForeColor = System.Drawing.Color.Gray;
            this.txtProvinceName.Location = new System.Drawing.Point(361, 59);
            this.txtProvinceName.Margin = new System.Windows.Forms.Padding(10);
            this.txtProvinceName.Name = "txtProvinceName";
            this.txtProvinceName.NextControl = null;
            this.txtProvinceName.ReadOnly = true;
            this.txtProvinceName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtProvinceName.Size = new System.Drawing.Size(275, 28);
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
            this.lblProvinceName.Location = new System.Drawing.Point(718, 61);
            this.lblProvinceName.Name = "lblProvinceName";
            this.lblProvinceName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblProvinceName.Size = new System.Drawing.Size(59, 20);
            this.lblProvinceName.TabIndex = 13;
            this.lblProvinceName.Text = "نام استان :";
            this.lblProvinceName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtRegionID
            // 
            this.txtRegionID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRegionID.BackColor = System.Drawing.Color.White;
            this.txtRegionID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRegionID.Enabled = false;
            this.txtRegionID.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.txtRegionID.ForeColor = System.Drawing.Color.Black;
            this.txtRegionID.Location = new System.Drawing.Point(213, 135);
            this.txtRegionID.Margin = new System.Windows.Forms.Padding(10);
            this.txtRegionID.Name = "txtRegionID";
            this.txtRegionID.NextControl = null;
            this.txtRegionID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtRegionID.Size = new System.Drawing.Size(70, 28);
            this.txtRegionID.TabIndex = 12;
            this.txtRegionID.Text = "0";
            this.txtRegionID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRegionID.Value = 0D;
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.BackColor = System.Drawing.Color.White;
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescription.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.txtDescription.ForeColor = System.Drawing.Color.Black;
            this.txtDescription.Location = new System.Drawing.Point(361, 173);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(10);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.NextControl = this.btnSave;
            this.txtDescription.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDescription.Size = new System.Drawing.Size(344, 28);
            this.txtDescription.TabIndex = 4;
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
            this.btnCancel.NextControl = this.dateControlRegion;
            this.btnCancel.Size = new System.Drawing.Size(81, 34);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "انصراف";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtRegionName
            // 
            this.txtRegionName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRegionName.BackColor = System.Drawing.Color.White;
            this.txtRegionName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRegionName.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.txtRegionName.ForeColor = System.Drawing.Color.Black;
            this.txtRegionName.Location = new System.Drawing.Point(361, 135);
            this.txtRegionName.Margin = new System.Windows.Forms.Padding(10);
            this.txtRegionName.Name = "txtRegionName";
            this.txtRegionName.NextControl = this.txtDescription;
            this.txtRegionName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtRegionName.Size = new System.Drawing.Size(344, 28);
            this.txtRegionName.TabIndex = 3;
            this.txtRegionName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRegionName.TextChanged += new System.EventHandler(this.txtRegionName_TextChanged);
            // 
            // lblRegionID
            // 
            this.lblRegionID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRegionID.AutoSize = true;
            this.lblRegionID.BackColor = System.Drawing.Color.Transparent;
            this.lblRegionID.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.lblRegionID.Location = new System.Drawing.Point(296, 137);
            this.lblRegionID.Name = "lblRegionID";
            this.lblRegionID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblRegionID.Size = new System.Drawing.Size(60, 20);
            this.lblRegionID.TabIndex = 9;
            this.lblRegionID.Text = "كد منطقه :";
            this.lblRegionID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescription.AutoSize = true;
            this.lblDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblDescription.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.lblDescription.Location = new System.Drawing.Point(718, 175);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblDescription.Size = new System.Drawing.Size(60, 20);
            this.lblDescription.TabIndex = 8;
            this.lblDescription.Text = "توضيحات :";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRegionName
            // 
            this.lblRegionName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRegionName.AutoSize = true;
            this.lblRegionName.BackColor = System.Drawing.Color.Transparent;
            this.lblRegionName.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.lblRegionName.Location = new System.Drawing.Point(718, 137);
            this.lblRegionName.Name = "lblRegionName";
            this.lblRegionName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblRegionName.Size = new System.Drawing.Size(61, 20);
            this.lblRegionName.TabIndex = 2;
            this.lblRegionName.Text = "نام منطقه :";
            this.lblRegionName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlButtons
            // 
            this.pnlButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlButtons.Controls.Add(this.btnRefresh);
            this.pnlButtons.Controls.Add(this.btnCancel);
            this.pnlButtons.Controls.Add(this.btnSave);
            this.pnlButtons.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.pnlButtons.Location = new System.Drawing.Point(7, 167);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlButtons.Size = new System.Drawing.Size(260, 40);
            this.pnlButtons.TabIndex = 5;
            // 
            // RegionDefinition
            // 
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlRegionDefinition);
            this.Name = "RegionDefinition";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(800, 500);
            this.Tag = "تعريف منطقه";
            this.Load += new System.EventHandler(this.RegionDefinition_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RegionDefinition_KeyDown);
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegion)).EndInit();
            this.pnlRegionDefinition.ResumeLayout(false);
            this.groupBoxRegionDefinition.ResumeLayout(false);
            this.groupBoxRegionDefinition.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            @tab.CloseTab(this);
        }

        private void DisableForm()
        {
            txtRegionName.Enabled = txtDescription.Enabled = btnSave.Enabled = btnRefresh.Enabled = false;
        }

        private DataTable RegionListDataTable(List<Region> RegionList)
        {
            var dataTable = ToolBox<Region>.GetDataTable(RegionList);
            return dataTable;
        }

        private void RegionDefinition_Load(object sender, EventArgs e)
        {
            var regionList = @class.GetRegion(true).ToList();
            dgvRegion.DataSource = regionList; //RegionListDataTable(RegionList);
            SetGridView();
            txtRegionID.Text = CalculateMaxId().ToString();
            chkProvince.Focus();
        }

        private int CalculateMaxId()
        {
            if (@class.GetRegion().Count <= 0) return 1;
            var max = @class.GetRegion().Max(i => i.ID) + 1;
            return max;
        }

        private void SetGridView()
        {
            foreach (DataGridViewColumn item in dgvRegion.Columns)
            {
                item.Visible = false;
            }
            dgvRegion.Columns["ID"].Visible = true;
            dgvRegion.Columns["Name"].Visible = true;
            dgvRegion.Columns["Description"].Visible = true;

            dgvRegion.Columns["ID"].HeaderText = "كد";
            dgvRegion.Columns["Name"].HeaderText = "نام";
            dgvRegion.Columns["Description"].HeaderText = "توضيحات";


            dgvRegion.Columns["ID"].DisplayIndex = 0;
            dgvRegion.Columns["Name"].DisplayIndex = 1;
            dgvRegion.Columns["Description"].DisplayIndex = 3;

            dgvRegion.Columns["ID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvRegion.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvRegion.Columns["Description"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvRegion.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvRegion.Columns["ID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvRegion.Columns["Name"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvRegion.Columns["Description"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            dgvRegion.AutoGenerateColumns = false;

        }

        private void RegionDefinition_KeyDown(object sender, KeyEventArgs e)
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
                CustomMessageForm.CustomMessageBox.Show("اخطار", "لطفا استان را انتخاب كنيد", "e");
                chkProvince.Focus();
                return false;
            }

            if (!chkCityName.Checked)
            {
                CustomMessageForm.CustomMessageBox.Show("اخطار", "لطفا شهر را انتخاب كنيد", "e");
                chkCityName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtRegionName.Text))
            {
                CustomMessageForm.CustomMessageBox.Show("اخطار", "لطفا نام منطقه را وارد كنيد", "e");
                txtRegionName.Focus();
                return false;
            }
            if (@class.GetRegion(true).Count(i => i.Name.Equals(txtRegionName.Text)) > 0)
            {
                CustomMessageForm.CustomMessageBox.Show("اخطار !", $"نام منطقه \"{txtRegionName.Text}\" تكراري است!", "e");
                txtRegionName.Focus();
                return false;
            }

            return true;
        }

        private void SaveProcess()
        {
            if (FormValidate())
            {
                var result = @class.RegionDefinition(txtRegionName.Text, int.Parse(txtCityName.Tag.ToString()), txtDescription.Text, dateControlRegion.ShamsiValue(), ConnectionClasses.DateServer.ReturnDateServer(), DateTime.Now.ToString("HH:mm:ss"), ConnectionClasses.DateServer.ServerTime(), ConnectionInfo.LoggedInUserId);

                if (result > 0)
                {
                    CustomMessageForm.CustomMessageBox.Show("پيغام سيستم", $"منطقه \"{txtRegionName.Text}\" با موفقيت ثبت شد", "i");
                    MaxID_ = result;
                    if (int.Parse(txtRegionID.Value.ToString()) != MaxID_)
                    {
                        CustomMessageForm.CustomMessageBox.Show("پيغام سيستم", $"كد منطقه به {MaxID_} تغيير يافت", "i");
                    }
                    RefreshForm();
                }
                else if (result == 0)
                {
                    CustomMessageForm.CustomMessageBox.Show("خطا !", $"خطا در تعريف منطقه!\n\nلطفا جهت بررسي مشكل با پشتيباني تماس بگيريد", "e");
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveProcess();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshForm();
        }

        private void RefreshForm()
        {
            RegionDefinition_Load(null, null);
            txtRegionName.Text = txtDescription.Text = string.Empty;
            chkCityName.Checked = chkProvince.Checked = false;
        }

        private void txtRegionName_TextChanged(object sender, EventArgs e)
        {
            var regionList = @class.GetRegion(true).Where(i => i.Name.Contains(txtRegionName.Text)).ToList();
            dgvRegion.DataSource = regionList; //RegionListDataTable(RegionList);
        }

        private void chkProvince_CheckedChanged(object sender, EventArgs e)
        {
            if (chkProvince.Checked)
            {
                var provinceList = new List<Province>();
                new UserControlLoader(new ProvinceSelect(provinceList), true, false, true);

                if (provinceList.Count() > 0)
                {
                    txtProvinceName.Text = provinceList.FirstOrDefault().Name;
                    txtProvinceName.Tag = provinceList.FirstOrDefault().ID;
                    chkCityName.Focus();
                }
                else
                {
                    txtProvinceName.Text = "انتخاب استان ...";
                    txtProvinceName.Tag = string.Empty;
                    chkProvince.Checked = chkCityName.Checked = false;
                    var RegionList = @class.GetRegion(true).ToList();
                    dgvRegion.DataSource = RegionList; //RegionListDataTable(RegionList);
                    chkProvince.Focus();
                    DisableForm();
                }
            }
            else if (!chkProvince.Checked)
            {
                txtProvinceName.Text = "انتخاب استان ...";
                txtProvinceName.Tag = string.Empty;
                chkCityName.Checked = false;
                var RegionList = @class.GetRegion(true).ToList();
                dgvRegion.DataSource = RegionList; //RegionListDataTable(RegionList);
                DisableForm();
            }
        }

        private void chkCityName_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkProvince.Checked && chkCityName.Checked)
            {
                CustomMessageForm.CustomMessageBox.Show("اخطار !", "لطفا ابتدا استان را انتخاب كنيد !", "e");
                chkProvince.Focus();
                chkCityName.Checked = false;
                return;
            }

            if (chkProvince.Checked && chkCityName.Checked)
            {
                var cityList = new List<City>();
                new UserControlLoader(new CitySelect(cityList, int.Parse(txtProvinceName.Tag.ToString())), true, false, true);

                if (cityList.Count > 0)
                {
                    txtCityName.Text = cityList.FirstOrDefault().Name;
                    txtCityName.Tag = cityList.FirstOrDefault().ID;
                    txtRegionName.Select();

                    //var RegionList = @class.GetRegion().Where(i => i.Active && i.ProvinceID == int.Parse(txtProvinceName.Tag.ToString())).ToList();
                    //dgvRegion.DataSource = RegionListDataTable(RegionList);
                    //txtRegionName.Focus();
                }
                else
                {
                    txtCityName.Text = "انتخاب شهر ...";
                    txtCityName.Tag = string.Empty;
                    chkCityName.Checked = false;
                    var regionList = @class.GetRegion(true).ToList();
                    dgvRegion.DataSource = regionList; //RegionListDataTable(RegionList);
                    chkProvince.Focus();
                    DisableForm();
                }
            }
            else if (!chkProvince.Checked)
            {
                txtCityName.Text = "انتخاب شهر ...";
                txtCityName.Tag = string.Empty;
                var regionList = @class.GetRegion(true).ToList();
                dgvRegion.DataSource = regionList; //RegionListDataTable(RegionList);
                DisableForm();
            }
        }
    }
}
