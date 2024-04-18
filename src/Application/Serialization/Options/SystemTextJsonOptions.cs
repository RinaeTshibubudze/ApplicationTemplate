using System.Text.Json;
using SawsAppTemplate.Application.Interfaces.Serialization.Options;

namespace SawsAppTemplate.Application.Serialization.Options
{
    public class SystemTextJsonOptions : IJsonSerializerOptions
    {
        public JsonSerializerOptions JsonSerializerOptions { get; } = new();
    }
}