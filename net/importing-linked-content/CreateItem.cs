// DocSection: import_linked_create_item
// Tip: Find more about .NET SDKs at https://docs.kontent.ai/net
using Kentico.Kontent.Management;

var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "<YOUR_API_KEY>",
    ProjectId = "<YOUR_PROJECT_ID>"
});

await client.UpsertContentItemByExternalIdAsync("123", new ContentItemUpsertModel
{
    Name = "On Roasts",
    Type = Reference.ByCodename("article"),
});
// EndDocSection