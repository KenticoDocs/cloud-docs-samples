// DocSection: importing_upsert_variant
// Tip: Find more about .NET SDKs at https://docs.kontent.ai/net
using Kentico.Kontent.Management;

var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "<YOUR_API_KEY>",
    ProjectId = "<YOUR_PROJECT_ID>"
});

var response = await client.CreateContentTypeAsync(new ContentTypeCreateModel
{
    Codename = "cafe",
    Name = "Cafe",
    ExternalId = "cafe",
    Elements = new ElementMetadataBase[]
    {
        new NumberElementMetadataModel
        {
            Name = "Price per uni",
            Codename = "price_per_unit",
        },
        new GuidelinesElementMetadataModel
        {
            Guidelines = "<h2>Keep Guidelines where the creative process happens.</h2>\n<p>These are sample guidelines that you can place for the whole content item. It’s a place where you can include your content brief, voice and tone recommendations or the URL to a wireframe, so the author will have all the relevant instructions at hand before writing a single line.</p>\n<p>Besides overview guidelines, you can include instructions for each particular content element, as you will see below.</p>",
            Codename = "n2f836bce_e062_b2cd_5265_f5c3be3aa6f5",
        },
        new TextElementMetadataModel
        {
            Name = "Street",
            ExternalId = "street",
        },
        new TextElementMetadataModel
        {
            Name = "City",
            ExternalId = "city",
        },
        new TextElementMetadataModel
        {
            Name = "Country",
            ExternalId = "country",
        },
        new TextElementMetadataModel
        {
            Name = "State",
            ExternalId = "state",
        },
        new TextElementMetadataModel
        {
            Name = "ZIP code",
            ExternalId = "zip_code",
        },
        new TextElementMetadataModel
        {
            Name = "Email",
            ExternalId = "email",
        },
        new TextElementMetadataModel
        {
            Name = "Phone",
            ExternalId = "phone",
        },
        new AssetElementMetadataModel
        {
            Name = "Photo",
            Codename = "photo"
        }
    }
});
// EndDocSection