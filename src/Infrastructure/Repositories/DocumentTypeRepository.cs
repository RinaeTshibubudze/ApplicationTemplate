using SawsAppTemplate.Application.Interfaces.Repositories;
using SawsAppTemplate.Domain.Entities.Misc;

namespace SawsAppTemplate.Infrastructure.Repositories
{
    public class DocumentTypeRepository : IDocumentTypeRepository
    {
        private readonly IRepositoryAsync<DocumentType, int> _repository;

        public DocumentTypeRepository(IRepositoryAsync<DocumentType, int> repository)
        {
            _repository = repository;
        }
    }
}