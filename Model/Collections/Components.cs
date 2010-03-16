using System;
using System.Collections.Generic;

namespace LcogClient.Model.Collections
{
    /// <summary>
    /// 
    /// </summary>
    public class Components : List<Component>
    {
        /// </summary>
        /// Returns the component for a given string name, null if it can't be found.
        /// <param name="name">Component name</param>
        /// <returns>Component</returns>
        public Component GetComponentByName(string name)
        {
            foreach (Component component in this)
            {
                if (component.Name == name)
                {
                    return component;
                }
            }
            return null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Component> GetDistinctComponents()
        {
            Components components = new Components();

            foreach (Component component in this)
            {
                if (components.GetComponentByName(component.Name) == null)
                {
                    components.Add(component);
                }
            }
            return components;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public int GetComponentCount(string name)
        {
            int i = 0;

            foreach (Component component in this)
            {
                if (component.Name == name)
                {
                    i++;
                }
            }
            return i;
        }
    }
}
