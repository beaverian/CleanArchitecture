using AutoMapper;
using CleanArchitectureECommerce.Application.Dto;
using CleanArchitectureECommerce.Core.Entities;

namespace CleanArchitectureECommerce.Common.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Product, ProductDto>().ReverseMap();
        }
    }
}
