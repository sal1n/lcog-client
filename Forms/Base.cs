using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace LcogClient.Forms
{
    /// <summary>
    /// Base form.
    /// </summary>
    public partial class Base : Form
    {
        /// <summary>
        /// Default constructor.
        /// </summary>
        public Base()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Virtual method used for explicit update calls.
        /// </summary>
        public virtual void UpdateView()
        {
        }
    }
}
