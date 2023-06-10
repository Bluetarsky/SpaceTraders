using System.Runtime.Serialization;

namespace SpaceTraders.Sdk;

public enum RotationType
{
    [EnumMember(Value = "STRICT")]
    Strict = 1,
    [EnumMember(Value = "RELAXED")]
    Relaxed = 2
}