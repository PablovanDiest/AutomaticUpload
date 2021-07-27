using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace AutomaticUpload
{
    public partial class Config : Form
    {

        public Config()
        {
            InitializeComponent();
        }

        #region Private Events
        private void btnProjectPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            folderDialog.Description = this.lblProjectPath.Text;
            folderDialog.ShowNewFolderButton = false;
            folderDialog.SelectedPath = this.txtProjectPath.Text;
            DialogResult result = folderDialog.ShowDialog(this);

            if (result == DialogResult.OK)
            {
                this.txtProjectPath.Text = folderDialog.SelectedPath;
            }
        }

        private void btnRemotePath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            folderDialog.Description = this.lblRemotePath.Text;
            folderDialog.ShowNewFolderButton = false;
            folderDialog.SelectedPath = this.txtRemotePath.Text;
            DialogResult result = folderDialog.ShowDialog(this);

            if (result == DialogResult.OK)
            {
                this.txtRemotePath.Text = folderDialog.SelectedPath;
            }
        }

        private void btnAddConfig_Click(object sender, EventArgs e)
        {
            this.checkForChanges(this.txtProjectPath.Text);
        }

        private void OnChanged(object source, FileSystemEventArgs e)
        {
            UpdateStatus(String.Format("File: {0} {1}", e.FullPath, e.ChangeType));
        }

        private void OnRenamed(object source, RenamedEventArgs e)
        {
            UpdateStatus(String.Format("File: {0} renamed to {1}", e.OldFullPath, e.FullPath));
        }
        #endregion

        #region Private Methods
        private void checkForChanges(String path)
        {
            this.lstProject.Items.Add(path);
            this.CreateFileWatcher(path);
        }

        private void CreateFileWatcher(string path)
        {
            FileSystemWatcher watcher = new FileSystemWatcher();
            watcher.Path = path;
            /* Watch for changes in LastAccess and LastWrite times, and 
               the renaming of files or directories. */
            watcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite
               | NotifyFilters.FileName | NotifyFilters.DirectoryName;
            // Only watch text files.
            //watcher.Filter = "*.txt";

            // Add event handlers.
            watcher.Changed += new FileSystemEventHandler(OnChanged);
            watcher.Created += new FileSystemEventHandler(OnChanged);
            watcher.Deleted += new FileSystemEventHandler(OnChanged);
            watcher.Renamed += new RenamedEventHandler(OnRenamed);

            watcher.EnableRaisingEvents = true;
        }

        private void UpdateStatus(String message)
        {
            Invoke(new Action(() => { this.lstActivity.Items.Add(message); }));
        }
        #endregion

        private void lstActivity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
