using System;
using System.ComponentModel;
using System.Windows.Forms;

using LcogClient.Model;

namespace LcogClient.Controls
{
    public partial class Base : UserControl
    {
        /// <summary>
        /// Default constructor.
        /// </summary>
        public Base()
        {
            InitializeComponent();

        // register the UpdateView method with the Clients update event
            Client.Instance.Update += new EventHandler(UpdateView);
        }

        /// <summary>
        /// Virtual method used for handling explicit update events.
        /// </summary>
        public virtual void UpdateView(object source, EventArgs e)
        {
        }
    }
}
