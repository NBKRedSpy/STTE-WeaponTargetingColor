using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using static RST.VisualSettings;

namespace WeaponTargetingColor
{
    internal class TargetingColor
    {
        public Color Color { get; private set; }
        public Color InnerColor { get; private set; }

        public TargetingColor()
        {
                
        }
        public TargetingColor(string htmlColor, string defaultHtmlColor, string htmlInnerColor, string defaultHtmlInnerColor)
        {
            Color = ParseColor(htmlColor, defaultHtmlColor);
            InnerColor = ParseColor(htmlInnerColor, defaultHtmlInnerColor);
        }

        /// <summary>
        /// Tries to parse the html color.  On failure, uses the html default color.
        /// </summary>
        /// <param name="htmlColor"></param>
        /// <param name="htmlDefaultColor"></param>
        /// <returns></returns>
        private Color ParseColor(string htmlColor, string htmlDefaultColor)
        {
            Color color;
            if(!ColorUtility.TryParseHtmlString("#" + htmlColor, out color))
            {
                ColorUtility.TryParseHtmlString("#" + htmlDefaultColor, out color);
            }

            return color;
        }

        /// <summary>
        /// Sets the colors for the game's weapon sectors
        /// </summary>
        /// <param name="target"></param>
        public void SetColors(WeaponSectorColors target)
        {
            target.innerColor = InnerColor;
            target.color = Color;
        }
    }
}
