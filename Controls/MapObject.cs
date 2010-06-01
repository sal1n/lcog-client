using System;
using System.ComponentModel;
using System.Windows.Forms;

using LcogClient.Forms;
using LcogClient.Model;
using LcogClient.Model.Orders;

namespace LcogClient.Controls
{
    public partial class MapObject : Base
    {
        public MapObject() : base()
        {
            InitializeComponent();
            this.textBoxObjectName.TextChanged += new EventHandler(textBoxObjectName_TextChanged);
        }

        void textBoxObjectName_TextChanged(object sender, EventArgs e)
        {
            if (Client.Instance.Selected.Name != this.textBoxObjectName.Text)
            {
                Rename order = new Rename(Client.Instance.Selected, this.textBoxObjectName.Text);
                Client.Instance.Player.Orders.AddRenameOrder(order);
                Client.Instance.Selected.Name = this.textBoxObjectName.Text;
            }
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

            if (Client.Instance.Map.GetAllOthersAtLocation(obj).Count > 0)
            {
                int planets = 0;
                int ships = 0;

                foreach (Model.MapObject mo in Client.Instance.Map.GetAllOthersAtLocation(obj))
                {
                    if (mo.GetType() == typeof(Planet))
                    {
                        planets += 1;
                    }
                    else
                    {
                        ships += 1;
                    }
                }
                this.buttonOthers.Visible = true;
                string message = "";
                if (planets > 0)
                {
                    message += "1 planet";
                }
                if (ships > 0)
                {
                    if (planets > 0)
                    {
                        message += " and ";
                    }
                    if (ships > 1)
                    {
                        message += ships.ToString() + " ships";
                    }
                    else
                    {
                        message += ships.ToString() + " ship";
                    }
                }
                message += " at this location - View";
                this.buttonOthers.Text = message;
                if (ships == 0 && planets == 0)
                {
                    this.buttonOthers.Visible = false;
                }
            }
            else
            {
                this.buttonOthers.Visible = false;
            }

            if (obj.GetType() == typeof(Planet))
            {
                Planet p = (Planet)obj;
                this.pictureBoxEnergy.Image = global::LcogClient.Properties.Resources.planet_energy;
                this.labelEnergy.Text = p.Energy.ToString();
            }
            else
            {
                this.pictureBoxEnergy.Image = global::LcogClient.Properties.Resources.damage;
                Ship s = (Ship)obj;
                this.labelEnergy.Text = s.Damage.ToString();
            }
        }

        private void buttonOthers_Click(object sender, EventArgs e)
        {
            Forms.Select form = new Select("Select object", Client.Instance.Map.GetAllOthersAtLocation(Client.Instance.Selected));
            form.ShowDialog();
            Client.Instance.Selected = Client.Instance.Target;
            Client.Instance.UpdateView();
        }
    }
}
