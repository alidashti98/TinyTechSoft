using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TinyTech.UI.Control.UIElement
{
    public class TabManagement
    {
        public class CloseService
        {
            public TabControl TabControlList { get; set; }

            public Guid Guid { get; set; }

            public CloseService()
            {

            }
        }

        public static List<CloseService> CloseList = new List<CloseService>();

        public void CloseTab(UserControl myUserControl)
        {
            CloseList.FirstOrDefault(a => a.Guid == myUserControl.guid).TabControlList.TabPages.Remove(CloseList.FirstOrDefault(a => a.Guid == myUserControl.guid).TabControlList.SelectedTab);
            CloseList.Remove(CloseList.FirstOrDefault(i => i.Guid == myUserControl.guid));
        }

        public void AddNewTab(TabControl myTabControl, UserControl myUserControl)
        {
            var myTabPage = new TabPage();
            myUserControl.Dock = DockStyle.Fill;
            myTabPage.Dock = DockStyle.Fill;
            myTabControl.Dock = DockStyle.Fill;
            myTabPage.Controls.Add(myUserControl);
            myTabControl.TabPages.Add(myTabPage);
            myTabPage.Text = $"{myUserControl.Tag}";
            myUserControl.Size = myTabControl.Size;
            var maxTabControlIndex = myTabControl.TabCount;
            myTabControl.SelectedIndex = maxTabControlIndex - 1;
            var closeService = new CloseService
            {
                TabControlList = myTabControl,
                Guid = myUserControl.guid
            };
            CloseList.Add(closeService);
        }
    }
}
