using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using TinyTech.Connection;
using TinyTech.UI.Control.MessageBox;
using TinyTech.UI.Control.TextBox;

namespace TinyTech.Main
{
    public class Login : Form
    {
        #region Region
        private UI.Control.TextBox.TextBox txtUserName;
        private UI.Control.TextBox.TextBox txtPassword;
        private UI.Control.ComboBox.ComboBox cmbFiscalYear;
        private UI.Control.Label.Label lblUserName;
        private UI.Control.Label.Label lblPassword;
        private UI.Control.Label.Label lblFiscalYear;
        private string GetInfoServerName;
        private string GetInfoDatabaseName;
        TinyTechEntities DB_Connection = new TinyTechEntities();
        private UI.Control.Button.OkButton btnLogin;
        private UI.Control.Button.ExitButton btnExit;
        private UI.Control.Label.Label lblWelcome;
        private UI.Control.Label.Label lblVersion;
        ConnectionClasses @class = new ConnectionClasses();
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

        public Login()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.lblVersion = new TinyTech.UI.Control.Label.Label();
            this.lblWelcome = new TinyTech.UI.Control.Label.Label();
            this.btnExit = new TinyTech.UI.Control.Button.ExitButton();
            this.btnLogin = new TinyTech.UI.Control.Button.OkButton();
            this.lblFiscalYear = new TinyTech.UI.Control.Label.Label();
            this.lblPassword = new TinyTech.UI.Control.Label.Label();
            this.lblUserName = new TinyTech.UI.Control.Label.Label();
            this.cmbFiscalYear = new TinyTech.UI.Control.ComboBox.ComboBox();
            this.txtPassword = new TinyTech.UI.Control.TextBox.TextBox();
            this.txtUserName = new TinyTech.UI.Control.TextBox.TextBox();
            this.SuspendLayout();
            // 
            // lblVersion
            // 
            this.lblVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVersion.BackColor = System.Drawing.Color.Transparent;
            this.lblVersion.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.lblVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblVersion.Location = new System.Drawing.Point(12, 420);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblVersion.Size = new System.Drawing.Size(380, 32);
            this.lblVersion.TabIndex = 9;
            this.lblVersion.Text = "اطلاعات نسخه برنامه";
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWelcome
            // 
            this.lblWelcome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("IRANSans(FaNum)", 10F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(12, 9);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblWelcome.Size = new System.Drawing.Size(371, 48);
            this.lblWelcome.TabIndex = 8;
            this.lblWelcome.Text = "به تايني تك سافت خوش آمديد\r\nلطفا جهت استفاده از نرم افزار با نام كاربري و كلمه عب" +
    "ور خود وارد شويد";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(56, 286);
            this.btnExit.Margin = new System.Windows.Forms.Padding(10);
            this.btnExit.Name = "btnExit";
            this.btnExit.NextControl = this.btnLogin;
            this.btnExit.Size = new System.Drawing.Size(76, 34);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "خروج";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(142)))), ((int)(((byte)(174)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(145, 286);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.NextControl = this.btnExit;
            this.btnLogin.Size = new System.Drawing.Size(81, 34);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "ورود";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblFiscalYear
            // 
            this.lblFiscalYear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFiscalYear.AutoSize = true;
            this.lblFiscalYear.BackColor = System.Drawing.Color.Transparent;
            this.lblFiscalYear.Font = new System.Drawing.Font("IRANSans(FaNum)", 12F, System.Drawing.FontStyle.Bold);
            this.lblFiscalYear.ForeColor = System.Drawing.Color.White;
            this.lblFiscalYear.Location = new System.Drawing.Point(239, 217);
            this.lblFiscalYear.Name = "lblFiscalYear";
            this.lblFiscalYear.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblFiscalYear.Size = new System.Drawing.Size(80, 27);
            this.lblFiscalYear.TabIndex = 5;
            this.lblFiscalYear.Text = "دوره مالي :";
            this.lblFiscalYear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("IRANSans(FaNum)", 12F, System.Drawing.FontStyle.Bold);
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(239, 168);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPassword.Size = new System.Drawing.Size(77, 27);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "كلمه عبور :";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUserName
            // 
            this.lblUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserName.AutoSize = true;
            this.lblUserName.BackColor = System.Drawing.Color.Transparent;
            this.lblUserName.Font = new System.Drawing.Font("IRANSans(FaNum)", 12F, System.Drawing.FontStyle.Bold);
            this.lblUserName.ForeColor = System.Drawing.Color.White;
            this.lblUserName.Location = new System.Drawing.Point(239, 120);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblUserName.Size = new System.Drawing.Size(82, 27);
            this.lblUserName.TabIndex = 3;
            this.lblUserName.Text = "نام كاربري :";
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbFiscalYear
            // 
            this.cmbFiscalYear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFiscalYear.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbFiscalYear.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbFiscalYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiscalYear.Font = new System.Drawing.Font("IRANSans(FaNum)", 10F, System.Drawing.FontStyle.Bold);
            this.cmbFiscalYear.FormattingEnabled = true;
            this.cmbFiscalYear.Location = new System.Drawing.Point(56, 214);
            this.cmbFiscalYear.Margin = new System.Windows.Forms.Padding(10);
            this.cmbFiscalYear.Name = "cmbFiscalYear";
            this.cmbFiscalYear.NextControl = this.btnLogin;
            this.cmbFiscalYear.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbFiscalYear.Size = new System.Drawing.Size(170, 30);
            this.cmbFiscalYear.TabIndex = 2;
            this.cmbFiscalYear.Enter += new System.EventHandler(this.cmbFiscalYear_Enter);
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("IRANSans(FaNum)", 10F, System.Drawing.FontStyle.Bold);
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.Location = new System.Drawing.Point(56, 166);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(10);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.NextControl = this.cmbFiscalYear;
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPassword.Size = new System.Drawing.Size(170, 30);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            // 
            // txtUserName
            // 
            this.txtUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUserName.BackColor = System.Drawing.Color.White;
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserName.Font = new System.Drawing.Font("IRANSans(FaNum)", 10F, System.Drawing.FontStyle.Bold);
            this.txtUserName.ForeColor = System.Drawing.Color.Black;
            this.txtUserName.Location = new System.Drawing.Point(56, 118);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(10);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.NextControl = this.txtPassword;
            this.txtUserName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtUserName.Size = new System.Drawing.Size(170, 30);
            this.txtUserName.TabIndex = 0;
            this.txtUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUserName.Enter += new System.EventHandler(this.txtUserName_Enter);
            // 
            // Login
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::TinyTech.Main.Properties.Resources.LoginBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblFiscalYear);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.cmbFiscalYear);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ورود به برنامه";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.Load += new System.EventHandler(this.Login_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Login_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (!FormIsValid()) return;
                var currentSelectedFiscalYear = int.Parse(cmbFiscalYear.SelectedValue.ToString());
                var databaseName = @class.GetFiscalYear().FirstOrDefault(i => i.ID == currentSelectedFiscalYear);
                ConnectionInfo.DatabaseName = databaseName?.DatabaseName;
                DB_Connection = new TinyTechEntities();
                if (!CheckNewConnection()) return;
                if (!CheckLoginInfo()) return;
                base.Hide();
                var mainForm = new MainForm();
                mainForm.Show();
            }
            catch (Exception ex)
            {
                CustomMessageForm.CustomMessageBox.Show("خطا !", $"خطا در ورود به برنامه\n\n{ex.Message}", "e");
            }
        }

        private bool CheckNewConnection()
        {
            try
            {
                var connectionTest = DB_Connection.FiscalYear.AsNoTracking().ToList();
                return connectionTest.Count > 0;
            }
            catch (Exception e)
            {
                CustomMessageForm.CustomMessageBox.Show("خطا !", $"خطا در اتصال به ديتابيس\n\n{e.Message}", "e");
                Login_Load(null, null);
            }

            return false;
        }

        private bool CheckLoginInfo()
        {
            try
            {

                var loginStatus = @class.CheckLoginInfo(txtUserName.Text.Trim(), txtPassword.Text);
                if (loginStatus == 1)
                {
                    CustomMessageForm.CustomMessageBox.Show("اخطار !", $"نام كاربري اشتباه است", "e");
                    txtUserName.Focus();
                    return false;
                }

                if (loginStatus != 2) return true;
                CustomMessageForm.CustomMessageBox.Show("اخطار !", $"كلمه عبور اشتباه است", "e");
                txtPassword.Focus();
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private bool FormIsValid()
        {
            if (string.IsNullOrWhiteSpace(txtUserName.Text))
            {
                CustomMessageForm.CustomMessageBox.Show("خطا !", $"لطفا نام كاربري را وارد كنيد", "e");
                txtUserName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                CustomMessageForm.CustomMessageBox.Show("خطا !", $"لطفا كلمه عبور را وارد كنيد", "e");
                txtPassword.Focus();
                return false;
            }
            return true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            try
            {
                lblVersion.Text = ConnectionInfo.Version;
                SetData();
                ConnectionInfo.ServerName = GetInfoServerName;
                ConnectionInfo.DatabaseName = GetInfoDatabaseName;
                DB_Connection = new TinyTechEntities();
                cmbFiscalYear.DataSource = @class.GetFiscalYear().Where(i => i.Active).ToList();
                cmbFiscalYear.DisplayMember = "DisplayName";
                cmbFiscalYear.ValueMember = "ID";
            }
            catch (Exception ex)
            {
                CustomMessageForm.CustomMessageBox.Show("خطا !", $"{ex.Message}", "e");
            }
        }

        private void SetData()
        {
            try
            {
                var reader = new XmlTextReader("GetInfo.XML");
                while (reader.Read())
                {
                    if (reader.NodeType != XmlNodeType.Element) continue;
                    switch (reader.Name)
                    {
                        case "Server":
                            reader.Read();
                            GetInfoServerName = reader.Value;
                            break;
                        case "Database":
                            reader.Read();
                            GetInfoDatabaseName = reader.Value;
                            break;
                    }
                }
                reader.Close();
                reader.Dispose();
            }
            catch (Exception ex)
            {
                CustomMessageForm.CustomMessageBox.Show("خطا !", $"خطا در شناسايي فايل ديتابيس\n\n{ex.Message}", "e");
            }
        }

        private void txtUserName_Enter(object sender, EventArgs e)
        {
            txtUserName.SelectAll();
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            txtPassword.SelectAll();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }

        private void cmbFiscalYear_Enter(object sender, EventArgs e)
        {
            cmbFiscalYear.DroppedDown = true;
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    Application.Exit();
                    break;
                case Keys.F1:
                    CustomMessageForm.CustomMessageBox.Show("راهنما", "راهنماي فرم ورود به برنامه", "i");
                    break;
            }
        }
    }
}

