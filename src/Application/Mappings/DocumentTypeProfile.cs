using AutoMapper;
using SawsAppTemplate.Application.Features.DocumentTypes.Commands.AddEdit;
using SawsAppTemplate.Application.Features.DocumentTypes.Queries.GetAll;
using SawsAppTemplate.Application.Features.DocumentTypes.Queries.GetById;
using SawsAppTemplate.Domain.Entities.Misc;

namespace SawsAppTemplate.Application.Mappings
{
    public class DocumentTypeProfile : Profile
    {
        public DocumentTypeProfile()
        {
            CreateMap<AddEditDocumentTypeCommand, DocumentType>().ReverseMap();
            CreateMap<GetDocumentTypeByIdResponse, DocumentType>().ReverseMap();
            CreateMap<GetAllDocumentTypesResponse, DocumentType>().ReverseMap();
        }
    }
}