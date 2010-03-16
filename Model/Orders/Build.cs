using System;

using LcogClient.Model.Collections;

namespace LcogClient.Model.Orders
{
    /// <summary>
    /// Build order.
    /// 
    ///     <build>
    ///         <ship>1</ship>  or  <planet>1</planet>  <!-- can use id or name -->
    ///         <slot>engine</slot>
    ///         <slot>factory</slot> <!-- for building -->
    ///         <slot>landing craft</slot> <!-- for colonising -->
    ///         <slot>lab</slot> <!-- research -->
    ///         <slot>torpedo</slot>
    ///         <slot>repair bay</slot> <!-- not implemented yet -->
    ///         <slot>shield</slot>
    ///     </build>
    ///
    /// </summary>
    public class Build : Order
    {
        #region Properties
        /// <summary>
        /// MapObject to build with.
        /// </summary>
        public MapObject MapObject { get; set; }
        /// <summary>
        /// Components to put in hull slots.
        /// </summary>
        public Components Components { get; set; }

        #endregion

        #region Constructors
        /// <summary>
        /// Default constructor.
        /// </summary>
        public Build()
        {
            this.Components = new Components();
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public Build(MapObject obj, Components components)
        {
            this.MapObject = obj;
            this.Components = components;
        }
        #endregion

        public override string ToString()
        {
            return "Build | " + this.MapObject.Name + " is building a new ship with " + this.Components.Count.ToString() + " components";
        }

        /// <summary>
        /// Todo:  replace this with proper object xml serialization, this is rubbish.
        /// </summary>
        public override string ToXml()
        {
            string xml = "<build>\n";
            if (this.MapObject.GetType() == typeof(Planet))
            {
                xml += "<planet>" + this.MapObject.ID + "</planet>\n";
            }
            else
            {
                xml += "<ship>" + this.MapObject.ID + "</ship>\n";
            }
            foreach (Component component in this.Components)
            {
                xml += "<slot>" + component.Name + "</slot>\n";
            }
            xml += "</build>";

            return xml;
        }
    }
}