# Awesomesauce Modpack Tools [![Build Status](https://travis-ci.org/AwesomesauceServer/Awesomesauce-Modpack-Tools.svg?branch=master)](https://travis-ci.org/AwesomesauceServer/Awesomesauce-Modpack-Tools) [![GitHub release](https://img.shields.io/github/release/AwesomesauceServer/Awesomesauce-Modpack-Tools.svg)](https://github.com/AwesomesauceServer/Awesomesauce-Modpack-Tools/releases/latest)
Collection of tools to help us manage the [Awesomesauce Modpack](https://github.com/AwesomesauceServer/Awesomesauce-Modpack), a semi-private community modpack.

### Why?
It's a pain to update and download many mods by hand.

### How?
You add a [CurseForge](https://minecraft.curseforge.com) url to a project **file** e.g. ```https://minecraft.curseforge.com/projects/rftools/files/2491667```. It will go to the site and pull information about the mod and format it into a JSON file.

The JSON file will be used to download and update the mod.

### JSON file?

##### Layout

|Property|Meaning|
|---|---|
|name|Name of the mod|
|id|[Random GUID assigned to the mod when it's created](https://github.com/AwesomesauceServer/Awesomesauce-Modpack-Tools/blob/master/AwesomesauceModpackTools/Mods/Mod.cs#L24)|
|file|File name of the mod|
|side|[Side that the mod is required](https://github.com/AwesomesauceServer/Awesomesauce-Modpack-Tools/blob/master/AwesomesauceModpackTools/Mods/Enums.cs#L6)|
|date|Date and time of when the mod was uploaded to CurseForge|
|size|Size of the mod (pretty formatted)|
|requires|[Mod(s) required for the mod to work](https://github.com/AwesomesauceServer/Awesomesauce-Modpack-Tools/blob/master/AwesomesauceModpackTools/Mods/RequiredMod.cs#L5)|
|link|Link to the mod web page|
|linkDownload|Download to the mod file|
|linkFiles|Project file list for the mod updates|
|md5|MD5 of the mod file|
|minecraftVersion|List of supported Minecraft versions|
|updateMode|[How the update should be handled](https://github.com/AwesomesauceServer/Awesomesauce-Modpack-Tools/blob/master/AwesomesauceModpackTools/Mods/Enums.cs#L11)|

##### Example
```json
 {
    "name": "RFTools",
    "id": "afb5bf99-40a7-45de-b4fc-e31209051b67",
    "file": "rftools-1.12-7.12.jar",
    "side": "Both",
    "date": "2017-10-17T18:13:36Z",
    "size": "3.17 MB",
    "requires": [
      {
        "name": "McJtyLib",
        "id": "31f66c0e-b76e-4a16-a0c3-c1498bf84717"
      }
    ],
    "link": "https://minecraft.curseforge.com/projects/rftools/files/2491667",
    "linkDownload": "https://minecraft.curseforge.com/projects/rftools/files/2491667/download",
    "linkFiles": "https://minecraft.curseforge.com/projects/rftools/files",
    "md5": "7678c0f484d0fdc1d910418142735aed",
    "minecraftVersion": [
      "1.12.2",
      "1.12.1"
    ],
    "updateMode": "Automatic"
  }
```
