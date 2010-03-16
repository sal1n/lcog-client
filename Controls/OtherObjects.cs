using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

using LcogClient.Model;

namespace LcogClient.Controls
{
    /// <summary>
    /// Displays other map objects at the same map location.
    /// </summary>
    public partial class OtherObjects : Base
    {

        #region Constructors
        /// <summary>
        /// Default constructor.
        /// </summary>
        public OtherObjects() : base()
        {
            InitializeComponent();
        }
        #endregion

        #region Event Handling
        /// <summary>
        /// Method used for handling explicit update events.
        /// </summary>
        public override void UpdateView(object source, EventArgs e)
        {
            this.flowLayoutPanel.Controls.Clear();
            
            foreach (Model.MapObject obj in Client.Instance.Map.GetAllOthersAtLocation(Client.Instance.Selected))
            {
                OtherObject otherObject = new OtherObject(obj);
                this.flowLayoutPanel.Controls.Add(otherObject);
            }
        }
        #endregion
    }
}