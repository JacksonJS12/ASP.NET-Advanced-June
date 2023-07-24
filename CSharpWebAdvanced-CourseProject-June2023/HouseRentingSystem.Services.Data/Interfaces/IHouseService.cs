namespace HouseRentingSystem.Services.Data.Interfaces
{
    using HouseRentingSystem.Web.ViewModels.House;
    using Web.ViewModels.Home;

    public interface IHouseService
    {
        Task<IEnumerable<IndexViewModel>> LastThreeHousesAsync();

        Task CreateAsync(HouseFormModel formModel, string agentId);
    }
}
