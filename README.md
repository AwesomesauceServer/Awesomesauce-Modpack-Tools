# Awesomesauce Modpack Tools [![Build Status](https://travis-ci.org/AwesomesauceServer/Awesomesauce-Modpack-Tools.svg?branch=master)](https://travis-ci.org/AwesomesauceServer/Awesomesauce-Modpack-Tools) [![GitHub release](https://img.shields.io/github/release/AwesomesauceServer/Awesomesauce-Modpack-Tools.svg)](https://github.com/AwesomesauceServer/Awesomesauce-Modpack-Tools/releases/latest)
Collection of tools to help us manage the [Awesomesauce Modpack](https://github.com/AwesomesauceServer/Awesomesauce-Modpack), a semi-private community modpack.

### Why?
It's a pain to update and download many mods by hand.

### How?
You add a [CurseForge](https://minecraft.curseforge.com) url to a project **file** e.g. ```https://minecraft.curseforge.com/projects/rftools/files/2511881```. It will go to the site and pull information about the mod and format it into a JSON file.

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
|requires|[Mod(s) required for the mod to work](https://github.com/AwesomesauceServer/Awesomesauce-Modpack-Tools/blob/master/AwesomesauceModpackTools/Mods/RequiredMod.cs#L8)|
|link|Link to the mod web page|
|linkDownload|Download to the mod file|
|linkFiles|Project file list for the mod updates|
|md5|MD5 of the mod file|
|releaseType|[Release type of the mod](https://github.com/AwesomesauceServer/Awesomesauce-Modpack-Tools/blob/master/AwesomesauceModpackTools/Mods/Enums.cs#L16)|
|minecraftVersion|List of supported Minecraft versions|
|updateMode|[How the update should be handled](https://github.com/AwesomesauceServer/Awesomesauce-Modpack-Tools/blob/master/AwesomesauceModpackTools/Mods/Enums.cs#L11)|

##### Example
```json
  {
    "name": "RFTools",
    "id": "6fda9b39-ca6a-440c-87a9-7d16938ac4c7",
    "file": "rftools-1.1x-7.16.jar",
    "side": "Both",
    "date": "2017-12-20T06:59:00Z",
    "size": "3.18 MB",
    "requires": [
      {
        "name": "McJtyLib",
        "id": "c363a00f-29ac-418c-8cb1-d52f8df3ed97"
      }
    ],
    "link": "https://minecraft.curseforge.com/projects/rftools/files/2511881",
    "linkDownload": "https://minecraft.curseforge.com/projects/rftools/files/2511881/download",
    "linkFiles": "https://minecraft.curseforge.com/projects/rftools/files",
    "md5": "64484ee05d03eff975aa684ea31adb5c",
    "releaseType": "Release",
    "minecraftVersion": [
      "1.11.2"
    ],
    "updateMode": "Automatic"
  }
```
