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
    /// An object that specifies the type of the target of a drillthrough operation.
    /// </summary>
    public partial class DrillthroughTarget : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DrillthroughTarget" /> class.
        /// </summary>
        /// <param name="drillthroughTargetType">drillthroughTargetType</param>
        [JsonConstructor]
        public DrillthroughTarget(DrillthroughTargetType drillthroughTargetType)
        {
#pragma warning disable CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
#pragma warning disable CS8073 // The result of the expression is always the same since a value of this type is never equal to 'null'

            if (drillthroughTargetType == null)
                throw new ArgumentNullException("drillthroughTargetType is a required property for DrillthroughTarget and cannot be null.");

#pragma warning restore CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
#pragma warning restore CS8073 // The result of the expression is always the same since a value of this type is never equal to 'null'

            DrillthroughTargetType = drillthroughTargetType;
        }

        /// <summary>
        /// Gets or Sets DrillthroughTargetType
        /// </summary>
        [JsonPropertyName("DrillthroughTargetType")]
        public DrillthroughTargetType DrillthroughTargetType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DrillthroughTarget {\n");
            sb.Append("  DrillthroughTargetType: ").Append(DrillthroughTargetType).Append("\n");
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
    /// A Json converter for type DrillthroughTarget
    /// </summary>
    public class DrillthroughTargetJsonConverter : JsonConverter<DrillthroughTarget>
    {
        /// <summary>
        /// A Json reader.
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override DrillthroughTarget Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            DrillthroughTargetType drillthroughTargetType = default;

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
                        case "DrillthroughTargetType":
                            string drillthroughTargetTypeRawValue = utf8JsonReader.GetString();
                            drillthroughTargetType = DrillthroughTargetTypeConverter.FromString(drillthroughTargetTypeRawValue);
                            break;
                        default:
                            break;
                    }
                }
            }

            return new DrillthroughTarget(drillthroughTargetType);
        }

        /// <summary>
        /// A Json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="drillthroughTarget"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, DrillthroughTarget drillthroughTarget, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            var drillthroughTargetTypeRawValue = DrillthroughTargetTypeConverter.ToJsonValue(drillthroughTarget.DrillthroughTargetType);
            if (drillthroughTargetTypeRawValue != null)
                writer.WriteString("DrillthroughTargetType", drillthroughTargetTypeRawValue);
            else
                writer.WriteNull("DrillthroughTargetType");

            writer.WriteEndObject();
        }
    }
}
