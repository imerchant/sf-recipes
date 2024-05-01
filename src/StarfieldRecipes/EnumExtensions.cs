using System.ComponentModel;
using System.Reflection;

namespace StarfieldRecipes;

public static class EnumExtensions
{
    public static string ToDescription<T>(this T value) where T : Enum
    {
        var enumType = typeof(T);
        if (!Enum.IsDefined(enumType, value))
            throw new ArgumentException("Given value is not a valid enum value", nameof(value));

        var description = value.ToString();
        var members = enumType.GetMember(description);
        if (members.Length > 0)
        {
            var attr = members[0].GetCustomAttribute<DescriptionAttribute>();
            if (attr is not null)
            {
                description = attr.Description;
            }
        }
        return description;
    }
}