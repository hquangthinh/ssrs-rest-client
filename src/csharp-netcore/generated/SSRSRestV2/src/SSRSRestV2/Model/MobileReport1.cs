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
    /// An object that specifies the content of a MobileReport.
    /// </summary>
    public partial class MobileReport1 : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MobileReport1" /> class.
        /// </summary>
        /// <param name="allowCaching">A boolean value that indicates whether the MobileReport allows caching.</param>
        /// <param name="hasSharedDataSets">A boolean value that indicates whether the MobileReport has shared DataSets associated with it.</param>
        /// <param name="manifest">manifest</param>
        [JsonConstructor]
        public MobileReport1(bool allowCaching, bool hasSharedDataSets, MobileReportManifest manifest)
        {
#pragma warning disable CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
#pragma warning disable CS8073 // The result of the expression is always the same since a value of this type is never equal to 'null'

            if (allowCaching == null)
                throw new ArgumentNullException("allowCaching is a required property for MobileReport1 and cannot be null.");

            if (manifest == null)
                throw new ArgumentNullException("manifest is a required property for MobileReport1 and cannot be null.");

            if (hasSharedDataSets == null)
                throw new ArgumentNullException("hasSharedDataSets is a required property for MobileReport1 and cannot be null.");

#pragma warning restore CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
#pragma warning restore CS8073 // The result of the expression is always the same since a value of this type is never equal to 'null'

            AllowCaching = allowCaching;
            HasSharedDataSets = hasSharedDataSets;
            Manifest = manifest;
        }

        /// <summary>
        /// A boolean value that indicates whether the MobileReport allows caching.
        /// </summary>
        /// <value>A boolean value that indicates whether the MobileReport allows caching.</value>
        [JsonPropertyName("AllowCaching")]
        public bool AllowCaching { get; set; }

        /// <summary>
        /// A boolean value that indicates whether the MobileReport has shared DataSets associated with it.
        /// </summary>
        /// <value>A boolean value that indicates whether the MobileReport has shared DataSets associated with it.</value>
        [JsonPropertyName("HasSharedDataSets")]
        public bool HasSharedDataSets { get; set; }

        /// <summary>
        /// Gets or Sets Manifest
        /// </summary>
        [JsonPropertyName("Manifest")]
        public MobileReportManifest Manifest { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MobileReport1 {\n");
            sb.Append("  AllowCaching: ").Append(AllowCaching).Append("\n");
            sb.Append("  HasSharedDataSets: ").Append(HasSharedDataSets).Append("\n");
            sb.Append("  Manifest: ").Append(Manifest).Append("\n");
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
    /// A Json converter for type MobileReport1
    /// </summary>
    public class MobileReport1JsonConverter : JsonConverter<MobileReport1>
    {
        /// <summary>
        /// A Json reader.
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override MobileReport1 Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            bool allowCaching = default;
            bool hasSharedDataSets = default;
            MobileReportManifest manifest = default;

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
                        case "AllowCaching":
                            allowCaching = utf8JsonReader.GetBoolean();
                            break;
                        case "HasSharedDataSets":
                            hasSharedDataSets = utf8JsonReader.GetBoolean();
                            break;
                        case "Manifest":
                            manifest = JsonSerializer.Deserialize<MobileReportManifest>(ref utf8JsonReader, jsonSerializerOptions);
                            break;
                        default:
                            break;
                    }
                }
            }

            return new MobileReport1(allowCaching, hasSharedDataSets, manifest);
        }

        /// <summary>
        /// A Json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="mobileReport1"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, MobileReport1 mobileReport1, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            writer.WriteBoolean("AllowCaching", mobileReport1.AllowCaching);
            writer.WriteBoolean("HasSharedDataSets", mobileReport1.HasSharedDataSets);
            writer.WritePropertyName("Manifest");
            JsonSerializer.Serialize(writer, mobileReport1.Manifest, jsonSerializerOptions);

            writer.WriteEndObject();
        }
    }
}