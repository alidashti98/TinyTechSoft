using System;
using System.ComponentModel;
using System.Drawing;
using System.Resources;
using System.Threading.Tasks;
using System.Windows.Forms;
using TinyTech.UI.Properties;

namespace TinyTech.UI.Control.MessageBox
{
    // Token: 0x02000076 RID: 118
    public class MessageBoxLoading : System.Windows.Forms.Form
    {
        // Token: 0x060006BF RID: 1727 RVA: 0x0007F2D1 File Offset: 0x0007D4D1
        protected override void Dispose(bool disposing)
        {
            if (disposing && this.components != null)
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        // Token: 0x060006C0 RID: 1728 RVA: 0x0007F2F0 File Offset: 0x0007D4F0
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new TinyTech.UI.Control.Label.Label();
            this.panel1 = new TinyTech.UI.Control.UIElement.Panel();
            this.label2 = new TinyTech.UI.Control.Label.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(383, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 49);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.richTextBox1.Font = new System.Drawing.Font("IRANSans(FaNum)", 10.75F);
            this.richTextBox1.Location = new System.Drawing.Point(28, 70);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.richTextBox1.Size = new System.Drawing.Size(333, 57);
            this.richTextBox1.TabIndex = 15;
            this.richTextBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.label2.Location = new System.Drawing.Point(3, 1);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(456, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "کمی صبر کنید ...";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MessageBoxLoading
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(462, 186);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MessageBoxLoading";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        // Token: 0x060006C1 RID: 1729 RVA: 0x0007F64B File Offset: 0x0007D84B
        public MessageBoxLoading(string description, string title)
        {
            this.InitializeComponent();
            this.richTextBox1.Text = description;
            if (string.IsNullOrEmpty(title))
            {
                title = "کمی صبر کنید ...";
            }
            this.label2.Text = title;
        }

        private void CustomMessageForm_Shown(object sender, EventArgs e)
        {
            this.pictureBox1.Image = Resources.Information;
            this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            //Image image = ResourceManager.GetResourceManager().GetObject("loader") as Bitmap;
            //this.pictureBox1.Image = image;
        }

        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                base.Close();
            }
        }

        private TinyTech.UI.Control.Label.Label richTextBox1;
        private TinyTech.UI.Control.UIElement.Panel panel1;
        public TinyTech.UI.Control.Label.Label label2;
        private PictureBox pictureBox1;
        private IContainer components;

        public static class CustomMessageBox
        {
            public static async Task<object> Show(string title, string description, Task<object> t, System.Windows.Forms.Form parrent)
            {
                MessageBoxLoading.CustomMessageBox.parrent = parrent;
                MessageBoxLoading.CustomMessageBox.form = new MessageBoxLoading(description, title);
                if (t != null)
                {
                    if (!t.IsCompleted)
                    {
                        t.GetAwaiter().OnCompleted(new Action(MessageBoxLoading.CustomMessageBox.Close));
                        MessageBoxLoading.CustomMessageBox.form.ShowDialog();
                    }
                    else
                    {
                        System.Windows.Forms.Form form = parrent;
                        form?.Close();
                        parrent = null;
                    }
                }
                return await t;
            }

            public static void Show(string title, string description)
            {
                using (System.Windows.Forms.Form form = new MessageBoxInfo(description, title))
                {
                    form.ShowDialog();
                }
            }

            public static void Close()
            {
                System.Windows.Forms.Form form = MessageBoxLoading.CustomMessageBox.form;
                form?.Close();
                System.Windows.Forms.Form form2 = MessageBoxLoading.CustomMessageBox.parrent;
                if (form2 == null)
                {
                    return;
                }
                form2.Close();
            }

            private static System.Windows.Forms.Form form;
            private static System.Windows.Forms.Form parrent;
        }
    }
}
