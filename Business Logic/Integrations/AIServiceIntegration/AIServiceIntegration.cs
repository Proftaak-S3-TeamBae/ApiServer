namespace AI_Service;

/// <summary>
/// The interface for the AI Service Integration.
/// An `inegration` refers to a hosting services for AI models. (Such as OpenAI, Google Cloud, etc.).
/// These are wrappers around the api's these hosts provide to list the models.
/// </summary>
public abstract class AIServiceIntegration
{
    /// <summary>
    /// The string id of the integration
    /// </summary>
    /// <returns></returns>
    public abstract string Id();

    /// <summary>
    /// Get the list of all ai services hosted by this integration.
    /// </summary>
    public abstract Task<List<AIService>> GetAIServices();

    /// <summary>
    /// Get the list of all ai services hosted by this integration of a specific type.
    /// </summary>
    /// <param name="type">The type of the ai service</param>
    public abstract Task<List<AIService>> GetAIServicesByType(AIType type);
}
