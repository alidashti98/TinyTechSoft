using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using TinyTech.UI.Control.Button;
using TinyTech.UI.Properties;

namespace TinyTech.UI.Control.MessageBox
{
    public class MessageBoxWarning : System.Windows.Forms.Form
    {
        public static int State { get; set; } = 1;

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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel3 = new TinyTech.UI.Control.UIElement.Panel();
            this.okButton1 = new TinyTech.UI.Control.Button.OkButton();
            this.cancelButton1 = new TinyTech.UI.Control.Button.CancelButton();
            this.panel1 = new TinyTech.UI.Control.UIElement.Panel();
            this.label1 = new TinyTech.UI.Control.Label.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::TinyTech.UI.Properties.Resources.Alarm;
            this.pictureBox1.Location = new System.Drawing.Point(388, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 50);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("IRANSans(FaNum)", 10.75F);
            this.richTextBox1.Location = new System.Drawing.Point(23, 69);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox1.Size = new System.Drawing.Size(343, 57);
            this.richTextBox1.TabIndex = 18;
            this.richTextBox1.Text = "";
            this.richTextBox1.ContentsResized += new System.Windows.Forms.ContentsResizedEventHandler(this.richTextBox1_ContentsResized);
            this.richTextBox1.Enter += new System.EventHandler(this.richTextBox1_Enter);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.Controls.Add(this.okButton1);
            this.panel3.Controls.Add(this.cancelButton1);
            this.panel3.Font = new System.Drawing.Font("IRANSans(FaNum)", 9.5F);
            this.panel3.Location = new System.Drawing.Point(3, 142);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(176, 38);
            this.panel3.TabIndex = 19;
            // 
            // okButton1
            // 
            this.okButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.okButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(142)))), ((int)(((byte)(174)))));
            this.okButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okButton1.Font = new System.Drawing.Font("IRANSans(FaNum)", 9.5F);
            this.okButton1.ForeColor = System.Drawing.Color.White;
            this.okButton1.Location = new System.Drawing.Point(90, 1);
            this.okButton1.Name = "okButton1";
            this.okButton1.NextControl = null;
            this.okButton1.Size = new System.Drawing.Size(81, 34);
            this.okButton1.TabIndex = 18;
            this.okButton1.Text = "بلي";
            this.okButton1.UseVisualStyleBackColor = false;
            this.okButton1.Click += new System.EventHandler(this.okButton1_Click);
            // 
            // cancelButton1
            // 
            this.cancelButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cancelButton1.BackColor = System.Drawing.Color.White;
            this.cancelButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton1.Font = new System.Drawing.Font("IRANSans(FaNum)", 9.5F);
            this.cancelButton1.ForeColor = System.Drawing.Color.Gray;
            this.cancelButton1.Location = new System.Drawing.Point(3, 1);
            this.cancelButton1.Name = "cancelButton1";
            this.cancelButton1.NextControl = null;
            this.cancelButton1.Size = new System.Drawing.Size(81, 34);
            this.cancelButton1.TabIndex = 2;
            this.cancelButton1.Text = "خير";
            this.cancelButton1.UseVisualStyleBackColor = false;
            this.cancelButton1.Click += new System.EventHandler(this.cancelButton1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("IRANSans(FaNum)", 9.5F);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(462, 28);
            this.panel1.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("IRANSans(FaNum)", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 1);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(453, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "پيام";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MessageBoxWarning
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(462, 186);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MessageBoxWarning";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.CustomMessageForm_Load);
            this.Shown += new System.EventHandler(this.CustomMessageForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        public MessageBoxWarning(string description, string title)
        {
            this.InitializeComponent();
            this.richTextBox1.Text = description;
            this.label1.Text = title;
        }

        private void okButton1_Click(object sender, EventArgs e)
        {
            MessageBoxWarning.dlg = DialogResult.Yes;
            base.Close();
        }

        private void CustomMessageForm_Shown(object sender, EventArgs e)
        {
            this.pictureBox1.Image = Resources.Alarm;
            this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void CustomMessageForm_Load(object sender, EventArgs e)
        {
            if (MessageBoxWarning.State == 0)
            {
                this.cancelButton1.Focus();
                return;
            }
            this.okButton1.Focus();
        }

        private void cancelButton1_Click(object sender, EventArgs e)
        {
            MessageBoxWarning.dlg = DialogResult.No;
            base.Close();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                MessageBoxWarning.dlg = DialogResult.No;
            }
            return base.ProcessCmdKey(ref msg, keyData);
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
            if (MessageBoxWarning.State == 0)
            {
                this.cancelButton1.Focus();
                return;
            }
            this.okButton1.Focus();
        }

        private TinyTech.UI.Control.UIElement.Panel panel1;
        public TinyTech.UI.Control.Label.Label label1;
        private CancelButton cancelButton1;
        private OkButton okButton1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private TinyTech.UI.Control.UIElement.Panel panel3;
        private PictureBox pictureBox1;
        private IContainer components;
        public static DialogResult dlg;

        public static class CustomMessageBox
        {
            public static void Show(string title, string description, ref DialogResult dialog)
            {
                using (MessageBoxWarning messageBoxWarning = new MessageBoxWarning(description, title))
                {
                    messageBoxWarning.ShowDialog();
                    dialog = MessageBoxWarning.dlg;
                }
            }
        }
    }
}
