using AI_Scanner_Service.DTOs;

namespace AI_Scanner_Service.IManagers
{
    public interface IAIManager
    {
        public Task<AIServiceDTO> AddAISystem();

        public Task<List<AIServiceDTO>> ApproveAISystemList(List<AIServiceDTO> aISystemList);

        public Task<List<AIServiceDTO>> EditAISystems(string id);

        //public Task<AIServiceDTO> GetAIServiceById(int id);

        /// <summary>
        /// Get the list of all ai systems from all the ai services
        /// </summary>
        /// <returns>All the ai systems in all serivces</returns>
        public Task<List<AIServiceDTO>> GetAllAISystems();

        /// <summary>
        /// Get the list of all ai systems from all the ai services of a specific type
        /// </summary>
        /// <param name="type">The type of the ai system</param>
        /// <returns>All the ai systems in all services of the specified type</returns>
        public Task<List<AIServiceDTO>> GetAllAISystemsByType(AITypeDTO type);

        public Task RemoveAISystem(string id);
    }
}
