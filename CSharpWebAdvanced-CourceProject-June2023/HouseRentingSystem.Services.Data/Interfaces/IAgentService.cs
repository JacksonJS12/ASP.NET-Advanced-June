namespace HouseRentingSystem.Services.Data.Interfaces;

using Web.ViewModels.Agent;
public interface IAgentService
{
    Task<bool> AgentExistByUserIdAsync(string userId);

    Task<bool> AgentExistsByPhoneNumberAsync(string phoneNumber);

    Task<bool> HasRentsByUserIdAsync(string userId);

    Task Create(string userId, BecomeAgentFormModel model);
}