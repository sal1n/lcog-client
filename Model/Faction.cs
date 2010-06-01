using System;
using System.Collections.Generic;

namespace LcogClient.Model
{
    /// <summary>
    /// Represents an in-game faction.
    /// </summary>
    public class Faction : LcogObject
    {
        #region Properties
        /// <summary>
        /// Total mass of the faction.
        /// </summary>
        public int Mass { get; set; }
        /// <summary>
        /// How many planets does the faction have.
        /// </summary>
        public int Planets { get; set; }
        /// <summary>
        /// How many ships does the faction have.
        /// </summary>
        public int Ships { get; set; }
        /// <summary>
        /// Current score of the faction.
        /// </summary>
        public int Score { get; set; }
        /// <summary>
        /// Current relations of the faction towards the player.
        /// </summary>
        public string Relations { get; set; }

        #endregion

        #region Constructors
        /// <summary>
        /// Default constructor.
        /// </summary>
        public Faction()
        {
        }
        #endregion
    }
}
