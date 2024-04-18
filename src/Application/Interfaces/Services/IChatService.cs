using SawsAppTemplate.Application.Responses.Identity;
using SawsAppTemplate.Shared.Wrapper;
using System.Collections.Generic;
using System.Threading.Tasks;
using SawsAppTemplate.Application.Interfaces.Chat;
using SawsAppTemplate.Application.Models.Chat;

namespace SawsAppTemplate.Application.Interfaces.Services
{
    public interface IChatService
    {
        Task<Result<IEnumerable<ChatUserResponse>>> GetChatUsersAsync(string userId);

        Task<IResult> SaveMessageAsync(ChatHistory<IChatUser> message);

        Task<Result<IEnumerable<ChatHistoryResponse>>> GetChatHistoryAsync(string userId, string contactId);
    }
}