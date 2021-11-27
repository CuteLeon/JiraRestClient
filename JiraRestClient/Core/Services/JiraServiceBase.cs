namespace JiraRestClient.Core.Services;

internal abstract class JiraServiceBase : IJiraServiceBase
{
    public ILogger<JiraServiceBase> Logger { get; }
    protected JiraRestClientV2 Client { get; }

    public JiraServiceBase(
        ILogger<JiraServiceBase> logger,
        JiraRestClientV2 client)
    {
        this.Logger = logger;
        this.Client = client;
    }
}
