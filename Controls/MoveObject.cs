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
    public partial class MoveObject : UserControl
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
        public MoveObject()
        {
            InitializeComponent();

            this.InitialiseEventHandlers();
        }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="obj">Map object to display</param>
        public MoveObject(Model.MapObject obj)
        {
            InitializeComponent();

            this.InitialiseEventHandlers();

            this.MapObject = obj;

            this.pictureBox.Image = obj.Image;
            this.labelObjectName.Text = obj.Name + " [" + obj.ID.ToString() + "]";

            if (obj.Faction != null)
            {
                this.labelFactionName.Text = obj.Faction.Name + " [" + obj.Faction.ID.ToString() + "]";
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

            this.pictureBox.MouseEnter += new EventHandler(other_Object_MouseEnter);
            this.labelObjectName.MouseEnter += new EventHandler(other_Object_MouseEnter);
            this.labelFactionName.MouseEnter += new EventHandler(other_Object_MouseEnter);
            this.labelMassOrEnergy.MouseEnter += new EventHandler(other_Object_MouseEnter);
            this.MouseEnter += new EventHandler(other_Object_MouseEnter);

            this.pictureBox.MouseLeave += new EventHandler(other_Object_MouseLeave);
            this.labelObjectName.MouseLeave += new EventHandler(other_Object_MouseLeave);
            this.labelFactionName.MouseLeave += new EventHandler(other_Object_MouseLeave);
            this.labelMassOrEnergy.MouseLeave += new EventHandler(other_Object_MouseLeave);
            this.MouseLeave += new EventHandler(other_Object_MouseLeave);
        }
        #endregion

        #region Event Handling
        void other_Object_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.BlanchedAlmond;
        }

        void other_Object_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        void otherObject_Click(object sender, EventArgs e)
        {
            if (this.MapObject.GetType() == typeof(Planet))
            {
                Ship ship = (Ship)Client.Instance.Selected;
                Planet target = (Planet)this.MapObject;
                ship.Move(target.Location);
            }
            else if (this.MapObject.GetType() == typeof(Ship))
            {
                Ship ship = (Ship)Client.Instance.Selected;
                Ship target = (Ship)this.MapObject;
                ship.Intercept(target);
            }
            Client.Instance.UpdateView();
            ParentForm.Close();
        }
        #endregion
    }
}
