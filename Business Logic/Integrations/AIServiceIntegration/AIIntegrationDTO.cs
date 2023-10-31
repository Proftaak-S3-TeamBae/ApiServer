using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace AI_Service;

/// <summary>
/// The manager for the AI Integrations
/// </summary>
public struct AIIntegrationDTO
{
    /// <summary>
    /// The id of the integration
    /// </summary>
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }

    /// <summary>
    /// The id of the user who the integration is registered to
    /// </summary>
    [BsonElement("user")]
    [BsonRepresentation(BsonType.ObjectId)]
    public string User { get; set; }

    /// <summary>
    /// The name of the integration
    /// </summary>
    [BsonElement("name")]
    public string Name { get; set; }
}
