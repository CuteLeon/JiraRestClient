namespace JiraRestClient.Application;

public interface IApplicationRolesService : IJiraServiceBase
{
    Task<IEnumerable<ApplicationRoleResponse>> GetAllApplicationRoles();

    Task<ApplicationRoleResponse> GetApplicationRole(string key);
}
