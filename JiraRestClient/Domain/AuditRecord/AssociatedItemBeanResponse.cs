namespace JiraRestClient.Domain.AuditRecord;

public class AssociatedItemBeanResponse
{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("typeName")]
    public string TypeName { get; set; }

    [JsonPropertyName("parentId")]
    public string ParentId { get; set; }

    [JsonPropertyName("parentName")]
    public string ParentName { get; set; }
}
