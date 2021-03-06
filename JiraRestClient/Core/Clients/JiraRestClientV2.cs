namespace JiraRestClient.Core.Clients;

internal class JiraRestClientV2
{
    public HttpClient HttpClient { get; }

    public JiraRestClientV2(
        HttpClient httpClient,
        IOptionsSnapshot<JiraRestClientOptions> options)
    {
        var tokenBytes = Encoding.ASCII.GetBytes($"{options.Value.UserName}:{options.Value.Password}");
        var tokenString = Convert.ToBase64String(tokenBytes);
        httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", tokenString);
        httpClient.BaseAddress = new Uri(options.Value.JiraBaseUri);
        this.HttpClient = httpClient;
    }
}
