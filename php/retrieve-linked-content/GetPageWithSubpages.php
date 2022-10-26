<?php
// DocSection: linked_content_get_page_with_subpages
// Tip: Find more about PHP SDKs at https://kontent.ai/learn/php
// Defined by Composer to include required libraries
require __DIR__ . '/vendor/autoload.php';

use Kontent\Ai\Delivery\DeliveryClient;

$client = new DeliveryClient('8d20758c-d74c-4f59-ae04-ee928c0816b7');

$item = $client->getItem('insurance_listing', (new QueryParams())
            ->depth(1));
// EndDocSection
?>