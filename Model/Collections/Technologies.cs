using System;
using System.Collections.Generic;

namespace LcogClient.Model.Collections
{
    public class Technologies : List<Technology>
    {

        public string Researching { get; set; }
        public int CurrentResearch { get; set; }

        public bool HasTechnologyLevel(Technologies tech)
        {
            foreach (Technology t in tech)
            {
                if (this.GetTechnologyLevel(t.Name) < t.Level)
                {
                     return false;
                }
            }
            return true;
        }

        public bool HasTechnology(string name)
        {
            foreach (Technology technology in this)
            {
                if (technology.Name == name)
                {
                    return true;
                }
            }
            return false;
        }

        public int GetTechnologyLevel(string name)
        {
            foreach (Technology technology in this)
            {
                if (technology.Name == name)
                {
                    return technology.Level;
                }
            }
            return 0;
        }

        public int GetResearchLevel(string name)
        {
            foreach (Technology technology in this)
            {
                if (technology.Name == name)
                {
                    return technology.Research;
                }
            }
            return 0;
        }
    }
}
