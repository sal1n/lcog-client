using System;
using System.Drawing;

using LcogClient.Model.Orders;
using LcogClient.Utility;

namespace LcogClient.Model
{
    /// <summary>
    /// Represents a planet.
    /// </summary>
    public class Planet : MapObject
    {
        #region Properties
        /// <summary>
        /// Energy.
        /// </summary>
        public int Energy { get; set; }

        #endregion

        #region Constructors
        /// <summary>
        /// Default constructor.
        /// </summary>
        public Planet()
        {
        }
        #endregion

        #region Orders
        /// <summary>
        /// Build order.
        /// </summary>
        /// <param name="hull">Hull to build.</param>
        /// <param name="components">Components to put in slots.</param>
        //public void Build(Hull hull, Components components)
        //{
        //    Build order = new Build(this, hull, components);
        //    Client.Instance.Player.Orders.AddOrder(order);
        //}
        #endregion

        #region Draw
        /// <summary>
        /// Draw method.
        /// </summary>
        /// <param name="g">Graphics context.</param>
        public override void Draw(Graphics g)
        {
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            g.FillEllipse(LcogBrushes.Planet, this.X, this.Y, 2, 2);

            if (this.Faction == null)
            {
            }
            else if (this.Faction == Client.Instance.Player.Faction)
            {
                g.DrawEllipse(LcogPens.OwnPlanet, this.X - 2, this.Y - 2, 6, 6);
            }
            else if (this.Faction != Client.Instance.Player.Faction && this.Faction.Relations == "neutral")
            {
                g.DrawEllipse(LcogPens.NeutralPlanet, this.X - 2, this.Y - 2, 6, 6);
            }
            else
            {
                g.DrawEllipse(LcogPens.HostilePlanet, this.X - 2, this.Y - 2, 6, 6);
            }

            if (this == Client.Instance.Selected)
            {
                g.DrawEllipse(LcogPens.Selected, this.X - 2, this.Y - 2, 6, 6);
            }
        }
        #endregion

        public Planet Clone()
        {
            Planet planet = new Planet();
            planet.Name = this.Name;
            planet.ID = this.ID;
            planet.Image = this.Image;
            foreach (Component component in this.Components)
            {
                planet.Components.Add(component);
            }
            return planet;
        }
    }
}
