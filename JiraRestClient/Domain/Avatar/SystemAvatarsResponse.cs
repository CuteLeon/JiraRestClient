namespace JiraRestClient.Domain.Avatar;

public class SystemAvatarsResponse
{
    [JsonPropertyName("system")]
    public IEnumerable<AvatarResponse> System { get; set; }
}
