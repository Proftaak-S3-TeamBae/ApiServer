namespace AI_Scanner_API.Config
{
    /// <summary>
    /// The database settings read from appsettings.json
    /// </summary>
    public class AIScannerDatabaseSettings
    {
        public string? ConnectionString { get;  set; }
        public string? DatabaseName { get;  set; }
    }
}
