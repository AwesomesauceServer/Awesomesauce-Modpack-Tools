namespace AwesomesauceModpackTools {

    /// <summary>
    /// Side that the mod is required.
    /// </summary>
    public enum Side { Both, Client, Server };

    /// <summary>
    /// Status of the mod request.
    /// </summary>
    public enum Status { _Blank, Accepted, OnHold, Rejected, Testing };

    /// <summary>
    /// Update mode of the mod.
    /// </summary>
    public enum UpdateMode { Automatic, Manual, Never };

}
