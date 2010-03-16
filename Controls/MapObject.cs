using System;
using System.ComponentModel;
using System.Windows.Forms;

using LcogClient.Forms;
using LcogClient.Model;

namespace LcogClient.Controls
{
    public partial class MapObject : Base
    {
        public MapObject() : base()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Method used for handling explicit update events.
        /// </summary>
        public override void UpdateView(object source, EventArgs e)
        {
            Model.MapObject obj = Client.Instance.Selected;

                this.pictureBoxObject.Image = obj.Image;
                this.textBoxObjectName.Text = obj.Name;
                this.labelObjectID.Text = obj.ID.ToString();

                if (obj.Faction != null)
                {
                    this.labelFactionName.Text = obj.Faction.Name;
                    this.componentsControl.Visible = true;
                }
                else
                {
                    this.labelFactionName.Text = "Unclaimed";
                    this.componentsControl.Visible = false;
                }

                if (obj.GetType() == typeof(Planet))
                {
                    Planet p = (Planet)obj;
                    this.pictureBoxEnergy.Image = global::LcogClient.Properties.Resources.planet_energy;
                    this.labelEnergy.Text = p.Energy.ToString();
                    this.labelColonise.Visible = false;
                    this.buttonCancelColonise.Visible = false;
                }
                else
                {
                    this.pictureBoxEnergy.Image = global::LcogClient.Properties.Resources.damage;
                    Ship s = (Ship)obj;
                    this.labelEnergy.Text = s.Damage.ToString();
                }

                if (obj.Components.GetComponentByName("factory") != null)
                {
                    this.buttonBuild.Visible = true;
                }
                else
                {
                    this.buttonBuild.Visible = false;
                }

                if (obj.Components.GetComponentByName("landing craft") != null)
                {
                    this.buttonColonise.Visible = true;
                }
                else
                {
                    this.buttonColonise.Visible = false;
                }

                if (obj.HasBuildOrder())
                {
                    this.labelBuild.Visible = true;
                    this.labelBuild.Text = "Building a new ship";
                    this.buttonCancelBuild.Visible = true;
                }
                else
                {
                    this.labelBuild.Visible = false;
                    this.buttonCancelBuild.Visible = false;
                }

                if (obj.HasUpgradeOrder())
                {
                    this.labelBuild.Visible = true;
                    this.labelBuild.Text = "Upgrade " + Client.Instance.Player.Orders.GetUpgradeOrder(obj).Target.Name;
                    this.buttonCancelBuild.Visible = true;
                }


                if (obj.GetType() == typeof(Ship))
                {
                    Ship s = (Ship)obj;

                    Planet p = Client.Instance.Map.GetPlanetAtLocation(s.Location);

                    if (p != null && p.Faction != obj.Faction)
                    {
                        this.buttonColonise.Visible = true;
                    }
                    else
                    {
                        this.buttonColonise.Visible = false;
                    }
                    if (s.HasColoniseOrder())
                    {
                        this.labelColonise.Visible = true;
                        this.labelColonise.Text = "Colonise " + Client.Instance.Map.GetPlanetAtLocation(s.Location).Name;
                        this.buttonCancelColonise.Visible = true;
                    }
                    else
                    {
                        this.labelColonise.Visible = false;
                        this.buttonCancelColonise.Visible = false;
                    }
                }
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
                    this.labelMove.Visible = false;
                    this.buttonCancelMove.Visible = false;
                }
        }

        private void buttonBuild_Click(object sender, EventArgs e)
        {
            Forms.Build form = new Forms.Build();
            form.ShowDialog();
        }

        private void buttonColonise_Click(object sender, EventArgs e)
        {
            Model.Orders.Colonise colonise = new Model.Orders.Colonise((Ship)Client.Instance.Selected);
            Client.Instance.Player.Orders.AddColoniseOrder(colonise);
            Client.Instance.UpdateView();
        }

        private void buttonCancelBuild_Click(object sender, EventArgs e)
        {
            Client.Instance.Player.Orders.CancelBuild(Client.Instance.Selected);
            Client.Instance.UpdateView();
        }

        private void buttonCancelMove_Click(object sender, EventArgs e)
        {
            Client.Instance.Player.Orders.CancelMove((Ship)Client.Instance.Selected);
            Client.Instance.UpdateView();
        }

        private void buttonCancelColonise_Click(object sender, EventArgs e)
        {
            Client.Instance.Player.Orders.CancelColonise((Ship)Client.Instance.Selected);
            Client.Instance.UpdateView();
        }
    }
}
