namespace AI_Scanner_Service.Entities
{
    /// <summary>
    /// Represents an AI Service
    /// </summary>
    public class AIService
    {
        public int Id { get; private set; }

        public string Type { get; private set; }

        public DateTime DateAdded { get; private set; }

        public string Owner { get; private set; }

        public string Purpose { get; private set; }

        public AIService(int id, string type, DateTime dateAdded, string owner, string purpose)
        {
            Id = id;
            Type = type;
            DateAdded = dateAdded;
            Owner = owner;
            Purpose = purpose;
        }
    }
}
