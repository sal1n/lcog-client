using System;
using System.Drawing;

namespace LcogClient.Model.Orders
{
    /// <summary>
    /// Move Order
    /// 
    ///     <move>
    ///         <ship>1</ship> <!-- can use id or name -->
    ///         <planet>2</planet> <!-- can use id or name, used in preference to x,y -->
    ///         <x>0</x>
    ///         <y>0</y>        
    ///     </move>
    ///
    /// </summary>
    public class Move : Order
    {
        #region Properties
        /// <summary>
        /// Which ship to move.
        /// </summary>
        public Ship Ship { get; set;}
        /// <summary>
        /// Destination waypoint.
        /// </summary>
        public Point Waypoint { get; set;}

        #endregion

        #region Constructors
        /// <summary>
        /// Default constructor.
        /// </summary>
        public Move()
        {
        }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="ship">Ship to move.</param>
        /// <param name="point">Waypoint.</param>
        public Move(Ship ship, Point point)
        {
            this.Ship = ship;
            this.Waypoint = point;
        }
        #endregion

        public override string ToString()
        {
            return "Move | " + this.Ship.Name + " moving to " + Client.Instance.Map.GetPlanetAtLocation(this.Waypoint).Name + " " + this.Waypoint.ToString();
        }
        /// <summary>
        /// Todo:  replace this with proper object xml serialization, this is rubbish.
        /// </summary>
        public override string ToXml()
        {
            string xml = "<move>\n";
            xml += "<ship>" + this.Ship.ID.ToString() + "</ship>\n";
            xml += "<x>" + this.Waypoint.X.ToString() + "</x>\n";
            xml += "<y>" + this.Waypoint.Y.ToString() + "</y>\n";
            xml += "</move>\n";

            return xml;
        }
    }
}
