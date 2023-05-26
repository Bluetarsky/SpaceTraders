namespace SpaceTraders.Sdk;

public record Agent
{
    public string AccountId { get; init; }
    public string Symbol { get; init; }
    public string Headquarters { get; init; }
    public int Credits { get; init; }
    public string StartingFaction { get; init; }
}