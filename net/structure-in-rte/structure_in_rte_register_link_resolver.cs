// You can also register the resolver in IServiceCollection or another framework for dependency injection: https://kontent.ai/learn/net-register-resolver
using Kontent.Ai.Delivery;

IDeliveryClient client = DeliveryClientBuilder
    .WithEnvironmentId("KONTENT_AI_ENVIRONMENT_ID")
    // Registers the resolver
    .WithContentLinkUrlResolver(new CustomContentLinkUrlResolver())
    .Build();
