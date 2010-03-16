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
            this.buttonCancelColonise = new LcogClient.Controls.Button();
            this.labelColonise = new System.Windows.Forms.Label();
            this.buttonColonise = new LcogClient.Controls.Button();
            this.buttonCancelMove = new LcogClient.Controls.Button();
            this.buttonCancelBuild = new LcogClient.Controls.Button();
            this.labelBuild = new System.Windows.Forms.Label();
            this.labelMove = new System.Windows.Forms.Label();
            this.labelEnergy = new System.Windows.Forms.Label();
            this.pictureBoxEnergy = new System.Windows.Forms.PictureBox();
            this.buttonBuild = new LcogClient.Controls.Button();
            this.componentsControl = new LcogClient.Controls.Components();
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
            this.groupBox.Controls.Add(this.buttonCancelColonise);
            this.groupBox.Controls.Add(this.labelColonise);
            this.groupBox.Controls.Add(this.buttonColonise);
            this.groupBox.Controls.Add(this.buttonCancelMove);
            this.groupBox.Controls.Add(this.buttonCancelBuild);
            this.groupBox.Controls.Add(this.labelBuild);
            this.groupBox.Controls.Add(this.labelMove);
            this.groupBox.Controls.Add(this.labelEnergy);
            this.groupBox.Controls.Add(this.pictureBoxEnergy);
            this.groupBox.Controls.Add(this.buttonBuild);
            this.groupBox.Controls.Add(this.componentsControl);
            this.groupBox.Controls.Add(this.labelFactionName);
            this.groupBox.Controls.Add(this.panel1);
            this.groupBox.Controls.Add(this.labelObjectID);
            this.groupBox.Controls.Add(this.textBoxObjectName);
            this.groupBox.Controls.Add(this.pictureBoxObject);
            this.groupBox.Location = new System.Drawing.Point(0, 0);
            this.groupBox.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox.Name = "groupBox";
            this.groupBox.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox.Size = new System.Drawing.Size(300, 426);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            // 
            // buttonCancelColonise
            // 
            this.buttonCancelColonise.BaseColor = System.Drawing.SystemColors.Control;
            this.buttonCancelColonise.HighlightColor = System.Drawing.Color.Khaki;
            this.buttonCancelColonise.Image = global::LcogClient.Properties.Resources.cancel;
            this.buttonCancelColonise.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancelColonise.Location = new System.Drawing.Point(252, 332);
            this.buttonCancelColonise.Margin = new System.Windows.Forms.Padding(5);
            this.buttonCancelColonise.Name = "buttonCancelColonise";
            this.buttonCancelColonise.Size = new System.Drawing.Size(38, 38);
            this.buttonCancelColonise.TabIndex = 21;
            this.buttonCancelColonise.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCancelColonise.UseVisualStyleBackColor = false;
            this.buttonCancelColonise.Click += new System.EventHandler(this.buttonCancelColonise_Click);
            // 
            // labelColonise
            // 
            this.labelColonise.Location = new System.Drawing.Point(101, 335);
            this.labelColonise.Margin = new System.Windows.Forms.Padding(5);
            this.labelColonise.Name = "labelColonise";
            this.labelColonise.Size = new System.Drawing.Size(151, 32);
            this.labelColonise.TabIndex = 20;
            this.labelColonise.Text = "Colonising Planet";
            this.labelColonise.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonColonise
            // 
            this.buttonColonise.BaseColor = System.Drawing.SystemColors.Control;
            this.buttonColonise.HighlightColor = System.Drawing.Color.Khaki;
            this.buttonColonise.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonColonise.Location = new System.Drawing.Point(13, 332);
            this.buttonColonise.Margin = new System.Windows.Forms.Padding(5);
            this.buttonColonise.Name = "buttonColonise";
            this.buttonColonise.Size = new System.Drawing.Size(78, 38);
            this.buttonColonise.TabIndex = 19;
            this.buttonColonise.Text = "Colonise";
            this.buttonColonise.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonColonise.UseVisualStyleBackColor = false;
            this.buttonColonise.Click += new System.EventHandler(this.buttonColonise_Click);
            // 
            // buttonCancelMove
            // 
            this.buttonCancelMove.BaseColor = System.Drawing.SystemColors.Control;
            this.buttonCancelMove.HighlightColor = System.Drawing.Color.Khaki;
            this.buttonCancelMove.Image = global::LcogClient.Properties.Resources.cancel;
            this.buttonCancelMove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancelMove.Location = new System.Drawing.Point(252, 380);
            this.buttonCancelMove.Margin = new System.Windows.Forms.Padding(5);
            this.buttonCancelMove.Name = "buttonCancelMove";
            this.buttonCancelMove.Size = new System.Drawing.Size(38, 38);
            this.buttonCancelMove.TabIndex = 18;
            this.buttonCancelMove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCancelMove.UseVisualStyleBackColor = false;
            this.buttonCancelMove.Click += new System.EventHandler(this.buttonCancelMove_Click);
            // 
            // buttonCancelBuild
            // 
            this.buttonCancelBuild.BaseColor = System.Drawing.SystemColors.Control;
            this.buttonCancelBuild.HighlightColor = System.Drawing.Color.Khaki;
            this.buttonCancelBuild.Image = global::LcogClient.Properties.Resources.cancel;
            this.buttonCancelBuild.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancelBuild.Location = new System.Drawing.Point(252, 284);
            this.buttonCancelBuild.Margin = new System.Windows.Forms.Padding(5);
            this.buttonCancelBuild.Name = "buttonCancelBuild";
            this.buttonCancelBuild.Size = new System.Drawing.Size(38, 38);
            this.buttonCancelBuild.TabIndex = 17;
            this.buttonCancelBuild.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCancelBuild.UseVisualStyleBackColor = false;
            this.buttonCancelBuild.Click += new System.EventHandler(this.buttonCancelBuild_Click);
            // 
            // labelBuild
            // 
            this.labelBuild.Location = new System.Drawing.Point(101, 287);
            this.labelBuild.Margin = new System.Windows.Forms.Padding(5);
            this.labelBuild.Name = "labelBuild";
            this.labelBuild.Size = new System.Drawing.Size(151, 32);
            this.labelBuild.TabIndex = 16;
            this.labelBuild.Text = "Building / Upgrading";
            this.labelBuild.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelMove
            // 
            this.labelMove.Location = new System.Drawing.Point(10, 380);
            this.labelMove.Margin = new System.Windows.Forms.Padding(5);
            this.labelMove.Name = "labelMove";
            this.labelMove.Size = new System.Drawing.Size(242, 38);
            this.labelMove.TabIndex = 15;
            this.labelMove.Text = "Moving to Xanadu (321, 321)";
            this.labelMove.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // buttonBuild
            // 
            this.buttonBuild.BaseColor = System.Drawing.SystemColors.Control;
            this.buttonBuild.HighlightColor = System.Drawing.Color.Khaki;
            this.buttonBuild.Image = global::LcogClient.Properties.Resources.build;
            this.buttonBuild.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBuild.Location = new System.Drawing.Point(13, 284);
            this.buttonBuild.Margin = new System.Windows.Forms.Padding(5);
            this.buttonBuild.Name = "buttonBuild";
            this.buttonBuild.Size = new System.Drawing.Size(78, 38);
            this.buttonBuild.TabIndex = 12;
            this.buttonBuild.Text = "Build";
            this.buttonBuild.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonBuild.UseVisualStyleBackColor = false;
            this.buttonBuild.Click += new System.EventHandler(this.buttonBuild_Click);
            // 
            // componentsControl
            // 
            this.componentsControl.BuildScreen = false;
            this.componentsControl.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.componentsControl.Location = new System.Drawing.Point(25, 117);
            this.componentsControl.MapObject = null;
            this.componentsControl.Margin = new System.Windows.Forms.Padding(5);
            this.componentsControl.Name = "componentsControl";
            this.componentsControl.Size = new System.Drawing.Size(250, 157);
            this.componentsControl.TabIndex = 5;
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
            this.Name = "MapObject";
            this.Size = new System.Drawing.Size(300, 426);
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
        private Components componentsControl;
        private System.Windows.Forms.PictureBox pictureBoxEnergy;
        private Button buttonBuild;
        private System.Windows.Forms.Label labelEnergy;
        private System.Windows.Forms.Label labelMove;
        private Button buttonCancelBuild;
        private System.Windows.Forms.Label labelBuild;
        private Button buttonCancelMove;
        private Button buttonCancelColonise;
        private System.Windows.Forms.Label labelColonise;
        private Button buttonColonise;
    }
}
