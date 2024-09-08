[b][size=5]Darker Targeting Color[/size][/b] 
 
 
When selecting a weapon, the existing target arc is fairly light.  This mod darkens it to make it easier to see.
 
This mod can change the color and opacity of any of the targeting arcs via the configuration file.
 
By default, only the "selected weapon" arc is changed.
 
[b][size=5]Steam Workshop[/size][/b] 
 
For Steam Users, subscribing to this mod does not install the mod.
Follow [font=Courier New]Installation section[/font] instructions below to install.
 
[b][size=5]Compatibility[/size][/b] 
[list]
[*]Some mods instruct the user to overwrite the game's original files.  This mod may not be compatible with those mods.
[list]
[*]This mod does not affect the original game files.
[/list]
[*]Safe to add and remove from existing saves.
[/list]
 
[b][size=5]Configuration[/size][/b] 
 
The configuration file will be created on the first game run and can be found at [font=Courier New]<Steam Directory>\steamapps\common\Shortest Trip to Earth\BepInEx\config\WeaponTargetingColor.cfg[/font].  The changes will take effect the next time the game is run.
 
The colors are in RGBA format.  [url=https://rgbcolorpicker.com/]https://rgbcolorpicker.com/[/url] is an online color picker.  Do not include the # prefix.
 
Note that the game will darken the colors slightly.
[font=Courier New]+-------------------+----------+---------------------------------------------------------+
| Name              | Default  | Description                                             |
|===================+==========+=========================================================|
| SelectedColorBox  | 005F0040 | The targeting box when a weapon is currently selected.  |
|-------------------+----------+---------------------------------------------------------|
| SelectedColorTail | 00270040 | The targeting tail when a weapon is currently selected. |
|-------------------+----------+---------------------------------------------------------|
| CursorColorBox    | 7D000000 | The targeting box when selecting a new target.          |
|-------------------+----------+---------------------------------------------------------|
| CursorColorTail   | 3C000000 | The targeting tail when selecting a new target.         |
|-------------------+----------+---------------------------------------------------------|
| ExistingColorBox  | 32323C00 | The targeting box when a weapon already has a target.   |
|-------------------+----------+---------------------------------------------------------|
| ExistingColorTail | 14141900 | The targeting tail when a weapon already has a target.  |
+-------------------+----------+---------------------------------------------------------+
[/font]
 
[b][size=5]Support[/size][/b] 
 
If you enjoy my mods and want to buy me a coffee, check out my [url=https://ko-fi.com/nbkredspy71915]Ko-Fi[/url] page.
Thanks!
 
[b][size=5]Installation[/size][/b] 
 
This section covers how to install the BepInEx mod loader and the mod itself.
 
[b][size=4]BepInEx Setup[/size][/b] 
 
If BepInEx has already been installed, skip to the [font=Courier New]Mod Install[/font] section.
[list]
[*]Download BepInEx from [url=https://github.com/BepInEx/BepInEx/releases/download/v5.4.23.2/BepInEx_win_x64_5.4.23.2.zip]https://github.com/BepInEx/BepInEx/releases/download/v5.4.23.2/BepInEx_win_x64_5.4.23.2.zip[/url]
[*]Extract the contents of the BepInEx zip file into the game's directory:
[font=Courier New]<Steam Directory>\steamapps\common\Shortest Trip to Earth[/font]
 
[b]Important[/b]:  The .zip file [i]must[/i] be extracted to the root folder of the game.  If BepInEx was extracted correctly, the following directory will exist: [font=Courier New]<Steam Directory>\steamapps\common\Shortest Trip to Earth\BepInEx[/font].
 
A common issue is extracting the .zip with the .zip name.  Ex: [font=Courier New]BepInEx_win_x64_5.4.23.1/BepInEx[/font].  If this occurs, move the [font=Courier New]BepInEx[/font] sub directory to the game's root directory.
[*]Run the game.  Once the main menu is shown, exit the game.
[*]If the install was successful, there will now be a [font=Courier New]<Game Dir>/BepInEx/plugins[/font] directory.
[/list]
 
[b][size=4]Mod Install[/size][/b] 
[list]
[*]Download the WeaponTargetingColor.zip.
[list]
[*]If on Nexumods.com, download from the Files tab.
[*]Otherwise, download from [url=https://github.com/NBKRedSpy/STTE-WeaponTargetingColor/releases/]https://github.com/NBKRedSpy/STTE-WeaponTargetingColor/releases/[/url]
[/list]
[*]Extract the contents of the zip file into the [font=Courier New]<Game Dir>/BepInEx/plugins[/font] folder.
[*]Run the Game.  The mod will now be enabled.
[/list]
 
[b][size=5]Uninstalling[/size][/b] 
 
[b][size=4]Uninstalling This Mod Only[/size][/b] 
 
This method removes this mod, but keeps the BepInEx mod loader and any other mods.
 
Delete the directory [font=Courier New]<Steam Directory>\steamapps\common\Shortest Trip to Earth\BepInEx\plugins\WeaponTargetingColor[/font].
 
[b][size=4]Uninstall the Mod and BepInEx[/size][/b] 
 
This resets the game to an unmodded state by deleting BepInEx and any BepInEx mods.
 
Delete the following files and folders in the game's directory:
[code]
BepInEx  (<-- Folder)
.doorstop_version
changelog.txt
doorstop_config.ini
winhttp.dll
[/code]
 
[b][size=5]Change Log[/size][/b] 
 
[b][size=4]1.0.0[/size][/b] 
[list]
[*]Release
[/list]
 
[b][size=5]Source Code[/size][/b] 
 
Source code is available on GitHub at [url=https://github.com/NBKRedSpy/STTE-WeaponTargetingColor]https://github.com/NBKRedSpy/STTE-WeaponTargetingColor[/url]
