using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using TinyTech.Connection;
using TinyTech.UI.Control.MessageBox;
using TinyTech.UI.Control.UIElement;
using TinyTech.UI.UserControl;
using TinyTech.Selecting;
using UserControl = TinyTech.UI.Control.UIElement.UserControl;

namespace TinyTech.BasicInformation
{
    public class PathDefinition : UserControl
    {
        #region Region
        private UI.Control.UIElement.Panel pnlPathDefinition;
        private UI.Control.UIElement.GroupBox groupBoxPathDefinition;
        private UI.Control.UIElement.Panel pnlButtons;
        private UI.Control.Button.RefreshButton btnRefresh;
        private UI.Control.Button.EditButton btnEdit;
        private UI.Control.Button.CancelButton btnCancel;
        private UI.Control.Button.SaveButton btnSave;
        private UI.Control.UIElement.Panel pnlMain;
        private UI.Control.UIElement.DataGridView dgvPath;
        ConnectionClasses @class = new ConnectionClasses();
        TabManagement @tab = new TabManagement();
        private int MaxID;
        private UI.Control.Label.Label lblPathName;
        private UI.Control.Label.Label lblPathID;
        private UI.Control.Label.Label lblDescription;
        private UI.Control.TextBox.TextBox txtDescription;
        private UI.Control.TextBox.TextBox txtPathName;
        private UI.Control.TextBox.NumericTextBoxWithSeperator txtPathID;
        private UI.Control.Label.Label lblProvinceName;
        private UI.Control.TextBox.TextBox txtProvinceName;
        private UI.Control.CheckBox.CheckBox chkProvince;
        private UI.Control.CheckBox.CheckBox chkCityName;
        private UI.Control.TextBox.TextBox txtCityName;
        private UI.Control.Label.Label lblCityName;
        private int MaxID_;
        private Container components = null;
        private UI.Control.CheckBox.CheckBox chkRegionName;
        private UI.Control.TextBox.TextBox txtRegionName;
        private UI.Control.Label.Label lblRegionName;
        private UI.Control.Label.Label lblDate;
        private UI.Control.TextBox.DateControl dateControlPath;
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

