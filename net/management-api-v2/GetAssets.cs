// DocSection: cm_api_v2_get_assets
// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Management;

var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "<YOUR_API_KEY>",
    ProjectId = "<YOUR_PROJECT_ID>"
});

// Gets the first page of results
var response = await client.ListAssetsAsync();
// EndDocSection