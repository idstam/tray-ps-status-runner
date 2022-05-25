namespace TrayPsStatusRunner
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.lblStatusFilePath = new System.Windows.Forms.Label();
            this.txtStatusFilePath = new System.Windows.Forms.TextBox();
            this.openStatusFileButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtErrorSignal = new System.Windows.Forms.TextBox();
            this.txtQuestionSignal = new System.Windows.Forms.TextBox();
            this.txtInfoSignal = new System.Windows.Forms.TextBox();
            this.statusSIgnalToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.saveConfigButton = new System.Windows.Forms.Button();
            this.notifyMenue = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.snippetNameTextBox = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.notifyMenue.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Error;
            this.notifyIcon1.BalloonTipText = "asdfasdfadsf";
            this.notifyIcon1.ContextMenuStrip = this.notifyMenue;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // lblStatusFilePath
            // 
            this.lblStatusFilePath.AutoSize = true;
            this.lblStatusFilePath.Location = new System.Drawing.Point(19, 19);
            this.lblStatusFilePath.Name = "lblStatusFilePath";
            this.lblStatusFilePath.Size = new System.Drawing.Size(56, 13);
            this.lblStatusFilePath.TabIndex = 0;
            this.lblStatusFilePath.Text = "StatusFile:";
            // 
            // txtStatusFilePath
            // 
            this.txtStatusFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStatusFilePath.Location = new System.Drawing.Point(83, 16);
            this.txtStatusFilePath.Name = "txtStatusFilePath";
            this.txtStatusFilePath.Size = new System.Drawing.Size(795, 20);
            this.txtStatusFilePath.TabIndex = 1;
            // 
            // openStatusFileButton
            // 
            this.openStatusFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.openStatusFileButton.Location = new System.Drawing.Point(884, 14);
            this.openStatusFileButton.Name = "openStatusFileButton";
            this.openStatusFileButton.Size = new System.Drawing.Size(75, 23);
            this.openStatusFileButton.TabIndex = 2;
            this.openStatusFileButton.Text = "Browse";
            this.openStatusFileButton.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TrayPsStatusRunner.Properties.Resources.Custom_Icon_Design_Flatastic_10_File_warning;
            this.pictureBox1.InitialImage = global::TrayPsStatusRunner.Properties.Resources.Custom_Icon_Design_Flatastic_10_File_warning;
            this.pictureBox1.Location = new System.Drawing.Point(2, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TrayPsStatusRunner.Properties.Resources.Custom_Icon_Design_Flatastic_10_Help_file;
            this.pictureBox2.Location = new System.Drawing.Point(2, 66);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::TrayPsStatusRunner.Properties.Resources.Custom_Icon_Design_Flatastic_10_File_info;
            this.pictureBox3.Location = new System.Drawing.Point(2, 104);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtInfoSignal);
            this.groupBox1.Controls.Add(this.txtQuestionSignal);
            this.groupBox1.Controls.Add(this.txtErrorSignal);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(22, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(937, 149);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Status signal in file";
            this.statusSIgnalToolTip.SetToolTip(this.groupBox1, "If the text is found in the status file the tray icon is switched to the correspo" +
        "nding icon. Leave text empty if you don\'t want to use the icon.");
            // 
            // txtErrorSignal
            // 
            this.txtErrorSignal.Location = new System.Drawing.Point(40, 35);
            this.txtErrorSignal.Name = "txtErrorSignal";
            this.txtErrorSignal.Size = new System.Drawing.Size(597, 20);
            this.txtErrorSignal.TabIndex = 6;
            // 
            // txtQuestionSignal
            // 
            this.txtQuestionSignal.Location = new System.Drawing.Point(40, 73);
            this.txtQuestionSignal.Name = "txtQuestionSignal";
            this.txtQuestionSignal.Size = new System.Drawing.Size(597, 20);
            this.txtQuestionSignal.TabIndex = 7;
            // 
            // txtInfoSignal
            // 
            this.txtInfoSignal.Location = new System.Drawing.Point(40, 111);
            this.txtInfoSignal.Name = "txtInfoSignal";
            this.txtInfoSignal.Size = new System.Drawing.Size(597, 20);
            this.txtInfoSignal.TabIndex = 8;
            // 
            // saveConfigButton
            // 
            this.saveConfigButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveConfigButton.Location = new System.Drawing.Point(849, 536);
            this.saveConfigButton.Name = "saveConfigButton";
            this.saveConfigButton.Size = new System.Drawing.Size(110, 23);
            this.saveConfigButton.TabIndex = 7;
            this.saveConfigButton.Text = "&Save";
            this.saveConfigButton.UseVisualStyleBackColor = true;
            this.saveConfigButton.Click += new System.EventHandler(this.saveConfigButton_Click);
            // 
            // notifyMenue
            // 
            this.notifyMenue.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.notifyMenue.Name = "notifyMenue";
            this.notifyMenue.Size = new System.Drawing.Size(94, 26);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.snippetNameTextBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(22, 204);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(937, 326);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Snippets";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // snippetNameTextBox
            // 
            this.snippetNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.snippetNameTextBox.Location = new System.Drawing.Point(62, 27);
            this.snippetNameTextBox.Name = "snippetNameTextBox";
            this.snippetNameTextBox.Size = new System.Drawing.Size(865, 20);
            this.snippetNameTextBox.TabIndex = 1;
            // 
            // textBox4
            // 
            this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox4.Location = new System.Drawing.Point(21, 53);
            this.textBox4.MinimumSize = new System.Drawing.Size(0, 25);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox4.Size = new System.Drawing.Size(906, 86);
            this.textBox4.TabIndex = 4;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            this.fileSystemWatcher1.Changed += new System.IO.FileSystemEventHandler(this.fileSystemWatcher1_Changed);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 571);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.saveConfigButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.openStatusFileButton);
            this.Controls.Add(this.txtStatusFilePath);
            this.Controls.Add(this.lblStatusFilePath);
            this.Name = "Form1";
            this.Text = "Config";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.notifyMenue.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label lblStatusFilePath;
        private System.Windows.Forms.TextBox txtStatusFilePath;
        private System.Windows.Forms.Button openStatusFileButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtInfoSignal;
        private System.Windows.Forms.TextBox txtQuestionSignal;
        private System.Windows.Forms.TextBox txtErrorSignal;
        private System.Windows.Forms.ToolTip statusSIgnalToolTip;
        private System.Windows.Forms.Button saveConfigButton;
        private System.Windows.Forms.ContextMenuStrip notifyMenue;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox snippetNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}

