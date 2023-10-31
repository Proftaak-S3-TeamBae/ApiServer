using System.Data.Common;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AI_Service;

/// <summary>
/// The result of a request to OpenAI
/// </summary>
public class OpenAiResult
{
    /// <summary>
    /// The object kind
    /// </summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }

    /// <summary>
    /// The data in the object
    /// </summary>
    [JsonPropertyName("data")]
    public List<OpenAiModelResult>? Data { get; set; }
}

public class OpenAiPermissionResult
{
    /// <summary>
    /// The id of the model
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// What kind of model it is
    /// </summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }

    /// <summary>
    /// When the model was created
    /// </summary>
    [JsonPropertyName("created")]
    public DateTime? Created { get; set; }

    [JsonPropertyName("allow_create_engine")]
    public bool AllowCreateEngine { get; set; }

    [JsonPropertyName("allow_sampling")]
    public bool AllowSampling { get; set; }

    [JsonPropertyName("allow_log_probs")]
    public bool AllowLogProbs { get; set; }

    [JsonPropertyName("allow_search_indices")]

    public bool AllowSearchIndices { get; set; }

    [JsonPropertyName("allow_view")]
    public bool AllowView { get; set; }

    [JsonPropertyName("allow_fine_tuning")]
    public bool AllowFineTuning { get; set; }

    [JsonPropertyName("is_blocking")]
    public bool IsBlocking { get; set; }
}

/// <summary>
/// The result of a request to OpenAI for a model
/// </summary>
public class OpenAiModelResult
{
    /// <summary>
    /// The id of the model
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// What kind of model it is
    /// </summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }

    /// <summary>
    /// When the model was created
    /// </summary>
    [JsonPropertyName("created")]
    public int? Created { get; set; }

    /// <summary>
    /// The owner of the model
    /// </summary>
    [JsonPropertyName("owned_by")]
    public string? OwnedBy { get; set; }

    /// <summary>
    /// The permissions of the model
    /// </summary>
    [JsonPropertyName("permissions")]
    public OpenAiPermissionResult? Permissions { get; set; }

    /// <summary>
    /// The root of the object
    /// </summary>
    [JsonPropertyName("root")]
    public string? Root { get; set; }

    /// <summary>
    /// The parent of the object
    /// </summary>
    [JsonPropertyName("parent")]
    public string? Parent { get; set; }
}

/// <summary>
/// The integration for OpenAI
/// </summary>
public class OpenAIIntegration : AIServiceIntegration
{
    /// <summary>
    /// The api key for the integration
    /// </summary>
    public string? ApiKey { get; set; }

    public override string Id() => "openai";

    public OpenAIIntegration(string apiKey)
    {
        ApiKey = apiKey;
    }

    public override async Task<List<AIService>> GetAIServices()
    {
        using HttpClient client = new HttpClient();
        client.DefaultRequestHeaders.Add("Authorization", $"Bearer {ApiKey}");
        var response = await client.GetAsync("https://api.openai.com/v1/models");
        if (!response.IsSuccessStatusCode)
        {
            throw new Exception("Failed to get engines from OpenAI");
        }

        var content = await response.Content.ReadAsStringAsync();
        Console.WriteLine(content);
        var result = JsonSerializer.Deserialize<OpenAiResult>(content);
        var services = new List<AIService>();
        foreach (var model in result.Data!)
        {
            services.Add(new AIService
            {
                Id = model.Id!,
                Type = AIType.LLM!,
            });
        }

        return services;
    }

    public override async Task<List<AIService>> GetAIServicesByType(AIType type)
    {
        var services = await GetAIServices();
        return services.Where(x => x.Type == type).ToList();
    }
}
