namespace JiraRestClient.Util;

internal static class AttributeValueExtension
{
    public static IEnumerable<object?> GetAmbientValue<TEnum>(this TEnum enumValue)
    {
        return typeof(TEnum)
            .GetMember(enumValue.ToString())
            .SelectMany(member => member.GetCustomAttributes(typeof(AmbientValueAttribute), false)
            .Cast<AmbientValueAttribute>()
            .Select(ambientValue => ambientValue.Value));
    }
}
