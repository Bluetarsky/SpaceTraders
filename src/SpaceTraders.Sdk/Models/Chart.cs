namespace SpaceTraders.Sdk;

public record Chart
{
    public string WaypointSymbol { get; set; }
    public string SubmittedBy { get; set; }
    public DateTime SubmittedOn { get; set; }
}