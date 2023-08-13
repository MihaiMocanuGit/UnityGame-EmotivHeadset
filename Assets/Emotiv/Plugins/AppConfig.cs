/// <summary>
/// Contain configuration of a specific App.
/// </summary>
static class AppConfig
{
    public static string AppUrl              = "wss://localhost:6868";
    public static string AppName             = "DYF";
    
    /// <summary>
    /// Name of directory where contain tmp data and logs file.
    /// </summary>
    public static string TmpAppDataDir       = "DYFtemp";
    //public static string ClientId            = "";
    public static string ClientId            = "";

    //public static string ClientSecret        = "";
    public static string ClientSecret = "";

    public static string AppVersion          = "3.0";
    
    /// <summary>
    /// License Id is used for App
    /// In most cases, you don't need to specify the license id. Cortex will find the appropriate license based on the client id
    /// </summary>
    public static string AppLicenseId        = "";
}
