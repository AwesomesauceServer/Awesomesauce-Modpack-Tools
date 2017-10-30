# Awesomesauce Modpack Tools [![Build Status](https://travis-ci.org/AwesomesauceServer/Awesomesauce-Modpack-Tools.svg?branch=master)](https://travis-ci.org/AwesomesauceServer/Awesomesauce-Modpack-Tools) [![GitHub release](https://img.shields.io/github/release/AwesomesauceServer/Awesomesauce-Modpack-Tools.svg)](https://github.com/AwesomesauceServer/Awesomesauce-Modpack-Tools/releases/latest)
Collection of tools to help us manage the [Awesomesauce Modpack](https://github.com/AwesomesauceServer/Awesomesauce-Modpack), a semi-private community modpack.

### Why?
It's a pain to update and download many mods by hand.

### How?
You add a [CurseForge](https://minecraft.curseforge.com) url to a project **file** e.g. ```https://minecraft.curseforge.com/projects/deep-resonance/files/2418068```. It will go to the site and pull information about the mod and format it into a JSON file.

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
|updateMode|[How the update should be handled](https://github.com/AwesomesauceServer/Awesomesauce-Modpack-Tools/blob/master/AwesomesauceModpackTools/Mods/Enums.cs#L11)|

##### Example
```json
  {
    "name": "Deep Resonance",
    "id": "f98b22af-862d-481b-b5f2-0dd36566edb9",
    "file": "deepresonance-1.1x-1.4.8.jar",
    "side": "Both",
    "date": "2017-05-10T09:51:09Z",
    "size": "849.93 KB",
    "requires": [
      {
        "name": "McJtyLib",
        "id": "a1d1b935-b47c-48e7-a8d0-1793bd5f7c48"
      },
      {
        "name": "CompatLayer",
        "id": "c8b881a0-f7f7-453e-9ec7-f87187ba36d3"
      },
      {
        "name": "ElecCore | Rendering Library",
        "id": "e78b16d7-871a-480b-80bb-571a80ace3a4"
      }
    ],
    "link": "https://minecraft.curseforge.com/projects/deep-resonance/files/2418068",
    "linkDownload": "https://minecraft.curseforge.com/projects/deep-resonance/files/2418068/download",
    "linkFiles": "https://minecraft.curseforge.com/projects/deep-resonance/files",
    "md5": "8cdc57488f31d0dfef88e2fabb7a815d",
    "updateMode": "Automatic"
  }
```
