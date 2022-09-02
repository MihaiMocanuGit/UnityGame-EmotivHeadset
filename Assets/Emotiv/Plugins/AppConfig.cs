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
    //public static string ClientId            = "GjdUNSFw9QZd6zmSRRXLR7rrfmdKntYOFguR2CZ2";
    public static string ClientId            = "sIClwpXyw67vK0GLgQfy01XNxzelDMGwbZI46eNx";

    //public static string ClientSecret        = "zoTEdYFwMJhzXHTboQPRA0F9IH71YJD0P58rPEOmI9m1KLWQFUxzKXb1LOJWgMMCjCkQotCvjrF4bQKOojsLwN1CLkA5I0zTAcdt4teF2LhkMNr1JBI9Q95Ge0dUJuVL";
    public static string ClientSecret = "WtlM8h6xSeCeNkxdSK3BQGZIwPqDzH4dKFyQTCtzZTRHU5iqz5Vl5OEWxbIjKkWzfXAQjkl3OMMl3tY72zYRNmESGWADzJezptGuAYqRPpe8vDWutxXrLSXQj1v1pb7T";

    public static string AppVersion          = "3.0";
    
    /// <summary>
    /// License Id is used for App
    /// In most cases, you don't need to specify the license id. Cortex will find the appropriate license based on the client id
    /// </summary>
    public static string AppLicenseId        = "";
}