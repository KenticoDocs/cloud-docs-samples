// DocSection: filtering_get_items_by_url_slug
// Gets items whose URL slug equals to sample-url-slug
CompletionStage<ContentItemsListingResponse> items = client.getItems(
  DeliveryParameterBuilder.params()
    .filterEquals("elements.url_slug", "sample-url-slug")
    .build()
);
// EndDocSection