// <auto-generated>
/*
 * SQL Server 2017 Reporting Services REST API
 *
 * The SQL Server 2017 Reporting Services REST API provides programmatic access to the report server catalog.  For example, basic CRUD operations can be done on folders, reports, KPIs, data sources, datasets, refresh plans, subscriptions, etc.     The REST API can also be used to provide more advanced functionality, such as: * Navigate the folder hierarchy * Discover the contents of a folder * Download a report definition * Modify default report parameters * Change or execute a refresh plan * A whole lot more  The REST API is a RESTful successor to the legacy [SOAP API](https://msdn.microsoft.com/library/reportservice2010.reportingservice2010.aspx).  Happy coding!  __API samples:__ https://github.com/Microsoft/Reporting-Services  __Developer documentation:__ https://docs.microsoft.com/sql/reporting-services/reporting-services-developer-documentation  __Team Blog:__ https://blogs.msdn.microsoft.com/sqlrsteamblog  __Support forums:__ https://social.msdn.microsoft.com/Forums/en-US/home?forum=sqlreportingservices 
 *
 * The version of the OpenAPI document: 2.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;

namespace SSRSRestV2.Model
{
    /// <summary>
    /// An object that contains the definition of a Reporting Services extension&#39;s parameter.
    /// </summary>
    public partial class ExtensionParameter : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExtensionParameter" /> class.
        /// </summary>
        /// <param name="displayName">The name of the extension setting that is displayed to the user.</param>
        /// <param name="encrypted">Indicates whether the extension parameter value should be encrypted in the Report Server database.</param>
        /// <param name="error">An error that describes a problem with the value of the setting.</param>
        /// <param name="isPassword">A Boolean value that indicates whether the ExtensionParameter is a password.</param>
        /// <param name="name">A string value that specifies the name for the ExtensionParameter.</param>
        /// <param name="readOnly">Indicates whether the setting is read-only.</param>
        /// <param name="required">Indicates whether the value is required.</param>
        /// <param name="validValues">A set of values that can be configured for the setting.</param>
        /// <param name="validValuesIsNull">A Boolean value that indicates whether the ValidValues property is null.</param>
        /// <param name="value">A string that represents the value of an extension parameter.</param>
        [JsonConstructor]
        public ExtensionParameter(string displayName, bool encrypted, string error, bool isPassword, string name, bool readOnly, bool required, List<ValidValue> validValues, bool validValuesIsNull, string value)
        {
#pragma warning disable CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
#pragma warning disable CS8073 // The result of the expression is always the same since a value of this type is never equal to 'null'

            if (name == null)
                throw new ArgumentNullException("name is a required property for ExtensionParameter and cannot be null.");

            if (displayName == null)
                throw new ArgumentNullException("displayName is a required property for ExtensionParameter and cannot be null.");

            if (required == null)
                throw new ArgumentNullException("required is a required property for ExtensionParameter and cannot be null.");

            if (readOnly == null)
                throw new ArgumentNullException("readOnly is a required property for ExtensionParameter and cannot be null.");

            if (value == null)
                throw new ArgumentNullException("value is a required property for ExtensionParameter and cannot be null.");

            if (error == null)
                throw new ArgumentNullException("error is a required property for ExtensionParameter and cannot be null.");

            if (encrypted == null)
                throw new ArgumentNullException("encrypted is a required property for ExtensionParameter and cannot be null.");

            if (isPassword == null)
                throw new ArgumentNullException("isPassword is a required property for ExtensionParameter and cannot be null.");

            if (validValues == null)
                throw new ArgumentNullException("validValues is a required property for ExtensionParameter and cannot be null.");

            if (validValuesIsNull == null)
                throw new ArgumentNullException("validValuesIsNull is a required property for ExtensionParameter and cannot be null.");

#pragma warning restore CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
#pragma warning restore CS8073 // The result of the expression is always the same since a value of this type is never equal to 'null'

            DisplayName = displayName;
            Encrypted = encrypted;
            Error = error;
            IsPassword = isPassword;
            Name = name;
            ReadOnly = readOnly;
            Required = required;
            ValidValues = validValues;
            ValidValuesIsNull = validValuesIsNull;
            Value = value;
        }

        /// <summary>
        /// The name of the extension setting that is displayed to the user.
        /// </summary>
        /// <value>The name of the extension setting that is displayed to the user.</value>
        [JsonPropertyName("DisplayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Indicates whether the extension parameter value should be encrypted in the Report Server database.
        /// </summary>
        /// <value>Indicates whether the extension parameter value should be encrypted in the Report Server database.</value>
        [JsonPropertyName("Encrypted")]
        public bool Encrypted { get; set; }

        /// <summary>
        /// An error that describes a problem with the value of the setting.
        /// </summary>
        /// <value>An error that describes a problem with the value of the setting.</value>
        [JsonPropertyName("Error")]
        public string Error { get; set; }

        /// <summary>
        /// A Boolean value that indicates whether the ExtensionParameter is a password.
        /// </summary>
        /// <value>A Boolean value that indicates whether the ExtensionParameter is a password.</value>
        [JsonPropertyName("IsPassword")]
        public bool IsPassword { get; set; }

        /// <summary>
        /// A string value that specifies the name for the ExtensionParameter.
        /// </summary>
        /// <value>A string value that specifies the name for the ExtensionParameter.</value>
        [JsonPropertyName("Name")]
        public string Name { get; set; }

        /// <summary>
        /// Indicates whether the setting is read-only.
        /// </summary>
        /// <value>Indicates whether the setting is read-only.</value>
        [JsonPropertyName("ReadOnly")]
        public bool ReadOnly { get; set; }

        /// <summary>
        /// Indicates whether the value is required.
        /// </summary>
        /// <value>Indicates whether the value is required.</value>
        [JsonPropertyName("Required")]
        public bool Required { get; set; }

        /// <summary>
        /// A set of values that can be configured for the setting.
        /// </summary>
        /// <value>A set of values that can be configured for the setting.</value>
        [JsonPropertyName("ValidValues")]
        public List<ValidValue> ValidValues { get; set; }

        /// <summary>
        /// A Boolean value that indicates whether the ValidValues property is null.
        /// </summary>
        /// <value>A Boolean value that indicates whether the ValidValues property is null.</value>
        [JsonPropertyName("ValidValuesIsNull")]
        public bool ValidValuesIsNull { get; set; }

        /// <summary>
        /// A string that represents the value of an extension parameter.
        /// </summary>
        /// <value>A string that represents the value of an extension parameter.</value>
        [JsonPropertyName("Value")]
        public string Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ExtensionParameter {\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Encrypted: ").Append(Encrypted).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  IsPassword: ").Append(IsPassword).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ReadOnly: ").Append(ReadOnly).Append("\n");
            sb.Append("  Required: ").Append(Required).Append("\n");
            sb.Append("  ValidValues: ").Append(ValidValues).Append("\n");
            sb.Append("  ValidValuesIsNull: ").Append(ValidValuesIsNull).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type ExtensionParameter
    /// </summary>
    public class ExtensionParameterJsonConverter : JsonConverter<ExtensionParameter>
    {
        /// <summary>
        /// A Json reader.
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override ExtensionParameter Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            string displayName = default;
            bool encrypted = default;
            string error = default;
            bool isPassword = default;
            string name = default;
            bool readOnly = default;
            bool required = default;
            List<ValidValue> validValues = default;
            bool validValuesIsNull = default;
            string value = default;

            while (utf8JsonReader.Read())
            {
                if (startingTokenType == JsonTokenType.StartObject && utf8JsonReader.TokenType == JsonTokenType.EndObject && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (startingTokenType == JsonTokenType.StartArray && utf8JsonReader.TokenType == JsonTokenType.EndArray && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (utf8JsonReader.TokenType == JsonTokenType.PropertyName && currentDepth == utf8JsonReader.CurrentDepth - 1)
                {
                    string propertyName = utf8JsonReader.GetString();
                    utf8JsonReader.Read();

                    switch (propertyName)
                    {
                        case "DisplayName":
                            displayName = utf8JsonReader.GetString();
                            break;
                        case "Encrypted":
                            encrypted = utf8JsonReader.GetBoolean();
                            break;
                        case "Error":
                            error = utf8JsonReader.GetString();
                            break;
                        case "IsPassword":
                            isPassword = utf8JsonReader.GetBoolean();
                            break;
                        case "Name":
                            name = utf8JsonReader.GetString();
                            break;
                        case "ReadOnly":
                            readOnly = utf8JsonReader.GetBoolean();
                            break;
                        case "Required":
                            required = utf8JsonReader.GetBoolean();
                            break;
                        case "ValidValues":
                            validValues = JsonSerializer.Deserialize<List<ValidValue>>(ref utf8JsonReader, jsonSerializerOptions);
                            break;
                        case "ValidValuesIsNull":
                            validValuesIsNull = utf8JsonReader.GetBoolean();
                            break;
                        case "Value":
                            value = utf8JsonReader.GetString();
                            break;
                        default:
                            break;
                    }
                }
            }

            return new ExtensionParameter(displayName, encrypted, error, isPassword, name, readOnly, required, validValues, validValuesIsNull, value);
        }

        /// <summary>
        /// A Json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="extensionParameter"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, ExtensionParameter extensionParameter, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            writer.WriteString("DisplayName", extensionParameter.DisplayName);
            writer.WriteBoolean("Encrypted", extensionParameter.Encrypted);
            writer.WriteString("Error", extensionParameter.Error);
            writer.WriteBoolean("IsPassword", extensionParameter.IsPassword);
            writer.WriteString("Name", extensionParameter.Name);
            writer.WriteBoolean("ReadOnly", extensionParameter.ReadOnly);
            writer.WriteBoolean("Required", extensionParameter.Required);
            writer.WritePropertyName("ValidValues");
            JsonSerializer.Serialize(writer, extensionParameter.ValidValues, jsonSerializerOptions);
            writer.WriteBoolean("ValidValuesIsNull", extensionParameter.ValidValuesIsNull);
            writer.WriteString("Value", extensionParameter.Value);

            writer.WriteEndObject();
        }
    }
}
