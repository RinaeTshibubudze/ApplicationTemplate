using AutoMapper;
using SawsAppTemplate.Infrastructure.Models.Audit;
using SawsAppTemplate.Application.Responses.Audit;

namespace SawsAppTemplate.Infrastructure.Mappings
{
    public class AuditProfile : Profile
    {
        public AuditProfile()
        {
            CreateMap<AuditResponse, Audit>().ReverseMap();
        }
    }
}