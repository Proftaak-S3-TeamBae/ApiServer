using AI_Scanner_Service.DTOs;

namespace AI_Scanner_Service.IRepositories
{
    public interface IAIServiceRepository
    {
        public List<AIServiceDTO> GetAllAIServices();

        public List<AIServiceDTO> GetAIServicesByType(string type);

        public List<AIServiceDTO> AddAIService();

        public AIServiceDTO ChangeAIService(AIServiceDTO service);

        public void RemoveAIService(AIServiceDTO service);

        public AIServiceDTO GetAIServiceById(string id);
    }
}
