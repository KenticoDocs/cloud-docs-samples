# Tip: Find more about Ruby SDKs at https://kontent.ai/learn/ruby
require 'delivery-sdk-ruby'

delivery_client = Kontent::Ai::Delivery::DeliveryClient.new project_id: '8d20758c-d74c-4f59-ae04-ee928c0816b7'

# Gets a specific article in Spanish
delivery_client.item('about_us')
               .language('es-ES')
               .execute do |response|
                 item = response.item
               end