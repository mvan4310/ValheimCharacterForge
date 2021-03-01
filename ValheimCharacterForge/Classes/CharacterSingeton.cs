using ElectronNET.API;
using ElectronNET.API.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ValheimCharacterForge.Models;

namespace ValheimCharacterForge.Classes
{
    public class CharacterSingeton
    {
        public Character[] AllCharacters { get; set; }
        public Character Character { get; set; }
        public string[] KnownMaterials { get; set; }

        static public HashSet<HairColorPreset> HairColorPresets = new HashSet<HairColorPreset>
        {
            new HairColorPreset { Name = "Black", Red = 0.106f, Green = 0.1f, Blue = 0.075f },
            new HairColorPreset { Name = "Blonde", Red = 1f, Green = 0.71f, Blue = 0.49f },
            new HairColorPreset { Name = "Ginger", Red = 0.70f, Green = 0.34f, Blue = 0.20f },
            new HairColorPreset { Name = "Brown", Red = 0.525f, Green = 0.374f, Blue = 0.26f },
            new HairColorPreset { Name = "White", Red = 0.81f, Green = 0.75f, Blue = 0.57f },
        };

        public bool Initialize(string name)
        {
            try
            {
                Character = AllCharacters.FirstOrDefault(a => a.Data.Name == name);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public HairColorPreset FindClosestPreset(Vector3 color)
        {
            HairColorPreset closestPreset = HairColorPresets.First();
            float lowestDist = 2;   // just has to be larger than sqrt(2)
            foreach (var preset in HairColorPresets)
            {
                // distance between points in 3d space
                float distance = Math.Abs(preset.Red * preset.Green * preset.Blue - color.X * color.Y * color.Z);
                if (distance <= lowestDist)
                {
                    lowestDist = distance;
                    closestPreset = preset;
                }
            }

            return closestPreset;
        }

        public bool WriteCustomization()
        {
            // Check again if game is running to avoid problems
            if (Util.IsGameRunning())
            {
                return false;
            }

            // Currently writting to the same .FCH file. I changed this because windows has limitations for file names and people will
            // start using forbidden characters which will result in a crash when writting file. Also, the characters combobox now shows the character
            // names instead of file names, so there is not really a need to change the filename as the user will always see his in-game name in the GUI.
            // No need to check WriteAllBytes as it does not return any value. If fails it will go to the Form1 Try-Catch block
            // No need to check backup because it is already checked when it is done in Util.
            File.WriteAllBytes(Character.File, Parser.CharacterWriteData(Character.Data));

            return true;
        }
    }
}