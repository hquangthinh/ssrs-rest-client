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
    /// An object that contains information about a parameter in a DataSet.
    /// </summary>
    public partial class DataSetParameterInfo : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DataSetParameterInfo" /> class.
        /// </summary>
        /// <param name="dataType">dataType</param>
        /// <param name="defaultValue">The default value for the parameter.</param>
        /// <param name="isExpression">Specifies whether the parameter is an expression.</param>
        /// <param name="isMultiValued">Specifies whether the parameter contains multiple values.</param>
        /// <param name="name">The name of the parameter.</param>
        /// <param name="nullable">Specifies whether the parameter can be null.</param>
        [JsonConstructor]
        public DataSetParameterInfo(ReportParameterType dataType, string defaultValue, bool isExpression, bool isMultiValued, string name, bool nullable)
        {
#pragma warning disable CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
#pragma warning disable CS8073 // The result of the expression is always the same since a value of this type is never equal to 'null'

            if (name == null)
                throw new ArgumentNullException("name is a required property for DataSetParameterInfo and cannot be null.");

            if (defaultValue == null)
                throw new ArgumentNullException("defaultValue is a required property for DataSetParameterInfo and cannot be null.");

            if (nullable == null)
                throw new ArgumentNullException("nullable is a required property for DataSetParameterInfo and cannot be null.");

            if (dataType == null)
                throw new ArgumentNullException("dataType is a required property for DataSetParameterInfo and cannot be null.");

            if (isExpression == null)
                throw new ArgumentNullException("isExpression is a required property for DataSetParameterInfo and cannot be null.");

            if (isMultiValued == null)
                throw new ArgumentNullException("isMultiValued is a required property for DataSetParameterInfo and cannot be null.");

#pragma warning restore CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
#pragma warning restore CS8073 // The result of the expression is always the same since a value of this type is never equal to 'null'

            DataType = dataType;
            DefaultValue = defaultValue;
            IsExpression = isExpression;
            IsMultiValued = isMultiValued;
            Name = name;
            Nullable = nullable;
        }

        /// <summary>
        /// Gets or Sets DataType
        /// </summary>
        [JsonPropertyName("DataType")]
        public ReportParameterType DataType { get; set; }

        /// <summary>
        /// The default value for the parameter.
        /// </summary>
        /// <value>The default value for the parameter.</value>
        [JsonPropertyName("DefaultValue")]
        public string DefaultValue { get; set; }

        /// <summary>
        /// Specifies whether the parameter is an expression.
        /// </summary>
        /// <value>Specifies whether the parameter is an expression.</value>
        [JsonPropertyName("IsExpression")]
        public bool IsExpression { get; set; }

        /// <summary>
        /// Specifies whether the parameter contains multiple values.
        /// </summary>
        /// <value>Specifies whether the parameter contains multiple values.</value>
        [JsonPropertyName("IsMultiValued")]
        public bool IsMultiValued { get; set; }

        /// <summary>
        /// The name of the parameter.
        /// </summary>
        /// <value>The name of the parameter.</value>
        [JsonPropertyName("Name")]
        public string Name { get; set; }

        /// <summary>
        /// Specifies whether the parameter can be null.
        /// </summary>
        /// <value>Specifies whether the parameter can be null.</value>
        [JsonPropertyName("Nullable")]
        public bool Nullable { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DataSetParameterInfo {\n");
            sb.Append("  DataType: ").Append(DataType).Append("\n");
            sb.Append("  DefaultValue: ").Append(DefaultValue).Append("\n");
            sb.Append("  IsExpression: ").Append(IsExpression).Append("\n");
            sb.Append("  IsMultiValued: ").Append(IsMultiValued).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Nullable: ").Append(Nullable).Append("\n");
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
    /// A Json converter for type DataSetParameterInfo
    /// </summary>
    public class DataSetParameterInfoJsonConverter : JsonConverter<DataSetParameterInfo>
    {
        /// <summary>
        /// A Json reader.
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override DataSetParameterInfo Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            ReportParameterType dataType = default;
            string defaultValue = default;
            bool isExpression = default;
            bool isMultiValued = default;
            string name = default;
            bool nullable = default;

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
                        case "DataType":
                            string dataTypeRawValue = utf8JsonReader.GetString();
                            dataType = ReportParameterTypeConverter.FromString(dataTypeRawValue);
                            break;
                        case "DefaultValue":
                            defaultValue = utf8JsonReader.GetString();
                            break;
                        case "IsExpression":
                            isExpression = utf8JsonReader.GetBoolean();
                            break;
                        case "IsMultiValued":
                            isMultiValued = utf8JsonReader.GetBoolean();
                            break;
                        case "Name":
                            name = utf8JsonReader.GetString();
                            break;
                        case "Nullable":
                            nullable = utf8JsonReader.GetBoolean();
                            break;
                        default:
                            break;
                    }
                }
            }

            return new DataSetParameterInfo(dataType, defaultValue, isExpression, isMultiValued, name, nullable);
        }

        /// <summary>
        /// A Json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="dataSetParameterInfo"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, DataSetParameterInfo dataSetParameterInfo, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            var dataTypeRawValue = ReportParameterTypeConverter.ToJsonValue(dataSetParameterInfo.DataType);
            if (dataTypeRawValue != null)
                writer.WriteString("DataType", dataTypeRawValue);
            else
                writer.WriteNull("DataType");
            writer.WriteString("DefaultValue", dataSetParameterInfo.DefaultValue);
            writer.WriteBoolean("IsExpression", dataSetParameterInfo.IsExpression);
            writer.WriteBoolean("IsMultiValued", dataSetParameterInfo.IsMultiValued);
            writer.WriteString("Name", dataSetParameterInfo.Name);
            writer.WriteBoolean("Nullable", dataSetParameterInfo.Nullable);

            writer.WriteEndObject();
        }
    }
}