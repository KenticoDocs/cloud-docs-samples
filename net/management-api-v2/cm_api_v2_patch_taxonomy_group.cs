// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Management;

var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "KONTENT_AI_MANAGEMENT_API_KEY",
    EnvironmentId = "KONTENT_AI_ENVIRONMENT_ID"
});

var identifier = Reference.ById(Guid.Parse("0be13600-e57c-577d-8108-c8d860330985"));
// var identifier = Reference.ByCodename("personas");
// var identifier = Reference.ByExternalId("Tax-Group-123");

var response = await client.ModifyTaxonomyGroupAsync(identifier, new TaxonomyGroupOperationBaseModel[]
{
    new TaxonomyGroupReplacePatchModel
    {
        PropertyName = PropertyName.Name,
        Value = "Categories"
    },
    new TaxonomyGroupReplacePatchModel
    {
        PropertyName = PropertyName.Codename,
        Value = "category"
    },
    new TaxonomyGroupReplacePatchModel
    {
        Reference = Reference.ByCodename("first_term"),
        PropertyName = PropertyName.Terms,
        Value = new TaxonomyGroupCreateModel[]
        {
            new TaxonomyGroupCreateModel
            {
                Name = "Second-level taxonomy term",
                Codename = "second_term",
                Terms = new TaxonomyTermCreateModel[]
                {
                    new TaxonomyTermCreateModel
                    {
                        Name = "Third-level taxonomy term",
                    }
                }
            }
        }
    },
    new TaxonomyGroupRemovePatchModel
    {
        Reference = Reference.ByExternalId("unused-taxonomy-term")
    },
    new TaxonomyGroupAddIntoPatchModel
    {
        Reference = Reference.ByCodename("second_term"),
        Value = new TaxonomyTermCreateModel
        {
            Name = "New taxonomy term",
            ExternalId = "my-new-term",
            Terms = Array.Empty<TaxonomyTermCreateModel>()
        }
    },
    new TaxonomyGroupMovePatchModel
    {
        Reference = Reference.ByExternalId("my-new-term"),
        Before = Reference.ByCodename("first_term")
    }
});
