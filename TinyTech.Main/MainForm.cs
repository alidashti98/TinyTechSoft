using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using TinyTech.BasicInformation;
using TinyTech.Connection;
using TinyTech.UI.Control.MessageBox;
using TinyTech.UI.Control.TextBox;
using TinyTech.UI.Control.UIElement;
using TinyTech.UI.UserControl;

namespace TinyTech.Main
{
    public class MainForm : Form
    {
        #region Region
        TabManagement @tab = new TabManagement();
        private ConnectionClasses @class = new ConnectionClasses();
        private UI.Control.UIElement.Timer timer1;
        private DateControl Date = new DateControl();
        private DateTime FullPersianDate = DateTime.Now;
        private UI.Control.Label.Label lblTime;
        private UI.Control.UIElement.Panel pnlBottom;
        private UI.Control.UIElement.Panel pnlTop;
        private MenuStrip menuMainForm;
        private ToolStripMenuItem ToolStripMenuItemBasicInformation;
        private ToolStripMenuItem ToolStripMenuItemLocation;
        private ToolStripMenuItem ToolStripMenuItemProvince;
        private ToolStripMenuItem ToolStripMenuItemCity;
        private ToolStripMenuItem ToolStripMenuItemRegion;
        private ToolStripMenuItem ToolStripMenuItemPath;
        private ToolStripMenuItem ToolStripMenuItemPeopleMenu;
        private ToolStripMenuItem ToolStripMenuItemPeopleGroup;
        private ToolStripMenuItem ToolStripMenuItemPeople;
        private ToolStripMenuItem ToolStripMenuItemGoodsMenu;
        private ToolStripMenuItem ToolStripMenuItemGoodsUnit;
        private ToolStripMenuItem ToolStripMenuItemGoodsGroup;
        private ToolStripMenuItem ToolStripMenuItemGoods;
        private ToolStripMenuItem ToolStripMenuItemGoodsBarcode;
        private ToolStripMenuItem ToolStripMenuItemDailyInformation;
        private ToolStripMenuItem ToolStripMenuItemFeatures;
        private ToolStripMenuItem ToolStripMenuItemUserManagement;
        private ToolStripMenuItem ToolStripMenuItemSetting;
        private ToolStripMenuItem ToolStripMenuItemBackup;
        private ToolStripMenuItem ToolStripMenuItemExit;
        private UI.Control.UIElement.Panel pnlMain;
        private UI.Control.UIElement.TabControl tabControlMain;
        private ToolStripMenuItem ToolStripMenuItemBankMenu;
        private ToolStripMenuItem ToolStripMenuItemBankName;
        private ToolStripMenuItem ToolStripMenuItemAccount;
        private ToolStripMenuItem ToolStripMenuItemCheckBook;
        private ToolStripMenuItem ToolStripMenuItemBankType;
        private UI.Control.UIElement.Timer timerInternetCheck;
        private PictureBox pictureBoxExit;
        private UI.Control.UIElement.Panel pnlMaxMin;
        private PictureBox pictureBoxMaximize;
        private UI.Control.Label.Label lblDate;
        private UI.Control.Label.Label lblCustomText;
        private UI.Control.Label.Label lblFiscalYearInfo;
        private UI.Control.Label.Label lblUserInfo;
        private UI.Control.Label.Label lblFreeSpace;
        private PictureBox pictureBoxUser;
        private PictureBox pictureBoxMinimize;
        private Container components = null;
        private ToolStripMenuItem ToolStripMenuItemCurrency;
        private bool Restart = false;
        #endregion

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                components?.Dispose();
            }
            base.Dispose(disposing);
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pnlMain = new TinyTech.UI.Control.UIElement.Panel();
            this.tabControlMain = new TinyTech.UI.Control.UIElement.TabControl();
            this.pnlTop = new TinyTech.UI.Control.UIElement.Panel();
            this.pictureBoxUser = new System.Windows.Forms.PictureBox();
            this.lblUserInfo = new TinyTech.UI.Control.Label.Label();
            this.lblFreeSpace = new TinyTech.UI.Control.Label.Label();
            this.lblFiscalYearInfo = new TinyTech.UI.Control.Label.Label();
            this.pnlMaxMin = new TinyTech.UI.Control.UIElement.Panel();
            this.pictureBoxMinimize = new System.Windows.Forms.PictureBox();
            this.pictureBoxMaximize = new System.Windows.Forms.PictureBox();
            this.pictureBoxExit = new System.Windows.Forms.PictureBox();
            this.menuMainForm = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItemBasicInformation = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemLocation = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemProvince = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemCity = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemRegion = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemPath = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemPeopleMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemPeopleGroup = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemPeople = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemGoodsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemGoodsUnit = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemGoodsGroup = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemGoods = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemGoodsBarcode = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemBankMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemCurrency = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemBankName = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemBankType = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemCheckBook = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemDailyInformation = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemFeatures = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemUserManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemBackup = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlBottom = new TinyTech.UI.Control.UIElement.Panel();
            this.lblCustomText = new TinyTech.UI.Control.Label.Label();
            this.lblDate = new TinyTech.UI.Control.Label.Label();
            this.lblTime = new TinyTech.UI.Control.Label.Label();
            this.timer1 = new TinyTech.UI.Control.UIElement.Timer();
            this.timerInternetCheck = new TinyTech.UI.Control.UIElement.Timer();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).BeginInit();
            this.pnlMaxMin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).BeginInit();
            this.menuMainForm.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.tabControlMain);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.pnlMain.Location = new System.Drawing.Point(0, 60);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlMain.Size = new System.Drawing.Size(1366, 652);
            this.pnlMain.TabIndex = 3;
            // 
            // tabControlMain
            // 
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabControlMain.RightToLeftLayout = true;
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.ShowToolTips = true;
            this.tabControlMain.Size = new System.Drawing.Size(1366, 652);
            this.tabControlMain.TabIndex = 0;
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.pictureBoxUser);
            this.pnlTop.Controls.Add(this.lblUserInfo);
            this.pnlTop.Controls.Add(this.lblFreeSpace);
            this.pnlTop.Controls.Add(this.lblFiscalYearInfo);
            this.pnlTop.Controls.Add(this.pnlMaxMin);
            this.pnlTop.Controls.Add(this.menuMainForm);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlTop.Size = new System.Drawing.Size(1366, 60);
            this.pnlTop.TabIndex = 0;
            this.pnlTop.DoubleClick += new System.EventHandler(this.pnlTop_DoubleClick);
            // 
            // pictureBoxUser
            // 
            this.pictureBoxUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxUser.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxUser.Image = global::TinyTech.Main.Properties.Resources.User;
            this.pictureBoxUser.Location = new System.Drawing.Point(308, 0);
            this.pictureBoxUser.Name = "pictureBoxUser";
            this.pictureBoxUser.Size = new System.Drawing.Size(29, 32);
            this.pictureBoxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxUser.TabIndex = 12;
            this.pictureBoxUser.TabStop = false;
            this.pictureBoxUser.Click += new System.EventHandler(this.pictureBoxUser_Click);
            // 
            // lblUserInfo
            // 
            this.lblUserInfo.AutoSize = true;
            this.lblUserInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblUserInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblUserInfo.Font = new System.Drawing.Font("IRANSans(FaNum)", 10F, System.Drawing.FontStyle.Bold);
            this.lblUserInfo.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblUserInfo.Location = new System.Drawing.Point(196, 0);
            this.lblUserInfo.Name = "lblUserInfo";
            this.lblUserInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblUserInfo.Size = new System.Drawing.Size(112, 24);
            this.lblUserInfo.TabIndex = 11;
            this.lblUserInfo.Text = "اطلاعات كاربر جاري";
            this.lblUserInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFreeSpace
            // 
            this.lblFreeSpace.AutoSize = true;
            this.lblFreeSpace.BackColor = System.Drawing.Color.Transparent;
            this.lblFreeSpace.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblFreeSpace.Font = new System.Drawing.Font("IRANSans(FaNum)", 11F, System.Drawing.FontStyle.Bold);
            this.lblFreeSpace.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblFreeSpace.Location = new System.Drawing.Point(140, 0);
            this.lblFreeSpace.Name = "lblFreeSpace";
            this.lblFreeSpace.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblFreeSpace.Size = new System.Drawing.Size(56, 25);
            this.lblFreeSpace.TabIndex = 10;
            this.lblFreeSpace.Text = "     |     ";
            this.lblFreeSpace.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFiscalYearInfo
            // 
            this.lblFiscalYearInfo.AutoSize = true;
            this.lblFiscalYearInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblFiscalYearInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblFiscalYearInfo.Font = new System.Drawing.Font("IRANSans(FaNum)", 10F, System.Drawing.FontStyle.Bold);
            this.lblFiscalYearInfo.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblFiscalYearInfo.Location = new System.Drawing.Point(0, 0);
            this.lblFiscalYearInfo.Name = "lblFiscalYearInfo";
            this.lblFiscalYearInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblFiscalYearInfo.Size = new System.Drawing.Size(140, 24);
            this.lblFiscalYearInfo.TabIndex = 9;
            this.lblFiscalYearInfo.Text = "اطلاعات دوره مالي جاري";
            this.lblFiscalYearInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlMaxMin
            // 
            this.pnlMaxMin.Controls.Add(this.pictureBoxMinimize);
            this.pnlMaxMin.Controls.Add(this.pictureBoxMaximize);
            this.pnlMaxMin.Controls.Add(this.pictureBoxExit);
            this.pnlMaxMin.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlMaxMin.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.pnlMaxMin.Location = new System.Drawing.Point(1276, 0);
            this.pnlMaxMin.Name = "pnlMaxMin";
            this.pnlMaxMin.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlMaxMin.Size = new System.Drawing.Size(90, 32);
            this.pnlMaxMin.TabIndex = 6;
            // 
            // pictureBoxMinimize
            // 
            this.pictureBoxMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBoxMinimize.Image = global::TinyTech.Main.Properties.Resources.Minimize;
            this.pictureBoxMinimize.Location = new System.Drawing.Point(3, 0);
            this.pictureBoxMinimize.Name = "pictureBoxMinimize";
            this.pictureBoxMinimize.Size = new System.Drawing.Size(29, 32);
            this.pictureBoxMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMinimize.TabIndex = 8;
            this.pictureBoxMinimize.TabStop = false;
            // 
            // pictureBoxMaximize
            // 
            this.pictureBoxMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxMaximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBoxMaximize.Image = global::TinyTech.Main.Properties.Resources.Restore;
            this.pictureBoxMaximize.Location = new System.Drawing.Point(32, 0);
            this.pictureBoxMaximize.Name = "pictureBoxMaximize";
            this.pictureBoxMaximize.Size = new System.Drawing.Size(29, 32);
            this.pictureBoxMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMaximize.TabIndex = 7;
            this.pictureBoxMaximize.TabStop = false;
            this.pictureBoxMaximize.Click += new System.EventHandler(this.pictureBoxMaximize_Click);
            // 
            // pictureBoxExit
            // 
            this.pictureBoxExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBoxExit.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxExit.Image")));
            this.pictureBoxExit.Location = new System.Drawing.Point(61, 0);
            this.pictureBoxExit.Name = "pictureBoxExit";
            this.pictureBoxExit.Size = new System.Drawing.Size(29, 32);
            this.pictureBoxExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxExit.TabIndex = 2;
            this.pictureBoxExit.TabStop = false;
            this.pictureBoxExit.Click += new System.EventHandler(this.pictureBoxExit_Click);
            // 
            // menuMainForm
            // 
            this.menuMainForm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuMainForm.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.menuMainForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemBasicInformation,
            this.ToolStripMenuItemDailyInformation,
            this.ToolStripMenuItemFeatures});
            this.menuMainForm.Location = new System.Drawing.Point(0, 32);
            this.menuMainForm.Name = "menuMainForm";
            this.menuMainForm.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuMainForm.Size = new System.Drawing.Size(1366, 28);
            this.menuMainForm.TabIndex = 1;
            this.menuMainForm.Text = "menuMainForm";
            // 
            // ToolStripMenuItemBasicInformation
            // 
            this.ToolStripMenuItemBasicInformation.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemLocation,
            this.ToolStripMenuItemPeopleMenu,
            this.ToolStripMenuItemGoodsMenu,
            this.ToolStripMenuItemBankMenu});
            this.ToolStripMenuItemBasicInformation.ForeColor = System.Drawing.Color.Lime;
            this.ToolStripMenuItemBasicInformation.Name = "ToolStripMenuItemBasicInformation";
            this.ToolStripMenuItemBasicInformation.Size = new System.Drawing.Size(80, 24);
            this.ToolStripMenuItemBasicInformation.Text = "اطلاعات پايه";
            // 
            // ToolStripMenuItemLocation
            // 
            this.ToolStripMenuItemLocation.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemProvince,
            this.ToolStripMenuItemCity,
            this.ToolStripMenuItemRegion,
            this.ToolStripMenuItemPath});
            this.ToolStripMenuItemLocation.Name = "ToolStripMenuItemLocation";
            this.ToolStripMenuItemLocation.Size = new System.Drawing.Size(135, 24);
            this.ToolStripMenuItemLocation.Text = "مكان";
            // 
            // ToolStripMenuItemProvince
            // 
            this.ToolStripMenuItemProvince.Name = "ToolStripMenuItemProvince";
            this.ToolStripMenuItemProvince.Size = new System.Drawing.Size(150, 24);
            this.ToolStripMenuItemProvince.Text = "مديريت استان";
            this.ToolStripMenuItemProvince.Click += new System.EventHandler(this.ToolStripMenuItemProvince_Click);
            // 
            // ToolStripMenuItemCity
            // 
            this.ToolStripMenuItemCity.Name = "ToolStripMenuItemCity";
            this.ToolStripMenuItemCity.Size = new System.Drawing.Size(150, 24);
            this.ToolStripMenuItemCity.Text = "مديريت شهر";
            this.ToolStripMenuItemCity.Click += new System.EventHandler(this.ToolStripMenuItemCity_Click);
            // 
            // ToolStripMenuItemRegion
            // 
            this.ToolStripMenuItemRegion.Name = "ToolStripMenuItemRegion";
            this.ToolStripMenuItemRegion.Size = new System.Drawing.Size(150, 24);
            this.ToolStripMenuItemRegion.Text = "مديريت منطقه";
            this.ToolStripMenuItemRegion.Click += new System.EventHandler(this.ToolStripMenuItemRegion_Click);
            // 
            // ToolStripMenuItemPath
            // 
            this.ToolStripMenuItemPath.Name = "ToolStripMenuItemPath";
            this.ToolStripMenuItemPath.Size = new System.Drawing.Size(150, 24);
            this.ToolStripMenuItemPath.Text = "مديريت مسير";
            this.ToolStripMenuItemPath.Click += new System.EventHandler(this.ToolStripMenuItemPath_Click);
            // 
            // ToolStripMenuItemPeopleMenu
            // 
            this.ToolStripMenuItemPeopleMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemPeopleGroup,
            this.ToolStripMenuItemPeople});
            this.ToolStripMenuItemPeopleMenu.Name = "ToolStripMenuItemPeopleMenu";
            this.ToolStripMenuItemPeopleMenu.Size = new System.Drawing.Size(135, 24);
            this.ToolStripMenuItemPeopleMenu.Text = "طرف حساب";
            // 
            // ToolStripMenuItemPeopleGroup
            // 
            this.ToolStripMenuItemPeopleGroup.Name = "ToolStripMenuItemPeopleGroup";
            this.ToolStripMenuItemPeopleGroup.Size = new System.Drawing.Size(200, 24);
            this.ToolStripMenuItemPeopleGroup.Text = "مديريت گروه طرف حساب";
            this.ToolStripMenuItemPeopleGroup.Click += new System.EventHandler(this.ToolStripMenuItemPeopleGroup_Click);
            // 
            // ToolStripMenuItemPeople
            // 
            this.ToolStripMenuItemPeople.Name = "ToolStripMenuItemPeople";
            this.ToolStripMenuItemPeople.Size = new System.Drawing.Size(200, 24);
            this.ToolStripMenuItemPeople.Text = "مديريت طرف حساب";
            // 
            // ToolStripMenuItemGoodsMenu
            // 
            this.ToolStripMenuItemGoodsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemGoodsUnit,
            this.ToolStripMenuItemGoodsGroup,
            this.ToolStripMenuItemGoods,
            this.ToolStripMenuItemGoodsBarcode});
            this.ToolStripMenuItemGoodsMenu.Name = "ToolStripMenuItemGoodsMenu";
            this.ToolStripMenuItemGoodsMenu.Size = new System.Drawing.Size(135, 24);
            this.ToolStripMenuItemGoodsMenu.Text = "كالا";
            // 
            // ToolStripMenuItemGoodsUnit
            // 
            this.ToolStripMenuItemGoodsUnit.Name = "ToolStripMenuItemGoodsUnit";
            this.ToolStripMenuItemGoodsUnit.Size = new System.Drawing.Size(162, 24);
            this.ToolStripMenuItemGoodsUnit.Text = "مديريت واحد كالا";
            this.ToolStripMenuItemGoodsUnit.Click += new System.EventHandler(this.ToolStripMenuItemGoodsUnit_Click);
            // 
            // ToolStripMenuItemGoodsGroup
            // 
            this.ToolStripMenuItemGoodsGroup.Name = "ToolStripMenuItemGoodsGroup";
            this.ToolStripMenuItemGoodsGroup.Size = new System.Drawing.Size(162, 24);
            this.ToolStripMenuItemGoodsGroup.Text = "مديريت گروه كالا";
            this.ToolStripMenuItemGoodsGroup.Click += new System.EventHandler(this.ToolStripMenuItemGoodsGroup_Click);
            // 
            // ToolStripMenuItemGoods
            // 
            this.ToolStripMenuItemGoods.Name = "ToolStripMenuItemGoods";
            this.ToolStripMenuItemGoods.Size = new System.Drawing.Size(162, 24);
            this.ToolStripMenuItemGoods.Text = "مديريت كالا";
            // 
            // ToolStripMenuItemGoodsBarcode
            // 
            this.ToolStripMenuItemGoodsBarcode.Name = "ToolStripMenuItemGoodsBarcode";
            this.ToolStripMenuItemGoodsBarcode.Size = new System.Drawing.Size(162, 24);
            this.ToolStripMenuItemGoodsBarcode.Text = "مديريت باركد كالا";
            // 
            // ToolStripMenuItemBankMenu
            // 
            this.ToolStripMenuItemBankMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemCurrency,
            this.ToolStripMenuItemBankName,
            this.ToolStripMenuItemBankType,
            this.ToolStripMenuItemAccount,
            this.ToolStripMenuItemCheckBook});
            this.ToolStripMenuItemBankMenu.Name = "ToolStripMenuItemBankMenu";
            this.ToolStripMenuItemBankMenu.Size = new System.Drawing.Size(135, 24);
            this.ToolStripMenuItemBankMenu.Text = "بانك";
            // 
            // ToolStripMenuItemCurrency
            // 
            this.ToolStripMenuItemCurrency.Name = "ToolStripMenuItemCurrency";
            this.ToolStripMenuItemCurrency.Size = new System.Drawing.Size(182, 24);
            this.ToolStripMenuItemCurrency.Text = "مديريت واحد پول";
            this.ToolStripMenuItemCurrency.Click += new System.EventHandler(this.ToolStripMenuItemCurrency_Click);
            // 
            // ToolStripMenuItemBankName
            // 
            this.ToolStripMenuItemBankName.Name = "ToolStripMenuItemBankName";
            this.ToolStripMenuItemBankName.Size = new System.Drawing.Size(182, 24);
            this.ToolStripMenuItemBankName.Text = "مديريت نام بانك";
            this.ToolStripMenuItemBankName.Click += new System.EventHandler(this.ToolStripMenuItemBankName_Click);
            // 
            // ToolStripMenuItemBankType
            // 
            this.ToolStripMenuItemBankType.Name = "ToolStripMenuItemBankType";
            this.ToolStripMenuItemBankType.Size = new System.Drawing.Size(182, 24);
            this.ToolStripMenuItemBankType.Text = "مديريت نوع حساب";
            this.ToolStripMenuItemBankType.Click += new System.EventHandler(this.ToolStripMenuItemBankType_Click);
            // 
            // ToolStripMenuItemAccount
            // 
            this.ToolStripMenuItemAccount.Name = "ToolStripMenuItemAccount";
            this.ToolStripMenuItemAccount.Size = new System.Drawing.Size(182, 24);
            this.ToolStripMenuItemAccount.Text = "مديريت شماره حساب";
            this.ToolStripMenuItemAccount.Click += new System.EventHandler(this.ToolStripMenuItemAccount_Click);
            // 
            // ToolStripMenuItemCheckBook
            // 
            this.ToolStripMenuItemCheckBook.Name = "ToolStripMenuItemCheckBook";
            this.ToolStripMenuItemCheckBook.Size = new System.Drawing.Size(182, 24);
            this.ToolStripMenuItemCheckBook.Text = "مديريت دسته چك";
            // 
            // ToolStripMenuItemDailyInformation
            // 
            this.ToolStripMenuItemDailyInformation.ForeColor = System.Drawing.Color.Lime;
            this.ToolStripMenuItemDailyInformation.Name = "ToolStripMenuItemDailyInformation";
            this.ToolStripMenuItemDailyInformation.Size = new System.Drawing.Size(83, 24);
            this.ToolStripMenuItemDailyInformation.Text = "عمليات روزانه";
            // 
            // ToolStripMenuItemFeatures
            // 
            this.ToolStripMenuItemFeatures.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemUserManagement,
            this.ToolStripMenuItemSetting,
            this.ToolStripMenuItemBackup,
            this.ToolStripMenuItemExit});
            this.ToolStripMenuItemFeatures.ForeColor = System.Drawing.Color.Lime;
            this.ToolStripMenuItemFeatures.Name = "ToolStripMenuItemFeatures";
            this.ToolStripMenuItemFeatures.Size = new System.Drawing.Size(56, 24);
            this.ToolStripMenuItemFeatures.Text = "امكانات";
            // 
            // ToolStripMenuItemUserManagement
            // 
            this.ToolStripMenuItemUserManagement.Name = "ToolStripMenuItemUserManagement";
            this.ToolStripMenuItemUserManagement.Size = new System.Drawing.Size(151, 24);
            this.ToolStripMenuItemUserManagement.Text = "مديريت كاربران";
            // 
            // ToolStripMenuItemSetting
            // 
            this.ToolStripMenuItemSetting.Name = "ToolStripMenuItemSetting";
            this.ToolStripMenuItemSetting.Size = new System.Drawing.Size(151, 24);
            this.ToolStripMenuItemSetting.Text = "تنظيمات";
            // 
            // ToolStripMenuItemBackup
            // 
            this.ToolStripMenuItemBackup.Name = "ToolStripMenuItemBackup";
            this.ToolStripMenuItemBackup.Size = new System.Drawing.Size(151, 24);
            this.ToolStripMenuItemBackup.Text = "پشتيبان گيري";
            // 
            // ToolStripMenuItemExit
            // 
            this.ToolStripMenuItemExit.Name = "ToolStripMenuItemExit";
            this.ToolStripMenuItemExit.Size = new System.Drawing.Size(151, 24);
            this.ToolStripMenuItemExit.Text = "خروج";
            this.ToolStripMenuItemExit.Click += new System.EventHandler(this.ToolStripMenuItemExit_Click);
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.lblCustomText);
            this.pnlBottom.Controls.Add(this.lblDate);
            this.pnlBottom.Controls.Add(this.lblTime);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.pnlBottom.Location = new System.Drawing.Point(0, 712);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlBottom.Size = new System.Drawing.Size(1366, 26);
            this.pnlBottom.TabIndex = 2;
            // 
            // lblCustomText
            // 
            this.lblCustomText.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCustomText.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F, System.Drawing.FontStyle.Bold);
            this.lblCustomText.ForeColor = System.Drawing.Color.Lime;
            this.lblCustomText.Location = new System.Drawing.Point(105, 0);
            this.lblCustomText.Name = "lblCustomText";
            this.lblCustomText.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblCustomText.Size = new System.Drawing.Size(1161, 26);
            this.lblCustomText.TabIndex = 5;
            this.lblCustomText.Text = "متن دلخواه";
            this.lblCustomText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblDate.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F, System.Drawing.FontStyle.Bold);
            this.lblDate.ForeColor = System.Drawing.Color.Lime;
            this.lblDate.Location = new System.Drawing.Point(1266, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblDate.Size = new System.Drawing.Size(100, 20);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "تاريخ جاري سيستم";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTime.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F, System.Drawing.FontStyle.Bold);
            this.lblTime.ForeColor = System.Drawing.Color.Lime;
            this.lblTime.Location = new System.Drawing.Point(0, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTime.Size = new System.Drawing.Size(105, 20);
            this.lblTime.TabIndex = 3;
            this.lblTime.Text = "ساعت جاري سيستم";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerInternetCheck
            // 
            this.timerInternetCheck.Enabled = true;
            this.timerInternetCheck.Interval = 60000;
            this.timerInternetCheck.Tick += new System.EventHandler(this.timerInternetCheck_Tick);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(1366, 738);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlBottom);
            this.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تايني تك سافت";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.pnlMain.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).EndInit();
            this.pnlMaxMin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).EndInit();
            this.menuMainForm.ResumeLayout(false);
            this.menuMainForm.PerformLayout();
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            this.ResumeLayout(false);

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            timer1_Tick(null, null);
            //timerInternetCheck_Tick(null, null);
            pnlTop.Controls.Add(menuMainForm);
            pnlMain.Controls.Add(tabControlMain);
            pnlBottom.Controls.Add(lblTime);
            SetColor();
            SetUserAndFiscalYearInfo();
            lblCustomText.Text = string.Empty;
            FormSizeChange("Max");
        }

        private void SetUserAndFiscalYearInfo()
        {
            var UserInfo_ = @class.GetUserInfo(ConnectionInfo.LoggedInUserId).FirstOrDefault();
            lblUserInfo.Text = $"{UserInfo_.FirstName} {UserInfo_.LastName} ({UserInfo_.UserName})";
            lblFiscalYearInfo.Text = $"{@class.GetFiscalYear().Where(i => i.DatabaseName.Equals(ConnectionInfo.DatabaseName)).Select(i => i.DisplayName).FirstOrDefault()}";
        }

        private void SetColor()
        {
            menuMainForm.BackColor = ConnectionInfo.BackgroudColor;
            pnlBottom.BackColor = ConnectionInfo.BackgroudColor;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Restart)
            {
                MessageBoxWarning.State = 0;
                if (CustomMessageForm.CustomMessageBox.Show("خروج", "آيا مي خواهيد از برنامه خارج شويد؟", "w") == DialogResult.No)
                {
                    e.Cancel = true;
                }
                MessageBoxWarning.State = 1;
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    if (tabControlMain.TabCount == 0)
                    {
                        CloseProgram();
                    }
                    break;
                case Keys.F1:
                    CustomMessageForm.CustomMessageBox.Show("راهنماي برنامه", "در حال تكميل شدن...", "i");
                    break;
            }
        }

        private void ToolStripMenuItemPeopleGroup_Click(object sender, EventArgs e)
        {
            var PeopleGroupDefinition = new PeopleGroupDefinition();
            tab.AddNewTab(tabControlMain, PeopleGroupDefinition);
        }

        private void ToolStripMenuItemExit_Click(object sender, EventArgs e)
        {
            CloseProgram();
        }

        private void CloseProgram()
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("fa-IR");
            lblTime.Text = $"{DateTime.Now.ToString("HH:mm:ss")}";
            lblDate.Text = $"{FullPersianDate.ToLongDateString()}";//{Date.ShamsiNow}
        }

        private void ToolStripMenuItemProvince_Click(object sender, EventArgs e)
        {
            var provinceDefinition = new ProvinceDefinition();
            tab.AddNewTab(tabControlMain, provinceDefinition);
        }

        private void ToolStripMenuItemCity_Click(object sender, EventArgs e)
        {
            var cityDefinition = new CityDefinition();
            tab.AddNewTab(tabControlMain, cityDefinition);
        }

        private void ToolStripMenuItemRegion_Click(object sender, EventArgs e)
        {
            var regionDefinition = new RegionDefinition();
            tab.AddNewTab(tabControlMain, regionDefinition);
        }

        private void ToolStripMenuItemPath_Click(object sender, EventArgs e)
        {
            var pathDefinition = new PathDefinition();
            tab.AddNewTab(tabControlMain, pathDefinition);
        }

        private void ToolStripMenuItemGoodsUnit_Click(object sender, EventArgs e)
        {
            var goodsUnitDefinition = new GoodsUnitDefinition();
            tab.AddNewTab(tabControlMain, goodsUnitDefinition);
        }

        private void ToolStripMenuItemGoodsGroup_Click(object sender, EventArgs e)
        {
            var goodsGroupDefinition = new GoodsGroupDefinition();
            tab.AddNewTab(tabControlMain, goodsGroupDefinition);
        }

        private void ToolStripMenuItemBankName_Click(object sender, EventArgs e)
        {
            var bankNameDefinition = new BankNameDefinition();
            tab.AddNewTab(tabControlMain, bankNameDefinition);
        }

        private void ToolStripMenuItemAccount_Click(object sender, EventArgs e)
        {
            var bankAccountDefinition = new BankAccountDefinition();
            tab.AddNewTab(tabControlMain, bankAccountDefinition);
        }

        private void FormSizeChange(string status = "")
        {
            if (status == "")
            {
                if (this.Size != MinimumSize)
                {
                    this.Size = MinimumSize;
                    this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
                    this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
                    this.pictureBoxMaximize.Image = global::TinyTech.Main.Properties.Resources.Max;
                }
                else if (this.Size == MinimumSize)
                {
                    Bounds = Screen.PrimaryScreen.WorkingArea;
                    this.pictureBoxMaximize.Image = global::TinyTech.Main.Properties.Resources.Restore;
                }
            }
            else if (status == "Max")
            {
                Bounds = Screen.PrimaryScreen.WorkingArea;
                this.pictureBoxMaximize.Image = global::TinyTech.Main.Properties.Resources.Restore;
            }
            else if (status == "Min")
            {
                this.Size = MinimumSize;
                this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
                this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
                this.pictureBoxMaximize.Image = global::TinyTech.Main.Properties.Resources.Max;
            }
        }

        private void ToolStripMenuItemBankType_Click(object sender, EventArgs e)
        {
            var bankAccountTypeDefinition = new BankAccountTypeDefinition();
            tab.AddNewTab(tabControlMain, bankAccountTypeDefinition);
        }

        private void ToolStripMenuItemCurrency_Click(object sender, EventArgs e)
        {
            var currencyDefinition = new CurrencyDefinition();
            tab.AddNewTab(tabControlMain, currencyDefinition);
        }

        private void timerInternetCheck_Tick(object sender, EventArgs e)
        {
            //if (@class.CheckForInternetConnection())
            //{
            //    lblCustomText.Text = $"ارتباط با اينترنت برقرار مي باشد";
            //    lblCustomText.ForeColor = Color.Lime;
            //}
            //else
            //{
            //    lblCustomText.Text = $"ارتباط با اينترنت برقرار نمي باشد";
            //    lblCustomText.ForeColor = Color.Red;
            //}
        }

        private void pictureBoxExit_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{ESC}");
        }

        private void pictureBoxMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pnlTop_DoubleClick(object sender, EventArgs e)
        {
            FormSizeChange();
        }

        private void pictureBoxMaximize_Click(object sender, EventArgs e)
        {
            FormSizeChange();
        }

        private void SwitchUser()
        {
            MessageBoxWarning.State = 0;
            if (CustomMessageForm.CustomMessageBox.Show("خروج از كاربري", "آيا مي خواهيد از كاربري خود خارج شويد؟", "w") == DialogResult.No)
            {
                Restart = false;
                MessageBoxWarning.State = 1;
                return;
            }
            else
            {
                Restart = true;
                Process.Start(Application.ExecutablePath);
                this.Close();
            }
        }

        private void pictureBoxUser_Click(object sender, EventArgs e)
        {
            SwitchUser();
        }


    }
}