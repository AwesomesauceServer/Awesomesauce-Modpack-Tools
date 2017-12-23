namespace AwesomesauceModpackTools.Mods {

    /// <summary>
    /// Side that the mod is required.
    /// </summary>
    public enum Side { Both, Client, Server };

    /// <summary>
    /// Update mode of the mod.
    /// </summary>
    public enum UpdateMode { Automatic, Manual, Never };

    /// <summary>
    /// Release type (status) of the mod.
    /// </summary>
    public enum ReleaseType { Alpha, Beta, Release, MostRecent };

}
