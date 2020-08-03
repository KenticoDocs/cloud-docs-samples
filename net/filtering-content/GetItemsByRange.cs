// DocSection: filtering_get_items_by_range
// Note: system.last_modified value is stored with ms precision
// Date&Time element value is stored with minute precision
DeliveryItemListingResponse<object> response = await deliveryClient.GetItemsAsync<object>(
  // Gets items modified between April 5, 2020 10:30 UTC and April 7, 2020, 7:00 UTC
  new RangeFilter("system.last_modified", "2020-05-05T10:30:00", "2020-05-07T07:00:00")
);
// EndDocSection 