        public PathDefinition()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.pnlMain = new TinyTech.UI.Control.UIElement.Panel();
            this.dgvPath = new TinyTech.UI.Control.UIElement.DataGridView();
            this.pnlPathDefinition = new TinyTech.UI.Control.UIElement.Panel();
            this.groupBoxPathDefinition = new TinyTech.UI.Control.UIElement.GroupBox();
            this.lblDate = new TinyTech.UI.Control.Label.Label();
            this.dateControlPath = new TinyTech.UI.Control.TextBox.DateControl();
            this.chkProvince = new TinyTech.UI.Control.CheckBox.CheckBox();
            this.chkRegionName = new TinyTech.UI.Control.CheckBox.CheckBox();
            this.txtRegionName = new TinyTech.UI.Control.TextBox.TextBox();
            this.lblRegionName = new TinyTech.UI.Control.Label.Label();
            this.chkCityName = new TinyTech.UI.Control.CheckBox.CheckBox();
            this.txtCityName = new TinyTech.UI.Control.TextBox.TextBox();
            this.lblCityName = new TinyTech.UI.Control.Label.Label();
            this.txtProvinceName = new TinyTech.UI.Control.TextBox.TextBox();
            this.lblProvinceName = new TinyTech.UI.Control.Label.Label();
            this.txtPathID = new TinyTech.UI.Control.TextBox.NumericTextBoxWithSeperator();
            this.txtDescription = new TinyTech.UI.Control.TextBox.TextBox();
            this.btnSave = new TinyTech.UI.Control.Button.SaveButton();
            this.btnRefresh = new TinyTech.UI.Control.Button.RefreshButton();
            this.btnCancel = new TinyTech.UI.Control.Button.CancelButton();
            this.txtPathName = new TinyTech.UI.Control.TextBox.TextBox();
            this.lblPathID = new TinyTech.UI.Control.Label.Label();
            this.lblDescription = new TinyTech.UI.Control.Label.Label();
            this.lblPathName = new TinyTech.UI.Control.Label.Label();
            this.pnlButtons = new TinyTech.UI.Control.UIElement.Panel();
            this.btnEdit = new TinyTech.UI.Control.Button.EditButton();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPath)).BeginInit();
            this.pnlPathDefinition.SuspendLayout();
            this.groupBoxPathDefinition.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.dgvPath);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.pnlMain.Location = new System.Drawing.Point(0, 251);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlMain.Size = new System.Drawing.Size(800, 249);
            this.pnlMain.TabIndex = 1;
            // 
            // dgvPath
            // 
            this.dgvPath.AllowUserToAddRows = false;
            this.dgvPath.AllowUserToDeleteRows = false;
            this.dgvPath.AllowUserToOrderColumns = true;
            this.dgvPath.AllowUserToResizeColumns = false;
            this.dgvPath.AllowUserToResizeRows = false;
            this.dgvPath.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPath.Location = new System.Drawing.Point(0, 0);
            this.dgvPath.MultiSelect = false;
            this.dgvPath.Name = "dgvPath";
            this.dgvPath.ReadOnly = true;
            this.dgvPath.RowHeadersVisible = false;
            this.dgvPath.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPath.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPath.Size = new System.Drawing.Size(800, 249);
            this.dgvPath.TabIndex = 0;
            // 
            // pnlPathDefinition
            // 
            this.pnlPathDefinition.Controls.Add(this.groupBoxPathDefinition);
            this.pnlPathDefinition.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPathDefinition.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.pnlPathDefinition.Location = new System.Drawing.Point(0, 0);
            this.pnlPathDefinition.Name = "pnlPathDefinition";
            this.pnlPathDefinition.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlPathDefinition.Size = new System.Drawing.Size(800, 251);
            this.pnlPathDefinition.TabIndex = 0;
            // 
            // groupBoxPathDefinition
            // 
            this.groupBoxPathDefinition.Controls.Add(this.lblDate);
            this.groupBoxPathDefinition.Controls.Add(this.dateControlPath);
            this.groupBoxPathDefinition.Controls.Add(this.chkRegionName);
            this.groupBoxPathDefinition.Controls.Add(this.txtRegionName);
            this.groupBoxPathDefinition.Controls.Add(this.lblRegionName);
            this.groupBoxPathDefinition.Controls.Add(this.chkCityName);
            this.groupBoxPathDefinition.Controls.Add(this.txtCityName);
            this.groupBoxPathDefinition.Controls.Add(this.lblCityName);
            this.groupBoxPathDefinition.Controls.Add(this.chkProvince);
            this.groupBoxPathDefinition.Controls.Add(this.txtProvinceName);
            this.groupBoxPathDefinition.Controls.Add(this.lblProvinceName);
            this.groupBoxPathDefinition.Controls.Add(this.txtPathID);
            this.groupBoxPathDefinition.Controls.Add(this.txtDescription);
            this.groupBoxPathDefinition.Controls.Add(this.txtPathName);
            this.groupBoxPathDefinition.Controls.Add(this.lblPathID);
            this.groupBoxPathDefinition.Controls.Add(this.lblDescription);
            this.groupBoxPathDefinition.Controls.Add(this.lblPathName);
            this.groupBoxPathDefinition.Controls.Add(this.pnlButtons);
            this.groupBoxPathDefinition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxPathDefinition.Location = new System.Drawing.Point(0, 0);
            this.groupBoxPathDefinition.Name = "groupBoxPathDefinition";
            this.groupBoxPathDefinition.Size = new System.Drawing.Size(800, 251);
            this.groupBoxPathDefinition.TabIndex = 0;
            this.groupBoxPathDefinition.TabStop = false;
            this.groupBoxPathDefinition.Text = "تعريف مسير";
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.lblDate.Location = new System.Drawing.Point(708, 27);
            this.lblDate.Name = "lblDate";
            this.lblDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblDate.Size = new System.Drawing.Size(40, 20);
            this.lblDate.TabIndex = 24;
            this.lblDate.Text = "تاريخ :";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateControlPath
            // 
            this.dateControlPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateControlPath.BackColor = System.Drawing.Color.White;
            this.dateControlPath.CanGoBackward = true;
            this.dateControlPath.CanGoForward = false;
            this.dateControlPath.Location = new System.Drawing.Point(575, 27);
            this.dateControlPath.Name = "dateControlPath";
            this.dateControlPath.NextControl = this.chkProvince;
            this.dateControlPath.NowShamsi10Cahracter = "1397/06/14";
            this.dateControlPath.NowShamsi8Character = "97/06/14";
            this.dateControlPath.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateControlPath.Size = new System.Drawing.Size(120, 20);
            this.dateControlPath.TabIndex = 0;
            this.dateControlPath.Text = "dateControl1";
            this.dateControlPath.Value10Cahracter = null;
            this.dateControlPath.Value8Character = null;
            // 
            // chkProvince
            // 
            this.chkProvince.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkProvince.AutoSize = true;
            this.chkProvince.Location = new System.Drawing.Point(639, 57);
            this.chkProvince.Name = "chkProvince";
            this.chkProvince.Size = new System.Drawing.Size(56, 24);
            this.chkProvince.TabIndex = 1;
            this.chkProvince.Text = "استان";
            this.chkProvince.UseVisualStyleBackColor = true;
            this.chkProvince.CheckedChanged += new System.EventHandler(this.chkProvince_CheckedChanged);
            // 
            // chkRegionName
            // 
            this.chkRegionName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkRegionName.AutoSize = true;
            this.chkRegionName.Location = new System.Drawing.Point(639, 128);
            this.chkRegionName.Name = "chkRegionName";
            this.chkRegionName.Size = new System.Drawing.Size(58, 24);
            this.chkRegionName.TabIndex = 3;
            this.chkRegionName.Text = "منطقه";
            this.chkRegionName.UseVisualStyleBackColor = true;
            this.chkRegionName.CheckedChanged += new System.EventHandler(this.chkRegionName_CheckedChanged);
            // 
            // txtRegionName
            // 
            this.txtRegionName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRegionName.BackColor = System.Drawing.Color.White;
            this.txtRegionName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRegionName.Enabled = false;
            this.txtRegionName.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.txtRegionName.ForeColor = System.Drawing.Color.Gray;
            this.txtRegionName.Location = new System.Drawing.Point(364, 127);
            this.txtRegionName.Margin = new System.Windows.Forms.Padding(10);
            this.txtRegionName.Name = "txtRegionName";
            this.txtRegionName.NextControl = null;
            this.txtRegionName.ReadOnly = true;
            this.txtRegionName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtRegionName.Size = new System.Drawing.Size(262, 28);
            this.txtRegionName.TabIndex = 22;
            this.txtRegionName.Text = "انتخاب منطقه ...";
            this.txtRegionName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblRegionName
            // 
            this.lblRegionName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRegionName.AutoSize = true;
            this.lblRegionName.BackColor = System.Drawing.Color.Transparent;
            this.lblRegionName.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.lblRegionName.Location = new System.Drawing.Point(708, 129);
            this.lblRegionName.Name = "lblRegionName";
            this.lblRegionName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblRegionName.Size = new System.Drawing.Size(61, 20);
            this.lblRegionName.TabIndex = 21;
            this.lblRegionName.Text = "نام منطقه :";
            this.lblRegionName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkCityName
            // 
            this.chkCityName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkCityName.AutoSize = true;
            this.chkCityName.Location = new System.Drawing.Point(649, 93);
            this.chkCityName.Name = "chkCityName";
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
            this.txtCityName.Location = new System.Drawing.Point(364, 92);
            this.txtCityName.Margin = new System.Windows.Forms.Padding(10);
            this.txtCityName.Name = "txtCityName";
            this.txtCityName.NextControl = null;
            this.txtCityName.ReadOnly = true;
            this.txtCityName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCityName.Size = new System.Drawing.Size(262, 28);
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
            this.lblCityName.Location = new System.Drawing.Point(708, 94);
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
            this.txtProvinceName.Location = new System.Drawing.Point(364, 56);
            this.txtProvinceName.Margin = new System.Windows.Forms.Padding(10);
            this.txtProvinceName.Name = "txtProvinceName";
            this.txtProvinceName.NextControl = null;
            this.txtProvinceName.ReadOnly = true;
            this.txtProvinceName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtProvinceName.Size = new System.Drawing.Size(262, 28);
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
            this.lblProvinceName.Location = new System.Drawing.Point(708, 58);
            this.lblProvinceName.Name = "lblProvinceName";
            this.lblProvinceName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblProvinceName.Size = new System.Drawing.Size(59, 20);
            this.lblProvinceName.TabIndex = 13;
            this.lblProvinceName.Text = "نام استان :";
            this.lblProvinceName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPathID
            // 
            this.txtPathID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPathID.BackColor = System.Drawing.Color.White;
            this.txtPathID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPathID.Enabled = false;
            this.txtPathID.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.txtPathID.ForeColor = System.Drawing.Color.Black;
            this.txtPathID.Location = new System.Drawing.Point(223, 165);
            this.txtPathID.Margin = new System.Windows.Forms.Padding(10);
            this.txtPathID.Name = "txtPathID";
            this.txtPathID.NextControl = null;
            this.txtPathID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPathID.Size = new System.Drawing.Size(70, 28);
            this.txtPathID.TabIndex = 12;
            this.txtPathID.Text = "0";
            this.txtPathID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPathID.Value = 0D;
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.BackColor = System.Drawing.Color.White;
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescription.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.txtDescription.ForeColor = System.Drawing.Color.Black;
            this.txtDescription.Location = new System.Drawing.Point(364, 202);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(10);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.NextControl = this.btnSave;
            this.txtDescription.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDescription.Size = new System.Drawing.Size(331, 28);
            this.txtDescription.TabIndex = 5;
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
            this.btnCancel.NextControl = this.dateControlPath;
            this.btnCancel.Size = new System.Drawing.Size(81, 34);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "انصراف";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtPathName
            // 
            this.txtPathName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPathName.BackColor = System.Drawing.Color.White;
            this.txtPathName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPathName.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.txtPathName.ForeColor = System.Drawing.Color.Black;
            this.txtPathName.Location = new System.Drawing.Point(364, 165);
            this.txtPathName.Margin = new System.Windows.Forms.Padding(10);
            this.txtPathName.Name = "txtPathName";
            this.txtPathName.NextControl = this.txtDescription;
            this.txtPathName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPathName.Size = new System.Drawing.Size(331, 28);
            this.txtPathName.TabIndex = 4;
            this.txtPathName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPathName.TextChanged += new System.EventHandler(this.txtPathName_TextChanged);
            // 
            // lblPathID
            // 
            this.lblPathID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPathID.AutoSize = true;
            this.lblPathID.BackColor = System.Drawing.Color.Transparent;
            this.lblPathID.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.lblPathID.Location = new System.Drawing.Point(306, 167);
            this.lblPathID.Name = "lblPathID";
            this.lblPathID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPathID.Size = new System.Drawing.Size(54, 20);
            this.lblPathID.TabIndex = 9;
            this.lblPathID.Text = "كد مسير :";
            this.lblPathID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescription.AutoSize = true;
            this.lblDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblDescription.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.lblDescription.Location = new System.Drawing.Point(708, 204);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblDescription.Size = new System.Drawing.Size(60, 20);
            this.lblDescription.TabIndex = 8;
            this.lblDescription.Text = "توضيحات :";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPathName
            // 
            this.lblPathName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPathName.AutoSize = true;
            this.lblPathName.BackColor = System.Drawing.Color.Transparent;
            this.lblPathName.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.lblPathName.Location = new System.Drawing.Point(708, 167);
            this.lblPathName.Name = "lblPathName";
            this.lblPathName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPathName.Size = new System.Drawing.Size(55, 20);
            this.lblPathName.TabIndex = 2;
            this.lblPathName.Text = "نام مسير :";
            this.lblPathName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlButtons
            // 
            this.pnlButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlButtons.Controls.Add(this.btnRefresh);
            this.pnlButtons.Controls.Add(this.btnEdit);
            this.pnlButtons.Controls.Add(this.btnCancel);
            this.pnlButtons.Controls.Add(this.btnSave);
            this.pnlButtons.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.pnlButtons.Location = new System.Drawing.Point(3, 202);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlButtons.Size = new System.Drawing.Size(345, 40);
            this.pnlButtons.TabIndex = 6;
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
            // PathDefinition
            // 
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlPathDefinition);
            this.Name = "PathDefinition";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(800, 500);
            this.Tag = "تعريف مسير";
            this.Load += new System.EventHandler(this.PathDefinition_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PathDefinition_KeyDown);
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPath)).EndInit();
            this.pnlPathDefinition.ResumeLayout(false);
            this.groupBoxPathDefinition.ResumeLayout(false);
            this.groupBoxPathDefinition.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            @tab.CloseTab(this);
        }

        private void DisableForm()
        {
            //txtPathName.Enabled = false;
            //txtDescription.Enabled = false;
            //btnSave.Enabled = false;
            //btnEdit.Enabled = false;
            //btnRefresh.Enabled = false;
        }

        private DataTable PathListDataTable(List<Path> pathList)
        {
            var dataTable = ToolBox<Path>.GetDataTable(pathList);
            return dataTable;
        }

        private void PathDefinition_Load(object sender, EventArgs e)
        {
            var pathList = @class.GetPath().Where(i => i.Active).ToList();
            dgvPath.DataSource = PathListDataTable(pathList);
            SetGridView();
            txtPathID.Text = CalculateMaxId().ToString();
            btnEdit.Enabled = false;
            chkProvince.Focus();
        }

        private int CalculateMaxId()
        {
            if (@class.GetPath().Count <= 0) return 1;
            var max = @class.GetPath().Max(i => i.ID) + 1;
            return max;
        }

        private void SetGridView()
        {
            foreach (DataGridViewColumn item in dgvPath.Columns)
            {
                item.Visible = false;
            }
            dgvPath.Columns["ID"].Visible = true;
            dgvPath.Columns["Name"].Visible = true;
            dgvPath.Columns["Description"].Visible = true;

            dgvPath.Columns["ID"].HeaderText = "كد";
            dgvPath.Columns["Name"].HeaderText = "نام";
            dgvPath.Columns["Description"].HeaderText = "توضيحات";


            dgvPath.Columns["ID"].DisplayIndex = 0;
            dgvPath.Columns["Name"].DisplayIndex = 1;
            dgvPath.Columns["Description"].DisplayIndex = 3;

            dgvPath.Columns["ID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvPath.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvPath.Columns["Description"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvPath.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvPath.Columns["ID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPath.Columns["Name"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvPath.Columns["Description"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            dgvPath.AutoGenerateColumns = false;

        }

        private void PathDefinition_KeyDown(object sender, KeyEventArgs e)
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

            if (!chkRegionName.Checked)
            {
                CustomMessageForm.CustomMessageBox.Show("اخطار", "لطفا منطقه را انتخاب كنيد", "e");
                chkRegionName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPathName.Text))
            {
                CustomMessageForm.CustomMessageBox.Show("اخطار", "لطفا نام مسير را وارد كنيد", "e");
                txtPathName.Focus();
                return false;
            }
            if (DB_Connection.Path.AsNoTracking().Count(i => i.Name.Equals(txtPathName.Text) && i.Active) > 0)
            {
                CustomMessageForm.CustomMessageBox.Show("اخطار !", $"نام مسير \"{txtPathName.Text}\" تكراري است!", "e");
                txtPathName.Focus();
                return false;
            }

            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (FormValidate())
            {
                var result = @class.PathDefinition(txtPathName.Text, int.Parse(txtRegionName.Tag.ToString()), txtDescription.Text, dateControlPath.Shamsi10CharacteriValue(), ConnectionClasses.DateServer.ReturnDateServer(), ConnectionInfo.LoggedInUserId);

                if (result > 0)
                {
                    CustomMessageForm.CustomMessageBox.Show("پيغام سيستم", $"مسير \"{txtPathName.Text}\" با موفقيت ثبت شد", "i");
                    MaxID_ = result;
                    if (int.Parse(txtPathID.Text) != MaxID_)
                    {
                        CustomMessageForm.CustomMessageBox.Show("پيغام سيستم", $"كد مسير به {MaxID_} تغيير يافت", "i");
                    }
                    RefreshForm();
                }
                else if (result == 0)
                {
                    CustomMessageForm.CustomMessageBox.Show("خطا !", $"خطا در تعريف مسير!\n\nلطفا جهت بررسي مشكل با پشتيباني تماس بگيريد", "e");
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshForm();
        }

        private void RefreshForm()
        {
            PathDefinition_Load(null, null);
            txtPathName.Clear();
            txtDescription.Clear();
            chkCityName.Checked = false;
            chkProvince.Checked = false;
        }

        private void txtPathName_TextChanged(object sender, EventArgs e)
        {
            var pathList = @class.GetPath().Where(i => i.Active && i.Name.Contains(txtPathName.Text)).ToList();
            dgvPath.DataSource = PathListDataTable(pathList);
        }

        private void chkProvince_CheckedChanged(object sender, EventArgs e)
        {
            if (chkProvince.Checked)
            {
                var provinceArray = new ArrayList();
                new UserControlLoader(new ProvinceSelect(provinceArray), true, false, true);

                if (provinceArray.Count > 0)
                {
                    txtProvinceName.Text = provinceArray[1].ToString();
                    txtProvinceName.Tag = provinceArray[0].ToString();

                    chkCityName.Focus();

                    //var PathList = @class.GetPath().Where(i => i.Active && i.ProvinceID == int.Parse(txtProvinceName.Tag.ToString())).ToList();
                    //dgvPath.DataSource = PathListDataTable(PathList);
                    //txtPathName.Focus();
                }
                else
                {
                    txtProvinceName.Text = "انتخاب استان ...";
                    txtProvinceName.Tag = string.Empty;
                    chkRegionName.Checked = false;
                    chkCityName.Checked = false;
                    chkProvince.Checked = false;
                    var pathList = @class.GetPath().Where(i => i.Active).ToList();
                    dgvPath.DataSource = PathListDataTable(pathList);
                    chkProvince.Focus();
                    DisableForm();
                }
            }
            else if (!chkProvince.Checked)
            {
                txtProvinceName.Text = "انتخاب استان ...";
                txtProvinceName.Tag = string.Empty;
                chkRegionName.Checked = false;
                chkCityName.Checked = false;
                var pathList = @class.GetPath().Where(i => i.Active).ToList();
                dgvPath.DataSource = PathListDataTable(pathList);
                DisableForm();
            }
        }

        private void chkCityName_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkProvince.Checked && chkCityName.Checked)
            {
                CustomMessageForm.CustomMessageBox.Show("اخطار !", "لطفا ابتدا استان را انتخاب كنيد !", "e");
                chkProvince.Focus();
                chkRegionName.Checked = false;
                chkCityName.Checked = false;
                return;
            }

            if (chkProvince.Checked && chkCityName.Checked)
            {
                var cityArray = new ArrayList();
                new UserControlLoader(new CitySelect(cityArray, int.Parse(txtProvinceName.Tag.ToString())), true, false, true);

                if (cityArray.Count > 0)
                {
                    txtCityName.Text = cityArray[1].ToString();
                    txtCityName.Tag = cityArray[0].ToString();
                    chkRegionName.Select();

                    //var PathList = @class.GetPath().Where(i => i.Active && i.ProvinceID == int.Parse(txtProvinceName.Tag.ToString())).ToList();
                    //dgvPath.DataSource = PathListDataTable(PathList);
                    //txtPathName.Focus();
                }
                else
                {
                    txtCityName.Text = "انتخاب شهر ...";
                    txtCityName.Tag = string.Empty;
                    chkRegionName.Checked = false;
                    chkCityName.Checked = false;
                    var pathList = @class.GetPath().Where(i => i.Active).ToList();
                    dgvPath.DataSource = PathListDataTable(pathList);
                    chkProvince.Focus();
                    DisableForm();
                }
            }
            else if (!chkCityName.Checked)
            {
                txtCityName.Text = "انتخاب شهر ...";
                txtCityName.Tag = string.Empty;
                chkRegionName.Checked = false;
                var pathList = @class.GetPath().Where(i => i.Active).ToList();
                dgvPath.DataSource = PathListDataTable(pathList);
                DisableForm();
            }
        }

        private void chkRegionName_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkProvince.Checked && chkRegionName.Checked)
            {
                CustomMessageForm.CustomMessageBox.Show("اخطار !", "لطفا ابتدا استان را انتخاب كنيد !", "e");
                chkProvince.Focus();
                chkRegionName.Checked = false;
                return;
            }

            if (!chkCityName.Checked && chkRegionName.Checked)
            {
                CustomMessageForm.CustomMessageBox.Show("اخطار !", "لطفا ابتدا شهر را انتخاب كنيد !", "e");
                chkCityName.Focus();
                chkRegionName.Checked = false;
                return;
            }

            if (chkProvince.Checked && chkCityName.Checked && chkRegionName.Checked)
            {
                var regionArray = new ArrayList();
                new UserControlLoader(new RegionSelect(regionArray, int.Parse(txtCityName.Tag.ToString())), true, false, true);

                if (regionArray.Count > 0)
                {
                    txtRegionName.Text = regionArray[1].ToString();
                    txtRegionName.Tag = regionArray[0].ToString();
                    txtPathName.Focus();

                    //var PathList = @class.GetPath().Where(i => i.Active && i.ProvinceID == int.Parse(txtProvinceName.Tag.ToString())).ToList();
                    //dgvPath.DataSource = PathListDataTable(PathList);
                    //txtPathName.Focus();
                }
                else
                {
                    txtRegionName.Text = "انتخاب منطقه ...";
                    txtRegionName.Tag = string.Empty;
                    chkRegionName.Checked = false;
                    var pathList = @class.GetPath().Where(i => i.Active).ToList();
                    dgvPath.DataSource = PathListDataTable(pathList);
                    chkRegionName.Focus();
                    DisableForm();
                }
            }
            else if (!chkRegionName.Checked)
            {
                txtRegionName.Text = "انتخاب منطقه ...";
                txtRegionName.Tag = string.Empty;
                var PathList = @class.GetPath().Where(i => i.Active).ToList();
                dgvPath.DataSource = PathListDataTable(PathList);
                DisableForm();
            }
        }
    }
}
