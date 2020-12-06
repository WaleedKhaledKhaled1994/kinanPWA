using PWA.Client.Helpers;
using PWA.Client.Repositories.Interfaces;
using PWA.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PWA.Client.Repositories
{
    public class SubCategoryRepository : ISubCategory
    {
        private readonly IHttpService httpService;
        private readonly string url = "api/subCategories";

        public SubCategoryRepository(IHttpService httpService)
        {
            this.httpService = httpService;
        }


        public async Task<List<SubCategory>> GetSubCategories()
        {
            var response = await httpService.Get<List<SubCategory>>(url);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }

        public async Task<List<SubCategory>> GetSubCategoriesByCategory(int CategoryId)
        {
            var response = await httpService.Get<List<SubCategory>>($"{url}/category/{CategoryId}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }

        public async Task<SubCategory> GetSubCategory(int Id)
        {
            var response = await httpService.Get<SubCategory>($"{url}/{Id}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }

        public async Task<int> CreateSubCategory(SubCategory subCategory)
        {
            var response = await httpService.Post<SubCategory, int>(url, subCategory);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }

        public async Task UpdateSubCategory(SubCategory subCategory)
        {
            var response = await httpService.Put(url, subCategory);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        public async Task DeleteSubCategory(int Id)
        {
            var response = await httpService.Delete($"{url}/{Id}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }
    }
}
