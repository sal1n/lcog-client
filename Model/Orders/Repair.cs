using System;

namespace LcogClient.Model.Orders
{
    /// <summary>
    /// Repair order.
    /// 
    ///     <repair>
    ///         <ship>1</ship> <!-- can use id or name -->
    ///         <energy>ALL</energy> <!-- amount of energy to use repairing, or ALL to repair all damage -->
    ///     </repair>
    ///
    /// </summary>
    public class Repair : Order
    {
        #region Properties
        /// <summary>
        /// Ship to repair.
        /// </summary>
        public Ship Ship { get; set;}
        /// <summary>
        /// Amount of energy to use.
        /// </summary>
        public int Energy { get; set;}

        #endregion

        #region Constructors
        /// <summary>
        /// Default constructor.
        /// </summary>
        public Repair()
        {
        }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="ship">Shipto repair.</param>
        /// <param name="energy">Amount of energy to use.</param>
        public Repair(Ship ship, int energy)
        {
            this.Ship = ship;
            this.Energy = energy;
        }
        #endregion

        /// <summary>
        /// Todo:  replace this with proper object xml serialization, this is rubbish.
        /// </summary>
        public override string ToXml()
        {
            string xml = "<repair>\n";
            xml += "<ship>" + this.Ship.ID.ToString() + "</ship>\n";
            xml += "<energy>" + this.Energy.ToString() + "</energy>\n";
            xml += "</repair>\n";

            return xml;
        }
    }
}