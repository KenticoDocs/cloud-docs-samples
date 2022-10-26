<?php
// DocSection: getting_localized_content_url_slug
// Tip: Find more about PHP SDKs at https://kontent.ai/learn/php
// Defined by Composer to include required libraries
require __DIR__ . '/vendor/autoload.php';

use Kontent\Ai\Delivery\DeliveryClient;

$client = new DeliveryClient('8d20758c-d74c-4f59-ae04-ee928c0816b7');

$items = $client->getItems((new QueryParams())
            ->language('es-ES')
            ->equals('system.type', 'article')
            ->equals('elements.url_pattern', 'acerda-de-nosotros'));
// EndDocSection
?>