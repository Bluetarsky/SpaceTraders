namespace SpaceTraders.Sdk;

public record Result<T> where T : class
{
    public bool Success { get; set; }

    public SpaceTradersResponse<T>? Response { get; set; }

    public IEnumerable<string> ErrorMessages { get; set; } = Enumerable.Empty<string>();
}