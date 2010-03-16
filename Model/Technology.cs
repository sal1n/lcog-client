using System;
using System.Collections.Generic;

namespace LcogClient.Model
{
    /// <summary>
    /// Represents technology.
    /// </summary>
    public class Technology
    {
        #region Properties
        /// <summary>
        /// Technology name.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Technology level.
        /// </summary>
        public int Level { get; set; }
        /// <summary>
        /// Current research level of the tech.
        /// </summary>
        public int Research { get; set; }  

        #endregion

        #region Constructors
        /// <summary>
        /// Default constructor.
        /// </summary>
        public Technology()
        {
        }

        /// <summary>
        /// Constructor.
        /// </summary>
        public Technology(string name, int level)
        {
            this.Name = name;
            this.Level = level;
        }

        /// <summary>
        /// Constructor.
        /// </summary>
        public Technology(string name, int level, int research)
        {
            this.Name = name;
            this.Level = level;
            this.Research = research;
        }
        #endregion
    }
}