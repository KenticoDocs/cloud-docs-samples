// DocSection: cm_api_v2_post_asset_folders
// Tip: Find more about .NET SDKs at https://docs.kontent.ai/net
using Kentico.Kontent.Management;

var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "<YOUR_API_KEY>",
    ProjectId = "<YOUR_PROJECT_ID>"
});

var response = await client.CreateAssetFoldersAsync(new AssetFolderCreateModel
{
    Folders = new[]
    {
        new AssetFolderHierarchy
        {
            Name = "Top level folder",
            ExternalId = "top-folder",
            Folders = new []
            {
                new AssetFolderHierarchy
                {
                    Name = "Second level folder",
                    ExternalId = "second-folder",
                    Folders = Enumerable.Empty<AssetFolderHierarchy>(),
                }
            }
        }
    }
});
// EndDocSection