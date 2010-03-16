using System;
using System.Drawing;

using LcogClient.Model.Collections;

namespace LcogClient.Model
{
    /// <summary>
    /// Base class of all map objects.
    /// </summary>
    public class MapObject : LcogObject
    {
        #region Properties
        /// <summary>
        /// X co-ordinate of the object.
        /// </summary>
        public int X { get; set; }
        /// <summary>
        /// Y co-ordinate of the object.
        /// </summary>
        public int Y { get; set; }
        /// <summary>
        /// Co-ordinates, (x,y) point.
        /// </summary>
        public Point Location
        {
            get
            {
                return new Point(this.X, this.Y);
            }
        }
        /// <summary>
        /// Owning faction.
        /// </summary>
        public Faction Faction { get; set; }
        /// <summary>
        /// Image that represents the object.
        /// </summary>
        public Image Image { get; set; }
        /// <summary>
        /// Components.
        /// </summary>
        public Components Components { get; set; }

        #endregion

        #region Constructors
        /// <summary>
        /// Default constructor.
        /// </summary>
        public MapObject()
        {
            this.Components = new Components();
        }
        #endregion

        #region Draw
        /// <summary>
        /// Virtual draw method, to be overridden.
        /// </summary>
        /// <param name="g">Graphics context.</param>
        public virtual void Draw(Graphics g)
        {
        }
        #endregion

        public bool HasMoveOrder()
        {
            if (Client.Instance.Player.Orders.GetMoveOrder(this) != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool HasInterceptOrder()
        {
            if (Client.Instance.Player.Orders.GetInterceptOrder(this) != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool HasBuildOrder()
        {
            if (Client.Instance.Player.Orders.GetBuildOrder(this) != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool HasUpgradeOrder()
        {
            if (Client.Instance.Player.Orders.GetUpgradeOrder(this) != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //public bool HasColoniseOrder()
        //{
        //    if (Client.Instance.Player.Orders.GetColoniseOrder(this) != null)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
    }
}
