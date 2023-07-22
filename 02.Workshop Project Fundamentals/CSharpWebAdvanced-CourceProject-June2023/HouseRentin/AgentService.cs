namespace HouseRentingSystem.Services.Data
{
    using Interfaces;

    using HouseRentingSystem.Data;
    using Microsoft.EntityFrameworkCore;
    public class AgentService : IAgentService
    {
        private readonly HouseRentingDbContext dbContext;

        public AgentService(HouseRentingDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<bool> AgentExistByUserId(string userId)
        {
            bool result = await this.dbContext
                .Agents
                .AnyAsync(a => a.UserId.ToString() == userId);

            return result;
        }
    }
}
