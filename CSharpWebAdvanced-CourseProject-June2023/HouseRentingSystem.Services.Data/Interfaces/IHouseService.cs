﻿namespace HouseRentingSystem.Services.Data.Interfaces
{
    using HouseRentingSystem.Services.Data.Models.Statistics;
    using Models.House;
    using Web.ViewModels.House;
    using Web.ViewModels.Home;

    public interface IHouseService
    {
        Task<IEnumerable<IndexViewModel>> LastThreeHousesAsync();

        Task<string> CreateAndReturnIdAsync(HouseFormModel formModel, string agentId);

        Task<AllHousesFilteredAndPagedServiceModel> AllAsync(AllHousesQueryModel queryModel);

        Task<IEnumerable<HouseAllViewModel>> AllByAgentIdAsync(string agentId);

        Task<IEnumerable<HouseAllViewModel>> AllByUserIdAsync(string userId);

        Task<bool> ExistsByIdAsync(string houseId);

        Task<HouseDetailsViewModel?> GetDetailsByIdAsync(string houseId);

        Task<HouseFormModel> GetHouseForEditByIdAsync(string houseId);

        Task<bool> IsAgentWithIdOwnerOfHouseWithIdAsync(string houseId, string agentId);

        Task EditHouseByIdAndFormModelAsync(string houseId, HouseFormModel formModel);

        Task<HousePreDeleteDetailsViewModel> GetHouseForDeleteByIdAsync(string houseId);

        Task DeleteHouseByIdAsync(string houseId);
        Task<bool> IsRentedAsync(string houseId);
        Task RentHouseAsync(string houseId, string userId);
        Task<bool> IsRentedByUserWithIdAsync(string houseId, string userId);
        Task LeaveHouseAsync(string houseId);

        Task<StatisticsServiceModel> GetStatisticsAsync();
    }
}
