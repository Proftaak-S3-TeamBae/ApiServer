namespace AI_Scanner_API.Config
{
    /// <summary>
    /// The database settings read from appsettings.json
    /// </summary>
    public class AIScannerDatabaseSettings
    {
        public string? ConnectionString { get; private set; }
        public string? DatabaseName { get; private set; }
    }
}
