using SawsAppTemplate.Application.Features.Products.Commands.AddEdit;
using SawsAppTemplate.Application.Features.Products.Queries.GetAllPaged;
using SawsAppTemplate.Application.Requests.Catalog;
using SawsAppTemplate.Shared.Wrapper;
using System.Threading.Tasks;

namespace SawsAppTemplate.Client.Infrastructure.Managers.Catalog.Product
{
    public interface IProductManager : IManager
    {
        Task<PaginatedResult<GetAllPagedProductsResponse>> GetProductsAsync(GetAllPagedProductsRequest request);

        Task<IResult<string>> GetProductImageAsync(int id);

        Task<IResult<int>> SaveAsync(AddEditProductCommand request);

        Task<IResult<int>> DeleteAsync(int id);

        Task<IResult<string>> ExportToExcelAsync(string searchString = "");
    }
}