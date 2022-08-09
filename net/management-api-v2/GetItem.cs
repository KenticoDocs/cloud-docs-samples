// DocSection: cm_api_v2_get_item
// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Management;

var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "<YOUR_API_KEY>",
    ProjectId = "<YOUR_PROJECT_ID>"
});

var identifier = Reference.ById(Guid.Parse("f4b3fc05-e988-4dae-9ac1-a94aba566474"));
// var identifier = Reference.ByCodename("my_article");
// var identifier = Reference.ByExternalId("59713");

var response = await client.GetContentItemAsync(identifier);
// EndDocSection