using System.Runtime.Serialization;

namespace SpaceTraders.Sdk;

public enum ShipModule
{
    [EnumMember(Value = "MODULE_MINERAL_PROCESSOR_I")]
    MineralProcessorI = 1,
    [EnumMember(Value = "MODULE_CARGO_HOLD_I")]
    CargoHoldI = 2,
    [EnumMember(Value = "MODULE_CREW_QUARTERS_I")]
    CrewQuartersI = 3,
    [EnumMember(Value = "MODULE_ENVOY_QUARTERS_I")]
    EnvoyQuartersI = 4,
    [EnumMember(Value = "MODULE_PASSENGER_CABIN_I")]
    PassengerCabinI = 5,
    [EnumMember(Value = "MODULE_MICRO_REFINERY_I")]
    MicroMefineryI = 6,
    [EnumMember(Value = "MODULE_ORE_REFINERY_I")]
    OreRefineryI = 7,
    [EnumMember(Value = "MODULE_FUEL_REFINERY_I")]
    FuelRefineryI = 8,
    [EnumMember(Value = "MODULE_SCIENCE_LAB_I")]
    ScienceLabI = 9,
    [EnumMember(Value = "MODULE_JUMP_DRIVE_I")]
    JumpDriveI = 10,
    [EnumMember(Value = "MODULE_JUMP_DRIVE_II")]
    JumpDriveII = 11,
    [EnumMember(Value = "MODULE_JUMP_DRIVE_III")]
    JumpDriveIII = 12,
    [EnumMember(Value = "MODULE_WARP_DRIVE_I")]
    WarpDriveI = 13,
    [EnumMember(Value = "MODULE_WARP_DRIVE_II")]
    WarpDriveII = 14,
    [EnumMember(Value = "MODULE_WARP_DRIVE_III")]
    WarpDriveIII = 15,
    [EnumMember(Value = "MODULE_SHIELD_GENERATOR_I")]
    ShieldGeneratorI = 16,
    [EnumMember(Value = "MODULE_SHIELD_GENERATOR_II")]
    ShieldGeneratorII = 17
}