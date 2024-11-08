// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
// Note that this approach works when using Node.js. See a worked example using the browser
import { ManagementClient } from '@kontent-ai/management-sdk';
import { readFileSync } from 'fs';

const client = new ManagementClient({
  environmentId: 'KONTENT_AI_ENVIRONMENT_ID',
  apiKey: 'KONTENT_AI_MANAGEMENT_API_KEY'
});

const data = readFileSync('which-brewing-fits-you-1080px.jpg');

const response = await client.uploadBinaryFile()
  .withData({
    binaryData: data,
    contentLength: data.byteLength,
    contentType: 'image/jpeg',
    filename: 'which-brewing-fits-you-1080px.jpg'
  })
  .toPromise();