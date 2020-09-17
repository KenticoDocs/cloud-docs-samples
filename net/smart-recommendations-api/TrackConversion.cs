// DocSection: rapi_v2_track_conversion
// Tip: Find more about .NET SDKs at https://docs.kontent.ai/net
using Kentico.Kontent.Recommendations;

// Creates an instance of the recommendation client
var recommendationClient = new RecommendationClient(accessToken: "<YOUR_RECOMMENDATION_API_KEY>", timeoutSeconds: 5);

// Tracks a conversion for a specific visitor and content item
await recommendationClient.TrackConversionAsync("visitoriId123","example_blog_post");
// EndDocSection