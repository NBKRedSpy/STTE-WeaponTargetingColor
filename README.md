# Darker Targeting Color

![thumbnail icon](media/thumbnail.png)

When selecting a weapon, the existing target arc is fairly light.  This mod darkens it to make it easier to see.

This mod can change the color and opacity of any of the targeting arcs via the configuration file.

By default, only the "selected weapon" arc is changed.

# Steam Workshop
For Steam Users, subscribing to this mod does not install the mod.
Follow [Installation section](#installation) instructions below to install.

# Compatibility
* Some mods instruct the user to overwrite the game's original files.  This mod may not be compatible with those mods.
    * This mod does not affect the original game files.
* Safe to add and remove from existing saves.

# Configuration
The configuration file will be created on the first game run and can be found at `<Steam Directory>\steamapps\common\Shortest Trip to Earth\BepInEx\config\WeaponTargetingColor.cfg`.  The changes will take effect the next time the game is run.

The colors are in RGBA format.  https://rgbcolorpicker.com/ is an online color picker.  Do not include the # prefix.

Note that the game will darken the colors slightly.

|Name|Default|Description|
|--|--|--|
|SelectedColorBox|005F0040|The targeting box when a weapon is currently selected.|
|SelectedColorTail|00270040|The targeting tail when a weapon is currently selected.|
|CursorColorBox|7D000000|The targeting box when selecting a new target.|
|CursorColorTail|3C000000|The targeting tail when selecting a new target.|
|ExistingColorBox|32323C00|The targeting box when a weapon already has a target.|
|ExistingColorTail|14141900|The targeting tail when a weapon already has a target.|

# Support
If you enjoy my mods and want to buy me a coffee, check out my [Ko-Fi](https://ko-fi.com/nbkredspy71915) page.
Thanks!

# Installation 

This section covers how to install the BepInEx mod loader and the mod itself.

## BepInEx Setup
If BepInEx has already been installed, skip to the [Mod Install](#mod-install) section.

* Download BepInEx from https://github.com/BepInEx/BepInEx/releases/download/v5.4.23.2/BepInEx_win_x64_5.4.23.2.zip
* Extract the contents of the BepInEx zip file into the game's directory:
```<Steam Directory>\steamapps\common\Shortest Trip to Earth```
    
    __Important__:  The .zip file *must* be extracted to the root folder of the game.  If BepInEx was extracted correctly, the following directory will exist: ```<Steam Directory>\steamapps\common\Shortest Trip to Earth\BepInEx```.  

    A common issue is extracting the .zip with the .zip name.  Ex: ```BepInEx_win_x64_5.4.23.1/BepInEx```.  If this occurs, move the ```BepInEx``` sub directory to the game's root directory.

* Run the game.  Once the main menu is shown, exit the game.  
* If the install was successful, there will now be a ```<Game Dir>/BepInEx/plugins``` directory.

## Mod Install
* Download the WeaponTargetingColor.zip.  
    * If on Nexumods.com, download from the Files tab.
    * Otherwise, download from https://github.com/NBKRedSpy/STTE-WeaponTargetingColor/releases/
* Extract the contents of the zip file into the ```<Game Dir>/BepInEx/plugins``` folder.
* Run the Game.  The mod will now be enabled.

# Uninstalling

## Uninstalling This Mod Only

This method removes this mod, but keeps the BepInEx mod loader and any other mods.

Delete the directory ```<Steam Directory>\steamapps\common\Shortest Trip to Earth\BepInEx\plugins\WeaponTargetingColor```.

## Uninstall the Mod and BepInEx
This resets the game to an unmodded state by deleting BepInEx and any BepInEx mods.

Delete the following files and folders in the game's directory:
```
BepInEx  (<-- Folder)
.doorstop_version
changelog.txt
doorstop_config.ini
winhttp.dll
```

# Change Log 

## 1.0.0
* Release

# Source Code
Source code is available on GitHub at https://github.com/NBKRedSpy/STTE-WeaponTargetingColor
