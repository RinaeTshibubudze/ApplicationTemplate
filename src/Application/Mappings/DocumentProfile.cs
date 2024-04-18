using AutoMapper;
using SawsAppTemplate.Application.Features.Documents.Commands.AddEdit;
using SawsAppTemplate.Application.Features.Documents.Queries.GetById;
using SawsAppTemplate.Domain.Entities.Misc;

namespace SawsAppTemplate.Application.Mappings
{
    public class DocumentProfile : Profile
    {
        public DocumentProfile()
        {
            CreateMap<AddEditDocumentCommand, Document>().ReverseMap();
            CreateMap<GetDocumentByIdResponse, Document>().ReverseMap();
        }
    }
}