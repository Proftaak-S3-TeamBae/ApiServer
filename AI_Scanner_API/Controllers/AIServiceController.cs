using AI_Scanner_Service.DTOs;
using AI_Scanner_Service.Entities;
using AI_Scanner_Service.IManagers;
using AI_Scanner_Service.Managers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace AI_Scanner_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class AiServiceController : ControllerBase
    {
        private readonly IAIManager _aIServiceManager;

        public AiServiceController(IAIManager aIServiceManager)
            => _aIServiceManager = aIServiceManager;

        [HttpGet]
        public async Task<List<AIServiceDTO>> GetAllAIServices()
            => await _aIServiceManager.GetAllAISystems();

        [HttpGet]
        public async Task<List<AIServiceDTO>> GetAllAISystemsByType(AITypeDTO type)
            => await _aIServiceManager.GetAllAISystemsByType(type);

        [HttpGet]
        public async Task<List<AIServiceDTO>> GetAIServiceById(AITypeDTO id)
            => await _aIServiceManager.GetAllAISystemsByType(id);

        [HttpPut]
        public async Task<List<AIServiceDTO>> EditAISystems(string id)
            => await _aIServiceManager.EditAISystems(id);


        [HttpPost]
        public async Task<AIServiceDTO> AddAISystems()
            => await _aIServiceManager.AddAISystem();


        [HttpPost]
        public async Task<List<AIServiceDTO>> ApproveAIList()
            => await _aIServiceManager.ApproveAISystemList();

        [HttpDelete]
        public void RemoveAISystem(string id)
            => _aIServiceManager.RemoveAISystem(id);
    }
}