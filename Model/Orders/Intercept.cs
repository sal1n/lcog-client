using System;

namespace LcogClient.Model.Orders
{
    /// <summary>
    /// Intercept order.
    /// 
    ///     <intercept>
    ///         <ship>1</ship> <!-- can use id or name -->
    ///         <target>2</target> <!-- use id -->
    ///     </intercept>
    ///
    /// </summary>
    public class Intercept : Order
    {        
        #region Properties
        /// <summary>
        /// Which ship to move.
        /// </summary>
        public Ship Ship { get; set;}
        /// <summary>
        /// Target.
        /// </summary>
        public Ship Target { get; set;}

        #endregion

        #region Constructors
        /// <summary>
        /// Default constructor.
        /// </summary>
        public Intercept()
        {
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public Intercept(Ship ship, Ship target)
        {
            this.Ship = ship;
            this.Target = target;
        }
        #endregion

        public override string ToString()
        {
            return "Intercept | " + this.Ship.Name + " intercepting " + this.Target.Name;
        }

        /// <summary>
        /// Todo:  replace this with proper object xml serialization, this is rubbish.
        /// </summary>
        public override string ToXml()
        {
            string xml = "<intercept>\n";
            xml += "<ship>" + this.Ship.ID.ToString() + "</ship>\n";
            xml += "<target>" + this.Target.ID.ToString() + "</target>\n";
            xml += "</intercept>\n";

            return xml;
        }
    }
}