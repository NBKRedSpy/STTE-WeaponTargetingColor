using HarmonyLib;
using RST;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;
using static RST.VisualSettings;

namespace WeaponTargetingColor
{
    /// <summary>
    /// Changes the default colors when the Visual Settings are inited.
    /// </summary>
    [HarmonyPatch(typeof(VisualSettings), nameof(VisualSettings.OnEnable))]
    public static class Example_Patch
    {
        public static void Postfix(VisualSettings __instance)
        {
            if (Plugin.LogColors) LogColors(__instance);

            Plugin.SectorColor.SetColors(__instance.weaponSectorColor);
            Plugin.CursorColor.SetColors(__instance.cursorWeaponSectorColor);
            Plugin.SelectedColor.SetColors(__instance.selectedWeaponSectorColor);
        }

        private static void LogColors(VisualSettings __instance)
        {

            Plugin.Log.LogInfo($"selectedWeaponSectorColor.color " +
                $"{ColorUtility.ToHtmlStringRGBA(__instance.selectedWeaponSectorColor.color)}");
            Plugin.Log.LogInfo($"selectedWeaponSectorColor.innerColor " +
                $"{ColorUtility.ToHtmlStringRGB(__instance.selectedWeaponSectorColor.innerColor)}");

            Plugin.Log.LogInfo($"cursorWeaponSectorColor.color " +
                $"{ColorUtility.ToHtmlStringRGBA(__instance.cursorWeaponSectorColor.color)}");
            Plugin.Log.LogInfo($"cursorWeaponSectorColor.innerColor " +
                $"{ColorUtility.ToHtmlStringRGBA(__instance.cursorWeaponSectorColor.innerColor)}");

            Plugin.Log.LogInfo($"weaponSectorColor.color " +
                $"{ColorUtility.ToHtmlStringRGBA(__instance.weaponSectorColor.color)}");
            Plugin.Log.LogInfo($"weaponSectorColor.innerColor " +
                $"{ColorUtility.ToHtmlStringRGBA(__instance.weaponSectorColor.innerColor)}");
        }
    }

}
