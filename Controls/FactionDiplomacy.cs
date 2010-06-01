using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

using LcogClient.Model;
using LcogClient.Model.Orders;

namespace LcogClient.Controls
{
    public partial class FactionDiplomacy : Base
    {
        private Model.Faction faction;

        public FactionDiplomacy(Model.Faction faction)
        {
            InitializeComponent();

            this.faction = faction;

            this.UpdateView();
        }

        private void UpdateView()
        {
            this.labelFactionName.Text = this.faction.Name + " [" + this.faction.ID.ToString() + "]";

            if (this.faction.Relations == "Neutral")
            {
                this.pictureBoxDiplomacy.Image = global::LcogClient.Properties.Resources.neutral;
                this.buttonDeclare.Image = global::LcogClient.Properties.Resources.hostile;
                this.buttonDeclare.Text = "Declare Enemy";
            }
            else if (this.faction.Relations == "Enemy")
            {
                this.pictureBoxDiplomacy.Image = global::LcogClient.Properties.Resources.hostile;
                this.buttonDeclare.Image = global::LcogClient.Properties.Resources.neutral;
                this.buttonDeclare.Text = "Declare Neutral";
            }

            this.labelPlanets.Text = this.faction.Planets.ToString();
            this.labelShips.Text = this.faction.Ships.ToString();
        }

        private void buttonDeclare_Click(object sender, EventArgs e)
        {
            if (this.faction.Relations == "Neutral")
            {
                Diplomacy order = new Diplomacy(this.faction, "Enemy");
                Client.Instance.Player.Orders.AddDiplomacyOrder(order);
                this.faction.Relations = "Enemy";
            }
            else
            {
                Diplomacy order = new Diplomacy(this.faction, "Neutral");
                Client.Instance.Player.Orders.AddDiplomacyOrder(order);
                this.faction.Relations = "Neutral";
            }
            this.UpdateView();
        }
    }
}
