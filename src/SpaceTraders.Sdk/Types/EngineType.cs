using System.Runtime.Serialization;

namespace SpaceTraders.Sdk;

public enum EngineType
{
    [EnumMember(Value = "ENGINE_IMPULSE_DRIVE_I")]
    ImpulseDriveI = 1,
    [EnumMember(Value = "ENGINE_ION_DRIVE_I")]
    IonDriveI = 2,
    [EnumMember(Value = "ENGINE_ION_DRIVE_II")]
    IonDriveII = 3,
    [EnumMember(Value = "ENGINE_HYPER_DRIVE_I")]
    HyperDriveI = 4
}