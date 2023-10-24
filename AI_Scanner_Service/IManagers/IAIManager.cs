using AI_Scanner_Service.DTOs;

namespace AI_Scanner_Service.IManagers
{
    public interface IAIManager
    {
        public List<AIServiceDTO> AddAISystems();

        public List<AIServiceDTO> ApproveAISystemList();

        public List<AIServiceDTO> EditAISystems(int id);

        public AIServiceDTO GetAIServiceById(int id);

        /// <summary>
        /// Get the list of all ai systems from all the ai services
        /// </summary>
        /// <returns>All the ai systems in all serivces</returns>
        public List<AIServiceDTO> GetAllAISystems();

        /// <summary>
        /// Get the list of all ai systems from all the ai services of a specific type
        /// </summary>
        /// <param name="type">The type of the ai system</param>
        /// <returns>All the ai systems in all serivces of the specified type</returns>
        public List<AIServiceDTO> GetAllAISystemsByType(AITypeDTO type);

        public void RemoveAISystem(int id);
    }
}
