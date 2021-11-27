namespace JiraRestClient.Core.Services;

internal abstract class JiraServiceBase
{
    public ILogger<JiraServiceBase> Logger { get; }
    protected Clients.JiraRestClient Client { get; }

    public JiraServiceBase(
        ILogger<JiraServiceBase> logger,
        Clients.JiraRestClient client)
    {
        this.Logger = logger;
        this.Client = client;
    }
}
