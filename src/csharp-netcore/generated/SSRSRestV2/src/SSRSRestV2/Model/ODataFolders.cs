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
    /// ODataFolders
    /// </summary>
    public partial class ODataFolders : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ODataFolders" /> class.
        /// </summary>
        /// <param name="odataContext">odataContext</param>
        /// <param name="odataCount">odataCount</param>
        /// <param name="value">value</param>
        [JsonConstructor]
        public ODataFolders(string odataContext, int odataCount, List<Folder> value)
        {
#pragma warning disable CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
#pragma warning disable CS8073 // The result of the expression is always the same since a value of this type is never equal to 'null'

            if (odataContext == null)
                throw new ArgumentNullException("odataContext is a required property for ODataFolders and cannot be null.");

            if (odataCount == null)
                throw new ArgumentNullException("odataCount is a required property for ODataFolders and cannot be null.");

            if (value == null)
                throw new ArgumentNullException("value is a required property for ODataFolders and cannot be null.");

#pragma warning restore CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
#pragma warning restore CS8073 // The result of the expression is always the same since a value of this type is never equal to 'null'

            OdataContext = odataContext;
            OdataCount = odataCount;
            Value = value;
        }

        /// <summary>
        /// Gets or Sets OdataContext
        /// </summary>
        [JsonPropertyName("@odata.context")]
        public string OdataContext { get; set; }

        /// <summary>
        /// Gets or Sets OdataCount
        /// </summary>
        [JsonPropertyName("@odata.count")]
        public int OdataCount { get; set; }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [JsonPropertyName("value")]
        public List<Folder> Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ODataFolders {\n");
            sb.Append("  OdataContext: ").Append(OdataContext).Append("\n");
            sb.Append("  OdataCount: ").Append(OdataCount).Append("\n");
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
    /// A Json converter for type ODataFolders
    /// </summary>
    public class ODataFoldersJsonConverter : JsonConverter<ODataFolders>
    {
        /// <summary>
        /// A Json reader.
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override ODataFolders Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            string odataContext = default;
            int odataCount = default;
            List<Folder> value = default;

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
                        case "@odata.context":
                            odataContext = utf8JsonReader.GetString();
                            break;
                        case "@odata.count":
                            odataCount = utf8JsonReader.GetInt32();
                            break;
                        case "value":
                            value = JsonSerializer.Deserialize<List<Folder>>(ref utf8JsonReader, jsonSerializerOptions);
                            break;
                        default:
                            break;
                    }
                }
            }

            return new ODataFolders(odataContext, odataCount, value);
        }

        /// <summary>
        /// A Json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="oDataFolders"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, ODataFolders oDataFolders, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            writer.WriteString("@odata.context", oDataFolders.OdataContext);
            writer.WriteNumber("@odata.count", oDataFolders.OdataCount);
            writer.WritePropertyName("value");
            JsonSerializer.Serialize(writer, oDataFolders.Value, jsonSerializerOptions);

            writer.WriteEndObject();
        }
    }
}
