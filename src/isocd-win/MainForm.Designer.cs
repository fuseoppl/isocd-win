namespace isocd_win {
    partial class ISOCDWin {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ISOCDWin));
            this.srcTextBox = new System.Windows.Forms.TextBox();
            this.startBuildButton = new System.Windows.Forms.Button();
            this.inputFolderLabel = new System.Windows.Forms.Label();
            this.imgTextBox = new System.Windows.Forms.TextBox();
            this.outputFileLabel = new System.Windows.Forms.Label();
            this.authorLabel = new System.Windows.Forms.Label();
            this.srcBrowseButton = new System.Windows.Forms.Button();
            this.imgBrowseButton = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.optionsButton = new System.Windows.Forms.Button();
            this.targetSystemPictureBox = new System.Windows.Forms.PictureBox();
            this.targetSystemComboBox = new System.Windows.Forms.ComboBox();
            this.useTmFileCheckBox = new System.Windows.Forms.CheckBox();
            this.targetSystemGroupBox = new System.Windows.Forms.Panel();
            this.targetSystemSettingsLabel = new System.Windows.Forms.Label();
            this.buildStatusGroupBox = new System.Windows.Forms.Panel();
            this.buildStatusLabel = new System.Windows.Forms.Label();
            this.progressBar = new isocd_win.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.targetSystemPictureBox)).BeginInit();
            this.targetSystemGroupBox.SuspendLayout();
            this.buildStatusGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.progressBar)).BeginInit();
            this.SuspendLayout();
            // 
            // srcTextBox
            // 
            this.srcTextBox.Location = new System.Drawing.Point(89, 20);
            this.srcTextBox.Name = "srcTextBox";
            this.srcTextBox.Size = new System.Drawing.Size(355, 20);
            this.srcTextBox.TabIndex = 2;
            this.srcTextBox.TextChanged += new System.EventHandler(this.srcTextBox_TextChanged);
            // 
            // startBuildButton
            // 
            this.startBuildButton.Location = new System.Drawing.Point(214, 213);
            this.startBuildButton.Name = "startBuildButton";
            this.startBuildButton.Size = new System.Drawing.Size(131, 22);
            this.startBuildButton.TabIndex = 11;
            this.startBuildButton.Text = "Start Build";
            this.startBuildButton.UseVisualStyleBackColor = true;
            this.startBuildButton.Click += new System.EventHandler(this.StartBuildButton_Click);
            // 
            // inputFolderLabel
            // 
            this.inputFolderLabel.AutoSize = true;
            this.inputFolderLabel.Location = new System.Drawing.Point(23, 23);
            this.inputFolderLabel.Name = "inputFolderLabel";
            this.inputFolderLabel.Size = new System.Drawing.Size(63, 13);
            this.inputFolderLabel.TabIndex = 1;
            this.inputFolderLabel.Text = "Input Folder";
            // 
            // imgTextBox
            // 
            this.imgTextBox.Location = new System.Drawing.Point(89, 55);
            this.imgTextBox.Name = "imgTextBox";
            this.imgTextBox.Size = new System.Drawing.Size(355, 20);
            this.imgTextBox.TabIndex = 5;
            this.imgTextBox.TextChanged += new System.EventHandler(this.imgTextBox_TextChanged);
            // 
            // outputFileLabel
            // 
            this.outputFileLabel.AutoSize = true;
            this.outputFileLabel.Location = new System.Drawing.Point(28, 58);
            this.outputFileLabel.Name = "outputFileLabel";
            this.outputFileLabel.Size = new System.Drawing.Size(58, 13);
            this.outputFileLabel.TabIndex = 4;
            this.outputFileLabel.Text = "Output File";
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Location = new System.Drawing.Point(427, 358);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(107, 13);
            this.authorLabel.TabIndex = 16;
            this.authorLabel.Text = "«Ben Squibb - 2020»";
            // 
            // srcBrowseButton
            // 
            this.srcBrowseButton.Location = new System.Drawing.Point(450, 18);
            this.srcBrowseButton.Name = "srcBrowseButton";
            this.srcBrowseButton.Size = new System.Drawing.Size(75, 23);
            this.srcBrowseButton.TabIndex = 3;
            this.srcBrowseButton.Text = "Browse";
            this.srcBrowseButton.UseVisualStyleBackColor = true;
            this.srcBrowseButton.Click += new System.EventHandler(this.SrcBrowseButton_Click);
            // 
            // imgBrowseButton
            // 
            this.imgBrowseButton.Location = new System.Drawing.Point(450, 53);
            this.imgBrowseButton.Name = "imgBrowseButton";
            this.imgBrowseButton.Size = new System.Drawing.Size(75, 23);
            this.imgBrowseButton.TabIndex = 6;
            this.imgBrowseButton.Text = "Browse";
            this.imgBrowseButton.UseVisualStyleBackColor = true;
            this.imgBrowseButton.Click += new System.EventHandler(this.ImgBrowseButton_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.BackColor = System.Drawing.SystemColors.Window;
            this.statusLabel.ForeColor = System.Drawing.Color.Blue;
            this.statusLabel.Location = new System.Drawing.Point(14, 9);
            this.statusLabel.MinimumSize = new System.Drawing.Size(330, 4);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(472, 25);
            this.statusLabel.TabIndex = 14;
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // optionsButton
            // 
            this.optionsButton.Location = new System.Drawing.Point(19, 353);
            this.optionsButton.Name = "optionsButton";
            this.optionsButton.Size = new System.Drawing.Size(75, 22);
            this.optionsButton.TabIndex = 15;
            this.optionsButton.Text = "Options";
            this.optionsButton.UseVisualStyleBackColor = true;
            this.optionsButton.Click += new System.EventHandler(this.OptionsButton_Click);
            // 
            // targetSystemPictureBox
            // 
            this.targetSystemPictureBox.Location = new System.Drawing.Point(174, 28);
            this.targetSystemPictureBox.Name = "targetSystemPictureBox";
            this.targetSystemPictureBox.Size = new System.Drawing.Size(131, 54);
            this.targetSystemPictureBox.TabIndex = 15;
            this.targetSystemPictureBox.TabStop = false;
            // 
            // targetSystemComboBox
            // 
            this.targetSystemComboBox.FormattingEnabled = true;
            this.targetSystemComboBox.Location = new System.Drawing.Point(74, 61);
            this.targetSystemComboBox.Name = "targetSystemComboBox";
            this.targetSystemComboBox.Size = new System.Drawing.Size(77, 21);
            this.targetSystemComboBox.TabIndex = 10;
            this.targetSystemComboBox.SelectedIndexChanged += new System.EventHandler(this.targetSystemComboBox_SelectedIndexChanged);
            // 
            // useTmFileCheckBox
            // 
            this.useTmFileCheckBox.AutoSize = true;
            this.useTmFileCheckBox.Location = new System.Drawing.Point(74, 28);
            this.useTmFileCheckBox.Name = "useTmFileCheckBox";
            this.useTmFileCheckBox.Size = new System.Drawing.Size(77, 17);
            this.useTmFileCheckBox.TabIndex = 9;
            this.useTmFileCheckBox.Text = "Trademark";
            this.useTmFileCheckBox.UseVisualStyleBackColor = true;
            this.useTmFileCheckBox.CheckedChanged += new System.EventHandler(this.useTmFileCheckBox_CheckedChanged);
            // 
            // targetSystemGroupBox
            // 
            this.targetSystemGroupBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.targetSystemGroupBox.Controls.Add(this.targetSystemPictureBox);
            this.targetSystemGroupBox.Controls.Add(this.useTmFileCheckBox);
            this.targetSystemGroupBox.Controls.Add(this.targetSystemComboBox);
            this.targetSystemGroupBox.Location = new System.Drawing.Point(89, 94);
            this.targetSystemGroupBox.Name = "targetSystemGroupBox";
            this.targetSystemGroupBox.Size = new System.Drawing.Size(355, 100);
            this.targetSystemGroupBox.TabIndex = 8;
            // 
            // targetSystemSettingsLabel
            // 
            this.targetSystemSettingsLabel.AutoSize = true;
            this.targetSystemSettingsLabel.Location = new System.Drawing.Point(202, 88);
            this.targetSystemSettingsLabel.Name = "targetSystemSettingsLabel";
            this.targetSystemSettingsLabel.Size = new System.Drawing.Size(128, 13);
            this.targetSystemSettingsLabel.TabIndex = 7;
            this.targetSystemSettingsLabel.Text = "[ Target System Settings ]";
            // 
            // buildStatusGroupBox
            // 
            this.buildStatusGroupBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.buildStatusGroupBox.Controls.Add(this.statusLabel);
            this.buildStatusGroupBox.Location = new System.Drawing.Point(31, 298);
            this.buildStatusGroupBox.Name = "buildStatusGroupBox";
            this.buildStatusGroupBox.Size = new System.Drawing.Size(494, 43);
            this.buildStatusGroupBox.TabIndex = 13;
            // 
            // buildStatusLabel
            // 
            this.buildStatusLabel.AutoSize = true;
            this.buildStatusLabel.Location = new System.Drawing.Point(242, 291);
            this.buildStatusLabel.Name = "buildStatusLabel";
            this.buildStatusLabel.Size = new System.Drawing.Size(75, 13);
            this.buildStatusLabel.TabIndex = 12;
            this.buildStatusLabel.Text = "[ Build Status ]";
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.progressBar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.progressBar.Cursor = System.Windows.Forms.Cursors.Default;
            this.progressBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressBar.ForeColor = System.Drawing.Color.LightGreen;
            this.progressBar.Location = new System.Drawing.Point(64, 244);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(431, 29);
            this.progressBar.TabIndex = 8;
            this.progressBar.TabStop = false;
            this.progressBar.Value = 50;
            // 
            // ISOCDWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 389);
            this.Controls.Add(this.buildStatusLabel);
            this.Controls.Add(this.targetSystemSettingsLabel);
            this.Controls.Add(this.buildStatusGroupBox);
            this.Controls.Add(this.targetSystemGroupBox);
            this.Controls.Add(this.optionsButton);
            this.Controls.Add(this.srcTextBox);
            this.Controls.Add(this.startBuildButton);
            this.Controls.Add(this.imgBrowseButton);
            this.Controls.Add(this.inputFolderLabel);
            this.Controls.Add(this.srcBrowseButton);
            this.Controls.Add(this.imgTextBox);
            this.Controls.Add(this.authorLabel);
            this.Controls.Add(this.outputFileLabel);
            this.Controls.Add(this.progressBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ISOCDWin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ISOCD-Win";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ISOCDWin_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ISOCDWin_FormClosed);
            this.Shown += new System.EventHandler(this.ISOCDWin_Shown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ISOCDWin_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.targetSystemPictureBox)).EndInit();
            this.targetSystemGroupBox.ResumeLayout(false);
            this.targetSystemGroupBox.PerformLayout();
            this.buildStatusGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.progressBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        System.Windows.Forms.TextBox srcTextBox;
        System.Windows.Forms.Button startBuildButton;
        System.Windows.Forms.Label inputFolderLabel;
        System.Windows.Forms.TextBox imgTextBox;
        System.Windows.Forms.Label outputFileLabel;
        System.Windows.Forms.Label authorLabel;
        System.Windows.Forms.Button srcBrowseButton;
        System.Windows.Forms.Button imgBrowseButton;
        ProgressBar progressBar;
        System.Windows.Forms.Label statusLabel;
        System.Windows.Forms.Button optionsButton;
        private System.Windows.Forms.PictureBox targetSystemPictureBox;
        private System.Windows.Forms.ComboBox targetSystemComboBox;
        private System.Windows.Forms.CheckBox useTmFileCheckBox;
        private System.Windows.Forms.Panel targetSystemGroupBox;
        private System.Windows.Forms.Panel buildStatusGroupBox;
        private System.Windows.Forms.Label targetSystemSettingsLabel;
        private System.Windows.Forms.Label buildStatusLabel;
    }
}

