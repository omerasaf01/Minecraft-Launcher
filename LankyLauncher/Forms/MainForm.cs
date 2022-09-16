using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CmlLib.Core;
using CmlLib.Core.Auth;
using LankyLauncher.Models;

namespace LankyLauncher.Forms
{
    public partial class MainForm : Form
    {
        public MainForm(Account User)
        {
            InitializeComponent();
            label1.Text = User.UserName;
            webBrowser1.Navigate("https://hypixel.net/forums/news-and-announcements.4/");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var path = new MinecraftPath();
            var launcher = new CMLauncher(path);

            string UserName = label1.Text;

            LaunchModel model = new LaunchModel { };
            MLaunchOption options = new MLaunchOption
            {
                MaximumRamMb = model.Memory,
                Session = MSession.GetOfflineSession(UserName),
                ScreenWidth = model.ScreenWidth,
                ScreenHeight = model.ScreenHeight,
                ServerIp = model.ServerIP,
            };

            var process = launcher.CreateProcess(model.Version, options);
        }
    }
}
