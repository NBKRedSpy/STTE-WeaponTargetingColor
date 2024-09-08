using BepInEx;
using BepInEx.Configuration;
using BepInEx.Logging;
using HarmonyLib;
using RST;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace WeaponTargetingColor
{

    [BepInPlugin(MyPluginInfo.PLUGIN_GUID, MyPluginInfo.PLUGIN_NAME, MyPluginInfo.PLUGIN_VERSION)]
    public class Plugin : BaseUnityPlugin
    {

        internal static string ModAssemblyName => Assembly.GetExecutingAssembly().GetName().Name;

        internal static ManualLogSource Log { get; set; }

        /// <summary>
        /// If true, will write the game's default colors to the log.
        /// </summary>
        internal static bool LogColors { get; private set; }

        /// <summary>
        /// Currently selected weapon
        /// </summary>
        internal static TargetingColor SelectedColor { get; private set; }

        /// <summary>
        /// A weapon is targeting.
        /// </summary>
        internal static TargetingColor CursorColor { get; private set; }

        /// <summary>
        /// An existing target.
        /// </summary>
        internal static TargetingColor SectorColor { get; private set; }

        private void Awake()
        {
            Log = Logger;

            LogColors = Config.Bind("Debug", nameof(LogColors), false,
                "If true, will write the game's default colors to the log.").Value;

            SelectedColor = ParseConfigColor("SelectedColor", "005F0040", "00270040", "when a weapon is currently selected");
            CursorColor = ParseConfigColor("CursorColor", "7D000000", "3C000000", "when selecting a new target");
            SectorColor = ParseConfigColor("ExistingColor", "32323C00", "14141900", "when a weapon already has a target");
       
            Harmony harmony = new Harmony(MyPluginInfo.PLUGIN_GUID);
            harmony.PatchAll();
        }

        private TargetingColor ParseConfigColor(string configName, 
            string defaultHtmlColor, string defaultHtmlInnerColor,
            string descriptionPrefix)
        {
            string color = Config.Bind("Option", configName + "Box", defaultHtmlColor, 
                $"The targeting box {descriptionPrefix}.  RGBA format.").Value;
            string innerColor = Config.Bind("Option", configName + "Tail", defaultHtmlInnerColor,
                $"The targeting tail {descriptionPrefix}.  RGBA format.").Value;

            return new TargetingColor(color, defaultHtmlColor, innerColor, defaultHtmlInnerColor);
        }
    }
}
