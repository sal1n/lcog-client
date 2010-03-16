using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

using LcogClient.Forms;
using LcogClient.Model;

namespace LcogClient.Controls
{
    /// <summary>
    /// A pannable, wrap-around display of a map object.
    /// 
    /// @todo  zoom (for the moment try moving your eyes closer to the screen;)
    ///        panning/wrap logic is pretty ugly/confusing, find better way of doing?!
    ///        this was a pain in the ass to get working correctly;)
    ///        scroll-bars (there IS a reason why I didn't just inherit from ScrollableControl 
    ///        - try it and see;) 
    /// </summary>
    public partial class Map : Base
    {
        #region Private Variables
        /// <summary>
        /// Reference to image being displayed.
        /// </summary>
        private Image image;
        /// <summary>
        /// x co-ordinate where the view actually displays (in relation to the absolute image source).
        /// </summary>
        private int x = 0;
        /// <summary>
        /// y co-ordinate where the view actually displays (in relation to the absolute image source).
        /// </summary>
        private int y = 0;
        /// <summary>
        /// Reference used for panning map with mouse.
        /// </summary>
        private Point previousPanPoint;
        #endregion

        #region Constructors
        /// <summary>
        /// Default constructor.
        /// </summary>
        public Map() : base()
        {
            InitializeComponent();

            this.MouseDown += new MouseEventHandler(MapControl_MouseDown);
            this.MouseMove += new MouseEventHandler(MapControl_MouseMove);
            this.MouseClick += new MouseEventHandler(MapControl_MouseClick);

          //  this.image = Client.Instance.Map.Image;
        }
        #endregion

        #region OnPaint
        /// <summary>
        /// Overriden OnPaint method to custom draw map.
        /// </summary>
        /// <param name="e">PaintEventArgs e</param>
        protected override void OnPaint(PaintEventArgs e)
        {
            if (this.image == null)
            {
                base.OnPaintBackground(e);
                return;
            }

            // if a break is found (either x or y)
            bool panbreak = false;  

            // get hold of the visible display dimensions
            Rectangle display = this.DisplayRectangle;
            int displayWidth = display.Width;
            int displayHeight = display.Height;

            // enforce bounds of source image
            if (this.x <= 0) { this.x += this.image.Width; }
            if (this.x >= this.image.Width) { this.x -= this.image.Width; }
            if (this.y <= 0) { this.y += this.image.Height; }
            if (this.y >= this.image.Height) { this.y -= this.image.Height; }

            // calculate where the breaks are
            int xbreak = this.image.Width - this.x;
            int ybreak = this.image.Height - this.y;

            // if there is no break then set the breaks to the extremes of the source image
            if (xbreak >= displayWidth) { xbreak = displayWidth; }
            if (ybreak >= displayHeight) { ybreak = displayHeight; }

            // a horizontal break
            if (xbreak != displayWidth)
            {
                Rectangle src1 = new Rectangle(x, y, xbreak, ybreak);
                Rectangle src2 = new Rectangle(0, y, displayWidth - xbreak, ybreak); ;

                Rectangle dest1 = new Rectangle(display.Left, display.Top, display.Left + xbreak, display.Top + ybreak);
                Rectangle dest2 = new Rectangle(display.Left + xbreak, display.Top, display.Right - xbreak, display.Top + ybreak);

                e.Graphics.DrawImage(this.image, dest1, src1, GraphicsUnit.Pixel);
                e.Graphics.DrawImage(this.image, dest2, src2, GraphicsUnit.Pixel);

                panbreak = true;
            }
            // a vertical break
            if (ybreak != displayWidth)
            {
                Rectangle src2 = new Rectangle(x, display.Top, displayWidth, display.Bottom - ybreak);
                Rectangle dest2 = new Rectangle(display.Left, ybreak, displayWidth, displayHeight - ybreak);

                // a 4-way break
                if (panbreak == true)
                {
                    Rectangle src1 = new Rectangle(0, 0, displayWidth - xbreak, displayHeight - ybreak);
                    Rectangle dest1 = new Rectangle(display.Left + xbreak, display.Top + ybreak, display.Right - xbreak, display.Bottom - ybreak);

                    e.Graphics.DrawImage(this.image, dest1, src1, GraphicsUnit.Pixel);
                }
                else
                {
                    Rectangle src1 = new Rectangle(x, y, x + displayWidth, ybreak);
                    Rectangle dest1 = new Rectangle(display.Left, display.Top, display.Left + xbreak, display.Top + ybreak);

                    e.Graphics.DrawImage(this.image, dest1, src1, GraphicsUnit.Pixel);
                }

                e.Graphics.DrawImage(this.image, dest2, src2, GraphicsUnit.Pixel);

                panbreak = true;
            }

            // no breaks, straightforward display
            if (panbreak == false)
            {
                Rectangle src1 = new Rectangle(this.x, this.y, displayWidth, displayHeight);
                Rectangle dest1 = new Rectangle(0, 0, displayWidth, displayHeight);
                e.Graphics.DrawImage(this.image, dest1, src1, GraphicsUnit.Pixel);
            }
        }
        #endregion

