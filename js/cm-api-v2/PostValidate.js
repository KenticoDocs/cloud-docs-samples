// DocSection: cm_api_v2_post_validate
// Tip: Find more about JS/TS SDKs at https://docs.kontent.ai/javascript
// Using ES6 syntax
import { ManagementClient } from '@kentico/kontent-management';

const client = new ManagementClient({
  projectId: '<YOUR_PROJECT_ID>',
  apiKey: '<YOUR_API_KEY>'
});

const response = await client.validateProjectContent()
  .forProjectId('<YOUR_PROJECT_ID>')
  .toPromise();
// EndDocSection