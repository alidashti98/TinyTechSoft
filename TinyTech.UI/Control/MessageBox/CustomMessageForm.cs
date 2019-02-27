using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TinyTech.UI.Control.MessageBox
{
    public class CustomMessageForm : Form
    {
        private void InitializeComponent()
        {
            base.SuspendLayout();
            this.BackColor = Color.Black;
            base.ClientSize = new Size(1280, 769);
            base.FormBorderStyle = FormBorderStyle.None;
            base.Name = "CustomMessageForm";
            base.Opacity = 0.7;
            base.ShowIcon = false;
            base.StartPosition = FormStartPosition.CenterScreen;
            base.WindowState = FormWindowState.Maximized;
            base.Load += this.CustomMessageForm_Load;
            base.ResumeLayout(false);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                components?.Dispose();
            }
            base.Dispose(disposing);
        }

        public CustomMessageForm(string description, string title, string BoxName = "i")
        {
            this.InitializeComponent();
        }

        public static void CloseLoading()
        {
            MessageBoxLoading.CustomMessageBox.Close();
        }

        private void CustomMessageForm_Load(object sender, EventArgs e)
        {
            if (CustomMessageForm.BoxNum_ == "i")
            {
                MessageBoxInfo.CustomMessageBox.Show(CustomMessageForm.Title_, CustomMessageForm.Desc_);
                base.Close();
            }
            if (CustomMessageForm.BoxNum_ == "e")
            {
                MessageBoxError.CustomMessageBox.Show(CustomMessageForm.Title_, CustomMessageForm.Desc_);
                base.Close();
            }
            if (CustomMessageForm.BoxNum_ == "w")
            {
                MessageBoxWarning.CustomMessageBox.Show(CustomMessageForm.Title_, CustomMessageForm.Desc_, ref CustomMessageForm.dialog);
                base.Close();
            }
            if (CustomMessageForm.BoxNum_ == "l")
            {
                MessageBoxLoading.CustomMessageBox.Show(CustomMessageForm.Title_, CustomMessageForm.Desc_, CustomMessageForm.Task_, this);
            }
        }

        private IContainer components;
        public static string Desc_;
        public static string Title_;
        public static string BoxNum_;
        public static Task<object> Task_;
        public static DialogResult dialog;
        private static MessageBoxLoading LoadingBox;

        public static class CustomMessageBox
        {
            public static DialogResult Show(string title, string description, string boxName = "i")
            {
                using (CustomMessageForm customMessageForm = new CustomMessageForm(description, title, boxName))
                {
                    CustomMessageForm.Desc_ = description;
                    CustomMessageForm.Title_ = title;
                    CustomMessageForm.BoxNum_ = boxName;
                    customMessageForm.ShowDialog();
                }
                return CustomMessageForm.dialog;
            }

            public static async Task<object> Show(string title, string description, Task<object> t)
            {
                using (CustomMessageForm customMessageForm = new CustomMessageForm(description, title, "l"))
                {
                    CustomMessageForm.Desc_ = description;
                    CustomMessageForm.Title_ = title;
                    CustomMessageForm.BoxNum_ = "l";
                    CustomMessageForm.Task_ = t;
                    customMessageForm.ShowDialog();
                }
                return await t;
            }
        }
    }
}
