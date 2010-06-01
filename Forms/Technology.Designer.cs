namespace LcogClient.Forms
{
    partial class Technology
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
            this.buttonEngineering = new LcogClient.Controls.Button();
            this.buttonQuantum = new LcogClient.Controls.Button();
            this.buttonFields = new LcogClient.Controls.Button();
            this.labelCurrentResearch = new System.Windows.Forms.Label();
            this.labelResearch = new System.Windows.Forms.Label();
            this.labelEngineering = new System.Windows.Forms.Label();
            this.labelQuantum = new System.Windows.Forms.Label();
            this.labelFields = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonEngineering
            // 
            this.buttonEngineering.BaseColor = System.Drawing.SystemColors.Control;
            this.buttonEngineering.HighlightColor = System.Drawing.Color.Khaki;
            this.buttonEngineering.Image = global::LcogClient.Properties.Resources.download;
            this.buttonEngineering.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEngineering.Location = new System.Drawing.Point(15, 37);
            this.buttonEngineering.Margin = new System.Windows.Forms.Padding(5);
            this.buttonEngineering.Name = "buttonEngineering";
            this.buttonEngineering.Size = new System.Drawing.Size(115, 38);
            this.buttonEngineering.TabIndex = 1;
            this.buttonEngineering.Text = "Engineering";
            this.buttonEngineering.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonEngineering.UseVisualStyleBackColor = false;
            this.buttonEngineering.Click += new System.EventHandler(this.buttonEngineering_Click);
            // 
            // buttonQuantum
            // 
            this.buttonQuantum.BaseColor = System.Drawing.SystemColors.Control;
            this.buttonQuantum.HighlightColor = System.Drawing.Color.Khaki;
            this.buttonQuantum.Image = global::LcogClient.Properties.Resources.download;
            this.buttonQuantum.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonQuantum.Location = new System.Drawing.Point(15, 85);
            this.buttonQuantum.Margin = new System.Windows.Forms.Padding(5);
            this.buttonQuantum.Name = "buttonQuantum";
            this.buttonQuantum.Size = new System.Drawing.Size(115, 38);
            this.buttonQuantum.TabIndex = 2;
            this.buttonQuantum.Text = "Quantum";
            this.buttonQuantum.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonQuantum.UseVisualStyleBackColor = false;
            this.buttonQuantum.Click += new System.EventHandler(this.buttonQuantum_Click);
            // 
            // buttonFields
            // 
            this.buttonFields.BaseColor = System.Drawing.SystemColors.Control;
            this.buttonFields.HighlightColor = System.Drawing.Color.Khaki;
            this.buttonFields.Image = global::LcogClient.Properties.Resources.download;
            this.buttonFields.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFields.Location = new System.Drawing.Point(14, 133);
            this.buttonFields.Margin = new System.Windows.Forms.Padding(5);
            this.buttonFields.Name = "buttonFields";
            this.buttonFields.Size = new System.Drawing.Size(115, 38);
            this.buttonFields.TabIndex = 3;
            this.buttonFields.Text = "Fields";
            this.buttonFields.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonFields.UseVisualStyleBackColor = false;
            this.buttonFields.Click += new System.EventHandler(this.buttonFields_Click);
            // 
            // labelCurrentResearch
            // 
            this.labelCurrentResearch.Location = new System.Drawing.Point(12, 9);
            this.labelCurrentResearch.Name = "labelCurrentResearch";
            this.labelCurrentResearch.Size = new System.Drawing.Size(145, 23);
            this.labelCurrentResearch.TabIndex = 4;
            this.labelCurrentResearch.Text = "Research (1 / turn):";
            this.labelCurrentResearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelResearch
            // 
            this.labelResearch.Location = new System.Drawing.Point(186, 9);
            this.labelResearch.Name = "labelResearch";
            this.labelResearch.Size = new System.Drawing.Size(108, 23);
            this.labelResearch.TabIndex = 5;
            this.labelResearch.Text = "Engineering";
            this.labelResearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelEngineering
            // 
            this.labelEngineering.Location = new System.Drawing.Point(138, 37);
            this.labelEngineering.Name = "labelEngineering";
            this.labelEngineering.Size = new System.Drawing.Size(86, 38);
            this.labelEngineering.TabIndex = 6;
            this.labelEngineering.Text = "Level 0 (0)";
            this.labelEngineering.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelQuantum
            // 
            this.labelQuantum.Location = new System.Drawing.Point(138, 85);
            this.labelQuantum.Name = "labelQuantum";
            this.labelQuantum.Size = new System.Drawing.Size(86, 38);
            this.labelQuantum.TabIndex = 7;
            this.labelQuantum.Text = "Level 0";
            this.labelQuantum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelFields
            // 
            this.labelFields.Location = new System.Drawing.Point(138, 133);
            this.labelFields.Name = "labelFields";
            this.labelFields.Size = new System.Drawing.Size(86, 38);
            this.labelFields.TabIndex = 8;
            this.labelFields.Text = "Level 0";
            this.labelFields.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Technology
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 189);
            this.Controls.Add(this.labelFields);
            this.Controls.Add(this.labelQuantum);
            this.Controls.Add(this.labelEngineering);
            this.Controls.Add(this.labelResearch);
            this.Controls.Add(this.labelCurrentResearch);
            this.Controls.Add(this.buttonFields);
            this.Controls.Add(this.buttonQuantum);
            this.Controls.Add(this.buttonEngineering);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Technology";
            this.ShowInTaskbar = false;
            this.Text = "Technology    |    Lost Colonies of Guernsey";
            this.ResumeLayout(false);

        }

        #endregion

        private LcogClient.Controls.Button buttonEngineering;
        private LcogClient.Controls.Button buttonQuantum;
        private LcogClient.Controls.Button buttonFields;
        private System.Windows.Forms.Label labelCurrentResearch;
        private System.Windows.Forms.Label labelResearch;
        private System.Windows.Forms.Label labelEngineering;
        private System.Windows.Forms.Label labelQuantum;
        private System.Windows.Forms.Label labelFields;


    }
}