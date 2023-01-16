// DocSection: cm_api_v2_post_space
// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Management;

var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "<YOUR_API_KEY>",
    ProjectId = "<YOUR_PROJECT_ID>"
});

var identifier = Reference.ById(Guid.Parse("6291c693-f6e4-4a6b-ac67-5c31c32f9388"));
// var identifier = Reference.ByCodename("space_1");

var response = await client.ModifySpaceAsync(identifier, new SpaceCreateRequestModel
    {
        Name = "Space 1", 
        Codename = "space_1"
    }
);
// EndDocSection