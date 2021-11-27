﻿namespace JiraRestClient.Core.Services;

internal class AvatarsService : JiraServiceBase, IAvatarsService
{
    public AvatarsService(
        ILogger<JiraServiceBase> logger,
        JiraRestClientV2 client)
        : base(logger, client)
    {
    }

    public async Task<SystemAvatarsResponse> GetSystemAvatarsByType(AvatarTypes avatarType)
    {
        var avatarTypeName = avatarType.GetAmbientValue().FirstOrDefault() ?? "user";
        var address = string.Format(JiraAPIContract.GetSystemAvatarsByType, avatarTypeName);
        return await this.Client.HttpClient.GetFromJsonAsync<SystemAvatarsResponse>(address);
    }
}
