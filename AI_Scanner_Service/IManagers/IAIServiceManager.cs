using AI_Scanner_Service.DTOs;

namespace AI_Scanner_Service.IManagers
{
    /// <summary>
    /// The interface for the manager for ai services
    /// </summary>
    public interface IAIServiceManager
    {
        /// <summary>
        /// Add a new ai service
        /// </summary>
        /// <returns></returns>
        public Task<AIServiceDTO> AddAIService();

        /// <summary>
        /// Approve a list of ai services
        /// </summary>
        /// <param name="aISystemList"></param>
        /// <returns></returns>
        public Task<List<AIServiceDTO>> ApproveAIServiceList(List<AIServiceDTO> aISystemList);

        /// <summary>
        /// Get the list of all ai systems from all the ai services
        /// </summary>
        /// <returns>All the ai systems in all serivces</returns>
        public Task<List<AIServiceDTO>> GetAllAIServices();

        /// <summary>
        /// Get the list of all ai systems from all the ai services of a specific type
        /// </summary>
        /// <param name="type">The type of the ai system</param>
        /// <returns>All the ai systems in all services of the specified type</returns>
        public Task<List<AIServiceDTO>> GetAllAIServicesByType(AITypeDTO type);

        /// <summary>
        /// Get an ai system by id
        /// </summary>
        public Task<AIServiceDTO> GetAIServiceById(string id);

        /// <summary>
        /// Edit an ai system
        /// </summary>
        public Task<List<AIServiceDTO>> EditAISystem(string id);

        /// <summary>
        /// Remove an ai system
        /// </summary>
        public Task RemoveAISystem(string id);
    }
}
