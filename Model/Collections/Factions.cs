using System;
using System.Collections.Generic;

namespace LcogClient.Model.Collections
{
    public class Factions : List<Faction>
    {
        public Faction GetFactionByID(int id)
        {
            foreach (Faction faction in this)
            {
                if (faction.ID == id)
                {
                    return faction;
                }
            }
            return null;
        }

        public Faction GetFactionByName(string name)
        {
            foreach (Faction faction in this)
            {
                if (faction.Name == name)
                {
                    return faction;
                }
            }
            return null;
        }
    }
}
