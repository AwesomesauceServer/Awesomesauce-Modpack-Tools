using System.Collections.Generic;
using System.Text;
using AwesomesauceModpackTools.Mods;

namespace AwesomesauceModpackTools {

    public static class Export {

        public static string AsHTML(List<Mod> modList) {
            try {
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
                return workingHTML;
            } catch {
                return null;
            }

        }

    }
}
