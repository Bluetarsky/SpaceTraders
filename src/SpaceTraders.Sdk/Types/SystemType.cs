using System.Runtime.Serialization;

namespace SpaceTraders.Sdk;

public enum SystemType
{
    [EnumMember(Value = "")]
    NeutronStar = 0,
    [EnumMember(Value = "")]
    RedStar,
    [EnumMember(Value = "")]
    OrangeStar,
    [EnumMember(Value = "")]
    BlueStar,
    [EnumMember(Value = "")]
    YoungStar,
    [EnumMember(Value = "")]
    WhiteDwarf,
    [EnumMember(Value = "")]
    BlackHole,
    [EnumMember(Value = "")]
    HyperGiant,
    [EnumMember(Value = "")]
    Nebula,
    [EnumMember(Value = "")]
    Unstable
}