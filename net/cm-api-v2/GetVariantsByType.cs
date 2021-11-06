// DocSection: cm_api_v2_get_variants_of_type
// Tip: Find more about .NET SDKs at https://docs.kontent.ai/net
using Kentico.Kontent.Management;

var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "<YOUR_API_KEY>",
    ProjectId = "<YOUR_PROJECT_ID>"
});

var identifier = Reference.ById(Guid.Parse("b7aa4a53-d9b1-48cf-b7a6-ed0b182c4b89"));
// var identifier = Reference.ByCodename("article");
// var identifier = Reference.ByExternalId("my-article-id");

var response = await client.ListLanguageVariantsByTypeAsync(identifier);
// EndDocSection