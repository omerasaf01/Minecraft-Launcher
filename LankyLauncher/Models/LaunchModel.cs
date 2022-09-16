using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LankyLauncher.Models
{
    public class LaunchModel
    {
        public int Memory { get; set; } = 2248;
        public string ServerIP { get; set; } = "hypixel.net";
        public int ScreenWidth { get; set; } = 1600;
        public int ScreenHeight { get; set; } = 900;
        public string Version { get; set; } = "1.8.9"
    }
}
