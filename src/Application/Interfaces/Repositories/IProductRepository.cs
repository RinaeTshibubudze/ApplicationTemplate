using System.Threading.Tasks;

namespace SawsAppTemplate.Application.Interfaces.Repositories
{
    public interface IProductRepository
    {
        Task<bool> IsBrandUsed(int brandId);
    }
}