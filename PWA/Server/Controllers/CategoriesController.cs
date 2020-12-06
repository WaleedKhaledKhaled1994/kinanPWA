using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PWA.Server.Models;
using PWA.Shared.Entities;
using PWA.Server.Helpers;
using AutoMapper;

namespace PWA.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoriesController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        private readonly IFileStorageService fileStorageService;
        private readonly IMapper mapper;

        public CategoriesController(ApplicationDbContext context, IFileStorageService fileStorageService, IMapper mapper)
        {
            this.mapper = mapper;
            this.fileStorageService = fileStorageService;
            this.context = context;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<List<Category>>> Get()
        {
            return await context.Category.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Category>> Get(int id)
        {
            var category = await context.Category.FirstOrDefaultAsync(x => x.Id == id);
            if (category == null) { return NotFound(); }
            return category;
        }

        [HttpPost]
        public async Task<ActionResult<int>> Post(Category category)
        {
            if (!string.IsNullOrWhiteSpace(category.Image))
            {
                var categoryImage = Convert.FromBase64String(category.Image);
                category.Image = await fileStorageService.SaveFile(categoryImage, "jpg", "categories");
            }
            context.Add(category);
            await context.SaveChangesAsync();
            return category.Id;
        }

        [HttpPut]
        public async Task<ActionResult> Put(Category category)
        {
            var categoryDB = await context.Category.FirstOrDefaultAsync(x => x.Id == category.Id);
            if (categoryDB == null) { return NotFound(); }
            categoryDB = mapper.Map(category, categoryDB);
            if (!string.IsNullOrWhiteSpace(category.Image))
            {
                var categoryImage = Convert.FromBase64String(category.Image);
                categoryDB.Image = await fileStorageService.EditFile(categoryImage, "jpg", "categories", categoryDB.Image);
            }
            await context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var category = await context.Category.FirstOrDefaultAsync(x => x.Id == id);
            if (category == null)
            {
                return NotFound();
            }

            if (!string.IsNullOrWhiteSpace(category.Image))
            {
                await fileStorageService.DeleteFile(category.Image, "categories");
            }
            context.Remove(category);
            await context.SaveChangesAsync();
            return NoContent();
        }
    }
}
