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

        [HttpPost]
        [ActionName("AddAIService")]
        public async Task<AIServiceDTO> AddAIService()
            => await _aIServiceManager.AddAIService();

        [HttpPost]
        [ActionName("ApproveAIServiceList")]
        public async Task<List<AIServiceDTO>> ApproveAIServiceList(List<AIServiceDTO> aISystemList)
            => await _aIServiceManager.ApproveAIServiceList(aISystemList);

        [HttpGet]
        [ActionName("GetAllAIServices")]
        public async Task<List<AIServiceDTO>> GetAllAIServices()
            => await _aIServiceManager.GetAllAIServices();

        [HttpGet]
        [ActionName("GetAllAIServicesByType")]
        public async Task<List<AIServiceDTO>> GetAllAIServicesByType(AITypeDTO type)
            => await _aIServiceManager.GetAllAIServicesByType(type);

        [HttpGet]
        [ActionName("GetAIServiceById")]
        public async Task<List<AIServiceDTO>> GetAIServiceById(AITypeDTO id)
            => await _aIServiceManager.GetAllAIServicesByType(id);

        [HttpPut]
        [ActionName("EditAIService")]
        public async Task<List<AIServiceDTO>> EditAIService(string id)
            => await _aIServiceManager.EditAISystem(id);

        [HttpDelete]
        [ActionName("RemoveAISystem")]
        public void RemoveAISystem(string id)
            => _aIServiceManager.RemoveAISystem(id);
    }
}