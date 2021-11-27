namespace JiraRestClient.Domain.AuditRecord;

public class AuditRecordBeanResponse
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("summary")]
    public string Summary { get; set; }

    [JsonPropertyName("remoteAddress")]
    public string RemoteAddress { get; set; }

    [JsonPropertyName("authorKey")]
    public string AuthorKey { get; set; }

    [JsonPropertyName("created")]
    public DateTime Created { get; set; }

    [JsonPropertyName("category")]
    public string Category { get; set; }

    [JsonPropertyName("eventSource")]
    public string EventSource { get; set; }

    [JsonPropertyName("description")]
    public string Description { get; set; }

    [JsonPropertyName("objectItem")]
    public AssociatedItemBeanResponse ObjectItem { get; set; }

    [JsonPropertyName("changedValues")]
    public IEnumerable<ChangedValueBeanResponse> ChangedValues { get; set; }

    [JsonPropertyName("associatedItems")]
    public IEnumerable<AssociatedItemBeanResponse> AssociatedItems { get; set; }
}
