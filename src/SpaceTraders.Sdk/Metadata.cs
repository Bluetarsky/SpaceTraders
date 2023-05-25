namespace SpaceTraders.Sdk;

public record Metadata
{
    public int Total { get; set; }
    public int Page { get; set; }
    public int Limit { get; set; }
}