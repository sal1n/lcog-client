namespace LcogClient.Controls
{
    partial class Message
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
            this.labelType = new System.Windows.Forms.Label();
            this.labelFrom = new System.Windows.Forms.Label();
            this.labelMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelType
            // 
            this.labelType.BackColor = System.Drawing.Color.Transparent;
            this.labelType.ForeColor = System.Drawing.Color.White;
            this.labelType.Location = new System.Drawing.Point(0, 0);
            this.labelType.Margin = new System.Windows.Forms.Padding(0);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(150, 16);
            this.labelType.TabIndex = 0;
            this.labelType.Text = "error";
            this.labelType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelFrom
            // 
            this.labelFrom.BackColor = System.Drawing.Color.Transparent;
            this.labelFrom.ForeColor = System.Drawing.Color.White;
            this.labelFrom.Location = new System.Drawing.Point(0, 16);
            this.labelFrom.Margin = new System.Windows.Forms.Padding(0);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(150, 16);
            this.labelFrom.TabIndex = 1;
            this.labelFrom.Text = "from host";
            this.labelFrom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelMessage
            // 
            this.labelMessage.BackColor = System.Drawing.Color.Transparent;
            this.labelMessage.ForeColor = System.Drawing.Color.White;
            this.labelMessage.Location = new System.Drawing.Point(150, 0);
            this.labelMessage.Margin = new System.Windows.Forms.Padding(0);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(450, 32);
            this.labelMessage.TabIndex = 2;
            this.labelMessage.Text = "from Our population has grown by 9 to 298 on Takamizawa";
            this.labelMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Message
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LcogClient.Properties.Resources.background_message;
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.labelFrom);
            this.Controls.Add(this.labelType);
            this.Name = "Message";
            this.Size = new System.Drawing.Size(600, 32);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.Label labelMessage;

    }
}
