namespace JiraRestClient.Core.Services;

internal class AuditRecordsService : JiraServiceBase, IAuditRecordsService
{
    public AuditRecordsService(
        ILogger<JiraServiceBase> logger,
        JiraRestClientV2 client)
        : base(logger, client)
    {
    }

    public async Task<AuditRecordResponse> GetAuditRecords()
    {
        var address = JiraAPIContract.GetAuditRecords;
        return await this.Client.HttpClient.GetFromJsonAsync<AuditRecordResponse>(address);
    }
}
