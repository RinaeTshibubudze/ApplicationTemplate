using System.Collections.Generic;
using System.Threading.Tasks;
using SawsAppTemplate.Application.Interfaces.Common;
using SawsAppTemplate.Application.Requests.Identity;
using SawsAppTemplate.Application.Responses.Identity;
using SawsAppTemplate.Shared.Wrapper;

namespace SawsAppTemplate.Application.Interfaces.Services.Identity
{
    public interface IRoleClaimService : IService
    {
        Task<Result<List<RoleClaimResponse>>> GetAllAsync();

        Task<int> GetCountAsync();

        Task<Result<RoleClaimResponse>> GetByIdAsync(int id);

        Task<Result<List<RoleClaimResponse>>> GetAllByRoleIdAsync(string roleId);

        Task<Result<string>> SaveAsync(RoleClaimRequest request);

        Task<Result<string>> DeleteAsync(int id);
    }
}