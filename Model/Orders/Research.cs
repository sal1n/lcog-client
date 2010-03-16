using System;

namespace LcogClient.Model.Orders
{
    /// <summary>
    /// Research order.
    /// 
    ///     <research>
    ///         <technology>fields or engineering or quantum</technology>
    ///     <research>
    ///
    /// </summary>
    public class Research : Order
    {
        #region Properties
        /// <summary>
        /// Technology to research.
        /// </summary>
        public string Technology { get; set;}

        #endregion

        #region Constructors
        /// <summary>
        /// Default constructor.
        /// </summary>
        public Research()
        {
        }

        /// <summary>
        /// Constructor.
        /// </summary>
        public Research(string technology)
        {
            this.Technology = technology;
        }
        #endregion

        public override string ToString()
        {
            return "Research | focus on " + this.Technology;
        }
        /// <summary>
        /// Todo:  replace this with proper object xml serialization, this is rubbish.
        /// </summary>
        public override string ToXml()
        {
            string xml = "<research>\n";
            xml += "<technology>" + this.Technology + "</technology>\n";         
            xml += "</research>\n";

            return xml;
        }
    }
}
