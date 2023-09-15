namespace StarfieldRecipes.Configuration;

public class Weapon
{
    public string Name { get; init; }
    public WeaponType Type { get; init; }
    public List<string> Components { get; init; }
}