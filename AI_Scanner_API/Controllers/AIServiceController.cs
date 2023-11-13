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

        /// <summary>
        /// Add a new ai service
        /// </summary>
        /// <returns></returns>
        [HttpPost("add")]
        public async Task<AIServiceDTO> AddAIService()
            => await _aIServiceManager.AddAIService();

        /// <summary>
        /// Approve a list of ai services
        /// </summary>
        /// <param name="aISystemList"></param>
        /// <returns></returns>
        [HttpPost("addlist")]
        public async Task<List<AIServiceDTO>> ApproveAIServiceList(List<AIServiceDTO> aISystemList)
            => await _aIServiceManager.ApproveAIServiceList(aISystemList);

        /// <summary>
        /// Get all ai services
        /// </summary>
        /// <returns></returns>
        [HttpGet("all")]
        public async Task<List<AIServiceDTO>> GetAllAIServices()
            => await _aIServiceManager.GetAllAIServices();

        /// <summary>
        /// Get all ai services by type
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        [HttpGet("allbytype")]
        public async Task<List<AIServiceDTO>> GetAllAIServicesByType(AITypeDTO type)
            => await _aIServiceManager.GetAllAIServicesByType(type);

        /// <summary>
        /// Get all ai services by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("allbyid")]
        public async Task<List<AIServiceDTO>> GetAIServiceById(AITypeDTO id)
            => await _aIServiceManager.GetAllAIServicesByType(id);

        /// <summary>
        /// Edit an ai service
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPut("edit")]
        public async Task<List<AIServiceDTO>> EditAIService(string id)
            => await _aIServiceManager.EditAISystem(id);

        /// <summary>
        /// Remove an ai service
        /// </summary>s
        /// <param name="id"></param>
        [HttpDelete("remove")]
        public void RemoveAISystem(string id)
            => _aIServiceManager.RemoveAISystem(id);
    }
}