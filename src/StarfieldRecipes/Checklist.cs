using StarfieldRecipes.Configuration;
namespace StarfieldRecipes;

public class Checklist
{
    private readonly RecipesConfiguration _configuration;
    public DefaultDictionary<Resource, int> NeededResources { get; } = new(_ => 0);

    public event Action? ChecklistChanged;

    public Checklist(RecipesConfiguration configuration)
    {
        _configuration = configuration;
    }

    public void UpdateResources(ChecklistAction action, Dictionary<string, int> resources)
    {
        var mod = action == ChecklistAction.Add ? 1 : -1;

        foreach (var (resourceName, count) in resources)
        {
            NeededResources[_configuration.Resources[resourceName]] += mod * count;
        }

        ChecklistChanged?.Invoke();
    }
}

public enum ChecklistAction
{
    Add, Remove
}