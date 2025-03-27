using System.Text.Json;
using Application.Interfaces.Serialization.Options;

namespace Infrastructure.Serialization
{
    /// <summary>
    /// Encapsula las configuraciones que System.Text.Json usará para serializar y deserializar
    /// </summary>
    public class SystemTextJsonOptions : IJsonSerializerOptions
    {
        public JsonSerializerOptions JsonSerializerOptions { get; } = new();
    }
}
