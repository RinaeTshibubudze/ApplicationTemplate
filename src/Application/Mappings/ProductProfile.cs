using AutoMapper;
using SawsAppTemplate.Application.Features.Products.Commands.AddEdit;
using SawsAppTemplate.Domain.Entities.Catalog;

namespace SawsAppTemplate.Application.Mappings
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<AddEditProductCommand, Product>().ReverseMap();
        }
    }
}