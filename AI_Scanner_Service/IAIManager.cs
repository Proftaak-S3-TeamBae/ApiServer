namespace AI_Scanner_Service
{
    public interface IAIManager
    {
        //CREATE
        public List<AIServiceDTO> AddAISystems();

        public List<AIServiceDTO> ApproveAISystemList();

        //READ
        public List<AIServiceDTO> GetAllAISystems();


        public AIServiceDTO GetAIServiceById(int id);


        public List<AIServiceDTO> GetAllAISystemsByType(AITypeDTO type);

        //UPDATE
        public List<AIServiceDTO> EditAISystems(int id);

        //REMOVE
        public void RemoveAISystem(int id);
    }
}
