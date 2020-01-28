// DocSection: getting_localized_content_language
// Tip: Find more about Java/JavaRx SDKs at https://docs.kontent.ai/java
import com.github.kentico.kontent.delivery;

DeliveryClient client = new DeliveryClient("8d20758c-d74c-4f59-ae04-ee928c0816b");

List<NameValuePair> params = DeliveryParameterBuilder.params().language("es-ES").build();

// Create strongly typed models according to https://docs.kontent.ai/strongly-typed-models
ArticleItem item = client.getItem("about_us", ArticleItem.class, params);
// EndDocSection