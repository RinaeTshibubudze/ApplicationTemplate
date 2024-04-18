using SawsAppTemplate.Shared.Wrapper;
using System.Threading.Tasks;
using SawsAppTemplate.Application.Features.Dashboards.Queries.GetData;

namespace SawsAppTemplate.Client.Infrastructure.Managers.Dashboard
{
    public interface IDashboardManager : IManager
    {
        Task<IResult<DashboardDataResponse>> GetDataAsync();
    }
}