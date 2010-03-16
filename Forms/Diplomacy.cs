using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace LcogClient.Forms
{
    public partial class Diplomacy : Base
    {
        public Diplomacy()
        {
            InitializeComponent();

            foreach (Model.Faction faction in Model.Client.Instance.Factions)
            {
                if (faction.ID != Model.Client.Instance.Player.Faction.ID)
                {
                    this.flowLayoutPanel.Controls.Add(new Controls.FactionDiplomacy(faction));
                }
            }
        }
    }
}
