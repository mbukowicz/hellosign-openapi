<?php
/**
 * TemplateResponseDocumentCustomFieldText
 *
 * PHP version 7.4
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

namespace Dropbox\Sign\Model;

use Dropbox\Sign\ObjectSerializer;
use ReturnTypeWillChange;

/**
 * TemplateResponseDocumentCustomFieldText Class Doc Comment
 *
 * @category Class
 * @description This class extends &#x60;TemplateResponseDocumentCustomFieldBase&#x60;
 * @author   OpenAPI Generator team
 * @see     https://openapi-generator.tech
 * @implements \ArrayAccess<TKey, TValue>
 * @template TKey int|null
 * @template TValue mixed|null
 */
class TemplateResponseDocumentCustomFieldText extends TemplateResponseDocumentCustomFieldBase
{
    public const DISCRIMINATOR = null;

    /**
     * The original name of the model.
     *
     * @var string
     */
    protected static $openAPIModelName = 'TemplateResponseDocumentCustomFieldText';

    /**
     * Array of property to type mappings. Used for (de)serialization
     *
     * @var string[]
     */
    protected static $openAPITypes = [
        'type' => 'string',
        'avg_text_length' => '\Dropbox\Sign\Model\TemplateResponseFieldAvgTextLength',
        'is_multiline' => 'bool',
        'original_font_size' => 'int',
        'font_family' => 'string',
    ];

    /**
     * Array of property to format mappings. Used for (de)serialization
     *
     * @var string[]
     * @phpstan-var array<string, string|null>
     * @psalm-var array<string, string|null>
     */
    protected static $openAPIFormats = [
        'type' => null,
        'avg_text_length' => null,
        'is_multiline' => null,
        'original_font_size' => null,
        'font_family' => null,
    ];

    /**
     * Array of property to type mappings. Used for (de)serialization
     *
     * @return array
     */
    public static function openAPITypes()
    {
        return self::$openAPITypes + parent::openAPITypes();
    }

    /**
     * Array of property to format mappings. Used for (de)serialization
     *
     * @return array
     */
    public static function openAPIFormats()
    {
        return self::$openAPIFormats + parent::openAPIFormats();
    }

    /**
     * Array of attributes where the key is the local name,
     * and the value is the original name
     *
     * @var string[]
     */
    protected static $attributeMap = [
        'type' => 'type',
        'avg_text_length' => 'avg_text_length',
        'is_multiline' => 'isMultiline',
        'original_font_size' => 'originalFontSize',
        'font_family' => 'fontFamily',
    ];

    /**
     * Array of attributes to setter functions (for deserialization of responses)
     *
     * @var string[]
     */
    protected static $setters = [
        'type' => 'setType',
        'avg_text_length' => 'setAvgTextLength',
        'is_multiline' => 'setIsMultiline',
        'original_font_size' => 'setOriginalFontSize',
        'font_family' => 'setFontFamily',
    ];

    /**
     * Array of attributes to getter functions (for serialization of requests)
     *
     * @var string[]
     */
    protected static $getters = [
        'type' => 'getType',
        'avg_text_length' => 'getAvgTextLength',
        'is_multiline' => 'getIsMultiline',
        'original_font_size' => 'getOriginalFontSize',
        'font_family' => 'getFontFamily',
    ];

    /**
     * Array of attributes where the key is the local name,
     * and the value is the original name
     *
     * @return array
     */
    public static function attributeMap()
    {
        return parent::attributeMap() + self::$attributeMap;
    }

    /**
     * Array of attributes to setter functions (for deserialization of responses)
     *
     * @return array
     */
    public static function setters()
    {
        return parent::setters() + self::$setters;
    }

    /**
     * Array of attributes to getter functions (for serialization of requests)
     *
     * @return array
     */
    public static function getters()
    {
        return parent::getters() + self::$getters;
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
     * Constructor
     *
     * @param array|null $data Associated array of property values
     *                         initializing the model
     */
    public function __construct(array $data = null)
    {
        parent::__construct($data);

        $this->container['type'] = $data['type'] ?? 'text';
        $this->container['avg_text_length'] = $data['avg_text_length'] ?? null;
        $this->container['is_multiline'] = $data['is_multiline'] ?? null;
        $this->container['original_font_size'] = $data['original_font_size'] ?? null;
        $this->container['font_family'] = $data['font_family'] ?? null;
    }

    /** @deprecated use ::init() */
    public static function fromArray(array $data): TemplateResponseDocumentCustomFieldText
    {
        return self::init($data);
    }

    /** Attempt to instantiate and hydrate a new instance of this class */
    public static function init(array $data): TemplateResponseDocumentCustomFieldText
    {
        /** @var TemplateResponseDocumentCustomFieldText $obj */
        $obj = ObjectSerializer::deserialize(
            $data,
            TemplateResponseDocumentCustomFieldText::class,
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
        $invalidProperties = parent::listInvalidProperties();

        if ($this->container['type'] === null) {
            $invalidProperties[] = "'type' can't be null";
        }

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
     * Gets type
     *
     * @return string
     */
    public function getType()
    {
        return $this->container['type'];
    }

    /**
     * Sets type
     *
     * @param string $type The type of this Custom Field. Only `text` and `checkbox` are currently supported.  * Text uses `TemplateResponseDocumentCustomFieldText` * Checkbox uses `TemplateResponseDocumentCustomFieldCheckbox`
     *
     * @return self
     */
    public function setType(string $type)
    {
        $this->container['type'] = $type;

        return $this;
    }

    /**
     * Gets avg_text_length
     *
     * @return TemplateResponseFieldAvgTextLength|null
     */
    public function getAvgTextLength()
    {
        return $this->container['avg_text_length'];
    }

    /**
     * Sets avg_text_length
     *
     * @param TemplateResponseFieldAvgTextLength|null $avg_text_length avg_text_length
     *
     * @return self
     */
    public function setAvgTextLength(?TemplateResponseFieldAvgTextLength $avg_text_length)
    {
        $this->container['avg_text_length'] = $avg_text_length;

        return $this;
    }

    /**
     * Gets is_multiline
     *
     * @return bool|null
     */
    public function getIsMultiline()
    {
        return $this->container['is_multiline'];
    }

    /**
     * Sets is_multiline
     *
     * @param bool|null $is_multiline whether this form field is multiline text
     *
     * @return self
     */
    public function setIsMultiline(?bool $is_multiline)
    {
        $this->container['is_multiline'] = $is_multiline;

        return $this;
    }

    /**
     * Gets original_font_size
     *
     * @return int|null
     */
    public function getOriginalFontSize()
    {
        return $this->container['original_font_size'];
    }

    /**
     * Sets original_font_size
     *
     * @param int|null $original_font_size original font size used in this form field's text
     *
     * @return self
     */
    public function setOriginalFontSize(?int $original_font_size)
    {
        $this->container['original_font_size'] = $original_font_size;

        return $this;
    }

    /**
     * Gets font_family
     *
     * @return string|null
     */
    public function getFontFamily()
    {
        return $this->container['font_family'];
    }

    /**
     * Sets font_family
     *
     * @param string|null $font_family font family used in this form field's text
     *
     * @return self
     */
    public function setFontFamily(?string $font_family)
    {
        $this->container['font_family'] = $font_family;

        return $this;
    }

    /**
     * Returns true if offset exists. False otherwise.
     *
     * @param mixed $offset Offset
     *
     * @return bool
     */
    #[ReturnTypeWillChange]
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
    #[ReturnTypeWillChange]
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
    #[ReturnTypeWillChange]
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
    #[ReturnTypeWillChange]
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
    #[ReturnTypeWillChange]
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
