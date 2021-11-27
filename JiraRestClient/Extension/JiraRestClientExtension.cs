namespace JiraRestClient.Extension;

public static class JiraRestClientExtension
{
    public static IServiceCollection AddJiraRestClient(
        this IServiceCollection services,
        Action<JiraRestClientOptions> options)
    => services
        .Configure(options)
        .AddHttpClient()
        .AddTransient<JiraRestClientV2>();
}
