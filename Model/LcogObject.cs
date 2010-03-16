using System;

using LcogClient.Model.Collections;
using LcogClient.Model.Orders;

namespace LcogClient.Model
{
    /// <summary>
    /// Base class of all objects.
    /// </summary>
    public class LcogObject
    {
        #region Public Properties
        /// <summary>
        /// Name of the object.
        /// </summary>
        public string Name { get; set;}
        /// <summary>
        /// ID reference of the object.
        /// </summary>
        public int ID { get; set;}

        #endregion

        #region Constructors
        /// <summary>
        /// Default constructor.
        /// </summary>
        public LcogObject()
        {
        }
        #endregion

        #region Orders
        /// <summary>
        /// Rename object order.
        /// </summary>
        /// <param name="name">New name.</param>
        public void Rename(string name)
        {
            this.Name = name;
            Rename order = new Rename(this, name);
            Client.Instance.Player.Orders.AddRenameOrder(order);
        }
        #endregion
    }
}
