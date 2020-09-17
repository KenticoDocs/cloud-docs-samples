// DocSection: rapi_v2_recommend_by_search_phrase
// Tip: Find more about .NET SDKs at https://docs.kontent.ai/net
using Kentico.Kontent.Recommendations;
using Kentico.Kontent.Recommendations.Models;

// Creates an instance of the recommendation client
var recommendationClient = new RecommendationClient(accessToken: "<YOUR_RECOMMENDATION_API_KEY>", timeoutSeconds: 5);

// Creates a new search request
var searchRequest = new SearchRequest
{
    VisitId = "visitorId123",
    Query = "collaboration",
    ResultCount = 3,
    RequestedTypeCodename = "blog_post",
};

// Returns a requested number of recommended content items (their codenames)
RecommendedContentItem[] foundArticles = await recommendationClient.SearchAsync(searchRequest);
// EndDocSection
