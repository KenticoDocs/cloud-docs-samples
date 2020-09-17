// DocSection: managing_navigation_articles_slugs
// Tip: Find more about JS/TS SDKs at https://docs.kontent.ai/javascript
const KontentDelivery = require('@kentico/kontent-delivery');

const deliveryClient = new KontentDelivery.DeliveryClient({
  projectId: '975bf280-fd91-488c-994c-2f04416e5ee3',
  typeResolvers: [
    // Create strongly typed models according to https://docs.kontent.ai/strongly-typed-models
    new KontentDelivery.TypeResolver('article', (rawData) => new Article())
  ]
});

deliveryClient.items()
  .type('article')
  .elementsParameter(['title', 'url_pattern'])
  .toObservable()
  .subscribe(response => console.log(response));
// EndDocSection