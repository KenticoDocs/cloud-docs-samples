# DocSection: delivery_api_get_item
# Tip: Find more about Ruby SDKs at https://kontent.ai/learn/ruby
require 'delivery-sdk-ruby'

delivery_client = Kontent::Ai::Delivery::DeliveryClient.new project_id: '<YOUR_PROJECT_ID>'
delivery_client.item('my_article')
               .execute do |response|
                 item = response.item
               end
# EndDocSection