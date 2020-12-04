// DocSection: linked_content_get_page_with_subpages
// Tip: Find more about Java SDK at https://docs.kontent.ai/java
import kentico.kontent.delivery.*;

// Initializes a DeliveryClient
DeliveryClient client = new DeliveryClient("<YOUR_PROJECT_ID>");

// Create strongly typed models according to https://docs.kontent.ai/strongly-typed-models
// Registers the model class for articles
client.registerType(Page.class);

CompletionStage<Page> item = client.getItem(
	"insurance_listing",
	Page.class,
	DeliveryParameterBuilder.params()
		.linkedItemsDepth(1)
		.build()
);
// To use the code for Android projects, see http://docs.kontent.ai/javarx
// EndDocSection