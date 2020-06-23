// DocSection: filtering_get_items_by_taxonomy_term
List<object> items = deliveryService.<object>items()
  // Get articles tagged with specific tag
  .filterContains("elements.tags", Arrays.asList("kentico"))

List<object> items = deliveryService.<object>items()
  ///Get articles tagged with any of the below tags
  .filterAny("elements.tags", Arrays.asList("sport", "soccer"))

List<object> items = deliveryService.<object>items()
  //Get articles tagged with all of the below tags
  .filterAll("elements.tags", Arrays.asList("mvc", "kontent", "headless"))
// EndDocSection