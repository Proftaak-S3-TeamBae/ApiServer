using AI_Scanner_Service.DTOs;
using AI_Scanner_Service.IManagers;

namespace AI_Scanner_Service.Managers
{
    public class AIManager : IAIManager
    {
        private readonly IAIManager _AImanager;

        public AIManager(IAIManager AIManager)
        {
            _AImanager = AIManager;
        }

        public List<AIServiceDTO> AddAISystems()
        {
            throw new NotImplementedException();
        }

        public List<AIServiceDTO> ApproveAISystemList()
        {
            throw new NotImplementedException();
        }

        public List<AIServiceDTO> EditAISystems(int id)
        {
            throw new NotImplementedException();
        }

        public AIServiceDTO GetAIServiceById(int id)
        {
            throw new NotImplementedException();
        }

        public List<AIServiceDTO> GetAllAISystems()
        {
            throw new NotImplementedException();
        }

        public List<AIServiceDTO> GetAllAISystemsByType(AITypeDTO type)
        {
            throw new NotImplementedException();
        }

        public void RemoveAISystem(int id)
        {
            throw new NotImplementedException();
        }
    }
}
