namespace JiraRestClient.Domain.Avatar;

public class AvatarResponse
{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("owner")]
    public string Owner { get; set; }

    [JsonPropertyName("isSystemAvatar")]
    public bool IsSystemAvatar { get; set; }

    [JsonPropertyName("isSelected")]
    public bool IsSelected { get; set; }

    [JsonPropertyName("isDeletable")]
    public bool IsDeletable { get; set; }

    [JsonPropertyName("fileName")]
    public string FileName { get; set; }

    [JsonPropertyName("urls")]
    public AvatarUrlsResponse Urls { get; set; }
}
