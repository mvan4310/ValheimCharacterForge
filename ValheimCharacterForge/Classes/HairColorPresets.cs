using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ValheimCharacterForge.Models;
/// <summary>
/// Credit to https://github.com/byt3m/Valheim-Character-Editor/ for this code
/// 
/// </summary>
namespace ValheimCharacterForge.Classes
{
    public static class HairColorPresets
    {
        static public HashSet<HairColorPreset> GetHairColorPresets = new HashSet<HairColorPreset>
        {
            new HairColorPreset { Name = "Black", Red = 0.106f, Green = 0.1f, Blue = 0.075f },
            new HairColorPreset { Name = "Blonde", Red = 1f, Green = 0.71f, Blue = 0.49f },
            new HairColorPreset { Name = "Ginger", Red = 0.70f, Green = 0.34f, Blue = 0.20f },
            new HairColorPreset { Name = "Brown", Red = 0.525f, Green = 0.374f, Blue = 0.26f },
            new HairColorPreset { Name = "White", Red = 0.81f, Green = 0.75f, Blue = 0.57f },
        };
    }
}
