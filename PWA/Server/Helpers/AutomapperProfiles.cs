using AutoMapper;
using PWA.Shared.Entities;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PWA.Server.Helpers
{
    public class AutomapperProfiles : Profile
    {
        public AutomapperProfiles()
        {
            CreateMap<Category, Category>()
                .ForMember(x => x.Image, option => option.Ignore());

            CreateMap<SubCategory, SubCategory>()
                .ForMember(x => x.Image, option => option.Ignore());

            CreateMap<Product, Product>()
                .ForMember(x => x.Image, option => option.Ignore());
        }
    }
}
