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
        {
            _aIServiceManager = aIServiceManager;
        }

        [HttpGet]
        public async Task<List<AIServiceDTO>> GetAllAIServices()
        {
            return _aIServiceManager.GetAllAISystems();
        }
    }
}
