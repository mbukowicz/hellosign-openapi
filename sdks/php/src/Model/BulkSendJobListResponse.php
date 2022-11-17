<?php
/**
 * BulkSendJobListResponse
 *
 * PHP version 7.3
 *
 * @category Class
 * @author   OpenAPI Generator team
 * @see     https://openapi-generator.tech
 */

/**
 * Dropbox Sign API
 *
 * Dropbox Sign v3 API
 *
 * The version of the OpenAPI document: 3.0.0
 * Contact: apisupport@hellosign.com
 * Generated by: https://openapi-generator.tech
 * OpenAPI Generator version: 5.3.0
 */

/**
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */

namespace HelloSignSDK\Model;

use ArrayAccess;
use HelloSignSDK\ObjectSerializer;
use JsonSerializable;

/**
 * BulkSendJobListResponse Class Doc Comment
 *
 * @category Class
 * @author   OpenAPI Generator team
 * @see     https://openapi-generator.tech
 * @implements \ArrayAccess<TKey, TValue>
 * @template TKey int|null
 * @template TValue mixed|null
 * @internal This class should not be instantiated directly
 */
class BulkSendJobListResponse implements ModelInterface, ArrayAccess, JsonSerializable
{
    public const DISCRIMINATOR = null;

    /**
     * The original name of the model.
     *
     * @var string
     */
    protected static $openAPIModelName = 'BulkSendJobListResponse';

    /**
     * Array of property to type mappings. Used for (de)serialization
     *
     * @var string[]
     */
    protected static $openAPITypes = [
        'bulk_send_jobs' => '\HelloSignSDK\Model\BulkSendJobResponse[]',
        'list_info' => '\HelloSignSDK\Model\ListInfoResponse',
        'warnings' => '\HelloSignSDK\Model\WarningResponse[]',
    ];

    /**
     * Array of property to format mappings. Used for (de)serialization
     *
     * @var string[]
     * @phpstan-var array<string, string|null>
     * @psalm-var array<string, string|null>
     */
    protected static $openAPIFormats = [
        'bulk_send_jobs' => null,
        'list_info' => null,
        'warnings' => null,
    ];

    /**
     * Array of property to type mappings. Used for (de)serialization
     *
     * @return array
     */
    public static function openAPITypes()
    {
        return self::$openAPITypes;
    }

    /**
     * Array of property to format mappings. Used for (de)serialization
     *
     * @return array
     */
    public static function openAPIFormats()
    {
        return self::$openAPIFormats;
    }

    /**
     * Array of attributes where the key is the local name,
     * and the value is the original name
     *
     * @var string[]
     */
    protected static $attributeMap = [
        'bulk_send_jobs' => 'bulk_send_jobs',
        'list_info' => 'list_info',
        'warnings' => 'warnings',
    ];

    /**
     * Array of attributes to setter functions (for deserialization of responses)
     *
     * @var string[]
     */
    protected static $setters = [
        'bulk_send_jobs' => 'setBulkSendJobs',
        'list_info' => 'setListInfo',
        'warnings' => 'setWarnings',
    ];

    /**
     * Array of attributes to getter functions (for serialization of requests)
     *
     * @var string[]
     */
    protected static $getters = [
        'bulk_send_jobs' => 'getBulkSendJobs',
        'list_info' => 'getListInfo',
        'warnings' => 'getWarnings',
    ];

    /**
     * Array of attributes where the key is the local name,
     * and the value is the original name
     *
     * @return array
     */
    public static function attributeMap()
    {
        return self::$attributeMap;
    }

    /**
     * Array of attributes to setter functions (for deserialization of responses)
     *
     * @return array
     */
    public static function setters()
    {
        return self::$setters;
    }

    /**
     * Array of attributes to getter functions (for serialization of requests)
     *
     * @return array
     */
    public static function getters()
    {
        return self::$getters;
    }

    /**
     * The original name of the model.
     *
     * @return string
     */
    public function getModelName()
    {
        return self::$openAPIModelName;
    }

    /**
     * Associative array for storing property values
     *
     * @var array
     */
    protected $container = [];

    /**
     * Constructor
     *
     * @param array|null $data Associated array of property values
     *                         initializing the model
     */
    public function __construct(array $data = null)
    {
        $this->container['bulk_send_jobs'] = $data['bulk_send_jobs'] ?? null;
        $this->container['list_info'] = $data['list_info'] ?? null;
        $this->container['warnings'] = $data['warnings'] ?? null;
    }

