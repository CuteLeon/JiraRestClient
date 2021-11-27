namespace JiraRestClient.Domain.AuditRecord;

public class AuditRecordResponse
{
    [JsonPropertyName("offset")]
    public int Offset { get; set; }

    [JsonPropertyName("limit")]
    public int Limit { get; set; }

    [JsonPropertyName("total")]
    public int Total { get; set; }

    [JsonPropertyName("records")]
    public IEnumerable<AuditRecordBeanResponse> Records { get; set; }
}
