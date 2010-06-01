namespace LcogClient.Controls
{
    partial class CycleObjects
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
            this.pictureBoxPlanets = new System.Windows.Forms.PictureBox();
            this.buttonBackPlanets = new LcogClient.Controls.Button();
            this.buttonForwardPlanets = new LcogClient.Controls.Button();
            this.buttonForwardShips = new LcogClient.Controls.Button();
            this.buttonBackShips = new LcogClient.Controls.Button();
            this.pictureBoxShips = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlanets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShips)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxPlanets
            // 
            this.pictureBoxPlanets.Image = global::LcogClient.Properties.Resources.planet;
            this.pictureBoxPlanets.Location = new System.Drawing.Point(41, 2);
            this.pictureBoxPlanets.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBoxPlanets.Name = "pictureBoxPlanets";
            this.pictureBoxPlanets.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxPlanets.TabIndex = 0;
            this.pictureBoxPlanets.TabStop = false;
            // 
            // buttonBackPlanets
            // 
            this.buttonBackPlanets.BaseColor = System.Drawing.SystemColors.Control;
            this.buttonBackPlanets.HighlightColor = System.Drawing.Color.Khaki;
            this.buttonBackPlanets.Image = global::LcogClient.Properties.Resources.back;
            this.buttonBackPlanets.Location = new System.Drawing.Point(0, 0);
            this.buttonBackPlanets.Margin = new System.Windows.Forms.Padding(0);
            this.buttonBackPlanets.Name = "buttonBackPlanets";
            this.buttonBackPlanets.Size = new System.Drawing.Size(36, 36);
            this.buttonBackPlanets.TabIndex = 2;
            this.buttonBackPlanets.UseVisualStyleBackColor = true;
            this.buttonBackPlanets.Click += new System.EventHandler(this.buttonBackPlanets_Click);
            // 
            // buttonForwardPlanets
            // 
            this.buttonForwardPlanets.BaseColor = System.Drawing.SystemColors.Control;
            this.buttonForwardPlanets.HighlightColor = System.Drawing.Color.Khaki;
            this.buttonForwardPlanets.Image = global::LcogClient.Properties.Resources.forward;
            this.buttonForwardPlanets.Location = new System.Drawing.Point(78, 0);
            this.buttonForwardPlanets.Margin = new System.Windows.Forms.Padding(0);
            this.buttonForwardPlanets.Name = "buttonForwardPlanets";
            this.buttonForwardPlanets.Size = new System.Drawing.Size(36, 36);
            this.buttonForwardPlanets.TabIndex = 3;
            this.buttonForwardPlanets.UseVisualStyleBackColor = true;
            this.buttonForwardPlanets.Click += new System.EventHandler(this.buttonForwardPlanets_Click);
            // 
            // buttonForwardShips
            // 
            this.buttonForwardShips.BaseColor = System.Drawing.SystemColors.Control;
            this.buttonForwardShips.HighlightColor = System.Drawing.Color.Khaki;
            this.buttonForwardShips.Image = global::LcogClient.Properties.Resources.forward;
            this.buttonForwardShips.Location = new System.Drawing.Point(212, 0);
            this.buttonForwardShips.Margin = new System.Windows.Forms.Padding(0);
            this.buttonForwardShips.Name = "buttonForwardShips";
            this.buttonForwardShips.Size = new System.Drawing.Size(36, 36);
            this.buttonForwardShips.TabIndex = 6;
            this.buttonForwardShips.UseVisualStyleBackColor = true;
            this.buttonForwardShips.Click += new System.EventHandler(this.buttonForwardShips_Click);
            // 
            // buttonBackShips
            // 
            this.buttonBackShips.BaseColor = System.Drawing.SystemColors.Control;
            this.buttonBackShips.HighlightColor = System.Drawing.Color.Khaki;
            this.buttonBackShips.Image = global::LcogClient.Properties.Resources.back;
            this.buttonBackShips.Location = new System.Drawing.Point(134, 0);
            this.buttonBackShips.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.buttonBackShips.Name = "buttonBackShips";
            this.buttonBackShips.Size = new System.Drawing.Size(36, 36);
            this.buttonBackShips.TabIndex = 5;
            this.buttonBackShips.UseVisualStyleBackColor = true;
            this.buttonBackShips.Click += new System.EventHandler(this.buttonBackShips_Click);
            // 
            // pictureBoxShips
            // 
            this.pictureBoxShips.Image = global::LcogClient.Properties.Resources.ship;
            this.pictureBoxShips.Location = new System.Drawing.Point(175, 2);
            this.pictureBoxShips.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBoxShips.Name = "pictureBoxShips";
            this.pictureBoxShips.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxShips.TabIndex = 4;
            this.pictureBoxShips.TabStop = false;
            // 
            // CycleObjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonForwardShips);
            this.Controls.Add(this.buttonBackShips);
            this.Controls.Add(this.pictureBoxShips);
            this.Controls.Add(this.buttonForwardPlanets);
            this.Controls.Add(this.buttonBackPlanets);
            this.Controls.Add(this.pictureBoxPlanets);
            this.Name = "CycleObjects";
            this.Size = new System.Drawing.Size(248, 36);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlanets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShips)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxPlanets;
        private Button buttonBackPlanets;
        private Button buttonForwardPlanets;
        private Button buttonForwardShips;
        private Button buttonBackShips;
        private System.Windows.Forms.PictureBox pictureBoxShips;
    }
}
