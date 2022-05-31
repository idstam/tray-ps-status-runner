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
            this.notifyMenue = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.configToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblStatusFilePath = new System.Windows.Forms.Label();
            this.txtStatusFilePath = new System.Windows.Forms.TextBox();
            this.openStatusFileButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtInfoSignal = new System.Windows.Forms.TextBox();
            this.txtQuestionSignal = new System.Windows.Forms.TextBox();
            this.txtErrorSignal = new System.Windows.Forms.TextBox();
            this.statusSIgnalToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstScriptNames = new System.Windows.Forms.ListBox();
            this.btnSaveSnippet = new System.Windows.Forms.Button();
            this.btnDeleteSnippet = new System.Windows.Forms.Button();
            this.txtScript = new System.Windows.Forms.TextBox();
            this.txtScriptName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.notifyMenue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            // notifyMenue
            // 
            this.notifyMenue.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.configToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.notifyMenue.Name = "notifyMenue";
            this.notifyMenue.Size = new System.Drawing.Size(111, 54);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(107, 6);
            // 
            // configToolStripMenuItem
            // 
            this.configToolStripMenuItem.Name = "configToolStripMenuItem";
            this.configToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.configToolStripMenuItem.Text = "Config";
            this.configToolStripMenuItem.Click += new System.EventHandler(this.configToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // lblStatusFilePath
            // 
            this.lblStatusFilePath.AutoSize = true;
            this.lblStatusFilePath.Location = new System.Drawing.Point(22, 23);
            this.lblStatusFilePath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatusFilePath.Name = "lblStatusFilePath";
            this.lblStatusFilePath.Size = new System.Drawing.Size(68, 16);
            this.lblStatusFilePath.TabIndex = 0;
            this.lblStatusFilePath.Text = "StatusFile:";
            // 
            // txtStatusFilePath
            // 
            this.txtStatusFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStatusFilePath.Location = new System.Drawing.Point(97, 20);
            this.txtStatusFilePath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtStatusFilePath.Name = "txtStatusFilePath";
            this.txtStatusFilePath.Size = new System.Drawing.Size(539, 23);
            this.txtStatusFilePath.TabIndex = 1;
            this.txtStatusFilePath.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // openStatusFileButton
            // 
            this.openStatusFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.openStatusFileButton.Location = new System.Drawing.Point(643, 17);
            this.openStatusFileButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.openStatusFileButton.Name = "openStatusFileButton";
            this.openStatusFileButton.Size = new System.Drawing.Size(88, 28);
            this.openStatusFileButton.TabIndex = 2;
            this.openStatusFileButton.Text = "Browse";
            this.openStatusFileButton.UseVisualStyleBackColor = true;
            this.openStatusFileButton.Click += new System.EventHandler(this.openStatusFileButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TrayPsStatusRunner.Properties.Resources.Custom_Icon_Design_Flatastic_10_File_warning;
            this.pictureBox1.InitialImage = global::TrayPsStatusRunner.Properties.Resources.Custom_Icon_Design_Flatastic_10_File_warning;
            this.pictureBox1.Location = new System.Drawing.Point(2, 34);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 39);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TrayPsStatusRunner.Properties.Resources.Custom_Icon_Design_Flatastic_10_Help_file;
            this.pictureBox2.Location = new System.Drawing.Point(2, 81);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(37, 39);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::TrayPsStatusRunner.Properties.Resources.Custom_Icon_Design_Flatastic_10_File_info;
            this.pictureBox3.Location = new System.Drawing.Point(2, 128);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(37, 39);
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
            this.groupBox1.Location = new System.Drawing.Point(26, 60);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(705, 183);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Status signal in file";
            this.statusSIgnalToolTip.SetToolTip(this.groupBox1, "If the text is found in the status file the tray icon is switched to the correspo" +
        "nding icon. Leave text empty if you don\'t want to use the icon.");
            // 
            // txtInfoSignal
            // 
            this.txtInfoSignal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInfoSignal.Location = new System.Drawing.Point(47, 137);
            this.txtInfoSignal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtInfoSignal.Name = "txtInfoSignal";
            this.txtInfoSignal.Size = new System.Drawing.Size(646, 23);
            this.txtInfoSignal.TabIndex = 8;
            this.txtInfoSignal.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // txtQuestionSignal
            // 
            this.txtQuestionSignal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuestionSignal.Location = new System.Drawing.Point(47, 90);
            this.txtQuestionSignal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtQuestionSignal.Name = "txtQuestionSignal";
            this.txtQuestionSignal.Size = new System.Drawing.Size(646, 23);
            this.txtQuestionSignal.TabIndex = 7;
            this.txtQuestionSignal.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // txtErrorSignal
            // 
            this.txtErrorSignal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtErrorSignal.Location = new System.Drawing.Point(47, 43);
            this.txtErrorSignal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtErrorSignal.Name = "txtErrorSignal";
            this.txtErrorSignal.Size = new System.Drawing.Size(646, 23);
            this.txtErrorSignal.TabIndex = 6;
            this.txtErrorSignal.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lstScriptNames);
            this.groupBox2.Controls.Add(this.btnSaveSnippet);
            this.groupBox2.Controls.Add(this.btnDeleteSnippet);
            this.groupBox2.Controls.Add(this.txtScript);
            this.groupBox2.Controls.Add(this.txtScriptName);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(26, 251);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.MinimumSize = new System.Drawing.Size(0, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(705, 320);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Scripts";
            // 
            // lstScriptNames
            // 
            this.lstScriptNames.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstScriptNames.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstScriptNames.FormattingEnabled = true;
            this.lstScriptNames.IntegralHeight = false;
            this.lstScriptNames.ItemHeight = 18;
            this.lstScriptNames.Location = new System.Drawing.Point(511, 89);
            this.lstScriptNames.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstScriptNames.Name = "lstScriptNames";
            this.lstScriptNames.Size = new System.Drawing.Size(181, 222);
            this.lstScriptNames.TabIndex = 7;
            this.lstScriptNames.SelectedIndexChanged += new System.EventHandler(this.lstScriptNames_SelectedIndexChanged);
            // 
            // btnSaveSnippet
            // 
            this.btnSaveSnippet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveSnippet.Location = new System.Drawing.Point(511, 31);
            this.btnSaveSnippet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSaveSnippet.Name = "btnSaveSnippet";
            this.btnSaveSnippet.Size = new System.Drawing.Size(88, 28);
            this.btnSaveSnippet.TabIndex = 6;
            this.btnSaveSnippet.Text = "Save";
            this.btnSaveSnippet.UseVisualStyleBackColor = true;
            this.btnSaveSnippet.Click += new System.EventHandler(this.btnSaveSnippet_Click);
            // 
            // btnDeleteSnippet
            // 
            this.btnDeleteSnippet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteSnippet.Location = new System.Drawing.Point(606, 31);
            this.btnDeleteSnippet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeleteSnippet.Name = "btnDeleteSnippet";
            this.btnDeleteSnippet.Size = new System.Drawing.Size(88, 28);
            this.btnDeleteSnippet.TabIndex = 5;
            this.btnDeleteSnippet.Text = "Delete";
            this.btnDeleteSnippet.UseVisualStyleBackColor = true;
            // 
            // txtScript
            // 
            this.txtScript.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtScript.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScript.Location = new System.Drawing.Point(58, 65);
            this.txtScript.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtScript.MinimumSize = new System.Drawing.Size(4, 24);
            this.txtScript.Multiline = true;
            this.txtScript.Name = "txtScript";
            this.txtScript.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtScript.Size = new System.Drawing.Size(446, 246);
            this.txtScript.TabIndex = 4;
            // 
            // txtScriptName
            // 
            this.txtScriptName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtScriptName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScriptName.Location = new System.Drawing.Point(58, 33);
            this.txtScriptName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtScriptName.Name = "txtScriptName";
            this.txtScriptName.Size = new System.Drawing.Size(446, 23);
            this.txtScriptName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            this.fileSystemWatcher1.Changed += new System.IO.FileSystemEventHandler(this.fileSystemWatcher1_Changed);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(514, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Available scripts";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 69);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Code:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 586);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.openStatusFileButton);
            this.Controls.Add(this.txtStatusFilePath);
            this.Controls.Add(this.lblStatusFilePath);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(347, 625);
            this.Name = "Form1";
            this.Text = "Config";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.notifyMenue.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.ContextMenuStrip notifyMenue;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtScript;
        private System.Windows.Forms.TextBox txtScriptName;
        private System.Windows.Forms.Label label1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button btnSaveSnippet;
        private System.Windows.Forms.Button btnDeleteSnippet;
        private System.Windows.Forms.ListBox lstScriptNames;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem configToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

