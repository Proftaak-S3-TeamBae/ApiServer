using AI_Scanner_Service.DTOs;
using AI_Scanner_Service.IManagers;
using Microsoft.AspNetCore.Mvc;


namespace AI_Scanner_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class AiServiceController : ControllerBase
    {
        private readonly IAIServiceManager _aIServiceManager;

        public AiServiceController(IAIServiceManager aIServiceManager)
            => _aIServiceManager = aIServiceManager;

        [HttpGet]
        [ActionName("GetAllAIServices")]
        public async Task<List<AIServiceDTO>> GetAllAIServices()
            => await _aIServiceManager.GetAllAIServices();

        [HttpGet]
        [ActionName("GetAllAISystemsByType")]
        public async Task<List<AIServiceDTO>> GetAllAIServicesByType(AITypeDTO type)
            => await _aIServiceManager.GetAllAIServicesByType(type);

        [HttpGet]
        [ActionName("GetAIServiceById")]
        public async Task<List<AIServiceDTO>> GetAIServiceById(AITypeDTO id)
            => await _aIServiceManager.GetAllAIServicesByType(id);

        [HttpPut]
        [ActionName("EditAISystem")]
        public async Task<List<AIServiceDTO>> EditAIService(string id)
            => await _aIServiceManager.EditAISystem(id);


        [HttpPost]
        public async Task<AIServiceDTO> AddAIService()
            => await _aIServiceManager.AddAIService();


        [HttpPost]
        public async Task<List<AIServiceDTO>> ApproveAIServiceList(List<AIServiceDTO> aISystemList)
            => await _aIServiceManager.ApproveAIServiceList(aISystemList);

        [HttpDelete]
        public void RemoveAISystem(string id)
            => _aIServiceManager.RemoveAISystem(id);
    }
}