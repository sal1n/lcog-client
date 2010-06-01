using System;
using System.ComponentModel;
using System.Windows.Forms;

using LcogClient.Model;

namespace LcogClient.Controls
{
    /// <summary>
    /// Simple control for cycling through a players planets and ships.
    /// </summary>
    public partial class CycleObjects : Base
    {
        #region Constructors
        /// <summary>
        /// Default constructor.
        /// </summary>
        public CycleObjects()
        {
            InitializeComponent();
        }
        #endregion

        #region Event Handling
        private void buttonBackPlanets_Click(object sender, EventArgs e)
        {
            if (Client.Instance.Selected.GetType() == typeof(Planet))
            {
                Client.Instance.Selected = Client.Instance.Player.GetPreviousPlanet((Planet)Client.Instance.Selected);
            }
            else
            {
                Client.Instance.Selected = Client.Instance.Player.Planets[0];
            }
        }

        private void buttonForwardPlanets_Click(object sender, EventArgs e)
        {
            if (Client.Instance.Selected.GetType() == typeof(Planet))
            {
                Client.Instance.Selected = Client.Instance.Player.GetNextPlanet((Planet)Client.Instance.Selected);
            }
            else
            {
                Client.Instance.Selected = Client.Instance.Player.Planets[0];
            }
        }

        private void buttonBackShips_Click(object sender, EventArgs e)
        {
            if (Client.Instance.Selected.GetType() == typeof(Ship))
            {
                Client.Instance.Selected = Client.Instance.Player.GetPreviousShip((Ship)Client.Instance.Selected);
            }
            else
            {
                Client.Instance.Selected = Client.Instance.Player.Ships[0];
            }
        }

        private void buttonForwardShips_Click(object sender, EventArgs e)
        {
            if (Client.Instance.Selected.GetType() == typeof(Ship))
            {
                Client.Instance.Selected = Client.Instance.Player.GetNextShip((Ship)Client.Instance.Selected);
            }
            else
            {
                Client.Instance.Selected = Client.Instance.Player.Ships[0];
            }
        }
        #endregion
    }
}
