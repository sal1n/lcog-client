using System;
using System.Collections.Generic;
using System.Windows;

using LcogClient.Controls;
using LcogClient.Model;

namespace LcogClient.Utility
{
    public class LcogComponentFactory
    {
        private static string engine = "engine";
        private static string factory = "factory";
        private static string landing_craft = "landing craft";
        private static string lab = "lab";
        private static string beam = "beam";
        private static string steel_plating = "steel plating";
        private static string torpedo = "torpedo";
        private static string enhanced_beam = "enhanced beam";
        private static string shield = "shield";
        private static string long_range_beam = "long range beam";
        private static string plasteel_armour = "plasteel armour";
        private static string ion_drive = "ion drive";
        private static string blaster = "blaster";
        private static string enhanced_shield = "enhanced shield";
        private static string plasma_torpedo = "plasma torpedo";

        public static List<Base> GetComponentControl(Model.MapObject obj, bool isBuild)
        {
            List<Base> list = new List<Base>();

            if (obj.Components.GetComponentByName(engine) != null)
            {
                list.Add(new EngineComponent(obj, isBuild));
                //list.Add(new GenericComponent(global::LcogClient.Properties.Resources.engine, "Engine component", obj.Components.GetComponentCount(engine).ToString()));
            }
            if (obj.Components.GetComponentByName(factory) != null)
            {
                list.Add(new FactoryComponent(obj, isBuild));
               // list.Add(new GenericComponent(global::LcogClient.Properties.Resources.factory, "Factory component", obj.Components.GetComponentCount(factory).ToString()));
            }
            if (obj.Components.GetComponentByName(landing_craft) != null)
            {
                list.Add(new LandingCraftComponent(obj, isBuild));
                //list.Add(new GenericComponent(global::LcogClient.Properties.Resources.landing_craft, "Landing craft component", obj.Components.GetComponentCount(landing_craft).ToString()));
            }
            if (obj.Components.GetComponentByName(lab) != null)
            {
                list.Add(new GenericComponent(global::LcogClient.Properties.Resources.light_bulb_16x16, "Labs", obj.Components.GetComponentCount(lab).ToString()));
            }
            if (obj.Components.GetComponentByName(beam) != null)
            {
                list.Add(new GenericComponent(global::LcogClient.Properties.Resources.beam_16x16, "Beams", obj.Components.GetComponentCount(beam).ToString()));
            }
            if (obj.Components.GetComponentByName(steel_plating) != null)
            {
                list.Add(new GenericComponent(global::LcogClient.Properties.Resources.steel_plate_16x16, "Steel plating", obj.Components.GetComponentCount(steel_plating).ToString()));
            }
            if (obj.Components.GetComponentByName(torpedo) != null)
            {
                list.Add(new GenericComponent(global::LcogClient.Properties.Resources.torpedo_16x16, "Torpedos", obj.Components.GetComponentCount(torpedo).ToString()));
            }
            if (obj.Components.GetComponentByName(enhanced_beam) != null)
            {
                list.Add(new GenericComponent(global::LcogClient.Properties.Resources.enhanced_beam_16x16, "Enhanced beams", obj.Components.GetComponentCount(enhanced_beam).ToString()));
            }
            if (obj.Components.GetComponentByName(shield) != null)
            {
                list.Add(new GenericComponent(global::LcogClient.Properties.Resources.shield_16x16, "Shields", obj.Components.GetComponentCount(shield).ToString()));
            }
            if (obj.Components.GetComponentByName(plasteel_armour) != null)
            {
                list.Add(new GenericComponent(global::LcogClient.Properties.Resources.plasteel_16x16, "Plasteel armour", obj.Components.GetComponentCount(plasteel_armour).ToString()));
            }
            if (obj.Components.GetComponentByName(long_range_beam) != null)
            {
                list.Add(new GenericComponent(global::LcogClient.Properties.Resources.long_range_beam_16x16, "Long range beams", obj.Components.GetComponentCount(long_range_beam).ToString()));
            }
            if (obj.Components.GetComponentByName(ion_drive) != null)
            {
                list.Add(new GenericComponent(global::LcogClient.Properties.Resources.ion_drive_16x16, "Ion drive component", obj.Components.GetComponentCount(ion_drive).ToString()));
            }
            if (obj.Components.GetComponentByName(enhanced_shield) != null)
            {
                list.Add(new GenericComponent(global::LcogClient.Properties.Resources.enhanced_shield_16x16, "Enhanced shields", obj.Components.GetComponentCount(enhanced_shield).ToString()));
            }
            if (obj.Components.GetComponentByName(blaster) != null)
            {
                list.Add(new GenericComponent(global::LcogClient.Properties.Resources.blaster_16x16, "Blasters", obj.Components.GetComponentCount(blaster).ToString()));
            }
            if (obj.Components.GetComponentByName(plasma_torpedo) != null)
            {
                list.Add(new GenericComponent(global::LcogClient.Properties.Resources.plasma_torpedo_16x16, "Plasma torpedos", obj.Components.GetComponentCount(plasma_torpedo).ToString()));
            }

            return list;
        }
    }
}