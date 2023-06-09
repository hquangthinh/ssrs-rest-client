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
    /// Represents the months of the year in which a scheduled report runs
    /// </summary>
    public partial class MonthsOfYearSelector : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MonthsOfYearSelector" /> class.
        /// </summary>
        /// <param name="april">april</param>
        /// <param name="august">august</param>
        /// <param name="december">december</param>
        /// <param name="february">february</param>
        /// <param name="january">january</param>
        /// <param name="july">july</param>
        /// <param name="june">june</param>
        /// <param name="march">march</param>
        /// <param name="may">may</param>
        /// <param name="november">november</param>
        /// <param name="october">october</param>
        /// <param name="september">september</param>
        [JsonConstructor]
        public MonthsOfYearSelector(bool april, bool august, bool december, bool february, bool january, bool july, bool june, bool march, bool may, bool november, bool october, bool september)
        {
#pragma warning disable CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
#pragma warning disable CS8073 // The result of the expression is always the same since a value of this type is never equal to 'null'

            if (january == null)
                throw new ArgumentNullException("january is a required property for MonthsOfYearSelector and cannot be null.");

            if (february == null)
                throw new ArgumentNullException("february is a required property for MonthsOfYearSelector and cannot be null.");

            if (march == null)
                throw new ArgumentNullException("march is a required property for MonthsOfYearSelector and cannot be null.");

            if (april == null)
                throw new ArgumentNullException("april is a required property for MonthsOfYearSelector and cannot be null.");

            if (may == null)
                throw new ArgumentNullException("may is a required property for MonthsOfYearSelector and cannot be null.");

            if (june == null)
                throw new ArgumentNullException("june is a required property for MonthsOfYearSelector and cannot be null.");

            if (july == null)
                throw new ArgumentNullException("july is a required property for MonthsOfYearSelector and cannot be null.");

            if (august == null)
                throw new ArgumentNullException("august is a required property for MonthsOfYearSelector and cannot be null.");

            if (september == null)
                throw new ArgumentNullException("september is a required property for MonthsOfYearSelector and cannot be null.");

            if (october == null)
                throw new ArgumentNullException("october is a required property for MonthsOfYearSelector and cannot be null.");

            if (november == null)
                throw new ArgumentNullException("november is a required property for MonthsOfYearSelector and cannot be null.");

            if (december == null)
                throw new ArgumentNullException("december is a required property for MonthsOfYearSelector and cannot be null.");

#pragma warning restore CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
#pragma warning restore CS8073 // The result of the expression is always the same since a value of this type is never equal to 'null'

            April = april;
            August = august;
            December = december;
            February = february;
            January = january;
            July = july;
            June = june;
            March = march;
            May = may;
            November = november;
            October = october;
            September = september;
        }

        /// <summary>
        /// Gets or Sets April
        /// </summary>
        [JsonPropertyName("April")]
        public bool April { get; set; }

        /// <summary>
        /// Gets or Sets August
        /// </summary>
        [JsonPropertyName("August")]
        public bool August { get; set; }

        /// <summary>
        /// Gets or Sets December
        /// </summary>
        [JsonPropertyName("December")]
        public bool December { get; set; }

        /// <summary>
        /// Gets or Sets February
        /// </summary>
        [JsonPropertyName("February")]
        public bool February { get; set; }

        /// <summary>
        /// Gets or Sets January
        /// </summary>
        [JsonPropertyName("January")]
        public bool January { get; set; }

        /// <summary>
        /// Gets or Sets July
        /// </summary>
        [JsonPropertyName("July")]
        public bool July { get; set; }

        /// <summary>
        /// Gets or Sets June
        /// </summary>
        [JsonPropertyName("June")]
        public bool June { get; set; }

        /// <summary>
        /// Gets or Sets March
        /// </summary>
        [JsonPropertyName("March")]
        public bool March { get; set; }

        /// <summary>
        /// Gets or Sets May
        /// </summary>
        [JsonPropertyName("May")]
        public bool May { get; set; }

        /// <summary>
        /// Gets or Sets November
        /// </summary>
        [JsonPropertyName("November")]
        public bool November { get; set; }

        /// <summary>
        /// Gets or Sets October
        /// </summary>
        [JsonPropertyName("October")]
        public bool October { get; set; }

        /// <summary>
        /// Gets or Sets September
        /// </summary>
        [JsonPropertyName("September")]
        public bool September { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MonthsOfYearSelector {\n");
            sb.Append("  April: ").Append(April).Append("\n");
            sb.Append("  August: ").Append(August).Append("\n");
            sb.Append("  December: ").Append(December).Append("\n");
            sb.Append("  February: ").Append(February).Append("\n");
            sb.Append("  January: ").Append(January).Append("\n");
            sb.Append("  July: ").Append(July).Append("\n");
            sb.Append("  June: ").Append(June).Append("\n");
            sb.Append("  March: ").Append(March).Append("\n");
            sb.Append("  May: ").Append(May).Append("\n");
            sb.Append("  November: ").Append(November).Append("\n");
            sb.Append("  October: ").Append(October).Append("\n");
            sb.Append("  September: ").Append(September).Append("\n");
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
    /// A Json converter for type MonthsOfYearSelector
    /// </summary>
    public class MonthsOfYearSelectorJsonConverter : JsonConverter<MonthsOfYearSelector>
    {
        /// <summary>
        /// A Json reader.
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override MonthsOfYearSelector Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            bool april = default;
            bool august = default;
            bool december = default;
            bool february = default;
            bool january = default;
            bool july = default;
            bool june = default;
            bool march = default;
            bool may = default;
            bool november = default;
            bool october = default;
            bool september = default;

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
                        case "April":
                            april = utf8JsonReader.GetBoolean();
                            break;
                        case "August":
                            august = utf8JsonReader.GetBoolean();
                            break;
                        case "December":
                            december = utf8JsonReader.GetBoolean();
                            break;
                        case "February":
                            february = utf8JsonReader.GetBoolean();
                            break;
                        case "January":
                            january = utf8JsonReader.GetBoolean();
                            break;
                        case "July":
                            july = utf8JsonReader.GetBoolean();
                            break;
                        case "June":
                            june = utf8JsonReader.GetBoolean();
                            break;
                        case "March":
                            march = utf8JsonReader.GetBoolean();
                            break;
                        case "May":
                            may = utf8JsonReader.GetBoolean();
                            break;
                        case "November":
                            november = utf8JsonReader.GetBoolean();
                            break;
                        case "October":
                            october = utf8JsonReader.GetBoolean();
                            break;
                        case "September":
                            september = utf8JsonReader.GetBoolean();
                            break;
                        default:
                            break;
                    }
                }
            }

            return new MonthsOfYearSelector(april, august, december, february, january, july, june, march, may, november, october, september);
        }

        /// <summary>
        /// A Json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="monthsOfYearSelector"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, MonthsOfYearSelector monthsOfYearSelector, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            writer.WriteBoolean("April", monthsOfYearSelector.April);
            writer.WriteBoolean("August", monthsOfYearSelector.August);
            writer.WriteBoolean("December", monthsOfYearSelector.December);
            writer.WriteBoolean("February", monthsOfYearSelector.February);
            writer.WriteBoolean("January", monthsOfYearSelector.January);
            writer.WriteBoolean("July", monthsOfYearSelector.July);
            writer.WriteBoolean("June", monthsOfYearSelector.June);
            writer.WriteBoolean("March", monthsOfYearSelector.March);
            writer.WriteBoolean("May", monthsOfYearSelector.May);
            writer.WriteBoolean("November", monthsOfYearSelector.November);
            writer.WriteBoolean("October", monthsOfYearSelector.October);
            writer.WriteBoolean("September", monthsOfYearSelector.September);

            writer.WriteEndObject();
        }
    }
}
