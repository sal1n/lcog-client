namespace LcogClient.Controls
{
    partial class FactoryComponent
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
            this.labelFactories = new System.Windows.Forms.Label();
            this.pictureBoxFactory = new System.Windows.Forms.PictureBox();
            this.labelBuild = new System.Windows.Forms.Label();
            this.buttonCancelBuild = new LcogClient.Controls.Button();
            this.buttonBuild = new LcogClient.Controls.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFactory)).BeginInit();
            this.SuspendLayout();
            // 
            // labelFactories
            // 
            this.labelFactories.Location = new System.Drawing.Point(0, 0);
            this.labelFactories.Margin = new System.Windows.Forms.Padding(0);
            this.labelFactories.Name = "labelFactories";
            this.labelFactories.Size = new System.Drawing.Size(24, 24);
            this.labelFactories.TabIndex = 5;
            this.labelFactories.Text = "1";
            this.labelFactories.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelFactories.Click += new System.EventHandler(this.labelFactories_Click);
            // 
            // pictureBoxFactory
            // 
            this.pictureBoxFactory.Image = global::LcogClient.Properties.Resources.factory;
            this.pictureBoxFactory.Location = new System.Drawing.Point(24, 0);
            this.pictureBoxFactory.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxFactory.Name = "pictureBoxFactory";
            this.pictureBoxFactory.Size = new System.Drawing.Size(24, 24);
            this.pictureBoxFactory.TabIndex = 4;
            this.pictureBoxFactory.TabStop = false;
            // 
            // labelBuild
            // 
            this.labelBuild.Location = new System.Drawing.Point(54, 0);
            this.labelBuild.Margin = new System.Windows.Forms.Padding(0);
            this.labelBuild.Name = "labelBuild";
            this.labelBuild.Size = new System.Drawing.Size(175, 24);
            this.labelBuild.TabIndex = 19;
            this.labelBuild.Text = "Building / Upgrading";
            this.labelBuild.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelBuild.Click += new System.EventHandler(this.labelBuild_Click);
            // 
            // buttonCancelBuild
            // 
            this.buttonCancelBuild.BaseColor = System.Drawing.SystemColors.Control;
            this.buttonCancelBuild.HighlightColor = System.Drawing.Color.Khaki;
            this.buttonCancelBuild.Image = global::LcogClient.Properties.Resources.cancel;
            this.buttonCancelBuild.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancelBuild.Location = new System.Drawing.Point(231, 0);
            this.buttonCancelBuild.Margin = new System.Windows.Forms.Padding(5);
            this.buttonCancelBuild.Name = "buttonCancelBuild";
            this.buttonCancelBuild.Size = new System.Drawing.Size(24, 24);
            this.buttonCancelBuild.TabIndex = 20;
            this.buttonCancelBuild.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCancelBuild.UseVisualStyleBackColor = false;
            this.buttonCancelBuild.Click += new System.EventHandler(this.buttonCancelBuild_Click);
            // 
            // buttonBuild
            // 
            this.buttonBuild.BaseColor = System.Drawing.SystemColors.Control;
            this.buttonBuild.HighlightColor = System.Drawing.Color.Khaki;
            this.buttonBuild.Image = global::LcogClient.Properties.Resources.build;
            this.buttonBuild.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBuild.Location = new System.Drawing.Point(54, 0);
            this.buttonBuild.Margin = new System.Windows.Forms.Padding(0);
            this.buttonBuild.Name = "buttonBuild";
            this.buttonBuild.Size = new System.Drawing.Size(78, 24);
            this.buttonBuild.TabIndex = 18;
            this.buttonBuild.Text = "Build";
            this.buttonBuild.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonBuild.UseVisualStyleBackColor = false;
            this.buttonBuild.Click += new System.EventHandler(this.buttonBuild_Click);
            // 
            // FactoryComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonCancelBuild);
            this.Controls.Add(this.labelBuild);
            this.Controls.Add(this.buttonBuild);
            this.Controls.Add(this.labelFactories);
            this.Controls.Add(this.pictureBoxFactory);
            this.Name = "FactoryComponent";
            this.Size = new System.Drawing.Size(260, 24);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFactory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelFactories;
        private System.Windows.Forms.PictureBox pictureBoxFactory;
        private Button buttonCancelBuild;
        private System.Windows.Forms.Label labelBuild;
        private Button buttonBuild;
    }
}
