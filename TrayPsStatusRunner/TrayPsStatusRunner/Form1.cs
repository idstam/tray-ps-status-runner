using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrayPsStatusRunner
{
    public partial class Form1 : Form
    {
        private bool _closedFromTray = false;
        private Icon _errorIcon;
        private Icon _questionIcon;
        private Icon _infoIcon;
        private Icon _okIcon;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.BalloonTipTitle = "Notify Icon Test Application";
            notifyIcon1.BalloonTipText = "You have just minimized the application." +
                                        Environment.NewLine +
                                        "Right-click on the icon for more options.";

            notifyIcon1.ShowBalloonTip(5000);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_closedFromTray)
            {
                this.ShowInTaskbar = false;
                this.WindowState = FormWindowState.Minimized;
                e.Cancel = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var bmp = Properties.Resources.Custom_Icon_Design_Flatastic_10_Delete_file;
            bmp.MakeTransparent();
            System.IntPtr icH = bmp.GetHicon();
            _errorIcon = Icon.FromHandle(icH);

            bmp = Properties.Resources.Custom_Icon_Design_Flatastic_10_Help_file;
            bmp.MakeTransparent();
            icH = bmp.GetHicon();
            _questionIcon = Icon.FromHandle(icH);

            bmp = Properties.Resources.Custom_Icon_Design_Flatastic_10_File_info;
            bmp.MakeTransparent();
            icH = bmp.GetHicon();
            _infoIcon = Icon.FromHandle(icH);

            bmp = Properties.Resources.Custom_Icon_Design_Flatastic_10_File_complete;
            bmp.MakeTransparent();
            icH = bmp.GetHicon();
            _okIcon = Icon.FromHandle(icH);

            notifyIcon1.Icon = _okIcon;
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _closedFromTray = true;
            this.Close();
        }

        private void saveConfigButton_Click(object sender, EventArgs e)
        {
            if (File.Exists(txtStatusFilePath.Text))
            {
                var f = new FileInfo(txtStatusFilePath.Text);
                fileSystemWatcher1.Path = f.DirectoryName;
                fileSystemWatcher1.Filter = f.Name;
                fileSystemWatcher1.EnableRaisingEvents = true;
            }
        }

        private void fileSystemWatcher1_Changed(object sender, FileSystemEventArgs e)
        {
            fileSystemWatcher1.EnableRaisingEvents = false;
            notifyIcon1.Icon = _okIcon;
            var content = "";
            for (int i = 0; i < 10; i++)
            {
                try
                {
                    content = File.ReadAllText(txtStatusFilePath.Text);
                    break;
                }
                catch
                {
                    Thread.Sleep(500);
                }
            }

            if (content.Contains(txtInfoSignal.Text))
            {
                notifyIcon1.Icon = _infoIcon;
            }
            if (content.Contains(txtQuestionSignal.Text))
            {
                notifyIcon1.Icon = _questionIcon;
            }
            if (content.Contains(txtErrorSignal.Text))
            {
                notifyIcon1.Icon = _errorIcon;
            }

            
            fileSystemWatcher1.EnableRaisingEvents = true;
        }

        private void openStatusFileButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.Multiselect = false;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtStatusFilePath.Text = openFileDialog1.FileName;
            }
            
        }
    }
}
