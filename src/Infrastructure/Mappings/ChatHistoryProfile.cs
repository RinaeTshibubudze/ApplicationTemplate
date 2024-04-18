using AutoMapper;
using SawsAppTemplate.Application.Interfaces.Chat;
using SawsAppTemplate.Application.Models.Chat;
using SawsAppTemplate.Infrastructure.Models.Identity;

namespace SawsAppTemplate.Infrastructure.Mappings
{
    public class ChatHistoryProfile : Profile
    {
        public ChatHistoryProfile()
        {
            CreateMap<ChatHistory<IChatUser>, ChatHistory<BlazorHeroUser>>().ReverseMap();
        }
    }
}