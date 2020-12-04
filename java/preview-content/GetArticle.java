// DocSection: preview_content_get_article
// Tip: Find more about Java SDK at https://docs.kontent.ai/java
import kentico.kontent.delivery.*;

// Initializes a DeliveryClient for preview
DeliveryClient client = new DeliveryClient(
    DeliveryOptions.builder()
        .projectId("<YOUR_PROJECT_ID>")
        .previewApiKey("<YOUR_PREVIEW_API_KEY>")
        .usePreviewApi(true)
        .build();
);

// Create strongly typed models according to https://docs.kontent.ai/strongly-typed-models
// Registers the model class for articles
client.registerType(Article.class);

// Gets the latest version of an item
CompletionStage<Article> article = client.getItem(
    "my_article",
    Article.class
);
// EndDocSection