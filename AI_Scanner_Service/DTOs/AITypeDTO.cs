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
        public string? Id;
        public string? Name;
        public string? IconURL;
        public string? ModelType;
    }
}
