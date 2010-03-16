using System;
using System.ComponentModel;
using System.Windows.Forms;

using LcogClient.Model;

namespace LcogClient.Forms
{
    public partial class Technology : Base
    {
        public Technology()
        {
            InitializeComponent();

            this.labelCurrentResearch.Text = "Research (" + Client.Instance.Player.Tech.CurrentResearch.ToString() + " / turn):";
            this.labelResearch.Text = Client.Instance.Player.Tech.Researching;
            this.labelEngineering.Text = Client.Instance.Player.Tech.GetTechnologyLevel("engineering").ToString() + " (" + Client.Instance.Player.Tech.GetResearchLevel("engineering").ToString() + ")";
            this.labelQuantum.Text = Client.Instance.Player.Tech.GetTechnologyLevel("quantum").ToString() + " (" + Client.Instance.Player.Tech.GetResearchLevel("quantum").ToString() + ")";
            this.labelFields.Text = Client.Instance.Player.Tech.GetTechnologyLevel("fields").ToString() + " (" + Client.Instance.Player.Tech.GetResearchLevel("fields").ToString() + ")";
        }

        private new void UpdateView()
        {
            this.labelResearch.Text = Client.Instance.Player.Tech.Researching;
        }
        private void buttonEngineering_Click(object sender, EventArgs e)
        {
            Model.Orders.Research order = new LcogClient.Model.Orders.Research("engineering");
            Model.Client.Instance.Player.Orders.AddResearchOrder(order);
            Client.Instance.Player.Tech.Researching = "engineering";
            this.UpdateView();
        }

        private void buttonQuantum_Click(object sender, EventArgs e)
        {
            Model.Orders.Research order = new LcogClient.Model.Orders.Research("quantum");
            Model.Client.Instance.Player.Orders.AddResearchOrder(order);
            Client.Instance.Player.Tech.Researching = "quantum";
            this.UpdateView();
        }

        private void buttonFields_Click(object sender, EventArgs e)
        {
            Model.Orders.Research order = new LcogClient.Model.Orders.Research("fields");
            Model.Client.Instance.Player.Orders.AddResearchOrder(order);
            Client.Instance.Player.Tech.Researching = "fields";
            this.UpdateView();
        }
    }
}
