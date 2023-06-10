using System.Runtime.Serialization;

namespace SpaceTraders.Sdk;

public enum FactionType
{
    [EnumMember(Value = "COSMIC")]
    Cosmic,
    [EnumMember(Value = "VOID")]
    Void,
    [EnumMember(Value = "GALACTIC")]
    Galactic,
    [EnumMember(Value = "QUANTUM")]
    Quantum,
    [EnumMember(Value = "DOMINION")]
    Dominion
}