namespace JiraRestClient.Application;

public interface IAvatarsService
{
    Task<AvatarsResponse> GetAvatars(AvatarTypes avatarType, string entityId);
 
    Task<SystemAvatarsResponse> GetSystemAvatarsByType(AvatarTypes avatarType);
}
