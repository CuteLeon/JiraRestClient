namespace JiraRestClient.Core.Services;

internal class ApplicationRolesService : JiraServiceBase, IApplicationRolesService
{
    public ApplicationRolesService(
        ILogger<JiraServiceBase> logger,
        JiraRestClientV2 client)
        : base(logger, client)
    {
    }

    public async Task<IEnumerable<ApplicationRoleResponse>> GetAllApplicationRoles()
    {
        var address = JiraAPIContract.GetAllApplicationRoles;
        return await this.Client.HttpClient.GetFromJsonAsync<IEnumerable<ApplicationRoleResponse>>(address);
    }

    public async Task<ApplicationRoleResponse> GetApplicationRole(string key)
    {
        var address = string.Format(JiraAPIContract.GetApplicationRole, key);
        return await this.Client.HttpClient.GetFromJsonAsync<ApplicationRoleResponse>(address);
    }
}
