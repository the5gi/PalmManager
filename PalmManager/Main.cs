using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PalmManager
{
    
    public partial class Main : Form
    {
        public static string installdir = "";
        public Main()
        {
            InitializeComponent();
            this.FormClosing += OnFormClosing;this.Visible = false;
            starttask();
        }

        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            System.Environment.Exit(0);
        }


        private async Task starttask()
        {
            //Apps
            applist.Items.Add("Gorilla Tag");
            //Apps
        }

        private void applist_SelectedIndexChanged(object sender, EventArgs e)
        {
            getapp();
            currentdirused.Text = installdir;
        }

        private async Task getapp()
        {
            //Gorilla Tag Check
            if (applist.SelectedItem.Equals("Gorilla Tag"))
            {
                foreach (string s in addonlist.Items)
                {
                    addonlist.Items.Remove(s);
                }
                //apps
                addonlist.Items.Add("Safe Mod | 1.0.0 | by 5gi");
                installdir = @"C:\Program Files (x86)\Steam\steamapps\common\Gorilla Tag\BepInEx\plugins\";
                //apps
            }
            //Gorilla Tag Check
        }

        private void installbtn_Click(object sender, EventArgs e)
        {
            foreach(string s in addonlist.CheckedItems)
            {
                installaddon(s);
            }
        }

        private async Task installaddon(string mod)
        {
            //gorillatagmods
            //safemod
            if (mod.Equals("Safe Mod | 1.0.0 | by 5gi"))
            {
                string modname = "SafeModBy5gi";
                using (var client = new WebClient())
                {
                    Directory.CreateDirectory(installdir + modname);
                    client.DownloadFile("https://cdn.discordapp.com/attachments/965422948494245949/972996874246172712/SafeModBy5gi.dll", installdir + modname + @"\" + modname + ".dll");
                }
            }
            //safemod
            //gorillatagmods
        }

        private void viewbtn_Click(object sender, EventArgs e)
        {
            Process.Start(installdir);
        }

        private void setcustomdirbtn_Click(object sender, EventArgs e)
        {
            if (!(customdir.Text == ""))
            {
                installdir = customdir.Text;
                currentdirused.Text = installdir;
            }
        }
    }
}
