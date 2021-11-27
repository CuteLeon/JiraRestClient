namespace JiraRestClient.Domain.ApplicationRole;

public class ApplicationRoleResponse
{
    [JsonPropertyName("key")]
    public string Key { get; set; }

    [JsonPropertyName("groups")]
    public string[] Groups { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("defaultGroups")]
    public string[] DefaultGroups { get; set; }

    [JsonPropertyName("selectedByDefault")]
    public bool SelectedByDefault { get; set; }

    [JsonPropertyName("userCountDescription")]
    public string UserCountDescription { get; set; }

    [JsonPropertyName("hasUnlimitedSeats")]
    public bool HasUnlimitedSeats { get; set; }

    [JsonPropertyName("defined")]
    public bool Defined { get; set; }

    [JsonPropertyName("numberOfSeats")]
    public int NumberOfSeats { get; set; }

    [JsonPropertyName("remainingSeats")]
    public int RemainingSeats { get; set; }

    [JsonPropertyName("userCount")]
    public int UserCount { get; set; }

    [JsonPropertyName("platform")]
    public bool Platform { get; set; }
}
