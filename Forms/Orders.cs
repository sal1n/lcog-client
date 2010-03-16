using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace LcogClient.Forms
{
    public partial class Orders : Base
    {
        public Orders()
        {
            InitializeComponent();

            foreach (Model.Orders.Order order in Model.Client.Instance.Player.Orders)
            {
                ListViewItem item = new ListViewItem();
                item.Text = order.ToString();
                this.listView.Items.Add(item);
            }
        }
    }
}
