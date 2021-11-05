// DocSection: getting_content_order_items
// Tip: Find more about JS/TS SDKs at https://docs.kontent.ai/javascript
const KontentDelivery = require('@kentico/kontent-delivery');

const deliveryClient = KontentDelivery.createDeliveryClient({
  projectId: '8d20758c-d74c-4f59-ae04-ee928c0816b7'
});

const response = await deliveryClient.items()
  .type('article')
  .limitParameter(3)
  .orderParameter('system.last_modified', KontentDelivery.SortOrder.desc)
  .toPromise();
// EndDocSection