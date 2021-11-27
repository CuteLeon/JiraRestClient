namespace JiraRestClient.Contract;

public static class JiraAPIContract
{
    public const string BaseRestPath = "/jira/rest/api/2/";

    public const string GetAllApplicationRoles = BaseRestPath + "applicationrole";

    public const string GetApplicationRole = BaseRestPath + "applicationrole/{0}";

    public const string GetAuditRecords = BaseRestPath + "auditing/record";

    public const string GetSystemAvatarsByType = BaseRestPath + "avatar/{0}/system";
}
