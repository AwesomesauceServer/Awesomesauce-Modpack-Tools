using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using AwesomesauceModpackTools.Mods;
using Newtonsoft.Json;

namespace AwesomesauceModpackTools {

    public static class Export {

        /// <summary>
        /// Export mod list to HTML.
        /// </summary>
        /// <param name="modList">Mod list to export.</param>
        /// <param name="file">Path to save the file.</param>
        public static void AsHTML(List<Mod> modList, string file) {
            string workingHTML = Properties.Resources.Export_HTML_Template;
            workingHTML = workingHTML.Replace("%CSS%", Properties.Resources.Export_HTML_CSS);
            workingHTML = workingHTML.Replace("%JS%", Properties.Resources.Export_HTML_JS);

            StringBuilder workingTable = new StringBuilder();
            foreach (Mod mod in modList) {
                workingTable.AppendLine("<tr>");
                workingTable.AppendLine($"<td><a href=\"{mod.Link}\" target=\"_blank\" rel=\"noreferrer\">{mod.Name}</a></td>");
                workingTable.AppendLine($"<td>{mod.Date}</td>");
                workingTable.AppendLine($"<td>{mod.MD5}</td>");
                workingTable.AppendLine("</tr>");
            }

            workingHTML = workingHTML.Replace("%TABLE%", workingTable.ToString());
            File.WriteAllText(file, workingHTML);
        }

        /// <summary>
        /// Export mod list to XML.
        /// </summary>
        /// <param name="modList">Mod list to export.</param>
        /// <param name="file">Path to save the file.</param>
        public static void AsXML(List<Mod> modList, string file) {
            XmlDocument xmlDocument = JsonConvert.DeserializeXmlNode("{\"Mod\":" + JsonConvert.SerializeObject(modList) + "}", "Mods");

            using (XmlTextWriter writer = new XmlTextWriter(file, Encoding.UTF8)) {
                writer.Formatting = System.Xml.Formatting.Indented;
                xmlDocument.Save(writer);
            }
        }

    }
}
