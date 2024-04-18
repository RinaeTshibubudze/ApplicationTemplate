using SawsAppTemplate.Application.Requests.Mail;
using System.Threading.Tasks;

namespace SawsAppTemplate.Application.Interfaces.Services
{
    public interface IMailService
    {
        Task SendAsync(MailRequest request);
    }
}