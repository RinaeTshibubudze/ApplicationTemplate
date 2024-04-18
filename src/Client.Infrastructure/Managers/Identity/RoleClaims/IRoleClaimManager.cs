using System.Collections.Generic;
using System.Threading.Tasks;
using SawsAppTemplate.Application.Requests.Identity;
using SawsAppTemplate.Application.Responses.Identity;
using SawsAppTemplate.Shared.Wrapper;

namespace SawsAppTemplate.Client.Infrastructure.Managers.Identity.RoleClaims
{
    public interface IRoleClaimManager : IManager
    {
        Task<IResult<List<RoleClaimResponse>>> GetRoleClaimsAsync();

        Task<IResult<List<RoleClaimResponse>>> GetRoleClaimsByRoleIdAsync(string roleId);

        Task<IResult<string>> SaveAsync(RoleClaimRequest role);

        Task<IResult<string>> DeleteAsync(string id);
    }
}