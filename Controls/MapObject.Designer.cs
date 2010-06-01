namespace LcogClient.Controls
{
    partial class MapObject
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
            this.componentsControl = new LcogClient.Controls.Components();
            this.buttonOthers = new LcogClient.Controls.Button();
            this.labelEnergy = new System.Windows.Forms.Label();
            this.pictureBoxEnergy = new System.Windows.Forms.PictureBox();
            this.labelFactionName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelObjectID = new System.Windows.Forms.Label();
            this.textBoxObjectName = new System.Windows.Forms.TextBox();
            this.pictureBoxObject = new System.Windows.Forms.PictureBox();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEnergy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxObject)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.componentsControl);
            this.groupBox.Controls.Add(this.buttonOthers);
            this.groupBox.Controls.Add(this.labelEnergy);
            this.groupBox.Controls.Add(this.pictureBoxEnergy);
            this.groupBox.Controls.Add(this.labelFactionName);
            this.groupBox.Controls.Add(this.panel1);
            this.groupBox.Controls.Add(this.labelObjectID);
            this.groupBox.Controls.Add(this.textBoxObjectName);
            this.groupBox.Controls.Add(this.pictureBoxObject);
            this.groupBox.Location = new System.Drawing.Point(0, 0);
            this.groupBox.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox.Name = "groupBox";
            this.groupBox.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox.Size = new System.Drawing.Size(300, 538);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            // 
            // componentsControl
            // 
            this.componentsControl.BuildScreen = false;
            this.componentsControl.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.componentsControl.Location = new System.Drawing.Point(10, 143);
            this.componentsControl.MapObject = null;
            this.componentsControl.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.componentsControl.Name = "componentsControl";
            this.componentsControl.Size = new System.Drawing.Size(282, 385);
            this.componentsControl.TabIndex = 18;
            // 
            // buttonOthers
            // 
            this.buttonOthers.BaseColor = System.Drawing.SystemColors.Control;
            this.buttonOthers.HighlightColor = System.Drawing.Color.Khaki;
            this.buttonOthers.Location = new System.Drawing.Point(10, 115);
            this.buttonOthers.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.buttonOthers.Name = "buttonOthers";
            this.buttonOthers.Size = new System.Drawing.Size(282, 23);
            this.buttonOthers.TabIndex = 17;
            this.buttonOthers.Text = "4 others at this location - View";
            this.buttonOthers.UseVisualStyleBackColor = false;
            this.buttonOthers.Click += new System.EventHandler(this.buttonOthers_Click);
            // 
            // labelEnergy
            // 
            this.labelEnergy.Location = new System.Drawing.Point(252, 77);
            this.labelEnergy.Margin = new System.Windows.Forms.Padding(5);
            this.labelEnergy.Name = "labelEnergy";
            this.labelEnergy.Size = new System.Drawing.Size(43, 32);
            this.labelEnergy.TabIndex = 14;
            this.labelEnergy.Text = "50021";
            this.labelEnergy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxEnergy
            // 
            this.pictureBoxEnergy.Image = global::LcogClient.Properties.Resources.energy;
            this.pictureBoxEnergy.Location = new System.Drawing.Point(217, 77);
            this.pictureBoxEnergy.Name = "pictureBoxEnergy";
            this.pictureBoxEnergy.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxEnergy.TabIndex = 13;
            this.pictureBoxEnergy.TabStop = false;
            // 
            // labelFactionName
            // 
            this.labelFactionName.Location = new System.Drawing.Point(10, 77);
            this.labelFactionName.Margin = new System.Windows.Forms.Padding(5);
            this.labelFactionName.Name = "labelFactionName";
            this.labelFactionName.Size = new System.Drawing.Size(213, 32);
            this.labelFactionName.TabIndex = 4;
            this.labelFactionName.Text = "The Drowned Rat Trading Company";
            this.labelFactionName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(10, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(282, 5);
            this.panel1.TabIndex = 3;
            // 
            // labelObjectID
            // 
            this.labelObjectID.Location = new System.Drawing.Point(260, 31);
            this.labelObjectID.Name = "labelObjectID";
            this.labelObjectID.Size = new System.Drawing.Size(35, 17);
            this.labelObjectID.TabIndex = 2;
            this.labelObjectID.Text = "ID#";
            this.labelObjectID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxObjectName
            // 
            this.textBoxObjectName.Location = new System.Drawing.Point(52, 30);
            this.textBoxObjectName.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxObjectName.Name = "textBoxObjectName";
            this.textBoxObjectName.Size = new System.Drawing.Size(200, 21);
            this.textBoxObjectName.TabIndex = 1;
            this.textBoxObjectName.Text = "Don\'t Blame Me I Voted Cromwell";
            // 
            // pictureBoxObject
            // 
            this.pictureBoxObject.Location = new System.Drawing.Point(10, 24);
            this.pictureBoxObject.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBoxObject.Name = "pictureBoxObject";
            this.pictureBoxObject.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxObject.TabIndex = 0;
            this.pictureBoxObject.TabStop = false;
            // 
            // MapObject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "MapObject";
            this.Size = new System.Drawing.Size(300, 538);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEnergy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxObject)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label labelFactionName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelObjectID;
        private System.Windows.Forms.TextBox textBoxObjectName;
        private System.Windows.Forms.PictureBox pictureBoxObject;
        private System.Windows.Forms.PictureBox pictureBoxEnergy;
        private System.Windows.Forms.Label labelEnergy;
        private Button buttonOthers;
        private Components componentsControl;
    }
}
