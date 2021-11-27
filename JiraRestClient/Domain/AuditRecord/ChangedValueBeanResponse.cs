namespace JiraRestClient.Domain.AuditRecord;

public class ChangedValueBeanResponse
{
    [JsonPropertyName("FieldName")]
    public string FieldName { get; set; }

    [JsonPropertyName("changedFrom")]
    public string ChangedFrom { get; set; }

    [JsonPropertyName("changedTo")]
    public string ChangedTo { get; set; }
}
