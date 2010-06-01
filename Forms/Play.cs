using System;
using System.ComponentModel;
using System.Windows.Forms;

using LcogClient.Model;

namespace LcogClient.Forms
{
    public partial class Play : Base
    {
        public Play()
        {
            InitializeComponent();

            Player player = Client.Instance.Player;
            if (player.Planets.Count > 0)
            {
                Client.Instance.Selected = player.Planets[0];
                this.map1.CenterOnPoint(Client.Instance.Selected.Location);
            }
            else
            {
                // yes this will throw an index out of range exception
                Client.Instance.Selected = player.Ships[0];
                this.map1.CenterOnPoint(Client.Instance.Selected.Location);
            }
        }

        private void Play_Load(object sender, EventArgs e)
        {

        }
    }
}
