using System;
using System.Collections.Generic;
using System.Drawing;

using LcogClient.Utility;

namespace LcogClient.Model
{
    /// <summary>
    /// Represents the game map which is a collection of map objects.
    /// </summary>
    public class Map : List<MapObject>
    {
        #region Properties
        /// <summary>
        /// Name of the map.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Size of the map.
        /// </summary>
        public int Size { get; set; }
        /// <summary>
        /// Readonly property - this creates a bitmap image based on the 
        /// state of the map and all its objects.
        /// </summary>
        public Image Image
        {
            get
            {
                Bitmap bm = new Bitmap(this.Size, this.Size);

                Graphics g = Graphics.FromImage(bm);

                //g.DrawRectangle(Pens.Yellow, 0, 0, this.Size, this.Size);
                this.Draw(g);

                // dispose of the resource
                g.Dispose();

                return (Image)bm;
            }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Default constructor.
        /// </summary>
        public Map()
        {
        }  
        #endregion

        #region Get/Find Methods

        public Planet GetPlanetByID(int id)
        {
            foreach (MapObject obj in this)
            {
                if (obj.GetType() == typeof(Planet))
                {
                    if (obj.ID == id)
                    {
                        return (Planet)obj;
                    }
                }
            }
            return null;
        }

        public Ship GetShipByID(int id)
        {
            foreach (MapObject obj in this)
            {
                if (obj.GetType() == typeof(Ship))
                {
                    if (obj.ID == id)
                    {
                        return (Ship)obj;
                    }
                }
            }
            return null;
        }

        public List<Ship> GetAllShipsAtLocation(Point point)
        {
            List<Ship> allShips = new List<Ship>();

            foreach (MapObject obj in this)
            {
                if (obj.GetType() == typeof(Ship) && obj.Location == point)
                {
                    allShips.Add((Ship)obj);
                }
            }

            return allShips;
        }

        public List<Ship> ShipsNearLocation(Point point)
        {
            List<Ship> nearShips = new List<Ship>();

            foreach (MapObject obj in this)
            {
                if (obj.GetType() == typeof(Ship) && Lcog2D.Distance(obj.Location, point, this.Size) < 20)
                {
                    nearShips.Add((Ship)obj);
                }
            }

            return nearShips;
        }

        public Planet GetPlanetAtLocation(Point point)
        {
            foreach (MapObject obj in this)
            {
                if (obj.GetType() == typeof(Planet) && obj.Location == point)
                {
                    return (Planet)obj;
                }
            }

            return null;
        }

        public MapObject GetNearestObject(Point point)
        {
            // assign first object in list as nearest
            MapObject nearest = this[0];
            // now iterate thro' list and re-assign if object is closer
            foreach (MapObject obj in this)
            {
                if (Lcog2D.Distance(obj.Location, point, this.Size) < Lcog2D.Distance(nearest.Location, point, this.Size))
                {
                    nearest = obj;
                }
                else if (Lcog2D.Distance(obj.Location, point, this.Size) == Lcog2D.Distance(nearest.Location, point, this.Size))
                {
                    if (nearest.Faction != Client.Instance.Player.Faction && obj.Faction == Client.Instance.Player.Faction)
                    {
                        nearest = obj;
                    }
                }
            }
            return nearest;
        }

        public List<MapObject> GetNearestObjects(Point point)
        {
            List<MapObject> nearObjects = new List<MapObject>();

            foreach (MapObject obj in this)
            {
                if (Lcog2D.Distance(obj.Location, point, this.Size) < LcogConfig.ShipTargetRadius)
                {
                    nearObjects.Add(obj);
                }
            }

            return nearObjects;
        }

        public List<MapObject> GetAllAtLocation(Point point)
        {
            List<MapObject> returnObjs = new List<MapObject>();

            foreach (MapObject obj in this)
            {
                if (obj.Location == point)
                {
                    returnObjs.Add(obj);
                }
            }
            return returnObjs;
        }


        public List<MapObject> GetAllOthersAtLocation(MapObject mapObj)
        {
            List<MapObject> returnObjs = new List<MapObject>();

            foreach (MapObject obj in this)
            {
                if (obj.Location == mapObj.Location && obj != mapObj)
                {
                    returnObjs.Add(obj);
                }
            }
            return returnObjs;
        }
        #endregion

        #region Draw
        /// <summary>
        /// Draws the map using the given Graphics context.
        /// </summary>
        /// <param name="g">Graphics context.</param>
        public void Draw(Graphics g)
        {
            foreach (MapObject obj in this)
            {
                obj.Draw(g);
            }
            if (Client.Instance.Selected != null)
            {
                // ensure selected always visible (quick z-order hack;)
                Client.Instance.Selected.Draw(g);
            }

            // display actual size of map with white square
           /// g.DrawLine(Pens.White, new Point(0, 0), new Point(this.Size, 0));
            //g.DrawLine(Pens.White, new Point(0, 0), new Point(0, this.Size));
           // g.DrawLine(Pens.White, new Point(this.Size, 0), new Point(this.Size, this.Size));
            //g.DrawLine(Pens.White, new Point(this.Size, this.Size), new Point(this.Size, this.Size));
        }
        #endregion
    }
}
