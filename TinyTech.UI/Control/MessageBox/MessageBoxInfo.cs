using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using TinyTech.UI.Control.Button;
using TinyTech.UI.Properties;

namespace TinyTech.UI.Control.MessageBox
{
    public class MessageBoxInfo : System.Windows.Forms.Form
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel2 = new TinyTech.UI.Control.UIElement.Panel();
            this.okButton1 = new TinyTech.UI.Control.Button.OkButton();
            this.panel1 = new TinyTech.UI.Control.UIElement.Panel();
            this.label2 = new TinyTech.UI.Control.Label.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("IRANSans(FaNum)", 10.75F);
            this.richTextBox1.Location = new System.Drawing.Point(28, 70);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox1.Size = new System.Drawing.Size(333, 57);
            this.richTextBox1.TabIndex = 15;
            this.richTextBox1.Text = "";
            this.richTextBox1.ContentsResized += new System.Windows.Forms.ContentsResizedEventHandler(this.richTextBox1_ContentsResized);
            this.richTextBox1.Enter += new System.EventHandler(this.richTextBox1_Enter);
            this.richTextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.richTextBox1_KeyDown);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.Controls.Add(this.okButton1);
            this.panel2.Font = new System.Drawing.Font("IRANSans(FaNum)", 9.5F);
            this.panel2.Location = new System.Drawing.Point(1, 141);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(88, 41);
            this.panel2.TabIndex = 0;
            // 
            // okButton1
            // 
            this.okButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(142)))), ((int)(((byte)(174)))));
            this.okButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okButton1.Font = new System.Drawing.Font("IRANSans(FaNum)", 9.5F);
            this.okButton1.ForeColor = System.Drawing.Color.White;
            this.okButton1.Location = new System.Drawing.Point(3, 3);
            this.okButton1.Name = "okButton1";
            this.okButton1.NextControl = null;
            this.okButton1.Size = new System.Drawing.Size(81, 34);
            this.okButton1.TabIndex = 1;
            this.okButton1.Text = "تاييد";
            this.okButton1.UseVisualStyleBackColor = false;
            this.okButton1.Click += new System.EventHandler(this.okButton1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("IRANSans(FaNum)", 9.5F);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(462, 28);
            this.panel1.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("IRANSans(FaNum)", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 1);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(459, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "پيام";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::TinyTech.UI.Properties.Resources.Information;
            this.pictureBox1.Location = new System.Drawing.Point(383, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 49);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // MessageBoxInfo
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(462, 186);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MessageBoxInfo";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MessageBoxInfo_Load);
            this.Shown += new System.EventHandler(this.CustomMessageForm_Shown);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        public MessageBoxInfo(string description, string title)
        {
            this.InitializeComponent();
            this.richTextBox1.Text = description;
            this.label2.Text = title;
        }

        private void okButton1_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void CustomMessageForm_Shown(object sender, EventArgs e)
        {
            this.pictureBox1.Image = Resources.Information;
            this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                base.Close();
            }
        }

        private void richTextBox1_ContentsResized(object sender, ContentsResizedEventArgs e)
        {
            this.richTextBox1.Height = (this.richTextBox1.GetLineFromCharIndex(this.richTextBox1.Text.Length) + 2) * this.richTextBox1.Font.Height + this.richTextBox1.Margin.Vertical;
            if (this.richTextBox1.Size.Height > 66)
            {
                base.Size = new Size(base.Width, this.richTextBox1.Height + 120);
            }
        }

        private void richTextBox1_Enter(object sender, EventArgs e)
        {
            this.okButton1.Focus();
        }

        private void MessageBoxInfo_Load(object sender, EventArgs e)
        {
            this.okButton1.Focus();
        }

        private System.Windows.Forms.RichTextBox richTextBox1;
        private TinyTech.UI.Control.UIElement.Panel panel1;
        public TinyTech.UI.Control.Label.Label label2;
        private OkButton okButton1;
        private TinyTech.UI.Control.UIElement.Panel panel2;
        private PictureBox pictureBox1;
        private IContainer components;

        public static class CustomMessageBox
        {
            public static void Show(string title, string description)
            {
                using (System.Windows.Forms.Form form = new MessageBoxInfo(description, title))
                {
                    form.ShowDialog();
                }
            }
        }
    }
}
