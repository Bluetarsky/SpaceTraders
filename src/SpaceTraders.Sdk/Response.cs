using System.Text.Json.Serialization;

namespace SpaceTraders.Sdk;

public record Response<T> where T : class
{
    public T Data { get; init; }
    [JsonPropertyName("meta")]
    public Metadata Metadata { get; init; }
}