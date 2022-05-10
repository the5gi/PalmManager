using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
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
            //setver
            vertext.Text = "Palm Manager v" + Startup.ver;
            //setver
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
                addonlist.Items.Add("BepInEx | 5.4.19 | by The BepInEx Team");
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
            if (Directory.Exists(installdir)) {
                //gorillatagmods
                //bepinex
                if (mod.Equals("BepInEx | 5.4.19 | by The BepInEx Team"))
                {
                    bepinex();
                }
                //bepinex
                //safemod
                if (mod.Equals("Safe Mod | 1.0.0 | by 5gi"))
                {
                    bepinex();
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
        }

        private void viewbtn_Click(object sender, EventArgs e)
        {
            Process.Start(installdir);
        }

        private void setcustomdirbtn_Click(object sender, EventArgs e)
        {
            if (!(customdir.Text == ""))
            {
                if (!customdir.Text.Contains(@"\BepInEx\plugins\"))
                {
                    installdir = customdir.Text + @"BepInEx\plugins\";
                    currentdirused.Text = installdir;

                } else {
                    installdir = customdir.Text;
                    currentdirused.Text = installdir;
                }
            }
        }

        private void sourcebtn_Click(object sender, EventArgs e)
        {
            if (applist.SelectedItem.Equals("Gorilla Tag"))
            {
                if (addonlist.SelectedIndex.Equals(0))
                {
                    System.Diagnostics.Process.Start("https://discord.gg/VDUXcvb8XM");
                }
            }
        }

        private void diropen_Click(object sender, EventArgs e)
        {
            if (applist.SelectedIndex == -1)
            {

            } else
            if (applist.SelectedItem.Equals("Gorilla Tag"))
            {
                if (dirshow.ShowDialog() == DialogResult.OK)
                {
                    customdir.Text = dirshow.FileName.Replace("Gorilla Tag.exe", @"BepInEx\plugins");
                }
            }
        }
        private async Task bepinex()
        {
            if (!Directory.Exists(installdir))
            {
                string install2 = installdir.Replace(@"\BepInEx\plugins\",@"\");
                using (var client = new WebClient())
                {
                    client.DownloadFile("https://github.com/BepInEx/BepInEx/releases/download/v5.4.19/BepInEx_x64_5.4.19.0.zip", Startup.tempdir + "bepinex.zip");
                }
                ZipFile.ExtractToDirectory(Startup.tempdir + "bepinex.zip", install2);
            }
        }
    }
}
