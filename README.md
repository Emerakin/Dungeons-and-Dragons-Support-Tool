# Dungeons & Dragons Support Tool Guide

## Building and running the project

### Build the solution

Build the whole solution, ideally from code editor, if possible, since on my machine I got weird errors while trying to do it through command line.

### Run the .exe file

Find and run ./DnD Support Tool/bin/Release/DnD Support Tool.exe to run the whole application. This is important, since paths in classes working with database are relative to the working directory.

## Moving thorugh apllication

### Dungeon Master Role

After seeing the initial window, select Dungeon Master role. New window will rise. On the left, there is list of created monsters, button to add new monster, and button to filter the list of existing monsters. After clicking the button to create new moster, input formular in main part will open. You cannot view/edit other monsters while in this formular. To save the monster, click Save button, to discard, click Discard button. If you did not input correct values or you missed mandatory inputs, those will flash with brighter color. To view a monster, click on its name and overview will popup in main part. To view action or trait, click on its name. To unview, click on its name again.

### Player Role

After seeing the initial window, select Player role. New window will rise. On the left, there is a list of created characters and button to create new one. After clicking the button to create new character, a simple three input boxes will show. Save button saves the character, Discard discards it. To view a character, click on its name. An overview will show in the main part. Character cannot be edited. To change character's hit points, write a number in textbox above buttons changing the hit points. To add new item, first, click Add button to add it into inventory. In need of equipping it, there is Equip button. There is also Add button in spells section. To view more information about item or spell, click its name. To unview, again, click its name. After clicking the Save button of a new item/spell, if you missed mandatory inputs or put an incorrect value, textboxes will flash with brighter color.

## Final thoughts

To fully understand this application, the user should understand Dungeons & Dragons rules.