using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

using LcogClient.Model;

namespace LcogClient.Controls
{
    /// <summary>
    /// Displays an object at the same location as the current selected object.
    /// </summary>
    public partial class OtherObject : UserControl
    {
        #region Properties
        /// <summary>
        /// The map object this is displaying. 
        /// </summary>
        public Model.MapObject MapObject { get; set; }

        #endregion

        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        public OtherObject()
        {
            InitializeComponent();

            this.InitialiseEventHandlers();
        }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="obj">Map object to display</param>
        public OtherObject(Model.MapObject obj)
        {
            InitializeComponent();

            this.InitialiseEventHandlers();

            this.MapObject = obj;

            this.pictureBox.Image = obj.Image;
            this.labelObjectName.Text = obj.Name + " [" + obj.ID.ToString() + "]";

            if (obj.Faction != null)
            {
                this.labelFactionName.Text = obj.Faction.Name;
            }
            else
            {
                this.labelFactionName.Text = "Unclaimed";
            }

            if (obj.GetType() == typeof(Planet))
            {
                Planet p = (Planet)obj;
                this.labelMassOrEnergy.Text = p.Energy.ToString();
            }
            else
            {
                Ship s = (Ship)obj;
                this.labelMassOrEnergy.Text = s.Mass.ToString();
            }
        }

        /// <summary>
        /// Initialises the click and mouse events, would be much nicer to use
        /// a simple transparent panel or something but that didn't work in Mono:(
        /// </summary>
        public void InitialiseEventHandlers()
        {
            this.pictureBox.Click += new EventHandler(otherObject_Click);
            this.labelObjectName.Click += new EventHandler(otherObject_Click);
            this.labelFactionName.Click += new EventHandler(otherObject_Click);
            this.labelMassOrEnergy.Click += new EventHandler(otherObject_Click);
            this.Click += new EventHandler(otherObject_Click);
        }
        #endregion

        #region Event Handling

        void otherObject_Click(object sender, EventArgs e)
        {
            Client.Instance.Target = this.MapObject;
           // Client.Instance.UpdateView();
            ParentForm.Close();
        }
        #endregion
    }
}
