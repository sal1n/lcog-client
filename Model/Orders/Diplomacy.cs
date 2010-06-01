using System;

namespace LcogClient.Model.Orders
{
    /// <summary>
    /// Diplomacy order.
    /// 
    ///     <diplomacy>    
    ///         <clear />
    ///         <enemy>Steve</enemy> <!-- can use id or name -->
    ///     </diplomacy>
    ///
    /// </summary>
    public class Diplomacy : Order
    {
        #region Properties
        /// <summary>
        /// Faction to declare.
        /// </summary>
        public Faction Faction { get; set; }
        /// <summary>
        /// New stance.
        /// </summary>
        public string Stance { get; set; }

        #endregion

        #region Constructors
        /// <summary>
        /// Default constructor.
        /// </summary>
        public Diplomacy()
        {
        }

        /// <summary>
        /// Constructor.
        /// </summary>
        public Diplomacy(Faction faction, string stance)
        {
            this.Faction = faction;
            this.Stance = stance;
        }
        #endregion

        public override string ToString()
        {
            return "Diplomacy | Declaring " + this.Faction.Name + " as " + this.Stance;
        }
        /// <summary>
        /// Todo:  replace this with proper object xml serialization, this is rubbish.
        /// </summary>
        public override string ToXml()
        {
            string xml = "<diplomacy>\n";
            if (this.Stance == "Neutral")
            {
                xml += "<neutral>" + this.Faction.ID.ToString() + "</neutral>\n";
            }
            else if (Stance == "Enemy")
            {
                xml += "<enemy>" + this.Faction.ID.ToString() + "</enemy>\n";
            }
            xml += "</diplomacy>\n";

            return xml;
        }
    }
}
