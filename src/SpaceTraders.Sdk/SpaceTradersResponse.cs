using System.Text.Json.Serialization;

namespace SpaceTraders.Sdk;

public record SpaceTradersResponse<T> where T : class
{
    public T Data { get; init; }
    [JsonPropertyName("meta")]
    public Metadata Metadata { get; init; }
}