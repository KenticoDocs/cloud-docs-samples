# DocSection: structure_in_rte_register_link_resolver
# Tip: Find more about Ruby SDKs at https://kontent.ai/learn/ruby
require 'delivery-sdk-ruby'

delivery_client = Kontent::Ai::Delivery::DeliveryClient.new project_id: '<YOUR_PROJECT_ID>',
               content_link_url_resolver: link_resolver
# EndDocSection