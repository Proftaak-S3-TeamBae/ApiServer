namespace AI_Service;

/// <summary>
/// The type of AI Service
/// </summary>
public enum AIType
{
    LLM,
    Diffusion,
    Miscillaneous
}

/// <summary>
/// Describes an AI Service fetched by the AI Service Integration
/// </summary>
public struct AIService
{
    /// <summary>
    /// The id of the service
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// The type of the service
    /// </summary>
    public AIType Type { get; set; }
}
