// DocSection: delivery_api_get_taxonomy_groups
// Tip: Find more about Java SDK at https://docs.kontent.ai/java
import kentico.kontent.delivery.*;

DeliveryClient client = new DeliveryClient("<YOUR_PROJECT_ID>");

List<NameValuePair> params = DeliveryParameterBuilder.params().page(null, 3).build();

CompletionStage<TaxonomyGroupListingResponse> response = client.getTaxonomyGroups(params);
// EndDocSection