namespace LcogClient.Forms
{
    partial class Menu
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
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.buttonUpdate = new LcogClient.Controls.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelFactionId = new System.Windows.Forms.Label();
            this.textBoxFactionId = new System.Windows.Forms.TextBox();
            this.buttonUpload = new LcogClient.Controls.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.buttonPlay = new LcogClient.Controls.Button();
            this.buttonVCR = new LcogClient.Controls.Button();
            this.button_download = new LcogClient.Controls.Button();
            this.listView = new System.Windows.Forms.ListView();
            this.columnHeader = new System.Windows.Forms.ColumnHeader();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.buttonUpdate);
            this.groupBox.Controls.Add(this.textBoxPassword);
            this.groupBox.Controls.Add(this.labelPassword);
            this.groupBox.Controls.Add(this.labelFactionId);
            this.groupBox.Controls.Add(this.textBoxFactionId);
            this.groupBox.Controls.Add(this.buttonUpload);
            this.groupBox.Controls.Add(this.progressBar);
            this.groupBox.Controls.Add(this.buttonPlay);
            this.groupBox.Controls.Add(this.buttonVCR);
            this.groupBox.Controls.Add(this.button_download);
            this.groupBox.Location = new System.Drawing.Point(12, 12);
            this.groupBox.Name = "groupBox";
            this.groupBox.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox.Size = new System.Drawing.Size(342, 223);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "LCoG Client version 2.0";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BaseColor = System.Drawing.SystemColors.Control;
            this.buttonUpdate.HighlightColor = System.Drawing.Color.Khaki;
            this.buttonUpdate.Location = new System.Drawing.Point(216, 171);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 9;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(216, 144);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(111, 21);
            this.textBoxPassword.TabIndex = 8;
            this.textBoxPassword.Text = "getjimheiswinning";
            // 
            // labelPassword
            // 
            this.labelPassword.Location = new System.Drawing.Point(213, 122);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(81, 20);
            this.labelPassword.TabIndex = 7;
            this.labelPassword.Text = "Password";
            this.labelPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelFactionId
            // 
            this.labelFactionId.Location = new System.Drawing.Point(213, 75);
            this.labelFactionId.Name = "labelFactionId";
            this.labelFactionId.Size = new System.Drawing.Size(81, 20);
            this.labelFactionId.TabIndex = 6;
            this.labelFactionId.Text = "Faction ID";
            this.labelFactionId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxFactionId
            // 
            this.textBoxFactionId.Location = new System.Drawing.Point(216, 98);
            this.textBoxFactionId.MaxLength = 3;
            this.textBoxFactionId.Name = "textBoxFactionId";
            this.textBoxFactionId.Size = new System.Drawing.Size(33, 21);
            this.textBoxFactionId.TabIndex = 5;
            this.textBoxFactionId.Text = "167";
            // 
            // buttonUpload
            // 
            this.buttonUpload.BaseColor = System.Drawing.SystemColors.Control;
            this.buttonUpload.HighlightColor = System.Drawing.Color.Khaki;
            this.buttonUpload.Image = global::LcogClient.Properties.Resources.upload;
            this.buttonUpload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUpload.Location = new System.Drawing.Point(13, 171);
            this.buttonUpload.Margin = new System.Windows.Forms.Padding(5);
            this.buttonUpload.Name = "buttonUpload";
            this.buttonUpload.Size = new System.Drawing.Size(153, 38);
            this.buttonUpload.TabIndex = 4;
            this.buttonUpload.Text = "Upload Orders";
            this.buttonUpload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonUpload.UseVisualStyleBackColor = false;
            this.buttonUpload.Click += new System.EventHandler(this.buttonUpload_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(174, 33);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(153, 23);
            this.progressBar.TabIndex = 3;
            // 
            // buttonPlay
            // 
            this.buttonPlay.BaseColor = System.Drawing.SystemColors.Control;
            this.buttonPlay.HighlightColor = System.Drawing.Color.Khaki;
            this.buttonPlay.Image = global::LcogClient.Properties.Resources.play;
            this.buttonPlay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPlay.Location = new System.Drawing.Point(13, 123);
            this.buttonPlay.Margin = new System.Windows.Forms.Padding(5);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(153, 38);
            this.buttonPlay.TabIndex = 2;
            this.buttonPlay.Text = "Play";
            this.buttonPlay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonPlay.UseVisualStyleBackColor = false;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // buttonVCR
            // 
            this.buttonVCR.BaseColor = System.Drawing.SystemColors.Control;
            this.buttonVCR.HighlightColor = System.Drawing.Color.Khaki;
            this.buttonVCR.Image = global::LcogClient.Properties.Resources.vcr_icon;
            this.buttonVCR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonVCR.Location = new System.Drawing.Point(13, 75);
            this.buttonVCR.Margin = new System.Windows.Forms.Padding(5);
            this.buttonVCR.Name = "buttonVCR";
            this.buttonVCR.Size = new System.Drawing.Size(153, 38);
            this.buttonVCR.TabIndex = 1;
            this.buttonVCR.Text = "VCR";
            this.buttonVCR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonVCR.UseVisualStyleBackColor = false;
            this.buttonVCR.Click += new System.EventHandler(this.buttonVCR_Click);
            // 
            // button_download
            // 
            this.button_download.BaseColor = System.Drawing.SystemColors.Control;
            this.button_download.HighlightColor = System.Drawing.Color.Khaki;
            this.button_download.Image = global::LcogClient.Properties.Resources.download;
            this.button_download.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_download.Location = new System.Drawing.Point(13, 27);
            this.button_download.Margin = new System.Windows.Forms.Padding(5);
            this.button_download.Name = "button_download";
            this.button_download.Size = new System.Drawing.Size(153, 38);
            this.button_download.TabIndex = 0;
            this.button_download.Text = "Download Report";
            this.button_download.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_download.UseVisualStyleBackColor = false;
            this.button_download.Click += new System.EventHandler(this.buttonDownload_Click);
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader});
            this.listView.FullRowSelect = true;
            this.listView.GridLines = true;
            this.listView.Location = new System.Drawing.Point(12, 243);
            this.listView.Margin = new System.Windows.Forms.Padding(5);
            this.listView.MultiSelect = false;
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(342, 165);
            this.listView.TabIndex = 1;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader
            // 
            this.columnHeader.Text = "Event Log";
            this.columnHeader.Width = 315;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 422);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.groupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Menu";
            this.Text = "Menu    |    Lost Colonies of Guernsey";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private LcogClient.Controls.Button button_download;
        private LcogClient.Controls.Button buttonPlay;
        private LcogClient.Controls.Button buttonVCR;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader columnHeader;
        private LcogClient.Controls.Button buttonUpload;
        private System.Windows.Forms.TextBox textBoxFactionId;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelFactionId;
        private LcogClient.Controls.Button buttonUpdate;
    }
}