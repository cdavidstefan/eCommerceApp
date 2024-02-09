using API.DTOs;
using AutoMapper;
using Core.Entities;

namespace API.Helpers
{
    // Derive from an automapper class called Profile.
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Product, ProductToReturnDto>()
                .ForMember(d => d.ProductBrand , o => o.MapFrom(s => s.ProductBrand.Name))
                .ForMember(d => d.ProductType , o => o.MapFrom(s => s.ProductType.Name))
                // d => d.PictureUrl - we specify the destination; o => o.MapFrom - we specify options
                .ForMember(d => d.PictureUrl, o => o.MapFrom<ProductUrlResolver>());
        }
    }
}