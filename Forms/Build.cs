using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

using LcogClient.Forms;
using LcogClient.Controls;
using LcogClient.Model;

namespace LcogClient.Forms
{
    public partial class Build : Base
    {
        enum Target
        {
            NewShip,
            Upgrade,
            UpgradeShip,
            UpgradePlanet
        }

        private bool isPlanet = false;

        private Target target;
        private Model.MapObject targetObj;
        private Model.Collections.Components newComponents;

        private Image GetImage(string component)
        {
            Bitmap image = new Bitmap(16, 16);
            Bitmap icon = new Bitmap(32, 32);

            if (component== "factory")
            {
                icon = global::LcogClient.Properties.Resources.factory;
            }
            else if (component == "engine")
            {
                icon = global::LcogClient.Properties.Resources.engine;
            }
            else if (component == "lab")
            {
                icon = global::LcogClient.Properties.Resources.light_bulb;
            }
            else if (component == "landing craft")
            {
                icon = global::LcogClient.Properties.Resources.landing_craft;
            }
            else if (component == "beam")
            {
                icon = global::LcogClient.Properties.Resources.beam;
            }
            else if (component == "shield")
            {
                icon = global::LcogClient.Properties.Resources.shield;
            }
            else if (component == "torpedo")
            {
                icon = global::LcogClient.Properties.Resources.torpedo;
            }
            else if (component == "steel plating")
            {
                icon = global::LcogClient.Properties.Resources.steel_plate;
            }

            using (Graphics g = Graphics.FromImage(image))
            {
                g.DrawImage(icon, 0, 0, 16, 16);
            }

            return image;
        }

        public Build()
        {
            InitializeComponent();

            this.componentsFactory.MapObject = Client.Instance.Selected;

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

                    b.Image = this.GetImage(c.Name);
                    b.ImageAlign = ContentAlignment.MiddleLeft;
                    b.Text = c.Name;
                    b.Name = c.Name;
                    b.Click += new EventHandler(componentButton_Click);
                    b.Width = 168;
                    this.flowLayoutPanel.Controls.Add(b);
                }
            }

            // build new ship by default
            this.buttonBuildNewShip_Click(this, EventArgs.Empty);

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

            if (this.target == Target.Upgrade)
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
            }
            else
            {
                this.labelTarget.Text = "Upgrade";
                this.labelTargetID.Visible = true;
                this.labelTargetID.Text = this.targetObj.ID.ToString();
                this.textBoxTargetName.Text = this.targetObj.Name;
                this.pictureBoxTarget.Image = this.targetObj.Image;
                this.componentsTarget.MapObject = this.targetObj;
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

        private void buttonUpgrade_Click(object sender, EventArgs e)
        {
            this.target = Target.Upgrade;

            if (Client.Instance.Map.GetAllOthersAtLocation(Client.Instance.Selected).Count > 0)
            {
                Select form = new Select("Select object to upgrade", Client.Instance.Map.GetAllAtLocation(Client.Instance.Selected.Location));
                form.ShowDialog();
                this.newComponents = new LcogClient.Model.Collections.Components();
                this.targetObj = Client.Instance.Target.Clone();
                if (Client.Instance.Target.GetType() == typeof(Planet))
                {
                    this.isPlanet = true;
                }
                else
                {
                    this.isPlanet = false;
                }
            }
            else
            {
                this.newComponents = new LcogClient.Model.Collections.Components();
                this.targetObj = Client.Instance.Selected.Clone();
                if (Client.Instance.Selected.GetType() == typeof(Planet))
                {
                    this.isPlanet = true;
                }
                else
                {
                    this.isPlanet = false;
                }
            }
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
                Model.Orders.Upgrade upgrade = new LcogClient.Model.Orders.Upgrade(Client.Instance.Selected, this.targetObj, this.newComponents, this.isPlanet);
                Client.Instance.Player.Orders.AddUpgradeOrder(upgrade);
            }
            //Client.Instance.UpdateView();
            this.Close();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            if (this.target == Target.NewShip)
            {
                this.targetObj = new Ship();
            }
            else
            {
                this.newComponents = new LcogClient.Model.Collections.Components();
                this.targetObj = Client.Instance.Target.Clone();
            }
            this.UpdateView();
        }

        private void components2_Load(object sender, EventArgs e)
        {

        }
    }
}
