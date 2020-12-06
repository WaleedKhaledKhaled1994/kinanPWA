using PWA.Client.Helpers;
using PWA.Client.Repositories.Interfaces;
using PWA.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PWA.Client.Repositories
{
    public class CategoryRepository : ICategory
    {
        private readonly IHttpService httpService;
        private readonly string url = "api/categories";

        public CategoryRepository(IHttpService httpService)
        {
            this.httpService = httpService;
        }


        public async Task<List<Category>> GetCategories()
        {
            var response = await httpService.Get<List<Category>>(url);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }
        public async Task<Category> GetCategory(int Id)
        {
            var response = await httpService.Get<Category>($"{url}/{Id}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }

        public async Task<int> CreateCategory(Category category)
        {
            var response = await httpService.Post<Category, int>(url, category);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }

        public async Task UpdateCategory(Category category)
        {
            var response = await httpService.Put(url, category);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        public async Task DeleteCategory(int Id)
        {
            var response = await httpService.Delete($"{url}/{Id}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }
    }
}
