using System.ComponentModel;

namespace StarfieldRecipes.Configuration;

public enum WeaponType
{
    Rifle,
    Pistol,
    Shotgun,
    [Description("Laser Rifle")]
    LaserRifle,
    [Description("Laser Pistol")]
    LaserPistol,
    [Description("Electromagnetic Rifle")]
    ElectromagneticRifle,
    [Description("Particle Beam Pistol")]
    ParticleBeamPistol,
    Heavy
}