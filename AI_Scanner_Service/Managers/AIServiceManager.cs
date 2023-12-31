﻿using AI_Scanner_API.Config;
using AI_Scanner_Service.DTOs;
using AI_Scanner_Service.IManagers;
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

        public AIServiceManager(IOptions<AIScannerDatabaseSettings> scannerAppSettings)
        {
            var mongoClient = new MongoClient(scannerAppSettings.Value.ConnectionString);
            var database = mongoClient.GetDatabase(scannerAppSettings.Value.DatabaseName);
            _aiServiceCollection = database.GetCollection<AIServiceDTO>(_collectionName);
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

        public Task<List<AIServiceDTO>> GetAllAIServices()
            => _aiServiceCollection.Find(AIServiceDTO => true).ToListAsync();

        public Task<List<AIServiceDTO>> GetAllAIServicesByType(AITypeDTO type)
            => _aiServiceCollection.Find(AIServiceDTO => AIServiceDTO.Type == type.Id).ToListAsync();

        public Task RemoveAISystem(string id)
            => _aiServiceCollection.DeleteOneAsync(AIServiceDTO => AIServiceDTO.Id == id);
    }
}
