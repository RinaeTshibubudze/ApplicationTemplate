﻿using SawsAppTemplate.Application.Interfaces.Common;
using SawsAppTemplate.Application.Requests.Identity;
using SawsAppTemplate.Shared.Wrapper;
using System.Threading.Tasks;

namespace SawsAppTemplate.Application.Interfaces.Services.Account
{
    public interface IAccountService : IService
    {
        Task<IResult> UpdateProfileAsync(UpdateProfileRequest model, string userId);

        Task<IResult> ChangePasswordAsync(ChangePasswordRequest model, string userId);

        Task<IResult<string>> GetProfilePictureAsync(string userId);

        Task<IResult<string>> UpdateProfilePictureAsync(UpdateProfilePictureRequest request, string userId);
    }
}