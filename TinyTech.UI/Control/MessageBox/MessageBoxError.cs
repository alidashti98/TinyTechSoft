using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using TinyTech.UI.Control.Button;
using TinyTech.UI.Properties;

namespace TinyTech.UI.Control.MessageBox
{
    public class MessageBoxError : Form
    {
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                components?.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this._richTextBox1 = new TinyTech.UI.Control.TextBox.RichTextBox();
            this._panel1 = new TinyTech.UI.Control.UIElement.Panel();
            this.Label2 = new TinyTech.UI.Control.Label.Label();
            this._panel2 = new TinyTech.UI.Control.UIElement.Panel();
            this._okButton1 = new TinyTech.UI.Control.Button.OkButton();
            this._pictureBox1 = new System.Windows.Forms.PictureBox();
            this._panel1.SuspendLayout();
            this._panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // _richTextBox1
            // 
            this._richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._richTextBox1.Font = new System.Drawing.Font("IRANSans(FaNum)", 10.75F);
            this._richTextBox1.Location = new System.Drawing.Point(27, 66);
            this._richTextBox1.Name = "_richTextBox1";
            this._richTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this._richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this._richTextBox1.Size = new System.Drawing.Size(337, 66);
            this._richTextBox1.TabIndex = 14;
            this._richTextBox1.Text = "";
            this._richTextBox1.ContentsResized += new System.Windows.Forms.ContentsResizedEventHandler(this.RichTextBox1_ContentsResized);
            this._richTextBox1.Enter += new System.EventHandler(this.RichTextBox1_Enter);
            this._richTextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RichTextBox1_KeyDown);
            // 
            // _panel1
            // 
            this._panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(44)))), ((int)(((byte)(0)))));
            this._panel1.Controls.Add(this.Label2);
            this._panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this._panel1.Font = new System.Drawing.Font("IRANSans(FaNum)", 9.5F);
            this._panel1.Location = new System.Drawing.Point(0, 0);
            this._panel1.Name = "_panel1";
            this._panel1.Size = new System.Drawing.Size(462, 28);
            this._panel1.TabIndex = 17;
            // 
            // Label2
            // 
            this.Label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Font = new System.Drawing.Font("IRANSans(FaNum)", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label2.ForeColor = System.Drawing.Color.White;
            this.Label2.Location = new System.Drawing.Point(3, 0);
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label2.Size = new System.Drawing.Size(456, 25);
            this.Label2.TabIndex = 11;
            this.Label2.Text = "خطا";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _panel2
            // 
            this._panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._panel2.Controls.Add(this._okButton1);
            this._panel2.Font = new System.Drawing.Font("IRANSans(FaNum)", 9.5F);
            this._panel2.Location = new System.Drawing.Point(1, 141);
            this._panel2.Name = "_panel2";
            this._panel2.Size = new System.Drawing.Size(88, 39);
            this._panel2.TabIndex = 18;
            // 
            // _okButton1
            // 
            this._okButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(142)))), ((int)(((byte)(174)))));
            this._okButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._okButton1.Font = new System.Drawing.Font("IRANSans(FaNum)", 9.5F);
            this._okButton1.ForeColor = System.Drawing.Color.White;
            this._okButton1.Location = new System.Drawing.Point(3, 3);
            this._okButton1.Name = "_okButton1";
            this._okButton1.NextControl = null;
            this._okButton1.Size = new System.Drawing.Size(81, 34);
            this._okButton1.TabIndex = 19;
            this._okButton1.Text = "تاييد";
            this._okButton1.UseVisualStyleBackColor = false;
            this._okButton1.Click += new System.EventHandler(this.OkButton1_Click);
            // 
            // _pictureBox1
            // 
            this._pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._pictureBox1.Image = global::TinyTech.UI.Properties.Resources.Error;
            this._pictureBox1.Location = new System.Drawing.Point(383, 50);
            this._pictureBox1.Name = "_pictureBox1";
            this._pictureBox1.Size = new System.Drawing.Size(57, 53);
            this._pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this._pictureBox1.TabIndex = 10;
            this._pictureBox1.TabStop = false;
            // 
            // MessageBoxError
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(462, 186);
            this.Controls.Add(this._panel2);
            this.Controls.Add(this._panel1);
            this.Controls.Add(this._richTextBox1);
            this.Controls.Add(this._pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MessageBoxError";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.CustomMessageForm_Load);
            this.Shown += new System.EventHandler(this.CustomMessageForm_Shown);
            this._panel1.ResumeLayout(false);
            this._panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        public MessageBoxError(string description, string title)
        {
            InitializeComponent();
            _richTextBox1.Text = description;
            Label2.Text = title;
        }

        private void OkButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CustomMessageForm_Shown(object sender, EventArgs e)
        {
            this._pictureBox1.Image = Resources.Error;
            _pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void CustomMessageForm_Load(object sender, EventArgs e)
        {
            _okButton1.Focus();
        }

        private void RichTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void RichTextBox1_Enter(object sender, EventArgs e)
        {
            _okButton1.Focus();
        }

        private void RichTextBox1_ContentsResized(object sender, ContentsResizedEventArgs e)
        {
            _richTextBox1.Height = (_richTextBox1.GetLineFromCharIndex(_richTextBox1.Text.Length) + 2) * _richTextBox1.Font.Height + _richTextBox1.Margin.Vertical;
            if (_richTextBox1.Size.Height > 66)
            {
                Size = new Size(Width, _richTextBox1.Height + 120);
            }
        }

        public static class CustomMessageBox
        {
            public static void Show(string title, string description)
            {
                using (var messageBoxError = new MessageBoxError(description, title))
                {
                    messageBoxError.ShowDialog();
                }
            }
        }

        public Label.Label Label2;
        private TextBox.RichTextBox _richTextBox1;
        private UIElement.Panel _panel1;
        private UIElement.Panel _panel2;
        private OkButton _okButton1;
        private PictureBox _pictureBox1;
        private IContainer components;
    }
}