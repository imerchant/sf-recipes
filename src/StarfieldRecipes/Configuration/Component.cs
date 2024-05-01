namespace StarfieldRecipes.Configuration;

public class Component
{
    public string Name { get; init; }
    public Dictionary<string, int> Resources { get; init; }
    public Slot Slot { get; init; }
    public string? Research { get; init; }
}