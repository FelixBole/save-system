# Save System

A Save System with a file manager that handles saving and loading files to/from disk.

## Installation

1. In Unity, from the package manager, click the `+` icon
2. Select `Add package from git URL...`.
3. In the text box that appears, enter this projects git url `https://github.com/FelixBole/save-system.git` 
4. That's it !

## Getting started

To get started, you will need to create scriptable objects of the SaveSystem and your Save Data. You can of course extend these for your custom needs as explained under. 

## Customization

To make your own save data, you can create a class that extends the Save class and put in all of the serializable data you want in here.
To customize the logic of the save system you can extend the SaveSystem class and override the following methods :
- LoadSaveDataFromDisk
- SaveDataToDisk
- WriteEmptySaveFile
- SetNewGameData

## Examples

To view an example setup of custom save data, you can import the sample package "Custom Extensions of Save Data and Save System"