// DocSection: cm_api_v2_put_preview_configuration
// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Management;

var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "<YOUR_API_KEY>",
    ProjectId = "<YOUR_PROJECT_ID>"
});

var response = await client.UpdatePreviewConfigurationAsync(new PreviewConfigurationRequestModel()
    {
        SpaceDomains = new List<SpaceDomainRequestModel>
        {
            new()
            {
                Domain = "www.mysite.com",
                Space = Reference.ByCodename("my_space")
            }
        },
        PreviewUrlPatterns = new List<TypePreviewUrlPatternRequestModel>
        {
            new()
            {
                ContentType = Reference.ByCodename("article"),
                UrlPatterns = new List<PreviewUrlPatternRequestModel>
                {
                    new()
                    {
                        Space = null,
                        UrlPattern = "https://www.globalsite.com/{URLSlug}"
                    },
                    new()
                    {
                        Space = Reference.ByCodename("my_space"),
                        UrlPattern = "https://{Space}/{URLSlug}/test"
                    },

                }
            }
        }
    }
);
// EndDocSection