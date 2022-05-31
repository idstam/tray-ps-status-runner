using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
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
        private ConfigData _config;
        private string _lastResult;

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
                saveConfig();
                this.ShowInTaskbar = false;
                this.WindowState = FormWindowState.Minimized;
                e.Cancel = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadConfig();

            var bmp = Properties.Resources.error;
            bmp.MakeTransparent();
            System.IntPtr icH = bmp.GetHicon();
            _errorIcon = Icon.FromHandle(icH);

            bmp = Properties.Resources.warning;
            bmp.MakeTransparent();
            icH = bmp.GetHicon();
            _questionIcon = Icon.FromHandle(icH);

            bmp = Properties.Resources.info;
            bmp.MakeTransparent();
            icH = bmp.GetHicon();
            _infoIcon = Icon.FromHandle(icH);

            bmp = Properties.Resources.ok;
            bmp.MakeTransparent();
            icH = bmp.GetHicon();
            _okIcon = Icon.FromHandle(icH);

            notifyIcon1.Icon = _okIcon;

            reloadTriggersAndMenue();
            if (cboTrigger.Text == "File")
            {
                fileSystemWatcher1_Changed(null, null);
            }
        }

        private void loadConfig()
        {
            var fp = Assembly.GetEntryAssembly().Location;
            var p = new FileInfo(fp).DirectoryName;

            var configFile = Path.Combine(p, "config.json");
            if (File.Exists(configFile))
            {
                _config = JsonConvert.DeserializeObject<ConfigData>(File.ReadAllText(configFile));
                if(_config.Scripts is null)
                {
                    _config.Scripts = new Dictionary<string, string>();
                }

                var cboIndex = cboTrigger.FindString(_config.TriggerType);

                cboTrigger.SelectedIndex = cboIndex > -1 ? cboIndex : 0;

                txtStatusFilePath.Text = _config.TriggerCommand;
                txtErrorSignal.Text = _config.ErrorTrigger;
                txtQuestionSignal.Text = _config.WarningTrigger;
                txtInfoSignal.Text = _config.InfoTrigger;
                udCommandInterval.Value = _config.TriggerInterval;

                foreach (var scriptName in _config.Scripts.Keys)
                {
                    lstScriptNames.Items.Add(scriptName);
                }
                reloadTriggersAndMenue();
            }
            else
            {
                _config = new ConfigData();
                _config.Scripts = new Dictionary<string, string>();
                saveConfig();
            }
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
            saveConfig();            
        }

        private void saveConfig()
        {
            _config.TriggerCommand = txtStatusFilePath.Text;
            _config.TriggerType = cboTrigger.Text;
            _config.ErrorTrigger = txtErrorSignal.Text;
            _config.InfoTrigger = txtQuestionSignal.Text;
            _config.WarningTrigger = txtInfoSignal.Text;
            _config.TriggerInterval = Decimal.ToInt32(udCommandInterval.Value);

            var json = JsonConvert.SerializeObject(_config);
            var fp = Assembly.GetEntryAssembly().Location;
            var p = new FileInfo(fp).DirectoryName;

            var configFile = Path.Combine(p, "config.json");
            File.WriteAllText(configFile, json);
            reloadTriggersAndMenue();

        }
        private void reloadTriggersAndMenue()
        {
            if (cboTrigger.Text == "File" && File.Exists(txtStatusFilePath.Text))
            {
                var f = new FileInfo(txtStatusFilePath.Text);
                fileSystemWatcher1.Path = f.DirectoryName;
                fileSystemWatcher1.Filter = f.Name;
                fileSystemWatcher1.EnableRaisingEvents = true;
            }
            if (cboTrigger.Text != "File" && !string.IsNullOrWhiteSpace(txtStatusFilePath.Text))
            {
                if(udCommandInterval.Value == 0)
                {
                    udCommandInterval.Value = 1;
                }

                timer1.Interval = Decimal.ToInt32(udCommandInterval.Value * 1000 * 60);
                timer1.Enabled = true;
            }


            for (int i = notifyMenue.Items.Count - 1; i >= 0; i--)
            {
                var m = notifyMenue.Items[i];
                if (m.Tag != null && m.Tag.ToString() == "Dynamic")
                {
                    notifyMenue.Items.RemoveAt(i);
                }
            }

            var mIndex = 0;
            foreach (var scriptName in _config.Scripts.Keys)
            {
                var m = new ToolStripButton(scriptName);
                m.Tag = "Dynamic";
                m.Click += M_Click;
                notifyMenue.Items.Insert(mIndex, m);
                mIndex++;
            }
        }

        private void M_Click(object sender, EventArgs e)
        {
            var m = sender as ToolStripButton;
            if (m != null)
            {
                var start = new ProcessStartInfo
                {
                    FileName = "powershell.exe",
                    UseShellExecute = true,
                    RedirectStandardOutput = false,
                    Arguments ="-NoExit -Command " + _config.Scripts[m.Text],
                    CreateNoWindow = false
                };


                var process = Process.Start(start);

            }
        }

        private void fileSystemWatcher1_Changed(object sender, FileSystemEventArgs e)
        {
            fileSystemWatcher1.EnableRaisingEvents = false;

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
            checkContent(content);

            if (File.Exists(txtStatusFilePath.Text))
            {
                fileSystemWatcher1.EnableRaisingEvents = true;
            }

        }

        private void checkContent(string content)
        {
            _lastResult = content;
            notifyIcon1.Icon = _okIcon;

            var trigger = "";
            if (!string.IsNullOrWhiteSpace(txtInfoSignal.Text) && content.Contains(txtInfoSignal.Text))
            {
                trigger = txtInfoSignal.Text;
                notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                notifyIcon1.Icon = _infoIcon;
            }
            if (!string.IsNullOrWhiteSpace(txtQuestionSignal.Text) && content.Contains(txtQuestionSignal.Text))
            {
                trigger = txtQuestionSignal.Text;
                notifyIcon1.BalloonTipIcon = ToolTipIcon.Warning;
                notifyIcon1.Icon = _questionIcon;
            }
            if (!string.IsNullOrWhiteSpace(txtErrorSignal.Text) && content.Contains(txtErrorSignal.Text))
            {
                trigger = txtErrorSignal.Text;
                notifyIcon1.BalloonTipIcon = ToolTipIcon.Error;
                notifyIcon1.Icon = _errorIcon;
            }
            if (!string.IsNullOrEmpty(trigger))
            {
                notifyIcon1.BalloonTipText = "Found [ " + trigger + " ] in status file.";
                notifyIcon1.ShowBalloonTip(5000);
            }

        }
        private void openStatusFileButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.Multiselect = false;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtStatusFilePath.Text = openFileDialog1.FileName;
                saveConfig();
            }

        }

        private void btnSaveSnippet_Click(object sender, EventArgs e)
        {
            _config.Scripts[txtScriptName.Text] = txtScript.Text;
            if (!lstScriptNames.Items.Contains(txtScriptName.Text))
            {
                lstScriptNames.Items.Add(txtScriptName.Text);
            }
            reloadTriggersAndMenue();
        }

        private void lstScriptNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstScriptNames.SelectedIndex == -1)
            {
                txtScript.Text = "";
                txtScriptName.Text = "";
            }
            else
            {

                txtScriptName.Text = lstScriptNames.SelectedItem.ToString();
                txtScript.Text = _config.Scripts[txtScriptName.Text];
            }
        }

        private void configToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;

        }

        private void txt_Leave(object sender, EventArgs e)
        {
            saveConfig();
        }

        private void cboTrigger_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cboTrigger_TextChanged(object sender, EventArgs e)
        {
            if(cboTrigger.Text == "File")
            {
                udCommandInterval.Visible = false;
                lblMinutes.Visible = false; 
                openStatusFileButton.Visible = true;
            } else
            {
                lblMinutes.Visible = true;
                udCommandInterval.Visible = true;
                openStatusFileButton.Visible = false;

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            if (cboTrigger.Text == "Powershell")
            {
                var start = new ProcessStartInfo
                {
                    FileName = "powershell.exe",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    Arguments = "-Command " + txtStatusFilePath.Text,
                    CreateNoWindow = true
                };


                using (var process = Process.Start(start))
                {
                    process.WaitForExit();
                    var content = process.StandardOutput.ReadToEnd();
                    checkContent(content);
                }
            }
            else
            {
                var start = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    Arguments = "/C " + txtStatusFilePath.Text,
                    CreateNoWindow = true
                };


                using (var process = Process.Start(start))
                {
                    process.WaitForExit();
                    var content = process.StandardOutput.ReadToEnd();
                    checkContent(content);
                }

            }
            timer1.Enabled = true;
        }

        private void btnDeleteSnippet_Click(object sender, EventArgs e)
        {
            _config.Scripts.Remove(txtScriptName.Text);
            lstScriptNames.Items.RemoveAt(lstScriptNames.FindString(txtScriptName.Text));
            reloadTriggersAndMenue();

        }

        private void lastResultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_lastResult, "Last status/result. CTRL + C to copy all of it");
        }

        private void checkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(cboTrigger.Text == "File")
            {
                fileSystemWatcher1_Changed(null, null);
            } else
            {
                timer1_Tick(null, null);
            }
        }
    }
}
