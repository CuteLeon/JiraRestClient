namespace JiraRestClient.Domain.Avatar;

public class AvatarUrlsResponse
{
    [JsonPropertyName("16x16")]
    public Uri Url_16 { get; set; }

    [JsonPropertyName("24x24")]
    public Uri Url_24 { get; set; }

    [JsonPropertyName("32x32")]
    public Uri Url_32 { get; set; }

    [JsonPropertyName("48x48")]
    public Uri Url_48 { get; set; }
}
