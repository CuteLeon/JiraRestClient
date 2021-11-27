namespace JiraRestClient.Domain.Avatar;

public enum AvatarTypes
{
    [AmbientValue("issuetype")]
    IssueType,

    [AmbientValue("project")]
    Project,
   
    [AmbientValue("user")]
    User
}
