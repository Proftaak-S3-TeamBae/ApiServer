namespace AI_Scanner_Service.Entities
{
    /// <summary>
    /// The entity for the ai type
    /// </summary>
    public class AIType
    {
        public int Id { get; private set; }

        public string Name { get; private set; }

        public string IconURL { get; private set; }

        public string ModelType { get; private set; }

        public AIType(int id, string name, string iconURL, string modelType)
        {
            Id = id;
            Name = name;
            IconURL = iconURL;
            ModelType = modelType;
        }
    }
}
