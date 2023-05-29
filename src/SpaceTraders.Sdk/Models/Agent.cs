namespace SpaceTraders.Sdk;

public record Agent
{
    /// <summary>
    /// 
    /// </summary>
    public string AccountId { get; init; }
    
    /// <summary>
    /// 
    /// </summary>
    public string Symbol { get; init; }
    
    /// <summary>
    /// 
    /// </summary>
    public string Headquarters { get; init; }
    
    /// <summary>
    /// 
    /// </summary>
    public int Credits { get; init; }
    
    /// <summary>
    /// NewDirectory1
    /// </summary>
    public string StartingFaction { get; init; }
}