    public static function fromArray(array $data): BulkSendJobListResponse
    {
        /** @var BulkSendJobListResponse $obj */
        $obj = ObjectSerializer::deserialize(
            ObjectSerializer::instantiateFiles(static::class, $data),
            BulkSendJobListResponse::class,
        );

        return $obj;
    }

    /**
     * Show all the invalid properties with reasons.
     *
     * @return array invalid properties with reasons
     */
    public function listInvalidProperties()
    {
        $invalidProperties = [];

        return $invalidProperties;
    }

    /**
     * Validate all the properties in the model
     * return true if all passed
     *
     * @return bool True if all properties are valid
     */
    public function valid()
    {
        return count($this->listInvalidProperties()) === 0;
    }

    /**
     * Gets bulk_send_jobs
     *
     * @return BulkSendJobResponse[]|null
     */
    public function getBulkSendJobs()
    {
        return $this->container['bulk_send_jobs'];
    }

    /**
     * Sets bulk_send_jobs
     *
     * @param BulkSendJobResponse[]|null $bulk_send_jobs contains a list of BulkSendJobs that the API caller has access to
     *
     * @return self
     */
    public function setBulkSendJobs(?array $bulk_send_jobs)
    {
        $this->container['bulk_send_jobs'] = $bulk_send_jobs;

        return $this;
    }

    /**
     * Gets list_info
     *
     * @return ListInfoResponse|null
     */
    public function getListInfo()
    {
        return $this->container['list_info'];
    }

    /**
     * Sets list_info
     *
     * @param ListInfoResponse|null $list_info list_info
     *
     * @return self
     */
    public function setListInfo(?ListInfoResponse $list_info)
    {
        $this->container['list_info'] = $list_info;

        return $this;
    }

    /**
     * Gets warnings
     *
     * @return WarningResponse[]|null
     */
    public function getWarnings()
    {
        return $this->container['warnings'];
    }

    /**
     * Sets warnings
     *
     * @param WarningResponse[]|null $warnings a list of warnings
     *
     * @return self
     */
    public function setWarnings(?array $warnings)
    {
        $this->container['warnings'] = $warnings;

        return $this;
    }

    /**
     * Returns true if offset exists. False otherwise.
     *
     * @param mixed $offset Offset
     *
     * @return bool
     */
    #[\ReturnTypeWillChange]
    public function offsetExists($offset)
    {
        return isset($this->container[$offset]);
    }

    /**
     * Gets offset.
     *
     * @param mixed $offset Offset
     *
     * @return mixed|null
     */
    #[\ReturnTypeWillChange]
    public function offsetGet($offset)
    {
        return $this->container[$offset] ?? null;
    }

    /**
     * Sets value based on offset.
     *
     * @param mixed $offset Offset
     * @param mixed $value Value to be set
     *
     * @return void
     */
    #[\ReturnTypeWillChange]
    public function offsetSet($offset, $value)
    {
        if (is_null($offset)) {
            $this->container[] = $value;
        } else {
            $this->container[$offset] = $value;
        }
    }

    /**
     * Unsets offset.
     *
     * @param mixed $offset Offset
     *
     * @return void
     */
    #[\ReturnTypeWillChange]
    public function offsetUnset($offset)
    {
        unset($this->container[$offset]);
    }

    /**
     * Serializes the object to a value that can be serialized natively by json_encode().
     * @see https://www.php.net/manual/en/jsonserializable.jsonserialize.php
     *
     * @return scalar|object|array|null returns data which can be serialized by json_encode(), which is a value
     *                                  of any type other than a resource
     */
    #[\ReturnTypeWillChange]
    public function jsonSerialize()
    {
        return ObjectSerializer::sanitizeForSerialization($this);
    }

    /**
     * Gets the string presentation of the object
     *
     * @return string
     */
    public function __toString()
    {
        return json_encode(
            ObjectSerializer::sanitizeForSerialization($this),
            JSON_UNESCAPED_SLASHES
        );
    }

    /**
     * Gets a header-safe presentation of the object
     *
     * @return string
     */
    public function toHeaderValue()
    {
        return json_encode(ObjectSerializer::sanitizeForSerialization($this));
    }
}