using System;
using HtmlAgilityPack;
using static AwesomesauceModpackTools.Utilities;

namespace AwesomesauceModpackTools.Mods {

    public static class CurseForge {

        public static (Mod Mod, Exception Exception) ParseForInfo(Mod mod) {
            try {
                HtmlWeb htmlWeb = new HtmlWeb();
                mod.HTML_Link = htmlWeb.Load(mod.Link);

                if (htmlWeb.StatusCode == System.Net.HttpStatusCode.OK) {
                    HtmlNode node = mod.HTML_Link.DocumentNode;
                    
                    Mod thisMod = new Mod() {
                        Link = mod.Link,
                        Name = node.SelectSingleNode("//span[@class='overflow-tip']").InnerText.Trim(),
                        File = node.SelectSingleNode("//div[@class='details-info']/ul/li[1]/div[@class='info-data overflow-tip']").InnerText.Trim(),
                        Date = EpochConverter(node.SelectSingleNode("//div[@class='details-info']/ul/li[3]/div[@class='info-data']/abbr[@class='tip standard-date standard-datetime']").Attributes["data-epoch"].Value.Trim()),
                        Size = node.SelectSingleNode("//div[@class='details-info']/ul/li[4]/div[@class='info-data']").InnerText.Trim(),
                        MD5 = node.SelectSingleNode("//div[@class='details-info']/ul/li[6]/div[@class='info-data']/span[@class='md5']").InnerText.Trim()
                    };

                    thisMod.Link = HtmlEntity.DeEntitize(thisMod.Link);
                    thisMod.Name = HtmlEntity.DeEntitize(thisMod.Name);
                    thisMod.File = HtmlEntity.DeEntitize(thisMod.File);
                    thisMod.Size = HtmlEntity.DeEntitize(thisMod.Size);
                    thisMod.MD5 = HtmlEntity.DeEntitize(thisMod.MD5);

                    thisMod.Link_Download = $"{thisMod.Link}/download";
                    thisMod.Link_Files = GetParentURL(thisMod.Link);

                    return (thisMod, null);
                } else {
                    return (null, new HtmlWebException($"HTTP returned status ({(int)htmlWeb.StatusCode}) {htmlWeb.StatusCode}."));
                }
            } catch (Exception ex) {
                return (null, ex);
            }
        }

        public static (Mod Mod, Exception Exception) ParseForUpdate(Mod mod) {
            try {
                HtmlWeb htmlWeb = new HtmlWeb();
                mod.HTML_Files = htmlWeb.Load(mod.Link_Files);

                if (htmlWeb.StatusCode == System.Net.HttpStatusCode.OK) {
                    HtmlNode node = mod.HTML_Files.DocumentNode;

                    Mod thisMod = new Mod() {
                        Name = node.SelectSingleNode("//span[@class='overflow-tip']").InnerText.Trim(),
                        File = node.SelectSingleNode(".//a[@class='overflow-tip']/@href").InnerText.Trim(),
                        Date = EpochConverter(node.SelectSingleNode(".//abbr/@data-epoch").Attributes["data-epoch"].Value.Trim()),
                        Size = node.SelectSingleNode(".//td[@class='project-file-size']").InnerText.Trim(),
                        Link = $"https://minecraft.curseforge.com{node.SelectSingleNode(".//a[@class='overflow-tip']/@href").Attributes["href"].Value.Trim()}"
                    };
                    thisMod.Link_Download = $"{thisMod.Link}/download";
                    thisMod.Link_Files = $"{thisMod.Link}/files";

                    return (thisMod, null);
                } else {
                    return (null, new HtmlWebException($"HTTP returned status ({(int)htmlWeb.StatusCode}) {htmlWeb.StatusCode}."));
                }
            } catch (Exception ex) {
                return (null, ex);
            }
        }

    }
}
