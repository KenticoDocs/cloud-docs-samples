// DocSection: filtering_get_item_by_id
delivery_client.items([
  # Gets items whose linked item has codename as one of specified values
  'elements.author'.any('john_snow', 'johnny_bravo')
])

delivery_client.items([
  # Gets items whose linked item has codename of certain value
  'elements.author'.contains('joe_down')
])
// EndDocSection
