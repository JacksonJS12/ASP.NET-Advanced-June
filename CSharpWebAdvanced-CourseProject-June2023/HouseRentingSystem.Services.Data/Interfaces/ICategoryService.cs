﻿using HouseRentingSystem.Web.ViewModels.Category;

namespace HouseRentingSystem.Services.Data.Interfaces;

public interface ICategoryService
{
    Task<IEnumerable<HouseSelectCategoryFormModel>> AllCategoriesAsync();

    Task<bool> ExistById(int id);
}