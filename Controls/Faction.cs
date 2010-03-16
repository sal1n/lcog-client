using System;
using System.ComponentModel;
using System.Windows.Forms;

using LcogClient.Forms;
using LcogClient.Model;

namespace LcogClient.Controls
{
    public partial class Faction : Base
    {
        /// <summary>
        /// Default constructor.
        /// </summary>
        public Faction(): base()
        {
            InitializeComponent();
        }

        private void buttonMessages_Click(object sender, EventArgs e)
        {
            Messages form = new Messages();
            form.ShowDialog();
        }

        private void buttonTechnology_Click(object sender, EventArgs e)
        {
            Forms.Technology form = new Forms.Technology();
            form.ShowDialog();

        }

        private void buttonDiplomacy_Click(object sender, EventArgs e)
        {
            Diplomacy form = new Diplomacy();
            form.ShowDialog();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Utility.LcogIO.WriteOrders(Client.Instance.Player.Orders.ToXml(), "orders" + Client.Instance.Player.ID + ".xml");
            //MessageBox.Show("Your orders have been written to file, remember to upload them on the Menu screen.", "Message    |    Lost Colonies of Guernsey");
        }

        /// <summary>
        /// Method used for handling explicit update events.
        /// </summary>
        public override void UpdateView(object source, EventArgs e)
        {
            this.labelFactionName.Text = Client.Instance.Player.Faction.Name;
            this.labelTurnNumber.Text = "Turn " + Client.Instance.Player.Turn.ToString();
            this.labelEnergy.Text = Client.Instance.Player.Energy.ToString();
            this.labelPlanets.Text = Client.Instance.Player.Planets.Count.ToString();
            this.labelShips.Text = Client.Instance.Player.Ships.Count.ToString();
        }

        private void buttonOrders_Click(object sender, EventArgs e)
        {
            Orders form = new Orders();
            form.ShowDialog();
        }
    }
}
