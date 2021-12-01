// DocSection: getting_content_get_items
// Tip: Find more about JS/TS SDKs at https://docs.kontent.ai/javascript
import { createDeliveryClient } from '@kentico/kontent-delivery';

const deliveryClient = createDeliveryClient({
  projectId: '8d20758c-d74c-4f59-ae04-ee928c0816b7'
});

const response = await deliveryClient.items()
    .toPromise();
// EndDocSection