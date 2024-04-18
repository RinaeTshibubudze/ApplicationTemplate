using AutoMapper;
using SawsAppTemplate.Application.Requests.Identity;
using SawsAppTemplate.Application.Responses.Identity;

namespace SawsAppTemplate.Client.Infrastructure.Mappings
{
    public class RoleProfile : Profile
    {
        public RoleProfile()
        {
            CreateMap<PermissionResponse, PermissionRequest>().ReverseMap();
            CreateMap<RoleClaimResponse, RoleClaimRequest>().ReverseMap();
        }
    }
}