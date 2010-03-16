﻿namespace LcogClient.Controls
{
    partial class FactionDiplomacy
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
            this.pictureBoxDiplomacy = new System.Windows.Forms.PictureBox();
            this.labelFactionName = new System.Windows.Forms.Label();
            this.buttonDeclare = new LcogClient.Controls.Button();
            this.labelShips = new System.Windows.Forms.Label();
            this.pictureBoxShips = new System.Windows.Forms.PictureBox();
            this.labelPlanets = new System.Windows.Forms.Label();
            this.pictureBoxPlanets = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDiplomacy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShips)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlanets)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxDiplomacy
            // 
            this.pictureBoxDiplomacy.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxDiplomacy.Image = global::LcogClient.Properties.Resources.neutral;
            this.pictureBoxDiplomacy.Location = new System.Drawing.Point(5, 5);
            this.pictureBoxDiplomacy.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBoxDiplomacy.Name = "pictureBoxDiplomacy";
            this.pictureBoxDiplomacy.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxDiplomacy.TabIndex = 0;
            this.pictureBoxDiplomacy.TabStop = false;
            // 
            // labelFactionName
            // 
            this.labelFactionName.BackColor = System.Drawing.Color.Transparent;
            this.labelFactionName.ForeColor = System.Drawing.Color.White;
            this.labelFactionName.Location = new System.Drawing.Point(47, 5);
            this.labelFactionName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelFactionName.Name = "labelFactionName";
            this.labelFactionName.Size = new System.Drawing.Size(243, 32);
            this.labelFactionName.TabIndex = 1;
            this.labelFactionName.Text = "Drowned Rat Trading Company [32]";
            this.labelFactionName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonDeclare
            // 
            this.buttonDeclare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonDeclare.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonDeclare.ForeColor = System.Drawing.Color.White;
            this.buttonDeclare.HighlightColor = System.Drawing.Color.Silver;
            this.buttonDeclare.Image = global::LcogClient.Properties.Resources.hostile;
            this.buttonDeclare.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDeclare.Location = new System.Drawing.Point(453, 2);
            this.buttonDeclare.Margin = new System.Windows.Forms.Padding(20, 5, 5, 5);
            this.buttonDeclare.Name = "buttonDeclare";
            this.buttonDeclare.Size = new System.Drawing.Size(139, 38);
            this.buttonDeclare.TabIndex = 3;
            this.buttonDeclare.Text = "Declare Hostile";
            this.buttonDeclare.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDeclare.UseVisualStyleBackColor = false;
            this.buttonDeclare.Click += new System.EventHandler(this.buttonDeclare_Click);
            // 
            // labelShips
            // 
            this.labelShips.BackColor = System.Drawing.Color.Transparent;
            this.labelShips.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShips.ForeColor = System.Drawing.Color.White;
            this.labelShips.Location = new System.Drawing.Point(401, 5);
            this.labelShips.Margin = new System.Windows.Forms.Padding(0);
            this.labelShips.Name = "labelShips";
            this.labelShips.Size = new System.Drawing.Size(32, 32);
            this.labelShips.TabIndex = 13;
            this.labelShips.Text = "5";
            this.labelShips.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxShips
            // 
            this.pictureBoxShips.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxShips.Image = global::LcogClient.Properties.Resources.ship;
            this.pictureBoxShips.Location = new System.Drawing.Point(369, 5);
            this.pictureBoxShips.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.pictureBoxShips.Name = "pictureBoxShips";
            this.pictureBoxShips.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxShips.TabIndex = 12;
            this.pictureBoxShips.TabStop = false;
            // 
            // labelPlanets
            // 
            this.labelPlanets.BackColor = System.Drawing.Color.Transparent;
            this.labelPlanets.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlanets.ForeColor = System.Drawing.Color.White;
            this.labelPlanets.Location = new System.Drawing.Point(332, 5);
            this.labelPlanets.Margin = new System.Windows.Forms.Padding(0);
            this.labelPlanets.Name = "labelPlanets";
            this.labelPlanets.Size = new System.Drawing.Size(32, 32);
            this.labelPlanets.TabIndex = 11;
            this.labelPlanets.Text = "51";
            this.labelPlanets.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxPlanets
            // 
            this.pictureBoxPlanets.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPlanets.Image = global::LcogClient.Properties.Resources.planet;
            this.pictureBoxPlanets.Location = new System.Drawing.Point(300, 5);
            this.pictureBoxPlanets.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.pictureBoxPlanets.Name = "pictureBoxPlanets";
            this.pictureBoxPlanets.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxPlanets.TabIndex = 10;
            this.pictureBoxPlanets.TabStop = false;
            // 
            // FactionDiplomacy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LcogClient.Properties.Resources.background_faction;
            this.Controls.Add(this.labelShips);
            this.Controls.Add(this.pictureBoxShips);
            this.Controls.Add(this.labelPlanets);
            this.Controls.Add(this.pictureBoxPlanets);
            this.Controls.Add(this.buttonDeclare);
            this.Controls.Add(this.labelFactionName);
            this.Controls.Add(this.pictureBoxDiplomacy);
            this.Name = "FactionDiplomacy";
            this.Size = new System.Drawing.Size(600, 42);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDiplomacy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShips)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlanets)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxDiplomacy;
        private System.Windows.Forms.Label labelFactionName;
        private Button buttonDeclare;
        private System.Windows.Forms.Label labelShips;
        private System.Windows.Forms.PictureBox pictureBoxShips;
        private System.Windows.Forms.Label labelPlanets;
        private System.Windows.Forms.PictureBox pictureBoxPlanets;
    }
}
