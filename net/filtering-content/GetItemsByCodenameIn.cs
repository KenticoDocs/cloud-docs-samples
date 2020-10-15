// DocSection: filtering_get_items_by_codename_in
// Gets three items by their codenames. The codenames are unique per project.
IDeliveryItemListingResponse<object> response = await deliveryClient.GetItemsAsync<object>(
    new InFilter("system.codename", "delivery_api", "get_content", "hello_world")
);
// EndDocSection