namespace JiraRestClient.Domain.Avatar;

public class AvatarsResponse
{
    [JsonPropertyName("system")]
    public IEnumerable<AvatarResponse> System { get; set; }

    [JsonPropertyName("custom")]
    public IEnumerable<AvatarResponse> Custom { get; set; }
}
