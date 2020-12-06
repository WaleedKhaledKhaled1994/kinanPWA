using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PWA.Server.Helpers;
using PWA.Server.Models;
using PWA.Shared.Entities;

namespace PWA.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        private readonly IFileStorageService fileStorageService;
        private readonly IMapper mapper;
        public ProductController(ApplicationDbContext context, IFileStorageService fileStorageService, IMapper mapper)
        {
            this.mapper = mapper;
            this.fileStorageService = fileStorageService;
            this.context = context;
        }
        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<List<Product>>> Get()
        {
            var a = await context.Product.Include(a=>a.SubCategory).ThenInclude(s => s.Category).ToListAsync();
            Console.WriteLine("a");
            return a;
        }

        [HttpGet("subcategory/{SubcategoryId}")]
        [AllowAnonymous]
        public async Task<ActionResult<List<Product>>> GetBySubCategory(int SubCategoryId)
        {
            var x = await context.Product.Include(s => s.SubCategory).ThenInclude(s => s.Category).Where(s => s.SubCatId == SubCategoryId).ToListAsync();
            return x;
        }


        [HttpGet("{Id}")]
        public async Task<ActionResult<Product>> Get(long Id)
        {
            var product = await context.Product.Include(s => s.SubCategory).ThenInclude(s=>s.Category).FirstOrDefaultAsync(x => x.Id == Id);
            if (product == null) { return NotFound(); }
            return product;
        }
        [HttpPost]
        public async Task<ActionResult<long>> Post(Product product)
        {
            if (!string.IsNullOrWhiteSpace(product.Image))
            {
                var productImage = Convert.FromBase64String(product.Image);
                product.Image = await fileStorageService.SaveFile(productImage, "jpg", "products");
            }
            context.Add(product);
            await context.SaveChangesAsync();
            return product.Id;
        }
        [HttpPut]
        public async Task<ActionResult> Put(Product product)
        {
            var productDB = await context.Product.Include(s => s.SubCategory).ThenInclude(s => s.Category).FirstOrDefaultAsync(x => x.Id == product.Id);
            if (productDB == null) { return NotFound(); }
            productDB = mapper.Map(product, productDB);
            if (!string.IsNullOrWhiteSpace(product.Image))
            {
                var productImage = Convert.FromBase64String(product.Image);
                productDB.Image = await fileStorageService.EditFile(productImage, "jpg", "products", productDB.Image);
            }
            await context.SaveChangesAsync();
            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(long id)
        {
            var product = await context.Product.Include(s => s.SubCategory).ThenInclude(s => s.Category).FirstOrDefaultAsync(x => x.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            if (!string.IsNullOrWhiteSpace(product.Image))
            {
                await fileStorageService.DeleteFile(product.Image, "products");
            }
            context.Remove(product);
            await context.SaveChangesAsync();
            return NoContent();
        }
    }
}
