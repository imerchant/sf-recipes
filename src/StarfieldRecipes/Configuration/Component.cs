namespace StarfieldRecipes.Configuration;

public class Component
{
    public string Name { get; init; }
    public Dictionary<string, int> Resources { get; init; }
    public Slot Slot { get; init; }
    public string? Research { get; init; }

    public string ResourcesString => Resources?.Count > 0 ? string.Join(", ", Resources.Select(x => $"{x.Value} {x.Key}")) : "None";
}