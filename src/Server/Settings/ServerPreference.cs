using System.Linq;
using SawsAppTemplate.Shared.Constants.Localization;
using SawsAppTemplate.Shared.Settings;

namespace SawsAppTemplate.Server.Settings
{
    public record ServerPreference : IPreference
    {
        public string LanguageCode { get; set; } = LocalizationConstants.SupportedLanguages.FirstOrDefault()?.Code ?? "en-US";

        //TODO - add server preferences
    }
}