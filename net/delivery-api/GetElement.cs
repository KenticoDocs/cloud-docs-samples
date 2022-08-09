// DocSection: delivery_api_get_element
// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Delivery;

// Creates an instance of the delivery client
// ProTip: Use DI for this in your apps https://kontent.ai/learn/net-register-client
IDeliveryClient client = DeliveryClientBuilder
      .WithProjectId("<YOUR_PROJECT_ID>")
      .Build();

// Gets the model of specific element within a specific content type
DeliveryElementResponse response = await client.GetContentElementAsync("article", "title");
IContentElement element = response.Element;
// EndDocSection