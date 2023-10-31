using AI_Scanner_API.Config;
using AI_Scanner_Service.DTOs;
using AI_Scanner_Service.IManagers;
using AI_Service;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace AI_Scanner_Service.Managers
{
    /// <summary>
    /// The manager for ai services
    /// </summary>
    public class AIServiceManager : IAIServiceManager
    {
        /// The name of the ai service collection
        private readonly string _collectionName = "AIservice";

        private readonly IMongoCollection<AIServiceDTO> _aiServiceCollection;

        private readonly IAIIntegrationManager _aiIntegrationManager;

        public AIServiceManager(IOptions<AIScannerDatabaseSettings> scannerAppSettings, IAIIntegrationManager aiIntegrationManager)
        {
            // var mongoClient = new MongoClient(scannerAppSettings.Value.ConnectionString);
            // var database = mongoClient.GetDatabase(scannerAppSettings.Value.DatabaseName);
            // _aiServiceCollection = database.GetCollection<AIServiceDTO>(_collectionName);

            _aiIntegrationManager = aiIntegrationManager;
        }

        public Task<AIServiceDTO> AddAIService()
        {
            throw new NotImplementedException();
        }

        public Task<List<AIServiceDTO>> ApproveAIServiceList(List<AIServiceDTO> aISystemList)
        {
            throw new NotImplementedException();
        }

        public void ApproveAISystemList(List<AIServiceDTO> aISystemList)
            => _aiServiceCollection.InsertMany(aISystemList);

        public Task<List<AIServiceDTO>> EditAISystem(string id)
        {
            throw new NotImplementedException();
        }

        public Task<AIServiceDTO> GetAIServiceById(string id)
            => (Task<AIServiceDTO>)_aiServiceCollection.Find(AIServiceDTO => AIServiceDTO.Id == id);

        public async Task<List<AIServiceDTO>> GetAllAIServices()
        {
            var integration = _aiIntegrationManager.GetIntegration("openai");
            var services = await integration.GetAIServices();
            return services.Select(service => new AIServiceDTO
            {
                Id = "",
                Type = "LLM",
                DateAdded = DateTime.Now,
                Owner = "OpenAI",
                Purpose = service.Id,
            }).ToList();
        }

        public Task<List<AIServiceDTO>> GetAllAIServicesByType(AITypeDTO type)
            => _aiServiceCollection.Find(AIServiceDTO => AIServiceDTO.Type == type.Id).ToListAsync();

        public Task RemoveAISystem(string id)
            => _aiServiceCollection.DeleteOneAsync(AIServiceDTO => AIServiceDTO.Id == id);
    }
}
