using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;

using LcogClient.Model.Orders;
using LcogClient.Utility;

namespace LcogClient.Model
{
    /// <summary>
    /// Represents a ship.
    /// </summary>
    public class Ship : MapObject
    {
        #region Properties
        /// <summary>
        /// Damage %, 0 is none, 100 is destroyed.
        /// </summary>
        public int Damage { get; set; }
        /// <summary>
        /// Waypoint.
        /// </summary>
        public Point Waypoint { get; set; }
        /// <summary>
        /// Total mass.
        /// </summary>
        public int Mass { get; set; }
        /// <summary>
        /// Class of hull, assigned by host.
        /// </summary>
        public string HullClass { get; set; }
        /// <summary>
        /// How far can this ship move in a single turn.
        /// </summary>
        public int MaxMove { get; set; }
        /// <summary>
        /// Hull capacity (for component size)
        /// </summary>
        public int Hull { get; set; }

        #endregion

        #region Constructors
        /// <summary>
        /// Default constructor.
        /// </summary>
        public Ship()
        {
        }
        #endregion

        #region Orders
        /// <summary>
        /// Move this ship to a given destination.
        /// </summary>
        /// <param name="destination">Waypoint.</param>
        public void Move(Point destination)
        {
            Move order = new Move(this, destination);
            this.Waypoint = destination;
            Client.Instance.Player.Orders.AddMoveOrder(order);
        }

        public void Intercept(Ship ship)
        {
            Intercept order = new Intercept(this, ship);
            this.Waypoint = ship.Location;
            Client.Instance.Player.Orders.AddInterceptOrder(order);
        }
        public bool HasColoniseOrder()
        {
            if (Client.Instance.Player.Orders.GetColoniseOrder(this) != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region Draw
        /// <summary>
        /// Draw method.
        /// </summary>
        /// <param name="g">Graphics context.</param>
        public override void Draw(Graphics g)
        {
            GraphicsPath path = new GraphicsPath();

            if (Client.Instance.Map.GetPlanetAtLocation(this.Location) == null)
            {
                // create triangular path

                Point pt1 = new Point(this.X, this.Y - 3);
                Point pt2 = new Point(this.X - 3, this.Y + 3);
                Point pt3 = new Point(this.X + 3, this.Y + 3);
                path.AddPolygon(new Point[] { pt1, pt2, pt3 });
            }
            else
            {
                path.AddEllipse(this.X - 4, this.Y - 4, 10, 10);
            }

            if (this.Faction == Client.Instance.Player.Faction)
            {
                g.DrawPath(LcogPens.OwnShip, path);
            }
            else if (this.Faction != Client.Instance.Player.Faction && this.Faction.Relations == "neutral")
            {
                g.DrawPath(LcogPens.NeutralShip, path);
            }
            else
            {
                g.DrawPath(LcogPens.HostileShip, path);
            }

            if (this.Waypoint != null && this == Client.Instance.Selected)
            {
                LcogClient.Utility.Lcog2D.DrawLine(this.Location, this.Waypoint, Client.Instance.Map.Size, g, Pens.Yellow);
            }

            if (this == Client.Instance.Selected)
            {
                // draw movement range
                path.AddEllipse(this.X - (this.MaxMove/2), this.Y - (this.MaxMove/2), this.MaxMove, this.MaxMove);
                g.DrawPath(LcogPens.Selected, path);
            }
        }
        #endregion

        public Ship Clone()
        {
            Ship ship = new Ship();
            ship.Name = this.Name;
            ship.ID = this.ID;
            ship.Image = this.Image;
            foreach (Component component in this.Components)
            {
                ship.Components.Add(component);
            }
            return ship;
        }
    }
}
