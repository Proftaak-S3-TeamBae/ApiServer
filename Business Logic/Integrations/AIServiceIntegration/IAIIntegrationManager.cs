namespace AI_Service;

/// <summary>
/// The manager for the AI Integrations
/// </summary>
public interface IAIIntegrationManager
{
    /// <summary>
    /// Add an integration to the account
    /// </summary>
    /// <param name="integration"></param>
    public void AddIntegration(AIServiceIntegration integration);

    /// <summary>
    /// Get an integration by its string id
    /// </summary>
    /// <param name="id">The string id of the integration</param>
    /// <returns></returns>
    public AIServiceIntegration GetIntegration(string id);
}