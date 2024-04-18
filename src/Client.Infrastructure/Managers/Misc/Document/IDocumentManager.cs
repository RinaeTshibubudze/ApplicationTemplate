using SawsAppTemplate.Application.Features.Documents.Commands.AddEdit;
using SawsAppTemplate.Application.Features.Documents.Queries.GetAll;
using SawsAppTemplate.Application.Requests.Documents;
using SawsAppTemplate.Shared.Wrapper;
using System.Threading.Tasks;
using SawsAppTemplate.Application.Features.Documents.Queries.GetById;

namespace SawsAppTemplate.Client.Infrastructure.Managers.Misc.Document
{
    public interface IDocumentManager : IManager
    {
        Task<PaginatedResult<GetAllDocumentsResponse>> GetAllAsync(GetAllPagedDocumentsRequest request);

        Task<IResult<GetDocumentByIdResponse>> GetByIdAsync(GetDocumentByIdQuery request);

        Task<IResult<int>> SaveAsync(AddEditDocumentCommand request);

        Task<IResult<int>> DeleteAsync(int id);
    }
}