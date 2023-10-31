using AI_Scanner_API.Config;
using AI_Scanner_Service.DTOs;
using AI_Scanner_Service.IManagers;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace AI_Scanner_Service.Managers
{
    /// <summary>
    /// The manager for ai services
    /// </summary>
    public class AIServiceManager : IAIManager
    {
        /// The name of the ai service collection
        private readonly string _collectionName = "AIservice";

        private readonly IMongoCollection<AIServiceDTO> _aiServiceCollection;

        public AIServiceManager(IOptions<AIscannerDatabaseSettings> scannerAppSettings)
        {
            var mongoClient = new MongoClient(scannerAppSettings.Value.ConnectionString);
            var database = mongoClient.GetDatabase(scannerAppSettings.Value.DatabaseName);
            _aiServiceCollection = database.GetCollection<AIServiceDTO>(_collectionName);
        }

        public Task<List<AIServiceDTO>> AddAISystems()
        {
            throw new NotImplementedException();
        }

        public Task<List<AIServiceDTO>> ApproveAISystemList()
        {
            throw new NotImplementedException();
        }

        public Task<List<AIServiceDTO>> EditAISystems(string id)
        {
            throw new NotImplementedException();
        }

        public Task<AIServiceDTO> GetAIServiceById(string id)
            => _aiServiceCollection.Find(AIServiceDTO => AIServiceDTO.Id == id);

        /// <summary>
        /// Get the list of all ai systems from all the ai services
        /// </summary>
        /// <returns>All the ai systems in all serivces</returns>
        public Task<List<AIServiceDTO>> GetAllAISystems()
            => _aiServiceCollection.Find(AIServiceDTO => true).ToListAsync();

        /// <summary>
        /// Get the list of all ai systems from all the ai services of a specific type
        /// </summary>
        /// <param name="type">The type of the ai system</param>
        /// <returns>All the ai systems in all serivces of the specified type</returns>
        public Task<List<AIServiceDTO>> GetAllAISystemsByType(AITypeDTO type)
            => _aiServiceCollection.Find(AIServiceDTO => AIServiceDTO.Type == type.Id).ToListAsync();

        public Task RemoveAISystem(string id)
            => _aiServiceCollection.DeleteOneAsync(AIServiceDTO => AIServiceDTO.Id == id);
    }
}
