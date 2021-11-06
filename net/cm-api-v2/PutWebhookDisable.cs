// DocSection: mapi_v2_disable_webhook
// Tip: Find more about .NET SDKs at https://docs.kontent.ai/net
using Kentico.Kontent.Management;

var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "<YOUR_API_KEY>",
    ProjectId = "<YOUR_PROJECT_ID>"
});

await client.DisableWebhookAsync(Reference.ById(Guid.Parse("5df74e27-1213-484e-b9ae-bcbe90bd5990")));
// EndDocSection