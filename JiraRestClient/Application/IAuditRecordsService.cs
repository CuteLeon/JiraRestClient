namespace JiraRestClient.Application;

public interface IAuditRecordsService : IJiraServiceBase
{
    Task<AuditRecordResponse> GetAuditRecords();
}
