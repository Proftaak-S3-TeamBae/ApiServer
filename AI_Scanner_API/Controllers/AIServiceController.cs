using AI_Scanner_Service.DTOs;
using AI_Scanner_Service.IManagers;
using Microsoft.AspNetCore.Mvc;


namespace AI_Scanner_API.Controllers
{
    /// <summary>
    /// The controller for ai services  
    /// </summary>
    [Route("/api/[controller]")]
    [ApiController]

    public class AiServiceController : ControllerBase
    {
        private readonly IAIServiceManager _aIServiceManager;

        public AiServiceController(IAIServiceManager aIServiceManager)
            => _aIServiceManager = aIServiceManager;

        [HttpPost]
        [Route("add")]
        public async Task<AIServiceDTO> AddAIService()
            => await _aIServiceManager.AddAIService();

        [HttpPost]
        [Route("addlist")]
        public async Task<List<AIServiceDTO>> ApproveAIServiceList(List<AIServiceDTO> aISystemList)
            => await _aIServiceManager.ApproveAIServiceList(aISystemList);

        [HttpGet]
        [Route("all")]
        public async Task<List<AIServiceDTO>> GetAllAIServices()
            => await _aIServiceManager.GetAllAIServices();

        [HttpGet]
        [Route("allbytype")]
        public async Task<List<AIServiceDTO>> GetAllAIServicesByType(AITypeDTO type)
            => await _aIServiceManager.GetAllAIServicesByType(type);

        [HttpGet]
        [Route("allbyid")]
        public async Task<List<AIServiceDTO>> GetAIServiceById(AITypeDTO id)
            => await _aIServiceManager.GetAllAIServicesByType(id);

        [HttpPut]
        [Route("edit")]
        public async Task<List<AIServiceDTO>> EditAIService(string id)
            => await _aIServiceManager.EditAISystem(id);

        [HttpDelete]
        [Route("remove")]
        public void RemoveAISystem(string id)
            => _aIServiceManager.RemoveAISystem(id);
    }
}