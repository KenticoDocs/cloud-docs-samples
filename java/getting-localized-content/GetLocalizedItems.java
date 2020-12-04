// DocSection: getting_localized_content_language
// Tip: Find more about Java SDK at https://docs.kontent.ai/java
import kentico.kontent.delivery.*;

// Initializes a DeliveryClient
DeliveryClient client = new DeliveryClient("<YOUR_PROJECT_ID>");

// Create strongly typed models according to https://docs.kontent.ai/strongly-typed-models
// Registers the model class for articles
client.registerType(Article.class);

// Gets the Spanish variant of an article
CompletionStage<Article> item = client.getItem(
	"about_us",
	Article.class,
	DeliveryParameterBuilder.params()
		.language("es-ES")
		.build()
	
);
// To use the code for Android projects, see http://docs.kontent.ai/javarx
// EndDocSection