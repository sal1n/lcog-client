namespace LcogClient.Controls
{
    partial class LandingCraftComponent
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelLandingCraft = new System.Windows.Forms.Label();
            this.pictureBoxLandingCraft = new System.Windows.Forms.PictureBox();
            this.buttonCancelColonise = new LcogClient.Controls.Button();
            this.labelColonise = new System.Windows.Forms.Label();
            this.buttonColonise = new LcogClient.Controls.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLandingCraft)).BeginInit();
            this.SuspendLayout();
            // 
            // labelLandingCraft
            // 
            this.labelLandingCraft.Location = new System.Drawing.Point(0, 0);
            this.labelLandingCraft.Margin = new System.Windows.Forms.Padding(0);
            this.labelLandingCraft.Name = "labelLandingCraft";
            this.labelLandingCraft.Size = new System.Drawing.Size(24, 24);
            this.labelLandingCraft.TabIndex = 7;
            this.labelLandingCraft.Text = "1";
            this.labelLandingCraft.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBoxLandingCraft
            // 
            this.pictureBoxLandingCraft.Image = global::LcogClient.Properties.Resources.landing_craft;
            this.pictureBoxLandingCraft.Location = new System.Drawing.Point(24, 0);
            this.pictureBoxLandingCraft.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxLandingCraft.Name = "pictureBoxLandingCraft";
            this.pictureBoxLandingCraft.Size = new System.Drawing.Size(24, 24);
            this.pictureBoxLandingCraft.TabIndex = 6;
            this.pictureBoxLandingCraft.TabStop = false;
            // 
            // buttonCancelColonise
            // 
            this.buttonCancelColonise.BaseColor = System.Drawing.SystemColors.Control;
            this.buttonCancelColonise.HighlightColor = System.Drawing.Color.Khaki;
            this.buttonCancelColonise.Image = global::LcogClient.Properties.Resources.cancel;
            this.buttonCancelColonise.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancelColonise.Location = new System.Drawing.Point(231, 0);
            this.buttonCancelColonise.Margin = new System.Windows.Forms.Padding(5);
            this.buttonCancelColonise.Name = "buttonCancelColonise";
            this.buttonCancelColonise.Size = new System.Drawing.Size(24, 24);
            this.buttonCancelColonise.TabIndex = 24;
            this.buttonCancelColonise.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCancelColonise.UseVisualStyleBackColor = false;
            this.buttonCancelColonise.Click += new System.EventHandler(this.buttonCancelColonise_Click);
            // 
            // labelColonise
            // 
            this.labelColonise.Location = new System.Drawing.Point(54, 0);
            this.labelColonise.Margin = new System.Windows.Forms.Padding(5);
            this.labelColonise.Name = "labelColonise";
            this.labelColonise.Size = new System.Drawing.Size(167, 24);
            this.labelColonise.TabIndex = 23;
            this.labelColonise.Text = "Colonising Planet";
            this.labelColonise.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonColonise
            // 
            this.buttonColonise.BaseColor = System.Drawing.SystemColors.Control;
            this.buttonColonise.HighlightColor = System.Drawing.Color.Khaki;
            this.buttonColonise.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonColonise.Location = new System.Drawing.Point(54, 0);
            this.buttonColonise.Margin = new System.Windows.Forms.Padding(0, 5, 5, 5);
            this.buttonColonise.Name = "buttonColonise";
            this.buttonColonise.Size = new System.Drawing.Size(78, 24);
            this.buttonColonise.TabIndex = 22;
            this.buttonColonise.Text = "Colonise";
            this.buttonColonise.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonColonise.UseVisualStyleBackColor = false;
            this.buttonColonise.Click += new System.EventHandler(this.buttonColonise_Click);
            // 
            // LandingCraftComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonCancelColonise);
            this.Controls.Add(this.labelColonise);
            this.Controls.Add(this.buttonColonise);
            this.Controls.Add(this.labelLandingCraft);
            this.Controls.Add(this.pictureBoxLandingCraft);
            this.Name = "LandingCraftComponent";
            this.Size = new System.Drawing.Size(268, 24);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLandingCraft)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelLandingCraft;
        private System.Windows.Forms.PictureBox pictureBoxLandingCraft;
        private Button buttonCancelColonise;
        private System.Windows.Forms.Label labelColonise;
        private Button buttonColonise;
    }
}
