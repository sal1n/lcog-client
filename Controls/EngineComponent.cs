using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

using LcogClient.Model;

namespace LcogClient.Controls
{
    public partial class EngineComponent : Base
    {
        public Model.MapObject MapObject { get; set; }
        public bool IsBuild { get; set; }

        public EngineComponent()
        {
            InitializeComponent();
        }

        public EngineComponent(Model.MapObject obj, bool isBuild)
        {
            InitializeComponent();

            this.MapObject = obj;
            this.IsBuild = isBuild;

            ToolTip tt = new ToolTip();
            tt.SetToolTip(this.pictureBoxEngines, "Engine component");

            this.pictureBoxEngines.Image = LcogClient.Utility.LcogImage.Resize(this.pictureBoxEngines.Image, 24, 24);
            this.buttonCancelMove.Image = LcogClient.Utility.LcogImage.Resize(this.buttonCancelMove.Image, 16, 16);
            this.UpdateView();
        }

        private void UpdateView()
        {
            Model.MapObject obj = this.MapObject;

            this.labelEngines.Text = this.MapObject.Components.GetComponentCount("engine").ToString();

            if (obj.HasMoveOrder())
            {
                this.labelMove.Visible = true;
                this.buttonCancelMove.Visible = true;
                this.labelMove.Text = "Move to " + Client.Instance.Map.GetPlanetAtLocation(Client.Instance.Player.Orders.GetMoveOrder(obj).Waypoint).Name;
            }
            else if (obj.HasInterceptOrder())
            {
                this.labelMove.Visible = true;
                this.buttonCancelMove.Visible = true;
                this.labelMove.Text = "Intercept " + Client.Instance.Player.Orders.GetInterceptOrder(obj).Target.Name;
            }
            else
            {
                this.labelMove.Text = obj.MaxMove.ToString() + " Light Years / Turn";
                //this.labelMove.Visible = false;
                this.buttonCancelMove.Visible = false;
            }

            if (this.IsBuild)
            {
                this.labelMove.Visible = false;
                this.buttonCancelMove.Visible = false;
                this.Width = 70;
            }
        }

        private void buttonCancelMove_Click(object sender, EventArgs e)
        {
            Client.Instance.Player.Orders.CancelMove((Ship)Client.Instance.Selected);
            Client.Instance.UpdateView();
        }

        private void labelEngines_Click(object sender, EventArgs e)
        {

        }
    }
}
