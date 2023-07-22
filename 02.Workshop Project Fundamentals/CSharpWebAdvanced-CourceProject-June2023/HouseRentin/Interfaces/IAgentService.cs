namespace HouseRentingSystem.Services.Data.Interfaces;

public interface IAgentService
{
    Task<bool> AgentExistByUserId(string userId);
}