namespace AutomaticUpload
{
    partial class Config
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
            this.txtProjectPath = new System.Windows.Forms.TextBox();
            this.lblProjectPath = new System.Windows.Forms.Label();
            this.btnProjectPath = new System.Windows.Forms.Button();
            this.btnAddConfig = new System.Windows.Forms.Button();
            this.lstProject = new System.Windows.Forms.ListBox();
            this.lstActivity = new System.Windows.Forms.ListBox();
            this.lblRemotePath = new System.Windows.Forms.Label();
            this.txtRemotePath = new System.Windows.Forms.TextBox();
            this.btnRemotePath = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.configDataSet = new AutomaticUpload.ConfigDataSet();
            this.configTableAdapter1 = new AutomaticUpload.ConfigDataSetTableAdapters.ConfigTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.configDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // txtProjectPath
            // 
            this.txtProjectPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProjectPath.Location = new System.Drawing.Point(128, 25);
            this.txtProjectPath.Name = "txtProjectPath";
            this.txtProjectPath.Size = new System.Drawing.Size(566, 20);
            this.txtProjectPath.TabIndex = 0;
            this.txtProjectPath.Text = "C:\\Users\\Pablo-HP\\nerdearlaenvivo";
            // 
            // lblProjectPath
            // 
            this.lblProjectPath.Location = new System.Drawing.Point(12, 25);
            this.lblProjectPath.Name = "lblProjectPath";
            this.lblProjectPath.Size = new System.Drawing.Size(110, 20);
            this.lblProjectPath.TabIndex = 1;
            this.lblProjectPath.Text = "Carpeta del proyecto";
            // 
            // btnProjectPath
            // 
            this.btnProjectPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProjectPath.Location = new System.Drawing.Point(700, 19);
            this.btnProjectPath.Name = "btnProjectPath";
            this.btnProjectPath.Size = new System.Drawing.Size(32, 30);
            this.btnProjectPath.TabIndex = 2;
            this.btnProjectPath.Text = "...";
            this.btnProjectPath.UseVisualStyleBackColor = true;
            this.btnProjectPath.Click += new System.EventHandler(this.btnProjectPath_Click);
            // 
            // btnAddConfig
            // 
            this.btnAddConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddConfig.Location = new System.Drawing.Point(738, 51);
            this.btnAddConfig.Name = "btnAddConfig";
            this.btnAddConfig.Size = new System.Drawing.Size(32, 30);
            this.btnAddConfig.TabIndex = 3;
            this.btnAddConfig.Text = ">>";
            this.btnAddConfig.UseVisualStyleBackColor = true;
            this.btnAddConfig.Click += new System.EventHandler(this.btnAddConfig_Click);
            // 
            // lstProject
            // 
            this.lstProject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstProject.FormattingEnabled = true;
            this.lstProject.Location = new System.Drawing.Point(15, 103);
            this.lstProject.Name = "lstProject";
            this.lstProject.Size = new System.Drawing.Size(392, 303);
            this.lstProject.TabIndex = 4;
            // 
            // lstActivity
            // 
            this.lstActivity.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstActivity.FormattingEnabled = true;
            this.lstActivity.Location = new System.Drawing.Point(422, 103);
            this.lstActivity.Name = "lstActivity";
            this.lstActivity.Size = new System.Drawing.Size(348, 303);
            this.lstActivity.TabIndex = 5;
            this.lstActivity.SelectedIndexChanged += new System.EventHandler(this.lstActivity_SelectedIndexChanged);
            // 
            // lblRemotePath
            // 
            this.lblRemotePath.Location = new System.Drawing.Point(12, 57);
            this.lblRemotePath.Name = "lblRemotePath";
            this.lblRemotePath.Size = new System.Drawing.Size(110, 20);
            this.lblRemotePath.TabIndex = 7;
            this.lblRemotePath.Text = "Carpeta remota";
            // 
            // txtRemotePath
            // 
            this.txtRemotePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRemotePath.Location = new System.Drawing.Point(128, 57);
            this.txtRemotePath.Name = "txtRemotePath";
            this.txtRemotePath.Size = new System.Drawing.Size(566, 20);
            this.txtRemotePath.TabIndex = 6;
            // 
            // btnRemotePath
            // 
            this.btnRemotePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemotePath.Location = new System.Drawing.Point(700, 51);
            this.btnRemotePath.Name = "btnRemotePath";
            this.btnRemotePath.Size = new System.Drawing.Size(32, 30);
            this.btnRemotePath.TabIndex = 8;
            this.btnRemotePath.Text = "...";
            this.btnRemotePath.UseVisualStyleBackColor = true;
            this.btnRemotePath.Click += new System.EventHandler(this.btnRemotePath_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(685, 434);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 30);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Cerrar";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // configDataSet
            // 
            this.configDataSet.DataSetName = "ConfigDataSet";
            this.configDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // configTableAdapter1
            // 
            this.configTableAdapter1.ClearBeforeFill = true;
            // 
            // Config
            // 
            this.AcceptButton = this.btnClose;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(784, 471);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRemotePath);
            this.Controls.Add(this.lblRemotePath);
            this.Controls.Add(this.txtRemotePath);
            this.Controls.Add(this.lstActivity);
            this.Controls.Add(this.lstProject);
            this.Controls.Add(this.btnAddConfig);
            this.Controls.Add(this.btnProjectPath);
            this.Controls.Add(this.lblProjectPath);
            this.Controls.Add(this.txtProjectPath);
            this.MinimumSize = new System.Drawing.Size(800, 510);
            this.Name = "Config";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Automatic Upload";
            this.Load += new System.EventHandler(this.Config_Load);
            ((System.ComponentModel.ISupportInitialize)(this.configDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtProjectPath;
        private System.Windows.Forms.Label lblProjectPath;
        private System.Windows.Forms.Button btnProjectPath;
        private System.Windows.Forms.Button btnAddConfig;
        private System.Windows.Forms.ListBox lstProject;
        private System.Windows.Forms.ListBox lstActivity;
        private System.Windows.Forms.Label lblRemotePath;
        private System.Windows.Forms.TextBox txtRemotePath;
        private System.Windows.Forms.Button btnRemotePath;
        private System.Windows.Forms.Button btnClose;
        private ConfigDataSet configDataSet;
        private ConfigDataSetTableAdapters.ConfigTableAdapter configTableAdapter1;
    }
}

