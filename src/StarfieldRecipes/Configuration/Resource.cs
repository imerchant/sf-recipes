namespace StarfieldRecipes.Configuration;

public class Resource
{
    public string Name { get; init; }
    public string RefId { get; init; }
    public string? Symbol { get; init; }
    public Rarity Rarity { get; init; }
    public Dictionary<string, int>? ComposedOf { get; init; }
    public bool IsManufactured => ComposedOf?.Count > 0;
}