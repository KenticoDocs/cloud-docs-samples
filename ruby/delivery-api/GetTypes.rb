# DocSection: delivery_api_get_types
# Tip: Find more about Ruby SDKs at https://kontent.ai/learn/ruby
require 'delivery-sdk-ruby'

delivery_client = Kontent::Ai::Delivery::DeliveryClient.new project_id: '<YOUR_PROJECT_ID>'
delivery_client.types
               .limit(3)
               .execute do |response|
                 types = response.types
               end
# EndDocSection