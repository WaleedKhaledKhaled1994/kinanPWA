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
using PWA.Shared.DTOs;
using PWA.Shared.Entities;

namespace PWA.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SubCategoriesController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        private readonly IFileStorageService fileStorageService;
        private readonly IMapper mapper;
        public SubCategoriesController(ApplicationDbContext context, IFileStorageService fileStorageService, IMapper mapper)
        {
            this.mapper = mapper;
            this.fileStorageService = fileStorageService;
            this.context = context;
        }
        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<List<SubCategory>>> Get()
        {
            return await context.SubCategory.Include(s => s.Category).ToListAsync();
        }

        [HttpGet("category/{CategoryId}")]
        [AllowAnonymous]
        public async Task<ActionResult<List<SubCategory>>> GetByCategory(int CategoryId)
        {
            var x = await context.SubCategory.Include(s => s.Category).Where(s => s.CategoryId == CategoryId).ToListAsync();
            return x;
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<SubCategory>> Get(int id)
        {
            var subCategory = await context.SubCategory.FirstOrDefaultAsync(x => x.Id == id);
            if (subCategory == null) { return NotFound(); }
            return subCategory;
        }
        [HttpPost]
        public async Task<ActionResult<int>> Post(SubCategory subCategory)
        {
            if (!string.IsNullOrWhiteSpace(subCategory.Image))
            {
                var subCategoryImage = Convert.FromBase64String(subCategory.Image);
                subCategory.Image = await fileStorageService.SaveFile(subCategoryImage, "jpg", "subCategories");
            }
            context.Add(subCategory);
            await context.SaveChangesAsync();
            return subCategory.Id;
        }
        [HttpPut]
        public async Task<ActionResult> Put(SubCategory subCategory)
        {
            var subCategoryDB = await context.SubCategory.FirstOrDefaultAsync(x => x.Id == subCategory.Id);
            if (subCategoryDB == null) { return NotFound(); }
            subCategoryDB = mapper.Map(subCategory, subCategoryDB);
            if (!string.IsNullOrWhiteSpace(subCategory.Image))
            {
                var categoryImage = Convert.FromBase64String(subCategory.Image);
                subCategoryDB.Image = await fileStorageService.EditFile(categoryImage, "jpg", "subCategories", subCategoryDB.Image);
            }
            await context.SaveChangesAsync();
            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var subCategory = await context.SubCategory.FirstOrDefaultAsync(x => x.Id == id);
            if (subCategory == null)
            {
                return NotFound();
            }

            if (!string.IsNullOrWhiteSpace(subCategory.Image))
            {
                await fileStorageService.DeleteFile(subCategory.Image, "subCategories");
            }
            context.Remove(subCategory);
            await context.SaveChangesAsync();
            return NoContent();
        }
    }
}
