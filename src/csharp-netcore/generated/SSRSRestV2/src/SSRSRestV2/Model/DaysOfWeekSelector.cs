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
    /// Represents the days of the week on which a scheduled report runs.
    /// </summary>
    public partial class DaysOfWeekSelector : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DaysOfWeekSelector" /> class.
        /// </summary>
        /// <param name="friday">friday</param>
        /// <param name="monday">monday</param>
        /// <param name="saturday">saturday</param>
        /// <param name="sunday">sunday</param>
        /// <param name="thursday">thursday</param>
        /// <param name="tuesday">tuesday</param>
        /// <param name="wednesday">wednesday</param>
        [JsonConstructor]
        public DaysOfWeekSelector(bool friday, bool monday, bool saturday, bool sunday, bool thursday, bool tuesday, bool wednesday)
        {
#pragma warning disable CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
#pragma warning disable CS8073 // The result of the expression is always the same since a value of this type is never equal to 'null'

            if (sunday == null)
                throw new ArgumentNullException("sunday is a required property for DaysOfWeekSelector and cannot be null.");

            if (monday == null)
                throw new ArgumentNullException("monday is a required property for DaysOfWeekSelector and cannot be null.");

            if (tuesday == null)
                throw new ArgumentNullException("tuesday is a required property for DaysOfWeekSelector and cannot be null.");

            if (wednesday == null)
                throw new ArgumentNullException("wednesday is a required property for DaysOfWeekSelector and cannot be null.");

            if (thursday == null)
                throw new ArgumentNullException("thursday is a required property for DaysOfWeekSelector and cannot be null.");

            if (friday == null)
                throw new ArgumentNullException("friday is a required property for DaysOfWeekSelector and cannot be null.");

            if (saturday == null)
                throw new ArgumentNullException("saturday is a required property for DaysOfWeekSelector and cannot be null.");

#pragma warning restore CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
#pragma warning restore CS8073 // The result of the expression is always the same since a value of this type is never equal to 'null'

            Friday = friday;
            Monday = monday;
            Saturday = saturday;
            Sunday = sunday;
            Thursday = thursday;
            Tuesday = tuesday;
            Wednesday = wednesday;
        }

        /// <summary>
        /// Gets or Sets Friday
        /// </summary>
        [JsonPropertyName("Friday")]
        public bool Friday { get; set; }

        /// <summary>
        /// Gets or Sets Monday
        /// </summary>
        [JsonPropertyName("Monday")]
        public bool Monday { get; set; }

        /// <summary>
        /// Gets or Sets Saturday
        /// </summary>
        [JsonPropertyName("Saturday")]
        public bool Saturday { get; set; }

        /// <summary>
        /// Gets or Sets Sunday
        /// </summary>
        [JsonPropertyName("Sunday")]
        public bool Sunday { get; set; }

        /// <summary>
        /// Gets or Sets Thursday
        /// </summary>
        [JsonPropertyName("Thursday")]
        public bool Thursday { get; set; }

        /// <summary>
        /// Gets or Sets Tuesday
        /// </summary>
        [JsonPropertyName("Tuesday")]
        public bool Tuesday { get; set; }

        /// <summary>
        /// Gets or Sets Wednesday
        /// </summary>
        [JsonPropertyName("Wednesday")]
        public bool Wednesday { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DaysOfWeekSelector {\n");
            sb.Append("  Friday: ").Append(Friday).Append("\n");
            sb.Append("  Monday: ").Append(Monday).Append("\n");
            sb.Append("  Saturday: ").Append(Saturday).Append("\n");
            sb.Append("  Sunday: ").Append(Sunday).Append("\n");
            sb.Append("  Thursday: ").Append(Thursday).Append("\n");
            sb.Append("  Tuesday: ").Append(Tuesday).Append("\n");
            sb.Append("  Wednesday: ").Append(Wednesday).Append("\n");
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
    /// A Json converter for type DaysOfWeekSelector
    /// </summary>
    public class DaysOfWeekSelectorJsonConverter : JsonConverter<DaysOfWeekSelector>
    {
        /// <summary>
        /// A Json reader.
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override DaysOfWeekSelector Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            bool friday = default;
            bool monday = default;
            bool saturday = default;
            bool sunday = default;
            bool thursday = default;
            bool tuesday = default;
            bool wednesday = default;

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
                        case "Friday":
                            friday = utf8JsonReader.GetBoolean();
                            break;
                        case "Monday":
                            monday = utf8JsonReader.GetBoolean();
                            break;
                        case "Saturday":
                            saturday = utf8JsonReader.GetBoolean();
                            break;
                        case "Sunday":
                            sunday = utf8JsonReader.GetBoolean();
                            break;
                        case "Thursday":
                            thursday = utf8JsonReader.GetBoolean();
                            break;
                        case "Tuesday":
                            tuesday = utf8JsonReader.GetBoolean();
                            break;
                        case "Wednesday":
                            wednesday = utf8JsonReader.GetBoolean();
                            break;
                        default:
                            break;
                    }
                }
            }

            return new DaysOfWeekSelector(friday, monday, saturday, sunday, thursday, tuesday, wednesday);
        }

        /// <summary>
        /// A Json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="daysOfWeekSelector"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, DaysOfWeekSelector daysOfWeekSelector, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            writer.WriteBoolean("Friday", daysOfWeekSelector.Friday);
            writer.WriteBoolean("Monday", daysOfWeekSelector.Monday);
            writer.WriteBoolean("Saturday", daysOfWeekSelector.Saturday);
            writer.WriteBoolean("Sunday", daysOfWeekSelector.Sunday);
            writer.WriteBoolean("Thursday", daysOfWeekSelector.Thursday);
            writer.WriteBoolean("Tuesday", daysOfWeekSelector.Tuesday);
            writer.WriteBoolean("Wednesday", daysOfWeekSelector.Wednesday);

            writer.WriteEndObject();
        }
    }
}
