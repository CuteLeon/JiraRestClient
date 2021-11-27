namespace JiraRestClient.Contract;

public static class JiraAPIContract
{
    public const string BaseRestPath = "/jira/rest/api/2/";

    public const string GetAllApplicationRoles = BaseRestPath + "applicationrole";

    public const string GetApplicationRole = BaseRestPath + "applicationrole/{0}";
}
