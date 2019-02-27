using System;
using System.Drawing;
using System.Windows.Forms;

namespace TinyTech.UI.Control.UIElement
{
    public class UserControlLoader
    {
        private void D_Load(object sender, EventArgs e)
        {
            using (var form = new Form())
            {
                if (AllSize)
                {
                    if (showMaximizeSate_)
                    {
                        form.KeyPreview = true;
                        usercontrol_.Dock = DockStyle.Fill;
                        form.WindowState = FormWindowState.Maximized;
                        form.Controls.Add(usercontrol_);
                        form.ShowDialog();
                        form.FormBorderStyle = FormBorderStyle.None;
                        //if (Pad)
                        //{
                        //    form.BackColor = Color.LightSeaGreen;
                        //}
                        //if (Pad)
                        //{
                        //    form.Padding = new Padding(10, 10, 10, 10);
                        //}
                        D.Close();
                    }
                    else
                    {
                        form.KeyPreview = true;
                        form.StartPosition = FormStartPosition.CenterScreen;
                        form.Width = usercontrol_.Width;
                        form.Height = usercontrol_.Height;
                        form.FormBorderStyle = FormBorderStyle.None;
                        if (ChangeSizeFormBySizeOfTheUserControl)
                        {
                            form.MaximumSize = new Size(usercontrol_.Width, usercontrol_.Height);
                        }
                        usercontrol_.Dock = DockStyle.Fill;
                        form.WindowState = FormWindowState.Normal;
                        //if (Pad)
                        //{
                        //    form.BackColor = Color.LightSeaGreen;
                        //}
                        //if (Pad)
                        //{
                        //    form.Padding = new Padding(10, 10, 10, 10);
                        //}
                        form.Controls.Add(usercontrol_);
                        form.ShowDialog();
                        D.Close();
                    }
                }
                else
                {
                    form.KeyPreview = true;
                    form.StartPosition = FormStartPosition.CenterScreen;
                    usercontrol_.Width = Screen.PrimaryScreen.Bounds.Width - 30;
                    usercontrol_.Height = Screen.PrimaryScreen.Bounds.Height - 30;
                    form.Width = usercontrol_.Width;
                    form.Height = usercontrol_.Height;
                    form.MaximumSize = new Size(usercontrol_.Width, usercontrol_.Height);
                    usercontrol_.Dock = DockStyle.Fill;
                    form.WindowState = FormWindowState.Normal;
                    form.FormBorderStyle = FormBorderStyle.None;
                    //if (Pad)
                    //{
                    //    form.BackColor = Color.LightSeaGreen;
                    //}
                    //if (Pad)
                    //{
                    //    form.Padding = new Padding(10, 10, 10, 10);
                    //}
                    form.Controls.Add(usercontrol_);
                    form.ShowDialog();
                    D.Close();
                }
            }
        }

        public UserControlLoader(System.Windows.Forms.UserControl usercontrol, bool ChangeSizeFormBySizeOfTheUserControl_ = false, bool showMaximizeSate = false, bool AllSize_ = false, bool Pad_ = true)
        {
            try
            {
                usercontrol_ = usercontrol;
                using (this.D = new Form())
                {
                    this.D.BackColor = Color.Black;
                    this.D.Opacity = 0.60000002384185791;
                    this.D.Width = usercontrol.Width;
                    this.D.KeyPreview = true;
                    this.D.Height = usercontrol.Height;
                    this.D.WindowState = FormWindowState.Maximized;
                    this.D.FormBorderStyle = FormBorderStyle.None;
                    showMaximizeSate_ = showMaximizeSate;
                    Pad = Pad_;
                    AllSize = AllSize_;
                    ChangeSizeFormBySizeOfTheUserControl = ChangeSizeFormBySizeOfTheUserControl_;
                    this.D.Load += D_Load;
                    this.D.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        // Token: 0x040004B4 RID: 1204
        private Form D;

        // Token: 0x040004B5 RID: 1205
        private bool ChangeSizeFormBySizeOfTheUserControl;

        // Token: 0x040004B6 RID: 1206
        private bool AllSize;

        // Token: 0x040004B7 RID: 1207
        private bool Pad;

        // Token: 0x040004B8 RID: 1208
        private bool showMaximizeSate_;

        // Token: 0x040004B9 RID: 1209
        private System.Windows.Forms.UserControl usercontrol_;
    }
}
