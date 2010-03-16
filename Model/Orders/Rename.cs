using System;

namespace LcogClient.Model.Orders
{
    /// <summary>
    /// Rename order.
    /// 
    ///     <name>
    ///         <planet>1</planet> <!-- can use id or name -->
    ///         <ship>2</ship> <!-- can use id or name -->
    ///         <faction>3</faction> <!-- can use id or name (ignored in client v1 - probably for the best!) -->
    ///         <name>New Name</name>
    ///     </name>
    ///
    /// </summary>
    public class Rename : Order
    {
        #region Properties
        /// <summary>
        /// Which object to rename.
        /// </summary>
        public LcogObject Obj { get; set;}
        /// <summary>
        /// New name.
        /// </summary>
        public string Name { get; set;}

        #endregion

        #region Constructors
        /// <summary>
        /// Default constructor.
        /// </summary>
        public Rename()
        {
        }

        /// <summary>
        /// Cosntructor.
        /// </summary>
        /// <param name="obj">Object to rename.</param>
        /// <param name="name">New name.</param>
        public Rename(LcogObject obj, string name)
        {
            this.Obj = obj;
            this.Name = name;
        }
        #endregion

        /// <summary>
        /// Todo:  replace this with proper object xml serialization, this is rubbish.
        /// </summary>
        public override string ToXml()
        {
            string xml = "<name>\n";
            xml += "<" + this.GetTypeName() + ">" + this.Obj.ID.ToString() + "</" + this.GetTypeName() + ">\n";
            xml += "<name>" + this.Name + "</name>\n";
            xml += "</name>\n";

            return xml;
        }

        // this shouldn't be here...
        private string GetTypeName()
        {
            if (this.Obj.GetType() == typeof(Planet))
            {
                return "planet";
            }
            else if (this.Obj.GetType() == typeof(Ship))
            {
                return "ship";
            }
            else if (this.Obj.GetType() == typeof(Faction))
            {
                return "factionname";
            }
            return "";
        }
    }
}