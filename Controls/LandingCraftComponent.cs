using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

using LcogClient.Model;

namespace LcogClient.Controls
{
    public partial class LandingCraftComponent : Base
    {
        public Model.MapObject MapObject { get; set; }
        public bool IsBuild { get; set; }

        public LandingCraftComponent()
        {
            InitializeComponent();
        }

        public LandingCraftComponent(Model.MapObject obj, bool isBuild)
        {
            InitializeComponent();

            this.MapObject = obj;
            this.IsBuild = isBuild;

            ToolTip tt = new ToolTip();
            tt.SetToolTip(this.pictureBoxLandingCraft, "Landing craft component");

            this.buttonCancelColonise.Image = LcogClient.Utility.LcogImage.Resize(this.buttonCancelColonise.Image, 16, 16);
            this.pictureBoxLandingCraft.Image = LcogClient.Utility.LcogImage.Resize(this.pictureBoxLandingCraft.Image, 24, 24);
            this.UpdateView();
        }

        private void UpdateView()
        {
            Model.MapObject obj = this.MapObject;

            this.labelLandingCraft.Text = this.MapObject.Components.GetComponentCount("landing craft").ToString();

            if (obj.HasColoniseOrder())
            {
                this.buttonColonise.Visible = false;
                this.buttonCancelColonise.Visible = true;
                this.labelColonise.Visible = true;
                this.labelColonise.Text = "Colonising " + Client.Instance.Map.GetPlanetAtLocation(obj.Location).Name;
            }
            else if (Client.Instance.Map.GetPlanetAtLocation(obj.Location) != null)
            {
                Planet p = Client.Instance.Map.GetPlanetAtLocation(obj.Location);

                if (p.Faction != obj.Faction)
                {
                    this.labelColonise.Visible = false;
                    this.buttonCancelColonise.Visible = false;
                    this.buttonColonise.Visible = true;
                }
                else
                {
                    this.labelColonise.Visible = false;
                    this.buttonCancelColonise.Visible = false;
                    this.buttonColonise.Visible = false;
                }
            }
            else
            {
                this.labelColonise.Visible = false;
                this.buttonCancelColonise.Visible = false;
                this.buttonColonise.Visible = false;
            }
            if (this.IsBuild)
            {
                this.labelColonise.Visible = false;
                this.buttonCancelColonise.Visible = false;
                this.buttonColonise.Visible = false;
                this.Width = 70;
            }
        }

        private void buttonColonise_Click(object sender, EventArgs e)
        {
            Model.Orders.Colonise colonise = new Model.Orders.Colonise((Ship)Client.Instance.Selected);
            Client.Instance.Player.Orders.AddColoniseOrder(colonise);
            this.UpdateView();
        }

        private void buttonCancelColonise_Click(object sender, EventArgs e)
        {
            Client.Instance.Player.Orders.CancelColonise((Ship)Client.Instance.Selected);
            this.UpdateView();
        }
    }
}
