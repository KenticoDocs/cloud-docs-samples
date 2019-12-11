// DocSection: preview_content_detect_environment
// Tip: Find more about Java/JavaRx SDKs at https://docs.kontent.ai/javaandroid
import com.github.kentico.kontent_delivery_core.*;
import com.github.kentico.kontent_delivery_rx.*;

import io.reactivex.functions.Function;

// TODO: Determine whether the app is running in a preview environment
boolean isPreview = ...;

// Prepares the DeliveryService configuration object
String projectId = "<YOUR_PROJECT_ID>";
String previewApiKey = "<YOUR_PREVIEW_API_KEY>";
IDeliveryConfig config = DeliveryConfig.newConfig(projectId)
    .withTypeResolvers(typeResolvers)
    .withPreviewApiKey(isPreview ? previewApiKey : null);

// Initializes a DeliveryService for Java projects
IDeliveryService deliveryService = new DeliveryService(config);
// EndDocSection