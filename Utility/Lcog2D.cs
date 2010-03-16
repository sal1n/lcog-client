using System;
using System.Drawing;

namespace LcogClient.Utility
{
    /// <summary>
    /// Utility methods for dealing with 2d wrap-around map.
    /// </summary>
    public class Lcog2D
    {
        /// <summary>
        /// Standard Euclidean distance between 2 points.
        /// </summary>
        public static double EuclideanDistance(Point a, Point b)
        {
            int dx = b.X - a.X;
            int dy = b.Y - a.Y;
            return Math.Sqrt((dx * dx) + (dy * dy));
        }

        /// <summary>
        /// Returns Euclidean distance on a torus (self-enclosed grid e.g., 2D wraparound map).
        /// </summary>
        public static double Distance(Point a, Point b, int size)
        {
            int x = Math.Abs(b.X - a.X);
            int y = Math.Abs(b.Y - a.Y);

            int minX = Math.Min(x, (size - x));
            minX *= minX;

            int minY = Math.Min(y, (size - y));
            minY *= minY;

            return Math.Sqrt(minX + minY);
        }

        /// <summary>
        /// Hideously over-complicated method for drawing a line between 2 points
        /// on a 2d wrap-around map.  Must be a much nicer solution for this, probably
        /// involving triangles;)
        /// </summary>
        public static void DrawLine(Point a, Point b, int size, Graphics g, Pen pen)
        {
            Point left = new Point(-(size * 2), size);
            Point right = new Point(size * 2, size);
            Point top = new Point(size, -(size * 2));
            Point bottom = new Point(size, size * 2);

            Point intersectX = new Point();
            Point intersectY = new Point();

            if (WrapX(a, b, size) && WrapY(a, b, size)) // cross both axis 
            {
                if (a.X > b.X && a.Y < b.Y) // top-right
                {
                    IntersectionOfTwoLines(a, new Point(b.X + size, b.Y - size), top, bottom, ref intersectY);
                    IntersectionOfTwoLines(new Point(a.X - size, a.Y + size), b, left, right, ref intersectX);
                    g.DrawLine(pen, a, intersectY);
                    g.DrawLine(pen, b, intersectX);
                    g.DrawLine(pen, new Point(intersectX.X, 0), new Point(0, intersectY.Y));
                }
                else if (a.X < b.X && a.Y < b.Y) // top-left [todo]
                {
                    IntersectionOfTwoLines(a, new Point(b.X + size, b.Y + size), left, right, ref intersectY);
                    IntersectionOfTwoLines(a, new Point(b.X + size, b.Y + size), top, bottom, ref intersectX);
                    g.DrawLine(pen, a, intersectY);
                    g.DrawLine(pen, b, intersectX);
                }
                else if (a.X > b.X && a.Y > b.Y) // bottom-right [todo]
                {
                }
                else if (a.X < b.X && a.Y > b.Y)  // bottom-left [todo]
                {
                }
            }
            else if (WrapX(a, b, size)) // cross y-axis 
            {
                if (a.X > b.X) // right 
                {
                    IntersectionOfTwoLines(a, new Point(b.X + size, b.Y), top, bottom, ref intersectY);
                    g.DrawLine(pen, a, intersectY);
                    g.DrawLine(pen, b, new Point(0, intersectY.Y));
                }
                else // left 
                {
                    IntersectionOfTwoLines(new Point(a.X + size, a.Y), b, top, bottom, ref intersectY);
                    g.DrawLine(pen, a, new Point(0, intersectY.Y));
                    g.DrawLine(pen, b, new Point(size, intersectY.Y));
                }
            }
            else if (WrapY(a, b, size)) // cross x-axis 
            {
                if (a.Y < b.Y) // top
                {
                    IntersectionOfTwoLines(new Point(a.X, a.Y + size), b, left, right, ref intersectX);
                    g.DrawLine(pen, a, new Point(intersectX.X, 0));
                    g.DrawLine(pen, b, intersectX);
                }
                else // bottom
                {
                    IntersectionOfTwoLines(a, new Point(b.X, b.Y + size), left, right, ref intersectX);
                    g.DrawLine(pen, a, intersectX);
                    g.DrawLine(pen, b, new Point(intersectX.X, 0));
                }
            }
            else // just draw the ruddy line 
            {
                g.DrawLine(pen, a, b);
            }
        }

        public static bool IntersectionOfTwoLines(Point a, Point b, Point c, Point d, ref Point intersect)
        {
            double r, s;

            double denominator = (b.X - a.X) * (d.Y - c.Y) - (b.Y - a.Y) * (d.X - c.X);

            // If the denominator in above is zero, AB & CD are colinear
            if (denominator == 0)
                return false;

            double numeratorR = (a.Y - c.Y) * (d.X - c.X) - (a.X - c.X) * (d.Y - c.Y);
            //  If the numerator above is also zero, AB & CD are collinear.
            //  If they are collinear, then the segments may be projected to the x- 
            //  or y-axis, and overlap of the projected intervals checked.

            r = numeratorR / denominator;

            double numeratorS = (a.Y - c.Y) * (b.X - a.X) - (a.X - c.X) * (b.Y - a.Y);

            s = numeratorS / denominator;

            //  If 0<=r<=1 & 0<=s<=1, intersection exists
            //  r<0 or r>1 or s<0 or s>1 line segments do not intersect
            if (r < 0 || r > 1 || s < 0 || s > 1)
                return false;

            ///*
            //    Note:
            //    If the intersection point of the 2 lines are needed (lines in this
            //    context mean infinite lines) regardless whether the two line
            //    segments intersect, then
            //
            //        If r>1, P is located on extension of AB
            //        If r<0, P is located on extension of BA
            //        If s>1, P is located on extension of CD
            //        If s<0, P is located on extension of DC
            //*/

            // Find intersection point
            intersect.X = (int)(a.X + (r * (b.X - a.X)));
            intersect.Y = (int)(a.Y + (r * (b.Y - a.Y)));

            return true;
        }

        /// <summary>
        /// Returns true if the shortest line between 2 points would wrap-around on the x-axis.
        /// </summary>
        public static bool WrapX(Point a, Point b, int size)
        {
            if ((int)Math.Abs(a.X - b.X) > (size / 2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Returns true if the shortest line between 2 points would wrap-around on the y-axis.
        /// </summary>
        public static bool WrapY(Point a, Point b, int size)
        {
            if ((int)Math.Abs(a.Y - b.Y) > (size / 2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
