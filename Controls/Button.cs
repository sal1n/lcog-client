using System;
using System.Drawing;
using System.Windows.Forms;

namespace LcogClient.Controls
{
    /// <summary>
    /// Button base class.
    /// </summary>
    public class Button : System.Windows.Forms.Button
    {
        #region Properties
        /// <summary>
        /// Default colour of the button.
        /// </summary>
        public Color BaseColor { get; set; }
        /// <summary>
        /// Highlight colour.
        /// </summary>
        public Color HighlightColor { get; set; }
        #endregion

        #region Constructors
        /// <summary>
        /// Default constructor.
        /// </summary>
        public Button()
        {   
            // @todo this is ignored for some reason and must be redone in designer, investigate
            this.UseVisualStyleBackColor = false;
            // set some defaults.
            this.BaseColor = SystemColors.Control;
            this.HighlightColor = Color.Khaki;
        }
        #endregion

        #region Event Handlers
        /// <summary>
        /// OnMouseEnter.
        /// </summary>
        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            this.BackColor = this.HighlightColor;
        }
        /// <summary>
        /// OnMouseLeave.
        /// </summary>
        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            this.BackColor = this.BaseColor;
        }
        #endregion
    }
}