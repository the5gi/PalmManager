using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PalmManager
{
    public partial class Startup : Form
    {
        public static string tempdir = @"C:\Windows\Temp\";
        public static string ver = "1.0.0";
        public Startup()
        {

            InitializeComponent();
            if (File.Exists(tempdir + "list.json"))
            {
                File.Delete(tempdir + "list.json");
                using (var client = new WebClient())
                {
                    client.DownloadFile("https://raw.githubusercontent.com/the5gi/palmdependencies/main/latestver", tempdir + "latestver");
                }
            }
            else
            {
                using (var client = new WebClient())
                {
                    client.DownloadFile("https://raw.githubusercontent.com/the5gi/palmdependencies/main/latestver", tempdir + "latestver");
                }
            }

            if (File.ReadAllText(tempdir + "latestver").Contains(ver))
            {
                delayedWork();
            }
            else 
            {
                delayedWork2();
            }
            //
        }
        private async Task delayedWork()
        {
            await Task.Delay(3000);


            this.Visible = false;
            var f2 = new Main();
            f2.ShowDialog();
        }
        private async Task delayedWork2()
        {
            this.Visible = false;
            System.Windows.Forms.MessageBox.Show("Outdated Version. Updating...", "Info");
            System.Environment.Exit(0);
        }
    }
}
