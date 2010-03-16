using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

using LcogClient.Model;

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

            foreach (Model.Component component in this.MapObject.Components.GetDistinctComponents())
            {
                Label c = new Label();
                c.Text = component.Name + " [" + this.MapObject.Components.GetComponentCount(component.Name).ToString() + "]";
                c.TextAlign = ContentAlignment.MiddleLeft;
                c.Width = 117;
                this.flowLayoutPanel.Controls.Add(c);
            }
        }
    }
}
