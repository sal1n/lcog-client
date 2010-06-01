namespace LcogClient.Forms
{
    partial class Build
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
            this.labelFactionEnergy = new System.Windows.Forms.Label();
            this.labelTotalCost = new System.Windows.Forms.Label();
            this.buttonBuild = new LcogClient.Controls.Button();
            this.groupBoxFactory = new System.Windows.Forms.GroupBox();
            this.componentsFactory = new LcogClient.Controls.Components();
            this.labelObjectID = new System.Windows.Forms.Label();
            this.textBoxObjectName = new System.Windows.Forms.TextBox();
            this.pictureBoxObject = new System.Windows.Forms.PictureBox();
            this.buttonUpgrade = new LcogClient.Controls.Button();
            this.buttonBuildNewShip = new LcogClient.Controls.Button();
            this.groupBoxComponents = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBoxTarget = new System.Windows.Forms.GroupBox();
            this.componentsTarget = new LcogClient.Controls.Components();
            this.labelTargetID = new System.Windows.Forms.Label();
            this.textBoxTargetName = new System.Windows.Forms.TextBox();
            this.pictureBoxTarget = new System.Windows.Forms.PictureBox();
            this.buttonClear = new LcogClient.Controls.Button();
            this.labelTarget = new System.Windows.Forms.Label();
            this.groupBoxFactory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxObject)).BeginInit();
            this.groupBoxComponents.SuspendLayout();
            this.groupBoxTarget.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTarget)).BeginInit();
            this.SuspendLayout();
            // 
            // labelFactionEnergy
            // 
            this.labelFactionEnergy.Image = global::LcogClient.Properties.Resources.energy;
            this.labelFactionEnergy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelFactionEnergy.Location = new System.Drawing.Point(536, 510);
            this.labelFactionEnergy.Name = "labelFactionEnergy";
            this.labelFactionEnergy.Size = new System.Drawing.Size(73, 38);
            this.labelFactionEnergy.TabIndex = 18;
            this.labelFactionEnergy.Text = "123";
            this.labelFactionEnergy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelTotalCost
            // 
            this.labelTotalCost.Image = global::LcogClient.Properties.Resources.energy;
            this.labelTotalCost.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelTotalCost.Location = new System.Drawing.Point(702, 510);
            this.labelTotalCost.Name = "labelTotalCost";
            this.labelTotalCost.Size = new System.Drawing.Size(135, 38);
            this.labelTotalCost.TabIndex = 17;
            this.labelTotalCost.Text = "Total cost: 1234";
            this.labelTotalCost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonBuild
            // 
            this.buttonBuild.BaseColor = System.Drawing.SystemColors.Control;
            this.buttonBuild.HighlightColor = System.Drawing.Color.Khaki;
            this.buttonBuild.Image = global::LcogClient.Properties.Resources.build;
            this.buttonBuild.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBuild.Location = new System.Drawing.Point(761, 553);
            this.buttonBuild.Margin = new System.Windows.Forms.Padding(5);
            this.buttonBuild.Name = "buttonBuild";
            this.buttonBuild.Size = new System.Drawing.Size(78, 38);
            this.buttonBuild.TabIndex = 20;
            this.buttonBuild.Text = "Build";
            this.buttonBuild.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonBuild.UseVisualStyleBackColor = false;
            this.buttonBuild.Click += new System.EventHandler(this.buttonBuild_Click);
            // 
            // groupBoxFactory
            // 
            this.groupBoxFactory.Controls.Add(this.componentsFactory);
            this.groupBoxFactory.Controls.Add(this.labelObjectID);
            this.groupBoxFactory.Controls.Add(this.textBoxObjectName);
            this.groupBoxFactory.Controls.Add(this.pictureBoxObject);
            this.groupBoxFactory.Location = new System.Drawing.Point(12, 49);
            this.groupBoxFactory.Name = "groupBoxFactory";
            this.groupBoxFactory.Size = new System.Drawing.Size(298, 447);
            this.groupBoxFactory.TabIndex = 21;
            this.groupBoxFactory.TabStop = false;
            this.groupBoxFactory.Text = "Factory";
            // 
            // componentsFactory
            // 
            this.componentsFactory.BuildScreen = true;
            this.componentsFactory.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.componentsFactory.Location = new System.Drawing.Point(7, 53);
            this.componentsFactory.MapObject = null;
            this.componentsFactory.Margin = new System.Windows.Forms.Padding(0);
            this.componentsFactory.Name = "componentsFactory";
            this.componentsFactory.Size = new System.Drawing.Size(282, 385);
            this.componentsFactory.TabIndex = 6;
            // 
            // labelObjectID
            // 
            this.labelObjectID.Location = new System.Drawing.Point(257, 23);
            this.labelObjectID.Name = "labelObjectID";
            this.labelObjectID.Size = new System.Drawing.Size(35, 17);
            this.labelObjectID.TabIndex = 5;
            this.labelObjectID.Text = "ID#";
            this.labelObjectID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxObjectName
            // 
            this.textBoxObjectName.Location = new System.Drawing.Point(49, 22);
            this.textBoxObjectName.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxObjectName.Name = "textBoxObjectName";
            this.textBoxObjectName.ReadOnly = true;
            this.textBoxObjectName.Size = new System.Drawing.Size(200, 21);
            this.textBoxObjectName.TabIndex = 4;
            this.textBoxObjectName.Text = "Don\'t Blame Me I Voted Cromwell";
            // 
            // pictureBoxObject
            // 
            this.pictureBoxObject.Location = new System.Drawing.Point(7, 16);
            this.pictureBoxObject.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBoxObject.Name = "pictureBoxObject";
            this.pictureBoxObject.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxObject.TabIndex = 3;
            this.pictureBoxObject.TabStop = false;
            // 
            // buttonUpgrade
            // 
            this.buttonUpgrade.BaseColor = System.Drawing.SystemColors.Control;
            this.buttonUpgrade.HighlightColor = System.Drawing.Color.Khaki;
            this.buttonUpgrade.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUpgrade.Location = new System.Drawing.Point(164, 12);
            this.buttonUpgrade.Margin = new System.Windows.Forms.Padding(5);
            this.buttonUpgrade.Name = "buttonUpgrade";
            this.buttonUpgrade.Size = new System.Drawing.Size(140, 23);
            this.buttonUpgrade.TabIndex = 32;
            this.buttonUpgrade.Text = "Upgrade";
            this.buttonUpgrade.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonUpgrade.UseVisualStyleBackColor = false;
            this.buttonUpgrade.Click += new System.EventHandler(this.buttonUpgrade_Click);
            // 
            // buttonBuildNewShip
            // 
            this.buttonBuildNewShip.BaseColor = System.Drawing.SystemColors.Control;
            this.buttonBuildNewShip.HighlightColor = System.Drawing.Color.Khaki;
            this.buttonBuildNewShip.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBuildNewShip.Location = new System.Drawing.Point(20, 12);
            this.buttonBuildNewShip.Margin = new System.Windows.Forms.Padding(5);
            this.buttonBuildNewShip.Name = "buttonBuildNewShip";
            this.buttonBuildNewShip.Size = new System.Drawing.Size(140, 23);
            this.buttonBuildNewShip.TabIndex = 24;
            this.buttonBuildNewShip.Text = "Build new ship";
            this.buttonBuildNewShip.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonBuildNewShip.UseVisualStyleBackColor = false;
            this.buttonBuildNewShip.Click += new System.EventHandler(this.buttonBuildNewShip_Click);
            // 
            // groupBoxComponents
            // 
            this.groupBoxComponents.Controls.Add(this.flowLayoutPanel);
            this.groupBoxComponents.Location = new System.Drawing.Point(325, 12);
            this.groupBoxComponents.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.groupBoxComponents.Name = "groupBoxComponents";
            this.groupBoxComponents.Size = new System.Drawing.Size(200, 579);
            this.groupBoxComponents.TabIndex = 25;
            this.groupBoxComponents.TabStop = false;
            this.groupBoxComponents.Text = "Add Components";
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Location = new System.Drawing.Point(6, 20);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(188, 553);
            this.flowLayoutPanel.TabIndex = 0;
            // 
            // groupBoxTarget
            // 
            this.groupBoxTarget.Controls.Add(this.componentsTarget);
            this.groupBoxTarget.Controls.Add(this.labelTargetID);
            this.groupBoxTarget.Controls.Add(this.textBoxTargetName);
            this.groupBoxTarget.Controls.Add(this.pictureBoxTarget);
            this.groupBoxTarget.Location = new System.Drawing.Point(539, 49);
            this.groupBoxTarget.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.groupBoxTarget.Name = "groupBoxTarget";
            this.groupBoxTarget.Size = new System.Drawing.Size(298, 447);
            this.groupBoxTarget.TabIndex = 26;
            this.groupBoxTarget.TabStop = false;
            this.groupBoxTarget.Text = "Target";
            // 
            // componentsTarget
            // 
            this.componentsTarget.BuildScreen = true;
            this.componentsTarget.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.componentsTarget.Location = new System.Drawing.Point(7, 53);
            this.componentsTarget.MapObject = null;
            this.componentsTarget.Margin = new System.Windows.Forms.Padding(0);
            this.componentsTarget.Name = "componentsTarget";
            this.componentsTarget.Size = new System.Drawing.Size(282, 385);
            this.componentsTarget.TabIndex = 6;
            // 
            // labelTargetID
            // 
            this.labelTargetID.Location = new System.Drawing.Point(257, 23);
            this.labelTargetID.Name = "labelTargetID";
            this.labelTargetID.Size = new System.Drawing.Size(35, 17);
            this.labelTargetID.TabIndex = 5;
            this.labelTargetID.Text = "ID#";
            this.labelTargetID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxTargetName
            // 
            this.textBoxTargetName.Location = new System.Drawing.Point(49, 22);
            this.textBoxTargetName.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxTargetName.Name = "textBoxTargetName";
            this.textBoxTargetName.ReadOnly = true;
            this.textBoxTargetName.Size = new System.Drawing.Size(200, 21);
            this.textBoxTargetName.TabIndex = 4;
            this.textBoxTargetName.Text = "Don\'t Blame Me I Voted Cromwell";
            // 
            // pictureBoxTarget
            // 
            this.pictureBoxTarget.Location = new System.Drawing.Point(7, 16);
            this.pictureBoxTarget.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBoxTarget.Name = "pictureBoxTarget";
            this.pictureBoxTarget.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxTarget.TabIndex = 3;
            this.pictureBoxTarget.TabStop = false;
            // 
            // buttonClear
            // 
            this.buttonClear.BaseColor = System.Drawing.SystemColors.Control;
            this.buttonClear.HighlightColor = System.Drawing.Color.Khaki;
            this.buttonClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonClear.Location = new System.Drawing.Point(668, 553);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(5);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(83, 38);
            this.buttonClear.TabIndex = 30;
            this.buttonClear.Text = "Clear";
            this.buttonClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // labelTarget
            // 
            this.labelTarget.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTarget.Location = new System.Drawing.Point(536, 12);
            this.labelTarget.Margin = new System.Windows.Forms.Padding(5);
            this.labelTarget.Name = "labelTarget";
            this.labelTarget.Size = new System.Drawing.Size(303, 38);
            this.labelTarget.TabIndex = 31;
            this.labelTarget.Text = "Build a new ship";
            this.labelTarget.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Build
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 600);
            this.Controls.Add(this.buttonBuildNewShip);
            this.Controls.Add(this.buttonUpgrade);
            this.Controls.Add(this.labelTarget);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.groupBoxTarget);
            this.Controls.Add(this.groupBoxComponents);
            this.Controls.Add(this.groupBoxFactory);
            this.Controls.Add(this.buttonBuild);
            this.Controls.Add(this.labelFactionEnergy);
            this.Controls.Add(this.labelTotalCost);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Build";
            this.ShowInTaskbar = false;
            this.Text = "Build or Upgrade    |    Lost Colonies of Guernsey";
            this.groupBoxFactory.ResumeLayout(false);
            this.groupBoxFactory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxObject)).EndInit();
            this.groupBoxComponents.ResumeLayout(false);
            this.groupBoxTarget.ResumeLayout(false);
            this.groupBoxTarget.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTarget)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelFactionEnergy;
        private System.Windows.Forms.Label labelTotalCost;
        private LcogClient.Controls.Button buttonBuild;
        private System.Windows.Forms.GroupBox groupBoxFactory;
        private LcogClient.Controls.Button buttonBuildNewShip;
        private System.Windows.Forms.Label labelObjectID;
        private System.Windows.Forms.TextBox textBoxObjectName;
        private System.Windows.Forms.PictureBox pictureBoxObject;
        private System.Windows.Forms.GroupBox groupBoxComponents;
        private System.Windows.Forms.GroupBox groupBoxTarget;
        private System.Windows.Forms.Label labelTargetID;
        private System.Windows.Forms.TextBox textBoxTargetName;
        private System.Windows.Forms.PictureBox pictureBoxTarget;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private LcogClient.Controls.Button buttonClear;
        private System.Windows.Forms.Label labelTarget;
        private LcogClient.Controls.Button buttonUpgrade;
        private LcogClient.Controls.Components componentsFactory;
        private LcogClient.Controls.Components componentsTarget;
    }
}