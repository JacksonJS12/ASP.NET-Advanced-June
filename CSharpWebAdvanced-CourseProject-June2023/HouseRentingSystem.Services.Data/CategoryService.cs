﻿namespace HouseRentingSystem.Services.Data
{
    using Interfaces;

    using Web.ViewModels.Category;

    using HouseRentingSystem.Data;
    using Microsoft.EntityFrameworkCore;

    public class CategoryService : ICategoryService
    {
        private readonly HouseRentingDbContext dbContext;

        public CategoryService(HouseRentingDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<IEnumerable<HouseSelectCategoryFormModel>> AllCategoriesAsync()
        {
            IEnumerable<HouseSelectCategoryFormModel> allCategories = await this.dbContext
                .Categories
                .AsNoTracking()
                .Select(c => new HouseSelectCategoryFormModel()
                {
                    Id = c.Id,
                    Name = c.Name
                })
                .ToArrayAsync();

            return allCategories;
        }

        public async Task<bool> ExistById(int id)
        {
            bool result = await this.dbContext
                .Categories
                .AnyAsync(c => c.Id == id);
            
            return result;
        }
    }
}
