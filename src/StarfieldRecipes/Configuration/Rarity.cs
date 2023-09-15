using MudBlazor;

namespace StarfieldRecipes.Configuration;

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