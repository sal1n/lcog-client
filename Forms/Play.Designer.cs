namespace LcogClient.Forms
{
    partial class Play
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
            this.cycleObjects1 = new LcogClient.Controls.CycleObjects();
            this.mapObject1 = new LcogClient.Controls.MapObject();
            this.map1 = new LcogClient.Controls.Map();
            this.otherObjects1 = new LcogClient.Controls.OtherObjects();
            this.faction1 = new LcogClient.Controls.Faction();
            this.SuspendLayout();
            // 
            // cycleObjects1
            // 
            this.cycleObjects1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cycleObjects1.Location = new System.Drawing.Point(39, 105);
            this.cycleObjects1.Margin = new System.Windows.Forms.Padding(5);
            this.cycleObjects1.Name = "cycleObjects1";
            this.cycleObjects1.Size = new System.Drawing.Size(248, 36);
            this.cycleObjects1.TabIndex = 1;
            // 
            // mapObject1
            // 
            this.mapObject1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mapObject1.Location = new System.Drawing.Point(14, 151);
            this.mapObject1.Margin = new System.Windows.Forms.Padding(5);
            this.mapObject1.Name = "mapObject1";
            this.mapObject1.Size = new System.Drawing.Size(300, 426);
            this.mapObject1.TabIndex = 2;
            // 
            // map1
            // 
            this.map1.BackColor = System.Drawing.Color.Black;
            this.map1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.map1.Location = new System.Drawing.Point(324, 105);
            this.map1.Margin = new System.Windows.Forms.Padding(5);
            this.map1.Name = "map1";
            this.map1.Size = new System.Drawing.Size(650, 650);
            this.map1.TabIndex = 4;
            // 
            // otherObjects1
            // 
            this.otherObjects1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otherObjects1.Location = new System.Drawing.Point(14, 587);
            this.otherObjects1.Margin = new System.Windows.Forms.Padding(5);
            this.otherObjects1.Name = "otherObjects1";
            this.otherObjects1.Size = new System.Drawing.Size(300, 170);
            this.otherObjects1.TabIndex = 5;
            // 
            // faction1
            // 
            this.faction1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.faction1.Location = new System.Drawing.Point(14, 14);
            this.faction1.Margin = new System.Windows.Forms.Padding(5);
            this.faction1.Name = "faction1";
            this.faction1.Size = new System.Drawing.Size(950, 81);
            this.faction1.TabIndex = 6;
            // 
            // Play
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 764);
            this.Controls.Add(this.faction1);
            this.Controls.Add(this.otherObjects1);
            this.Controls.Add(this.map1);
            this.Controls.Add(this.mapObject1);
            this.Controls.Add(this.cycleObjects1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Play";
            this.Text = "Play    |    Lost Colonies of Guernsey";
            this.ResumeLayout(false);

        }

        #endregion

        private LcogClient.Controls.CycleObjects cycleObjects1;
        private LcogClient.Controls.MapObject mapObject1;
        private LcogClient.Controls.Map map1;
        private LcogClient.Controls.OtherObjects otherObjects1;
        private LcogClient.Controls.Faction faction1;

    }
}