        #region Event Handlers

        void MapControl_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && Control.ModifierKeys == Keys.Shift)
            {
                if (Client.Instance.Selected.GetType() == typeof(Ship))
                {
                    if (Client.Instance.Selected.Faction == Client.Instance.Player.Faction)
                    {
                        Point relativeLocation = new Point();
                        relativeLocation.X = this.x + e.X;
                        relativeLocation.Y = this.y + e.Y;

                        // enforce bounds
                        if (relativeLocation.X <= 0) { relativeLocation.X += this.image.Width; }
                        if (relativeLocation.X >= this.image.Width) { relativeLocation.X -= this.image.Width; }
                        if (relativeLocation.Y <= 0) { relativeLocation.Y += this.image.Height; }
                        if (relativeLocation.Y >= this.image.Height) { relativeLocation.Y -= this.image.Height; }

                        Ship ship = (Ship)Client.Instance.Selected;

                        List<Model.MapObject> near = Client.Instance.Map.GetNearestObjects(relativeLocation);

                        if (near.Count == 1)
                        {
                            if (near[0].GetType() == typeof(Planet))
                            {
                                ship.Move(near[0].Location);
                                Client.Instance.UpdateView();
                            }
                            else if (near[0].GetType() == typeof(Ship))
                            {
                                Ship target = (Ship)near[0];
                                ship.Intercept(target);
                                Client.Instance.UpdateView();
                            }
                        }
                        else if (near.Count > 1)
                        {
                            Move form = new Move(near);
                            form.ShowDialog();
                        }
                    }
                }
            }
            else if (e.Button == MouseButtons.Left)
            {
                Point relativeLocation = new Point();
                relativeLocation.X = this.x + e.X;
                relativeLocation.Y = this.y + e.Y;

                Client.Instance.Target = null;

                Client.Instance.SelectNearestMapObject(relativeLocation);
                this.CenterOnPoint(relativeLocation);
            }
            else if (e.Button == MouseButtons.Right)
            {

            }
        }

        public void CenterOnPoint(Point point)
        {
            x = (point.X - this.Width / 2);
            y = (point.Y - this.Height / 2);
            this.Invalidate();
        }

        void MapControl_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int offsetX = e.X - this.previousPanPoint.X;
                int offsetY = e.Y - this.previousPanPoint.Y;
                this.x -= offsetX;
                this.y -= offsetY;
                this.previousPanPoint = e.Location;
                this.Invalidate();
            }
        }

        void MapControl_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.previousPanPoint = e.Location;
            }
        }
        #endregion

        /// <summary>
        /// Method used for handling explicit update events.
        /// </summary>
        public override void UpdateView(object source, EventArgs e)
        {
            this.image = Client.Instance.Map.Image;
            this.Invalidate();
        }
    }
}
