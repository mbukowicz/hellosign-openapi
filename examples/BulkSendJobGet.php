<?php

require_once __DIR__ . "/vendor/autoload.php";

$config = HelloSignSDK\Configuration::getDefaultConfiguration();

// Configure HTTP basic authorization: api_key
$config->setUsername("YOUR_API_KEY");

// or, configure Bearer (JWT) authorization: oauth2
// $config->setAccessToken("YOUR_ACCESS_TOKEN");

$api = new HelloSignSDK\Api\BulkSendJobApi(
    new GuzzleHttp\Client(),
    $config
);

$bulkSendJobId = "6e683bc0369ba3d5b6f43c2c22a8031dbf6bd174";

try {
    $result = $api->bulkSendJobGet($bulkSendJobId);
    print_r($result);
} catch (Exception $e) {
    echo "Exception when calling HelloSign API: "
        . $e->getMessage() . PHP_EOL;
}
