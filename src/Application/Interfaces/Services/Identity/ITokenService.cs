using SawsAppTemplate.Application.Interfaces.Common;
using SawsAppTemplate.Application.Requests.Identity;
using SawsAppTemplate.Application.Responses.Identity;
using SawsAppTemplate.Shared.Wrapper;
using System.Threading.Tasks;

namespace SawsAppTemplate.Application.Interfaces.Services.Identity
{
    public interface ITokenService : IService
    {
        Task<Result<TokenResponse>> LoginAsync(TokenRequest model);

        Task<Result<TokenResponse>> GetRefreshTokenAsync(RefreshTokenRequest model);
    }
}