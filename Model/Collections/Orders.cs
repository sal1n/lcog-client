using System;
using System.Collections.Generic;

using LcogClient.Model.Orders;

namespace LcogClient.Model.Collections
{
    /// <summary>
    /// List of players current orders with add and get methods for each Order type.
    /// </summary>
    public class Orders : List<Order>
    {
        #region Build

        public void CancelBuild(MapObject obj)
        {
            this.Remove(this.GetBuildOrder(obj));
            this.Remove(this.GetUpgradeOrder(obj));
        }

        public void AddBuildOrder(Build build)
        {
            this.Remove(this.GetBuildOrder(build.MapObject));
            this.Remove(this.GetUpgradeOrder(build.MapObject));
            this.Add(build);
        }

        public Build GetBuildOrder(MapObject obj)
        {
            foreach (Order order in this)
            {
                if (order.GetType() == typeof(Build))
                {
                    Build b = (Build)order;
                    if (b.MapObject == obj)
                    {
                        return (Build)order;
                    }
                }
            }
            return null;
        }

        #endregion

        #region Colonise

        public void CancelColonise(Ship ship)
        {
            this.Remove(this.GetColoniseOrder(ship));
        }

        public void AddColoniseOrder(Colonise colonise)
        {
            this.Remove(this.GetColoniseOrder(colonise.Ship));
            this.Add(colonise);
        }

        public Colonise GetColoniseOrder(Ship ship)
        {
            foreach (Order order in this)
            {
                if (order.GetType() == typeof(Colonise))
                {
                    Colonise b = (Colonise)order;
                    if (b.Ship == ship)
                    {
                        return (Colonise)order;
                    }
                }
            }
            return null;
        }
        #endregion

        #region Diplomacy

        public void AddDiplomacyOrder(Diplomacy diplomacy)
        {
            this.Remove(this.GetDiplomacyOrder(diplomacy.Faction));
            this.Add(diplomacy);
        }

        public Diplomacy GetDiplomacyOrder(Faction faction)
        {
            foreach (Order order in this)
            {
                if (order.GetType() == typeof(Diplomacy))
                {
                    Diplomacy d = (Diplomacy)order;
                    if (d.Faction == faction)
                    {
                        return (Diplomacy)order;
                    }
                }
            }
            return null;
        }
        #endregion

        #region Intercept

        public void AddInterceptOrder(Intercept intercept)
        {
            this.Remove(this.GetInterceptOrder(intercept.Ship));
            this.Remove(this.GetMoveOrder(intercept.Ship));
            this.Add(intercept);
        }

        public Intercept GetInterceptOrder(MapObject obj)
        {
            foreach (Order o in this)
            {
                if (o.GetType() == typeof(Intercept))
                {
                    Intercept move = (Intercept)o;
                    if (move.Ship == obj)
                    {
                        return (Intercept)o;
                    }
                }
            }
            return null;
        }

        #endregion

        #region Move

        public void CancelMove(Ship ship)
        {
            ship.Waypoint = ship.Location;
            this.Remove(this.GetMoveOrder(ship));
            this.Remove(this.GetInterceptOrder(ship));
        }

        public void AddMoveOrder(Move move)
        {
            this.Remove(this.GetMoveOrder(move.Ship));
            this.Remove(this.GetInterceptOrder(move.Ship));
            this.Add(move);
        }

        public Move GetMoveOrder(MapObject obj)
        {
            foreach (Order o in this)
            {
                if (o.GetType() == typeof(Move))
                {
                    Move move = (Move)o;
                    if (move.Ship == obj)
                    {
                        return (Move)o;
                    }
                }
            }
            return null;
        }

        #endregion

        #region Rename

        public void AddRenameOrder(Rename rename)
        {
            this.Remove(this.GetRenameOrder(rename.Obj));
            this.Add(rename);
        }

        public Rename GetRenameOrder(LcogObject obj)
        {
            foreach (Order o in this)
            {
                if (o.GetType() == typeof(Rename))
                {
                    Rename rename = (Rename)o;
                    if (rename.Obj == obj)
                    {
                        return rename;
                    }
                }
            }
            return null;
        }
        #endregion

        #region Repair

        public void AddRepairOrder(Repair repair)
        {
            this.Remove(this.GetRepairOrder(repair.Ship));
            this.Add(repair);
        }

        public Repair GetRepairOrder(Ship ship)
        {
            foreach (Order order in this)
            {
                if (order.GetType() == typeof(Repair))
                {
                    Repair repair = (Repair)order;
                    if (repair.Ship == ship)
                    {
                        return repair;
                    }
                }
            }
            return null;
        }
        #endregion

        #region Research

        public void AddResearchOrder(Research research)
        {
            this.Remove(this.GetResearchOrder());
            this.Add(research);
        }

        public Research GetResearchOrder()
        {
            foreach (Order order in this)
            {
                if (order.GetType() == typeof(Research))
                {
                    return (Research)order;   
                }
            }
            return null;
        }
        #endregion

        #region Upgrade

        public void AddUpgradeOrder(Upgrade upgrade)
        {
            this.Remove(this.GetUpgradeOrder(upgrade.Factory));
            this.Remove(this.GetBuildOrder(upgrade.Factory));
            this.Add(upgrade);
        }

        public Upgrade GetUpgradeOrder(MapObject obj)
        {
            foreach (Order order in this)
            {
                if (order.GetType() == typeof(Upgrade))
                {
                    Upgrade upgrade = (Upgrade)order;
                    if (upgrade.Factory == obj)
                    {
                        return upgrade;
                    }
                }
            }
            return null;
        }
        #endregion

        public string ToXml()
        {
            string xml = "";

            xml += "<orders>\n";
            foreach (Order order in this)
            {
                xml += order.ToXml();
            }
            xml += "</orders>";
            return xml;
        }
    }
}
