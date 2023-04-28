// DocSection: import_rich_create_item
// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
// Using ES6 syntax
import { ManagementClient } from '@kontent-ai/management-sdk';

const client = new ManagementClient({
  environmentId: '<YOUR_ENVIRONMENT_ID>',
  apiKey: '<YOUR_API_KEY>'
});

const response = await client.upsertContentItem()
  .byItemExternalId('simple-example')
  .withData(
    {
      name: 'Simple example',
      type: {
        external_id: 'simple-rich-text'
      }
    }
  )
  .toPromise();
// EndDocSection