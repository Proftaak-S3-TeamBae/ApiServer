namespace AI_Scanner_Service.Entities
{
    public class AITypeEntity
    {
        public int Id { get; private set; }
        public string Name { get; private set; }

        public string IconURL { get; private set; }

        public string ModelType { get; private set; }

        public AITypeEntity(int id, string name, string iconURL, string modelType)
        {
            Id = id;
            Name = name;
            IconURL = iconURL;
            ModelType = modelType;
        }
    }
}
