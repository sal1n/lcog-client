using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

using LcogClient.Controls;
using LcogClient.Model;

namespace LcogClient.Forms
{
    public partial class Build : Base
    {
        enum Target
        {
            NewShip,
            UpgradeShip,
            UpgradePlanet
        }

        private Target target;
        private Model.MapObject targetObj;
        private Model.Collections.Components newComponents;

        public Build()
        {
            InitializeComponent();

            this.labelFactionEnergy.Text = Client.Instance.Player.Energy.ToString();
            this.labelObjectID.Text = Client.Instance.Selected.ID.ToString();
            this.pictureBoxObject.Image = Client.Instance.Selected.Image;
            this.textBoxObjectName.Text = Client.Instance.Selected.Name;
            this.componentsFactory.UpdateView(this, EventArgs.Empty);

            foreach (Model.Component c in Client.Instance.Components)
            {
                if (Client.Instance.Player.Tech.HasTechnologyLevel(c.Tech))
                {
                    LcogClient.Controls.Button b = new LcogClient.Controls.Button();
                    b.Text = c.Name;
                    b.Name = c.Name;
                    b.Click += new EventHandler(componentButton_Click);
                    b.Width = 168;
                    this.flowLayoutPanel.Controls.Add(b);
                }
            }

            // build new ship by default
            this.buttonBuildNewShip_Click(this, EventArgs.Empty);

            if (Client.Instance.Selected.GetType() == typeof(Ship))
            {
                this.buttonUpgradeShip.Visible = true;

                if (Client.Instance.Map.GetPlanetAtLocation(Client.Instance.Selected.Location) != null)
                {
                    this.buttonUpgradePlanet.Visible = true;
                }
                else
                {
                    this.buttonUpgradePlanet.Visible = false;
                }
            }

            if (Client.Instance.Selected.GetType() == typeof(Planet))
            {
                this.buttonUpgradePlanet.Visible = true;
                this.buttonUpgradeShip.Visible = false;
            }
        }

        void componentButton_Click(object sender, EventArgs e)
        {
            LcogClient.Controls.Button b = (LcogClient.Controls.Button)sender;
            this.targetObj.Components.Add(Client.Instance.Components.GetComponentByName(b.Name));
            if (this.newComponents != null)
            {
                this.newComponents.Add(Client.Instance.Components.GetComponentByName(b.Name));
            }
            this.componentsTarget.UpdateView(this, EventArgs.Empty);
            this.CalculateCost();
        }

        private void CalculateCost()
        {
            int sum = 0;

            if (this.target == Target.UpgradePlanet || this.target == Target.UpgradeShip)
            {
                foreach (Model.Component c in this.newComponents)
                {
                    sum += c.Cost;
                }
            }
            else
            {
                foreach (Model.Component c in this.targetObj.Components)
                {
                    sum += c.Cost;
                }
            }
            this.labelTotalCost.Text = "Total cost: " + sum.ToString();
        }

        public override void UpdateView()
        {
            if (this.target == Target.NewShip)
            {
                this.labelTarget.Text = "Build a new ship";
                this.targetObj = new Ship();
                this.labelTargetID.Visible = false;
                this.textBoxTargetName.Text = "New ship";
                this.pictureBoxTarget.Image = global::LcogClient.Properties.Resources.ship;
                this.componentsTarget.MapObject = this.targetObj;
                this.buttonBuildNewShip.BackColor = Color.Khaki;
                this.buttonUpgradePlanet.BackColor = SystemColors.Control;
                this.buttonUpgradeShip.BackColor = SystemColors.Control;
            }
            else if (this.target == Target.UpgradePlanet)
            {
                this.labelTarget.Text = "Upgrade planet";
            }
            else
            {
                this.labelTarget.Text = "Upgrade ship";
            }
            this.CalculateCost();
            this.componentsTarget.UpdateView(this, EventArgs.Empty);
        }

        private void buttonBuildNewShip_Click(object sender, EventArgs e)
        {
            this.target = Target.NewShip;
            this.targetObj = new Ship();
            this.UpdateView();
        }

        private void buttonUpgradeShip_Click(object sender, EventArgs e)
        {
            this.target = Target.UpgradeShip;
            this.newComponents = new LcogClient.Model.Collections.Components();
            Ship s = (Ship)Client.Instance.Selected;
            this.targetObj = s.Clone();
            this.labelTargetID.Visible = true;
            this.labelTargetID.Text = this.targetObj.ID.ToString();
            this.textBoxTargetName.Text = this.targetObj.Name;
            this.pictureBoxTarget.Image = this.targetObj.Image;
            this.componentsTarget.MapObject = this.targetObj;
            this.UpdateView();
        }

        private void buttonUpgradePlanet_Click(object sender, EventArgs e)
        {
            this.target = Target.UpgradePlanet;
            this.newComponents = new LcogClient.Model.Collections.Components();
            Planet p = Client.Instance.Map.GetPlanetAtLocation(Client.Instance.Selected.Location);
            this.targetObj = p.Clone();
            this.labelTargetID.Visible = true;
            this.labelTargetID.Text = this.targetObj.ID.ToString();
            this.textBoxTargetName.Text = this.targetObj.Name;
            this.pictureBoxTarget.Image = this.targetObj.Image;
            this.componentsTarget.MapObject = this.targetObj;
            this.UpdateView();
        }

        private void buttonBuild_Click(object sender, EventArgs e)
        {
            if (this.target == Target.NewShip)
            {
                Model.Orders.Build build = new Model.Orders.Build(Client.Instance.Selected, this.targetObj.Components);
                Client.Instance.Player.Orders.AddBuildOrder(build);
            }
            else
            {
                Model.Orders.Upgrade upgrade = new LcogClient.Model.Orders.Upgrade(Client.Instance.Selected, this.targetObj, this.newComponents);
                Client.Instance.Player.Orders.AddUpgradeOrder(upgrade);
            }
            Client.Instance.UpdateView();
            this.Close();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            if (this.target == Target.NewShip)
            {
                this.buttonBuildNewShip_Click(this, EventArgs.Empty);
            }
            else if (this.target == Target.UpgradeShip)
            {
                this.buttonUpgradeShip_Click(this, EventArgs.Empty);
            }
            else
            {
                this.buttonUpgradePlanet_Click(this, EventArgs.Empty);
            }
        }
    }
}
