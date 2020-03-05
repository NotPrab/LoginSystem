using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Net;
using System.Windows.Forms;

namespace FreeandPremium
{
    public partial class MainForm : Form
    {
        string hwid;
        bool premium = false;
        public MainForm()
        {
            InitializeComponent();
        }

        private static string GetHWID()
        {
            bool is64BitOperatingSystem = Environment.Is64BitOperatingSystem;
            bool flag = is64BitOperatingSystem;
            RegistryKey registryKey;
            if (flag)
            {
                registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
            }
            else
            {
                registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32);
            }
            return registryKey.OpenSubKey("Software\\Microsoft\\Windows NT\\CurrentVersion").GetValue("ProductId").ToString();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            hwid = MainForm.GetHWID();
            WebClient loginshit = new WebClient();
            string hwidshit = loginshit.DownloadString("https://pastebin.com/raw/wX50fHzk");
            if (hwidshit.Contains(hwid))
            {
                premium = true;
            }
        }

        private void ggb_Click(object sender, EventArgs e)
        {
            // Free and Premium
            Process.Start("https://www.google.com/");   
        }

        private void fbb_Click(object sender, EventArgs e)
        {
            // Free and Premium
            Process.Start("https://www.facebook.com/");            
        }

        private void wab_Click(object sender, EventArgs e)
        {
            // Free and Premium
            Process.Start("https://www.whatsapp.com/");            
        }

        private void twb_Click(object sender, EventArgs e)
        {
            // Premium
            if (premium == true)
            {
                Process.Start("https://twitter.com/");
            }
            else
            {
                MessageBox.Show("You're not Premium !");
            }
        }

        private void ytb_Click(object sender, EventArgs e)
        {
            // Premium
            if (premium == true)
            {
                Process.Start("https://www.youtube.com/");
            }
            else
            {
                MessageBox.Show("You're not Premium !");
            }
        }

        private void igb_Click(object sender, EventArgs e)
        {
            // Premium
            if (premium == true)
            {
                Process.Start("https://www.instagram.com/");
            }
            else
            {
                MessageBox.Show("You're not Premium !");
            }
        }
    }
}
