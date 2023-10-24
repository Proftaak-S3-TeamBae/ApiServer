using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace AI_Scanner_Service.DTOs
{
    /// <summary>
    /// Data Transfer Object for an AI Service in the database.
    /// </summary>
    public class AIServiceDTO
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id;

        [BsonRepresentation(BsonType.ObjectId)]
        public string? Type;

        public DateTime? DateAdded;

        [BsonRepresentation(BsonType.ObjectId)]
        public string? Owner;

        public string? Purpose;
    }
}
