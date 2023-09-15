namespace StarfieldRecipes.Configuration;

public class RecipesConfiguration
{
    public string? SampleData { get; init; }

    public Dictionary<string, Resource> Resources { get; init; }
    public Dictionary<string, Weapon> Weapons { get; init; }
    public Dictionary<string, Component> Components { get; init; }
}