using AI_Scanner_Service.DTOs;
using AI_Scanner_Service.IRepositories;

namespace AI_Scanner_DB.Repositories
{
    public class AIRepository : IAIServiceRepository
    {
        private readonly IAIServiceRepository _AIService;

        public AIRepository(IAIServiceRepository AIService)
        {
            _AIService = AIService;
        }

        public List<AIServiceDTO> AddAIService()
        {
            throw new NotImplementedException();
        }

        public AIServiceDTO ChangeAIService(AIServiceDTO service)
        {
            throw new NotImplementedException();
        }

        public AIServiceDTO GetAIServiceById(string id)
        {
            throw new NotImplementedException();
        }

        public List<AIServiceDTO> GetAIServicesByType(string type)
        {
            throw new NotImplementedException();
        }

        public List<AIServiceDTO> GetAllAIServices()
        {
            throw new NotImplementedException();
        }

        public void RemoveAIService(AIServiceDTO service)
        {
            throw new NotImplementedException();
        }
    }
}
