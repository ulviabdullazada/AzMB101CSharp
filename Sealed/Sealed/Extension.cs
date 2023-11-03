namespace Sealed;

internal static class Extension1
{
}
internal static class Extension
{
    public static string ToCapitalize(this string value)
    {
        value = value.Trim().ToLower();
        return Char.ToUpper(value[0]) + value.Substring(1);
    }
    public static string Cut(this string value, int step)
    {
        if (value.Length < step) return value;
        return value.Substring(0, step);
    }
}
