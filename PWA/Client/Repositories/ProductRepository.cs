using PWA.Client.Helpers;
using PWA.Client.Repositories.Interfaces;
using PWA.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PWA.Client.Repositories
{
    public class ProductRepository:IProduct
    {
        private readonly IHttpService httpService;
        private readonly string url = "api/product";

        public ProductRepository(IHttpService httpService)
        {
            this.httpService = httpService;
        }

        public async Task<List<Product>> GetProducts()
        {
            var response = await httpService.Get<List<Product>>(url);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }

        public async Task<List<Product>> GetProductsBySubCategory(int SubCategoryId)
        {
            var response = await httpService.Get<List<Product>>($"{url}/subcategory/{SubCategoryId}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }

        public async Task<Product> GetProduct(long Id)
        {
            var response = await httpService.Get<Product>($"{url}/{Id}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }

        public async Task<long> CreateProduct(Product product)
        {
            var response = await httpService.Post<Product, int>(url, product);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }

        public async Task UpdateProduct(Product product)
        {
            var response = await httpService.Put(url, product);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        public async Task DeleteProduct(long Id)
        {
            var response = await httpService.Delete($"{url}/{Id}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }
    }
}
