# DocSection: filtering_get_product_within_rating
# Gets items whose rating is at least 6.5 and at most 9
delivery_client.items('elements.product_rating'.range('7', '9'))
# EndDocSection