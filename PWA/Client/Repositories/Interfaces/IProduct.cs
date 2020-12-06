using PWA.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PWA.Client.Repositories.Interfaces
{
    public interface IProduct
    {
        Task<long> CreateProduct(Product product);
        Task DeleteProduct(long Id);
        Task<Product> GetProduct(long Id);
        Task<List<Product>> GetProducts();
        Task<List<Product>> GetProductsBySubCategory(int SubCategoryId);
        Task UpdateProduct(Product product);
    }
}
