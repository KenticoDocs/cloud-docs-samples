// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
import { createDeliveryClient } from '@kontent-ai/delivery-sdk';

const deliveryClient = createDeliveryClient({
  environmentId: 'KONTENT_AI_ENVIRONMENT_ID'
});

const response = await deliveryClient.initializeSync().toPromise();

// Store the X-Continuation token in a persistent storage for later use
const continuationToken = response.xContinuationToken;