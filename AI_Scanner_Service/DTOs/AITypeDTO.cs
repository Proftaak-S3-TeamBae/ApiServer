using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace AI_Scanner_Service.DTOs
{
    /// <summary>
    /// The Data Transfer Object for an ai type
    /// </summary>
    public class AITypeDTO
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("name")]
        public string? Name { get; set; }

        [BsonElement("iconurl")]
        public string? IconURL { get; set; }

        [BsonElement("modeltype")]
        public string? ModelType { get; set; }
    }
}
