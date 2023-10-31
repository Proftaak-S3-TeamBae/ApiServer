using MongoDB.Bson;
using MongoDB.Driver;

namespace AI_Service;

/// <summary>
/// The manager for the AI Integrations
/// </summary>
public class AIIntegrationManager : IAIIntegrationManager
{
    private Dictionary<string, AIServiceIntegration> _integrations = new();

    /// <summary>
    /// Add an integration to the account
    /// </summary>
    /// <param name="integration"></param>
    public void AddIntegration(AIServiceIntegration integration)
        => _integrations.Add(integration.Id(), integration);

    /// <summary>
    /// Get an integration by its string id
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    /// <exception cref="Exception"></exception>
    public AIServiceIntegration GetIntegration(string id)
    {
        if (_integrations.ContainsKey(id))
            return _integrations[id];
        else
            throw new Exception("Integration not found");
    }
}
