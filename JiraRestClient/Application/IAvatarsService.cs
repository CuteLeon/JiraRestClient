namespace JiraRestClient.Application;

public interface IAvatarsService
{
    Task<SystemAvatarsResponse> GetSystemAvatarsByType(AvatarTypes avatarType);
}
