// DocSection: filtering_get_item_by_id
$items = $client->getItems((new QueryParams())
  // Gets item by its ID
  ->equals('system.id', '2f7288a1-cfc8-47be-9bf1-b1d312f7da18')
// EndDocSection
