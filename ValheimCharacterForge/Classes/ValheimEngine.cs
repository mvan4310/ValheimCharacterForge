using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/// <summary>
/// Credit to https://github.com/byt3m/Valheim-Character-Editor/ for this code
/// Stripped code into a new Character class, or into separate files
/// </summary>
namespace ValheimCharacterForge.Classes
{
    class ValheimEngine // This class should only be used to "store" the reverse engineered classes from the game and other required structs like Vec3.
    {
        static public string[] BeardsUI = { "No beard", "Braided 1", "Braided 2", "Braided 3", "Braided 4", "Long 1", "Long 2", "Short 1", "Short 2", "Short 3", "Thick 1" };
        static public string[] BeardsInternal = { "BeardNone", "Beard5", "Beard6", "Beard9", "Beard10", "Beard1", "Beard2", "Beard3", "Beard4", "Beard7", "Beard8" };
        static public string[] HairsUI = { "No hair", "Braided 1", "Braided 2", "Braided 3", "Braided 4", "Long 1", "Ponytail 1", "Ponytail 2", "Ponytail 3", "Ponytail 4", "Short 1", "Short 2", "Side Swept 1", "Side Swept 2", "Side Swept 3" };
        static public string[] HairsInternal = { "HairNone", "Hair3", "Hair11", "Hair12", "Hair13", "Hair6", "Hair1", "Hair2", "Hair4", "Hair7", "Hair5", "Hair8", "Hair9", "Hair10", "Hair14" };

        static public string NameDisallowedCharacters = "0123456789,;.:-_´¨{}][+*`^¡¿'?=)(/&¬%$·#@!|ª\\º\"'";
    }
}
