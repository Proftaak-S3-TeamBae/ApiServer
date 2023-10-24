namespace AI_Scanner_API.Config
{
    /// <summary>
    /// The database settings read from appsettings.json
    /// </summary>
    public class AIscannerDatabaseSettings
    {
        public string? ConnectionString { get; set; }
        public string? DatabaseName { get; set; }
    }
}
