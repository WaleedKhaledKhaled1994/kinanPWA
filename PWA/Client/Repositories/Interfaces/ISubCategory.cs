using PWA.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PWA.Client.Repositories.Interfaces
{
    public interface ISubCategory
    {
        Task<int> CreateSubCategory(SubCategory subCategory);
        Task DeleteSubCategory(int Id);
        Task<List<SubCategory>> GetSubCategories();
        Task<List<SubCategory>> GetSubCategoriesByCategory(int categoryId);
        Task<SubCategory> GetSubCategory(int Id);
        Task UpdateSubCategory(SubCategory subCategory);
    }
}
