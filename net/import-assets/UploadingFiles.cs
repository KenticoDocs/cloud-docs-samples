// DocSection: importing_assets_upload_file
// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kentico.Kontent.Management;

var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "<YOUR_API_KEY>",
    ProjectId = "<YOUR_PROJECT_ID>"
});

var filePath = Path.Combine(Environment.CurrentDirectory, "Data", "brno-cafe-1080px.jpg");
var contentType = "image/jpeg";

// Binary file reference to be used when adding a new asset
var response = await client.UploadFileAsync(new FileContentSource(filePath, contentType));
// EndDocSection