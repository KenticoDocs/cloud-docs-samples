// DocSection: delivery_api_get_items_feed
// Tip: Find more about .NET SDKs at https://docs.kontent.ai/net
using Kentico.Kontent.Delivery;

// Creates an instance of the delivery client
// ProTip: Use DI for this in your apps https://docs.kontent.ai/net-register-client
IDeliveryClient client = DeliveryClientBuilder
      .WithProjectId("<YOUR_PROJECT_ID>")
      .Build();

// Gets feed for specific elements of articles ordered by the "Post date" element
// Create strongly typed models according to https://docs.kontent.ai/net-strong-types
DeliveryItemsFeed<Article> feed = client.GetItemsFeed<Article>(
    new EqualsFilter("system.type", "article"),
    );

while (feed.HasMoreResults)
{
    DeliveryItemsFeedResponse<Article> response = await feed.FetchNextBatchAsync();
    foreach(Article article in response) {
        // Do something with the content item, e.g. update cache
        ProcessContentItem(article);
    }
}
// EndDocSection
