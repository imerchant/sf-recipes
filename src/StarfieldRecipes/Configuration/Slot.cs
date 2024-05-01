using System.ComponentModel;

namespace StarfieldRecipes.Configuration;

public enum Slot
{
    Barrel,
    Laser,
    Optic,
    Muzzle,
    [Description("Grip and Stock")]
    GripAndStock,
    [Description("Magazine and Battery")]
    MagazineAndBattery,
    Internal,
    Receiver
}