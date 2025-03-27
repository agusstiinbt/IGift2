using Application.Interfaces.Serialization.Settings;
using Newtonsoft.Json;

namespace Infrastructure.Serialization.Settings
{
    public class NewtonsoftJsonSettings : IJsonSerializerSettings
    {
        public JsonSerializerSettings JsonSerializerSettings { get; } = new();
    }
}
