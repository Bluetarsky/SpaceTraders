using System.Runtime.Serialization;

namespace SpaceTraders.Sdk;

public enum FlightMode
{
    [EnumMember(Value = "DRIFT")]
    Drift = 1,
    [EnumMember(Value = "STEALTH")]
    Stealth = 2,
    [EnumMember(Value = "CRUISE")]
    Cruise = 3,
    [EnumMember(Value = "BURN")]
    Burn = 4
}