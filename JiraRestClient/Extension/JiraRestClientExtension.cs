namespace JiraRestClient.Extension;

public static class JiraRestClientExtension
{
    public static IServiceCollection AddJiraRestClient(
        this IServiceCollection services,
        Action<JiraRestClientOptions> options)
    => services
        .Configure(options)
        .AddHttpClient()
        .AddTransient<IApplicationRolesService, ApplicationRolesService>()
        .AddTransient<IAuditRecordsService, AuditRecordsService>()
        .AddTransient<JiraRestClientV2>();
}
