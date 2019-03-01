using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
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
        private UI.Control.UIElement.Timer timer1;
        private DateControl Date = new DateControl();
        private DateTime FullPersianDate = DateTime.Now;
        private UI.Control.Label.Label lblDateTime;
        private UI.Control.UIElement.Panel pnlBottom;
        private UI.Control.UIElement.Panel pnlTop;
        private MenuStrip menuMainForm;
        private ToolStripMenuItem ToolStripMenuItemBasicInformation;
        private ToolStripMenuItem ToolStripMenuItemLocation;
        private ToolStripMenuItem ToolStripMenuItemProvince;
        private ToolStripMenuItem ToolStripMenuItemCity;
        private ToolStripMenuItem ToolStripMenuItemRegion;
        private ToolStripMenuItem ToolStripMenuItemPath;
        private ToolStripMenuItem ToolStripMenuItemCustomerMenu;
        private ToolStripMenuItem ToolStripMenuItemCustomerGroup;
        private ToolStripMenuItem ToolStripMenuItemCustomer;
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

        public MainForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.pnlMain = new TinyTech.UI.Control.UIElement.Panel();
            this.tabControlMain = new TinyTech.UI.Control.UIElement.TabControl();
            this.pnlTop = new TinyTech.UI.Control.UIElement.Panel();
            this.menuMainForm = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItemBasicInformation = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemLocation = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemProvince = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemCity = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemRegion = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemPath = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemCustomerMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemCustomerGroup = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemGoodsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemGoodsUnit = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemGoodsGroup = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemGoods = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemGoodsBarcode = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemBankMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemBankName = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemCheckBook = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemDailyInformation = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemFeatures = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemUserManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemBackup = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlBottom = new TinyTech.UI.Control.UIElement.Panel();
            this.lblDateTime = new TinyTech.UI.Control.Label.Label();
            this.timer1 = new TinyTech.UI.Control.UIElement.Timer();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.menuMainForm.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.tabControlMain);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.pnlMain.Location = new System.Drawing.Point(0, 29);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlMain.Size = new System.Drawing.Size(1008, 625);
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
            this.tabControlMain.Size = new System.Drawing.Size(1008, 625);
            this.tabControlMain.TabIndex = 0;
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.menuMainForm);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlTop.Size = new System.Drawing.Size(1008, 29);
            this.pnlTop.TabIndex = 0;
            // 
            // menuMainForm
            // 
            this.menuMainForm.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.menuMainForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemBasicInformation,
            this.ToolStripMenuItemDailyInformation,
            this.ToolStripMenuItemFeatures});
            this.menuMainForm.Location = new System.Drawing.Point(0, 0);
            this.menuMainForm.Name = "menuMainForm";
            this.menuMainForm.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuMainForm.Size = new System.Drawing.Size(1008, 28);
            this.menuMainForm.TabIndex = 1;
            this.menuMainForm.Text = "menuMainForm";
            // 
            // ToolStripMenuItemBasicInformation
            // 
            this.ToolStripMenuItemBasicInformation.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemLocation,
            this.ToolStripMenuItemCustomerMenu,
            this.ToolStripMenuItemGoodsMenu,
            this.ToolStripMenuItemBankMenu});
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
            this.ToolStripMenuItemLocation.Size = new System.Drawing.Size(180, 24);
            this.ToolStripMenuItemLocation.Text = "مكان";
            // 
            // ToolStripMenuItemProvince
            // 
            this.ToolStripMenuItemProvince.Name = "ToolStripMenuItemProvince";
            this.ToolStripMenuItemProvince.Size = new System.Drawing.Size(141, 24);
            this.ToolStripMenuItemProvince.Text = "تعريف استان";
            this.ToolStripMenuItemProvince.Click += new System.EventHandler(this.ToolStripMenuItemProvince_Click);
            // 
            // ToolStripMenuItemCity
            // 
            this.ToolStripMenuItemCity.Name = "ToolStripMenuItemCity";
            this.ToolStripMenuItemCity.Size = new System.Drawing.Size(141, 24);
            this.ToolStripMenuItemCity.Text = "تعريف شهر";
            this.ToolStripMenuItemCity.Click += new System.EventHandler(this.ToolStripMenuItemCity_Click);
            // 
            // ToolStripMenuItemRegion
            // 
            this.ToolStripMenuItemRegion.Name = "ToolStripMenuItemRegion";
            this.ToolStripMenuItemRegion.Size = new System.Drawing.Size(141, 24);
            this.ToolStripMenuItemRegion.Text = "تعريف منطقه";
            this.ToolStripMenuItemRegion.Click += new System.EventHandler(this.ToolStripMenuItemRegion_Click);
            // 
            // ToolStripMenuItemPath
            // 
            this.ToolStripMenuItemPath.Name = "ToolStripMenuItemPath";
            this.ToolStripMenuItemPath.Size = new System.Drawing.Size(141, 24);
            this.ToolStripMenuItemPath.Text = "تعريف مسير";
            this.ToolStripMenuItemPath.Click += new System.EventHandler(this.ToolStripMenuItemPath_Click);
            // 
            // ToolStripMenuItemCustomerMenu
            // 
            this.ToolStripMenuItemCustomerMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemCustomerGroup,
            this.ToolStripMenuItemCustomer});
            this.ToolStripMenuItemCustomerMenu.Name = "ToolStripMenuItemCustomerMenu";
            this.ToolStripMenuItemCustomerMenu.Size = new System.Drawing.Size(180, 24);
            this.ToolStripMenuItemCustomerMenu.Text = "طرف حساب";
            // 
            // ToolStripMenuItemCustomerGroup
            // 
            this.ToolStripMenuItemCustomerGroup.Name = "ToolStripMenuItemCustomerGroup";
            this.ToolStripMenuItemCustomerGroup.Size = new System.Drawing.Size(191, 24);
            this.ToolStripMenuItemCustomerGroup.Text = "تعريف گروه طرف حساب";
            this.ToolStripMenuItemCustomerGroup.Click += new System.EventHandler(this.ToolStripMenuItemCustomerGroup_Click);
            // 
            // ToolStripMenuItemCustomer
            // 
            this.ToolStripMenuItemCustomer.Name = "ToolStripMenuItemCustomer";
            this.ToolStripMenuItemCustomer.Size = new System.Drawing.Size(191, 24);
            this.ToolStripMenuItemCustomer.Text = "تعريف طرف حساب";
            // 
            // ToolStripMenuItemGoodsMenu
            // 
            this.ToolStripMenuItemGoodsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemGoodsUnit,
            this.ToolStripMenuItemGoodsGroup,
            this.ToolStripMenuItemGoods,
            this.ToolStripMenuItemGoodsBarcode});
            this.ToolStripMenuItemGoodsMenu.Name = "ToolStripMenuItemGoodsMenu";
            this.ToolStripMenuItemGoodsMenu.Size = new System.Drawing.Size(180, 24);
            this.ToolStripMenuItemGoodsMenu.Text = "كالا";
            // 
            // ToolStripMenuItemGoodsUnit
            // 
            this.ToolStripMenuItemGoodsUnit.Name = "ToolStripMenuItemGoodsUnit";
            this.ToolStripMenuItemGoodsUnit.Size = new System.Drawing.Size(153, 24);
            this.ToolStripMenuItemGoodsUnit.Text = "تعريف واحد كالا";
            this.ToolStripMenuItemGoodsUnit.Click += new System.EventHandler(this.ToolStripMenuItemGoodsUnit_Click);
            // 
            // ToolStripMenuItemGoodsGroup
            // 
            this.ToolStripMenuItemGoodsGroup.Name = "ToolStripMenuItemGoodsGroup";
            this.ToolStripMenuItemGoodsGroup.Size = new System.Drawing.Size(153, 24);
            this.ToolStripMenuItemGoodsGroup.Text = "تعريف گروه كالا";
            this.ToolStripMenuItemGoodsGroup.Click += new System.EventHandler(this.ToolStripMenuItemGoodsGroup_Click);
            // 
            // ToolStripMenuItemGoods
            // 
            this.ToolStripMenuItemGoods.Name = "ToolStripMenuItemGoods";
            this.ToolStripMenuItemGoods.Size = new System.Drawing.Size(153, 24);
            this.ToolStripMenuItemGoods.Text = "تعريف كالا";
            // 
            // ToolStripMenuItemGoodsBarcode
            // 
            this.ToolStripMenuItemGoodsBarcode.Name = "ToolStripMenuItemGoodsBarcode";
            this.ToolStripMenuItemGoodsBarcode.Size = new System.Drawing.Size(153, 24);
            this.ToolStripMenuItemGoodsBarcode.Text = "تعريف باركد كالا";
            // 
            // ToolStripMenuItemBankMenu
            // 
            this.ToolStripMenuItemBankMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemBankName,
            this.ToolStripMenuItemAccount,
            this.ToolStripMenuItemCheckBook});
            this.ToolStripMenuItemBankMenu.Name = "ToolStripMenuItemBankMenu";
            this.ToolStripMenuItemBankMenu.Size = new System.Drawing.Size(180, 24);
            this.ToolStripMenuItemBankMenu.Text = "بانك";
            // 
            // ToolStripMenuItemBankName
            // 
            this.ToolStripMenuItemBankName.Name = "ToolStripMenuItemBankName";
            this.ToolStripMenuItemBankName.Size = new System.Drawing.Size(173, 24);
            this.ToolStripMenuItemBankName.Text = "تعريف نام بانك";
            this.ToolStripMenuItemBankName.Click += new System.EventHandler(this.ToolStripMenuItemBankName_Click);
            // 
            // ToolStripMenuItemAccount
            // 
            this.ToolStripMenuItemAccount.Name = "ToolStripMenuItemAccount";
            this.ToolStripMenuItemAccount.Size = new System.Drawing.Size(173, 24);
            this.ToolStripMenuItemAccount.Text = "تعريف شماره حساب";
            this.ToolStripMenuItemAccount.Click += new System.EventHandler(this.ToolStripMenuItemAccount_Click);
            // 
            // ToolStripMenuItemCheckBook
            // 
            this.ToolStripMenuItemCheckBook.Name = "ToolStripMenuItemCheckBook";
            this.ToolStripMenuItemCheckBook.Size = new System.Drawing.Size(173, 24);
            this.ToolStripMenuItemCheckBook.Text = "تعريف دسته چك";
            // 
            // ToolStripMenuItemDailyInformation
            // 
            this.ToolStripMenuItemDailyInformation.Name = "ToolStripMenuItemDailyInformation";
            this.ToolStripMenuItemDailyInformation.Size = new System.Drawing.Size(88, 24);
            this.ToolStripMenuItemDailyInformation.Text = "اطلاعات روزانه";
            // 
            // ToolStripMenuItemFeatures
            // 
            this.ToolStripMenuItemFeatures.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemUserManagement,
            this.ToolStripMenuItemSetting,
            this.ToolStripMenuItemBackup,
            this.ToolStripMenuItemExit});
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
            this.pnlBottom.Controls.Add(this.lblDateTime);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.pnlBottom.Location = new System.Drawing.Point(0, 654);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlBottom.Size = new System.Drawing.Size(1008, 75);
            this.pnlBottom.TabIndex = 2;
            // 
            // lblDateTime
            // 
            this.lblDateTime.BackColor = System.Drawing.Color.Transparent;
            this.lblDateTime.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblDateTime.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F, System.Drawing.FontStyle.Bold);
            this.lblDateTime.ForeColor = System.Drawing.Color.Yellow;
            this.lblDateTime.Location = new System.Drawing.Point(0, 0);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblDateTime.Size = new System.Drawing.Size(184, 75);
            this.lblDateTime.TabIndex = 3;
            this.lblDateTime.Text = "زمان جاري سيستم";
            this.lblDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(1008, 729);
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
            this.Text = "صفحه اصلي";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.pnlMain.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.menuMainForm.ResumeLayout(false);
            this.menuMainForm.PerformLayout();
            this.pnlBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            timer1_Tick(null, null);
            pnlTop.Controls.Add(menuMainForm);
            pnlMain.Controls.Add(tabControlMain);
            pnlBottom.Controls.Add(lblDateTime);
            SetColor();
        }

        private void SetColor()
        {
            menuMainForm.BackColor = ConnectionInfo.BackgroudColor;
            pnlBottom.BackColor = ConnectionInfo.BackgroudColor;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBoxWarning.State = 0;
            if (CustomMessageForm.CustomMessageBox.Show("خروج", "آيا مي خواهيد از برنامه خارج شويد؟", "w") == DialogResult.No)
            {
                e.Cancel = true;
            }
            MessageBoxWarning.State = 1;
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
                        this.Close();
                    }
                    break;
                case Keys.F1:
                    CustomMessageForm.CustomMessageBox.Show("راهنماي برنامه", "تست", "i");
                    break;
            }
        }

        private void ToolStripMenuItemCustomerGroup_Click(object sender, EventArgs e)
        {
            var customerGroupDefinition = new CustomerGroupDefinition();
            tab.AddNewTab(tabControlMain, customerGroupDefinition);
        }

        private void ToolStripMenuItemExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("fa-IR");
            lblDateTime.Text = $"{DateTime.Now.ToString("HH:mm:ss")}\n{Date.ShamsiNow}\n{FullPersianDate.ToLongDateString()}";
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
            //var bankAccountDefinition = new BankAccountDefinition();
            //tab.AddNewTab(tabControlMain, bankAccountDefinition);
        }
    }
}