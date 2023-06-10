using System.Runtime.Serialization;

namespace SpaceTraders.Sdk;

public enum DepositType
{
    [EnumMember(Value = "QUARTZ_SAND")]
    QuartzSand = 1,
    [EnumMember(Value = "SILICON_CRYSTALS")]
    SiliconCrystals = 2,
    [EnumMember(Value = "PRECIOUS_STONES")]
    PreciousStones = 3,
    [EnumMember(Value = "ICE_WATER")]
    IceWater = 4,
    [EnumMember(Value = "AMMONIA_ICE")]
    AmmoniaIce = 5,
    [EnumMember(Value = "IRON_ORE")]
    IronOre = 6,
    [EnumMember(Value = "COPPER_ORE")]
    CopperOre = 7,
    [EnumMember(Value = "SILVER_ORE")]
    SilverOre = 8,
    [EnumMember(Value = "ALUMINUM_ORE")]
    AluminumOre = 9,
    [EnumMember(Value = "GOLD_ORE")]
    GoldOre = 10,
    [EnumMember(Value = "PLATINUM_ORE")]
    PlatinumOre = 11,
    [EnumMember(Value = "DIAMONDS")]
    Diamonds = 12,
    [EnumMember(Value = "URANITE_ORE")]
    UraniteOre = 13,
    [EnumMember(Value = "MERITIUM_ORE")]
    MeritiumOre = 14
}