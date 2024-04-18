using AutoMapper;
using SawsAppTemplate.Application.Features.Brands.Commands.AddEdit;
using SawsAppTemplate.Application.Features.Brands.Queries.GetAll;
using SawsAppTemplate.Application.Features.Brands.Queries.GetById;
using SawsAppTemplate.Domain.Entities.Catalog;

namespace SawsAppTemplate.Application.Mappings
{
    public class BrandProfile : Profile
    {
        public BrandProfile()
        {
            CreateMap<AddEditBrandCommand, Brand>().ReverseMap();
            CreateMap<GetBrandByIdResponse, Brand>().ReverseMap();
            CreateMap<GetAllBrandsResponse, Brand>().ReverseMap();
        }
    }
}