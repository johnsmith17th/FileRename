namespace FileRename
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.SourceGroupBox = new System.Windows.Forms.GroupBox();
            this.ItemCountLabel = new System.Windows.Forms.Label();
            this.StRadioButton = new System.Windows.Forms.RadioButton();
            this.FileListBox = new System.Windows.Forms.ListBox();
            this.SelectSourceButton = new System.Windows.Forms.Button();
            this.SourceTextBox = new System.Windows.Forms.TextBox();
            this.SnRadioButton = new System.Windows.Forms.RadioButton();
            this.PreferenceGroupBox = new System.Windows.Forms.GroupBox();
            this.DigitNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.SeedNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.SuffixTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PrefixTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.ActionButton = new System.Windows.Forms.Button();
            this.ProcessWorker = new System.ComponentModel.BackgroundWorker();
            this.SourceGroupBox.SuspendLayout();
            this.PreferenceGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DigitNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SeedNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // SourceGroupBox
            // 
            this.SourceGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.SourceGroupBox.Controls.Add(this.ItemCountLabel);
            this.SourceGroupBox.Controls.Add(this.StRadioButton);
            this.SourceGroupBox.Controls.Add(this.FileListBox);
            this.SourceGroupBox.Controls.Add(this.SelectSourceButton);
            this.SourceGroupBox.Controls.Add(this.SourceTextBox);
            this.SourceGroupBox.Controls.Add(this.SnRadioButton);
            this.SourceGroupBox.Location = new System.Drawing.Point(12, 12);
            this.SourceGroupBox.Name = "SourceGroupBox";
            this.SourceGroupBox.Size = new System.Drawing.Size(429, 209);
            this.SourceGroupBox.TabIndex = 0;
            this.SourceGroupBox.TabStop = false;
            this.SourceGroupBox.Text = "Source";
            // 
            // ItemCountLabel
            // 
            this.ItemCountLabel.AutoSize = true;
            this.ItemCountLabel.Location = new System.Drawing.Point(7, 183);
            this.ItemCountLabel.Name = "ItemCountLabel";
            this.ItemCountLabel.Size = new System.Drawing.Size(41, 15);
            this.ItemCountLabel.TabIndex = 5;
            this.ItemCountLabel.Text = "Empty";
            // 
            // StRadioButton
            // 
            this.StRadioButton.AutoSize = true;
            this.StRadioButton.Location = new System.Drawing.Point(288, 181);
            this.StRadioButton.Name = "StRadioButton";
            this.StRadioButton.Size = new System.Drawing.Size(135, 19);
            this.StRadioButton.TabIndex = 1;
            this.StRadioButton.Text = "Sort by creation time";
            this.StRadioButton.UseVisualStyleBackColor = true;
            this.StRadioButton.CheckedChanged += new System.EventHandler(this.StCheckedChanged);
            // 
            // FileListBox
            // 
            this.FileListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.FileListBox.FormattingEnabled = true;
            this.FileListBox.ItemHeight = 15;
            this.FileListBox.Location = new System.Drawing.Point(10, 51);
            this.FileListBox.Name = "FileListBox";
            this.FileListBox.Size = new System.Drawing.Size(408, 124);
            this.FileListBox.TabIndex = 2;
            // 
            // SelectSourceButton
            // 
            this.SelectSourceButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectSourceButton.Location = new System.Drawing.Point(348, 21);
            this.SelectSourceButton.Name = "SelectSourceButton";
            this.SelectSourceButton.Size = new System.Drawing.Size(70, 23);
            this.SelectSourceButton.TabIndex = 4;
            this.SelectSourceButton.Text = "Select...";
            this.SelectSourceButton.UseVisualStyleBackColor = true;
            this.SelectSourceButton.Click += new System.EventHandler(this.OnSourceSelectButtonClicked);
            // 
            // SourceTextBox
            // 
            this.SourceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.SourceTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.SourceTextBox.Location = new System.Drawing.Point(10, 22);
            this.SourceTextBox.Name = "SourceTextBox";
            this.SourceTextBox.ReadOnly = true;
            this.SourceTextBox.Size = new System.Drawing.Size(332, 23);
            this.SourceTextBox.TabIndex = 2;
            // 
            // SnRadioButton
            // 
            this.SnRadioButton.AutoSize = true;
            this.SnRadioButton.Checked = true;
            this.SnRadioButton.Location = new System.Drawing.Point(187, 181);
            this.SnRadioButton.Name = "SnRadioButton";
            this.SnRadioButton.Size = new System.Drawing.Size(95, 19);
            this.SnRadioButton.TabIndex = 0;
            this.SnRadioButton.TabStop = true;
            this.SnRadioButton.Text = "Sort by name";
            this.SnRadioButton.UseVisualStyleBackColor = true;
            this.SnRadioButton.CheckedChanged += new System.EventHandler(this.SnCheckedChanged);
            // 
            // PreferenceGroupBox
            // 
            this.PreferenceGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.PreferenceGroupBox.Controls.Add(this.DigitNumericUpDown);
            this.PreferenceGroupBox.Controls.Add(this.SeedNumericUpDown);
            this.PreferenceGroupBox.Controls.Add(this.SuffixTextBox);
            this.PreferenceGroupBox.Controls.Add(this.label6);
            this.PreferenceGroupBox.Controls.Add(this.PrefixTextBox);
            this.PreferenceGroupBox.Controls.Add(this.label5);
            this.PreferenceGroupBox.Controls.Add(this.label4);
            this.PreferenceGroupBox.Controls.Add(this.label3);
            this.PreferenceGroupBox.Location = new System.Drawing.Point(12, 227);
            this.PreferenceGroupBox.Name = "PreferenceGroupBox";
            this.PreferenceGroupBox.Size = new System.Drawing.Size(429, 82);
            this.PreferenceGroupBox.TabIndex = 1;
            this.PreferenceGroupBox.TabStop = false;
            this.PreferenceGroupBox.Text = "Preferences";
            // 
            // DigitNumericUpDown
            // 
            this.DigitNumericUpDown.Location = new System.Drawing.Point(333, 49);
            this.DigitNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.DigitNumericUpDown.Name = "DigitNumericUpDown";
            this.DigitNumericUpDown.Size = new System.Drawing.Size(85, 23);
            this.DigitNumericUpDown.TabIndex = 9;
            this.DigitNumericUpDown.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // SeedNumericUpDown
            // 
            this.SeedNumericUpDown.Location = new System.Drawing.Point(333, 20);
            this.SeedNumericUpDown.Maximum = new decimal(new int[] {
            65536,
            0,
            0,
            0});
            this.SeedNumericUpDown.Name = "SeedNumericUpDown";
            this.SeedNumericUpDown.Size = new System.Drawing.Size(85, 23);
            this.SeedNumericUpDown.TabIndex = 8;
            this.SeedNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // SuffixTextBox
            // 
            this.SuffixTextBox.Location = new System.Drawing.Point(51, 49);
            this.SuffixTextBox.Name = "SuffixTextBox";
            this.SuffixTextBox.Size = new System.Drawing.Size(235, 23);
            this.SuffixTextBox.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(292, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Digit:";
            // 
            // PrefixTextBox
            // 
            this.PrefixTextBox.Location = new System.Drawing.Point(51, 20);
            this.PrefixTextBox.Name = "PrefixTextBox";
            this.PrefixTextBox.Size = new System.Drawing.Size(235, 23);
            this.PrefixTextBox.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(292, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Seed:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Suffix:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prefix:";
            // 
            // ProgressBar
            // 
            this.ProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ProgressBar.Location = new System.Drawing.Point(12, 319);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(348, 25);
            this.ProgressBar.Step = 1;
            this.ProgressBar.TabIndex = 3;
            // 
            // ActionButton
            // 
            this.ActionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ActionButton.Location = new System.Drawing.Point(366, 319);
            this.ActionButton.Name = "ActionButton";
            this.ActionButton.Size = new System.Drawing.Size(75, 25);
            this.ActionButton.TabIndex = 4;
            this.ActionButton.Text = "Start";
            this.ActionButton.UseVisualStyleBackColor = true;
            this.ActionButton.Click += new System.EventHandler(this.OnActionButtonClicked);
            // 
            // ProcessWorker
            // 
            this.ProcessWorker.WorkerReportsProgress = true;
            this.ProcessWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.OnProcessWorkerDoWork);
            this.ProcessWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.OnProcessWorkerProgress);
            this.ProcessWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.OnProcessWorkerCompleted);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 356);
            this.Controls.Add(this.ActionButton);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.PreferenceGroupBox);
            this.Controls.Add(this.SourceGroupBox);
            this.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Rename";
            this.SourceGroupBox.ResumeLayout(false);
            this.SourceGroupBox.PerformLayout();
            this.PreferenceGroupBox.ResumeLayout(false);
            this.PreferenceGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DigitNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SeedNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox SourceGroupBox;
        private System.Windows.Forms.Button SelectSourceButton;
        private System.Windows.Forms.TextBox SourceTextBox;
        private System.Windows.Forms.GroupBox PreferenceGroupBox;
        private System.Windows.Forms.TextBox SuffixTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PrefixTextBox;
        private System.Windows.Forms.NumericUpDown DigitNumericUpDown;
        private System.Windows.Forms.NumericUpDown SeedNumericUpDown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox FileListBox;
        private System.Windows.Forms.RadioButton StRadioButton;
        private System.Windows.Forms.RadioButton SnRadioButton;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.Button ActionButton;
        private System.Windows.Forms.Label ItemCountLabel;
        private System.ComponentModel.BackgroundWorker ProcessWorker;
    }
}

