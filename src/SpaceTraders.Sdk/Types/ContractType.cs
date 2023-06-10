using System.Runtime.Serialization;

namespace SpaceTraders.Sdk;

public enum ContractType
{
    [EnumMember(Value = "PROCUREMENT")]
    Procurement = 1,
    [EnumMember(Value = "TRANSPORT")]
    Transport = 2,
    [EnumMember(Value = "SHUTTLE")]
    Shuttle = 3
}