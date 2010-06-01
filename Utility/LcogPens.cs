using System;
using System.Drawing;

namespace LcogClient.Utility
{
    public class LcogPens
    {
        public static Pen Planet
        {
            get
            {
                return Pens.White;
            }
        }
        public static Pen Ship
        {
            get
            {
                return Pens.White;
            }
        }

        public static Pen OwnPlanet
        {
            get
            {
                return Pens.Blue;
            }
        }
        public static Pen NeutralPlanet
        {
            get
            {
                return Pens.Orange;
            }
        }
        public static Pen HostilePlanet
        {
            get
            {
                return Pens.Red;
            }
        }
        public static Pen NeutralShip
        {
            get
            {
                return Pens.Red;
            }
        }
        public static Pen HostileShip
        {
            get
            {
                return Pens.Red;
            }
        }
        public static Pen Target
        {
            get
            {
                return Pens.Yellow;
            }
        }
        public static Pen Selected
        {
            get
            {
                return Pens.Yellow;
            }
        }
        public static Pen OwnShip
        {
            get
            {
                return Pens.Green;
            }
        }
    }
}
