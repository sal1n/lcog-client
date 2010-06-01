namespace LcogClient.Controls
{
    partial class EngineComponent
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
            this.labelEngines = new System.Windows.Forms.Label();
            this.pictureBoxEngines = new System.Windows.Forms.PictureBox();
            this.labelMove = new System.Windows.Forms.Label();
            this.buttonCancelMove = new LcogClient.Controls.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEngines)).BeginInit();
            this.SuspendLayout();
            // 
            // labelEngines
            // 
            this.labelEngines.Location = new System.Drawing.Point(0, 0);
            this.labelEngines.Margin = new System.Windows.Forms.Padding(0);
            this.labelEngines.Name = "labelEngines";
            this.labelEngines.Size = new System.Drawing.Size(24, 24);
            this.labelEngines.TabIndex = 9;
            this.labelEngines.Text = "1";
            this.labelEngines.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelEngines.Click += new System.EventHandler(this.labelEngines_Click);
            // 
            // pictureBoxEngines
            // 
            this.pictureBoxEngines.Image = global::LcogClient.Properties.Resources.engine;
            this.pictureBoxEngines.Location = new System.Drawing.Point(24, 0);
            this.pictureBoxEngines.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxEngines.Name = "pictureBoxEngines";
            this.pictureBoxEngines.Size = new System.Drawing.Size(24, 24);
            this.pictureBoxEngines.TabIndex = 8;
            this.pictureBoxEngines.TabStop = false;
            // 
            // labelMove
            // 
            this.labelMove.Location = new System.Drawing.Point(51, 0);
            this.labelMove.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.labelMove.Name = "labelMove";
            this.labelMove.Size = new System.Drawing.Size(175, 24);
            this.labelMove.TabIndex = 19;
            this.labelMove.Text = "Moving to Xanadu";
            this.labelMove.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonCancelMove
            // 
            this.buttonCancelMove.BaseColor = System.Drawing.SystemColors.Control;
            this.buttonCancelMove.HighlightColor = System.Drawing.Color.Khaki;
            this.buttonCancelMove.Image = global::LcogClient.Properties.Resources.cancel;
            this.buttonCancelMove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancelMove.Location = new System.Drawing.Point(231, 0);
            this.buttonCancelMove.Margin = new System.Windows.Forms.Padding(5);
            this.buttonCancelMove.Name = "buttonCancelMove";
            this.buttonCancelMove.Size = new System.Drawing.Size(24, 24);
            this.buttonCancelMove.TabIndex = 20;
            this.buttonCancelMove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCancelMove.UseVisualStyleBackColor = false;
            this.buttonCancelMove.Click += new System.EventHandler(this.buttonCancelMove_Click);
            // 
            // EngineComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonCancelMove);
            this.Controls.Add(this.labelMove);
            this.Controls.Add(this.labelEngines);
            this.Controls.Add(this.pictureBoxEngines);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 16, 5);
            this.Name = "EngineComponent";
            this.Size = new System.Drawing.Size(260, 24);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEngines)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelEngines;
        private System.Windows.Forms.PictureBox pictureBoxEngines;
        private Button buttonCancelMove;
        private System.Windows.Forms.Label labelMove;
    }
}
