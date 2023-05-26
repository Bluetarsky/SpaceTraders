using System.ComponentModel.DataAnnotations;
using SpaceTraders.Sdk.Types;

namespace SpaceTraders.Sdk.Registration;

public record RegisterNewAgent
{
    public FactionType FactionType { get; set; }
    public string Symbol { get; set; }
    public string? Email { get; set; }
}