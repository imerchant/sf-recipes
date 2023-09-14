using MudBlazor;

namespace StarfieldRecipes.Configuration;

public class RecipesConfiguration
{
    public string? SampleData { get; init; }

    public Dictionary<string, Resource> Resources { get; init; }
    public Dictionary<string, Weapon> Weapons { get; init; }
    public Dictionary<string, Component> Components { get; init; }
}

public class Resource
{
    public string Name { get; init; }
    public string RefId { get; init; }
    public string? Symbol { get; init; }
    public Rarity Rarity { get; init; }
}

public class Weapon
{
    public string Name { get; init; }
    public WeaponType Type { get; init; }
    public List<string> Components { get; init; }
}

public class Component
{
    public string Name { get; init; }
    public Dictionary<string, int> Resources { get; init; }
    public Slot Slot { get; init; }
    public string? Research { get; init; }

    public string ResourcesString => Resources?.Count > 0 ? string.Join(", ", Resources.Select(x => $"{x.Value} {x.Key}")) : "None";
}

public enum Slot
{
    Barrel,
    Laser,
    Optic,
    Muzzle,
    GripAndStock,
    MagazineAndBattery,
    Internal,
    Receiver
}

public enum WeaponType
{
    Rifle
}

public enum Rarity
{
    Common,
    Uncommon,
    Rare,
    Exotic,
    Unique
}

public static class RarityExtensions
{
    public static Color ToColor(this Rarity rarity) =>
        rarity switch
        {
            Rarity.Common => Color.Default,
            Rarity.Uncommon => Color.Info,
            Rarity.Rare => Color.Primary,
            Rarity.Exotic => Color.Warning,
            Rarity.Unique => Color.Success,
            _ => throw new ArgumentOutOfRangeException(nameof(rarity), rarity, "Rarity doesn't exist")
        };
}