# Valheim Character Forge
<hr />
Built with Blazor and ElectronNET, and based on a similar GitHub project, https://github.com/byt3m/Valheim-Character-Editor .
<br />
This repository is licensed under the GNU General Public License v3.0.
<br />
<br />
Valheim Character Forge is a utility to add, modify, and remove items in your character's inventory, and to modify the skill levels of your character. Built with Blazor and ElectronNET, this editor is based upon another similar editor (byt3m/Valheim-Character-Editor (github.com) ), and the source code the repository for this editor is available at mvan4310/ValheimCharacterForge (github.com) .

Known issues:
- Sometimes, if you try to select the save location immediately on startup you will get an error. Workaround: Wait half a second and try again.
- If you dont select an inventory slot to add an item to, it will be given an invalid slot. Workaround: Select the slot before adding the item, or delete the item and add it again.
- Values that are higher than the in-game max will cause bugs or UI issues. Workaround: Edit your character again after closing the game, and bring the values back down until you find a point the bugs no longer occur.
