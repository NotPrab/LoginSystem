using Microsoft.Win32;
using System;
using System.Net;
using System.Windows.Forms;

namespace FreeandPremium
{
    public partial class LoginForm : Form
    {
        string hwid;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void FreeLoginBtn_Click(object sender, EventArgs e)
        {
            WebClient loginshit = new WebClient();
            string hwidshit = loginshit.DownloadString("https://pastebin.com/raw/wX50fHzk"); // Edit and change to your pastebin
            if (hwidshit.Contains(hwid))
            {
                MessageBox.Show("You have premium version! Go use it!", "github.com/NotPrab");
            }
            else
            {
                MainForm main = new MainForm();
                this.Hide();
                main.Show();
            }
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

        private void LoginForm_Load(object sender, EventArgs e)
        {
            hwidtextbox.Text = GetHWID().ToString();
            hwid = LoginForm.GetHWID();
        }

        private void PremiumLoginBtn_Click(object sender, EventArgs e)
        {
            WebClient loginshit = new WebClient();
            string hwidshit = loginshit.DownloadString("https://pastebin.com/raw/wX50fHzk"); // Edit and change to your pastebin
            if (hwidshit.Contains(hwid))
            {
                MainForm main = new MainForm();
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("You don't have premium version!", "github.com/NotPrab");
            }
        }
    }
}
