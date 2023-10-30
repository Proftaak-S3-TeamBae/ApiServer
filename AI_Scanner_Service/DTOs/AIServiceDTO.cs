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
        public string? Id { get; set; }
                                    
        [BsonRepresentation(BsonType.ObjectId)]
        [BsonElement("type")]
        public string? Type { get; set; }    

        [BsonDateTimeOptions(Kind = DateTimeKind.Utc)]   
        [BsonRepresentation(BsonType.DateTime)]
        [BsonElement("dateadded")]
        public DateTime? DateAdded { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        [BsonElement("owner")]
        public string? Owner { get; set; }

        [BsonElement("purpose")]
        public string? Purpose { get; set; }
    }
}
