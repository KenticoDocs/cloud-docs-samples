// DocSection: cm_api_v2_post_item
// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Management;

var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "<YOUR_API_KEY>",
    ProjectId = "<YOUR_PROJECT_ID>"
});

var response = await client.CreateContentItemAsync(new ContentItemCreateModel
{
    Name = "On Roasts",
    Codename = "my_article",
    Type = Reference.ByCodename("article"),
    Collection = Reference.ByCodename("default"),
    ExternalId = "59713",
});
// EndDocSection
