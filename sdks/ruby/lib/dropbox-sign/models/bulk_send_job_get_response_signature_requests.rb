=begin
#Dropbox Sign API

#Dropbox Sign v3 API

The version of the OpenAPI document: 3.0.0
Contact: apisupport@hellosign.com
Generated by: https://openapi-generator.tech
OpenAPI Generator version: 5.3.0

=end

require 'date'
require 'time'

module Dropbox
end

module Dropbox::Sign
  class BulkSendJobGetResponseSignatureRequests
    # Whether this is a test signature request. Test requests have no legal value. Defaults to `false`.
    # @return [Boolean, nil]
    attr_accessor :test_mode

    # The id of the SignatureRequest.
    # @return [String]
    attr_accessor :signature_request_id

    # The email address of the initiator of the SignatureRequest.
    # @return [String]
    attr_accessor :requester_email_address

    # The title the specified Account uses for the SignatureRequest.
    # @return [String]
    attr_accessor :title

    # Default Label for account.
    # @return [String]
    attr_accessor :original_title

    # The subject in the email that was initially sent to the signers.
    # @return [String, nil]
    attr_accessor :subject

    # The custom message in the email that was initially sent to the signers.
    # @return [String, nil]
    attr_accessor :message

    # The metadata attached to the signature request.
    # @return [Object]
    attr_accessor :metadata

    # Time the signature request was created.
    # @return [Integer]
    attr_accessor :created_at

    # The time when the signature request will expire unsigned signatures. See [Signature Request Expiration Date](https://developers.hellosign.com/docs/signature-request/expiration/) for details.
    # @return [Integer]
    attr_accessor :expires_at

    # Whether or not the SignatureRequest has been fully executed by all signers.
    # @return [Boolean]
    attr_accessor :is_complete

    # Whether or not the SignatureRequest has been declined by a signer.
    # @return [Boolean]
    attr_accessor :is_declined

    # Whether or not an error occurred (either during the creation of the SignatureRequest or during one of the signings).
    # @return [Boolean]
    attr_accessor :has_error

    # The URL where a copy of the request's documents can be downloaded.
    # @return [String]
    attr_accessor :files_url

    # The URL where a signer, after authenticating, can sign the documents. This should only be used by users with existing Dropbox Sign accounts as they will be required to log in before signing.
    # @return [String, nil]
    attr_accessor :signing_url

    # The URL where the requester and the signers can view the current status of the SignatureRequest.
    # @return [String]
    attr_accessor :details_url

    # A list of email addresses that were CCed on the SignatureRequest. They will receive a copy of the final PDF once all the signers have signed.
    # @return [Array<String>]
    attr_accessor :cc_email_addresses

    # The URL you want the signer redirected to after they successfully sign.
    # @return [String, nil]
    attr_accessor :signing_redirect_url

    # Templates IDs used in this SignatureRequest (if any).
    # @return [Array<String>, nil]
    attr_accessor :template_ids

    # An array of Custom Field objects containing the name and type of each custom field.  * Text Field uses `SignatureRequestResponseCustomFieldText` * Checkbox Field uses `SignatureRequestResponseCustomFieldCheckbox`
    # @return [Array<SignatureRequestResponseCustomFieldBase>, nil]
    attr_accessor :custom_fields

    # Signer attachments.
    # @return [Array<SignatureRequestResponseAttachment>, nil]
    attr_accessor :attachments

    # An array of form field objects containing the name, value, and type of each textbox or checkmark field filled in by the signers.
    # @return [Array<SignatureRequestResponseDataBase>, nil]
    attr_accessor :response_data

    # An array of signature objects, 1 for each signer.
    # @return [Array<SignatureRequestResponseSignatures>]
    attr_accessor :signatures

    # The id of the BulkSendJob.
    # @return [String]
    attr_accessor :bulk_send_job_id

    # Attribute mapping from ruby-style variable name to JSON key.
    def self.attribute_map
      {
        :'test_mode' => :'test_mode',
        :'signature_request_id' => :'signature_request_id',
        :'requester_email_address' => :'requester_email_address',
        :'title' => :'title',
        :'original_title' => :'original_title',
        :'subject' => :'subject',
        :'message' => :'message',
        :'metadata' => :'metadata',
        :'created_at' => :'created_at',
        :'expires_at' => :'expires_at',
        :'is_complete' => :'is_complete',
        :'is_declined' => :'is_declined',
        :'has_error' => :'has_error',
        :'files_url' => :'files_url',
        :'signing_url' => :'signing_url',
        :'details_url' => :'details_url',
        :'cc_email_addresses' => :'cc_email_addresses',
        :'signing_redirect_url' => :'signing_redirect_url',
        :'template_ids' => :'template_ids',
        :'custom_fields' => :'custom_fields',
        :'attachments' => :'attachments',
        :'response_data' => :'response_data',
        :'signatures' => :'signatures',
        :'bulk_send_job_id' => :'bulk_send_job_id'
      }
    end

    # Returns all the JSON keys this model knows about
    def self.acceptable_attributes
      attribute_map.values
    end

    # Returns attribute map of this model + parent
    def self.merged_attributes
      self.attribute_map
    end

    # Attribute type mapping.
    def self.openapi_types
      {
        :'test_mode' => :'Boolean',
        :'signature_request_id' => :'String',
        :'requester_email_address' => :'String',
        :'title' => :'String',
        :'original_title' => :'String',
        :'subject' => :'String',
        :'message' => :'String',
        :'metadata' => :'Object',
        :'created_at' => :'Integer',
        :'expires_at' => :'Integer',
        :'is_complete' => :'Boolean',
        :'is_declined' => :'Boolean',
        :'has_error' => :'Boolean',
        :'files_url' => :'String',
        :'signing_url' => :'String',
        :'details_url' => :'String',
        :'cc_email_addresses' => :'Array<String>',
        :'signing_redirect_url' => :'String',
        :'template_ids' => :'Array<String>',
        :'custom_fields' => :'Array<SignatureRequestResponseCustomFieldBase>',
        :'attachments' => :'Array<SignatureRequestResponseAttachment>',
        :'response_data' => :'Array<SignatureRequestResponseDataBase>',
        :'signatures' => :'Array<SignatureRequestResponseSignatures>',
        :'bulk_send_job_id' => :'String'
      }
    end

    # Attribute type mapping of this model + parent
    def self.merged_types
      self.openapi_types
    end

    # List of attributes with nullable: true
    def self.openapi_nullable
      Set.new([
        :'test_mode',
        :'subject',
        :'message',
        :'signing_url',
        :'signing_redirect_url',
        :'template_ids',
        :'custom_fields',
        :'attachments',
        :'response_data',
      ])
    end

    # Returns list of attributes with nullable: true of this model + parent
    def self.merged_nullable
      self.openapi_nullable
    end

    # Attempt to instantiate and hydrate a new instance of this class
    # @param [Object] data Data to be converted
    # @return [BulkSendJobGetResponseSignatureRequests]
    def self.init(data)
      return ApiClient.default.convert_to_type(
        data,
        "BulkSendJobGetResponseSignatureRequests"
      ) || BulkSendJobGetResponseSignatureRequests.new
    end

    # Initializes the object
    # @param [Hash] attributes Model attributes in the form of hash
    def initialize(attributes = {})
      if (!attributes.is_a?(Hash))
        fail ArgumentError, "The input argument (attributes) must be a hash in `Dropbox::Sign::BulkSendJobGetResponseSignatureRequests` initialize method"
      end

      # check to see if the attribute exists and convert string to symbol for hash key
      attributes = attributes.each_with_object({}) { |(k, v), h|
        if (!self.class.merged_attributes.key?(k.to_sym))
          fail ArgumentError, "`#{k}` is not a valid attribute in `Dropbox::Sign::BulkSendJobGetResponseSignatureRequests`. Please check the name to make sure it's valid. List of attributes: " + self.class.attribute_map.keys.inspect
        end
        h[k.to_sym] = v
      }

      if attributes.key?(:'test_mode')
        self.test_mode = attributes[:'test_mode']
      else
        self.test_mode = false
      end

      if attributes.key?(:'signature_request_id')
        self.signature_request_id = attributes[:'signature_request_id']
      end

      if attributes.key?(:'requester_email_address')
        self.requester_email_address = attributes[:'requester_email_address']
      end

      if attributes.key?(:'title')
        self.title = attributes[:'title']
      end

      if attributes.key?(:'original_title')
        self.original_title = attributes[:'original_title']
      end

      if attributes.key?(:'subject')
        self.subject = attributes[:'subject']
      end

      if attributes.key?(:'message')
        self.message = attributes[:'message']
      end

      if attributes.key?(:'metadata')
        self.metadata = attributes[:'metadata']
      end

      if attributes.key?(:'created_at')
        self.created_at = attributes[:'created_at']
      end

      if attributes.key?(:'expires_at')
        self.expires_at = attributes[:'expires_at']
      end

      if attributes.key?(:'is_complete')
        self.is_complete = attributes[:'is_complete']
      end

      if attributes.key?(:'is_declined')
        self.is_declined = attributes[:'is_declined']
      end

      if attributes.key?(:'has_error')
        self.has_error = attributes[:'has_error']
      end

      if attributes.key?(:'files_url')
        self.files_url = attributes[:'files_url']
      end

      if attributes.key?(:'signing_url')
        self.signing_url = attributes[:'signing_url']
      end

      if attributes.key?(:'details_url')
        self.details_url = attributes[:'details_url']
      end

      if attributes.key?(:'cc_email_addresses')
        if (value = attributes[:'cc_email_addresses']).is_a?(Array)
          self.cc_email_addresses = value
        end
      end

      if attributes.key?(:'signing_redirect_url')
        self.signing_redirect_url = attributes[:'signing_redirect_url']
      end

      if attributes.key?(:'template_ids')
        if (value = attributes[:'template_ids']).is_a?(Array)
          self.template_ids = value
        end
      end

      if attributes.key?(:'custom_fields')
        if (value = attributes[:'custom_fields']).is_a?(Array)
          self.custom_fields = value
        end
      end

      if attributes.key?(:'attachments')
        if (value = attributes[:'attachments']).is_a?(Array)
          self.attachments = value
        end
      end

      if attributes.key?(:'response_data')
        if (value = attributes[:'response_data']).is_a?(Array)
          self.response_data = value
        end
      end

      if attributes.key?(:'signatures')
        if (value = attributes[:'signatures']).is_a?(Array)
          self.signatures = value
        end
      end

      if attributes.key?(:'bulk_send_job_id')
        self.bulk_send_job_id = attributes[:'bulk_send_job_id']
      end
    end

    # Show invalid properties with the reasons. Usually used together with valid?
    # @return Array for valid properties with the reasons
    def list_invalid_properties
      invalid_properties = Array.new
      invalid_properties
    end

    # Check to see if the all the properties in the model are valid
    # @return true if the model is valid
    def valid?
      true
    end

    # Checks equality by comparing each attribute.
    # @param [Object] Object to be compared
    def ==(o)
      return true if self.equal?(o)
      self.class == o.class &&
          test_mode == o.test_mode &&
          signature_request_id == o.signature_request_id &&
          requester_email_address == o.requester_email_address &&
          title == o.title &&
          original_title == o.original_title &&
          subject == o.subject &&
          message == o.message &&
          metadata == o.metadata &&
          created_at == o.created_at &&
          expires_at == o.expires_at &&
          is_complete == o.is_complete &&
          is_declined == o.is_declined &&
          has_error == o.has_error &&
          files_url == o.files_url &&
          signing_url == o.signing_url &&
          details_url == o.details_url &&
          cc_email_addresses == o.cc_email_addresses &&
          signing_redirect_url == o.signing_redirect_url &&
          template_ids == o.template_ids &&
          custom_fields == o.custom_fields &&
          attachments == o.attachments &&
          response_data == o.response_data &&
          signatures == o.signatures &&
          bulk_send_job_id == o.bulk_send_job_id
    end

    # @see the `==` method
    # @param [Object] Object to be compared
    def eql?(o)
      self == o
    end

    # Calculates hash code according to all attributes.
    # @return [Integer] Hash code
    def hash
      [test_mode, signature_request_id, requester_email_address, title, original_title, subject, message, metadata, created_at, expires_at, is_complete, is_declined, has_error, files_url, signing_url, details_url, cc_email_addresses, signing_redirect_url, template_ids, custom_fields, attachments, response_data, signatures, bulk_send_job_id].hash
    end

    # Builds the object from hash
    # @param [Hash] attributes Model attributes in the form of hash
    # @return [Object] Returns the model itself
    def self.build_from_hash(attributes)
      new.build_from_hash(attributes)
    end

    # Builds the object from hash
    # @param [Hash] attributes Model attributes in the form of hash
    # @return [Object] Returns the model itself
    def build_from_hash(attributes)
      return nil unless attributes.is_a?(Hash)
      attribute_map = self.class.merged_attributes

      self.class.merged_types.each_pair do |key, type|
        if type =~ /\AArray<(.*)>/i
          # check to ensure the input is an array given that the attribute
          # is documented as an array but the input is not
          if attributes[attribute_map[key]].is_a?(Array)
            self.send("#{key}=", attributes[attribute_map[key]].map { |v| _deserialize($1, v) })
          end
        elsif !attributes[attribute_map[key]].nil?
          self.send("#{key}=", _deserialize(type, attributes[attribute_map[key]]))
        end
      end

      self
    end

    # Deserializes the data based on type
    # @param string type Data type
    # @param string value Value to be deserialized
    # @return [Object] Deserialized data
    def _deserialize(type, value)
      case type.to_sym
      when :Time
        Time.parse(value)
      when :Date
        Date.parse(value)
      when :String
        value.to_s
      when :Integer
        value.to_i
      when :Float
        value.to_f
      when :Boolean
        if value.to_s =~ /\A(true|t|yes|y|1)\z/i
          true
        else
          false
        end
      when :File
        value
      when :Object
        # generic object (usually a Hash), return directly
        value
      when /\AArray<(?<inner_type>.+)>\z/
        inner_type = Regexp.last_match[:inner_type]
        value.map { |v| _deserialize(inner_type, v) }
      when /\AHash<(?<k_type>.+?), (?<v_type>.+)>\z/
        k_type = Regexp.last_match[:k_type]
        v_type = Regexp.last_match[:v_type]
        {}.tap do |hash|
          value.each do |k, v|
            hash[_deserialize(k_type, k)] = _deserialize(v_type, v)
          end
        end
      else # model
        # models (e.g. Pet)
        klass = Dropbox::Sign.const_get(type)
        klass.respond_to?(:openapi_one_of) ? klass.build(value) : klass.build_from_hash(value)
      end
    end

    # Returns the string representation of the object
    # @return [String] String presentation of the object
    def to_s
      to_hash.to_s
    end

    # to_body is an alias to to_hash (backward compatibility)
    # @return [Hash] Returns the object in the form of hash
    def to_body
      to_hash
    end

    # Returns the object in the form of hash
    # @return [Hash] Returns the object in the form of hash
    def to_hash(include_nil = true)
      hash = {}
      self.class.merged_attributes.each_pair do |attr, param|
        value = self.send(attr)
        if value.nil?
          next unless include_nil
          is_nullable = self.class.merged_nullable.include?(attr)
          next if !is_nullable || (is_nullable && !instance_variable_defined?(:"@#{attr}"))
        end

        hash[param] = _to_hash(value, include_nil)
      end
      hash
    end

    # Outputs non-array value in the form of hash
    # For object, use to_hash. Otherwise, just return the value
    # @param [Object] value Any valid value
    # @return [Hash] Returns the value in the form of hash
    def _to_hash(value, include_nil = true)
      if value.is_a?(Array)
        value.compact.map { |v| _to_hash(v, include_nil) }
      elsif value.is_a?(Hash)
        {}.tap do |hash|
          value.each { |k, v| hash[k] = _to_hash(v, include_nil) }
        end
      elsif value.respond_to? :to_hash
        value.to_hash(include_nil)
      else
        value
      end
    end

  end

end
