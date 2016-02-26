namespace Namer
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text.RegularExpressions;
    using System.Threading;
    using System.Windows.Forms;

    using Namer.Properties;

    /// <summary>
    /// The main form.
    /// </summary>
    public partial class NamerForm : Form
    {
        /// <summary>
        /// The files.
        /// </summary>
        private readonly List<string> files = new List<string>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NamerForm"/> class.
        /// </summary>
        public NamerForm()
        {
            this.InitializeComponent();

            this.directoryTextBox.Text = this.GetLastOpenedDirectory();
            this.replacementComboBox.Text = ".";
            this.patternComboBox.Text = ".";

            this.fileListBox.DataSource = this.files;

            this.RebindFiles();
        }

        private string GetLastOpenedDirectory()
        {
            var lastDirectory = Settings.Default.LastOpenedDirectory;

            if (string.IsNullOrEmpty(lastDirectory))
            {
                var result = MessageBox.Show("Could not retrieve last used folder. Do you want to choose one now?", "Ops!", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    this.BrowseButtonClick(this, null);
                    lastDirectory = this.directoryTextBox.Text;
                }
            }

            return lastDirectory;
        }

        /// <summary>
        /// Browse button click.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The e.</param>
        private void BrowseButtonClick(object sender, EventArgs e)
        {
            this.folderBrowserDialog.SelectedPath = this.directoryTextBox.Text;
            this.folderBrowserDialog.ShowDialog();

            if (!string.IsNullOrEmpty(this.folderBrowserDialog.SelectedPath) && Directory.Exists(this.folderBrowserDialog.SelectedPath))
            {
                this.directoryTextBox.Text = this.folderBrowserDialog.SelectedPath;
                
                this.RebindFiles();
            }
        }

        /// <summary>
        /// Start rename operation.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The e.</param>
        private void StartButtonClick(object sender, EventArgs e)
        {

            if (this.applyToAllCheckBox.Checked)
            {
                this.RenameFiles(Directory.GetFiles(this.directoryTextBox.Text));
            }
            else
            {
                if (this.fileListBox.SelectedItems.Count > 0)
                {
                    List<string> fileNames = new List<string>();

                    foreach (var selectedItem in this.fileListBox.SelectedItems)
                    {
                        fileNames.Add(selectedItem.ToString());
                    }

                    this.RenameFiles(fileNames);
                }
            }
        }

        /// <summary>
        /// Rename files.
        /// </summary>
        /// <param name="files">Files to rename.</param>
        private void RenameFiles(IEnumerable<string> files)
        {
            this.SetStatus(ApplicationStatus.Renaming);

            this.toolStripProgressBar1.Value = 0;
            this.toolStripProgressBar1.Maximum = files.Count();
            this.toolStripProgressBar1.Step = 1;


            if (string.IsNullOrEmpty(this.patternComboBox.Text.Trim()))
            {
                throw new Exception("Specify parameters!");
            }

            foreach (var file in files)
            {
                this.RenameFile(file);
                this.toolStripProgressBar1.PerformStep();
            }

            this.RebindFiles();

            this.SetStatus(ApplicationStatus.Ready);
        }

        /// <summary>
        /// Rename file on disk.
        /// </summary>
        /// <param name="file">File path.</param>
        private void RenameFile(string file)
        {
            string oldFileName = Path.GetFileName(file);
            string newFileName;

            if (this.regExCheckBox.Checked)
            {
                newFileName = Regex.Replace(oldFileName, this.patternComboBox.Text, this.replacementComboBox.Text);
            }
            else
            {
                newFileName = oldFileName.Replace(this.patternComboBox.Text, this.replacementComboBox.Text);
            }
            
            File.Move(file, Path.Combine(Path.GetDirectoryName(file), newFileName));
        }

        /// <summary>
        /// Get pattern button click.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The e.</param>
        private void GetPatternButtonClick(object sender, EventArgs e)
        {
            if (this.fileListBox.SelectedItem != null)
            {
                this.patternComboBox.Text = Path.GetFileName(this.fileListBox.SelectedItem.ToString());
            }
        }

        /// <summary>
        /// Rebind files list box.
        /// </summary>
        private void RebindFiles()
        {
            if (Directory.Exists(this.directoryTextBox.Text))
            {
                this.files.Clear();
                this.files.AddRange(Directory.GetFiles(this.directoryTextBox.Text));
                this.fileListBox.DataSource = null;
                this.fileListBox.DataSource = this.files;
            }
        }

        /// <summary>
        /// Directory text box leave.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The e.</param>
        private void DirectoryTextBoxLeave(object sender, EventArgs e)
        {
            if (Directory.Exists(this.directoryTextBox.Text))
            {
                this.RebindFiles();
            }
        }

        /// <summary>
        /// Set status.
        /// </summary>
        /// <param name="status">Status to set.</param>
        private void SetStatus(ApplicationStatus status)
        {
            this.toolStripStatusLabel.Text = EnumExtensions.GetEnumDescription(status);
            this.statusStrip.Refresh();
        }

        /// <summary>
        /// Delete button click.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The e.</param>
        private void DeleteButtonClick(object sender, EventArgs e)
        {
            this.SetStatus(ApplicationStatus.Delete);

            foreach (var selectedItem in this.fileListBox.SelectedItems)
            {
                File.Delete(selectedItem.ToString());
            }

            this.RebindFiles();

            this.SetStatus(ApplicationStatus.Ready);
        }

        /// <summary>
        /// Namer form closing.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The e.</param>
        private void NamerFormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default.LastOpenedDirectory = this.directoryTextBox.Text;
            Settings.Default.Save();
        }
    }
}
