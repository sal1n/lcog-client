using System;
using System.Collections.Generic;
using System.Drawing;
using System.Xml;

using LcogClient.Model.Collections;
using LcogClient.Utility;

namespace LcogClient.Model
{
    /// <summary>
    /// Singleton instance representing the actual client application.
    /// </summary>
    public class Client
    {
        #region Properties
        /// <summary>
        /// All components in the game.
        /// </summary>
        public Components Components { get; set;}
        /// <summary>
        /// All factions in the game.
        /// </summary>
        public Factions Factions { get; set;}
        /// <summary>
        /// Current selected MapObject.
        /// </summary>
        private MapObject selected;
        public MapObject Selected {
            get
            {
                return this.selected;
            }
            set
            {
                this.selected = value;
                this.UpdateView();
            }
        }
        /// <summary>
        /// Current selected target MapObject.
        /// </summary>
        public MapObject Target { get; set;}
        /// <summary>
        /// Reference to player faction.
        /// </summary>
        public Player Player { get; set; }
        /// <summary>
        /// Reference to the current map.
        /// </summary>
        public Map Map { get; set;}
        /// <summary>
        /// Current game name.
        /// </summary>
        public string GameName { get; set;}

        #endregion

        #region Singleton
        /// <summary>
        /// Private instance.
        /// </summary>
        private static Client instance;

        /// <summary>
        /// Private default constructor.
        /// </summary>
        private Client()
        {
        }

        /// <summary>
        /// Singleton instance.
        /// </summary>
        public static Client Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Client();
                }
                return instance;
            }
        }
        #endregion

        #region Events
        /// <summary>
        /// All controls attach their updateview() to this eventhandler so they know when to update. 
        /// </summary>
        public event EventHandler Update;
        
        /// <summary>
        /// Call this explicitly to update the gui.
        /// </summary>
        public virtual void UpdateView()
        {
            if (Update != null) Update(this, EventArgs.Empty);
        }
        #endregion

        public void SelectNearestMapObject(Point point)
        {
            this.Selected = this.Map.GetNearestObject(point);
            this.UpdateView();
        }

        public void TargetNearestMapObject(Point point)
        {
            this.Target = this.Map.GetNearestObject(point);
            this.UpdateView();
        }

        public List<Ship> InterceptShip(Point point)
        {
            return this.Map.ShipsNearLocation(point);
        }
    }
}
