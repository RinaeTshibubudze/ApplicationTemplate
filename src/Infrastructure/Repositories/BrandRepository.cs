using SawsAppTemplate.Application.Interfaces.Repositories;
using SawsAppTemplate.Domain.Entities.Catalog;

namespace SawsAppTemplate.Infrastructure.Repositories
{
    public class BrandRepository : IBrandRepository
    {
        private readonly IRepositoryAsync<Brand, int> _repository;

        public BrandRepository(IRepositoryAsync<Brand, int> repository)
        {
            _repository = repository;
        }
    }
}