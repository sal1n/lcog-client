using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

using LcogClient.Controls;
using LcogClient.Model;
using LcogClient.Utility;

namespace LcogClient.Controls
{
    public partial class Components : Base
    {
        public Model.MapObject MapObject { get; set; }
        public bool BuildScreen { get; set; }

        public Components() : base()
        {
            InitializeComponent();
            this.BuildScreen = false;
        }

        /// <summary>
        /// Method used for handling explicit update events.
        /// </summary>
        public override void UpdateView(object source, EventArgs e)
        {
            this.flowLayoutPanel.Controls.Clear();

            if (!this.BuildScreen)
            {
                this.MapObject = Client.Instance.Selected;
            }

            foreach (LcogClient.Controls.Base c in LcogComponentFactory.GetComponentControl(this.MapObject, this.BuildScreen))
            {
                this.flowLayoutPanel.Controls.Add(c);
            }
        }
    }
}
