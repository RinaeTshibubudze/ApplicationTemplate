
using SawsAppTemplate.Application.Interfaces.Serialization.Settings;
using Newtonsoft.Json;

namespace SawsAppTemplate.Application.Serialization.Settings
{
    public class NewtonsoftJsonSettings : IJsonSerializerSettings
    {
        public JsonSerializerSettings JsonSerializerSettings { get; } = new();
    }
}