using SawsAppTemplate.Shared.Settings;
using System.Threading.Tasks;
using SawsAppTemplate.Shared.Wrapper;

namespace SawsAppTemplate.Shared.Managers
{
    public interface IPreferenceManager
    {
        Task SetPreference(IPreference preference);

        Task<IPreference> GetPreference();

        Task<IResult> ChangeLanguageAsync(string languageCode);
    }
}