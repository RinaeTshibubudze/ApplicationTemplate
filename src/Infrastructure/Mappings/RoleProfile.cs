using AutoMapper;
using SawsAppTemplate.Infrastructure.Models.Identity;
using SawsAppTemplate.Application.Responses.Identity;

namespace SawsAppTemplate.Infrastructure.Mappings
{
    public class RoleProfile : Profile
    {
        public RoleProfile()
        {
            CreateMap<RoleResponse, BlazorHeroRole>().ReverseMap();
        }
    }
}