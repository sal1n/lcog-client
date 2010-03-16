namespace LcogClient.Controls
{
    partial class MoveObject
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.labelObjectName = new System.Windows.Forms.Label();
            this.labelFactionName = new System.Windows.Forms.Label();
            this.labelMassOrEnergy = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox.Location = new System.Drawing.Point(5, 5);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(32, 32);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // labelObjectName
            // 
            this.labelObjectName.BackColor = System.Drawing.Color.Transparent;
            this.labelObjectName.Location = new System.Drawing.Point(45, 5);
            this.labelObjectName.Name = "labelObjectName";
            this.labelObjectName.Size = new System.Drawing.Size(207, 32);
            this.labelObjectName.TabIndex = 1;
            this.labelObjectName.Text = "Map Object Name Goes Here [324]";
            this.labelObjectName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelFactionName
            // 
            this.labelFactionName.BackColor = System.Drawing.Color.Transparent;
            this.labelFactionName.Location = new System.Drawing.Point(45, 42);
            this.labelFactionName.Margin = new System.Windows.Forms.Padding(0);
            this.labelFactionName.Name = "labelFactionName";
            this.labelFactionName.Size = new System.Drawing.Size(207, 23);
            this.labelFactionName.TabIndex = 2;
            this.labelFactionName.Text = "Drowned Rat Trading [3]";
            this.labelFactionName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelMassOrEnergy
            // 
            this.labelMassOrEnergy.BackColor = System.Drawing.Color.Transparent;
            this.labelMassOrEnergy.Location = new System.Drawing.Point(5, 37);
            this.labelMassOrEnergy.Margin = new System.Windows.Forms.Padding(0);
            this.labelMassOrEnergy.Name = "labelMassOrEnergy";
            this.labelMassOrEnergy.Size = new System.Drawing.Size(37, 32);
            this.labelMassOrEnergy.TabIndex = 3;
            this.labelMassOrEnergy.Text = "1000";
            this.labelMassOrEnergy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OtherObject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelMassOrEnergy);
            this.Controls.Add(this.labelFactionName);
            this.Controls.Add(this.labelObjectName);
            this.Controls.Add(this.pictureBox);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "OtherObject";
            this.Size = new System.Drawing.Size(268, 70);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label labelObjectName;
        private System.Windows.Forms.Label labelFactionName;
        private System.Windows.Forms.Label labelMassOrEnergy;

    }
}
