// DocSection: importing_upsert_variant
// Using CM API v1
using KenticoCloud.ContentManagement;

ContentManagementOptions options = new ContentManagementOptions
{
    ApiKey = "<YOUR_API_KEY>",
    ProjectId = "14372844-0a5d-434a-8423-605b8a631623"
};

ContentManagementClient client = new ContentManagementClient(options);

// Elements to update
CafeContentTypeModel stronglyTypedElements = new CafeContentTypeModel
{
    Street = "Nove Sady 25",
    City = "Brno",
    Country = "Czech Republic",
    State = "Jihomoravsky kraj",
    ZipCode = "60200",
    Phone = "+420 555 555 555",
    Email = "brnocafe@kontent.ai"
};

ContentItemIdentifier itemIdentifier = ContentItemIdentifier.ByExternalId("ext-cafe-brno");

LanguageIdentifier languageIdentifier = LanguageIdentifier.ByCodename("en-US");

ContentItemVariantIdentifier identifier = new ContentItemVariantIdentifier(itemIdentifier, languageIdentifier);

ContentItemVariantModel<CafeContentTypeModel> responseVariant = await client.UpsertContentItemVariantAsync<CafeContentTypeModel>(identifier, stronglyTypedElements);
// EndDocSection