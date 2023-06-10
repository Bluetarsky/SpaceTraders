using System.Runtime.Serialization;

namespace SpaceTraders.Sdk;

public enum SupplyAmount
{
    [EnumMember(Value = "SCARCE")]
    Scarce = 1,
    [EnumMember(Value = "LIMITED")]
    Limited = 2,
    [EnumMember(Value = "MODERATE")]
    Moderate = 3,
    [EnumMember(Value = "ABUNDANT")]
    Abundant = 4
}