using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ValheimCharacterForge.Models;

/// <summary>
/// Credit to https://github.com/byt3m/Valheim-Character-Editor/ for this code
/// Stripped and moved blocks of code to other areas / separate files
/// </summary>
namespace ValheimCharacterForge.Classes
{
    class Customization
    {
        static public bool FirstRun = true;
        static public Character[] FoundCharacters;
        static public Character SelectedCharacter = new Character();

        static public Vector3 GetHairColor(int index)
        {
            return new Vector3
            {
                X = HairColorPresets.GetHairColorPresets.ElementAt(index).Red,
                Y = HairColorPresets.GetHairColorPresets.ElementAt(index).Green,
                Z = HairColorPresets.GetHairColorPresets.ElementAt(index).Blue,
            };
        }

        static public Character[] GetCharacters(string directory)
        {
            String dir = directory; // Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), @"AppData\LocalLow\IronGate\Valheim\characters");
            while (true)
            {
                if (!Directory.Exists(dir))
                {
                    //MessageBox.Show("Directory containing character information not found. Please, point me to the directory where character \".FCH\" files are held.", "ERROR", MessageBoxButtons.OK);
                    //dir = Util.OpenDirectoryDialog();
                }
                else
                {
                    break;
                }
            }

            String[] fchFiles = Directory.GetFiles(dir, "*.fch");
            if (fchFiles.Length == 0)
            {
                //MessageBox.Show("No character data files found.", "ERROR", MessageBoxButtons.OK);
                //Application.Exit();
            }

            // Create a Customization.Character class for each identified FCH file and read everything
            FoundCharacters = new Character[fchFiles.Length];
            for (int i = 0; i < fchFiles.Length; i++)
            {
                byte[] fbytes = File.ReadAllBytes(fchFiles[i]);
                if (fbytes.Length == 0)
                {
                    //MessageBox.Show("Could not read file \"" + fchFiles[i] + "\".", "ERROR", MessageBoxButtons.OK);
                    continue;
                }

                FoundCharacters[i] = new Character();
                FoundCharacters[i].File = fchFiles[i];
                //FoundCharacters[i].Data = Parser.CharacterReadData(fbytes);
                // TODO check if data is correct
            }

            return FoundCharacters;
        }

        
    }
}
