using System.Collections.Generic;

namespace AwesomesauceModpackTools {

    public static class Minecraft {

        private static Dictionary<string, string> _GameVersions = new Dictionary<string, string>();
        /// <summary>
        /// Dictionary of all supported Minecraft game versions. The key is the game version, value is CurseForge url filter string.
        /// </summary>
        /// <remarks>
        /// Example: [key = 1.10.2, value = ?filter-game-version=2020709689%3A6170]
        /// </remarks>
        public static Dictionary<string, string> GameVersions { get => _GameVersions; }

        /// <summary>
        /// Setup <see cref="GameVersions"/> key pairs.
        /// </summary>
        public static void SetupGameVersions() {
            _GameVersions.Add("1.12.2", "?filter-game-version=2020709689%3A6756");
            _GameVersions.Add("1.12", "?filter-game-version=2020709689%3A6580");
            _GameVersions.Add("1.11.2", "?filter-game-version=2020709689%3A6452");
            _GameVersions.Add("1.10.2", "?filter-game-version=2020709689%3A6170");
            _GameVersions.Add("1.9.4", "?filter-game-version=2020709689%3A6084");
            _GameVersions.Add("1.8.9", "?filter-game-version=2020709689%3A5806");
            _GameVersions.Add("1.7.10", "?filter-game-version=2020709689%3A4449");
            _GameVersions.Add("1.6.4", "?filter-game-version=2020709689%3A326");
            _GameVersions.Add("1.5.2", "?filter-game-version=2020709689%3A312");
            _GameVersions.Add("1.4.7", "?filter-game-version=2020709689%3A272");
        }

    }

}
