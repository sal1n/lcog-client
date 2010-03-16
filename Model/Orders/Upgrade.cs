using System;

using LcogClient.Model.Collections;

namespace LcogClient.Model.Orders
{
    /// <summary>
    /// Upgrade order.
    /// 
    ///     <upgrade>
    ///         <ship>1</ship>    or <planet>1</planet> <!-- can use id or name -->
    ///         <target_ship>1</target_ship>    or <target_planet>1</target_planet> <!-- can use id or name -->
    ///         <slot>engine</slot>
    ///         <slot>factory</slot> <!-- for building -->
    ///         <slot>landing craft</slot> <!-- for colonising -->
    ///         <slot>lab</slot> <!-- research -->
    ///         <slot>torpedo</slot>
    ///         <slot>repair bay</slot> <!-- not implemented yet -->
    ///         <slot>shield</slot>
    ///     </upgrade>
    ///
    /// </summary>
    public class Upgrade : Order
    {
        #region Properties
        /// <summary>
        /// Factory object to build with.
        /// </summary>
        public MapObject Factory { get; set; }
        /// <summary>
        /// Target to upgrade.
        /// </summary>
        public MapObject Target { get; set; }
        /// <summary>
        /// Components to add.
        /// </summary>
        public Components Components { get; set; }

        #endregion

        #region Constructors
        /// <summary>
        /// Default constructor.
        /// </summary>
        public Upgrade()
        {
            this.Components = new Components();
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public Upgrade(MapObject factory, MapObject target, Components components)
        {
            this.Factory = factory;
            this.Target = target;
            this.Components = components;
        }
        #endregion

        public override string ToString()
        {
            return "Upgrade | " + this.Factory.Name + " is upgrading " + this.Target.Name + " with " + this.Components.Count.ToString() + " components";
        }

        /// <summary>
        /// Todo:  replace this with proper object xml serialization, this is rubbish.
        /// </summary>
        public override string ToXml()
        {
            string xml = "<upgrade>\n";
            if (this.Factory.GetType() == typeof(Planet))
            {
                xml += "<planet>" + this.Factory.ID + "</planet>\n";
            }
            else
            {
                xml += "<ship>" + this.Factory.ID + "</ship>\n";
            }
            if (this.Target.GetType() == typeof(Planet))
            {
                xml += "<target_planet>" + this.Target.ID + "</target_planet>\n";
            }
            else
            {
                xml += "<target_ship>" + this.Target.ID + "</target_ship>\n";
            }
            foreach (Component component in this.Components)
            {
                xml += "<slot>" + component.Name + "</slot>\n";
            }
            xml += "</upgrade>\n";

            return xml;
        }
    }
}