// DocSection: managing_navigation_articles_slugs
// Tip: Find more about Java SDK at https://docs.kontent.ai/java
import kentico.kontent.delivery.*;

DeliveryClient client = new DeliveryClient("975bf280-fd91-488c-994c-2f04416e5ee3");

List<NameValuePair> params = DeliveryParameterBuilder.params()
    .filterEquals("system.type", "article")
    .projection("title", "url_pattern").build();

// Create strongly typed models according to https://docs.kontent.ai/strongly-typed-models
CompletionStage<List<ArticleItem>> items = client.getItems(ArticleItem.class, params);
// EndDocSection