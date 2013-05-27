using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace FileRename
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public string Source
        {
            get { return SourceTextBox.Text; }
            set
            {
                if (value != SourceTextBox.Text)
                {
                    SourceTextBox.Text = value;
                    OnSourceChange(value);
                }                
            }
        }

        /// <summary>
        /// fill the items to file list box
        /// </summary>
        private void SetFileItems(FileObject[] collection)
        {
            FileListBox.Items.Clear();
            if (collection != null)
            {
                FileListBox.Items.AddRange(collection);
            }
        }

        /// <summary>
        /// fill files to the file list box on source changed
        /// </summary>
        private void OnSourceChange(string newSource)
        {
            var query = from s in Directory.GetFiles(newSource) select new FileObject(s);
            SetFileItems(query.ToArray());
            SnRadioButton.Checked = true;
            UpdateSourceCount();
        }

        /// <summary>
        /// update the source count label
        /// </summary>
        private void UpdateSourceCount()
        {
            int count = FileListBox.Items.Count;
            DigitNumericUpDown.Value = Convert.ToDecimal(count.ToString().Length);
            ProgressBar.Maximum = count;
            if (count == 0)
            {
                ItemCountLabel.Text = "Empty";
            }
            else if (count == 1)
            {
                ItemCountLabel.Text = "Total 1 file";
            }
            else
            {
                ItemCountLabel.Text = string.Format("Total {0} files", count);
            }
        }

        /// <summary>
        /// open the folder browser dialog to select a path
        /// </summary>
        private string SelectPath()
        {
            using (FolderBrowserDialog d = new FolderBrowserDialog())
            {
                d.ShowNewFolderButton = false;
                if (DialogResult.OK == d.ShowDialog())
                {                    
                    return d.SelectedPath;
                }
            }
            return null;
        }

        /// <summary>
        /// get the rename task object
        /// </summary>
        private RenameTask GetTask()
        {
            var collection = FileListBox.Items.OfType<FileObject>();
            var generator = new SerialNameGenerator(PrefixTextBox.Text, SuffixTextBox.Text,
                Convert.ToInt32(SeedNumericUpDown.Value), Convert.ToInt32(DigitNumericUpDown.Value));
            return new RenameTask(collection, generator);
        }

        #region Action Events

        private void OnSourceSelectButtonClicked(object sender, EventArgs e)
        {
            string path = SelectPath();
            if (string.IsNullOrEmpty(path) == false)
            {
                Source = path;
            }
        }

        private void SnCheckedChanged(object sender, EventArgs e)
        {
            if (SnRadioButton.Checked)
            {
                var query = FileListBox.Items.OfType<FileObject>().OrderBy(c => c.Name);
                SetFileItems(query.ToArray());
            }
        }

        private void StCheckedChanged(object sender, EventArgs e)
        {
            if (StRadioButton.Checked)
            {
                var query = FileListBox.Items.OfType<FileObject>().OrderBy(c => c.CreationTime);
                SetFileItems(query.ToArray());
            }
        }

        private void OnActionButtonClicked(object sender, EventArgs e)
        {
            switch (ActionButton.Text)
            {
                case "Start":
                    SourceGroupBox.Enabled = false;
                    PreferenceGroupBox.Enabled = false;
                    ActionButton.Text = "Cancel";
                    ProcessWorker.RunWorkerAsync(GetTask());
                    break;
                case "Cancel":
                    Application.Exit();
                    break;
                case "Close":
                    this.Close();
                    break;
            }
        } 

        #endregion

        #region Background Worker Event

        private void OnProcessWorkerDoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            RenameTask task = e.Argument as RenameTask;

            while (task.DoNext())
            {
                worker.ReportProgress(0, null);
            }
        }

        private void OnProcessWorkerProgress(object sender, ProgressChangedEventArgs e)
        {
            ProgressBar.PerformStep();
        }

        private void OnProcessWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ProgressBar.Maximum = FileListBox.Items.Count;
            SourceGroupBox.Enabled = true;
            PreferenceGroupBox.Enabled = true;
            ActionButton.Text = "Close";
        } 

        #endregion        
    }
}
