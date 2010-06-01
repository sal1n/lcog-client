using System;

using LcogClient.Model.Collections;

namespace LcogClient.Model.Orders
{
    /// <summary>
    /// Colonise order.
    /// 
    ///     <colonise>
    ///         <ship>1</ship> <!-- can use id or name, to colonise a planet at same location -->
    ///     <colonise>
    ///
    /// </summary>
    public class Colonise : Order
    {
        #region Properties
        /// <summary>
        /// Ship to colonise with.
        /// </summary>
        public Model.MapObject Ship { get; set; }

        #endregion

        #region Constructors
        /// <summary>
        /// Default constructor.
        /// </summary>
        public Colonise()
        {
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public Colonise(Ship ship)
        {
            this.Ship = ship;
        }
        #endregion

        public override string ToString()
        {
            Planet p = Client.Instance.Map.GetPlanetAtLocation(this.Ship.Location);
            return "Colonise | " + this.Ship.Name + " colonising " + p.Name;
        }

        /// <summary>
        /// Todo:  replace this with proper object xml serialization, this is rubbish.
        /// </summary>
        public override string ToXml()
        {
            string xml = "<colonise>\n";
                xml += "<ship>" + this.Ship.ID + "</ship>\n";
            xml += "</colonise>\n";

            return xml;
        }
    }
}