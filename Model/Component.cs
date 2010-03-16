using System;
using System.Collections.Generic;

using LcogClient.Model.Collections;
using LcogClient.Utility;

namespace LcogClient.Model
{
    /// <summary>
    /// Represents a component.
    /// </summary>
    public class Component
    {
        #region Properties
        /// <summary>
        /// Name of the component.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Description of the hull type.
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Cost to build.
        /// </summary>
        public int Cost { get; set; }
        /// <summary>
        /// Component mass.
        /// </summary>
        public int Mass { get; set; }
        /// <summary>
        /// Component size.
        /// </summary>
        public int Size { get; set; }
        /// <summary>
        /// Tech requirements of the component.
        /// </summary>
        public Technologies Tech { get; set; }

        #endregion

        #region Constructors
        /// <summary>
        /// Default constructor.
        /// </summary>
        public Component()
        {
            this.Tech = new Technologies();
        }
        #endregion
    }
}