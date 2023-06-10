using System.Runtime.Serialization;

namespace SpaceTraders.Sdk;

public enum MarketTransaction
{
    [EnumMember(Value = "PURCHASE")]
    Purchase = 1,
    [EnumMember(Value = "SELL")]
    Sell = 2
}