namespace LcogClient.Controls
{
    partial class Faction
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
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.buttonOrders = new LcogClient.Controls.Button();
            this.buttonTechnology = new LcogClient.Controls.Button();
            this.buttonSave = new LcogClient.Controls.Button();
            this.buttonDiplomacy = new LcogClient.Controls.Button();
            this.buttonMessages = new LcogClient.Controls.Button();
            this.labelShips = new System.Windows.Forms.Label();
            this.pictureBoxShips = new System.Windows.Forms.PictureBox();
            this.labelPlanets = new System.Windows.Forms.Label();
            this.pictureBoxPlanets = new System.Windows.Forms.PictureBox();
            this.labelEnergy = new System.Windows.Forms.Label();
            this.pictureBoxEnergy = new System.Windows.Forms.PictureBox();
            this.labelTurnNumber = new System.Windows.Forms.Label();
            this.labelFactionName = new System.Windows.Forms.Label();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShips)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlanets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEnergy)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.buttonOrders);
            this.groupBox.Controls.Add(this.buttonTechnology);
            this.groupBox.Controls.Add(this.buttonSave);
            this.groupBox.Controls.Add(this.buttonDiplomacy);
            this.groupBox.Controls.Add(this.buttonMessages);
            this.groupBox.Controls.Add(this.labelShips);
            this.groupBox.Controls.Add(this.pictureBoxShips);
            this.groupBox.Controls.Add(this.labelPlanets);
            this.groupBox.Controls.Add(this.pictureBoxPlanets);
            this.groupBox.Controls.Add(this.labelEnergy);
            this.groupBox.Controls.Add(this.pictureBoxEnergy);
            this.groupBox.Controls.Add(this.labelTurnNumber);
            this.groupBox.Controls.Add(this.labelFactionName);
            this.groupBox.Location = new System.Drawing.Point(0, 0);
            this.groupBox.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox.Name = "groupBox";
            this.groupBox.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox.Size = new System.Drawing.Size(950, 81);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Faction";
            // 
            // buttonOrders
            // 
            this.buttonOrders.BaseColor = System.Drawing.SystemColors.Control;
            this.buttonOrders.HighlightColor = System.Drawing.Color.Khaki;
            this.buttonOrders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOrders.Location = new System.Drawing.Point(754, 24);
            this.buttonOrders.Margin = new System.Windows.Forms.Padding(5);
            this.buttonOrders.Name = "buttonOrders";
            this.buttonOrders.Size = new System.Drawing.Size(86, 38);
            this.buttonOrders.TabIndex = 12;
            this.buttonOrders.Text = "Orders";
            this.buttonOrders.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonOrders.UseVisualStyleBackColor = false;
            this.buttonOrders.Click += new System.EventHandler(this.buttonOrders_Click);
            // 
            // buttonTechnology
            // 
            this.buttonTechnology.BaseColor = System.Drawing.SystemColors.Control;
            this.buttonTechnology.HighlightColor = System.Drawing.Color.Khaki;
            this.buttonTechnology.Image = global::LcogClient.Properties.Resources.cargo;
            this.buttonTechnology.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTechnology.Location = new System.Drawing.Point(484, 24);
            this.buttonTechnology.Margin = new System.Windows.Forms.Padding(5);
            this.buttonTechnology.Name = "buttonTechnology";
            this.buttonTechnology.Size = new System.Drawing.Size(125, 38);
            this.buttonTechnology.TabIndex = 11;
            this.buttonTechnology.Text = "Technology";
            this.buttonTechnology.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonTechnology.UseVisualStyleBackColor = false;
            this.buttonTechnology.Click += new System.EventHandler(this.buttonTechnology_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BaseColor = System.Drawing.SystemColors.Control;
            this.buttonSave.HighlightColor = System.Drawing.Color.Khaki;
            this.buttonSave.Image = global::LcogClient.Properties.Resources.save;
            this.buttonSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSave.Location = new System.Drawing.Point(850, 24);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(5);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(86, 38);
            this.buttonSave.TabIndex = 10;
            this.buttonSave.Text = "Save";
            this.buttonSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonDiplomacy
            // 
            this.buttonDiplomacy.BaseColor = System.Drawing.SystemColors.Control;
            this.buttonDiplomacy.HighlightColor = System.Drawing.Color.Khaki;
            this.buttonDiplomacy.Image = global::LcogClient.Properties.Resources.hostile;
            this.buttonDiplomacy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDiplomacy.Location = new System.Drawing.Point(619, 24);
            this.buttonDiplomacy.Margin = new System.Windows.Forms.Padding(5);
            this.buttonDiplomacy.Name = "buttonDiplomacy";
            this.buttonDiplomacy.Size = new System.Drawing.Size(125, 38);
            this.buttonDiplomacy.TabIndex = 9;
            this.buttonDiplomacy.Text = "Diplomacy";
            this.buttonDiplomacy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDiplomacy.UseVisualStyleBackColor = false;
            this.buttonDiplomacy.Click += new System.EventHandler(this.buttonDiplomacy_Click);
            // 
            // buttonMessages
            // 
            this.buttonMessages.BaseColor = System.Drawing.SystemColors.Control;
            this.buttonMessages.HighlightColor = System.Drawing.Color.Khaki;
            this.buttonMessages.Image = global::LcogClient.Properties.Resources.messages;
            this.buttonMessages.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMessages.Location = new System.Drawing.Point(349, 24);
            this.buttonMessages.Margin = new System.Windows.Forms.Padding(5);
            this.buttonMessages.Name = "buttonMessages";
            this.buttonMessages.Size = new System.Drawing.Size(125, 38);
            this.buttonMessages.TabIndex = 8;
            this.buttonMessages.Text = "Messages";
            this.buttonMessages.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonMessages.UseVisualStyleBackColor = false;
            this.buttonMessages.Click += new System.EventHandler(this.buttonMessages_Click);
            // 
            // labelShips
            // 
            this.labelShips.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShips.Location = new System.Drawing.Point(270, 48);
            this.labelShips.Margin = new System.Windows.Forms.Padding(0);
            this.labelShips.Name = "labelShips";
            this.labelShips.Size = new System.Drawing.Size(32, 17);
            this.labelShips.TabIndex = 7;
            this.labelShips.Text = "5";
            this.labelShips.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBoxShips
            // 
            this.pictureBoxShips.Image = global::LcogClient.Properties.Resources.ship;
            this.pictureBoxShips.Location = new System.Drawing.Point(270, 16);
            this.pictureBoxShips.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.pictureBoxShips.Name = "pictureBoxShips";
            this.pictureBoxShips.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxShips.TabIndex = 6;
            this.pictureBoxShips.TabStop = false;
            // 
            // labelPlanets
            // 
            this.labelPlanets.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlanets.Location = new System.Drawing.Point(218, 48);
            this.labelPlanets.Margin = new System.Windows.Forms.Padding(0);
            this.labelPlanets.Name = "labelPlanets";
            this.labelPlanets.Size = new System.Drawing.Size(32, 17);
            this.labelPlanets.TabIndex = 5;
            this.labelPlanets.Text = "51";
            this.labelPlanets.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBoxPlanets
            // 
            this.pictureBoxPlanets.Image = global::LcogClient.Properties.Resources.planet;
            this.pictureBoxPlanets.Location = new System.Drawing.Point(218, 16);
            this.pictureBoxPlanets.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.pictureBoxPlanets.Name = "pictureBoxPlanets";
            this.pictureBoxPlanets.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxPlanets.TabIndex = 4;
            this.pictureBoxPlanets.TabStop = false;
            // 
            // labelEnergy
            // 
            this.labelEnergy.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnergy.Location = new System.Drawing.Point(165, 48);
            this.labelEnergy.Margin = new System.Windows.Forms.Padding(0);
            this.labelEnergy.Name = "labelEnergy";
            this.labelEnergy.Size = new System.Drawing.Size(42, 17);
            this.labelEnergy.TabIndex = 3;
            this.labelEnergy.Text = "51211";
            this.labelEnergy.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBoxEnergy
            // 
            this.pictureBoxEnergy.Image = global::LcogClient.Properties.Resources.energy;
            this.pictureBoxEnergy.Location = new System.Drawing.Point(166, 16);
            this.pictureBoxEnergy.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxEnergy.Name = "pictureBoxEnergy";
            this.pictureBoxEnergy.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxEnergy.TabIndex = 2;
            this.pictureBoxEnergy.TabStop = false;
            // 
            // labelTurnNumber
            // 
            this.labelTurnNumber.Location = new System.Drawing.Point(10, 46);
            this.labelTurnNumber.Margin = new System.Windows.Forms.Padding(5);
            this.labelTurnNumber.Name = "labelTurnNumber";
            this.labelTurnNumber.Size = new System.Drawing.Size(150, 17);
            this.labelTurnNumber.TabIndex = 1;
            this.labelTurnNumber.Text = "Turn 13";
            this.labelTurnNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelFactionName
            // 
            this.labelFactionName.Location = new System.Drawing.Point(10, 24);
            this.labelFactionName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelFactionName.Name = "labelFactionName";
            this.labelFactionName.Size = new System.Drawing.Size(150, 17);
            this.labelFactionName.TabIndex = 0;
            this.labelFactionName.Text = "Drowned Rat Trading";
            this.labelFactionName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Faction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox);
            this.Name = "Faction";
            this.Size = new System.Drawing.Size(950, 81);
            this.groupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShips)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlanets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEnergy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label labelFactionName;
        private System.Windows.Forms.Label labelTurnNumber;
        private System.Windows.Forms.PictureBox pictureBoxEnergy;
        private System.Windows.Forms.Label labelEnergy;
        private System.Windows.Forms.Label labelShips;
        private System.Windows.Forms.PictureBox pictureBoxShips;
        private System.Windows.Forms.Label labelPlanets;
        private System.Windows.Forms.PictureBox pictureBoxPlanets;
        private Button buttonDiplomacy;
        private Button buttonMessages;
        private Button buttonSave;
        private Button buttonTechnology;
        private Button buttonOrders;
    }
}
