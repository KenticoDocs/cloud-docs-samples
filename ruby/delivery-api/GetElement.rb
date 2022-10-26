# DocSection: delivery_api_get_element
# Tip: Find more about Ruby SDKs at https://kontent.ai/learn/ruby
require 'delivery-sdk-ruby'

delivery_client = Kontent::Ai::Delivery::DeliveryClient.new project_id: '<YOUR_PROJECT_ID>'
delivery_client.element('article', 'title').execute do |response|
  ele = response.element
end
# EndDocSection