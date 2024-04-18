using SawsAppTemplate.Application.Interfaces.Common;

namespace SawsAppTemplate.Application.Interfaces.Services
{
    public interface ICurrentUserService : IService
    {
        string UserId { get; }
    }
}