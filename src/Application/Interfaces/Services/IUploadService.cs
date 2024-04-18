using SawsAppTemplate.Application.Requests;

namespace SawsAppTemplate.Application.Interfaces.Services
{
    public interface IUploadService
    {
        string UploadAsync(UploadRequest request);
    }
}