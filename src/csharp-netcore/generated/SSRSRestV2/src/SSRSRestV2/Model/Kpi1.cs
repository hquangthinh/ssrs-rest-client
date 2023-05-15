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
    /// An object that specifies a Key Process Indicator (KPI). KPI is derived from the abstract type CatalogItem and therefore includes all of its properties.
    /// </summary>
    public partial class Kpi1 : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Kpi1" /> class.
        /// </summary>
        /// <param name="currency">A string value that specifies the currency. Must follow the ISO 4217 Currency codes standard.</param>
        /// <param name="data">data</param>
        /// <param name="drillthroughTarget">drillthroughTarget</param>
        /// <param name="valueFormat">valueFormat</param>
        /// <param name="values">values</param>
        /// <param name="visualization">visualization</param>
        [JsonConstructor]
        public Kpi1(string currency, KpiData data, DrillthroughTarget drillthroughTarget, KpiValueFormat valueFormat, KpiValues values, KpiVisualization visualization)
        {
#pragma warning disable CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
#pragma warning disable CS8073 // The result of the expression is always the same since a value of this type is never equal to 'null'

            if (valueFormat == null)
                throw new ArgumentNullException("valueFormat is a required property for Kpi1 and cannot be null.");

            if (visualization == null)
                throw new ArgumentNullException("visualization is a required property for Kpi1 and cannot be null.");

            if (drillthroughTarget == null)
                throw new ArgumentNullException("drillthroughTarget is a required property for Kpi1 and cannot be null.");

            if (currency == null)
                throw new ArgumentNullException("currency is a required property for Kpi1 and cannot be null.");

            if (values == null)
                throw new ArgumentNullException("values is a required property for Kpi1 and cannot be null.");

            if (data == null)
                throw new ArgumentNullException("data is a required property for Kpi1 and cannot be null.");

#pragma warning restore CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
#pragma warning restore CS8073 // The result of the expression is always the same since a value of this type is never equal to 'null'

            Currency = currency;
            Data = data;
            DrillthroughTarget = drillthroughTarget;
            ValueFormat = valueFormat;
            Values = values;
            Visualization = visualization;
        }

        /// <summary>
        /// Gets or Sets ValueFormat
        /// </summary>
        [JsonPropertyName("ValueFormat")]
        public KpiValueFormat ValueFormat { get; set; }

        /// <summary>
        /// Gets or Sets Visualization
        /// </summary>
        [JsonPropertyName("Visualization")]
        public KpiVisualization Visualization { get; set; }

        /// <summary>
        /// A string value that specifies the currency. Must follow the ISO 4217 Currency codes standard.
        /// </summary>
        /// <value>A string value that specifies the currency. Must follow the ISO 4217 Currency codes standard.</value>
        [JsonPropertyName("Currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [JsonPropertyName("Data")]
        public KpiData Data { get; set; }

        /// <summary>
        /// Gets or Sets DrillthroughTarget
        /// </summary>
        [JsonPropertyName("DrillthroughTarget")]
        public DrillthroughTarget DrillthroughTarget { get; set; }

        /// <summary>
        /// Gets or Sets Values
        /// </summary>
        [JsonPropertyName("Values")]
        public KpiValues Values { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Kpi1 {\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  DrillthroughTarget: ").Append(DrillthroughTarget).Append("\n");
            sb.Append("  ValueFormat: ").Append(ValueFormat).Append("\n");
            sb.Append("  Values: ").Append(Values).Append("\n");
            sb.Append("  Visualization: ").Append(Visualization).Append("\n");
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
    /// A Json converter for type Kpi1
    /// </summary>
    public class Kpi1JsonConverter : JsonConverter<Kpi1>
    {
        /// <summary>
        /// A Json reader.
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override Kpi1 Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            string currency = default;
            KpiData data = default;
            DrillthroughTarget drillthroughTarget = default;
            KpiValueFormat valueFormat = default;
            KpiValues values = default;
            KpiVisualization visualization = default;

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
                        case "Currency":
                            currency = utf8JsonReader.GetString();
                            break;
                        case "Data":
                            data = JsonSerializer.Deserialize<KpiData>(ref utf8JsonReader, jsonSerializerOptions);
                            break;
                        case "DrillthroughTarget":
                            drillthroughTarget = JsonSerializer.Deserialize<DrillthroughTarget>(ref utf8JsonReader, jsonSerializerOptions);
                            break;
                        case "ValueFormat":
                            string valueFormatRawValue = utf8JsonReader.GetString();
                            valueFormat = KpiValueFormatConverter.FromString(valueFormatRawValue);
                            break;
                        case "Values":
                            values = JsonSerializer.Deserialize<KpiValues>(ref utf8JsonReader, jsonSerializerOptions);
                            break;
                        case "Visualization":
                            string visualizationRawValue = utf8JsonReader.GetString();
                            visualization = KpiVisualizationConverter.FromString(visualizationRawValue);
                            break;
                        default:
                            break;
                    }
                }
            }

            return new Kpi1(currency, data, drillthroughTarget, valueFormat, values, visualization);
        }

        /// <summary>
        /// A Json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="kpi1"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, Kpi1 kpi1, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            writer.WriteString("Currency", kpi1.Currency);
            writer.WritePropertyName("Data");
            JsonSerializer.Serialize(writer, kpi1.Data, jsonSerializerOptions);
            writer.WritePropertyName("DrillthroughTarget");
            JsonSerializer.Serialize(writer, kpi1.DrillthroughTarget, jsonSerializerOptions);
            var valueFormatRawValue = KpiValueFormatConverter.ToJsonValue(kpi1.ValueFormat);
            if (valueFormatRawValue != null)
                writer.WriteString("ValueFormat", valueFormatRawValue);
            else
                writer.WriteNull("ValueFormat");
            writer.WritePropertyName("Values");
            JsonSerializer.Serialize(writer, kpi1.Values, jsonSerializerOptions);
            var visualizationRawValue = KpiVisualizationConverter.ToJsonValue(kpi1.Visualization);
            if (visualizationRawValue != null)
                writer.WriteString("Visualization", visualizationRawValue);
            else
                writer.WriteNull("Visualization");

            writer.WriteEndObject();
        }
    }
}