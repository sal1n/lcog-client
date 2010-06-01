using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

using LcogClient.Model;
using LcogClient.Utility;

namespace LcogClient.Controls
{
    public partial class GenericComponent : Base
    {
        public GenericComponent()
        {
            InitializeComponent();
        }

        public GenericComponent(Bitmap image, string toolTip, string text)
        {
            InitializeComponent();

            this.pictureBox1.Image = image; // LcogImage.Resize(image, 16, 16);
            this.label1.Text = toolTip;
            this.label2.Text = text;
            ToolTip tt = new ToolTip();
            tt.SetToolTip(this.pictureBox1, toolTip);
        }
    }
}
