using System.Runtime.Serialization;

namespace SpaceTraders.Sdk;

public enum ShipFrame
{
    [EnumMember(Value = "FRAME_PROBE")]
    Probe = 1,
    [EnumMember(Value = "FRAME_DRONE")]
    Drone = 2,
    [EnumMember(Value = "FRAME_INTERCEPTOR")]
    Interceptor = 3,
    [EnumMember(Value = "FRAME_RACER")]
    Racer = 4,
    [EnumMember(Value = "FRAME_FIGHTER")]
    Fighter = 5,
    [EnumMember(Value = "FRAME_FRIGATE")]
    Frigate = 6,
    [EnumMember(Value = "FRAME_SHUTTLE")]
    Shuttle = 7,
    [EnumMember(Value = "FRAME_EXPLORER")]
    Explorer = 8,
    [EnumMember(Value = "FRAME_MINER")]
    Miner = 9,
    [EnumMember(Value = "FRAME_LIGHT_FREIGHTER")]
    LightFreighter = 10,
    [EnumMember(Value = "FRAME_HEAVY_FREIGHTER")]
    HeavyFreighter = 11,
    [EnumMember(Value = "FRAME_TRANSPORT")]
    Transport = 12,
    [EnumMember(Value = "FRAME_DESTROYER")]
    Destroyer = 13,
    [EnumMember(Value = "FRAME_CRUISER")]
    Cruiser = 14,
    [EnumMember(Value = "FRAME_CARRIER")]
    Carrier = 15
}