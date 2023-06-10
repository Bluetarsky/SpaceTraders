using System.Runtime.Serialization;

namespace SpaceTraders.Sdk;

public enum MountType
{
    [EnumMember(Value = "MOUNT_GAS_SIPHON_I")]
    GasSiphonI = 1,
    [EnumMember(Value = "MOUNT_GAS_SIPHON_II")]
    GasSiphonII = 2,
    [EnumMember(Value = "MOUNT_GAS_SIPHON_III")]
    GasSiphonIII = 3,
    [EnumMember(Value = "MOUNT_SURVEYOR_I")]
    SurveyorI = 4,
    [EnumMember(Value = "MOUNT_SURVEYOR_II")]
    SurveyorII = 5,
    [EnumMember(Value = "MOUNT_SURVEYOR_III")]
    SurveyorIII = 6,
    [EnumMember(Value = "MOUNT_SENSOR_ARRAY_I")]
    SensorArrayI = 7,
    [EnumMember(Value = "MOUNT_SENSOR_ARRAY_II")]
    SensorArrayII = 8,
    [EnumMember(Value = "MOUNT_SENSOR_ARRAY_III")]
    SensorArrayIII = 9,
    [EnumMember(Value = "MOUNT_MINING_LASER_I")]
    MiningLaserI = 10,
    [EnumMember(Value = "MOUNT_MINING_LASER_II")]
    MiningLaserII = 11,
    [EnumMember(Value = "MOUNT_MINING_LASER_III")]
    MiningLaserIII = 12,
    [EnumMember(Value = "MOUNT_LASER_CANNON_I")]
    LaserCannonI = 13,
    [EnumMember(Value = "MOUNT_MISSILE_LAUNCHER_I")]
    MissileLauncherI = 14,
    [EnumMember(Value = "MOUNT_TURRET_I")]
    TurretI = 15
}